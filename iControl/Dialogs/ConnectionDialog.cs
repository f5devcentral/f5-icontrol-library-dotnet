//===========================================================================
//
// File         : ConnectionDialog.cs
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
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using iControl.Utility;

namespace iControl.Dialogs
{
	/// <summary>
	/// Summary description for ConnectionInfo.
	/// </summary>
	public partial class ConnectionDialog : System.Windows.Forms.Form
	{
        public int centerX;
        public int centerY;
        public iControl.Interfaces m_interfaces = null;
        private static iControl.ConnectionInfo m_ci = new iControl.ConnectionInfo();

        //public ConnectionInfo ci;

        public System.Net.NetworkCredential Credentials
        {
            get { return m_ci.creds; }
        }

		public iControl.ConnectionInfo ConnectionInfo
		{
			get { return m_ci; }
			set { m_ci = value; }
		}

		public ConnectionDialog()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		private void ConnectionDialog_Load(object sender, System.EventArgs e)
		{
			int newX = centerX - (this.Width/2);
			int newY = centerY - (this.Height/2);
			//this.SetDesktopLocation(newX, newY);
			m_ci.clear();

            this.Show();

            // load up the child keys
            HostnameComboBox.Items.AddRange(m_ci.getAccounts());

            fillupForm(m_ci.getLastAccount());
		}

        private void fillupForm(String sHostname)
        {
            HostnameComboBox.Text = sHostname;
            UsernameTextBox.Text = "";
            //PortTextBox.Text = "";
            PasswordTextBox.Text = "";

            m_ci.loadFromRegistry(sHostname);
            HostnameComboBox.Focus();
            if (m_ci.hostname.Length > 0)
            {
                HostnameComboBox.Text = m_ci.hostname;
                UsernameTextBox.Focus();
            }
            if (-1 != m_ci.port)
            {
                PortTextBox.Text = m_ci.port.ToString();
            }
            if (m_ci.username.Length > 0)
            {
                UsernameTextBox.Text = m_ci.username;
                PasswordTextBox.Focus();
            }
			System.Net.WebProxy proxy = m_ci.getWebProxy();
			if (null != proxy)
			{
				UseProxyCheckBox.Checked = true;
				ProxyAddressTextBox.Text = proxy.Address.Host;
				ProxyPortTextBox.Text = Convert.ToString(proxy.Address.Port);
				if (null != proxy.Credentials)
				{
					ProxyUserTextBox.Text = ((System.Net.NetworkCredential)proxy.Credentials).UserName;
				}
			}
			else
			{
				UseProxyCheckBox.Checked = false;
				ProxyAddressTextBox.Text = "";
				ProxyPortTextBox.Text = "";
				ProxyUserTextBox.Text = "";
				ProxyPassTextBox.Text = "";
			}
        }

