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
	[System.Web.Services.WebServiceBindingAttribute(Name="System.InetBinding", Namespace="urn:iControl")]
	public partial class SystemInet : iControlInterface {
		public SystemInet() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// get_dns_server_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Inet", 
		RequestNamespace="urn:iControl:System/Inet", ResponseNamespace="urn:iControl:System/Inet")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_dns_server_address(

	) {
		object [] results = this.Invoke("get_dns_server_address", new object [0]);
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_dns_server_address(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dns_server_address", new object[0], callback, asyncState);
	}
	public string [] Endget_dns_server_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_hostname
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Inet", 
		RequestNamespace="urn:iControl:System/Inet", ResponseNamespace="urn:iControl:System/Inet")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string get_hostname(

	) {
		object [] results = this.Invoke("get_hostname", new object [0]);
		return ((string)(results[0]));
	}
	public System.IAsyncResult Beginget_hostname(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_hostname", new object[0], callback, asyncState);
	}
	public string Endget_hostname(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ntp_server_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Inet", 
		RequestNamespace="urn:iControl:System/Inet", ResponseNamespace="urn:iControl:System/Inet")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_ntp_server_address(

	) {
		object [] results = this.Invoke("get_ntp_server_address", new object [0]);
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_ntp_server_address(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ntp_server_address", new object[0], callback, asyncState);
	}
	public string [] Endget_ntp_server_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Inet", 
		RequestNamespace="urn:iControl:System/Inet", ResponseNamespace="urn:iControl:System/Inet")]
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
	// hostname_to_ip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Inet", 
		RequestNamespace="urn:iControl:System/Inet", ResponseNamespace="urn:iControl:System/Inet")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] hostname_to_ip(
		string [] hostnames
	) {
		object [] results = this.Invoke("hostname_to_ip", new object [] {
				hostnames});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginhostname_to_ip(string [] hostnames, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("hostname_to_ip", new object[] {
			hostnames}, callback, asyncState);
	}
	public string [] Endhostname_to_ip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// ip_to_hostname
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Inet", 
		RequestNamespace="urn:iControl:System/Inet", ResponseNamespace="urn:iControl:System/Inet")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] ip_to_hostname(
		string [] ip_addresses
	) {
		object [] results = this.Invoke("ip_to_hostname", new object [] {
				ip_addresses});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginip_to_hostname(string [] ip_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("ip_to_hostname", new object[] {
			ip_addresses}, callback, asyncState);
	}
	public string [] Endip_to_hostname(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// service_name_to_service_number
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Inet", 
		RequestNamespace="urn:iControl:System/Inet", ResponseNamespace="urn:iControl:System/Inet")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] service_name_to_service_number(
		string [] service_names
	) {
		object [] results = this.Invoke("service_name_to_service_number", new object [] {
				service_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginservice_name_to_service_number(string [] service_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("service_name_to_service_number", new object[] {
			service_names}, callback, asyncState);
	}
	public long [] Endservice_name_to_service_number(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// service_number_to_service_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Inet", 
		RequestNamespace="urn:iControl:System/Inet", ResponseNamespace="urn:iControl:System/Inet")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] service_number_to_service_name(
		long [] services
	) {
		object [] results = this.Invoke("service_number_to_service_name", new object [] {
				services});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginservice_number_to_service_name(long [] services, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("service_number_to_service_name", new object[] {
			services}, callback, asyncState);
	}
	public string [] Endservice_number_to_service_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// set_hostname
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Inet", 
		RequestNamespace="urn:iControl:System/Inet", ResponseNamespace="urn:iControl:System/Inet")]
	public void set_hostname(
		string hostname
	) {
		this.Invoke("set_hostname", new object [] {
				hostname});

	}
	public System.IAsyncResult Beginset_hostname(string hostname, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_hostname", new object[] {
			hostname}, callback, asyncState);
	}
	public void Endset_hostname(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ntp_server_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Inet", 
		RequestNamespace="urn:iControl:System/Inet", ResponseNamespace="urn:iControl:System/Inet")]
	public void set_ntp_server_address(
		string [] ntp_addresses
	) {
		this.Invoke("set_ntp_server_address", new object [] {
				ntp_addresses});

	}
	public System.IAsyncResult Beginset_ntp_server_address(string [] ntp_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ntp_server_address", new object[] {
			ntp_addresses}, callback, asyncState);
	}
	public void Endset_ntp_server_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	//=======================================================================
	// Structs
	//=======================================================================

}
