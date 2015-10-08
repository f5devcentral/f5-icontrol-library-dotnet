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
	[System.Web.Services.WebServiceBindingAttribute(Name="Networking.RouteTableV2Binding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(NetworkingRouteTableV2RouteDestination))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(NetworkingRouteTableV2RouteAttribute))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(NetworkingRouteTableV2DynamicRouteStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(NetworkingRouteTableV2DynamicRouteECMPStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(NetworkingRouteTableV2RouteTableMetricStatistics))]
	public partial class NetworkingRouteTableV2 : iControlInterface {
		public NetworkingRouteTableV2() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create_management_route
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTableV2", 
		RequestNamespace="urn:iControl:Networking/RouteTableV2", ResponseNamespace="urn:iControl:Networking/RouteTableV2")]
	public void create_management_route(
		string [] routes,
		NetworkingRouteTableV2RouteDestination [] destinations,
		NetworkingRouteTableV2RouteAttribute [] attributes
	) {
		this.Invoke("create_management_route", new object [] {
				routes,
				destinations,
				attributes});

	}
	public System.IAsyncResult Begincreate_management_route(string [] routes,NetworkingRouteTableV2RouteDestination [] destinations,NetworkingRouteTableV2RouteAttribute [] attributes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_management_route", new object[] {
			routes,
			destinations,
			attributes}, callback, asyncState);
	}
	public void Endcreate_management_route(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create_static_route
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTableV2", 
		RequestNamespace="urn:iControl:Networking/RouteTableV2", ResponseNamespace="urn:iControl:Networking/RouteTableV2")]
	public void create_static_route(
		string [] routes,
		NetworkingRouteTableV2RouteDestination [] destinations,
		NetworkingRouteTableV2RouteAttribute [] attributes
	) {
		this.Invoke("create_static_route", new object [] {
				routes,
				destinations,
				attributes});

	}
	public System.IAsyncResult Begincreate_static_route(string [] routes,NetworkingRouteTableV2RouteDestination [] destinations,NetworkingRouteTableV2RouteAttribute [] attributes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_static_route", new object[] {
			routes,
			destinations,
			attributes}, callback, asyncState);
	}
	public void Endcreate_static_route(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_management_routes
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTableV2", 
		RequestNamespace="urn:iControl:Networking/RouteTableV2", ResponseNamespace="urn:iControl:Networking/RouteTableV2")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTableV2", 
		RequestNamespace="urn:iControl:Networking/RouteTableV2", ResponseNamespace="urn:iControl:Networking/RouteTableV2")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTableV2", 
		RequestNamespace="urn:iControl:Networking/RouteTableV2", ResponseNamespace="urn:iControl:Networking/RouteTableV2")]
	public void delete_management_route(
		string [] routes
	) {
		this.Invoke("delete_management_route", new object [] {
				routes});

	}
	public System.IAsyncResult Begindelete_management_route(string [] routes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_management_route", new object[] {
			routes}, callback, asyncState);
	}
	public void Enddelete_management_route(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_static_route
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTableV2", 
		RequestNamespace="urn:iControl:Networking/RouteTableV2", ResponseNamespace="urn:iControl:Networking/RouteTableV2")]
	public void delete_static_route(
		string [] routes
	) {
		this.Invoke("delete_static_route", new object [] {
				routes});

	}
	public System.IAsyncResult Begindelete_static_route(string [] routes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_static_route", new object[] {
			routes}, callback, asyncState);
	}
	public void Enddelete_static_route(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_dynamic_route
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTableV2", 
		RequestNamespace="urn:iControl:Networking/RouteTableV2", ResponseNamespace="urn:iControl:Networking/RouteTableV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingRouteTableV2DynamicRouteStatistics get_dynamic_route(
		string [] routes
	) {
		object [] results = this.Invoke("get_dynamic_route", new object [] {
				routes});
		return ((NetworkingRouteTableV2DynamicRouteStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_dynamic_route(string [] routes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dynamic_route", new object[] {
			routes}, callback, asyncState);
	}
	public NetworkingRouteTableV2DynamicRouteStatistics Endget_dynamic_route(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingRouteTableV2DynamicRouteStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dynamic_route_ecmp
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTableV2", 
		RequestNamespace="urn:iControl:Networking/RouteTableV2", ResponseNamespace="urn:iControl:Networking/RouteTableV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingRouteTableV2DynamicRouteECMPStatistics get_dynamic_route_ecmp(
		string [] routes
	) {
		object [] results = this.Invoke("get_dynamic_route_ecmp", new object [] {
				routes});
		return ((NetworkingRouteTableV2DynamicRouteECMPStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_dynamic_route_ecmp(string [] routes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dynamic_route_ecmp", new object[] {
			routes}, callback, asyncState);
	}
	public NetworkingRouteTableV2DynamicRouteECMPStatistics Endget_dynamic_route_ecmp(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingRouteTableV2DynamicRouteECMPStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dynamic_route_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTableV2", 
		RequestNamespace="urn:iControl:Networking/RouteTableV2", ResponseNamespace="urn:iControl:Networking/RouteTableV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_dynamic_route_list(

	) {
		object [] results = this.Invoke("get_dynamic_route_list", new object [0]);
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_dynamic_route_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dynamic_route_list", new object[0], callback, asyncState);
	}
	public string [] Endget_dynamic_route_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_management_route_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTableV2", 
		RequestNamespace="urn:iControl:Networking/RouteTableV2", ResponseNamespace="urn:iControl:Networking/RouteTableV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_management_route_description(
		string [] routes
	) {
		object [] results = this.Invoke("get_management_route_description", new object [] {
				routes});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_management_route_description(string [] routes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_management_route_description", new object[] {
			routes}, callback, asyncState);
	}
	public string [] Endget_management_route_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_management_route_destination
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTableV2", 
		RequestNamespace="urn:iControl:Networking/RouteTableV2", ResponseNamespace="urn:iControl:Networking/RouteTableV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingRouteTableV2RouteDestination [] get_management_route_destination(
		string [] routes
	) {
		object [] results = this.Invoke("get_management_route_destination", new object [] {
				routes});
		return ((NetworkingRouteTableV2RouteDestination [])(results[0]));
	}
	public System.IAsyncResult Beginget_management_route_destination(string [] routes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_management_route_destination", new object[] {
			routes}, callback, asyncState);
	}
	public NetworkingRouteTableV2RouteDestination [] Endget_management_route_destination(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingRouteTableV2RouteDestination [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_management_route_gateway
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTableV2", 
		RequestNamespace="urn:iControl:Networking/RouteTableV2", ResponseNamespace="urn:iControl:Networking/RouteTableV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_management_route_gateway(
		string [] routes
	) {
		object [] results = this.Invoke("get_management_route_gateway", new object [] {
				routes});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_management_route_gateway(string [] routes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_management_route_gateway", new object[] {
			routes}, callback, asyncState);
	}
	public string [] Endget_management_route_gateway(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_management_route_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTableV2", 
		RequestNamespace="urn:iControl:Networking/RouteTableV2", ResponseNamespace="urn:iControl:Networking/RouteTableV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_management_route_list(

	) {
		object [] results = this.Invoke("get_management_route_list", new object [0]);
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_management_route_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_management_route_list", new object[0], callback, asyncState);
	}
	public string [] Endget_management_route_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_management_route_mtu
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTableV2", 
		RequestNamespace="urn:iControl:Networking/RouteTableV2", ResponseNamespace="urn:iControl:Networking/RouteTableV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_management_route_mtu(
		string [] routes
	) {
		object [] results = this.Invoke("get_management_route_mtu", new object [] {
				routes});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_management_route_mtu(string [] routes, System.AsyncCallback callback, object asyncState) {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTableV2", 
		RequestNamespace="urn:iControl:Networking/RouteTableV2", ResponseNamespace="urn:iControl:Networking/RouteTableV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingRouteEntryType [] get_management_route_type(
		string [] routes
	) {
		object [] results = this.Invoke("get_management_route_type", new object [] {
				routes});
		return ((NetworkingRouteEntryType [])(results[0]));
	}
	public System.IAsyncResult Beginget_management_route_type(string [] routes, System.AsyncCallback callback, object asyncState) {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTableV2", 
		RequestNamespace="urn:iControl:Networking/RouteTableV2", ResponseNamespace="urn:iControl:Networking/RouteTableV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingRouteTableV2RouteTableMetricStatistics [] get_route_table_metric_statistics_for_destination(
		string [] destinations
	) {
		object [] results = this.Invoke("get_route_table_metric_statistics_for_destination", new object [] {
				destinations});
		return ((NetworkingRouteTableV2RouteTableMetricStatistics [])(results[0]));
	}
	public System.IAsyncResult Beginget_route_table_metric_statistics_for_destination(string [] destinations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_route_table_metric_statistics_for_destination", new object[] {
			destinations}, callback, asyncState);
	}
	public NetworkingRouteTableV2RouteTableMetricStatistics [] Endget_route_table_metric_statistics_for_destination(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingRouteTableV2RouteTableMetricStatistics [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_route_table_metric_statistics_for_mac
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTableV2", 
		RequestNamespace="urn:iControl:Networking/RouteTableV2", ResponseNamespace="urn:iControl:Networking/RouteTableV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingRouteTableV2RouteTableMetricStatistics [] get_route_table_metric_statistics_for_mac(
		string [] mac_addresses
	) {
		object [] results = this.Invoke("get_route_table_metric_statistics_for_mac", new object [] {
				mac_addresses});
		return ((NetworkingRouteTableV2RouteTableMetricStatistics [])(results[0]));
	}
	public System.IAsyncResult Beginget_route_table_metric_statistics_for_mac(string [] mac_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_route_table_metric_statistics_for_mac", new object[] {
			mac_addresses}, callback, asyncState);
	}
	public NetworkingRouteTableV2RouteTableMetricStatistics [] Endget_route_table_metric_statistics_for_mac(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingRouteTableV2RouteTableMetricStatistics [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_static_route_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTableV2", 
		RequestNamespace="urn:iControl:Networking/RouteTableV2", ResponseNamespace="urn:iControl:Networking/RouteTableV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_static_route_description(
		string [] routes
	) {
		object [] results = this.Invoke("get_static_route_description", new object [] {
				routes});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_static_route_description(string [] routes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_static_route_description", new object[] {
			routes}, callback, asyncState);
	}
	public string [] Endget_static_route_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_static_route_destination
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTableV2", 
		RequestNamespace="urn:iControl:Networking/RouteTableV2", ResponseNamespace="urn:iControl:Networking/RouteTableV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingRouteTableV2RouteDestination [] get_static_route_destination(
		string [] routes
	) {
		object [] results = this.Invoke("get_static_route_destination", new object [] {
				routes});
		return ((NetworkingRouteTableV2RouteDestination [])(results[0]));
	}
	public System.IAsyncResult Beginget_static_route_destination(string [] routes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_static_route_destination", new object[] {
			routes}, callback, asyncState);
	}
	public NetworkingRouteTableV2RouteDestination [] Endget_static_route_destination(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingRouteTableV2RouteDestination [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_static_route_gateway
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTableV2", 
		RequestNamespace="urn:iControl:Networking/RouteTableV2", ResponseNamespace="urn:iControl:Networking/RouteTableV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_static_route_gateway(
		string [] routes
	) {
		object [] results = this.Invoke("get_static_route_gateway", new object [] {
				routes});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_static_route_gateway(string [] routes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_static_route_gateway", new object[] {
			routes}, callback, asyncState);
	}
	public string [] Endget_static_route_gateway(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_static_route_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTableV2", 
		RequestNamespace="urn:iControl:Networking/RouteTableV2", ResponseNamespace="urn:iControl:Networking/RouteTableV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_static_route_list(

	) {
		object [] results = this.Invoke("get_static_route_list", new object [0]);
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_static_route_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_static_route_list", new object[0], callback, asyncState);
	}
	public string [] Endget_static_route_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_static_route_mtu
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTableV2", 
		RequestNamespace="urn:iControl:Networking/RouteTableV2", ResponseNamespace="urn:iControl:Networking/RouteTableV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_static_route_mtu(
		string [] routes
	) {
		object [] results = this.Invoke("get_static_route_mtu", new object [] {
				routes});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_static_route_mtu(string [] routes, System.AsyncCallback callback, object asyncState) {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTableV2", 
		RequestNamespace="urn:iControl:Networking/RouteTableV2", ResponseNamespace="urn:iControl:Networking/RouteTableV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_static_route_pool(
		string [] routes
	) {
		object [] results = this.Invoke("get_static_route_pool", new object [] {
				routes});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_static_route_pool(string [] routes, System.AsyncCallback callback, object asyncState) {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTableV2", 
		RequestNamespace="urn:iControl:Networking/RouteTableV2", ResponseNamespace="urn:iControl:Networking/RouteTableV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingRouteEntryType [] get_static_route_type(
		string [] routes
	) {
		object [] results = this.Invoke("get_static_route_type", new object [] {
				routes});
		return ((NetworkingRouteEntryType [])(results[0]));
	}
	public System.IAsyncResult Beginget_static_route_type(string [] routes, System.AsyncCallback callback, object asyncState) {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTableV2", 
		RequestNamespace="urn:iControl:Networking/RouteTableV2", ResponseNamespace="urn:iControl:Networking/RouteTableV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_static_route_vlan(
		string [] routes
	) {
		object [] results = this.Invoke("get_static_route_vlan", new object [] {
				routes});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_static_route_vlan(string [] routes, System.AsyncCallback callback, object asyncState) {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTableV2", 
		RequestNamespace="urn:iControl:Networking/RouteTableV2", ResponseNamespace="urn:iControl:Networking/RouteTableV2")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTableV2", 
		RequestNamespace="urn:iControl:Networking/RouteTableV2", ResponseNamespace="urn:iControl:Networking/RouteTableV2")]
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
	// set_management_route_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTableV2", 
		RequestNamespace="urn:iControl:Networking/RouteTableV2", ResponseNamespace="urn:iControl:Networking/RouteTableV2")]
	public void set_management_route_description(
		string [] routes,
		string [] descriptions
	) {
		this.Invoke("set_management_route_description", new object [] {
				routes,
				descriptions});

	}
	public System.IAsyncResult Beginset_management_route_description(string [] routes,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_management_route_description", new object[] {
			routes,
			descriptions}, callback, asyncState);
	}
	public void Endset_management_route_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_management_route_gateway
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTableV2", 
		RequestNamespace="urn:iControl:Networking/RouteTableV2", ResponseNamespace="urn:iControl:Networking/RouteTableV2")]
	public void set_management_route_gateway(
		string [] routes,
		string [] gateways
	) {
		this.Invoke("set_management_route_gateway", new object [] {
				routes,
				gateways});

	}
	public System.IAsyncResult Beginset_management_route_gateway(string [] routes,string [] gateways, System.AsyncCallback callback, object asyncState) {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTableV2", 
		RequestNamespace="urn:iControl:Networking/RouteTableV2", ResponseNamespace="urn:iControl:Networking/RouteTableV2")]
	public void set_management_route_mtu(
		string [] routes,
		long [] mtus
	) {
		this.Invoke("set_management_route_mtu", new object [] {
				routes,
				mtus});

	}
	public System.IAsyncResult Beginset_management_route_mtu(string [] routes,long [] mtus, System.AsyncCallback callback, object asyncState) {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTableV2", 
		RequestNamespace="urn:iControl:Networking/RouteTableV2", ResponseNamespace="urn:iControl:Networking/RouteTableV2")]
	public void set_management_route_reject(
		string [] routes
	) {
		this.Invoke("set_management_route_reject", new object [] {
				routes});

	}
	public System.IAsyncResult Beginset_management_route_reject(string [] routes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_management_route_reject", new object[] {
			routes}, callback, asyncState);
	}
	public void Endset_management_route_reject(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_static_route_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTableV2", 
		RequestNamespace="urn:iControl:Networking/RouteTableV2", ResponseNamespace="urn:iControl:Networking/RouteTableV2")]
	public void set_static_route_description(
		string [] routes,
		string [] descriptions
	) {
		this.Invoke("set_static_route_description", new object [] {
				routes,
				descriptions});

	}
	public System.IAsyncResult Beginset_static_route_description(string [] routes,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_static_route_description", new object[] {
			routes,
			descriptions}, callback, asyncState);
	}
	public void Endset_static_route_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_static_route_gateway
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTableV2", 
		RequestNamespace="urn:iControl:Networking/RouteTableV2", ResponseNamespace="urn:iControl:Networking/RouteTableV2")]
	public void set_static_route_gateway(
		string [] routes,
		string [] gateways
	) {
		this.Invoke("set_static_route_gateway", new object [] {
				routes,
				gateways});

	}
	public System.IAsyncResult Beginset_static_route_gateway(string [] routes,string [] gateways, System.AsyncCallback callback, object asyncState) {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTableV2", 
		RequestNamespace="urn:iControl:Networking/RouteTableV2", ResponseNamespace="urn:iControl:Networking/RouteTableV2")]
	public void set_static_route_mtu(
		string [] routes,
		long [] mtus
	) {
		this.Invoke("set_static_route_mtu", new object [] {
				routes,
				mtus});

	}
	public System.IAsyncResult Beginset_static_route_mtu(string [] routes,long [] mtus, System.AsyncCallback callback, object asyncState) {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTableV2", 
		RequestNamespace="urn:iControl:Networking/RouteTableV2", ResponseNamespace="urn:iControl:Networking/RouteTableV2")]
	public void set_static_route_pool(
		string [] routes,
		string [] pools
	) {
		this.Invoke("set_static_route_pool", new object [] {
				routes,
				pools});

	}
	public System.IAsyncResult Beginset_static_route_pool(string [] routes,string [] pools, System.AsyncCallback callback, object asyncState) {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTableV2", 
		RequestNamespace="urn:iControl:Networking/RouteTableV2", ResponseNamespace="urn:iControl:Networking/RouteTableV2")]
	public void set_static_route_reject(
		string [] routes
	) {
		this.Invoke("set_static_route_reject", new object [] {
				routes});

	}
	public System.IAsyncResult Beginset_static_route_reject(string [] routes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_static_route_reject", new object[] {
			routes}, callback, asyncState);
	}
	public void Endset_static_route_reject(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_static_route_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteTableV2", 
		RequestNamespace="urn:iControl:Networking/RouteTableV2", ResponseNamespace="urn:iControl:Networking/RouteTableV2")]
	public void set_static_route_vlan(
		string [] routes,
		string [] vlans
	) {
		this.Invoke("set_static_route_vlan", new object [] {
				routes,
				vlans});

	}
	public System.IAsyncResult Beginset_static_route_vlan(string [] routes,string [] vlans, System.AsyncCallback callback, object asyncState) {
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.RouteTableV2.DynamicRoute", Namespace = "urn:iControl")]
	public partial class NetworkingRouteTableV2DynamicRoute
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.RouteTableV2.DynamicRouteECMP", Namespace = "urn:iControl")]
	public partial class NetworkingRouteTableV2DynamicRouteECMP
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
		private NetworkingRouteTableV2RouteNexthopEntry [] nexthopsField;
		public NetworkingRouteTableV2RouteNexthopEntry [] nexthops
		{
			get { return this.nexthopsField; }
			set { this.nexthopsField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.RouteTableV2.DynamicRouteECMPStatistics", Namespace = "urn:iControl")]
	public partial class NetworkingRouteTableV2DynamicRouteECMPStatistics
	{
		private NetworkingRouteTableV2DynamicRouteECMP [] statisticsField;
		public NetworkingRouteTableV2DynamicRouteECMP [] statistics
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.RouteTableV2.DynamicRouteStatistics", Namespace = "urn:iControl")]
	public partial class NetworkingRouteTableV2DynamicRouteStatistics
	{
		private NetworkingRouteTableV2DynamicRoute [] statisticsField;
		public NetworkingRouteTableV2DynamicRoute [] statistics
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.RouteTableV2.RouteAttribute", Namespace = "urn:iControl")]
	public partial class NetworkingRouteTableV2RouteAttribute
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.RouteTableV2.RouteDestination", Namespace = "urn:iControl")]
	public partial class NetworkingRouteTableV2RouteDestination
	{
		private string addressField;
		public string address
		{
			get { return this.addressField; }
			set { this.addressField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.RouteTableV2.RouteNexthopEntry", Namespace = "urn:iControl")]
	public partial class NetworkingRouteTableV2RouteNexthopEntry
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
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.RouteTableV2.RouteTableMetricEntry", Namespace = "urn:iControl")]
	public partial class NetworkingRouteTableV2RouteTableMetricEntry
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.RouteTableV2.RouteTableMetricStatistics", Namespace = "urn:iControl")]
	public partial class NetworkingRouteTableV2RouteTableMetricStatistics
	{
		private NetworkingRouteTableV2RouteTableMetricEntry [] statisticsField;
		public NetworkingRouteTableV2RouteTableMetricEntry [] statistics
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
