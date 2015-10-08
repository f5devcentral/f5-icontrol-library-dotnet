//===========================================================================
//
// File         : ConnectionInfo.cs
//                   
//---------------------------------------------------------------------------
//
// The contents of this file are subject to the "END USER LICENSE AGREEMENT FOR F5
// Software Development Kit for iControl"; you may not use this file except in
// compliance with the License. The License is included in the iControl
// Software Development Kit.
//
// Software distributed under the License is distributed on an "AS IS"
// basis, WITHOUT WARRANTY OF ANY KIND, either express or implied. See
// the License for the specific language governing rights and limitations
// under the License.
//
// The Original Code is iControl Code and related documentation
// distributed by F5.
//
// The Initial Developer of the Original Code is F5 Networks, Inc.
// Seattle, WA, USA.
// Portions created by F5 are Copyright (C) 2006 F5 Networks, Inc.
// All Rights Reserved.
// iControl (TM) is a registered trademark of F5 Networks, Inc.
//
// Alternatively, the contents of this file may be used under the terms
// of the GNU General Public License (the "GPL"), in which case the
// provisions of GPL are applicable instead of those above.  If you wish
// to allow use of your version of this file only under the terms of the
// GPL and not to allow others to use your version of this file under the
// License, indicate your decision by deleting the provisions above and
// replace them with the notice and other provisions required by the GPL.
// If you do not delete the provisions above, a recipient may use your
// version of this file under either the License or the GPL.
//
//===========================================================================

using System;

namespace iControl
{
	/// <summary>
	/// Summary description for ConnectionInfo.
	/// </summary>
	public class ConnectionInfo
	{
        //-------------------------------------------------------------------
        // member variables
        //-------------------------------------------------------------------
		private String CONFIG_KEY = "Software\\F5 Networks\\iRuler";
		private String ACCOUNTS_KEY = "Software\\F5 Networks\\iRuler\\Accounts";
        
        
        private String m_hostname = "";
        private long m_port = -1;
        private String m_endpoint = "";
        private String m_username = "";
        private String m_password = "";
		public String m_hostType;
		public Boolean m_bGTMLicensed = false;
		private System.Net.NetworkCredential m_creds = new System.Net.NetworkCredential();
		private System.Net.WebProxy m_proxy = null;

        //-------------------------------------------------------------------
        // Constructor
        //-------------------------------------------------------------------

        public ConnectionInfo()
		{
		}

        //-------------------------------------------------------------------
        // public accessors
        //-------------------------------------------------------------------
        public String hostname
        {
            get { return m_hostname; }
            set { m_hostname = value; }
        }
        public long port
        {
            get { return m_port; }
            set { m_port = value; }
        }
        public String endpoint
        {
            get { return m_endpoint; }
            set { m_endpoint = value; }
        }
        public String username
        {
            get { return m_username; }
            set { m_username = value; }
        }
        public String password
        {
            get { return m_password; }
            set { m_password = value; }
        }

        public System.Net.NetworkCredential creds
        {
            get { return m_creds; }
        }

        public void setEndpoint(String hostname, long port, String endpoint)
		{
			m_hostname = hostname;
			m_port = port;
			m_endpoint = endpoint;
		}
		public void setCredentials(string username, string password)
		{
			m_creds.UserName = username;
			m_creds.Password = password;
            m_username = username;
            m_password = password;
        }

		public void setHostType(string hosttype)
		{
			m_hostType = hosttype;
		}

		public void setGTMLicensed(bool bLicensed)
		{
			// HACK, really set the value when we are ready to release GTM support.
			m_bGTMLicensed = bLicensed;
		}
		public bool getGTMLicensed()
		{
			return m_bGTMLicensed;
		}

		//-------------------------------------------------------------------
        // public methods
        //-------------------------------------------------------------------
        public String buildURL()
        {
            String sURL;
            sURL = "http";
            if (443 == m_port)
            {
                sURL = sURL + "s";
            }
            sURL = sURL + "://" + m_hostname + ":" + m_port.ToString() + m_endpoint;
            return sURL;
        }
		public String buildURLwToken(string em_ipaddress, string token)
		{
			String sURL;
			sURL = "http";
			if (443 == m_port)
			{
				sURL = sURL + "s";
			}

			sURL = sURL + "://" + m_hostname + ":" + m_port.ToString() + m_endpoint + "?em_server_ip=" + em_ipaddress + "&em_server_auth_token=" + Uri.EscapeUriString(token);
			return sURL;
		}

