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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.ProfileRequestLoggingBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileEnabledState))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileString))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileRequestLoggingProfileProtocol))]
	public partial class LocalLBProfileRequestLogging : iControlInterface {
		public LocalLBProfileRequestLogging() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	public void create(
		string [] profile_names
	) {
		this.Invoke("create", new object [] {
				profile_names});

	}
	public System.IAsyncResult Begincreate(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_profiles
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	public void delete_all_profiles(

	) {
		this.Invoke("delete_all_profiles", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_profiles(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_profiles", new object[0], callback, asyncState);
	}
	public void Enddelete_all_profiles(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	public void delete_profile(
		string [] profile_names
	) {
		this.Invoke("delete_profile", new object [] {
				profile_names});

	}
	public System.IAsyncResult Begindelete_profile(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_profile", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Enddelete_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_default_profile(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_default_profile", new object [] {
				profile_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_default_profile(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_default_profile", new object[] {
			profile_names}, callback, asyncState);
	}
	public string [] Endget_default_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_description", new object [] {
				profile_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			profile_names}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
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
	// get_proxy_close_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_proxy_close_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_proxy_close_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_proxy_close_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_proxy_close_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_proxy_close_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_proxy_response
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_proxy_response(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_proxy_response", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_proxy_response(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_proxy_response", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_proxy_response(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_proxy_response_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_proxy_response_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_proxy_response_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_proxy_response_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_proxy_response_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_proxy_response_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_request_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_request_pool(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_request_pool", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_request_pool(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_request_pool", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_request_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_request_protocol
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileRequestLoggingProfileProtocol [] get_request_protocol(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_request_protocol", new object [] {
				profile_names});
		return ((LocalLBProfileRequestLoggingProfileProtocol [])(results[0]));
	}
	public System.IAsyncResult Beginget_request_protocol(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_request_protocol", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileRequestLoggingProfileProtocol [] Endget_request_protocol(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileRequestLoggingProfileProtocol [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_request_secondary_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_request_secondary_pool(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_request_secondary_pool", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_request_secondary_pool(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_request_secondary_pool", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_request_secondary_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_request_secondary_protocol
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileRequestLoggingProfileProtocol [] get_request_secondary_protocol(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_request_secondary_protocol", new object [] {
				profile_names});
		return ((LocalLBProfileRequestLoggingProfileProtocol [])(results[0]));
	}
	public System.IAsyncResult Beginget_request_secondary_protocol(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_request_secondary_protocol", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileRequestLoggingProfileProtocol [] Endget_request_secondary_protocol(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileRequestLoggingProfileProtocol [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_request_secondary_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_request_secondary_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_request_secondary_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_request_secondary_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_request_secondary_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_request_secondary_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_request_secondary_template
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_request_secondary_template(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_request_secondary_template", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_request_secondary_template(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_request_secondary_template", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_request_secondary_template(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_request_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_request_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_request_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_request_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_request_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_request_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_request_template
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_request_template(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_request_template", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_request_template(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_request_template", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_request_template(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_response_log_by_default_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_response_log_by_default_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_response_log_by_default_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_response_log_by_default_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_response_log_by_default_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_response_log_by_default_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_response_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_response_pool(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_response_pool", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_response_pool(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_response_pool", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_response_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_response_protocol
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileRequestLoggingProfileProtocol [] get_response_protocol(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_response_protocol", new object [] {
				profile_names});
		return ((LocalLBProfileRequestLoggingProfileProtocol [])(results[0]));
	}
	public System.IAsyncResult Beginget_response_protocol(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_response_protocol", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileRequestLoggingProfileProtocol [] Endget_response_protocol(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileRequestLoggingProfileProtocol [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_response_secondary_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_response_secondary_pool(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_response_secondary_pool", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_response_secondary_pool(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_response_secondary_pool", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_response_secondary_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_response_secondary_protocol
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileRequestLoggingProfileProtocol [] get_response_secondary_protocol(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_response_secondary_protocol", new object [] {
				profile_names});
		return ((LocalLBProfileRequestLoggingProfileProtocol [])(results[0]));
	}
	public System.IAsyncResult Beginget_response_secondary_protocol(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_response_secondary_protocol", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileRequestLoggingProfileProtocol [] Endget_response_secondary_protocol(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileRequestLoggingProfileProtocol [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_response_secondary_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_response_secondary_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_response_secondary_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_response_secondary_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_response_secondary_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_response_secondary_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_response_secondary_template
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_response_secondary_template(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_response_secondary_template", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_response_secondary_template(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_response_secondary_template", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_response_secondary_template(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_response_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_response_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_response_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_response_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_response_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_response_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_response_template
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_response_template(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_response_template", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_response_template(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_response_template", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_response_template(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
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
	// is_base_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] is_base_profile(
		string [] profile_names
	) {
		object [] results = this.Invoke("is_base_profile", new object [] {
				profile_names});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginis_base_profile(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("is_base_profile", new object[] {
			profile_names}, callback, asyncState);
	}
	public bool [] Endis_base_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// is_system_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] is_system_profile(
		string [] profile_names
	) {
		object [] results = this.Invoke("is_system_profile", new object [] {
				profile_names});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginis_system_profile(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("is_system_profile", new object[] {
			profile_names}, callback, asyncState);
	}
	public bool [] Endis_system_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// set_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	public void set_default_profile(
		string [] profile_names,
		string [] defaults
	) {
		this.Invoke("set_default_profile", new object [] {
				profile_names,
				defaults});

	}
	public System.IAsyncResult Beginset_default_profile(string [] profile_names,string [] defaults, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_profile", new object[] {
			profile_names,
			defaults}, callback, asyncState);
	}
	public void Endset_default_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	public void set_description(
		string [] profile_names,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				profile_names,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] profile_names,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			profile_names,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_proxy_close_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	public void set_proxy_close_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_proxy_close_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_proxy_close_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_proxy_close_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_proxy_close_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_proxy_response
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	public void set_proxy_response(
		string [] profile_names,
		LocalLBProfileString [] responses
	) {
		this.Invoke("set_proxy_response", new object [] {
				profile_names,
				responses});

	}
	public System.IAsyncResult Beginset_proxy_response(string [] profile_names,LocalLBProfileString [] responses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_proxy_response", new object[] {
			profile_names,
			responses}, callback, asyncState);
	}
	public void Endset_proxy_response(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_proxy_response_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	public void set_proxy_response_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_proxy_response_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_proxy_response_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_proxy_response_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_proxy_response_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_request_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	public void set_request_pool(
		string [] profile_names,
		LocalLBProfileString [] pools
	) {
		this.Invoke("set_request_pool", new object [] {
				profile_names,
				pools});

	}
	public System.IAsyncResult Beginset_request_pool(string [] profile_names,LocalLBProfileString [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_request_pool", new object[] {
			profile_names,
			pools}, callback, asyncState);
	}
	public void Endset_request_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_request_protocol
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	public void set_request_protocol(
		string [] profile_names,
		LocalLBProfileRequestLoggingProfileProtocol [] protocols
	) {
		this.Invoke("set_request_protocol", new object [] {
				profile_names,
				protocols});

	}
	public System.IAsyncResult Beginset_request_protocol(string [] profile_names,LocalLBProfileRequestLoggingProfileProtocol [] protocols, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_request_protocol", new object[] {
			profile_names,
			protocols}, callback, asyncState);
	}
	public void Endset_request_protocol(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_request_secondary_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	public void set_request_secondary_pool(
		string [] profile_names,
		LocalLBProfileString [] pools
	) {
		this.Invoke("set_request_secondary_pool", new object [] {
				profile_names,
				pools});

	}
	public System.IAsyncResult Beginset_request_secondary_pool(string [] profile_names,LocalLBProfileString [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_request_secondary_pool", new object[] {
			profile_names,
			pools}, callback, asyncState);
	}
	public void Endset_request_secondary_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_request_secondary_protocol
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	public void set_request_secondary_protocol(
		string [] profile_names,
		LocalLBProfileRequestLoggingProfileProtocol [] protocols
	) {
		this.Invoke("set_request_secondary_protocol", new object [] {
				profile_names,
				protocols});

	}
	public System.IAsyncResult Beginset_request_secondary_protocol(string [] profile_names,LocalLBProfileRequestLoggingProfileProtocol [] protocols, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_request_secondary_protocol", new object[] {
			profile_names,
			protocols}, callback, asyncState);
	}
	public void Endset_request_secondary_protocol(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_request_secondary_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	public void set_request_secondary_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_request_secondary_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_request_secondary_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_request_secondary_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_request_secondary_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_request_secondary_template
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	public void set_request_secondary_template(
		string [] profile_names,
		LocalLBProfileString [] templates
	) {
		this.Invoke("set_request_secondary_template", new object [] {
				profile_names,
				templates});

	}
	public System.IAsyncResult Beginset_request_secondary_template(string [] profile_names,LocalLBProfileString [] templates, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_request_secondary_template", new object[] {
			profile_names,
			templates}, callback, asyncState);
	}
	public void Endset_request_secondary_template(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_request_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	public void set_request_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_request_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_request_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_request_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_request_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_request_template
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	public void set_request_template(
		string [] profile_names,
		LocalLBProfileString [] templates
	) {
		this.Invoke("set_request_template", new object [] {
				profile_names,
				templates});

	}
	public System.IAsyncResult Beginset_request_template(string [] profile_names,LocalLBProfileString [] templates, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_request_template", new object[] {
			profile_names,
			templates}, callback, asyncState);
	}
	public void Endset_request_template(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_response_log_by_default_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	public void set_response_log_by_default_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_response_log_by_default_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_response_log_by_default_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_response_log_by_default_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_response_log_by_default_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_response_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	public void set_response_pool(
		string [] profile_names,
		LocalLBProfileString [] pools
	) {
		this.Invoke("set_response_pool", new object [] {
				profile_names,
				pools});

	}
	public System.IAsyncResult Beginset_response_pool(string [] profile_names,LocalLBProfileString [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_response_pool", new object[] {
			profile_names,
			pools}, callback, asyncState);
	}
	public void Endset_response_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_response_protocol
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	public void set_response_protocol(
		string [] profile_names,
		LocalLBProfileRequestLoggingProfileProtocol [] protocols
	) {
		this.Invoke("set_response_protocol", new object [] {
				profile_names,
				protocols});

	}
	public System.IAsyncResult Beginset_response_protocol(string [] profile_names,LocalLBProfileRequestLoggingProfileProtocol [] protocols, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_response_protocol", new object[] {
			profile_names,
			protocols}, callback, asyncState);
	}
	public void Endset_response_protocol(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_response_secondary_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	public void set_response_secondary_pool(
		string [] profile_names,
		LocalLBProfileString [] pools
	) {
		this.Invoke("set_response_secondary_pool", new object [] {
				profile_names,
				pools});

	}
	public System.IAsyncResult Beginset_response_secondary_pool(string [] profile_names,LocalLBProfileString [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_response_secondary_pool", new object[] {
			profile_names,
			pools}, callback, asyncState);
	}
	public void Endset_response_secondary_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_response_secondary_protocol
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	public void set_response_secondary_protocol(
		string [] profile_names,
		LocalLBProfileRequestLoggingProfileProtocol [] protocols
	) {
		this.Invoke("set_response_secondary_protocol", new object [] {
				profile_names,
				protocols});

	}
	public System.IAsyncResult Beginset_response_secondary_protocol(string [] profile_names,LocalLBProfileRequestLoggingProfileProtocol [] protocols, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_response_secondary_protocol", new object[] {
			profile_names,
			protocols}, callback, asyncState);
	}
	public void Endset_response_secondary_protocol(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_response_secondary_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	public void set_response_secondary_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_response_secondary_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_response_secondary_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_response_secondary_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_response_secondary_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_response_secondary_template
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	public void set_response_secondary_template(
		string [] profile_names,
		LocalLBProfileString [] templates
	) {
		this.Invoke("set_response_secondary_template", new object [] {
				profile_names,
				templates});

	}
	public System.IAsyncResult Beginset_response_secondary_template(string [] profile_names,LocalLBProfileString [] templates, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_response_secondary_template", new object[] {
			profile_names,
			templates}, callback, asyncState);
	}
	public void Endset_response_secondary_template(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_response_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	public void set_response_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_response_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_response_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_response_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_response_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_response_template
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileRequestLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileRequestLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileRequestLogging")]
	public void set_response_template(
		string [] profile_names,
		LocalLBProfileString [] templates
	) {
		this.Invoke("set_response_template", new object [] {
				profile_names,
				templates});

	}
	public System.IAsyncResult Beginset_response_template(string [] profile_names,LocalLBProfileString [] templates, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_response_template", new object[] {
			profile_names,
			templates}, callback, asyncState);
	}
	public void Endset_response_template(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileRequestLogging.Protocol", Namespace = "urn:iControl")]
	public enum LocalLBProfileRequestLoggingProtocol
	{
		PROTOCOL_UNKNOWN,
		PROTOCOL_TCP,
		PROTOCOL_UDP,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileRequestLogging.ProfileProtocol", Namespace = "urn:iControl")]
	public partial class LocalLBProfileRequestLoggingProfileProtocol
	{
		private LocalLBProfileRequestLoggingProtocol valueField;
		public LocalLBProfileRequestLoggingProtocol value
		{
			get { return this.valueField; }
			set { this.valueField = value; }
		}
		private bool default_flagField;
		public bool default_flag
		{
			get { return this.default_flagField; }
			set { this.default_flagField = value; }
		}
	};

}
