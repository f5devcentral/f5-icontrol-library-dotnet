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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.ProfileAuthBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileString))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileAuthenticationMethod))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileAuthProfileAuthStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileCredentialSource))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileULong))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileProfileMode))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileStatisticsByVirtual))]
	public partial class LocalLBProfileAuth : iControlInterface {
		public LocalLBProfileAuth() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAuth", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAuth", ResponseNamespace="urn:iControl:LocalLB/ProfileAuth")]
	public void create(
		string [] profile_names,
		LocalLBProfileString [] config_names,
		LocalLBProfileAuthenticationMethod [] auth_methods
	) {
		this.Invoke("create", new object [] {
				profile_names,
				config_names,
				auth_methods});

	}
	public System.IAsyncResult Begincreate(string [] profile_names,LocalLBProfileString [] config_names,LocalLBProfileAuthenticationMethod [] auth_methods, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			profile_names,
			config_names,
			auth_methods}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_profiles
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAuth", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAuth", ResponseNamespace="urn:iControl:LocalLB/ProfileAuth")]
	public void delete_all_profiles(

	) {
		this.Invoke("delete_all_profiles", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_profiles(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_profiles", new object[0], callback, asyncState);
	}
	public void Enddelete_all_profiles(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAuth", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAuth", ResponseNamespace="urn:iControl:LocalLB/ProfileAuth")]
	public void delete_profile(
		string [] profile_names
	) {
		this.Invoke("delete_profile", new object [] {
				profile_names});

	}
	public System.IAsyncResult Begindelete_profile(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_profile", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Enddelete_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAuth", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAuth", ResponseNamespace="urn:iControl:LocalLB/ProfileAuth")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileAuthProfileAuthStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((LocalLBProfileAuthProfileAuthStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public LocalLBProfileAuthProfileAuthStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileAuthProfileAuthStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_authentication_method
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAuth", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAuth", ResponseNamespace="urn:iControl:LocalLB/ProfileAuth")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileAuthenticationMethod [] get_authentication_method(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_authentication_method", new object [] {
				profile_names});
		return ((LocalLBProfileAuthenticationMethod [])(results[0]));
	}
	public System.IAsyncResult Beginget_authentication_method(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_authentication_method", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileAuthenticationMethod [] Endget_authentication_method(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileAuthenticationMethod [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_configuration_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAuth", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAuth", ResponseNamespace="urn:iControl:LocalLB/ProfileAuth")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_configuration_name(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_configuration_name", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_configuration_name(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_configuration_name", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_configuration_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_credential_source
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAuth", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAuth", ResponseNamespace="urn:iControl:LocalLB/ProfileAuth")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileCredentialSource [] get_credential_source(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_credential_source", new object [] {
				profile_names});
		return ((LocalLBProfileCredentialSource [])(results[0]));
	}
	public System.IAsyncResult Beginget_credential_source(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_credential_source", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileCredentialSource [] Endget_credential_source(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileCredentialSource [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAuth", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAuth", ResponseNamespace="urn:iControl:LocalLB/ProfileAuth")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_default_profile(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_default_profile", new object [] {
				profile_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_default_profile(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_default_profile", new object[] {
			profile_names}, callback, asyncState);
	}
	public string [] Endget_default_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAuth", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAuth", ResponseNamespace="urn:iControl:LocalLB/ProfileAuth")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_description", new object [] {
				profile_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			profile_names}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_idle_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAuth", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAuth", ResponseNamespace="urn:iControl:LocalLB/ProfileAuth")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_idle_timeout(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_idle_timeout", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_idle_timeout(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_idle_timeout", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_idle_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAuth", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAuth", ResponseNamespace="urn:iControl:LocalLB/ProfileAuth")]
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
	// get_profile_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAuth", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAuth", ResponseNamespace="urn:iControl:LocalLB/ProfileAuth")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileProfileMode [] get_profile_mode(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_profile_mode", new object [] {
				profile_names});
		return ((LocalLBProfileProfileMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_profile_mode(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_profile_mode", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileProfileMode [] Endget_profile_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileProfileMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rule_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAuth", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAuth", ResponseNamespace="urn:iControl:LocalLB/ProfileAuth")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_rule_name(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_rule_name", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_rule_name(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rule_name", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_rule_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAuth", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAuth", ResponseNamespace="urn:iControl:LocalLB/ProfileAuth")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileAuthProfileAuthStatistics get_statistics(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				profile_names});
		return ((LocalLBProfileAuthProfileAuthStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileAuthProfileAuthStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileAuthProfileAuthStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics_by_virtual
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAuth", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAuth", ResponseNamespace="urn:iControl:LocalLB/ProfileAuth")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileStatisticsByVirtual get_statistics_by_virtual(
		string [] profile_names,
		string [] [] virtual_names
	) {
		object [] results = this.Invoke("get_statistics_by_virtual", new object [] {
				profile_names,
				virtual_names});
		return ((LocalLBProfileStatisticsByVirtual)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics_by_virtual(string [] profile_names,string [] [] virtual_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics_by_virtual", new object[] {
			profile_names,
			virtual_names}, callback, asyncState);
	}
	public LocalLBProfileStatisticsByVirtual Endget_statistics_by_virtual(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileStatisticsByVirtual)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAuth", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAuth", ResponseNamespace="urn:iControl:LocalLB/ProfileAuth")]
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
	// is_base_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAuth", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAuth", ResponseNamespace="urn:iControl:LocalLB/ProfileAuth")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] is_base_profile(
		string [] profile_names
	) {
		object [] results = this.Invoke("is_base_profile", new object [] {
				profile_names});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginis_base_profile(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("is_base_profile", new object[] {
			profile_names}, callback, asyncState);
	}
	public bool [] Endis_base_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// is_system_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAuth", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAuth", ResponseNamespace="urn:iControl:LocalLB/ProfileAuth")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] is_system_profile(
		string [] profile_names
	) {
		object [] results = this.Invoke("is_system_profile", new object [] {
				profile_names});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginis_system_profile(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("is_system_profile", new object[] {
			profile_names}, callback, asyncState);
	}
	public bool [] Endis_system_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAuth", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAuth", ResponseNamespace="urn:iControl:LocalLB/ProfileAuth")]
	public void reset_statistics(
		string [] profile_names
	) {
		this.Invoke("reset_statistics", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginreset_statistics(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endreset_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics_by_virtual
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAuth", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAuth", ResponseNamespace="urn:iControl:LocalLB/ProfileAuth")]
	public void reset_statistics_by_virtual(
		string [] profile_names,
		string [] [] virtual_names
	) {
		this.Invoke("reset_statistics_by_virtual", new object [] {
				profile_names,
				virtual_names});

	}
	public System.IAsyncResult Beginreset_statistics_by_virtual(string [] profile_names,string [] [] virtual_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics_by_virtual", new object[] {
			profile_names,
			virtual_names}, callback, asyncState);
	}
	public void Endreset_statistics_by_virtual(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_authentication_method
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAuth", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAuth", ResponseNamespace="urn:iControl:LocalLB/ProfileAuth")]
	public void set_authentication_method(
		string [] profile_names,
		LocalLBProfileAuthenticationMethod [] auth_methods
	) {
		this.Invoke("set_authentication_method", new object [] {
				profile_names,
				auth_methods});

	}
	public System.IAsyncResult Beginset_authentication_method(string [] profile_names,LocalLBProfileAuthenticationMethod [] auth_methods, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_authentication_method", new object[] {
			profile_names,
			auth_methods}, callback, asyncState);
	}
	public void Endset_authentication_method(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_configuration_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAuth", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAuth", ResponseNamespace="urn:iControl:LocalLB/ProfileAuth")]
	public void set_configuration_name(
		string [] profile_names,
		LocalLBProfileString [] config_names
	) {
		this.Invoke("set_configuration_name", new object [] {
				profile_names,
				config_names});

	}
	public System.IAsyncResult Beginset_configuration_name(string [] profile_names,LocalLBProfileString [] config_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_configuration_name", new object[] {
			profile_names,
			config_names}, callback, asyncState);
	}
	public void Endset_configuration_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_credential_source
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAuth", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAuth", ResponseNamespace="urn:iControl:LocalLB/ProfileAuth")]
	public void set_credential_source(
		string [] profile_names,
		LocalLBProfileCredentialSource [] sources
	) {
		this.Invoke("set_credential_source", new object [] {
				profile_names,
				sources});

	}
	public System.IAsyncResult Beginset_credential_source(string [] profile_names,LocalLBProfileCredentialSource [] sources, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_credential_source", new object[] {
			profile_names,
			sources}, callback, asyncState);
	}
	public void Endset_credential_source(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAuth", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAuth", ResponseNamespace="urn:iControl:LocalLB/ProfileAuth")]
	public void set_default_profile(
		string [] profile_names,
		string [] defaults
	) {
		this.Invoke("set_default_profile", new object [] {
				profile_names,
				defaults});

	}
	public System.IAsyncResult Beginset_default_profile(string [] profile_names,string [] defaults, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_profile", new object[] {
			profile_names,
			defaults}, callback, asyncState);
	}
	public void Endset_default_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAuth", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAuth", ResponseNamespace="urn:iControl:LocalLB/ProfileAuth")]
	public void set_description(
		string [] profile_names,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				profile_names,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] profile_names,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			profile_names,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_idle_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAuth", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAuth", ResponseNamespace="urn:iControl:LocalLB/ProfileAuth")]
	public void set_idle_timeout(
		string [] profile_names,
		LocalLBProfileULong [] timeouts
	) {
		this.Invoke("set_idle_timeout", new object [] {
				profile_names,
				timeouts});

	}
	public System.IAsyncResult Beginset_idle_timeout(string [] profile_names,LocalLBProfileULong [] timeouts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_idle_timeout", new object[] {
			profile_names,
			timeouts}, callback, asyncState);
	}
	public void Endset_idle_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_profile_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAuth", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAuth", ResponseNamespace="urn:iControl:LocalLB/ProfileAuth")]
	public void set_profile_mode(
		string [] profile_names,
		LocalLBProfileProfileMode [] modes
	) {
		this.Invoke("set_profile_mode", new object [] {
				profile_names,
				modes});

	}
	public System.IAsyncResult Beginset_profile_mode(string [] profile_names,LocalLBProfileProfileMode [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_profile_mode", new object[] {
			profile_names,
			modes}, callback, asyncState);
	}
	public void Endset_profile_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rule_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileAuth", 
		RequestNamespace="urn:iControl:LocalLB/ProfileAuth", ResponseNamespace="urn:iControl:LocalLB/ProfileAuth")]
	public void set_rule_name(
		string [] profile_names,
		LocalLBProfileString [] rule_names
	) {
		this.Invoke("set_rule_name", new object [] {
				profile_names,
				rule_names});

	}
	public System.IAsyncResult Beginset_rule_name(string [] profile_names,LocalLBProfileString [] rule_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rule_name", new object[] {
			profile_names,
			rule_names}, callback, asyncState);
	}
	public void Endset_rule_name(System.IAsyncResult asyncResult) {
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileAuth.ProfileAuthStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBProfileAuthProfileAuthStatisticEntry
	{
		private string profile_nameField;
		public string profile_name
		{
			get { return this.profile_nameField; }
			set { this.profile_nameField = value; }
		}
		private CommonStatistic [] statisticsField;
		public CommonStatistic [] statistics
		{
			get { return this.statisticsField; }
			set { this.statisticsField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileAuth.ProfileAuthStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBProfileAuthProfileAuthStatistics
	{
		private LocalLBProfileAuthProfileAuthStatisticEntry [] statisticsField;
		public LocalLBProfileAuthProfileAuthStatisticEntry [] statistics
		{
			get { return this.statisticsField; }
			set { this.statisticsField = value; }
		}
		private CommonTimeStamp time_stampField;
		public CommonTimeStamp time_stamp
		{
			get { return this.time_stampField; }
			set { this.time_stampField = value; }
		}
	};

}
