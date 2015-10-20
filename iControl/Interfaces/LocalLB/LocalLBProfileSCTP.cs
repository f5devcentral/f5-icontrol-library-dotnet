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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.ProfileSCTPBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileSCTPProfileSCTPStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileEnabledState))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileULong))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileString))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileStatisticsByVirtual))]
	public partial class LocalLBProfileSCTP : iControlInterface {
		public LocalLBProfileSCTP() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_multi_homing_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
	public void add_multi_homing_address(
		string [] profile_names,
		string [] [] addresses
	) {
		this.Invoke("add_multi_homing_address", new object [] {
				profile_names,
				addresses});

	}
	public System.IAsyncResult Beginadd_multi_homing_address(string [] profile_names,string [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_multi_homing_address", new object[] {
			profile_names,
			addresses}, callback, asyncState);
	}
	public void Endadd_multi_homing_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileSCTPProfileSCTPStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((LocalLBProfileSCTPProfileSCTPStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public LocalLBProfileSCTPProfileSCTPStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileSCTPProfileSCTPStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_client_side_multi_homing_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_client_side_multi_homing_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_client_side_multi_homing_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_client_side_multi_homing_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_client_side_multi_homing_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_client_side_multi_homing_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_connect_maximum_retry
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_connect_maximum_retry(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_connect_maximum_retry", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_connect_maximum_retry(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_connect_maximum_retry", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_connect_maximum_retry(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cookie_expiration
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_cookie_expiration(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_cookie_expiration", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_cookie_expiration(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cookie_expiration", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_cookie_expiration(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
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
	// get_emulate_tcp_shutdown_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_emulate_tcp_shutdown_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_emulate_tcp_shutdown_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_emulate_tcp_shutdown_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_emulate_tcp_shutdown_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_emulate_tcp_shutdown_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_heartbeat_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_heartbeat_interval(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_heartbeat_interval", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_heartbeat_interval(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_heartbeat_interval", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_heartbeat_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_heartbeat_max_burst
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_heartbeat_max_burst(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_heartbeat_max_burst", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_heartbeat_max_burst(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_heartbeat_max_burst", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_heartbeat_max_burst(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_idle_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
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
	// get_inbound_stream
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_inbound_stream(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_inbound_stream", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_inbound_stream(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_inbound_stream", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_inbound_stream(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ip_tos_to_peer
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_ip_tos_to_peer(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_ip_tos_to_peer", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_ip_tos_to_peer(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ip_tos_to_peer", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_ip_tos_to_peer(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_link_qos_to_peer
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_link_qos_to_peer(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_link_qos_to_peer", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_link_qos_to_peer(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_link_qos_to_peer", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_link_qos_to_peer(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
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
	// get_max_burst
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_max_burst(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_max_burst", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_max_burst(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_max_burst", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_max_burst(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_maximum_communication_paths
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_maximum_communication_paths(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_maximum_communication_paths", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_communication_paths(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_communication_paths", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_maximum_communication_paths(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_maximum_path_retransmit_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_maximum_path_retransmit_limit(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_maximum_path_retransmit_limit", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_path_retransmit_limit(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_path_retransmit_limit", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_maximum_path_retransmit_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_multi_homing_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_multi_homing_address(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_multi_homing_address", new object [] {
				profile_names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_multi_homing_address(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_multi_homing_address", new object[] {
			profile_names}, callback, asyncState);
	}
	public string [] [] Endget_multi_homing_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_order_receive_message_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_order_receive_message_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_order_receive_message_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_order_receive_message_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_order_receive_message_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_order_receive_message_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_outbound_stream
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_outbound_stream(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_outbound_stream", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_outbound_stream(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_outbound_stream", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_outbound_stream(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_proxy_buffer_high
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
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
	// get_receive_chunk_buffer
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_receive_chunk_buffer(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_receive_chunk_buffer", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_receive_chunk_buffer(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_receive_chunk_buffer", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_receive_chunk_buffer(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_receive_window_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
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
	// get_secret
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_secret(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_secret", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_secret(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_secret", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_secret(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_send_buffer_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
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
	// get_send_maximum_retry
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_send_maximum_retry(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_send_maximum_retry", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_send_maximum_retry(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_send_maximum_retry", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_send_maximum_retry(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_send_partial_data_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_send_partial_data_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_send_partial_data_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_send_partial_data_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_send_partial_data_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_send_partial_data_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_server_side_multi_homing_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_server_side_multi_homing_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_server_side_multi_homing_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_server_side_multi_homing_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_server_side_multi_homing_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_server_side_multi_homing_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileSCTPProfileSCTPStatistics get_statistics(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				profile_names});
		return ((LocalLBProfileSCTPProfileSCTPStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileSCTPProfileSCTPStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileSCTPProfileSCTPStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics_by_virtual
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
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
	// get_transmit_chunk_buffer
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_transmit_chunk_buffer(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_transmit_chunk_buffer", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_transmit_chunk_buffer(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_transmit_chunk_buffer", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_transmit_chunk_buffer(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
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
	// remove_all_multi_homing_addresses
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
	public void remove_all_multi_homing_addresses(
		string [] profile_names
	) {
		this.Invoke("remove_all_multi_homing_addresses", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginremove_all_multi_homing_addresses(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_multi_homing_addresses", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endremove_all_multi_homing_addresses(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_multi_homing_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
	public void remove_multi_homing_address(
		string [] profile_names,
		string [] [] addresses
	) {
		this.Invoke("remove_multi_homing_address", new object [] {
				profile_names,
				addresses});

	}
	public System.IAsyncResult Beginremove_multi_homing_address(string [] profile_names,string [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_multi_homing_address", new object[] {
			profile_names,
			addresses}, callback, asyncState);
	}
	public void Endremove_multi_homing_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
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
	// set_client_side_multi_homing_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
	public void set_client_side_multi_homing_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_client_side_multi_homing_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_client_side_multi_homing_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_client_side_multi_homing_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_client_side_multi_homing_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_connect_maximum_retry
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
	public void set_connect_maximum_retry(
		string [] profile_names,
		LocalLBProfileULong [] retries
	) {
		this.Invoke("set_connect_maximum_retry", new object [] {
				profile_names,
				retries});

	}
	public System.IAsyncResult Beginset_connect_maximum_retry(string [] profile_names,LocalLBProfileULong [] retries, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_connect_maximum_retry", new object[] {
			profile_names,
			retries}, callback, asyncState);
	}
	public void Endset_connect_maximum_retry(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_cookie_expiration
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
	public void set_cookie_expiration(
		string [] profile_names,
		LocalLBProfileULong [] durations
	) {
		this.Invoke("set_cookie_expiration", new object [] {
				profile_names,
				durations});

	}
	public System.IAsyncResult Beginset_cookie_expiration(string [] profile_names,LocalLBProfileULong [] durations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cookie_expiration", new object[] {
			profile_names,
			durations}, callback, asyncState);
	}
	public void Endset_cookie_expiration(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
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
	// set_emulate_tcp_shutdown_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
	public void set_emulate_tcp_shutdown_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_emulate_tcp_shutdown_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_emulate_tcp_shutdown_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_emulate_tcp_shutdown_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_emulate_tcp_shutdown_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_heartbeat_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
	public void set_heartbeat_interval(
		string [] profile_names,
		LocalLBProfileULong [] intervals
	) {
		this.Invoke("set_heartbeat_interval", new object [] {
				profile_names,
				intervals});

	}
	public System.IAsyncResult Beginset_heartbeat_interval(string [] profile_names,LocalLBProfileULong [] intervals, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_heartbeat_interval", new object[] {
			profile_names,
			intervals}, callback, asyncState);
	}
	public void Endset_heartbeat_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_heartbeat_max_burst
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
	public void set_heartbeat_max_burst(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_heartbeat_max_burst", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_heartbeat_max_burst(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_heartbeat_max_burst", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_heartbeat_max_burst(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_idle_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
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
	// set_inbound_stream
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
	public void set_inbound_stream(
		string [] profile_names,
		LocalLBProfileULong [] streams
	) {
		this.Invoke("set_inbound_stream", new object [] {
				profile_names,
				streams});

	}
	public System.IAsyncResult Beginset_inbound_stream(string [] profile_names,LocalLBProfileULong [] streams, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_inbound_stream", new object[] {
			profile_names,
			streams}, callback, asyncState);
	}
	public void Endset_inbound_stream(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ip_tos_to_peer
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
	public void set_ip_tos_to_peer(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_ip_tos_to_peer", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_ip_tos_to_peer(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ip_tos_to_peer", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_ip_tos_to_peer(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_link_qos_to_peer
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
	public void set_link_qos_to_peer(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_link_qos_to_peer", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_link_qos_to_peer(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_link_qos_to_peer", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_link_qos_to_peer(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_max_burst
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
	public void set_max_burst(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_max_burst", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_max_burst(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_max_burst", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_max_burst(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_communication_paths
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
	public void set_maximum_communication_paths(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_maximum_communication_paths", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_maximum_communication_paths(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_communication_paths", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_maximum_communication_paths(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_path_retransmit_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
	public void set_maximum_path_retransmit_limit(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_maximum_path_retransmit_limit", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_maximum_path_retransmit_limit(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_path_retransmit_limit", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_maximum_path_retransmit_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_order_receive_message_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
	public void set_order_receive_message_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_order_receive_message_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_order_receive_message_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_order_receive_message_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_order_receive_message_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_outbound_stream
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
	public void set_outbound_stream(
		string [] profile_names,
		LocalLBProfileULong [] streams
	) {
		this.Invoke("set_outbound_stream", new object [] {
				profile_names,
				streams});

	}
	public System.IAsyncResult Beginset_outbound_stream(string [] profile_names,LocalLBProfileULong [] streams, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_outbound_stream", new object[] {
			profile_names,
			streams}, callback, asyncState);
	}
	public void Endset_outbound_stream(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_proxy_buffer_high
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
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
	// set_receive_chunk_buffer
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
	public void set_receive_chunk_buffer(
		string [] profile_names,
		LocalLBProfileULong [] buffers
	) {
		this.Invoke("set_receive_chunk_buffer", new object [] {
				profile_names,
				buffers});

	}
	public System.IAsyncResult Beginset_receive_chunk_buffer(string [] profile_names,LocalLBProfileULong [] buffers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_receive_chunk_buffer", new object[] {
			profile_names,
			buffers}, callback, asyncState);
	}
	public void Endset_receive_chunk_buffer(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_receive_window_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
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
	// set_secret
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
	public void set_secret(
		string [] profile_names,
		LocalLBProfileString [] secrets
	) {
		this.Invoke("set_secret", new object [] {
				profile_names,
				secrets});

	}
	public System.IAsyncResult Beginset_secret(string [] profile_names,LocalLBProfileString [] secrets, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_secret", new object[] {
			profile_names,
			secrets}, callback, asyncState);
	}
	public void Endset_secret(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_send_buffer_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
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
	// set_send_maximum_retry
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
	public void set_send_maximum_retry(
		string [] profile_names,
		LocalLBProfileULong [] retries
	) {
		this.Invoke("set_send_maximum_retry", new object [] {
				profile_names,
				retries});

	}
	public System.IAsyncResult Beginset_send_maximum_retry(string [] profile_names,LocalLBProfileULong [] retries, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_send_maximum_retry", new object[] {
			profile_names,
			retries}, callback, asyncState);
	}
	public void Endset_send_maximum_retry(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_send_partial_data_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
	public void set_send_partial_data_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_send_partial_data_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_send_partial_data_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_send_partial_data_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_send_partial_data_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_server_side_multi_homing_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
	public void set_server_side_multi_homing_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_server_side_multi_homing_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_server_side_multi_homing_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_server_side_multi_homing_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_server_side_multi_homing_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_transmit_chunk_buffer
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileSCTP", 
		RequestNamespace="urn:iControl:LocalLB/ProfileSCTP", ResponseNamespace="urn:iControl:LocalLB/ProfileSCTP")]
	public void set_transmit_chunk_buffer(
		string [] profile_names,
		LocalLBProfileULong [] buffers
	) {
		this.Invoke("set_transmit_chunk_buffer", new object [] {
				profile_names,
				buffers});

	}
	public System.IAsyncResult Beginset_transmit_chunk_buffer(string [] profile_names,LocalLBProfileULong [] buffers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_transmit_chunk_buffer", new object[] {
			profile_names,
			buffers}, callback, asyncState);
	}
	public void Endset_transmit_chunk_buffer(System.IAsyncResult asyncResult) {
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileSCTP.ProfileSCTPStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBProfileSCTPProfileSCTPStatisticEntry
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileSCTP.ProfileSCTPStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBProfileSCTPProfileSCTPStatistics
	{
		private LocalLBProfileSCTPProfileSCTPStatisticEntry [] statisticsField;
		public LocalLBProfileSCTPProfileSCTPStatisticEntry [] statistics
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
