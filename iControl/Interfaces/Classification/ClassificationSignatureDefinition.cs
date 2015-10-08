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
	[System.Web.Services.WebServiceBindingAttribute(Name="Classification.SignatureDefinitionBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonTimeStamp))]
	public partial class ClassificationSignatureDefinition : iControlInterface {
		public ClassificationSignatureDefinition() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// get_last_attempt_automatic_mode_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Classification/SignatureDefinition", 
		RequestNamespace="urn:iControl:Classification/SignatureDefinition", ResponseNamespace="urn:iControl:Classification/SignatureDefinition")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_last_attempt_automatic_mode_state(
		string [] definitions
	) {
		object [] results = this.Invoke("get_last_attempt_automatic_mode_state", new object [] {
				definitions});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_last_attempt_automatic_mode_state(string [] definitions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_last_attempt_automatic_mode_state", new object[] {
			definitions}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_last_attempt_automatic_mode_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_last_attempt_time
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Classification/SignatureDefinition", 
		RequestNamespace="urn:iControl:Classification/SignatureDefinition", ResponseNamespace="urn:iControl:Classification/SignatureDefinition")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonTimeStamp [] get_last_attempt_time(
		string [] definitions
	) {
		object [] results = this.Invoke("get_last_attempt_time", new object [] {
				definitions});
		return ((CommonTimeStamp [])(results[0]));
	}
	public System.IAsyncResult Beginget_last_attempt_time(string [] definitions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_last_attempt_time", new object[] {
			definitions}, callback, asyncState);
	}
	public CommonTimeStamp [] Endget_last_attempt_time(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonTimeStamp [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_last_attempt_user
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Classification/SignatureDefinition", 
		RequestNamespace="urn:iControl:Classification/SignatureDefinition", ResponseNamespace="urn:iControl:Classification/SignatureDefinition")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_last_attempt_user(
		string [] definitions
	) {
		object [] results = this.Invoke("get_last_attempt_user", new object [] {
				definitions});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_last_attempt_user(string [] definitions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_last_attempt_user", new object[] {
			definitions}, callback, asyncState);
	}
	public string [] Endget_last_attempt_user(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_last_update_automatic_mode_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Classification/SignatureDefinition", 
		RequestNamespace="urn:iControl:Classification/SignatureDefinition", ResponseNamespace="urn:iControl:Classification/SignatureDefinition")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_last_update_automatic_mode_state(
		string [] definitions
	) {
		object [] results = this.Invoke("get_last_update_automatic_mode_state", new object [] {
				definitions});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_last_update_automatic_mode_state(string [] definitions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_last_update_automatic_mode_state", new object[] {
			definitions}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_last_update_automatic_mode_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_last_update_time
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Classification/SignatureDefinition", 
		RequestNamespace="urn:iControl:Classification/SignatureDefinition", ResponseNamespace="urn:iControl:Classification/SignatureDefinition")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonTimeStamp [] get_last_update_time(
		string [] definitions
	) {
		object [] results = this.Invoke("get_last_update_time", new object [] {
				definitions});
		return ((CommonTimeStamp [])(results[0]));
	}
	public System.IAsyncResult Beginget_last_update_time(string [] definitions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_last_update_time", new object[] {
			definitions}, callback, asyncState);
	}
	public CommonTimeStamp [] Endget_last_update_time(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonTimeStamp [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_last_update_user
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Classification/SignatureDefinition", 
		RequestNamespace="urn:iControl:Classification/SignatureDefinition", ResponseNamespace="urn:iControl:Classification/SignatureDefinition")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_last_update_user(
		string [] definitions
	) {
		object [] results = this.Invoke("get_last_update_user", new object [] {
				definitions});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_last_update_user(string [] definitions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_last_update_user", new object[] {
			definitions}, callback, asyncState);
	}
	public string [] Endget_last_update_user(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Classification/SignatureDefinition", 
		RequestNamespace="urn:iControl:Classification/SignatureDefinition", ResponseNamespace="urn:iControl:Classification/SignatureDefinition")]
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
	// get_message
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Classification/SignatureDefinition", 
		RequestNamespace="urn:iControl:Classification/SignatureDefinition", ResponseNamespace="urn:iControl:Classification/SignatureDefinition")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_message(
		string [] definitions
	) {
		object [] results = this.Invoke("get_message", new object [] {
				definitions});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_message(string [] definitions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_message", new object[] {
			definitions}, callback, asyncState);
	}
	public string [] Endget_message(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_progress_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Classification/SignatureDefinition", 
		RequestNamespace="urn:iControl:Classification/SignatureDefinition", ResponseNamespace="urn:iControl:Classification/SignatureDefinition")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ClassificationSignatureUpdateProgressStatus [] get_progress_status(
		string [] definitions
	) {
		object [] results = this.Invoke("get_progress_status", new object [] {
				definitions});
		return ((ClassificationSignatureUpdateProgressStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_progress_status(string [] definitions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_progress_status", new object[] {
			definitions}, callback, asyncState);
	}
	public ClassificationSignatureUpdateProgressStatus [] Endget_progress_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ClassificationSignatureUpdateProgressStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Classification/SignatureDefinition", 
		RequestNamespace="urn:iControl:Classification/SignatureDefinition", ResponseNamespace="urn:iControl:Classification/SignatureDefinition")]
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

	}
	//=======================================================================
	// Enums
	//=======================================================================

	//=======================================================================
	// Structs
	//=======================================================================

}
