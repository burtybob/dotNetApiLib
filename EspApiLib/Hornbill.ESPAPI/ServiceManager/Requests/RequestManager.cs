using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

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
        /// Gets all requests in the last maxDays days
        /// </summary>
        /// <param name="maxDays">Maximum number of days to look back</param>
        /// <returns></returns>
        public List<RequestObject> GetRequests(int maxDays = 180)
        {
            int total = 0;
            int limit = 1000;
            int totalCount = -1;
            List<RequestObject> _rtnCol = new List<RequestObject>();

            while (totalCount > total || totalCount == -1)
            {
                _service.HornbillClient.AddParam("closedAfter", "2019-01-01");
                _service.HornbillClient.AddParam("closedLastXDays", maxDays);
                _service.HornbillClient.AddParam("rowstart", total);
                _service.HornbillClient.AddParam("limit", limit);
                _service.HornbillClient.Invoke("apps/com.hornbill.servicemanager/Requests", "smGetRequests");
                var res1 = Helper.GetParamsNode(_service.HornbillClient.GetResponseXML());
                totalCount = int.Parse(res1[0].SelectNodes("count")[0].InnerText);

                var r4 = JsonConvert.DeserializeObject<JObject>(res1[0].SelectSingleNode("requests").InnerText).SelectToken("row");
                _rtnCol.AddRange(r4.ToObject<List<RequestObject>>());

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