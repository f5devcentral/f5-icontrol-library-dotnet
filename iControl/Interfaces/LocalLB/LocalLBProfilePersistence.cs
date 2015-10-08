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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.ProfilePersistenceBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileEnabledState))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileULong))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileString))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileCookiePersistenceMethod))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfilePersistenceProfilePersistenceHashMethod))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileIPAddress))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfilePersistenceMode))]
	public partial class LocalLBProfilePersistence : iControlInterface {
		public LocalLBProfilePersistence() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	public void create(
		string [] profile_names,
		LocalLBPersistenceMode [] modes
	) {
		this.Invoke("create", new object [] {
				profile_names,
				modes});

	}
	public System.IAsyncResult Begincreate(string [] profile_names,LocalLBPersistenceMode [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			profile_names,
			modes}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_profiles
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
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
	// get_across_pool_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_across_pool_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_across_pool_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_across_pool_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_across_pool_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_across_pool_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_across_service_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_across_service_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_across_service_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_across_service_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_across_service_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_across_service_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_across_virtual_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_across_virtual_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_across_virtual_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_across_virtual_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_across_virtual_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_across_virtual_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cookie_always_send_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_cookie_always_send_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_cookie_always_send_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_cookie_always_send_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cookie_always_send_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_cookie_always_send_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cookie_expiration
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_cookie_expiration(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_cookie_expiration", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_cookie_expiration(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cookie_expiration", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_cookie_expiration(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cookie_hash_length
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_cookie_hash_length(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_cookie_hash_length", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_cookie_hash_length(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cookie_hash_length", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_cookie_hash_length(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cookie_hash_offset
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_cookie_hash_offset(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_cookie_hash_offset", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_cookie_hash_offset(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cookie_hash_offset", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_cookie_hash_offset(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cookie_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_cookie_name(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_cookie_name", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_cookie_name(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cookie_name", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_cookie_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cookie_persistence_method
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileCookiePersistenceMethod [] get_cookie_persistence_method(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_cookie_persistence_method", new object [] {
				profile_names});
		return ((LocalLBProfileCookiePersistenceMethod [])(results[0]));
	}
	public System.IAsyncResult Beginget_cookie_persistence_method(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cookie_persistence_method", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileCookiePersistenceMethod [] Endget_cookie_persistence_method(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileCookiePersistenceMethod [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
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
	// get_ending_hash_pattern
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_ending_hash_pattern(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_ending_hash_pattern", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_ending_hash_pattern(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ending_hash_pattern", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_ending_hash_pattern(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_hash_length
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_hash_length(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_hash_length", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_hash_length(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_hash_length", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_hash_length(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_hash_method
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfilePersistenceProfilePersistenceHashMethod [] get_hash_method(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_hash_method", new object [] {
				profile_names});
		return ((LocalLBProfilePersistenceProfilePersistenceHashMethod [])(results[0]));
	}
	public System.IAsyncResult Beginget_hash_method(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_hash_method", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfilePersistenceProfilePersistenceHashMethod [] Endget_hash_method(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfilePersistenceProfilePersistenceHashMethod [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_hash_more_data_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_hash_more_data_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_hash_more_data_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_hash_more_data_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_hash_more_data_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_hash_more_data_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_hash_offset
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_hash_offset(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_hash_offset", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_hash_offset(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_hash_offset", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_hash_offset(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
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
	// get_map_proxy_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileIPAddress [] get_map_proxy_address(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_map_proxy_address", new object [] {
				profile_names});
		return ((LocalLBProfileIPAddress [])(results[0]));
	}
	public System.IAsyncResult Beginget_map_proxy_address(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_map_proxy_address", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileIPAddress [] Endget_map_proxy_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileIPAddress [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_map_proxy_class
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_map_proxy_class(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_map_proxy_class", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_map_proxy_class(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_map_proxy_class", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_map_proxy_class(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_map_proxy_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_map_proxy_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_map_proxy_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_map_proxy_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_map_proxy_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_map_proxy_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_mask
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileIPAddress [] get_mask(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_mask", new object [] {
				profile_names});
		return ((LocalLBProfileIPAddress [])(results[0]));
	}
	public System.IAsyncResult Beginget_mask(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_mask", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileIPAddress [] Endget_mask(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileIPAddress [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_maximum_hash_buffer_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_maximum_hash_buffer_size(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_maximum_hash_buffer_size", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_hash_buffer_size(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_hash_buffer_size", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_maximum_hash_buffer_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_mirror_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_mirror_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_mirror_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_mirror_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_mirror_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_mirror_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_msrdp_without_session_directory_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_msrdp_without_session_directory_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_msrdp_without_session_directory_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_msrdp_without_session_directory_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_msrdp_without_session_directory_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_msrdp_without_session_directory_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_override_connection_limit_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_override_connection_limit_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_override_connection_limit_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_override_connection_limit_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_override_connection_limit_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_override_connection_limit_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_persistence_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfilePersistenceMode [] get_persistence_mode(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_persistence_mode", new object [] {
				profile_names});
		return ((LocalLBProfilePersistenceMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_persistence_mode(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_persistence_mode", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfilePersistenceMode [] Endget_persistence_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfilePersistenceMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_rule(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_rule", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_rule(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rule", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_sip_info
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_sip_info(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_sip_info", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_sip_info(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_sip_info", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_sip_info(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_starting_hash_pattern
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_starting_hash_pattern(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_starting_hash_pattern", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_starting_hash_pattern(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_starting_hash_pattern", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_starting_hash_pattern(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
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
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
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
	// set_across_pool_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	public void set_across_pool_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_across_pool_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_across_pool_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_across_pool_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_across_pool_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_across_service_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	public void set_across_service_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_across_service_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_across_service_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_across_service_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_across_service_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_across_virtual_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	public void set_across_virtual_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_across_virtual_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_across_virtual_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_across_virtual_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_across_virtual_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_cookie_always_send_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	public void set_cookie_always_send_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_cookie_always_send_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_cookie_always_send_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cookie_always_send_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_cookie_always_send_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_cookie_expiration
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	public void set_cookie_expiration(
		string [] profile_names,
		LocalLBProfileULong [] expirations
	) {
		this.Invoke("set_cookie_expiration", new object [] {
				profile_names,
				expirations});

	}
	public System.IAsyncResult Beginset_cookie_expiration(string [] profile_names,LocalLBProfileULong [] expirations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cookie_expiration", new object[] {
			profile_names,
			expirations}, callback, asyncState);
	}
	public void Endset_cookie_expiration(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_cookie_hash_length
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	public void set_cookie_hash_length(
		string [] profile_names,
		LocalLBProfileULong [] lengths
	) {
		this.Invoke("set_cookie_hash_length", new object [] {
				profile_names,
				lengths});

	}
	public System.IAsyncResult Beginset_cookie_hash_length(string [] profile_names,LocalLBProfileULong [] lengths, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cookie_hash_length", new object[] {
			profile_names,
			lengths}, callback, asyncState);
	}
	public void Endset_cookie_hash_length(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_cookie_hash_offset
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	public void set_cookie_hash_offset(
		string [] profile_names,
		LocalLBProfileULong [] offsets
	) {
		this.Invoke("set_cookie_hash_offset", new object [] {
				profile_names,
				offsets});

	}
	public System.IAsyncResult Beginset_cookie_hash_offset(string [] profile_names,LocalLBProfileULong [] offsets, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cookie_hash_offset", new object[] {
			profile_names,
			offsets}, callback, asyncState);
	}
	public void Endset_cookie_hash_offset(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_cookie_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	public void set_cookie_name(
		string [] profile_names,
		LocalLBProfileString [] cookie_names
	) {
		this.Invoke("set_cookie_name", new object [] {
				profile_names,
				cookie_names});

	}
	public System.IAsyncResult Beginset_cookie_name(string [] profile_names,LocalLBProfileString [] cookie_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cookie_name", new object[] {
			profile_names,
			cookie_names}, callback, asyncState);
	}
	public void Endset_cookie_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_cookie_persistence_method
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	public void set_cookie_persistence_method(
		string [] profile_names,
		LocalLBProfileCookiePersistenceMethod [] methods
	) {
		this.Invoke("set_cookie_persistence_method", new object [] {
				profile_names,
				methods});

	}
	public System.IAsyncResult Beginset_cookie_persistence_method(string [] profile_names,LocalLBProfileCookiePersistenceMethod [] methods, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cookie_persistence_method", new object[] {
			profile_names,
			methods}, callback, asyncState);
	}
	public void Endset_cookie_persistence_method(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
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
	// set_ending_hash_pattern
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	public void set_ending_hash_pattern(
		string [] profile_names,
		LocalLBProfileString [] patterns
	) {
		this.Invoke("set_ending_hash_pattern", new object [] {
				profile_names,
				patterns});

	}
	public System.IAsyncResult Beginset_ending_hash_pattern(string [] profile_names,LocalLBProfileString [] patterns, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ending_hash_pattern", new object[] {
			profile_names,
			patterns}, callback, asyncState);
	}
	public void Endset_ending_hash_pattern(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_hash_length
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	public void set_hash_length(
		string [] profile_names,
		LocalLBProfileULong [] lengths
	) {
		this.Invoke("set_hash_length", new object [] {
				profile_names,
				lengths});

	}
	public System.IAsyncResult Beginset_hash_length(string [] profile_names,LocalLBProfileULong [] lengths, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_hash_length", new object[] {
			profile_names,
			lengths}, callback, asyncState);
	}
	public void Endset_hash_length(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_hash_method
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	public void set_hash_method(
		string [] profile_names,
		LocalLBProfilePersistenceProfilePersistenceHashMethod [] methods
	) {
		this.Invoke("set_hash_method", new object [] {
				profile_names,
				methods});

	}
	public System.IAsyncResult Beginset_hash_method(string [] profile_names,LocalLBProfilePersistenceProfilePersistenceHashMethod [] methods, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_hash_method", new object[] {
			profile_names,
			methods}, callback, asyncState);
	}
	public void Endset_hash_method(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_hash_more_data_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	public void set_hash_more_data_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_hash_more_data_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_hash_more_data_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_hash_more_data_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_hash_more_data_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_hash_offset
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	public void set_hash_offset(
		string [] profile_names,
		LocalLBProfileULong [] offsets
	) {
		this.Invoke("set_hash_offset", new object [] {
				profile_names,
				offsets});

	}
	public System.IAsyncResult Beginset_hash_offset(string [] profile_names,LocalLBProfileULong [] offsets, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_hash_offset", new object[] {
			profile_names,
			offsets}, callback, asyncState);
	}
	public void Endset_hash_offset(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_map_proxy_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	public void set_map_proxy_address(
		string [] profile_names,
		LocalLBProfileIPAddress [] addresses
	) {
		this.Invoke("set_map_proxy_address", new object [] {
				profile_names,
				addresses});

	}
	public System.IAsyncResult Beginset_map_proxy_address(string [] profile_names,LocalLBProfileIPAddress [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_map_proxy_address", new object[] {
			profile_names,
			addresses}, callback, asyncState);
	}
	public void Endset_map_proxy_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_map_proxy_class
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	public void set_map_proxy_class(
		string [] profile_names,
		LocalLBProfileString [] classes
	) {
		this.Invoke("set_map_proxy_class", new object [] {
				profile_names,
				classes});

	}
	public System.IAsyncResult Beginset_map_proxy_class(string [] profile_names,LocalLBProfileString [] classes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_map_proxy_class", new object[] {
			profile_names,
			classes}, callback, asyncState);
	}
	public void Endset_map_proxy_class(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_map_proxy_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	public void set_map_proxy_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_map_proxy_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_map_proxy_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_map_proxy_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_map_proxy_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_mask
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	public void set_mask(
		string [] profile_names,
		LocalLBProfileIPAddress [] masks
	) {
		this.Invoke("set_mask", new object [] {
				profile_names,
				masks});

	}
	public System.IAsyncResult Beginset_mask(string [] profile_names,LocalLBProfileIPAddress [] masks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_mask", new object[] {
			profile_names,
			masks}, callback, asyncState);
	}
	public void Endset_mask(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_hash_buffer_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	public void set_maximum_hash_buffer_size(
		string [] profile_names,
		LocalLBProfileULong [] sizes
	) {
		this.Invoke("set_maximum_hash_buffer_size", new object [] {
				profile_names,
				sizes});

	}
	public System.IAsyncResult Beginset_maximum_hash_buffer_size(string [] profile_names,LocalLBProfileULong [] sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_hash_buffer_size", new object[] {
			profile_names,
			sizes}, callback, asyncState);
	}
	public void Endset_maximum_hash_buffer_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_mirror_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	public void set_mirror_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_mirror_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_mirror_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_mirror_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_mirror_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_msrdp_without_session_directory_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	public void set_msrdp_without_session_directory_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_msrdp_without_session_directory_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_msrdp_without_session_directory_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_msrdp_without_session_directory_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_msrdp_without_session_directory_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_override_connection_limit_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	public void set_override_connection_limit_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_override_connection_limit_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_override_connection_limit_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_override_connection_limit_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_override_connection_limit_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_persistence_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	public void set_persistence_mode(
		string [] profile_names,
		LocalLBProfilePersistenceMode [] modes
	) {
		this.Invoke("set_persistence_mode", new object [] {
				profile_names,
				modes});

	}
	public System.IAsyncResult Beginset_persistence_mode(string [] profile_names,LocalLBProfilePersistenceMode [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_persistence_mode", new object[] {
			profile_names,
			modes}, callback, asyncState);
	}
	public void Endset_persistence_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	public void set_rule(
		string [] profile_names,
		LocalLBProfileString [] rules
	) {
		this.Invoke("set_rule", new object [] {
				profile_names,
				rules});

	}
	public System.IAsyncResult Beginset_rule(string [] profile_names,LocalLBProfileString [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rule", new object[] {
			profile_names,
			rules}, callback, asyncState);
	}
	public void Endset_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_sip_info
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	public void set_sip_info(
		string [] profile_names,
		LocalLBProfileString [] sip_info_headers
	) {
		this.Invoke("set_sip_info", new object [] {
				profile_names,
				sip_info_headers});

	}
	public System.IAsyncResult Beginset_sip_info(string [] profile_names,LocalLBProfileString [] sip_info_headers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_sip_info", new object[] {
			profile_names,
			sip_info_headers}, callback, asyncState);
	}
	public void Endset_sip_info(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_starting_hash_pattern
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	public void set_starting_hash_pattern(
		string [] profile_names,
		LocalLBProfileString [] patterns
	) {
		this.Invoke("set_starting_hash_pattern", new object [] {
				profile_names,
				patterns});

	}
	public System.IAsyncResult Beginset_starting_hash_pattern(string [] profile_names,LocalLBProfileString [] patterns, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_starting_hash_pattern", new object[] {
			profile_names,
			patterns}, callback, asyncState);
	}
	public void Endset_starting_hash_pattern(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfilePersistence", 
		RequestNamespace="urn:iControl:LocalLB/ProfilePersistence", ResponseNamespace="urn:iControl:LocalLB/ProfilePersistence")]
	public void set_timeout(
		string [] profile_names,
		LocalLBProfileULong [] timeouts
	) {
		this.Invoke("set_timeout", new object [] {
				profile_names,
				timeouts});

	}
	public System.IAsyncResult Beginset_timeout(string [] profile_names,LocalLBProfileULong [] timeouts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_timeout", new object[] {
			profile_names,
			timeouts}, callback, asyncState);
	}
	public void Endset_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfilePersistence.PersistenceHashMethod", Namespace = "urn:iControl")]
	public enum LocalLBProfilePersistencePersistenceHashMethod
	{
		PERSISTENCE_HASH_NONE,
		PERSISTENCE_HASH_DEFAULT,
		PERSISTENCE_HASH_CARP,
		PERSISTENCE_HASH_UNKNOWN,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfilePersistence.ProfilePersistenceHashMethod", Namespace = "urn:iControl")]
	public partial class LocalLBProfilePersistenceProfilePersistenceHashMethod
	{
		private LocalLBProfilePersistencePersistenceHashMethod valueField;
		public LocalLBProfilePersistencePersistenceHashMethod value
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
