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
	[System.Web.Services.WebServiceBindingAttribute(Name="Networking.PacketFilterBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(NetworkingPacketFilterPacketFilterStatistics))]
	public partial class NetworkingPacketFilter : iControlInterface {
		public NetworkingPacketFilter() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PacketFilter", 
		RequestNamespace="urn:iControl:Networking/PacketFilter", ResponseNamespace="urn:iControl:Networking/PacketFilter")]
	public void create(
		string [] filters,
		long [] sort_orders,
		NetworkingFilterAction [] actions,
		string [] expressions
	) {
		this.Invoke("create", new object [] {
				filters,
				sort_orders,
				actions,
				expressions});

	}
	public System.IAsyncResult Begincreate(string [] filters,long [] sort_orders,NetworkingFilterAction [] actions,string [] expressions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			filters,
			sort_orders,
			actions,
			expressions}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_packet_filters
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PacketFilter", 
		RequestNamespace="urn:iControl:Networking/PacketFilter", ResponseNamespace="urn:iControl:Networking/PacketFilter")]
	public void delete_all_packet_filters(

	) {
		this.Invoke("delete_all_packet_filters", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_packet_filters(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_packet_filters", new object[0], callback, asyncState);
	}
	public void Enddelete_all_packet_filters(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_packet_filter
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PacketFilter", 
		RequestNamespace="urn:iControl:Networking/PacketFilter", ResponseNamespace="urn:iControl:Networking/PacketFilter")]
	public void delete_packet_filter(
		string [] filters
	) {
		this.Invoke("delete_packet_filter", new object [] {
				filters});

	}
	public System.IAsyncResult Begindelete_packet_filter(string [] filters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_packet_filter", new object[] {
			filters}, callback, asyncState);
	}
	public void Enddelete_packet_filter(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PacketFilter", 
		RequestNamespace="urn:iControl:Networking/PacketFilter", ResponseNamespace="urn:iControl:Networking/PacketFilter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingFilterAction [] get_action(
		string [] filters
	) {
		object [] results = this.Invoke("get_action", new object [] {
				filters});
		return ((NetworkingFilterAction [])(results[0]));
	}
	public System.IAsyncResult Beginget_action(string [] filters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action", new object[] {
			filters}, callback, asyncState);
	}
	public NetworkingFilterAction [] Endget_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingFilterAction [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PacketFilter", 
		RequestNamespace="urn:iControl:Networking/PacketFilter", ResponseNamespace="urn:iControl:Networking/PacketFilter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingPacketFilterPacketFilterStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((NetworkingPacketFilterPacketFilterStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public NetworkingPacketFilterPacketFilterStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingPacketFilterPacketFilterStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_bw_controller_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PacketFilter", 
		RequestNamespace="urn:iControl:Networking/PacketFilter", ResponseNamespace="urn:iControl:Networking/PacketFilter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_bw_controller_policy(
		string [] filters
	) {
		object [] results = this.Invoke("get_bw_controller_policy", new object [] {
				filters});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_bw_controller_policy(string [] filters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_bw_controller_policy", new object[] {
			filters}, callback, asyncState);
	}
	public string [] Endget_bw_controller_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PacketFilter", 
		RequestNamespace="urn:iControl:Networking/PacketFilter", ResponseNamespace="urn:iControl:Networking/PacketFilter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] filters
	) {
		object [] results = this.Invoke("get_description", new object [] {
				filters});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] filters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			filters}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_expression
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PacketFilter", 
		RequestNamespace="urn:iControl:Networking/PacketFilter", ResponseNamespace="urn:iControl:Networking/PacketFilter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_expression(
		string [] filters
	) {
		object [] results = this.Invoke("get_expression", new object [] {
				filters});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_expression(string [] filters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_expression", new object[] {
			filters}, callback, asyncState);
	}
	public string [] Endget_expression(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PacketFilter", 
		RequestNamespace="urn:iControl:Networking/PacketFilter", ResponseNamespace="urn:iControl:Networking/PacketFilter")]
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
	// get_log_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PacketFilter", 
		RequestNamespace="urn:iControl:Networking/PacketFilter", ResponseNamespace="urn:iControl:Networking/PacketFilter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_log_state(
		string [] filters
	) {
		object [] results = this.Invoke("get_log_state", new object [] {
				filters});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_log_state(string [] filters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_log_state", new object[] {
			filters}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_log_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rate_class
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PacketFilter", 
		RequestNamespace="urn:iControl:Networking/PacketFilter", ResponseNamespace="urn:iControl:Networking/PacketFilter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_rate_class(
		string [] filters
	) {
		object [] results = this.Invoke("get_rate_class", new object [] {
				filters});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_rate_class(string [] filters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rate_class", new object[] {
			filters}, callback, asyncState);
	}
	public string [] Endget_rate_class(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_sort_order
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PacketFilter", 
		RequestNamespace="urn:iControl:Networking/PacketFilter", ResponseNamespace="urn:iControl:Networking/PacketFilter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_sort_order(
		string [] filters
	) {
		object [] results = this.Invoke("get_sort_order", new object [] {
				filters});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_sort_order(string [] filters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_sort_order", new object[] {
			filters}, callback, asyncState);
	}
	public long [] Endget_sort_order(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PacketFilter", 
		RequestNamespace="urn:iControl:Networking/PacketFilter", ResponseNamespace="urn:iControl:Networking/PacketFilter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingPacketFilterPacketFilterStatistics get_statistics(
		string [] filters
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				filters});
		return ((NetworkingPacketFilterPacketFilterStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] filters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			filters}, callback, asyncState);
	}
	public NetworkingPacketFilterPacketFilterStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingPacketFilterPacketFilterStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PacketFilter", 
		RequestNamespace="urn:iControl:Networking/PacketFilter", ResponseNamespace="urn:iControl:Networking/PacketFilter")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PacketFilter", 
		RequestNamespace="urn:iControl:Networking/PacketFilter", ResponseNamespace="urn:iControl:Networking/PacketFilter")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_vlan(
		string [] filters
	) {
		object [] results = this.Invoke("get_vlan", new object [] {
				filters});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_vlan(string [] filters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_vlan", new object[] {
			filters}, callback, asyncState);
	}
	public string [] Endget_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PacketFilter", 
		RequestNamespace="urn:iControl:Networking/PacketFilter", ResponseNamespace="urn:iControl:Networking/PacketFilter")]
	public void reset_statistics(
		string [] filters
	) {
		this.Invoke("reset_statistics", new object [] {
				filters});

	}
	public System.IAsyncResult Beginreset_statistics(string [] filters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics", new object[] {
			filters}, callback, asyncState);
	}
	public void Endreset_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PacketFilter", 
		RequestNamespace="urn:iControl:Networking/PacketFilter", ResponseNamespace="urn:iControl:Networking/PacketFilter")]
	public void set_action(
		string [] filters,
		NetworkingFilterAction [] actions
	) {
		this.Invoke("set_action", new object [] {
				filters,
				actions});

	}
	public System.IAsyncResult Beginset_action(string [] filters,NetworkingFilterAction [] actions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_action", new object[] {
			filters,
			actions}, callback, asyncState);
	}
	public void Endset_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_bw_controller_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PacketFilter", 
		RequestNamespace="urn:iControl:Networking/PacketFilter", ResponseNamespace="urn:iControl:Networking/PacketFilter")]
	public void set_bw_controller_policy(
		string [] filters,
		string [] policies
	) {
		this.Invoke("set_bw_controller_policy", new object [] {
				filters,
				policies});

	}
	public System.IAsyncResult Beginset_bw_controller_policy(string [] filters,string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_bw_controller_policy", new object[] {
			filters,
			policies}, callback, asyncState);
	}
	public void Endset_bw_controller_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PacketFilter", 
		RequestNamespace="urn:iControl:Networking/PacketFilter", ResponseNamespace="urn:iControl:Networking/PacketFilter")]
	public void set_description(
		string [] filters,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				filters,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] filters,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			filters,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_expression
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PacketFilter", 
		RequestNamespace="urn:iControl:Networking/PacketFilter", ResponseNamespace="urn:iControl:Networking/PacketFilter")]
	public void set_expression(
		string [] filters,
		string [] expressions
	) {
		this.Invoke("set_expression", new object [] {
				filters,
				expressions});

	}
	public System.IAsyncResult Beginset_expression(string [] filters,string [] expressions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_expression", new object[] {
			filters,
			expressions}, callback, asyncState);
	}
	public void Endset_expression(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_log_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PacketFilter", 
		RequestNamespace="urn:iControl:Networking/PacketFilter", ResponseNamespace="urn:iControl:Networking/PacketFilter")]
	public void set_log_state(
		string [] filters,
		CommonEnabledState [] states
	) {
		this.Invoke("set_log_state", new object [] {
				filters,
				states});

	}
	public System.IAsyncResult Beginset_log_state(string [] filters,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_log_state", new object[] {
			filters,
			states}, callback, asyncState);
	}
	public void Endset_log_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rate_class
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PacketFilter", 
		RequestNamespace="urn:iControl:Networking/PacketFilter", ResponseNamespace="urn:iControl:Networking/PacketFilter")]
	public void set_rate_class(
		string [] filters,
		string [] rate_classes
	) {
		this.Invoke("set_rate_class", new object [] {
				filters,
				rate_classes});

	}
	public System.IAsyncResult Beginset_rate_class(string [] filters,string [] rate_classes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rate_class", new object[] {
			filters,
			rate_classes}, callback, asyncState);
	}
	public void Endset_rate_class(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_sort_order
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PacketFilter", 
		RequestNamespace="urn:iControl:Networking/PacketFilter", ResponseNamespace="urn:iControl:Networking/PacketFilter")]
	public void set_sort_order(
		string [] filters,
		long [] orders
	) {
		this.Invoke("set_sort_order", new object [] {
				filters,
				orders});

	}
	public System.IAsyncResult Beginset_sort_order(string [] filters,long [] orders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_sort_order", new object[] {
			filters,
			orders}, callback, asyncState);
	}
	public void Endset_sort_order(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PacketFilter", 
		RequestNamespace="urn:iControl:Networking/PacketFilter", ResponseNamespace="urn:iControl:Networking/PacketFilter")]
	public void set_vlan(
		string [] filters,
		string [] vlan_names
	) {
		this.Invoke("set_vlan", new object [] {
				filters,
				vlan_names});

	}
	public System.IAsyncResult Beginset_vlan(string [] filters,string [] vlan_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_vlan", new object[] {
			filters,
			vlan_names}, callback, asyncState);
	}
	public void Endset_vlan(System.IAsyncResult asyncResult) {
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.PacketFilter.PacketFilterStatisticEntry", Namespace = "urn:iControl")]
	public partial class NetworkingPacketFilterPacketFilterStatisticEntry
	{
		private string filterField;
		public string filter
		{
			get { return this.filterField; }
			set { this.filterField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.PacketFilter.PacketFilterStatistics", Namespace = "urn:iControl")]
	public partial class NetworkingPacketFilterPacketFilterStatistics
	{
		private NetworkingPacketFilterPacketFilterStatisticEntry [] statisticsField;
		public NetworkingPacketFilterPacketFilterStatisticEntry [] statistics
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
