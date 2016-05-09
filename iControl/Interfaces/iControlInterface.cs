using System;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace iControl
{
    public class iControlInterface : System.Web.Services.Protocols.SoapHttpClientProtocol
    {
        // Private Members
        private Dictionary<string, string> m_headers = new Dictionary<string, string>();
        private iControl.Interfaces m_interfaces = null;
        private bool m_ForceSOAP12 = false;

        // Public Accessors

        public iControl.Interfaces interfaces { get { return m_interfaces; } set { m_interfaces = value; } }

        // Overrides

        protected override System.Net.WebRequest GetWebRequest(Uri uri)
        {
            HttpWebRequest req = (HttpWebRequest)base.GetWebRequest(uri);
            if (m_headers.Count > 0)
            {
                foreach (KeyValuePair<string, string> kvp in m_headers)
                {
                    req.Headers.Add(kvp.Key, kvp.Value);
                }
            }

            if (null != m_interfaces)
            {
                if (m_interfaces.SessionIdentifier > 0)
                {
                    req.Headers.Add("X-iControl-Session", m_interfaces.SessionIdentifier.ToString());
                }
            }
            return (WebRequest)req;
        }

        protected override System.Net.WebResponse GetWebResponse(WebRequest request)
        {
            System.Net.WebResponse resp = base.GetWebResponse(request);
            return resp;
        }

        protected override System.Xml.XmlReader GetReaderForMessage(System.Web.Services.Protocols.SoapClientMessage message, int bufferSize)
        {
            System.Xml.XmlReader reader = base.GetReaderForMessage(message, bufferSize);

            if (m_ForceSOAP12)
            {
                StringBuilder sb = new StringBuilder();
                while(reader.Read())
                {
                    sb.AppendLine(reader.ReadOuterXml());
                }
                /**/
                String content = sb.ToString();
                content = content.Replace(@"http://schemas.xmlsoap.org/soap/envelope/", @"http://www.w3.org/2003/05/soap-envelope");
                content = content.Replace(@"http://schemas.xmlsoap.org/soap/encoding/", @"http://www.w3.org/2003/05/soap-encoding");
                /**/
                //String content = sb.ToString();
                //System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
                //doc.Load(reader);
                //string content = doc.InnerXml.ToString();
                //content = content
                 //   .Replace(@"http://schemas.xmlsoap.org/soap/envelope/", @"http://www.w3.org/2003/05/soap-envelope")
                 //   .Replace(@"http://schemas.xmlsoap.org/soap/encoding/", @"http://www.w3.org/2003/05/soap-encoding");
                System.Xml.XmlReader reader2 = System.Xml.XmlReader.Create(new System.IO.StringReader(content));
                return reader2;
            }
            else
            {
                return reader;
            }
        }

        protected override System.Xml.XmlWriter GetWriterForMessage(System.Web.Services.Protocols.SoapClientMessage message, int bufferSize)
        {
            System.Xml.XmlWriter writer = base.GetWriterForMessage(message, bufferSize);
            return writer;
        }

        // Public Methods

        public void AddHttpHeader(string name, string value)
        {
            m_headers.Add(name, value);
        }

        public void RemoveHttpHeader(string name)
        {
            try
            {
                m_headers.Remove(name);
            }
            catch (Exception) { }
        }

        public void ClearHttpHeaders()
        {
            m_headers.Clear();
        }

        public void ForceSoap12(bool value)
        {
            m_ForceSOAP12 = value;
        }
    }
}
