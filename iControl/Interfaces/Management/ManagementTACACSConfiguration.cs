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
	[System.Web.Services.WebServiceBindingAttribute(Name="Management.TACACSConfigurationBinding", Namespace="urn:iControl")]
	public partial class ManagementTACACSConfiguration : iControlInterface {
		public ManagementTACACSConfiguration() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TACACSConfiguration", 
		RequestNamespace="urn:iControl:Management/TACACSConfiguration", ResponseNamespace="urn:iControl:Management/TACACSConfiguration")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TACACSConfiguration", 
		RequestNamespace="urn:iControl:Management/TACACSConfiguration", ResponseNamespace="urn:iControl:Management/TACACSConfiguration")]
	public void create(
		string [] config_names,
		string [] secrets,
		string [] service_names,
		string [] protocol_names,
		string [] [] servers
	) {
		this.Invoke("create", new object [] {
				config_names,
				secrets,
				service_names,
				protocol_names,
				servers});

	}
	public System.IAsyncResult Begincreate(string [] config_names,string [] secrets,string [] service_names,string [] protocol_names,string [] [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			config_names,
			secrets,
			service_names,
			protocol_names,
			servers}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_configurations
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TACACSConfiguration", 
		RequestNamespace="urn:iControl:Management/TACACSConfiguration", ResponseNamespace="urn:iControl:Management/TACACSConfiguration")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TACACSConfiguration", 
		RequestNamespace="urn:iControl:Management/TACACSConfiguration", ResponseNamespace="urn:iControl:Management/TACACSConfiguration")]
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
	// get_accounting_to_all_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TACACSConfiguration", 
		RequestNamespace="urn:iControl:Management/TACACSConfiguration", ResponseNamespace="urn:iControl:Management/TACACSConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_accounting_to_all_state(
		string [] config_names
	) {
		object [] results = this.Invoke("get_accounting_to_all_state", new object [] {
				config_names});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_accounting_to_all_state(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_accounting_to_all_state", new object[] {
			config_names}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_accounting_to_all_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_debug_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TACACSConfiguration", 
		RequestNamespace="urn:iControl:Management/TACACSConfiguration", ResponseNamespace="urn:iControl:Management/TACACSConfiguration")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TACACSConfiguration", 
		RequestNamespace="urn:iControl:Management/TACACSConfiguration", ResponseNamespace="urn:iControl:Management/TACACSConfiguration")]
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
	// get_encryption_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TACACSConfiguration", 
		RequestNamespace="urn:iControl:Management/TACACSConfiguration", ResponseNamespace="urn:iControl:Management/TACACSConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_encryption_state(
		string [] config_names
	) {
		object [] results = this.Invoke("get_encryption_state", new object [] {
				config_names});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_encryption_state(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_encryption_state", new object[] {
			config_names}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_encryption_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_first_hit_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TACACSConfiguration", 
		RequestNamespace="urn:iControl:Management/TACACSConfiguration", ResponseNamespace="urn:iControl:Management/TACACSConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_first_hit_state(
		string [] config_names
	) {
		object [] results = this.Invoke("get_first_hit_state", new object [] {
				config_names});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_first_hit_state(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_first_hit_state", new object[] {
			config_names}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_first_hit_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TACACSConfiguration", 
		RequestNamespace="urn:iControl:Management/TACACSConfiguration", ResponseNamespace="urn:iControl:Management/TACACSConfiguration")]
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
	// get_protocol_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TACACSConfiguration", 
		RequestNamespace="urn:iControl:Management/TACACSConfiguration", ResponseNamespace="urn:iControl:Management/TACACSConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_protocol_name(
		string [] config_names
	) {
		object [] results = this.Invoke("get_protocol_name", new object [] {
				config_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_protocol_name(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_protocol_name", new object[] {
			config_names}, callback, asyncState);
	}
	public string [] Endget_protocol_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_secret
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TACACSConfiguration", 
		RequestNamespace="urn:iControl:Management/TACACSConfiguration", ResponseNamespace="urn:iControl:Management/TACACSConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_secret(
		string [] config_names
	) {
		object [] results = this.Invoke("get_secret", new object [] {
				config_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_secret(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_secret", new object[] {
			config_names}, callback, asyncState);
	}
	public string [] Endget_secret(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TACACSConfiguration", 
		RequestNamespace="urn:iControl:Management/TACACSConfiguration", ResponseNamespace="urn:iControl:Management/TACACSConfiguration")]
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
	// get_service_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TACACSConfiguration", 
		RequestNamespace="urn:iControl:Management/TACACSConfiguration", ResponseNamespace="urn:iControl:Management/TACACSConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_service_name(
		string [] config_names
	) {
		object [] results = this.Invoke("get_service_name", new object [] {
				config_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_service_name(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_service_name", new object[] {
			config_names}, callback, asyncState);
	}
	public string [] Endget_service_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TACACSConfiguration", 
		RequestNamespace="urn:iControl:Management/TACACSConfiguration", ResponseNamespace="urn:iControl:Management/TACACSConfiguration")]
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
	// remove_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TACACSConfiguration", 
		RequestNamespace="urn:iControl:Management/TACACSConfiguration", ResponseNamespace="urn:iControl:Management/TACACSConfiguration")]
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
	// set_accounting_to_all_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TACACSConfiguration", 
		RequestNamespace="urn:iControl:Management/TACACSConfiguration", ResponseNamespace="urn:iControl:Management/TACACSConfiguration")]
	public void set_accounting_to_all_state(
		string [] config_names,
		CommonEnabledState [] states
	) {
		this.Invoke("set_accounting_to_all_state", new object [] {
				config_names,
				states});

	}
	public System.IAsyncResult Beginset_accounting_to_all_state(string [] config_names,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_accounting_to_all_state", new object[] {
			config_names,
			states}, callback, asyncState);
	}
	public void Endset_accounting_to_all_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_debug_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TACACSConfiguration", 
		RequestNamespace="urn:iControl:Management/TACACSConfiguration", ResponseNamespace="urn:iControl:Management/TACACSConfiguration")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TACACSConfiguration", 
		RequestNamespace="urn:iControl:Management/TACACSConfiguration", ResponseNamespace="urn:iControl:Management/TACACSConfiguration")]
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
	// set_encryption_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TACACSConfiguration", 
		RequestNamespace="urn:iControl:Management/TACACSConfiguration", ResponseNamespace="urn:iControl:Management/TACACSConfiguration")]
	public void set_encryption_state(
		string [] config_names,
		CommonEnabledState [] states
	) {
		this.Invoke("set_encryption_state", new object [] {
				config_names,
				states});

	}
	public System.IAsyncResult Beginset_encryption_state(string [] config_names,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_encryption_state", new object[] {
			config_names,
			states}, callback, asyncState);
	}
	public void Endset_encryption_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_first_hit_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TACACSConfiguration", 
		RequestNamespace="urn:iControl:Management/TACACSConfiguration", ResponseNamespace="urn:iControl:Management/TACACSConfiguration")]
	public void set_first_hit_state(
		string [] config_names,
		CommonEnabledState [] states
	) {
		this.Invoke("set_first_hit_state", new object [] {
				config_names,
				states});

	}
	public System.IAsyncResult Beginset_first_hit_state(string [] config_names,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_first_hit_state", new object[] {
			config_names,
			states}, callback, asyncState);
	}
	public void Endset_first_hit_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_protocol_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TACACSConfiguration", 
		RequestNamespace="urn:iControl:Management/TACACSConfiguration", ResponseNamespace="urn:iControl:Management/TACACSConfiguration")]
	public void set_protocol_name(
		string [] config_names,
		string [] protocol_names
	) {
		this.Invoke("set_protocol_name", new object [] {
				config_names,
				protocol_names});

	}
	public System.IAsyncResult Beginset_protocol_name(string [] config_names,string [] protocol_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_protocol_name", new object[] {
			config_names,
			protocol_names}, callback, asyncState);
	}
	public void Endset_protocol_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_secret
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TACACSConfiguration", 
		RequestNamespace="urn:iControl:Management/TACACSConfiguration", ResponseNamespace="urn:iControl:Management/TACACSConfiguration")]
	public void set_secret(
		string [] config_names,
		string [] secrets
	) {
		this.Invoke("set_secret", new object [] {
				config_names,
				secrets});

	}
	public System.IAsyncResult Beginset_secret(string [] config_names,string [] secrets, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_secret", new object[] {
			config_names,
			secrets}, callback, asyncState);
	}
	public void Endset_secret(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_service_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TACACSConfiguration", 
		RequestNamespace="urn:iControl:Management/TACACSConfiguration", ResponseNamespace="urn:iControl:Management/TACACSConfiguration")]
	public void set_service_name(
		string [] config_names,
		string [] service_names
	) {
		this.Invoke("set_service_name", new object [] {
				config_names,
				service_names});

	}
	public System.IAsyncResult Beginset_service_name(string [] config_names,string [] service_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_service_name", new object[] {
			config_names,
			service_names}, callback, asyncState);
	}
	public void Endset_service_name(System.IAsyncResult asyncResult) {
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
