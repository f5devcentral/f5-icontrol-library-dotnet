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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.ProfileDNSLoggingBinding", Namespace="urn:iControl")]
	public partial class LocalLBProfileDNSLogging : iControlInterface {
		public LocalLBProfileDNSLogging() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNSLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNSLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileDNSLogging")]
	public void create(
		string [] profile_names,
		string [] publishers
	) {
		this.Invoke("create", new object [] {
				profile_names,
				publishers});

	}
	public System.IAsyncResult Begincreate(string [] profile_names,string [] publishers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			profile_names,
			publishers}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_profiles
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNSLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNSLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileDNSLogging")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNSLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNSLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileDNSLogging")]
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
	// get_complete_answer_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNSLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNSLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileDNSLogging")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_complete_answer_enabled_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_complete_answer_enabled_state", new object [] {
				profile_names});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_complete_answer_enabled_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_complete_answer_enabled_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_complete_answer_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dns_log_publisher
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNSLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNSLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileDNSLogging")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_dns_log_publisher(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_dns_log_publisher", new object [] {
				profile_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_dns_log_publisher(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dns_log_publisher", new object[] {
			profile_names}, callback, asyncState);
	}
	public string [] Endget_dns_log_publisher(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNSLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNSLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileDNSLogging")]
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
	// get_query_id_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNSLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNSLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileDNSLogging")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_query_id_enabled_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_query_id_enabled_state", new object [] {
				profile_names});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_query_id_enabled_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_query_id_enabled_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_query_id_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_query_logging_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNSLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNSLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileDNSLogging")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_query_logging_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_query_logging_state", new object [] {
				profile_names});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_query_logging_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_query_logging_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_query_logging_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_response_logging_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNSLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNSLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileDNSLogging")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_response_logging_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_response_logging_state", new object [] {
				profile_names});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_response_logging_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_response_logging_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_response_logging_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_source_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNSLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNSLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileDNSLogging")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_source_enabled_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_source_enabled_state", new object [] {
				profile_names});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_source_enabled_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_source_enabled_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_source_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_timestamp_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNSLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNSLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileDNSLogging")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_timestamp_enabled_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_timestamp_enabled_state", new object [] {
				profile_names});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_timestamp_enabled_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_timestamp_enabled_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_timestamp_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNSLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNSLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileDNSLogging")]
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
	// get_view_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNSLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNSLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileDNSLogging")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_view_enabled_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_view_enabled_state", new object [] {
				profile_names});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_view_enabled_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_view_enabled_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_view_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// set_complete_answer_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNSLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNSLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileDNSLogging")]
	public void set_complete_answer_enabled_state(
		string [] profile_names,
		CommonEnabledState [] states
	) {
		this.Invoke("set_complete_answer_enabled_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_complete_answer_enabled_state(string [] profile_names,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_complete_answer_enabled_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_complete_answer_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dns_log_publisher
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNSLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNSLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileDNSLogging")]
	public void set_dns_log_publisher(
		string [] profile_names,
		string [] publishers
	) {
		this.Invoke("set_dns_log_publisher", new object [] {
				profile_names,
				publishers});

	}
	public System.IAsyncResult Beginset_dns_log_publisher(string [] profile_names,string [] publishers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dns_log_publisher", new object[] {
			profile_names,
			publishers}, callback, asyncState);
	}
	public void Endset_dns_log_publisher(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_query_id_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNSLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNSLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileDNSLogging")]
	public void set_query_id_enabled_state(
		string [] profile_names,
		CommonEnabledState [] states
	) {
		this.Invoke("set_query_id_enabled_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_query_id_enabled_state(string [] profile_names,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_query_id_enabled_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_query_id_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_query_logging_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNSLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNSLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileDNSLogging")]
	public void set_query_logging_state(
		string [] profile_names,
		CommonEnabledState [] states
	) {
		this.Invoke("set_query_logging_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_query_logging_state(string [] profile_names,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_query_logging_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_query_logging_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_response_logging_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNSLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNSLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileDNSLogging")]
	public void set_response_logging_state(
		string [] profile_names,
		CommonEnabledState [] states
	) {
		this.Invoke("set_response_logging_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_response_logging_state(string [] profile_names,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_response_logging_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_response_logging_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_source_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNSLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNSLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileDNSLogging")]
	public void set_source_enabled_state(
		string [] profile_names,
		CommonEnabledState [] states
	) {
		this.Invoke("set_source_enabled_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_source_enabled_state(string [] profile_names,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_source_enabled_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_source_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_timestamp_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNSLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNSLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileDNSLogging")]
	public void set_timestamp_enabled_state(
		string [] profile_names,
		CommonEnabledState [] states
	) {
		this.Invoke("set_timestamp_enabled_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_timestamp_enabled_state(string [] profile_names,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_timestamp_enabled_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_timestamp_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_view_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileDNSLogging", 
		RequestNamespace="urn:iControl:LocalLB/ProfileDNSLogging", ResponseNamespace="urn:iControl:LocalLB/ProfileDNSLogging")]
	public void set_view_enabled_state(
		string [] profile_names,
		CommonEnabledState [] states
	) {
		this.Invoke("set_view_enabled_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_view_enabled_state(string [] profile_names,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_view_enabled_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_view_enabled_state(System.IAsyncResult asyncResult) {
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
