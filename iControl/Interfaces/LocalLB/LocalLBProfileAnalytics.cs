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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.ProfileAnalyticsBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileEnabledState))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileString))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileStringArray))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileIPAddress))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfilePortNumber))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileAnalyticsProfileLoggingFacility))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileULong))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileAnalyticsProfileSessionCookieSecurityMode))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileAnalyticsProfileSessionTimeout))]
	public partial class LocalLBProfileAnalytics : iControlInterface {
		public LocalLBProfileAnalytics() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_alert
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void add_alert(
		string [] profile_names,
		string [] [] alerts
	) {
		this.Invoke("add_alert", new object [] {
				profile_names,
				alerts});

	}
	public System.IAsyncResult Beginadd_alert(string [] profile_names,string [] [] alerts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_alert", new object[] {
			profile_names,
			alerts}, callback, asyncState);
	}
	public void Endadd_alert(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_notification_by_email_addresses
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void add_notification_by_email_addresses(
		string [] profile_names,
		string [] [] email_addresses
	) {
		this.Invoke("add_notification_by_email_addresses", new object [] {
				profile_names,
				email_addresses});

	}
	public System.IAsyncResult Beginadd_notification_by_email_addresses(string [] profile_names,string [] [] email_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_notification_by_email_addresses", new object[] {
			profile_names,
			email_addresses}, callback, asyncState);
	}
	public void Endadd_notification_by_email_addresses(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_subnet
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void add_subnet(
		string [] profile_names,
		string [] [] subnets,
		string [] [] addresses
	) {
		this.Invoke("add_subnet", new object [] {
				profile_names,
				subnets,
				addresses});

	}
	public System.IAsyncResult Beginadd_subnet(string [] profile_names,string [] [] subnets,string [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_subnet", new object[] {
			profile_names,
			subnets,
			addresses}, callback, asyncState);
	}
	public void Endadd_subnet(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_traffic_capture
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void add_traffic_capture(
		string [] profile_names,
		string [] [] traffic_capture_names
	) {
		this.Invoke("add_traffic_capture", new object [] {
				profile_names,
				traffic_capture_names});

	}
	public System.IAsyncResult Beginadd_traffic_capture(string [] profile_names,string [] [] traffic_capture_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_traffic_capture", new object[] {
			profile_names,
			traffic_capture_names}, callback, asyncState);
	}
	public void Endadd_traffic_capture(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_traffic_capture_client_ips
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void add_traffic_capture_client_ips(
		string [] profile_names,
		string [] [] traffic_capture_names,
		string [] [] [] ip_addresses
	) {
		this.Invoke("add_traffic_capture_client_ips", new object [] {
				profile_names,
				traffic_capture_names,
				ip_addresses});

	}
	public System.IAsyncResult Beginadd_traffic_capture_client_ips(string [] profile_names,string [] [] traffic_capture_names,string [] [] [] ip_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_traffic_capture_client_ips", new object[] {
			profile_names,
			traffic_capture_names,
			ip_addresses}, callback, asyncState);
	}
	public void Endadd_traffic_capture_client_ips(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_traffic_capture_methods
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void add_traffic_capture_methods(
		string [] profile_names,
		string [] [] traffic_capture_names,
		string [] [] [] methods
	) {
		this.Invoke("add_traffic_capture_methods", new object [] {
				profile_names,
				traffic_capture_names,
				methods});

	}
	public System.IAsyncResult Beginadd_traffic_capture_methods(string [] profile_names,string [] [] traffic_capture_names,string [] [] [] methods, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_traffic_capture_methods", new object[] {
			profile_names,
			traffic_capture_names,
			methods}, callback, asyncState);
	}
	public void Endadd_traffic_capture_methods(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_traffic_capture_nodes
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void add_traffic_capture_nodes(
		string [] profile_names,
		string [] [] traffic_capture_names,
		string [] [] [] nodes
	) {
		this.Invoke("add_traffic_capture_nodes", new object [] {
				profile_names,
				traffic_capture_names,
				nodes});

	}
	public System.IAsyncResult Beginadd_traffic_capture_nodes(string [] profile_names,string [] [] traffic_capture_names,string [] [] [] nodes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_traffic_capture_nodes", new object[] {
			profile_names,
			traffic_capture_names,
			nodes}, callback, asyncState);
	}
	public void Endadd_traffic_capture_nodes(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_traffic_capture_response_codes
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void add_traffic_capture_response_codes(
		string [] profile_names,
		string [] [] traffic_capture_names,
		long [] [] [] response_codes
	) {
		this.Invoke("add_traffic_capture_response_codes", new object [] {
				profile_names,
				traffic_capture_names,
				response_codes});

	}
	public System.IAsyncResult Beginadd_traffic_capture_response_codes(string [] profile_names,string [] [] traffic_capture_names,long [] [] [] response_codes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_traffic_capture_response_codes", new object[] {
			profile_names,
			traffic_capture_names,
			response_codes}, callback, asyncState);
	}
	public void Endadd_traffic_capture_response_codes(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_traffic_capture_url_path_prefixes
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void add_traffic_capture_url_path_prefixes(
		string [] profile_names,
		string [] [] traffic_capture_names,
		string [] [] [] url_path_prefixes
	) {
		this.Invoke("add_traffic_capture_url_path_prefixes", new object [] {
				profile_names,
				traffic_capture_names,
				url_path_prefixes});

	}
	public System.IAsyncResult Beginadd_traffic_capture_url_path_prefixes(string [] profile_names,string [] [] traffic_capture_names,string [] [] [] url_path_prefixes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_traffic_capture_url_path_prefixes", new object[] {
			profile_names,
			traffic_capture_names,
			url_path_prefixes}, callback, asyncState);
	}
	public void Endadd_traffic_capture_url_path_prefixes(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_traffic_capture_user_agent_substrings
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void add_traffic_capture_user_agent_substrings(
		string [] profile_names,
		string [] [] traffic_capture_names,
		string [] [] [] user_agent_substrings
	) {
		this.Invoke("add_traffic_capture_user_agent_substrings", new object [] {
				profile_names,
				traffic_capture_names,
				user_agent_substrings});

	}
	public System.IAsyncResult Beginadd_traffic_capture_user_agent_substrings(string [] profile_names,string [] [] traffic_capture_names,string [] [] [] user_agent_substrings, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_traffic_capture_user_agent_substrings", new object[] {
			profile_names,
			traffic_capture_names,
			user_agent_substrings}, callback, asyncState);
	}
	public void Endadd_traffic_capture_user_agent_substrings(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_traffic_capture_virtual_servers
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void add_traffic_capture_virtual_servers(
		string [] profile_names,
		string [] [] traffic_capture_names,
		string [] [] [] virtual_server_names
	) {
		this.Invoke("add_traffic_capture_virtual_servers", new object [] {
				profile_names,
				traffic_capture_names,
				virtual_server_names});

	}
	public System.IAsyncResult Beginadd_traffic_capture_virtual_servers(string [] profile_names,string [] [] traffic_capture_names,string [] [] [] virtual_server_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_traffic_capture_virtual_servers", new object[] {
			profile_names,
			traffic_capture_names,
			virtual_server_names}, callback, asyncState);
	}
	public void Endadd_traffic_capture_virtual_servers(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
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
	// get_alert
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_alert(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_alert", new object [] {
				profile_names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_alert(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_alert", new object[] {
			profile_names}, callback, asyncState);
	}
	public string [] [] Endget_alert(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_alert_granularity
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileAnalyticsAnalyticsAlertGranularity [] [] get_alert_granularity(
		string [] profile_names,
		string [] [] alerts
	) {
		object [] results = this.Invoke("get_alert_granularity", new object [] {
				profile_names,
				alerts});
		return ((LocalLBProfileAnalyticsAnalyticsAlertGranularity [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_alert_granularity(string [] profile_names,string [] [] alerts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_alert_granularity", new object[] {
			profile_names,
			alerts}, callback, asyncState);
	}
	public LocalLBProfileAnalyticsAnalyticsAlertGranularity [] [] Endget_alert_granularity(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileAnalyticsAnalyticsAlertGranularity [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_alert_metric
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileAnalyticsAnalyticsAlertMetric [] [] get_alert_metric(
		string [] profile_names,
		string [] [] alerts
	) {
		object [] results = this.Invoke("get_alert_metric", new object [] {
				profile_names,
				alerts});
		return ((LocalLBProfileAnalyticsAnalyticsAlertMetric [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_alert_metric(string [] profile_names,string [] [] alerts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_alert_metric", new object[] {
			profile_names,
			alerts}, callback, asyncState);
	}
	public LocalLBProfileAnalyticsAnalyticsAlertMetric [] [] Endget_alert_metric(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileAnalyticsAnalyticsAlertMetric [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_alert_sample_period
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_alert_sample_period(
		string [] profile_names,
		string [] [] alerts
	) {
		object [] results = this.Invoke("get_alert_sample_period", new object [] {
				profile_names,
				alerts});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_alert_sample_period(string [] profile_names,string [] [] alerts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_alert_sample_period", new object[] {
			profile_names,
			alerts}, callback, asyncState);
	}
	public long [] [] Endget_alert_sample_period(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_alert_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_alert_threshold(
		string [] profile_names,
		string [] [] alerts
	) {
		object [] results = this.Invoke("get_alert_threshold", new object [] {
				profile_names,
				alerts});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_alert_threshold(string [] profile_names,string [] [] alerts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_alert_threshold", new object[] {
			profile_names,
			alerts}, callback, asyncState);
	}
	public long [] [] Endget_alert_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_alert_threshold_relation
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileAnalyticsAnalyticsAlertThresholdRelation [] [] get_alert_threshold_relation(
		string [] profile_names,
		string [] [] alerts
	) {
		object [] results = this.Invoke("get_alert_threshold_relation", new object [] {
				profile_names,
				alerts});
		return ((LocalLBProfileAnalyticsAnalyticsAlertThresholdRelation [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_alert_threshold_relation(string [] profile_names,string [] [] alerts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_alert_threshold_relation", new object[] {
			profile_names,
			alerts}, callback, asyncState);
	}
	public LocalLBProfileAnalyticsAnalyticsAlertThresholdRelation [] [] Endget_alert_threshold_relation(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileAnalyticsAnalyticsAlertThresholdRelation [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_captured_protocol
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileAnalyticsCapturedProtocol [] [] get_captured_protocol(
		string [] profile_names,
		string [] [] traffic_capture_names
	) {
		object [] results = this.Invoke("get_captured_protocol", new object [] {
				profile_names,
				traffic_capture_names});
		return ((LocalLBProfileAnalyticsCapturedProtocol [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_captured_protocol(string [] profile_names,string [] [] traffic_capture_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_captured_protocol", new object[] {
			profile_names,
			traffic_capture_names}, callback, asyncState);
	}
	public LocalLBProfileAnalyticsCapturedProtocol [] [] Endget_captured_protocol(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileAnalyticsCapturedProtocol [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_captured_traffic_external_logging_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_captured_traffic_external_logging_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_captured_traffic_external_logging_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_captured_traffic_external_logging_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_captured_traffic_external_logging_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_captured_traffic_external_logging_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_captured_traffic_internal_logging_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_captured_traffic_internal_logging_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_captured_traffic_internal_logging_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_captured_traffic_internal_logging_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_captured_traffic_internal_logging_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_captured_traffic_internal_logging_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_collect_client_ip_addresses_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_collect_client_ip_addresses_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_collect_client_ip_addresses_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_collect_client_ip_addresses_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_collect_client_ip_addresses_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_collect_client_ip_addresses_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_collect_countries_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_collect_countries_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_collect_countries_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_collect_countries_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_collect_countries_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_collect_countries_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_collect_http_throughput_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_collect_http_throughput_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_collect_http_throughput_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_collect_http_throughput_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_collect_http_throughput_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_collect_http_throughput_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_collect_maximum_tps_and_throughput_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_collect_maximum_tps_and_throughput_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_collect_maximum_tps_and_throughput_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_collect_maximum_tps_and_throughput_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_collect_maximum_tps_and_throughput_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_collect_maximum_tps_and_throughput_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_collect_methods_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_collect_methods_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_collect_methods_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_collect_methods_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_collect_methods_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_collect_methods_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_collect_page_load_time_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_collect_page_load_time_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_collect_page_load_time_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_collect_page_load_time_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_collect_page_load_time_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_collect_page_load_time_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_collect_response_codes_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_collect_response_codes_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_collect_response_codes_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_collect_response_codes_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_collect_response_codes_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_collect_response_codes_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_collect_server_latency_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_collect_server_latency_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_collect_server_latency_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_collect_server_latency_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_collect_server_latency_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_collect_server_latency_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_collect_subnets_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_collect_subnets_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_collect_subnets_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_collect_subnets_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_collect_subnets_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_collect_subnets_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_collect_url_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_collect_url_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_collect_url_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_collect_url_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_collect_url_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_collect_url_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_collect_user_agents_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_collect_user_agents_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_collect_user_agents_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_collect_user_agents_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_collect_user_agents_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_collect_user_agents_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_collect_user_sessions_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_collect_user_sessions_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_collect_user_sessions_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_collect_user_sessions_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_collect_user_sessions_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_collect_user_sessions_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_collected_stats_external_logging_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_collected_stats_external_logging_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_collected_stats_external_logging_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_collected_stats_external_logging_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_collected_stats_external_logging_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_collected_stats_external_logging_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_collected_stats_internal_logging_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_collected_stats_internal_logging_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_collected_stats_internal_logging_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_collected_stats_internal_logging_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_collected_stats_internal_logging_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_collected_stats_internal_logging_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
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
	// get_external_logging_publisher
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_external_logging_publisher(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_external_logging_publisher", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_external_logging_publisher(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_external_logging_publisher", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_external_logging_publisher(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
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
	// get_notification_by_email_addresses
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileStringArray [] get_notification_by_email_addresses(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_notification_by_email_addresses", new object [] {
				profile_names});
		return ((LocalLBProfileStringArray [])(results[0]));
	}
	public System.IAsyncResult Beginget_notification_by_email_addresses(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_notification_by_email_addresses", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileStringArray [] Endget_notification_by_email_addresses(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileStringArray [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_notification_by_email_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_notification_by_email_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_notification_by_email_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_notification_by_email_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_notification_by_email_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_notification_by_email_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_notification_by_snmp_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_notification_by_snmp_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_notification_by_snmp_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_notification_by_snmp_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_notification_by_snmp_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_notification_by_snmp_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_notification_by_syslog_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_notification_by_syslog_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_notification_by_syslog_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_notification_by_syslog_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_notification_by_syslog_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_notification_by_syslog_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_publish_irule_statistics_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_publish_irule_statistics_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_publish_irule_statistics_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_publish_irule_statistics_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_publish_irule_statistics_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_publish_irule_statistics_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_remote_server_ip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileIPAddress [] get_remote_server_ip(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_remote_server_ip", new object [] {
				profile_names});
		return ((LocalLBProfileIPAddress [])(results[0]));
	}
	public System.IAsyncResult Beginget_remote_server_ip(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_remote_server_ip", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileIPAddress [] Endget_remote_server_ip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileIPAddress [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_remote_server_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfilePortNumber [] get_remote_server_port(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_remote_server_port", new object [] {
				profile_names});
		return ((LocalLBProfilePortNumber [])(results[0]));
	}
	public System.IAsyncResult Beginget_remote_server_port(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_remote_server_port", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfilePortNumber [] Endget_remote_server_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfilePortNumber [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_remote_server_syslog_facility
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileAnalyticsProfileLoggingFacility [] get_remote_server_syslog_facility(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_remote_server_syslog_facility", new object [] {
				profile_names});
		return ((LocalLBProfileAnalyticsProfileLoggingFacility [])(results[0]));
	}
	public System.IAsyncResult Beginget_remote_server_syslog_facility(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_remote_server_syslog_facility", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileAnalyticsProfileLoggingFacility [] Endget_remote_server_syslog_facility(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileAnalyticsProfileLoggingFacility [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_request_captured_parts
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileAnalyticsTransactionPart [] [] get_request_captured_parts(
		string [] profile_names,
		string [] [] traffic_capture_names
	) {
		object [] results = this.Invoke("get_request_captured_parts", new object [] {
				profile_names,
				traffic_capture_names});
		return ((LocalLBProfileAnalyticsTransactionPart [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_request_captured_parts(string [] profile_names,string [] [] traffic_capture_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_request_captured_parts", new object[] {
			profile_names,
			traffic_capture_names}, callback, asyncState);
	}
	public LocalLBProfileAnalyticsTransactionPart [] [] Endget_request_captured_parts(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileAnalyticsTransactionPart [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_request_content_filter_search_part
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileAnalyticsTransactionPart [] [] get_request_content_filter_search_part(
		string [] profile_names,
		string [] [] traffic_capture_names
	) {
		object [] results = this.Invoke("get_request_content_filter_search_part", new object [] {
				profile_names,
				traffic_capture_names});
		return ((LocalLBProfileAnalyticsTransactionPart [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_request_content_filter_search_part(string [] profile_names,string [] [] traffic_capture_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_request_content_filter_search_part", new object[] {
			profile_names,
			traffic_capture_names}, callback, asyncState);
	}
	public LocalLBProfileAnalyticsTransactionPart [] [] Endget_request_content_filter_search_part(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileAnalyticsTransactionPart [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_request_content_filter_search_string
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_request_content_filter_search_string(
		string [] profile_names,
		string [] [] traffic_capture_names
	) {
		object [] results = this.Invoke("get_request_content_filter_search_string", new object [] {
				profile_names,
				traffic_capture_names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_request_content_filter_search_string(string [] profile_names,string [] [] traffic_capture_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_request_content_filter_search_string", new object[] {
			profile_names,
			traffic_capture_names}, callback, asyncState);
	}
	public string [] [] Endget_request_content_filter_search_string(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_response_captured_parts
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileAnalyticsTransactionPart [] [] get_response_captured_parts(
		string [] profile_names,
		string [] [] traffic_capture_names
	) {
		object [] results = this.Invoke("get_response_captured_parts", new object [] {
				profile_names,
				traffic_capture_names});
		return ((LocalLBProfileAnalyticsTransactionPart [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_response_captured_parts(string [] profile_names,string [] [] traffic_capture_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_response_captured_parts", new object[] {
			profile_names,
			traffic_capture_names}, callback, asyncState);
	}
	public LocalLBProfileAnalyticsTransactionPart [] [] Endget_response_captured_parts(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileAnalyticsTransactionPart [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_response_content_filter_search_part
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileAnalyticsTransactionPart [] [] get_response_content_filter_search_part(
		string [] profile_names,
		string [] [] traffic_capture_names
	) {
		object [] results = this.Invoke("get_response_content_filter_search_part", new object [] {
				profile_names,
				traffic_capture_names});
		return ((LocalLBProfileAnalyticsTransactionPart [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_response_content_filter_search_part(string [] profile_names,string [] [] traffic_capture_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_response_content_filter_search_part", new object[] {
			profile_names,
			traffic_capture_names}, callback, asyncState);
	}
	public LocalLBProfileAnalyticsTransactionPart [] [] Endget_response_content_filter_search_part(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileAnalyticsTransactionPart [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_response_content_filter_search_string
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_response_content_filter_search_string(
		string [] profile_names,
		string [] [] traffic_capture_names
	) {
		object [] results = this.Invoke("get_response_content_filter_search_string", new object [] {
				profile_names,
				traffic_capture_names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_response_content_filter_search_string(string [] profile_names,string [] [] traffic_capture_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_response_content_filter_search_string", new object[] {
			profile_names,
			traffic_capture_names}, callback, asyncState);
	}
	public string [] [] Endget_response_content_filter_search_string(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_sampling_ratio
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_sampling_ratio(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_sampling_ratio", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_sampling_ratio(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_sampling_ratio", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_sampling_ratio(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_sampling_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_sampling_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_sampling_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_sampling_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_sampling_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_sampling_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_session_cookie_security_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileAnalyticsProfileSessionCookieSecurityMode [] get_session_cookie_security_mode(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_session_cookie_security_mode", new object [] {
				profile_names});
		return ((LocalLBProfileAnalyticsProfileSessionCookieSecurityMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_session_cookie_security_mode(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_session_cookie_security_mode", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileAnalyticsProfileSessionCookieSecurityMode [] Endget_session_cookie_security_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileAnalyticsProfileSessionCookieSecurityMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_smtp_configuration
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_smtp_configuration(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_smtp_configuration", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_smtp_configuration(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_smtp_configuration", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_smtp_configuration(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_subnet
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_subnet(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_subnet", new object [] {
				profile_names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_subnet(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_subnet", new object[] {
			profile_names}, callback, asyncState);
	}
	public string [] [] Endget_subnet(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_subnet_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_subnet_address(
		string [] profile_names,
		string [] [] subnets
	) {
		object [] results = this.Invoke("get_subnet_address", new object [] {
				profile_names,
				subnets});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_subnet_address(string [] profile_names,string [] [] subnets, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_subnet_address", new object[] {
			profile_names,
			subnets}, callback, asyncState);
	}
	public string [] [] Endget_subnet_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_traffic_capture
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_traffic_capture(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_traffic_capture", new object [] {
				profile_names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_traffic_capture(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_traffic_capture", new object[] {
			profile_names}, callback, asyncState);
	}
	public string [] [] Endget_traffic_capture(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_traffic_capture_client_ips
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_traffic_capture_client_ips(
		string [] profile_names,
		string [] [] traffic_capture_names
	) {
		object [] results = this.Invoke("get_traffic_capture_client_ips", new object [] {
				profile_names,
				traffic_capture_names});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_traffic_capture_client_ips(string [] profile_names,string [] [] traffic_capture_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_traffic_capture_client_ips", new object[] {
			profile_names,
			traffic_capture_names}, callback, asyncState);
	}
	public string [] [] [] Endget_traffic_capture_client_ips(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_traffic_capture_methods
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_traffic_capture_methods(
		string [] profile_names,
		string [] [] traffic_capture_names
	) {
		object [] results = this.Invoke("get_traffic_capture_methods", new object [] {
				profile_names,
				traffic_capture_names});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_traffic_capture_methods(string [] profile_names,string [] [] traffic_capture_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_traffic_capture_methods", new object[] {
			profile_names,
			traffic_capture_names}, callback, asyncState);
	}
	public string [] [] [] Endget_traffic_capture_methods(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_traffic_capture_nodes
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_traffic_capture_nodes(
		string [] profile_names,
		string [] [] traffic_capture_names
	) {
		object [] results = this.Invoke("get_traffic_capture_nodes", new object [] {
				profile_names,
				traffic_capture_names});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_traffic_capture_nodes(string [] profile_names,string [] [] traffic_capture_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_traffic_capture_nodes", new object[] {
			profile_names,
			traffic_capture_names}, callback, asyncState);
	}
	public string [] [] [] Endget_traffic_capture_nodes(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_traffic_capture_response_codes
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] [] get_traffic_capture_response_codes(
		string [] profile_names,
		string [] [] traffic_capture_names
	) {
		object [] results = this.Invoke("get_traffic_capture_response_codes", new object [] {
				profile_names,
				traffic_capture_names});
		return ((long [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_traffic_capture_response_codes(string [] profile_names,string [] [] traffic_capture_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_traffic_capture_response_codes", new object[] {
			profile_names,
			traffic_capture_names}, callback, asyncState);
	}
	public long [] [] [] Endget_traffic_capture_response_codes(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_traffic_capture_url_path_prefixes
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_traffic_capture_url_path_prefixes(
		string [] profile_names,
		string [] [] traffic_capture_names
	) {
		object [] results = this.Invoke("get_traffic_capture_url_path_prefixes", new object [] {
				profile_names,
				traffic_capture_names});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_traffic_capture_url_path_prefixes(string [] profile_names,string [] [] traffic_capture_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_traffic_capture_url_path_prefixes", new object[] {
			profile_names,
			traffic_capture_names}, callback, asyncState);
	}
	public string [] [] [] Endget_traffic_capture_url_path_prefixes(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_traffic_capture_user_agent_substrings
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_traffic_capture_user_agent_substrings(
		string [] profile_names,
		string [] [] traffic_capture_names
	) {
		object [] results = this.Invoke("get_traffic_capture_user_agent_substrings", new object [] {
				profile_names,
				traffic_capture_names});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_traffic_capture_user_agent_substrings(string [] profile_names,string [] [] traffic_capture_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_traffic_capture_user_agent_substrings", new object[] {
			profile_names,
			traffic_capture_names}, callback, asyncState);
	}
	public string [] [] [] Endget_traffic_capture_user_agent_substrings(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_traffic_capture_virtual_servers
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_traffic_capture_virtual_servers(
		string [] profile_names,
		string [] [] traffic_capture_names
	) {
		object [] results = this.Invoke("get_traffic_capture_virtual_servers", new object [] {
				profile_names,
				traffic_capture_names});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_traffic_capture_virtual_servers(string [] profile_names,string [] [] traffic_capture_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_traffic_capture_virtual_servers", new object[] {
			profile_names,
			traffic_capture_names}, callback, asyncState);
	}
	public string [] [] [] Endget_traffic_capture_virtual_servers(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_trust_xff_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_trust_xff_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_trust_xff_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_trust_xff_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_trust_xff_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_trust_xff_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_user_sessions_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileAnalyticsProfileSessionTimeout [] get_user_sessions_timeout(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_user_sessions_timeout", new object [] {
				profile_names});
		return ((LocalLBProfileAnalyticsProfileSessionTimeout [])(results[0]));
	}
	public System.IAsyncResult Beginget_user_sessions_timeout(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_user_sessions_timeout", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileAnalyticsProfileSessionTimeout [] Endget_user_sessions_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileAnalyticsProfileSessionTimeout [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
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
	// remove_alert
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void remove_alert(
		string [] profile_names,
		string [] [] alerts
	) {
		this.Invoke("remove_alert", new object [] {
				profile_names,
				alerts});

	}
	public System.IAsyncResult Beginremove_alert(string [] profile_names,string [] [] alerts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_alert", new object[] {
			profile_names,
			alerts}, callback, asyncState);
	}
	public void Endremove_alert(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_alerts
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void remove_all_alerts(
		string [] profile_names
	) {
		this.Invoke("remove_all_alerts", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginremove_all_alerts(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_alerts", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endremove_all_alerts(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_notification_by_email_addresses
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void remove_all_notification_by_email_addresses(
		string [] profile_names
	) {
		this.Invoke("remove_all_notification_by_email_addresses", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginremove_all_notification_by_email_addresses(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_notification_by_email_addresses", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endremove_all_notification_by_email_addresses(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_subnets
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void remove_all_subnets(
		string [] profile_names
	) {
		this.Invoke("remove_all_subnets", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginremove_all_subnets(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_subnets", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endremove_all_subnets(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_traffic_capture
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void remove_all_traffic_capture(
		string [] profile_names
	) {
		this.Invoke("remove_all_traffic_capture", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginremove_all_traffic_capture(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_traffic_capture", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endremove_all_traffic_capture(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_traffic_capture_client_ips
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void remove_all_traffic_capture_client_ips(
		string [] profile_names,
		string [] [] traffic_capture_names
	) {
		this.Invoke("remove_all_traffic_capture_client_ips", new object [] {
				profile_names,
				traffic_capture_names});

	}
	public System.IAsyncResult Beginremove_all_traffic_capture_client_ips(string [] profile_names,string [] [] traffic_capture_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_traffic_capture_client_ips", new object[] {
			profile_names,
			traffic_capture_names}, callback, asyncState);
	}
	public void Endremove_all_traffic_capture_client_ips(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_traffic_capture_methods
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void remove_all_traffic_capture_methods(
		string [] profile_names,
		string [] [] traffic_capture_names
	) {
		this.Invoke("remove_all_traffic_capture_methods", new object [] {
				profile_names,
				traffic_capture_names});

	}
	public System.IAsyncResult Beginremove_all_traffic_capture_methods(string [] profile_names,string [] [] traffic_capture_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_traffic_capture_methods", new object[] {
			profile_names,
			traffic_capture_names}, callback, asyncState);
	}
	public void Endremove_all_traffic_capture_methods(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_traffic_capture_nodes
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void remove_all_traffic_capture_nodes(
		string [] profile_names,
		string [] [] traffic_capture_names
	) {
		this.Invoke("remove_all_traffic_capture_nodes", new object [] {
				profile_names,
				traffic_capture_names});

	}
	public System.IAsyncResult Beginremove_all_traffic_capture_nodes(string [] profile_names,string [] [] traffic_capture_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_traffic_capture_nodes", new object[] {
			profile_names,
			traffic_capture_names}, callback, asyncState);
	}
	public void Endremove_all_traffic_capture_nodes(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_traffic_capture_response_codes
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void remove_all_traffic_capture_response_codes(
		string [] profile_names,
		string [] [] traffic_capture_names
	) {
		this.Invoke("remove_all_traffic_capture_response_codes", new object [] {
				profile_names,
				traffic_capture_names});

	}
	public System.IAsyncResult Beginremove_all_traffic_capture_response_codes(string [] profile_names,string [] [] traffic_capture_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_traffic_capture_response_codes", new object[] {
			profile_names,
			traffic_capture_names}, callback, asyncState);
	}
	public void Endremove_all_traffic_capture_response_codes(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_traffic_capture_url_path_prefixes
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void remove_all_traffic_capture_url_path_prefixes(
		string [] profile_names,
		string [] [] traffic_capture_names
	) {
		this.Invoke("remove_all_traffic_capture_url_path_prefixes", new object [] {
				profile_names,
				traffic_capture_names});

	}
	public System.IAsyncResult Beginremove_all_traffic_capture_url_path_prefixes(string [] profile_names,string [] [] traffic_capture_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_traffic_capture_url_path_prefixes", new object[] {
			profile_names,
			traffic_capture_names}, callback, asyncState);
	}
	public void Endremove_all_traffic_capture_url_path_prefixes(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_traffic_capture_user_agent_substrings
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void remove_all_traffic_capture_user_agent_substrings(
		string [] profile_names,
		string [] [] traffic_capture_names
	) {
		this.Invoke("remove_all_traffic_capture_user_agent_substrings", new object [] {
				profile_names,
				traffic_capture_names});

	}
	public System.IAsyncResult Beginremove_all_traffic_capture_user_agent_substrings(string [] profile_names,string [] [] traffic_capture_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_traffic_capture_user_agent_substrings", new object[] {
			profile_names,
			traffic_capture_names}, callback, asyncState);
	}
	public void Endremove_all_traffic_capture_user_agent_substrings(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_traffic_capture_virtual_servers
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void remove_all_traffic_capture_virtual_servers(
		string [] profile_names,
		string [] [] traffic_capture_names
	) {
		this.Invoke("remove_all_traffic_capture_virtual_servers", new object [] {
				profile_names,
				traffic_capture_names});

	}
	public System.IAsyncResult Beginremove_all_traffic_capture_virtual_servers(string [] profile_names,string [] [] traffic_capture_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_traffic_capture_virtual_servers", new object[] {
			profile_names,
			traffic_capture_names}, callback, asyncState);
	}
	public void Endremove_all_traffic_capture_virtual_servers(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_notification_by_email_addresses
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void remove_notification_by_email_addresses(
		string [] profile_names,
		string [] [] email_addresses
	) {
		this.Invoke("remove_notification_by_email_addresses", new object [] {
				profile_names,
				email_addresses});

	}
	public System.IAsyncResult Beginremove_notification_by_email_addresses(string [] profile_names,string [] [] email_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_notification_by_email_addresses", new object[] {
			profile_names,
			email_addresses}, callback, asyncState);
	}
	public void Endremove_notification_by_email_addresses(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_subnet
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void remove_subnet(
		string [] profile_names,
		string [] [] subnets
	) {
		this.Invoke("remove_subnet", new object [] {
				profile_names,
				subnets});

	}
	public System.IAsyncResult Beginremove_subnet(string [] profile_names,string [] [] subnets, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_subnet", new object[] {
			profile_names,
			subnets}, callback, asyncState);
	}
	public void Endremove_subnet(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_traffic_capture
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void remove_traffic_capture(
		string [] profile_names,
		string [] [] traffic_capture_names
	) {
		this.Invoke("remove_traffic_capture", new object [] {
				profile_names,
				traffic_capture_names});

	}
	public System.IAsyncResult Beginremove_traffic_capture(string [] profile_names,string [] [] traffic_capture_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_traffic_capture", new object[] {
			profile_names,
			traffic_capture_names}, callback, asyncState);
	}
	public void Endremove_traffic_capture(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_traffic_capture_client_ips
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void remove_traffic_capture_client_ips(
		string [] profile_names,
		string [] [] traffic_capture_names,
		string [] [] [] ip_addresses
	) {
		this.Invoke("remove_traffic_capture_client_ips", new object [] {
				profile_names,
				traffic_capture_names,
				ip_addresses});

	}
	public System.IAsyncResult Beginremove_traffic_capture_client_ips(string [] profile_names,string [] [] traffic_capture_names,string [] [] [] ip_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_traffic_capture_client_ips", new object[] {
			profile_names,
			traffic_capture_names,
			ip_addresses}, callback, asyncState);
	}
	public void Endremove_traffic_capture_client_ips(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_traffic_capture_methods
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void remove_traffic_capture_methods(
		string [] profile_names,
		string [] [] traffic_capture_names,
		string [] [] [] methods
	) {
		this.Invoke("remove_traffic_capture_methods", new object [] {
				profile_names,
				traffic_capture_names,
				methods});

	}
	public System.IAsyncResult Beginremove_traffic_capture_methods(string [] profile_names,string [] [] traffic_capture_names,string [] [] [] methods, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_traffic_capture_methods", new object[] {
			profile_names,
			traffic_capture_names,
			methods}, callback, asyncState);
	}
	public void Endremove_traffic_capture_methods(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_traffic_capture_nodes
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void remove_traffic_capture_nodes(
		string [] profile_names,
		string [] [] traffic_capture_names,
		string [] [] [] nodes
	) {
		this.Invoke("remove_traffic_capture_nodes", new object [] {
				profile_names,
				traffic_capture_names,
				nodes});

	}
	public System.IAsyncResult Beginremove_traffic_capture_nodes(string [] profile_names,string [] [] traffic_capture_names,string [] [] [] nodes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_traffic_capture_nodes", new object[] {
			profile_names,
			traffic_capture_names,
			nodes}, callback, asyncState);
	}
	public void Endremove_traffic_capture_nodes(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_traffic_capture_response_codes
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void remove_traffic_capture_response_codes(
		string [] profile_names,
		string [] [] traffic_capture_names,
		long [] [] [] response_codes
	) {
		this.Invoke("remove_traffic_capture_response_codes", new object [] {
				profile_names,
				traffic_capture_names,
				response_codes});

	}
	public System.IAsyncResult Beginremove_traffic_capture_response_codes(string [] profile_names,string [] [] traffic_capture_names,long [] [] [] response_codes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_traffic_capture_response_codes", new object[] {
			profile_names,
			traffic_capture_names,
			response_codes}, callback, asyncState);
	}
	public void Endremove_traffic_capture_response_codes(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_traffic_capture_url_path_prefixes
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void remove_traffic_capture_url_path_prefixes(
		string [] profile_names,
		string [] [] traffic_capture_names,
		string [] [] [] url_path_prefixes
	) {
		this.Invoke("remove_traffic_capture_url_path_prefixes", new object [] {
				profile_names,
				traffic_capture_names,
				url_path_prefixes});

	}
	public System.IAsyncResult Beginremove_traffic_capture_url_path_prefixes(string [] profile_names,string [] [] traffic_capture_names,string [] [] [] url_path_prefixes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_traffic_capture_url_path_prefixes", new object[] {
			profile_names,
			traffic_capture_names,
			url_path_prefixes}, callback, asyncState);
	}
	public void Endremove_traffic_capture_url_path_prefixes(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_traffic_capture_user_agent_substrings
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void remove_traffic_capture_user_agent_substrings(
		string [] profile_names,
		string [] [] traffic_capture_names,
		string [] [] [] user_agent_substrings
	) {
		this.Invoke("remove_traffic_capture_user_agent_substrings", new object [] {
				profile_names,
				traffic_capture_names,
				user_agent_substrings});

	}
	public System.IAsyncResult Beginremove_traffic_capture_user_agent_substrings(string [] profile_names,string [] [] traffic_capture_names,string [] [] [] user_agent_substrings, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_traffic_capture_user_agent_substrings", new object[] {
			profile_names,
			traffic_capture_names,
			user_agent_substrings}, callback, asyncState);
	}
	public void Endremove_traffic_capture_user_agent_substrings(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_traffic_capture_virtual_servers
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void remove_traffic_capture_virtual_servers(
		string [] profile_names,
		string [] [] traffic_capture_names,
		string [] [] [] virtual_server_names
	) {
		this.Invoke("remove_traffic_capture_virtual_servers", new object [] {
				profile_names,
				traffic_capture_names,
				virtual_server_names});

	}
	public System.IAsyncResult Beginremove_traffic_capture_virtual_servers(string [] profile_names,string [] [] traffic_capture_names,string [] [] [] virtual_server_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_traffic_capture_virtual_servers", new object[] {
			profile_names,
			traffic_capture_names,
			virtual_server_names}, callback, asyncState);
	}
	public void Endremove_traffic_capture_virtual_servers(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_alert_granularity
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_alert_granularity(
		string [] profile_names,
		string [] [] alerts,
		LocalLBProfileAnalyticsAnalyticsAlertGranularity [] [] granularities
	) {
		this.Invoke("set_alert_granularity", new object [] {
				profile_names,
				alerts,
				granularities});

	}
	public System.IAsyncResult Beginset_alert_granularity(string [] profile_names,string [] [] alerts,LocalLBProfileAnalyticsAnalyticsAlertGranularity [] [] granularities, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_alert_granularity", new object[] {
			profile_names,
			alerts,
			granularities}, callback, asyncState);
	}
	public void Endset_alert_granularity(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_alert_metric
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_alert_metric(
		string [] profile_names,
		string [] [] alerts,
		LocalLBProfileAnalyticsAnalyticsAlertMetric [] [] metrics
	) {
		this.Invoke("set_alert_metric", new object [] {
				profile_names,
				alerts,
				metrics});

	}
	public System.IAsyncResult Beginset_alert_metric(string [] profile_names,string [] [] alerts,LocalLBProfileAnalyticsAnalyticsAlertMetric [] [] metrics, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_alert_metric", new object[] {
			profile_names,
			alerts,
			metrics}, callback, asyncState);
	}
	public void Endset_alert_metric(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_alert_sample_period
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_alert_sample_period(
		string [] profile_names,
		string [] [] alerts,
		long [] [] values
	) {
		this.Invoke("set_alert_sample_period", new object [] {
				profile_names,
				alerts,
				values});

	}
	public System.IAsyncResult Beginset_alert_sample_period(string [] profile_names,string [] [] alerts,long [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_alert_sample_period", new object[] {
			profile_names,
			alerts,
			values}, callback, asyncState);
	}
	public void Endset_alert_sample_period(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_alert_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_alert_threshold(
		string [] profile_names,
		string [] [] alerts,
		long [] [] values
	) {
		this.Invoke("set_alert_threshold", new object [] {
				profile_names,
				alerts,
				values});

	}
	public System.IAsyncResult Beginset_alert_threshold(string [] profile_names,string [] [] alerts,long [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_alert_threshold", new object[] {
			profile_names,
			alerts,
			values}, callback, asyncState);
	}
	public void Endset_alert_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_alert_threshold_relation
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_alert_threshold_relation(
		string [] profile_names,
		string [] [] alerts,
		LocalLBProfileAnalyticsAnalyticsAlertThresholdRelation [] [] relations
	) {
		this.Invoke("set_alert_threshold_relation", new object [] {
				profile_names,
				alerts,
				relations});

	}
	public System.IAsyncResult Beginset_alert_threshold_relation(string [] profile_names,string [] [] alerts,LocalLBProfileAnalyticsAnalyticsAlertThresholdRelation [] [] relations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_alert_threshold_relation", new object[] {
			profile_names,
			alerts,
			relations}, callback, asyncState);
	}
	public void Endset_alert_threshold_relation(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_captured_protocol
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_captured_protocol(
		string [] profile_names,
		string [] [] traffic_capture_names,
		LocalLBProfileAnalyticsCapturedProtocol [] [] captured_protocols
	) {
		this.Invoke("set_captured_protocol", new object [] {
				profile_names,
				traffic_capture_names,
				captured_protocols});

	}
	public System.IAsyncResult Beginset_captured_protocol(string [] profile_names,string [] [] traffic_capture_names,LocalLBProfileAnalyticsCapturedProtocol [] [] captured_protocols, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_captured_protocol", new object[] {
			profile_names,
			traffic_capture_names,
			captured_protocols}, callback, asyncState);
	}
	public void Endset_captured_protocol(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_captured_traffic_external_logging_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_captured_traffic_external_logging_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_captured_traffic_external_logging_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_captured_traffic_external_logging_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_captured_traffic_external_logging_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_captured_traffic_external_logging_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_captured_traffic_internal_logging_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_captured_traffic_internal_logging_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_captured_traffic_internal_logging_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_captured_traffic_internal_logging_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_captured_traffic_internal_logging_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_captured_traffic_internal_logging_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_collect_client_ip_addresses_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_collect_client_ip_addresses_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_collect_client_ip_addresses_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_collect_client_ip_addresses_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_collect_client_ip_addresses_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_collect_client_ip_addresses_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_collect_countries_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_collect_countries_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_collect_countries_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_collect_countries_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_collect_countries_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_collect_countries_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_collect_http_throughput_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_collect_http_throughput_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_collect_http_throughput_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_collect_http_throughput_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_collect_http_throughput_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_collect_http_throughput_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_collect_maximum_tps_and_throughput_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_collect_maximum_tps_and_throughput_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_collect_maximum_tps_and_throughput_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_collect_maximum_tps_and_throughput_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_collect_maximum_tps_and_throughput_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_collect_maximum_tps_and_throughput_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_collect_methods_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_collect_methods_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_collect_methods_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_collect_methods_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_collect_methods_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_collect_methods_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_collect_page_load_time_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_collect_page_load_time_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_collect_page_load_time_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_collect_page_load_time_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_collect_page_load_time_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_collect_page_load_time_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_collect_response_codes_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_collect_response_codes_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_collect_response_codes_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_collect_response_codes_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_collect_response_codes_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_collect_response_codes_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_collect_server_latency_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_collect_server_latency_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_collect_server_latency_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_collect_server_latency_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_collect_server_latency_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_collect_server_latency_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_collect_subnets_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_collect_subnets_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_collect_subnets_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_collect_subnets_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_collect_subnets_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_collect_subnets_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_collect_url_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_collect_url_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_collect_url_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_collect_url_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_collect_url_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_collect_url_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_collect_user_agents_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_collect_user_agents_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_collect_user_agents_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_collect_user_agents_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_collect_user_agents_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_collect_user_agents_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_collect_user_sessions_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_collect_user_sessions_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_collect_user_sessions_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_collect_user_sessions_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_collect_user_sessions_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_collect_user_sessions_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_collected_stats_external_logging_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_collected_stats_external_logging_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_collected_stats_external_logging_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_collected_stats_external_logging_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_collected_stats_external_logging_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_collected_stats_external_logging_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_collected_stats_internal_logging_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_collected_stats_internal_logging_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_collected_stats_internal_logging_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_collected_stats_internal_logging_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_collected_stats_internal_logging_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_collected_stats_internal_logging_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_notification_by_email_addresses
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_default_notification_by_email_addresses(
		string [] profile_names
	) {
		this.Invoke("set_default_notification_by_email_addresses", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginset_default_notification_by_email_addresses(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_notification_by_email_addresses", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endset_default_notification_by_email_addresses(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
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
	// set_external_logging_publisher
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_external_logging_publisher(
		string [] profile_names,
		LocalLBProfileString [] publishers
	) {
		this.Invoke("set_external_logging_publisher", new object [] {
				profile_names,
				publishers});

	}
	public System.IAsyncResult Beginset_external_logging_publisher(string [] profile_names,LocalLBProfileString [] publishers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_external_logging_publisher", new object[] {
			profile_names,
			publishers}, callback, asyncState);
	}
	public void Endset_external_logging_publisher(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_notification_by_email_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_notification_by_email_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_notification_by_email_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_notification_by_email_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_notification_by_email_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_notification_by_email_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_notification_by_snmp_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_notification_by_snmp_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_notification_by_snmp_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_notification_by_snmp_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_notification_by_snmp_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_notification_by_snmp_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_notification_by_syslog_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_notification_by_syslog_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_notification_by_syslog_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_notification_by_syslog_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_notification_by_syslog_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_notification_by_syslog_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_publish_irule_statistics_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_publish_irule_statistics_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_publish_irule_statistics_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_publish_irule_statistics_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_publish_irule_statistics_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_publish_irule_statistics_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_remote_server_ip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_remote_server_ip(
		string [] profile_names,
		LocalLBProfileIPAddress [] addresses
	) {
		this.Invoke("set_remote_server_ip", new object [] {
				profile_names,
				addresses});

	}
	public System.IAsyncResult Beginset_remote_server_ip(string [] profile_names,LocalLBProfileIPAddress [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_remote_server_ip", new object[] {
			profile_names,
			addresses}, callback, asyncState);
	}
	public void Endset_remote_server_ip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_remote_server_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_remote_server_port(
		string [] profile_names,
		LocalLBProfilePortNumber [] ports
	) {
		this.Invoke("set_remote_server_port", new object [] {
				profile_names,
				ports});

	}
	public System.IAsyncResult Beginset_remote_server_port(string [] profile_names,LocalLBProfilePortNumber [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_remote_server_port", new object[] {
			profile_names,
			ports}, callback, asyncState);
	}
	public void Endset_remote_server_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_remote_server_syslog_facility
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_remote_server_syslog_facility(
		string [] profile_names,
		LocalLBProfileAnalyticsProfileLoggingFacility [] facilities
	) {
		this.Invoke("set_remote_server_syslog_facility", new object [] {
				profile_names,
				facilities});

	}
	public System.IAsyncResult Beginset_remote_server_syslog_facility(string [] profile_names,LocalLBProfileAnalyticsProfileLoggingFacility [] facilities, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_remote_server_syslog_facility", new object[] {
			profile_names,
			facilities}, callback, asyncState);
	}
	public void Endset_remote_server_syslog_facility(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_request_captured_parts
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_request_captured_parts(
		string [] profile_names,
		string [] [] traffic_capture_names,
		LocalLBProfileAnalyticsTransactionPart [] [] transaction_parts
	) {
		this.Invoke("set_request_captured_parts", new object [] {
				profile_names,
				traffic_capture_names,
				transaction_parts});

	}
	public System.IAsyncResult Beginset_request_captured_parts(string [] profile_names,string [] [] traffic_capture_names,LocalLBProfileAnalyticsTransactionPart [] [] transaction_parts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_request_captured_parts", new object[] {
			profile_names,
			traffic_capture_names,
			transaction_parts}, callback, asyncState);
	}
	public void Endset_request_captured_parts(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_request_content_filter_search_part
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_request_content_filter_search_part(
		string [] profile_names,
		string [] [] traffic_capture_names,
		LocalLBProfileAnalyticsTransactionPart [] [] transaction_parts
	) {
		this.Invoke("set_request_content_filter_search_part", new object [] {
				profile_names,
				traffic_capture_names,
				transaction_parts});

	}
	public System.IAsyncResult Beginset_request_content_filter_search_part(string [] profile_names,string [] [] traffic_capture_names,LocalLBProfileAnalyticsTransactionPart [] [] transaction_parts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_request_content_filter_search_part", new object[] {
			profile_names,
			traffic_capture_names,
			transaction_parts}, callback, asyncState);
	}
	public void Endset_request_content_filter_search_part(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_request_content_filter_search_string
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_request_content_filter_search_string(
		string [] profile_names,
		string [] [] traffic_capture_names,
		string [] [] filter_strings
	) {
		this.Invoke("set_request_content_filter_search_string", new object [] {
				profile_names,
				traffic_capture_names,
				filter_strings});

	}
	public System.IAsyncResult Beginset_request_content_filter_search_string(string [] profile_names,string [] [] traffic_capture_names,string [] [] filter_strings, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_request_content_filter_search_string", new object[] {
			profile_names,
			traffic_capture_names,
			filter_strings}, callback, asyncState);
	}
	public void Endset_request_content_filter_search_string(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_response_captured_parts
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_response_captured_parts(
		string [] profile_names,
		string [] [] traffic_capture_names,
		LocalLBProfileAnalyticsTransactionPart [] [] transaction_parts
	) {
		this.Invoke("set_response_captured_parts", new object [] {
				profile_names,
				traffic_capture_names,
				transaction_parts});

	}
	public System.IAsyncResult Beginset_response_captured_parts(string [] profile_names,string [] [] traffic_capture_names,LocalLBProfileAnalyticsTransactionPart [] [] transaction_parts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_response_captured_parts", new object[] {
			profile_names,
			traffic_capture_names,
			transaction_parts}, callback, asyncState);
	}
	public void Endset_response_captured_parts(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_response_content_filter_search_part
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_response_content_filter_search_part(
		string [] profile_names,
		string [] [] traffic_capture_names,
		LocalLBProfileAnalyticsTransactionPart [] [] transaction_parts
	) {
		this.Invoke("set_response_content_filter_search_part", new object [] {
				profile_names,
				traffic_capture_names,
				transaction_parts});

	}
	public System.IAsyncResult Beginset_response_content_filter_search_part(string [] profile_names,string [] [] traffic_capture_names,LocalLBProfileAnalyticsTransactionPart [] [] transaction_parts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_response_content_filter_search_part", new object[] {
			profile_names,
			traffic_capture_names,
			transaction_parts}, callback, asyncState);
	}
	public void Endset_response_content_filter_search_part(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_response_content_filter_search_string
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_response_content_filter_search_string(
		string [] profile_names,
		string [] [] traffic_capture_names,
		string [] [] filter_strings
	) {
		this.Invoke("set_response_content_filter_search_string", new object [] {
				profile_names,
				traffic_capture_names,
				filter_strings});

	}
	public System.IAsyncResult Beginset_response_content_filter_search_string(string [] profile_names,string [] [] traffic_capture_names,string [] [] filter_strings, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_response_content_filter_search_string", new object[] {
			profile_names,
			traffic_capture_names,
			filter_strings}, callback, asyncState);
	}
	public void Endset_response_content_filter_search_string(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_sampling_ratio
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_sampling_ratio(
		string [] profile_names,
		LocalLBProfileULong [] ratios
	) {
		this.Invoke("set_sampling_ratio", new object [] {
				profile_names,
				ratios});

	}
	public System.IAsyncResult Beginset_sampling_ratio(string [] profile_names,LocalLBProfileULong [] ratios, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_sampling_ratio", new object[] {
			profile_names,
			ratios}, callback, asyncState);
	}
	public void Endset_sampling_ratio(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_sampling_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_sampling_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_sampling_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_sampling_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_sampling_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_sampling_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_session_cookie_security_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_session_cookie_security_mode(
		string [] profile_names,
		LocalLBProfileAnalyticsProfileSessionCookieSecurityMode [] modes
	) {
		this.Invoke("set_session_cookie_security_mode", new object [] {
				profile_names,
				modes});

	}
	public System.IAsyncResult Beginset_session_cookie_security_mode(string [] profile_names,LocalLBProfileAnalyticsProfileSessionCookieSecurityMode [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_session_cookie_security_mode", new object[] {
			profile_names,
			modes}, callback, asyncState);
	}
	public void Endset_session_cookie_security_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_smtp_configuration
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_smtp_configuration(
		string [] profile_names,
		LocalLBProfileString [] configs
	) {
		this.Invoke("set_smtp_configuration", new object [] {
				profile_names,
				configs});

	}
	public System.IAsyncResult Beginset_smtp_configuration(string [] profile_names,LocalLBProfileString [] configs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_smtp_configuration", new object[] {
			profile_names,
			configs}, callback, asyncState);
	}
	public void Endset_smtp_configuration(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_subnet_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_subnet_address(
		string [] profile_names,
		string [] [] subnets,
		string [] [] addresses
	) {
		this.Invoke("set_subnet_address", new object [] {
				profile_names,
				subnets,
				addresses});

	}
	public System.IAsyncResult Beginset_subnet_address(string [] profile_names,string [] [] subnets,string [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_subnet_address", new object[] {
			profile_names,
			subnets,
			addresses}, callback, asyncState);
	}
	public void Endset_subnet_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_traffic_capture_client_ips
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_traffic_capture_client_ips(
		string [] profile_names,
		string [] [] traffic_capture_names,
		string [] [] [] ip_addresses
	) {
		this.Invoke("set_traffic_capture_client_ips", new object [] {
				profile_names,
				traffic_capture_names,
				ip_addresses});

	}
	public System.IAsyncResult Beginset_traffic_capture_client_ips(string [] profile_names,string [] [] traffic_capture_names,string [] [] [] ip_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_traffic_capture_client_ips", new object[] {
			profile_names,
			traffic_capture_names,
			ip_addresses}, callback, asyncState);
	}
	public void Endset_traffic_capture_client_ips(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_traffic_capture_methods
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_traffic_capture_methods(
		string [] profile_names,
		string [] [] traffic_capture_names,
		string [] [] [] methods
	) {
		this.Invoke("set_traffic_capture_methods", new object [] {
				profile_names,
				traffic_capture_names,
				methods});

	}
	public System.IAsyncResult Beginset_traffic_capture_methods(string [] profile_names,string [] [] traffic_capture_names,string [] [] [] methods, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_traffic_capture_methods", new object[] {
			profile_names,
			traffic_capture_names,
			methods}, callback, asyncState);
	}
	public void Endset_traffic_capture_methods(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_traffic_capture_response_codes
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_traffic_capture_response_codes(
		string [] profile_names,
		string [] [] traffic_capture_names,
		long [] [] [] response_codes
	) {
		this.Invoke("set_traffic_capture_response_codes", new object [] {
				profile_names,
				traffic_capture_names,
				response_codes});

	}
	public System.IAsyncResult Beginset_traffic_capture_response_codes(string [] profile_names,string [] [] traffic_capture_names,long [] [] [] response_codes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_traffic_capture_response_codes", new object[] {
			profile_names,
			traffic_capture_names,
			response_codes}, callback, asyncState);
	}
	public void Endset_traffic_capture_response_codes(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_traffic_capture_url_path_prefixes
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_traffic_capture_url_path_prefixes(
		string [] profile_names,
		string [] [] traffic_capture_names,
		string [] [] [] url_path_prefixes
	) {
		this.Invoke("set_traffic_capture_url_path_prefixes", new object [] {
				profile_names,
				traffic_capture_names,
				url_path_prefixes});

	}
	public System.IAsyncResult Beginset_traffic_capture_url_path_prefixes(string [] profile_names,string [] [] traffic_capture_names,string [] [] [] url_path_prefixes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_traffic_capture_url_path_prefixes", new object[] {
			profile_names,
			traffic_capture_names,
			url_path_prefixes}, callback, asyncState);
	}
	public void Endset_traffic_capture_url_path_prefixes(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_traffic_capture_user_agent_substrings
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_traffic_capture_user_agent_substrings(
		string [] profile_names,
		string [] [] traffic_capture_names,
		string [] [] [] user_agent_substrings
	) {
		this.Invoke("set_traffic_capture_user_agent_substrings", new object [] {
				profile_names,
				traffic_capture_names,
				user_agent_substrings});

	}
	public System.IAsyncResult Beginset_traffic_capture_user_agent_substrings(string [] profile_names,string [] [] traffic_capture_names,string [] [] [] user_agent_substrings, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_traffic_capture_user_agent_substrings", new object[] {
			profile_names,
			traffic_capture_names,
			user_agent_substrings}, callback, asyncState);
	}
	public void Endset_traffic_capture_user_agent_substrings(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_trust_xff_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_trust_xff_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_trust_xff_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_trust_xff_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_trust_xff_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_trust_xff_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_user_sessions_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileAnalytics")]
	public void set_user_sessions_timeout(
		string [] profile_names,
		LocalLBProfileAnalyticsProfileSessionTimeout [] timeouts
	) {
		this.Invoke("set_user_sessions_timeout", new object [] {
				profile_names,
				timeouts});

	}
	public System.IAsyncResult Beginset_user_sessions_timeout(string [] profile_names,LocalLBProfileAnalyticsProfileSessionTimeout [] timeouts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_user_sessions_timeout", new object[] {
			profile_names,
			timeouts}, callback, asyncState);
	}
	public void Endset_user_sessions_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileAnalytics.AnalyticsAlertGranularity", Namespace = "urn:iControl")]
	public enum LocalLBProfileAnalyticsAnalyticsAlertGranularity
	{
		ANALYTICS_ALERT_GRANULARITY_UNKNOWN,
		ANALYTICS_ALERT_GRANULARITY_APPLICATION,
		ANALYTICS_ALERT_GRANULARITY_VS,
		ANALYTICS_ALERT_GRANULARITY_MEMBER,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileAnalytics.AnalyticsAlertMetric", Namespace = "urn:iControl")]
	public enum LocalLBProfileAnalyticsAnalyticsAlertMetric
	{
		ANALYTICS_ALERT_METRIC_UNKNOWN,
		ANALYTICS_ALERT_METRIC_AVG_TPS,
		ANALYTICS_ALERT_METRIC_MAX_TPS,
		ANALYTICS_ALERT_METRIC_AVG_SERVER_LAT,
		ANALYTICS_ALERT_METRIC_AVG_CLIENT_LAT,
		ANALYTICS_ALERT_METRIC_MAX_SERVER_LAT,
		ANALYTICS_ALERT_METRIC_MAX_CLIENT_LAT,
		ANALYTICS_ALERT_METRIC_AVG_REQUEST_THROUGHPUT,
		ANALYTICS_ALERT_METRIC_AVG_RESPONSE_THROUGHPUT,
		ANALYTICS_ALERT_METRIC_MAX_REQUEST_THROUGHPUT,
		ANALYTICS_ALERT_METRIC_MAX_RESPONSE_THROUGHPUT,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileAnalytics.AnalyticsAlertThresholdRelation", Namespace = "urn:iControl")]
	public enum LocalLBProfileAnalyticsAnalyticsAlertThresholdRelation
	{
		ANALYTICS_ALERT_THRESHOLD_RELATION_UNKNOWN,
		ANALYTICS_ALERT_THRESHOLD_RELATION_BELOW,
		ANALYTICS_ALERT_THRESHOLD_RELATION_ABOVE,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileAnalytics.CapturedProtocol", Namespace = "urn:iControl")]
	public enum LocalLBProfileAnalyticsCapturedProtocol
	{
		CAPTURED_PROTOCOL_UNKNOWN,
		CAPTURED_PROTOCOL_HTTP,
		CAPTURED_PROTOCOL_HTTPS,
		CAPTURED_PROTOCOL_ALL,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileAnalytics.LoggingFacility", Namespace = "urn:iControl")]
	public enum LocalLBProfileAnalyticsLoggingFacility
	{
		UNKNOWN,
		LOCAL0,
		LOCAL1,
		LOCAL2,
		LOCAL3,
		LOCAL4,
		LOCAL5,
		LOCAL6,
		LOCAL7,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileAnalytics.SessionCookieSecurityMode", Namespace = "urn:iControl")]
	public enum LocalLBProfileAnalyticsSessionCookieSecurityMode
	{
		SESSION_COOKIE_SECURITY_MODE_UNKNOWN,
		SESSION_COOKIE_SECURITY_MODE_ALWAYS,
		SESSION_COOKIE_SECURITY_MODE_NEVER,
		SESSION_COOKIE_SECURITY_MODE_SSL_ONLY,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileAnalytics.SessionTimeout", Namespace = "urn:iControl")]
	public enum LocalLBProfileAnalyticsSessionTimeout
	{
		SESSION_TIMEOUT_UNKNOWN,
		SESSION_TIMEOUT_5_MIN,
		SESSION_TIMEOUT_10_MIN,
		SESSION_TIMEOUT_15_MIN,
		SESSION_TIMEOUT_20_MIN,
		SESSION_TIMEOUT_25_MIN,
		SESSION_TIMEOUT_30_MIN,
		SESSION_TIMEOUT_35_MIN,
		SESSION_TIMEOUT_40_MIN,
		SESSION_TIMEOUT_45_MIN,
		SESSION_TIMEOUT_50_MIN,
		SESSION_TIMEOUT_55_MIN,
		SESSION_TIMEOUT_60_MIN,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileAnalytics.TransactionPart", Namespace = "urn:iControl")]
	public enum LocalLBProfileAnalyticsTransactionPart
	{
		TRANSACTION_PART_UNKNOWN,
		TRANSACTION_PART_NONE,
		TRANSACTION_PART_HEADERS,
		TRANSACTION_PART_BODY,
		TRANSACTION_PART_REQUEST,
		TRANSACTION_PART_URI,
		TRANSACTION_PART_ALL,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileAnalytics.ProfileLoggingFacility", Namespace = "urn:iControl")]
	public partial class LocalLBProfileAnalyticsProfileLoggingFacility
	{
		private LocalLBProfileAnalyticsLoggingFacility valueField;
		public LocalLBProfileAnalyticsLoggingFacility value
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileAnalytics.ProfileSessionCookieSecurityMode", Namespace = "urn:iControl")]
	public partial class LocalLBProfileAnalyticsProfileSessionCookieSecurityMode
	{
		private LocalLBProfileAnalyticsSessionCookieSecurityMode valueField;
		public LocalLBProfileAnalyticsSessionCookieSecurityMode value
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileAnalytics.ProfileSessionTimeout", Namespace = "urn:iControl")]
	public partial class LocalLBProfileAnalyticsProfileSessionTimeout
	{
		private LocalLBProfileAnalyticsSessionTimeout valueField;
		public LocalLBProfileAnalyticsSessionTimeout value
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
