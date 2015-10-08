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
	[System.Web.Services.WebServiceBindingAttribute(Name="Management.DeviceGroupBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementDeviceGroupDeviceSyncStatus))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementDeviceGroupFailoverStatus))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementDeviceGroupSyncStatus))]
	public partial class ManagementDeviceGroup : iControlInterface {
		public ManagementDeviceGroup() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_device
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/DeviceGroup", 
		RequestNamespace="urn:iControl:Management/DeviceGroup", ResponseNamespace="urn:iControl:Management/DeviceGroup")]
	public void add_device(
		string [] device_groups,
		string [] [] devices
	) {
		this.Invoke("add_device", new object [] {
				device_groups,
				devices});

	}
	public System.IAsyncResult Beginadd_device(string [] device_groups,string [] [] devices, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_device", new object[] {
			device_groups,
			devices}, callback, asyncState);
	}
	public void Endadd_device(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/DeviceGroup", 
		RequestNamespace="urn:iControl:Management/DeviceGroup", ResponseNamespace="urn:iControl:Management/DeviceGroup")]
	public void create(
		string [] device_groups,
		ManagementDeviceGroupType [] types
	) {
		this.Invoke("create", new object [] {
				device_groups,
				types});

	}
	public System.IAsyncResult Begincreate(string [] device_groups,ManagementDeviceGroupType [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			device_groups,
			types}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_device_group
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/DeviceGroup", 
		RequestNamespace="urn:iControl:Management/DeviceGroup", ResponseNamespace="urn:iControl:Management/DeviceGroup")]
	public void delete_device_group(
		string [] device_groups
	) {
		this.Invoke("delete_device_group", new object [] {
				device_groups});

	}
	public System.IAsyncResult Begindelete_device_group(string [] device_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_device_group", new object[] {
			device_groups}, callback, asyncState);
	}
	public void Enddelete_device_group(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_all_preferred_active
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/DeviceGroup", 
		RequestNamespace="urn:iControl:Management/DeviceGroup", ResponseNamespace="urn:iControl:Management/DeviceGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] get_all_preferred_active(
		string [] device_groups
	) {
		object [] results = this.Invoke("get_all_preferred_active", new object [] {
				device_groups});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginget_all_preferred_active(string [] device_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_preferred_active", new object[] {
			device_groups}, callback, asyncState);
	}
	public bool [] Endget_all_preferred_active(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_autosync_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/DeviceGroup", 
		RequestNamespace="urn:iControl:Management/DeviceGroup", ResponseNamespace="urn:iControl:Management/DeviceGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_autosync_enabled_state(
		string [] device_groups
	) {
		object [] results = this.Invoke("get_autosync_enabled_state", new object [] {
				device_groups});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_autosync_enabled_state(string [] device_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_autosync_enabled_state", new object[] {
			device_groups}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_autosync_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/DeviceGroup", 
		RequestNamespace="urn:iControl:Management/DeviceGroup", ResponseNamespace="urn:iControl:Management/DeviceGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] device_groups
	) {
		object [] results = this.Invoke("get_description", new object [] {
				device_groups});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] device_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			device_groups}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_device
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/DeviceGroup", 
		RequestNamespace="urn:iControl:Management/DeviceGroup", ResponseNamespace="urn:iControl:Management/DeviceGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_device(
		string [] device_groups
	) {
		object [] results = this.Invoke("get_device", new object [] {
				device_groups});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_device(string [] device_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_device", new object[] {
			device_groups}, callback, asyncState);
	}
	public string [] [] Endget_device(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_device_sync_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/DeviceGroup", 
		RequestNamespace="urn:iControl:Management/DeviceGroup", ResponseNamespace="urn:iControl:Management/DeviceGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementDeviceGroupDeviceSyncStatus [] [] get_device_sync_status(
		string [] device_groups,
		string [] [] devices
	) {
		object [] results = this.Invoke("get_device_sync_status", new object [] {
				device_groups,
				devices});
		return ((ManagementDeviceGroupDeviceSyncStatus [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_device_sync_status(string [] device_groups,string [] [] devices, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_device_sync_status", new object[] {
			device_groups,
			devices}, callback, asyncState);
	}
	public ManagementDeviceGroupDeviceSyncStatus [] [] Endget_device_sync_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementDeviceGroupDeviceSyncStatus [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_failover_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/DeviceGroup", 
		RequestNamespace="urn:iControl:Management/DeviceGroup", ResponseNamespace="urn:iControl:Management/DeviceGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementDeviceGroupFailoverStatus get_failover_status(

	) {
		object [] results = this.Invoke("get_failover_status", new object [0]);
		return ((ManagementDeviceGroupFailoverStatus)(results[0]));
	}
	public System.IAsyncResult Beginget_failover_status(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_failover_status", new object[0], callback, asyncState);
	}
	public ManagementDeviceGroupFailoverStatus Endget_failover_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementDeviceGroupFailoverStatus)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_full_load_on_sync_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/DeviceGroup", 
		RequestNamespace="urn:iControl:Management/DeviceGroup", ResponseNamespace="urn:iControl:Management/DeviceGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_full_load_on_sync_state(
		string [] device_groups
	) {
		object [] results = this.Invoke("get_full_load_on_sync_state", new object [] {
				device_groups});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_full_load_on_sync_state(string [] device_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_full_load_on_sync_state", new object[] {
			device_groups}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_full_load_on_sync_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_incremental_config_sync_size_maximum
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/DeviceGroup", 
		RequestNamespace="urn:iControl:Management/DeviceGroup", ResponseNamespace="urn:iControl:Management/DeviceGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_incremental_config_sync_size_maximum(
		string [] device_groups
	) {
		object [] results = this.Invoke("get_incremental_config_sync_size_maximum", new object [] {
				device_groups});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_incremental_config_sync_size_maximum(string [] device_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_incremental_config_sync_size_maximum", new object[] {
			device_groups}, callback, asyncState);
	}
	public long [] Endget_incremental_config_sync_size_maximum(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/DeviceGroup", 
		RequestNamespace="urn:iControl:Management/DeviceGroup", ResponseNamespace="urn:iControl:Management/DeviceGroup")]
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
	// get_network_failover_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/DeviceGroup", 
		RequestNamespace="urn:iControl:Management/DeviceGroup", ResponseNamespace="urn:iControl:Management/DeviceGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_network_failover_enabled_state(
		string [] device_groups
	) {
		object [] results = this.Invoke("get_network_failover_enabled_state", new object [] {
				device_groups});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_network_failover_enabled_state(string [] device_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_network_failover_enabled_state", new object[] {
			device_groups}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_network_failover_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_sync_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/DeviceGroup", 
		RequestNamespace="urn:iControl:Management/DeviceGroup", ResponseNamespace="urn:iControl:Management/DeviceGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementDeviceGroupSyncStatus [] get_sync_status(
		string [] device_groups
	) {
		object [] results = this.Invoke("get_sync_status", new object [] {
				device_groups});
		return ((ManagementDeviceGroupSyncStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_sync_status(string [] device_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_sync_status", new object[] {
			device_groups}, callback, asyncState);
	}
	public ManagementDeviceGroupSyncStatus [] Endget_sync_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementDeviceGroupSyncStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_sync_status_overview
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/DeviceGroup", 
		RequestNamespace="urn:iControl:Management/DeviceGroup", ResponseNamespace="urn:iControl:Management/DeviceGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementDeviceGroupSyncStatus get_sync_status_overview(

	) {
		object [] results = this.Invoke("get_sync_status_overview", new object [0]);
		return ((ManagementDeviceGroupSyncStatus)(results[0]));
	}
	public System.IAsyncResult Beginget_sync_status_overview(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_sync_status_overview", new object[0], callback, asyncState);
	}
	public ManagementDeviceGroupSyncStatus Endget_sync_status_overview(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementDeviceGroupSyncStatus)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/DeviceGroup", 
		RequestNamespace="urn:iControl:Management/DeviceGroup", ResponseNamespace="urn:iControl:Management/DeviceGroup")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementDeviceGroupType [] get_type(
		string [] device_groups
	) {
		object [] results = this.Invoke("get_type", new object [] {
				device_groups});
		return ((ManagementDeviceGroupType [])(results[0]));
	}
	public System.IAsyncResult Beginget_type(string [] device_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_type", new object[] {
			device_groups}, callback, asyncState);
	}
	public ManagementDeviceGroupType [] Endget_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementDeviceGroupType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/DeviceGroup", 
		RequestNamespace="urn:iControl:Management/DeviceGroup", ResponseNamespace="urn:iControl:Management/DeviceGroup")]
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
	// remove_all_devices
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/DeviceGroup", 
		RequestNamespace="urn:iControl:Management/DeviceGroup", ResponseNamespace="urn:iControl:Management/DeviceGroup")]
	public void remove_all_devices(
		string [] device_groups
	) {
		this.Invoke("remove_all_devices", new object [] {
				device_groups});

	}
	public System.IAsyncResult Beginremove_all_devices(string [] device_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_devices", new object[] {
			device_groups}, callback, asyncState);
	}
	public void Endremove_all_devices(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_device
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/DeviceGroup", 
		RequestNamespace="urn:iControl:Management/DeviceGroup", ResponseNamespace="urn:iControl:Management/DeviceGroup")]
	public void remove_device(
		string [] device_groups,
		string [] [] devices
	) {
		this.Invoke("remove_device", new object [] {
				device_groups,
				devices});

	}
	public System.IAsyncResult Beginremove_device(string [] device_groups,string [] [] devices, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_device", new object[] {
			device_groups,
			devices}, callback, asyncState);
	}
	public void Endremove_device(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_autosync_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/DeviceGroup", 
		RequestNamespace="urn:iControl:Management/DeviceGroup", ResponseNamespace="urn:iControl:Management/DeviceGroup")]
	public void set_autosync_enabled_state(
		string [] device_groups,
		CommonEnabledState [] states
	) {
		this.Invoke("set_autosync_enabled_state", new object [] {
				device_groups,
				states});

	}
	public System.IAsyncResult Beginset_autosync_enabled_state(string [] device_groups,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_autosync_enabled_state", new object[] {
			device_groups,
			states}, callback, asyncState);
	}
	public void Endset_autosync_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/DeviceGroup", 
		RequestNamespace="urn:iControl:Management/DeviceGroup", ResponseNamespace="urn:iControl:Management/DeviceGroup")]
	public void set_description(
		string [] device_groups,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				device_groups,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] device_groups,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			device_groups,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_full_load_on_sync_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/DeviceGroup", 
		RequestNamespace="urn:iControl:Management/DeviceGroup", ResponseNamespace="urn:iControl:Management/DeviceGroup")]
	public void set_full_load_on_sync_state(
		string [] device_groups,
		CommonEnabledState [] states
	) {
		this.Invoke("set_full_load_on_sync_state", new object [] {
				device_groups,
				states});

	}
	public System.IAsyncResult Beginset_full_load_on_sync_state(string [] device_groups,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_full_load_on_sync_state", new object[] {
			device_groups,
			states}, callback, asyncState);
	}
	public void Endset_full_load_on_sync_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_incremental_config_sync_size_maximum
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/DeviceGroup", 
		RequestNamespace="urn:iControl:Management/DeviceGroup", ResponseNamespace="urn:iControl:Management/DeviceGroup")]
	public void set_incremental_config_sync_size_maximum(
		string [] device_groups,
		long [] values
	) {
		this.Invoke("set_incremental_config_sync_size_maximum", new object [] {
				device_groups,
				values});

	}
	public System.IAsyncResult Beginset_incremental_config_sync_size_maximum(string [] device_groups,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_incremental_config_sync_size_maximum", new object[] {
			device_groups,
			values}, callback, asyncState);
	}
	public void Endset_incremental_config_sync_size_maximum(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_network_failover_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/DeviceGroup", 
		RequestNamespace="urn:iControl:Management/DeviceGroup", ResponseNamespace="urn:iControl:Management/DeviceGroup")]
	public void set_network_failover_enabled_state(
		string [] device_groups,
		CommonEnabledState [] states
	) {
		this.Invoke("set_network_failover_enabled_state", new object [] {
				device_groups,
				states});

	}
	public System.IAsyncResult Beginset_network_failover_enabled_state(string [] device_groups,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_network_failover_enabled_state", new object[] {
			device_groups,
			states}, callback, asyncState);
	}
	public void Endset_network_failover_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.DeviceGroup.DeviceSyncType", Namespace = "urn:iControl")]
	public enum ManagementDeviceGroupDeviceSyncType
	{
		SYNC_TYPE_UNKNOWN,
		SYNC_TYPE_NONE,
		SYNC_TYPE_FULL_LOAD_MANUAL,
		SYNC_TYPE_FULL_LOAD_AUTO,
		SYNC_TYPE_INCREMENTAL_MANUAL,
		SYNC_TYPE_INCREMENTAL_AUTO,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.DeviceGroup.MemberState", Namespace = "urn:iControl")]
	public enum ManagementDeviceGroupMemberState
	{
		MEMBER_STATE_UNKNOWN,
		MEMBER_STATE_SYNCING,
		MEMBER_STATE_NEED_MANUAL_SYNC,
		MEMBER_STATE_IN_SYNC,
		MEMBER_STATE_SYNC_FAILED,
		MEMBER_STATE_SYNC_DISCONNECTED,
		MEMBER_STATE_STANDALONE,
		MEMBER_STATE_AWAITING_INITIAL_SYNC,
		MEMBER_STATE_INCOMPATIBLE_VERSION,
		MEMBER_STATE_PARTIAL_SYNC,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.DeviceGroup.StatusColor", Namespace = "urn:iControl")]
	public enum ManagementDeviceGroupStatusColor
	{
		COLOR_UNKNOWN,
		COLOR_GREEN,
		COLOR_YELLOW,
		COLOR_RED,
		COLOR_BLUE,
		COLOR_GRAY,
		COLOR_BLACK,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.DeviceGroup.Type", Namespace = "urn:iControl")]
	public enum ManagementDeviceGroupType
	{
		DGT_UNKNOWN,
		DGT_SYNC_ONLY,
		DGT_FAILOVER,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.DeviceGroup.CommitID", Namespace = "urn:iControl")]
	public partial class ManagementDeviceGroupCommitID
	{
		private string originatorField;
		public string originator
		{
			get { return this.originatorField; }
			set { this.originatorField = value; }
		}
		private CommonTimeStamp sync_timeField;
		public CommonTimeStamp sync_time
		{
			get { return this.sync_timeField; }
			set { this.sync_timeField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.DeviceGroup.DeviceSyncStatus", Namespace = "urn:iControl")]
	public partial class ManagementDeviceGroupDeviceSyncStatus
	{
		private CommonTimeStamp last_sync_timeField;
		public CommonTimeStamp last_sync_time
		{
			get { return this.last_sync_timeField; }
			set { this.last_sync_timeField = value; }
		}
		private ManagementDeviceGroupDeviceSyncType last_sync_typeField;
		public ManagementDeviceGroupDeviceSyncType last_sync_type
		{
			get { return this.last_sync_typeField; }
			set { this.last_sync_typeField = value; }
		}
		private ManagementDeviceGroupCommitID commit_idField;
		public ManagementDeviceGroupCommitID commit_id
		{
			get { return this.commit_idField; }
			set { this.commit_idField = value; }
		}
		private ManagementDeviceGroupCommitID last_successful_commit_idField;
		public ManagementDeviceGroupCommitID last_successful_commit_id
		{
			get { return this.last_successful_commit_idField; }
			set { this.last_successful_commit_idField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.DeviceGroup.FailoverStatus", Namespace = "urn:iControl")]
	public partial class ManagementDeviceGroupFailoverStatus
	{
		private CommonHAState failover_statusField;
		public CommonHAState failover_status
		{
			get { return this.failover_statusField; }
			set { this.failover_statusField = value; }
		}
		private ManagementDeviceGroupStatusColor colorField;
		public ManagementDeviceGroupStatusColor color
		{
			get { return this.colorField; }
			set { this.colorField = value; }
		}
		private string statusField;
		public string status
		{
			get { return this.statusField; }
			set { this.statusField = value; }
		}
		private string summaryField;
		public string summary
		{
			get { return this.summaryField; }
			set { this.summaryField = value; }
		}
		private string [] detailsField;
		public string [] details
		{
			get { return this.detailsField; }
			set { this.detailsField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.DeviceGroup.SyncStatus", Namespace = "urn:iControl")]
	public partial class ManagementDeviceGroupSyncStatus
	{
		private ManagementDeviceGroupStatusColor colorField;
		public ManagementDeviceGroupStatusColor color
		{
			get { return this.colorField; }
			set { this.colorField = value; }
		}
		private ManagementDeviceGroupMemberState member_stateField;
		public ManagementDeviceGroupMemberState member_state
		{
			get { return this.member_stateField; }
			set { this.member_stateField = value; }
		}
		private string statusField;
		public string status
		{
			get { return this.statusField; }
			set { this.statusField = value; }
		}
		private string summaryField;
		public string summary
		{
			get { return this.summaryField; }
			set { this.summaryField = value; }
		}
		private string [] detailsField;
		public string [] details
		{
			get { return this.detailsField; }
			set { this.detailsField = value; }
		}
	};

}
