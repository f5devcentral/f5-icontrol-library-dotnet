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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.OCSPStaplingParametersBinding", Namespace="urn:iControl")]
	public partial class LocalLBOCSPStaplingParameters : iControlInterface {
		public LocalLBOCSPStaplingParameters() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/OCSPStaplingParameters", 
		RequestNamespace="urn:iControl:LocalLB/OCSPStaplingParameters", ResponseNamespace="urn:iControl:LocalLB/OCSPStaplingParameters")]
	public void create(
		string [] stapling_parameters,
		CommonEnabledState [] use_proxy_server_states,
		string [] pools,
		string [] dns_resolvers,
		string [] cas
	) {
		this.Invoke("create", new object [] {
				stapling_parameters,
				use_proxy_server_states,
				pools,
				dns_resolvers,
				cas});

	}
	public System.IAsyncResult Begincreate(string [] stapling_parameters,CommonEnabledState [] use_proxy_server_states,string [] pools,string [] dns_resolvers,string [] cas, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			stapling_parameters,
			use_proxy_server_states,
			pools,
			dns_resolvers,
			cas}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_ocsp_stapling_parameters
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/OCSPStaplingParameters", 
		RequestNamespace="urn:iControl:LocalLB/OCSPStaplingParameters", ResponseNamespace="urn:iControl:LocalLB/OCSPStaplingParameters")]
	public void delete_all_ocsp_stapling_parameters(

	) {
		this.Invoke("delete_all_ocsp_stapling_parameters", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_ocsp_stapling_parameters(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_ocsp_stapling_parameters", new object[0], callback, asyncState);
	}
	public void Enddelete_all_ocsp_stapling_parameters(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_ocsp_stapling_parameters
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/OCSPStaplingParameters", 
		RequestNamespace="urn:iControl:LocalLB/OCSPStaplingParameters", ResponseNamespace="urn:iControl:LocalLB/OCSPStaplingParameters")]
	public void delete_ocsp_stapling_parameters(
		string [] stapling_parameters
	) {
		this.Invoke("delete_ocsp_stapling_parameters", new object [] {
				stapling_parameters});

	}
	public System.IAsyncResult Begindelete_ocsp_stapling_parameters(string [] stapling_parameters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_ocsp_stapling_parameters", new object[] {
			stapling_parameters}, callback, asyncState);
	}
	public void Enddelete_ocsp_stapling_parameters(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_cache_error_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/OCSPStaplingParameters", 
		RequestNamespace="urn:iControl:LocalLB/OCSPStaplingParameters", ResponseNamespace="urn:iControl:LocalLB/OCSPStaplingParameters")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_cache_error_timeout(
		string [] stapling_parameters
	) {
		object [] results = this.Invoke("get_cache_error_timeout", new object [] {
				stapling_parameters});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_cache_error_timeout(string [] stapling_parameters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cache_error_timeout", new object[] {
			stapling_parameters}, callback, asyncState);
	}
	public long [] Endget_cache_error_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cache_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/OCSPStaplingParameters", 
		RequestNamespace="urn:iControl:LocalLB/OCSPStaplingParameters", ResponseNamespace="urn:iControl:LocalLB/OCSPStaplingParameters")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_cache_timeout(
		string [] stapling_parameters
	) {
		object [] results = this.Invoke("get_cache_timeout", new object [] {
				stapling_parameters});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_cache_timeout(string [] stapling_parameters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cache_timeout", new object[] {
			stapling_parameters}, callback, asyncState);
	}
	public long [] Endget_cache_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_clock_skew
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/OCSPStaplingParameters", 
		RequestNamespace="urn:iControl:LocalLB/OCSPStaplingParameters", ResponseNamespace="urn:iControl:LocalLB/OCSPStaplingParameters")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_clock_skew(
		string [] stapling_parameters
	) {
		object [] results = this.Invoke("get_clock_skew", new object [] {
				stapling_parameters});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_clock_skew(string [] stapling_parameters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_clock_skew", new object[] {
			stapling_parameters}, callback, asyncState);
	}
	public long [] Endget_clock_skew(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/OCSPStaplingParameters", 
		RequestNamespace="urn:iControl:LocalLB/OCSPStaplingParameters", ResponseNamespace="urn:iControl:LocalLB/OCSPStaplingParameters")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] stapling_parameters
	) {
		object [] results = this.Invoke("get_description", new object [] {
				stapling_parameters});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] stapling_parameters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			stapling_parameters}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dns_resolver
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/OCSPStaplingParameters", 
		RequestNamespace="urn:iControl:LocalLB/OCSPStaplingParameters", ResponseNamespace="urn:iControl:LocalLB/OCSPStaplingParameters")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_dns_resolver(
		string [] stapling_parameters
	) {
		object [] results = this.Invoke("get_dns_resolver", new object [] {
				stapling_parameters});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_dns_resolver(string [] stapling_parameters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dns_resolver", new object[] {
			stapling_parameters}, callback, asyncState);
	}
	public string [] Endget_dns_resolver(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/OCSPStaplingParameters", 
		RequestNamespace="urn:iControl:LocalLB/OCSPStaplingParameters", ResponseNamespace="urn:iControl:LocalLB/OCSPStaplingParameters")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/OCSPStaplingParameters", 
		RequestNamespace="urn:iControl:LocalLB/OCSPStaplingParameters", ResponseNamespace="urn:iControl:LocalLB/OCSPStaplingParameters")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_proxy_server_pool(
		string [] stapling_parameters
	) {
		object [] results = this.Invoke("get_proxy_server_pool", new object [] {
				stapling_parameters});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_proxy_server_pool(string [] stapling_parameters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_proxy_server_pool", new object[] {
			stapling_parameters}, callback, asyncState);
	}
	public string [] Endget_proxy_server_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_responder_url
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/OCSPStaplingParameters", 
		RequestNamespace="urn:iControl:LocalLB/OCSPStaplingParameters", ResponseNamespace="urn:iControl:LocalLB/OCSPStaplingParameters")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_responder_url(
		string [] stapling_parameters
	) {
		object [] results = this.Invoke("get_responder_url", new object [] {
				stapling_parameters});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_responder_url(string [] stapling_parameters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_responder_url", new object[] {
			stapling_parameters}, callback, asyncState);
	}
	public string [] Endget_responder_url(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_sign_hash
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/OCSPStaplingParameters", 
		RequestNamespace="urn:iControl:LocalLB/OCSPStaplingParameters", ResponseNamespace="urn:iControl:LocalLB/OCSPStaplingParameters")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBOCSPStaplingParametersOCSPStaplingSignHash [] get_sign_hash(
		string [] stapling_parameters
	) {
		object [] results = this.Invoke("get_sign_hash", new object [] {
				stapling_parameters});
		return ((LocalLBOCSPStaplingParametersOCSPStaplingSignHash [])(results[0]));
	}
	public System.IAsyncResult Beginget_sign_hash(string [] stapling_parameters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_sign_hash", new object[] {
			stapling_parameters}, callback, asyncState);
	}
	public LocalLBOCSPStaplingParametersOCSPStaplingSignHash [] Endget_sign_hash(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBOCSPStaplingParametersOCSPStaplingSignHash [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_signer_certificate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/OCSPStaplingParameters", 
		RequestNamespace="urn:iControl:LocalLB/OCSPStaplingParameters", ResponseNamespace="urn:iControl:LocalLB/OCSPStaplingParameters")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_signer_certificate(
		string [] stapling_parameters
	) {
		object [] results = this.Invoke("get_signer_certificate", new object [] {
				stapling_parameters});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_signer_certificate(string [] stapling_parameters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_signer_certificate", new object[] {
			stapling_parameters}, callback, asyncState);
	}
	public string [] Endget_signer_certificate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_signer_key
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/OCSPStaplingParameters", 
		RequestNamespace="urn:iControl:LocalLB/OCSPStaplingParameters", ResponseNamespace="urn:iControl:LocalLB/OCSPStaplingParameters")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_signer_key(
		string [] stapling_parameters
	) {
		object [] results = this.Invoke("get_signer_key", new object [] {
				stapling_parameters});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_signer_key(string [] stapling_parameters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_signer_key", new object[] {
			stapling_parameters}, callback, asyncState);
	}
	public string [] Endget_signer_key(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_status_age
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/OCSPStaplingParameters", 
		RequestNamespace="urn:iControl:LocalLB/OCSPStaplingParameters", ResponseNamespace="urn:iControl:LocalLB/OCSPStaplingParameters")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_status_age(
		string [] stapling_parameters
	) {
		object [] results = this.Invoke("get_status_age", new object [] {
				stapling_parameters});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_status_age(string [] stapling_parameters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_status_age", new object[] {
			stapling_parameters}, callback, asyncState);
	}
	public long [] Endget_status_age(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_strict_responder_certificate_checking_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/OCSPStaplingParameters", 
		RequestNamespace="urn:iControl:LocalLB/OCSPStaplingParameters", ResponseNamespace="urn:iControl:LocalLB/OCSPStaplingParameters")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_strict_responder_certificate_checking_state(
		string [] stapling_parameters
	) {
		object [] results = this.Invoke("get_strict_responder_certificate_checking_state", new object [] {
				stapling_parameters});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_strict_responder_certificate_checking_state(string [] stapling_parameters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_strict_responder_certificate_checking_state", new object[] {
			stapling_parameters}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_strict_responder_certificate_checking_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/OCSPStaplingParameters", 
		RequestNamespace="urn:iControl:LocalLB/OCSPStaplingParameters", ResponseNamespace="urn:iControl:LocalLB/OCSPStaplingParameters")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_timeout(
		string [] stapling_parameters
	) {
		object [] results = this.Invoke("get_timeout", new object [] {
				stapling_parameters});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_timeout(string [] stapling_parameters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_timeout", new object[] {
			stapling_parameters}, callback, asyncState);
	}
	public long [] Endget_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_trusted_certificate_authority
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/OCSPStaplingParameters", 
		RequestNamespace="urn:iControl:LocalLB/OCSPStaplingParameters", ResponseNamespace="urn:iControl:LocalLB/OCSPStaplingParameters")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_trusted_certificate_authority(
		string [] stapling_parameters
	) {
		object [] results = this.Invoke("get_trusted_certificate_authority", new object [] {
				stapling_parameters});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_trusted_certificate_authority(string [] stapling_parameters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_trusted_certificate_authority", new object[] {
			stapling_parameters}, callback, asyncState);
	}
	public string [] Endget_trusted_certificate_authority(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_trusted_responder
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/OCSPStaplingParameters", 
		RequestNamespace="urn:iControl:LocalLB/OCSPStaplingParameters", ResponseNamespace="urn:iControl:LocalLB/OCSPStaplingParameters")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_trusted_responder(
		string [] stapling_parameters
	) {
		object [] results = this.Invoke("get_trusted_responder", new object [] {
				stapling_parameters});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_trusted_responder(string [] stapling_parameters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_trusted_responder", new object[] {
			stapling_parameters}, callback, asyncState);
	}
	public string [] Endget_trusted_responder(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_use_proxy_server_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/OCSPStaplingParameters", 
		RequestNamespace="urn:iControl:LocalLB/OCSPStaplingParameters", ResponseNamespace="urn:iControl:LocalLB/OCSPStaplingParameters")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_use_proxy_server_state(
		string [] stapling_parameters
	) {
		object [] results = this.Invoke("get_use_proxy_server_state", new object [] {
				stapling_parameters});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_use_proxy_server_state(string [] stapling_parameters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_use_proxy_server_state", new object[] {
			stapling_parameters}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_use_proxy_server_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/OCSPStaplingParameters", 
		RequestNamespace="urn:iControl:LocalLB/OCSPStaplingParameters", ResponseNamespace="urn:iControl:LocalLB/OCSPStaplingParameters")]
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
	// set_cache_error_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/OCSPStaplingParameters", 
		RequestNamespace="urn:iControl:LocalLB/OCSPStaplingParameters", ResponseNamespace="urn:iControl:LocalLB/OCSPStaplingParameters")]
	public void set_cache_error_timeout(
		string [] stapling_parameters,
		long [] values
	) {
		this.Invoke("set_cache_error_timeout", new object [] {
				stapling_parameters,
				values});

	}
	public System.IAsyncResult Beginset_cache_error_timeout(string [] stapling_parameters,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cache_error_timeout", new object[] {
			stapling_parameters,
			values}, callback, asyncState);
	}
	public void Endset_cache_error_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_cache_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/OCSPStaplingParameters", 
		RequestNamespace="urn:iControl:LocalLB/OCSPStaplingParameters", ResponseNamespace="urn:iControl:LocalLB/OCSPStaplingParameters")]
	public void set_cache_timeout(
		string [] stapling_parameters,
		long [] values
	) {
		this.Invoke("set_cache_timeout", new object [] {
				stapling_parameters,
				values});

	}
	public System.IAsyncResult Beginset_cache_timeout(string [] stapling_parameters,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cache_timeout", new object[] {
			stapling_parameters,
			values}, callback, asyncState);
	}
	public void Endset_cache_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_clock_skew
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/OCSPStaplingParameters", 
		RequestNamespace="urn:iControl:LocalLB/OCSPStaplingParameters", ResponseNamespace="urn:iControl:LocalLB/OCSPStaplingParameters")]
	public void set_clock_skew(
		string [] stapling_parameters,
		long [] values
	) {
		this.Invoke("set_clock_skew", new object [] {
				stapling_parameters,
				values});

	}
	public System.IAsyncResult Beginset_clock_skew(string [] stapling_parameters,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_clock_skew", new object[] {
			stapling_parameters,
			values}, callback, asyncState);
	}
	public void Endset_clock_skew(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/OCSPStaplingParameters", 
		RequestNamespace="urn:iControl:LocalLB/OCSPStaplingParameters", ResponseNamespace="urn:iControl:LocalLB/OCSPStaplingParameters")]
	public void set_description(
		string [] stapling_parameters,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				stapling_parameters,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] stapling_parameters,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			stapling_parameters,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dns_resolver
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/OCSPStaplingParameters", 
		RequestNamespace="urn:iControl:LocalLB/OCSPStaplingParameters", ResponseNamespace="urn:iControl:LocalLB/OCSPStaplingParameters")]
	public void set_dns_resolver(
		string [] stapling_parameters,
		string [] dns_resolvers
	) {
		this.Invoke("set_dns_resolver", new object [] {
				stapling_parameters,
				dns_resolvers});

	}
	public System.IAsyncResult Beginset_dns_resolver(string [] stapling_parameters,string [] dns_resolvers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dns_resolver", new object[] {
			stapling_parameters,
			dns_resolvers}, callback, asyncState);
	}
	public void Endset_dns_resolver(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_proxy_server_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/OCSPStaplingParameters", 
		RequestNamespace="urn:iControl:LocalLB/OCSPStaplingParameters", ResponseNamespace="urn:iControl:LocalLB/OCSPStaplingParameters")]
	public void set_proxy_server_pool(
		string [] stapling_parameters,
		string [] pools
	) {
		this.Invoke("set_proxy_server_pool", new object [] {
				stapling_parameters,
				pools});

	}
	public System.IAsyncResult Beginset_proxy_server_pool(string [] stapling_parameters,string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_proxy_server_pool", new object[] {
			stapling_parameters,
			pools}, callback, asyncState);
	}
	public void Endset_proxy_server_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_responder_url
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/OCSPStaplingParameters", 
		RequestNamespace="urn:iControl:LocalLB/OCSPStaplingParameters", ResponseNamespace="urn:iControl:LocalLB/OCSPStaplingParameters")]
	public void set_responder_url(
		string [] stapling_parameters,
		string [] urls
	) {
		this.Invoke("set_responder_url", new object [] {
				stapling_parameters,
				urls});

	}
	public System.IAsyncResult Beginset_responder_url(string [] stapling_parameters,string [] urls, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_responder_url", new object[] {
			stapling_parameters,
			urls}, callback, asyncState);
	}
	public void Endset_responder_url(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_sign_hash
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/OCSPStaplingParameters", 
		RequestNamespace="urn:iControl:LocalLB/OCSPStaplingParameters", ResponseNamespace="urn:iControl:LocalLB/OCSPStaplingParameters")]
	public void set_sign_hash(
		string [] stapling_parameters,
		LocalLBOCSPStaplingParametersOCSPStaplingSignHash [] hashes
	) {
		this.Invoke("set_sign_hash", new object [] {
				stapling_parameters,
				hashes});

	}
	public System.IAsyncResult Beginset_sign_hash(string [] stapling_parameters,LocalLBOCSPStaplingParametersOCSPStaplingSignHash [] hashes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_sign_hash", new object[] {
			stapling_parameters,
			hashes}, callback, asyncState);
	}
	public void Endset_sign_hash(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_signer_certificate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/OCSPStaplingParameters", 
		RequestNamespace="urn:iControl:LocalLB/OCSPStaplingParameters", ResponseNamespace="urn:iControl:LocalLB/OCSPStaplingParameters")]
	public void set_signer_certificate(
		string [] stapling_parameters,
		string [] certs
	) {
		this.Invoke("set_signer_certificate", new object [] {
				stapling_parameters,
				certs});

	}
	public System.IAsyncResult Beginset_signer_certificate(string [] stapling_parameters,string [] certs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_signer_certificate", new object[] {
			stapling_parameters,
			certs}, callback, asyncState);
	}
	public void Endset_signer_certificate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_signer_key
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/OCSPStaplingParameters", 
		RequestNamespace="urn:iControl:LocalLB/OCSPStaplingParameters", ResponseNamespace="urn:iControl:LocalLB/OCSPStaplingParameters")]
	public void set_signer_key(
		string [] stapling_parameters,
		string [] keys
	) {
		this.Invoke("set_signer_key", new object [] {
				stapling_parameters,
				keys});

	}
	public System.IAsyncResult Beginset_signer_key(string [] stapling_parameters,string [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_signer_key", new object[] {
			stapling_parameters,
			keys}, callback, asyncState);
	}
	public void Endset_signer_key(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_signer_key_passphrase
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/OCSPStaplingParameters", 
		RequestNamespace="urn:iControl:LocalLB/OCSPStaplingParameters", ResponseNamespace="urn:iControl:LocalLB/OCSPStaplingParameters")]
	public void set_signer_key_passphrase(
		string [] stapling_parameters,
		string [] passphrases
	) {
		this.Invoke("set_signer_key_passphrase", new object [] {
				stapling_parameters,
				passphrases});

	}
	public System.IAsyncResult Beginset_signer_key_passphrase(string [] stapling_parameters,string [] passphrases, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_signer_key_passphrase", new object[] {
			stapling_parameters,
			passphrases}, callback, asyncState);
	}
	public void Endset_signer_key_passphrase(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_status_age
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/OCSPStaplingParameters", 
		RequestNamespace="urn:iControl:LocalLB/OCSPStaplingParameters", ResponseNamespace="urn:iControl:LocalLB/OCSPStaplingParameters")]
	public void set_status_age(
		string [] stapling_parameters,
		long [] values
	) {
		this.Invoke("set_status_age", new object [] {
				stapling_parameters,
				values});

	}
	public System.IAsyncResult Beginset_status_age(string [] stapling_parameters,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_status_age", new object[] {
			stapling_parameters,
			values}, callback, asyncState);
	}
	public void Endset_status_age(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_strict_responder_certificate_checking_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/OCSPStaplingParameters", 
		RequestNamespace="urn:iControl:LocalLB/OCSPStaplingParameters", ResponseNamespace="urn:iControl:LocalLB/OCSPStaplingParameters")]
	public void set_strict_responder_certificate_checking_state(
		string [] stapling_parameters,
		CommonEnabledState [] states
	) {
		this.Invoke("set_strict_responder_certificate_checking_state", new object [] {
				stapling_parameters,
				states});

	}
	public System.IAsyncResult Beginset_strict_responder_certificate_checking_state(string [] stapling_parameters,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_strict_responder_certificate_checking_state", new object[] {
			stapling_parameters,
			states}, callback, asyncState);
	}
	public void Endset_strict_responder_certificate_checking_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/OCSPStaplingParameters", 
		RequestNamespace="urn:iControl:LocalLB/OCSPStaplingParameters", ResponseNamespace="urn:iControl:LocalLB/OCSPStaplingParameters")]
	public void set_timeout(
		string [] stapling_parameters,
		long [] values
	) {
		this.Invoke("set_timeout", new object [] {
				stapling_parameters,
				values});

	}
	public System.IAsyncResult Beginset_timeout(string [] stapling_parameters,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_timeout", new object[] {
			stapling_parameters,
			values}, callback, asyncState);
	}
	public void Endset_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_trusted_certificate_authority
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/OCSPStaplingParameters", 
		RequestNamespace="urn:iControl:LocalLB/OCSPStaplingParameters", ResponseNamespace="urn:iControl:LocalLB/OCSPStaplingParameters")]
	public void set_trusted_certificate_authority(
		string [] stapling_parameters,
		string [] cas
	) {
		this.Invoke("set_trusted_certificate_authority", new object [] {
				stapling_parameters,
				cas});

	}
	public System.IAsyncResult Beginset_trusted_certificate_authority(string [] stapling_parameters,string [] cas, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_trusted_certificate_authority", new object[] {
			stapling_parameters,
			cas}, callback, asyncState);
	}
	public void Endset_trusted_certificate_authority(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_trusted_responder
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/OCSPStaplingParameters", 
		RequestNamespace="urn:iControl:LocalLB/OCSPStaplingParameters", ResponseNamespace="urn:iControl:LocalLB/OCSPStaplingParameters")]
	public void set_trusted_responder(
		string [] stapling_parameters,
		string [] certs
	) {
		this.Invoke("set_trusted_responder", new object [] {
				stapling_parameters,
				certs});

	}
	public System.IAsyncResult Beginset_trusted_responder(string [] stapling_parameters,string [] certs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_trusted_responder", new object[] {
			stapling_parameters,
			certs}, callback, asyncState);
	}
	public void Endset_trusted_responder(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_use_proxy_server_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/OCSPStaplingParameters", 
		RequestNamespace="urn:iControl:LocalLB/OCSPStaplingParameters", ResponseNamespace="urn:iControl:LocalLB/OCSPStaplingParameters")]
	public void set_use_proxy_server_state(
		string [] stapling_parameters,
		CommonEnabledState [] states
	) {
		this.Invoke("set_use_proxy_server_state", new object [] {
				stapling_parameters,
				states});

	}
	public System.IAsyncResult Beginset_use_proxy_server_state(string [] stapling_parameters,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_use_proxy_server_state", new object[] {
			stapling_parameters,
			states}, callback, asyncState);
	}
	public void Endset_use_proxy_server_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.OCSPStaplingParameters.OCSPStaplingSignHash", Namespace = "urn:iControl")]
	public enum LocalLBOCSPStaplingParametersOCSPStaplingSignHash
	{
		OCSP_STAPLING_HASH_UNKNOWN,
		OCSP_STAPLING_HASH_SHA1,
		OCSP_STAPLING_HASH_SHA256,
	}

	//=======================================================================
	// Structs
	//=======================================================================

}
