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
	[System.Web.Services.WebServiceBindingAttribute(Name="Security.ProfileIPIntelligenceBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SecurityProfileIPIntelligenceProfileIPIntelligenceStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SecurityProfileIPIntelligenceProfileAction))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonProfileStatisticsByVirtual))]
	public partial class SecurityProfileIPIntelligence : iControlInterface {
		public SecurityProfileIPIntelligence() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileIPIntelligence", 
		RequestNamespace="urn:iControl:Security/ProfileIPIntelligence", ResponseNamespace="urn:iControl:Security/ProfileIPIntelligence")]
	public void create(
		string [] profile_names
	) {
		this.Invoke("create", new object [] {
				profile_names});

	}
	public System.IAsyncResult Begincreate(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_profiles
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileIPIntelligence", 
		RequestNamespace="urn:iControl:Security/ProfileIPIntelligence", ResponseNamespace="urn:iControl:Security/ProfileIPIntelligence")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileIPIntelligence", 
		RequestNamespace="urn:iControl:Security/ProfileIPIntelligence", ResponseNamespace="urn:iControl:Security/ProfileIPIntelligence")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileIPIntelligence", 
		RequestNamespace="urn:iControl:Security/ProfileIPIntelligence", ResponseNamespace="urn:iControl:Security/ProfileIPIntelligence")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityProfileIPIntelligenceProfileIPIntelligenceStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((SecurityProfileIPIntelligenceProfileIPIntelligenceStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public SecurityProfileIPIntelligenceProfileIPIntelligenceStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityProfileIPIntelligenceProfileIPIntelligenceStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_botnets_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileIPIntelligence", 
		RequestNamespace="urn:iControl:Security/ProfileIPIntelligence", ResponseNamespace="urn:iControl:Security/ProfileIPIntelligence")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityProfileIPIntelligenceProfileAction [] get_botnets_action(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_botnets_action", new object [] {
				profile_names});
		return ((SecurityProfileIPIntelligenceProfileAction [])(results[0]));
	}
	public System.IAsyncResult Beginget_botnets_action(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_botnets_action", new object[] {
			profile_names}, callback, asyncState);
	}
	public SecurityProfileIPIntelligenceProfileAction [] Endget_botnets_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityProfileIPIntelligenceProfileAction [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileIPIntelligence", 
		RequestNamespace="urn:iControl:Security/ProfileIPIntelligence", ResponseNamespace="urn:iControl:Security/ProfileIPIntelligence")]
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
	// get_denial_of_service_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileIPIntelligence", 
		RequestNamespace="urn:iControl:Security/ProfileIPIntelligence", ResponseNamespace="urn:iControl:Security/ProfileIPIntelligence")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityProfileIPIntelligenceProfileAction [] get_denial_of_service_action(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_denial_of_service_action", new object [] {
				profile_names});
		return ((SecurityProfileIPIntelligenceProfileAction [])(results[0]));
	}
	public System.IAsyncResult Beginget_denial_of_service_action(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_denial_of_service_action", new object[] {
			profile_names}, callback, asyncState);
	}
	public SecurityProfileIPIntelligenceProfileAction [] Endget_denial_of_service_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityProfileIPIntelligenceProfileAction [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileIPIntelligence", 
		RequestNamespace="urn:iControl:Security/ProfileIPIntelligence", ResponseNamespace="urn:iControl:Security/ProfileIPIntelligence")]
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
	// get_infected_sources_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileIPIntelligence", 
		RequestNamespace="urn:iControl:Security/ProfileIPIntelligence", ResponseNamespace="urn:iControl:Security/ProfileIPIntelligence")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityProfileIPIntelligenceProfileAction [] get_infected_sources_action(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_infected_sources_action", new object [] {
				profile_names});
		return ((SecurityProfileIPIntelligenceProfileAction [])(results[0]));
	}
	public System.IAsyncResult Beginget_infected_sources_action(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_infected_sources_action", new object[] {
			profile_names}, callback, asyncState);
	}
	public SecurityProfileIPIntelligenceProfileAction [] Endget_infected_sources_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityProfileIPIntelligenceProfileAction [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileIPIntelligence", 
		RequestNamespace="urn:iControl:Security/ProfileIPIntelligence", ResponseNamespace="urn:iControl:Security/ProfileIPIntelligence")]
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
	// get_phishing_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileIPIntelligence", 
		RequestNamespace="urn:iControl:Security/ProfileIPIntelligence", ResponseNamespace="urn:iControl:Security/ProfileIPIntelligence")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityProfileIPIntelligenceProfileAction [] get_phishing_action(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_phishing_action", new object [] {
				profile_names});
		return ((SecurityProfileIPIntelligenceProfileAction [])(results[0]));
	}
	public System.IAsyncResult Beginget_phishing_action(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_phishing_action", new object[] {
			profile_names}, callback, asyncState);
	}
	public SecurityProfileIPIntelligenceProfileAction [] Endget_phishing_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityProfileIPIntelligenceProfileAction [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_proxy_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileIPIntelligence", 
		RequestNamespace="urn:iControl:Security/ProfileIPIntelligence", ResponseNamespace="urn:iControl:Security/ProfileIPIntelligence")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityProfileIPIntelligenceProfileAction [] get_proxy_action(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_proxy_action", new object [] {
				profile_names});
		return ((SecurityProfileIPIntelligenceProfileAction [])(results[0]));
	}
	public System.IAsyncResult Beginget_proxy_action(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_proxy_action", new object[] {
			profile_names}, callback, asyncState);
	}
	public SecurityProfileIPIntelligenceProfileAction [] Endget_proxy_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityProfileIPIntelligenceProfileAction [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_scanners_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileIPIntelligence", 
		RequestNamespace="urn:iControl:Security/ProfileIPIntelligence", ResponseNamespace="urn:iControl:Security/ProfileIPIntelligence")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityProfileIPIntelligenceProfileAction [] get_scanners_action(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_scanners_action", new object [] {
				profile_names});
		return ((SecurityProfileIPIntelligenceProfileAction [])(results[0]));
	}
	public System.IAsyncResult Beginget_scanners_action(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_scanners_action", new object[] {
			profile_names}, callback, asyncState);
	}
	public SecurityProfileIPIntelligenceProfileAction [] Endget_scanners_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityProfileIPIntelligenceProfileAction [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_spam_sources_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileIPIntelligence", 
		RequestNamespace="urn:iControl:Security/ProfileIPIntelligence", ResponseNamespace="urn:iControl:Security/ProfileIPIntelligence")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityProfileIPIntelligenceProfileAction [] get_spam_sources_action(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_spam_sources_action", new object [] {
				profile_names});
		return ((SecurityProfileIPIntelligenceProfileAction [])(results[0]));
	}
	public System.IAsyncResult Beginget_spam_sources_action(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_spam_sources_action", new object[] {
			profile_names}, callback, asyncState);
	}
	public SecurityProfileIPIntelligenceProfileAction [] Endget_spam_sources_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityProfileIPIntelligenceProfileAction [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileIPIntelligence", 
		RequestNamespace="urn:iControl:Security/ProfileIPIntelligence", ResponseNamespace="urn:iControl:Security/ProfileIPIntelligence")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityProfileIPIntelligenceProfileIPIntelligenceStatistics get_statistics(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				profile_names});
		return ((SecurityProfileIPIntelligenceProfileIPIntelligenceStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			profile_names}, callback, asyncState);
	}
	public SecurityProfileIPIntelligenceProfileIPIntelligenceStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityProfileIPIntelligenceProfileIPIntelligenceStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics_by_virtual
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileIPIntelligence", 
		RequestNamespace="urn:iControl:Security/ProfileIPIntelligence", ResponseNamespace="urn:iControl:Security/ProfileIPIntelligence")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonProfileStatisticsByVirtual get_statistics_by_virtual(
		string [] profile_names,
		string [] [] virtual_names
	) {
		object [] results = this.Invoke("get_statistics_by_virtual", new object [] {
				profile_names,
				virtual_names});
		return ((CommonProfileStatisticsByVirtual)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics_by_virtual(string [] profile_names,string [] [] virtual_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics_by_virtual", new object[] {
			profile_names,
			virtual_names}, callback, asyncState);
	}
	public CommonProfileStatisticsByVirtual Endget_statistics_by_virtual(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonProfileStatisticsByVirtual)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileIPIntelligence", 
		RequestNamespace="urn:iControl:Security/ProfileIPIntelligence", ResponseNamespace="urn:iControl:Security/ProfileIPIntelligence")]
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
	// get_web_attacks_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileIPIntelligence", 
		RequestNamespace="urn:iControl:Security/ProfileIPIntelligence", ResponseNamespace="urn:iControl:Security/ProfileIPIntelligence")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityProfileIPIntelligenceProfileAction [] get_web_attacks_action(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_web_attacks_action", new object [] {
				profile_names});
		return ((SecurityProfileIPIntelligenceProfileAction [])(results[0]));
	}
	public System.IAsyncResult Beginget_web_attacks_action(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_web_attacks_action", new object[] {
			profile_names}, callback, asyncState);
	}
	public SecurityProfileIPIntelligenceProfileAction [] Endget_web_attacks_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityProfileIPIntelligenceProfileAction [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_windows_exploits_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileIPIntelligence", 
		RequestNamespace="urn:iControl:Security/ProfileIPIntelligence", ResponseNamespace="urn:iControl:Security/ProfileIPIntelligence")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityProfileIPIntelligenceProfileAction [] get_windows_exploits_action(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_windows_exploits_action", new object [] {
				profile_names});
		return ((SecurityProfileIPIntelligenceProfileAction [])(results[0]));
	}
	public System.IAsyncResult Beginget_windows_exploits_action(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_windows_exploits_action", new object[] {
			profile_names}, callback, asyncState);
	}
	public SecurityProfileIPIntelligenceProfileAction [] Endget_windows_exploits_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityProfileIPIntelligenceProfileAction [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// is_base_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileIPIntelligence", 
		RequestNamespace="urn:iControl:Security/ProfileIPIntelligence", ResponseNamespace="urn:iControl:Security/ProfileIPIntelligence")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileIPIntelligence", 
		RequestNamespace="urn:iControl:Security/ProfileIPIntelligence", ResponseNamespace="urn:iControl:Security/ProfileIPIntelligence")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileIPIntelligence", 
		RequestNamespace="urn:iControl:Security/ProfileIPIntelligence", ResponseNamespace="urn:iControl:Security/ProfileIPIntelligence")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileIPIntelligence", 
		RequestNamespace="urn:iControl:Security/ProfileIPIntelligence", ResponseNamespace="urn:iControl:Security/ProfileIPIntelligence")]
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
	// set_botnets_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileIPIntelligence", 
		RequestNamespace="urn:iControl:Security/ProfileIPIntelligence", ResponseNamespace="urn:iControl:Security/ProfileIPIntelligence")]
	public void set_botnets_action(
		string [] profile_names,
		SecurityProfileIPIntelligenceProfileAction [] actions
	) {
		this.Invoke("set_botnets_action", new object [] {
				profile_names,
				actions});

	}
	public System.IAsyncResult Beginset_botnets_action(string [] profile_names,SecurityProfileIPIntelligenceProfileAction [] actions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_botnets_action", new object[] {
			profile_names,
			actions}, callback, asyncState);
	}
	public void Endset_botnets_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileIPIntelligence", 
		RequestNamespace="urn:iControl:Security/ProfileIPIntelligence", ResponseNamespace="urn:iControl:Security/ProfileIPIntelligence")]
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
	// set_denial_of_service_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileIPIntelligence", 
		RequestNamespace="urn:iControl:Security/ProfileIPIntelligence", ResponseNamespace="urn:iControl:Security/ProfileIPIntelligence")]
	public void set_denial_of_service_action(
		string [] profile_names,
		SecurityProfileIPIntelligenceProfileAction [] actions
	) {
		this.Invoke("set_denial_of_service_action", new object [] {
				profile_names,
				actions});

	}
	public System.IAsyncResult Beginset_denial_of_service_action(string [] profile_names,SecurityProfileIPIntelligenceProfileAction [] actions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_denial_of_service_action", new object[] {
			profile_names,
			actions}, callback, asyncState);
	}
	public void Endset_denial_of_service_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileIPIntelligence", 
		RequestNamespace="urn:iControl:Security/ProfileIPIntelligence", ResponseNamespace="urn:iControl:Security/ProfileIPIntelligence")]
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
	// set_infected_sources_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileIPIntelligence", 
		RequestNamespace="urn:iControl:Security/ProfileIPIntelligence", ResponseNamespace="urn:iControl:Security/ProfileIPIntelligence")]
	public void set_infected_sources_action(
		string [] profile_names,
		SecurityProfileIPIntelligenceProfileAction [] actions
	) {
		this.Invoke("set_infected_sources_action", new object [] {
				profile_names,
				actions});

	}
	public System.IAsyncResult Beginset_infected_sources_action(string [] profile_names,SecurityProfileIPIntelligenceProfileAction [] actions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_infected_sources_action", new object[] {
			profile_names,
			actions}, callback, asyncState);
	}
	public void Endset_infected_sources_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_phishing_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileIPIntelligence", 
		RequestNamespace="urn:iControl:Security/ProfileIPIntelligence", ResponseNamespace="urn:iControl:Security/ProfileIPIntelligence")]
	public void set_phishing_action(
		string [] profile_names,
		SecurityProfileIPIntelligenceProfileAction [] actions
	) {
		this.Invoke("set_phishing_action", new object [] {
				profile_names,
				actions});

	}
	public System.IAsyncResult Beginset_phishing_action(string [] profile_names,SecurityProfileIPIntelligenceProfileAction [] actions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_phishing_action", new object[] {
			profile_names,
			actions}, callback, asyncState);
	}
	public void Endset_phishing_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_proxy_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileIPIntelligence", 
		RequestNamespace="urn:iControl:Security/ProfileIPIntelligence", ResponseNamespace="urn:iControl:Security/ProfileIPIntelligence")]
	public void set_proxy_action(
		string [] profile_names,
		SecurityProfileIPIntelligenceProfileAction [] actions
	) {
		this.Invoke("set_proxy_action", new object [] {
				profile_names,
				actions});

	}
	public System.IAsyncResult Beginset_proxy_action(string [] profile_names,SecurityProfileIPIntelligenceProfileAction [] actions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_proxy_action", new object[] {
			profile_names,
			actions}, callback, asyncState);
	}
	public void Endset_proxy_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_scanners_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileIPIntelligence", 
		RequestNamespace="urn:iControl:Security/ProfileIPIntelligence", ResponseNamespace="urn:iControl:Security/ProfileIPIntelligence")]
	public void set_scanners_action(
		string [] profile_names,
		SecurityProfileIPIntelligenceProfileAction [] actions
	) {
		this.Invoke("set_scanners_action", new object [] {
				profile_names,
				actions});

	}
	public System.IAsyncResult Beginset_scanners_action(string [] profile_names,SecurityProfileIPIntelligenceProfileAction [] actions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_scanners_action", new object[] {
			profile_names,
			actions}, callback, asyncState);
	}
	public void Endset_scanners_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_spam_sources_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileIPIntelligence", 
		RequestNamespace="urn:iControl:Security/ProfileIPIntelligence", ResponseNamespace="urn:iControl:Security/ProfileIPIntelligence")]
	public void set_spam_sources_action(
		string [] profile_names,
		SecurityProfileIPIntelligenceProfileAction [] actions
	) {
		this.Invoke("set_spam_sources_action", new object [] {
				profile_names,
				actions});

	}
	public System.IAsyncResult Beginset_spam_sources_action(string [] profile_names,SecurityProfileIPIntelligenceProfileAction [] actions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_spam_sources_action", new object[] {
			profile_names,
			actions}, callback, asyncState);
	}
	public void Endset_spam_sources_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_web_attacks_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileIPIntelligence", 
		RequestNamespace="urn:iControl:Security/ProfileIPIntelligence", ResponseNamespace="urn:iControl:Security/ProfileIPIntelligence")]
	public void set_web_attacks_action(
		string [] profile_names,
		SecurityProfileIPIntelligenceProfileAction [] actions
	) {
		this.Invoke("set_web_attacks_action", new object [] {
				profile_names,
				actions});

	}
	public System.IAsyncResult Beginset_web_attacks_action(string [] profile_names,SecurityProfileIPIntelligenceProfileAction [] actions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_web_attacks_action", new object[] {
			profile_names,
			actions}, callback, asyncState);
	}
	public void Endset_web_attacks_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_windows_exploits_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/ProfileIPIntelligence", 
		RequestNamespace="urn:iControl:Security/ProfileIPIntelligence", ResponseNamespace="urn:iControl:Security/ProfileIPIntelligence")]
	public void set_windows_exploits_action(
		string [] profile_names,
		SecurityProfileIPIntelligenceProfileAction [] actions
	) {
		this.Invoke("set_windows_exploits_action", new object [] {
				profile_names,
				actions});

	}
	public System.IAsyncResult Beginset_windows_exploits_action(string [] profile_names,SecurityProfileIPIntelligenceProfileAction [] actions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_windows_exploits_action", new object[] {
			profile_names,
			actions}, callback, asyncState);
	}
	public void Endset_windows_exploits_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Security.ProfileIPIntelligence.Action", Namespace = "urn:iControl")]
	public enum SecurityProfileIPIntelligenceAction
	{
		IP_INTELLIGENCE_ACTION_UNKNOWN,
		IP_INTELLIGENCE_ACTION_ACCEPT,
		IP_INTELLIGENCE_ACTION_WARN,
		IP_INTELLIGENCE_ACTION_REJECT,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Security.ProfileIPIntelligence.ProfileAction", Namespace = "urn:iControl")]
	public partial class SecurityProfileIPIntelligenceProfileAction
	{
		private SecurityProfileIPIntelligenceAction valueField;
		public SecurityProfileIPIntelligenceAction value
		{
			get { return this.valueField; }
			set { this.valueField = value; }
		}
		private bool default_flagField;
		public bool default_flag
		{
			get { return this.default_flagField; }
			set { this.default_flagField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Security.ProfileIPIntelligence.ProfileIPIntelligenceStatisticEntry", Namespace = "urn:iControl")]
	public partial class SecurityProfileIPIntelligenceProfileIPIntelligenceStatisticEntry
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Security.ProfileIPIntelligence.ProfileIPIntelligenceStatistics", Namespace = "urn:iControl")]
	public partial class SecurityProfileIPIntelligenceProfileIPIntelligenceStatistics
	{
		private SecurityProfileIPIntelligenceProfileIPIntelligenceStatisticEntry [] statisticsField;
		public SecurityProfileIPIntelligenceProfileIPIntelligenceStatisticEntry [] statistics
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
