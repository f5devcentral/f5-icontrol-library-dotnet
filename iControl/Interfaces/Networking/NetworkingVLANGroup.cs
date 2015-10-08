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
	[System.Web.Services.WebServiceBindingAttribute(Name="Networking.VLANGroupBinding", Namespace="urn:iControl")]
	public partial class NetworkingVLANGroup : iControlInterface {
		public NetworkingVLANGroup() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_global_proxy_exclusion
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLANGroup", 
		RequestNamespace="urn:iControl:Networking/VLANGroup", ResponseNamespace="urn:iControl:Networking/VLANGroup")]
	public void add_global_proxy_exclusion(
		string [] addresses
	) {
		this.Invoke("add_global_proxy_exclusion", new object [] {
				addresses});

	}
	public System.IAsyncResult Beginadd_global_proxy_exclusion(string [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_global_proxy_exclusion", new object[] {
			addresses}, callback, asyncState);
	}
	public void Endadd_global_proxy_exclusion(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLANGroup", 
		RequestNamespace="urn:iControl:Networking/VLANGroup", ResponseNamespace="urn:iControl:Networking/VLANGroup")]
	public void add_member(
		string [] vlan_groups,
		string [] [] member_vlans
	) {
		this.Invoke("add_member", new object [] {
				vlan_groups,
				member_vlans});

	}
	public System.IAsyncResult Beginadd_member(string [] vlan_groups,string [] [] member_vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_member", new object[] {
			vlan_groups,
			member_vlans}, callback, asyncState);
	}
	public void Endadd_member(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_proxy_exclusion
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLANGroup", 
		RequestNamespace="urn:iControl:Networking/VLANGroup", ResponseNamespace="urn:iControl:Networking/VLANGroup")]
	public void add_proxy_exclusion(
		string [] vlan_groups,
		string [] [] addresses
	) {
		this.Invoke("add_proxy_exclusion", new object [] {
				vlan_groups,
				addresses});

	}
	public System.IAsyncResult Beginadd_proxy_exclusion(string [] vlan_groups,string [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_proxy_exclusion", new object[] {
			vlan_groups,
			addresses}, callback, asyncState);
	}
	public void Endadd_proxy_exclusion(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLANGroup", 
		RequestNamespace="urn:iControl:Networking/VLANGroup", ResponseNamespace="urn:iControl:Networking/VLANGroup")]
	public void create(
		string [] vlan_groups,
		long [] vlan_ids,
		string [] [] member_vlans
	) {
		this.Invoke("create", new object [] {
				vlan_groups,
				vlan_ids,
				member_vlans});

	}
	public System.IAsyncResult Begincreate(string [] vlan_groups,long [] vlan_ids,string [] [] member_vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			vlan_groups,
			vlan_ids,
			member_vlans}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLANGroup", 
		RequestNamespace="urn:iControl:Networking/VLANGroup", ResponseNamespace="urn:iControl:Networking/VLANGroup")]
	public void create_v2(
		string [] vlan_groups,
		string [] [] member_vlans
	) {
		this.Invoke("create_v2", new object [] {
				vlan_groups,
				member_vlans});

	}
	public System.IAsyncResult Begincreate_v2(string [] vlan_groups,string [] [] member_vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_v2", new object[] {
			vlan_groups,
			member_vlans}, callback, asyncState);
	}
	public void Endcreate_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_vlan_groups
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLANGroup", 
		RequestNamespace="urn:iControl:Networking/VLANGroup", ResponseNamespace="urn:iControl:Networking/VLANGroup")]
	public void delete_all_vlan_groups(

	) {
		this.Invoke("delete_all_vlan_groups", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_vlan_groups(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_vlan_groups", new object[0], callback, asyncState);
	}
	public void Enddelete_all_vlan_groups(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_vlan_group
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLANGroup", 
		RequestNamespace="urn:iControl:Networking/VLANGroup", ResponseNamespace="urn:iControl:Networking/VLANGroup")]
	public void delete_vlan_group(
		string [] vlan_groups
	) {
		this.Invoke("delete_vlan_group", new object [] {
				vlan_groups});

	}
	public System.IAsyncResult Begindelete_vlan_group(string [] vlan_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_vlan_group", new object[] {
			vlan_groups}, callback, asyncState);
	}
	public void Enddelete_vlan_group(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_auto_lasthop
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLANGroup", 
		RequestNamespace="urn:iControl:Networking/VLANGroup", ResponseNamespace="urn:iControl:Networking/VLANGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonAutoLasthop [] get_auto_lasthop(
		string [] vlan_groups
	) {
		object [] results = this.Invoke("get_auto_lasthop", new object [] {
				vlan_groups});
		return ((CommonAutoLasthop [])(results[0]));
	}
	public System.IAsyncResult Beginget_auto_lasthop(string [] vlan_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_auto_lasthop", new object[] {
			vlan_groups}, callback, asyncState);
	}
	public CommonAutoLasthop [] Endget_auto_lasthop(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonAutoLasthop [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_bridge_all_traffic_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLANGroup", 
		RequestNamespace="urn:iControl:Networking/VLANGroup", ResponseNamespace="urn:iControl:Networking/VLANGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_bridge_all_traffic_state(
		string [] vlan_groups
	) {
		object [] results = this.Invoke("get_bridge_all_traffic_state", new object [] {
				vlan_groups});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_bridge_all_traffic_state(string [] vlan_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_bridge_all_traffic_state", new object[] {
			vlan_groups}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_bridge_all_traffic_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_bridge_in_standby_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLANGroup", 
		RequestNamespace="urn:iControl:Networking/VLANGroup", ResponseNamespace="urn:iControl:Networking/VLANGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_bridge_in_standby_state(
		string [] vlan_groups
	) {
		object [] results = this.Invoke("get_bridge_in_standby_state", new object [] {
				vlan_groups});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_bridge_in_standby_state(string [] vlan_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_bridge_in_standby_state", new object[] {
			vlan_groups}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_bridge_in_standby_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_bridge_multicast_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLANGroup", 
		RequestNamespace="urn:iControl:Networking/VLANGroup", ResponseNamespace="urn:iControl:Networking/VLANGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_bridge_multicast_state(
		string [] vlan_groups
	) {
		object [] results = this.Invoke("get_bridge_multicast_state", new object [] {
				vlan_groups});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_bridge_multicast_state(string [] vlan_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_bridge_multicast_state", new object[] {
			vlan_groups}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_bridge_multicast_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLANGroup", 
		RequestNamespace="urn:iControl:Networking/VLANGroup", ResponseNamespace="urn:iControl:Networking/VLANGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] vlan_groups
	) {
		object [] results = this.Invoke("get_description", new object [] {
				vlan_groups});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] vlan_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			vlan_groups}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_global_proxy_exclusion
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLANGroup", 
		RequestNamespace="urn:iControl:Networking/VLANGroup", ResponseNamespace="urn:iControl:Networking/VLANGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_global_proxy_exclusion(

	) {
		object [] results = this.Invoke("get_global_proxy_exclusion", new object [0]);
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_global_proxy_exclusion(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_global_proxy_exclusion", new object[0], callback, asyncState);
	}
	public string [] Endget_global_proxy_exclusion(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLANGroup", 
		RequestNamespace="urn:iControl:Networking/VLANGroup", ResponseNamespace="urn:iControl:Networking/VLANGroup")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLANGroup", 
		RequestNamespace="urn:iControl:Networking/VLANGroup", ResponseNamespace="urn:iControl:Networking/VLANGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_mac_masquerade_address(
		string [] vlan_groups
	) {
		object [] results = this.Invoke("get_mac_masquerade_address", new object [] {
				vlan_groups});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_mac_masquerade_address(string [] vlan_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_mac_masquerade_address", new object[] {
			vlan_groups}, callback, asyncState);
	}
	public string [] Endget_mac_masquerade_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLANGroup", 
		RequestNamespace="urn:iControl:Networking/VLANGroup", ResponseNamespace="urn:iControl:Networking/VLANGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_member(
		string [] vlan_groups
	) {
		object [] results = this.Invoke("get_member", new object [] {
				vlan_groups});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member(string [] vlan_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member", new object[] {
			vlan_groups}, callback, asyncState);
	}
	public string [] [] Endget_member(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_proxy_exclusion
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLANGroup", 
		RequestNamespace="urn:iControl:Networking/VLANGroup", ResponseNamespace="urn:iControl:Networking/VLANGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_proxy_exclusion(
		string [] vlan_groups
	) {
		object [] results = this.Invoke("get_proxy_exclusion", new object [] {
				vlan_groups});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_proxy_exclusion(string [] vlan_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_proxy_exclusion", new object[] {
			vlan_groups}, callback, asyncState);
	}
	public string [] [] Endget_proxy_exclusion(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_transparency_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLANGroup", 
		RequestNamespace="urn:iControl:Networking/VLANGroup", ResponseNamespace="urn:iControl:Networking/VLANGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingVLANGroupVLANGroupTransparency [] get_transparency_mode(
		string [] vlan_groups
	) {
		object [] results = this.Invoke("get_transparency_mode", new object [] {
				vlan_groups});
		return ((NetworkingVLANGroupVLANGroupTransparency [])(results[0]));
	}
	public System.IAsyncResult Beginget_transparency_mode(string [] vlan_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_transparency_mode", new object[] {
			vlan_groups}, callback, asyncState);
	}
	public NetworkingVLANGroupVLANGroupTransparency [] Endget_transparency_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingVLANGroupVLANGroupTransparency [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_true_mac_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLANGroup", 
		RequestNamespace="urn:iControl:Networking/VLANGroup", ResponseNamespace="urn:iControl:Networking/VLANGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_true_mac_address(
		string [] vlan_groups
	) {
		object [] results = this.Invoke("get_true_mac_address", new object [] {
				vlan_groups});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_true_mac_address(string [] vlan_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_true_mac_address", new object[] {
			vlan_groups}, callback, asyncState);
	}
	public string [] Endget_true_mac_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLANGroup", 
		RequestNamespace="urn:iControl:Networking/VLANGroup", ResponseNamespace="urn:iControl:Networking/VLANGroup")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLANGroup", 
		RequestNamespace="urn:iControl:Networking/VLANGroup", ResponseNamespace="urn:iControl:Networking/VLANGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_vlan_id(
		string [] vlan_groups
	) {
		object [] results = this.Invoke("get_vlan_id", new object [] {
				vlan_groups});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_vlan_id(string [] vlan_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_vlan_id", new object[] {
			vlan_groups}, callback, asyncState);
	}
	public long [] Endget_vlan_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// remove_all_global_proxy_exclusions
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLANGroup", 
		RequestNamespace="urn:iControl:Networking/VLANGroup", ResponseNamespace="urn:iControl:Networking/VLANGroup")]
	public void remove_all_global_proxy_exclusions(

	) {
		this.Invoke("remove_all_global_proxy_exclusions", new object [0]);

	}
	public System.IAsyncResult Beginremove_all_global_proxy_exclusions(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_global_proxy_exclusions", new object[0], callback, asyncState);
	}
	public void Endremove_all_global_proxy_exclusions(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_members
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLANGroup", 
		RequestNamespace="urn:iControl:Networking/VLANGroup", ResponseNamespace="urn:iControl:Networking/VLANGroup")]
	public void remove_all_members(
		string [] vlan_groups
	) {
		this.Invoke("remove_all_members", new object [] {
				vlan_groups});

	}
	public System.IAsyncResult Beginremove_all_members(string [] vlan_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_members", new object[] {
			vlan_groups}, callback, asyncState);
	}
	public void Endremove_all_members(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_proxy_exclusions
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLANGroup", 
		RequestNamespace="urn:iControl:Networking/VLANGroup", ResponseNamespace="urn:iControl:Networking/VLANGroup")]
	public void remove_all_proxy_exclusions(
		string [] vlan_groups
	) {
		this.Invoke("remove_all_proxy_exclusions", new object [] {
				vlan_groups});

	}
	public System.IAsyncResult Beginremove_all_proxy_exclusions(string [] vlan_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_proxy_exclusions", new object[] {
			vlan_groups}, callback, asyncState);
	}
	public void Endremove_all_proxy_exclusions(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_global_proxy_exclusion
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLANGroup", 
		RequestNamespace="urn:iControl:Networking/VLANGroup", ResponseNamespace="urn:iControl:Networking/VLANGroup")]
	public void remove_global_proxy_exclusion(
		string [] addresses
	) {
		this.Invoke("remove_global_proxy_exclusion", new object [] {
				addresses});

	}
	public System.IAsyncResult Beginremove_global_proxy_exclusion(string [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_global_proxy_exclusion", new object[] {
			addresses}, callback, asyncState);
	}
	public void Endremove_global_proxy_exclusion(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLANGroup", 
		RequestNamespace="urn:iControl:Networking/VLANGroup", ResponseNamespace="urn:iControl:Networking/VLANGroup")]
	public void remove_member(
		string [] vlan_groups,
		string [] [] member_vlans
	) {
		this.Invoke("remove_member", new object [] {
				vlan_groups,
				member_vlans});

	}
	public System.IAsyncResult Beginremove_member(string [] vlan_groups,string [] [] member_vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_member", new object[] {
			vlan_groups,
			member_vlans}, callback, asyncState);
	}
	public void Endremove_member(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_proxy_exclusion
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLANGroup", 
		RequestNamespace="urn:iControl:Networking/VLANGroup", ResponseNamespace="urn:iControl:Networking/VLANGroup")]
	public void remove_proxy_exclusion(
		string [] vlan_groups,
		string [] [] addresses
	) {
		this.Invoke("remove_proxy_exclusion", new object [] {
				vlan_groups,
				addresses});

	}
	public System.IAsyncResult Beginremove_proxy_exclusion(string [] vlan_groups,string [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_proxy_exclusion", new object[] {
			vlan_groups,
			addresses}, callback, asyncState);
	}
	public void Endremove_proxy_exclusion(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_auto_lasthop
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLANGroup", 
		RequestNamespace="urn:iControl:Networking/VLANGroup", ResponseNamespace="urn:iControl:Networking/VLANGroup")]
	public void set_auto_lasthop(
		string [] vlan_groups,
		CommonAutoLasthop [] values
	) {
		this.Invoke("set_auto_lasthop", new object [] {
				vlan_groups,
				values});

	}
	public System.IAsyncResult Beginset_auto_lasthop(string [] vlan_groups,CommonAutoLasthop [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_auto_lasthop", new object[] {
			vlan_groups,
			values}, callback, asyncState);
	}
	public void Endset_auto_lasthop(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_bridge_all_traffic_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLANGroup", 
		RequestNamespace="urn:iControl:Networking/VLANGroup", ResponseNamespace="urn:iControl:Networking/VLANGroup")]
	public void set_bridge_all_traffic_state(
		string [] vlan_groups,
		CommonEnabledState [] states
	) {
		this.Invoke("set_bridge_all_traffic_state", new object [] {
				vlan_groups,
				states});

	}
	public System.IAsyncResult Beginset_bridge_all_traffic_state(string [] vlan_groups,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_bridge_all_traffic_state", new object[] {
			vlan_groups,
			states}, callback, asyncState);
	}
	public void Endset_bridge_all_traffic_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_bridge_in_standby_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLANGroup", 
		RequestNamespace="urn:iControl:Networking/VLANGroup", ResponseNamespace="urn:iControl:Networking/VLANGroup")]
	public void set_bridge_in_standby_state(
		string [] vlan_groups,
		CommonEnabledState [] states
	) {
		this.Invoke("set_bridge_in_standby_state", new object [] {
				vlan_groups,
				states});

	}
	public System.IAsyncResult Beginset_bridge_in_standby_state(string [] vlan_groups,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_bridge_in_standby_state", new object[] {
			vlan_groups,
			states}, callback, asyncState);
	}
	public void Endset_bridge_in_standby_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_bridge_multicast_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLANGroup", 
		RequestNamespace="urn:iControl:Networking/VLANGroup", ResponseNamespace="urn:iControl:Networking/VLANGroup")]
	public void set_bridge_multicast_state(
		string [] vlan_groups,
		CommonEnabledState [] states
	) {
		this.Invoke("set_bridge_multicast_state", new object [] {
				vlan_groups,
				states});

	}
	public System.IAsyncResult Beginset_bridge_multicast_state(string [] vlan_groups,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_bridge_multicast_state", new object[] {
			vlan_groups,
			states}, callback, asyncState);
	}
	public void Endset_bridge_multicast_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLANGroup", 
		RequestNamespace="urn:iControl:Networking/VLANGroup", ResponseNamespace="urn:iControl:Networking/VLANGroup")]
	public void set_description(
		string [] vlan_groups,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				vlan_groups,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] vlan_groups,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			vlan_groups,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_mac_masquerade_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLANGroup", 
		RequestNamespace="urn:iControl:Networking/VLANGroup", ResponseNamespace="urn:iControl:Networking/VLANGroup")]
	public void set_mac_masquerade_address(
		string [] vlan_groups,
		string [] mac_masquerade_addresses
	) {
		this.Invoke("set_mac_masquerade_address", new object [] {
				vlan_groups,
				mac_masquerade_addresses});

	}
	public System.IAsyncResult Beginset_mac_masquerade_address(string [] vlan_groups,string [] mac_masquerade_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_mac_masquerade_address", new object[] {
			vlan_groups,
			mac_masquerade_addresses}, callback, asyncState);
	}
	public void Endset_mac_masquerade_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_transparency_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLANGroup", 
		RequestNamespace="urn:iControl:Networking/VLANGroup", ResponseNamespace="urn:iControl:Networking/VLANGroup")]
	public void set_transparency_mode(
		string [] vlan_groups,
		NetworkingVLANGroupVLANGroupTransparency [] modes
	) {
		this.Invoke("set_transparency_mode", new object [] {
				vlan_groups,
				modes});

	}
	public System.IAsyncResult Beginset_transparency_mode(string [] vlan_groups,NetworkingVLANGroupVLANGroupTransparency [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_transparency_mode", new object[] {
			vlan_groups,
			modes}, callback, asyncState);
	}
	public void Endset_transparency_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_vlan_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/VLANGroup", 
		RequestNamespace="urn:iControl:Networking/VLANGroup", ResponseNamespace="urn:iControl:Networking/VLANGroup")]
	public void set_vlan_id(
		string [] vlan_groups,
		long [] vlan_ids
	) {
		this.Invoke("set_vlan_id", new object [] {
				vlan_groups,
				vlan_ids});

	}
	public System.IAsyncResult Beginset_vlan_id(string [] vlan_groups,long [] vlan_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_vlan_id", new object[] {
			vlan_groups,
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.VLANGroup.VLANGroupTransparency", Namespace = "urn:iControl")]
	public enum NetworkingVLANGroupVLANGroupTransparency
	{
		VLANGROUP_TRANSPARENT,
		VLANGROUP_OPAQUE,
		VLANGROUP_TRANSLUCENT,
	}

	//=======================================================================
	// Structs
	//=======================================================================

}
