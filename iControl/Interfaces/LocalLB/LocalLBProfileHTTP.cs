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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.ProfileHttpBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileEnabledState))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileHttpProfileHttpStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileString))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileULong))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileStringArray))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileHttpCompressionMode))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileHttpProfileHTTPProxyType))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileProfileMode))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileHttpProfilePassthroughMode))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileCompressionMethod))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileRamCacheCacheControlMode))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileHttpRedirectRewriteMode))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileHttpChunkMode))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileHttpProfileViaHeader))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonProfileSFlowGlobalType))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileStatisticsByVirtual))]
	public partial class LocalLBProfileHttp : iControlInterface {
		public LocalLBProfileHttp() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_compression_content_type_exclude
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void add_compression_content_type_exclude(
		string [] profile_names,
		string [] [] reg_expressions
	) {
		this.Invoke("add_compression_content_type_exclude", new object [] {
				profile_names,
				reg_expressions});

	}
	public System.IAsyncResult Beginadd_compression_content_type_exclude(string [] profile_names,string [] [] reg_expressions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_compression_content_type_exclude", new object[] {
			profile_names,
			reg_expressions}, callback, asyncState);
	}
	public void Endadd_compression_content_type_exclude(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_compression_content_type_include
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void add_compression_content_type_include(
		string [] profile_names,
		string [] [] reg_expressions
	) {
		this.Invoke("add_compression_content_type_include", new object [] {
				profile_names,
				reg_expressions});

	}
	public System.IAsyncResult Beginadd_compression_content_type_include(string [] profile_names,string [] [] reg_expressions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_compression_content_type_include", new object[] {
			profile_names,
			reg_expressions}, callback, asyncState);
	}
	public void Endadd_compression_content_type_include(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_compression_uri_exclude
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void add_compression_uri_exclude(
		string [] profile_names,
		string [] [] reg_expressions
	) {
		this.Invoke("add_compression_uri_exclude", new object [] {
				profile_names,
				reg_expressions});

	}
	public System.IAsyncResult Beginadd_compression_uri_exclude(string [] profile_names,string [] [] reg_expressions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_compression_uri_exclude", new object[] {
			profile_names,
			reg_expressions}, callback, asyncState);
	}
	public void Endadd_compression_uri_exclude(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_compression_uri_include
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void add_compression_uri_include(
		string [] profile_names,
		string [] [] reg_expressions
	) {
		this.Invoke("add_compression_uri_include", new object [] {
				profile_names,
				reg_expressions});

	}
	public System.IAsyncResult Beginadd_compression_uri_include(string [] profile_names,string [] [] reg_expressions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_compression_uri_include", new object[] {
			profile_names,
			reg_expressions}, callback, asyncState);
	}
	public void Endadd_compression_uri_include(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_cookie_encryption
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void add_cookie_encryption(
		string [] profile_names,
		string [] [] cookies
	) {
		this.Invoke("add_cookie_encryption", new object [] {
				profile_names,
				cookies});

	}
	public System.IAsyncResult Beginadd_cookie_encryption(string [] profile_names,string [] [] cookies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_cookie_encryption", new object[] {
			profile_names,
			cookies}, callback, asyncState);
	}
	public void Endadd_cookie_encryption(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fallback_status_code
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void add_fallback_status_code(
		string [] profile_names,
		string [] [] status_codes
	) {
		this.Invoke("add_fallback_status_code", new object [] {
				profile_names,
				status_codes});

	}
	public System.IAsyncResult Beginadd_fallback_status_code(string [] profile_names,string [] [] status_codes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fallback_status_code", new object[] {
			profile_names,
			status_codes}, callback, asyncState);
	}
	public void Endadd_fallback_status_code(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_permitted_response_header
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void add_permitted_response_header(
		string [] profile_names,
		string [] [] headers
	) {
		this.Invoke("add_permitted_response_header", new object [] {
				profile_names,
				headers});

	}
	public System.IAsyncResult Beginadd_permitted_response_header(string [] profile_names,string [] [] headers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_permitted_response_header", new object[] {
			profile_names,
			headers}, callback, asyncState);
	}
	public void Endadd_permitted_response_header(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_ramcache_uri_exclude
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void add_ramcache_uri_exclude(
		string [] profile_names,
		string [] [] reg_expressions
	) {
		this.Invoke("add_ramcache_uri_exclude", new object [] {
				profile_names,
				reg_expressions});

	}
	public System.IAsyncResult Beginadd_ramcache_uri_exclude(string [] profile_names,string [] [] reg_expressions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_ramcache_uri_exclude", new object[] {
			profile_names,
			reg_expressions}, callback, asyncState);
	}
	public void Endadd_ramcache_uri_exclude(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_ramcache_uri_include
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void add_ramcache_uri_include(
		string [] profile_names,
		string [] [] reg_expressions
	) {
		this.Invoke("add_ramcache_uri_include", new object [] {
				profile_names,
				reg_expressions});

	}
	public System.IAsyncResult Beginadd_ramcache_uri_include(string [] profile_names,string [] [] reg_expressions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_ramcache_uri_include", new object[] {
			profile_names,
			reg_expressions}, callback, asyncState);
	}
	public void Endadd_ramcache_uri_include(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_ramcache_uri_pinned
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void add_ramcache_uri_pinned(
		string [] profile_names,
		string [] [] reg_expressions
	) {
		this.Invoke("add_ramcache_uri_pinned", new object [] {
				profile_names,
				reg_expressions});

	}
	public System.IAsyncResult Beginadd_ramcache_uri_pinned(string [] profile_names,string [] [] reg_expressions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_ramcache_uri_pinned", new object[] {
			profile_names,
			reg_expressions}, callback, asyncState);
	}
	public void Endadd_ramcache_uri_pinned(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_xff_alternative_names
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void add_xff_alternative_names(
		string [] profile_names,
		string [] [] headers
	) {
		this.Invoke("add_xff_alternative_names", new object [] {
				profile_names,
				headers});

	}
	public System.IAsyncResult Beginadd_xff_alternative_names(string [] profile_names,string [] [] headers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_xff_alternative_names", new object[] {
			profile_names,
			headers}, callback, asyncState);
	}
	public void Endadd_xff_alternative_names(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
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
	// get_accept_xff_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_accept_xff_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_accept_xff_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_accept_xff_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_accept_xff_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_accept_xff_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileHttpProfileHttpStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((LocalLBProfileHttpProfileHttpStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public LocalLBProfileHttpProfileHttpStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileHttpProfileHttpStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_basic_auth_realm
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_basic_auth_realm(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_basic_auth_realm", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_basic_auth_realm(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_basic_auth_realm", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_basic_auth_realm(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_compression_allow_http_10_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_compression_allow_http_10_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_compression_allow_http_10_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_compression_allow_http_10_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_compression_allow_http_10_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_compression_allow_http_10_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_compression_browser_workaround_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_compression_browser_workaround_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_compression_browser_workaround_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_compression_browser_workaround_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_compression_browser_workaround_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_compression_browser_workaround_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_compression_buffer_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_compression_buffer_size(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_compression_buffer_size", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_compression_buffer_size(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_compression_buffer_size", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_compression_buffer_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_compression_content_type_exclude
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileStringArray [] get_compression_content_type_exclude(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_compression_content_type_exclude", new object [] {
				profile_names});
		return ((LocalLBProfileStringArray [])(results[0]));
	}
	public System.IAsyncResult Beginget_compression_content_type_exclude(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_compression_content_type_exclude", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileStringArray [] Endget_compression_content_type_exclude(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileStringArray [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_compression_content_type_include
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileStringArray [] get_compression_content_type_include(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_compression_content_type_include", new object [] {
				profile_names});
		return ((LocalLBProfileStringArray [])(results[0]));
	}
	public System.IAsyncResult Beginget_compression_content_type_include(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_compression_content_type_include", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileStringArray [] Endget_compression_content_type_include(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileStringArray [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_compression_cpu_saver_high_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_compression_cpu_saver_high_threshold(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_compression_cpu_saver_high_threshold", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_compression_cpu_saver_high_threshold(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_compression_cpu_saver_high_threshold", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_compression_cpu_saver_high_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_compression_cpu_saver_low_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_compression_cpu_saver_low_threshold(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_compression_cpu_saver_low_threshold", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_compression_cpu_saver_low_threshold(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_compression_cpu_saver_low_threshold", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_compression_cpu_saver_low_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_compression_cpu_saver_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_compression_cpu_saver_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_compression_cpu_saver_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_compression_cpu_saver_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_compression_cpu_saver_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_compression_cpu_saver_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_compression_level
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_compression_level(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_compression_level", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_compression_level(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_compression_level", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_compression_level(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_compression_memory_level
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_compression_memory_level(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_compression_memory_level", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_compression_memory_level(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_compression_memory_level", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_compression_memory_level(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_compression_minimum_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_compression_minimum_size(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_compression_minimum_size", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_compression_minimum_size(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_compression_minimum_size", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_compression_minimum_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_compression_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileHttpCompressionMode [] get_compression_mode(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_compression_mode", new object [] {
				profile_names});
		return ((LocalLBProfileHttpCompressionMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_compression_mode(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_compression_mode", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileHttpCompressionMode [] Endget_compression_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileHttpCompressionMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_compression_uri_exclude
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileStringArray [] get_compression_uri_exclude(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_compression_uri_exclude", new object [] {
				profile_names});
		return ((LocalLBProfileStringArray [])(results[0]));
	}
	public System.IAsyncResult Beginget_compression_uri_exclude(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_compression_uri_exclude", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileStringArray [] Endget_compression_uri_exclude(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileStringArray [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_compression_uri_include
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileStringArray [] get_compression_uri_include(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_compression_uri_include", new object [] {
				profile_names});
		return ((LocalLBProfileStringArray [])(results[0]));
	}
	public System.IAsyncResult Beginget_compression_uri_include(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_compression_uri_include", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileStringArray [] Endget_compression_uri_include(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileStringArray [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_compression_vary_header_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_compression_vary_header_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_compression_vary_header_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_compression_vary_header_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_compression_vary_header_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_compression_vary_header_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_compression_window_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_compression_window_size(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_compression_window_size", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_compression_window_size(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_compression_window_size", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_compression_window_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cookie_encryption
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileStringArray [] get_cookie_encryption(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_cookie_encryption", new object [] {
				profile_names});
		return ((LocalLBProfileStringArray [])(results[0]));
	}
	public System.IAsyncResult Beginget_cookie_encryption(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cookie_encryption", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileStringArray [] Endget_cookie_encryption(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileStringArray [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cookie_encryption_passphrase
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_cookie_encryption_passphrase(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_cookie_encryption_passphrase", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_cookie_encryption_passphrase(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cookie_encryption_passphrase", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_cookie_encryption_passphrase(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
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
	// get_fallback_host_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_fallback_host_name(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_fallback_host_name", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_fallback_host_name(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fallback_host_name", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_fallback_host_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fallback_status_code
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileStringArray [] get_fallback_status_code(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_fallback_status_code", new object [] {
				profile_names});
		return ((LocalLBProfileStringArray [])(results[0]));
	}
	public System.IAsyncResult Beginget_fallback_status_code(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fallback_status_code", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileStringArray [] Endget_fallback_status_code(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileStringArray [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_header_erase
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_header_erase(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_header_erase", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_header_erase(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_header_erase", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_header_erase(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_header_insert
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_header_insert(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_header_insert", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_header_insert(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_header_insert", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_header_insert(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_http_proxy_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileHttpProfileHTTPProxyType [] get_http_proxy_type(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_http_proxy_type", new object [] {
				profile_names});
		return ((LocalLBProfileHttpProfileHTTPProxyType [])(results[0]));
	}
	public System.IAsyncResult Beginget_http_proxy_type(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_http_proxy_type", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileHttpProfileHTTPProxyType [] Endget_http_proxy_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileHttpProfileHTTPProxyType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_insert_xforwarded_for_header_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileProfileMode [] get_insert_xforwarded_for_header_mode(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_insert_xforwarded_for_header_mode", new object [] {
				profile_names});
		return ((LocalLBProfileProfileMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_insert_xforwarded_for_header_mode(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_insert_xforwarded_for_header_mode", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileProfileMode [] Endget_insert_xforwarded_for_header_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileProfileMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_keep_accept_encoding_header_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_keep_accept_encoding_header_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_keep_accept_encoding_header_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_keep_accept_encoding_header_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_keep_accept_encoding_header_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_keep_accept_encoding_header_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
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
	// get_lws_maximum_column
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_lws_maximum_column(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_lws_maximum_column", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_lws_maximum_column(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_lws_maximum_column", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_lws_maximum_column(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_lws_separator
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_lws_separator(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_lws_separator", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_lws_separator(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_lws_separator", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_lws_separator(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_maximum_header_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_maximum_header_size(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_maximum_header_size", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_header_size(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_header_size", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_maximum_header_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_maximum_requests
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_maximum_requests(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_maximum_requests", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_requests(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_requests", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_maximum_requests(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_oneconnect_header_transformation_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_oneconnect_header_transformation_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_oneconnect_header_transformation_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_oneconnect_header_transformation_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_oneconnect_header_transformation_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_oneconnect_header_transformation_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_passthrough_excess_client_headers_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_passthrough_excess_client_headers_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_passthrough_excess_client_headers_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_passthrough_excess_client_headers_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_passthrough_excess_client_headers_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_passthrough_excess_client_headers_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_passthrough_excess_server_headers_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_passthrough_excess_server_headers_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_passthrough_excess_server_headers_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_passthrough_excess_server_headers_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_passthrough_excess_server_headers_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_passthrough_excess_server_headers_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_passthrough_oversize_client_headers_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_passthrough_oversize_client_headers_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_passthrough_oversize_client_headers_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_passthrough_oversize_client_headers_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_passthrough_oversize_client_headers_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_passthrough_oversize_client_headers_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_passthrough_oversize_server_headers_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_passthrough_oversize_server_headers_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_passthrough_oversize_server_headers_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_passthrough_oversize_server_headers_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_passthrough_oversize_server_headers_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_passthrough_oversize_server_headers_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_passthrough_unknown_method_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileHttpProfilePassthroughMode [] get_passthrough_unknown_method_mode(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_passthrough_unknown_method_mode", new object [] {
				profile_names});
		return ((LocalLBProfileHttpProfilePassthroughMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_passthrough_unknown_method_mode(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_passthrough_unknown_method_mode", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileHttpProfilePassthroughMode [] Endget_passthrough_unknown_method_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileHttpProfilePassthroughMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_permitted_response_header
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileStringArray [] get_permitted_response_header(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_permitted_response_header", new object [] {
				profile_names});
		return ((LocalLBProfileStringArray [])(results[0]));
	}
	public System.IAsyncResult Beginget_permitted_response_header(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_permitted_response_header", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileStringArray [] Endget_permitted_response_header(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileStringArray [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_pipelining_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileProfileMode [] get_pipelining_mode(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_pipelining_mode", new object [] {
				profile_names});
		return ((LocalLBProfileProfileMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_pipelining_mode(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_pipelining_mode", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileProfileMode [] Endget_pipelining_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileProfileMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_pipelining_mode_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileHttpProfilePassthroughMode [] get_pipelining_mode_v2(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_pipelining_mode_v2", new object [] {
				profile_names});
		return ((LocalLBProfileHttpProfilePassthroughMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_pipelining_mode_v2(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_pipelining_mode_v2", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileHttpProfilePassthroughMode [] Endget_pipelining_mode_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileHttpProfilePassthroughMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_preferred_compression_method
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileCompressionMethod [] get_preferred_compression_method(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_preferred_compression_method", new object [] {
				profile_names});
		return ((LocalLBProfileCompressionMethod [])(results[0]));
	}
	public System.IAsyncResult Beginget_preferred_compression_method(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_preferred_compression_method", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileCompressionMethod [] Endget_preferred_compression_method(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileCompressionMethod [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ramcache_aging_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_ramcache_aging_rate(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_ramcache_aging_rate", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_ramcache_aging_rate(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ramcache_aging_rate", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_ramcache_aging_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ramcache_ignore_client_cache_control_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileRamCacheCacheControlMode [] get_ramcache_ignore_client_cache_control_mode(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_ramcache_ignore_client_cache_control_mode", new object [] {
				profile_names});
		return ((LocalLBProfileRamCacheCacheControlMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_ramcache_ignore_client_cache_control_mode(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ramcache_ignore_client_cache_control_mode", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileRamCacheCacheControlMode [] Endget_ramcache_ignore_client_cache_control_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileRamCacheCacheControlMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ramcache_insert_age_header_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileProfileMode [] get_ramcache_insert_age_header_mode(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_ramcache_insert_age_header_mode", new object [] {
				profile_names});
		return ((LocalLBProfileProfileMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_ramcache_insert_age_header_mode(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ramcache_insert_age_header_mode", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileProfileMode [] Endget_ramcache_insert_age_header_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileProfileMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ramcache_maximum_age
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_ramcache_maximum_age(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_ramcache_maximum_age", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_ramcache_maximum_age(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ramcache_maximum_age", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_ramcache_maximum_age(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ramcache_maximum_entry
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_ramcache_maximum_entry(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_ramcache_maximum_entry", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_ramcache_maximum_entry(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ramcache_maximum_entry", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_ramcache_maximum_entry(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ramcache_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileProfileMode [] get_ramcache_mode(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_ramcache_mode", new object [] {
				profile_names});
		return ((LocalLBProfileProfileMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_ramcache_mode(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ramcache_mode", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileProfileMode [] Endget_ramcache_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileProfileMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ramcache_object_maximum_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_ramcache_object_maximum_size(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_ramcache_object_maximum_size", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_ramcache_object_maximum_size(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ramcache_object_maximum_size", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_ramcache_object_maximum_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ramcache_object_minimum_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_ramcache_object_minimum_size(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_ramcache_object_minimum_size", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_ramcache_object_minimum_size(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ramcache_object_minimum_size", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_ramcache_object_minimum_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ramcache_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_ramcache_size(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_ramcache_size", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_ramcache_size(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ramcache_size", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_ramcache_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ramcache_uri_exclude
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileStringArray [] get_ramcache_uri_exclude(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_ramcache_uri_exclude", new object [] {
				profile_names});
		return ((LocalLBProfileStringArray [])(results[0]));
	}
	public System.IAsyncResult Beginget_ramcache_uri_exclude(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ramcache_uri_exclude", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileStringArray [] Endget_ramcache_uri_exclude(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileStringArray [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ramcache_uri_include
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileStringArray [] get_ramcache_uri_include(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_ramcache_uri_include", new object [] {
				profile_names});
		return ((LocalLBProfileStringArray [])(results[0]));
	}
	public System.IAsyncResult Beginget_ramcache_uri_include(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ramcache_uri_include", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileStringArray [] Endget_ramcache_uri_include(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileStringArray [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ramcache_uri_pinned
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileStringArray [] get_ramcache_uri_pinned(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_ramcache_uri_pinned", new object [] {
				profile_names});
		return ((LocalLBProfileStringArray [])(results[0]));
	}
	public System.IAsyncResult Beginget_ramcache_uri_pinned(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ramcache_uri_pinned", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileStringArray [] Endget_ramcache_uri_pinned(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileStringArray [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_redirect_rewrite_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileHttpRedirectRewriteMode [] get_redirect_rewrite_mode(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_redirect_rewrite_mode", new object [] {
				profile_names});
		return ((LocalLBProfileHttpRedirectRewriteMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_redirect_rewrite_mode(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_redirect_rewrite_mode", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileHttpRedirectRewriteMode [] Endget_redirect_rewrite_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileHttpRedirectRewriteMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_request_chunk_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileHttpChunkMode [] get_request_chunk_mode(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_request_chunk_mode", new object [] {
				profile_names});
		return ((LocalLBProfileHttpChunkMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_request_chunk_mode(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_request_chunk_mode", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileHttpChunkMode [] Endget_request_chunk_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileHttpChunkMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_response_chunk_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileHttpChunkMode [] get_response_chunk_mode(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_response_chunk_mode", new object [] {
				profile_names});
		return ((LocalLBProfileHttpChunkMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_response_chunk_mode(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_response_chunk_mode", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileHttpChunkMode [] Endget_response_chunk_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileHttpChunkMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_security_enabled_request_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_security_enabled_request_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_security_enabled_request_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_security_enabled_request_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_security_enabled_request_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_security_enabled_request_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_send_proxy_via_header_host_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_send_proxy_via_header_host_name(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_send_proxy_via_header_host_name", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_send_proxy_via_header_host_name(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_send_proxy_via_header_host_name", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_send_proxy_via_header_host_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_send_proxy_via_header_type_in_request
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileHttpProfileViaHeader [] get_send_proxy_via_header_type_in_request(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_send_proxy_via_header_type_in_request", new object [] {
				profile_names});
		return ((LocalLBProfileHttpProfileViaHeader [])(results[0]));
	}
	public System.IAsyncResult Beginget_send_proxy_via_header_type_in_request(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_send_proxy_via_header_type_in_request", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileHttpProfileViaHeader [] Endget_send_proxy_via_header_type_in_request(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileHttpProfileViaHeader [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_send_proxy_via_header_type_in_response
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileHttpProfileViaHeader [] get_send_proxy_via_header_type_in_response(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_send_proxy_via_header_type_in_response", new object [] {
				profile_names});
		return ((LocalLBProfileHttpProfileViaHeader [])(results[0]));
	}
	public System.IAsyncResult Beginget_send_proxy_via_header_type_in_response(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_send_proxy_via_header_type_in_response", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileHttpProfileViaHeader [] Endget_send_proxy_via_header_type_in_response(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileHttpProfileViaHeader [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_server_agent_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_server_agent_name(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_server_agent_name", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_server_agent_name(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_server_agent_name", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_server_agent_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_sflow_poll_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_sflow_poll_interval(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_sflow_poll_interval", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_sflow_poll_interval(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_sflow_poll_interval", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_sflow_poll_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_sflow_poll_interval_global
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonProfileSFlowGlobalType [] get_sflow_poll_interval_global(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_sflow_poll_interval_global", new object [] {
				profile_names});
		return ((CommonProfileSFlowGlobalType [])(results[0]));
	}
	public System.IAsyncResult Beginget_sflow_poll_interval_global(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_sflow_poll_interval_global", new object[] {
			profile_names}, callback, asyncState);
	}
	public CommonProfileSFlowGlobalType [] Endget_sflow_poll_interval_global(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonProfileSFlowGlobalType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_sflow_sampling_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_sflow_sampling_rate(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_sflow_sampling_rate", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_sflow_sampling_rate(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_sflow_sampling_rate", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_sflow_sampling_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_sflow_sampling_rate_global
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonProfileSFlowGlobalType [] get_sflow_sampling_rate_global(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_sflow_sampling_rate_global", new object [] {
				profile_names});
		return ((CommonProfileSFlowGlobalType [])(results[0]));
	}
	public System.IAsyncResult Beginget_sflow_sampling_rate_global(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_sflow_sampling_rate_global", new object[] {
			profile_names}, callback, asyncState);
	}
	public CommonProfileSFlowGlobalType [] Endget_sflow_sampling_rate_global(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonProfileSFlowGlobalType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileHttpProfileHttpStatistics get_statistics(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				profile_names});
		return ((LocalLBProfileHttpProfileHttpStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileHttpProfileHttpStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileHttpProfileHttpStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics_by_virtual
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
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
	// get_truncated_redirect_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileProfileMode [] get_truncated_redirect_mode(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_truncated_redirect_mode", new object [] {
				profile_names});
		return ((LocalLBProfileProfileMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_truncated_redirect_mode(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_truncated_redirect_mode", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileProfileMode [] Endget_truncated_redirect_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileProfileMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
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
	// get_xff_alternative_names
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileStringArray [] get_xff_alternative_names(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_xff_alternative_names", new object [] {
				profile_names});
		return ((LocalLBProfileStringArray [])(results[0]));
	}
	public System.IAsyncResult Beginget_xff_alternative_names(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_xff_alternative_names", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileStringArray [] Endget_xff_alternative_names(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileStringArray [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// is_base_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
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
	// remove_all_xff_alternative_names
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void remove_all_xff_alternative_names(
		string [] profile_names
	) {
		this.Invoke("remove_all_xff_alternative_names", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginremove_all_xff_alternative_names(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_xff_alternative_names", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endremove_all_xff_alternative_names(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_compression_content_type_exclude
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void remove_compression_content_type_exclude(
		string [] profile_names,
		string [] [] reg_expressions
	) {
		this.Invoke("remove_compression_content_type_exclude", new object [] {
				profile_names,
				reg_expressions});

	}
	public System.IAsyncResult Beginremove_compression_content_type_exclude(string [] profile_names,string [] [] reg_expressions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_compression_content_type_exclude", new object[] {
			profile_names,
			reg_expressions}, callback, asyncState);
	}
	public void Endremove_compression_content_type_exclude(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_compression_content_type_include
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void remove_compression_content_type_include(
		string [] profile_names,
		string [] [] reg_expressions
	) {
		this.Invoke("remove_compression_content_type_include", new object [] {
				profile_names,
				reg_expressions});

	}
	public System.IAsyncResult Beginremove_compression_content_type_include(string [] profile_names,string [] [] reg_expressions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_compression_content_type_include", new object[] {
			profile_names,
			reg_expressions}, callback, asyncState);
	}
	public void Endremove_compression_content_type_include(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_compression_uri_exclude
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void remove_compression_uri_exclude(
		string [] profile_names,
		string [] [] reg_expressions
	) {
		this.Invoke("remove_compression_uri_exclude", new object [] {
				profile_names,
				reg_expressions});

	}
	public System.IAsyncResult Beginremove_compression_uri_exclude(string [] profile_names,string [] [] reg_expressions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_compression_uri_exclude", new object[] {
			profile_names,
			reg_expressions}, callback, asyncState);
	}
	public void Endremove_compression_uri_exclude(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_compression_uri_include
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void remove_compression_uri_include(
		string [] profile_names,
		string [] [] reg_expressions
	) {
		this.Invoke("remove_compression_uri_include", new object [] {
				profile_names,
				reg_expressions});

	}
	public System.IAsyncResult Beginremove_compression_uri_include(string [] profile_names,string [] [] reg_expressions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_compression_uri_include", new object[] {
			profile_names,
			reg_expressions}, callback, asyncState);
	}
	public void Endremove_compression_uri_include(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_cookie_encryption
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void remove_cookie_encryption(
		string [] profile_names,
		string [] [] cookies
	) {
		this.Invoke("remove_cookie_encryption", new object [] {
				profile_names,
				cookies});

	}
	public System.IAsyncResult Beginremove_cookie_encryption(string [] profile_names,string [] [] cookies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_cookie_encryption", new object[] {
			profile_names,
			cookies}, callback, asyncState);
	}
	public void Endremove_cookie_encryption(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fallback_status_code
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void remove_fallback_status_code(
		string [] profile_names,
		string [] [] status_codes
	) {
		this.Invoke("remove_fallback_status_code", new object [] {
				profile_names,
				status_codes});

	}
	public System.IAsyncResult Beginremove_fallback_status_code(string [] profile_names,string [] [] status_codes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fallback_status_code", new object[] {
			profile_names,
			status_codes}, callback, asyncState);
	}
	public void Endremove_fallback_status_code(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_permitted_response_header
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void remove_permitted_response_header(
		string [] profile_names,
		string [] [] headers
	) {
		this.Invoke("remove_permitted_response_header", new object [] {
				profile_names,
				headers});

	}
	public System.IAsyncResult Beginremove_permitted_response_header(string [] profile_names,string [] [] headers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_permitted_response_header", new object[] {
			profile_names,
			headers}, callback, asyncState);
	}
	public void Endremove_permitted_response_header(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_ramcache_uri_exclude
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void remove_ramcache_uri_exclude(
		string [] profile_names,
		string [] [] reg_expressions
	) {
		this.Invoke("remove_ramcache_uri_exclude", new object [] {
				profile_names,
				reg_expressions});

	}
	public System.IAsyncResult Beginremove_ramcache_uri_exclude(string [] profile_names,string [] [] reg_expressions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_ramcache_uri_exclude", new object[] {
			profile_names,
			reg_expressions}, callback, asyncState);
	}
	public void Endremove_ramcache_uri_exclude(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_ramcache_uri_include
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void remove_ramcache_uri_include(
		string [] profile_names,
		string [] [] reg_expressions
	) {
		this.Invoke("remove_ramcache_uri_include", new object [] {
				profile_names,
				reg_expressions});

	}
	public System.IAsyncResult Beginremove_ramcache_uri_include(string [] profile_names,string [] [] reg_expressions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_ramcache_uri_include", new object[] {
			profile_names,
			reg_expressions}, callback, asyncState);
	}
	public void Endremove_ramcache_uri_include(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_ramcache_uri_pinned
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void remove_ramcache_uri_pinned(
		string [] profile_names,
		string [] [] reg_expressions
	) {
		this.Invoke("remove_ramcache_uri_pinned", new object [] {
				profile_names,
				reg_expressions});

	}
	public System.IAsyncResult Beginremove_ramcache_uri_pinned(string [] profile_names,string [] [] reg_expressions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_ramcache_uri_pinned", new object[] {
			profile_names,
			reg_expressions}, callback, asyncState);
	}
	public void Endremove_ramcache_uri_pinned(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_xff_alternative_names
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void remove_xff_alternative_names(
		string [] profile_names,
		string [] [] headers
	) {
		this.Invoke("remove_xff_alternative_names", new object [] {
				profile_names,
				headers});

	}
	public System.IAsyncResult Beginremove_xff_alternative_names(string [] profile_names,string [] [] headers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_xff_alternative_names", new object[] {
			profile_names,
			headers}, callback, asyncState);
	}
	public void Endremove_xff_alternative_names(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
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
	// set_accept_xff_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_accept_xff_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_accept_xff_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_accept_xff_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_accept_xff_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_accept_xff_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_basic_auth_realm
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_basic_auth_realm(
		string [] profile_names,
		LocalLBProfileString [] realms
	) {
		this.Invoke("set_basic_auth_realm", new object [] {
				profile_names,
				realms});

	}
	public System.IAsyncResult Beginset_basic_auth_realm(string [] profile_names,LocalLBProfileString [] realms, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_basic_auth_realm", new object[] {
			profile_names,
			realms}, callback, asyncState);
	}
	public void Endset_basic_auth_realm(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_compression_allow_http_10_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_compression_allow_http_10_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_compression_allow_http_10_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_compression_allow_http_10_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_compression_allow_http_10_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_compression_allow_http_10_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_compression_browser_workaround_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_compression_browser_workaround_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_compression_browser_workaround_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_compression_browser_workaround_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_compression_browser_workaround_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_compression_browser_workaround_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_compression_buffer_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_compression_buffer_size(
		string [] profile_names,
		LocalLBProfileULong [] sizes
	) {
		this.Invoke("set_compression_buffer_size", new object [] {
				profile_names,
				sizes});

	}
	public System.IAsyncResult Beginset_compression_buffer_size(string [] profile_names,LocalLBProfileULong [] sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_compression_buffer_size", new object[] {
			profile_names,
			sizes}, callback, asyncState);
	}
	public void Endset_compression_buffer_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_compression_cpu_saver_high_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_compression_cpu_saver_high_threshold(
		string [] profile_names,
		LocalLBProfileULong [] thresholds
	) {
		this.Invoke("set_compression_cpu_saver_high_threshold", new object [] {
				profile_names,
				thresholds});

	}
	public System.IAsyncResult Beginset_compression_cpu_saver_high_threshold(string [] profile_names,LocalLBProfileULong [] thresholds, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_compression_cpu_saver_high_threshold", new object[] {
			profile_names,
			thresholds}, callback, asyncState);
	}
	public void Endset_compression_cpu_saver_high_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_compression_cpu_saver_low_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_compression_cpu_saver_low_threshold(
		string [] profile_names,
		LocalLBProfileULong [] thresholds
	) {
		this.Invoke("set_compression_cpu_saver_low_threshold", new object [] {
				profile_names,
				thresholds});

	}
	public System.IAsyncResult Beginset_compression_cpu_saver_low_threshold(string [] profile_names,LocalLBProfileULong [] thresholds, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_compression_cpu_saver_low_threshold", new object[] {
			profile_names,
			thresholds}, callback, asyncState);
	}
	public void Endset_compression_cpu_saver_low_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_compression_cpu_saver_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_compression_cpu_saver_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_compression_cpu_saver_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_compression_cpu_saver_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_compression_cpu_saver_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_compression_cpu_saver_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_compression_level
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_compression_level(
		string [] profile_names,
		LocalLBProfileULong [] levels
	) {
		this.Invoke("set_compression_level", new object [] {
				profile_names,
				levels});

	}
	public System.IAsyncResult Beginset_compression_level(string [] profile_names,LocalLBProfileULong [] levels, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_compression_level", new object[] {
			profile_names,
			levels}, callback, asyncState);
	}
	public void Endset_compression_level(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_compression_memory_level
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_compression_memory_level(
		string [] profile_names,
		LocalLBProfileULong [] levels
	) {
		this.Invoke("set_compression_memory_level", new object [] {
				profile_names,
				levels});

	}
	public System.IAsyncResult Beginset_compression_memory_level(string [] profile_names,LocalLBProfileULong [] levels, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_compression_memory_level", new object[] {
			profile_names,
			levels}, callback, asyncState);
	}
	public void Endset_compression_memory_level(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_compression_minimum_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_compression_minimum_size(
		string [] profile_names,
		LocalLBProfileULong [] sizes
	) {
		this.Invoke("set_compression_minimum_size", new object [] {
				profile_names,
				sizes});

	}
	public System.IAsyncResult Beginset_compression_minimum_size(string [] profile_names,LocalLBProfileULong [] sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_compression_minimum_size", new object[] {
			profile_names,
			sizes}, callback, asyncState);
	}
	public void Endset_compression_minimum_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_compression_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_compression_mode(
		string [] profile_names,
		LocalLBProfileHttpCompressionMode [] modes
	) {
		this.Invoke("set_compression_mode", new object [] {
				profile_names,
				modes});

	}
	public System.IAsyncResult Beginset_compression_mode(string [] profile_names,LocalLBProfileHttpCompressionMode [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_compression_mode", new object[] {
			profile_names,
			modes}, callback, asyncState);
	}
	public void Endset_compression_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_compression_vary_header_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_compression_vary_header_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_compression_vary_header_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_compression_vary_header_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_compression_vary_header_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_compression_vary_header_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_compression_window_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_compression_window_size(
		string [] profile_names,
		LocalLBProfileULong [] sizes
	) {
		this.Invoke("set_compression_window_size", new object [] {
				profile_names,
				sizes});

	}
	public System.IAsyncResult Beginset_compression_window_size(string [] profile_names,LocalLBProfileULong [] sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_compression_window_size", new object[] {
			profile_names,
			sizes}, callback, asyncState);
	}
	public void Endset_compression_window_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_cookie_encryption_passphrase
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_cookie_encryption_passphrase(
		string [] profile_names,
		LocalLBProfileString [] passphrases
	) {
		this.Invoke("set_cookie_encryption_passphrase", new object [] {
				profile_names,
				passphrases});

	}
	public System.IAsyncResult Beginset_cookie_encryption_passphrase(string [] profile_names,LocalLBProfileString [] passphrases, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cookie_encryption_passphrase", new object[] {
			profile_names,
			passphrases}, callback, asyncState);
	}
	public void Endset_cookie_encryption_passphrase(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_compression_content_type_exclude
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_default_compression_content_type_exclude(
		string [] profile_names
	) {
		this.Invoke("set_default_compression_content_type_exclude", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginset_default_compression_content_type_exclude(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_compression_content_type_exclude", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endset_default_compression_content_type_exclude(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_compression_content_type_include
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_default_compression_content_type_include(
		string [] profile_names
	) {
		this.Invoke("set_default_compression_content_type_include", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginset_default_compression_content_type_include(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_compression_content_type_include", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endset_default_compression_content_type_include(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_compression_uri_exclude
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_default_compression_uri_exclude(
		string [] profile_names
	) {
		this.Invoke("set_default_compression_uri_exclude", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginset_default_compression_uri_exclude(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_compression_uri_exclude", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endset_default_compression_uri_exclude(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_compression_uri_include
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_default_compression_uri_include(
		string [] profile_names
	) {
		this.Invoke("set_default_compression_uri_include", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginset_default_compression_uri_include(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_compression_uri_include", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endset_default_compression_uri_include(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_cookie_encryption
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_default_cookie_encryption(
		string [] profile_names
	) {
		this.Invoke("set_default_cookie_encryption", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginset_default_cookie_encryption(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_cookie_encryption", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endset_default_cookie_encryption(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_fallback_status_code
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_default_fallback_status_code(
		string [] profile_names
	) {
		this.Invoke("set_default_fallback_status_code", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginset_default_fallback_status_code(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_fallback_status_code", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endset_default_fallback_status_code(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_permitted_response_header
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_default_permitted_response_header(
		string [] profile_names
	) {
		this.Invoke("set_default_permitted_response_header", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginset_default_permitted_response_header(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_permitted_response_header", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endset_default_permitted_response_header(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
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
	// set_default_ramcache_uri_exclude
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_default_ramcache_uri_exclude(
		string [] profile_names
	) {
		this.Invoke("set_default_ramcache_uri_exclude", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginset_default_ramcache_uri_exclude(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_ramcache_uri_exclude", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endset_default_ramcache_uri_exclude(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_ramcache_uri_include
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_default_ramcache_uri_include(
		string [] profile_names
	) {
		this.Invoke("set_default_ramcache_uri_include", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginset_default_ramcache_uri_include(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_ramcache_uri_include", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endset_default_ramcache_uri_include(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_ramcache_uri_pinned
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_default_ramcache_uri_pinned(
		string [] profile_names
	) {
		this.Invoke("set_default_ramcache_uri_pinned", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginset_default_ramcache_uri_pinned(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_ramcache_uri_pinned", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endset_default_ramcache_uri_pinned(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_xff_alternative_names
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_default_xff_alternative_names(
		string [] profile_names
	) {
		this.Invoke("set_default_xff_alternative_names", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginset_default_xff_alternative_names(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_xff_alternative_names", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endset_default_xff_alternative_names(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
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
	// set_fallback_host_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_fallback_host_name(
		string [] profile_names,
		LocalLBProfileString [] fallbacks
	) {
		this.Invoke("set_fallback_host_name", new object [] {
				profile_names,
				fallbacks});

	}
	public System.IAsyncResult Beginset_fallback_host_name(string [] profile_names,LocalLBProfileString [] fallbacks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fallback_host_name", new object[] {
			profile_names,
			fallbacks}, callback, asyncState);
	}
	public void Endset_fallback_host_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_header_erase
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_header_erase(
		string [] profile_names,
		LocalLBProfileString [] headers
	) {
		this.Invoke("set_header_erase", new object [] {
				profile_names,
				headers});

	}
	public System.IAsyncResult Beginset_header_erase(string [] profile_names,LocalLBProfileString [] headers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_header_erase", new object[] {
			profile_names,
			headers}, callback, asyncState);
	}
	public void Endset_header_erase(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_header_insert
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_header_insert(
		string [] profile_names,
		LocalLBProfileString [] headers
	) {
		this.Invoke("set_header_insert", new object [] {
				profile_names,
				headers});

	}
	public System.IAsyncResult Beginset_header_insert(string [] profile_names,LocalLBProfileString [] headers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_header_insert", new object[] {
			profile_names,
			headers}, callback, asyncState);
	}
	public void Endset_header_insert(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_insert_xforwarded_for_header_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_insert_xforwarded_for_header_mode(
		string [] profile_names,
		LocalLBProfileProfileMode [] modes
	) {
		this.Invoke("set_insert_xforwarded_for_header_mode", new object [] {
				profile_names,
				modes});

	}
	public System.IAsyncResult Beginset_insert_xforwarded_for_header_mode(string [] profile_names,LocalLBProfileProfileMode [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_insert_xforwarded_for_header_mode", new object[] {
			profile_names,
			modes}, callback, asyncState);
	}
	public void Endset_insert_xforwarded_for_header_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_keep_accept_encoding_header_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_keep_accept_encoding_header_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_keep_accept_encoding_header_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_keep_accept_encoding_header_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_keep_accept_encoding_header_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_keep_accept_encoding_header_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_lws_maximum_column
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_lws_maximum_column(
		string [] profile_names,
		LocalLBProfileULong [] sizes
	) {
		this.Invoke("set_lws_maximum_column", new object [] {
				profile_names,
				sizes});

	}
	public System.IAsyncResult Beginset_lws_maximum_column(string [] profile_names,LocalLBProfileULong [] sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_lws_maximum_column", new object[] {
			profile_names,
			sizes}, callback, asyncState);
	}
	public void Endset_lws_maximum_column(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_lws_separator
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_lws_separator(
		string [] profile_names,
		LocalLBProfileString [] separators
	) {
		this.Invoke("set_lws_separator", new object [] {
				profile_names,
				separators});

	}
	public System.IAsyncResult Beginset_lws_separator(string [] profile_names,LocalLBProfileString [] separators, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_lws_separator", new object[] {
			profile_names,
			separators}, callback, asyncState);
	}
	public void Endset_lws_separator(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_header_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_maximum_header_size(
		string [] profile_names,
		LocalLBProfileULong [] sizes
	) {
		this.Invoke("set_maximum_header_size", new object [] {
				profile_names,
				sizes});

	}
	public System.IAsyncResult Beginset_maximum_header_size(string [] profile_names,LocalLBProfileULong [] sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_header_size", new object[] {
			profile_names,
			sizes}, callback, asyncState);
	}
	public void Endset_maximum_header_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_requests
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_maximum_requests(
		string [] profile_names,
		LocalLBProfileULong [] maximum_requests
	) {
		this.Invoke("set_maximum_requests", new object [] {
				profile_names,
				maximum_requests});

	}
	public System.IAsyncResult Beginset_maximum_requests(string [] profile_names,LocalLBProfileULong [] maximum_requests, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_requests", new object[] {
			profile_names,
			maximum_requests}, callback, asyncState);
	}
	public void Endset_maximum_requests(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_oneconnect_header_transformation_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_oneconnect_header_transformation_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_oneconnect_header_transformation_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_oneconnect_header_transformation_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_oneconnect_header_transformation_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_oneconnect_header_transformation_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_passthrough_excess_client_headers_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_passthrough_excess_client_headers_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_passthrough_excess_client_headers_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_passthrough_excess_client_headers_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_passthrough_excess_client_headers_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_passthrough_excess_client_headers_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_passthrough_excess_server_headers_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_passthrough_excess_server_headers_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_passthrough_excess_server_headers_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_passthrough_excess_server_headers_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_passthrough_excess_server_headers_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_passthrough_excess_server_headers_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_passthrough_oversize_client_headers_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_passthrough_oversize_client_headers_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_passthrough_oversize_client_headers_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_passthrough_oversize_client_headers_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_passthrough_oversize_client_headers_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_passthrough_oversize_client_headers_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_passthrough_oversize_server_headers_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_passthrough_oversize_server_headers_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_passthrough_oversize_server_headers_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_passthrough_oversize_server_headers_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_passthrough_oversize_server_headers_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_passthrough_oversize_server_headers_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_passthrough_unknown_method_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_passthrough_unknown_method_mode(
		string [] profile_names,
		LocalLBProfileHttpProfilePassthroughMode [] modes
	) {
		this.Invoke("set_passthrough_unknown_method_mode", new object [] {
				profile_names,
				modes});

	}
	public System.IAsyncResult Beginset_passthrough_unknown_method_mode(string [] profile_names,LocalLBProfileHttpProfilePassthroughMode [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_passthrough_unknown_method_mode", new object[] {
			profile_names,
			modes}, callback, asyncState);
	}
	public void Endset_passthrough_unknown_method_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_pipelining_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_pipelining_mode(
		string [] profile_names,
		LocalLBProfileProfileMode [] modes
	) {
		this.Invoke("set_pipelining_mode", new object [] {
				profile_names,
				modes});

	}
	public System.IAsyncResult Beginset_pipelining_mode(string [] profile_names,LocalLBProfileProfileMode [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_pipelining_mode", new object[] {
			profile_names,
			modes}, callback, asyncState);
	}
	public void Endset_pipelining_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_pipelining_mode_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_pipelining_mode_v2(
		string [] profile_names,
		LocalLBProfileHttpProfilePassthroughMode [] modes
	) {
		this.Invoke("set_pipelining_mode_v2", new object [] {
				profile_names,
				modes});

	}
	public System.IAsyncResult Beginset_pipelining_mode_v2(string [] profile_names,LocalLBProfileHttpProfilePassthroughMode [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_pipelining_mode_v2", new object[] {
			profile_names,
			modes}, callback, asyncState);
	}
	public void Endset_pipelining_mode_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_preferred_compression_method
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_preferred_compression_method(
		string [] profile_names,
		LocalLBProfileCompressionMethod [] compression_methods
	) {
		this.Invoke("set_preferred_compression_method", new object [] {
				profile_names,
				compression_methods});

	}
	public System.IAsyncResult Beginset_preferred_compression_method(string [] profile_names,LocalLBProfileCompressionMethod [] compression_methods, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_preferred_compression_method", new object[] {
			profile_names,
			compression_methods}, callback, asyncState);
	}
	public void Endset_preferred_compression_method(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ramcache_aging_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_ramcache_aging_rate(
		string [] profile_names,
		LocalLBProfileULong [] aging_rates
	) {
		this.Invoke("set_ramcache_aging_rate", new object [] {
				profile_names,
				aging_rates});

	}
	public System.IAsyncResult Beginset_ramcache_aging_rate(string [] profile_names,LocalLBProfileULong [] aging_rates, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ramcache_aging_rate", new object[] {
			profile_names,
			aging_rates}, callback, asyncState);
	}
	public void Endset_ramcache_aging_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ramcache_ignore_client_cache_control_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_ramcache_ignore_client_cache_control_mode(
		string [] profile_names,
		LocalLBProfileRamCacheCacheControlMode [] modes
	) {
		this.Invoke("set_ramcache_ignore_client_cache_control_mode", new object [] {
				profile_names,
				modes});

	}
	public System.IAsyncResult Beginset_ramcache_ignore_client_cache_control_mode(string [] profile_names,LocalLBProfileRamCacheCacheControlMode [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ramcache_ignore_client_cache_control_mode", new object[] {
			profile_names,
			modes}, callback, asyncState);
	}
	public void Endset_ramcache_ignore_client_cache_control_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ramcache_insert_age_header_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_ramcache_insert_age_header_mode(
		string [] profile_names,
		LocalLBProfileProfileMode [] modes
	) {
		this.Invoke("set_ramcache_insert_age_header_mode", new object [] {
				profile_names,
				modes});

	}
	public System.IAsyncResult Beginset_ramcache_insert_age_header_mode(string [] profile_names,LocalLBProfileProfileMode [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ramcache_insert_age_header_mode", new object[] {
			profile_names,
			modes}, callback, asyncState);
	}
	public void Endset_ramcache_insert_age_header_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ramcache_maximum_age
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_ramcache_maximum_age(
		string [] profile_names,
		LocalLBProfileULong [] maximum_age
	) {
		this.Invoke("set_ramcache_maximum_age", new object [] {
				profile_names,
				maximum_age});

	}
	public System.IAsyncResult Beginset_ramcache_maximum_age(string [] profile_names,LocalLBProfileULong [] maximum_age, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ramcache_maximum_age", new object[] {
			profile_names,
			maximum_age}, callback, asyncState);
	}
	public void Endset_ramcache_maximum_age(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ramcache_maximum_entry
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_ramcache_maximum_entry(
		string [] profile_names,
		LocalLBProfileULong [] maximum_entries
	) {
		this.Invoke("set_ramcache_maximum_entry", new object [] {
				profile_names,
				maximum_entries});

	}
	public System.IAsyncResult Beginset_ramcache_maximum_entry(string [] profile_names,LocalLBProfileULong [] maximum_entries, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ramcache_maximum_entry", new object[] {
			profile_names,
			maximum_entries}, callback, asyncState);
	}
	public void Endset_ramcache_maximum_entry(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ramcache_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_ramcache_mode(
		string [] profile_names,
		LocalLBProfileProfileMode [] modes
	) {
		this.Invoke("set_ramcache_mode", new object [] {
				profile_names,
				modes});

	}
	public System.IAsyncResult Beginset_ramcache_mode(string [] profile_names,LocalLBProfileProfileMode [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ramcache_mode", new object[] {
			profile_names,
			modes}, callback, asyncState);
	}
	public void Endset_ramcache_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ramcache_object_maximum_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_ramcache_object_maximum_size(
		string [] profile_names,
		LocalLBProfileULong [] maximum_size
	) {
		this.Invoke("set_ramcache_object_maximum_size", new object [] {
				profile_names,
				maximum_size});

	}
	public System.IAsyncResult Beginset_ramcache_object_maximum_size(string [] profile_names,LocalLBProfileULong [] maximum_size, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ramcache_object_maximum_size", new object[] {
			profile_names,
			maximum_size}, callback, asyncState);
	}
	public void Endset_ramcache_object_maximum_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ramcache_object_minimum_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_ramcache_object_minimum_size(
		string [] profile_names,
		LocalLBProfileULong [] minimum_size
	) {
		this.Invoke("set_ramcache_object_minimum_size", new object [] {
				profile_names,
				minimum_size});

	}
	public System.IAsyncResult Beginset_ramcache_object_minimum_size(string [] profile_names,LocalLBProfileULong [] minimum_size, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ramcache_object_minimum_size", new object[] {
			profile_names,
			minimum_size}, callback, asyncState);
	}
	public void Endset_ramcache_object_minimum_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ramcache_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_ramcache_size(
		string [] profile_names,
		LocalLBProfileULong [] sizes
	) {
		this.Invoke("set_ramcache_size", new object [] {
				profile_names,
				sizes});

	}
	public System.IAsyncResult Beginset_ramcache_size(string [] profile_names,LocalLBProfileULong [] sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ramcache_size", new object[] {
			profile_names,
			sizes}, callback, asyncState);
	}
	public void Endset_ramcache_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_redirect_rewrite_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_redirect_rewrite_mode(
		string [] profile_names,
		LocalLBProfileHttpRedirectRewriteMode [] modes
	) {
		this.Invoke("set_redirect_rewrite_mode", new object [] {
				profile_names,
				modes});

	}
	public System.IAsyncResult Beginset_redirect_rewrite_mode(string [] profile_names,LocalLBProfileHttpRedirectRewriteMode [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_redirect_rewrite_mode", new object[] {
			profile_names,
			modes}, callback, asyncState);
	}
	public void Endset_redirect_rewrite_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_request_chunk_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_request_chunk_mode(
		string [] profile_names,
		LocalLBProfileHttpChunkMode [] modes
	) {
		this.Invoke("set_request_chunk_mode", new object [] {
				profile_names,
				modes});

	}
	public System.IAsyncResult Beginset_request_chunk_mode(string [] profile_names,LocalLBProfileHttpChunkMode [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_request_chunk_mode", new object[] {
			profile_names,
			modes}, callback, asyncState);
	}
	public void Endset_request_chunk_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_response_chunk_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_response_chunk_mode(
		string [] profile_names,
		LocalLBProfileHttpChunkMode [] modes
	) {
		this.Invoke("set_response_chunk_mode", new object [] {
				profile_names,
				modes});

	}
	public System.IAsyncResult Beginset_response_chunk_mode(string [] profile_names,LocalLBProfileHttpChunkMode [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_response_chunk_mode", new object[] {
			profile_names,
			modes}, callback, asyncState);
	}
	public void Endset_response_chunk_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_security_enabled_request_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_security_enabled_request_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_security_enabled_request_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_security_enabled_request_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_security_enabled_request_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_security_enabled_request_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_send_proxy_via_header_host_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_send_proxy_via_header_host_name(
		string [] profile_names,
		LocalLBProfileString [] hostnames
	) {
		this.Invoke("set_send_proxy_via_header_host_name", new object [] {
				profile_names,
				hostnames});

	}
	public System.IAsyncResult Beginset_send_proxy_via_header_host_name(string [] profile_names,LocalLBProfileString [] hostnames, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_send_proxy_via_header_host_name", new object[] {
			profile_names,
			hostnames}, callback, asyncState);
	}
	public void Endset_send_proxy_via_header_host_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_send_proxy_via_header_type_in_request
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_send_proxy_via_header_type_in_request(
		string [] profile_names,
		LocalLBProfileHttpProfileViaHeader [] types
	) {
		this.Invoke("set_send_proxy_via_header_type_in_request", new object [] {
				profile_names,
				types});

	}
	public System.IAsyncResult Beginset_send_proxy_via_header_type_in_request(string [] profile_names,LocalLBProfileHttpProfileViaHeader [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_send_proxy_via_header_type_in_request", new object[] {
			profile_names,
			types}, callback, asyncState);
	}
	public void Endset_send_proxy_via_header_type_in_request(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_send_proxy_via_header_type_in_response
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_send_proxy_via_header_type_in_response(
		string [] profile_names,
		LocalLBProfileHttpProfileViaHeader [] types
	) {
		this.Invoke("set_send_proxy_via_header_type_in_response", new object [] {
				profile_names,
				types});

	}
	public System.IAsyncResult Beginset_send_proxy_via_header_type_in_response(string [] profile_names,LocalLBProfileHttpProfileViaHeader [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_send_proxy_via_header_type_in_response", new object[] {
			profile_names,
			types}, callback, asyncState);
	}
	public void Endset_send_proxy_via_header_type_in_response(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_server_agent_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_server_agent_name(
		string [] profile_names,
		LocalLBProfileString [] names
	) {
		this.Invoke("set_server_agent_name", new object [] {
				profile_names,
				names});

	}
	public System.IAsyncResult Beginset_server_agent_name(string [] profile_names,LocalLBProfileString [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_server_agent_name", new object[] {
			profile_names,
			names}, callback, asyncState);
	}
	public void Endset_server_agent_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_sflow_poll_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_sflow_poll_interval(
		string [] profile_names,
		LocalLBProfileULong [] intervals
	) {
		this.Invoke("set_sflow_poll_interval", new object [] {
				profile_names,
				intervals});

	}
	public System.IAsyncResult Beginset_sflow_poll_interval(string [] profile_names,LocalLBProfileULong [] intervals, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_sflow_poll_interval", new object[] {
			profile_names,
			intervals}, callback, asyncState);
	}
	public void Endset_sflow_poll_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_sflow_poll_interval_global
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_sflow_poll_interval_global(
		string [] profile_names,
		CommonProfileSFlowGlobalType [] types
	) {
		this.Invoke("set_sflow_poll_interval_global", new object [] {
				profile_names,
				types});

	}
	public System.IAsyncResult Beginset_sflow_poll_interval_global(string [] profile_names,CommonProfileSFlowGlobalType [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_sflow_poll_interval_global", new object[] {
			profile_names,
			types}, callback, asyncState);
	}
	public void Endset_sflow_poll_interval_global(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_sflow_sampling_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_sflow_sampling_rate(
		string [] profile_names,
		LocalLBProfileULong [] rates
	) {
		this.Invoke("set_sflow_sampling_rate", new object [] {
				profile_names,
				rates});

	}
	public System.IAsyncResult Beginset_sflow_sampling_rate(string [] profile_names,LocalLBProfileULong [] rates, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_sflow_sampling_rate", new object[] {
			profile_names,
			rates}, callback, asyncState);
	}
	public void Endset_sflow_sampling_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_sflow_sampling_rate_global
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_sflow_sampling_rate_global(
		string [] profile_names,
		CommonProfileSFlowGlobalType [] types
	) {
		this.Invoke("set_sflow_sampling_rate_global", new object [] {
				profile_names,
				types});

	}
	public System.IAsyncResult Beginset_sflow_sampling_rate_global(string [] profile_names,CommonProfileSFlowGlobalType [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_sflow_sampling_rate_global", new object[] {
			profile_names,
			types}, callback, asyncState);
	}
	public void Endset_sflow_sampling_rate_global(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_truncated_redirect_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttp", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttp", ResponseNamespace="urn:iControl:LocalLB/ProfileHttp")]
	public void set_truncated_redirect_mode(
		string [] profile_names,
		LocalLBProfileProfileMode [] modes
	) {
		this.Invoke("set_truncated_redirect_mode", new object [] {
				profile_names,
				modes});

	}
	public System.IAsyncResult Beginset_truncated_redirect_mode(string [] profile_names,LocalLBProfileProfileMode [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_truncated_redirect_mode", new object[] {
			profile_names,
			modes}, callback, asyncState);
	}
	public void Endset_truncated_redirect_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileHttp.HTTPProxyType", Namespace = "urn:iControl")]
	public enum LocalLBProfileHttpHTTPProxyType
	{
		HTTP_PROXY_TYPE_UNKNOWN,
		HTTP_PROXY_TYPE_REVERSE,
		HTTP_PROXY_TYPE_EXPLICIT,
		HTTP_PROXY_TYPE_TRANSPARENT,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileHttp.PassthroughMode", Namespace = "urn:iControl")]
	public enum LocalLBProfileHttpPassthroughMode
	{
		HTTP_PASSTHROUGH_MODE_UNKNOWN,
		HTTP_PASSTHROUGH_MODE_REJECT,
		HTTP_PASSTHROUGH_MODE_ALLOW,
		HTTP_PASSTHROUGH_MODE_PASSTHROUGH,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileHttp.ViaHeader", Namespace = "urn:iControl")]
	public enum LocalLBProfileHttpViaHeader
	{
		VIA_HEADER_UNKNOWN,
		VIA_HEADER_REMOVE,
		VIA_HEADER_PRESERVE,
		VIA_HEADER_APPEND,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileHttp.ProfileHTTPProxyType", Namespace = "urn:iControl")]
	public partial class LocalLBProfileHttpProfileHTTPProxyType
	{
		private LocalLBProfileHttpHTTPProxyType valueField;
		public LocalLBProfileHttpHTTPProxyType value
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileHttp.ProfileHttpStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBProfileHttpProfileHttpStatisticEntry
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileHttp.ProfileHttpStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBProfileHttpProfileHttpStatistics
	{
		private LocalLBProfileHttpProfileHttpStatisticEntry [] statisticsField;
		public LocalLBProfileHttpProfileHttpStatisticEntry [] statistics
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

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileHttp.ProfilePassthroughMode", Namespace = "urn:iControl")]
	public partial class LocalLBProfileHttpProfilePassthroughMode
	{
		private LocalLBProfileHttpPassthroughMode valueField;
		public LocalLBProfileHttpPassthroughMode value
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileHttp.ProfileViaHeader", Namespace = "urn:iControl")]
	public partial class LocalLBProfileHttpProfileViaHeader
	{
		private LocalLBProfileHttpViaHeader valueField;
		public LocalLBProfileHttpViaHeader value
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

}
