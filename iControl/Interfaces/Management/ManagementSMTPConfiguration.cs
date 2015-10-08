namespace iControl {
	using System.Xml.Serialization;
	using System.Web.Services;
	using System.ComponentModel;
	using System.Web.Services.Protocols;
	using System;
	using System.Diagnostics;

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Web.Services.WebServiceBindingAttribute(Name="Management.SMTPConfigurationBinding", Namespace="urn:iControl")]
	public partial class ManagementSMTPConfiguration : iControlInterface {
		public ManagementSMTPConfiguration() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SMTPConfiguration", 
		RequestNamespace="urn:iControl:Management/SMTPConfiguration", ResponseNamespace="urn:iControl:Management/SMTPConfiguration")]
	public void create(
		string [] configs
	) {
		this.Invoke("create", new object [] {
				configs});

	}
	public System.IAsyncResult Begincreate(string [] configs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			configs}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_smtp_configs
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SMTPConfiguration", 
		RequestNamespace="urn:iControl:Management/SMTPConfiguration", ResponseNamespace="urn:iControl:Management/SMTPConfiguration")]
	public void delete_all_smtp_configs(

	) {
		this.Invoke("delete_all_smtp_configs", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_smtp_configs(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_smtp_configs", new object[0], callback, asyncState);
	}
	public void Enddelete_all_smtp_configs(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_smtp_config
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SMTPConfiguration", 
		RequestNamespace="urn:iControl:Management/SMTPConfiguration", ResponseNamespace="urn:iControl:Management/SMTPConfiguration")]
	public void delete_smtp_config(
		string [] configs
	) {
		this.Invoke("delete_smtp_config", new object [] {
				configs});

	}
	public System.IAsyncResult Begindelete_smtp_config(string [] configs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_smtp_config", new object[] {
			configs}, callback, asyncState);
	}
	public void Enddelete_smtp_config(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_auth_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SMTPConfiguration", 
		RequestNamespace="urn:iControl:Management/SMTPConfiguration", ResponseNamespace="urn:iControl:Management/SMTPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_auth_enabled_state(
		string [] configs
	) {
		object [] results = this.Invoke("get_auth_enabled_state", new object [] {
				configs});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_auth_enabled_state(string [] configs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_auth_enabled_state", new object[] {
			configs}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_auth_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_encrypted_connection_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SMTPConfiguration", 
		RequestNamespace="urn:iControl:Management/SMTPConfiguration", ResponseNamespace="urn:iControl:Management/SMTPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementSMTPConfigurationEncryptedConnectionType [] get_encrypted_connection_type(
		string [] configs
	) {
		object [] results = this.Invoke("get_encrypted_connection_type", new object [] {
				configs});
		return ((ManagementSMTPConfigurationEncryptedConnectionType [])(results[0]));
	}
	public System.IAsyncResult Beginget_encrypted_connection_type(string [] configs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_encrypted_connection_type", new object[] {
			configs}, callback, asyncState);
	}
	public ManagementSMTPConfigurationEncryptedConnectionType [] Endget_encrypted_connection_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementSMTPConfigurationEncryptedConnectionType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_from_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SMTPConfiguration", 
		RequestNamespace="urn:iControl:Management/SMTPConfiguration", ResponseNamespace="urn:iControl:Management/SMTPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_from_address(
		string [] configs
	) {
		object [] results = this.Invoke("get_from_address", new object [] {
				configs});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_from_address(string [] configs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_from_address", new object[] {
			configs}, callback, asyncState);
	}
	public string [] Endget_from_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SMTPConfiguration", 
		RequestNamespace="urn:iControl:Management/SMTPConfiguration", ResponseNamespace="urn:iControl:Management/SMTPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_list(

	) {
		object [] results = this.Invoke("get_list", new object [0]);
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_list", new object[0], callback, asyncState);
	}
	public string [] Endget_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_local_host_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SMTPConfiguration", 
		RequestNamespace="urn:iControl:Management/SMTPConfiguration", ResponseNamespace="urn:iControl:Management/SMTPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_local_host_name(
		string [] configs
	) {
		object [] results = this.Invoke("get_local_host_name", new object [] {
				configs});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_local_host_name(string [] configs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_local_host_name", new object[] {
			configs}, callback, asyncState);
	}
	public string [] Endget_local_host_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_password
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SMTPConfiguration", 
		RequestNamespace="urn:iControl:Management/SMTPConfiguration", ResponseNamespace="urn:iControl:Management/SMTPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_password(
		string [] configs
	) {
		object [] results = this.Invoke("get_password", new object [] {
				configs});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_password(string [] configs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_password", new object[] {
			configs}, callback, asyncState);
	}
	public string [] Endget_password(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_smtp_server_host_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SMTPConfiguration", 
		RequestNamespace="urn:iControl:Management/SMTPConfiguration", ResponseNamespace="urn:iControl:Management/SMTPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_smtp_server_host_name(
		string [] configs
	) {
		object [] results = this.Invoke("get_smtp_server_host_name", new object [] {
				configs});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_smtp_server_host_name(string [] configs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_smtp_server_host_name", new object[] {
			configs}, callback, asyncState);
	}
	public string [] Endget_smtp_server_host_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_smtp_server_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SMTPConfiguration", 
		RequestNamespace="urn:iControl:Management/SMTPConfiguration", ResponseNamespace="urn:iControl:Management/SMTPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_smtp_server_port(
		string [] configs
	) {
		object [] results = this.Invoke("get_smtp_server_port", new object [] {
				configs});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_smtp_server_port(string [] configs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_smtp_server_port", new object[] {
			configs}, callback, asyncState);
	}
	public long [] Endget_smtp_server_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_user_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SMTPConfiguration", 
		RequestNamespace="urn:iControl:Management/SMTPConfiguration", ResponseNamespace="urn:iControl:Management/SMTPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_user_name(
		string [] configs
	) {
		object [] results = this.Invoke("get_user_name", new object [] {
				configs});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_user_name(string [] configs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_user_name", new object[] {
			configs}, callback, asyncState);
	}
	public string [] Endget_user_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SMTPConfiguration", 
		RequestNamespace="urn:iControl:Management/SMTPConfiguration", ResponseNamespace="urn:iControl:Management/SMTPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string get_version(

	) {
		object [] results = this.Invoke("get_version", new object [] {
});
		return ((string)(results[0]));
	}
	public System.IAsyncResult Beginget_version(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_version", new object[] {
}, callback, asyncState);
	}
	public string Endget_version(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string)(results[0]));
	}

	//-----------------------------------------------------------------------
	// set_auth_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SMTPConfiguration", 
		RequestNamespace="urn:iControl:Management/SMTPConfiguration", ResponseNamespace="urn:iControl:Management/SMTPConfiguration")]
	public void set_auth_enabled_state(
		string [] configs,
		CommonEnabledState [] states
	) {
		this.Invoke("set_auth_enabled_state", new object [] {
				configs,
				states});

	}
	public System.IAsyncResult Beginset_auth_enabled_state(string [] configs,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_auth_enabled_state", new object[] {
			configs,
			states}, callback, asyncState);
	}
	public void Endset_auth_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_encrypted_connection_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SMTPConfiguration", 
		RequestNamespace="urn:iControl:Management/SMTPConfiguration", ResponseNamespace="urn:iControl:Management/SMTPConfiguration")]
	public void set_encrypted_connection_type(
		string [] configs,
		ManagementSMTPConfigurationEncryptedConnectionType [] encryption_types
	) {
		this.Invoke("set_encrypted_connection_type", new object [] {
				configs,
				encryption_types});

	}
	public System.IAsyncResult Beginset_encrypted_connection_type(string [] configs,ManagementSMTPConfigurationEncryptedConnectionType [] encryption_types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_encrypted_connection_type", new object[] {
			configs,
			encryption_types}, callback, asyncState);
	}
	public void Endset_encrypted_connection_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_from_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SMTPConfiguration", 
		RequestNamespace="urn:iControl:Management/SMTPConfiguration", ResponseNamespace="urn:iControl:Management/SMTPConfiguration")]
	public void set_from_address(
		string [] configs,
		string [] addresses
	) {
		this.Invoke("set_from_address", new object [] {
				configs,
				addresses});

	}
	public System.IAsyncResult Beginset_from_address(string [] configs,string [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_from_address", new object[] {
			configs,
			addresses}, callback, asyncState);
	}
	public void Endset_from_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_local_host_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SMTPConfiguration", 
		RequestNamespace="urn:iControl:Management/SMTPConfiguration", ResponseNamespace="urn:iControl:Management/SMTPConfiguration")]
	public void set_local_host_name(
		string [] configs,
		string [] values
	) {
		this.Invoke("set_local_host_name", new object [] {
				configs,
				values});

	}
	public System.IAsyncResult Beginset_local_host_name(string [] configs,string [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_local_host_name", new object[] {
			configs,
			values}, callback, asyncState);
	}
	public void Endset_local_host_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_password
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SMTPConfiguration", 
		RequestNamespace="urn:iControl:Management/SMTPConfiguration", ResponseNamespace="urn:iControl:Management/SMTPConfiguration")]
	public void set_password(
		string [] configs,
		string [] passwords
	) {
		this.Invoke("set_password", new object [] {
				configs,
				passwords});

	}
	public System.IAsyncResult Beginset_password(string [] configs,string [] passwords, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_password", new object[] {
			configs,
			passwords}, callback, asyncState);
	}
	public void Endset_password(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_smtp_server_host_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SMTPConfiguration", 
		RequestNamespace="urn:iControl:Management/SMTPConfiguration", ResponseNamespace="urn:iControl:Management/SMTPConfiguration")]
	public void set_smtp_server_host_name(
		string [] configs,
		string [] values
	) {
		this.Invoke("set_smtp_server_host_name", new object [] {
				configs,
				values});

	}
	public System.IAsyncResult Beginset_smtp_server_host_name(string [] configs,string [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_smtp_server_host_name", new object[] {
			configs,
			values}, callback, asyncState);
	}
	public void Endset_smtp_server_host_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_smtp_server_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SMTPConfiguration", 
		RequestNamespace="urn:iControl:Management/SMTPConfiguration", ResponseNamespace="urn:iControl:Management/SMTPConfiguration")]
	public void set_smtp_server_port(
		string [] configs,
		long [] ports
	) {
		this.Invoke("set_smtp_server_port", new object [] {
				configs,
				ports});

	}
	public System.IAsyncResult Beginset_smtp_server_port(string [] configs,long [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_smtp_server_port", new object[] {
			configs,
			ports}, callback, asyncState);
	}
	public void Endset_smtp_server_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_user_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SMTPConfiguration", 
		RequestNamespace="urn:iControl:Management/SMTPConfiguration", ResponseNamespace="urn:iControl:Management/SMTPConfiguration")]
	public void set_user_name(
		string [] configs,
		string [] values
	) {
		this.Invoke("set_user_name", new object [] {
				configs,
				values});

	}
	public System.IAsyncResult Beginset_user_name(string [] configs,string [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_user_name", new object[] {
			configs,
			values}, callback, asyncState);
	}
	public void Endset_user_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.SMTPConfiguration.EncryptedConnectionType", Namespace = "urn:iControl")]
	public enum ManagementSMTPConfigurationEncryptedConnectionType
	{
		SMTP_ENCRYPTED_CONNECTION_TYPE_UNKNOWN,
		SMTP_ENCRYPTED_CONNECTION_TYPE_NONE,
		SMTP_ENCRYPTED_CONNECTION_TYPE_TLS,
		SMTP_ENCRYPTED_CONNECTION_TYPE_SSL,
	}

	//=======================================================================
	// Structs
	//=======================================================================

}
