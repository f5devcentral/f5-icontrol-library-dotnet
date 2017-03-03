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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.NodeAddressV2Binding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBNodeAddressV2NodeAddressStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBMonitorRule))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBMonitorInstanceState))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBObjectStatus))]
	public partial class LocalLBNodeAddressV2 : iControlInterface {
		public LocalLBNodeAddressV2() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddressV2", ResponseNamespace="urn:iControl:LocalLB/NodeAddressV2")]
	public void add_metadata(
		string [] nodes,
		string [] [] names,
		string [] [] values
	) {
		this.Invoke("add_metadata", new object [] {
				nodes,
				names,
				values});

	}
	public System.IAsyncResult Beginadd_metadata(string [] nodes,string [] [] names,string [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_metadata", new object[] {
			nodes,
			names,
			values}, callback, asyncState);
	}
	public void Endadd_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddressV2", ResponseNamespace="urn:iControl:LocalLB/NodeAddressV2")]
	public void create(
		string [] nodes,
		string [] addresses,
		long [] limits
	) {
		this.Invoke("create", new object [] {
				nodes,
				addresses,
				limits});

	}
	public System.IAsyncResult Begincreate(string [] nodes,string [] addresses,long [] limits, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			nodes,
			addresses,
			limits}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_node_addresses
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddressV2", ResponseNamespace="urn:iControl:LocalLB/NodeAddressV2")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddressV2", ResponseNamespace="urn:iControl:LocalLB/NodeAddressV2")]
	public void delete_node_address(
		string [] nodes
	) {
		this.Invoke("delete_node_address", new object [] {
				nodes});

	}
	public System.IAsyncResult Begindelete_node_address(string [] nodes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_node_address", new object[] {
			nodes}, callback, asyncState);
	}
	public void Enddelete_node_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddressV2", ResponseNamespace="urn:iControl:LocalLB/NodeAddressV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_address(
		string [] nodes
	) {
		object [] results = this.Invoke("get_address", new object [] {
				nodes});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_address(string [] nodes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_address", new object[] {
			nodes}, callback, asyncState);
	}
	public string [] Endget_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddressV2", ResponseNamespace="urn:iControl:LocalLB/NodeAddressV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBNodeAddressV2NodeAddressStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((LocalLBNodeAddressV2NodeAddressStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public LocalLBNodeAddressV2NodeAddressStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBNodeAddressV2NodeAddressStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_connection_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddressV2", ResponseNamespace="urn:iControl:LocalLB/NodeAddressV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_connection_limit(
		string [] nodes
	) {
		object [] results = this.Invoke("get_connection_limit", new object [] {
				nodes});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_connection_limit(string [] nodes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_connection_limit", new object[] {
			nodes}, callback, asyncState);
	}
	public long [] Endget_connection_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default_node_monitor
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddressV2", ResponseNamespace="urn:iControl:LocalLB/NodeAddressV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBMonitorRule get_default_node_monitor(

	) {
		object [] results = this.Invoke("get_default_node_monitor", new object [0]);
		return ((LocalLBMonitorRule)(results[0]));
	}
	public System.IAsyncResult Beginget_default_node_monitor(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_default_node_monitor", new object[0], callback, asyncState);
	}
	public LocalLBMonitorRule Endget_default_node_monitor(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBMonitorRule)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddressV2", ResponseNamespace="urn:iControl:LocalLB/NodeAddressV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] nodes
	) {
		object [] results = this.Invoke("get_description", new object [] {
				nodes});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] nodes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			nodes}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dynamic_ratio
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddressV2", ResponseNamespace="urn:iControl:LocalLB/NodeAddressV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public short [] get_dynamic_ratio(
		string [] nodes
	) {
		object [] results = this.Invoke("get_dynamic_ratio", new object [] {
				nodes});
		return ((short [])(results[0]));
	}
	public System.IAsyncResult Beginget_dynamic_ratio(string [] nodes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dynamic_ratio", new object[] {
			nodes}, callback, asyncState);
	}
	public short [] Endget_dynamic_ratio(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((short [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dynamic_ratio_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddressV2", ResponseNamespace="urn:iControl:LocalLB/NodeAddressV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_dynamic_ratio_v2(
		string [] nodes
	) {
		object [] results = this.Invoke("get_dynamic_ratio_v2", new object [] {
				nodes});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_dynamic_ratio_v2(string [] nodes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dynamic_ratio_v2", new object[] {
			nodes}, callback, asyncState);
	}
	public long [] Endget_dynamic_ratio_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddressV2", ResponseNamespace="urn:iControl:LocalLB/NodeAddressV2")]
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
	// get_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddressV2", ResponseNamespace="urn:iControl:LocalLB/NodeAddressV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_metadata(
		string [] nodes
	) {
		object [] results = this.Invoke("get_metadata", new object [] {
				nodes});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata(string [] nodes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_metadata", new object[] {
			nodes}, callback, asyncState);
	}
	public string [] [] Endget_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_metadata_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddressV2", ResponseNamespace="urn:iControl:LocalLB/NodeAddressV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_metadata_description(
		string [] nodes,
		string [] [] names
	) {
		object [] results = this.Invoke("get_metadata_description", new object [] {
				nodes,
				names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata_description(string [] nodes,string [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_metadata_description", new object[] {
			nodes,
			names}, callback, asyncState);
	}
	public string [] [] Endget_metadata_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_metadata_persistence
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddressV2", ResponseNamespace="urn:iControl:LocalLB/NodeAddressV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonMetadataPersistence [] [] get_metadata_persistence(
		string [] nodes,
		string [] [] names
	) {
		object [] results = this.Invoke("get_metadata_persistence", new object [] {
				nodes,
				names});
		return ((CommonMetadataPersistence [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata_persistence(string [] nodes,string [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_metadata_persistence", new object[] {
			nodes,
			names}, callback, asyncState);
	}
	public CommonMetadataPersistence [] [] Endget_metadata_persistence(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonMetadataPersistence [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_metadata_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddressV2", ResponseNamespace="urn:iControl:LocalLB/NodeAddressV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_metadata_value(
		string [] nodes,
		string [] [] names
	) {
		object [] results = this.Invoke("get_metadata_value", new object [] {
				nodes,
				names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata_value(string [] nodes,string [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_metadata_value", new object[] {
			nodes,
			names}, callback, asyncState);
	}
	public string [] [] Endget_metadata_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_monitor_instance
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddressV2", ResponseNamespace="urn:iControl:LocalLB/NodeAddressV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBMonitorInstanceState [] [] get_monitor_instance(
		string [] nodes
	) {
		object [] results = this.Invoke("get_monitor_instance", new object [] {
				nodes});
		return ((LocalLBMonitorInstanceState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_monitor_instance(string [] nodes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_monitor_instance", new object[] {
			nodes}, callback, asyncState);
	}
	public LocalLBMonitorInstanceState [] [] Endget_monitor_instance(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBMonitorInstanceState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_monitor_logging_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddressV2", ResponseNamespace="urn:iControl:LocalLB/NodeAddressV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_monitor_logging_state(
		string [] nodes
	) {
		object [] results = this.Invoke("get_monitor_logging_state", new object [] {
				nodes});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_monitor_logging_state(string [] nodes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_monitor_logging_state", new object[] {
			nodes}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_monitor_logging_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_monitor_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddressV2", ResponseNamespace="urn:iControl:LocalLB/NodeAddressV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBMonitorRule [] get_monitor_rule(
		string [] nodes
	) {
		object [] results = this.Invoke("get_monitor_rule", new object [] {
				nodes});
		return ((LocalLBMonitorRule [])(results[0]));
	}
	public System.IAsyncResult Beginget_monitor_rule(string [] nodes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_monitor_rule", new object[] {
			nodes}, callback, asyncState);
	}
	public LocalLBMonitorRule [] Endget_monitor_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBMonitorRule [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_monitor_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddressV2", ResponseNamespace="urn:iControl:LocalLB/NodeAddressV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBMonitorStatus [] get_monitor_status(
		string [] nodes
	) {
		object [] results = this.Invoke("get_monitor_status", new object [] {
				nodes});
		return ((LocalLBMonitorStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_monitor_status(string [] nodes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_monitor_status", new object[] {
			nodes}, callback, asyncState);
	}
	public LocalLBMonitorStatus [] Endget_monitor_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBMonitorStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_object_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddressV2", ResponseNamespace="urn:iControl:LocalLB/NodeAddressV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBObjectStatus [] get_object_status(
		string [] nodes
	) {
		object [] results = this.Invoke("get_object_status", new object [] {
				nodes});
		return ((LocalLBObjectStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_object_status(string [] nodes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_object_status", new object[] {
			nodes}, callback, asyncState);
	}
	public LocalLBObjectStatus [] Endget_object_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBObjectStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rate_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddressV2", ResponseNamespace="urn:iControl:LocalLB/NodeAddressV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_rate_limit(
		string [] nodes
	) {
		object [] results = this.Invoke("get_rate_limit", new object [] {
				nodes});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_rate_limit(string [] nodes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rate_limit", new object[] {
			nodes}, callback, asyncState);
	}
	public long [] Endget_rate_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ratio
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddressV2", ResponseNamespace="urn:iControl:LocalLB/NodeAddressV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_ratio(
		string [] nodes
	) {
		object [] results = this.Invoke("get_ratio", new object [] {
				nodes});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_ratio(string [] nodes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ratio", new object[] {
			nodes}, callback, asyncState);
	}
	public long [] Endget_ratio(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_session_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddressV2", ResponseNamespace="urn:iControl:LocalLB/NodeAddressV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBSessionStatus [] get_session_status(
		string [] nodes
	) {
		object [] results = this.Invoke("get_session_status", new object [] {
				nodes});
		return ((LocalLBSessionStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_session_status(string [] nodes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_session_status", new object[] {
			nodes}, callback, asyncState);
	}
	public LocalLBSessionStatus [] Endget_session_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBSessionStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddressV2", ResponseNamespace="urn:iControl:LocalLB/NodeAddressV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBNodeAddressV2NodeAddressStatistics get_statistics(
		string [] nodes
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				nodes});
		return ((LocalLBNodeAddressV2NodeAddressStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] nodes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			nodes}, callback, asyncState);
	}
	public LocalLBNodeAddressV2NodeAddressStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBNodeAddressV2NodeAddressStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_traffic_acceleration_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddressV2", ResponseNamespace="urn:iControl:LocalLB/NodeAddressV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonTrafficAccelerationStatus [] get_traffic_acceleration_status(
		string [] nodes
	) {
		object [] results = this.Invoke("get_traffic_acceleration_status", new object [] {
				nodes});
		return ((CommonTrafficAccelerationStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_traffic_acceleration_status(string [] nodes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_traffic_acceleration_status", new object[] {
			nodes}, callback, asyncState);
	}
	public CommonTrafficAccelerationStatus [] Endget_traffic_acceleration_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonTrafficAccelerationStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddressV2", ResponseNamespace="urn:iControl:LocalLB/NodeAddressV2")]
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
	// remove_all_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddressV2", ResponseNamespace="urn:iControl:LocalLB/NodeAddressV2")]
	public void remove_all_metadata(
		string [] nodes
	) {
		this.Invoke("remove_all_metadata", new object [] {
				nodes});

	}
	public System.IAsyncResult Beginremove_all_metadata(string [] nodes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_metadata", new object[] {
			nodes}, callback, asyncState);
	}
	public void Endremove_all_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddressV2", ResponseNamespace="urn:iControl:LocalLB/NodeAddressV2")]
	public void remove_metadata(
		string [] nodes,
		string [] [] names
	) {
		this.Invoke("remove_metadata", new object [] {
				nodes,
				names});

	}
	public System.IAsyncResult Beginremove_metadata(string [] nodes,string [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_metadata", new object[] {
			nodes,
			names}, callback, asyncState);
	}
	public void Endremove_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddressV2", ResponseNamespace="urn:iControl:LocalLB/NodeAddressV2")]
	public void reset_statistics(
		string [] nodes
	) {
		this.Invoke("reset_statistics", new object [] {
				nodes});

	}
	public System.IAsyncResult Beginreset_statistics(string [] nodes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics", new object[] {
			nodes}, callback, asyncState);
	}
	public void Endreset_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_connection_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddressV2", ResponseNamespace="urn:iControl:LocalLB/NodeAddressV2")]
	public void set_connection_limit(
		string [] nodes,
		long [] limits
	) {
		this.Invoke("set_connection_limit", new object [] {
				nodes,
				limits});

	}
	public System.IAsyncResult Beginset_connection_limit(string [] nodes,long [] limits, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_connection_limit", new object[] {
			nodes,
			limits}, callback, asyncState);
	}
	public void Endset_connection_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_node_monitor
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddressV2", ResponseNamespace="urn:iControl:LocalLB/NodeAddressV2")]
	public void set_default_node_monitor(
		LocalLBMonitorRule monitor_rule
	) {
		this.Invoke("set_default_node_monitor", new object [] {
				monitor_rule});

	}
	public System.IAsyncResult Beginset_default_node_monitor(LocalLBMonitorRule monitor_rule, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_node_monitor", new object[] {
			monitor_rule}, callback, asyncState);
	}
	public void Endset_default_node_monitor(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddressV2", ResponseNamespace="urn:iControl:LocalLB/NodeAddressV2")]
	public void set_description(
		string [] nodes,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				nodes,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] nodes,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			nodes,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dynamic_ratio
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddressV2", ResponseNamespace="urn:iControl:LocalLB/NodeAddressV2")]
	public void set_dynamic_ratio(
		string [] nodes,
		short [] dynamic_ratios
	) {
		this.Invoke("set_dynamic_ratio", new object [] {
				nodes,
				dynamic_ratios});

	}
	public System.IAsyncResult Beginset_dynamic_ratio(string [] nodes,short [] dynamic_ratios, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dynamic_ratio", new object[] {
			nodes,
			dynamic_ratios}, callback, asyncState);
	}
	public void Endset_dynamic_ratio(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dynamic_ratio_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddressV2", ResponseNamespace="urn:iControl:LocalLB/NodeAddressV2")]
	public void set_dynamic_ratio_v2(
		string [] nodes,
		long [] dynamic_ratios
	) {
		this.Invoke("set_dynamic_ratio_v2", new object [] {
				nodes,
				dynamic_ratios});

	}
	public System.IAsyncResult Beginset_dynamic_ratio_v2(string [] nodes,long [] dynamic_ratios, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dynamic_ratio_v2", new object[] {
			nodes,
			dynamic_ratios}, callback, asyncState);
	}
	public void Endset_dynamic_ratio_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_metadata_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddressV2", ResponseNamespace="urn:iControl:LocalLB/NodeAddressV2")]
	public void set_metadata_description(
		string [] nodes,
		string [] [] names,
		string [] [] descriptions
	) {
		this.Invoke("set_metadata_description", new object [] {
				nodes,
				names,
				descriptions});

	}
	public System.IAsyncResult Beginset_metadata_description(string [] nodes,string [] [] names,string [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_metadata_description", new object[] {
			nodes,
			names,
			descriptions}, callback, asyncState);
	}
	public void Endset_metadata_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_metadata_persistence
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddressV2", ResponseNamespace="urn:iControl:LocalLB/NodeAddressV2")]
	public void set_metadata_persistence(
		string [] nodes,
		string [] [] names,
		CommonMetadataPersistence [] [] values
	) {
		this.Invoke("set_metadata_persistence", new object [] {
				nodes,
				names,
				values});

	}
	public System.IAsyncResult Beginset_metadata_persistence(string [] nodes,string [] [] names,CommonMetadataPersistence [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_metadata_persistence", new object[] {
			nodes,
			names,
			values}, callback, asyncState);
	}
	public void Endset_metadata_persistence(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_metadata_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddressV2", ResponseNamespace="urn:iControl:LocalLB/NodeAddressV2")]
	public void set_metadata_value(
		string [] nodes,
		string [] [] names,
		string [] [] values
	) {
		this.Invoke("set_metadata_value", new object [] {
				nodes,
				names,
				values});

	}
	public System.IAsyncResult Beginset_metadata_value(string [] nodes,string [] [] names,string [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_metadata_value", new object[] {
			nodes,
			names,
			values}, callback, asyncState);
	}
	public void Endset_metadata_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_monitor_logging_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddressV2", ResponseNamespace="urn:iControl:LocalLB/NodeAddressV2")]
	public void set_monitor_logging_state(
		string [] nodes,
		CommonEnabledState [] states
	) {
		this.Invoke("set_monitor_logging_state", new object [] {
				nodes,
				states});

	}
	public System.IAsyncResult Beginset_monitor_logging_state(string [] nodes,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_monitor_logging_state", new object[] {
			nodes,
			states}, callback, asyncState);
	}
	public void Endset_monitor_logging_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_monitor_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddressV2", ResponseNamespace="urn:iControl:LocalLB/NodeAddressV2")]
	public void set_monitor_rule(
		string [] nodes,
		LocalLBMonitorRule [] monitor_rules
	) {
		this.Invoke("set_monitor_rule", new object [] {
				nodes,
				monitor_rules});

	}
	public System.IAsyncResult Beginset_monitor_rule(string [] nodes,LocalLBMonitorRule [] monitor_rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_monitor_rule", new object[] {
			nodes,
			monitor_rules}, callback, asyncState);
	}
	public void Endset_monitor_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_monitor_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddressV2", ResponseNamespace="urn:iControl:LocalLB/NodeAddressV2")]
	public void set_monitor_state(
		string [] nodes,
		CommonEnabledState [] states
	) {
		this.Invoke("set_monitor_state", new object [] {
				nodes,
				states});

	}
	public System.IAsyncResult Beginset_monitor_state(string [] nodes,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_monitor_state", new object[] {
			nodes,
			states}, callback, asyncState);
	}
	public void Endset_monitor_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rate_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddressV2", ResponseNamespace="urn:iControl:LocalLB/NodeAddressV2")]
	public void set_rate_limit(
		string [] nodes,
		long [] limits
	) {
		this.Invoke("set_rate_limit", new object [] {
				nodes,
				limits});

	}
	public System.IAsyncResult Beginset_rate_limit(string [] nodes,long [] limits, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rate_limit", new object[] {
			nodes,
			limits}, callback, asyncState);
	}
	public void Endset_rate_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ratio
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddressV2", ResponseNamespace="urn:iControl:LocalLB/NodeAddressV2")]
	public void set_ratio(
		string [] nodes,
		long [] ratios
	) {
		this.Invoke("set_ratio", new object [] {
				nodes,
				ratios});

	}
	public System.IAsyncResult Beginset_ratio(string [] nodes,long [] ratios, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ratio", new object[] {
			nodes,
			ratios}, callback, asyncState);
	}
	public void Endset_ratio(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_session_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NodeAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/NodeAddressV2", ResponseNamespace="urn:iControl:LocalLB/NodeAddressV2")]
	public void set_session_enabled_state(
		string [] nodes,
		CommonEnabledState [] states
	) {
		this.Invoke("set_session_enabled_state", new object [] {
				nodes,
				states});

	}
	public System.IAsyncResult Beginset_session_enabled_state(string [] nodes,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_session_enabled_state", new object[] {
			nodes,
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.NodeAddressV2.NodeAddressStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBNodeAddressV2NodeAddressStatisticEntry
	{
		private string nodeField;
		public string node
		{
			get { return this.nodeField; }
			set { this.nodeField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.NodeAddressV2.NodeAddressStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBNodeAddressV2NodeAddressStatistics
	{
		private LocalLBNodeAddressV2NodeAddressStatisticEntry [] statisticsField;
		public LocalLBNodeAddressV2NodeAddressStatisticEntry [] statistics
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
