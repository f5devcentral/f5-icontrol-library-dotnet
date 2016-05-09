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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.ProfileTCPBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileEnabledState))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileTCPProfileTCPStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileULong))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileTCPCongestionControlMode))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileString))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileTCPProfileTCPMode))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileStatisticsByVirtual))]
	public partial class LocalLBProfileTCP : iControlInterface {
		public LocalLBProfileTCP() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
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
	// get_ack_on_push_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_ack_on_push_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_ack_on_push_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_ack_on_push_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ack_on_push_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_ack_on_push_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileTCPProfileTCPStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((LocalLBProfileTCPProfileTCPStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public LocalLBProfileTCPProfileTCPStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileTCPProfileTCPStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_appropriate_byte_counting_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_appropriate_byte_counting_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_appropriate_byte_counting_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_appropriate_byte_counting_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_appropriate_byte_counting_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_appropriate_byte_counting_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_bandwidth_delay_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_bandwidth_delay_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_bandwidth_delay_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_bandwidth_delay_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_bandwidth_delay_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_bandwidth_delay_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_close_wait_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_close_wait_timeout(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_close_wait_timeout", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_close_wait_timeout(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_close_wait_timeout", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_close_wait_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cmetrics_cache_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_cmetrics_cache_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_cmetrics_cache_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_cmetrics_cache_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cmetrics_cache_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_cmetrics_cache_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cmetrics_cache_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_cmetrics_cache_timeout(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_cmetrics_cache_timeout", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_cmetrics_cache_timeout(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cmetrics_cache_timeout", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_cmetrics_cache_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_congestion_control_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileTCPCongestionControlMode [] get_congestion_control_mode(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_congestion_control_mode", new object [] {
				profile_names});
		return ((LocalLBProfileTCPCongestionControlMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_congestion_control_mode(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_congestion_control_mode", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileTCPCongestionControlMode [] Endget_congestion_control_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileTCPCongestionControlMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
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
	// get_deferred_accept_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_deferred_accept_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_deferred_accept_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_deferred_accept_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_deferred_accept_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_deferred_accept_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_delay_window_control_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_delay_window_control_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_delay_window_control_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_delay_window_control_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_delay_window_control_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_delay_window_control_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_delayed_ack_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_delayed_ack_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_delayed_ack_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_delayed_ack_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_delayed_ack_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_delayed_ack_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
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
	// get_duplicate_selective_ack_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_duplicate_selective_ack_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_duplicate_selective_ack_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_duplicate_selective_ack_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_duplicate_selective_ack_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_duplicate_selective_ack_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_early_retransmit_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_early_retransmit_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_early_retransmit_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_early_retransmit_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_early_retransmit_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_early_retransmit_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ecn_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_ecn_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_ecn_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_ecn_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ecn_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_ecn_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fast_open_cookie_expiration
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_fast_open_cookie_expiration(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_fast_open_cookie_expiration", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_fast_open_cookie_expiration(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fast_open_cookie_expiration", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_fast_open_cookie_expiration(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fast_open_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_fast_open_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_fast_open_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_fast_open_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fast_open_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_fast_open_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fin_wait_2_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_fin_wait_2_timeout(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_fin_wait_2_timeout", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_fin_wait_2_timeout(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fin_wait_2_timeout", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_fin_wait_2_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fin_wait_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_fin_wait_timeout(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_fin_wait_timeout", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_fin_wait_timeout(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fin_wait_timeout", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_fin_wait_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_hardware_syn_cookie_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_hardware_syn_cookie_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_hardware_syn_cookie_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_hardware_syn_cookie_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_hardware_syn_cookie_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_hardware_syn_cookie_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_high_performance_tcp_extension_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_high_performance_tcp_extension_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_high_performance_tcp_extension_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_high_performance_tcp_extension_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_high_performance_tcp_extension_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_high_performance_tcp_extension_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_idle_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
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
	// get_initial_congestion_window_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_initial_congestion_window_size(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_initial_congestion_window_size", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_initial_congestion_window_size(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_initial_congestion_window_size", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_initial_congestion_window_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_initial_receive_window_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_initial_receive_window_size(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_initial_receive_window_size", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_initial_receive_window_size(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_initial_receive_window_size", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_initial_receive_window_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_initial_syn_rto_base_multiplier
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_initial_syn_rto_base_multiplier(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_initial_syn_rto_base_multiplier", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_initial_syn_rto_base_multiplier(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_initial_syn_rto_base_multiplier", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_initial_syn_rto_base_multiplier(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ip_tos_to_client
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_ip_tos_to_client(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_ip_tos_to_client", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_ip_tos_to_client(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ip_tos_to_client", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_ip_tos_to_client(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_keep_alive_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_keep_alive_interval(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_keep_alive_interval", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_keep_alive_interval(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_keep_alive_interval", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_keep_alive_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_limited_transmit_recovery_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_limited_transmit_recovery_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_limited_transmit_recovery_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_limited_transmit_recovery_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_limited_transmit_recovery_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_limited_transmit_recovery_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_link_qos_to_client
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_link_qos_to_client(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_link_qos_to_client", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_link_qos_to_client(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_link_qos_to_client", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_link_qos_to_client(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
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
	// get_maximum_data_retransmission
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_maximum_data_retransmission(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_maximum_data_retransmission", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_data_retransmission(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_data_retransmission", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_maximum_data_retransmission(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_maximum_syn_retransmission
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_maximum_syn_retransmission(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_maximum_syn_retransmission", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_syn_retransmission(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_syn_retransmission", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_maximum_syn_retransmission(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_md5_signature_passphrase
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_md5_signature_passphrase(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_md5_signature_passphrase", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_md5_signature_passphrase(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_md5_signature_passphrase", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_md5_signature_passphrase(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_md5_signature_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_md5_signature_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_md5_signature_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_md5_signature_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_md5_signature_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_md5_signature_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_minimum_rto
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_minimum_rto(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_minimum_rto", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_minimum_rto(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_minimum_rto", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_minimum_rto(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_mptcp_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_mptcp_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_mptcp_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_mptcp_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_mptcp_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_mptcp_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_nagle_algorithm_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileTCPProfileTCPMode [] get_nagle_algorithm_mode(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_nagle_algorithm_mode", new object [] {
				profile_names});
		return ((LocalLBProfileTCPProfileTCPMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_nagle_algorithm_mode(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_nagle_algorithm_mode", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileTCPProfileTCPMode [] Endget_nagle_algorithm_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileTCPProfileTCPMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_packet_loss_ignore_burst
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_packet_loss_ignore_burst(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_packet_loss_ignore_burst", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_packet_loss_ignore_burst(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_packet_loss_ignore_burst", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_packet_loss_ignore_burst(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_packet_loss_ignore_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_packet_loss_ignore_rate(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_packet_loss_ignore_rate", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_packet_loss_ignore_rate(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_packet_loss_ignore_rate", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_packet_loss_ignore_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_proxy_buffer_high
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_proxy_buffer_high(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_proxy_buffer_high", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_proxy_buffer_high(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_proxy_buffer_high", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_proxy_buffer_high(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_proxy_buffer_low
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_proxy_buffer_low(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_proxy_buffer_low", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_proxy_buffer_low(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_proxy_buffer_low", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_proxy_buffer_low(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_proxy_mss_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_proxy_mss_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_proxy_mss_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_proxy_mss_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_proxy_mss_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_proxy_mss_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_proxy_option_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_proxy_option_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_proxy_option_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_proxy_option_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_proxy_option_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_proxy_option_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rate_pace_maximum_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_rate_pace_maximum_rate(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_rate_pace_maximum_rate", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_rate_pace_maximum_rate(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rate_pace_maximum_rate", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_rate_pace_maximum_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rate_pace_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_rate_pace_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_rate_pace_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_rate_pace_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rate_pace_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_rate_pace_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_receive_window_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_receive_window_size(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_receive_window_size", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_receive_window_size(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_receive_window_size", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_receive_window_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_reset_on_timeout_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
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
	// get_retransmit_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_retransmit_threshold(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_retransmit_threshold", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_retransmit_threshold(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_retransmit_threshold", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_retransmit_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rfc1323_timestamps_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_rfc1323_timestamps_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_rfc1323_timestamps_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_rfc1323_timestamps_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rfc1323_timestamps_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_rfc1323_timestamps_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_selective_ack_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_selective_ack_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_selective_ack_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_selective_ack_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_selective_ack_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_selective_ack_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_selective_nack_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_selective_nack_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_selective_nack_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_selective_nack_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_selective_nack_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_selective_nack_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_send_buffer_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_send_buffer_size(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_send_buffer_size", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_send_buffer_size(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_send_buffer_size", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_send_buffer_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_slow_start_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_slow_start_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_slow_start_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_slow_start_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_slow_start_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_slow_start_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileTCPProfileTCPStatistics get_statistics(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				profile_names});
		return ((LocalLBProfileTCPProfileTCPStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileTCPProfileTCPStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileTCPProfileTCPStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics_by_virtual
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
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
	// get_tail_loss_probe_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_tail_loss_probe_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_tail_loss_probe_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_tail_loss_probe_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_tail_loss_probe_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_tail_loss_probe_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_tcp_options
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_tcp_options(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_tcp_options", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_tcp_options(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_tcp_options", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_tcp_options(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_time_wait_recycle_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_time_wait_recycle_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_time_wait_recycle_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_time_wait_recycle_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_time_wait_recycle_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_time_wait_recycle_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_time_wait_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_time_wait_timeout(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_time_wait_timeout", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_time_wait_timeout(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_time_wait_timeout", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_time_wait_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_use_nagle_algorithm_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_use_nagle_algorithm_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_use_nagle_algorithm_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_use_nagle_algorithm_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_use_nagle_algorithm_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_use_nagle_algorithm_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_verified_accept_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_verified_accept_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_verified_accept_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_verified_accept_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_verified_accept_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_verified_accept_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
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
	// get_zero_window_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_zero_window_timeout(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_zero_window_timeout", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_zero_window_timeout(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_zero_window_timeout", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_zero_window_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// is_base_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
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
	// set_ack_on_push_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_ack_on_push_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_ack_on_push_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_ack_on_push_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ack_on_push_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_ack_on_push_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_appropriate_byte_counting_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_appropriate_byte_counting_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_appropriate_byte_counting_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_appropriate_byte_counting_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_appropriate_byte_counting_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_appropriate_byte_counting_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_bandwidth_delay_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_bandwidth_delay_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_bandwidth_delay_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_bandwidth_delay_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_bandwidth_delay_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_bandwidth_delay_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_close_wait_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_close_wait_timeout(
		string [] profile_names,
		LocalLBProfileULong [] timeouts
	) {
		this.Invoke("set_close_wait_timeout", new object [] {
				profile_names,
				timeouts});

	}
	public System.IAsyncResult Beginset_close_wait_timeout(string [] profile_names,LocalLBProfileULong [] timeouts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_close_wait_timeout", new object[] {
			profile_names,
			timeouts}, callback, asyncState);
	}
	public void Endset_close_wait_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_cmetrics_cache_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_cmetrics_cache_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_cmetrics_cache_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_cmetrics_cache_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cmetrics_cache_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_cmetrics_cache_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_cmetrics_cache_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_cmetrics_cache_timeout(
		string [] profile_names,
		LocalLBProfileULong [] timeouts
	) {
		this.Invoke("set_cmetrics_cache_timeout", new object [] {
				profile_names,
				timeouts});

	}
	public System.IAsyncResult Beginset_cmetrics_cache_timeout(string [] profile_names,LocalLBProfileULong [] timeouts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cmetrics_cache_timeout", new object[] {
			profile_names,
			timeouts}, callback, asyncState);
	}
	public void Endset_cmetrics_cache_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_congestion_control_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_congestion_control_mode(
		string [] profile_names,
		LocalLBProfileTCPCongestionControlMode [] values
	) {
		this.Invoke("set_congestion_control_mode", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_congestion_control_mode(string [] profile_names,LocalLBProfileTCPCongestionControlMode [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_congestion_control_mode", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_congestion_control_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
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
	// set_deferred_accept_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_deferred_accept_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_deferred_accept_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_deferred_accept_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_deferred_accept_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_deferred_accept_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_delay_window_control_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_delay_window_control_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_delay_window_control_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_delay_window_control_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_delay_window_control_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_delay_window_control_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_delayed_ack_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_delayed_ack_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_delayed_ack_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_delayed_ack_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_delayed_ack_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_delayed_ack_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
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
	// set_duplicate_selective_ack_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_duplicate_selective_ack_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_duplicate_selective_ack_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_duplicate_selective_ack_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_duplicate_selective_ack_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_duplicate_selective_ack_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_early_retransmit_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_early_retransmit_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_early_retransmit_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_early_retransmit_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_early_retransmit_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_early_retransmit_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ecn_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_ecn_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_ecn_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_ecn_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ecn_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_ecn_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fast_open_cookie_expiration
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_fast_open_cookie_expiration(
		string [] profile_names,
		LocalLBProfileULong [] expirations
	) {
		this.Invoke("set_fast_open_cookie_expiration", new object [] {
				profile_names,
				expirations});

	}
	public System.IAsyncResult Beginset_fast_open_cookie_expiration(string [] profile_names,LocalLBProfileULong [] expirations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fast_open_cookie_expiration", new object[] {
			profile_names,
			expirations}, callback, asyncState);
	}
	public void Endset_fast_open_cookie_expiration(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fast_open_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_fast_open_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_fast_open_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_fast_open_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fast_open_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_fast_open_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fin_wait_2_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_fin_wait_2_timeout(
		string [] profile_names,
		LocalLBProfileULong [] timeouts
	) {
		this.Invoke("set_fin_wait_2_timeout", new object [] {
				profile_names,
				timeouts});

	}
	public System.IAsyncResult Beginset_fin_wait_2_timeout(string [] profile_names,LocalLBProfileULong [] timeouts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fin_wait_2_timeout", new object[] {
			profile_names,
			timeouts}, callback, asyncState);
	}
	public void Endset_fin_wait_2_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fin_wait_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_fin_wait_timeout(
		string [] profile_names,
		LocalLBProfileULong [] timeouts
	) {
		this.Invoke("set_fin_wait_timeout", new object [] {
				profile_names,
				timeouts});

	}
	public System.IAsyncResult Beginset_fin_wait_timeout(string [] profile_names,LocalLBProfileULong [] timeouts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fin_wait_timeout", new object[] {
			profile_names,
			timeouts}, callback, asyncState);
	}
	public void Endset_fin_wait_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_hardware_syn_cookie_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_hardware_syn_cookie_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_hardware_syn_cookie_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_hardware_syn_cookie_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_hardware_syn_cookie_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_hardware_syn_cookie_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_high_performance_tcp_extension_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_high_performance_tcp_extension_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_high_performance_tcp_extension_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_high_performance_tcp_extension_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_high_performance_tcp_extension_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_high_performance_tcp_extension_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_idle_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
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
	// set_initial_congestion_window_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_initial_congestion_window_size(
		string [] profile_names,
		LocalLBProfileULong [] sizes
	) {
		this.Invoke("set_initial_congestion_window_size", new object [] {
				profile_names,
				sizes});

	}
	public System.IAsyncResult Beginset_initial_congestion_window_size(string [] profile_names,LocalLBProfileULong [] sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_initial_congestion_window_size", new object[] {
			profile_names,
			sizes}, callback, asyncState);
	}
	public void Endset_initial_congestion_window_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_initial_receive_window_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_initial_receive_window_size(
		string [] profile_names,
		LocalLBProfileULong [] sizes
	) {
		this.Invoke("set_initial_receive_window_size", new object [] {
				profile_names,
				sizes});

	}
	public System.IAsyncResult Beginset_initial_receive_window_size(string [] profile_names,LocalLBProfileULong [] sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_initial_receive_window_size", new object[] {
			profile_names,
			sizes}, callback, asyncState);
	}
	public void Endset_initial_receive_window_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_initial_syn_rto_base_multiplier
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_initial_syn_rto_base_multiplier(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_initial_syn_rto_base_multiplier", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_initial_syn_rto_base_multiplier(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_initial_syn_rto_base_multiplier", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_initial_syn_rto_base_multiplier(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ip_tos_to_client
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_ip_tos_to_client(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_ip_tos_to_client", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_ip_tos_to_client(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ip_tos_to_client", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_ip_tos_to_client(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_keep_alive_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_keep_alive_interval(
		string [] profile_names,
		LocalLBProfileULong [] intervals
	) {
		this.Invoke("set_keep_alive_interval", new object [] {
				profile_names,
				intervals});

	}
	public System.IAsyncResult Beginset_keep_alive_interval(string [] profile_names,LocalLBProfileULong [] intervals, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_keep_alive_interval", new object[] {
			profile_names,
			intervals}, callback, asyncState);
	}
	public void Endset_keep_alive_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_limited_transmit_recovery_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_limited_transmit_recovery_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_limited_transmit_recovery_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_limited_transmit_recovery_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_limited_transmit_recovery_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_limited_transmit_recovery_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_link_qos_to_client
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_link_qos_to_client(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_link_qos_to_client", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_link_qos_to_client(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_link_qos_to_client", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_link_qos_to_client(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_data_retransmission
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_maximum_data_retransmission(
		string [] profile_names,
		LocalLBProfileULong [] retries
	) {
		this.Invoke("set_maximum_data_retransmission", new object [] {
				profile_names,
				retries});

	}
	public System.IAsyncResult Beginset_maximum_data_retransmission(string [] profile_names,LocalLBProfileULong [] retries, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_data_retransmission", new object[] {
			profile_names,
			retries}, callback, asyncState);
	}
	public void Endset_maximum_data_retransmission(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_syn_retransmission
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_maximum_syn_retransmission(
		string [] profile_names,
		LocalLBProfileULong [] retries
	) {
		this.Invoke("set_maximum_syn_retransmission", new object [] {
				profile_names,
				retries});

	}
	public System.IAsyncResult Beginset_maximum_syn_retransmission(string [] profile_names,LocalLBProfileULong [] retries, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_syn_retransmission", new object[] {
			profile_names,
			retries}, callback, asyncState);
	}
	public void Endset_maximum_syn_retransmission(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_md5_signature_passphrase
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_md5_signature_passphrase(
		string [] profile_names,
		LocalLBProfileString [] passphrases
	) {
		this.Invoke("set_md5_signature_passphrase", new object [] {
				profile_names,
				passphrases});

	}
	public System.IAsyncResult Beginset_md5_signature_passphrase(string [] profile_names,LocalLBProfileString [] passphrases, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_md5_signature_passphrase", new object[] {
			profile_names,
			passphrases}, callback, asyncState);
	}
	public void Endset_md5_signature_passphrase(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_md5_signature_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_md5_signature_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_md5_signature_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_md5_signature_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_md5_signature_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_md5_signature_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_minimum_rto
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_minimum_rto(
		string [] profile_names,
		LocalLBProfileULong [] timeouts
	) {
		this.Invoke("set_minimum_rto", new object [] {
				profile_names,
				timeouts});

	}
	public System.IAsyncResult Beginset_minimum_rto(string [] profile_names,LocalLBProfileULong [] timeouts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_minimum_rto", new object[] {
			profile_names,
			timeouts}, callback, asyncState);
	}
	public void Endset_minimum_rto(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_mptcp_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_mptcp_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_mptcp_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_mptcp_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_mptcp_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_mptcp_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_nagle_algorithm_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_nagle_algorithm_mode(
		string [] profile_names,
		LocalLBProfileTCPProfileTCPMode [] modes
	) {
		this.Invoke("set_nagle_algorithm_mode", new object [] {
				profile_names,
				modes});

	}
	public System.IAsyncResult Beginset_nagle_algorithm_mode(string [] profile_names,LocalLBProfileTCPProfileTCPMode [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_nagle_algorithm_mode", new object[] {
			profile_names,
			modes}, callback, asyncState);
	}
	public void Endset_nagle_algorithm_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_packet_loss_ignore_burst
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_packet_loss_ignore_burst(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_packet_loss_ignore_burst", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_packet_loss_ignore_burst(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_packet_loss_ignore_burst", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_packet_loss_ignore_burst(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_packet_loss_ignore_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_packet_loss_ignore_rate(
		string [] profile_names,
		LocalLBProfileULong [] thresholds
	) {
		this.Invoke("set_packet_loss_ignore_rate", new object [] {
				profile_names,
				thresholds});

	}
	public System.IAsyncResult Beginset_packet_loss_ignore_rate(string [] profile_names,LocalLBProfileULong [] thresholds, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_packet_loss_ignore_rate", new object[] {
			profile_names,
			thresholds}, callback, asyncState);
	}
	public void Endset_packet_loss_ignore_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_proxy_buffer_high
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_proxy_buffer_high(
		string [] profile_names,
		LocalLBProfileULong [] levels
	) {
		this.Invoke("set_proxy_buffer_high", new object [] {
				profile_names,
				levels});

	}
	public System.IAsyncResult Beginset_proxy_buffer_high(string [] profile_names,LocalLBProfileULong [] levels, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_proxy_buffer_high", new object[] {
			profile_names,
			levels}, callback, asyncState);
	}
	public void Endset_proxy_buffer_high(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_proxy_buffer_low
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_proxy_buffer_low(
		string [] profile_names,
		LocalLBProfileULong [] levels
	) {
		this.Invoke("set_proxy_buffer_low", new object [] {
				profile_names,
				levels});

	}
	public System.IAsyncResult Beginset_proxy_buffer_low(string [] profile_names,LocalLBProfileULong [] levels, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_proxy_buffer_low", new object[] {
			profile_names,
			levels}, callback, asyncState);
	}
	public void Endset_proxy_buffer_low(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_proxy_mss_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_proxy_mss_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_proxy_mss_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_proxy_mss_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_proxy_mss_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_proxy_mss_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_proxy_option_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_proxy_option_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_proxy_option_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_proxy_option_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_proxy_option_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_proxy_option_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rate_pace_maximum_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_rate_pace_maximum_rate(
		string [] profile_names,
		LocalLBProfileULong [] rates
	) {
		this.Invoke("set_rate_pace_maximum_rate", new object [] {
				profile_names,
				rates});

	}
	public System.IAsyncResult Beginset_rate_pace_maximum_rate(string [] profile_names,LocalLBProfileULong [] rates, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rate_pace_maximum_rate", new object[] {
			profile_names,
			rates}, callback, asyncState);
	}
	public void Endset_rate_pace_maximum_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rate_pace_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_rate_pace_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_rate_pace_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_rate_pace_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rate_pace_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_rate_pace_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_receive_window_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_receive_window_size(
		string [] profile_names,
		LocalLBProfileULong [] sizes
	) {
		this.Invoke("set_receive_window_size", new object [] {
				profile_names,
				sizes});

	}
	public System.IAsyncResult Beginset_receive_window_size(string [] profile_names,LocalLBProfileULong [] sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_receive_window_size", new object[] {
			profile_names,
			sizes}, callback, asyncState);
	}
	public void Endset_receive_window_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_reset_on_timeout_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
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
	// set_retransmit_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_retransmit_threshold(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_retransmit_threshold", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_retransmit_threshold(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_retransmit_threshold", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_retransmit_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rfc1323_timestamps_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_rfc1323_timestamps_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_rfc1323_timestamps_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_rfc1323_timestamps_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rfc1323_timestamps_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_rfc1323_timestamps_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_selective_ack_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_selective_ack_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_selective_ack_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_selective_ack_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_selective_ack_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_selective_ack_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_selective_nack_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_selective_nack_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_selective_nack_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_selective_nack_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_selective_nack_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_selective_nack_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_send_buffer_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_send_buffer_size(
		string [] profile_names,
		LocalLBProfileULong [] sizes
	) {
		this.Invoke("set_send_buffer_size", new object [] {
				profile_names,
				sizes});

	}
	public System.IAsyncResult Beginset_send_buffer_size(string [] profile_names,LocalLBProfileULong [] sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_send_buffer_size", new object[] {
			profile_names,
			sizes}, callback, asyncState);
	}
	public void Endset_send_buffer_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_slow_start_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_slow_start_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_slow_start_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_slow_start_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_slow_start_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_slow_start_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_tail_loss_probe_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_tail_loss_probe_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_tail_loss_probe_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_tail_loss_probe_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_tail_loss_probe_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_tail_loss_probe_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_tcp_options
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_tcp_options(
		string [] profile_names,
		LocalLBProfileString [] options
	) {
		this.Invoke("set_tcp_options", new object [] {
				profile_names,
				options});

	}
	public System.IAsyncResult Beginset_tcp_options(string [] profile_names,LocalLBProfileString [] options, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_tcp_options", new object[] {
			profile_names,
			options}, callback, asyncState);
	}
	public void Endset_tcp_options(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_time_wait_recycle_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_time_wait_recycle_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_time_wait_recycle_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_time_wait_recycle_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_time_wait_recycle_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_time_wait_recycle_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_time_wait_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_time_wait_timeout(
		string [] profile_names,
		LocalLBProfileULong [] timeouts
	) {
		this.Invoke("set_time_wait_timeout", new object [] {
				profile_names,
				timeouts});

	}
	public System.IAsyncResult Beginset_time_wait_timeout(string [] profile_names,LocalLBProfileULong [] timeouts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_time_wait_timeout", new object[] {
			profile_names,
			timeouts}, callback, asyncState);
	}
	public void Endset_time_wait_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_use_nagle_algorithm_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_use_nagle_algorithm_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_use_nagle_algorithm_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_use_nagle_algorithm_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_use_nagle_algorithm_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_use_nagle_algorithm_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_verified_accept_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_verified_accept_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_verified_accept_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_verified_accept_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_verified_accept_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_verified_accept_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_zero_window_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileTCP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileTCP", ResponseNamespace="urn:iControl:LocalLB/ProfileTCP")]
	public void set_zero_window_timeout(
		string [] profile_names,
		LocalLBProfileULong [] timeouts
	) {
		this.Invoke("set_zero_window_timeout", new object [] {
				profile_names,
				timeouts});

	}
	public System.IAsyncResult Beginset_zero_window_timeout(string [] profile_names,LocalLBProfileULong [] timeouts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_zero_window_timeout", new object[] {
			profile_names,
			timeouts}, callback, asyncState);
	}
	public void Endset_zero_window_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileTCP.TCPMode", Namespace = "urn:iControl")]
	public enum LocalLBProfileTCPTCPMode
	{
		TCP_MODE_UNKNOWN,
		TCP_MODE_DISABLED,
		TCP_MODE_ENABLED,
		TCP_MODE_AUTO,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileTCP.ProfileTCPMode", Namespace = "urn:iControl")]
	public partial class LocalLBProfileTCPProfileTCPMode
	{
		private LocalLBProfileTCPTCPMode valueField;
		public LocalLBProfileTCPTCPMode value
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileTCP.ProfileTCPStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBProfileTCPProfileTCPStatisticEntry
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileTCP.ProfileTCPStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBProfileTCPProfileTCPStatistics
	{
		private LocalLBProfileTCPProfileTCPStatisticEntry [] statisticsField;
		public LocalLBProfileTCPProfileTCPStatisticEntry [] statistics
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
