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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.ProfileHttpClassBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBMatchPatternString))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileHttpClassProfileHttpClassStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileEnabledState))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileMatchPatternStringArray))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileString))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileStatisticsByVirtual))]
	public partial class LocalLBProfileHttpClass : iControlInterface {
		public LocalLBProfileHttpClass() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_cookie_match_pattern
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpClass", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpClass", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpClass")]
	public void add_cookie_match_pattern(
		string [] profile_names,
		LocalLBMatchPatternString [] [] patterns
	) {
		this.Invoke("add_cookie_match_pattern", new object [] {
				profile_names,
				patterns});

	}
	public System.IAsyncResult Beginadd_cookie_match_pattern(string [] profile_names,LocalLBMatchPatternString [] [] patterns, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_cookie_match_pattern", new object[] {
			profile_names,
			patterns}, callback, asyncState);
	}
	public void Endadd_cookie_match_pattern(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_header_match_pattern
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpClass", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpClass", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpClass")]
	public void add_header_match_pattern(
		string [] profile_names,
		LocalLBMatchPatternString [] [] patterns
	) {
		this.Invoke("add_header_match_pattern", new object [] {
				profile_names,
				patterns});

	}
	public System.IAsyncResult Beginadd_header_match_pattern(string [] profile_names,LocalLBMatchPatternString [] [] patterns, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_header_match_pattern", new object[] {
			profile_names,
			patterns}, callback, asyncState);
	}
	public void Endadd_header_match_pattern(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_host_match_pattern
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpClass", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpClass", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpClass")]
	public void add_host_match_pattern(
		string [] profile_names,
		LocalLBMatchPatternString [] [] patterns
	) {
		this.Invoke("add_host_match_pattern", new object [] {
				profile_names,
				patterns});

	}
	public System.IAsyncResult Beginadd_host_match_pattern(string [] profile_names,LocalLBMatchPatternString [] [] patterns, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_host_match_pattern", new object[] {
			profile_names,
			patterns}, callback, asyncState);
	}
	public void Endadd_host_match_pattern(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_path_match_pattern
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpClass", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpClass", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpClass")]
	public void add_path_match_pattern(
		string [] profile_names,
		LocalLBMatchPatternString [] [] patterns
	) {
		this.Invoke("add_path_match_pattern", new object [] {
				profile_names,
				patterns});

	}
	public System.IAsyncResult Beginadd_path_match_pattern(string [] profile_names,LocalLBMatchPatternString [] [] patterns, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_path_match_pattern", new object[] {
			profile_names,
			patterns}, callback, asyncState);
	}
	public void Endadd_path_match_pattern(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpClass", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpClass", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpClass")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpClass", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpClass", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpClass")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpClass", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpClass", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpClass")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpClass", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpClass", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileHttpClassProfileHttpClassStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((LocalLBProfileHttpClassProfileHttpClassStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public LocalLBProfileHttpClassProfileHttpClassStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileHttpClassProfileHttpClassStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_application_security_module_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpClass", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpClass", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_application_security_module_enabled_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_application_security_module_enabled_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_application_security_module_enabled_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_application_security_module_enabled_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_application_security_module_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cookie_match_pattern
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpClass", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpClass", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileMatchPatternStringArray [] get_cookie_match_pattern(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_cookie_match_pattern", new object [] {
				profile_names});
		return ((LocalLBProfileMatchPatternStringArray [])(results[0]));
	}
	public System.IAsyncResult Beginget_cookie_match_pattern(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cookie_match_pattern", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileMatchPatternStringArray [] Endget_cookie_match_pattern(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileMatchPatternStringArray [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpClass", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpClass", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpClass")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpClass", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpClass", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpClass")]
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
	// get_header_match_pattern
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpClass", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpClass", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileMatchPatternStringArray [] get_header_match_pattern(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_header_match_pattern", new object [] {
				profile_names});
		return ((LocalLBProfileMatchPatternStringArray [])(results[0]));
	}
	public System.IAsyncResult Beginget_header_match_pattern(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_header_match_pattern", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileMatchPatternStringArray [] Endget_header_match_pattern(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileMatchPatternStringArray [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_host_match_pattern
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpClass", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpClass", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileMatchPatternStringArray [] get_host_match_pattern(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_host_match_pattern", new object [] {
				profile_names});
		return ((LocalLBProfileMatchPatternStringArray [])(results[0]));
	}
	public System.IAsyncResult Beginget_host_match_pattern(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_host_match_pattern", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileMatchPatternStringArray [] Endget_host_match_pattern(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileMatchPatternStringArray [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpClass", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpClass", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpClass")]
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
	// get_path_match_pattern
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpClass", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpClass", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileMatchPatternStringArray [] get_path_match_pattern(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_path_match_pattern", new object [] {
				profile_names});
		return ((LocalLBProfileMatchPatternStringArray [])(results[0]));
	}
	public System.IAsyncResult Beginget_path_match_pattern(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_path_match_pattern", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileMatchPatternStringArray [] Endget_path_match_pattern(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileMatchPatternStringArray [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_pool_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpClass", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpClass", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_pool_name(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_pool_name", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_pool_name(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_pool_name", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_pool_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_redirect_location
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpClass", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpClass", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_redirect_location(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_redirect_location", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_redirect_location(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_redirect_location", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_redirect_location(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rewrite_url
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpClass", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpClass", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_rewrite_url(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_rewrite_url", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_rewrite_url(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rewrite_url", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_rewrite_url(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpClass", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpClass", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileHttpClassProfileHttpClassStatistics get_statistics(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				profile_names});
		return ((LocalLBProfileHttpClassProfileHttpClassStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileHttpClassProfileHttpClassStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileHttpClassProfileHttpClassStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics_by_virtual
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpClass", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpClass", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpClass")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpClass", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpClass", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpClass")]
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
	// get_web_accelerator_module_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpClass", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpClass", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpClass")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_web_accelerator_module_enabled_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_web_accelerator_module_enabled_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_web_accelerator_module_enabled_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_web_accelerator_module_enabled_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_web_accelerator_module_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// is_base_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpClass", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpClass", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpClass")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpClass", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpClass", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpClass")]
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
	// remove_cookie_match_pattern
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpClass", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpClass", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpClass")]
	public void remove_cookie_match_pattern(
		string [] profile_names,
		LocalLBMatchPatternString [] [] patterns
	) {
		this.Invoke("remove_cookie_match_pattern", new object [] {
				profile_names,
				patterns});

	}
	public System.IAsyncResult Beginremove_cookie_match_pattern(string [] profile_names,LocalLBMatchPatternString [] [] patterns, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_cookie_match_pattern", new object[] {
			profile_names,
			patterns}, callback, asyncState);
	}
	public void Endremove_cookie_match_pattern(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_header_match_pattern
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpClass", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpClass", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpClass")]
	public void remove_header_match_pattern(
		string [] profile_names,
		LocalLBMatchPatternString [] [] patterns
	) {
		this.Invoke("remove_header_match_pattern", new object [] {
				profile_names,
				patterns});

	}
	public System.IAsyncResult Beginremove_header_match_pattern(string [] profile_names,LocalLBMatchPatternString [] [] patterns, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_header_match_pattern", new object[] {
			profile_names,
			patterns}, callback, asyncState);
	}
	public void Endremove_header_match_pattern(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_host_match_pattern
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpClass", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpClass", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpClass")]
	public void remove_host_match_pattern(
		string [] profile_names,
		LocalLBMatchPatternString [] [] patterns
	) {
		this.Invoke("remove_host_match_pattern", new object [] {
				profile_names,
				patterns});

	}
	public System.IAsyncResult Beginremove_host_match_pattern(string [] profile_names,LocalLBMatchPatternString [] [] patterns, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_host_match_pattern", new object[] {
			profile_names,
			patterns}, callback, asyncState);
	}
	public void Endremove_host_match_pattern(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_path_match_pattern
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpClass", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpClass", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpClass")]
	public void remove_path_match_pattern(
		string [] profile_names,
		LocalLBMatchPatternString [] [] patterns
	) {
		this.Invoke("remove_path_match_pattern", new object [] {
				profile_names,
				patterns});

	}
	public System.IAsyncResult Beginremove_path_match_pattern(string [] profile_names,LocalLBMatchPatternString [] [] patterns, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_path_match_pattern", new object[] {
			profile_names,
			patterns}, callback, asyncState);
	}
	public void Endremove_path_match_pattern(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpClass", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpClass", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpClass")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpClass", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpClass", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpClass")]
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
	// set_application_security_module_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpClass", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpClass", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpClass")]
	public void set_application_security_module_enabled_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_application_security_module_enabled_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_application_security_module_enabled_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_application_security_module_enabled_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_application_security_module_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_cookie_match_pattern
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpClass", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpClass", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpClass")]
	public void set_default_cookie_match_pattern(
		string [] profile_names
	) {
		this.Invoke("set_default_cookie_match_pattern", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginset_default_cookie_match_pattern(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_cookie_match_pattern", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endset_default_cookie_match_pattern(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_header_match_pattern
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpClass", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpClass", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpClass")]
	public void set_default_header_match_pattern(
		string [] profile_names
	) {
		this.Invoke("set_default_header_match_pattern", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginset_default_header_match_pattern(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_header_match_pattern", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endset_default_header_match_pattern(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_host_match_pattern
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpClass", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpClass", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpClass")]
	public void set_default_host_match_pattern(
		string [] profile_names
	) {
		this.Invoke("set_default_host_match_pattern", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginset_default_host_match_pattern(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_host_match_pattern", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endset_default_host_match_pattern(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_path_match_pattern
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpClass", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpClass", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpClass")]
	public void set_default_path_match_pattern(
		string [] profile_names
	) {
		this.Invoke("set_default_path_match_pattern", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginset_default_path_match_pattern(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_path_match_pattern", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endset_default_path_match_pattern(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpClass", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpClass", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpClass")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpClass", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpClass", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpClass")]
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
	// set_pool_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpClass", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpClass", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpClass")]
	public void set_pool_name(
		string [] profile_names,
		LocalLBProfileString [] pool_names
	) {
		this.Invoke("set_pool_name", new object [] {
				profile_names,
				pool_names});

	}
	public System.IAsyncResult Beginset_pool_name(string [] profile_names,LocalLBProfileString [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_pool_name", new object[] {
			profile_names,
			pool_names}, callback, asyncState);
	}
	public void Endset_pool_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_redirect_location
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpClass", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpClass", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpClass")]
	public void set_redirect_location(
		string [] profile_names,
		LocalLBProfileString [] redirect_locations
	) {
		this.Invoke("set_redirect_location", new object [] {
				profile_names,
				redirect_locations});

	}
	public System.IAsyncResult Beginset_redirect_location(string [] profile_names,LocalLBProfileString [] redirect_locations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_redirect_location", new object[] {
			profile_names,
			redirect_locations}, callback, asyncState);
	}
	public void Endset_redirect_location(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rewrite_url
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpClass", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpClass", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpClass")]
	public void set_rewrite_url(
		string [] profile_names,
		LocalLBProfileString [] urls
	) {
		this.Invoke("set_rewrite_url", new object [] {
				profile_names,
				urls});

	}
	public System.IAsyncResult Beginset_rewrite_url(string [] profile_names,LocalLBProfileString [] urls, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rewrite_url", new object[] {
			profile_names,
			urls}, callback, asyncState);
	}
	public void Endset_rewrite_url(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_web_accelerator_module_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpClass", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpClass", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpClass")]
	public void set_web_accelerator_module_enabled_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_web_accelerator_module_enabled_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_web_accelerator_module_enabled_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_web_accelerator_module_enabled_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_web_accelerator_module_enabled_state(System.IAsyncResult asyncResult) {
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileHttpClass.ProfileHttpClassStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBProfileHttpClassProfileHttpClassStatisticEntry
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileHttpClass.ProfileHttpClassStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBProfileHttpClassProfileHttpClassStatistics
	{
		private LocalLBProfileHttpClassProfileHttpClassStatisticEntry [] statisticsField;
		public LocalLBProfileHttpClassProfileHttpClassStatisticEntry [] statistics
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
