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
	[System.Web.Services.WebServiceBindingAttribute(Name="ASM.WebApplicationBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ASMApplyLearning))]
	public partial class ASMWebApplication : iControlInterface {
		public ASMWebApplication() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// delete_all_disabled_webapps
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/WebApplication", 
		RequestNamespace="urn:iControl:ASM/WebApplication", ResponseNamespace="urn:iControl:ASM/WebApplication")]
	public void delete_all_disabled_webapps(

	) {
		this.Invoke("delete_all_disabled_webapps", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_disabled_webapps(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_disabled_webapps", new object[0], callback, asyncState);
	}
	public void Enddelete_all_disabled_webapps(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_non_active_policies
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/WebApplication", 
		RequestNamespace="urn:iControl:ASM/WebApplication", ResponseNamespace="urn:iControl:ASM/WebApplication")]
	public void delete_all_non_active_policies(
		string [] webapp_names
	) {
		this.Invoke("delete_all_non_active_policies", new object [] {
				webapp_names});

	}
	public System.IAsyncResult Begindelete_all_non_active_policies(string [] webapp_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_non_active_policies", new object[] {
			webapp_names}, callback, asyncState);
	}
	public void Enddelete_all_non_active_policies(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_webapp
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/WebApplication", 
		RequestNamespace="urn:iControl:ASM/WebApplication", ResponseNamespace="urn:iControl:ASM/WebApplication")]
	public void delete_webapp(
		string [] webapp_names
	) {
		this.Invoke("delete_webapp", new object [] {
				webapp_names});

	}
	public System.IAsyncResult Begindelete_webapp(string [] webapp_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_webapp", new object[] {
			webapp_names}, callback, asyncState);
	}
	public void Enddelete_webapp(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_active_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/WebApplication", 
		RequestNamespace="urn:iControl:ASM/WebApplication", ResponseNamespace="urn:iControl:ASM/WebApplication")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_active_policy(
		string [] webapp_names
	) {
		object [] results = this.Invoke("get_active_policy", new object [] {
				webapp_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_active_policy(string [] webapp_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_active_policy", new object[] {
			webapp_names}, callback, asyncState);
	}
	public string [] Endget_active_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_apply_learning
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/WebApplication", 
		RequestNamespace="urn:iControl:ASM/WebApplication", ResponseNamespace="urn:iControl:ASM/WebApplication")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ASMApplyLearning [] get_apply_learning(
		string [] webapp_names
	) {
		object [] results = this.Invoke("get_apply_learning", new object [] {
				webapp_names});
		return ((ASMApplyLearning [])(results[0]));
	}
	public System.IAsyncResult Beginget_apply_learning(string [] webapp_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_apply_learning", new object[] {
			webapp_names}, callback, asyncState);
	}
	public ASMApplyLearning [] Endget_apply_learning(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ASMApplyLearning [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/WebApplication", 
		RequestNamespace="urn:iControl:ASM/WebApplication", ResponseNamespace="urn:iControl:ASM/WebApplication")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] get_enabled_state(
		string [] webapp_names
	) {
		object [] results = this.Invoke("get_enabled_state", new object [] {
				webapp_names});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginget_enabled_state(string [] webapp_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_enabled_state", new object[] {
			webapp_names}, callback, asyncState);
	}
	public bool [] Endget_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_language
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/WebApplication", 
		RequestNamespace="urn:iControl:ASM/WebApplication", ResponseNamespace="urn:iControl:ASM/WebApplication")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ASMWebApplicationLanguage [] get_language(
		string [] webapp_names
	) {
		object [] results = this.Invoke("get_language", new object [] {
				webapp_names});
		return ((ASMWebApplicationLanguage [])(results[0]));
	}
	public System.IAsyncResult Beginget_language(string [] webapp_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_language", new object[] {
			webapp_names}, callback, asyncState);
	}
	public ASMWebApplicationLanguage [] Endget_language(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ASMWebApplicationLanguage [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/WebApplication", 
		RequestNamespace="urn:iControl:ASM/WebApplication", ResponseNamespace="urn:iControl:ASM/WebApplication")]
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
	// get_logging_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/WebApplication", 
		RequestNamespace="urn:iControl:ASM/WebApplication", ResponseNamespace="urn:iControl:ASM/WebApplication")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_logging_profile(
		string [] webapp_names
	) {
		object [] results = this.Invoke("get_logging_profile", new object [] {
				webapp_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_logging_profile(string [] webapp_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_logging_profile", new object[] {
			webapp_names}, callback, asyncState);
	}
	public string [] Endget_logging_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_policy_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/WebApplication", 
		RequestNamespace="urn:iControl:ASM/WebApplication", ResponseNamespace="urn:iControl:ASM/WebApplication")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_policy_list(
		string [] webapp_names
	) {
		object [] results = this.Invoke("get_policy_list", new object [] {
				webapp_names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_policy_list(string [] webapp_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_policy_list", new object[] {
			webapp_names}, callback, asyncState);
	}
	public string [] [] Endget_policy_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/WebApplication", 
		RequestNamespace="urn:iControl:ASM/WebApplication", ResponseNamespace="urn:iControl:ASM/WebApplication")]
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
	// reconfigure
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/WebApplication", 
		RequestNamespace="urn:iControl:ASM/WebApplication", ResponseNamespace="urn:iControl:ASM/WebApplication")]
	public void reconfigure(
		string [] webapp_names
	) {
		this.Invoke("reconfigure", new object [] {
				webapp_names});

	}
	public System.IAsyncResult Beginreconfigure(string [] webapp_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reconfigure", new object[] {
			webapp_names}, callback, asyncState);
	}
	public void Endreconfigure(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_active_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/WebApplication", 
		RequestNamespace="urn:iControl:ASM/WebApplication", ResponseNamespace="urn:iControl:ASM/WebApplication")]
	public void set_active_policy(
		string [] webapp_names,
		string [] policy_names
	) {
		this.Invoke("set_active_policy", new object [] {
				webapp_names,
				policy_names});

	}
	public System.IAsyncResult Beginset_active_policy(string [] webapp_names,string [] policy_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_active_policy", new object[] {
			webapp_names,
			policy_names}, callback, asyncState);
	}
	public void Endset_active_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_apply_learning
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/WebApplication", 
		RequestNamespace="urn:iControl:ASM/WebApplication", ResponseNamespace="urn:iControl:ASM/WebApplication")]
	public void set_apply_learning(
		string [] webapp_names,
		ASMApplyLearning [] settings
	) {
		this.Invoke("set_apply_learning", new object [] {
				webapp_names,
				settings});

	}
	public System.IAsyncResult Beginset_apply_learning(string [] webapp_names,ASMApplyLearning [] settings, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_apply_learning", new object[] {
			webapp_names,
			settings}, callback, asyncState);
	}
	public void Endset_apply_learning(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_language
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/WebApplication", 
		RequestNamespace="urn:iControl:ASM/WebApplication", ResponseNamespace="urn:iControl:ASM/WebApplication")]
	public void set_language(
		string [] webapp_names,
		ASMWebApplicationLanguage [] languages
	) {
		this.Invoke("set_language", new object [] {
				webapp_names,
				languages});

	}
	public System.IAsyncResult Beginset_language(string [] webapp_names,ASMWebApplicationLanguage [] languages, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_language", new object[] {
			webapp_names,
			languages}, callback, asyncState);
	}
	public void Endset_language(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_language_extended
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/WebApplication", 
		RequestNamespace="urn:iControl:ASM/WebApplication", ResponseNamespace="urn:iControl:ASM/WebApplication")]
	public void set_language_extended(
		string [] webapp_names,
		ASMWebApplicationLanguage [] languages,
		string [] policy_names,
		ASMPolicyTemplate [] policy_template_names,
		long timeout
	) {
		this.Invoke("set_language_extended", new object [] {
				webapp_names,
				languages,
				policy_names,
				policy_template_names,
				timeout});

	}
	public System.IAsyncResult Beginset_language_extended(string [] webapp_names,ASMWebApplicationLanguage [] languages,string [] policy_names,ASMPolicyTemplate [] policy_template_names,long timeout, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_language_extended", new object[] {
			webapp_names,
			languages,
			policy_names,
			policy_template_names,
			timeout}, callback, asyncState);
	}
	public void Endset_language_extended(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_language_extended_template_names
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/WebApplication", 
		RequestNamespace="urn:iControl:ASM/WebApplication", ResponseNamespace="urn:iControl:ASM/WebApplication")]
	public void set_language_extended_template_names(
		string [] webapp_names,
		ASMWebApplicationLanguage [] languages,
		string [] policy_names,
		string [] policy_template_names,
		long timeout
	) {
		this.Invoke("set_language_extended_template_names", new object [] {
				webapp_names,
				languages,
				policy_names,
				policy_template_names,
				timeout});

	}
	public System.IAsyncResult Beginset_language_extended_template_names(string [] webapp_names,ASMWebApplicationLanguage [] languages,string [] policy_names,string [] policy_template_names,long timeout, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_language_extended_template_names", new object[] {
			webapp_names,
			languages,
			policy_names,
			policy_template_names,
			timeout}, callback, asyncState);
	}
	public void Endset_language_extended_template_names(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_logging_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:ASM/WebApplication", 
		RequestNamespace="urn:iControl:ASM/WebApplication", ResponseNamespace="urn:iControl:ASM/WebApplication")]
	public void set_logging_profile(
		string [] webapp_names,
		string [] logprof_names
	) {
		this.Invoke("set_logging_profile", new object [] {
				webapp_names,
				logprof_names});

	}
	public System.IAsyncResult Beginset_logging_profile(string [] webapp_names,string [] logprof_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_logging_profile", new object[] {
			webapp_names,
			logprof_names}, callback, asyncState);
	}
	public void Endset_logging_profile(System.IAsyncResult asyncResult) {
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
