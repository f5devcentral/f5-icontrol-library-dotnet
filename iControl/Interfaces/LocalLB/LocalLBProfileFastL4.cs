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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.ProfileFastL4Binding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileFastL4ProfileFastL4Statistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileHardwareAccelerationMode))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileEnabledState))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileULong))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileFastL4ProfileLateBindingTimeoutRecoveryMode))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileFastL4ProfilePVAOffloadState))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileStatisticsByVirtual))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileTCPOptionMode))]
	public partial class LocalLBProfileFastL4 : iControlInterface {
		public LocalLBProfileFastL4() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileFastL4ProfileFastL4Statistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((LocalLBProfileFastL4ProfileFastL4Statistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public LocalLBProfileFastL4ProfileFastL4Statistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileFastL4ProfileFastL4Statistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
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
	// get_hardware_acceleration_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileHardwareAccelerationMode [] get_hardware_acceleration_mode(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_hardware_acceleration_mode", new object [] {
				profile_names});
		return ((LocalLBProfileHardwareAccelerationMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_hardware_acceleration_mode(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_hardware_acceleration_mode", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileHardwareAccelerationMode [] Endget_hardware_acceleration_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileHardwareAccelerationMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_hardware_syn_cookie_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
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
	// get_idle_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
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
	// get_ip_fragment_reassemble_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_ip_fragment_reassemble_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_ip_fragment_reassemble_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_ip_fragment_reassemble_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ip_fragment_reassemble_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_ip_fragment_reassemble_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ip_tos_to_client
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
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
	// get_ip_tos_to_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_ip_tos_to_server(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_ip_tos_to_server", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_ip_tos_to_server(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ip_tos_to_server", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_ip_tos_to_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_keep_alive_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
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
	// get_late_binding_client_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_late_binding_client_timeout(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_late_binding_client_timeout", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_late_binding_client_timeout(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_late_binding_client_timeout", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_late_binding_client_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_late_binding_explicit_flow_migration_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_late_binding_explicit_flow_migration_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_late_binding_explicit_flow_migration_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_late_binding_explicit_flow_migration_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_late_binding_explicit_flow_migration_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_late_binding_explicit_flow_migration_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_late_binding_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_late_binding_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_late_binding_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_late_binding_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_late_binding_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_late_binding_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_late_binding_timeout_recovery_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileFastL4ProfileLateBindingTimeoutRecoveryMode [] get_late_binding_timeout_recovery_mode(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_late_binding_timeout_recovery_mode", new object [] {
				profile_names});
		return ((LocalLBProfileFastL4ProfileLateBindingTimeoutRecoveryMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_late_binding_timeout_recovery_mode(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_late_binding_timeout_recovery_mode", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileFastL4ProfileLateBindingTimeoutRecoveryMode [] Endget_late_binding_timeout_recovery_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileFastL4ProfileLateBindingTimeoutRecoveryMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_link_qos_to_client
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
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
	// get_link_qos_to_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_link_qos_to_server(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_link_qos_to_server", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_link_qos_to_server(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_link_qos_to_server", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_link_qos_to_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
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
	// get_loose_close_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_loose_close_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_loose_close_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_loose_close_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_loose_close_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_loose_close_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_loose_initiation_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_loose_initiation_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_loose_initiation_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_loose_initiation_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_loose_initiation_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_loose_initiation_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_mss_override
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
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
	// get_pva_offload_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileFastL4ProfilePVAOffloadState [] get_pva_offload_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_pva_offload_state", new object [] {
				profile_names});
		return ((LocalLBProfileFastL4ProfilePVAOffloadState [])(results[0]));
	}
	public System.IAsyncResult Beginget_pva_offload_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_pva_offload_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileFastL4ProfilePVAOffloadState [] Endget_pva_offload_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileFastL4ProfilePVAOffloadState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_reset_on_timeout_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
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
	// get_rtt_from_client_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_rtt_from_client_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_rtt_from_client_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_rtt_from_client_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rtt_from_client_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_rtt_from_client_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rtt_from_server_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_rtt_from_server_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_rtt_from_server_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_rtt_from_server_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rtt_from_server_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_rtt_from_server_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_software_syn_cookie_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_software_syn_cookie_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_software_syn_cookie_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_software_syn_cookie_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_software_syn_cookie_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_software_syn_cookie_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileFastL4ProfileFastL4Statistics get_statistics(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				profile_names});
		return ((LocalLBProfileFastL4ProfileFastL4Statistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileFastL4ProfileFastL4Statistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileFastL4ProfileFastL4Statistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics_by_virtual
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
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
	// get_tcp_close_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_tcp_close_timeout(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_tcp_close_timeout", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_tcp_close_timeout(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_tcp_close_timeout", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_tcp_close_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_tcp_generate_isn_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_tcp_generate_isn_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_tcp_generate_isn_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_tcp_generate_isn_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_tcp_generate_isn_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_tcp_generate_isn_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_tcp_handshake_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_tcp_handshake_timeout(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_tcp_handshake_timeout", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_tcp_handshake_timeout(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_tcp_handshake_timeout", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_tcp_handshake_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_tcp_strip_sackok_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_tcp_strip_sackok_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_tcp_strip_sackok_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_tcp_strip_sackok_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_tcp_strip_sackok_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_tcp_strip_sackok_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_tcp_timestamp_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileTCPOptionMode [] get_tcp_timestamp_mode(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_tcp_timestamp_mode", new object [] {
				profile_names});
		return ((LocalLBProfileTCPOptionMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_tcp_timestamp_mode(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_tcp_timestamp_mode", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileTCPOptionMode [] Endget_tcp_timestamp_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileTCPOptionMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_tcp_window_scale_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileTCPOptionMode [] get_tcp_window_scale_mode(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_tcp_window_scale_mode", new object [] {
				profile_names});
		return ((LocalLBProfileTCPOptionMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_tcp_window_scale_mode(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_tcp_window_scale_mode", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileTCPOptionMode [] Endget_tcp_window_scale_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileTCPOptionMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
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
	// set_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
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
	// set_hardware_acceleration_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
	public void set_hardware_acceleration_mode(
		string [] profile_names,
		LocalLBProfileHardwareAccelerationMode [] acceleration_modes
	) {
		this.Invoke("set_hardware_acceleration_mode", new object [] {
				profile_names,
				acceleration_modes});

	}
	public System.IAsyncResult Beginset_hardware_acceleration_mode(string [] profile_names,LocalLBProfileHardwareAccelerationMode [] acceleration_modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_hardware_acceleration_mode", new object[] {
			profile_names,
			acceleration_modes}, callback, asyncState);
	}
	public void Endset_hardware_acceleration_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_hardware_syn_cookie_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
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
	// set_idle_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
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
	// set_ip_fragment_reassemble_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
	public void set_ip_fragment_reassemble_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_ip_fragment_reassemble_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_ip_fragment_reassemble_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ip_fragment_reassemble_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_ip_fragment_reassemble_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ip_tos_to_client
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
	public void set_ip_tos_to_client(
		string [] profile_names,
		LocalLBProfileULong [] ip_tos_values
	) {
		this.Invoke("set_ip_tos_to_client", new object [] {
				profile_names,
				ip_tos_values});

	}
	public System.IAsyncResult Beginset_ip_tos_to_client(string [] profile_names,LocalLBProfileULong [] ip_tos_values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ip_tos_to_client", new object[] {
			profile_names,
			ip_tos_values}, callback, asyncState);
	}
	public void Endset_ip_tos_to_client(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ip_tos_to_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
	public void set_ip_tos_to_server(
		string [] profile_names,
		LocalLBProfileULong [] ip_tos_values
	) {
		this.Invoke("set_ip_tos_to_server", new object [] {
				profile_names,
				ip_tos_values});

	}
	public System.IAsyncResult Beginset_ip_tos_to_server(string [] profile_names,LocalLBProfileULong [] ip_tos_values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ip_tos_to_server", new object[] {
			profile_names,
			ip_tos_values}, callback, asyncState);
	}
	public void Endset_ip_tos_to_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_keep_alive_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
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
	// set_late_binding_client_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
	public void set_late_binding_client_timeout(
		string [] profile_names,
		LocalLBProfileULong [] timeouts
	) {
		this.Invoke("set_late_binding_client_timeout", new object [] {
				profile_names,
				timeouts});

	}
	public System.IAsyncResult Beginset_late_binding_client_timeout(string [] profile_names,LocalLBProfileULong [] timeouts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_late_binding_client_timeout", new object[] {
			profile_names,
			timeouts}, callback, asyncState);
	}
	public void Endset_late_binding_client_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_late_binding_explicit_flow_migration_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
	public void set_late_binding_explicit_flow_migration_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_late_binding_explicit_flow_migration_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_late_binding_explicit_flow_migration_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_late_binding_explicit_flow_migration_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_late_binding_explicit_flow_migration_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_late_binding_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
	public void set_late_binding_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_late_binding_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_late_binding_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_late_binding_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_late_binding_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_late_binding_timeout_recovery_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
	public void set_late_binding_timeout_recovery_mode(
		string [] profile_names,
		LocalLBProfileFastL4ProfileLateBindingTimeoutRecoveryMode [] modes
	) {
		this.Invoke("set_late_binding_timeout_recovery_mode", new object [] {
				profile_names,
				modes});

	}
	public System.IAsyncResult Beginset_late_binding_timeout_recovery_mode(string [] profile_names,LocalLBProfileFastL4ProfileLateBindingTimeoutRecoveryMode [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_late_binding_timeout_recovery_mode", new object[] {
			profile_names,
			modes}, callback, asyncState);
	}
	public void Endset_late_binding_timeout_recovery_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_link_qos_to_client
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
	public void set_link_qos_to_client(
		string [] profile_names,
		LocalLBProfileULong [] link_qos_values
	) {
		this.Invoke("set_link_qos_to_client", new object [] {
				profile_names,
				link_qos_values});

	}
	public System.IAsyncResult Beginset_link_qos_to_client(string [] profile_names,LocalLBProfileULong [] link_qos_values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_link_qos_to_client", new object[] {
			profile_names,
			link_qos_values}, callback, asyncState);
	}
	public void Endset_link_qos_to_client(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_link_qos_to_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
	public void set_link_qos_to_server(
		string [] profile_names,
		LocalLBProfileULong [] link_qos_values
	) {
		this.Invoke("set_link_qos_to_server", new object [] {
				profile_names,
				link_qos_values});

	}
	public System.IAsyncResult Beginset_link_qos_to_server(string [] profile_names,LocalLBProfileULong [] link_qos_values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_link_qos_to_server", new object[] {
			profile_names,
			link_qos_values}, callback, asyncState);
	}
	public void Endset_link_qos_to_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_loose_close_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
	public void set_loose_close_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_loose_close_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_loose_close_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_loose_close_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_loose_close_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_loose_initiation_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
	public void set_loose_initiation_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_loose_initiation_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_loose_initiation_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_loose_initiation_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_loose_initiation_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_mss_override
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
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
	// set_pva_offload_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
	public void set_pva_offload_state(
		string [] profile_names,
		LocalLBProfileFastL4ProfilePVAOffloadState [] states
	) {
		this.Invoke("set_pva_offload_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_pva_offload_state(string [] profile_names,LocalLBProfileFastL4ProfilePVAOffloadState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_pva_offload_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_pva_offload_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_reset_on_timeout_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
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
	// set_rtt_from_client_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
	public void set_rtt_from_client_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_rtt_from_client_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_rtt_from_client_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rtt_from_client_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_rtt_from_client_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rtt_from_server_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
	public void set_rtt_from_server_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_rtt_from_server_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_rtt_from_server_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rtt_from_server_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_rtt_from_server_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_software_syn_cookie_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
	public void set_software_syn_cookie_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_software_syn_cookie_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_software_syn_cookie_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_software_syn_cookie_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_software_syn_cookie_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_tcp_close_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
	public void set_tcp_close_timeout(
		string [] profile_names,
		LocalLBProfileULong [] timeouts
	) {
		this.Invoke("set_tcp_close_timeout", new object [] {
				profile_names,
				timeouts});

	}
	public System.IAsyncResult Beginset_tcp_close_timeout(string [] profile_names,LocalLBProfileULong [] timeouts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_tcp_close_timeout", new object[] {
			profile_names,
			timeouts}, callback, asyncState);
	}
	public void Endset_tcp_close_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_tcp_generate_isn_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
	public void set_tcp_generate_isn_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_tcp_generate_isn_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_tcp_generate_isn_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_tcp_generate_isn_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_tcp_generate_isn_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_tcp_handshake_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
	public void set_tcp_handshake_timeout(
		string [] profile_names,
		LocalLBProfileULong [] timeouts
	) {
		this.Invoke("set_tcp_handshake_timeout", new object [] {
				profile_names,
				timeouts});

	}
	public System.IAsyncResult Beginset_tcp_handshake_timeout(string [] profile_names,LocalLBProfileULong [] timeouts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_tcp_handshake_timeout", new object[] {
			profile_names,
			timeouts}, callback, asyncState);
	}
	public void Endset_tcp_handshake_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_tcp_strip_sackok_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
	public void set_tcp_strip_sackok_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_tcp_strip_sackok_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_tcp_strip_sackok_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_tcp_strip_sackok_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_tcp_strip_sackok_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_tcp_timestamp_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
	public void set_tcp_timestamp_mode(
		string [] profile_names,
		LocalLBProfileTCPOptionMode [] modes
	) {
		this.Invoke("set_tcp_timestamp_mode", new object [] {
				profile_names,
				modes});

	}
	public System.IAsyncResult Beginset_tcp_timestamp_mode(string [] profile_names,LocalLBProfileTCPOptionMode [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_tcp_timestamp_mode", new object[] {
			profile_names,
			modes}, callback, asyncState);
	}
	public void Endset_tcp_timestamp_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_tcp_window_scale_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileFastL4", 
		RequestNamespace="urn:iControl:LocalLB/ProfileFastL4", ResponseNamespace="urn:iControl:LocalLB/ProfileFastL4")]
	public void set_tcp_window_scale_mode(
		string [] profile_names,
		LocalLBProfileTCPOptionMode [] modes
	) {
		this.Invoke("set_tcp_window_scale_mode", new object [] {
				profile_names,
				modes});

	}
	public System.IAsyncResult Beginset_tcp_window_scale_mode(string [] profile_names,LocalLBProfileTCPOptionMode [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_tcp_window_scale_mode", new object[] {
			profile_names,
			modes}, callback, asyncState);
	}
	public void Endset_tcp_window_scale_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileFastL4.LateBindingTimeoutRecoveryMode", Namespace = "urn:iControl")]
	public enum LocalLBProfileFastL4LateBindingTimeoutRecoveryMode
	{
		LATE_BINDING_TIMEOUT_RECOVERY_UNKNOWN,
		LATE_BINDING_TIMEOUT_RECOVERY_DISCONNECT,
		LATE_BINDING_TIMEOUT_RECOVERY_FALLBACK,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileFastL4.PVAOffloadState", Namespace = "urn:iControl")]
	public enum LocalLBProfileFastL4PVAOffloadState
	{
		OFFLOAD_STATE_UNKNOWN,
		OFFLOAD_STATE_EST,
		OFFLOAD_STATE_SYN,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileFastL4.ProfileFastL4StatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBProfileFastL4ProfileFastL4StatisticEntry
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileFastL4.ProfileFastL4Statistics", Namespace = "urn:iControl")]
	public partial class LocalLBProfileFastL4ProfileFastL4Statistics
	{
		private LocalLBProfileFastL4ProfileFastL4StatisticEntry [] statisticsField;
		public LocalLBProfileFastL4ProfileFastL4StatisticEntry [] statistics
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

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileFastL4.ProfileLateBindingTimeoutRecoveryMode", Namespace = "urn:iControl")]
	public partial class LocalLBProfileFastL4ProfileLateBindingTimeoutRecoveryMode
	{
		private LocalLBProfileFastL4LateBindingTimeoutRecoveryMode valueField;
		public LocalLBProfileFastL4LateBindingTimeoutRecoveryMode value
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileFastL4.ProfilePVAOffloadState", Namespace = "urn:iControl")]
	public partial class LocalLBProfileFastL4ProfilePVAOffloadState
	{
		private LocalLBProfileFastL4PVAOffloadState valueField;
		public LocalLBProfileFastL4PVAOffloadState value
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
