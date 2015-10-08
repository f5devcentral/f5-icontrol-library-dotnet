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
	[System.Web.Services.WebServiceBindingAttribute(Name="Management.OCSPResponderBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementOCSPResponderResponderDefinition))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementOCSPResponderSignInformation))]
	public partial class ManagementOCSPResponder : iControlInterface {
		public ManagementOCSPResponder() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	public void create(
		ManagementOCSPResponderResponderDefinition [] responders
	) {
		this.Invoke("create", new object [] {
				responders});

	}
	public System.IAsyncResult Begincreate(ManagementOCSPResponderResponderDefinition [] responders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			responders}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_responders
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	public void delete_all_responders(

	) {
		this.Invoke("delete_all_responders", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_responders(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_responders", new object[0], callback, asyncState);
	}
	public void Enddelete_all_responders(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_responder
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	public void delete_responder(
		string [] responders
	) {
		this.Invoke("delete_responder", new object [] {
				responders});

	}
	public System.IAsyncResult Begindelete_responder(string [] responders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_responder", new object[] {
			responders}, callback, asyncState);
	}
	public void Enddelete_responder(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_allow_additional_certificate_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_allow_additional_certificate_state(
		string [] responders
	) {
		object [] results = this.Invoke("get_allow_additional_certificate_state", new object [] {
				responders});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_allow_additional_certificate_state(string [] responders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_allow_additional_certificate_state", new object[] {
			responders}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_allow_additional_certificate_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ca_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_ca_file(
		string [] responders
	) {
		object [] results = this.Invoke("get_ca_file", new object [] {
				responders});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_ca_file(string [] responders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ca_file", new object[] {
			responders}, callback, asyncState);
	}
	public string [] Endget_ca_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ca_file_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_ca_file_v2(
		string [] responders
	) {
		object [] results = this.Invoke("get_ca_file_v2", new object [] {
				responders});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_ca_file_v2(string [] responders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ca_file_v2", new object[] {
			responders}, callback, asyncState);
	}
	public string [] Endget_ca_file_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ca_path
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_ca_path(
		string [] responders
	) {
		object [] results = this.Invoke("get_ca_path", new object [] {
				responders});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_ca_path(string [] responders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ca_path", new object[] {
			responders}, callback, asyncState);
	}
	public string [] Endget_ca_path(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_certificate_check_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_certificate_check_state(
		string [] responders
	) {
		object [] results = this.Invoke("get_certificate_check_state", new object [] {
				responders});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_certificate_check_state(string [] responders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_certificate_check_state", new object[] {
			responders}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_certificate_check_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_certificate_id_digest_method
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementOCSPDigestMethod [] get_certificate_id_digest_method(
		string [] responders
	) {
		object [] results = this.Invoke("get_certificate_id_digest_method", new object [] {
				responders});
		return ((ManagementOCSPDigestMethod [])(results[0]));
	}
	public System.IAsyncResult Beginget_certificate_id_digest_method(string [] responders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_certificate_id_digest_method", new object[] {
			responders}, callback, asyncState);
	}
	public ManagementOCSPDigestMethod [] Endget_certificate_id_digest_method(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementOCSPDigestMethod [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_certificate_verification_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_certificate_verification_state(
		string [] responders
	) {
		object [] results = this.Invoke("get_certificate_verification_state", new object [] {
				responders});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_certificate_verification_state(string [] responders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_certificate_verification_state", new object[] {
			responders}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_certificate_verification_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_chain_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_chain_state(
		string [] responders
	) {
		object [] results = this.Invoke("get_chain_state", new object [] {
				responders});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_chain_state(string [] responders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_chain_state", new object[] {
			responders}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_chain_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] responders
	) {
		object [] results = this.Invoke("get_description", new object [] {
				responders});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] responders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			responders}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_explicit_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_explicit_state(
		string [] responders
	) {
		object [] results = this.Invoke("get_explicit_state", new object [] {
				responders});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_explicit_state(string [] responders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_explicit_state", new object[] {
			responders}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_explicit_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ignore_aia_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_ignore_aia_state(
		string [] responders
	) {
		object [] results = this.Invoke("get_ignore_aia_state", new object [] {
				responders});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_ignore_aia_state(string [] responders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ignore_aia_state", new object[] {
			responders}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_ignore_aia_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_intern_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_intern_state(
		string [] responders
	) {
		object [] results = this.Invoke("get_intern_state", new object [] {
				responders});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_intern_state(string [] responders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_intern_state", new object[] {
			responders}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_intern_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
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
	// get_nonce_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_nonce_state(
		string [] responders
	) {
		object [] results = this.Invoke("get_nonce_state", new object [] {
				responders});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_nonce_state(string [] responders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_nonce_state", new object[] {
			responders}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_nonce_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_other_certificate_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_other_certificate_file(
		string [] responders
	) {
		object [] results = this.Invoke("get_other_certificate_file", new object [] {
				responders});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_other_certificate_file(string [] responders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_other_certificate_file", new object[] {
			responders}, callback, asyncState);
	}
	public string [] Endget_other_certificate_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_other_certificate_file_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_other_certificate_file_v2(
		string [] responders
	) {
		object [] results = this.Invoke("get_other_certificate_file_v2", new object [] {
				responders});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_other_certificate_file_v2(string [] responders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_other_certificate_file_v2", new object[] {
			responders}, callback, asyncState);
	}
	public string [] Endget_other_certificate_file_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_signature_verification_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_signature_verification_state(
		string [] responders
	) {
		object [] results = this.Invoke("get_signature_verification_state", new object [] {
				responders});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_signature_verification_state(string [] responders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_signature_verification_state", new object[] {
			responders}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_signature_verification_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_signing_information
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementOCSPResponderSignInformation [] get_signing_information(
		string [] responders
	) {
		object [] results = this.Invoke("get_signing_information", new object [] {
				responders});
		return ((ManagementOCSPResponderSignInformation [])(results[0]));
	}
	public System.IAsyncResult Beginget_signing_information(string [] responders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_signing_information", new object[] {
			responders}, callback, asyncState);
	}
	public ManagementOCSPResponderSignInformation [] Endget_signing_information(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementOCSPResponderSignInformation [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_signing_information_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementOCSPResponderSignInformation [] get_signing_information_v2(
		string [] responders
	) {
		object [] results = this.Invoke("get_signing_information_v2", new object [] {
				responders});
		return ((ManagementOCSPResponderSignInformation [])(results[0]));
	}
	public System.IAsyncResult Beginget_signing_information_v2(string [] responders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_signing_information_v2", new object[] {
			responders}, callback, asyncState);
	}
	public ManagementOCSPResponderSignInformation [] Endget_signing_information_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementOCSPResponderSignInformation [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_status_age
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_status_age(
		string [] responders
	) {
		object [] results = this.Invoke("get_status_age", new object [] {
				responders});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_status_age(string [] responders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_status_age", new object[] {
			responders}, callback, asyncState);
	}
	public long [] Endget_status_age(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_trust_other_certificate_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_trust_other_certificate_state(
		string [] responders
	) {
		object [] results = this.Invoke("get_trust_other_certificate_state", new object [] {
				responders});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_trust_other_certificate_state(string [] responders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_trust_other_certificate_state", new object[] {
			responders}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_trust_other_certificate_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_url
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_url(
		string [] responders
	) {
		object [] results = this.Invoke("get_url", new object [] {
				responders});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_url(string [] responders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_url", new object[] {
			responders}, callback, asyncState);
	}
	public string [] Endget_url(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_va_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_va_file(
		string [] responders
	) {
		object [] results = this.Invoke("get_va_file", new object [] {
				responders});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_va_file(string [] responders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_va_file", new object[] {
			responders}, callback, asyncState);
	}
	public string [] Endget_va_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_va_file_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_va_file_v2(
		string [] responders
	) {
		object [] results = this.Invoke("get_va_file_v2", new object [] {
				responders});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_va_file_v2(string [] responders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_va_file_v2", new object[] {
			responders}, callback, asyncState);
	}
	public string [] Endget_va_file_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_validity_period
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_validity_period(
		string [] responders
	) {
		object [] results = this.Invoke("get_validity_period", new object [] {
				responders});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_validity_period(string [] responders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_validity_period", new object[] {
			responders}, callback, asyncState);
	}
	public long [] Endget_validity_period(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_verification_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_verification_state(
		string [] responders
	) {
		object [] results = this.Invoke("get_verification_state", new object [] {
				responders});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_verification_state(string [] responders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_verification_state", new object[] {
			responders}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_verification_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
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
	// set_allow_additional_certificate_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	public void set_allow_additional_certificate_state(
		string [] responders,
		CommonEnabledState [] states
	) {
		this.Invoke("set_allow_additional_certificate_state", new object [] {
				responders,
				states});

	}
	public System.IAsyncResult Beginset_allow_additional_certificate_state(string [] responders,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_allow_additional_certificate_state", new object[] {
			responders,
			states}, callback, asyncState);
	}
	public void Endset_allow_additional_certificate_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ca_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	public void set_ca_file(
		string [] responders,
		string [] ca_files
	) {
		this.Invoke("set_ca_file", new object [] {
				responders,
				ca_files});

	}
	public System.IAsyncResult Beginset_ca_file(string [] responders,string [] ca_files, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ca_file", new object[] {
			responders,
			ca_files}, callback, asyncState);
	}
	public void Endset_ca_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ca_file_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	public void set_ca_file_v2(
		string [] responders,
		string [] ca_files
	) {
		this.Invoke("set_ca_file_v2", new object [] {
				responders,
				ca_files});

	}
	public System.IAsyncResult Beginset_ca_file_v2(string [] responders,string [] ca_files, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ca_file_v2", new object[] {
			responders,
			ca_files}, callback, asyncState);
	}
	public void Endset_ca_file_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ca_path
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	public void set_ca_path(
		string [] responders,
		string [] ca_paths
	) {
		this.Invoke("set_ca_path", new object [] {
				responders,
				ca_paths});

	}
	public System.IAsyncResult Beginset_ca_path(string [] responders,string [] ca_paths, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ca_path", new object[] {
			responders,
			ca_paths}, callback, asyncState);
	}
	public void Endset_ca_path(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_certificate_check_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	public void set_certificate_check_state(
		string [] responders,
		CommonEnabledState [] states
	) {
		this.Invoke("set_certificate_check_state", new object [] {
				responders,
				states});

	}
	public System.IAsyncResult Beginset_certificate_check_state(string [] responders,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_certificate_check_state", new object[] {
			responders,
			states}, callback, asyncState);
	}
	public void Endset_certificate_check_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_certificate_id_digest_method
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	public void set_certificate_id_digest_method(
		string [] responders,
		ManagementOCSPDigestMethod [] digest_methods
	) {
		this.Invoke("set_certificate_id_digest_method", new object [] {
				responders,
				digest_methods});

	}
	public System.IAsyncResult Beginset_certificate_id_digest_method(string [] responders,ManagementOCSPDigestMethod [] digest_methods, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_certificate_id_digest_method", new object[] {
			responders,
			digest_methods}, callback, asyncState);
	}
	public void Endset_certificate_id_digest_method(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_certificate_verification_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	public void set_certificate_verification_state(
		string [] responders,
		CommonEnabledState [] states
	) {
		this.Invoke("set_certificate_verification_state", new object [] {
				responders,
				states});

	}
	public System.IAsyncResult Beginset_certificate_verification_state(string [] responders,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_certificate_verification_state", new object[] {
			responders,
			states}, callback, asyncState);
	}
	public void Endset_certificate_verification_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_chain_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	public void set_chain_state(
		string [] responders,
		CommonEnabledState [] states
	) {
		this.Invoke("set_chain_state", new object [] {
				responders,
				states});

	}
	public System.IAsyncResult Beginset_chain_state(string [] responders,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_chain_state", new object[] {
			responders,
			states}, callback, asyncState);
	}
	public void Endset_chain_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	public void set_description(
		string [] responders,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				responders,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] responders,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			responders,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_explicit_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	public void set_explicit_state(
		string [] responders,
		CommonEnabledState [] states
	) {
		this.Invoke("set_explicit_state", new object [] {
				responders,
				states});

	}
	public System.IAsyncResult Beginset_explicit_state(string [] responders,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_explicit_state", new object[] {
			responders,
			states}, callback, asyncState);
	}
	public void Endset_explicit_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ignore_aia_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	public void set_ignore_aia_state(
		string [] responders,
		CommonEnabledState [] states
	) {
		this.Invoke("set_ignore_aia_state", new object [] {
				responders,
				states});

	}
	public System.IAsyncResult Beginset_ignore_aia_state(string [] responders,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ignore_aia_state", new object[] {
			responders,
			states}, callback, asyncState);
	}
	public void Endset_ignore_aia_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_intern_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	public void set_intern_state(
		string [] responders,
		CommonEnabledState [] states
	) {
		this.Invoke("set_intern_state", new object [] {
				responders,
				states});

	}
	public System.IAsyncResult Beginset_intern_state(string [] responders,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_intern_state", new object[] {
			responders,
			states}, callback, asyncState);
	}
	public void Endset_intern_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_nonce_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	public void set_nonce_state(
		string [] responders,
		CommonEnabledState [] states
	) {
		this.Invoke("set_nonce_state", new object [] {
				responders,
				states});

	}
	public System.IAsyncResult Beginset_nonce_state(string [] responders,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_nonce_state", new object[] {
			responders,
			states}, callback, asyncState);
	}
	public void Endset_nonce_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_other_certificate_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	public void set_other_certificate_file(
		string [] responders,
		string [] other_files
	) {
		this.Invoke("set_other_certificate_file", new object [] {
				responders,
				other_files});

	}
	public System.IAsyncResult Beginset_other_certificate_file(string [] responders,string [] other_files, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_other_certificate_file", new object[] {
			responders,
			other_files}, callback, asyncState);
	}
	public void Endset_other_certificate_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_other_certificate_file_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	public void set_other_certificate_file_v2(
		string [] responders,
		string [] other_files
	) {
		this.Invoke("set_other_certificate_file_v2", new object [] {
				responders,
				other_files});

	}
	public System.IAsyncResult Beginset_other_certificate_file_v2(string [] responders,string [] other_files, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_other_certificate_file_v2", new object[] {
			responders,
			other_files}, callback, asyncState);
	}
	public void Endset_other_certificate_file_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_signature_verification_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	public void set_signature_verification_state(
		string [] responders,
		CommonEnabledState [] states
	) {
		this.Invoke("set_signature_verification_state", new object [] {
				responders,
				states});

	}
	public System.IAsyncResult Beginset_signature_verification_state(string [] responders,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_signature_verification_state", new object[] {
			responders,
			states}, callback, asyncState);
	}
	public void Endset_signature_verification_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_signing_information
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	public void set_signing_information(
		string [] responders,
		ManagementOCSPResponderSignInformation [] signers
	) {
		this.Invoke("set_signing_information", new object [] {
				responders,
				signers});

	}
	public System.IAsyncResult Beginset_signing_information(string [] responders,ManagementOCSPResponderSignInformation [] signers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_signing_information", new object[] {
			responders,
			signers}, callback, asyncState);
	}
	public void Endset_signing_information(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_signing_information_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	public void set_signing_information_v2(
		string [] responders,
		ManagementOCSPResponderSignInformation [] signers
	) {
		this.Invoke("set_signing_information_v2", new object [] {
				responders,
				signers});

	}
	public System.IAsyncResult Beginset_signing_information_v2(string [] responders,ManagementOCSPResponderSignInformation [] signers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_signing_information_v2", new object[] {
			responders,
			signers}, callback, asyncState);
	}
	public void Endset_signing_information_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_status_age
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	public void set_status_age(
		string [] responders,
		long [] ages
	) {
		this.Invoke("set_status_age", new object [] {
				responders,
				ages});

	}
	public System.IAsyncResult Beginset_status_age(string [] responders,long [] ages, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_status_age", new object[] {
			responders,
			ages}, callback, asyncState);
	}
	public void Endset_status_age(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_trust_other_certificate_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	public void set_trust_other_certificate_state(
		string [] responders,
		CommonEnabledState [] states
	) {
		this.Invoke("set_trust_other_certificate_state", new object [] {
				responders,
				states});

	}
	public System.IAsyncResult Beginset_trust_other_certificate_state(string [] responders,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_trust_other_certificate_state", new object[] {
			responders,
			states}, callback, asyncState);
	}
	public void Endset_trust_other_certificate_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_url
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	public void set_url(
		string [] responders,
		string [] urls
	) {
		this.Invoke("set_url", new object [] {
				responders,
				urls});

	}
	public System.IAsyncResult Beginset_url(string [] responders,string [] urls, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_url", new object[] {
			responders,
			urls}, callback, asyncState);
	}
	public void Endset_url(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_va_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	public void set_va_file(
		string [] responders,
		string [] va_files
	) {
		this.Invoke("set_va_file", new object [] {
				responders,
				va_files});

	}
	public System.IAsyncResult Beginset_va_file(string [] responders,string [] va_files, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_va_file", new object[] {
			responders,
			va_files}, callback, asyncState);
	}
	public void Endset_va_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_va_file_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	public void set_va_file_v2(
		string [] responders,
		string [] va_files
	) {
		this.Invoke("set_va_file_v2", new object [] {
				responders,
				va_files});

	}
	public System.IAsyncResult Beginset_va_file_v2(string [] responders,string [] va_files, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_va_file_v2", new object[] {
			responders,
			va_files}, callback, asyncState);
	}
	public void Endset_va_file_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_validity_period
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	public void set_validity_period(
		string [] responders,
		long [] ranges
	) {
		this.Invoke("set_validity_period", new object [] {
				responders,
				ranges});

	}
	public System.IAsyncResult Beginset_validity_period(string [] responders,long [] ranges, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_validity_period", new object[] {
			responders,
			ranges}, callback, asyncState);
	}
	public void Endset_validity_period(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_verification_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/OCSPResponder", 
		RequestNamespace="urn:iControl:Management/OCSPResponder", ResponseNamespace="urn:iControl:Management/OCSPResponder")]
	public void set_verification_state(
		string [] responders,
		CommonEnabledState [] states
	) {
		this.Invoke("set_verification_state", new object [] {
				responders,
				states});

	}
	public System.IAsyncResult Beginset_verification_state(string [] responders,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_verification_state", new object[] {
			responders,
			states}, callback, asyncState);
	}
	public void Endset_verification_state(System.IAsyncResult asyncResult) {
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.OCSPResponder.ResponderDefinition", Namespace = "urn:iControl")]
	public partial class ManagementOCSPResponderResponderDefinition
	{
		private string nameField;
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}
		private string urlField;
		public string url
		{
			get { return this.urlField; }
			set { this.urlField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.OCSPResponder.SignInformation", Namespace = "urn:iControl")]
	public partial class ManagementOCSPResponderSignInformation
	{
		private string signer_certificateField;
		public string signer_certificate
		{
			get { return this.signer_certificateField; }
			set { this.signer_certificateField = value; }
		}
		private string private_keyField;
		public string private_key
		{
			get { return this.private_keyField; }
			set { this.private_keyField = value; }
		}
		private string pass_phraseField;
		public string pass_phrase
		{
			get { return this.pass_phraseField; }
			set { this.pass_phraseField = value; }
		}
		private string other_certificateField;
		public string other_certificate
		{
			get { return this.other_certificateField; }
			set { this.other_certificateField = value; }
		}
		private ManagementOCSPDigestMethod digest_methodField;
		public ManagementOCSPDigestMethod digest_method
		{
			get { return this.digest_methodField; }
			set { this.digest_methodField = value; }
		}
	};

}
