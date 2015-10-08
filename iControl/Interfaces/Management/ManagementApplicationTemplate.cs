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
	[System.Web.Services.WebServiceBindingAttribute(Name="Management.ApplicationTemplateBinding", Namespace="urn:iControl")]
	public partial class ManagementApplicationTemplate : iControlInterface {
		public ManagementApplicationTemplate() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_checksum
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationTemplate", 
		RequestNamespace="urn:iControl:Management/ApplicationTemplate", ResponseNamespace="urn:iControl:Management/ApplicationTemplate")]
	public void add_checksum(
		string [] templates
	) {
		this.Invoke("add_checksum", new object [] {
				templates});

	}
	public System.IAsyncResult Beginadd_checksum(string [] templates, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_checksum", new object[] {
			templates}, callback, asyncState);
	}
	public void Endadd_checksum(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_signature
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationTemplate", 
		RequestNamespace="urn:iControl:Management/ApplicationTemplate", ResponseNamespace="urn:iControl:Management/ApplicationTemplate")]
	public void add_signature(
		string [] templates,
		string [] signing_key_names,
		string [] public_cert_names
	) {
		this.Invoke("add_signature", new object [] {
				templates,
				signing_key_names,
				public_cert_names});

	}
	public System.IAsyncResult Beginadd_signature(string [] templates,string [] signing_key_names,string [] public_cert_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_signature", new object[] {
			templates,
			signing_key_names,
			public_cert_names}, callback, asyncState);
	}
	public void Endadd_signature(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// clear_verification
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationTemplate", 
		RequestNamespace="urn:iControl:Management/ApplicationTemplate", ResponseNamespace="urn:iControl:Management/ApplicationTemplate")]
	public void clear_verification(
		string [] templates
	) {
		this.Invoke("clear_verification", new object [] {
				templates});

	}
	public System.IAsyncResult Beginclear_verification(string [] templates, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("clear_verification", new object[] {
			templates}, callback, asyncState);
	}
	public void Endclear_verification(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationTemplate", 
		RequestNamespace="urn:iControl:Management/ApplicationTemplate", ResponseNamespace="urn:iControl:Management/ApplicationTemplate")]
	public void create(
		string [] templates
	) {
		this.Invoke("create", new object [] {
				templates});

	}
	public System.IAsyncResult Begincreate(string [] templates, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			templates}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_templates
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationTemplate", 
		RequestNamespace="urn:iControl:Management/ApplicationTemplate", ResponseNamespace="urn:iControl:Management/ApplicationTemplate")]
	public void delete_all_templates(

	) {
		this.Invoke("delete_all_templates", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_templates(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_templates", new object[0], callback, asyncState);
	}
	public void Enddelete_all_templates(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_application_template
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationTemplate", 
		RequestNamespace="urn:iControl:Management/ApplicationTemplate", ResponseNamespace="urn:iControl:Management/ApplicationTemplate")]
	public void delete_application_template(
		string [] templates
	) {
		this.Invoke("delete_application_template", new object [] {
				templates});

	}
	public System.IAsyncResult Begindelete_application_template(string [] templates, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_application_template", new object[] {
			templates}, callback, asyncState);
	}
	public void Enddelete_application_template(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_action_implementation
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationTemplate", 
		RequestNamespace="urn:iControl:Management/ApplicationTemplate", ResponseNamespace="urn:iControl:Management/ApplicationTemplate")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_action_implementation(
		string [] templates,
		string [] [] actions
	) {
		object [] results = this.Invoke("get_action_implementation", new object [] {
				templates,
				actions});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_action_implementation(string [] templates,string [] [] actions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action_implementation", new object[] {
			templates,
			actions}, callback, asyncState);
	}
	public string [] [] Endget_action_implementation(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_action_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationTemplate", 
		RequestNamespace="urn:iControl:Management/ApplicationTemplate", ResponseNamespace="urn:iControl:Management/ApplicationTemplate")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_action_list(
		string [] templates
	) {
		object [] results = this.Invoke("get_action_list", new object [] {
				templates});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_action_list(string [] templates, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action_list", new object[] {
			templates}, callback, asyncState);
	}
	public string [] [] Endget_action_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_action_presentation
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationTemplate", 
		RequestNamespace="urn:iControl:Management/ApplicationTemplate", ResponseNamespace="urn:iControl:Management/ApplicationTemplate")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_action_presentation(
		string [] templates,
		string [] [] actions
	) {
		object [] results = this.Invoke("get_action_presentation", new object [] {
				templates,
				actions});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_action_presentation(string [] templates,string [] [] actions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action_presentation", new object[] {
			templates,
			actions}, callback, asyncState);
	}
	public string [] [] Endget_action_presentation(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_action_presentation_help
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationTemplate", 
		RequestNamespace="urn:iControl:Management/ApplicationTemplate", ResponseNamespace="urn:iControl:Management/ApplicationTemplate")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_action_presentation_help(
		string [] templates,
		string [] [] actions
	) {
		object [] results = this.Invoke("get_action_presentation_help", new object [] {
				templates,
				actions});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_action_presentation_help(string [] templates,string [] [] actions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action_presentation_help", new object[] {
			templates,
			actions}, callback, asyncState);
	}
	public string [] [] Endget_action_presentation_help(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationTemplate", 
		RequestNamespace="urn:iControl:Management/ApplicationTemplate", ResponseNamespace="urn:iControl:Management/ApplicationTemplate")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] templates
	) {
		object [] results = this.Invoke("get_description", new object [] {
				templates});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] templates, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			templates}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ignore_verification_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationTemplate", 
		RequestNamespace="urn:iControl:Management/ApplicationTemplate", ResponseNamespace="urn:iControl:Management/ApplicationTemplate")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_ignore_verification_state(
		string [] templates
	) {
		object [] results = this.Invoke("get_ignore_verification_state", new object [] {
				templates});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_ignore_verification_state(string [] templates, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ignore_verification_state", new object[] {
			templates}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_ignore_verification_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationTemplate", 
		RequestNamespace="urn:iControl:Management/ApplicationTemplate", ResponseNamespace="urn:iControl:Management/ApplicationTemplate")]
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
	// get_prerequisite_bigip_version_maximum
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationTemplate", 
		RequestNamespace="urn:iControl:Management/ApplicationTemplate", ResponseNamespace="urn:iControl:Management/ApplicationTemplate")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_prerequisite_bigip_version_maximum(
		string [] templates
	) {
		object [] results = this.Invoke("get_prerequisite_bigip_version_maximum", new object [] {
				templates});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_prerequisite_bigip_version_maximum(string [] templates, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_prerequisite_bigip_version_maximum", new object[] {
			templates}, callback, asyncState);
	}
	public string [] Endget_prerequisite_bigip_version_maximum(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_prerequisite_bigip_version_minimum
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationTemplate", 
		RequestNamespace="urn:iControl:Management/ApplicationTemplate", ResponseNamespace="urn:iControl:Management/ApplicationTemplate")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_prerequisite_bigip_version_minimum(
		string [] templates
	) {
		object [] results = this.Invoke("get_prerequisite_bigip_version_minimum", new object [] {
				templates});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_prerequisite_bigip_version_minimum(string [] templates, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_prerequisite_bigip_version_minimum", new object[] {
			templates}, callback, asyncState);
	}
	public string [] Endget_prerequisite_bigip_version_minimum(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_prerequisite_errors
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationTemplate", 
		RequestNamespace="urn:iControl:Management/ApplicationTemplate", ResponseNamespace="urn:iControl:Management/ApplicationTemplate")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_prerequisite_errors(
		string [] templates
	) {
		object [] results = this.Invoke("get_prerequisite_errors", new object [] {
				templates});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_prerequisite_errors(string [] templates, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_prerequisite_errors", new object[] {
			templates}, callback, asyncState);
	}
	public string [] Endget_prerequisite_errors(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_prerequisite_modules
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationTemplate", 
		RequestNamespace="urn:iControl:Management/ApplicationTemplate", ResponseNamespace="urn:iControl:Management/ApplicationTemplate")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonTMOSModule [] [] get_prerequisite_modules(
		string [] templates
	) {
		object [] results = this.Invoke("get_prerequisite_modules", new object [] {
				templates});
		return ((CommonTMOSModule [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_prerequisite_modules(string [] templates, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_prerequisite_modules", new object[] {
			templates}, callback, asyncState);
	}
	public CommonTMOSModule [] [] Endget_prerequisite_modules(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonTMOSModule [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_verification_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationTemplate", 
		RequestNamespace="urn:iControl:Management/ApplicationTemplate", ResponseNamespace="urn:iControl:Management/ApplicationTemplate")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonVerificationStatus [] get_verification_status(
		string [] templates
	) {
		object [] results = this.Invoke("get_verification_status", new object [] {
				templates});
		return ((CommonVerificationStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_verification_status(string [] templates, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_verification_status", new object[] {
			templates}, callback, asyncState);
	}
	public CommonVerificationStatus [] Endget_verification_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonVerificationStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationTemplate", 
		RequestNamespace="urn:iControl:Management/ApplicationTemplate", ResponseNamespace="urn:iControl:Management/ApplicationTemplate")]
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
	// set_action_implementation
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationTemplate", 
		RequestNamespace="urn:iControl:Management/ApplicationTemplate", ResponseNamespace="urn:iControl:Management/ApplicationTemplate")]
	public void set_action_implementation(
		string [] templates,
		string [] [] actions,
		string [] [] values
	) {
		this.Invoke("set_action_implementation", new object [] {
				templates,
				actions,
				values});

	}
	public System.IAsyncResult Beginset_action_implementation(string [] templates,string [] [] actions,string [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_action_implementation", new object[] {
			templates,
			actions,
			values}, callback, asyncState);
	}
	public void Endset_action_implementation(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_action_presentation
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationTemplate", 
		RequestNamespace="urn:iControl:Management/ApplicationTemplate", ResponseNamespace="urn:iControl:Management/ApplicationTemplate")]
	public void set_action_presentation(
		string [] templates,
		string [] [] actions,
		string [] [] values
	) {
		this.Invoke("set_action_presentation", new object [] {
				templates,
				actions,
				values});

	}
	public System.IAsyncResult Beginset_action_presentation(string [] templates,string [] [] actions,string [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_action_presentation", new object[] {
			templates,
			actions,
			values}, callback, asyncState);
	}
	public void Endset_action_presentation(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_action_presentation_help
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationTemplate", 
		RequestNamespace="urn:iControl:Management/ApplicationTemplate", ResponseNamespace="urn:iControl:Management/ApplicationTemplate")]
	public void set_action_presentation_help(
		string [] templates,
		string [] [] actions,
		string [] [] values
	) {
		this.Invoke("set_action_presentation_help", new object [] {
				templates,
				actions,
				values});

	}
	public System.IAsyncResult Beginset_action_presentation_help(string [] templates,string [] [] actions,string [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_action_presentation_help", new object[] {
			templates,
			actions,
			values}, callback, asyncState);
	}
	public void Endset_action_presentation_help(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationTemplate", 
		RequestNamespace="urn:iControl:Management/ApplicationTemplate", ResponseNamespace="urn:iControl:Management/ApplicationTemplate")]
	public void set_description(
		string [] templates,
		string [] values
	) {
		this.Invoke("set_description", new object [] {
				templates,
				values});

	}
	public System.IAsyncResult Beginset_description(string [] templates,string [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			templates,
			values}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ignore_verification_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationTemplate", 
		RequestNamespace="urn:iControl:Management/ApplicationTemplate", ResponseNamespace="urn:iControl:Management/ApplicationTemplate")]
	public void set_ignore_verification_state(
		string [] templates,
		CommonEnabledState [] states
	) {
		this.Invoke("set_ignore_verification_state", new object [] {
				templates,
				states});

	}
	public System.IAsyncResult Beginset_ignore_verification_state(string [] templates,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ignore_verification_state", new object[] {
			templates,
			states}, callback, asyncState);
	}
	public void Endset_ignore_verification_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_prerequisite_bigip_version_maximum
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationTemplate", 
		RequestNamespace="urn:iControl:Management/ApplicationTemplate", ResponseNamespace="urn:iControl:Management/ApplicationTemplate")]
	public void set_prerequisite_bigip_version_maximum(
		string [] templates,
		string [] values
	) {
		this.Invoke("set_prerequisite_bigip_version_maximum", new object [] {
				templates,
				values});

	}
	public System.IAsyncResult Beginset_prerequisite_bigip_version_maximum(string [] templates,string [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_prerequisite_bigip_version_maximum", new object[] {
			templates,
			values}, callback, asyncState);
	}
	public void Endset_prerequisite_bigip_version_maximum(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_prerequisite_bigip_version_minimum
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationTemplate", 
		RequestNamespace="urn:iControl:Management/ApplicationTemplate", ResponseNamespace="urn:iControl:Management/ApplicationTemplate")]
	public void set_prerequisite_bigip_version_minimum(
		string [] templates,
		string [] values
	) {
		this.Invoke("set_prerequisite_bigip_version_minimum", new object [] {
				templates,
				values});

	}
	public System.IAsyncResult Beginset_prerequisite_bigip_version_minimum(string [] templates,string [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_prerequisite_bigip_version_minimum", new object[] {
			templates,
			values}, callback, asyncState);
	}
	public void Endset_prerequisite_bigip_version_minimum(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_prerequisite_modules
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ApplicationTemplate", 
		RequestNamespace="urn:iControl:Management/ApplicationTemplate", ResponseNamespace="urn:iControl:Management/ApplicationTemplate")]
	public void set_prerequisite_modules(
		string [] templates,
		CommonTMOSModule [] [] values
	) {
		this.Invoke("set_prerequisite_modules", new object [] {
				templates,
				values});

	}
	public System.IAsyncResult Beginset_prerequisite_modules(string [] templates,CommonTMOSModule [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_prerequisite_modules", new object[] {
			templates,
			values}, callback, asyncState);
	}
	public void Endset_prerequisite_modules(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	//=======================================================================
	// Structs
	//=======================================================================

}
