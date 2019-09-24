using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Hornbill.ESPAPI.ServiceManager.Assets
{
    public class AssetManager
    {
        private HornbillService _service;

        public AssetManager(HornbillService service)
        {
            if (service == null)
                throw new ArgumentNullException("service");

            _service = service;
        }

        /// <summary>
        /// Retrieves a list of all Assets in the Hornbill database
        /// </summary>
        /// <returns>A list of Items with a name and ID</returns>
        public List<Item> GetAssetList()
        {
            _service.HornbillClient.AddParam("application", "com.hornbill.servicemanager");
            _service.HornbillClient.AddParam("entity", "asset");
            _service.HornbillClient.Invoke("data", "entityGetNameList");

            var res = _service.HornbillClient.GetResponseXML();
            XmlSerializer serializer = new XmlSerializer(typeof(methodCallResult));

            using (StringReader sr = new StringReader(res))
            {
                methodCallResult cars = (methodCallResult)serializer.Deserialize(sr);
                List<Item> items = new List<Item>();
                items.AddRange(cars.Items);
                return items;
            }
        }

        /// <summary>
        /// Retrieves the details for the specified asset
        /// </summary>
        /// <param name="assetId">The ID of the asset to retrieve</param>
        /// <returns>An asset detail response</returns>
        public Rootobject GetAssetDetails(int assetId)
        {
            _service.HornbillClient.AddParam("assetId", assetId);
            _service.HornbillClient.AddParam("language", "english");
            _service.HornbillClient.Invoke("apps/com.hornbill.servicemanager/Asset", "loadAssetData");

            var t = Helper.GetParamsNode(_service.HornbillClient.GetResponseXML());

            if (t != null && t.Count > 0)
            {
                string j = t[0].InnerText;
                return JsonConvert.DeserializeObject<Rootobject>(j);
            }

            return null;
        }

        public object GetAssetLinkedEntities(int assetId)
        {
            _service.HornbillClient.AddParam("assetId", assetId);
            _service.HornbillClient.AddParam("language", "english");
            _service.HornbillClient.Invoke("apps/com.hornbill.servicemanager/Asset", "loadLinkedEntities");
            var t = Helper.GetParamsNode(_service.HornbillClient.GetResponseXML());

            if (t != null && t.Count > 0)
            {
                string json = t[0].InnerText;
                return JsonConvert.DeserializeObject(json);
            }

            return null;
        }

    }
}
