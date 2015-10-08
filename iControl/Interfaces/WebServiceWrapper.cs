using System;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace iControl
{
  public class SystemSystemInfoEx : iControl.SystemSystemInfo
  {
    private Dictionary<string, string> m_headers = new Dictionary<string, string>();
    //private string m_headerName = null;
    //private string m_headerValue = null;

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
      //if (null != HeaderName)
      //{
      //  req.Headers.Add(this.HeaderName, this.HeaderValue);
      //}
      return (WebRequest)req;
    }

    //public string HeaderName { get { return m_headerName; } set { m_headerName = value; } }
    //public string HeaderValue { get { return m_headerValue; } set { m_headerValue = value; } }

    public void AddHeader(string name, string value)
    {
      m_headers.Add(name, value);
      //HeaderName = name;
      //HeaderValue = value;
    }
  }
}
