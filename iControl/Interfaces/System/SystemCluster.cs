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
	[System.Web.Services.WebServiceBindingAttribute(Name="System.ClusterBinding", Namespace="urn:iControl")]
	public partial class SystemCluster : iControlInterface {
		public SystemCluster() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// get_cluster_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Cluster", 
		RequestNamespace="urn:iControl:System/Cluster", ResponseNamespace="urn:iControl:System/Cluster")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_cluster_enabled_state(
		string [] cluster_names
	) {
		object [] results = this.Invoke("get_cluster_enabled_state", new object [] {
				cluster_names});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_cluster_enabled_state(string [] cluster_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cluster_enabled_state", new object[] {
			cluster_names}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_cluster_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cluster_ha_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Cluster", 
		RequestNamespace="urn:iControl:System/Cluster", ResponseNamespace="urn:iControl:System/Cluster")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonHAState [] get_cluster_ha_state(
		string [] cluster_names
	) {
		object [] results = this.Invoke("get_cluster_ha_state", new object [] {
				cluster_names});
		return ((CommonHAState [])(results[0]));
	}
	public System.IAsyncResult Beginget_cluster_ha_state(string [] cluster_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cluster_ha_state", new object[] {
			cluster_names}, callback, asyncState);
	}
	public CommonHAState [] Endget_cluster_ha_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonHAState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_current_primary_slot
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Cluster", 
		RequestNamespace="urn:iControl:System/Cluster", ResponseNamespace="urn:iControl:System/Cluster")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_current_primary_slot(
		string [] cluster_names
	) {
		object [] results = this.Invoke("get_current_primary_slot", new object [] {
				cluster_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_current_primary_slot(string [] cluster_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_current_primary_slot", new object[] {
			cluster_names}, callback, asyncState);
	}
	public long [] Endget_current_primary_slot(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Cluster", 
		RequestNamespace="urn:iControl:System/Cluster", ResponseNamespace="urn:iControl:System/Cluster")]
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
	// get_member_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Cluster", 
		RequestNamespace="urn:iControl:System/Cluster", ResponseNamespace="urn:iControl:System/Cluster")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_member_enabled_state(
		string [] cluster_names,
		long [] [] slot_ids
	) {
		object [] results = this.Invoke("get_member_enabled_state", new object [] {
				cluster_names,
				slot_ids});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_enabled_state(string [] cluster_names,long [] [] slot_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_enabled_state", new object[] {
			cluster_names,
			slot_ids}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_member_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_ha_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Cluster", 
		RequestNamespace="urn:iControl:System/Cluster", ResponseNamespace="urn:iControl:System/Cluster")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonHAState [] [] get_member_ha_state(
		string [] cluster_names,
		long [] [] slot_ids
	) {
		object [] results = this.Invoke("get_member_ha_state", new object [] {
				cluster_names,
				slot_ids});
		return ((CommonHAState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_ha_state(string [] cluster_names,long [] [] slot_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_ha_state", new object[] {
			cluster_names,
			slot_ids}, callback, asyncState);
	}
	public CommonHAState [] [] Endget_member_ha_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonHAState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_licensed_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Cluster", 
		RequestNamespace="urn:iControl:System/Cluster", ResponseNamespace="urn:iControl:System/Cluster")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_member_licensed_state(
		string [] cluster_names,
		long [] [] slot_ids
	) {
		object [] results = this.Invoke("get_member_licensed_state", new object [] {
				cluster_names,
				slot_ids});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_licensed_state(string [] cluster_names,long [] [] slot_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_licensed_state", new object[] {
			cluster_names,
			slot_ids}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_member_licensed_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_priming_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Cluster", 
		RequestNamespace="urn:iControl:System/Cluster", ResponseNamespace="urn:iControl:System/Cluster")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_member_priming_state(
		string [] cluster_names,
		long [] [] slot_ids
	) {
		object [] results = this.Invoke("get_member_priming_state", new object [] {
				cluster_names,
				slot_ids});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_priming_state(string [] cluster_names,long [] [] slot_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_priming_state", new object[] {
			cluster_names,
			slot_ids}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_member_priming_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_min_up_members
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Cluster", 
		RequestNamespace="urn:iControl:System/Cluster", ResponseNamespace="urn:iControl:System/Cluster")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_min_up_members(
		string [] cluster_names
	) {
		object [] results = this.Invoke("get_min_up_members", new object [] {
				cluster_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_min_up_members(string [] cluster_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_min_up_members", new object[] {
			cluster_names}, callback, asyncState);
	}
	public long [] Endget_min_up_members(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_min_up_members_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Cluster", 
		RequestNamespace="urn:iControl:System/Cluster", ResponseNamespace="urn:iControl:System/Cluster")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonHAAction [] get_min_up_members_action(
		string [] cluster_names
	) {
		object [] results = this.Invoke("get_min_up_members_action", new object [] {
				cluster_names});
		return ((CommonHAAction [])(results[0]));
	}
	public System.IAsyncResult Beginget_min_up_members_action(string [] cluster_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_min_up_members_action", new object[] {
			cluster_names}, callback, asyncState);
	}
	public CommonHAAction [] Endget_min_up_members_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonHAAction [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_min_up_members_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Cluster", 
		RequestNamespace="urn:iControl:System/Cluster", ResponseNamespace="urn:iControl:System/Cluster")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_min_up_members_state(
		string [] cluster_names
	) {
		object [] results = this.Invoke("get_min_up_members_state", new object [] {
				cluster_names});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_min_up_members_state(string [] cluster_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_min_up_members_state", new object[] {
			cluster_names}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_min_up_members_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_slot_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Cluster", 
		RequestNamespace="urn:iControl:System/Cluster", ResponseNamespace="urn:iControl:System/Cluster")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_slot_id(
		string [] cluster_names
	) {
		object [] results = this.Invoke("get_slot_id", new object [] {
				cluster_names});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_slot_id(string [] cluster_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_slot_id", new object[] {
			cluster_names}, callback, asyncState);
	}
	public long [] [] Endget_slot_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Cluster", 
		RequestNamespace="urn:iControl:System/Cluster", ResponseNamespace="urn:iControl:System/Cluster")]
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
	// is_clustered_environment
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Cluster", 
		RequestNamespace="urn:iControl:System/Cluster", ResponseNamespace="urn:iControl:System/Cluster")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool is_clustered_environment(

	) {
		object [] results = this.Invoke("is_clustered_environment", new object [0]);
		return ((bool)(results[0]));
	}
	public System.IAsyncResult Beginis_clustered_environment(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("is_clustered_environment", new object[0], callback, asyncState);
	}
	public bool Endis_clustered_environment(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool)(results[0]));
	}

	//-----------------------------------------------------------------------
	// set_cluster_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Cluster", 
		RequestNamespace="urn:iControl:System/Cluster", ResponseNamespace="urn:iControl:System/Cluster")]
	public void set_cluster_enabled_state(
		string [] cluster_names,
		CommonEnabledState [] cluster_states
	) {
		this.Invoke("set_cluster_enabled_state", new object [] {
				cluster_names,
				cluster_states});

	}
	public System.IAsyncResult Beginset_cluster_enabled_state(string [] cluster_names,CommonEnabledState [] cluster_states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cluster_enabled_state", new object[] {
			cluster_names,
			cluster_states}, callback, asyncState);
	}
	public void Endset_cluster_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_current_primary_slot
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Cluster", 
		RequestNamespace="urn:iControl:System/Cluster", ResponseNamespace="urn:iControl:System/Cluster")]
	public void set_current_primary_slot(
		string [] cluster_names,
		long [] primary_slots
	) {
		this.Invoke("set_current_primary_slot", new object [] {
				cluster_names,
				primary_slots});

	}
	public System.IAsyncResult Beginset_current_primary_slot(string [] cluster_names,long [] primary_slots, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_current_primary_slot", new object[] {
			cluster_names,
			primary_slots}, callback, asyncState);
	}
	public void Endset_current_primary_slot(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_member_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Cluster", 
		RequestNamespace="urn:iControl:System/Cluster", ResponseNamespace="urn:iControl:System/Cluster")]
	public void set_member_enabled_state(
		string [] cluster_names,
		long [] [] slot_ids,
		CommonEnabledState [] [] member_states
	) {
		this.Invoke("set_member_enabled_state", new object [] {
				cluster_names,
				slot_ids,
				member_states});

	}
	public System.IAsyncResult Beginset_member_enabled_state(string [] cluster_names,long [] [] slot_ids,CommonEnabledState [] [] member_states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_member_enabled_state", new object[] {
			cluster_names,
			slot_ids,
			member_states}, callback, asyncState);
	}
	public void Endset_member_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_member_priming_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Cluster", 
		RequestNamespace="urn:iControl:System/Cluster", ResponseNamespace="urn:iControl:System/Cluster")]
	public void set_member_priming_state(
		string [] cluster_names,
		long [] [] slot_ids,
		CommonEnabledState [] [] priming_states
	) {
		this.Invoke("set_member_priming_state", new object [] {
				cluster_names,
				slot_ids,
				priming_states});

	}
	public System.IAsyncResult Beginset_member_priming_state(string [] cluster_names,long [] [] slot_ids,CommonEnabledState [] [] priming_states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_member_priming_state", new object[] {
			cluster_names,
			slot_ids,
			priming_states}, callback, asyncState);
	}
	public void Endset_member_priming_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_min_up_members
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Cluster", 
		RequestNamespace="urn:iControl:System/Cluster", ResponseNamespace="urn:iControl:System/Cluster")]
	public void set_min_up_members(
		string [] cluster_names,
		long [] min_up_members
	) {
		this.Invoke("set_min_up_members", new object [] {
				cluster_names,
				min_up_members});

	}
	public System.IAsyncResult Beginset_min_up_members(string [] cluster_names,long [] min_up_members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_min_up_members", new object[] {
			cluster_names,
			min_up_members}, callback, asyncState);
	}
	public void Endset_min_up_members(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_min_up_members_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Cluster", 
		RequestNamespace="urn:iControl:System/Cluster", ResponseNamespace="urn:iControl:System/Cluster")]
	public void set_min_up_members_action(
		string [] cluster_names,
		CommonHAAction [] min_up_actions
	) {
		this.Invoke("set_min_up_members_action", new object [] {
				cluster_names,
				min_up_actions});

	}
	public System.IAsyncResult Beginset_min_up_members_action(string [] cluster_names,CommonHAAction [] min_up_actions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_min_up_members_action", new object[] {
			cluster_names,
			min_up_actions}, callback, asyncState);
	}
	public void Endset_min_up_members_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_min_up_members_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Cluster", 
		RequestNamespace="urn:iControl:System/Cluster", ResponseNamespace="urn:iControl:System/Cluster")]
	public void set_min_up_members_state(
		string [] cluster_names,
		CommonEnabledState [] min_up_states
	) {
		this.Invoke("set_min_up_members_state", new object [] {
				cluster_names,
				min_up_states});

	}
	public System.IAsyncResult Beginset_min_up_members_state(string [] cluster_names,CommonEnabledState [] min_up_states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_min_up_members_state", new object[] {
			cluster_names,
			min_up_states}, callback, asyncState);
	}
	public void Endset_min_up_members_state(System.IAsyncResult asyncResult) {
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
