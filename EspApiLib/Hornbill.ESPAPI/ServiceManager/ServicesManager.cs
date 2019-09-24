using System;

namespace Hornbill.ESPAPI.ServiceManager
{
    public class ServicesManager
    {
        private HornbillService _service;

        public ServicesManager(HornbillService service)
        {
            if (service == null)
                throw new ArgumentNullException("service");

            _service = service;
        }

        /// <summary>
        /// Gets all services set up in Hornbill
        /// </summary>
        private void GetServices()
        {
            _service.HornbillClient.Invoke("apps/com.hornbill.servicemanager/Services", "selfserviceGetServices");
        }

    }
}
