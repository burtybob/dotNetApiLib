using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

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
                    ro.DateLogged = t1.SelectToken("h_datelogged.@raw").ToObject<DateTime>();

                    JToken _resDateRaw = t1.SelectToken("h_dateresolved.@raw");
                    if (_resDateRaw != null)
                        ro.DateResolved = _resDateRaw.ToObject<DateTime>();

                    ro.DateClosed = t1.SelectToken("h_dateclosed.@raw").ToObject<DateTime>();

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

    }
}