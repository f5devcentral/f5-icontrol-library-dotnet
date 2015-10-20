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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.ProfileOneConnectBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileOneConnectProfileOneConnectStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileULong))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileOneConnectProfileLimitType))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileEnabledState))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileIPAddress))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileStatisticsByVirtual))]
	public partial class LocalLBProfileOneConnect : iControlInterface {
		public LocalLBProfileOneConnect() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileOneConnect", 
		RequestNamespace="urn:iControl:LocalLB/ProfileOneConnect", ResponseNamespace="urn:iControl:LocalLB/ProfileOneConnect")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileOneConnect", 
		RequestNamespace="urn:iControl:LocalLB/ProfileOneConnect", ResponseNamespace="urn:iControl:LocalLB/ProfileOneConnect")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileOneConnect", 
		RequestNamespace="urn:iControl:LocalLB/ProfileOneConnect", ResponseNamespace="urn:iControl:LocalLB/ProfileOneConnect")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileOneConnect", 
		RequestNamespace="urn:iControl:LocalLB/ProfileOneConnect", ResponseNamespace="urn:iControl:LocalLB/ProfileOneConnect")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileOneConnectProfileOneConnectStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((LocalLBProfileOneConnectProfileOneConnectStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public LocalLBProfileOneConnectProfileOneConnectStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileOneConnectProfileOneConnectStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileOneConnect", 
		RequestNamespace="urn:iControl:LocalLB/ProfileOneConnect", ResponseNamespace="urn:iControl:LocalLB/ProfileOneConnect")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileOneConnect", 
		RequestNamespace="urn:iControl:LocalLB/ProfileOneConnect", ResponseNamespace="urn:iControl:LocalLB/ProfileOneConnect")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileOneConnect", 
		RequestNamespace="urn:iControl:LocalLB/ProfileOneConnect", ResponseNamespace="urn:iControl:LocalLB/ProfileOneConnect")]
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
	// get_limit_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileOneConnect", 
		RequestNamespace="urn:iControl:LocalLB/ProfileOneConnect", ResponseNamespace="urn:iControl:LocalLB/ProfileOneConnect")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileOneConnectProfileLimitType [] get_limit_type(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_limit_type", new object [] {
				profile_names});
		return ((LocalLBProfileOneConnectProfileLimitType [])(results[0]));
	}
	public System.IAsyncResult Beginget_limit_type(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_limit_type", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileOneConnectProfileLimitType [] Endget_limit_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileOneConnectProfileLimitType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileOneConnect", 
		RequestNamespace="urn:iControl:LocalLB/ProfileOneConnect", ResponseNamespace="urn:iControl:LocalLB/ProfileOneConnect")]
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
	// get_maximum_age
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileOneConnect", 
		RequestNamespace="urn:iControl:LocalLB/ProfileOneConnect", ResponseNamespace="urn:iControl:LocalLB/ProfileOneConnect")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_maximum_age(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_maximum_age", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_age(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_age", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_maximum_age(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_maximum_connection
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileOneConnect", 
		RequestNamespace="urn:iControl:LocalLB/ProfileOneConnect", ResponseNamespace="urn:iControl:LocalLB/ProfileOneConnect")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_maximum_connection(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_maximum_connection", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_connection(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_connection", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_maximum_connection(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_maximum_reuse
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileOneConnect", 
		RequestNamespace="urn:iControl:LocalLB/ProfileOneConnect", ResponseNamespace="urn:iControl:LocalLB/ProfileOneConnect")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_maximum_reuse(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_maximum_reuse", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_reuse(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_reuse", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_maximum_reuse(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_share_pools_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileOneConnect", 
		RequestNamespace="urn:iControl:LocalLB/ProfileOneConnect", ResponseNamespace="urn:iControl:LocalLB/ProfileOneConnect")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_share_pools_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_share_pools_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_share_pools_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_share_pools_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_share_pools_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_source_mask
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileOneConnect", 
		RequestNamespace="urn:iControl:LocalLB/ProfileOneConnect", ResponseNamespace="urn:iControl:LocalLB/ProfileOneConnect")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileIPAddress [] get_source_mask(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_source_mask", new object [] {
				profile_names});
		return ((LocalLBProfileIPAddress [])(results[0]));
	}
	public System.IAsyncResult Beginget_source_mask(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_source_mask", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileIPAddress [] Endget_source_mask(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileIPAddress [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileOneConnect", 
		RequestNamespace="urn:iControl:LocalLB/ProfileOneConnect", ResponseNamespace="urn:iControl:LocalLB/ProfileOneConnect")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileOneConnectProfileOneConnectStatistics get_statistics(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				profile_names});
		return ((LocalLBProfileOneConnectProfileOneConnectStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileOneConnectProfileOneConnectStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileOneConnectProfileOneConnectStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics_by_virtual
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileOneConnect", 
		RequestNamespace="urn:iControl:LocalLB/ProfileOneConnect", ResponseNamespace="urn:iControl:LocalLB/ProfileOneConnect")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileOneConnect", 
		RequestNamespace="urn:iControl:LocalLB/ProfileOneConnect", ResponseNamespace="urn:iControl:LocalLB/ProfileOneConnect")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileOneConnect", 
		RequestNamespace="urn:iControl:LocalLB/ProfileOneConnect", ResponseNamespace="urn:iControl:LocalLB/ProfileOneConnect")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileOneConnect", 
		RequestNamespace="urn:iControl:LocalLB/ProfileOneConnect", ResponseNamespace="urn:iControl:LocalLB/ProfileOneConnect")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileOneConnect", 
		RequestNamespace="urn:iControl:LocalLB/ProfileOneConnect", ResponseNamespace="urn:iControl:LocalLB/ProfileOneConnect")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileOneConnect", 
		RequestNamespace="urn:iControl:LocalLB/ProfileOneConnect", ResponseNamespace="urn:iControl:LocalLB/ProfileOneConnect")]
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
	// set_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileOneConnect", 
		RequestNamespace="urn:iControl:LocalLB/ProfileOneConnect", ResponseNamespace="urn:iControl:LocalLB/ProfileOneConnect")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileOneConnect", 
		RequestNamespace="urn:iControl:LocalLB/ProfileOneConnect", ResponseNamespace="urn:iControl:LocalLB/ProfileOneConnect")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileOneConnect", 
		RequestNamespace="urn:iControl:LocalLB/ProfileOneConnect", ResponseNamespace="urn:iControl:LocalLB/ProfileOneConnect")]
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
	// set_limit_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileOneConnect", 
		RequestNamespace="urn:iControl:LocalLB/ProfileOneConnect", ResponseNamespace="urn:iControl:LocalLB/ProfileOneConnect")]
	public void set_limit_type(
		string [] profile_names,
		LocalLBProfileOneConnectProfileLimitType [] limit_types
	) {
		this.Invoke("set_limit_type", new object [] {
				profile_names,
				limit_types});

	}
	public System.IAsyncResult Beginset_limit_type(string [] profile_names,LocalLBProfileOneConnectProfileLimitType [] limit_types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_limit_type", new object[] {
			profile_names,
			limit_types}, callback, asyncState);
	}
	public void Endset_limit_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_age
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileOneConnect", 
		RequestNamespace="urn:iControl:LocalLB/ProfileOneConnect", ResponseNamespace="urn:iControl:LocalLB/ProfileOneConnect")]
	public void set_maximum_age(
		string [] profile_names,
		LocalLBProfileULong [] maximum_ages
	) {
		this.Invoke("set_maximum_age", new object [] {
				profile_names,
				maximum_ages});

	}
	public System.IAsyncResult Beginset_maximum_age(string [] profile_names,LocalLBProfileULong [] maximum_ages, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_age", new object[] {
			profile_names,
			maximum_ages}, callback, asyncState);
	}
	public void Endset_maximum_age(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_connection
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileOneConnect", 
		RequestNamespace="urn:iControl:LocalLB/ProfileOneConnect", ResponseNamespace="urn:iControl:LocalLB/ProfileOneConnect")]
	public void set_maximum_connection(
		string [] profile_names,
		LocalLBProfileULong [] maximum_connections
	) {
		this.Invoke("set_maximum_connection", new object [] {
				profile_names,
				maximum_connections});

	}
	public System.IAsyncResult Beginset_maximum_connection(string [] profile_names,LocalLBProfileULong [] maximum_connections, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_connection", new object[] {
			profile_names,
			maximum_connections}, callback, asyncState);
	}
	public void Endset_maximum_connection(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_reuse
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileOneConnect", 
		RequestNamespace="urn:iControl:LocalLB/ProfileOneConnect", ResponseNamespace="urn:iControl:LocalLB/ProfileOneConnect")]
	public void set_maximum_reuse(
		string [] profile_names,
		LocalLBProfileULong [] maximum_reuses
	) {
		this.Invoke("set_maximum_reuse", new object [] {
				profile_names,
				maximum_reuses});

	}
	public System.IAsyncResult Beginset_maximum_reuse(string [] profile_names,LocalLBProfileULong [] maximum_reuses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_reuse", new object[] {
			profile_names,
			maximum_reuses}, callback, asyncState);
	}
	public void Endset_maximum_reuse(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_share_pools_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileOneConnect", 
		RequestNamespace="urn:iControl:LocalLB/ProfileOneConnect", ResponseNamespace="urn:iControl:LocalLB/ProfileOneConnect")]
	public void set_share_pools_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_share_pools_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_share_pools_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_share_pools_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_share_pools_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_source_mask
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileOneConnect", 
		RequestNamespace="urn:iControl:LocalLB/ProfileOneConnect", ResponseNamespace="urn:iControl:LocalLB/ProfileOneConnect")]
	public void set_source_mask(
		string [] profile_names,
		LocalLBProfileIPAddress [] source_masks
	) {
		this.Invoke("set_source_mask", new object [] {
				profile_names,
				source_masks});

	}
	public System.IAsyncResult Beginset_source_mask(string [] profile_names,LocalLBProfileIPAddress [] source_masks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_source_mask", new object[] {
			profile_names,
			source_masks}, callback, asyncState);
	}
	public void Endset_source_mask(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileOneConnect.LimitType", Namespace = "urn:iControl")]
	public enum LocalLBProfileOneConnectLimitType
	{
		ONECONNECT_LIMIT_TYPE_UNKNOWN,
		ONECONNECT_LIMIT_TYPE_NONE,
		ONECONNECT_LIMIT_TYPE_IDLE,
		ONECONNECT_LIMIT_TYPE_STRICT,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileOneConnect.ProfileLimitType", Namespace = "urn:iControl")]
	public partial class LocalLBProfileOneConnectProfileLimitType
	{
		private LocalLBProfileOneConnectLimitType valueField;
		public LocalLBProfileOneConnectLimitType value
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileOneConnect.ProfileOneConnectStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBProfileOneConnectProfileOneConnectStatisticEntry
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileOneConnect.ProfileOneConnectStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBProfileOneConnectProfileOneConnectStatistics
	{
		private LocalLBProfileOneConnectProfileOneConnectStatisticEntry [] statisticsField;
		public LocalLBProfileOneConnectProfileOneConnectStatisticEntry [] statistics
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
