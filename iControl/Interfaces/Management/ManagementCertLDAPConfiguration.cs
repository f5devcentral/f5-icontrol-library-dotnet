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
	[System.Web.Services.WebServiceBindingAttribute(Name="Management.CertLDAPConfigurationBinding", Namespace="urn:iControl")]
	public partial class ManagementCertLDAPConfiguration : iControlInterface {
		public ManagementCertLDAPConfiguration() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	public void create(
		string [] config_names,
		string [] search_base_dns,
		string [] [] servers
	) {
		this.Invoke("create", new object [] {
				config_names,
				search_base_dns,
				servers});

	}
	public System.IAsyncResult Begincreate(string [] config_names,string [] search_base_dns,string [] [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			config_names,
			search_base_dns,
			servers}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create_default_authentication_ad_configuration
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	public void create_default_authentication_ad_configuration(
		string search_base_dn,
		string [] servers
	) {
		this.Invoke("create_default_authentication_ad_configuration", new object [] {
				search_base_dn,
				servers});

	}
	public System.IAsyncResult Begincreate_default_authentication_ad_configuration(string search_base_dn,string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_default_authentication_ad_configuration", new object[] {
			search_base_dn,
			servers}, callback, asyncState);
	}
	public void Endcreate_default_authentication_ad_configuration(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create_default_authentication_ldap_configuration
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	public void create_default_authentication_ldap_configuration(
		string search_base_dn,
		string [] servers
	) {
		this.Invoke("create_default_authentication_ldap_configuration", new object [] {
				search_base_dn,
				servers});

	}
	public System.IAsyncResult Begincreate_default_authentication_ldap_configuration(string search_base_dn,string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_default_authentication_ldap_configuration", new object[] {
			search_base_dn,
			servers}, callback, asyncState);
	}
	public void Endcreate_default_authentication_ldap_configuration(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_configurations
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
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
	// get_bind_distinguished_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_bind_distinguished_name(
		string [] config_names
	) {
		object [] results = this.Invoke("get_bind_distinguished_name", new object [] {
				config_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_bind_distinguished_name(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_bind_distinguished_name", new object[] {
			config_names}, callback, asyncState);
	}
	public string [] Endget_bind_distinguished_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_bind_password
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_bind_password(
		string [] config_names
	) {
		object [] results = this.Invoke("get_bind_password", new object [] {
				config_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_bind_password(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_bind_password", new object[] {
			config_names}, callback, asyncState);
	}
	public string [] Endget_bind_password(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_bind_time_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_bind_time_limit(
		string [] config_names
	) {
		object [] results = this.Invoke("get_bind_time_limit", new object [] {
				config_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_bind_time_limit(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_bind_time_limit", new object[] {
			config_names}, callback, asyncState);
	}
	public long [] Endget_bind_time_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_check_host_attribute_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_check_host_attribute_state(
		string [] config_names
	) {
		object [] results = this.Invoke("get_check_host_attribute_state", new object [] {
				config_names});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_check_host_attribute_state(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_check_host_attribute_state", new object[] {
			config_names}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_check_host_attribute_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_check_roles_group_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_check_roles_group_state(
		string [] config_names
	) {
		object [] results = this.Invoke("get_check_roles_group_state", new object [] {
				config_names});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_check_roles_group_state(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_check_roles_group_state", new object[] {
			config_names}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_check_roles_group_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_debug_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
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
	// get_filter
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_filter(
		string [] config_names
	) {
		object [] results = this.Invoke("get_filter", new object [] {
				config_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_filter(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_filter", new object[] {
			config_names}, callback, asyncState);
	}
	public string [] Endget_filter(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_idle_time_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_idle_time_limit(
		string [] config_names
	) {
		object [] results = this.Invoke("get_idle_time_limit", new object [] {
				config_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_idle_time_limit(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_idle_time_limit", new object[] {
			config_names}, callback, asyncState);
	}
	public long [] Endget_idle_time_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ignore_unavailable_authentication_information_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_ignore_unavailable_authentication_information_state(
		string [] config_names
	) {
		object [] results = this.Invoke("get_ignore_unavailable_authentication_information_state", new object [] {
				config_names});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_ignore_unavailable_authentication_information_state(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ignore_unavailable_authentication_information_state", new object[] {
			config_names}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_ignore_unavailable_authentication_information_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ldap_ssl_option
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementLDAPSSLOption [] get_ldap_ssl_option(
		string [] config_names
	) {
		object [] results = this.Invoke("get_ldap_ssl_option", new object [] {
				config_names});
		return ((ManagementLDAPSSLOption [])(results[0]));
	}
	public System.IAsyncResult Beginget_ldap_ssl_option(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ldap_ssl_option", new object[] {
			config_names}, callback, asyncState);
	}
	public ManagementLDAPSSLOption [] Endget_ldap_ssl_option(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementLDAPSSLOption [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ldap_sso_option
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementLDAPSSOOption [] get_ldap_sso_option(
		string [] config_names
	) {
		object [] results = this.Invoke("get_ldap_sso_option", new object [] {
				config_names});
		return ((ManagementLDAPSSOOption [])(results[0]));
	}
	public System.IAsyncResult Beginget_ldap_sso_option(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ldap_sso_option", new object[] {
			config_names}, callback, asyncState);
	}
	public ManagementLDAPSSOOption [] Endget_ldap_sso_option(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementLDAPSSOOption [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ldap_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_ldap_version(
		string [] config_names
	) {
		object [] results = this.Invoke("get_ldap_version", new object [] {
				config_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_ldap_version(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ldap_version", new object[] {
			config_names}, callback, asyncState);
	}
	public long [] Endget_ldap_version(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
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
	// get_login_attribute
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_login_attribute(
		string [] config_names
	) {
		object [] results = this.Invoke("get_login_attribute", new object [] {
				config_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_login_attribute(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_login_attribute", new object[] {
			config_names}, callback, asyncState);
	}
	public string [] Endget_login_attribute(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_login_filter
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_login_filter(
		string [] config_names
	) {
		object [] results = this.Invoke("get_login_filter", new object [] {
				config_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_login_filter(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_login_filter", new object[] {
			config_names}, callback, asyncState);
	}
	public string [] Endget_login_filter(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_login_name_attribute
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_login_name_attribute(
		string [] config_names
	) {
		object [] results = this.Invoke("get_login_name_attribute", new object [] {
				config_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_login_name_attribute(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_login_name_attribute", new object[] {
			config_names}, callback, asyncState);
	}
	public string [] Endget_login_name_attribute(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_port(
		string [] config_names
	) {
		object [] results = this.Invoke("get_port", new object [] {
				config_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_port(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_port", new object[] {
			config_names}, callback, asyncState);
	}
	public long [] Endget_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_search_base_distinguished_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_search_base_distinguished_name(
		string [] config_names
	) {
		object [] results = this.Invoke("get_search_base_distinguished_name", new object [] {
				config_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_search_base_distinguished_name(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_search_base_distinguished_name", new object[] {
			config_names}, callback, asyncState);
	}
	public string [] Endget_search_base_distinguished_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_search_scope
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementLDAPSearchScope [] get_search_scope(
		string [] config_names
	) {
		object [] results = this.Invoke("get_search_scope", new object [] {
				config_names});
		return ((ManagementLDAPSearchScope [])(results[0]));
	}
	public System.IAsyncResult Beginget_search_scope(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_search_scope", new object[] {
			config_names}, callback, asyncState);
	}
	public ManagementLDAPSearchScope [] Endget_search_scope(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementLDAPSearchScope [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_search_time_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_search_time_limit(
		string [] config_names
	) {
		object [] results = this.Invoke("get_search_time_limit", new object [] {
				config_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_search_time_limit(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_search_time_limit", new object[] {
			config_names}, callback, asyncState);
	}
	public long [] Endget_search_time_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
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
	// get_ssl_ca_certificate_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_ssl_ca_certificate_file(
		string [] config_names
	) {
		object [] results = this.Invoke("get_ssl_ca_certificate_file", new object [] {
				config_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_ssl_ca_certificate_file(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ssl_ca_certificate_file", new object[] {
			config_names}, callback, asyncState);
	}
	public string [] Endget_ssl_ca_certificate_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ssl_check_peer_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_ssl_check_peer_state(
		string [] config_names
	) {
		object [] results = this.Invoke("get_ssl_check_peer_state", new object [] {
				config_names});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_ssl_check_peer_state(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ssl_check_peer_state", new object[] {
			config_names}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_ssl_check_peer_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ssl_cipher
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_ssl_cipher(
		string [] config_names
	) {
		object [] results = this.Invoke("get_ssl_cipher", new object [] {
				config_names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_ssl_cipher(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ssl_cipher", new object[] {
			config_names}, callback, asyncState);
	}
	public string [] [] Endget_ssl_cipher(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ssl_client_certificate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_ssl_client_certificate(
		string [] config_names
	) {
		object [] results = this.Invoke("get_ssl_client_certificate", new object [] {
				config_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_ssl_client_certificate(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ssl_client_certificate", new object[] {
			config_names}, callback, asyncState);
	}
	public string [] Endget_ssl_client_certificate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ssl_client_key
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_ssl_client_key(
		string [] config_names
	) {
		object [] results = this.Invoke("get_ssl_client_key", new object [] {
				config_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_ssl_client_key(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ssl_client_key", new object[] {
			config_names}, callback, asyncState);
	}
	public string [] Endget_ssl_client_key(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
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
	// get_warning_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_warning_state(
		string [] config_names
	) {
		object [] results = this.Invoke("get_warning_state", new object [] {
				config_names});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_warning_state(string [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_warning_state", new object[] {
			config_names}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_warning_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// remove_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
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
	// set_bind_distinguished_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	public void set_bind_distinguished_name(
		string [] config_names,
		string [] bind_dns
	) {
		this.Invoke("set_bind_distinguished_name", new object [] {
				config_names,
				bind_dns});

	}
	public System.IAsyncResult Beginset_bind_distinguished_name(string [] config_names,string [] bind_dns, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_bind_distinguished_name", new object[] {
			config_names,
			bind_dns}, callback, asyncState);
	}
	public void Endset_bind_distinguished_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_bind_password
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	public void set_bind_password(
		string [] config_names,
		string [] bind_passwords
	) {
		this.Invoke("set_bind_password", new object [] {
				config_names,
				bind_passwords});

	}
	public System.IAsyncResult Beginset_bind_password(string [] config_names,string [] bind_passwords, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_bind_password", new object[] {
			config_names,
			bind_passwords}, callback, asyncState);
	}
	public void Endset_bind_password(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_bind_time_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	public void set_bind_time_limit(
		string [] config_names,
		long [] time_limits
	) {
		this.Invoke("set_bind_time_limit", new object [] {
				config_names,
				time_limits});

	}
	public System.IAsyncResult Beginset_bind_time_limit(string [] config_names,long [] time_limits, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_bind_time_limit", new object[] {
			config_names,
			time_limits}, callback, asyncState);
	}
	public void Endset_bind_time_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_check_host_attribute_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	public void set_check_host_attribute_state(
		string [] config_names,
		CommonEnabledState [] states
	) {
		this.Invoke("set_check_host_attribute_state", new object [] {
				config_names,
				states});

	}
	public System.IAsyncResult Beginset_check_host_attribute_state(string [] config_names,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_check_host_attribute_state", new object[] {
			config_names,
			states}, callback, asyncState);
	}
	public void Endset_check_host_attribute_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_check_roles_group_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	public void set_check_roles_group_state(
		string [] config_names,
		CommonEnabledState [] states
	) {
		this.Invoke("set_check_roles_group_state", new object [] {
				config_names,
				states});

	}
	public System.IAsyncResult Beginset_check_roles_group_state(string [] config_names,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_check_roles_group_state", new object[] {
			config_names,
			states}, callback, asyncState);
	}
	public void Endset_check_roles_group_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_debug_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
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
	// set_filter
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	public void set_filter(
		string [] config_names,
		string [] filters
	) {
		this.Invoke("set_filter", new object [] {
				config_names,
				filters});

	}
	public System.IAsyncResult Beginset_filter(string [] config_names,string [] filters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_filter", new object[] {
			config_names,
			filters}, callback, asyncState);
	}
	public void Endset_filter(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_idle_time_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	public void set_idle_time_limit(
		string [] config_names,
		long [] time_limits
	) {
		this.Invoke("set_idle_time_limit", new object [] {
				config_names,
				time_limits});

	}
	public System.IAsyncResult Beginset_idle_time_limit(string [] config_names,long [] time_limits, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_idle_time_limit", new object[] {
			config_names,
			time_limits}, callback, asyncState);
	}
	public void Endset_idle_time_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ignore_unavailable_authentication_information_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	public void set_ignore_unavailable_authentication_information_state(
		string [] config_names,
		CommonEnabledState [] states
	) {
		this.Invoke("set_ignore_unavailable_authentication_information_state", new object [] {
				config_names,
				states});

	}
	public System.IAsyncResult Beginset_ignore_unavailable_authentication_information_state(string [] config_names,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ignore_unavailable_authentication_information_state", new object[] {
			config_names,
			states}, callback, asyncState);
	}
	public void Endset_ignore_unavailable_authentication_information_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ldap_ssl_option
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	public void set_ldap_ssl_option(
		string [] config_names,
		ManagementLDAPSSLOption [] options
	) {
		this.Invoke("set_ldap_ssl_option", new object [] {
				config_names,
				options});

	}
	public System.IAsyncResult Beginset_ldap_ssl_option(string [] config_names,ManagementLDAPSSLOption [] options, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ldap_ssl_option", new object[] {
			config_names,
			options}, callback, asyncState);
	}
	public void Endset_ldap_ssl_option(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ldap_sso_option
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	public void set_ldap_sso_option(
		string [] config_names,
		ManagementLDAPSSOOption [] options
	) {
		this.Invoke("set_ldap_sso_option", new object [] {
				config_names,
				options});

	}
	public System.IAsyncResult Beginset_ldap_sso_option(string [] config_names,ManagementLDAPSSOOption [] options, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ldap_sso_option", new object[] {
			config_names,
			options}, callback, asyncState);
	}
	public void Endset_ldap_sso_option(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ldap_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	public void set_ldap_version(
		string [] config_names,
		long [] versions
	) {
		this.Invoke("set_ldap_version", new object [] {
				config_names,
				versions});

	}
	public System.IAsyncResult Beginset_ldap_version(string [] config_names,long [] versions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ldap_version", new object[] {
			config_names,
			versions}, callback, asyncState);
	}
	public void Endset_ldap_version(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_login_attribute
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	public void set_login_attribute(
		string [] config_names,
		string [] login_attributes
	) {
		this.Invoke("set_login_attribute", new object [] {
				config_names,
				login_attributes});

	}
	public System.IAsyncResult Beginset_login_attribute(string [] config_names,string [] login_attributes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_login_attribute", new object[] {
			config_names,
			login_attributes}, callback, asyncState);
	}
	public void Endset_login_attribute(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_login_filter
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	public void set_login_filter(
		string [] config_names,
		string [] filters
	) {
		this.Invoke("set_login_filter", new object [] {
				config_names,
				filters});

	}
	public System.IAsyncResult Beginset_login_filter(string [] config_names,string [] filters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_login_filter", new object[] {
			config_names,
			filters}, callback, asyncState);
	}
	public void Endset_login_filter(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_login_name_attribute
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	public void set_login_name_attribute(
		string [] config_names,
		string [] attributes
	) {
		this.Invoke("set_login_name_attribute", new object [] {
				config_names,
				attributes});

	}
	public System.IAsyncResult Beginset_login_name_attribute(string [] config_names,string [] attributes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_login_name_attribute", new object[] {
			config_names,
			attributes}, callback, asyncState);
	}
	public void Endset_login_name_attribute(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	public void set_port(
		string [] config_names,
		long [] ports
	) {
		this.Invoke("set_port", new object [] {
				config_names,
				ports});

	}
	public System.IAsyncResult Beginset_port(string [] config_names,long [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_port", new object[] {
			config_names,
			ports}, callback, asyncState);
	}
	public void Endset_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_search_base_distinguished_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	public void set_search_base_distinguished_name(
		string [] config_names,
		string [] search_base_dns
	) {
		this.Invoke("set_search_base_distinguished_name", new object [] {
				config_names,
				search_base_dns});

	}
	public System.IAsyncResult Beginset_search_base_distinguished_name(string [] config_names,string [] search_base_dns, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_search_base_distinguished_name", new object[] {
			config_names,
			search_base_dns}, callback, asyncState);
	}
	public void Endset_search_base_distinguished_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_search_scope
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	public void set_search_scope(
		string [] config_names,
		ManagementLDAPSearchScope [] search_scopes
	) {
		this.Invoke("set_search_scope", new object [] {
				config_names,
				search_scopes});

	}
	public System.IAsyncResult Beginset_search_scope(string [] config_names,ManagementLDAPSearchScope [] search_scopes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_search_scope", new object[] {
			config_names,
			search_scopes}, callback, asyncState);
	}
	public void Endset_search_scope(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_search_time_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	public void set_search_time_limit(
		string [] config_names,
		long [] time_limits
	) {
		this.Invoke("set_search_time_limit", new object [] {
				config_names,
				time_limits});

	}
	public System.IAsyncResult Beginset_search_time_limit(string [] config_names,long [] time_limits, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_search_time_limit", new object[] {
			config_names,
			time_limits}, callback, asyncState);
	}
	public void Endset_search_time_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ssl_ca_certificate_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	public void set_ssl_ca_certificate_file(
		string [] config_names,
		string [] ca_cert_files
	) {
		this.Invoke("set_ssl_ca_certificate_file", new object [] {
				config_names,
				ca_cert_files});

	}
	public System.IAsyncResult Beginset_ssl_ca_certificate_file(string [] config_names,string [] ca_cert_files, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ssl_ca_certificate_file", new object[] {
			config_names,
			ca_cert_files}, callback, asyncState);
	}
	public void Endset_ssl_ca_certificate_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ssl_check_peer_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	public void set_ssl_check_peer_state(
		string [] config_names,
		CommonEnabledState [] states
	) {
		this.Invoke("set_ssl_check_peer_state", new object [] {
				config_names,
				states});

	}
	public System.IAsyncResult Beginset_ssl_check_peer_state(string [] config_names,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ssl_check_peer_state", new object[] {
			config_names,
			states}, callback, asyncState);
	}
	public void Endset_ssl_check_peer_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ssl_cipher
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	public void set_ssl_cipher(
		string [] config_names,
		string [] [] ciphers
	) {
		this.Invoke("set_ssl_cipher", new object [] {
				config_names,
				ciphers});

	}
	public System.IAsyncResult Beginset_ssl_cipher(string [] config_names,string [] [] ciphers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ssl_cipher", new object[] {
			config_names,
			ciphers}, callback, asyncState);
	}
	public void Endset_ssl_cipher(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ssl_client_certificate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	public void set_ssl_client_certificate(
		string [] config_names,
		string [] certificates
	) {
		this.Invoke("set_ssl_client_certificate", new object [] {
				config_names,
				certificates});

	}
	public System.IAsyncResult Beginset_ssl_client_certificate(string [] config_names,string [] certificates, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ssl_client_certificate", new object[] {
			config_names,
			certificates}, callback, asyncState);
	}
	public void Endset_ssl_client_certificate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ssl_client_key
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	public void set_ssl_client_key(
		string [] config_names,
		string [] keys
	) {
		this.Invoke("set_ssl_client_key", new object [] {
				config_names,
				keys});

	}
	public System.IAsyncResult Beginset_ssl_client_key(string [] config_names,string [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ssl_client_key", new object[] {
			config_names,
			keys}, callback, asyncState);
	}
	public void Endset_ssl_client_key(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_warning_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertLDAPConfiguration", 
		RequestNamespace="urn:iControl:Management/CertLDAPConfiguration", ResponseNamespace="urn:iControl:Management/CertLDAPConfiguration")]
	public void set_warning_state(
		string [] config_names,
		CommonEnabledState [] states
	) {
		this.Invoke("set_warning_state", new object [] {
				config_names,
				states});

	}
	public System.IAsyncResult Beginset_warning_state(string [] config_names,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_warning_state", new object[] {
			config_names,
			states}, callback, asyncState);
	}
	public void Endset_warning_state(System.IAsyncResult asyncResult) {
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
