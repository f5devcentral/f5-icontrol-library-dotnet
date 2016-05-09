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
	[System.Web.Services.WebServiceBindingAttribute(Name="Networking.MulticastRouteBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(NetworkingMulticastRouteMulticastRouteInfo))]
	public partial class NetworkingMulticastRoute : iControlInterface {
		public NetworkingMulticastRoute() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// get_multicast_route
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/MulticastRoute", 
		RequestNamespace="urn:iControl:Networking/MulticastRoute", ResponseNamespace="urn:iControl:Networking/MulticastRoute")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingMulticastRouteMulticastRouteInfo [] get_multicast_route(

	) {
		object [] results = this.Invoke("get_multicast_route", new object [0]);
		return ((NetworkingMulticastRouteMulticastRouteInfo [])(results[0]));
	}
	public System.IAsyncResult Beginget_multicast_route(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_multicast_route", new object[0], callback, asyncState);
	}
	public NetworkingMulticastRouteMulticastRouteInfo [] Endget_multicast_route(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingMulticastRouteMulticastRouteInfo [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_multicast_route_for_group
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/MulticastRoute", 
		RequestNamespace="urn:iControl:Networking/MulticastRoute", ResponseNamespace="urn:iControl:Networking/MulticastRoute")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingMulticastRouteMulticastRouteInfo [] get_multicast_route_for_group(
		string [] group_addresses
	) {
		object [] results = this.Invoke("get_multicast_route_for_group", new object [] {
				group_addresses});
		return ((NetworkingMulticastRouteMulticastRouteInfo [])(results[0]));
	}
	public System.IAsyncResult Beginget_multicast_route_for_group(string [] group_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_multicast_route_for_group", new object[] {
			group_addresses}, callback, asyncState);
	}
	public NetworkingMulticastRouteMulticastRouteInfo [] Endget_multicast_route_for_group(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingMulticastRouteMulticastRouteInfo [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_multicast_route_for_source
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/MulticastRoute", 
		RequestNamespace="urn:iControl:Networking/MulticastRoute", ResponseNamespace="urn:iControl:Networking/MulticastRoute")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingMulticastRouteMulticastRouteInfo [] get_multicast_route_for_source(
		string [] source_addresses
	) {
		object [] results = this.Invoke("get_multicast_route_for_source", new object [] {
				source_addresses});
		return ((NetworkingMulticastRouteMulticastRouteInfo [])(results[0]));
	}
	public System.IAsyncResult Beginget_multicast_route_for_source(string [] source_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_multicast_route_for_source", new object[] {
			source_addresses}, callback, asyncState);
	}
	public NetworkingMulticastRouteMulticastRouteInfo [] Endget_multicast_route_for_source(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingMulticastRouteMulticastRouteInfo [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_multicast_route_for_source_group_pair
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/MulticastRoute", 
		RequestNamespace="urn:iControl:Networking/MulticastRoute", ResponseNamespace="urn:iControl:Networking/MulticastRoute")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingMulticastRouteMulticastRouteInfo [] get_multicast_route_for_source_group_pair(
		string [] source_addresses,
		string [] group_addresses
	) {
		object [] results = this.Invoke("get_multicast_route_for_source_group_pair", new object [] {
				source_addresses,
				group_addresses});
		return ((NetworkingMulticastRouteMulticastRouteInfo [])(results[0]));
	}
	public System.IAsyncResult Beginget_multicast_route_for_source_group_pair(string [] source_addresses,string [] group_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_multicast_route_for_source_group_pair", new object[] {
			source_addresses,
			group_addresses}, callback, asyncState);
	}
	public NetworkingMulticastRouteMulticastRouteInfo [] Endget_multicast_route_for_source_group_pair(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingMulticastRouteMulticastRouteInfo [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/MulticastRoute", 
		RequestNamespace="urn:iControl:Networking/MulticastRoute", ResponseNamespace="urn:iControl:Networking/MulticastRoute")]
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.MulticastRoute.MulticastRouteInfo", Namespace = "urn:iControl")]
	public partial class NetworkingMulticastRouteMulticastRouteInfo
	{
		private string source_addressField;
		public string source_address
		{
			get { return this.source_addressField; }
			set { this.source_addressField = value; }
		}
		private string group_addressField;
		public string group_address
		{
			get { return this.group_addressField; }
			set { this.group_addressField = value; }
		}
		private string ingress_interfaceField;
		public string ingress_interface
		{
			get { return this.ingress_interfaceField; }
			set { this.ingress_interfaceField = value; }
		}
		private string [] outgoing_interfacesField;
		public string [] outgoing_interfaces
		{
			get { return this.outgoing_interfacesField; }
			set { this.outgoing_interfacesField = value; }
		}
		private string rp_addressField;
		public string rp_address
		{
			get { return this.rp_addressField; }
			set { this.rp_addressField = value; }
		}
	};

}
