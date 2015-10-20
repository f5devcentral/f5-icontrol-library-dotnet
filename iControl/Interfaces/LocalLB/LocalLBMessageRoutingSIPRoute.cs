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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.MessageRoutingSIPRouteBinding", Namespace="urn:iControl")]
	public partial class LocalLBMessageRoutingSIPRoute : iControlInterface {
		public LocalLBMessageRoutingSIPRoute() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingSIPRoute", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingSIPRoute", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingSIPRoute")]
	public void create(
		string [] sip_routes
	) {
		this.Invoke("create", new object [] {
				sip_routes});

	}
	public System.IAsyncResult Begincreate(string [] sip_routes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			sip_routes}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_sip_routes
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingSIPRoute", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingSIPRoute", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingSIPRoute")]
	public void delete_all_sip_routes(

	) {
		this.Invoke("delete_all_sip_routes", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_sip_routes(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_sip_routes", new object[0], callback, asyncState);
	}
	public void Enddelete_all_sip_routes(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_sip_route
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingSIPRoute", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingSIPRoute", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingSIPRoute")]
	public void delete_sip_route(
		string [] sip_routes
	) {
		this.Invoke("delete_sip_route", new object [] {
				sip_routes});

	}
	public System.IAsyncResult Begindelete_sip_route(string [] sip_routes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_sip_route", new object[] {
			sip_routes}, callback, asyncState);
	}
	public void Enddelete_sip_route(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingSIPRoute", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingSIPRoute", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingSIPRoute")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] sip_routes
	) {
		object [] results = this.Invoke("get_description", new object [] {
				sip_routes});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] sip_routes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			sip_routes}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_from_uri
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingSIPRoute", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingSIPRoute", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingSIPRoute")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_from_uri(
		string [] sip_routes
	) {
		object [] results = this.Invoke("get_from_uri", new object [] {
				sip_routes});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_from_uri(string [] sip_routes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_from_uri", new object[] {
			sip_routes}, callback, asyncState);
	}
	public string [] Endget_from_uri(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingSIPRoute", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingSIPRoute", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingSIPRoute")]
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
	// get_peer
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingSIPRoute", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingSIPRoute", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingSIPRoute")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_peer(
		string [] sip_routes
	) {
		object [] results = this.Invoke("get_peer", new object [] {
				sip_routes});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_peer(string [] sip_routes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_peer", new object[] {
			sip_routes}, callback, asyncState);
	}
	public string [] [] Endget_peer(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_request_uri
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingSIPRoute", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingSIPRoute", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingSIPRoute")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_request_uri(
		string [] sip_routes
	) {
		object [] results = this.Invoke("get_request_uri", new object [] {
				sip_routes});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_request_uri(string [] sip_routes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_request_uri", new object[] {
			sip_routes}, callback, asyncState);
	}
	public string [] Endget_request_uri(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_selection_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingSIPRoute", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingSIPRoute", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingSIPRoute")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBMessageRoutingSIPRouteSelectionMode [] get_selection_mode(
		string [] sip_routes
	) {
		object [] results = this.Invoke("get_selection_mode", new object [] {
				sip_routes});
		return ((LocalLBMessageRoutingSIPRouteSelectionMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_selection_mode(string [] sip_routes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_selection_mode", new object[] {
			sip_routes}, callback, asyncState);
	}
	public LocalLBMessageRoutingSIPRouteSelectionMode [] Endget_selection_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBMessageRoutingSIPRouteSelectionMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_to_uri
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingSIPRoute", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingSIPRoute", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingSIPRoute")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_to_uri(
		string [] sip_routes
	) {
		object [] results = this.Invoke("get_to_uri", new object [] {
				sip_routes});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_to_uri(string [] sip_routes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_to_uri", new object[] {
			sip_routes}, callback, asyncState);
	}
	public string [] Endget_to_uri(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingSIPRoute", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingSIPRoute", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingSIPRoute")]
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
	// get_virtual_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingSIPRoute", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingSIPRoute", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingSIPRoute")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_virtual_server(
		string [] sip_routes
	) {
		object [] results = this.Invoke("get_virtual_server", new object [] {
				sip_routes});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_virtual_server(string [] sip_routes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_virtual_server", new object[] {
			sip_routes}, callback, asyncState);
	}
	public string [] Endget_virtual_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// replace_peer
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingSIPRoute", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingSIPRoute", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingSIPRoute")]
	public void replace_peer(
		string [] sip_routes,
		string [] [] peers,
		long [] [] priorities
	) {
		this.Invoke("replace_peer", new object [] {
				sip_routes,
				peers,
				priorities});

	}
	public System.IAsyncResult Beginreplace_peer(string [] sip_routes,string [] [] peers,long [] [] priorities, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("replace_peer", new object[] {
			sip_routes,
			peers,
			priorities}, callback, asyncState);
	}
	public void Endreplace_peer(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingSIPRoute", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingSIPRoute", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingSIPRoute")]
	public void set_description(
		string [] sip_routes,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				sip_routes,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] sip_routes,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			sip_routes,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_from_uri
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingSIPRoute", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingSIPRoute", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingSIPRoute")]
	public void set_from_uri(
		string [] sip_routes,
		string [] uris
	) {
		this.Invoke("set_from_uri", new object [] {
				sip_routes,
				uris});

	}
	public System.IAsyncResult Beginset_from_uri(string [] sip_routes,string [] uris, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_from_uri", new object[] {
			sip_routes,
			uris}, callback, asyncState);
	}
	public void Endset_from_uri(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_request_uri
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingSIPRoute", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingSIPRoute", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingSIPRoute")]
	public void set_request_uri(
		string [] sip_routes,
		string [] uris
	) {
		this.Invoke("set_request_uri", new object [] {
				sip_routes,
				uris});

	}
	public System.IAsyncResult Beginset_request_uri(string [] sip_routes,string [] uris, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_request_uri", new object[] {
			sip_routes,
			uris}, callback, asyncState);
	}
	public void Endset_request_uri(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_selection_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingSIPRoute", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingSIPRoute", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingSIPRoute")]
	public void set_selection_mode(
		string [] sip_routes,
		LocalLBMessageRoutingSIPRouteSelectionMode [] modes
	) {
		this.Invoke("set_selection_mode", new object [] {
				sip_routes,
				modes});

	}
	public System.IAsyncResult Beginset_selection_mode(string [] sip_routes,LocalLBMessageRoutingSIPRouteSelectionMode [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_selection_mode", new object[] {
			sip_routes,
			modes}, callback, asyncState);
	}
	public void Endset_selection_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_to_uri
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingSIPRoute", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingSIPRoute", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingSIPRoute")]
	public void set_to_uri(
		string [] sip_routes,
		string [] uris
	) {
		this.Invoke("set_to_uri", new object [] {
				sip_routes,
				uris});

	}
	public System.IAsyncResult Beginset_to_uri(string [] sip_routes,string [] uris, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_to_uri", new object[] {
			sip_routes,
			uris}, callback, asyncState);
	}
	public void Endset_to_uri(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_virtual_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingSIPRoute", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingSIPRoute", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingSIPRoute")]
	public void set_virtual_server(
		string [] sip_routes,
		string [] virtual_servers
	) {
		this.Invoke("set_virtual_server", new object [] {
				sip_routes,
				virtual_servers});

	}
	public System.IAsyncResult Beginset_virtual_server(string [] sip_routes,string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_virtual_server", new object[] {
			sip_routes,
			virtual_servers}, callback, asyncState);
	}
	public void Endset_virtual_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.MessageRoutingSIPRoute.SelectionMode", Namespace = "urn:iControl")]
	public enum LocalLBMessageRoutingSIPRouteSelectionMode
	{
		SELECTION_MODE_UNKNOWN,
		SELECTION_MODE_SEQUENTIAL,
		SELECTION_MODE_RATIO,
	}

	//=======================================================================
	// Structs
	//=======================================================================

}
