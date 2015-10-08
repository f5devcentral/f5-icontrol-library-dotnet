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
	[System.Web.Services.WebServiceBindingAttribute(Name="Networking.InterfacesBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(NetworkingInterfacesInterfaceStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(NetworkingInterfacesInterfaceMediaOption))]
	public partial class NetworkingInterfaces : iControlInterface {
		public NetworkingInterfaces() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// get_active_media
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingInterfacesMediaType [] get_active_media(
		string [] interfaces
	) {
		object [] results = this.Invoke("get_active_media", new object [] {
				interfaces});
		return ((NetworkingInterfacesMediaType [])(results[0]));
	}
	public System.IAsyncResult Beginget_active_media(string [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_active_media", new object[] {
			interfaces}, callback, asyncState);
	}
	public NetworkingInterfacesMediaType [] Endget_active_media(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingInterfacesMediaType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_actual_flow_control
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingFlowControlType [] get_actual_flow_control(
		string [] interfaces
	) {
		object [] results = this.Invoke("get_actual_flow_control", new object [] {
				interfaces});
		return ((NetworkingFlowControlType [])(results[0]));
	}
	public System.IAsyncResult Beginget_actual_flow_control(string [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_actual_flow_control", new object[] {
			interfaces}, callback, asyncState);
	}
	public NetworkingFlowControlType [] Endget_actual_flow_control(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingFlowControlType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingInterfacesInterfaceStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((NetworkingInterfacesInterfaceStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public NetworkingInterfacesInterfaceStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingInterfacesInterfaceStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_bundle_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingInterfacesBundleState [] get_bundle_state(
		string [] interfaces
	) {
		object [] results = this.Invoke("get_bundle_state", new object [] {
				interfaces});
		return ((NetworkingInterfacesBundleState [])(results[0]));
	}
	public System.IAsyncResult Beginget_bundle_state(string [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_bundle_state", new object[] {
			interfaces}, callback, asyncState);
	}
	public NetworkingInterfacesBundleState [] Endget_bundle_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingInterfacesBundleState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] interfaces
	) {
		object [] results = this.Invoke("get_description", new object [] {
				interfaces});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			interfaces}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dual_media_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_dual_media_state(
		string [] interfaces
	) {
		object [] results = this.Invoke("get_dual_media_state", new object [] {
				interfaces});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_dual_media_state(string [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dual_media_state", new object[] {
			interfaces}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_dual_media_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_enabled_state(
		string [] interfaces
	) {
		object [] results = this.Invoke("get_enabled_state", new object [] {
				interfaces});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_enabled_state(string [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_enabled_state", new object[] {
			interfaces}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_if_index
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_if_index(
		string [] interfaces
	) {
		object [] results = this.Invoke("get_if_index", new object [] {
				interfaces});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_if_index(string [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_if_index", new object[] {
			interfaces}, callback, asyncState);
	}
	public long [] Endget_if_index(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_learning_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingLearningMode [] get_learning_mode(
		string [] interfaces
	) {
		object [] results = this.Invoke("get_learning_mode", new object [] {
				interfaces});
		return ((NetworkingLearningMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_learning_mode(string [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_learning_mode", new object[] {
			interfaces}, callback, asyncState);
	}
	public NetworkingLearningMode [] Endget_learning_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingLearningMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
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
	// get_lldp_admin_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingInterfacesLLDPAdminStatus [] get_lldp_admin_status(
		string [] interfaces
	) {
		object [] results = this.Invoke("get_lldp_admin_status", new object [] {
				interfaces});
		return ((NetworkingInterfacesLLDPAdminStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_lldp_admin_status(string [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_lldp_admin_status", new object[] {
			interfaces}, callback, asyncState);
	}
	public NetworkingInterfacesLLDPAdminStatus [] Endget_lldp_admin_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingInterfacesLLDPAdminStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_lldp_tlvmap
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_lldp_tlvmap(
		string [] interfaces
	) {
		object [] results = this.Invoke("get_lldp_tlvmap", new object [] {
				interfaces});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_lldp_tlvmap(string [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_lldp_tlvmap", new object[] {
			interfaces}, callback, asyncState);
	}
	public long [] Endget_lldp_tlvmap(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_mac_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_mac_address(
		string [] interfaces
	) {
		object [] results = this.Invoke("get_mac_address", new object [] {
				interfaces});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_mac_address(string [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_mac_address", new object[] {
			interfaces}, callback, asyncState);
	}
	public string [] Endget_mac_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_media
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingInterfacesMediaType [] get_media(
		string [] interfaces
	) {
		object [] results = this.Invoke("get_media", new object [] {
				interfaces});
		return ((NetworkingInterfacesMediaType [])(results[0]));
	}
	public System.IAsyncResult Beginget_media(string [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_media", new object[] {
			interfaces}, callback, asyncState);
	}
	public NetworkingInterfacesMediaType [] Endget_media(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingInterfacesMediaType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_media_option
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingInterfacesInterfaceMediaOption [] get_media_option(
		string [] interfaces
	) {
		object [] results = this.Invoke("get_media_option", new object [] {
				interfaces});
		return ((NetworkingInterfacesInterfaceMediaOption [])(results[0]));
	}
	public System.IAsyncResult Beginget_media_option(string [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_media_option", new object[] {
			interfaces}, callback, asyncState);
	}
	public NetworkingInterfacesInterfaceMediaOption [] Endget_media_option(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingInterfacesInterfaceMediaOption [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_media_option_sfp
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingInterfacesInterfaceMediaOption [] get_media_option_sfp(
		string [] interfaces
	) {
		object [] results = this.Invoke("get_media_option_sfp", new object [] {
				interfaces});
		return ((NetworkingInterfacesInterfaceMediaOption [])(results[0]));
	}
	public System.IAsyncResult Beginget_media_option_sfp(string [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_media_option_sfp", new object[] {
			interfaces}, callback, asyncState);
	}
	public NetworkingInterfacesInterfaceMediaOption [] Endget_media_option_sfp(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingInterfacesInterfaceMediaOption [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_media_sfp
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingInterfacesMediaType [] get_media_sfp(
		string [] interfaces
	) {
		object [] results = this.Invoke("get_media_sfp", new object [] {
				interfaces});
		return ((NetworkingInterfacesMediaType [])(results[0]));
	}
	public System.IAsyncResult Beginget_media_sfp(string [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_media_sfp", new object[] {
			interfaces}, callback, asyncState);
	}
	public NetworkingInterfacesMediaType [] Endget_media_sfp(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingInterfacesMediaType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_media_speed
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_media_speed(
		string [] interfaces
	) {
		object [] results = this.Invoke("get_media_speed", new object [] {
				interfaces});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_media_speed(string [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_media_speed", new object[] {
			interfaces}, callback, asyncState);
	}
	public long [] Endget_media_speed(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_media_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingMediaStatus [] get_media_status(
		string [] interfaces
	) {
		object [] results = this.Invoke("get_media_status", new object [] {
				interfaces});
		return ((NetworkingMediaStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_media_status(string [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_media_status", new object[] {
			interfaces}, callback, asyncState);
	}
	public NetworkingMediaStatus [] Endget_media_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingMediaStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_mtu
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_mtu(
		string [] interfaces
	) {
		object [] results = this.Invoke("get_mtu", new object [] {
				interfaces});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_mtu(string [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_mtu", new object[] {
			interfaces}, callback, asyncState);
	}
	public long [] Endget_mtu(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_phy_master_slave_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingPhyMasterSlaveMode [] get_phy_master_slave_mode(
		string [] interfaces
	) {
		object [] results = this.Invoke("get_phy_master_slave_mode", new object [] {
				interfaces});
		return ((NetworkingPhyMasterSlaveMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_phy_master_slave_mode(string [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_phy_master_slave_mode", new object[] {
			interfaces}, callback, asyncState);
	}
	public NetworkingPhyMasterSlaveMode [] Endget_phy_master_slave_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingPhyMasterSlaveMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_prefer_sfp_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_prefer_sfp_state(
		string [] interfaces
	) {
		object [] results = this.Invoke("get_prefer_sfp_state", new object [] {
				interfaces});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_prefer_sfp_state(string [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_prefer_sfp_state", new object[] {
			interfaces}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_prefer_sfp_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_requested_flow_control
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingFlowControlType [] get_requested_flow_control(
		string [] interfaces
	) {
		object [] results = this.Invoke("get_requested_flow_control", new object [] {
				interfaces});
		return ((NetworkingFlowControlType [])(results[0]));
	}
	public System.IAsyncResult Beginget_requested_flow_control(string [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_requested_flow_control", new object[] {
			interfaces}, callback, asyncState);
	}
	public NetworkingFlowControlType [] Endget_requested_flow_control(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingFlowControlType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_sflow_poll_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_sflow_poll_interval(
		string [] interfaces
	) {
		object [] results = this.Invoke("get_sflow_poll_interval", new object [] {
				interfaces});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_sflow_poll_interval(string [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_sflow_poll_interval", new object[] {
			interfaces}, callback, asyncState);
	}
	public long [] Endget_sflow_poll_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_sflow_poll_interval_global
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonSFlowGlobalType [] get_sflow_poll_interval_global(
		string [] interfaces
	) {
		object [] results = this.Invoke("get_sflow_poll_interval_global", new object [] {
				interfaces});
		return ((CommonSFlowGlobalType [])(results[0]));
	}
	public System.IAsyncResult Beginget_sflow_poll_interval_global(string [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_sflow_poll_interval_global", new object[] {
			interfaces}, callback, asyncState);
	}
	public CommonSFlowGlobalType [] Endget_sflow_poll_interval_global(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonSFlowGlobalType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_sfp_media_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_sfp_media_state(
		string [] interfaces
	) {
		object [] results = this.Invoke("get_sfp_media_state", new object [] {
				interfaces});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_sfp_media_state(string [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_sfp_media_state", new object[] {
			interfaces}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_sfp_media_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingInterfacesInterfaceStatistics get_statistics(
		string [] interfaces
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				interfaces});
		return ((NetworkingInterfacesInterfaceStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			interfaces}, callback, asyncState);
	}
	public NetworkingInterfacesInterfaceStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingInterfacesInterfaceStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_stp_active_edge_port_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_stp_active_edge_port_state(
		string [] interfaces
	) {
		object [] results = this.Invoke("get_stp_active_edge_port_state", new object [] {
				interfaces});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_stp_active_edge_port_state(string [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_stp_active_edge_port_state", new object[] {
			interfaces}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_stp_active_edge_port_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_stp_auto_edge_port_detection_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_stp_auto_edge_port_detection_state(
		string [] interfaces
	) {
		object [] results = this.Invoke("get_stp_auto_edge_port_detection_state", new object [] {
				interfaces});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_stp_auto_edge_port_detection_state(string [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_stp_auto_edge_port_detection_state", new object[] {
			interfaces}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_stp_auto_edge_port_detection_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_stp_edge_port_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_stp_edge_port_state(
		string [] interfaces
	) {
		object [] results = this.Invoke("get_stp_edge_port_state", new object [] {
				interfaces});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_stp_edge_port_state(string [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_stp_edge_port_state", new object[] {
			interfaces}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_stp_edge_port_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_stp_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_stp_enabled_state(
		string [] interfaces
	) {
		object [] results = this.Invoke("get_stp_enabled_state", new object [] {
				interfaces});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_stp_enabled_state(string [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_stp_enabled_state", new object[] {
			interfaces}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_stp_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_stp_link_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingSTPLinkType [] get_stp_link_type(
		string [] interfaces
	) {
		object [] results = this.Invoke("get_stp_link_type", new object [] {
				interfaces});
		return ((NetworkingSTPLinkType [])(results[0]));
	}
	public System.IAsyncResult Beginget_stp_link_type(string [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_stp_link_type", new object[] {
			interfaces}, callback, asyncState);
	}
	public NetworkingSTPLinkType [] Endget_stp_link_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingSTPLinkType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_stp_protocol_detection_reset_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_stp_protocol_detection_reset_state(
		string [] interfaces
	) {
		object [] results = this.Invoke("get_stp_protocol_detection_reset_state", new object [] {
				interfaces});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_stp_protocol_detection_reset_state(string [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_stp_protocol_detection_reset_state", new object[] {
			interfaces}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_stp_protocol_detection_reset_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
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
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	public void reset_statistics(
		string [] interfaces
	) {
		this.Invoke("reset_statistics", new object [] {
				interfaces});

	}
	public System.IAsyncResult Beginreset_statistics(string [] interfaces, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics", new object[] {
			interfaces}, callback, asyncState);
	}
	public void Endreset_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_bundle_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	public void set_bundle_state(
		string [] interfaces,
		NetworkingInterfacesBundleState [] states
	) {
		this.Invoke("set_bundle_state", new object [] {
				interfaces,
				states});

	}
	public System.IAsyncResult Beginset_bundle_state(string [] interfaces,NetworkingInterfacesBundleState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_bundle_state", new object[] {
			interfaces,
			states}, callback, asyncState);
	}
	public void Endset_bundle_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	public void set_description(
		string [] interfaces,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				interfaces,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] interfaces,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			interfaces,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	public void set_enabled_state(
		string [] interfaces,
		CommonEnabledState [] states
	) {
		this.Invoke("set_enabled_state", new object [] {
				interfaces,
				states});

	}
	public System.IAsyncResult Beginset_enabled_state(string [] interfaces,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_enabled_state", new object[] {
			interfaces,
			states}, callback, asyncState);
	}
	public void Endset_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_learning_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	public void set_learning_mode(
		string [] interfaces,
		NetworkingLearningMode [] modes
	) {
		this.Invoke("set_learning_mode", new object [] {
				interfaces,
				modes});

	}
	public System.IAsyncResult Beginset_learning_mode(string [] interfaces,NetworkingLearningMode [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_learning_mode", new object[] {
			interfaces,
			modes}, callback, asyncState);
	}
	public void Endset_learning_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_lldp_admin_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	public void set_lldp_admin_status(
		string [] interfaces,
		NetworkingInterfacesLLDPAdminStatus [] statuses
	) {
		this.Invoke("set_lldp_admin_status", new object [] {
				interfaces,
				statuses});

	}
	public System.IAsyncResult Beginset_lldp_admin_status(string [] interfaces,NetworkingInterfacesLLDPAdminStatus [] statuses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_lldp_admin_status", new object[] {
			interfaces,
			statuses}, callback, asyncState);
	}
	public void Endset_lldp_admin_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_lldp_tlvmap
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	public void set_lldp_tlvmap(
		string [] interfaces,
		long [] tlvmaps
	) {
		this.Invoke("set_lldp_tlvmap", new object [] {
				interfaces,
				tlvmaps});

	}
	public System.IAsyncResult Beginset_lldp_tlvmap(string [] interfaces,long [] tlvmaps, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_lldp_tlvmap", new object[] {
			interfaces,
			tlvmaps}, callback, asyncState);
	}
	public void Endset_lldp_tlvmap(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_media
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	public void set_media(
		string [] interfaces,
		NetworkingInterfacesMediaType [] media_types
	) {
		this.Invoke("set_media", new object [] {
				interfaces,
				media_types});

	}
	public System.IAsyncResult Beginset_media(string [] interfaces,NetworkingInterfacesMediaType [] media_types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_media", new object[] {
			interfaces,
			media_types}, callback, asyncState);
	}
	public void Endset_media(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_media_fixed_or_sfp
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	public void set_media_fixed_or_sfp(
		string [] interfaces,
		NetworkingInterfacesMediaType [] media_types
	) {
		this.Invoke("set_media_fixed_or_sfp", new object [] {
				interfaces,
				media_types});

	}
	public System.IAsyncResult Beginset_media_fixed_or_sfp(string [] interfaces,NetworkingInterfacesMediaType [] media_types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_media_fixed_or_sfp", new object[] {
			interfaces,
			media_types}, callback, asyncState);
	}
	public void Endset_media_fixed_or_sfp(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_media_sfp
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	public void set_media_sfp(
		string [] interfaces,
		NetworkingInterfacesMediaType [] media_types
	) {
		this.Invoke("set_media_sfp", new object [] {
				interfaces,
				media_types});

	}
	public System.IAsyncResult Beginset_media_sfp(string [] interfaces,NetworkingInterfacesMediaType [] media_types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_media_sfp", new object[] {
			interfaces,
			media_types}, callback, asyncState);
	}
	public void Endset_media_sfp(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_phy_master_slave_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	public void set_phy_master_slave_mode(
		string [] interfaces,
		NetworkingPhyMasterSlaveMode [] modes
	) {
		this.Invoke("set_phy_master_slave_mode", new object [] {
				interfaces,
				modes});

	}
	public System.IAsyncResult Beginset_phy_master_slave_mode(string [] interfaces,NetworkingPhyMasterSlaveMode [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_phy_master_slave_mode", new object[] {
			interfaces,
			modes}, callback, asyncState);
	}
	public void Endset_phy_master_slave_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_prefer_sfp_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	public void set_prefer_sfp_state(
		string [] interfaces,
		CommonEnabledState [] states
	) {
		this.Invoke("set_prefer_sfp_state", new object [] {
				interfaces,
				states});

	}
	public System.IAsyncResult Beginset_prefer_sfp_state(string [] interfaces,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_prefer_sfp_state", new object[] {
			interfaces,
			states}, callback, asyncState);
	}
	public void Endset_prefer_sfp_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_requested_flow_control
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	public void set_requested_flow_control(
		string [] interfaces,
		NetworkingFlowControlType [] flow_controls
	) {
		this.Invoke("set_requested_flow_control", new object [] {
				interfaces,
				flow_controls});

	}
	public System.IAsyncResult Beginset_requested_flow_control(string [] interfaces,NetworkingFlowControlType [] flow_controls, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_requested_flow_control", new object[] {
			interfaces,
			flow_controls}, callback, asyncState);
	}
	public void Endset_requested_flow_control(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_sflow_poll_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	public void set_sflow_poll_interval(
		string [] interfaces,
		long [] intervals
	) {
		this.Invoke("set_sflow_poll_interval", new object [] {
				interfaces,
				intervals});

	}
	public System.IAsyncResult Beginset_sflow_poll_interval(string [] interfaces,long [] intervals, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_sflow_poll_interval", new object[] {
			interfaces,
			intervals}, callback, asyncState);
	}
	public void Endset_sflow_poll_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_sflow_poll_interval_global
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	public void set_sflow_poll_interval_global(
		string [] interfaces,
		CommonSFlowGlobalType [] types
	) {
		this.Invoke("set_sflow_poll_interval_global", new object [] {
				interfaces,
				types});

	}
	public System.IAsyncResult Beginset_sflow_poll_interval_global(string [] interfaces,CommonSFlowGlobalType [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_sflow_poll_interval_global", new object[] {
			interfaces,
			types}, callback, asyncState);
	}
	public void Endset_sflow_poll_interval_global(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_stp_auto_edge_port_detection_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	public void set_stp_auto_edge_port_detection_state(
		string [] interfaces,
		CommonEnabledState [] states
	) {
		this.Invoke("set_stp_auto_edge_port_detection_state", new object [] {
				interfaces,
				states});

	}
	public System.IAsyncResult Beginset_stp_auto_edge_port_detection_state(string [] interfaces,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_stp_auto_edge_port_detection_state", new object[] {
			interfaces,
			states}, callback, asyncState);
	}
	public void Endset_stp_auto_edge_port_detection_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_stp_edge_port_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	public void set_stp_edge_port_state(
		string [] interfaces,
		CommonEnabledState [] states
	) {
		this.Invoke("set_stp_edge_port_state", new object [] {
				interfaces,
				states});

	}
	public System.IAsyncResult Beginset_stp_edge_port_state(string [] interfaces,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_stp_edge_port_state", new object[] {
			interfaces,
			states}, callback, asyncState);
	}
	public void Endset_stp_edge_port_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_stp_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	public void set_stp_enabled_state(
		string [] interfaces,
		CommonEnabledState [] states
	) {
		this.Invoke("set_stp_enabled_state", new object [] {
				interfaces,
				states});

	}
	public System.IAsyncResult Beginset_stp_enabled_state(string [] interfaces,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_stp_enabled_state", new object[] {
			interfaces,
			states}, callback, asyncState);
	}
	public void Endset_stp_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_stp_link_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	public void set_stp_link_type(
		string [] interfaces,
		NetworkingSTPLinkType [] link_types
	) {
		this.Invoke("set_stp_link_type", new object [] {
				interfaces,
				link_types});

	}
	public System.IAsyncResult Beginset_stp_link_type(string [] interfaces,NetworkingSTPLinkType [] link_types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_stp_link_type", new object[] {
			interfaces,
			link_types}, callback, asyncState);
	}
	public void Endset_stp_link_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_stp_protocol_detection_reset_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Interfaces", 
		RequestNamespace="urn:iControl:Networking/Interfaces", ResponseNamespace="urn:iControl:Networking/Interfaces")]
	public void set_stp_protocol_detection_reset_state(
		string [] interfaces,
		CommonEnabledState [] states
	) {
		this.Invoke("set_stp_protocol_detection_reset_state", new object [] {
				interfaces,
				states});

	}
	public System.IAsyncResult Beginset_stp_protocol_detection_reset_state(string [] interfaces,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_stp_protocol_detection_reset_state", new object[] {
			interfaces,
			states}, callback, asyncState);
	}
	public void Endset_stp_protocol_detection_reset_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.Interfaces.BundleState", Namespace = "urn:iControl")]
	public enum NetworkingInterfacesBundleState
	{
		INTERFACE_BUNDLE_UNKNOWN,
		INTERFACE_BUNDLE_NOT_SUPPORTED,
		INTERFACE_BUNDLE_ENABLED,
		INTERFACE_BUNDLE_DISABLED,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.Interfaces.LLDPAdminStatus", Namespace = "urn:iControl")]
	public enum NetworkingInterfacesLLDPAdminStatus
	{
		INTERFACE_LLDP_UNKNOWN,
		INTERFACE_LLDP_DISABLE,
		INTERFACE_LLDP_TXONLY,
		INTERFACE_LLDP_RXONLY,
		INTERFACE_LLDP_TXRX,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.Interfaces.MediaType", Namespace = "urn:iControl")]
	public enum NetworkingInterfacesMediaType
	{
		MT_NONE,
		MT_AUTO,
		MT_LOOP,
		MT_NO_PHY,
		MT_10T_HALF,
		MT_10T_FULL,
		MT_100TX_HALF,
		MT_100TX_FULL,
		MT_1000TX_HALF,
		MT_1000TX_FULL,
		MT_1000FX_HALF,
		MT_1000FX_FULL,
		MT_10000TX_HALF,
		MT_10000TX_FULL,
		MT_10000FX_HALF,
		MT_10000FX_FULL,
		MT_1000SX_HALF,
		MT_1000SX_FULL,
		MT_1000LX_HALF,
		MT_1000LX_FULL,
		MT_1000T_HALF,
		MT_1000T_FULL,
		MT_10000T_FULL,
		MT_10000SR_FULL,
		MT_10000LR_FULL,
		MT_10000ER_FULL,
		MT_12000_FULL,
		MT_16000_FULL,
		MT_20000_FULL,
		MT_1000CX_FULL,
		MT_10000SFP_PLUS_CU_FULL,
		MT_40000SR_FULL,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.Interfaces.InterfaceMediaOption", Namespace = "urn:iControl")]
	public partial class NetworkingInterfacesInterfaceMediaOption
	{
		private string interface_nameField;
		public string interface_name
		{
			get { return this.interface_nameField; }
			set { this.interface_nameField = value; }
		}
		private NetworkingInterfacesMediaType [] media_optionsField;
		public NetworkingInterfacesMediaType [] media_options
		{
			get { return this.media_optionsField; }
			set { this.media_optionsField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.Interfaces.InterfaceStatisticEntry", Namespace = "urn:iControl")]
	public partial class NetworkingInterfacesInterfaceStatisticEntry
	{
		private string interface_nameField;
		public string interface_name
		{
			get { return this.interface_nameField; }
			set { this.interface_nameField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.Interfaces.InterfaceStatistics", Namespace = "urn:iControl")]
	public partial class NetworkingInterfacesInterfaceStatistics
	{
		private NetworkingInterfacesInterfaceStatisticEntry [] statisticsField;
		public NetworkingInterfacesInterfaceStatisticEntry [] statistics
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
