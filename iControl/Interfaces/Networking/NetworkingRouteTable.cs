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
	[System.Web.Services.WebServiceBindingAttribute(Name="Networking.RouteTableBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(NetworkingRouteTableRouteDefinition))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(NetworkingRouteTableRouteAttribute))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(NetworkingRouteTableDynamicRouteStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(NetworkingRouteTableRouteTableMetricStatistics))]
	public partial class NetworkingRouteTable : iControlInterface {
		public NetworkingRouteTable() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_management_route
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTable", 
		RequestNamespace="urn:iControl:Networking/RouteTable", ResponseNamespace="urn:iControl:Networking/RouteTable")]
	public void add_management_route(
		NetworkingRouteTableRouteDefinition [] routes,
		NetworkingRouteTableRouteAttribute [] attributes
	) {
		this.Invoke("add_management_route", new object [] {
				routes,
				attributes});

	}
	public System.IAsyncResult Beginadd_management_route(NetworkingRouteTableRouteDefinition [] routes,NetworkingRouteTableRouteAttribute [] attributes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_management_route", new object[] {
			routes,
			attributes}, callback, asyncState);
	}
	public void Endadd_management_route(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_static_route
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTable", 
		RequestNamespace="urn:iControl:Networking/RouteTable", ResponseNamespace="urn:iControl:Networking/RouteTable")]
	public void add_static_route(
		NetworkingRouteTableRouteDefinition [] routes,
		NetworkingRouteTableRouteAttribute [] attributes
	) {
		this.Invoke("add_static_route", new object [] {
				routes,
				attributes});

	}
	public System.IAsyncResult Beginadd_static_route(NetworkingRouteTableRouteDefinition [] routes,NetworkingRouteTableRouteAttribute [] attributes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_static_route", new object[] {
			routes,
			attributes}, callback, asyncState);
	}
	public void Endadd_static_route(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_management_routes
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTable", 
		RequestNamespace="urn:iControl:Networking/RouteTable", ResponseNamespace="urn:iControl:Networking/RouteTable")]
	public void delete_all_management_routes(

	) {
		this.Invoke("delete_all_management_routes", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_management_routes(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_management_routes", new object[0], callback, asyncState);
	}
	public void Enddelete_all_management_routes(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_static_routes
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTable", 
		RequestNamespace="urn:iControl:Networking/RouteTable", ResponseNamespace="urn:iControl:Networking/RouteTable")]
	public void delete_all_static_routes(

	) {
		this.Invoke("delete_all_static_routes", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_static_routes(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_static_routes", new object[0], callback, asyncState);
	}
	public void Enddelete_all_static_routes(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_management_route
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTable", 
		RequestNamespace="urn:iControl:Networking/RouteTable", ResponseNamespace="urn:iControl:Networking/RouteTable")]
	public void delete_management_route(
		NetworkingRouteTableRouteDefinition [] routes
	) {
		this.Invoke("delete_management_route", new object [] {
				routes});

	}
	public System.IAsyncResult Begindelete_management_route(NetworkingRouteTableRouteDefinition [] routes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_management_route", new object[] {
			routes}, callback, asyncState);
	}
	public void Enddelete_management_route(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_static_route
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTable", 
		RequestNamespace="urn:iControl:Networking/RouteTable", ResponseNamespace="urn:iControl:Networking/RouteTable")]
	public void delete_static_route(
		NetworkingRouteTableRouteDefinition [] routes
	) {
		this.Invoke("delete_static_route", new object [] {
				routes});

	}
	public System.IAsyncResult Begindelete_static_route(NetworkingRouteTableRouteDefinition [] routes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_static_route", new object[] {
			routes}, callback, asyncState);
	}
	public void Enddelete_static_route(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_dynamic_route
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTable", 
		RequestNamespace="urn:iControl:Networking/RouteTable", ResponseNamespace="urn:iControl:Networking/RouteTable")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingRouteTableDynamicRouteStatistics [] get_dynamic_route(
		string [] destinations
	) {
		object [] results = this.Invoke("get_dynamic_route", new object [] {
				destinations});
		return ((NetworkingRouteTableDynamicRouteStatistics [])(results[0]));
	}
	public System.IAsyncResult Beginget_dynamic_route(string [] destinations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dynamic_route", new object[] {
			destinations}, callback, asyncState);
	}
	public NetworkingRouteTableDynamicRouteStatistics [] Endget_dynamic_route(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingRouteTableDynamicRouteStatistics [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_management_route
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTable", 
		RequestNamespace="urn:iControl:Networking/RouteTable", ResponseNamespace="urn:iControl:Networking/RouteTable")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingRouteTableRouteDefinition [] get_management_route(

	) {
		object [] results = this.Invoke("get_management_route", new object [0]);
		return ((NetworkingRouteTableRouteDefinition [])(results[0]));
	}
	public System.IAsyncResult Beginget_management_route(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_management_route", new object[0], callback, asyncState);
	}
	public NetworkingRouteTableRouteDefinition [] Endget_management_route(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingRouteTableRouteDefinition [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_management_route_gateway
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTable", 
		RequestNamespace="urn:iControl:Networking/RouteTable", ResponseNamespace="urn:iControl:Networking/RouteTable")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_management_route_gateway(
		NetworkingRouteTableRouteDefinition [] routes
	) {
		object [] results = this.Invoke("get_management_route_gateway", new object [] {
				routes});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_management_route_gateway(NetworkingRouteTableRouteDefinition [] routes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_management_route_gateway", new object[] {
			routes}, callback, asyncState);
	}
	public string [] Endget_management_route_gateway(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_management_route_mtu
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTable", 
		RequestNamespace="urn:iControl:Networking/RouteTable", ResponseNamespace="urn:iControl:Networking/RouteTable")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_management_route_mtu(
		NetworkingRouteTableRouteDefinition [] routes
	) {
		object [] results = this.Invoke("get_management_route_mtu", new object [] {
				routes});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_management_route_mtu(NetworkingRouteTableRouteDefinition [] routes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_management_route_mtu", new object[] {
			routes}, callback, asyncState);
	}
	public long [] Endget_management_route_mtu(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_management_route_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTable", 
		RequestNamespace="urn:iControl:Networking/RouteTable", ResponseNamespace="urn:iControl:Networking/RouteTable")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingRouteEntryType [] get_management_route_type(
		NetworkingRouteTableRouteDefinition [] routes
	) {
		object [] results = this.Invoke("get_management_route_type", new object [] {
				routes});
		return ((NetworkingRouteEntryType [])(results[0]));
	}
	public System.IAsyncResult Beginget_management_route_type(NetworkingRouteTableRouteDefinition [] routes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_management_route_type", new object[] {
			routes}, callback, asyncState);
	}
	public NetworkingRouteEntryType [] Endget_management_route_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingRouteEntryType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_route_table_metric_statistics_for_destination
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTable", 
		RequestNamespace="urn:iControl:Networking/RouteTable", ResponseNamespace="urn:iControl:Networking/RouteTable")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingRouteTableRouteTableMetricStatistics [] get_route_table_metric_statistics_for_destination(
		string [] destinations
	) {
		object [] results = this.Invoke("get_route_table_metric_statistics_for_destination", new object [] {
				destinations});
		return ((NetworkingRouteTableRouteTableMetricStatistics [])(results[0]));
	}
	public System.IAsyncResult Beginget_route_table_metric_statistics_for_destination(string [] destinations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_route_table_metric_statistics_for_destination", new object[] {
			destinations}, callback, asyncState);
	}
	public NetworkingRouteTableRouteTableMetricStatistics [] Endget_route_table_metric_statistics_for_destination(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingRouteTableRouteTableMetricStatistics [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_route_table_metric_statistics_for_mac
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTable", 
		RequestNamespace="urn:iControl:Networking/RouteTable", ResponseNamespace="urn:iControl:Networking/RouteTable")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingRouteTableRouteTableMetricStatistics [] get_route_table_metric_statistics_for_mac(
		string [] mac_addresses
	) {
		object [] results = this.Invoke("get_route_table_metric_statistics_for_mac", new object [] {
				mac_addresses});
		return ((NetworkingRouteTableRouteTableMetricStatistics [])(results[0]));
	}
	public System.IAsyncResult Beginget_route_table_metric_statistics_for_mac(string [] mac_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_route_table_metric_statistics_for_mac", new object[] {
			mac_addresses}, callback, asyncState);
	}
	public NetworkingRouteTableRouteTableMetricStatistics [] Endget_route_table_metric_statistics_for_mac(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingRouteTableRouteTableMetricStatistics [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_static_route
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTable", 
		RequestNamespace="urn:iControl:Networking/RouteTable", ResponseNamespace="urn:iControl:Networking/RouteTable")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingRouteTableRouteDefinition [] get_static_route(

	) {
		object [] results = this.Invoke("get_static_route", new object [0]);
		return ((NetworkingRouteTableRouteDefinition [])(results[0]));
	}
	public System.IAsyncResult Beginget_static_route(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_static_route", new object[0], callback, asyncState);
	}
	public NetworkingRouteTableRouteDefinition [] Endget_static_route(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingRouteTableRouteDefinition [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_static_route_gateway
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTable", 
		RequestNamespace="urn:iControl:Networking/RouteTable", ResponseNamespace="urn:iControl:Networking/RouteTable")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_static_route_gateway(
		NetworkingRouteTableRouteDefinition [] routes
	) {
		object [] results = this.Invoke("get_static_route_gateway", new object [] {
				routes});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_static_route_gateway(NetworkingRouteTableRouteDefinition [] routes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_static_route_gateway", new object[] {
			routes}, callback, asyncState);
	}
	public string [] Endget_static_route_gateway(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_static_route_mtu
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTable", 
		RequestNamespace="urn:iControl:Networking/RouteTable", ResponseNamespace="urn:iControl:Networking/RouteTable")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_static_route_mtu(
		NetworkingRouteTableRouteDefinition [] routes
	) {
		object [] results = this.Invoke("get_static_route_mtu", new object [] {
				routes});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_static_route_mtu(NetworkingRouteTableRouteDefinition [] routes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_static_route_mtu", new object[] {
			routes}, callback, asyncState);
	}
	public long [] Endget_static_route_mtu(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_static_route_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTable", 
		RequestNamespace="urn:iControl:Networking/RouteTable", ResponseNamespace="urn:iControl:Networking/RouteTable")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_static_route_pool(
		NetworkingRouteTableRouteDefinition [] routes
	) {
		object [] results = this.Invoke("get_static_route_pool", new object [] {
				routes});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_static_route_pool(NetworkingRouteTableRouteDefinition [] routes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_static_route_pool", new object[] {
			routes}, callback, asyncState);
	}
	public string [] Endget_static_route_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_static_route_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTable", 
		RequestNamespace="urn:iControl:Networking/RouteTable", ResponseNamespace="urn:iControl:Networking/RouteTable")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingRouteEntryType [] get_static_route_type(
		NetworkingRouteTableRouteDefinition [] routes
	) {
		object [] results = this.Invoke("get_static_route_type", new object [] {
				routes});
		return ((NetworkingRouteEntryType [])(results[0]));
	}
	public System.IAsyncResult Beginget_static_route_type(NetworkingRouteTableRouteDefinition [] routes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_static_route_type", new object[] {
			routes}, callback, asyncState);
	}
	public NetworkingRouteEntryType [] Endget_static_route_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingRouteEntryType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_static_route_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTable", 
		RequestNamespace="urn:iControl:Networking/RouteTable", ResponseNamespace="urn:iControl:Networking/RouteTable")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_static_route_vlan(
		NetworkingRouteTableRouteDefinition [] routes
	) {
		object [] results = this.Invoke("get_static_route_vlan", new object [] {
				routes});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_static_route_vlan(NetworkingRouteTableRouteDefinition [] routes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_static_route_vlan", new object[] {
			routes}, callback, asyncState);
	}
	public string [] Endget_static_route_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTable", 
		RequestNamespace="urn:iControl:Networking/RouteTable", ResponseNamespace="urn:iControl:Networking/RouteTable")]
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
	// reset_all_route_table_metric_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTable", 
		RequestNamespace="urn:iControl:Networking/RouteTable", ResponseNamespace="urn:iControl:Networking/RouteTable")]
	public void reset_all_route_table_metric_statistics(

	) {
		this.Invoke("reset_all_route_table_metric_statistics", new object [0]);

	}
	public System.IAsyncResult Beginreset_all_route_table_metric_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_all_route_table_metric_statistics", new object[0], callback, asyncState);
	}
	public void Endreset_all_route_table_metric_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_management_route_gateway
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTable", 
		RequestNamespace="urn:iControl:Networking/RouteTable", ResponseNamespace="urn:iControl:Networking/RouteTable")]
	public void set_management_route_gateway(
		NetworkingRouteTableRouteDefinition [] routes,
		string [] gateways
	) {
		this.Invoke("set_management_route_gateway", new object [] {
				routes,
				gateways});

	}
	public System.IAsyncResult Beginset_management_route_gateway(NetworkingRouteTableRouteDefinition [] routes,string [] gateways, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_management_route_gateway", new object[] {
			routes,
			gateways}, callback, asyncState);
	}
	public void Endset_management_route_gateway(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_management_route_mtu
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTable", 
		RequestNamespace="urn:iControl:Networking/RouteTable", ResponseNamespace="urn:iControl:Networking/RouteTable")]
	public void set_management_route_mtu(
		NetworkingRouteTableRouteDefinition [] routes,
		long [] mtus
	) {
		this.Invoke("set_management_route_mtu", new object [] {
				routes,
				mtus});

	}
	public System.IAsyncResult Beginset_management_route_mtu(NetworkingRouteTableRouteDefinition [] routes,long [] mtus, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_management_route_mtu", new object[] {
			routes,
			mtus}, callback, asyncState);
	}
	public void Endset_management_route_mtu(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_management_route_reject
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTable", 
		RequestNamespace="urn:iControl:Networking/RouteTable", ResponseNamespace="urn:iControl:Networking/RouteTable")]
	public void set_management_route_reject(
		NetworkingRouteTableRouteDefinition [] routes
	) {
		this.Invoke("set_management_route_reject", new object [] {
				routes});

	}
	public System.IAsyncResult Beginset_management_route_reject(NetworkingRouteTableRouteDefinition [] routes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_management_route_reject", new object[] {
			routes}, callback, asyncState);
	}
	public void Endset_management_route_reject(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_static_route_gateway
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTable", 
		RequestNamespace="urn:iControl:Networking/RouteTable", ResponseNamespace="urn:iControl:Networking/RouteTable")]
	public void set_static_route_gateway(
		NetworkingRouteTableRouteDefinition [] routes,
		string [] gateways
	) {
		this.Invoke("set_static_route_gateway", new object [] {
				routes,
				gateways});

	}
	public System.IAsyncResult Beginset_static_route_gateway(NetworkingRouteTableRouteDefinition [] routes,string [] gateways, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_static_route_gateway", new object[] {
			routes,
			gateways}, callback, asyncState);
	}
	public void Endset_static_route_gateway(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_static_route_mtu
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTable", 
		RequestNamespace="urn:iControl:Networking/RouteTable", ResponseNamespace="urn:iControl:Networking/RouteTable")]
	public void set_static_route_mtu(
		NetworkingRouteTableRouteDefinition [] routes,
		long [] mtus
	) {
		this.Invoke("set_static_route_mtu", new object [] {
				routes,
				mtus});

	}
	public System.IAsyncResult Beginset_static_route_mtu(NetworkingRouteTableRouteDefinition [] routes,long [] mtus, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_static_route_mtu", new object[] {
			routes,
			mtus}, callback, asyncState);
	}
	public void Endset_static_route_mtu(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_static_route_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTable", 
		RequestNamespace="urn:iControl:Networking/RouteTable", ResponseNamespace="urn:iControl:Networking/RouteTable")]
	public void set_static_route_pool(
		NetworkingRouteTableRouteDefinition [] routes,
		string [] pools
	) {
		this.Invoke("set_static_route_pool", new object [] {
				routes,
				pools});

	}
	public System.IAsyncResult Beginset_static_route_pool(NetworkingRouteTableRouteDefinition [] routes,string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_static_route_pool", new object[] {
			routes,
			pools}, callback, asyncState);
	}
	public void Endset_static_route_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_static_route_reject
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTable", 
		RequestNamespace="urn:iControl:Networking/RouteTable", ResponseNamespace="urn:iControl:Networking/RouteTable")]
	public void set_static_route_reject(
		NetworkingRouteTableRouteDefinition [] routes
	) {
		this.Invoke("set_static_route_reject", new object [] {
				routes});

	}
	public System.IAsyncResult Beginset_static_route_reject(NetworkingRouteTableRouteDefinition [] routes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_static_route_reject", new object[] {
			routes}, callback, asyncState);
	}
	public void Endset_static_route_reject(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_static_route_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTable", 
		RequestNamespace="urn:iControl:Networking/RouteTable", ResponseNamespace="urn:iControl:Networking/RouteTable")]
	public void set_static_route_vlan(
		NetworkingRouteTableRouteDefinition [] routes,
		string [] vlans
	) {
		this.Invoke("set_static_route_vlan", new object [] {
				routes,
				vlans});

	}
	public System.IAsyncResult Beginset_static_route_vlan(NetworkingRouteTableRouteDefinition [] routes,string [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_static_route_vlan", new object[] {
			routes,
			vlans}, callback, asyncState);
	}
	public void Endset_static_route_vlan(System.IAsyncResult asyncResult) {
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.RouteTable.DynamicRoute", Namespace = "urn:iControl")]
	public partial class NetworkingRouteTableDynamicRoute
	{
		private string destinationField;
		public string destination
		{
			get { return this.destinationField; }
			set { this.destinationField = value; }
		}
		private string netmaskField;
		public string netmask
		{
			get { return this.netmaskField; }
			set { this.netmaskField = value; }
		}
		private string gatewayField;
		public string gateway
		{
			get { return this.gatewayField; }
			set { this.gatewayField = value; }
		}
		private string vlan_nameField;
		public string vlan_name
		{
			get { return this.vlan_nameField; }
			set { this.vlan_nameField = value; }
		}
		private string pool_nameField;
		public string pool_name
		{
			get { return this.pool_nameField; }
			set { this.pool_nameField = value; }
		}
		private long mtuField;
		public long mtu
		{
			get { return this.mtuField; }
			set { this.mtuField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.RouteTable.DynamicRouteStatistics", Namespace = "urn:iControl")]
	public partial class NetworkingRouteTableDynamicRouteStatistics
	{
		private NetworkingRouteTableDynamicRoute [] statisticsField;
		public NetworkingRouteTableDynamicRoute [] statistics
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.RouteTable.RouteAttribute", Namespace = "urn:iControl")]
	public partial class NetworkingRouteTableRouteAttribute
	{
		private string gatewayField;
		public string gateway
		{
			get { return this.gatewayField; }
			set { this.gatewayField = value; }
		}
		private string vlan_nameField;
		public string vlan_name
		{
			get { return this.vlan_nameField; }
			set { this.vlan_nameField = value; }
		}
		private string pool_nameField;
		public string pool_name
		{
			get { return this.pool_nameField; }
			set { this.pool_nameField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.RouteTable.RouteDefinition", Namespace = "urn:iControl")]
	public partial class NetworkingRouteTableRouteDefinition
	{
		private string destinationField;
		public string destination
		{
			get { return this.destinationField; }
			set { this.destinationField = value; }
		}
		private string netmaskField;
		public string netmask
		{
			get { return this.netmaskField; }
			set { this.netmaskField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.RouteTable.RouteTableMetricEntry", Namespace = "urn:iControl")]
	public partial class NetworkingRouteTableRouteTableMetricEntry
	{
		private string destinationField;
		public string destination
		{
			get { return this.destinationField; }
			set { this.destinationField = value; }
		}
		private string mac_addressField;
		public string mac_address
		{
			get { return this.mac_addressField; }
			set { this.mac_addressField = value; }
		}
		private long rttField;
		public long rtt
		{
			get { return this.rttField; }
			set { this.rttField = value; }
		}
		private long rtt_varianceField;
		public long rtt_variance
		{
			get { return this.rtt_varianceField; }
			set { this.rtt_varianceField = value; }
		}
		private long mtuField;
		public long mtu
		{
			get { return this.mtuField; }
			set { this.mtuField = value; }
		}
		private long expirationField;
		public long expiration
		{
			get { return this.expirationField; }
			set { this.expirationField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.RouteTable.RouteTableMetricStatistics", Namespace = "urn:iControl")]
	public partial class NetworkingRouteTableRouteTableMetricStatistics
	{
		private NetworkingRouteTableRouteTableMetricEntry [] statisticsField;
		public NetworkingRouteTableRouteTableMetricEntry [] statistics
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
