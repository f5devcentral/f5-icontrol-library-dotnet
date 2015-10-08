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
	[System.Web.Services.WebServiceBindingAttribute(Name="PEM.ForwardingEndpointBinding", Namespace="urn:iControl")]
	public partial class PEMForwardingEndpoint : iControlInterface {
		public PEMForwardingEndpoint() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/ForwardingEndpoint", 
		RequestNamespace="urn:iControl:PEM/ForwardingEndpoint", ResponseNamespace="urn:iControl:PEM/ForwardingEndpoint")]
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
	// delete_all_forwarding_endpoints
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/ForwardingEndpoint", 
		RequestNamespace="urn:iControl:PEM/ForwardingEndpoint", ResponseNamespace="urn:iControl:PEM/ForwardingEndpoint")]
	public void delete_all_forwarding_endpoints(

	) {
		this.Invoke("delete_all_forwarding_endpoints", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_forwarding_endpoints(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_forwarding_endpoints", new object[0], callback, asyncState);
	}
	public void Enddelete_all_forwarding_endpoints(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_forwarding_endpoint
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/ForwardingEndpoint", 
		RequestNamespace="urn:iControl:PEM/ForwardingEndpoint", ResponseNamespace="urn:iControl:PEM/ForwardingEndpoint")]
	public void delete_forwarding_endpoint(
		string [] endpoints
	) {
		this.Invoke("delete_forwarding_endpoint", new object [] {
				endpoints});

	}
	public System.IAsyncResult Begindelete_forwarding_endpoint(string [] endpoints, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_forwarding_endpoint", new object[] {
			endpoints}, callback, asyncState);
	}
	public void Enddelete_forwarding_endpoint(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_forwarding_endpoint_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/ForwardingEndpoint", 
		RequestNamespace="urn:iControl:PEM/ForwardingEndpoint", ResponseNamespace="urn:iControl:PEM/ForwardingEndpoint")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public PEMForwardingEndpointForwardingEndpointType [] get_forwarding_endpoint_type(
		string [] endpoints
	) {
		object [] results = this.Invoke("get_forwarding_endpoint_type", new object [] {
				endpoints});
		return ((PEMForwardingEndpointForwardingEndpointType [])(results[0]));
	}
	public System.IAsyncResult Beginget_forwarding_endpoint_type(string [] endpoints, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_forwarding_endpoint_type", new object[] {
			endpoints}, callback, asyncState);
	}
	public PEMForwardingEndpointForwardingEndpointType [] Endget_forwarding_endpoint_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((PEMForwardingEndpointForwardingEndpointType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/ForwardingEndpoint", 
		RequestNamespace="urn:iControl:PEM/ForwardingEndpoint", ResponseNamespace="urn:iControl:PEM/ForwardingEndpoint")]
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
	// get_lsn_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/ForwardingEndpoint", 
		RequestNamespace="urn:iControl:PEM/ForwardingEndpoint", ResponseNamespace="urn:iControl:PEM/ForwardingEndpoint")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_lsn_pool(
		string [] endpoints
	) {
		object [] results = this.Invoke("get_lsn_pool", new object [] {
				endpoints});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_lsn_pool(string [] endpoints, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_lsn_pool", new object[] {
			endpoints}, callback, asyncState);
	}
	public string [] Endget_lsn_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_persistence_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/ForwardingEndpoint", 
		RequestNamespace="urn:iControl:PEM/ForwardingEndpoint", ResponseNamespace="urn:iControl:PEM/ForwardingEndpoint")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/ForwardingEndpoint", 
		RequestNamespace="urn:iControl:PEM/ForwardingEndpoint", ResponseNamespace="urn:iControl:PEM/ForwardingEndpoint")]
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
	// get_snat_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/ForwardingEndpoint", 
		RequestNamespace="urn:iControl:PEM/ForwardingEndpoint", ResponseNamespace="urn:iControl:PEM/ForwardingEndpoint")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_snat_pool(
		string [] endpoints
	) {
		object [] results = this.Invoke("get_snat_pool", new object [] {
				endpoints});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_snat_pool(string [] endpoints, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_snat_pool", new object[] {
			endpoints}, callback, asyncState);
	}
	public string [] Endget_snat_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_source_port_behavior
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/ForwardingEndpoint", 
		RequestNamespace="urn:iControl:PEM/ForwardingEndpoint", ResponseNamespace="urn:iControl:PEM/ForwardingEndpoint")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonSourcePortBehavior [] get_source_port_behavior(
		string [] endpoints
	) {
		object [] results = this.Invoke("get_source_port_behavior", new object [] {
				endpoints});
		return ((CommonSourcePortBehavior [])(results[0]));
	}
	public System.IAsyncResult Beginget_source_port_behavior(string [] endpoints, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_source_port_behavior", new object[] {
			endpoints}, callback, asyncState);
	}
	public CommonSourcePortBehavior [] Endget_source_port_behavior(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonSourcePortBehavior [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_translate_address_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/ForwardingEndpoint", 
		RequestNamespace="urn:iControl:PEM/ForwardingEndpoint", ResponseNamespace="urn:iControl:PEM/ForwardingEndpoint")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_translate_address_state(
		string [] endpoints
	) {
		object [] results = this.Invoke("get_translate_address_state", new object [] {
				endpoints});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_translate_address_state(string [] endpoints, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_translate_address_state", new object[] {
			endpoints}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_translate_address_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_translate_service_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/ForwardingEndpoint", 
		RequestNamespace="urn:iControl:PEM/ForwardingEndpoint", ResponseNamespace="urn:iControl:PEM/ForwardingEndpoint")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_translate_service_state(
		string [] endpoints
	) {
		object [] results = this.Invoke("get_translate_service_state", new object [] {
				endpoints});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_translate_service_state(string [] endpoints, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_translate_service_state", new object[] {
			endpoints}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_translate_service_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/ForwardingEndpoint", 
		RequestNamespace="urn:iControl:PEM/ForwardingEndpoint", ResponseNamespace="urn:iControl:PEM/ForwardingEndpoint")]
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
	// set_forwarding_endpoint_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/ForwardingEndpoint", 
		RequestNamespace="urn:iControl:PEM/ForwardingEndpoint", ResponseNamespace="urn:iControl:PEM/ForwardingEndpoint")]
	public void set_forwarding_endpoint_type(
		string [] endpoints,
		PEMForwardingEndpointForwardingEndpointType [] values
	) {
		this.Invoke("set_forwarding_endpoint_type", new object [] {
				endpoints,
				values});

	}
	public System.IAsyncResult Beginset_forwarding_endpoint_type(string [] endpoints,PEMForwardingEndpointForwardingEndpointType [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_forwarding_endpoint_type", new object[] {
			endpoints,
			values}, callback, asyncState);
	}
	public void Endset_forwarding_endpoint_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_lsn_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/ForwardingEndpoint", 
		RequestNamespace="urn:iControl:PEM/ForwardingEndpoint", ResponseNamespace="urn:iControl:PEM/ForwardingEndpoint")]
	public void set_lsn_pool(
		string [] endpoints,
		string [] pools
	) {
		this.Invoke("set_lsn_pool", new object [] {
				endpoints,
				pools});

	}
	public System.IAsyncResult Beginset_lsn_pool(string [] endpoints,string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_lsn_pool", new object[] {
			endpoints,
			pools}, callback, asyncState);
	}
	public void Endset_lsn_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_persistence_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/ForwardingEndpoint", 
		RequestNamespace="urn:iControl:PEM/ForwardingEndpoint", ResponseNamespace="urn:iControl:PEM/ForwardingEndpoint")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/ForwardingEndpoint", 
		RequestNamespace="urn:iControl:PEM/ForwardingEndpoint", ResponseNamespace="urn:iControl:PEM/ForwardingEndpoint")]
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

	//-----------------------------------------------------------------------
	// set_snat_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/ForwardingEndpoint", 
		RequestNamespace="urn:iControl:PEM/ForwardingEndpoint", ResponseNamespace="urn:iControl:PEM/ForwardingEndpoint")]
	public void set_snat_pool(
		string [] endpoints,
		string [] pools
	) {
		this.Invoke("set_snat_pool", new object [] {
				endpoints,
				pools});

	}
	public System.IAsyncResult Beginset_snat_pool(string [] endpoints,string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_snat_pool", new object[] {
			endpoints,
			pools}, callback, asyncState);
	}
	public void Endset_snat_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_source_port_behavior
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/ForwardingEndpoint", 
		RequestNamespace="urn:iControl:PEM/ForwardingEndpoint", ResponseNamespace="urn:iControl:PEM/ForwardingEndpoint")]
	public void set_source_port_behavior(
		string [] endpoints,
		CommonSourcePortBehavior [] behaviors
	) {
		this.Invoke("set_source_port_behavior", new object [] {
				endpoints,
				behaviors});

	}
	public System.IAsyncResult Beginset_source_port_behavior(string [] endpoints,CommonSourcePortBehavior [] behaviors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_source_port_behavior", new object[] {
			endpoints,
			behaviors}, callback, asyncState);
	}
	public void Endset_source_port_behavior(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_translate_address_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/ForwardingEndpoint", 
		RequestNamespace="urn:iControl:PEM/ForwardingEndpoint", ResponseNamespace="urn:iControl:PEM/ForwardingEndpoint")]
	public void set_translate_address_state(
		string [] endpoints,
		CommonEnabledState [] states
	) {
		this.Invoke("set_translate_address_state", new object [] {
				endpoints,
				states});

	}
	public System.IAsyncResult Beginset_translate_address_state(string [] endpoints,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_translate_address_state", new object[] {
			endpoints,
			states}, callback, asyncState);
	}
	public void Endset_translate_address_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_translate_service_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/ForwardingEndpoint", 
		RequestNamespace="urn:iControl:PEM/ForwardingEndpoint", ResponseNamespace="urn:iControl:PEM/ForwardingEndpoint")]
	public void set_translate_service_state(
		string [] endpoints,
		CommonEnabledState [] states
	) {
		this.Invoke("set_translate_service_state", new object [] {
				endpoints,
				states});

	}
	public System.IAsyncResult Beginset_translate_service_state(string [] endpoints,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_translate_service_state", new object[] {
			endpoints,
			states}, callback, asyncState);
	}
	public void Endset_translate_service_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "PEM.ForwardingEndpoint.ForwardingEndpointType", Namespace = "urn:iControl")]
	public enum PEMForwardingEndpointForwardingEndpointType
	{
		FORWARDING_ENDPOINT_UNKNOWN,
		FORWARDING_ENDPOINT_TRANSPARENT,
		FORWARDING_ENDPOINT_NONTRANSPARENT,
	}

	//=======================================================================
	// Structs
	//=======================================================================

}