        private void OKLinkLabel_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
            if (0 == HostnameComboBox.Text.Length)
            {
                MessageBox.Show("Please enter a hostname.", "Missing information");
                HostnameComboBox.Focus();
            }
            else if (0 == PortTextBox.Text.Length)
            {
                MessageBox.Show("Please enter a port.", "Missing information");
                PortTextBox.Text = "443";
                PortTextBox.Focus();
            }
            else if (0 == EndpointTextBox.Text.Length)
            {
                MessageBox.Show("Please enter a endpoint (default of /iControl/iControlPortal.cgi).", "Missing information");
                EndpointTextBox.Text = "/iControl/iControlPortal.cgi";
                EndpointTextBox.Focus();
            }
            else if (0 == UsernameTextBox.Text.Length)
            {
                MessageBox.Show("Please enter a username.", "Missing information");
                UsernameTextBox.Focus();
            }
            else if (0 == PasswordTextBox.Text.Length)
            {
                MessageBox.Show("Please enter a password.", "Missing information");
                PasswordTextBox.Focus();
            }
			else if (UseProxyCheckBox.Checked && (ProxyAddressTextBox.Text.Length == 0))
			{
				MessageBox.Show("If you are using a proxy server, please specify the address");
				ProxyAddressTextBox.Focus();
			}
			else if (UseProxyCheckBox.Checked && (ProxyPortTextBox.Text.Length == 0))
			{
				MessageBox.Show("If you are using a proxy server, please specify the port");
				ProxyPortTextBox.Focus();
			}
			else
			{
				bool bInitialized = false;
				Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;

				m_ci.setEndpoint(HostnameComboBox.Text, Convert.ToInt32(PortTextBox.Text), EndpointTextBox.Text);
				m_ci.setCredentials(UsernameTextBox.Text, PasswordTextBox.Text);

				// Now verify if we can connect to the host
				if (null == m_interfaces)
				{
					m_interfaces = new iControl.Interfaces();
				}

				if (UseProxyCheckBox.Checked)
				{
					bInitialized = m_interfaces.initialize(HostnameComboBox.Text, Convert.ToUInt32(PortTextBox.Text), UsernameTextBox.Text, PasswordTextBox.Text, ProxyAddressTextBox.Text, Convert.ToInt32(ProxyPortTextBox.Text), ProxyUserTextBox.Text, ProxyPassTextBox.Text);
				}
				else
				{
					bInitialized = m_interfaces.initialize(HostnameComboBox.Text, Convert.ToUInt32(PortTextBox.Text), UsernameTextBox.Text, PasswordTextBox.Text);
				}

				if (bInitialized)
				{
					try
					{
						//sysInfo.Url = m_ci.buildURL();
						iControl.SystemProductInformation prodInfo = m_interfaces.SystemSystemInfo.get_product_information();
						if (null != prodInfo.product_code)
						{
							m_ci.setHostType(prodInfo.product_code);
						}

						// Check for GTM Support
						bool bGTMLicensed = false;
						for (int i = 0; i < prodInfo.product_features.Length; i++)
						{
							if (prodInfo.product_features[i].Equals("GTM Rules"))
							{
								bGTMLicensed = true;
								break;
							}
						}
						m_ci.setGTMLicensed(bGTMLicensed);

						//sysInfo.Dispose();
						Cursor.Current = System.Windows.Forms.Cursors.Default;
						this.DialogResult = DialogResult.OK;

						// Update proxy info in connection info class
						if (UseProxyCheckBox.Checked)
						{
							m_ci.setWebProxy(ProxyAddressTextBox.Text, Convert.ToInt32(ProxyPortTextBox.Text),
								ProxyUserTextBox.Text, ProxyPortTextBox.Text);
						}

						if (SaveConfigCheckBox.Checked)
						{
							m_ci.saveToRegistry(HostnameComboBox.Text);
						}

						if (UseProxyCheckBox.Checked)
						{
							m_ci.setWebProxy(ProxyAddressTextBox.Text, Convert.ToInt32(ProxyPortTextBox.Text), ProxyUserTextBox.Text, ProxyPassTextBox.Text);
						}

						this.DialogResult = DialogResult.OK;
						this.Close();
					}
					catch (System.Net.WebException)
					{
						MessageBox.Show(this, "Connection could not be established to specified host", "Error");
					}
					catch (System.UriFormatException)
					{
						MessageBox.Show(this, "Connection could not be established to specified host", "Error");
					}
				}
				else
				{
					MessageBox.Show(this, "Invalid Connection Information...", "Error");
				}

				//sysInfo.Dispose();
				Cursor.Current = System.Windows.Forms.Cursors.Default;
			}
        }
    	private void CancelLinkLabel_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
        private void ConnectionDialog_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            Configuration.LaunchProcess(Configuration.getWebHelpURL() + "#ConnectionDialog");
        }

        private void HostnameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillupForm(HostnameComboBox.Text);
        }

        private void ClearLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            m_ci.clearAccounts();
            HostnameComboBox.Items.Clear();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

		private void UseProxyCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			ProxyAddressTextBox.Enabled = UseProxyCheckBox.Checked;
			ProxyPortTextBox.Enabled = UseProxyCheckBox.Checked;
			ProxyUserTextBox.Enabled = UseProxyCheckBox.Checked;
			ProxyPassTextBox.Enabled = UseProxyCheckBox.Checked;
		}

	}
}