		public void clear()
        {
            m_hostname = "";
            m_port = -1;
            m_endpoint = "";
            m_username = "";
            m_password = "";
			m_proxy = null;
        }
        public Boolean isValid()
		{
			Boolean bValid = false;
			if ( (0 != m_hostname.Length) && (m_port > 0) &&
				(0 != m_endpoint.Length) &&
				(0 != m_username.Length) && (0 != m_password.Length) )
			{
				bValid = false;
			}
			return bValid;
		}


		public void loadFromRegistry()
		{
			loadFromRegistry("");
		}
		public void loadFromRegistry(String sRequestedHostname)
		{
			migrateOldSettings();
			Microsoft.Win32.RegistryKey cu = Microsoft.Win32.Registry.CurrentUser;
			String accountKey = CONFIG_KEY;

			if (sRequestedHostname.Length > 0)
			{
				accountKey = ACCOUNTS_KEY + "\\" + sRequestedHostname;
			}

			Microsoft.Win32.RegistryKey f5Key = cu.OpenSubKey(accountKey);
			if (null != f5Key)
			{
				Object obj = null;
				if (null != (obj = f5Key.GetValue("Hostname")))
				{
					m_hostname = Convert.ToString(obj);
				}
				if (null != (obj = f5Key.GetValue("Port")))
				{
					m_port = Convert.ToInt32(obj);
				}
				if (null != (obj = f5Key.GetValue("Username")))
				{
					m_username = Convert.ToString(obj);
				}
				if (null != (obj = f5Key.GetValue("UseProxy")))
				{
					if (null != (obj = f5Key.GetValue("ProxyHost")))
					{
						String address = Convert.ToString(obj);
						int port = 8080;

						if (null != (obj = f5Key.GetValue("ProxyPort")))
						{
							port = Convert.ToInt32(obj);
						}
						m_proxy = new System.Net.WebProxy(address, port);

						if (null != (obj = f5Key.GetValue("ProxyUser")))
						{
							m_proxy.Credentials = new System.Net.NetworkCredential();
							((System.Net.NetworkCredential)m_proxy.Credentials).UserName = Convert.ToString(obj);
						}
						else
						{
							m_proxy.UseDefaultCredentials = true;
						}
					}
				}
				else
				{
					m_proxy = null;
				}
				f5Key.Close();
			}
		}
		public void saveToRegistry()
		{
			Microsoft.Win32.RegistryKey cu = Microsoft.Win32.Registry.CurrentUser;
			Microsoft.Win32.RegistryKey f5Key = cu.CreateSubKey(CONFIG_KEY);
			if (null != f5Key)
			{
				f5Key.SetValue("Hostname", m_hostname);
				f5Key.SetValue("Port", m_port);
				f5Key.SetValue("Username", m_username);
				if (null != m_proxy)
				{
					f5Key.SetValue("UseProxy", true);
					f5Key.SetValue("ProxyHost", m_proxy.Address.Host);
					f5Key.SetValue("ProxyPort", m_proxy.Address.Port.ToString());
					if (null != m_proxy.Credentials)
					{
						f5Key.SetValue("ProxyUser", ((System.Net.NetworkCredential)m_proxy.Credentials).UserName);
					}
				}
			}
			f5Key.Close();
		}
		public void saveToRegistry(String m_hostname)
		{
			Microsoft.Win32.RegistryKey cu = Microsoft.Win32.Registry.CurrentUser;
			Microsoft.Win32.RegistryKey f5Key = cu.CreateSubKey(ACCOUNTS_KEY + "\\" + m_hostname);
			if (null != f5Key)
			{
				f5Key.SetValue("Hostname", m_hostname);
				f5Key.SetValue("Port", m_port);
				f5Key.SetValue("Username", m_username);
				if (null != m_proxy)
				{
					f5Key.SetValue("UseProxy", true);
					f5Key.SetValue("ProxyHost", m_proxy.Address.Host);
					f5Key.SetValue("ProxyPort", m_proxy.Address.Port.ToString());
					if (null != m_proxy.Credentials)
					{
						f5Key.SetValue("ProxyUser", ((System.Net.NetworkCredential)m_proxy.Credentials).UserName);
					}
				}
			}
			f5Key.Close();

			setLastAccount(m_hostname);
		}

