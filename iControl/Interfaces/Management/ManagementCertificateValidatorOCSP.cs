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
	[System.Web.Services.WebServiceBindingAttribute(Name="Management.CertificateValidatorOCSPBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementCertificateValidatorOCSPCertificateValidatorOCSPStatistics))]
	public partial class ManagementCertificateValidatorOCSP : iControlInterface {
		public ManagementCertificateValidatorOCSP() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertificateValidatorOCSP", 
		RequestNamespace="urn:iControl:Management/CertificateValidatorOCSP", ResponseNamespace="urn:iControl:Management/CertificateValidatorOCSP")]
	public void create(
		string [] validators,
		string [] pools,
		string [] dns_resolvers
	) {
		this.Invoke("create", new object [] {
				validators,
				pools,
				dns_resolvers});

	}
	public System.IAsyncResult Begincreate(string [] validators,string [] pools,string [] dns_resolvers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			validators,
			pools,
			dns_resolvers}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_ocsp_certificate_validators
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertificateValidatorOCSP", 
		RequestNamespace="urn:iControl:Management/CertificateValidatorOCSP", ResponseNamespace="urn:iControl:Management/CertificateValidatorOCSP")]
	public void delete_all_ocsp_certificate_validators(

	) {
		this.Invoke("delete_all_ocsp_certificate_validators", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_ocsp_certificate_validators(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_ocsp_certificate_validators", new object[0], callback, asyncState);
	}
	public void Enddelete_all_ocsp_certificate_validators(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_ocsp_certificate_validator
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertificateValidatorOCSP", 
		RequestNamespace="urn:iControl:Management/CertificateValidatorOCSP", ResponseNamespace="urn:iControl:Management/CertificateValidatorOCSP")]
	public void delete_ocsp_certificate_validator(
		string [] validators
	) {
		this.Invoke("delete_ocsp_certificate_validator", new object [] {
				validators});

	}
	public System.IAsyncResult Begindelete_ocsp_certificate_validator(string [] validators, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_ocsp_certificate_validator", new object[] {
			validators}, callback, asyncState);
	}
	public void Enddelete_ocsp_certificate_validator(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertificateValidatorOCSP", 
		RequestNamespace="urn:iControl:Management/CertificateValidatorOCSP", ResponseNamespace="urn:iControl:Management/CertificateValidatorOCSP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementCertificateValidatorOCSPCertificateValidatorOCSPStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((ManagementCertificateValidatorOCSPCertificateValidatorOCSPStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public ManagementCertificateValidatorOCSPCertificateValidatorOCSPStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementCertificateValidatorOCSPCertificateValidatorOCSPStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cache_error_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertificateValidatorOCSP", 
		RequestNamespace="urn:iControl:Management/CertificateValidatorOCSP", ResponseNamespace="urn:iControl:Management/CertificateValidatorOCSP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_cache_error_timeout(
		string [] validators
	) {
		object [] results = this.Invoke("get_cache_error_timeout", new object [] {
				validators});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_cache_error_timeout(string [] validators, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cache_error_timeout", new object[] {
			validators}, callback, asyncState);
	}
	public long [] Endget_cache_error_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cache_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertificateValidatorOCSP", 
		RequestNamespace="urn:iControl:Management/CertificateValidatorOCSP", ResponseNamespace="urn:iControl:Management/CertificateValidatorOCSP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_cache_timeout(
		string [] validators
	) {
		object [] results = this.Invoke("get_cache_timeout", new object [] {
				validators});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_cache_timeout(string [] validators, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cache_timeout", new object[] {
			validators}, callback, asyncState);
	}
	public long [] Endget_cache_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_clock_skew
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertificateValidatorOCSP", 
		RequestNamespace="urn:iControl:Management/CertificateValidatorOCSP", ResponseNamespace="urn:iControl:Management/CertificateValidatorOCSP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_clock_skew(
		string [] validators
	) {
		object [] results = this.Invoke("get_clock_skew", new object [] {
				validators});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_clock_skew(string [] validators, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_clock_skew", new object[] {
			validators}, callback, asyncState);
	}
	public long [] Endget_clock_skew(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_concurrent_connections_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertificateValidatorOCSP", 
		RequestNamespace="urn:iControl:Management/CertificateValidatorOCSP", ResponseNamespace="urn:iControl:Management/CertificateValidatorOCSP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_concurrent_connections_limit(
		string [] validators
	) {
		object [] results = this.Invoke("get_concurrent_connections_limit", new object [] {
				validators});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_concurrent_connections_limit(string [] validators, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_concurrent_connections_limit", new object[] {
			validators}, callback, asyncState);
	}
	public long [] Endget_concurrent_connections_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertificateValidatorOCSP", 
		RequestNamespace="urn:iControl:Management/CertificateValidatorOCSP", ResponseNamespace="urn:iControl:Management/CertificateValidatorOCSP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] validators
	) {
		object [] results = this.Invoke("get_description", new object [] {
				validators});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] validators, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			validators}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dns_resolver
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertificateValidatorOCSP", 
		RequestNamespace="urn:iControl:Management/CertificateValidatorOCSP", ResponseNamespace="urn:iControl:Management/CertificateValidatorOCSP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_dns_resolver(
		string [] validators
	) {
		object [] results = this.Invoke("get_dns_resolver", new object [] {
				validators});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_dns_resolver(string [] validators, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dns_resolver", new object[] {
			validators}, callback, asyncState);
	}
	public string [] Endget_dns_resolver(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertificateValidatorOCSP", 
		RequestNamespace="urn:iControl:Management/CertificateValidatorOCSP", ResponseNamespace="urn:iControl:Management/CertificateValidatorOCSP")]
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
	// get_proxy_server_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertificateValidatorOCSP", 
		RequestNamespace="urn:iControl:Management/CertificateValidatorOCSP", ResponseNamespace="urn:iControl:Management/CertificateValidatorOCSP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_proxy_server_pool(
		string [] validators
	) {
		object [] results = this.Invoke("get_proxy_server_pool", new object [] {
				validators});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_proxy_server_pool(string [] validators, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_proxy_server_pool", new object[] {
			validators}, callback, asyncState);
	}
	public string [] Endget_proxy_server_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_responder_url
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertificateValidatorOCSP", 
		RequestNamespace="urn:iControl:Management/CertificateValidatorOCSP", ResponseNamespace="urn:iControl:Management/CertificateValidatorOCSP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_responder_url(
		string [] validators
	) {
		object [] results = this.Invoke("get_responder_url", new object [] {
				validators});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_responder_url(string [] validators, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_responder_url", new object[] {
			validators}, callback, asyncState);
	}
	public string [] Endget_responder_url(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_route_domain
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertificateValidatorOCSP", 
		RequestNamespace="urn:iControl:Management/CertificateValidatorOCSP", ResponseNamespace="urn:iControl:Management/CertificateValidatorOCSP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_route_domain(
		string [] validators
	) {
		object [] results = this.Invoke("get_route_domain", new object [] {
				validators});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_route_domain(string [] validators, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_route_domain", new object[] {
			validators}, callback, asyncState);
	}
	public string [] Endget_route_domain(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_sign_hash
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertificateValidatorOCSP", 
		RequestNamespace="urn:iControl:Management/CertificateValidatorOCSP", ResponseNamespace="urn:iControl:Management/CertificateValidatorOCSP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementCertificateValidatorOCSPOCSPSignHash [] get_sign_hash(
		string [] validators
	) {
		object [] results = this.Invoke("get_sign_hash", new object [] {
				validators});
		return ((ManagementCertificateValidatorOCSPOCSPSignHash [])(results[0]));
	}
	public System.IAsyncResult Beginget_sign_hash(string [] validators, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_sign_hash", new object[] {
			validators}, callback, asyncState);
	}
	public ManagementCertificateValidatorOCSPOCSPSignHash [] Endget_sign_hash(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementCertificateValidatorOCSPOCSPSignHash [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_signer_certificate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertificateValidatorOCSP", 
		RequestNamespace="urn:iControl:Management/CertificateValidatorOCSP", ResponseNamespace="urn:iControl:Management/CertificateValidatorOCSP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_signer_certificate(
		string [] validators
	) {
		object [] results = this.Invoke("get_signer_certificate", new object [] {
				validators});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_signer_certificate(string [] validators, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_signer_certificate", new object[] {
			validators}, callback, asyncState);
	}
	public string [] Endget_signer_certificate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_signer_key
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertificateValidatorOCSP", 
		RequestNamespace="urn:iControl:Management/CertificateValidatorOCSP", ResponseNamespace="urn:iControl:Management/CertificateValidatorOCSP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_signer_key(
		string [] validators
	) {
		object [] results = this.Invoke("get_signer_key", new object [] {
				validators});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_signer_key(string [] validators, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_signer_key", new object[] {
			validators}, callback, asyncState);
	}
	public string [] Endget_signer_key(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertificateValidatorOCSP", 
		RequestNamespace="urn:iControl:Management/CertificateValidatorOCSP", ResponseNamespace="urn:iControl:Management/CertificateValidatorOCSP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementCertificateValidatorOCSPCertificateValidatorOCSPStatistics get_statistics(
		string [] validators
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				validators});
		return ((ManagementCertificateValidatorOCSPCertificateValidatorOCSPStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] validators, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			validators}, callback, asyncState);
	}
	public ManagementCertificateValidatorOCSPCertificateValidatorOCSPStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementCertificateValidatorOCSPCertificateValidatorOCSPStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_status_age
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertificateValidatorOCSP", 
		RequestNamespace="urn:iControl:Management/CertificateValidatorOCSP", ResponseNamespace="urn:iControl:Management/CertificateValidatorOCSP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_status_age(
		string [] validators
	) {
		object [] results = this.Invoke("get_status_age", new object [] {
				validators});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_status_age(string [] validators, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_status_age", new object[] {
			validators}, callback, asyncState);
	}
	public long [] Endget_status_age(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_strict_responder_certificate_checking_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertificateValidatorOCSP", 
		RequestNamespace="urn:iControl:Management/CertificateValidatorOCSP", ResponseNamespace="urn:iControl:Management/CertificateValidatorOCSP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_strict_responder_certificate_checking_state(
		string [] validators
	) {
		object [] results = this.Invoke("get_strict_responder_certificate_checking_state", new object [] {
				validators});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_strict_responder_certificate_checking_state(string [] validators, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_strict_responder_certificate_checking_state", new object[] {
			validators}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_strict_responder_certificate_checking_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertificateValidatorOCSP", 
		RequestNamespace="urn:iControl:Management/CertificateValidatorOCSP", ResponseNamespace="urn:iControl:Management/CertificateValidatorOCSP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_timeout(
		string [] validators
	) {
		object [] results = this.Invoke("get_timeout", new object [] {
				validators});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_timeout(string [] validators, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_timeout", new object[] {
			validators}, callback, asyncState);
	}
	public long [] Endget_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_trusted_responder
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertificateValidatorOCSP", 
		RequestNamespace="urn:iControl:Management/CertificateValidatorOCSP", ResponseNamespace="urn:iControl:Management/CertificateValidatorOCSP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_trusted_responder(
		string [] validators
	) {
		object [] results = this.Invoke("get_trusted_responder", new object [] {
				validators});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_trusted_responder(string [] validators, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_trusted_responder", new object[] {
			validators}, callback, asyncState);
	}
	public string [] Endget_trusted_responder(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertificateValidatorOCSP", 
		RequestNamespace="urn:iControl:Management/CertificateValidatorOCSP", ResponseNamespace="urn:iControl:Management/CertificateValidatorOCSP")]
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
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertificateValidatorOCSP", 
		RequestNamespace="urn:iControl:Management/CertificateValidatorOCSP", ResponseNamespace="urn:iControl:Management/CertificateValidatorOCSP")]
	public void reset_statistics(
		string [] validators
	) {
		this.Invoke("reset_statistics", new object [] {
				validators});

	}
	public System.IAsyncResult Beginreset_statistics(string [] validators, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics", new object[] {
			validators}, callback, asyncState);
	}
	public void Endreset_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_cache_error_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertificateValidatorOCSP", 
		RequestNamespace="urn:iControl:Management/CertificateValidatorOCSP", ResponseNamespace="urn:iControl:Management/CertificateValidatorOCSP")]
	public void set_cache_error_timeout(
		string [] validators,
		long [] values
	) {
		this.Invoke("set_cache_error_timeout", new object [] {
				validators,
				values});

	}
	public System.IAsyncResult Beginset_cache_error_timeout(string [] validators,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cache_error_timeout", new object[] {
			validators,
			values}, callback, asyncState);
	}
	public void Endset_cache_error_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_cache_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertificateValidatorOCSP", 
		RequestNamespace="urn:iControl:Management/CertificateValidatorOCSP", ResponseNamespace="urn:iControl:Management/CertificateValidatorOCSP")]
	public void set_cache_timeout(
		string [] validators,
		long [] values
	) {
		this.Invoke("set_cache_timeout", new object [] {
				validators,
				values});

	}
	public System.IAsyncResult Beginset_cache_timeout(string [] validators,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cache_timeout", new object[] {
			validators,
			values}, callback, asyncState);
	}
	public void Endset_cache_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_clock_skew
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertificateValidatorOCSP", 
		RequestNamespace="urn:iControl:Management/CertificateValidatorOCSP", ResponseNamespace="urn:iControl:Management/CertificateValidatorOCSP")]
	public void set_clock_skew(
		string [] validators,
		long [] values
	) {
		this.Invoke("set_clock_skew", new object [] {
				validators,
				values});

	}
	public System.IAsyncResult Beginset_clock_skew(string [] validators,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_clock_skew", new object[] {
			validators,
			values}, callback, asyncState);
	}
	public void Endset_clock_skew(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_concurrent_connections_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertificateValidatorOCSP", 
		RequestNamespace="urn:iControl:Management/CertificateValidatorOCSP", ResponseNamespace="urn:iControl:Management/CertificateValidatorOCSP")]
	public void set_concurrent_connections_limit(
		string [] validators,
		long [] values
	) {
		this.Invoke("set_concurrent_connections_limit", new object [] {
				validators,
				values});

	}
	public System.IAsyncResult Beginset_concurrent_connections_limit(string [] validators,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_concurrent_connections_limit", new object[] {
			validators,
			values}, callback, asyncState);
	}
	public void Endset_concurrent_connections_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertificateValidatorOCSP", 
		RequestNamespace="urn:iControl:Management/CertificateValidatorOCSP", ResponseNamespace="urn:iControl:Management/CertificateValidatorOCSP")]
	public void set_description(
		string [] validators,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				validators,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] validators,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			validators,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dns_resolver
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertificateValidatorOCSP", 
		RequestNamespace="urn:iControl:Management/CertificateValidatorOCSP", ResponseNamespace="urn:iControl:Management/CertificateValidatorOCSP")]
	public void set_dns_resolver(
		string [] validators,
		string [] dns_resolvers
	) {
		this.Invoke("set_dns_resolver", new object [] {
				validators,
				dns_resolvers});

	}
	public System.IAsyncResult Beginset_dns_resolver(string [] validators,string [] dns_resolvers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dns_resolver", new object[] {
			validators,
			dns_resolvers}, callback, asyncState);
	}
	public void Endset_dns_resolver(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_proxy_server_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertificateValidatorOCSP", 
		RequestNamespace="urn:iControl:Management/CertificateValidatorOCSP", ResponseNamespace="urn:iControl:Management/CertificateValidatorOCSP")]
	public void set_proxy_server_pool(
		string [] validators,
		string [] pools
	) {
		this.Invoke("set_proxy_server_pool", new object [] {
				validators,
				pools});

	}
	public System.IAsyncResult Beginset_proxy_server_pool(string [] validators,string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_proxy_server_pool", new object[] {
			validators,
			pools}, callback, asyncState);
	}
	public void Endset_proxy_server_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_responder_url
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertificateValidatorOCSP", 
		RequestNamespace="urn:iControl:Management/CertificateValidatorOCSP", ResponseNamespace="urn:iControl:Management/CertificateValidatorOCSP")]
	public void set_responder_url(
		string [] validators,
		string [] urls
	) {
		this.Invoke("set_responder_url", new object [] {
				validators,
				urls});

	}
	public System.IAsyncResult Beginset_responder_url(string [] validators,string [] urls, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_responder_url", new object[] {
			validators,
			urls}, callback, asyncState);
	}
	public void Endset_responder_url(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_route_domain
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertificateValidatorOCSP", 
		RequestNamespace="urn:iControl:Management/CertificateValidatorOCSP", ResponseNamespace="urn:iControl:Management/CertificateValidatorOCSP")]
	public void set_route_domain(
		string [] validators,
		string [] route_domains
	) {
		this.Invoke("set_route_domain", new object [] {
				validators,
				route_domains});

	}
	public System.IAsyncResult Beginset_route_domain(string [] validators,string [] route_domains, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_route_domain", new object[] {
			validators,
			route_domains}, callback, asyncState);
	}
	public void Endset_route_domain(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_sign_hash
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertificateValidatorOCSP", 
		RequestNamespace="urn:iControl:Management/CertificateValidatorOCSP", ResponseNamespace="urn:iControl:Management/CertificateValidatorOCSP")]
	public void set_sign_hash(
		string [] validators,
		ManagementCertificateValidatorOCSPOCSPSignHash [] hashes
	) {
		this.Invoke("set_sign_hash", new object [] {
				validators,
				hashes});

	}
	public System.IAsyncResult Beginset_sign_hash(string [] validators,ManagementCertificateValidatorOCSPOCSPSignHash [] hashes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_sign_hash", new object[] {
			validators,
			hashes}, callback, asyncState);
	}
	public void Endset_sign_hash(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_signer_certificate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertificateValidatorOCSP", 
		RequestNamespace="urn:iControl:Management/CertificateValidatorOCSP", ResponseNamespace="urn:iControl:Management/CertificateValidatorOCSP")]
	public void set_signer_certificate(
		string [] validators,
		string [] certs
	) {
		this.Invoke("set_signer_certificate", new object [] {
				validators,
				certs});

	}
	public System.IAsyncResult Beginset_signer_certificate(string [] validators,string [] certs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_signer_certificate", new object[] {
			validators,
			certs}, callback, asyncState);
	}
	public void Endset_signer_certificate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_signer_certificate_key_passphrase
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertificateValidatorOCSP", 
		RequestNamespace="urn:iControl:Management/CertificateValidatorOCSP", ResponseNamespace="urn:iControl:Management/CertificateValidatorOCSP")]
	public void set_signer_certificate_key_passphrase(
		string [] validators,
		string [] certs,
		string [] keys,
		string [] passphrases
	) {
		this.Invoke("set_signer_certificate_key_passphrase", new object [] {
				validators,
				certs,
				keys,
				passphrases});

	}
	public System.IAsyncResult Beginset_signer_certificate_key_passphrase(string [] validators,string [] certs,string [] keys,string [] passphrases, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_signer_certificate_key_passphrase", new object[] {
			validators,
			certs,
			keys,
			passphrases}, callback, asyncState);
	}
	public void Endset_signer_certificate_key_passphrase(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_signer_key
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertificateValidatorOCSP", 
		RequestNamespace="urn:iControl:Management/CertificateValidatorOCSP", ResponseNamespace="urn:iControl:Management/CertificateValidatorOCSP")]
	public void set_signer_key(
		string [] validators,
		string [] keys
	) {
		this.Invoke("set_signer_key", new object [] {
				validators,
				keys});

	}
	public System.IAsyncResult Beginset_signer_key(string [] validators,string [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_signer_key", new object[] {
			validators,
			keys}, callback, asyncState);
	}
	public void Endset_signer_key(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_signer_key_passphrase
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertificateValidatorOCSP", 
		RequestNamespace="urn:iControl:Management/CertificateValidatorOCSP", ResponseNamespace="urn:iControl:Management/CertificateValidatorOCSP")]
	public void set_signer_key_passphrase(
		string [] validators,
		string [] passphrases
	) {
		this.Invoke("set_signer_key_passphrase", new object [] {
				validators,
				passphrases});

	}
	public System.IAsyncResult Beginset_signer_key_passphrase(string [] validators,string [] passphrases, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_signer_key_passphrase", new object[] {
			validators,
			passphrases}, callback, asyncState);
	}
	public void Endset_signer_key_passphrase(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_status_age
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertificateValidatorOCSP", 
		RequestNamespace="urn:iControl:Management/CertificateValidatorOCSP", ResponseNamespace="urn:iControl:Management/CertificateValidatorOCSP")]
	public void set_status_age(
		string [] validators,
		long [] values
	) {
		this.Invoke("set_status_age", new object [] {
				validators,
				values});

	}
	public System.IAsyncResult Beginset_status_age(string [] validators,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_status_age", new object[] {
			validators,
			values}, callback, asyncState);
	}
	public void Endset_status_age(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_strict_responder_certificate_checking_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertificateValidatorOCSP", 
		RequestNamespace="urn:iControl:Management/CertificateValidatorOCSP", ResponseNamespace="urn:iControl:Management/CertificateValidatorOCSP")]
	public void set_strict_responder_certificate_checking_state(
		string [] validators,
		CommonEnabledState [] states
	) {
		this.Invoke("set_strict_responder_certificate_checking_state", new object [] {
				validators,
				states});

	}
	public System.IAsyncResult Beginset_strict_responder_certificate_checking_state(string [] validators,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_strict_responder_certificate_checking_state", new object[] {
			validators,
			states}, callback, asyncState);
	}
	public void Endset_strict_responder_certificate_checking_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertificateValidatorOCSP", 
		RequestNamespace="urn:iControl:Management/CertificateValidatorOCSP", ResponseNamespace="urn:iControl:Management/CertificateValidatorOCSP")]
	public void set_timeout(
		string [] validators,
		long [] values
	) {
		this.Invoke("set_timeout", new object [] {
				validators,
				values});

	}
	public System.IAsyncResult Beginset_timeout(string [] validators,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_timeout", new object[] {
			validators,
			values}, callback, asyncState);
	}
	public void Endset_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_trusted_responder
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CertificateValidatorOCSP", 
		RequestNamespace="urn:iControl:Management/CertificateValidatorOCSP", ResponseNamespace="urn:iControl:Management/CertificateValidatorOCSP")]
	public void set_trusted_responder(
		string [] validators,
		string [] certs
	) {
		this.Invoke("set_trusted_responder", new object [] {
				validators,
				certs});

	}
	public System.IAsyncResult Beginset_trusted_responder(string [] validators,string [] certs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_trusted_responder", new object[] {
			validators,
			certs}, callback, asyncState);
	}
	public void Endset_trusted_responder(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.CertificateValidatorOCSP.OCSPSignHash", Namespace = "urn:iControl")]
	public enum ManagementCertificateValidatorOCSPOCSPSignHash
	{
		OCSP_HASH_UNKNOWN,
		OCSP_HASH_SHA1,
		OCSP_HASH_SHA256,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.CertificateValidatorOCSP.CertificateValidatorOCSPStatisticEntry", Namespace = "urn:iControl")]
	public partial class ManagementCertificateValidatorOCSPCertificateValidatorOCSPStatisticEntry
	{
		private string validatorField;
		public string validator
		{
			get { return this.validatorField; }
			set { this.validatorField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.CertificateValidatorOCSP.CertificateValidatorOCSPStatistics", Namespace = "urn:iControl")]
	public partial class ManagementCertificateValidatorOCSPCertificateValidatorOCSPStatistics
	{
		private ManagementCertificateValidatorOCSPCertificateValidatorOCSPStatisticEntry [] statisticsField;
		public ManagementCertificateValidatorOCSPCertificateValidatorOCSPStatisticEntry [] statistics
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
