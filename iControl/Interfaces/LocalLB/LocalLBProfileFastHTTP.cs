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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.ProfileFastHttpBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileFastHttpProfileFastHttpStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileULong))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileEnabledState))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileString))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileProfileMode))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileStatisticsByVirtual))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileUncleanShutdownMode))]
	public partial class LocalLBProfileFastHttp : iControlInterface {
		public LocalLBProfileFastHttp() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
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
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileFastHttpProfileFastHttpStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((LocalLBProfileFastHttpProfileFastHttpStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public LocalLBProfileFastHttpProfileFastHttpStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileFastHttpProfileFastHttpStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_client_close_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_client_close_timeout(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_client_close_timeout", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_client_close_timeout(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_client_close_timeout", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_client_close_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_connection_pool_idle_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_connection_pool_idle_timeout(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_connection_pool_idle_timeout", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_connection_pool_idle_timeout(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_connection_pool_idle_timeout", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_connection_pool_idle_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_connection_pool_maximum_reuse
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_connection_pool_maximum_reuse(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_connection_pool_maximum_reuse", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_connection_pool_maximum_reuse(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_connection_pool_maximum_reuse", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_connection_pool_maximum_reuse(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_connection_pool_maximum_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_connection_pool_maximum_size(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_connection_pool_maximum_size", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_connection_pool_maximum_size(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_connection_pool_maximum_size", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_connection_pool_maximum_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_connection_pool_minimum_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_connection_pool_minimum_size(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_connection_pool_minimum_size", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_connection_pool_minimum_size(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_connection_pool_minimum_size", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_connection_pool_minimum_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_connection_pool_ramp_increment
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_connection_pool_ramp_increment(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_connection_pool_ramp_increment", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_connection_pool_ramp_increment(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_connection_pool_ramp_increment", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_connection_pool_ramp_increment(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_connection_pool_replenish_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_connection_pool_replenish_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_connection_pool_replenish_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_connection_pool_replenish_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_connection_pool_replenish_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_connection_pool_replenish_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
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
	// get_force_http10_response_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_force_http10_response_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_force_http10_response_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_force_http10_response_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_force_http10_response_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_force_http10_response_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_header_insert
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_header_insert(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_header_insert", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_header_insert(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_header_insert", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_header_insert(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_http11_close_workarounds_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_http11_close_workarounds_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_http11_close_workarounds_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_http11_close_workarounds_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_http11_close_workarounds_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_http11_close_workarounds_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_idle_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_idle_timeout(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_idle_timeout", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_idle_timeout(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_idle_timeout", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_idle_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_insert_xforwarded_for_header_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileProfileMode [] get_insert_xforwarded_for_header_mode(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_insert_xforwarded_for_header_mode", new object [] {
				profile_names});
		return ((LocalLBProfileProfileMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_insert_xforwarded_for_header_mode(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_insert_xforwarded_for_header_mode", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileProfileMode [] Endget_insert_xforwarded_for_header_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileProfileMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_layer7_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_layer7_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_layer7_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_layer7_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_layer7_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_layer7_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
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
	// get_maximum_header_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_maximum_header_size(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_maximum_header_size", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_header_size(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_header_size", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_maximum_header_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_maximum_requests
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_maximum_requests(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_maximum_requests", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_requests(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_requests", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_maximum_requests(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_mss_override
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_mss_override(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_mss_override", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_mss_override(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_mss_override", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_mss_override(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_reset_on_timeout_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_reset_on_timeout_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_reset_on_timeout_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_reset_on_timeout_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_reset_on_timeout_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_reset_on_timeout_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_server_close_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_server_close_timeout(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_server_close_timeout", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_server_close_timeout(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_server_close_timeout", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_server_close_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileFastHttpProfileFastHttpStatistics get_statistics(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				profile_names});
		return ((LocalLBProfileFastHttpProfileFastHttpStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileFastHttpProfileFastHttpStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileFastHttpProfileFastHttpStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics_by_virtual
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileStatisticsByVirtual get_statistics_by_virtual(
		string [] profile_names,
		string [] [] virtual_names
	) {
		object [] results = this.Invoke("get_statistics_by_virtual", new object [] {
				profile_names,
				virtual_names});
		return ((LocalLBProfileStatisticsByVirtual)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics_by_virtual(string [] profile_names,string [] [] virtual_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics_by_virtual", new object[] {
			profile_names,
			virtual_names}, callback, asyncState);
	}
	public LocalLBProfileStatisticsByVirtual Endget_statistics_by_virtual(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileStatisticsByVirtual)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_unclean_shutdown_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileUncleanShutdownMode [] get_unclean_shutdown_mode(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_unclean_shutdown_mode", new object [] {
				profile_names});
		return ((LocalLBProfileUncleanShutdownMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_unclean_shutdown_mode(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_unclean_shutdown_mode", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileUncleanShutdownMode [] Endget_unclean_shutdown_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileUncleanShutdownMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
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
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
	public void reset_statistics(
		string [] profile_names
	) {
		this.Invoke("reset_statistics", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginreset_statistics(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endreset_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics_by_virtual
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
	public void reset_statistics_by_virtual(
		string [] profile_names,
		string [] [] virtual_names
	) {
		this.Invoke("reset_statistics_by_virtual", new object [] {
				profile_names,
				virtual_names});

	}
	public System.IAsyncResult Beginreset_statistics_by_virtual(string [] profile_names,string [] [] virtual_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics_by_virtual", new object[] {
			profile_names,
			virtual_names}, callback, asyncState);
	}
	public void Endreset_statistics_by_virtual(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_client_close_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
	public void set_client_close_timeout(
		string [] profile_names,
		LocalLBProfileULong [] timeouts
	) {
		this.Invoke("set_client_close_timeout", new object [] {
				profile_names,
				timeouts});

	}
	public System.IAsyncResult Beginset_client_close_timeout(string [] profile_names,LocalLBProfileULong [] timeouts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_client_close_timeout", new object[] {
			profile_names,
			timeouts}, callback, asyncState);
	}
	public void Endset_client_close_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_connection_pool_idle_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
	public void set_connection_pool_idle_timeout(
		string [] profile_names,
		LocalLBProfileULong [] timeouts
	) {
		this.Invoke("set_connection_pool_idle_timeout", new object [] {
				profile_names,
				timeouts});

	}
	public System.IAsyncResult Beginset_connection_pool_idle_timeout(string [] profile_names,LocalLBProfileULong [] timeouts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_connection_pool_idle_timeout", new object[] {
			profile_names,
			timeouts}, callback, asyncState);
	}
	public void Endset_connection_pool_idle_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_connection_pool_maximum_reuse
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
	public void set_connection_pool_maximum_reuse(
		string [] profile_names,
		LocalLBProfileULong [] reuses
	) {
		this.Invoke("set_connection_pool_maximum_reuse", new object [] {
				profile_names,
				reuses});

	}
	public System.IAsyncResult Beginset_connection_pool_maximum_reuse(string [] profile_names,LocalLBProfileULong [] reuses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_connection_pool_maximum_reuse", new object[] {
			profile_names,
			reuses}, callback, asyncState);
	}
	public void Endset_connection_pool_maximum_reuse(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_connection_pool_maximum_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
	public void set_connection_pool_maximum_size(
		string [] profile_names,
		LocalLBProfileULong [] sizes
	) {
		this.Invoke("set_connection_pool_maximum_size", new object [] {
				profile_names,
				sizes});

	}
	public System.IAsyncResult Beginset_connection_pool_maximum_size(string [] profile_names,LocalLBProfileULong [] sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_connection_pool_maximum_size", new object[] {
			profile_names,
			sizes}, callback, asyncState);
	}
	public void Endset_connection_pool_maximum_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_connection_pool_minimum_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
	public void set_connection_pool_minimum_size(
		string [] profile_names,
		LocalLBProfileULong [] sizes
	) {
		this.Invoke("set_connection_pool_minimum_size", new object [] {
				profile_names,
				sizes});

	}
	public System.IAsyncResult Beginset_connection_pool_minimum_size(string [] profile_names,LocalLBProfileULong [] sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_connection_pool_minimum_size", new object[] {
			profile_names,
			sizes}, callback, asyncState);
	}
	public void Endset_connection_pool_minimum_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_connection_pool_ramp_increment
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
	public void set_connection_pool_ramp_increment(
		string [] profile_names,
		LocalLBProfileULong [] increments
	) {
		this.Invoke("set_connection_pool_ramp_increment", new object [] {
				profile_names,
				increments});

	}
	public System.IAsyncResult Beginset_connection_pool_ramp_increment(string [] profile_names,LocalLBProfileULong [] increments, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_connection_pool_ramp_increment", new object[] {
			profile_names,
			increments}, callback, asyncState);
	}
	public void Endset_connection_pool_ramp_increment(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_connection_pool_replenish_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
	public void set_connection_pool_replenish_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_connection_pool_replenish_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_connection_pool_replenish_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_connection_pool_replenish_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_connection_pool_replenish_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
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
	// set_force_http10_response_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
	public void set_force_http10_response_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_force_http10_response_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_force_http10_response_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_force_http10_response_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_force_http10_response_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_header_insert
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
	public void set_header_insert(
		string [] profile_names,
		LocalLBProfileString [] headers
	) {
		this.Invoke("set_header_insert", new object [] {
				profile_names,
				headers});

	}
	public System.IAsyncResult Beginset_header_insert(string [] profile_names,LocalLBProfileString [] headers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_header_insert", new object[] {
			profile_names,
			headers}, callback, asyncState);
	}
	public void Endset_header_insert(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_http11_close_workarounds_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
	public void set_http11_close_workarounds_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_http11_close_workarounds_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_http11_close_workarounds_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_http11_close_workarounds_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_http11_close_workarounds_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_idle_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
	public void set_idle_timeout(
		string [] profile_names,
		LocalLBProfileULong [] timeouts
	) {
		this.Invoke("set_idle_timeout", new object [] {
				profile_names,
				timeouts});

	}
	public System.IAsyncResult Beginset_idle_timeout(string [] profile_names,LocalLBProfileULong [] timeouts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_idle_timeout", new object[] {
			profile_names,
			timeouts}, callback, asyncState);
	}
	public void Endset_idle_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_insert_xforwarded_for_header_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
	public void set_insert_xforwarded_for_header_mode(
		string [] profile_names,
		LocalLBProfileProfileMode [] modes
	) {
		this.Invoke("set_insert_xforwarded_for_header_mode", new object [] {
				profile_names,
				modes});

	}
	public System.IAsyncResult Beginset_insert_xforwarded_for_header_mode(string [] profile_names,LocalLBProfileProfileMode [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_insert_xforwarded_for_header_mode", new object[] {
			profile_names,
			modes}, callback, asyncState);
	}
	public void Endset_insert_xforwarded_for_header_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_layer7_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
	public void set_layer7_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_layer7_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_layer7_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_layer7_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_layer7_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_header_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
	public void set_maximum_header_size(
		string [] profile_names,
		LocalLBProfileULong [] sizes
	) {
		this.Invoke("set_maximum_header_size", new object [] {
				profile_names,
				sizes});

	}
	public System.IAsyncResult Beginset_maximum_header_size(string [] profile_names,LocalLBProfileULong [] sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_header_size", new object[] {
			profile_names,
			sizes}, callback, asyncState);
	}
	public void Endset_maximum_header_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_requests
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
	public void set_maximum_requests(
		string [] profile_names,
		LocalLBProfileULong [] maximum_requests
	) {
		this.Invoke("set_maximum_requests", new object [] {
				profile_names,
				maximum_requests});

	}
	public System.IAsyncResult Beginset_maximum_requests(string [] profile_names,LocalLBProfileULong [] maximum_requests, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_requests", new object[] {
			profile_names,
			maximum_requests}, callback, asyncState);
	}
	public void Endset_maximum_requests(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_mss_override
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
	public void set_mss_override(
		string [] profile_names,
		LocalLBProfileULong [] mss_overrides
	) {
		this.Invoke("set_mss_override", new object [] {
				profile_names,
				mss_overrides});

	}
	public System.IAsyncResult Beginset_mss_override(string [] profile_names,LocalLBProfileULong [] mss_overrides, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_mss_override", new object[] {
			profile_names,
			mss_overrides}, callback, asyncState);
	}
	public void Endset_mss_override(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_reset_on_timeout_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
	public void set_reset_on_timeout_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_reset_on_timeout_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_reset_on_timeout_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_reset_on_timeout_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_reset_on_timeout_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_server_close_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
	public void set_server_close_timeout(
		string [] profile_names,
		LocalLBProfileULong [] timeouts
	) {
		this.Invoke("set_server_close_timeout", new object [] {
				profile_names,
				timeouts});

	}
	public System.IAsyncResult Beginset_server_close_timeout(string [] profile_names,LocalLBProfileULong [] timeouts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_server_close_timeout", new object[] {
			profile_names,
			timeouts}, callback, asyncState);
	}
	public void Endset_server_close_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_unclean_shutdown_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileFastHttp")]
	public void set_unclean_shutdown_mode(
		string [] profile_names,
		LocalLBProfileUncleanShutdownMode [] modes
	) {
		this.Invoke("set_unclean_shutdown_mode", new object [] {
				profile_names,
				modes});

	}
	public System.IAsyncResult Beginset_unclean_shutdown_mode(string [] profile_names,LocalLBProfileUncleanShutdownMode [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_unclean_shutdown_mode", new object[] {
			profile_names,
			modes}, callback, asyncState);
	}
	public void Endset_unclean_shutdown_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileFastHttp.ProfileFastHttpStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBProfileFastHttpProfileFastHttpStatisticEntry
	{
		private string profile_nameField;
		public string profile_name
		{
			get { return this.profile_nameField; }
			set { this.profile_nameField = value; }
		}
		private CommonStatistic [] statisticsField;
		public CommonStatistic [] statistics
		{
			get { return this.statisticsField; }
			set { this.statisticsField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileFastHttp.ProfileFastHttpStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBProfileFastHttpProfileFastHttpStatistics
	{
		private LocalLBProfileFastHttpProfileFastHttpStatisticEntry [] statisticsField;
		public LocalLBProfileFastHttpProfileFastHttpStatisticEntry [] statistics
		{
			get { return this.statisticsField; }
			set { this.statisticsField = value; }
		}
		private CommonTimeStamp time_stampField;
		public CommonTimeStamp time_stamp
		{
			get { return this.time_stampField; }
			set { this.time_stampField = value; }
		}
	};

}
