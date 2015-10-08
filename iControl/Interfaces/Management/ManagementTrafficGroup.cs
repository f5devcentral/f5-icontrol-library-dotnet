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
	[System.Web.Services.WebServiceBindingAttribute(Name="Management.TrafficGroupBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementTrafficGroupHAOrder))]
	public partial class ManagementTrafficGroup : iControlInterface {
		public ManagementTrafficGroup() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_ha_order
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TrafficGroup", 
		RequestNamespace="urn:iControl:Management/TrafficGroup", ResponseNamespace="urn:iControl:Management/TrafficGroup")]
	public void add_ha_order(
		string [] traffic_groups,
		ManagementTrafficGroupHAOrder [] [] orders
	) {
		this.Invoke("add_ha_order", new object [] {
				traffic_groups,
				orders});

	}
	public System.IAsyncResult Beginadd_ha_order(string [] traffic_groups,ManagementTrafficGroupHAOrder [] [] orders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_ha_order", new object[] {
			traffic_groups,
			orders}, callback, asyncState);
	}
	public void Endadd_ha_order(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TrafficGroup", 
		RequestNamespace="urn:iControl:Management/TrafficGroup", ResponseNamespace="urn:iControl:Management/TrafficGroup")]
	public void create(
		string [] traffic_groups
	) {
		this.Invoke("create", new object [] {
				traffic_groups});

	}
	public System.IAsyncResult Begincreate(string [] traffic_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			traffic_groups}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_traffic_group
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TrafficGroup", 
		RequestNamespace="urn:iControl:Management/TrafficGroup", ResponseNamespace="urn:iControl:Management/TrafficGroup")]
	public void delete_traffic_group(
		string [] traffic_groups
	) {
		this.Invoke("delete_traffic_group", new object [] {
				traffic_groups});

	}
	public System.IAsyncResult Begindelete_traffic_group(string [] traffic_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_traffic_group", new object[] {
			traffic_groups}, callback, asyncState);
	}
	public void Enddelete_traffic_group(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_auto_failback_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TrafficGroup", 
		RequestNamespace="urn:iControl:Management/TrafficGroup", ResponseNamespace="urn:iControl:Management/TrafficGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_auto_failback_enabled_state(
		string [] traffic_groups
	) {
		object [] results = this.Invoke("get_auto_failback_enabled_state", new object [] {
				traffic_groups});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_auto_failback_enabled_state(string [] traffic_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_auto_failback_enabled_state", new object[] {
			traffic_groups}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_auto_failback_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_auto_failback_time
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TrafficGroup", 
		RequestNamespace="urn:iControl:Management/TrafficGroup", ResponseNamespace="urn:iControl:Management/TrafficGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_auto_failback_time(
		string [] traffic_groups
	) {
		object [] results = this.Invoke("get_auto_failback_time", new object [] {
				traffic_groups});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_auto_failback_time(string [] traffic_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_auto_failback_time", new object[] {
			traffic_groups}, callback, asyncState);
	}
	public long [] Endget_auto_failback_time(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default_device
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TrafficGroup", 
		RequestNamespace="urn:iControl:Management/TrafficGroup", ResponseNamespace="urn:iControl:Management/TrafficGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_default_device(
		string [] traffic_groups
	) {
		object [] results = this.Invoke("get_default_device", new object [] {
				traffic_groups});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_default_device(string [] traffic_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_default_device", new object[] {
			traffic_groups}, callback, asyncState);
	}
	public string [] Endget_default_device(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TrafficGroup", 
		RequestNamespace="urn:iControl:Management/TrafficGroup", ResponseNamespace="urn:iControl:Management/TrafficGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] traffic_groups
	) {
		object [] results = this.Invoke("get_description", new object [] {
				traffic_groups});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] traffic_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			traffic_groups}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ha_group
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TrafficGroup", 
		RequestNamespace="urn:iControl:Management/TrafficGroup", ResponseNamespace="urn:iControl:Management/TrafficGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_ha_group(
		string [] traffic_groups
	) {
		object [] results = this.Invoke("get_ha_group", new object [] {
				traffic_groups});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_ha_group(string [] traffic_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ha_group", new object[] {
			traffic_groups}, callback, asyncState);
	}
	public string [] Endget_ha_group(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ha_load_factor
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TrafficGroup", 
		RequestNamespace="urn:iControl:Management/TrafficGroup", ResponseNamespace="urn:iControl:Management/TrafficGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_ha_load_factor(
		string [] traffic_groups
	) {
		object [] results = this.Invoke("get_ha_load_factor", new object [] {
				traffic_groups});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_ha_load_factor(string [] traffic_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ha_load_factor", new object[] {
			traffic_groups}, callback, asyncState);
	}
	public long [] Endget_ha_load_factor(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ha_order
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TrafficGroup", 
		RequestNamespace="urn:iControl:Management/TrafficGroup", ResponseNamespace="urn:iControl:Management/TrafficGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementTrafficGroupHAOrder [] [] get_ha_order(
		string [] traffic_groups
	) {
		object [] results = this.Invoke("get_ha_order", new object [] {
				traffic_groups});
		return ((ManagementTrafficGroupHAOrder [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_ha_order(string [] traffic_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ha_order", new object[] {
			traffic_groups}, callback, asyncState);
	}
	public ManagementTrafficGroupHAOrder [] [] Endget_ha_order(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementTrafficGroupHAOrder [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_is_floating
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TrafficGroup", 
		RequestNamespace="urn:iControl:Management/TrafficGroup", ResponseNamespace="urn:iControl:Management/TrafficGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] get_is_floating(
		string [] traffic_groups
	) {
		object [] results = this.Invoke("get_is_floating", new object [] {
				traffic_groups});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginget_is_floating(string [] traffic_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_is_floating", new object[] {
			traffic_groups}, callback, asyncState);
	}
	public bool [] Endget_is_floating(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TrafficGroup", 
		RequestNamespace="urn:iControl:Management/TrafficGroup", ResponseNamespace="urn:iControl:Management/TrafficGroup")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TrafficGroup", 
		RequestNamespace="urn:iControl:Management/TrafficGroup", ResponseNamespace="urn:iControl:Management/TrafficGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_mac_masquerade_address(
		string [] traffic_groups
	) {
		object [] results = this.Invoke("get_mac_masquerade_address", new object [] {
				traffic_groups});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_mac_masquerade_address(string [] traffic_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_mac_masquerade_address", new object[] {
			traffic_groups}, callback, asyncState);
	}
	public string [] Endget_mac_masquerade_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_unit_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TrafficGroup", 
		RequestNamespace="urn:iControl:Management/TrafficGroup", ResponseNamespace="urn:iControl:Management/TrafficGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_unit_id(
		string [] traffic_groups
	) {
		object [] results = this.Invoke("get_unit_id", new object [] {
				traffic_groups});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_unit_id(string [] traffic_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_unit_id", new object[] {
			traffic_groups}, callback, asyncState);
	}
	public long [] Endget_unit_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TrafficGroup", 
		RequestNamespace="urn:iControl:Management/TrafficGroup", ResponseNamespace="urn:iControl:Management/TrafficGroup")]
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
	// remove_all_ha_orders
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TrafficGroup", 
		RequestNamespace="urn:iControl:Management/TrafficGroup", ResponseNamespace="urn:iControl:Management/TrafficGroup")]
	public void remove_all_ha_orders(
		string [] traffic_groups
	) {
		this.Invoke("remove_all_ha_orders", new object [] {
				traffic_groups});

	}
	public System.IAsyncResult Beginremove_all_ha_orders(string [] traffic_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_ha_orders", new object[] {
			traffic_groups}, callback, asyncState);
	}
	public void Endremove_all_ha_orders(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_ha_order
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TrafficGroup", 
		RequestNamespace="urn:iControl:Management/TrafficGroup", ResponseNamespace="urn:iControl:Management/TrafficGroup")]
	public void remove_ha_order(
		string [] traffic_groups,
		ManagementTrafficGroupHAOrder [] [] orders
	) {
		this.Invoke("remove_ha_order", new object [] {
				traffic_groups,
				orders});

	}
	public System.IAsyncResult Beginremove_ha_order(string [] traffic_groups,ManagementTrafficGroupHAOrder [] [] orders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_ha_order", new object[] {
			traffic_groups,
			orders}, callback, asyncState);
	}
	public void Endremove_ha_order(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_auto_failback_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TrafficGroup", 
		RequestNamespace="urn:iControl:Management/TrafficGroup", ResponseNamespace="urn:iControl:Management/TrafficGroup")]
	public void set_auto_failback_enabled_state(
		string [] traffic_groups,
		CommonEnabledState [] states
	) {
		this.Invoke("set_auto_failback_enabled_state", new object [] {
				traffic_groups,
				states});

	}
	public System.IAsyncResult Beginset_auto_failback_enabled_state(string [] traffic_groups,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_auto_failback_enabled_state", new object[] {
			traffic_groups,
			states}, callback, asyncState);
	}
	public void Endset_auto_failback_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_auto_failback_time
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TrafficGroup", 
		RequestNamespace="urn:iControl:Management/TrafficGroup", ResponseNamespace="urn:iControl:Management/TrafficGroup")]
	public void set_auto_failback_time(
		string [] traffic_groups,
		long [] times
	) {
		this.Invoke("set_auto_failback_time", new object [] {
				traffic_groups,
				times});

	}
	public System.IAsyncResult Beginset_auto_failback_time(string [] traffic_groups,long [] times, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_auto_failback_time", new object[] {
			traffic_groups,
			times}, callback, asyncState);
	}
	public void Endset_auto_failback_time(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_device
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TrafficGroup", 
		RequestNamespace="urn:iControl:Management/TrafficGroup", ResponseNamespace="urn:iControl:Management/TrafficGroup")]
	public void set_default_device(
		string [] traffic_groups,
		string [] devices
	) {
		this.Invoke("set_default_device", new object [] {
				traffic_groups,
				devices});

	}
	public System.IAsyncResult Beginset_default_device(string [] traffic_groups,string [] devices, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_device", new object[] {
			traffic_groups,
			devices}, callback, asyncState);
	}
	public void Endset_default_device(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TrafficGroup", 
		RequestNamespace="urn:iControl:Management/TrafficGroup", ResponseNamespace="urn:iControl:Management/TrafficGroup")]
	public void set_description(
		string [] traffic_groups,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				traffic_groups,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] traffic_groups,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			traffic_groups,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ha_group
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TrafficGroup", 
		RequestNamespace="urn:iControl:Management/TrafficGroup", ResponseNamespace="urn:iControl:Management/TrafficGroup")]
	public void set_ha_group(
		string [] traffic_groups,
		string [] ha_groups
	) {
		this.Invoke("set_ha_group", new object [] {
				traffic_groups,
				ha_groups});

	}
	public System.IAsyncResult Beginset_ha_group(string [] traffic_groups,string [] ha_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ha_group", new object[] {
			traffic_groups,
			ha_groups}, callback, asyncState);
	}
	public void Endset_ha_group(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ha_load_factor
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TrafficGroup", 
		RequestNamespace="urn:iControl:Management/TrafficGroup", ResponseNamespace="urn:iControl:Management/TrafficGroup")]
	public void set_ha_load_factor(
		string [] traffic_groups,
		long [] loads
	) {
		this.Invoke("set_ha_load_factor", new object [] {
				traffic_groups,
				loads});

	}
	public System.IAsyncResult Beginset_ha_load_factor(string [] traffic_groups,long [] loads, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ha_load_factor", new object[] {
			traffic_groups,
			loads}, callback, asyncState);
	}
	public void Endset_ha_load_factor(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_mac_masquerade_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TrafficGroup", 
		RequestNamespace="urn:iControl:Management/TrafficGroup", ResponseNamespace="urn:iControl:Management/TrafficGroup")]
	public void set_mac_masquerade_address(
		string [] traffic_groups,
		string [] addresses
	) {
		this.Invoke("set_mac_masquerade_address", new object [] {
				traffic_groups,
				addresses});

	}
	public System.IAsyncResult Beginset_mac_masquerade_address(string [] traffic_groups,string [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_mac_masquerade_address", new object[] {
			traffic_groups,
			addresses}, callback, asyncState);
	}
	public void Endset_mac_masquerade_address(System.IAsyncResult asyncResult) {
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.TrafficGroup.HAOrder", Namespace = "urn:iControl")]
	public partial class ManagementTrafficGroupHAOrder
	{
		private string deviceField;
		public string device
		{
			get { return this.deviceField; }
			set { this.deviceField = value; }
		}
		private long orderField;
		public long order
		{
			get { return this.orderField; }
			set { this.orderField = value; }
		}
	};

}
