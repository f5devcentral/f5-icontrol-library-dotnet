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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.NodeAddressBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBNodeAddressNodeAddressStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonULong64))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBNodeAddressMonitorAssociation))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBMonitorIP))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBMonitorInstanceState))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBObjectStatus))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBNodeAddressMonitorAssociationRemoval))]
	public partial class LocalLBNodeAddress : iControlInterface {
		public LocalLBNodeAddress() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddress", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddress", ResponseNamespace="urn:iControl:LocalLB/NodeAddress")]
	public void create(
		string [] node_addresses,
		long [] limits
	) {
		this.Invoke("create", new object [] {
				node_addresses,
				limits});

	}
	public System.IAsyncResult Begincreate(string [] node_addresses,long [] limits, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			node_addresses,
			limits}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_node_addresses
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddress", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddress", ResponseNamespace="urn:iControl:LocalLB/NodeAddress")]
	public void delete_all_node_addresses(

	) {
		this.Invoke("delete_all_node_addresses", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_node_addresses(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_node_addresses", new object[0], callback, asyncState);
	}
	public void Enddelete_all_node_addresses(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_node_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddress", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddress", ResponseNamespace="urn:iControl:LocalLB/NodeAddress")]
	public void delete_node_address(
		string [] node_addresses
	) {
		this.Invoke("delete_node_address", new object [] {
				node_addresses});

	}
	public System.IAsyncResult Begindelete_node_address(string [] node_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_node_address", new object[] {
			node_addresses}, callback, asyncState);
	}
	public void Enddelete_node_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddress", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddress", ResponseNamespace="urn:iControl:LocalLB/NodeAddress")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBNodeAddressNodeAddressStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((LocalLBNodeAddressNodeAddressStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public LocalLBNodeAddressNodeAddressStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBNodeAddressNodeAddressStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_connection_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddress", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddress", ResponseNamespace="urn:iControl:LocalLB/NodeAddress")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonULong64 [] get_connection_limit(
		string [] node_addresses
	) {
		object [] results = this.Invoke("get_connection_limit", new object [] {
				node_addresses});
		return ((CommonULong64 [])(results[0]));
	}
	public System.IAsyncResult Beginget_connection_limit(string [] node_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_connection_limit", new object[] {
			node_addresses}, callback, asyncState);
	}
	public CommonULong64 [] Endget_connection_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonULong64 [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dynamic_ratio
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddress", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddress", ResponseNamespace="urn:iControl:LocalLB/NodeAddress")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public short [] get_dynamic_ratio(
		string [] node_addresses
	) {
		object [] results = this.Invoke("get_dynamic_ratio", new object [] {
				node_addresses});
		return ((short [])(results[0]));
	}
	public System.IAsyncResult Beginget_dynamic_ratio(string [] node_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dynamic_ratio", new object[] {
			node_addresses}, callback, asyncState);
	}
	public short [] Endget_dynamic_ratio(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((short [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddress", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddress", ResponseNamespace="urn:iControl:LocalLB/NodeAddress")]
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
	// get_monitor_association
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddress", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddress", ResponseNamespace="urn:iControl:LocalLB/NodeAddress")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBNodeAddressMonitorAssociation [] get_monitor_association(
		LocalLBMonitorIP [] addresses
	) {
		object [] results = this.Invoke("get_monitor_association", new object [] {
				addresses});
		return ((LocalLBNodeAddressMonitorAssociation [])(results[0]));
	}
	public System.IAsyncResult Beginget_monitor_association(LocalLBMonitorIP [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_monitor_association", new object[] {
			addresses}, callback, asyncState);
	}
	public LocalLBNodeAddressMonitorAssociation [] Endget_monitor_association(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBNodeAddressMonitorAssociation [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_monitor_instance
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddress", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddress", ResponseNamespace="urn:iControl:LocalLB/NodeAddress")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBMonitorInstanceState [] [] get_monitor_instance(
		LocalLBMonitorIP [] addresses
	) {
		object [] results = this.Invoke("get_monitor_instance", new object [] {
				addresses});
		return ((LocalLBMonitorInstanceState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_monitor_instance(LocalLBMonitorIP [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_monitor_instance", new object[] {
			addresses}, callback, asyncState);
	}
	public LocalLBMonitorInstanceState [] [] Endget_monitor_instance(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBMonitorInstanceState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_monitor_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddress", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddress", ResponseNamespace="urn:iControl:LocalLB/NodeAddress")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBMonitorStatus [] get_monitor_status(
		string [] node_addresses
	) {
		object [] results = this.Invoke("get_monitor_status", new object [] {
				node_addresses});
		return ((LocalLBMonitorStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_monitor_status(string [] node_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_monitor_status", new object[] {
			node_addresses}, callback, asyncState);
	}
	public LocalLBMonitorStatus [] Endget_monitor_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBMonitorStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_object_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddress", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddress", ResponseNamespace="urn:iControl:LocalLB/NodeAddress")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBObjectStatus [] get_object_status(
		string [] node_addresses
	) {
		object [] results = this.Invoke("get_object_status", new object [] {
				node_addresses});
		return ((LocalLBObjectStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_object_status(string [] node_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_object_status", new object[] {
			node_addresses}, callback, asyncState);
	}
	public LocalLBObjectStatus [] Endget_object_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBObjectStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ratio
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddress", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddress", ResponseNamespace="urn:iControl:LocalLB/NodeAddress")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_ratio(
		string [] node_addresses
	) {
		object [] results = this.Invoke("get_ratio", new object [] {
				node_addresses});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_ratio(string [] node_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ratio", new object[] {
			node_addresses}, callback, asyncState);
	}
	public long [] Endget_ratio(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_screen_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddress", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddress", ResponseNamespace="urn:iControl:LocalLB/NodeAddress")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_screen_name(
		string [] node_addresses
	) {
		object [] results = this.Invoke("get_screen_name", new object [] {
				node_addresses});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_screen_name(string [] node_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_screen_name", new object[] {
			node_addresses}, callback, asyncState);
	}
	public string [] Endget_screen_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_session_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddress", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddress", ResponseNamespace="urn:iControl:LocalLB/NodeAddress")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_session_enabled_state(
		string [] node_addresses
	) {
		object [] results = this.Invoke("get_session_enabled_state", new object [] {
				node_addresses});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_session_enabled_state(string [] node_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_session_enabled_state", new object[] {
			node_addresses}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_session_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_session_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddress", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddress", ResponseNamespace="urn:iControl:LocalLB/NodeAddress")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBSessionStatus [] get_session_status(
		string [] node_addresses
	) {
		object [] results = this.Invoke("get_session_status", new object [] {
				node_addresses});
		return ((LocalLBSessionStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_session_status(string [] node_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_session_status", new object[] {
			node_addresses}, callback, asyncState);
	}
	public LocalLBSessionStatus [] Endget_session_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBSessionStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddress", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddress", ResponseNamespace="urn:iControl:LocalLB/NodeAddress")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBNodeAddressNodeAddressStatistics get_statistics(
		string [] node_addresses
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				node_addresses});
		return ((LocalLBNodeAddressNodeAddressStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] node_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			node_addresses}, callback, asyncState);
	}
	public LocalLBNodeAddressNodeAddressStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBNodeAddressNodeAddressStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddress", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddress", ResponseNamespace="urn:iControl:LocalLB/NodeAddress")]
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
	// remove_monitor_association
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddress", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddress", ResponseNamespace="urn:iControl:LocalLB/NodeAddress")]
	public void remove_monitor_association(
		LocalLBNodeAddressMonitorAssociationRemoval [] monitor_associations
	) {
		this.Invoke("remove_monitor_association", new object [] {
				monitor_associations});

	}
	public System.IAsyncResult Beginremove_monitor_association(LocalLBNodeAddressMonitorAssociationRemoval [] monitor_associations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_monitor_association", new object[] {
			monitor_associations}, callback, asyncState);
	}
	public void Endremove_monitor_association(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddress", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddress", ResponseNamespace="urn:iControl:LocalLB/NodeAddress")]
	public void reset_statistics(
		string [] node_addresses
	) {
		this.Invoke("reset_statistics", new object [] {
				node_addresses});

	}
	public System.IAsyncResult Beginreset_statistics(string [] node_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics", new object[] {
			node_addresses}, callback, asyncState);
	}
	public void Endreset_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_connection_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddress", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddress", ResponseNamespace="urn:iControl:LocalLB/NodeAddress")]
	public void set_connection_limit(
		string [] node_addresses,
		CommonULong64 [] limits
	) {
		this.Invoke("set_connection_limit", new object [] {
				node_addresses,
				limits});

	}
	public System.IAsyncResult Beginset_connection_limit(string [] node_addresses,CommonULong64 [] limits, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_connection_limit", new object[] {
			node_addresses,
			limits}, callback, asyncState);
	}
	public void Endset_connection_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dynamic_ratio
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddress", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddress", ResponseNamespace="urn:iControl:LocalLB/NodeAddress")]
	public void set_dynamic_ratio(
		string [] node_addresses,
		short [] dynamic_ratios
	) {
		this.Invoke("set_dynamic_ratio", new object [] {
				node_addresses,
				dynamic_ratios});

	}
	public System.IAsyncResult Beginset_dynamic_ratio(string [] node_addresses,short [] dynamic_ratios, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dynamic_ratio", new object[] {
			node_addresses,
			dynamic_ratios}, callback, asyncState);
	}
	public void Endset_dynamic_ratio(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_monitor_association
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddress", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddress", ResponseNamespace="urn:iControl:LocalLB/NodeAddress")]
	public void set_monitor_association(
		LocalLBNodeAddressMonitorAssociation [] monitor_associations
	) {
		this.Invoke("set_monitor_association", new object [] {
				monitor_associations});

	}
	public System.IAsyncResult Beginset_monitor_association(LocalLBNodeAddressMonitorAssociation [] monitor_associations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_monitor_association", new object[] {
			monitor_associations}, callback, asyncState);
	}
	public void Endset_monitor_association(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_monitor_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddress", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddress", ResponseNamespace="urn:iControl:LocalLB/NodeAddress")]
	public void set_monitor_state(
		string [] node_addresses,
		CommonEnabledState [] states
	) {
		this.Invoke("set_monitor_state", new object [] {
				node_addresses,
				states});

	}
	public System.IAsyncResult Beginset_monitor_state(string [] node_addresses,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_monitor_state", new object[] {
			node_addresses,
			states}, callback, asyncState);
	}
	public void Endset_monitor_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ratio
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddress", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddress", ResponseNamespace="urn:iControl:LocalLB/NodeAddress")]
	public void set_ratio(
		string [] node_addresses,
		long [] ratios
	) {
		this.Invoke("set_ratio", new object [] {
				node_addresses,
				ratios});

	}
	public System.IAsyncResult Beginset_ratio(string [] node_addresses,long [] ratios, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ratio", new object[] {
			node_addresses,
			ratios}, callback, asyncState);
	}
	public void Endset_ratio(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_screen_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddress", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddress", ResponseNamespace="urn:iControl:LocalLB/NodeAddress")]
	public void set_screen_name(
		string [] node_addresses,
		string [] names
	) {
		this.Invoke("set_screen_name", new object [] {
				node_addresses,
				names});

	}
	public System.IAsyncResult Beginset_screen_name(string [] node_addresses,string [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_screen_name", new object[] {
			node_addresses,
			names}, callback, asyncState);
	}
	public void Endset_screen_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_session_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddress", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddress", ResponseNamespace="urn:iControl:LocalLB/NodeAddress")]
	public void set_session_enabled_state(
		string [] node_addresses,
		CommonEnabledState [] states
	) {
		this.Invoke("set_session_enabled_state", new object [] {
				node_addresses,
				states});

	}
	public System.IAsyncResult Beginset_session_enabled_state(string [] node_addresses,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_session_enabled_state", new object[] {
			node_addresses,
			states}, callback, asyncState);
	}
	public void Endset_session_enabled_state(System.IAsyncResult asyncResult) {
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.NodeAddress.MonitorAssociation", Namespace = "urn:iControl")]
	public partial class LocalLBNodeAddressMonitorAssociation
	{
		private LocalLBMonitorIP node_addressField;
		public LocalLBMonitorIP node_address
		{
			get { return this.node_addressField; }
			set { this.node_addressField = value; }
		}
		private LocalLBMonitorRule monitor_ruleField;
		public LocalLBMonitorRule monitor_rule
		{
			get { return this.monitor_ruleField; }
			set { this.monitor_ruleField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.NodeAddress.MonitorAssociationRemoval", Namespace = "urn:iControl")]
	public partial class LocalLBNodeAddressMonitorAssociationRemoval
	{
		private LocalLBMonitorIP node_addressField;
		public LocalLBMonitorIP node_address
		{
			get { return this.node_addressField; }
			set { this.node_addressField = value; }
		}
		private LocalLBMonitorAssociationRemovalRule removal_ruleField;
		public LocalLBMonitorAssociationRemovalRule removal_rule
		{
			get { return this.removal_ruleField; }
			set { this.removal_ruleField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.NodeAddress.NodeAddressStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBNodeAddressNodeAddressStatisticEntry
	{
		private string node_addressField;
		public string node_address
		{
			get { return this.node_addressField; }
			set { this.node_addressField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.NodeAddress.NodeAddressStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBNodeAddressNodeAddressStatistics
	{
		private LocalLBNodeAddressNodeAddressStatisticEntry [] statisticsField;
		public LocalLBNodeAddressNodeAddressStatisticEntry [] statistics
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
