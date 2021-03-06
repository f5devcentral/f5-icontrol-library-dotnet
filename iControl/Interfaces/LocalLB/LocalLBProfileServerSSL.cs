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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.ProfileServerSSLBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileStringArray))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileULong))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileServerSSLProfileServerSSLStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileEnabledState))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileSSLC3DCertificateExtension))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileResponseControlMode))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileServerSSLCertificateMode))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileProfileMode))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileSecureRenegotiationMode))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileSSLOption))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileSSLSignHash))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBProfileStatisticsByVirtual))]
	public partial class LocalLBProfileServerSSL : iControlInterface {
		public LocalLBProfileServerSSL() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_c3d_certificate_extension_custom_oid
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void add_c3d_certificate_extension_custom_oid(
		string [] profile_names,
		LocalLBProfileStringArray [] values
	) {
		this.Invoke("add_c3d_certificate_extension_custom_oid", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginadd_c3d_certificate_extension_custom_oid(string [] profile_names,LocalLBProfileStringArray [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_c3d_certificate_extension_custom_oid", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endadd_c3d_certificate_extension_custom_oid(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
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
	// get_alert_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_alert_timeout(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_alert_timeout", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_alert_timeout(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_alert_timeout", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_alert_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileServerSSLProfileServerSSLStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((LocalLBProfileServerSSLProfileServerSSLStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public LocalLBProfileServerSSLProfileServerSSLStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileServerSSLProfileServerSSLStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_allow_expired_crl_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_allow_expired_crl_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_allow_expired_crl_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_allow_expired_crl_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_allow_expired_crl_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_allow_expired_crl_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_authenticate_depth
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_authenticate_depth(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_authenticate_depth", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_authenticate_depth(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_authenticate_depth", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_authenticate_depth(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_authenticate_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_authenticate_name(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_authenticate_name", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_authenticate_name(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_authenticate_name", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_authenticate_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_authenticate_once_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_authenticate_once_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_authenticate_once_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_authenticate_once_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_authenticate_once_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_authenticate_once_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_bypass_on_failed_client_certificate_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_bypass_on_failed_client_certificate_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_bypass_on_failed_client_certificate_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_bypass_on_failed_client_certificate_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_bypass_on_failed_client_certificate_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_bypass_on_failed_client_certificate_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_bypass_on_handshake_alert_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_bypass_on_handshake_alert_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_bypass_on_handshake_alert_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_bypass_on_handshake_alert_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_bypass_on_handshake_alert_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_bypass_on_handshake_alert_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_c3d_ca_certificate_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_c3d_ca_certificate_file(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_c3d_ca_certificate_file", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_c3d_ca_certificate_file(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_c3d_ca_certificate_file", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_c3d_ca_certificate_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_c3d_ca_key_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_c3d_ca_key_file(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_c3d_ca_key_file", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_c3d_ca_key_file(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_c3d_ca_key_file", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_c3d_ca_key_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_c3d_ca_passphrase
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_c3d_ca_passphrase(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_c3d_ca_passphrase", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_c3d_ca_passphrase(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_c3d_ca_passphrase", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_c3d_ca_passphrase(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_c3d_certificate_extension_custom_oid
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileStringArray [] get_c3d_certificate_extension_custom_oid(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_c3d_certificate_extension_custom_oid", new object [] {
				profile_names});
		return ((LocalLBProfileStringArray [])(results[0]));
	}
	public System.IAsyncResult Beginget_c3d_certificate_extension_custom_oid(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_c3d_certificate_extension_custom_oid", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileStringArray [] Endget_c3d_certificate_extension_custom_oid(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileStringArray [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_c3d_certificate_extension_include
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileSSLC3DCertificateExtension [] get_c3d_certificate_extension_include(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_c3d_certificate_extension_include", new object [] {
				profile_names});
		return ((LocalLBProfileSSLC3DCertificateExtension [])(results[0]));
	}
	public System.IAsyncResult Beginget_c3d_certificate_extension_include(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_c3d_certificate_extension_include", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileSSLC3DCertificateExtension [] Endget_c3d_certificate_extension_include(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileSSLC3DCertificateExtension [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_c3d_certificate_lifespan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_c3d_certificate_lifespan(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_c3d_certificate_lifespan", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_c3d_certificate_lifespan(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_c3d_certificate_lifespan", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_c3d_certificate_lifespan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_c3d_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_c3d_enabled_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_c3d_enabled_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_c3d_enabled_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_c3d_enabled_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_c3d_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ca_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_ca_file(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_ca_file", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_ca_file(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ca_file", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_ca_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ca_file_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_ca_file_v2(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_ca_file_v2", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_ca_file_v2(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ca_file_v2", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_ca_file_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cache_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
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
	// get_cache_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_cache_timeout(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_cache_timeout", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_cache_timeout(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cache_timeout", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_cache_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_certificate_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_certificate_file(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_certificate_file", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_certificate_file(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_certificate_file", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_certificate_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_certificate_file_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_certificate_file_v2(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_certificate_file_v2", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_certificate_file_v2(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_certificate_file_v2", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_certificate_file_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_chain_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_chain_file(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_chain_file", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_chain_file(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_chain_file", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_chain_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_chain_file_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_chain_file_v2(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_chain_file_v2", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_chain_file_v2(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_chain_file_v2", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_chain_file_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cipher_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileStringArray [] get_cipher_list(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_cipher_list", new object [] {
				profile_names});
		return ((LocalLBProfileStringArray [])(results[0]));
	}
	public System.IAsyncResult Beginget_cipher_list(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cipher_list", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileStringArray [] Endget_cipher_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileStringArray [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_crl_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_crl_file(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_crl_file", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_crl_file(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_crl_file", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_crl_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_crl_file_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_crl_file_v2(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_crl_file_v2", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_crl_file_v2(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_crl_file_v2", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_crl_file_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
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
	// get_expired_certificate_response_control_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileResponseControlMode [] get_expired_certificate_response_control_mode(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_expired_certificate_response_control_mode", new object [] {
				profile_names});
		return ((LocalLBProfileResponseControlMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_expired_certificate_response_control_mode(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_expired_certificate_response_control_mode", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileResponseControlMode [] Endget_expired_certificate_response_control_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileResponseControlMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_forward_proxy_bypass_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_forward_proxy_bypass_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_forward_proxy_bypass_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_forward_proxy_bypass_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_forward_proxy_bypass_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_forward_proxy_bypass_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_forward_proxy_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_forward_proxy_enabled_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_forward_proxy_enabled_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_forward_proxy_enabled_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_forward_proxy_enabled_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_forward_proxy_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_generic_alert_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_generic_alert_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_generic_alert_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_generic_alert_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_generic_alert_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_generic_alert_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_handshake_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_handshake_timeout(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_handshake_timeout", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_handshake_timeout(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_handshake_timeout", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_handshake_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_key_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_key_file(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_key_file", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_key_file(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_key_file", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_key_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_key_file_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_key_file_v2(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_key_file_v2", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_key_file_v2(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_key_file_v2", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_key_file_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
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
	// get_maximum_active_handshakes
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_maximum_active_handshakes(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_maximum_active_handshakes", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_active_handshakes(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_active_handshakes", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_maximum_active_handshakes(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_modssl_emulation_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_modssl_emulation_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_modssl_emulation_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_modssl_emulation_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_modssl_emulation_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_modssl_emulation_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ocsp
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_ocsp(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_ocsp", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_ocsp(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ocsp", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_ocsp(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_passphrase
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_passphrase(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_passphrase", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_passphrase(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_passphrase", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_passphrase(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_peer_certification_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileServerSSLCertificateMode [] get_peer_certification_mode(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_peer_certification_mode", new object [] {
				profile_names});
		return ((LocalLBProfileServerSSLCertificateMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_peer_certification_mode(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_peer_certification_mode", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileServerSSLCertificateMode [] Endget_peer_certification_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileServerSSLCertificateMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_profile_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
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
	// get_proxy_ssl_passthrough_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_proxy_ssl_passthrough_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_proxy_ssl_passthrough_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_proxy_ssl_passthrough_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_proxy_ssl_passthrough_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_proxy_ssl_passthrough_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_proxy_ssl_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_proxy_ssl_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_proxy_ssl_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_proxy_ssl_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_proxy_ssl_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_proxy_ssl_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_renegotiation_period
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_renegotiation_period(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_renegotiation_period", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_renegotiation_period(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_renegotiation_period", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_renegotiation_period(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_renegotiation_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_renegotiation_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_renegotiation_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_renegotiation_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_renegotiation_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_renegotiation_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_renegotiation_throughput
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileULong [] get_renegotiation_throughput(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_renegotiation_throughput", new object [] {
				profile_names});
		return ((LocalLBProfileULong [])(results[0]));
	}
	public System.IAsyncResult Beginget_renegotiation_throughput(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_renegotiation_throughput", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileULong [] Endget_renegotiation_throughput(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileULong [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_retain_certificate_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_retain_certificate_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_retain_certificate_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_retain_certificate_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_retain_certificate_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_retain_certificate_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_secure_renegotiation_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileSecureRenegotiationMode [] get_secure_renegotiation_mode(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_secure_renegotiation_mode", new object [] {
				profile_names});
		return ((LocalLBProfileSecureRenegotiationMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_secure_renegotiation_mode(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_secure_renegotiation_mode", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileSecureRenegotiationMode [] Endget_secure_renegotiation_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileSecureRenegotiationMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_server_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileString [] get_server_name(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_server_name", new object [] {
				profile_names});
		return ((LocalLBProfileString [])(results[0]));
	}
	public System.IAsyncResult Beginget_server_name(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_server_name", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileString [] Endget_server_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileString [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_session_mirroring_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_session_mirroring_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_session_mirroring_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_session_mirroring_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_session_mirroring_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_session_mirroring_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_session_ticket_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_session_ticket_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_session_ticket_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_session_ticket_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_session_ticket_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_session_ticket_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_sni_default_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_sni_default_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_sni_default_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_sni_default_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_sni_default_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_sni_default_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_sni_require_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_sni_require_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_sni_require_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_sni_require_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_sni_require_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_sni_require_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ssl_option
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileSSLOption [] get_ssl_option(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_ssl_option", new object [] {
				profile_names});
		return ((LocalLBProfileSSLOption [])(results[0]));
	}
	public System.IAsyncResult Beginget_ssl_option(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ssl_option", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileSSLOption [] Endget_ssl_option(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileSSLOption [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ssl_sign_hash
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileSSLSignHash [] get_ssl_sign_hash(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_ssl_sign_hash", new object [] {
				profile_names});
		return ((LocalLBProfileSSLSignHash [])(results[0]));
	}
	public System.IAsyncResult Beginget_ssl_sign_hash(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ssl_sign_hash", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileSSLSignHash [] Endget_ssl_sign_hash(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileSSLSignHash [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileServerSSLProfileServerSSLStatistics get_statistics(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				profile_names});
		return ((LocalLBProfileServerSSLProfileServerSSLStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileServerSSLProfileServerSSLStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileServerSSLProfileServerSSLStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics_by_virtual
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
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
	// get_strict_resume_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_strict_resume_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_strict_resume_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_strict_resume_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_strict_resume_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_strict_resume_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_unclean_shutdown_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileEnabledState [] get_unclean_shutdown_state(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_unclean_shutdown_state", new object [] {
				profile_names});
		return ((LocalLBProfileEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_unclean_shutdown_state(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_unclean_shutdown_state", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileEnabledState [] Endget_unclean_shutdown_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_untrusted_certificate_response_control_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBProfileResponseControlMode [] get_untrusted_certificate_response_control_mode(
		string [] profile_names
	) {
		object [] results = this.Invoke("get_untrusted_certificate_response_control_mode", new object [] {
				profile_names});
		return ((LocalLBProfileResponseControlMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_untrusted_certificate_response_control_mode(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_untrusted_certificate_response_control_mode", new object[] {
			profile_names}, callback, asyncState);
	}
	public LocalLBProfileResponseControlMode [] Endget_untrusted_certificate_response_control_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBProfileResponseControlMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
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
	// remove_all_c3d_certificate_extension_custom_oids
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void remove_all_c3d_certificate_extension_custom_oids(
		string [] profile_names
	) {
		this.Invoke("remove_all_c3d_certificate_extension_custom_oids", new object [] {
				profile_names});

	}
	public System.IAsyncResult Beginremove_all_c3d_certificate_extension_custom_oids(string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_c3d_certificate_extension_custom_oids", new object[] {
			profile_names}, callback, asyncState);
	}
	public void Endremove_all_c3d_certificate_extension_custom_oids(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_c3d_certificate_extension_custom_oid
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void remove_c3d_certificate_extension_custom_oid(
		string [] profile_names,
		LocalLBProfileStringArray [] values
	) {
		this.Invoke("remove_c3d_certificate_extension_custom_oid", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginremove_c3d_certificate_extension_custom_oid(string [] profile_names,LocalLBProfileStringArray [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_c3d_certificate_extension_custom_oid", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endremove_c3d_certificate_extension_custom_oid(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
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
	// set_alert_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_alert_timeout(
		string [] profile_names,
		LocalLBProfileULong [] timeouts
	) {
		this.Invoke("set_alert_timeout", new object [] {
				profile_names,
				timeouts});

	}
	public System.IAsyncResult Beginset_alert_timeout(string [] profile_names,LocalLBProfileULong [] timeouts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_alert_timeout", new object[] {
			profile_names,
			timeouts}, callback, asyncState);
	}
	public void Endset_alert_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_allow_expired_crl_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_allow_expired_crl_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_allow_expired_crl_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_allow_expired_crl_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_allow_expired_crl_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_allow_expired_crl_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_authenticate_depth
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_authenticate_depth(
		string [] profile_names,
		LocalLBProfileULong [] depths
	) {
		this.Invoke("set_authenticate_depth", new object [] {
				profile_names,
				depths});

	}
	public System.IAsyncResult Beginset_authenticate_depth(string [] profile_names,LocalLBProfileULong [] depths, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_authenticate_depth", new object[] {
			profile_names,
			depths}, callback, asyncState);
	}
	public void Endset_authenticate_depth(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_authenticate_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_authenticate_name(
		string [] profile_names,
		LocalLBProfileString [] dn_names
	) {
		this.Invoke("set_authenticate_name", new object [] {
				profile_names,
				dn_names});

	}
	public System.IAsyncResult Beginset_authenticate_name(string [] profile_names,LocalLBProfileString [] dn_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_authenticate_name", new object[] {
			profile_names,
			dn_names}, callback, asyncState);
	}
	public void Endset_authenticate_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_authenticate_once_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_authenticate_once_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_authenticate_once_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_authenticate_once_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_authenticate_once_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_authenticate_once_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_bypass_on_failed_client_certificate_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_bypass_on_failed_client_certificate_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_bypass_on_failed_client_certificate_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_bypass_on_failed_client_certificate_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_bypass_on_failed_client_certificate_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_bypass_on_failed_client_certificate_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_bypass_on_handshake_alert_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_bypass_on_handshake_alert_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_bypass_on_handshake_alert_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_bypass_on_handshake_alert_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_bypass_on_handshake_alert_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_bypass_on_handshake_alert_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_c3d_ca_key_certificate_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_c3d_ca_key_certificate_file(
		string [] profile_names,
		LocalLBProfileString [] keys,
		LocalLBProfileString [] certs
	) {
		this.Invoke("set_c3d_ca_key_certificate_file", new object [] {
				profile_names,
				keys,
				certs});

	}
	public System.IAsyncResult Beginset_c3d_ca_key_certificate_file(string [] profile_names,LocalLBProfileString [] keys,LocalLBProfileString [] certs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_c3d_ca_key_certificate_file", new object[] {
			profile_names,
			keys,
			certs}, callback, asyncState);
	}
	public void Endset_c3d_ca_key_certificate_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_c3d_ca_passphrase
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_c3d_ca_passphrase(
		string [] profile_names,
		LocalLBProfileString [] passphrases
	) {
		this.Invoke("set_c3d_ca_passphrase", new object [] {
				profile_names,
				passphrases});

	}
	public System.IAsyncResult Beginset_c3d_ca_passphrase(string [] profile_names,LocalLBProfileString [] passphrases, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_c3d_ca_passphrase", new object[] {
			profile_names,
			passphrases}, callback, asyncState);
	}
	public void Endset_c3d_ca_passphrase(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_c3d_certificate_extension_include
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_c3d_certificate_extension_include(
		string [] profile_names,
		LocalLBProfileSSLC3DCertificateExtension [] extensions
	) {
		this.Invoke("set_c3d_certificate_extension_include", new object [] {
				profile_names,
				extensions});

	}
	public System.IAsyncResult Beginset_c3d_certificate_extension_include(string [] profile_names,LocalLBProfileSSLC3DCertificateExtension [] extensions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_c3d_certificate_extension_include", new object[] {
			profile_names,
			extensions}, callback, asyncState);
	}
	public void Endset_c3d_certificate_extension_include(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_c3d_certificate_lifespan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_c3d_certificate_lifespan(
		string [] profile_names,
		LocalLBProfileULong [] lifespans
	) {
		this.Invoke("set_c3d_certificate_lifespan", new object [] {
				profile_names,
				lifespans});

	}
	public System.IAsyncResult Beginset_c3d_certificate_lifespan(string [] profile_names,LocalLBProfileULong [] lifespans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_c3d_certificate_lifespan", new object[] {
			profile_names,
			lifespans}, callback, asyncState);
	}
	public void Endset_c3d_certificate_lifespan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_c3d_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_c3d_enabled_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_c3d_enabled_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_c3d_enabled_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_c3d_enabled_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_c3d_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ca_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_ca_file(
		string [] profile_names,
		LocalLBProfileString [] cas
	) {
		this.Invoke("set_ca_file", new object [] {
				profile_names,
				cas});

	}
	public System.IAsyncResult Beginset_ca_file(string [] profile_names,LocalLBProfileString [] cas, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ca_file", new object[] {
			profile_names,
			cas}, callback, asyncState);
	}
	public void Endset_ca_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ca_file_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_ca_file_v2(
		string [] profile_names,
		LocalLBProfileString [] cas
	) {
		this.Invoke("set_ca_file_v2", new object [] {
				profile_names,
				cas});

	}
	public System.IAsyncResult Beginset_ca_file_v2(string [] profile_names,LocalLBProfileString [] cas, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ca_file_v2", new object[] {
			profile_names,
			cas}, callback, asyncState);
	}
	public void Endset_ca_file_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_cache_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
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
	// set_cache_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_cache_timeout(
		string [] profile_names,
		LocalLBProfileULong [] timeouts
	) {
		this.Invoke("set_cache_timeout", new object [] {
				profile_names,
				timeouts});

	}
	public System.IAsyncResult Beginset_cache_timeout(string [] profile_names,LocalLBProfileULong [] timeouts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cache_timeout", new object[] {
			profile_names,
			timeouts}, callback, asyncState);
	}
	public void Endset_cache_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_certificate_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_certificate_file(
		string [] profile_names,
		LocalLBProfileString [] certs
	) {
		this.Invoke("set_certificate_file", new object [] {
				profile_names,
				certs});

	}
	public System.IAsyncResult Beginset_certificate_file(string [] profile_names,LocalLBProfileString [] certs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_certificate_file", new object[] {
			profile_names,
			certs}, callback, asyncState);
	}
	public void Endset_certificate_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_chain_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_chain_file(
		string [] profile_names,
		LocalLBProfileString [] chains
	) {
		this.Invoke("set_chain_file", new object [] {
				profile_names,
				chains});

	}
	public System.IAsyncResult Beginset_chain_file(string [] profile_names,LocalLBProfileString [] chains, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_chain_file", new object[] {
			profile_names,
			chains}, callback, asyncState);
	}
	public void Endset_chain_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_chain_file_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_chain_file_v2(
		string [] profile_names,
		LocalLBProfileString [] chains
	) {
		this.Invoke("set_chain_file_v2", new object [] {
				profile_names,
				chains});

	}
	public System.IAsyncResult Beginset_chain_file_v2(string [] profile_names,LocalLBProfileString [] chains, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_chain_file_v2", new object[] {
			profile_names,
			chains}, callback, asyncState);
	}
	public void Endset_chain_file_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_cipher_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_cipher_list(
		string [] profile_names,
		LocalLBProfileStringArray [] ciphers
	) {
		this.Invoke("set_cipher_list", new object [] {
				profile_names,
				ciphers});

	}
	public System.IAsyncResult Beginset_cipher_list(string [] profile_names,LocalLBProfileStringArray [] ciphers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cipher_list", new object[] {
			profile_names,
			ciphers}, callback, asyncState);
	}
	public void Endset_cipher_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_crl_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_crl_file(
		string [] profile_names,
		LocalLBProfileString [] crls
	) {
		this.Invoke("set_crl_file", new object [] {
				profile_names,
				crls});

	}
	public System.IAsyncResult Beginset_crl_file(string [] profile_names,LocalLBProfileString [] crls, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_crl_file", new object[] {
			profile_names,
			crls}, callback, asyncState);
	}
	public void Endset_crl_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_crl_file_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_crl_file_v2(
		string [] profile_names,
		LocalLBProfileString [] crls
	) {
		this.Invoke("set_crl_file_v2", new object [] {
				profile_names,
				crls});

	}
	public System.IAsyncResult Beginset_crl_file_v2(string [] profile_names,LocalLBProfileString [] crls, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_crl_file_v2", new object[] {
			profile_names,
			crls}, callback, asyncState);
	}
	public void Endset_crl_file_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
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
	// set_expired_certificate_response_control_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_expired_certificate_response_control_mode(
		string [] profile_names,
		LocalLBProfileResponseControlMode [] modes
	) {
		this.Invoke("set_expired_certificate_response_control_mode", new object [] {
				profile_names,
				modes});

	}
	public System.IAsyncResult Beginset_expired_certificate_response_control_mode(string [] profile_names,LocalLBProfileResponseControlMode [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_expired_certificate_response_control_mode", new object[] {
			profile_names,
			modes}, callback, asyncState);
	}
	public void Endset_expired_certificate_response_control_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_forward_proxy_bypass_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_forward_proxy_bypass_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_forward_proxy_bypass_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_forward_proxy_bypass_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_forward_proxy_bypass_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_forward_proxy_bypass_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_forward_proxy_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_forward_proxy_enabled_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_forward_proxy_enabled_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_forward_proxy_enabled_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_forward_proxy_enabled_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_forward_proxy_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_generic_alert_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_generic_alert_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_generic_alert_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_generic_alert_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_generic_alert_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_generic_alert_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_handshake_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_handshake_timeout(
		string [] profile_names,
		LocalLBProfileULong [] timeouts
	) {
		this.Invoke("set_handshake_timeout", new object [] {
				profile_names,
				timeouts});

	}
	public System.IAsyncResult Beginset_handshake_timeout(string [] profile_names,LocalLBProfileULong [] timeouts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_handshake_timeout", new object[] {
			profile_names,
			timeouts}, callback, asyncState);
	}
	public void Endset_handshake_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_key_certificate_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_key_certificate_file(
		string [] profile_names,
		LocalLBProfileString [] keys,
		LocalLBProfileString [] certs
	) {
		this.Invoke("set_key_certificate_file", new object [] {
				profile_names,
				keys,
				certs});

	}
	public System.IAsyncResult Beginset_key_certificate_file(string [] profile_names,LocalLBProfileString [] keys,LocalLBProfileString [] certs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_key_certificate_file", new object[] {
			profile_names,
			keys,
			certs}, callback, asyncState);
	}
	public void Endset_key_certificate_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_key_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_key_file(
		string [] profile_names,
		LocalLBProfileString [] keys
	) {
		this.Invoke("set_key_file", new object [] {
				profile_names,
				keys});

	}
	public System.IAsyncResult Beginset_key_file(string [] profile_names,LocalLBProfileString [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_key_file", new object[] {
			profile_names,
			keys}, callback, asyncState);
	}
	public void Endset_key_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_active_handshakes
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_maximum_active_handshakes(
		string [] profile_names,
		LocalLBProfileULong [] values
	) {
		this.Invoke("set_maximum_active_handshakes", new object [] {
				profile_names,
				values});

	}
	public System.IAsyncResult Beginset_maximum_active_handshakes(string [] profile_names,LocalLBProfileULong [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_active_handshakes", new object[] {
			profile_names,
			values}, callback, asyncState);
	}
	public void Endset_maximum_active_handshakes(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_modssl_emulation_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_modssl_emulation_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_modssl_emulation_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_modssl_emulation_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_modssl_emulation_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_modssl_emulation_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ocsp
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_ocsp(
		string [] profile_names,
		LocalLBProfileString [] ocsp_objects
	) {
		this.Invoke("set_ocsp", new object [] {
				profile_names,
				ocsp_objects});

	}
	public System.IAsyncResult Beginset_ocsp(string [] profile_names,LocalLBProfileString [] ocsp_objects, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ocsp", new object[] {
			profile_names,
			ocsp_objects}, callback, asyncState);
	}
	public void Endset_ocsp(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_passphrase
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_passphrase(
		string [] profile_names,
		LocalLBProfileString [] passphrases
	) {
		this.Invoke("set_passphrase", new object [] {
				profile_names,
				passphrases});

	}
	public System.IAsyncResult Beginset_passphrase(string [] profile_names,LocalLBProfileString [] passphrases, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_passphrase", new object[] {
			profile_names,
			passphrases}, callback, asyncState);
	}
	public void Endset_passphrase(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_peer_certificate_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_peer_certificate_mode(
		string [] profile_names,
		LocalLBProfileServerSSLCertificateMode [] modes
	) {
		this.Invoke("set_peer_certificate_mode", new object [] {
				profile_names,
				modes});

	}
	public System.IAsyncResult Beginset_peer_certificate_mode(string [] profile_names,LocalLBProfileServerSSLCertificateMode [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_peer_certificate_mode", new object[] {
			profile_names,
			modes}, callback, asyncState);
	}
	public void Endset_peer_certificate_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_profile_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
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
	// set_proxy_ssl_passthrough_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_proxy_ssl_passthrough_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_proxy_ssl_passthrough_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_proxy_ssl_passthrough_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_proxy_ssl_passthrough_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_proxy_ssl_passthrough_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_proxy_ssl_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_proxy_ssl_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_proxy_ssl_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_proxy_ssl_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_proxy_ssl_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_proxy_ssl_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_renegotiation_period
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_renegotiation_period(
		string [] profile_names,
		LocalLBProfileULong [] periods
	) {
		this.Invoke("set_renegotiation_period", new object [] {
				profile_names,
				periods});

	}
	public System.IAsyncResult Beginset_renegotiation_period(string [] profile_names,LocalLBProfileULong [] periods, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_renegotiation_period", new object[] {
			profile_names,
			periods}, callback, asyncState);
	}
	public void Endset_renegotiation_period(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_renegotiation_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_renegotiation_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_renegotiation_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_renegotiation_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_renegotiation_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_renegotiation_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_renegotiation_throughput
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_renegotiation_throughput(
		string [] profile_names,
		LocalLBProfileULong [] throughputs
	) {
		this.Invoke("set_renegotiation_throughput", new object [] {
				profile_names,
				throughputs});

	}
	public System.IAsyncResult Beginset_renegotiation_throughput(string [] profile_names,LocalLBProfileULong [] throughputs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_renegotiation_throughput", new object[] {
			profile_names,
			throughputs}, callback, asyncState);
	}
	public void Endset_renegotiation_throughput(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_retain_certificate_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_retain_certificate_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_retain_certificate_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_retain_certificate_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_retain_certificate_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_retain_certificate_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_secure_renegotiation_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_secure_renegotiation_mode(
		string [] profile_names,
		LocalLBProfileSecureRenegotiationMode [] modes
	) {
		this.Invoke("set_secure_renegotiation_mode", new object [] {
				profile_names,
				modes});

	}
	public System.IAsyncResult Beginset_secure_renegotiation_mode(string [] profile_names,LocalLBProfileSecureRenegotiationMode [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_secure_renegotiation_mode", new object[] {
			profile_names,
			modes}, callback, asyncState);
	}
	public void Endset_secure_renegotiation_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_server_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_server_name(
		string [] profile_names,
		LocalLBProfileString [] server_names
	) {
		this.Invoke("set_server_name", new object [] {
				profile_names,
				server_names});

	}
	public System.IAsyncResult Beginset_server_name(string [] profile_names,LocalLBProfileString [] server_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_server_name", new object[] {
			profile_names,
			server_names}, callback, asyncState);
	}
	public void Endset_server_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_session_mirroring_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_session_mirroring_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_session_mirroring_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_session_mirroring_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_session_mirroring_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_session_mirroring_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_session_ticket_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_session_ticket_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_session_ticket_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_session_ticket_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_session_ticket_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_session_ticket_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_sni_default_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_sni_default_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_sni_default_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_sni_default_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_sni_default_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_sni_default_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_sni_require_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_sni_require_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_sni_require_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_sni_require_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_sni_require_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_sni_require_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ssl_option
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_ssl_option(
		string [] profile_names,
		LocalLBProfileSSLOption [] options
	) {
		this.Invoke("set_ssl_option", new object [] {
				profile_names,
				options});

	}
	public System.IAsyncResult Beginset_ssl_option(string [] profile_names,LocalLBProfileSSLOption [] options, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ssl_option", new object[] {
			profile_names,
			options}, callback, asyncState);
	}
	public void Endset_ssl_option(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ssl_sign_hash
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_ssl_sign_hash(
		string [] profile_names,
		LocalLBProfileSSLSignHash [] hashes
	) {
		this.Invoke("set_ssl_sign_hash", new object [] {
				profile_names,
				hashes});

	}
	public System.IAsyncResult Beginset_ssl_sign_hash(string [] profile_names,LocalLBProfileSSLSignHash [] hashes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ssl_sign_hash", new object[] {
			profile_names,
			hashes}, callback, asyncState);
	}
	public void Endset_ssl_sign_hash(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_strict_resume_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_strict_resume_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_strict_resume_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_strict_resume_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_strict_resume_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_strict_resume_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_unclean_shutdown_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_unclean_shutdown_state(
		string [] profile_names,
		LocalLBProfileEnabledState [] states
	) {
		this.Invoke("set_unclean_shutdown_state", new object [] {
				profile_names,
				states});

	}
	public System.IAsyncResult Beginset_unclean_shutdown_state(string [] profile_names,LocalLBProfileEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_unclean_shutdown_state", new object[] {
			profile_names,
			states}, callback, asyncState);
	}
	public void Endset_unclean_shutdown_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_untrusted_certificate_response_control_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ProfileServerSSL", 
		RequestNamespace="urn:iControl:LocalLB/ProfileServerSSL", ResponseNamespace="urn:iControl:LocalLB/ProfileServerSSL")]
	public void set_untrusted_certificate_response_control_mode(
		string [] profile_names,
		LocalLBProfileResponseControlMode [] modes
	) {
		this.Invoke("set_untrusted_certificate_response_control_mode", new object [] {
				profile_names,
				modes});

	}
	public System.IAsyncResult Beginset_untrusted_certificate_response_control_mode(string [] profile_names,LocalLBProfileResponseControlMode [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_untrusted_certificate_response_control_mode", new object[] {
			profile_names,
			modes}, callback, asyncState);
	}
	public void Endset_untrusted_certificate_response_control_mode(System.IAsyncResult asyncResult) {
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileServerSSL.ProfileServerSSLStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBProfileServerSSLProfileServerSSLStatisticEntry
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ProfileServerSSL.ProfileServerSSLStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBProfileServerSSLProfileServerSSLStatistics
	{
		private LocalLBProfileServerSSLProfileServerSSLStatisticEntry [] statisticsField;
		public LocalLBProfileServerSSLProfileServerSSLStatisticEntry [] statistics
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
