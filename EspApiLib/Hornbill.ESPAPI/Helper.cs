using System.Xml;

namespace Hornbill.ESPAPI
{
    public class Helper
    {
        public static XmlNodeList GetParamsNode(string pXML)
        {
            XmlDocument xd = new XmlDocument();
            xd.LoadXml(pXML);
            return xd.GetElementsByTagName("params");
        }
    }
}
