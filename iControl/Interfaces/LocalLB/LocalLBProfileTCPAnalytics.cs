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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.ProfileTCPAnalyticsBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileEnabledState))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileString))]
	public partial class LocalLBProfileTCPAnalytics : iControlInterface {
		public LocalLBProfileTCPAnalytics() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCPAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCPAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCPAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics")]
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
	// get_collect_by_city_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCPAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_collect_by_city_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_collect_by_city_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_collect_by_city_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_collect_by_city_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_collect_by_city_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_collect_by_continent_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCPAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_collect_by_continent_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_collect_by_continent_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_collect_by_continent_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_collect_by_continent_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_collect_by_continent_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_collect_by_country_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCPAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_collect_by_country_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_collect_by_country_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_collect_by_country_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_collect_by_country_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_collect_by_country_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_collect_by_nexthop_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCPAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_collect_by_nexthop_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_collect_by_nexthop_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_collect_by_nexthop_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_collect_by_nexthop_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_collect_by_nexthop_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_collect_by_post_code_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCPAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_collect_by_post_code_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_collect_by_post_code_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_collect_by_post_code_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_collect_by_post_code_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_collect_by_post_code_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_collect_by_region_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCPAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_collect_by_region_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_collect_by_region_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_collect_by_region_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_collect_by_region_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_collect_by_region_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_collect_by_remote_host_ip_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCPAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_collect_by_remote_host_ip_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_collect_by_remote_host_ip_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_collect_by_remote_host_ip_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_collect_by_remote_host_ip_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_collect_by_remote_host_ip_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_collect_by_remote_host_subnet_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCPAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_collect_by_remote_host_subnet_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_collect_by_remote_host_subnet_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_collect_by_remote_host_subnet_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_collect_by_remote_host_subnet_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_collect_by_remote_host_subnet_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_collected_by_client_side_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCPAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_collected_by_client_side_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_collected_by_client_side_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_collected_by_client_side_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_collected_by_client_side_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_collected_by_client_side_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_collected_by_server_side_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCPAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_collected_by_server_side_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_collected_by_server_side_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_collected_by_server_side_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_collected_by_server_side_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_collected_by_server_side_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_collected_stats_external_logging_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCPAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCPAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCPAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCPAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCPAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics")]
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
	// get_log_publisher
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCPAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics")]
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
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCPAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCPAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCPAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics")]
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
	// set_collect_by_city_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCPAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics")]
	public void set_collect_by_city_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_collect_by_city_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_collect_by_city_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_collect_by_city_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_collect_by_city_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_collect_by_continent_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCPAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics")]
	public void set_collect_by_continent_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_collect_by_continent_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_collect_by_continent_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_collect_by_continent_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_collect_by_continent_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_collect_by_country_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCPAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics")]
	public void set_collect_by_country_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_collect_by_country_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_collect_by_country_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_collect_by_country_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_collect_by_country_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_collect_by_nexthop_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCPAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics")]
	public void set_collect_by_nexthop_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_collect_by_nexthop_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_collect_by_nexthop_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_collect_by_nexthop_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_collect_by_nexthop_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_collect_by_post_code_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCPAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics")]
	public void set_collect_by_post_code_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_collect_by_post_code_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_collect_by_post_code_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_collect_by_post_code_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_collect_by_post_code_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_collect_by_region_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCPAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics")]
	public void set_collect_by_region_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_collect_by_region_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_collect_by_region_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_collect_by_region_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_collect_by_region_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_collect_by_remote_host_ip_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCPAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics")]
	public void set_collect_by_remote_host_ip_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_collect_by_remote_host_ip_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_collect_by_remote_host_ip_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_collect_by_remote_host_ip_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_collect_by_remote_host_ip_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_collect_by_remote_host_subnet_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCPAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics")]
	public void set_collect_by_remote_host_subnet_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_collect_by_remote_host_subnet_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_collect_by_remote_host_subnet_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_collect_by_remote_host_subnet_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_collect_by_remote_host_subnet_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_collected_by_client_side_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCPAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics")]
	public void set_collected_by_client_side_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_collected_by_client_side_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_collected_by_client_side_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_collected_by_client_side_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_collected_by_client_side_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_collected_by_server_side_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCPAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics")]
	public void set_collected_by_server_side_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_collected_by_server_side_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_collected_by_server_side_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_collected_by_server_side_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_collected_by_server_side_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_collected_stats_external_logging_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCPAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCPAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics")]
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
	// set_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCPAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCPAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics")]
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
	// set_log_publisher
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCPAnalytics", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics", ResponseNamespace="urn:iControl:LocalLB/ProfileTCPAnalytics")]
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

	}
	//=======================================================================
	// Enums
	//=======================================================================

	//=======================================================================
	// Structs
	//=======================================================================

}
