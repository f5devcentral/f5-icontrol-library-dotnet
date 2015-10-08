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
	[System.Web.Services.WebServiceBindingAttribute(Name="PEM.ServiceChainEndpointBinding", Namespace="urn:iControl")]
	public partial class PEMServiceChainEndpoint : iControlInterface {
		public PEMServiceChainEndpoint() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_service_endpoint
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/ServiceChainEndpoint", 
		RequestNamespace="urn:iControl:PEM/ServiceChainEndpoint", ResponseNamespace="urn:iControl:PEM/ServiceChainEndpoint")]
	public void add_service_endpoint(
		string [] endpoints,
		string [] [] service_endpoints,
		string [] [] vlans,
		string [] [] to_endpoints,
		long [] [] orders
	) {
		this.Invoke("add_service_endpoint", new object [] {
				endpoints,
				service_endpoints,
				vlans,
				to_endpoints,
				orders});

	}
	public System.IAsyncResult Beginadd_service_endpoint(string [] endpoints,string [] [] service_endpoints,string [] [] vlans,string [] [] to_endpoints,long [] [] orders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_service_endpoint", new object[] {
			endpoints,
			service_endpoints,
			vlans,
			to_endpoints,
			orders}, callback, asyncState);
	}
	public void Endadd_service_endpoint(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/ServiceChainEndpoint", 
		RequestNamespace="urn:iControl:PEM/ServiceChainEndpoint", ResponseNamespace="urn:iControl:PEM/ServiceChainEndpoint")]
	public void create(
		string [] endpoints
	) {
		this.Invoke("create", new object [] {
				endpoints});

	}
	public System.IAsyncResult Begincreate(string [] endpoints, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			endpoints}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_service_chain_endpoints
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/ServiceChainEndpoint", 
		RequestNamespace="urn:iControl:PEM/ServiceChainEndpoint", ResponseNamespace="urn:iControl:PEM/ServiceChainEndpoint")]
	public void delete_all_service_chain_endpoints(

	) {
		this.Invoke("delete_all_service_chain_endpoints", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_service_chain_endpoints(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_service_chain_endpoints", new object[0], callback, asyncState);
	}
	public void Enddelete_all_service_chain_endpoints(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_service_chain_endpoint
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/ServiceChainEndpoint", 
		RequestNamespace="urn:iControl:PEM/ServiceChainEndpoint", ResponseNamespace="urn:iControl:PEM/ServiceChainEndpoint")]
	public void delete_service_chain_endpoint(
		string [] endpoints
	) {
		this.Invoke("delete_service_chain_endpoint", new object [] {
				endpoints});

	}
	public System.IAsyncResult Begindelete_service_chain_endpoint(string [] endpoints, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_service_chain_endpoint", new object[] {
			endpoints}, callback, asyncState);
	}
	public void Enddelete_service_chain_endpoint(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/ServiceChainEndpoint", 
		RequestNamespace="urn:iControl:PEM/ServiceChainEndpoint", ResponseNamespace="urn:iControl:PEM/ServiceChainEndpoint")]
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
	// get_service_endpoint
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/ServiceChainEndpoint", 
		RequestNamespace="urn:iControl:PEM/ServiceChainEndpoint", ResponseNamespace="urn:iControl:PEM/ServiceChainEndpoint")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_service_endpoint(
		string [] endpoints
	) {
		object [] results = this.Invoke("get_service_endpoint", new object [] {
				endpoints});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_service_endpoint(string [] endpoints, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_service_endpoint", new object[] {
			endpoints}, callback, asyncState);
	}
	public string [] [] Endget_service_endpoint(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_service_endpoint_from_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/ServiceChainEndpoint", 
		RequestNamespace="urn:iControl:PEM/ServiceChainEndpoint", ResponseNamespace="urn:iControl:PEM/ServiceChainEndpoint")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_service_endpoint_from_vlan(
		string [] endpoints,
		string [] [] service_endpoints
	) {
		object [] results = this.Invoke("get_service_endpoint_from_vlan", new object [] {
				endpoints,
				service_endpoints});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_service_endpoint_from_vlan(string [] endpoints,string [] [] service_endpoints, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_service_endpoint_from_vlan", new object[] {
			endpoints,
			service_endpoints}, callback, asyncState);
	}
	public string [] [] Endget_service_endpoint_from_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_service_endpoint_internal_virtual_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/ServiceChainEndpoint", 
		RequestNamespace="urn:iControl:PEM/ServiceChainEndpoint", ResponseNamespace="urn:iControl:PEM/ServiceChainEndpoint")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_service_endpoint_internal_virtual_server(
		string [] chains,
		string [] [] endpoints
	) {
		object [] results = this.Invoke("get_service_endpoint_internal_virtual_server", new object [] {
				chains,
				endpoints});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_service_endpoint_internal_virtual_server(string [] chains,string [] [] endpoints, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_service_endpoint_internal_virtual_server", new object[] {
			chains,
			endpoints}, callback, asyncState);
	}
	public string [] [] Endget_service_endpoint_internal_virtual_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_service_endpoint_option_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/ServiceChainEndpoint", 
		RequestNamespace="urn:iControl:PEM/ServiceChainEndpoint", ResponseNamespace="urn:iControl:PEM/ServiceChainEndpoint")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public PEMServiceChainEndpointServiceOptionType [] [] get_service_endpoint_option_type(
		string [] endpoints,
		string [] [] service_endpoints
	) {
		object [] results = this.Invoke("get_service_endpoint_option_type", new object [] {
				endpoints,
				service_endpoints});
		return ((PEMServiceChainEndpointServiceOptionType [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_service_endpoint_option_type(string [] endpoints,string [] [] service_endpoints, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_service_endpoint_option_type", new object[] {
			endpoints,
			service_endpoints}, callback, asyncState);
	}
	public PEMServiceChainEndpointServiceOptionType [] [] Endget_service_endpoint_option_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((PEMServiceChainEndpointServiceOptionType [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_service_endpoint_order
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/ServiceChainEndpoint", 
		RequestNamespace="urn:iControl:PEM/ServiceChainEndpoint", ResponseNamespace="urn:iControl:PEM/ServiceChainEndpoint")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_service_endpoint_order(
		string [] endpoints,
		string [] [] service_endpoints
	) {
		object [] results = this.Invoke("get_service_endpoint_order", new object [] {
				endpoints,
				service_endpoints});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_service_endpoint_order(string [] endpoints,string [] [] service_endpoints, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_service_endpoint_order", new object[] {
			endpoints,
			service_endpoints}, callback, asyncState);
	}
	public long [] [] Endget_service_endpoint_order(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_service_endpoint_steering_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/ServiceChainEndpoint", 
		RequestNamespace="urn:iControl:PEM/ServiceChainEndpoint", ResponseNamespace="urn:iControl:PEM/ServiceChainEndpoint")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_service_endpoint_steering_policy(
		string [] chains,
		string [] [] endpoints
	) {
		object [] results = this.Invoke("get_service_endpoint_steering_policy", new object [] {
				chains,
				endpoints});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_service_endpoint_steering_policy(string [] chains,string [] [] endpoints, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_service_endpoint_steering_policy", new object[] {
			chains,
			endpoints}, callback, asyncState);
	}
	public string [] [] Endget_service_endpoint_steering_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_service_endpoint_to_endpoint
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/ServiceChainEndpoint", 
		RequestNamespace="urn:iControl:PEM/ServiceChainEndpoint", ResponseNamespace="urn:iControl:PEM/ServiceChainEndpoint")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_service_endpoint_to_endpoint(
		string [] endpoints,
		string [] [] service_endpoints
	) {
		object [] results = this.Invoke("get_service_endpoint_to_endpoint", new object [] {
				endpoints,
				service_endpoints});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_service_endpoint_to_endpoint(string [] endpoints,string [] [] service_endpoints, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_service_endpoint_to_endpoint", new object[] {
			endpoints,
			service_endpoints}, callback, asyncState);
	}
	public string [] [] Endget_service_endpoint_to_endpoint(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/ServiceChainEndpoint", 
		RequestNamespace="urn:iControl:PEM/ServiceChainEndpoint", ResponseNamespace="urn:iControl:PEM/ServiceChainEndpoint")]
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
	// remove_all_service_endpoints
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/ServiceChainEndpoint", 
		RequestNamespace="urn:iControl:PEM/ServiceChainEndpoint", ResponseNamespace="urn:iControl:PEM/ServiceChainEndpoint")]
	public void remove_all_service_endpoints(
		string [] endpoints
	) {
		this.Invoke("remove_all_service_endpoints", new object [] {
				endpoints});

	}
	public System.IAsyncResult Beginremove_all_service_endpoints(string [] endpoints, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_service_endpoints", new object[] {
			endpoints}, callback, asyncState);
	}
	public void Endremove_all_service_endpoints(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_service_endpoint
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/ServiceChainEndpoint", 
		RequestNamespace="urn:iControl:PEM/ServiceChainEndpoint", ResponseNamespace="urn:iControl:PEM/ServiceChainEndpoint")]
	public void remove_service_endpoint(
		string [] endpoints,
		string [] [] service_endpoints
	) {
		this.Invoke("remove_service_endpoint", new object [] {
				endpoints,
				service_endpoints});

	}
	public System.IAsyncResult Beginremove_service_endpoint(string [] endpoints,string [] [] service_endpoints, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_service_endpoint", new object[] {
			endpoints,
			service_endpoints}, callback, asyncState);
	}
	public void Endremove_service_endpoint(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_service_endpoint_from_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/ServiceChainEndpoint", 
		RequestNamespace="urn:iControl:PEM/ServiceChainEndpoint", ResponseNamespace="urn:iControl:PEM/ServiceChainEndpoint")]
	public void set_service_endpoint_from_vlan(
		string [] endpoints,
		string [] [] service_endpoints,
		string [] [] vlans
	) {
		this.Invoke("set_service_endpoint_from_vlan", new object [] {
				endpoints,
				service_endpoints,
				vlans});

	}
	public System.IAsyncResult Beginset_service_endpoint_from_vlan(string [] endpoints,string [] [] service_endpoints,string [] [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_service_endpoint_from_vlan", new object[] {
			endpoints,
			service_endpoints,
			vlans}, callback, asyncState);
	}
	public void Endset_service_endpoint_from_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_service_endpoint_internal_virtual_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/ServiceChainEndpoint", 
		RequestNamespace="urn:iControl:PEM/ServiceChainEndpoint", ResponseNamespace="urn:iControl:PEM/ServiceChainEndpoint")]
	public void set_service_endpoint_internal_virtual_server(
		string [] chains,
		string [] [] endpoints,
		string [] [] virtual_servers
	) {
		this.Invoke("set_service_endpoint_internal_virtual_server", new object [] {
				chains,
				endpoints,
				virtual_servers});

	}
	public System.IAsyncResult Beginset_service_endpoint_internal_virtual_server(string [] chains,string [] [] endpoints,string [] [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_service_endpoint_internal_virtual_server", new object[] {
			chains,
			endpoints,
			virtual_servers}, callback, asyncState);
	}
	public void Endset_service_endpoint_internal_virtual_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_service_endpoint_option_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/ServiceChainEndpoint", 
		RequestNamespace="urn:iControl:PEM/ServiceChainEndpoint", ResponseNamespace="urn:iControl:PEM/ServiceChainEndpoint")]
	public void set_service_endpoint_option_type(
		string [] endpoints,
		string [] [] service_endpoints,
		PEMServiceChainEndpointServiceOptionType [] [] types
	) {
		this.Invoke("set_service_endpoint_option_type", new object [] {
				endpoints,
				service_endpoints,
				types});

	}
	public System.IAsyncResult Beginset_service_endpoint_option_type(string [] endpoints,string [] [] service_endpoints,PEMServiceChainEndpointServiceOptionType [] [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_service_endpoint_option_type", new object[] {
			endpoints,
			service_endpoints,
			types}, callback, asyncState);
	}
	public void Endset_service_endpoint_option_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_service_endpoint_order
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/ServiceChainEndpoint", 
		RequestNamespace="urn:iControl:PEM/ServiceChainEndpoint", ResponseNamespace="urn:iControl:PEM/ServiceChainEndpoint")]
	public void set_service_endpoint_order(
		string [] endpoints,
		string [] [] service_endpoints,
		long [] [] orders
	) {
		this.Invoke("set_service_endpoint_order", new object [] {
				endpoints,
				service_endpoints,
				orders});

	}
	public System.IAsyncResult Beginset_service_endpoint_order(string [] endpoints,string [] [] service_endpoints,long [] [] orders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_service_endpoint_order", new object[] {
			endpoints,
			service_endpoints,
			orders}, callback, asyncState);
	}
	public void Endset_service_endpoint_order(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_service_endpoint_steering_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/ServiceChainEndpoint", 
		RequestNamespace="urn:iControl:PEM/ServiceChainEndpoint", ResponseNamespace="urn:iControl:PEM/ServiceChainEndpoint")]
	public void set_service_endpoint_steering_policy(
		string [] chains,
		string [] [] endpoints,
		string [] [] values
	) {
		this.Invoke("set_service_endpoint_steering_policy", new object [] {
				chains,
				endpoints,
				values});

	}
	public System.IAsyncResult Beginset_service_endpoint_steering_policy(string [] chains,string [] [] endpoints,string [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_service_endpoint_steering_policy", new object[] {
			chains,
			endpoints,
			values}, callback, asyncState);
	}
	public void Endset_service_endpoint_steering_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_service_endpoint_to_endpoint
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/ServiceChainEndpoint", 
		RequestNamespace="urn:iControl:PEM/ServiceChainEndpoint", ResponseNamespace="urn:iControl:PEM/ServiceChainEndpoint")]
	public void set_service_endpoint_to_endpoint(
		string [] endpoints,
		string [] [] service_endpoints,
		string [] [] to_endpoints
	) {
		this.Invoke("set_service_endpoint_to_endpoint", new object [] {
				endpoints,
				service_endpoints,
				to_endpoints});

	}
	public System.IAsyncResult Beginset_service_endpoint_to_endpoint(string [] endpoints,string [] [] service_endpoints,string [] [] to_endpoints, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_service_endpoint_to_endpoint", new object[] {
			endpoints,
			service_endpoints,
			to_endpoints}, callback, asyncState);
	}
	public void Endset_service_endpoint_to_endpoint(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "PEM.ServiceChainEndpoint.ServiceOptionType", Namespace = "urn:iControl")]
	public enum PEMServiceChainEndpointServiceOptionType
	{
		SERVICE_OPTION_TYPE_UNKNOWN,
		SERVICE_OPTION_TYPE_OPTIONAL,
		SERVICE_OPTION_TYPE_MANDATORY,
	}

	//=======================================================================
	// Structs
	//=======================================================================

}
