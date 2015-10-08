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
    }
}
