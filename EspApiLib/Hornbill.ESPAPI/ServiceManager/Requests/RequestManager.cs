using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace Hornbill.ESPAPI.ServiceManager.Requests
{
    public class RequestManager
    {
        private HornbillService _service;

        public RequestManager(HornbillService service)
        {
            if (service == null)
                throw new ArgumentNullException("service");

            _service = service;
        }

        /// <summary>
        /// Gets all requests closed in the last maxDays days
        /// </summary>
        /// <param name="maxDays">Maximum number of days to look back</param>
        /// <returns></returns>
        public List<RequestObject> GetClosedRequests(int maxDays = 180)
        {
            int total = 0;
            int limit = 1000;
            int totalCount = -1;
            List<RequestObject> _rtnCol = new List<RequestObject>();

            while (totalCount > total || totalCount == -1)
            {
                //_service.HornbillClient.AddParam("closedAfter", "2019-01-01");
                _service.HornbillClient.AddParam("closedLastXDays", maxDays);
                _service.HornbillClient.AddParam("rowstart", total);
                _service.HornbillClient.AddParam("limit", limit);
                _service.HornbillClient.Invoke("apps/com.hornbill.servicemanager/Requests", "smGetRequests");
                var res1 = Helper.GetParamsNode(_service.HornbillClient.GetResponseXML());
                totalCount = int.Parse(res1[0].SelectNodes("count")[0].InnerText);

                var r4 = JsonConvert.DeserializeObject<JObject>(res1[0].SelectSingleNode("requests").InnerText).SelectToken("row");
                var r5 = r4.ToObject<List<RequestObject>>();

                // Process each request
                foreach (RequestObject ro in r5)
                {
                    JToken t1 = r4.FirstOrDefault(f => f.First.First.ToObject<string>() == ro.RequestID);
                    ro.DateLogged = t1.SelectToken("h_datelogged").ToObject<DateTime>();

                    JToken _resDateRaw = t1.SelectToken("h_dateresolved");
                    if (_resDateRaw != null)
                        ro.DateResolved = _resDateRaw.ToObject<DateTime>();

                    ro.DateClosed = t1.SelectToken("h_dateclosed").ToObject<DateTime>();

                    _rtnCol.Add(ro);
                }

                total += limit;
            }

            return _rtnCol;
        }

        /// <summary>
        /// Retrieves a single request specified by requestId
        /// </summary>
        /// <param name="requestId">The identifier of the request to retrieve</param>
        /// <returns>The details of the request</returns>
        public RequestObject GetRequest(string requestId)
        {
            _service.HornbillClient.AddParam("requestNumberEquals", requestId);
            _service.HornbillClient.AddParam("rowstart", 0);
            _service.HornbillClient.AddParam("limit", 1);
            _service.HornbillClient.Invoke("apps/com.hornbill.servicemanager/Requests", "smGetRequests");
            var res1 = Helper.GetParamsNode(_service.HornbillClient.GetResponseXML());

            if (res1 == null || res1.Count == 0)
                return null;

            var r4 = JsonConvert.DeserializeObject<JObject>(res1[0].SelectSingleNode("requests").InnerText).SelectToken("row");

            return r4.ToObject<RequestObject>();
        }

        /// <summary>
        /// Retrieves a single requests details specified by requestId
        /// </summary>
        /// <param name="requestId">The identifier of the request to retrieve</param>
        /// <returns>The details of the request</returns>
        public RequestObject GetRequestTimeline(string requestId)
        {
            // First we need to get the activity stream access token from smGetReqDetails
            _service.HornbillClient.AddParam("requestId", requestId);
            _service.HornbillClient.Invoke("apps/com.hornbill.servicemanager/Requests", "smGetReqDetails");
            var res1 = Helper.GetParamsNode(_service.HornbillClient.GetResponseXML());

            if (res1 == null || res1.Count == 0)
                return null;
            
            IEnumerable<XmlNode> _childNodes = res1[0].ChildNodes.Cast<XmlNode>();

            var r4 = JsonConvert.DeserializeObject<JObject>(_childNodes.Where(f => f.Name == "requestDetails").FirstOrDefault()?.InnerText);

            string accessToken = _childNodes.Where(f => f.Name == "requestActivityStreamAccessToken").FirstOrDefault()?.InnerText;
            string activityStreamId = r4.SelectToken("h_activity_stream_id").ToObject<string>();

            // Now we can call to get the activity stream details.
            _service.HornbillClient.AddParam("activityStreamID", activityStreamId);
            _service.HornbillClient.AddParam("accessToken", accessToken);
            _service.HornbillClient.Invoke("activity", "activityStreamQuery");
            res1 = Helper.GetParamsNode(_service.HornbillClient.GetResponseXML());

            if (res1 == null || res1.Count == 0)
                return null;
            var _activities = res1[0].ChildNodes.Cast<XmlNode>().Where(f => f.Name == "activity");
            foreach (var _activity in _activities)
            {
                Activity _a = new Activity();
                // Do something
                _childNodes = _activity.ChildNodes.Cast<XmlNode>();
                _a.ID = _childNodes.FirstOrDefault(f => f.Name == "id")?.InnerText;
                _a.Published = DateTime.Parse(_childNodes.FirstOrDefault(f => f.Name == "published")?.InnerText);
                _a.Content = _childNodes.FirstOrDefault(f => f.Name == "content")?.InnerText;
                _a.Likes = int.Parse(_childNodes.FirstOrDefault(f => f.Name == "likes")?.InnerText);
                _a.Title = _childNodes.FirstOrDefault(f => f.Name == "title")?.InnerText;
            }

            // Convert timeline to something useful
            var r5 = JsonConvert.DeserializeObject<JObject>(res1[0].SelectSingleNode("requests").InnerText).SelectToken("row");
            
            return r4.ToObject<RequestObject>();
        }



        /// <summary>
        /// Gets all open requests
        /// </summary>
        /// <returns></returns>
        public List<RequestObject> GetOpenRequests()
        {
            int total = 0;
            int limit = 1000;
            int totalCount = -1;
            List<RequestObject> _rtnCol = new List<RequestObject>();

            while (totalCount > total || totalCount == -1)
            {
                //_service.HornbillClient.AddParam("closedAfter", "2019-01-01");
                _service.HornbillClient.AddParam("statusNotEquals", "status.closed");
                //_service.HornbillClient.AddParam("closedLastXDays", maxDays);
                _service.HornbillClient.AddParam("rowstart", total);
                _service.HornbillClient.AddParam("limit", limit);
                _service.HornbillClient.Invoke("apps/com.hornbill.servicemanager/Requests", "smGetRequests");
                var res1 = Helper.GetParamsNode(_service.HornbillClient.GetResponseXML());
                totalCount = int.Parse(res1[0].SelectNodes("count")[0].InnerText);

                var r4 = JsonConvert.DeserializeObject<JObject>(res1[0].SelectSingleNode("requests").InnerText).SelectToken("row");
                var r5 = r4.ToObject<List<RequestObject>>();

                // Process each request
                foreach (RequestObject ro in r5)
                {
                    JToken t1 = r4.FirstOrDefault(f => f.First.First.ToObject<string>() == ro.RequestID);
                    ro.DateLogged = t1.SelectToken("h_datelogged").ToObject<DateTime>();

                    JToken _resDateRaw = t1.SelectToken("h_dateresolved");
                    if (_resDateRaw != null)
                        ro.DateResolved = _resDateRaw.ToObject<DateTime>();
                    
                    _rtnCol.Add(ro);
                }

                total += limit;
            }

            return _rtnCol;
        }

    }
}