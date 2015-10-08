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
	[System.Web.Services.WebServiceBindingAttribute(Name="Networking.STPInstanceBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(NetworkingSTPInstanceInterfaceSTPState))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(NetworkingSTPInstanceInterfacePathCost))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(NetworkingSTPInstanceInterfacePriority))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(NetworkingSTPInstanceInterfaceSTPRole))]
	public partial class NetworkingSTPInstance : iControlInterface {
		public NetworkingSTPInstance() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPInstance", 
		RequestNamespace="urn:iControl:Networking/STPInstance", ResponseNamespace="urn:iControl:Networking/STPInstance")]
	public void add_vlan(
		long [] stp_instances,
		string [] [] vlan_names
	) {
		this.Invoke("add_vlan", new object [] {
				stp_instances,
				vlan_names});

	}
	public System.IAsyncResult Beginadd_vlan(long [] stp_instances,string [] [] vlan_names, System.AsyncCallback callback, object asyncState) {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPInstance", 
		RequestNamespace="urn:iControl:Networking/STPInstance", ResponseNamespace="urn:iControl:Networking/STPInstance")]
	public void create(
		long [] stp_instances,
		long [] priorities,
		string [] [] vlan_names
	) {
		this.Invoke("create", new object [] {
				stp_instances,
				priorities,
				vlan_names});

	}
	public System.IAsyncResult Begincreate(long [] stp_instances,long [] priorities,string [] [] vlan_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			stp_instances,
			priorities,
			vlan_names}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_instances
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPInstance", 
		RequestNamespace="urn:iControl:Networking/STPInstance", ResponseNamespace="urn:iControl:Networking/STPInstance")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPInstance", 
		RequestNamespace="urn:iControl:Networking/STPInstance", ResponseNamespace="urn:iControl:Networking/STPInstance")]
	public void delete_instance(
		long [] stp_instances
	) {
		this.Invoke("delete_instance", new object [] {
				stp_instances});

	}
	public System.IAsyncResult Begindelete_instance(long [] stp_instances, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_instance", new object[] {
			stp_instances}, callback, asyncState);
	}
	public void Enddelete_instance(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_bridge_priority
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPInstance", 
		RequestNamespace="urn:iControl:Networking/STPInstance", ResponseNamespace="urn:iControl:Networking/STPInstance")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_bridge_priority(
		long [] stp_instances
	) {
		object [] results = this.Invoke("get_bridge_priority", new object [] {
				stp_instances});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_bridge_priority(long [] stp_instances, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_bridge_priority", new object[] {
			stp_instances}, callback, asyncState);
	}
	public long [] Endget_bridge_priority(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_interface_active_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPInstance", 
		RequestNamespace="urn:iControl:Networking/STPInstance", ResponseNamespace="urn:iControl:Networking/STPInstance")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingSTPInstanceInterfaceSTPState [] [] get_interface_active_state(
		long [] stp_instances,
		string [] [] interfaces
	) {
		object [] results = this.Invoke("get_interface_active_state", new object [] {
				stp_instances,
				interfaces});
		return ((NetworkingSTPInstanceInterfaceSTPState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_interface_active_state(long [] stp_instances,string [] [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_interface_active_state", new object[] {
			stp_instances,
			interfaces}, callback, asyncState);
	}
	public NetworkingSTPInstanceInterfaceSTPState [] [] Endget_interface_active_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingSTPInstanceInterfaceSTPState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_interface_path_cost
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPInstance", 
		RequestNamespace="urn:iControl:Networking/STPInstance", ResponseNamespace="urn:iControl:Networking/STPInstance")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingSTPInstanceInterfacePathCost [] [] get_interface_path_cost(
		long [] stp_instances,
		string [] [] interfaces,
		NetworkingSTPInstancePathCostType [] [] path_cost_types
	) {
		object [] results = this.Invoke("get_interface_path_cost", new object [] {
				stp_instances,
				interfaces,
				path_cost_types});
		return ((NetworkingSTPInstanceInterfacePathCost [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_interface_path_cost(long [] stp_instances,string [] [] interfaces,NetworkingSTPInstancePathCostType [] [] path_cost_types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_interface_path_cost", new object[] {
			stp_instances,
			interfaces,
			path_cost_types}, callback, asyncState);
	}
	public NetworkingSTPInstanceInterfacePathCost [] [] Endget_interface_path_cost(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingSTPInstanceInterfacePathCost [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_interface_priority
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPInstance", 
		RequestNamespace="urn:iControl:Networking/STPInstance", ResponseNamespace="urn:iControl:Networking/STPInstance")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingSTPInstanceInterfacePriority [] [] get_interface_priority(
		long [] stp_instances,
		string [] [] interfaces
	) {
		object [] results = this.Invoke("get_interface_priority", new object [] {
				stp_instances,
				interfaces});
		return ((NetworkingSTPInstanceInterfacePriority [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_interface_priority(long [] stp_instances,string [] [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_interface_priority", new object[] {
			stp_instances,
			interfaces}, callback, asyncState);
	}
	public NetworkingSTPInstanceInterfacePriority [] [] Endget_interface_priority(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingSTPInstanceInterfacePriority [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_interface_requested_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPInstance", 
		RequestNamespace="urn:iControl:Networking/STPInstance", ResponseNamespace="urn:iControl:Networking/STPInstance")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingSTPInstanceInterfaceSTPState [] [] get_interface_requested_state(
		long [] stp_instances,
		string [] [] interfaces
	) {
		object [] results = this.Invoke("get_interface_requested_state", new object [] {
				stp_instances,
				interfaces});
		return ((NetworkingSTPInstanceInterfaceSTPState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_interface_requested_state(long [] stp_instances,string [] [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_interface_requested_state", new object[] {
			stp_instances,
			interfaces}, callback, asyncState);
	}
	public NetworkingSTPInstanceInterfaceSTPState [] [] Endget_interface_requested_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingSTPInstanceInterfaceSTPState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_interface_role
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPInstance", 
		RequestNamespace="urn:iControl:Networking/STPInstance", ResponseNamespace="urn:iControl:Networking/STPInstance")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingSTPInstanceInterfaceSTPRole [] [] get_interface_role(
		long [] stp_instances,
		string [] [] interfaces
	) {
		object [] results = this.Invoke("get_interface_role", new object [] {
				stp_instances,
				interfaces});
		return ((NetworkingSTPInstanceInterfaceSTPRole [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_interface_role(long [] stp_instances,string [] [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_interface_role", new object[] {
			stp_instances,
			interfaces}, callback, asyncState);
	}
	public NetworkingSTPInstanceInterfaceSTPRole [] [] Endget_interface_role(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingSTPInstanceInterfaceSTPRole [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPInstance", 
		RequestNamespace="urn:iControl:Networking/STPInstance", ResponseNamespace="urn:iControl:Networking/STPInstance")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_list(

	) {
		object [] results = this.Invoke("get_list", new object [0]);
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_list", new object[0], callback, asyncState);
	}
	public long [] Endget_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_regional_root_bridge_mac_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPInstance", 
		RequestNamespace="urn:iControl:Networking/STPInstance", ResponseNamespace="urn:iControl:Networking/STPInstance")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_regional_root_bridge_mac_address(
		long [] stp_instances
	) {
		object [] results = this.Invoke("get_regional_root_bridge_mac_address", new object [] {
				stp_instances});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_regional_root_bridge_mac_address(long [] stp_instances, System.AsyncCallback callback, object asyncState) {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPInstance", 
		RequestNamespace="urn:iControl:Networking/STPInstance", ResponseNamespace="urn:iControl:Networking/STPInstance")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_root_bridge_mac_address(
		long [] stp_instances
	) {
		object [] results = this.Invoke("get_root_bridge_mac_address", new object [] {
				stp_instances});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_root_bridge_mac_address(long [] stp_instances, System.AsyncCallback callback, object asyncState) {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPInstance", 
		RequestNamespace="urn:iControl:Networking/STPInstance", ResponseNamespace="urn:iControl:Networking/STPInstance")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPInstance", 
		RequestNamespace="urn:iControl:Networking/STPInstance", ResponseNamespace="urn:iControl:Networking/STPInstance")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_vlan(
		long [] stp_instances
	) {
		object [] results = this.Invoke("get_vlan", new object [] {
				stp_instances});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_vlan(long [] stp_instances, System.AsyncCallback callback, object asyncState) {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPInstance", 
		RequestNamespace="urn:iControl:Networking/STPInstance", ResponseNamespace="urn:iControl:Networking/STPInstance")]
	public void remove_all_vlans(
		long [] stp_instances
	) {
		this.Invoke("remove_all_vlans", new object [] {
				stp_instances});

	}
	public System.IAsyncResult Beginremove_all_vlans(long [] stp_instances, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_vlans", new object[] {
			stp_instances}, callback, asyncState);
	}
	public void Endremove_all_vlans(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPInstance", 
		RequestNamespace="urn:iControl:Networking/STPInstance", ResponseNamespace="urn:iControl:Networking/STPInstance")]
	public void remove_vlan(
		long [] stp_instances,
		string [] [] vlan_names
	) {
		this.Invoke("remove_vlan", new object [] {
				stp_instances,
				vlan_names});

	}
	public System.IAsyncResult Beginremove_vlan(long [] stp_instances,string [] [] vlan_names, System.AsyncCallback callback, object asyncState) {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPInstance", 
		RequestNamespace="urn:iControl:Networking/STPInstance", ResponseNamespace="urn:iControl:Networking/STPInstance")]
	public void set_bridge_priority(
		long [] stp_instances,
		long [] priorities
	) {
		this.Invoke("set_bridge_priority", new object [] {
				stp_instances,
				priorities});

	}
	public System.IAsyncResult Beginset_bridge_priority(long [] stp_instances,long [] priorities, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_bridge_priority", new object[] {
			stp_instances,
			priorities}, callback, asyncState);
	}
	public void Endset_bridge_priority(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_interface_path_cost
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPInstance", 
		RequestNamespace="urn:iControl:Networking/STPInstance", ResponseNamespace="urn:iControl:Networking/STPInstance")]
	public void set_interface_path_cost(
		long [] stp_instances,
		NetworkingSTPInstanceInterfacePathCost [] [] path_costs
	) {
		this.Invoke("set_interface_path_cost", new object [] {
				stp_instances,
				path_costs});

	}
	public System.IAsyncResult Beginset_interface_path_cost(long [] stp_instances,NetworkingSTPInstanceInterfacePathCost [] [] path_costs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_interface_path_cost", new object[] {
			stp_instances,
			path_costs}, callback, asyncState);
	}
	public void Endset_interface_path_cost(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_interface_priority
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/STPInstance", 
		RequestNamespace="urn:iControl:Networking/STPInstance", ResponseNamespace="urn:iControl:Networking/STPInstance")]
	public void set_interface_priority(
		long [] stp_instances,
		NetworkingSTPInstanceInterfacePriority [] [] priorities
	) {
		this.Invoke("set_interface_priority", new object [] {
				stp_instances,
				priorities});

	}
	public System.IAsyncResult Beginset_interface_priority(long [] stp_instances,NetworkingSTPInstanceInterfacePriority [] [] priorities, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_interface_priority", new object[] {
			stp_instances,
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.STPInstance.PathCostType", Namespace = "urn:iControl")]
	public enum NetworkingSTPInstancePathCostType
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.STPInstance.InterfacePathCost", Namespace = "urn:iControl")]
	public partial class NetworkingSTPInstanceInterfacePathCost
	{
		private string nameField;
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}
		private NetworkingSTPInstancePathCost path_costField;
		public NetworkingSTPInstancePathCost path_cost
		{
			get { return this.path_costField; }
			set { this.path_costField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.STPInstance.InterfacePriority", Namespace = "urn:iControl")]
	public partial class NetworkingSTPInstanceInterfacePriority
	{
		private string nameField;
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}
		private long priorityField;
		public long priority
		{
			get { return this.priorityField; }
			set { this.priorityField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.STPInstance.InterfaceSTPRole", Namespace = "urn:iControl")]
	public partial class NetworkingSTPInstanceInterfaceSTPRole
	{
		private string nameField;
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}
		private NetworkingSTPRoleType roleField;
		public NetworkingSTPRoleType role
		{
			get { return this.roleField; }
			set { this.roleField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.STPInstance.InterfaceSTPState", Namespace = "urn:iControl")]
	public partial class NetworkingSTPInstanceInterfaceSTPState
	{
		private string nameField;
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}
		private NetworkingSTPStateType stateField;
		public NetworkingSTPStateType state
		{
			get { return this.stateField; }
			set { this.stateField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.STPInstance.PathCost", Namespace = "urn:iControl")]
	public partial class NetworkingSTPInstancePathCost
	{
		private NetworkingSTPInstancePathCostType typeField;
		public NetworkingSTPInstancePathCostType type
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
