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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.ProfileResponseAdaptBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileResponseAdaptResponseAdaptProfileStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileEnabledState))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileString))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileULong))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileAdaptServiceDownAction))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileStatisticsByVirtual))]
	public partial class LocalLBProfileResponseAdapt : iControlInterface {
		public LocalLBProfileResponseAdapt() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileResponseAdapt", 
		RequestNamespace="urn:iControl:LocalLB/ProfileResponseAdapt", ResponseNamespace="urn:iControl:LocalLB/ProfileResponseAdapt")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileResponseAdapt", 
		RequestNamespace="urn:iControl:LocalLB/ProfileResponseAdapt", ResponseNamespace="urn:iControl:LocalLB/ProfileResponseAdapt")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileResponseAdapt", 
		RequestNamespace="urn:iControl:LocalLB/ProfileResponseAdapt", ResponseNamespace="urn:iControl:LocalLB/ProfileResponseAdapt")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileResponseAdapt", 
		RequestNamespace="urn:iControl:LocalLB/ProfileResponseAdapt", ResponseNamespace="urn:iControl:LocalLB/ProfileResponseAdapt")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileResponseAdaptResponseAdaptProfileStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((LocalLBProfileResponseAdaptResponseAdaptProfileStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public LocalLBProfileResponseAdaptResponseAdaptProfileStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileResponseAdaptResponseAdaptProfileStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_allow_http_10_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileResponseAdapt", 
		RequestNamespace="urn:iControl:LocalLB/ProfileResponseAdapt", ResponseNamespace="urn:iControl:LocalLB/ProfileResponseAdapt")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_allow_http_10_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_allow_http_10_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_allow_http_10_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_allow_http_10_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_allow_http_10_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileResponseAdapt", 
		RequestNamespace="urn:iControl:LocalLB/ProfileResponseAdapt", ResponseNamespace="urn:iControl:LocalLB/ProfileResponseAdapt")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileResponseAdapt", 
		RequestNamespace="urn:iControl:LocalLB/ProfileResponseAdapt", ResponseNamespace="urn:iControl:LocalLB/ProfileResponseAdapt")]
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
	// get_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileResponseAdapt", 
		RequestNamespace="urn:iControl:LocalLB/ProfileResponseAdapt", ResponseNamespace="urn:iControl:LocalLB/ProfileResponseAdapt")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_enabled_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_enabled_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_enabled_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_enabled_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_internal_virtual_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileResponseAdapt", 
		RequestNamespace="urn:iControl:LocalLB/ProfileResponseAdapt", ResponseNamespace="urn:iControl:LocalLB/ProfileResponseAdapt")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_internal_virtual_server(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_internal_virtual_server", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_internal_virtual_server(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_internal_virtual_server", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_internal_virtual_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileResponseAdapt", 
		RequestNamespace="urn:iControl:LocalLB/ProfileResponseAdapt", ResponseNamespace="urn:iControl:LocalLB/ProfileResponseAdapt")]
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
	// get_preview_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileResponseAdapt", 
		RequestNamespace="urn:iControl:LocalLB/ProfileResponseAdapt", ResponseNamespace="urn:iControl:LocalLB/ProfileResponseAdapt")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_preview_size(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_preview_size", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_preview_size(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_preview_size", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_preview_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_service_down_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileResponseAdapt", 
		RequestNamespace="urn:iControl:LocalLB/ProfileResponseAdapt", ResponseNamespace="urn:iControl:LocalLB/ProfileResponseAdapt")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileAdaptServiceDownAction [] get_service_down_action(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_service_down_action", new object [] {
				profile_names});
		return ((LocalLBProfileAdaptServiceDownAction [])(results[0]));
	}
	public System.IAsyncResult Beginget_service_down_action(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_service_down_action", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileAdaptServiceDownAction [] Endget_service_down_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileAdaptServiceDownAction [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileResponseAdapt", 
		RequestNamespace="urn:iControl:LocalLB/ProfileResponseAdapt", ResponseNamespace="urn:iControl:LocalLB/ProfileResponseAdapt")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileResponseAdaptResponseAdaptProfileStatistics get_statistics(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				profile_names});
		return ((LocalLBProfileResponseAdaptResponseAdaptProfileStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileResponseAdaptResponseAdaptProfileStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileResponseAdaptResponseAdaptProfileStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics_by_virtual
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileResponseAdapt", 
		RequestNamespace="urn:iControl:LocalLB/ProfileResponseAdapt", ResponseNamespace="urn:iControl:LocalLB/ProfileResponseAdapt")]
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
	// get_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileResponseAdapt", 
		RequestNamespace="urn:iControl:LocalLB/ProfileResponseAdapt", ResponseNamespace="urn:iControl:LocalLB/ProfileResponseAdapt")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_timeout(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_timeout", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_timeout(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_timeout", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_timeout_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileResponseAdapt", 
		RequestNamespace="urn:iControl:LocalLB/ProfileResponseAdapt", ResponseNamespace="urn:iControl:LocalLB/ProfileResponseAdapt")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_timeout_v2(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_timeout_v2", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_timeout_v2(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_timeout_v2", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_timeout_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileResponseAdapt", 
		RequestNamespace="urn:iControl:LocalLB/ProfileResponseAdapt", ResponseNamespace="urn:iControl:LocalLB/ProfileResponseAdapt")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileResponseAdapt", 
		RequestNamespace="urn:iControl:LocalLB/ProfileResponseAdapt", ResponseNamespace="urn:iControl:LocalLB/ProfileResponseAdapt")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileResponseAdapt", 
		RequestNamespace="urn:iControl:LocalLB/ProfileResponseAdapt", ResponseNamespace="urn:iControl:LocalLB/ProfileResponseAdapt")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileResponseAdapt", 
		RequestNamespace="urn:iControl:LocalLB/ProfileResponseAdapt", ResponseNamespace="urn:iControl:LocalLB/ProfileResponseAdapt")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileResponseAdapt", 
		RequestNamespace="urn:iControl:LocalLB/ProfileResponseAdapt", ResponseNamespace="urn:iControl:LocalLB/ProfileResponseAdapt")]
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
	// set_allow_http_10_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileResponseAdapt", 
		RequestNamespace="urn:iControl:LocalLB/ProfileResponseAdapt", ResponseNamespace="urn:iControl:LocalLB/ProfileResponseAdapt")]
	public void set_allow_http_10_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_allow_http_10_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_allow_http_10_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_allow_http_10_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_allow_http_10_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileResponseAdapt", 
		RequestNamespace="urn:iControl:LocalLB/ProfileResponseAdapt", ResponseNamespace="urn:iControl:LocalLB/ProfileResponseAdapt")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileResponseAdapt", 
		RequestNamespace="urn:iControl:LocalLB/ProfileResponseAdapt", ResponseNamespace="urn:iControl:LocalLB/ProfileResponseAdapt")]
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
	// set_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileResponseAdapt", 
		RequestNamespace="urn:iControl:LocalLB/ProfileResponseAdapt", ResponseNamespace="urn:iControl:LocalLB/ProfileResponseAdapt")]
	public void set_enabled_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_enabled_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_enabled_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_enabled_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_internal_virtual_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileResponseAdapt", 
		RequestNamespace="urn:iControl:LocalLB/ProfileResponseAdapt", ResponseNamespace="urn:iControl:LocalLB/ProfileResponseAdapt")]
	public void set_internal_virtual_server(
		string [] profile_names,
		LocalLBProfileString [] virtuals
	) {
		this.Invoke("set_internal_virtual_server", new object [] {
				profile_names,
				virtuals});

	}
	public System.IAsyncResult Beginset_internal_virtual_server(string [] profile_names,LocalLBProfileString [] virtuals, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_internal_virtual_server", new object[] {
			profile_names,
			virtuals}, callback, asyncState);
	}
	public void Endset_internal_virtual_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_preview_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileResponseAdapt", 
		RequestNamespace="urn:iControl:LocalLB/ProfileResponseAdapt", ResponseNamespace="urn:iControl:LocalLB/ProfileResponseAdapt")]
	public void set_preview_size(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_preview_size", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_preview_size(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_preview_size", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_preview_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_service_down_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileResponseAdapt", 
		RequestNamespace="urn:iControl:LocalLB/ProfileResponseAdapt", ResponseNamespace="urn:iControl:LocalLB/ProfileResponseAdapt")]
	public void set_service_down_action(
		string [] profile_names,
		LocalLBProfileAdaptServiceDownAction [] values
	) {
		this.Invoke("set_service_down_action", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_service_down_action(string [] profile_names,LocalLBProfileAdaptServiceDownAction [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_service_down_action", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_service_down_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileResponseAdapt", 
		RequestNamespace="urn:iControl:LocalLB/ProfileResponseAdapt", ResponseNamespace="urn:iControl:LocalLB/ProfileResponseAdapt")]
	public void set_timeout(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_timeout", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_timeout(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_timeout", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_timeout_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileResponseAdapt", 
		RequestNamespace="urn:iControl:LocalLB/ProfileResponseAdapt", ResponseNamespace="urn:iControl:LocalLB/ProfileResponseAdapt")]
	public void set_timeout_v2(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_timeout_v2", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_timeout_v2(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_timeout_v2", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_timeout_v2(System.IAsyncResult asyncResult) {
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileResponseAdapt.ResponseAdaptProfileStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBProfileResponseAdaptResponseAdaptProfileStatisticEntry
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileResponseAdapt.ResponseAdaptProfileStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBProfileResponseAdaptResponseAdaptProfileStatistics
	{
		private LocalLBProfileResponseAdaptResponseAdaptProfileStatisticEntry [] statisticsField;
		public LocalLBProfileResponseAdaptResponseAdaptProfileStatisticEntry [] statistics
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
