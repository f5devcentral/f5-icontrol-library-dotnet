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
	[System.Web.Services.WebServiceBindingAttribute(Name="Networking.VLANBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(NetworkingVLANMemberEntry))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(NetworkingVLANForwardingTableEntry))]
	public partial class NetworkingVLAN : iControlInterface {
		public NetworkingVLAN() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	public void add_member(
		string [] vlans,
		NetworkingVLANMemberEntry [] [] members
	) {
		this.Invoke("add_member", new object [] {
				vlans,
				members});

	}
	public System.IAsyncResult Beginadd_member(string [] vlans,NetworkingVLANMemberEntry [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_member", new object[] {
			vlans,
			members}, callback, asyncState);
	}
	public void Endadd_member(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_static_forwarding
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	public void add_static_forwarding(
		string [] vlans,
		NetworkingVLANForwardingTableEntry [] [] forwarding_entries
	) {
		this.Invoke("add_static_forwarding", new object [] {
				vlans,
				forwarding_entries});

	}
	public System.IAsyncResult Beginadd_static_forwarding(string [] vlans,NetworkingVLANForwardingTableEntry [] [] forwarding_entries, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_static_forwarding", new object[] {
			vlans,
			forwarding_entries}, callback, asyncState);
	}
	public void Endadd_static_forwarding(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	public void create(
		string [] vlans,
		long [] vlan_ids,
		NetworkingVLANMemberEntry [] [] members,
		CommonEnabledState [] failsafe_states,
		long [] timeouts,
		string [] mac_masquerade_addresses
	) {
		this.Invoke("create", new object [] {
				vlans,
				vlan_ids,
				members,
				failsafe_states,
				timeouts,
				mac_masquerade_addresses});

	}
	public System.IAsyncResult Begincreate(string [] vlans,long [] vlan_ids,NetworkingVLANMemberEntry [] [] members,CommonEnabledState [] failsafe_states,long [] timeouts,string [] mac_masquerade_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			vlans,
			vlan_ids,
			members,
			failsafe_states,
			timeouts,
			mac_masquerade_addresses}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	public void create_v2(
		string [] vlans,
		long [] vlan_ids,
		NetworkingVLANMemberEntry [] [] members,
		CommonEnabledState [] failsafe_states,
		long [] timeouts
	) {
		this.Invoke("create_v2", new object [] {
				vlans,
				vlan_ids,
				members,
				failsafe_states,
				timeouts});

	}
	public System.IAsyncResult Begincreate_v2(string [] vlans,long [] vlan_ids,NetworkingVLANMemberEntry [] [] members,CommonEnabledState [] failsafe_states,long [] timeouts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_v2", new object[] {
			vlans,
			vlan_ids,
			members,
			failsafe_states,
			timeouts}, callback, asyncState);
	}
	public void Endcreate_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_vlans
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	public void delete_all_vlans(

	) {
		this.Invoke("delete_all_vlans", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_vlans(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_vlans", new object[0], callback, asyncState);
	}
	public void Enddelete_all_vlans(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	public void delete_vlan(
		string [] vlans
	) {
		this.Invoke("delete_vlan", new object [] {
				vlans});

	}
	public System.IAsyncResult Begindelete_vlan(string [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_vlan", new object[] {
			vlans}, callback, asyncState);
	}
	public void Enddelete_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_auto_lasthop
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonAutoLasthop [] get_auto_lasthop(
		string [] vlans
	) {
		object [] results = this.Invoke("get_auto_lasthop", new object [] {
				vlans});
		return ((CommonAutoLasthop [])(results[0]));
	}
	public System.IAsyncResult Beginget_auto_lasthop(string [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_auto_lasthop", new object[] {
			vlans}, callback, asyncState);
	}
	public CommonAutoLasthop [] Endget_auto_lasthop(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonAutoLasthop [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cmp_hash_algorithm
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingVLANVLANCMPHash [] get_cmp_hash_algorithm(
		string [] vlans
	) {
		object [] results = this.Invoke("get_cmp_hash_algorithm", new object [] {
				vlans});
		return ((NetworkingVLANVLANCMPHash [])(results[0]));
	}
	public System.IAsyncResult Beginget_cmp_hash_algorithm(string [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cmp_hash_algorithm", new object[] {
			vlans}, callback, asyncState);
	}
	public NetworkingVLANVLANCMPHash [] Endget_cmp_hash_algorithm(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingVLANVLANCMPHash [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] vlans
	) {
		object [] results = this.Invoke("get_description", new object [] {
				vlans});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			vlans}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dynamic_forwarding
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingVLANForwardingTableEntry [] [] get_dynamic_forwarding(
		string [] vlans
	) {
		object [] results = this.Invoke("get_dynamic_forwarding", new object [] {
				vlans});
		return ((NetworkingVLANForwardingTableEntry [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_dynamic_forwarding(string [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dynamic_forwarding", new object[] {
			vlans}, callback, asyncState);
	}
	public NetworkingVLANForwardingTableEntry [] [] Endget_dynamic_forwarding(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingVLANForwardingTableEntry [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_failsafe_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonHAAction [] get_failsafe_action(
		string [] vlans
	) {
		object [] results = this.Invoke("get_failsafe_action", new object [] {
				vlans});
		return ((CommonHAAction [])(results[0]));
	}
	public System.IAsyncResult Beginget_failsafe_action(string [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_failsafe_action", new object[] {
			vlans}, callback, asyncState);
	}
	public CommonHAAction [] Endget_failsafe_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonHAAction [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_failsafe_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_failsafe_state(
		string [] vlans
	) {
		object [] results = this.Invoke("get_failsafe_state", new object [] {
				vlans});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_failsafe_state(string [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_failsafe_state", new object[] {
			vlans}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_failsafe_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_failsafe_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_failsafe_timeout(
		string [] vlans
	) {
		object [] results = this.Invoke("get_failsafe_timeout", new object [] {
				vlans});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_failsafe_timeout(string [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_failsafe_timeout", new object[] {
			vlans}, callback, asyncState);
	}
	public long [] Endget_failsafe_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_if_index
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_if_index(
		string [] vlans
	) {
		object [] results = this.Invoke("get_if_index", new object [] {
				vlans});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_if_index(string [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_if_index", new object[] {
			vlans}, callback, asyncState);
	}
	public long [] Endget_if_index(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_learning_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingLearningMode [] get_learning_mode(
		string [] vlans
	) {
		object [] results = this.Invoke("get_learning_mode", new object [] {
				vlans});
		return ((NetworkingLearningMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_learning_mode(string [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_learning_mode", new object[] {
			vlans}, callback, asyncState);
	}
	public NetworkingLearningMode [] Endget_learning_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingLearningMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
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
	// get_mac_masquerade_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_mac_masquerade_address(
		string [] vlans
	) {
		object [] results = this.Invoke("get_mac_masquerade_address", new object [] {
				vlans});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_mac_masquerade_address(string [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_mac_masquerade_address", new object[] {
			vlans}, callback, asyncState);
	}
	public string [] Endget_mac_masquerade_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingVLANMemberEntry [] [] get_member(
		string [] vlans
	) {
		object [] results = this.Invoke("get_member", new object [] {
				vlans});
		return ((NetworkingVLANMemberEntry [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member(string [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member", new object[] {
			vlans}, callback, asyncState);
	}
	public NetworkingVLANMemberEntry [] [] Endget_member(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingVLANMemberEntry [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_mtu
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_mtu(
		string [] vlans
	) {
		object [] results = this.Invoke("get_mtu", new object [] {
				vlans});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_mtu(string [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_mtu", new object[] {
			vlans}, callback, asyncState);
	}
	public long [] Endget_mtu(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_sflow_poll_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_sflow_poll_interval(
		string [] vlans
	) {
		object [] results = this.Invoke("get_sflow_poll_interval", new object [] {
				vlans});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_sflow_poll_interval(string [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_sflow_poll_interval", new object[] {
			vlans}, callback, asyncState);
	}
	public long [] Endget_sflow_poll_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_sflow_poll_interval_global
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonSFlowGlobalType [] get_sflow_poll_interval_global(
		string [] vlans
	) {
		object [] results = this.Invoke("get_sflow_poll_interval_global", new object [] {
				vlans});
		return ((CommonSFlowGlobalType [])(results[0]));
	}
	public System.IAsyncResult Beginget_sflow_poll_interval_global(string [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_sflow_poll_interval_global", new object[] {
			vlans}, callback, asyncState);
	}
	public CommonSFlowGlobalType [] Endget_sflow_poll_interval_global(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonSFlowGlobalType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_sflow_sampling_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_sflow_sampling_rate(
		string [] vlans
	) {
		object [] results = this.Invoke("get_sflow_sampling_rate", new object [] {
				vlans});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_sflow_sampling_rate(string [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_sflow_sampling_rate", new object[] {
			vlans}, callback, asyncState);
	}
	public long [] Endget_sflow_sampling_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_sflow_sampling_rate_global
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonSFlowGlobalType [] get_sflow_sampling_rate_global(
		string [] vlans
	) {
		object [] results = this.Invoke("get_sflow_sampling_rate_global", new object [] {
				vlans});
		return ((CommonSFlowGlobalType [])(results[0]));
	}
	public System.IAsyncResult Beginget_sflow_sampling_rate_global(string [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_sflow_sampling_rate_global", new object[] {
			vlans}, callback, asyncState);
	}
	public CommonSFlowGlobalType [] Endget_sflow_sampling_rate_global(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonSFlowGlobalType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_source_check_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_source_check_state(
		string [] vlans
	) {
		object [] results = this.Invoke("get_source_check_state", new object [] {
				vlans});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_source_check_state(string [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_source_check_state", new object[] {
			vlans}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_source_check_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_static_forwarding
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingVLANForwardingTableEntry [] [] get_static_forwarding(
		string [] vlans
	) {
		object [] results = this.Invoke("get_static_forwarding", new object [] {
				vlans});
		return ((NetworkingVLANForwardingTableEntry [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_static_forwarding(string [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_static_forwarding", new object[] {
			vlans}, callback, asyncState);
	}
	public NetworkingVLANForwardingTableEntry [] [] Endget_static_forwarding(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingVLANForwardingTableEntry [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_static_forwarding_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_static_forwarding_description(
		string [] vlans,
		string [] [] mac_addresses
	) {
		object [] results = this.Invoke("get_static_forwarding_description", new object [] {
				vlans,
				mac_addresses});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_static_forwarding_description(string [] vlans,string [] [] mac_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_static_forwarding_description", new object[] {
			vlans,
			mac_addresses}, callback, asyncState);
	}
	public string [] [] Endget_static_forwarding_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_true_mac_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_true_mac_address(
		string [] vlans
	) {
		object [] results = this.Invoke("get_true_mac_address", new object [] {
				vlans});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_true_mac_address(string [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_true_mac_address", new object[] {
			vlans}, callback, asyncState);
	}
	public string [] Endget_true_mac_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
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
	// get_vlan_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_vlan_id(
		string [] vlans
	) {
		object [] results = this.Invoke("get_vlan_id", new object [] {
				vlans});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_vlan_id(string [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_vlan_id", new object[] {
			vlans}, callback, asyncState);
	}
	public long [] Endget_vlan_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// remove_all_dynamic_forwardings
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	public void remove_all_dynamic_forwardings(
		string [] vlans
	) {
		this.Invoke("remove_all_dynamic_forwardings", new object [] {
				vlans});

	}
	public System.IAsyncResult Beginremove_all_dynamic_forwardings(string [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_dynamic_forwardings", new object[] {
			vlans}, callback, asyncState);
	}
	public void Endremove_all_dynamic_forwardings(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_members
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	public void remove_all_members(
		string [] vlans
	) {
		this.Invoke("remove_all_members", new object [] {
				vlans});

	}
	public System.IAsyncResult Beginremove_all_members(string [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_members", new object[] {
			vlans}, callback, asyncState);
	}
	public void Endremove_all_members(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_static_forwardings
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	public void remove_all_static_forwardings(
		string [] vlans
	) {
		this.Invoke("remove_all_static_forwardings", new object [] {
				vlans});

	}
	public System.IAsyncResult Beginremove_all_static_forwardings(string [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_static_forwardings", new object[] {
			vlans}, callback, asyncState);
	}
	public void Endremove_all_static_forwardings(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	public void remove_member(
		string [] vlans,
		NetworkingVLANMemberEntry [] [] members
	) {
		this.Invoke("remove_member", new object [] {
				vlans,
				members});

	}
	public System.IAsyncResult Beginremove_member(string [] vlans,NetworkingVLANMemberEntry [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_member", new object[] {
			vlans,
			members}, callback, asyncState);
	}
	public void Endremove_member(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_static_forwarding
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	public void remove_static_forwarding(
		string [] vlans,
		NetworkingVLANForwardingTableEntry [] [] forwarding_entries
	) {
		this.Invoke("remove_static_forwarding", new object [] {
				vlans,
				forwarding_entries});

	}
	public System.IAsyncResult Beginremove_static_forwarding(string [] vlans,NetworkingVLANForwardingTableEntry [] [] forwarding_entries, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_static_forwarding", new object[] {
			vlans,
			forwarding_entries}, callback, asyncState);
	}
	public void Endremove_static_forwarding(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_auto_lasthop
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	public void set_auto_lasthop(
		string [] vlans,
		CommonAutoLasthop [] values
	) {
		this.Invoke("set_auto_lasthop", new object [] {
				vlans,
				values});

	}
	public System.IAsyncResult Beginset_auto_lasthop(string [] vlans,CommonAutoLasthop [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_auto_lasthop", new object[] {
			vlans,
			values}, callback, asyncState);
	}
	public void Endset_auto_lasthop(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_cmp_hash_algorithm
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	public void set_cmp_hash_algorithm(
		string [] vlans,
		NetworkingVLANVLANCMPHash [] values
	) {
		this.Invoke("set_cmp_hash_algorithm", new object [] {
				vlans,
				values});

	}
	public System.IAsyncResult Beginset_cmp_hash_algorithm(string [] vlans,NetworkingVLANVLANCMPHash [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cmp_hash_algorithm", new object[] {
			vlans,
			values}, callback, asyncState);
	}
	public void Endset_cmp_hash_algorithm(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	public void set_description(
		string [] vlans,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				vlans,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] vlans,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			vlans,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_failsafe_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	public void set_failsafe_action(
		string [] vlans,
		CommonHAAction [] actions
	) {
		this.Invoke("set_failsafe_action", new object [] {
				vlans,
				actions});

	}
	public System.IAsyncResult Beginset_failsafe_action(string [] vlans,CommonHAAction [] actions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_failsafe_action", new object[] {
			vlans,
			actions}, callback, asyncState);
	}
	public void Endset_failsafe_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_failsafe_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	public void set_failsafe_state(
		string [] vlans,
		CommonEnabledState [] states
	) {
		this.Invoke("set_failsafe_state", new object [] {
				vlans,
				states});

	}
	public System.IAsyncResult Beginset_failsafe_state(string [] vlans,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_failsafe_state", new object[] {
			vlans,
			states}, callback, asyncState);
	}
	public void Endset_failsafe_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_failsafe_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	public void set_failsafe_timeout(
		string [] vlans,
		long [] timeouts
	) {
		this.Invoke("set_failsafe_timeout", new object [] {
				vlans,
				timeouts});

	}
	public System.IAsyncResult Beginset_failsafe_timeout(string [] vlans,long [] timeouts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_failsafe_timeout", new object[] {
			vlans,
			timeouts}, callback, asyncState);
	}
	public void Endset_failsafe_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_learning_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	public void set_learning_mode(
		string [] vlans,
		NetworkingLearningMode [] modes
	) {
		this.Invoke("set_learning_mode", new object [] {
				vlans,
				modes});

	}
	public System.IAsyncResult Beginset_learning_mode(string [] vlans,NetworkingLearningMode [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_learning_mode", new object[] {
			vlans,
			modes}, callback, asyncState);
	}
	public void Endset_learning_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_mac_masquerade_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	public void set_mac_masquerade_address(
		string [] vlans,
		string [] mac_masquerade_addresses
	) {
		this.Invoke("set_mac_masquerade_address", new object [] {
				vlans,
				mac_masquerade_addresses});

	}
	public System.IAsyncResult Beginset_mac_masquerade_address(string [] vlans,string [] mac_masquerade_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_mac_masquerade_address", new object[] {
			vlans,
			mac_masquerade_addresses}, callback, asyncState);
	}
	public void Endset_mac_masquerade_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_mtu
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	public void set_mtu(
		string [] vlans,
		long [] mtus
	) {
		this.Invoke("set_mtu", new object [] {
				vlans,
				mtus});

	}
	public System.IAsyncResult Beginset_mtu(string [] vlans,long [] mtus, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_mtu", new object[] {
			vlans,
			mtus}, callback, asyncState);
	}
	public void Endset_mtu(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_sflow_poll_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	public void set_sflow_poll_interval(
		string [] vlans,
		long [] intervals
	) {
		this.Invoke("set_sflow_poll_interval", new object [] {
				vlans,
				intervals});

	}
	public System.IAsyncResult Beginset_sflow_poll_interval(string [] vlans,long [] intervals, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_sflow_poll_interval", new object[] {
			vlans,
			intervals}, callback, asyncState);
	}
	public void Endset_sflow_poll_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_sflow_poll_interval_global
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	public void set_sflow_poll_interval_global(
		string [] vlans,
		CommonSFlowGlobalType [] types
	) {
		this.Invoke("set_sflow_poll_interval_global", new object [] {
				vlans,
				types});

	}
	public System.IAsyncResult Beginset_sflow_poll_interval_global(string [] vlans,CommonSFlowGlobalType [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_sflow_poll_interval_global", new object[] {
			vlans,
			types}, callback, asyncState);
	}
	public void Endset_sflow_poll_interval_global(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_sflow_sampling_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	public void set_sflow_sampling_rate(
		string [] vlans,
		long [] rates
	) {
		this.Invoke("set_sflow_sampling_rate", new object [] {
				vlans,
				rates});

	}
	public System.IAsyncResult Beginset_sflow_sampling_rate(string [] vlans,long [] rates, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_sflow_sampling_rate", new object[] {
			vlans,
			rates}, callback, asyncState);
	}
	public void Endset_sflow_sampling_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_sflow_sampling_rate_global
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	public void set_sflow_sampling_rate_global(
		string [] vlans,
		CommonSFlowGlobalType [] types
	) {
		this.Invoke("set_sflow_sampling_rate_global", new object [] {
				vlans,
				types});

	}
	public System.IAsyncResult Beginset_sflow_sampling_rate_global(string [] vlans,CommonSFlowGlobalType [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_sflow_sampling_rate_global", new object[] {
			vlans,
			types}, callback, asyncState);
	}
	public void Endset_sflow_sampling_rate_global(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_source_check_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	public void set_source_check_state(
		string [] vlans,
		CommonEnabledState [] states
	) {
		this.Invoke("set_source_check_state", new object [] {
				vlans,
				states});

	}
	public System.IAsyncResult Beginset_source_check_state(string [] vlans,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_source_check_state", new object[] {
			vlans,
			states}, callback, asyncState);
	}
	public void Endset_source_check_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_static_forwarding_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	public void set_static_forwarding_description(
		string [] vlans,
		string [] [] mac_addresses,
		string [] [] descriptions
	) {
		this.Invoke("set_static_forwarding_description", new object [] {
				vlans,
				mac_addresses,
				descriptions});

	}
	public System.IAsyncResult Beginset_static_forwarding_description(string [] vlans,string [] [] mac_addresses,string [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_static_forwarding_description", new object[] {
			vlans,
			mac_addresses,
			descriptions}, callback, asyncState);
	}
	public void Endset_static_forwarding_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_vlan_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLAN", 
		RequestNamespace="urn:iControl:Networking/VLAN", ResponseNamespace="urn:iControl:Networking/VLAN")]
	public void set_vlan_id(
		string [] vlans,
		long [] vlan_ids
	) {
		this.Invoke("set_vlan_id", new object [] {
				vlans,
				vlan_ids});

	}
	public System.IAsyncResult Beginset_vlan_id(string [] vlans,long [] vlan_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_vlan_id", new object[] {
			vlans,
			vlan_ids}, callback, asyncState);
	}
	public void Endset_vlan_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.VLAN.VLANCMPHash", Namespace = "urn:iControl")]
	public enum NetworkingVLANVLANCMPHash
	{
		CMP_HASH_UNKNOWN,
		CMP_HASH_DEFAULT,
		CMP_HASH_DESTINATION_IP,
		CMP_HASH_SOURCE_IP,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.VLAN.ForwardingTableEntry", Namespace = "urn:iControl")]
	public partial class NetworkingVLANForwardingTableEntry
	{
		private string mac_addressField;
		public string mac_address
		{
			get { return this.mac_addressField; }
			set { this.mac_addressField = value; }
		}
		private string interface_nameField;
		public string interface_name
		{
			get { return this.interface_nameField; }
			set { this.interface_nameField = value; }
		}
		private NetworkingMemberType interface_typeField;
		public NetworkingMemberType interface_type
		{
			get { return this.interface_typeField; }
			set { this.interface_typeField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.VLAN.MemberEntry", Namespace = "urn:iControl")]
	public partial class NetworkingVLANMemberEntry
	{
		private string member_nameField;
		public string member_name
		{
			get { return this.member_nameField; }
			set { this.member_nameField = value; }
		}
		private NetworkingMemberType member_typeField;
		public NetworkingMemberType member_type
		{
			get { return this.member_typeField; }
			set { this.member_typeField = value; }
		}
		private NetworkingMemberTagType tag_stateField;
		public NetworkingMemberTagType tag_state
		{
			get { return this.tag_stateField; }
			set { this.tag_stateField = value; }
		}
	};

}
