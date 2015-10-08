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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.ProfileXMLBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileXMLNamespaceMapping))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileEnabledState))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileXMLProfileXMLStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileULong))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileXMLProfileNamespaceMappingSequence))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileStatisticsByVirtual))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileStringArray))]
	public partial class LocalLBProfileXML : iControlInterface {
		public LocalLBProfileXML() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_namespace_mappings
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileXML", 
		RequestNamespace="urn:iControl:LocalLB/ProfileXML", ResponseNamespace="urn:iControl:LocalLB/ProfileXML")]
	public void add_namespace_mappings(
		string [] profile_names,
		LocalLBProfileXMLNamespaceMapping [] [] namespace_mappings
	) {
		this.Invoke("add_namespace_mappings", new object [] {
				profile_names,
				namespace_mappings});

	}
	public System.IAsyncResult Beginadd_namespace_mappings(string [] profile_names,LocalLBProfileXMLNamespaceMapping [] [] namespace_mappings, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_namespace_mappings", new object[] {
			profile_names,
			namespace_mappings}, callback, asyncState);
	}
	public void Endadd_namespace_mappings(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_xpath_queries
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileXML", 
		RequestNamespace="urn:iControl:LocalLB/ProfileXML", ResponseNamespace="urn:iControl:LocalLB/ProfileXML")]
	public void add_xpath_queries(
		string [] profile_names,
		string [] [] xpath_queries
	) {
		this.Invoke("add_xpath_queries", new object [] {
				profile_names,
				xpath_queries});

	}
	public System.IAsyncResult Beginadd_xpath_queries(string [] profile_names,string [] [] xpath_queries, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_xpath_queries", new object[] {
			profile_names,
			xpath_queries}, callback, asyncState);
	}
	public void Endadd_xpath_queries(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileXML", 
		RequestNamespace="urn:iControl:LocalLB/ProfileXML", ResponseNamespace="urn:iControl:LocalLB/ProfileXML")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileXML", 
		RequestNamespace="urn:iControl:LocalLB/ProfileXML", ResponseNamespace="urn:iControl:LocalLB/ProfileXML")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileXML", 
		RequestNamespace="urn:iControl:LocalLB/ProfileXML", ResponseNamespace="urn:iControl:LocalLB/ProfileXML")]
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
	// get_abort_on_error_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileXML", 
		RequestNamespace="urn:iControl:LocalLB/ProfileXML", ResponseNamespace="urn:iControl:LocalLB/ProfileXML")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_abort_on_error_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_abort_on_error_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_abort_on_error_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_abort_on_error_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_abort_on_error_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileXML", 
		RequestNamespace="urn:iControl:LocalLB/ProfileXML", ResponseNamespace="urn:iControl:LocalLB/ProfileXML")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileXMLProfileXMLStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((LocalLBProfileXMLProfileXMLStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public LocalLBProfileXMLProfileXMLStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileXMLProfileXMLStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileXML", 
		RequestNamespace="urn:iControl:LocalLB/ProfileXML", ResponseNamespace="urn:iControl:LocalLB/ProfileXML")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileXML", 
		RequestNamespace="urn:iControl:LocalLB/ProfileXML", ResponseNamespace="urn:iControl:LocalLB/ProfileXML")]
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
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileXML", 
		RequestNamespace="urn:iControl:LocalLB/ProfileXML", ResponseNamespace="urn:iControl:LocalLB/ProfileXML")]
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
	// get_maximum_buffer_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileXML", 
		RequestNamespace="urn:iControl:LocalLB/ProfileXML", ResponseNamespace="urn:iControl:LocalLB/ProfileXML")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_maximum_buffer_size(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_maximum_buffer_size", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_buffer_size(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_buffer_size", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_maximum_buffer_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_multiple_query_matches_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileXML", 
		RequestNamespace="urn:iControl:LocalLB/ProfileXML", ResponseNamespace="urn:iControl:LocalLB/ProfileXML")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_multiple_query_matches_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_multiple_query_matches_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_multiple_query_matches_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_multiple_query_matches_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_multiple_query_matches_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_namespace_mappings
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileXML", 
		RequestNamespace="urn:iControl:LocalLB/ProfileXML", ResponseNamespace="urn:iControl:LocalLB/ProfileXML")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileXMLProfileNamespaceMappingSequence [] get_namespace_mappings(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_namespace_mappings", new object [] {
				profile_names});
		return ((LocalLBProfileXMLProfileNamespaceMappingSequence [])(results[0]));
	}
	public System.IAsyncResult Beginget_namespace_mappings(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_namespace_mappings", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileXMLProfileNamespaceMappingSequence [] Endget_namespace_mappings(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileXMLProfileNamespaceMappingSequence [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileXML", 
		RequestNamespace="urn:iControl:LocalLB/ProfileXML", ResponseNamespace="urn:iControl:LocalLB/ProfileXML")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileXMLProfileXMLStatistics get_statistics(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				profile_names});
		return ((LocalLBProfileXMLProfileXMLStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileXMLProfileXMLStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileXMLProfileXMLStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics_by_virtual
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileXML", 
		RequestNamespace="urn:iControl:LocalLB/ProfileXML", ResponseNamespace="urn:iControl:LocalLB/ProfileXML")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileXML", 
		RequestNamespace="urn:iControl:LocalLB/ProfileXML", ResponseNamespace="urn:iControl:LocalLB/ProfileXML")]
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
	// get_xpath_queries
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileXML", 
		RequestNamespace="urn:iControl:LocalLB/ProfileXML", ResponseNamespace="urn:iControl:LocalLB/ProfileXML")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileStringArray [] get_xpath_queries(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_xpath_queries", new object [] {
				profile_names});
		return ((LocalLBProfileStringArray [])(results[0]));
	}
	public System.IAsyncResult Beginget_xpath_queries(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_xpath_queries", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileStringArray [] Endget_xpath_queries(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileStringArray [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// is_base_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileXML", 
		RequestNamespace="urn:iControl:LocalLB/ProfileXML", ResponseNamespace="urn:iControl:LocalLB/ProfileXML")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileXML", 
		RequestNamespace="urn:iControl:LocalLB/ProfileXML", ResponseNamespace="urn:iControl:LocalLB/ProfileXML")]
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
	// remove_all_namespace_mappings
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileXML", 
		RequestNamespace="urn:iControl:LocalLB/ProfileXML", ResponseNamespace="urn:iControl:LocalLB/ProfileXML")]
	public void remove_all_namespace_mappings(
		string [] profile_names
	) {
		this.Invoke("remove_all_namespace_mappings", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginremove_all_namespace_mappings(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_namespace_mappings", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endremove_all_namespace_mappings(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_xpath_queries
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileXML", 
		RequestNamespace="urn:iControl:LocalLB/ProfileXML", ResponseNamespace="urn:iControl:LocalLB/ProfileXML")]
	public void remove_all_xpath_queries(
		string [] profile_names
	) {
		this.Invoke("remove_all_xpath_queries", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginremove_all_xpath_queries(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_xpath_queries", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endremove_all_xpath_queries(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_namespace_mappings
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileXML", 
		RequestNamespace="urn:iControl:LocalLB/ProfileXML", ResponseNamespace="urn:iControl:LocalLB/ProfileXML")]
	public void remove_namespace_mappings(
		string [] profile_names,
		LocalLBProfileXMLNamespaceMapping [] [] namespace_mappings
	) {
		this.Invoke("remove_namespace_mappings", new object [] {
				profile_names,
				namespace_mappings});

	}
	public System.IAsyncResult Beginremove_namespace_mappings(string [] profile_names,LocalLBProfileXMLNamespaceMapping [] [] namespace_mappings, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_namespace_mappings", new object[] {
			profile_names,
			namespace_mappings}, callback, asyncState);
	}
	public void Endremove_namespace_mappings(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_xpath_queries
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileXML", 
		RequestNamespace="urn:iControl:LocalLB/ProfileXML", ResponseNamespace="urn:iControl:LocalLB/ProfileXML")]
	public void remove_xpath_queries(
		string [] profile_names,
		string [] [] xpath_queries
	) {
		this.Invoke("remove_xpath_queries", new object [] {
				profile_names,
				xpath_queries});

	}
	public System.IAsyncResult Beginremove_xpath_queries(string [] profile_names,string [] [] xpath_queries, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_xpath_queries", new object[] {
			profile_names,
			xpath_queries}, callback, asyncState);
	}
	public void Endremove_xpath_queries(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileXML", 
		RequestNamespace="urn:iControl:LocalLB/ProfileXML", ResponseNamespace="urn:iControl:LocalLB/ProfileXML")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileXML", 
		RequestNamespace="urn:iControl:LocalLB/ProfileXML", ResponseNamespace="urn:iControl:LocalLB/ProfileXML")]
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
	// set_abort_on_error_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileXML", 
		RequestNamespace="urn:iControl:LocalLB/ProfileXML", ResponseNamespace="urn:iControl:LocalLB/ProfileXML")]
	public void set_abort_on_error_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_abort_on_error_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_abort_on_error_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_abort_on_error_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_abort_on_error_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileXML", 
		RequestNamespace="urn:iControl:LocalLB/ProfileXML", ResponseNamespace="urn:iControl:LocalLB/ProfileXML")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileXML", 
		RequestNamespace="urn:iControl:LocalLB/ProfileXML", ResponseNamespace="urn:iControl:LocalLB/ProfileXML")]
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
	// set_maximum_buffer_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileXML", 
		RequestNamespace="urn:iControl:LocalLB/ProfileXML", ResponseNamespace="urn:iControl:LocalLB/ProfileXML")]
	public void set_maximum_buffer_size(
		string [] profile_names,
		LocalLBProfileULong [] sizes
	) {
		this.Invoke("set_maximum_buffer_size", new object [] {
				profile_names,
				sizes});

	}
	public System.IAsyncResult Beginset_maximum_buffer_size(string [] profile_names,LocalLBProfileULong [] sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_buffer_size", new object[] {
			profile_names,
			sizes}, callback, asyncState);
	}
	public void Endset_maximum_buffer_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_multiple_query_matches_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileXML", 
		RequestNamespace="urn:iControl:LocalLB/ProfileXML", ResponseNamespace="urn:iControl:LocalLB/ProfileXML")]
	public void set_multiple_query_matches_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_multiple_query_matches_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_multiple_query_matches_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_multiple_query_matches_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_multiple_query_matches_state(System.IAsyncResult asyncResult) {
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileXML.NamespaceMapping", Namespace = "urn:iControl")]
	public partial class LocalLBProfileXMLNamespaceMapping
	{
		private string mapping_prefixField;
		public string mapping_prefix
		{
			get { return this.mapping_prefixField; }
			set { this.mapping_prefixField = value; }
		}
		private string mapping_namespaceField;
		public string mapping_namespace
		{
			get { return this.mapping_namespaceField; }
			set { this.mapping_namespaceField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileXML.ProfileNamespaceMappingSequence", Namespace = "urn:iControl")]
	public partial class LocalLBProfileXMLProfileNamespaceMappingSequence
	{
		private LocalLBProfileXMLNamespaceMapping [] valuesField;
		public LocalLBProfileXMLNamespaceMapping [] values
		{
			get { return this.valuesField; }
			set { this.valuesField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileXML.ProfileXMLStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBProfileXMLProfileXMLStatisticEntry
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileXML.ProfileXMLStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBProfileXMLProfileXMLStatistics
	{
		private LocalLBProfileXMLProfileXMLStatisticEntry [] statisticsField;
		public LocalLBProfileXMLProfileXMLStatisticEntry [] statistics
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
