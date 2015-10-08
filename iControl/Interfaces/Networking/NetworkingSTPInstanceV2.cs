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
	[System.Web.Services.WebServiceBindingAttribute(Name="Networking.STPInstanceV2Binding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(NetworkingSTPInstanceV2PathCost))]
	public partial class NetworkingSTPInstanceV2 : iControlInterface {
		public NetworkingSTPInstanceV2() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPInstanceV2", 
		RequestNamespace="urn:iControl:Networking/STPInstanceV2", ResponseNamespace="urn:iControl:Networking/STPInstanceV2")]
	public void add_vlan(
		string [] stp_instances,
		string [] [] vlan_names
	) {
		this.Invoke("add_vlan", new object [] {
				stp_instances,
				vlan_names});

	}
	public System.IAsyncResult Beginadd_vlan(string [] stp_instances,string [] [] vlan_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_vlan", new object[] {
			stp_instances,
			vlan_names}, callback, asyncState);
	}
	public void Endadd_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPInstanceV2", 
		RequestNamespace="urn:iControl:Networking/STPInstanceV2", ResponseNamespace="urn:iControl:Networking/STPInstanceV2")]
	public void create(
		string [] stp_instances,
		long [] ids,
		long [] priorities,
		string [] [] vlan_names
	) {
		this.Invoke("create", new object [] {
				stp_instances,
				ids,
				priorities,
				vlan_names});

	}
	public System.IAsyncResult Begincreate(string [] stp_instances,long [] ids,long [] priorities,string [] [] vlan_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			stp_instances,
			ids,
			priorities,
			vlan_names}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_instances
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPInstanceV2", 
		RequestNamespace="urn:iControl:Networking/STPInstanceV2", ResponseNamespace="urn:iControl:Networking/STPInstanceV2")]
	public void delete_all_instances(

	) {
		this.Invoke("delete_all_instances", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_instances(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_instances", new object[0], callback, asyncState);
	}
	public void Enddelete_all_instances(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_instance
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPInstanceV2", 
		RequestNamespace="urn:iControl:Networking/STPInstanceV2", ResponseNamespace="urn:iControl:Networking/STPInstanceV2")]
	public void delete_instance(
		string [] stp_instances
	) {
		this.Invoke("delete_instance", new object [] {
				stp_instances});

	}
	public System.IAsyncResult Begindelete_instance(string [] stp_instances, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_instance", new object[] {
			stp_instances}, callback, asyncState);
	}
	public void Enddelete_instance(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_bridge_priority
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPInstanceV2", 
		RequestNamespace="urn:iControl:Networking/STPInstanceV2", ResponseNamespace="urn:iControl:Networking/STPInstanceV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_bridge_priority(
		string [] stp_instances
	) {
		object [] results = this.Invoke("get_bridge_priority", new object [] {
				stp_instances});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_bridge_priority(string [] stp_instances, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_bridge_priority", new object[] {
			stp_instances}, callback, asyncState);
	}
	public long [] Endget_bridge_priority(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPInstanceV2", 
		RequestNamespace="urn:iControl:Networking/STPInstanceV2", ResponseNamespace="urn:iControl:Networking/STPInstanceV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] stp_instances
	) {
		object [] results = this.Invoke("get_description", new object [] {
				stp_instances});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] stp_instances, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			stp_instances}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_instance_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPInstanceV2", 
		RequestNamespace="urn:iControl:Networking/STPInstanceV2", ResponseNamespace="urn:iControl:Networking/STPInstanceV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_instance_id(
		string [] stp_instances
	) {
		object [] results = this.Invoke("get_instance_id", new object [] {
				stp_instances});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_instance_id(string [] stp_instances, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_instance_id", new object[] {
			stp_instances}, callback, asyncState);
	}
	public long [] Endget_instance_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_interface_active_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPInstanceV2", 
		RequestNamespace="urn:iControl:Networking/STPInstanceV2", ResponseNamespace="urn:iControl:Networking/STPInstanceV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingSTPStateType [] [] get_interface_active_state(
		string [] stp_instances,
		string [] [] interfaces
	) {
		object [] results = this.Invoke("get_interface_active_state", new object [] {
				stp_instances,
				interfaces});
		return ((NetworkingSTPStateType [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_interface_active_state(string [] stp_instances,string [] [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_interface_active_state", new object[] {
			stp_instances,
			interfaces}, callback, asyncState);
	}
	public NetworkingSTPStateType [] [] Endget_interface_active_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingSTPStateType [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_interface_path_cost
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPInstanceV2", 
		RequestNamespace="urn:iControl:Networking/STPInstanceV2", ResponseNamespace="urn:iControl:Networking/STPInstanceV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingSTPInstanceV2PathCost [] [] get_interface_path_cost(
		string [] stp_instances,
		string [] [] interfaces,
		NetworkingSTPInstanceV2PathCostType [] [] path_cost_types
	) {
		object [] results = this.Invoke("get_interface_path_cost", new object [] {
				stp_instances,
				interfaces,
				path_cost_types});
		return ((NetworkingSTPInstanceV2PathCost [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_interface_path_cost(string [] stp_instances,string [] [] interfaces,NetworkingSTPInstanceV2PathCostType [] [] path_cost_types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_interface_path_cost", new object[] {
			stp_instances,
			interfaces,
			path_cost_types}, callback, asyncState);
	}
	public NetworkingSTPInstanceV2PathCost [] [] Endget_interface_path_cost(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingSTPInstanceV2PathCost [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_interface_priority
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPInstanceV2", 
		RequestNamespace="urn:iControl:Networking/STPInstanceV2", ResponseNamespace="urn:iControl:Networking/STPInstanceV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_interface_priority(
		string [] stp_instances,
		string [] [] interfaces
	) {
		object [] results = this.Invoke("get_interface_priority", new object [] {
				stp_instances,
				interfaces});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_interface_priority(string [] stp_instances,string [] [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_interface_priority", new object[] {
			stp_instances,
			interfaces}, callback, asyncState);
	}
	public long [] [] Endget_interface_priority(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_interface_requested_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPInstanceV2", 
		RequestNamespace="urn:iControl:Networking/STPInstanceV2", ResponseNamespace="urn:iControl:Networking/STPInstanceV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingSTPStateType [] [] get_interface_requested_state(
		string [] stp_instances,
		string [] [] interfaces
	) {
		object [] results = this.Invoke("get_interface_requested_state", new object [] {
				stp_instances,
				interfaces});
		return ((NetworkingSTPStateType [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_interface_requested_state(string [] stp_instances,string [] [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_interface_requested_state", new object[] {
			stp_instances,
			interfaces}, callback, asyncState);
	}
	public NetworkingSTPStateType [] [] Endget_interface_requested_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingSTPStateType [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_interface_role
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPInstanceV2", 
		RequestNamespace="urn:iControl:Networking/STPInstanceV2", ResponseNamespace="urn:iControl:Networking/STPInstanceV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingSTPRoleType [] [] get_interface_role(
		string [] stp_instances,
		string [] [] interfaces
	) {
		object [] results = this.Invoke("get_interface_role", new object [] {
				stp_instances,
				interfaces});
		return ((NetworkingSTPRoleType [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_interface_role(string [] stp_instances,string [] [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_interface_role", new object[] {
			stp_instances,
			interfaces}, callback, asyncState);
	}
	public NetworkingSTPRoleType [] [] Endget_interface_role(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingSTPRoleType [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPInstanceV2", 
		RequestNamespace="urn:iControl:Networking/STPInstanceV2", ResponseNamespace="urn:iControl:Networking/STPInstanceV2")]
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
	// get_regional_root_bridge_mac_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPInstanceV2", 
		RequestNamespace="urn:iControl:Networking/STPInstanceV2", ResponseNamespace="urn:iControl:Networking/STPInstanceV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_regional_root_bridge_mac_address(
		string [] stp_instances
	) {
		object [] results = this.Invoke("get_regional_root_bridge_mac_address", new object [] {
				stp_instances});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_regional_root_bridge_mac_address(string [] stp_instances, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_regional_root_bridge_mac_address", new object[] {
			stp_instances}, callback, asyncState);
	}
	public string [] Endget_regional_root_bridge_mac_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_root_bridge_mac_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPInstanceV2", 
		RequestNamespace="urn:iControl:Networking/STPInstanceV2", ResponseNamespace="urn:iControl:Networking/STPInstanceV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_root_bridge_mac_address(
		string [] stp_instances
	) {
		object [] results = this.Invoke("get_root_bridge_mac_address", new object [] {
				stp_instances});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_root_bridge_mac_address(string [] stp_instances, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_root_bridge_mac_address", new object[] {
			stp_instances}, callback, asyncState);
	}
	public string [] Endget_root_bridge_mac_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPInstanceV2", 
		RequestNamespace="urn:iControl:Networking/STPInstanceV2", ResponseNamespace="urn:iControl:Networking/STPInstanceV2")]
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
	// get_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPInstanceV2", 
		RequestNamespace="urn:iControl:Networking/STPInstanceV2", ResponseNamespace="urn:iControl:Networking/STPInstanceV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_vlan(
		string [] stp_instances
	) {
		object [] results = this.Invoke("get_vlan", new object [] {
				stp_instances});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_vlan(string [] stp_instances, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_vlan", new object[] {
			stp_instances}, callback, asyncState);
	}
	public string [] [] Endget_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// remove_all_vlans
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPInstanceV2", 
		RequestNamespace="urn:iControl:Networking/STPInstanceV2", ResponseNamespace="urn:iControl:Networking/STPInstanceV2")]
	public void remove_all_vlans(
		string [] stp_instances
	) {
		this.Invoke("remove_all_vlans", new object [] {
				stp_instances});

	}
	public System.IAsyncResult Beginremove_all_vlans(string [] stp_instances, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_vlans", new object[] {
			stp_instances}, callback, asyncState);
	}
	public void Endremove_all_vlans(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPInstanceV2", 
		RequestNamespace="urn:iControl:Networking/STPInstanceV2", ResponseNamespace="urn:iControl:Networking/STPInstanceV2")]
	public void remove_vlan(
		string [] stp_instances,
		string [] [] vlan_names
	) {
		this.Invoke("remove_vlan", new object [] {
				stp_instances,
				vlan_names});

	}
	public System.IAsyncResult Beginremove_vlan(string [] stp_instances,string [] [] vlan_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_vlan", new object[] {
			stp_instances,
			vlan_names}, callback, asyncState);
	}
	public void Endremove_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_bridge_priority
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPInstanceV2", 
		RequestNamespace="urn:iControl:Networking/STPInstanceV2", ResponseNamespace="urn:iControl:Networking/STPInstanceV2")]
	public void set_bridge_priority(
		string [] stp_instances,
		long [] priorities
	) {
		this.Invoke("set_bridge_priority", new object [] {
				stp_instances,
				priorities});

	}
	public System.IAsyncResult Beginset_bridge_priority(string [] stp_instances,long [] priorities, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_bridge_priority", new object[] {
			stp_instances,
			priorities}, callback, asyncState);
	}
	public void Endset_bridge_priority(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPInstanceV2", 
		RequestNamespace="urn:iControl:Networking/STPInstanceV2", ResponseNamespace="urn:iControl:Networking/STPInstanceV2")]
	public void set_description(
		string [] stp_instances,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				stp_instances,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] stp_instances,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			stp_instances,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_interface_path_cost
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPInstanceV2", 
		RequestNamespace="urn:iControl:Networking/STPInstanceV2", ResponseNamespace="urn:iControl:Networking/STPInstanceV2")]
	public void set_interface_path_cost(
		string [] stp_instances,
		string [] [] interfaces,
		NetworkingSTPInstanceV2PathCost [] [] path_costs
	) {
		this.Invoke("set_interface_path_cost", new object [] {
				stp_instances,
				interfaces,
				path_costs});

	}
	public System.IAsyncResult Beginset_interface_path_cost(string [] stp_instances,string [] [] interfaces,NetworkingSTPInstanceV2PathCost [] [] path_costs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_interface_path_cost", new object[] {
			stp_instances,
			interfaces,
			path_costs}, callback, asyncState);
	}
	public void Endset_interface_path_cost(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_interface_priority
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPInstanceV2", 
		RequestNamespace="urn:iControl:Networking/STPInstanceV2", ResponseNamespace="urn:iControl:Networking/STPInstanceV2")]
	public void set_interface_priority(
		string [] stp_instances,
		string [] [] interfaces,
		long [] [] priorities
	) {
		this.Invoke("set_interface_priority", new object [] {
				stp_instances,
				interfaces,
				priorities});

	}
	public System.IAsyncResult Beginset_interface_priority(string [] stp_instances,string [] [] interfaces,long [] [] priorities, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_interface_priority", new object[] {
			stp_instances,
			interfaces,
			priorities}, callback, asyncState);
	}
	public void Endset_interface_priority(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.STPInstanceV2.PathCostType", Namespace = "urn:iControl")]
	public enum NetworkingSTPInstanceV2PathCostType
	{
		PATH_COST_INTERNAL,
		PATH_COST_EXTERNAL,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.STPInstanceV2.PathCost", Namespace = "urn:iControl")]
	public partial class NetworkingSTPInstanceV2PathCost
	{
		private NetworkingSTPInstanceV2PathCostType typeField;
		public NetworkingSTPInstanceV2PathCostType type
		{
			get { return this.typeField; }
			set { this.typeField = value; }
		}
		private long valueField;
		public long value
		{
			get { return this.valueField; }
			set { this.valueField = value; }
		}
	};

}
