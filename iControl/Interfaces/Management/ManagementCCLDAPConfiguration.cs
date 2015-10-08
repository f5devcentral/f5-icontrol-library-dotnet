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
	[System.Web.Services.WebServiceBindingAttribute(Name="Management.CCLDAPConfigurationBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementCCLDAPConfigurationLDAPSearchOption))]
	public partial class ManagementCCLDAPConfiguration : iControlInterface {
		public ManagementCCLDAPConfiguration() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CCLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CCLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CCLDAPConfiguration")]
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
	// add_valid_group
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CCLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CCLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CCLDAPConfiguration")]
	public void add_valid_group(
		string [] config_names,
		string [] [] groups
	) {
		this.Invoke("add_valid_group", new object [] {
				config_names,
				groups});

	}
	public System.IAsyncResult Beginadd_valid_group(string [] config_names,string [] [] groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_valid_group", new object[] {
			config_names,
			groups}, callback, asyncState);
	}
	public void Endadd_valid_group(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_valid_role
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CCLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CCLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CCLDAPConfiguration")]
	public void add_valid_role(
		string [] config_names,
		string [] [] roles
	) {
		this.Invoke("add_valid_role", new object [] {
				config_names,
				roles});

	}
	public System.IAsyncResult Beginadd_valid_role(string [] config_names,string [] [] roles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_valid_role", new object[] {
			config_names,
			roles}, callback, asyncState);
	}
	public void Endadd_valid_role(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CCLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CCLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CCLDAPConfiguration")]
	public void create(
		string [] config_names,
		ManagementCCLDAPConfigurationLDAPSearchOption [] search_options,
		string [] [] servers
	) {
		this.Invoke("create", new object [] {
				config_names,
				search_options,
				servers});

	}
	public System.IAsyncResult Begincreate(string [] config_names,ManagementCCLDAPConfigurationLDAPSearchOption [] search_options,string [] [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			config_names,
			search_options,
			servers}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_configurations
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CCLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CCLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CCLDAPConfiguration")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CCLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CCLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CCLDAPConfiguration")]
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
	// get_admin_distinguished_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CCLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CCLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CCLDAPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_admin_distinguished_name(
		string [] config_names
	) {
		object [] results = this.Invoke("get_admin_distinguished_name", new object [] {
				config_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_admin_distinguished_name(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_admin_distinguished_name", new object[] {
			config_names}, callback, asyncState);
	}
	public string [] Endget_admin_distinguished_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_admin_password
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CCLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CCLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CCLDAPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_admin_password(
		string [] config_names
	) {
		object [] results = this.Invoke("get_admin_password", new object [] {
				config_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_admin_password(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_admin_password", new object[] {
			config_names}, callback, asyncState);
	}
	public string [] Endget_admin_password(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cache_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CCLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CCLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CCLDAPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_cache_size(
		string [] config_names
	) {
		object [] results = this.Invoke("get_cache_size", new object [] {
				config_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_cache_size(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cache_size", new object[] {
			config_names}, callback, asyncState);
	}
	public long [] Endget_cache_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cache_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CCLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CCLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CCLDAPConfiguration")]
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
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CCLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CCLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CCLDAPConfiguration")]
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
	// get_group_base
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CCLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CCLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CCLDAPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_group_base(
		string [] config_names
	) {
		object [] results = this.Invoke("get_group_base", new object [] {
				config_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_group_base(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_group_base", new object[] {
			config_names}, callback, asyncState);
	}
	public string [] Endget_group_base(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_group_key
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CCLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CCLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CCLDAPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_group_key(
		string [] config_names
	) {
		object [] results = this.Invoke("get_group_key", new object [] {
				config_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_group_key(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_group_key", new object[] {
			config_names}, callback, asyncState);
	}
	public string [] Endget_group_key(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_group_member_key
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CCLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CCLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CCLDAPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_group_member_key(
		string [] config_names
	) {
		object [] results = this.Invoke("get_group_member_key", new object [] {
				config_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_group_member_key(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_group_member_key", new object[] {
			config_names}, callback, asyncState);
	}
	public string [] Endget_group_member_key(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CCLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CCLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CCLDAPConfiguration")]
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
	// get_role_key
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CCLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CCLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CCLDAPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_role_key(
		string [] config_names
	) {
		object [] results = this.Invoke("get_role_key", new object [] {
				config_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_role_key(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_role_key", new object[] {
			config_names}, callback, asyncState);
	}
	public string [] Endget_role_key(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_search_option
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CCLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CCLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CCLDAPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementCCLDAPConfigurationLDAPSearchOption [] get_search_option(
		string [] config_names
	) {
		object [] results = this.Invoke("get_search_option", new object [] {
				config_names});
		return ((ManagementCCLDAPConfigurationLDAPSearchOption [])(results[0]));
	}
	public System.IAsyncResult Beginget_search_option(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_search_option", new object[] {
			config_names}, callback, asyncState);
	}
	public ManagementCCLDAPConfigurationLDAPSearchOption [] Endget_search_option(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementCCLDAPConfigurationLDAPSearchOption [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CCLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CCLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CCLDAPConfiguration")]
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
	// get_use_certificate_serial_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CCLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CCLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CCLDAPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_use_certificate_serial_state(
		string [] config_names
	) {
		object [] results = this.Invoke("get_use_certificate_serial_state", new object [] {
				config_names});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_use_certificate_serial_state(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_use_certificate_serial_state", new object[] {
			config_names}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_use_certificate_serial_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_use_security_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CCLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CCLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CCLDAPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_use_security_state(
		string [] config_names
	) {
		object [] results = this.Invoke("get_use_security_state", new object [] {
				config_names});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_use_security_state(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_use_security_state", new object[] {
			config_names}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_use_security_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_user_class
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CCLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CCLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CCLDAPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_user_class(
		string [] config_names
	) {
		object [] results = this.Invoke("get_user_class", new object [] {
				config_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_user_class(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_user_class", new object[] {
			config_names}, callback, asyncState);
	}
	public string [] Endget_user_class(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_valid_group
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CCLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CCLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CCLDAPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_valid_group(
		string [] config_names
	) {
		object [] results = this.Invoke("get_valid_group", new object [] {
				config_names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_valid_group(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_valid_group", new object[] {
			config_names}, callback, asyncState);
	}
	public string [] [] Endget_valid_group(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_valid_role
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CCLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CCLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CCLDAPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_valid_role(
		string [] config_names
	) {
		object [] results = this.Invoke("get_valid_role", new object [] {
				config_names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_valid_role(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_valid_role", new object[] {
			config_names}, callback, asyncState);
	}
	public string [] [] Endget_valid_role(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CCLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CCLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CCLDAPConfiguration")]
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
	// remove_all_valid_groups
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CCLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CCLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CCLDAPConfiguration")]
	public void remove_all_valid_groups(
		string [] config_names
	) {
		this.Invoke("remove_all_valid_groups", new object [] {
				config_names});

	}
	public System.IAsyncResult Beginremove_all_valid_groups(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_valid_groups", new object[] {
			config_names}, callback, asyncState);
	}
	public void Endremove_all_valid_groups(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_valid_roles
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CCLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CCLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CCLDAPConfiguration")]
	public void remove_all_valid_roles(
		string [] config_names
	) {
		this.Invoke("remove_all_valid_roles", new object [] {
				config_names});

	}
	public System.IAsyncResult Beginremove_all_valid_roles(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_valid_roles", new object[] {
			config_names}, callback, asyncState);
	}
	public void Endremove_all_valid_roles(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CCLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CCLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CCLDAPConfiguration")]
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
	// remove_valid_group
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CCLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CCLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CCLDAPConfiguration")]
	public void remove_valid_group(
		string [] config_names,
		string [] [] groups
	) {
		this.Invoke("remove_valid_group", new object [] {
				config_names,
				groups});

	}
	public System.IAsyncResult Beginremove_valid_group(string [] config_names,string [] [] groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_valid_group", new object[] {
			config_names,
			groups}, callback, asyncState);
	}
	public void Endremove_valid_group(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_valid_role
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CCLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CCLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CCLDAPConfiguration")]
	public void remove_valid_role(
		string [] config_names,
		string [] [] roles
	) {
		this.Invoke("remove_valid_role", new object [] {
				config_names,
				roles});

	}
	public System.IAsyncResult Beginremove_valid_role(string [] config_names,string [] [] roles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_valid_role", new object[] {
			config_names,
			roles}, callback, asyncState);
	}
	public void Endremove_valid_role(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_admin_distinguished_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CCLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CCLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CCLDAPConfiguration")]
	public void set_admin_distinguished_name(
		string [] config_names,
		string [] admin_dns
	) {
		this.Invoke("set_admin_distinguished_name", new object [] {
				config_names,
				admin_dns});

	}
	public System.IAsyncResult Beginset_admin_distinguished_name(string [] config_names,string [] admin_dns, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_admin_distinguished_name", new object[] {
			config_names,
			admin_dns}, callback, asyncState);
	}
	public void Endset_admin_distinguished_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_admin_password
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CCLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CCLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CCLDAPConfiguration")]
	public void set_admin_password(
		string [] config_names,
		string [] admin_passwords
	) {
		this.Invoke("set_admin_password", new object [] {
				config_names,
				admin_passwords});

	}
	public System.IAsyncResult Beginset_admin_password(string [] config_names,string [] admin_passwords, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_admin_password", new object[] {
			config_names,
			admin_passwords}, callback, asyncState);
	}
	public void Endset_admin_password(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_cache_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CCLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CCLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CCLDAPConfiguration")]
	public void set_cache_size(
		string [] config_names,
		long [] sizes
	) {
		this.Invoke("set_cache_size", new object [] {
				config_names,
				sizes});

	}
	public System.IAsyncResult Beginset_cache_size(string [] config_names,long [] sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cache_size", new object[] {
			config_names,
			sizes}, callback, asyncState);
	}
	public void Endset_cache_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_cache_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CCLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CCLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CCLDAPConfiguration")]
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
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CCLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CCLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CCLDAPConfiguration")]
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
	// set_group_base
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CCLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CCLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CCLDAPConfiguration")]
	public void set_group_base(
		string [] config_names,
		string [] bases
	) {
		this.Invoke("set_group_base", new object [] {
				config_names,
				bases});

	}
	public System.IAsyncResult Beginset_group_base(string [] config_names,string [] bases, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_group_base", new object[] {
			config_names,
			bases}, callback, asyncState);
	}
	public void Endset_group_base(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_group_key
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CCLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CCLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CCLDAPConfiguration")]
	public void set_group_key(
		string [] config_names,
		string [] keys
	) {
		this.Invoke("set_group_key", new object [] {
				config_names,
				keys});

	}
	public System.IAsyncResult Beginset_group_key(string [] config_names,string [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_group_key", new object[] {
			config_names,
			keys}, callback, asyncState);
	}
	public void Endset_group_key(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_group_member_key
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CCLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CCLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CCLDAPConfiguration")]
	public void set_group_member_key(
		string [] config_names,
		string [] keys
	) {
		this.Invoke("set_group_member_key", new object [] {
				config_names,
				keys});

	}
	public System.IAsyncResult Beginset_group_member_key(string [] config_names,string [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_group_member_key", new object[] {
			config_names,
			keys}, callback, asyncState);
	}
	public void Endset_group_member_key(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_role_key
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CCLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CCLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CCLDAPConfiguration")]
	public void set_role_key(
		string [] config_names,
		string [] keys
	) {
		this.Invoke("set_role_key", new object [] {
				config_names,
				keys});

	}
	public System.IAsyncResult Beginset_role_key(string [] config_names,string [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_role_key", new object[] {
			config_names,
			keys}, callback, asyncState);
	}
	public void Endset_role_key(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_search_option
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CCLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CCLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CCLDAPConfiguration")]
	public void set_search_option(
		string [] config_names,
		ManagementCCLDAPConfigurationLDAPSearchOption [] options
	) {
		this.Invoke("set_search_option", new object [] {
				config_names,
				options});

	}
	public System.IAsyncResult Beginset_search_option(string [] config_names,ManagementCCLDAPConfigurationLDAPSearchOption [] options, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_search_option", new object[] {
			config_names,
			options}, callback, asyncState);
	}
	public void Endset_search_option(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_use_certificate_serial_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CCLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CCLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CCLDAPConfiguration")]
	public void set_use_certificate_serial_state(
		string [] config_names,
		CommonEnabledState [] states
	) {
		this.Invoke("set_use_certificate_serial_state", new object [] {
				config_names,
				states});

	}
	public System.IAsyncResult Beginset_use_certificate_serial_state(string [] config_names,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_use_certificate_serial_state", new object[] {
			config_names,
			states}, callback, asyncState);
	}
	public void Endset_use_certificate_serial_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_use_security_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CCLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CCLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CCLDAPConfiguration")]
	public void set_use_security_state(
		string [] config_names,
		CommonEnabledState [] states
	) {
		this.Invoke("set_use_security_state", new object [] {
				config_names,
				states});

	}
	public System.IAsyncResult Beginset_use_security_state(string [] config_names,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_use_security_state", new object[] {
			config_names,
			states}, callback, asyncState);
	}
	public void Endset_use_security_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_user_class
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CCLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CCLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CCLDAPConfiguration")]
	public void set_user_class(
		string [] config_names,
		string [] user_classes
	) {
		this.Invoke("set_user_class", new object [] {
				config_names,
				user_classes});

	}
	public System.IAsyncResult Beginset_user_class(string [] config_names,string [] user_classes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_user_class", new object[] {
			config_names,
			user_classes}, callback, asyncState);
	}
	public void Endset_user_class(System.IAsyncResult asyncResult) {
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.CCLDAPConfiguration.LDAPSearchOption", Namespace = "urn:iControl")]
	public partial class ManagementCCLDAPConfigurationLDAPSearchOption
	{
		private ManagementLDAPSearchMethod search_methodField;
		public ManagementLDAPSearchMethod search_method
		{
			get { return this.search_methodField; }
			set { this.search_methodField = value; }
		}
		private string search_baseField;
		public string search_base
		{
			get { return this.search_baseField; }
			set { this.search_baseField = value; }
		}
		private string search_keyField;
		public string search_key
		{
			get { return this.search_keyField; }
			set { this.search_keyField = value; }
		}
	};

}
