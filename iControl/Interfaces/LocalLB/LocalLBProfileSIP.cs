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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.ProfileSIPBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileEnabledState))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileULong))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileSIPProfileSIPStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileString))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileSIPProfileRTPProxyStyle))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileStatisticsByVirtual))]
	public partial class LocalLBProfileSIP : iControlInterface {
		public LocalLBProfileSIP() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
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
	// get_alg_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_alg_enabled_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_alg_enabled_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_alg_enabled_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_alg_enabled_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_alg_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_alg_session_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_alg_session_timeout(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_alg_session_timeout", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_alg_session_timeout(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_alg_session_timeout", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_alg_session_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileSIPProfileSIPStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((LocalLBProfileSIPProfileSIPStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public LocalLBProfileSIPProfileSIPStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileSIPProfileSIPStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
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
	// get_dialog_aware_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_dialog_aware_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_dialog_aware_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_dialog_aware_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dialog_aware_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_dialog_aware_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dialog_establishment_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_dialog_establishment_timeout(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_dialog_establishment_timeout", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_dialog_establishment_timeout(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dialog_establishment_timeout", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_dialog_establishment_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_firewall_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_firewall_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_firewall_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_firewall_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_firewall_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_firewall_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_insert_record_route_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_insert_record_route_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_insert_record_route_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_insert_record_route_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_insert_record_route_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_insert_record_route_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_insert_via_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_insert_via_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_insert_via_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_insert_via_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_insert_via_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_insert_via_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
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
	// get_log_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_log_profile(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_log_profile", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_log_profile(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_log_profile", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_log_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_log_publisher
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_log_publisher(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_log_publisher", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_log_publisher(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_log_publisher", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_log_publisher(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_max_message_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_max_message_size(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_max_message_size", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_max_message_size(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_max_message_size", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_max_message_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_maximum_media_sessions
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_maximum_media_sessions(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_maximum_media_sessions", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_media_sessions(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_media_sessions", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_maximum_media_sessions(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_maximum_registrations
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_maximum_registrations(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_maximum_registrations", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_registrations(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_registrations", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_maximum_registrations(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_maximum_sessions_per_registration
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_maximum_sessions_per_registration(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_maximum_sessions_per_registration", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_sessions_per_registration(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_sessions_per_registration", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_maximum_sessions_per_registration(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_registration_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_registration_timeout(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_registration_timeout", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_registration_timeout(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_registration_timeout", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_registration_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rtp_proxy_style
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileSIPProfileRTPProxyStyle [] get_rtp_proxy_style(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_rtp_proxy_style", new object [] {
				profile_names});
		return ((LocalLBProfileSIPProfileRTPProxyStyle [])(results[0]));
	}
	public System.IAsyncResult Beginget_rtp_proxy_style(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rtp_proxy_style", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileSIPProfileRTPProxyStyle [] Endget_rtp_proxy_style(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileSIPProfileRTPProxyStyle [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_secure_via_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_secure_via_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_secure_via_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_secure_via_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_secure_via_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_secure_via_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_sip_community
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_sip_community(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_sip_community", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_sip_community(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_sip_community", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_sip_community(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileSIPProfileSIPStatistics get_statistics(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				profile_names});
		return ((LocalLBProfileSIPProfileSIPStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileSIPProfileSIPStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileSIPProfileSIPStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics_by_virtual
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
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
	// get_terminate_connection_after_bye_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_terminate_connection_after_bye_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_terminate_connection_after_bye_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_terminate_connection_after_bye_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_terminate_connection_after_bye_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_terminate_connection_after_bye_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_unique_usernames_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_unique_usernames_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_unique_usernames_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_unique_usernames_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_unique_usernames_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_unique_usernames_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
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
	// get_via_userdata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_via_userdata(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_via_userdata", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_via_userdata(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_via_userdata", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_via_userdata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// is_base_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
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
	// set_alg_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
	public void set_alg_enabled_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_alg_enabled_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_alg_enabled_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_alg_enabled_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_alg_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_alg_session_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
	public void set_alg_session_timeout(
		string [] profile_names,
		LocalLBProfileULong [] timeouts
	) {
		this.Invoke("set_alg_session_timeout", new object [] {
				profile_names,
				timeouts});

	}
	public System.IAsyncResult Beginset_alg_session_timeout(string [] profile_names,LocalLBProfileULong [] timeouts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_alg_session_timeout", new object[] {
			profile_names,
			timeouts}, callback, asyncState);
	}
	public void Endset_alg_session_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
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
	// set_dialog_aware_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
	public void set_dialog_aware_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_dialog_aware_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_dialog_aware_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dialog_aware_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_dialog_aware_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dialog_establishment_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
	public void set_dialog_establishment_timeout(
		string [] profile_names,
		LocalLBProfileULong [] timeouts
	) {
		this.Invoke("set_dialog_establishment_timeout", new object [] {
				profile_names,
				timeouts});

	}
	public System.IAsyncResult Beginset_dialog_establishment_timeout(string [] profile_names,LocalLBProfileULong [] timeouts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dialog_establishment_timeout", new object[] {
			profile_names,
			timeouts}, callback, asyncState);
	}
	public void Endset_dialog_establishment_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_firewall_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
	public void set_firewall_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_firewall_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_firewall_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_firewall_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_firewall_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_insert_record_route_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
	public void set_insert_record_route_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_insert_record_route_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_insert_record_route_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_insert_record_route_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_insert_record_route_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_insert_via_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
	public void set_insert_via_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_insert_via_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_insert_via_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_insert_via_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_insert_via_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_log_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
	public void set_log_profile(
		string [] profile_names,
		LocalLBProfileString [] profiles
	) {
		this.Invoke("set_log_profile", new object [] {
				profile_names,
				profiles});

	}
	public System.IAsyncResult Beginset_log_profile(string [] profile_names,LocalLBProfileString [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_log_profile", new object[] {
			profile_names,
			profiles}, callback, asyncState);
	}
	public void Endset_log_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_log_publisher
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
	public void set_log_publisher(
		string [] profile_names,
		LocalLBProfileString [] publishers
	) {
		this.Invoke("set_log_publisher", new object [] {
				profile_names,
				publishers});

	}
	public System.IAsyncResult Beginset_log_publisher(string [] profile_names,LocalLBProfileString [] publishers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_log_publisher", new object[] {
			profile_names,
			publishers}, callback, asyncState);
	}
	public void Endset_log_publisher(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_log_settings
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
	public void set_log_settings(
		string [] profile_names,
		LocalLBProfileString [] publishers,
		LocalLBProfileString [] profiles
	) {
		this.Invoke("set_log_settings", new object [] {
				profile_names,
				publishers,
				profiles});

	}
	public System.IAsyncResult Beginset_log_settings(string [] profile_names,LocalLBProfileString [] publishers,LocalLBProfileString [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_log_settings", new object[] {
			profile_names,
			publishers,
			profiles}, callback, asyncState);
	}
	public void Endset_log_settings(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_max_message_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
	public void set_max_message_size(
		string [] profile_names,
		LocalLBProfileULong [] max_message_sizes
	) {
		this.Invoke("set_max_message_size", new object [] {
				profile_names,
				max_message_sizes});

	}
	public System.IAsyncResult Beginset_max_message_size(string [] profile_names,LocalLBProfileULong [] max_message_sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_max_message_size", new object[] {
			profile_names,
			max_message_sizes}, callback, asyncState);
	}
	public void Endset_max_message_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_media_sessions
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
	public void set_maximum_media_sessions(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_maximum_media_sessions", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_maximum_media_sessions(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_media_sessions", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_maximum_media_sessions(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_registrations
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
	public void set_maximum_registrations(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_maximum_registrations", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_maximum_registrations(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_registrations", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_maximum_registrations(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_sessions_per_registration
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
	public void set_maximum_sessions_per_registration(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_maximum_sessions_per_registration", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_maximum_sessions_per_registration(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_sessions_per_registration", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_maximum_sessions_per_registration(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_registration_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
	public void set_registration_timeout(
		string [] profile_names,
		LocalLBProfileULong [] timeouts
	) {
		this.Invoke("set_registration_timeout", new object [] {
				profile_names,
				timeouts});

	}
	public System.IAsyncResult Beginset_registration_timeout(string [] profile_names,LocalLBProfileULong [] timeouts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_registration_timeout", new object[] {
			profile_names,
			timeouts}, callback, asyncState);
	}
	public void Endset_registration_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rtp_proxy_style
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
	public void set_rtp_proxy_style(
		string [] profile_names,
		LocalLBProfileSIPProfileRTPProxyStyle [] values
	) {
		this.Invoke("set_rtp_proxy_style", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_rtp_proxy_style(string [] profile_names,LocalLBProfileSIPProfileRTPProxyStyle [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rtp_proxy_style", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_rtp_proxy_style(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_secure_via_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
	public void set_secure_via_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_secure_via_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_secure_via_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_secure_via_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_secure_via_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_sip_community
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
	public void set_sip_community(
		string [] profile_names,
		LocalLBProfileString [] community
	) {
		this.Invoke("set_sip_community", new object [] {
				profile_names,
				community});

	}
	public System.IAsyncResult Beginset_sip_community(string [] profile_names,LocalLBProfileString [] community, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_sip_community", new object[] {
			profile_names,
			community}, callback, asyncState);
	}
	public void Endset_sip_community(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_terminate_connection_after_bye_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
	public void set_terminate_connection_after_bye_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_terminate_connection_after_bye_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_terminate_connection_after_bye_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_terminate_connection_after_bye_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_terminate_connection_after_bye_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_unique_usernames_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
	public void set_unique_usernames_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_unique_usernames_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_unique_usernames_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_unique_usernames_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_unique_usernames_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_via_userdata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIP", ResponseNamespace="urn:iControl:LocalLB/ProfileSIP")]
	public void set_via_userdata(
		string [] profile_names,
		LocalLBProfileString [] via_userdata
	) {
		this.Invoke("set_via_userdata", new object [] {
				profile_names,
				via_userdata});

	}
	public System.IAsyncResult Beginset_via_userdata(string [] profile_names,LocalLBProfileString [] via_userdata, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_via_userdata", new object[] {
			profile_names,
			via_userdata}, callback, asyncState);
	}
	public void Endset_via_userdata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileSIP.RTPProxyStyle", Namespace = "urn:iControl")]
	public enum LocalLBProfileSIPRTPProxyStyle
	{
		RTP_PROXY_STYLE_UNKNOWN,
		RTP_PROXY_STYLE_SYMMETRIC,
		RTP_PROXY_STYLE_RESTRICTED_IP,
		RTP_PROXY_STYLE_ANY,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileSIP.ProfileRTPProxyStyle", Namespace = "urn:iControl")]
	public partial class LocalLBProfileSIPProfileRTPProxyStyle
	{
		private LocalLBProfileSIPRTPProxyStyle valueField;
		public LocalLBProfileSIPRTPProxyStyle value
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

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileSIP.ProfileSIPStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBProfileSIPProfileSIPStatisticEntry
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileSIP.ProfileSIPStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBProfileSIPProfileSIPStatistics
	{
		private LocalLBProfileSIPProfileSIPStatisticEntry [] statisticsField;
		public LocalLBProfileSIPProfileSIPStatisticEntry [] statistics
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
