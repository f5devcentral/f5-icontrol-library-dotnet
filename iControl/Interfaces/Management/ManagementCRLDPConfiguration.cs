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
	[System.Web.Services.WebServiceBindingAttribute(Name="Management.CRLDPConfigurationBinding", Namespace="urn:iControl")]
	public partial class ManagementCRLDPConfiguration : iControlInterface {
		public ManagementCRLDPConfiguration() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CRLDPConfiguration", 
		RequestNamespace="urn:iControl:Management/CRLDPConfiguration", ResponseNamespace="urn:iControl:Management/CRLDPConfiguration")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CRLDPConfiguration", 
		RequestNamespace="urn:iControl:Management/CRLDPConfiguration", ResponseNamespace="urn:iControl:Management/CRLDPConfiguration")]
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
	// delete_all_configurations
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CRLDPConfiguration", 
		RequestNamespace="urn:iControl:Management/CRLDPConfiguration", ResponseNamespace="urn:iControl:Management/CRLDPConfiguration")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CRLDPConfiguration", 
		RequestNamespace="urn:iControl:Management/CRLDPConfiguration", ResponseNamespace="urn:iControl:Management/CRLDPConfiguration")]
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
	// get_cache_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CRLDPConfiguration", 
		RequestNamespace="urn:iControl:Management/CRLDPConfiguration", ResponseNamespace="urn:iControl:Management/CRLDPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_cache_timeout(
		string [] config_names
	) {
		object [] results = this.Invoke("get_cache_timeout", new object [] {
				config_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_cache_timeout(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cache_timeout", new object[] {
			config_names}, callback, asyncState);
	}
	public long [] Endget_cache_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_connection_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CRLDPConfiguration", 
		RequestNamespace="urn:iControl:Management/CRLDPConfiguration", ResponseNamespace="urn:iControl:Management/CRLDPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_connection_timeout(
		string [] config_names
	) {
		object [] results = this.Invoke("get_connection_timeout", new object [] {
				config_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_connection_timeout(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_connection_timeout", new object[] {
			config_names}, callback, asyncState);
	}
	public long [] Endget_connection_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CRLDPConfiguration", 
		RequestNamespace="urn:iControl:Management/CRLDPConfiguration", ResponseNamespace="urn:iControl:Management/CRLDPConfiguration")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CRLDPConfiguration", 
		RequestNamespace="urn:iControl:Management/CRLDPConfiguration", ResponseNamespace="urn:iControl:Management/CRLDPConfiguration")]
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
	// get_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CRLDPConfiguration", 
		RequestNamespace="urn:iControl:Management/CRLDPConfiguration", ResponseNamespace="urn:iControl:Management/CRLDPConfiguration")]
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
	// get_update_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CRLDPConfiguration", 
		RequestNamespace="urn:iControl:Management/CRLDPConfiguration", ResponseNamespace="urn:iControl:Management/CRLDPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_update_interval(
		string [] config_names
	) {
		object [] results = this.Invoke("get_update_interval", new object [] {
				config_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_update_interval(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_update_interval", new object[] {
			config_names}, callback, asyncState);
	}
	public long [] Endget_update_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_use_issuer_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CRLDPConfiguration", 
		RequestNamespace="urn:iControl:Management/CRLDPConfiguration", ResponseNamespace="urn:iControl:Management/CRLDPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_use_issuer_state(
		string [] config_names
	) {
		object [] results = this.Invoke("get_use_issuer_state", new object [] {
				config_names});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_use_issuer_state(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_use_issuer_state", new object[] {
			config_names}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_use_issuer_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CRLDPConfiguration", 
		RequestNamespace="urn:iControl:Management/CRLDPConfiguration", ResponseNamespace="urn:iControl:Management/CRLDPConfiguration")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CRLDPConfiguration", 
		RequestNamespace="urn:iControl:Management/CRLDPConfiguration", ResponseNamespace="urn:iControl:Management/CRLDPConfiguration")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CRLDPConfiguration", 
		RequestNamespace="urn:iControl:Management/CRLDPConfiguration", ResponseNamespace="urn:iControl:Management/CRLDPConfiguration")]
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
	// set_cache_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CRLDPConfiguration", 
		RequestNamespace="urn:iControl:Management/CRLDPConfiguration", ResponseNamespace="urn:iControl:Management/CRLDPConfiguration")]
	public void set_cache_timeout(
		string [] config_names,
		long [] timeouts
	) {
		this.Invoke("set_cache_timeout", new object [] {
				config_names,
				timeouts});

	}
	public System.IAsyncResult Beginset_cache_timeout(string [] config_names,long [] timeouts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cache_timeout", new object[] {
			config_names,
			timeouts}, callback, asyncState);
	}
	public void Endset_cache_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_connection_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CRLDPConfiguration", 
		RequestNamespace="urn:iControl:Management/CRLDPConfiguration", ResponseNamespace="urn:iControl:Management/CRLDPConfiguration")]
	public void set_connection_timeout(
		string [] config_names,
		long [] timeouts
	) {
		this.Invoke("set_connection_timeout", new object [] {
				config_names,
				timeouts});

	}
	public System.IAsyncResult Beginset_connection_timeout(string [] config_names,long [] timeouts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_connection_timeout", new object[] {
			config_names,
			timeouts}, callback, asyncState);
	}
	public void Endset_connection_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CRLDPConfiguration", 
		RequestNamespace="urn:iControl:Management/CRLDPConfiguration", ResponseNamespace="urn:iControl:Management/CRLDPConfiguration")]
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
	// set_update_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CRLDPConfiguration", 
		RequestNamespace="urn:iControl:Management/CRLDPConfiguration", ResponseNamespace="urn:iControl:Management/CRLDPConfiguration")]
	public void set_update_interval(
		string [] config_names,
		long [] intervals
	) {
		this.Invoke("set_update_interval", new object [] {
				config_names,
				intervals});

	}
	public System.IAsyncResult Beginset_update_interval(string [] config_names,long [] intervals, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_update_interval", new object[] {
			config_names,
			intervals}, callback, asyncState);
	}
	public void Endset_update_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_use_issuer_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CRLDPConfiguration", 
		RequestNamespace="urn:iControl:Management/CRLDPConfiguration", ResponseNamespace="urn:iControl:Management/CRLDPConfiguration")]
	public void set_use_issuer_state(
		string [] config_names,
		CommonEnabledState [] states
	) {
		this.Invoke("set_use_issuer_state", new object [] {
				config_names,
				states});

	}
	public System.IAsyncResult Beginset_use_issuer_state(string [] config_names,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_use_issuer_state", new object[] {
			config_names,
			states}, callback, asyncState);
	}
	public void Endset_use_issuer_state(System.IAsyncResult asyncResult) {
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
