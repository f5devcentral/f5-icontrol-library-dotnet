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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.ProfileHttpCompressionBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileHttpCompressionProfileHttpCompressionStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileEnabledState))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileULong))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileStringArray))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileCompressionMethod))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileStatisticsByVirtual))]
	public partial class LocalLBProfileHttpCompression : iControlInterface {
		public LocalLBProfileHttpCompression() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_content_type_exclude
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
	public void add_content_type_exclude(
		string [] profile_names,
		string [] [] reg_expressions
	) {
		this.Invoke("add_content_type_exclude", new object [] {
				profile_names,
				reg_expressions});

	}
	public System.IAsyncResult Beginadd_content_type_exclude(string [] profile_names,string [] [] reg_expressions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_content_type_exclude", new object[] {
			profile_names,
			reg_expressions}, callback, asyncState);
	}
	public void Endadd_content_type_exclude(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_content_type_include
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
	public void add_content_type_include(
		string [] profile_names,
		string [] [] reg_expressions
	) {
		this.Invoke("add_content_type_include", new object [] {
				profile_names,
				reg_expressions});

	}
	public System.IAsyncResult Beginadd_content_type_include(string [] profile_names,string [] [] reg_expressions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_content_type_include", new object[] {
			profile_names,
			reg_expressions}, callback, asyncState);
	}
	public void Endadd_content_type_include(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_uri_exclude
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
	public void add_uri_exclude(
		string [] profile_names,
		string [] [] reg_expressions
	) {
		this.Invoke("add_uri_exclude", new object [] {
				profile_names,
				reg_expressions});

	}
	public System.IAsyncResult Beginadd_uri_exclude(string [] profile_names,string [] [] reg_expressions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_uri_exclude", new object[] {
			profile_names,
			reg_expressions}, callback, asyncState);
	}
	public void Endadd_uri_exclude(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_uri_include
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
	public void add_uri_include(
		string [] profile_names,
		string [] [] reg_expressions
	) {
		this.Invoke("add_uri_include", new object [] {
				profile_names,
				reg_expressions});

	}
	public System.IAsyncResult Beginadd_uri_include(string [] profile_names,string [] [] reg_expressions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_uri_include", new object[] {
			profile_names,
			reg_expressions}, callback, asyncState);
	}
	public void Endadd_uri_include(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileHttpCompressionProfileHttpCompressionStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((LocalLBProfileHttpCompressionProfileHttpCompressionStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public LocalLBProfileHttpCompressionProfileHttpCompressionStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileHttpCompressionProfileHttpCompressionStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_allow_http_10_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
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
	// get_browser_workaround_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_browser_workaround_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_browser_workaround_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_browser_workaround_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_browser_workaround_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_browser_workaround_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_buffer_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_buffer_size(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_buffer_size", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_buffer_size(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_buffer_size", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_buffer_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_content_type_exclude
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileStringArray [] get_content_type_exclude(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_content_type_exclude", new object [] {
				profile_names});
		return ((LocalLBProfileStringArray [])(results[0]));
	}
	public System.IAsyncResult Beginget_content_type_exclude(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_content_type_exclude", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileStringArray [] Endget_content_type_exclude(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileStringArray [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_content_type_include
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileStringArray [] get_content_type_include(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_content_type_include", new object [] {
				profile_names});
		return ((LocalLBProfileStringArray [])(results[0]));
	}
	public System.IAsyncResult Beginget_content_type_include(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_content_type_include", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileStringArray [] Endget_content_type_include(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileStringArray [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cpu_saver_high_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_cpu_saver_high_threshold(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_cpu_saver_high_threshold", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_cpu_saver_high_threshold(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cpu_saver_high_threshold", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_cpu_saver_high_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cpu_saver_low_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_cpu_saver_low_threshold(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_cpu_saver_low_threshold", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_cpu_saver_low_threshold(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cpu_saver_low_threshold", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_cpu_saver_low_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cpu_saver_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_cpu_saver_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_cpu_saver_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_cpu_saver_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cpu_saver_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_cpu_saver_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
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
	// get_keep_accept_encoding_header_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
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
	// get_level
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_level(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_level", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_level(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_level", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_level(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
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
	// get_memory_level
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_memory_level(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_memory_level", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_memory_level(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_memory_level", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_memory_level(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_minimum_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_minimum_size(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_minimum_size", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_minimum_size(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_minimum_size", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_minimum_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_preferred_method
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileCompressionMethod [] get_preferred_method(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_preferred_method", new object [] {
				profile_names});
		return ((LocalLBProfileCompressionMethod [])(results[0]));
	}
	public System.IAsyncResult Beginget_preferred_method(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_preferred_method", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileCompressionMethod [] Endget_preferred_method(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileCompressionMethod [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_selective_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_selective_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_selective_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_selective_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_selective_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_selective_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileHttpCompressionProfileHttpCompressionStatistics get_statistics(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				profile_names});
		return ((LocalLBProfileHttpCompressionProfileHttpCompressionStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileHttpCompressionProfileHttpCompressionStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileHttpCompressionProfileHttpCompressionStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics_by_virtual
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
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
	// get_uri_exclude
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileStringArray [] get_uri_exclude(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_uri_exclude", new object [] {
				profile_names});
		return ((LocalLBProfileStringArray [])(results[0]));
	}
	public System.IAsyncResult Beginget_uri_exclude(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_uri_exclude", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileStringArray [] Endget_uri_exclude(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileStringArray [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_uri_include
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileStringArray [] get_uri_include(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_uri_include", new object [] {
				profile_names});
		return ((LocalLBProfileStringArray [])(results[0]));
	}
	public System.IAsyncResult Beginget_uri_include(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_uri_include", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileStringArray [] Endget_uri_include(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileStringArray [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_vary_header_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_vary_header_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_vary_header_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_vary_header_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_vary_header_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_vary_header_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
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
	// get_window_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_window_size(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_window_size", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_window_size(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_window_size", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_window_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// is_base_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
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
	// remove_content_type_exclude
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
	public void remove_content_type_exclude(
		string [] profile_names,
		string [] [] reg_expressions
	) {
		this.Invoke("remove_content_type_exclude", new object [] {
				profile_names,
				reg_expressions});

	}
	public System.IAsyncResult Beginremove_content_type_exclude(string [] profile_names,string [] [] reg_expressions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_content_type_exclude", new object[] {
			profile_names,
			reg_expressions}, callback, asyncState);
	}
	public void Endremove_content_type_exclude(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_content_type_include
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
	public void remove_content_type_include(
		string [] profile_names,
		string [] [] reg_expressions
	) {
		this.Invoke("remove_content_type_include", new object [] {
				profile_names,
				reg_expressions});

	}
	public System.IAsyncResult Beginremove_content_type_include(string [] profile_names,string [] [] reg_expressions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_content_type_include", new object[] {
			profile_names,
			reg_expressions}, callback, asyncState);
	}
	public void Endremove_content_type_include(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_uri_exclude
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
	public void remove_uri_exclude(
		string [] profile_names,
		string [] [] reg_expressions
	) {
		this.Invoke("remove_uri_exclude", new object [] {
				profile_names,
				reg_expressions});

	}
	public System.IAsyncResult Beginremove_uri_exclude(string [] profile_names,string [] [] reg_expressions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_uri_exclude", new object[] {
			profile_names,
			reg_expressions}, callback, asyncState);
	}
	public void Endremove_uri_exclude(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_uri_include
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
	public void remove_uri_include(
		string [] profile_names,
		string [] [] reg_expressions
	) {
		this.Invoke("remove_uri_include", new object [] {
				profile_names,
				reg_expressions});

	}
	public System.IAsyncResult Beginremove_uri_include(string [] profile_names,string [] [] reg_expressions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_uri_include", new object[] {
			profile_names,
			reg_expressions}, callback, asyncState);
	}
	public void Endremove_uri_include(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
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
	// set_browser_workaround_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
	public void set_browser_workaround_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_browser_workaround_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_browser_workaround_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_browser_workaround_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_browser_workaround_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_buffer_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
	public void set_buffer_size(
		string [] profile_names,
		LocalLBProfileULong [] sizes
	) {
		this.Invoke("set_buffer_size", new object [] {
				profile_names,
				sizes});

	}
	public System.IAsyncResult Beginset_buffer_size(string [] profile_names,LocalLBProfileULong [] sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_buffer_size", new object[] {
			profile_names,
			sizes}, callback, asyncState);
	}
	public void Endset_buffer_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_cpu_saver_high_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
	public void set_cpu_saver_high_threshold(
		string [] profile_names,
		LocalLBProfileULong [] thresholds
	) {
		this.Invoke("set_cpu_saver_high_threshold", new object [] {
				profile_names,
				thresholds});

	}
	public System.IAsyncResult Beginset_cpu_saver_high_threshold(string [] profile_names,LocalLBProfileULong [] thresholds, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cpu_saver_high_threshold", new object[] {
			profile_names,
			thresholds}, callback, asyncState);
	}
	public void Endset_cpu_saver_high_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_cpu_saver_low_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
	public void set_cpu_saver_low_threshold(
		string [] profile_names,
		LocalLBProfileULong [] thresholds
	) {
		this.Invoke("set_cpu_saver_low_threshold", new object [] {
				profile_names,
				thresholds});

	}
	public System.IAsyncResult Beginset_cpu_saver_low_threshold(string [] profile_names,LocalLBProfileULong [] thresholds, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cpu_saver_low_threshold", new object[] {
			profile_names,
			thresholds}, callback, asyncState);
	}
	public void Endset_cpu_saver_low_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_cpu_saver_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
	public void set_cpu_saver_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_cpu_saver_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_cpu_saver_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cpu_saver_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_cpu_saver_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_content_type_exclude
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
	public void set_default_content_type_exclude(
		string [] profile_names
	) {
		this.Invoke("set_default_content_type_exclude", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginset_default_content_type_exclude(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_content_type_exclude", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endset_default_content_type_exclude(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_content_type_include
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
	public void set_default_content_type_include(
		string [] profile_names
	) {
		this.Invoke("set_default_content_type_include", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginset_default_content_type_include(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_content_type_include", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endset_default_content_type_include(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
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
	// set_default_uri_exclude
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
	public void set_default_uri_exclude(
		string [] profile_names
	) {
		this.Invoke("set_default_uri_exclude", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginset_default_uri_exclude(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_uri_exclude", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endset_default_uri_exclude(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_uri_include
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
	public void set_default_uri_include(
		string [] profile_names
	) {
		this.Invoke("set_default_uri_include", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginset_default_uri_include(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_uri_include", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endset_default_uri_include(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
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
	// set_keep_accept_encoding_header_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
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
	// set_level
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
	public void set_level(
		string [] profile_names,
		LocalLBProfileULong [] levels
	) {
		this.Invoke("set_level", new object [] {
				profile_names,
				levels});

	}
	public System.IAsyncResult Beginset_level(string [] profile_names,LocalLBProfileULong [] levels, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_level", new object[] {
			profile_names,
			levels}, callback, asyncState);
	}
	public void Endset_level(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_memory_level
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
	public void set_memory_level(
		string [] profile_names,
		LocalLBProfileULong [] levels
	) {
		this.Invoke("set_memory_level", new object [] {
				profile_names,
				levels});

	}
	public System.IAsyncResult Beginset_memory_level(string [] profile_names,LocalLBProfileULong [] levels, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_memory_level", new object[] {
			profile_names,
			levels}, callback, asyncState);
	}
	public void Endset_memory_level(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_minimum_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
	public void set_minimum_size(
		string [] profile_names,
		LocalLBProfileULong [] sizes
	) {
		this.Invoke("set_minimum_size", new object [] {
				profile_names,
				sizes});

	}
	public System.IAsyncResult Beginset_minimum_size(string [] profile_names,LocalLBProfileULong [] sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_minimum_size", new object[] {
			profile_names,
			sizes}, callback, asyncState);
	}
	public void Endset_minimum_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_preferred_method
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
	public void set_preferred_method(
		string [] profile_names,
		LocalLBProfileCompressionMethod [] compression_methods
	) {
		this.Invoke("set_preferred_method", new object [] {
				profile_names,
				compression_methods});

	}
	public System.IAsyncResult Beginset_preferred_method(string [] profile_names,LocalLBProfileCompressionMethod [] compression_methods, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_preferred_method", new object[] {
			profile_names,
			compression_methods}, callback, asyncState);
	}
	public void Endset_preferred_method(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_selective_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
	public void set_selective_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_selective_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_selective_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_selective_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_selective_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_vary_header_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
	public void set_vary_header_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_vary_header_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_vary_header_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_vary_header_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_vary_header_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_window_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileHttpCompression", 
		RequestNamespace="urn:iControl:LocalLB/ProfileHttpCompression", ResponseNamespace="urn:iControl:LocalLB/ProfileHttpCompression")]
	public void set_window_size(
		string [] profile_names,
		LocalLBProfileULong [] sizes
	) {
		this.Invoke("set_window_size", new object [] {
				profile_names,
				sizes});

	}
	public System.IAsyncResult Beginset_window_size(string [] profile_names,LocalLBProfileULong [] sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_window_size", new object[] {
			profile_names,
			sizes}, callback, asyncState);
	}
	public void Endset_window_size(System.IAsyncResult asyncResult) {
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileHttpCompression.ProfileHttpCompressionStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBProfileHttpCompressionProfileHttpCompressionStatisticEntry
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileHttpCompression.ProfileHttpCompressionStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBProfileHttpCompressionProfileHttpCompressionStatistics
	{
		private LocalLBProfileHttpCompressionProfileHttpCompressionStatisticEntry [] statisticsField;
		public LocalLBProfileHttpCompressionProfileHttpCompressionStatisticEntry [] statistics
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
