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
	[System.Web.Services.WebServiceBindingAttribute(Name="GlobalLB.LinkBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBLinkLinkCostSegment))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBLinkLinkIPDefinition))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBLinkLinkStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBLinkLinkMetricLimit))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBLinkMonitorAssociation))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonObjectStatus))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonULong64))]
	public partial class GlobalLBLink : iControlInterface {
		public GlobalLBLink() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_cost_segment
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Link", 
		RequestNamespace="urn:iControl:GlobalLB/Link", ResponseNamespace="urn:iControl:GlobalLB/Link")]
	public void add_cost_segment(
		string [] links,
		GlobalLBLinkLinkCostSegment [] [] cost_segments
	) {
		this.Invoke("add_cost_segment", new object [] {
				links,
				cost_segments});

	}
	public System.IAsyncResult Beginadd_cost_segment(string [] links,GlobalLBLinkLinkCostSegment [] [] cost_segments, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_cost_segment", new object[] {
			links,
			cost_segments}, callback, asyncState);
	}
	public void Endadd_cost_segment(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_ip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Link", 
		RequestNamespace="urn:iControl:GlobalLB/Link", ResponseNamespace="urn:iControl:GlobalLB/Link")]
	public void add_ip(
		GlobalLBLinkLinkIPDefinition [] ips
	) {
		this.Invoke("add_ip", new object [] {
				ips});

	}
	public System.IAsyncResult Beginadd_ip(GlobalLBLinkLinkIPDefinition [] ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_ip", new object[] {
			ips}, callback, asyncState);
	}
	public void Endadd_ip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Link", 
		RequestNamespace="urn:iControl:GlobalLB/Link", ResponseNamespace="urn:iControl:GlobalLB/Link")]
	public void create(
		GlobalLBLinkLinkIPDefinition [] links,
		string [] data_centers
	) {
		this.Invoke("create", new object [] {
				links,
				data_centers});

	}
	public System.IAsyncResult Begincreate(GlobalLBLinkLinkIPDefinition [] links,string [] data_centers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			links,
			data_centers}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_links
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Link", 
		RequestNamespace="urn:iControl:GlobalLB/Link", ResponseNamespace="urn:iControl:GlobalLB/Link")]
	public void delete_all_links(

	) {
		this.Invoke("delete_all_links", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_links(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_links", new object[0], callback, asyncState);
	}
	public void Enddelete_all_links(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_link
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Link", 
		RequestNamespace="urn:iControl:GlobalLB/Link", ResponseNamespace="urn:iControl:GlobalLB/Link")]
	public void delete_link(
		string [] links
	) {
		this.Invoke("delete_link", new object [] {
				links});

	}
	public System.IAsyncResult Begindelete_link(string [] links, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_link", new object[] {
			links}, callback, asyncState);
	}
	public void Enddelete_link(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Link", 
		RequestNamespace="urn:iControl:GlobalLB/Link", ResponseNamespace="urn:iControl:GlobalLB/Link")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBLinkLinkStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((GlobalLBLinkLinkStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public GlobalLBLinkLinkStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBLinkLinkStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cost_segment
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Link", 
		RequestNamespace="urn:iControl:GlobalLB/Link", ResponseNamespace="urn:iControl:GlobalLB/Link")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBLinkLinkCostSegment [] [] get_cost_segment(
		string [] links
	) {
		object [] results = this.Invoke("get_cost_segment", new object [] {
				links});
		return ((GlobalLBLinkLinkCostSegment [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_cost_segment(string [] links, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cost_segment", new object[] {
			links}, callback, asyncState);
	}
	public GlobalLBLinkLinkCostSegment [] [] Endget_cost_segment(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBLinkLinkCostSegment [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_data_center
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Link", 
		RequestNamespace="urn:iControl:GlobalLB/Link", ResponseNamespace="urn:iControl:GlobalLB/Link")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_data_center(
		string [] links
	) {
		object [] results = this.Invoke("get_data_center", new object [] {
				links});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_data_center(string [] links, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_data_center", new object[] {
			links}, callback, asyncState);
	}
	public string [] Endget_data_center(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Link", 
		RequestNamespace="urn:iControl:GlobalLB/Link", ResponseNamespace="urn:iControl:GlobalLB/Link")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] links
	) {
		object [] results = this.Invoke("get_description", new object [] {
				links});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] links, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			links}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_duplex_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Link", 
		RequestNamespace="urn:iControl:GlobalLB/Link", ResponseNamespace="urn:iControl:GlobalLB/Link")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_duplex_state(
		string [] links
	) {
		object [] results = this.Invoke("get_duplex_state", new object [] {
				links});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_duplex_state(string [] links, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_duplex_state", new object[] {
			links}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_duplex_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Link", 
		RequestNamespace="urn:iControl:GlobalLB/Link", ResponseNamespace="urn:iControl:GlobalLB/Link")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_enabled_state(
		string [] links
	) {
		object [] results = this.Invoke("get_enabled_state", new object [] {
				links});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_enabled_state(string [] links, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_enabled_state", new object[] {
			links}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_inbound_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Link", 
		RequestNamespace="urn:iControl:GlobalLB/Link", ResponseNamespace="urn:iControl:GlobalLB/Link")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBLinkLinkMetricLimit [] get_inbound_limit(
		string [] links
	) {
		object [] results = this.Invoke("get_inbound_limit", new object [] {
				links});
		return ((GlobalLBLinkLinkMetricLimit [])(results[0]));
	}
	public System.IAsyncResult Beginget_inbound_limit(string [] links, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_inbound_limit", new object[] {
			links}, callback, asyncState);
	}
	public GlobalLBLinkLinkMetricLimit [] Endget_inbound_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBLinkLinkMetricLimit [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Link", 
		RequestNamespace="urn:iControl:GlobalLB/Link", ResponseNamespace="urn:iControl:GlobalLB/Link")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBLinkLinkIPDefinition [] get_ip(
		string [] links
	) {
		object [] results = this.Invoke("get_ip", new object [] {
				links});
		return ((GlobalLBLinkLinkIPDefinition [])(results[0]));
	}
	public System.IAsyncResult Beginget_ip(string [] links, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ip", new object[] {
			links}, callback, asyncState);
	}
	public GlobalLBLinkLinkIPDefinition [] Endget_ip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBLinkLinkIPDefinition [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_isp_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Link", 
		RequestNamespace="urn:iControl:GlobalLB/Link", ResponseNamespace="urn:iControl:GlobalLB/Link")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_isp_name(
		string [] links
	) {
		object [] results = this.Invoke("get_isp_name", new object [] {
				links});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_isp_name(string [] links, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_isp_name", new object[] {
			links}, callback, asyncState);
	}
	public string [] Endget_isp_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Link", 
		RequestNamespace="urn:iControl:GlobalLB/Link", ResponseNamespace="urn:iControl:GlobalLB/Link")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Link", 
		RequestNamespace="urn:iControl:GlobalLB/Link", ResponseNamespace="urn:iControl:GlobalLB/Link")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBLinkMonitorAssociation [] get_monitor_association(
		string [] links
	) {
		object [] results = this.Invoke("get_monitor_association", new object [] {
				links});
		return ((GlobalLBLinkMonitorAssociation [])(results[0]));
	}
	public System.IAsyncResult Beginget_monitor_association(string [] links, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_monitor_association", new object[] {
			links}, callback, asyncState);
	}
	public GlobalLBLinkMonitorAssociation [] Endget_monitor_association(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBLinkMonitorAssociation [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_object_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Link", 
		RequestNamespace="urn:iControl:GlobalLB/Link", ResponseNamespace="urn:iControl:GlobalLB/Link")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonObjectStatus [] get_object_status(
		string [] links
	) {
		object [] results = this.Invoke("get_object_status", new object [] {
				links});
		return ((CommonObjectStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_object_status(string [] links, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_object_status", new object[] {
			links}, callback, asyncState);
	}
	public CommonObjectStatus [] Endget_object_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonObjectStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_outbound_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Link", 
		RequestNamespace="urn:iControl:GlobalLB/Link", ResponseNamespace="urn:iControl:GlobalLB/Link")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBLinkLinkMetricLimit [] get_outbound_limit(
		string [] links
	) {
		object [] results = this.Invoke("get_outbound_limit", new object [] {
				links});
		return ((GlobalLBLinkLinkMetricLimit [])(results[0]));
	}
	public System.IAsyncResult Beginget_outbound_limit(string [] links, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_outbound_limit", new object[] {
			links}, callback, asyncState);
	}
	public GlobalLBLinkLinkMetricLimit [] Endget_outbound_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBLinkLinkMetricLimit [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_prepaid_traffic
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Link", 
		RequestNamespace="urn:iControl:GlobalLB/Link", ResponseNamespace="urn:iControl:GlobalLB/Link")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonULong64 [] get_prepaid_traffic(
		string [] links
	) {
		object [] results = this.Invoke("get_prepaid_traffic", new object [] {
				links});
		return ((CommonULong64 [])(results[0]));
	}
	public System.IAsyncResult Beginget_prepaid_traffic(string [] links, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_prepaid_traffic", new object[] {
			links}, callback, asyncState);
	}
	public CommonULong64 [] Endget_prepaid_traffic(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonULong64 [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ratio
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Link", 
		RequestNamespace="urn:iControl:GlobalLB/Link", ResponseNamespace="urn:iControl:GlobalLB/Link")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_ratio(
		string [] links
	) {
		object [] results = this.Invoke("get_ratio", new object [] {
				links});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_ratio(string [] links, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ratio", new object[] {
			links}, callback, asyncState);
	}
	public long [] Endget_ratio(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Link", 
		RequestNamespace="urn:iControl:GlobalLB/Link", ResponseNamespace="urn:iControl:GlobalLB/Link")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBLinkLinkStatistics get_statistics(
		string [] links
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				links});
		return ((GlobalLBLinkLinkStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] links, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			links}, callback, asyncState);
	}
	public GlobalLBLinkLinkStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBLinkLinkStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_total_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Link", 
		RequestNamespace="urn:iControl:GlobalLB/Link", ResponseNamespace="urn:iControl:GlobalLB/Link")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBLinkLinkMetricLimit [] get_total_limit(
		string [] links
	) {
		object [] results = this.Invoke("get_total_limit", new object [] {
				links});
		return ((GlobalLBLinkLinkMetricLimit [])(results[0]));
	}
	public System.IAsyncResult Beginget_total_limit(string [] links, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_total_limit", new object[] {
			links}, callback, asyncState);
	}
	public GlobalLBLinkLinkMetricLimit [] Endget_total_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBLinkLinkMetricLimit [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_uplink_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Link", 
		RequestNamespace="urn:iControl:GlobalLB/Link", ResponseNamespace="urn:iControl:GlobalLB/Link")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_uplink_address(
		string [] links
	) {
		object [] results = this.Invoke("get_uplink_address", new object [] {
				links});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_uplink_address(string [] links, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_uplink_address", new object[] {
			links}, callback, asyncState);
	}
	public string [] Endget_uplink_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Link", 
		RequestNamespace="urn:iControl:GlobalLB/Link", ResponseNamespace="urn:iControl:GlobalLB/Link")]
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
	// get_weight_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Link", 
		RequestNamespace="urn:iControl:GlobalLB/Link", ResponseNamespace="urn:iControl:GlobalLB/Link")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBLinkWeightType [] get_weight_type(
		string [] links
	) {
		object [] results = this.Invoke("get_weight_type", new object [] {
				links});
		return ((GlobalLBLinkWeightType [])(results[0]));
	}
	public System.IAsyncResult Beginget_weight_type(string [] links, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_weight_type", new object[] {
			links}, callback, asyncState);
	}
	public GlobalLBLinkWeightType [] Endget_weight_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBLinkWeightType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// remove_all_cost_segments
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Link", 
		RequestNamespace="urn:iControl:GlobalLB/Link", ResponseNamespace="urn:iControl:GlobalLB/Link")]
	public void remove_all_cost_segments(
		string [] links
	) {
		this.Invoke("remove_all_cost_segments", new object [] {
				links});

	}
	public System.IAsyncResult Beginremove_all_cost_segments(string [] links, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_cost_segments", new object[] {
			links}, callback, asyncState);
	}
	public void Endremove_all_cost_segments(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_cost_segment
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Link", 
		RequestNamespace="urn:iControl:GlobalLB/Link", ResponseNamespace="urn:iControl:GlobalLB/Link")]
	public void remove_cost_segment(
		string [] links,
		GlobalLBLinkLinkCostSegment [] [] cost_segments
	) {
		this.Invoke("remove_cost_segment", new object [] {
				links,
				cost_segments});

	}
	public System.IAsyncResult Beginremove_cost_segment(string [] links,GlobalLBLinkLinkCostSegment [] [] cost_segments, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_cost_segment", new object[] {
			links,
			cost_segments}, callback, asyncState);
	}
	public void Endremove_cost_segment(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_ip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Link", 
		RequestNamespace="urn:iControl:GlobalLB/Link", ResponseNamespace="urn:iControl:GlobalLB/Link")]
	public void remove_ip(
		GlobalLBLinkLinkIPDefinition [] ips
	) {
		this.Invoke("remove_ip", new object [] {
				ips});

	}
	public System.IAsyncResult Beginremove_ip(GlobalLBLinkLinkIPDefinition [] ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_ip", new object[] {
			ips}, callback, asyncState);
	}
	public void Endremove_ip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_monitor_association
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Link", 
		RequestNamespace="urn:iControl:GlobalLB/Link", ResponseNamespace="urn:iControl:GlobalLB/Link")]
	public void remove_monitor_association(
		string [] links
	) {
		this.Invoke("remove_monitor_association", new object [] {
				links});

	}
	public System.IAsyncResult Beginremove_monitor_association(string [] links, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_monitor_association", new object[] {
			links}, callback, asyncState);
	}
	public void Endremove_monitor_association(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Link", 
		RequestNamespace="urn:iControl:GlobalLB/Link", ResponseNamespace="urn:iControl:GlobalLB/Link")]
	public void reset_statistics(
		string [] links
	) {
		this.Invoke("reset_statistics", new object [] {
				links});

	}
	public System.IAsyncResult Beginreset_statistics(string [] links, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics", new object[] {
			links}, callback, asyncState);
	}
	public void Endreset_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_data_center
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Link", 
		RequestNamespace="urn:iControl:GlobalLB/Link", ResponseNamespace="urn:iControl:GlobalLB/Link")]
	public void set_data_center(
		string [] links,
		string [] data_centers
	) {
		this.Invoke("set_data_center", new object [] {
				links,
				data_centers});

	}
	public System.IAsyncResult Beginset_data_center(string [] links,string [] data_centers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_data_center", new object[] {
			links,
			data_centers}, callback, asyncState);
	}
	public void Endset_data_center(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Link", 
		RequestNamespace="urn:iControl:GlobalLB/Link", ResponseNamespace="urn:iControl:GlobalLB/Link")]
	public void set_description(
		string [] links,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				links,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] links,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			links,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_duplex_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Link", 
		RequestNamespace="urn:iControl:GlobalLB/Link", ResponseNamespace="urn:iControl:GlobalLB/Link")]
	public void set_duplex_state(
		string [] links,
		CommonEnabledState [] states
	) {
		this.Invoke("set_duplex_state", new object [] {
				links,
				states});

	}
	public System.IAsyncResult Beginset_duplex_state(string [] links,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_duplex_state", new object[] {
			links,
			states}, callback, asyncState);
	}
	public void Endset_duplex_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Link", 
		RequestNamespace="urn:iControl:GlobalLB/Link", ResponseNamespace="urn:iControl:GlobalLB/Link")]
	public void set_enabled_state(
		string [] links,
		CommonEnabledState [] states
	) {
		this.Invoke("set_enabled_state", new object [] {
				links,
				states});

	}
	public System.IAsyncResult Beginset_enabled_state(string [] links,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_enabled_state", new object[] {
			links,
			states}, callback, asyncState);
	}
	public void Endset_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_inbound_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Link", 
		RequestNamespace="urn:iControl:GlobalLB/Link", ResponseNamespace="urn:iControl:GlobalLB/Link")]
	public void set_inbound_limit(
		GlobalLBLinkLinkMetricLimit [] limits
	) {
		this.Invoke("set_inbound_limit", new object [] {
				limits});

	}
	public System.IAsyncResult Beginset_inbound_limit(GlobalLBLinkLinkMetricLimit [] limits, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_inbound_limit", new object[] {
			limits}, callback, asyncState);
	}
	public void Endset_inbound_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_isp_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Link", 
		RequestNamespace="urn:iControl:GlobalLB/Link", ResponseNamespace="urn:iControl:GlobalLB/Link")]
	public void set_isp_name(
		string [] links,
		string [] isp_names
	) {
		this.Invoke("set_isp_name", new object [] {
				links,
				isp_names});

	}
	public System.IAsyncResult Beginset_isp_name(string [] links,string [] isp_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_isp_name", new object[] {
			links,
			isp_names}, callback, asyncState);
	}
	public void Endset_isp_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_monitor_association
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Link", 
		RequestNamespace="urn:iControl:GlobalLB/Link", ResponseNamespace="urn:iControl:GlobalLB/Link")]
	public void set_monitor_association(
		GlobalLBLinkMonitorAssociation [] monitor_associations
	) {
		this.Invoke("set_monitor_association", new object [] {
				monitor_associations});

	}
	public System.IAsyncResult Beginset_monitor_association(GlobalLBLinkMonitorAssociation [] monitor_associations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_monitor_association", new object[] {
			monitor_associations}, callback, asyncState);
	}
	public void Endset_monitor_association(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_outbound_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Link", 
		RequestNamespace="urn:iControl:GlobalLB/Link", ResponseNamespace="urn:iControl:GlobalLB/Link")]
	public void set_outbound_limit(
		GlobalLBLinkLinkMetricLimit [] limits
	) {
		this.Invoke("set_outbound_limit", new object [] {
				limits});

	}
	public System.IAsyncResult Beginset_outbound_limit(GlobalLBLinkLinkMetricLimit [] limits, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_outbound_limit", new object[] {
			limits}, callback, asyncState);
	}
	public void Endset_outbound_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_prepaid_traffic
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Link", 
		RequestNamespace="urn:iControl:GlobalLB/Link", ResponseNamespace="urn:iControl:GlobalLB/Link")]
	public void set_prepaid_traffic(
		string [] links,
		CommonULong64 [] prepaids
	) {
		this.Invoke("set_prepaid_traffic", new object [] {
				links,
				prepaids});

	}
	public System.IAsyncResult Beginset_prepaid_traffic(string [] links,CommonULong64 [] prepaids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_prepaid_traffic", new object[] {
			links,
			prepaids}, callback, asyncState);
	}
	public void Endset_prepaid_traffic(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ratio
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Link", 
		RequestNamespace="urn:iControl:GlobalLB/Link", ResponseNamespace="urn:iControl:GlobalLB/Link")]
	public void set_ratio(
		string [] links,
		long [] ratios
	) {
		this.Invoke("set_ratio", new object [] {
				links,
				ratios});

	}
	public System.IAsyncResult Beginset_ratio(string [] links,long [] ratios, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ratio", new object[] {
			links,
			ratios}, callback, asyncState);
	}
	public void Endset_ratio(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_total_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Link", 
		RequestNamespace="urn:iControl:GlobalLB/Link", ResponseNamespace="urn:iControl:GlobalLB/Link")]
	public void set_total_limit(
		GlobalLBLinkLinkMetricLimit [] limits
	) {
		this.Invoke("set_total_limit", new object [] {
				limits});

	}
	public System.IAsyncResult Beginset_total_limit(GlobalLBLinkLinkMetricLimit [] limits, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_total_limit", new object[] {
			limits}, callback, asyncState);
	}
	public void Endset_total_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_uplink_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Link", 
		RequestNamespace="urn:iControl:GlobalLB/Link", ResponseNamespace="urn:iControl:GlobalLB/Link")]
	public void set_uplink_address(
		string [] links,
		string [] uplinks
	) {
		this.Invoke("set_uplink_address", new object [] {
				links,
				uplinks});

	}
	public System.IAsyncResult Beginset_uplink_address(string [] links,string [] uplinks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_uplink_address", new object[] {
			links,
			uplinks}, callback, asyncState);
	}
	public void Endset_uplink_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_weight_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Link", 
		RequestNamespace="urn:iControl:GlobalLB/Link", ResponseNamespace="urn:iControl:GlobalLB/Link")]
	public void set_weight_type(
		string [] links,
		GlobalLBLinkWeightType [] weight_types
	) {
		this.Invoke("set_weight_type", new object [] {
				links,
				weight_types});

	}
	public System.IAsyncResult Beginset_weight_type(string [] links,GlobalLBLinkWeightType [] weight_types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_weight_type", new object[] {
			links,
			weight_types}, callback, asyncState);
	}
	public void Endset_weight_type(System.IAsyncResult asyncResult) {
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.Link.LinkCostSegment", Namespace = "urn:iControl")]
	public partial class GlobalLBLinkLinkCostSegment
	{
		private CommonULong64 upper_limitField;
		public CommonULong64 upper_limit
		{
			get { return this.upper_limitField; }
			set { this.upper_limitField = value; }
		}
		private long price_per_mbpsField;
		public long price_per_mbps
		{
			get { return this.price_per_mbpsField; }
			set { this.price_per_mbpsField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.Link.LinkIPDefinition", Namespace = "urn:iControl")]
	public partial class GlobalLBLinkLinkIPDefinition
	{
		private string linkField;
		public string link
		{
			get { return this.linkField; }
			set { this.linkField = value; }
		}
		private string [] addressesField;
		public string [] addresses
		{
			get { return this.addressesField; }
			set { this.addressesField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.Link.LinkMetricLimit", Namespace = "urn:iControl")]
	public partial class GlobalLBLinkLinkMetricLimit
	{
		private string linkField;
		public string link
		{
			get { return this.linkField; }
			set { this.linkField = value; }
		}
		private GlobalLBMetricLimit [] metric_limitsField;
		public GlobalLBMetricLimit [] metric_limits
		{
			get { return this.metric_limitsField; }
			set { this.metric_limitsField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.Link.LinkStatisticEntry", Namespace = "urn:iControl")]
	public partial class GlobalLBLinkLinkStatisticEntry
	{
		private string linkField;
		public string link
		{
			get { return this.linkField; }
			set { this.linkField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.Link.LinkStatistics", Namespace = "urn:iControl")]
	public partial class GlobalLBLinkLinkStatistics
	{
		private GlobalLBLinkLinkStatisticEntry [] statisticsField;
		public GlobalLBLinkLinkStatisticEntry [] statistics
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

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.Link.MonitorAssociation", Namespace = "urn:iControl")]
	public partial class GlobalLBLinkMonitorAssociation
	{
		private string linkField;
		public string link
		{
			get { return this.linkField; }
			set { this.linkField = value; }
		}
		private GlobalLBMonitorRule monitor_ruleField;
		public GlobalLBMonitorRule monitor_rule
		{
			get { return this.monitor_ruleField; }
			set { this.monitor_ruleField = value; }
		}
	};

}
