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
	[System.Web.Services.WebServiceBindingAttribute(Name="Management.RADIUSConfigurationBinding", Namespace="urn:iControl")]
	public partial class ManagementRADIUSConfiguration : iControlInterface {
		public ManagementRADIUSConfiguration() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/RADIUSConfiguration", 
		RequestNamespace="urn:iControl:Management/RADIUSConfiguration", ResponseNamespace="urn:iControl:Management/RADIUSConfiguration")]
	public void add_server(
		string [] config_names,
		string [] [] servers
	) {
		this.Invoke("add_server", new object [] {
				config_names,
				servers});

	}
	public System.IAsyncResult Beginadd_server(string [] config_names,string [] [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_server", new object[] {
			config_names,
			servers}, callback, asyncState);
	}
	public void Endadd_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/RADIUSConfiguration", 
		RequestNamespace="urn:iControl:Management/RADIUSConfiguration", ResponseNamespace="urn:iControl:Management/RADIUSConfiguration")]
	public void create(
		string [] config_names,
		string [] [] servers
	) {
		this.Invoke("create", new object [] {
				config_names,
				servers});

	}
	public System.IAsyncResult Begincreate(string [] config_names,string [] [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			config_names,
			servers}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create_default_authentication_radius_configuration
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/RADIUSConfiguration", 
		RequestNamespace="urn:iControl:Management/RADIUSConfiguration", ResponseNamespace="urn:iControl:Management/RADIUSConfiguration")]
	public void create_default_authentication_radius_configuration(
		string [] servers
	) {
		this.Invoke("create_default_authentication_radius_configuration", new object [] {
				servers});

	}
	public System.IAsyncResult Begincreate_default_authentication_radius_configuration(string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_default_authentication_radius_configuration", new object[] {
			servers}, callback, asyncState);
	}
	public void Endcreate_default_authentication_radius_configuration(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_configurations
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/RADIUSConfiguration", 
		RequestNamespace="urn:iControl:Management/RADIUSConfiguration", ResponseNamespace="urn:iControl:Management/RADIUSConfiguration")]
	public void delete_all_configurations(

	) {
		this.Invoke("delete_all_configurations", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_configurations(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_configurations", new object[0], callback, asyncState);
	}
	public void Enddelete_all_configurations(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_configuration
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/RADIUSConfiguration", 
		RequestNamespace="urn:iControl:Management/RADIUSConfiguration", ResponseNamespace="urn:iControl:Management/RADIUSConfiguration")]
	public void delete_configuration(
		string [] config_names
	) {
		this.Invoke("delete_configuration", new object [] {
				config_names});

	}
	public System.IAsyncResult Begindelete_configuration(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_configuration", new object[] {
			config_names}, callback, asyncState);
	}
	public void Enddelete_configuration(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_accounting_validation_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/RADIUSConfiguration", 
		RequestNamespace="urn:iControl:Management/RADIUSConfiguration", ResponseNamespace="urn:iControl:Management/RADIUSConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_accounting_validation_state(
		string [] config_names
	) {
		object [] results = this.Invoke("get_accounting_validation_state", new object [] {
				config_names});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_accounting_validation_state(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_accounting_validation_state", new object[] {
			config_names}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_accounting_validation_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_client_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/RADIUSConfiguration", 
		RequestNamespace="urn:iControl:Management/RADIUSConfiguration", ResponseNamespace="urn:iControl:Management/RADIUSConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_client_id(
		string [] config_names
	) {
		object [] results = this.Invoke("get_client_id", new object [] {
				config_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_client_id(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_client_id", new object[] {
			config_names}, callback, asyncState);
	}
	public string [] Endget_client_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_debug_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/RADIUSConfiguration", 
		RequestNamespace="urn:iControl:Management/RADIUSConfiguration", ResponseNamespace="urn:iControl:Management/RADIUSConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_debug_state(
		string [] config_names
	) {
		object [] results = this.Invoke("get_debug_state", new object [] {
				config_names});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_debug_state(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_debug_state", new object[] {
			config_names}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_debug_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/RADIUSConfiguration", 
		RequestNamespace="urn:iControl:Management/RADIUSConfiguration", ResponseNamespace="urn:iControl:Management/RADIUSConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] config_names
	) {
		object [] results = this.Invoke("get_description", new object [] {
				config_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			config_names}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/RADIUSConfiguration", 
		RequestNamespace="urn:iControl:Management/RADIUSConfiguration", ResponseNamespace="urn:iControl:Management/RADIUSConfiguration")]
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
	// get_retry
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/RADIUSConfiguration", 
		RequestNamespace="urn:iControl:Management/RADIUSConfiguration", ResponseNamespace="urn:iControl:Management/RADIUSConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_retry(
		string [] config_names
	) {
		object [] results = this.Invoke("get_retry", new object [] {
				config_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_retry(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_retry", new object[] {
			config_names}, callback, asyncState);
	}
	public long [] Endget_retry(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/RADIUSConfiguration", 
		RequestNamespace="urn:iControl:Management/RADIUSConfiguration", ResponseNamespace="urn:iControl:Management/RADIUSConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_server(
		string [] config_names
	) {
		object [] results = this.Invoke("get_server", new object [] {
				config_names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_server(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_server", new object[] {
			config_names}, callback, asyncState);
	}
	public string [] [] Endget_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_service_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/RADIUSConfiguration", 
		RequestNamespace="urn:iControl:Management/RADIUSConfiguration", ResponseNamespace="urn:iControl:Management/RADIUSConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementRadiusServiceType [] get_service_type(
		string [] config_names
	) {
		object [] results = this.Invoke("get_service_type", new object [] {
				config_names});
		return ((ManagementRadiusServiceType [])(results[0]));
	}
	public System.IAsyncResult Beginget_service_type(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_service_type", new object[] {
			config_names}, callback, asyncState);
	}
	public ManagementRadiusServiceType [] Endget_service_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementRadiusServiceType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/RADIUSConfiguration", 
		RequestNamespace="urn:iControl:Management/RADIUSConfiguration", ResponseNamespace="urn:iControl:Management/RADIUSConfiguration")]
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
	// remove_all_servers
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/RADIUSConfiguration", 
		RequestNamespace="urn:iControl:Management/RADIUSConfiguration", ResponseNamespace="urn:iControl:Management/RADIUSConfiguration")]
	public void remove_all_servers(
		string [] config_names
	) {
		this.Invoke("remove_all_servers", new object [] {
				config_names});

	}
	public System.IAsyncResult Beginremove_all_servers(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_servers", new object[] {
			config_names}, callback, asyncState);
	}
	public void Endremove_all_servers(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/RADIUSConfiguration", 
		RequestNamespace="urn:iControl:Management/RADIUSConfiguration", ResponseNamespace="urn:iControl:Management/RADIUSConfiguration")]
	public void remove_server(
		string [] config_names,
		string [] [] servers
	) {
		this.Invoke("remove_server", new object [] {
				config_names,
				servers});

	}
	public System.IAsyncResult Beginremove_server(string [] config_names,string [] [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_server", new object[] {
			config_names,
			servers}, callback, asyncState);
	}
	public void Endremove_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_accounting_validation_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/RADIUSConfiguration", 
		RequestNamespace="urn:iControl:Management/RADIUSConfiguration", ResponseNamespace="urn:iControl:Management/RADIUSConfiguration")]
	public void set_accounting_validation_state(
		string [] config_names,
		CommonEnabledState [] states
	) {
		this.Invoke("set_accounting_validation_state", new object [] {
				config_names,
				states});

	}
	public System.IAsyncResult Beginset_accounting_validation_state(string [] config_names,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_accounting_validation_state", new object[] {
			config_names,
			states}, callback, asyncState);
	}
	public void Endset_accounting_validation_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_client_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/RADIUSConfiguration", 
		RequestNamespace="urn:iControl:Management/RADIUSConfiguration", ResponseNamespace="urn:iControl:Management/RADIUSConfiguration")]
	public void set_client_id(
		string [] config_names,
		string [] client_ids
	) {
		this.Invoke("set_client_id", new object [] {
				config_names,
				client_ids});

	}
	public System.IAsyncResult Beginset_client_id(string [] config_names,string [] client_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_client_id", new object[] {
			config_names,
			client_ids}, callback, asyncState);
	}
	public void Endset_client_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_debug_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/RADIUSConfiguration", 
		RequestNamespace="urn:iControl:Management/RADIUSConfiguration", ResponseNamespace="urn:iControl:Management/RADIUSConfiguration")]
	public void set_debug_state(
		string [] config_names,
		CommonEnabledState [] states
	) {
		this.Invoke("set_debug_state", new object [] {
				config_names,
				states});

	}
	public System.IAsyncResult Beginset_debug_state(string [] config_names,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_debug_state", new object[] {
			config_names,
			states}, callback, asyncState);
	}
	public void Endset_debug_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/RADIUSConfiguration", 
		RequestNamespace="urn:iControl:Management/RADIUSConfiguration", ResponseNamespace="urn:iControl:Management/RADIUSConfiguration")]
	public void set_description(
		string [] config_names,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				config_names,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] config_names,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			config_names,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_retry
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/RADIUSConfiguration", 
		RequestNamespace="urn:iControl:Management/RADIUSConfiguration", ResponseNamespace="urn:iControl:Management/RADIUSConfiguration")]
	public void set_retry(
		string [] config_names,
		long [] retries
	) {
		this.Invoke("set_retry", new object [] {
				config_names,
				retries});

	}
	public System.IAsyncResult Beginset_retry(string [] config_names,long [] retries, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_retry", new object[] {
			config_names,
			retries}, callback, asyncState);
	}
	public void Endset_retry(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_service_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/RADIUSConfiguration", 
		RequestNamespace="urn:iControl:Management/RADIUSConfiguration", ResponseNamespace="urn:iControl:Management/RADIUSConfiguration")]
	public void set_service_type(
		string [] config_names,
		ManagementRadiusServiceType [] service_types
	) {
		this.Invoke("set_service_type", new object [] {
				config_names,
				service_types});

	}
	public System.IAsyncResult Beginset_service_type(string [] config_names,ManagementRadiusServiceType [] service_types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_service_type", new object[] {
			config_names,
			service_types}, callback, asyncState);
	}
	public void Endset_service_type(System.IAsyncResult asyncResult) {
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
