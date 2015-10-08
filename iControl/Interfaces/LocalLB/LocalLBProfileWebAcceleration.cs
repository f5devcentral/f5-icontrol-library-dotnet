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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.ProfileWebAccelerationBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileWebAccelerationCacheKey))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileWebAccelerationProfileWebAccelerationStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileStringArray))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileULong))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileWebAccelerationCacheEntry))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileWebAccelerationCacheEntryExactMatch))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileWACacheControlMode))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileEnabledState))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileStatisticsByVirtual))]
	public partial class LocalLBProfileWebAcceleration : iControlInterface {
		public LocalLBProfileWebAcceleration() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_application
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
	public void add_application(
		string [] profile_names,
		string [] [] applications
	) {
		this.Invoke("add_application", new object [] {
				profile_names,
				applications});

	}
	public System.IAsyncResult Beginadd_application(string [] profile_names,string [] [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_application", new object[] {
			profile_names,
			applications}, callback, asyncState);
	}
	public void Endadd_application(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_cache_uri_exclude
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
	public void add_cache_uri_exclude(
		string [] profile_names,
		string [] [] reg_expressions
	) {
		this.Invoke("add_cache_uri_exclude", new object [] {
				profile_names,
				reg_expressions});

	}
	public System.IAsyncResult Beginadd_cache_uri_exclude(string [] profile_names,string [] [] reg_expressions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_cache_uri_exclude", new object[] {
			profile_names,
			reg_expressions}, callback, asyncState);
	}
	public void Endadd_cache_uri_exclude(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_cache_uri_include
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
	public void add_cache_uri_include(
		string [] profile_names,
		string [] [] reg_expressions
	) {
		this.Invoke("add_cache_uri_include", new object [] {
				profile_names,
				reg_expressions});

	}
	public System.IAsyncResult Beginadd_cache_uri_include(string [] profile_names,string [] [] reg_expressions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_cache_uri_include", new object[] {
			profile_names,
			reg_expressions}, callback, asyncState);
	}
	public void Endadd_cache_uri_include(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_cache_uri_include_override
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
	public void add_cache_uri_include_override(
		string [] profile_names,
		string [] [] reg_expressions
	) {
		this.Invoke("add_cache_uri_include_override", new object [] {
				profile_names,
				reg_expressions});

	}
	public System.IAsyncResult Beginadd_cache_uri_include_override(string [] profile_names,string [] [] reg_expressions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_cache_uri_include_override", new object[] {
			profile_names,
			reg_expressions}, callback, asyncState);
	}
	public void Endadd_cache_uri_include_override(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_cache_uri_pinned
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
	public void add_cache_uri_pinned(
		string [] profile_names,
		string [] [] reg_expressions
	) {
		this.Invoke("add_cache_uri_pinned", new object [] {
				profile_names,
				reg_expressions});

	}
	public System.IAsyncResult Beginadd_cache_uri_pinned(string [] profile_names,string [] [] reg_expressions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_cache_uri_pinned", new object[] {
			profile_names,
			reg_expressions}, callback, asyncState);
	}
	public void Endadd_cache_uri_pinned(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
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
	// evict_all_cache_entries
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
	public void evict_all_cache_entries(

	) {
		this.Invoke("evict_all_cache_entries", new object [0]);

	}
	public System.IAsyncResult Beginevict_all_cache_entries(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("evict_all_cache_entries", new object[0], callback, asyncState);
	}
	public void Endevict_all_cache_entries(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// evict_cache_entry
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
	public void evict_cache_entry(
		LocalLBProfileWebAccelerationCacheKey [] keys,
		bool exact_match
	) {
		this.Invoke("evict_cache_entry", new object [] {
				keys,
				exact_match});

	}
	public System.IAsyncResult Beginevict_cache_entry(LocalLBProfileWebAccelerationCacheKey [] keys,bool exact_match, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("evict_cache_entry", new object[] {
			keys,
			exact_match}, callback, asyncState);
	}
	public void Endevict_cache_entry(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileWebAccelerationProfileWebAccelerationStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((LocalLBProfileWebAccelerationProfileWebAccelerationStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public LocalLBProfileWebAccelerationProfileWebAccelerationStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileWebAccelerationProfileWebAccelerationStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_application
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileStringArray [] get_application(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_application", new object [] {
				profile_names});
		return ((LocalLBProfileStringArray [])(results[0]));
	}
	public System.IAsyncResult Beginget_application(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_application", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileStringArray [] Endget_application(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileStringArray [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cache_aging_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_cache_aging_rate(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_cache_aging_rate", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_cache_aging_rate(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cache_aging_rate", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_cache_aging_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cache_entry
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileWebAccelerationCacheEntry [] [] get_cache_entry(
		LocalLBProfileWebAccelerationCacheKey [] keys
	) {
		object [] results = this.Invoke("get_cache_entry", new object [] {
				keys});
		return ((LocalLBProfileWebAccelerationCacheEntry [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_cache_entry(LocalLBProfileWebAccelerationCacheKey [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cache_entry", new object[] {
			keys}, callback, asyncState);
	}
	public LocalLBProfileWebAccelerationCacheEntry [] [] Endget_cache_entry(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileWebAccelerationCacheEntry [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cache_entry_exact_match
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileWebAccelerationCacheEntryExactMatch [] [] get_cache_entry_exact_match(
		LocalLBProfileWebAccelerationCacheKey [] keys
	) {
		object [] results = this.Invoke("get_cache_entry_exact_match", new object [] {
				keys});
		return ((LocalLBProfileWebAccelerationCacheEntryExactMatch [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_cache_entry_exact_match(LocalLBProfileWebAccelerationCacheKey [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cache_entry_exact_match", new object[] {
			keys}, callback, asyncState);
	}
	public LocalLBProfileWebAccelerationCacheEntryExactMatch [] [] Endget_cache_entry_exact_match(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileWebAccelerationCacheEntryExactMatch [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cache_ignore_client_cache_control_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileWACacheControlMode [] get_cache_ignore_client_cache_control_mode(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_cache_ignore_client_cache_control_mode", new object [] {
				profile_names});
		return ((LocalLBProfileWACacheControlMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_cache_ignore_client_cache_control_mode(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cache_ignore_client_cache_control_mode", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileWACacheControlMode [] Endget_cache_ignore_client_cache_control_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileWACacheControlMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cache_insert_age_header_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_cache_insert_age_header_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_cache_insert_age_header_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_cache_insert_age_header_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cache_insert_age_header_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_cache_insert_age_header_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cache_maximum_age
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_cache_maximum_age(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_cache_maximum_age", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_cache_maximum_age(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cache_maximum_age", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_cache_maximum_age(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cache_maximum_entries
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_cache_maximum_entries(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_cache_maximum_entries", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_cache_maximum_entries(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cache_maximum_entries", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_cache_maximum_entries(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cache_object_maximum_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_cache_object_maximum_size(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_cache_object_maximum_size", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_cache_object_maximum_size(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cache_object_maximum_size", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_cache_object_maximum_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cache_object_minimum_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_cache_object_minimum_size(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_cache_object_minimum_size", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_cache_object_minimum_size(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cache_object_minimum_size", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_cache_object_minimum_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cache_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_cache_size(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_cache_size", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_cache_size(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cache_size", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_cache_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cache_uri_exclude
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileStringArray [] get_cache_uri_exclude(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_cache_uri_exclude", new object [] {
				profile_names});
		return ((LocalLBProfileStringArray [])(results[0]));
	}
	public System.IAsyncResult Beginget_cache_uri_exclude(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cache_uri_exclude", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileStringArray [] Endget_cache_uri_exclude(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileStringArray [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cache_uri_include
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileStringArray [] get_cache_uri_include(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_cache_uri_include", new object [] {
				profile_names});
		return ((LocalLBProfileStringArray [])(results[0]));
	}
	public System.IAsyncResult Beginget_cache_uri_include(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cache_uri_include", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileStringArray [] Endget_cache_uri_include(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileStringArray [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cache_uri_include_override
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileStringArray [] get_cache_uri_include_override(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_cache_uri_include_override", new object [] {
				profile_names});
		return ((LocalLBProfileStringArray [])(results[0]));
	}
	public System.IAsyncResult Beginget_cache_uri_include_override(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cache_uri_include_override", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileStringArray [] Endget_cache_uri_include_override(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileStringArray [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cache_uri_pinned
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileStringArray [] get_cache_uri_pinned(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_cache_uri_pinned", new object [] {
				profile_names});
		return ((LocalLBProfileStringArray [])(results[0]));
	}
	public System.IAsyncResult Beginget_cache_uri_pinned(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cache_uri_pinned", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileStringArray [] Endget_cache_uri_pinned(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileStringArray [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
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
	// get_maximum_mtag_cache_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_maximum_mtag_cache_size(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_maximum_mtag_cache_size", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_mtag_cache_size(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_mtag_cache_size", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_maximum_mtag_cache_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileWebAccelerationProfileWebAccelerationStatistics get_statistics(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				profile_names});
		return ((LocalLBProfileWebAccelerationProfileWebAccelerationStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileWebAccelerationProfileWebAccelerationStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileWebAccelerationProfileWebAccelerationStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics_by_virtual
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
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
	// remove_all_applications
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
	public void remove_all_applications(
		string [] profile_names
	) {
		this.Invoke("remove_all_applications", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginremove_all_applications(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_applications", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endremove_all_applications(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_application
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
	public void remove_application(
		string [] profile_names,
		string [] [] applications
	) {
		this.Invoke("remove_application", new object [] {
				profile_names,
				applications});

	}
	public System.IAsyncResult Beginremove_application(string [] profile_names,string [] [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_application", new object[] {
			profile_names,
			applications}, callback, asyncState);
	}
	public void Endremove_application(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_cache_uri_exclude
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
	public void remove_cache_uri_exclude(
		string [] profile_names,
		string [] [] reg_expressions
	) {
		this.Invoke("remove_cache_uri_exclude", new object [] {
				profile_names,
				reg_expressions});

	}
	public System.IAsyncResult Beginremove_cache_uri_exclude(string [] profile_names,string [] [] reg_expressions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_cache_uri_exclude", new object[] {
			profile_names,
			reg_expressions}, callback, asyncState);
	}
	public void Endremove_cache_uri_exclude(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_cache_uri_include
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
	public void remove_cache_uri_include(
		string [] profile_names,
		string [] [] reg_expressions
	) {
		this.Invoke("remove_cache_uri_include", new object [] {
				profile_names,
				reg_expressions});

	}
	public System.IAsyncResult Beginremove_cache_uri_include(string [] profile_names,string [] [] reg_expressions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_cache_uri_include", new object[] {
			profile_names,
			reg_expressions}, callback, asyncState);
	}
	public void Endremove_cache_uri_include(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_cache_uri_include_override
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
	public void remove_cache_uri_include_override(
		string [] profile_names,
		string [] [] reg_expressions
	) {
		this.Invoke("remove_cache_uri_include_override", new object [] {
				profile_names,
				reg_expressions});

	}
	public System.IAsyncResult Beginremove_cache_uri_include_override(string [] profile_names,string [] [] reg_expressions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_cache_uri_include_override", new object[] {
			profile_names,
			reg_expressions}, callback, asyncState);
	}
	public void Endremove_cache_uri_include_override(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_cache_uri_pinned
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
	public void remove_cache_uri_pinned(
		string [] profile_names,
		string [] [] reg_expressions
	) {
		this.Invoke("remove_cache_uri_pinned", new object [] {
				profile_names,
				reg_expressions});

	}
	public System.IAsyncResult Beginremove_cache_uri_pinned(string [] profile_names,string [] [] reg_expressions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_cache_uri_pinned", new object[] {
			profile_names,
			reg_expressions}, callback, asyncState);
	}
	public void Endremove_cache_uri_pinned(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
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
	// set_cache_aging_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
	public void set_cache_aging_rate(
		string [] profile_names,
		LocalLBProfileULong [] aging_rates
	) {
		this.Invoke("set_cache_aging_rate", new object [] {
				profile_names,
				aging_rates});

	}
	public System.IAsyncResult Beginset_cache_aging_rate(string [] profile_names,LocalLBProfileULong [] aging_rates, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cache_aging_rate", new object[] {
			profile_names,
			aging_rates}, callback, asyncState);
	}
	public void Endset_cache_aging_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_cache_ignore_client_cache_control_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
	public void set_cache_ignore_client_cache_control_mode(
		string [] profile_names,
		LocalLBProfileWACacheControlMode [] modes
	) {
		this.Invoke("set_cache_ignore_client_cache_control_mode", new object [] {
				profile_names,
				modes});

	}
	public System.IAsyncResult Beginset_cache_ignore_client_cache_control_mode(string [] profile_names,LocalLBProfileWACacheControlMode [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cache_ignore_client_cache_control_mode", new object[] {
			profile_names,
			modes}, callback, asyncState);
	}
	public void Endset_cache_ignore_client_cache_control_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_cache_insert_age_header_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
	public void set_cache_insert_age_header_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_cache_insert_age_header_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_cache_insert_age_header_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cache_insert_age_header_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_cache_insert_age_header_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_cache_maximum_age
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
	public void set_cache_maximum_age(
		string [] profile_names,
		LocalLBProfileULong [] maximum_age
	) {
		this.Invoke("set_cache_maximum_age", new object [] {
				profile_names,
				maximum_age});

	}
	public System.IAsyncResult Beginset_cache_maximum_age(string [] profile_names,LocalLBProfileULong [] maximum_age, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cache_maximum_age", new object[] {
			profile_names,
			maximum_age}, callback, asyncState);
	}
	public void Endset_cache_maximum_age(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_cache_maximum_entries
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
	public void set_cache_maximum_entries(
		string [] profile_names,
		LocalLBProfileULong [] maximum_entries
	) {
		this.Invoke("set_cache_maximum_entries", new object [] {
				profile_names,
				maximum_entries});

	}
	public System.IAsyncResult Beginset_cache_maximum_entries(string [] profile_names,LocalLBProfileULong [] maximum_entries, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cache_maximum_entries", new object[] {
			profile_names,
			maximum_entries}, callback, asyncState);
	}
	public void Endset_cache_maximum_entries(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_cache_object_maximum_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
	public void set_cache_object_maximum_size(
		string [] profile_names,
		LocalLBProfileULong [] maximum_size
	) {
		this.Invoke("set_cache_object_maximum_size", new object [] {
				profile_names,
				maximum_size});

	}
	public System.IAsyncResult Beginset_cache_object_maximum_size(string [] profile_names,LocalLBProfileULong [] maximum_size, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cache_object_maximum_size", new object[] {
			profile_names,
			maximum_size}, callback, asyncState);
	}
	public void Endset_cache_object_maximum_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_cache_object_minimum_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
	public void set_cache_object_minimum_size(
		string [] profile_names,
		LocalLBProfileULong [] minimum_size
	) {
		this.Invoke("set_cache_object_minimum_size", new object [] {
				profile_names,
				minimum_size});

	}
	public System.IAsyncResult Beginset_cache_object_minimum_size(string [] profile_names,LocalLBProfileULong [] minimum_size, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cache_object_minimum_size", new object[] {
			profile_names,
			minimum_size}, callback, asyncState);
	}
	public void Endset_cache_object_minimum_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_cache_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
	public void set_cache_size(
		string [] profile_names,
		LocalLBProfileULong [] sizes
	) {
		this.Invoke("set_cache_size", new object [] {
				profile_names,
				sizes});

	}
	public System.IAsyncResult Beginset_cache_size(string [] profile_names,LocalLBProfileULong [] sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cache_size", new object[] {
			profile_names,
			sizes}, callback, asyncState);
	}
	public void Endset_cache_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_application
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
	public void set_default_application(
		string [] profile_names
	) {
		this.Invoke("set_default_application", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginset_default_application(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_application", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endset_default_application(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_cache_uri_exclude
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
	public void set_default_cache_uri_exclude(
		string [] profile_names
	) {
		this.Invoke("set_default_cache_uri_exclude", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginset_default_cache_uri_exclude(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_cache_uri_exclude", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endset_default_cache_uri_exclude(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_cache_uri_include
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
	public void set_default_cache_uri_include(
		string [] profile_names
	) {
		this.Invoke("set_default_cache_uri_include", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginset_default_cache_uri_include(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_cache_uri_include", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endset_default_cache_uri_include(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_cache_uri_include_override
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
	public void set_default_cache_uri_include_override(
		string [] profile_names
	) {
		this.Invoke("set_default_cache_uri_include_override", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginset_default_cache_uri_include_override(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_cache_uri_include_override", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endset_default_cache_uri_include_override(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_cache_uri_pinned
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
	public void set_default_cache_uri_pinned(
		string [] profile_names
	) {
		this.Invoke("set_default_cache_uri_pinned", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginset_default_cache_uri_pinned(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_cache_uri_pinned", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endset_default_cache_uri_pinned(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
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
	// set_maximum_mtag_cache_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileWebAcceleration", 
		RequestNamespace="urn:iControl:LocalLB/ProfileWebAcceleration", ResponseNamespace="urn:iControl:LocalLB/ProfileWebAcceleration")]
	public void set_maximum_mtag_cache_size(
		string [] profile_names,
		LocalLBProfileULong [] cache_sizes
	) {
		this.Invoke("set_maximum_mtag_cache_size", new object [] {
				profile_names,
				cache_sizes});

	}
	public System.IAsyncResult Beginset_maximum_mtag_cache_size(string [] profile_names,LocalLBProfileULong [] cache_sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_mtag_cache_size", new object[] {
			profile_names,
			cache_sizes}, callback, asyncState);
	}
	public void Endset_maximum_mtag_cache_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileWebAcceleration.CacheVaryType", Namespace = "urn:iControl")]
	public enum LocalLBProfileWebAccelerationCacheVaryType
	{
		CACHE_VARY_NONE,
		CACHE_VARY_USERAGENT,
		CACHE_VARY_ACCEPT_ENCODING,
		CACHE_VARY_BOTH,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileWebAcceleration.CacheEntry", Namespace = "urn:iControl")]
	public partial class LocalLBProfileWebAccelerationCacheEntry
	{
		private string profile_nameField;
		public string profile_name
		{
			get { return this.profile_nameField; }
			set { this.profile_nameField = value; }
		}
		private string host_nameField;
		public string host_name
		{
			get { return this.host_nameField; }
			set { this.host_nameField = value; }
		}
		private string uriField;
		public string uri
		{
			get { return this.uriField; }
			set { this.uriField = value; }
		}
		private LocalLBProfileWebAccelerationCacheVaryType vary_typeField;
		public LocalLBProfileWebAccelerationCacheVaryType vary_type
		{
			get { return this.vary_typeField; }
			set { this.vary_typeField = value; }
		}
		private long vary_countField;
		public long vary_count
		{
			get { return this.vary_countField; }
			set { this.vary_countField = value; }
		}
		private long hitsField;
		public long hits
		{
			get { return this.hitsField; }
			set { this.hitsField = value; }
		}
		private long receivedField;
		public long received
		{
			get { return this.receivedField; }
			set { this.receivedField = value; }
		}
		private long last_sentField;
		public long last_sent
		{
			get { return this.last_sentField; }
			set { this.last_sentField = value; }
		}
		private long expirationField;
		public long expiration
		{
			get { return this.expirationField; }
			set { this.expirationField = value; }
		}
		private long sizeField;
		public long size
		{
			get { return this.sizeField; }
			set { this.sizeField = value; }
		}
		private long rankField;
		public long rank
		{
			get { return this.rankField; }
			set { this.rankField = value; }
		}
		private long source_slotField;
		public long source_slot
		{
			get { return this.source_slotField; }
			set { this.source_slotField = value; }
		}
		private long source_tmmField;
		public long source_tmm
		{
			get { return this.source_tmmField; }
			set { this.source_tmmField = value; }
		}
		private long owner_slotField;
		public long owner_slot
		{
			get { return this.owner_slotField; }
			set { this.owner_slotField = value; }
		}
		private long owner_tmmField;
		public long owner_tmm
		{
			get { return this.owner_tmmField; }
			set { this.owner_tmmField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileWebAcceleration.CacheEntryExactMatch", Namespace = "urn:iControl")]
	public partial class LocalLBProfileWebAccelerationCacheEntryExactMatch
	{
		private string profile_nameField;
		public string profile_name
		{
			get { return this.profile_nameField; }
			set { this.profile_nameField = value; }
		}
		private string host_nameField;
		public string host_name
		{
			get { return this.host_nameField; }
			set { this.host_nameField = value; }
		}
		private string uriField;
		public string uri
		{
			get { return this.uriField; }
			set { this.uriField = value; }
		}
		private string vary_useragentField;
		public string vary_useragent
		{
			get { return this.vary_useragentField; }
			set { this.vary_useragentField = value; }
		}
		private string vary_encodingField;
		public string vary_encoding
		{
			get { return this.vary_encodingField; }
			set { this.vary_encodingField = value; }
		}
		private long hitsField;
		public long hits
		{
			get { return this.hitsField; }
			set { this.hitsField = value; }
		}
		private long receivedField;
		public long received
		{
			get { return this.receivedField; }
			set { this.receivedField = value; }
		}
		private long last_sentField;
		public long last_sent
		{
			get { return this.last_sentField; }
			set { this.last_sentField = value; }
		}
		private long expirationField;
		public long expiration
		{
			get { return this.expirationField; }
			set { this.expirationField = value; }
		}
		private long sizeField;
		public long size
		{
			get { return this.sizeField; }
			set { this.sizeField = value; }
		}
		private long rankField;
		public long rank
		{
			get { return this.rankField; }
			set { this.rankField = value; }
		}
		private long source_slotField;
		public long source_slot
		{
			get { return this.source_slotField; }
			set { this.source_slotField = value; }
		}
		private long source_tmmField;
		public long source_tmm
		{
			get { return this.source_tmmField; }
			set { this.source_tmmField = value; }
		}
		private long owner_slotField;
		public long owner_slot
		{
			get { return this.owner_slotField; }
			set { this.owner_slotField = value; }
		}
		private long owner_tmmField;
		public long owner_tmm
		{
			get { return this.owner_tmmField; }
			set { this.owner_tmmField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileWebAcceleration.CacheKey", Namespace = "urn:iControl")]
	public partial class LocalLBProfileWebAccelerationCacheKey
	{
		private string profile_nameField;
		public string profile_name
		{
			get { return this.profile_nameField; }
			set { this.profile_nameField = value; }
		}
		private string host_nameField;
		public string host_name
		{
			get { return this.host_nameField; }
			set { this.host_nameField = value; }
		}
		private string uriField;
		public string uri
		{
			get { return this.uriField; }
			set { this.uriField = value; }
		}
		private long maximum_responsesField;
		public long maximum_responses
		{
			get { return this.maximum_responsesField; }
			set { this.maximum_responsesField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileWebAcceleration.ProfileWebAccelerationStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBProfileWebAccelerationProfileWebAccelerationStatisticEntry
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileWebAcceleration.ProfileWebAccelerationStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBProfileWebAccelerationProfileWebAccelerationStatistics
	{
		private LocalLBProfileWebAccelerationProfileWebAccelerationStatisticEntry [] statisticsField;
		public LocalLBProfileWebAccelerationProfileWebAccelerationStatisticEntry [] statistics
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
