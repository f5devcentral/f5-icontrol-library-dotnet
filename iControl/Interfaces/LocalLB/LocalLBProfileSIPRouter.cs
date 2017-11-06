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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.ProfileSIPRouterBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileSIPRouterSIPRouterProfileStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileULong))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileString))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileEnabledState))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileStatisticsByVirtual))]
	public partial class LocalLBProfileSIPRouter : iControlInterface {
		public LocalLBProfileSIPRouter() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_sip_route
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
	public void add_sip_route(
		string [] profile_names,
		string [] [] sip_routes
	) {
		this.Invoke("add_sip_route", new object [] {
				profile_names,
				sip_routes});

	}
	public System.IAsyncResult Beginadd_sip_route(string [] profile_names,string [] [] sip_routes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_sip_route", new object[] {
			profile_names,
			sip_routes}, callback, asyncState);
	}
	public void Endadd_sip_route(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileSIPRouterSIPRouterProfileStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((LocalLBProfileSIPRouterSIPRouterProfileStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public LocalLBProfileSIPRouterSIPRouterProfileStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileSIPRouterSIPRouterProfileStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_concurrent_sessions_per_subscriber
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_concurrent_sessions_per_subscriber(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_concurrent_sessions_per_subscriber", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_concurrent_sessions_per_subscriber(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_concurrent_sessions_per_subscriber", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_concurrent_sessions_per_subscriber(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
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
	// get_dialog_establishment_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
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
	// get_ha_message_sweeper_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_ha_message_sweeper_interval(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_ha_message_sweeper_interval", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_ha_message_sweeper_interval(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ha_message_sweeper_interval", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_ha_message_sweeper_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
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
	// get_maximum_global_registrations
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_maximum_global_registrations(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_maximum_global_registrations", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_global_registrations(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_global_registrations", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_maximum_global_registrations(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_maximum_media_sessions
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
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
	// get_maximum_pending_bytes
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_maximum_pending_bytes(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_maximum_pending_bytes", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_pending_bytes(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_pending_bytes", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_maximum_pending_bytes(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_maximum_pending_messages
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_maximum_pending_messages(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_maximum_pending_messages", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_pending_messages(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_pending_messages", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_maximum_pending_messages(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_maximum_registrations_per_subscriber
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_maximum_registrations_per_subscriber(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_maximum_registrations_per_subscriber", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_registrations_per_subscriber(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_registrations_per_subscriber", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_maximum_registrations_per_subscriber(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_maximum_session_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_maximum_session_timeout(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_maximum_session_timeout", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_session_timeout(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_session_timeout", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_maximum_session_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_media_inactivity_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_media_inactivity_timeout(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_media_inactivity_timeout", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_media_inactivity_timeout(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_media_inactivity_timeout", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_media_inactivity_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_mirroring_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_mirroring_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_mirroring_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_mirroring_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_mirroring_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_mirroring_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_registration_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
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
	// get_sip_route
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_sip_route(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_sip_route", new object [] {
				profile_names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_sip_route(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_sip_route", new object[] {
			profile_names}, callback, asyncState);
	}
	public string [] [] Endget_sip_route(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileSIPRouterSIPRouterProfileStatistics get_statistics(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				profile_names});
		return ((LocalLBProfileSIPRouterSIPRouterProfileStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileSIPRouterSIPRouterProfileStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileSIPRouterSIPRouterProfileStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics_by_virtual
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
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
	// get_traffic_group
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_traffic_group(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_traffic_group", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_traffic_group(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_traffic_group", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_traffic_group(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_transaction_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_transaction_timeout(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_transaction_timeout", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_transaction_timeout(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_transaction_timeout", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_transaction_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_use_local_connection_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_use_local_connection_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_use_local_connection_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_use_local_connection_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_use_local_connection_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_use_local_connection_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
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
	// remove_all_sip_routes
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
	public void remove_all_sip_routes(
		string [] profile_names
	) {
		this.Invoke("remove_all_sip_routes", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginremove_all_sip_routes(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_sip_routes", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endremove_all_sip_routes(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_sip_route
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
	public void remove_sip_route(
		string [] profile_names,
		string [] [] sip_routes
	) {
		this.Invoke("remove_sip_route", new object [] {
				profile_names,
				sip_routes});

	}
	public System.IAsyncResult Beginremove_sip_route(string [] profile_names,string [] [] sip_routes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_sip_route", new object[] {
			profile_names,
			sip_routes}, callback, asyncState);
	}
	public void Endremove_sip_route(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
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
	// set_concurrent_sessions_per_subscriber
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
	public void set_concurrent_sessions_per_subscriber(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_concurrent_sessions_per_subscriber", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_concurrent_sessions_per_subscriber(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_concurrent_sessions_per_subscriber", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_concurrent_sessions_per_subscriber(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
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
	// set_dialog_establishment_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
	public void set_dialog_establishment_timeout(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_dialog_establishment_timeout", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_dialog_establishment_timeout(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dialog_establishment_timeout", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_dialog_establishment_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ha_message_sweeper_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
	public void set_ha_message_sweeper_interval(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_ha_message_sweeper_interval", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_ha_message_sweeper_interval(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ha_message_sweeper_interval", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_ha_message_sweeper_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_log_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
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
	// set_maximum_global_registrations
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
	public void set_maximum_global_registrations(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_maximum_global_registrations", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_maximum_global_registrations(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_global_registrations", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_maximum_global_registrations(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_media_sessions
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
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
	// set_maximum_pending_bytes
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
	public void set_maximum_pending_bytes(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_maximum_pending_bytes", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_maximum_pending_bytes(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_pending_bytes", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_maximum_pending_bytes(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_pending_messages
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
	public void set_maximum_pending_messages(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_maximum_pending_messages", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_maximum_pending_messages(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_pending_messages", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_maximum_pending_messages(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_registrations_per_subscriber
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
	public void set_maximum_registrations_per_subscriber(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_maximum_registrations_per_subscriber", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_maximum_registrations_per_subscriber(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_registrations_per_subscriber", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_maximum_registrations_per_subscriber(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_session_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
	public void set_maximum_session_timeout(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_maximum_session_timeout", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_maximum_session_timeout(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_session_timeout", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_maximum_session_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_media_inactivity_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
	public void set_media_inactivity_timeout(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_media_inactivity_timeout", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_media_inactivity_timeout(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_media_inactivity_timeout", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_media_inactivity_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_mirroring_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
	public void set_mirroring_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] values
	) {
		this.Invoke("set_mirroring_state", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_mirroring_state(string [] profile_names,LocalLBProfileEnabledState [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_mirroring_state", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_mirroring_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_registration_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
	public void set_registration_timeout(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_registration_timeout", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_registration_timeout(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_registration_timeout", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_registration_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_traffic_group
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
	public void set_traffic_group(
		string [] profile_names,
		LocalLBProfileString [] values
	) {
		this.Invoke("set_traffic_group", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_traffic_group(string [] profile_names,LocalLBProfileString [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_traffic_group", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_traffic_group(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_transaction_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
	public void set_transaction_timeout(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_transaction_timeout", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_transaction_timeout(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_transaction_timeout", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_transaction_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_use_local_connection_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSIPRouter", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSIPRouter", ResponseNamespace="urn:iControl:LocalLB/ProfileSIPRouter")]
	public void set_use_local_connection_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_use_local_connection_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_use_local_connection_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_use_local_connection_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_use_local_connection_state(System.IAsyncResult asyncResult) {
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileSIPRouter.SIPRouterProfileStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBProfileSIPRouterSIPRouterProfileStatisticEntry
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileSIPRouter.SIPRouterProfileStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBProfileSIPRouterSIPRouterProfileStatistics
	{
		private LocalLBProfileSIPRouterSIPRouterProfileStatisticEntry [] statisticsField;
		public LocalLBProfileSIPRouterSIPRouterProfileStatisticEntry [] statistics
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
