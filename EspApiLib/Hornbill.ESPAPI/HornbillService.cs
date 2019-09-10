using System;

namespace Hornbill.ESPAPI
{
    public class HornbillService
    {
        /// <summary>
        /// Hornbill XmlmcService instance for direct calls
        /// </summary>
        public XmlmcService HornbillClient { get; set; }

        /// <summary>
        /// Creates a HornbillService object.
        /// </summary>
        /// <param name="instanceOrURL">The instance name or the server URL.</param>
        /// <param name="webDavEntryPoint">Tthe WebDav entry point.</param>
        /// <param name="apiKey">The API key.</param>
        public HornbillService(string instanceOrURL, string webDavEntryPoint = "")
        {
            HornbillClient = new XmlmcService(instanceOrURL, "xmlmc", webDavEntryPoint, string.Empty);
        }

        /// <summary>
        /// Authenticate against the hornbill server using the specified username/password
        /// </summary>
        /// <param name="username">The username to login with</param>
        /// <param name="password">The password to login with</param>
        /// <returns>The users session id</returns>
        public string Authenticate(string username, string password)
        {
            if (string.IsNullOrEmpty(username))            
                throw new ArgumentNullException("username");
            
            if (string.IsNullOrEmpty(password))
                throw new ArgumentNullException("password");

            HornbillClient.AddParam("userId", username);
            HornbillClient.AddParam("password", password).EncodeValue(XmlmcEncoding.Base64);
            HornbillClient.Invoke("session", "userLogon");

            return HornbillClient.GetResponseParamAsString("sessionId");
        }

        /// <summary>
        /// Authenticate against the hornbill server using an APIKey
        /// </summary>
        /// <param name="apiKey">The APIKey to use</param>
        public void Authenticate(string apiKey)
        {
            if (string.IsNullOrWhiteSpace(apiKey))
                throw new ArgumentNullException("apiKey");

            HornbillClient.APIKey = apiKey;
        }

    }
}