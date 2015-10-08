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
	[System.Web.Services.WebServiceBindingAttribute(Name="Management.EMBinding", Namespace="urn:iControl")]
	public partial class ManagementEM : iControlInterface {
		public ManagementEM() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// delete_devices
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/EM", 
		RequestNamespace="urn:iControl:Management/EM", ResponseNamespace="urn:iControl:Management/EM")]
	public void delete_devices(
		string [] devices
	) {
		this.Invoke("delete_devices", new object [] {
				devices});

	}
	public System.IAsyncResult Begindelete_devices(string [] devices, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_devices", new object[] {
			devices}, callback, asyncState);
	}
	public void Enddelete_devices(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// discover_devices
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/EM", 
		RequestNamespace="urn:iControl:Management/EM", ResponseNamespace="urn:iControl:Management/EM")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string discover_devices(
		string [] addresses,
		string [] usernames,
		string [] passwords
	) {
		object [] results = this.Invoke("discover_devices", new object [] {
				addresses,
				usernames,
				passwords});
		return ((string)(results[0]));
	}
	public System.IAsyncResult Begindiscover_devices(string [] addresses,string [] usernames,string [] passwords, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("discover_devices", new object[] {
			addresses,
			usernames,
			passwords}, callback, asyncState);
	}
	public string Enddiscover_devices(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_context_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/EM", 
		RequestNamespace="urn:iControl:Management/EM", ResponseNamespace="urn:iControl:Management/EM")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string get_context_id(

	) {
		object [] results = this.Invoke("get_context_id", new object [0]);
		return ((string)(results[0]));
	}
	public System.IAsyncResult Beginget_context_id(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_context_id", new object[0], callback, asyncState);
	}
	public string Endget_context_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_device_proxy_configuration
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/EM", 
		RequestNamespace="urn:iControl:Management/EM", ResponseNamespace="urn:iControl:Management/EM")]
	public void get_device_proxy_configuration(
		out string emSslProxyHost,
		out short emSslProxyPort,
		out string deviceSslProxyHost,
		out short deviceSslProxyPort,
		out bool useEmSslProxyForDevice,
		out bool deviceProxyEnabled
	) {
		object [] results = this.Invoke("get_device_proxy_configuration", new object [] {
});
		emSslProxyHost = ((string)(results[0]));
		emSslProxyPort = ((short)(results[1]));
		deviceSslProxyHost = ((string)(results[2]));
		deviceSslProxyPort = ((short)(results[3]));
		useEmSslProxyForDevice = ((bool)(results[4]));
		deviceProxyEnabled = ((bool)(results[5]));

	}
	public System.IAsyncResult Beginget_device_proxy_configuration(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_device_proxy_configuration", new object[] {
}, callback, asyncState);
	}
	public void Endget_device_proxy_configuration(System.IAsyncResult asyncResult,
 out string emSslProxyHost,
 out short emSslProxyPort,
 out string deviceSslProxyHost,
 out short deviceSslProxyPort,
 out bool useEmSslProxyForDevice,
 out bool deviceProxyEnabled) {
		object [] results = this.EndInvoke(asyncResult);
		emSslProxyHost = ((string)(results[0]));
		emSslProxyPort = ((short)(results[1]));
		deviceSslProxyHost = ((string)(results[2]));
		deviceSslProxyPort = ((short)(results[3]));
		useEmSslProxyForDevice = ((bool)(results[4]));
		deviceProxyEnabled = ((bool)(results[5]));
	}

	//-----------------------------------------------------------------------
	// get_device_token
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/EM", 
		RequestNamespace="urn:iControl:Management/EM", ResponseNamespace="urn:iControl:Management/EM")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string get_device_token(
		string ip_address
	) {
		object [] results = this.Invoke("get_device_token", new object [] {
				ip_address});
		return ((string)(results[0]));
	}
	public System.IAsyncResult Beginget_device_token(string ip_address, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_device_token", new object[] {
			ip_address}, callback, asyncState);
	}
	public string Endget_device_token(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_devices
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/EM", 
		RequestNamespace="urn:iControl:Management/EM", ResponseNamespace="urn:iControl:Management/EM")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_devices(

	) {
		object [] results = this.Invoke("get_devices", new object [0]);
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_devices(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_devices", new object[0], callback, asyncState);
	}
	public string [] Endget_devices(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_task_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/EM", 
		RequestNamespace="urn:iControl:Management/EM", ResponseNamespace="urn:iControl:Management/EM")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementEMTaskStatus [] get_task_status(
		string [] ids
	) {
		object [] results = this.Invoke("get_task_status", new object [] {
				ids});
		return ((ManagementEMTaskStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_task_status(string [] ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_task_status", new object[] {
			ids}, callback, asyncState);
	}
	public ManagementEMTaskStatus [] Endget_task_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementEMTaskStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// sendRequest
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/EM", 
		RequestNamespace="urn:iControl:Management/EM", ResponseNamespace="urn:iControl:Management/EM")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string sendRequest(
		string daemon,
		string request
	) {
		object [] results = this.Invoke("sendRequest", new object [] {
				daemon,
				request});
		return ((string)(results[0]));
	}
	public System.IAsyncResult BeginsendRequest(string daemon,string request, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("sendRequest", new object[] {
			daemon,
			request}, callback, asyncState);
	}
	public string EndsendRequest(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string)(results[0]));
	}

	//-----------------------------------------------------------------------
	// set_device_context
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/EM", 
		RequestNamespace="urn:iControl:Management/EM", ResponseNamespace="urn:iControl:Management/EM")]
	public void set_device_context(
		string ip_address
	) {
		this.Invoke("set_device_context", new object [] {
				ip_address});

	}
	public System.IAsyncResult Beginset_device_context(string ip_address, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_device_context", new object[] {
			ip_address}, callback, asyncState);
	}
	public void Endset_device_context(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.EM.TaskStatus", Namespace = "urn:iControl")]
	public enum ManagementEMTaskStatus
	{
		TASK_STATUS_UNKNOWN,
		TASK_STATUS_PENDING,
		TASK_STATUS_STARTED,
		TASK_STATUS_FAILED,
		TASK_STATUS_COMPLETE,
		TASK_STATUS_RUNNING,
		TASK_STATUS_CANCELING,
		TASK_STATUS_CANCELED,
		TASK_STATUS_ABANDONED,
		TASK_STATUS_TERMINATED,
		TASK_STATUS_TIMED_OUT,
		TASK_STATUS_RESCHEDULED,
	}

	//=======================================================================
	// Structs
	//=======================================================================

}