		public String[] getAccounts()
		{
			String[] name_list = null;
			Microsoft.Win32.RegistryKey cu = Microsoft.Win32.Registry.CurrentUser;
			Microsoft.Win32.RegistryKey accountsKey = cu.CreateSubKey(ACCOUNTS_KEY);
			if (null != accountsKey)
			{
				name_list = accountsKey.GetSubKeyNames();
			}
			accountsKey.Close();
			return name_list;
		}
		public void clearAccounts()
		{
			Microsoft.Win32.Registry.CurrentUser.DeleteSubKey(ACCOUNTS_KEY);
		}
		public String getLastAccount()
		{
			string sLastAccount = "";
			Microsoft.Win32.RegistryKey cu = Microsoft.Win32.Registry.CurrentUser;
			Microsoft.Win32.RegistryKey f5Key = cu.OpenSubKey(CONFIG_KEY);
			if (null != f5Key)
			{
				Object obj = null;
				if (null != (obj = f5Key.GetValue("LastAccount")))
				{
					sLastAccount = Convert.ToString(obj);
				}
				f5Key.Close();
			}
			return sLastAccount;
		}
		public void setLastAccount(String m_hostname)
		{
			Microsoft.Win32.RegistryKey cu = Microsoft.Win32.Registry.CurrentUser;
			Microsoft.Win32.RegistryKey f5Key = cu.CreateSubKey(CONFIG_KEY);
			if (null != f5Key)
			{
				f5Key.SetValue("LastAccount", m_hostname);
			}
			f5Key.Close();
		}
		public void setWebProxy(System.Net.WebProxy proxy)
		{
			m_proxy = proxy;
		}
		public void setWebProxy(String host, int port, String proxyUser, String proxyPass)
		{
			System.Net.WebProxy proxy = new System.Net.WebProxy(host, port);
			if ((proxyUser.Length > 0) && (proxyPass.Length > 0))
			{
				proxy.Credentials = new System.Net.NetworkCredential();
				((System.Net.NetworkCredential)proxy.Credentials).UserName = proxyUser;
				((System.Net.NetworkCredential)proxy.Credentials).Password = proxyPass;
			}
			else
			{
				proxy.UseDefaultCredentials = true;
			}
			setWebProxy(proxy);
		}
		public System.Net.WebProxy getWebProxy()
		{
			return m_proxy;
		}

		public void migrateOldSettings()
		{
			Microsoft.Win32.RegistryKey cu = Microsoft.Win32.Registry.CurrentUser;
			Microsoft.Win32.RegistryKey f5Key = cu.CreateSubKey(CONFIG_KEY);
			if (null != f5Key)
			{
				Object obj = null;
				if (null != (obj = f5Key.GetValue("Hostname")))
				{
					m_hostname = Convert.ToString(obj);
					f5Key.DeleteValue("Hostname");

					Microsoft.Win32.RegistryKey accountKey = f5Key.CreateSubKey("Accounts\\" + m_hostname);
					if (null != accountKey)
					{
						accountKey.SetValue("Hostname", m_hostname);

						// Create account and delete keys
						if (null != (obj = f5Key.GetValue("Port")))
						{
							m_port = Convert.ToInt32(obj);
							accountKey.SetValue("Port", m_port);
							f5Key.DeleteValue("Port");

						}
						if (null != (obj = f5Key.GetValue("Username")))
						{
							m_username = Convert.ToString(obj);
							accountKey.SetValue("Username", m_username);
							f5Key.DeleteValue("Username");
						}
						accountKey.Close();
					}
				}
				f5Key.Close();
			}
		}
	
	}
}
