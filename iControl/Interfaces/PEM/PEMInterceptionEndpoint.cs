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
	[System.Web.Services.WebServiceBindingAttribute(Name="PEM.InterceptionEndpointBinding", Namespace="urn:iControl")]
	public partial class PEMInterceptionEndpoint : iControlInterface {
		public PEMInterceptionEndpoint() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/InterceptionEndpoint", 
		RequestNamespace="urn:iControl:PEM/InterceptionEndpoint", ResponseNamespace="urn:iControl:PEM/InterceptionEndpoint")]
	public void create(
		string [] endpoints,
		string [] pools
	) {
		this.Invoke("create", new object [] {
				endpoints,
				pools});

	}
	public System.IAsyncResult Begincreate(string [] endpoints,string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			endpoints,
			pools}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_interception_endpoints
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/InterceptionEndpoint", 
		RequestNamespace="urn:iControl:PEM/InterceptionEndpoint", ResponseNamespace="urn:iControl:PEM/InterceptionEndpoint")]
	public void delete_all_interception_endpoints(

	) {
		this.Invoke("delete_all_interception_endpoints", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_interception_endpoints(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_interception_endpoints", new object[0], callback, asyncState);
	}
	public void Enddelete_all_interception_endpoints(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_interception_endpoint
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/InterceptionEndpoint", 
		RequestNamespace="urn:iControl:PEM/InterceptionEndpoint", ResponseNamespace="urn:iControl:PEM/InterceptionEndpoint")]
	public void delete_interception_endpoint(
		string [] endpoints
	) {
		this.Invoke("delete_interception_endpoint", new object [] {
				endpoints});

	}
	public System.IAsyncResult Begindelete_interception_endpoint(string [] endpoints, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_interception_endpoint", new object[] {
			endpoints}, callback, asyncState);
	}
	public void Enddelete_interception_endpoint(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/InterceptionEndpoint", 
		RequestNamespace="urn:iControl:PEM/InterceptionEndpoint", ResponseNamespace="urn:iControl:PEM/InterceptionEndpoint")]
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
	// get_persistence_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/InterceptionEndpoint", 
		RequestNamespace="urn:iControl:PEM/InterceptionEndpoint", ResponseNamespace="urn:iControl:PEM/InterceptionEndpoint")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public PEMPersistenceType [] get_persistence_type(
		string [] endpoints
	) {
		object [] results = this.Invoke("get_persistence_type", new object [] {
				endpoints});
		return ((PEMPersistenceType [])(results[0]));
	}
	public System.IAsyncResult Beginget_persistence_type(string [] endpoints, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_persistence_type", new object[] {
			endpoints}, callback, asyncState);
	}
	public PEMPersistenceType [] Endget_persistence_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((PEMPersistenceType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/InterceptionEndpoint", 
		RequestNamespace="urn:iControl:PEM/InterceptionEndpoint", ResponseNamespace="urn:iControl:PEM/InterceptionEndpoint")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_pool(
		string [] endpoints
	) {
		object [] results = this.Invoke("get_pool", new object [] {
				endpoints});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_pool(string [] endpoints, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_pool", new object[] {
			endpoints}, callback, asyncState);
	}
	public string [] Endget_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/InterceptionEndpoint", 
		RequestNamespace="urn:iControl:PEM/InterceptionEndpoint", ResponseNamespace="urn:iControl:PEM/InterceptionEndpoint")]
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
	// set_persistence_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/InterceptionEndpoint", 
		RequestNamespace="urn:iControl:PEM/InterceptionEndpoint", ResponseNamespace="urn:iControl:PEM/InterceptionEndpoint")]
	public void set_persistence_type(
		string [] endpoints,
		PEMPersistenceType [] types
	) {
		this.Invoke("set_persistence_type", new object [] {
				endpoints,
				types});

	}
	public System.IAsyncResult Beginset_persistence_type(string [] endpoints,PEMPersistenceType [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_persistence_type", new object[] {
			endpoints,
			types}, callback, asyncState);
	}
	public void Endset_persistence_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/InterceptionEndpoint", 
		RequestNamespace="urn:iControl:PEM/InterceptionEndpoint", ResponseNamespace="urn:iControl:PEM/InterceptionEndpoint")]
	public void set_pool(
		string [] endpoints,
		string [] pools
	) {
		this.Invoke("set_pool", new object [] {
				endpoints,
				pools});

	}
	public System.IAsyncResult Beginset_pool(string [] endpoints,string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_pool", new object[] {
			endpoints,
			pools}, callback, asyncState);
	}
	public void Endset_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	//=======================================================================
	// Structs
	//=======================================================================

}
