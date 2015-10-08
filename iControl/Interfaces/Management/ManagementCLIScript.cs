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
	[System.Web.Services.WebServiceBindingAttribute(Name="Management.CLIScriptBinding", Namespace="urn:iControl")]
	public partial class ManagementCLIScript : iControlInterface {
		public ManagementCLIScript() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_checksum
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CLIScript", 
		RequestNamespace="urn:iControl:Management/CLIScript", ResponseNamespace="urn:iControl:Management/CLIScript")]
	public void add_checksum(
		string [] scripts
	) {
		this.Invoke("add_checksum", new object [] {
				scripts});

	}
	public System.IAsyncResult Beginadd_checksum(string [] scripts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_checksum", new object[] {
			scripts}, callback, asyncState);
	}
	public void Endadd_checksum(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_signature
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CLIScript", 
		RequestNamespace="urn:iControl:Management/CLIScript", ResponseNamespace="urn:iControl:Management/CLIScript")]
	public void add_signature(
		string [] scripts,
		string [] signing_keys,
		string [] public_certs
	) {
		this.Invoke("add_signature", new object [] {
				scripts,
				signing_keys,
				public_certs});

	}
	public System.IAsyncResult Beginadd_signature(string [] scripts,string [] signing_keys,string [] public_certs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_signature", new object[] {
			scripts,
			signing_keys,
			public_certs}, callback, asyncState);
	}
	public void Endadd_signature(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// clear_verification
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CLIScript", 
		RequestNamespace="urn:iControl:Management/CLIScript", ResponseNamespace="urn:iControl:Management/CLIScript")]
	public void clear_verification(
		string [] scripts
	) {
		this.Invoke("clear_verification", new object [] {
				scripts});

	}
	public System.IAsyncResult Beginclear_verification(string [] scripts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("clear_verification", new object[] {
			scripts}, callback, asyncState);
	}
	public void Endclear_verification(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CLIScript", 
		RequestNamespace="urn:iControl:Management/CLIScript", ResponseNamespace="urn:iControl:Management/CLIScript")]
	public void create(
		string [] scripts,
		string [] definitions
	) {
		this.Invoke("create", new object [] {
				scripts,
				definitions});

	}
	public System.IAsyncResult Begincreate(string [] scripts,string [] definitions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			scripts,
			definitions}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_cli_scripts
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CLIScript", 
		RequestNamespace="urn:iControl:Management/CLIScript", ResponseNamespace="urn:iControl:Management/CLIScript")]
	public void delete_all_cli_scripts(

	) {
		this.Invoke("delete_all_cli_scripts", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_cli_scripts(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_cli_scripts", new object[0], callback, asyncState);
	}
	public void Enddelete_all_cli_scripts(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_cli_script
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CLIScript", 
		RequestNamespace="urn:iControl:Management/CLIScript", ResponseNamespace="urn:iControl:Management/CLIScript")]
	public void delete_cli_script(
		string [] scripts
	) {
		this.Invoke("delete_cli_script", new object [] {
				scripts});

	}
	public System.IAsyncResult Begindelete_cli_script(string [] scripts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_cli_script", new object[] {
			scripts}, callback, asyncState);
	}
	public void Enddelete_cli_script(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CLIScript", 
		RequestNamespace="urn:iControl:Management/CLIScript", ResponseNamespace="urn:iControl:Management/CLIScript")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] scripts
	) {
		object [] results = this.Invoke("get_description", new object [] {
				scripts});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] scripts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			scripts}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ignore_verification_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CLIScript", 
		RequestNamespace="urn:iControl:Management/CLIScript", ResponseNamespace="urn:iControl:Management/CLIScript")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_ignore_verification_state(
		string [] scripts
	) {
		object [] results = this.Invoke("get_ignore_verification_state", new object [] {
				scripts});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_ignore_verification_state(string [] scripts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ignore_verification_state", new object[] {
			scripts}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_ignore_verification_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CLIScript", 
		RequestNamespace="urn:iControl:Management/CLIScript", ResponseNamespace="urn:iControl:Management/CLIScript")]
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
	// get_script
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CLIScript", 
		RequestNamespace="urn:iControl:Management/CLIScript", ResponseNamespace="urn:iControl:Management/CLIScript")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_script(
		string [] scripts
	) {
		object [] results = this.Invoke("get_script", new object [] {
				scripts});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_script(string [] scripts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_script", new object[] {
			scripts}, callback, asyncState);
	}
	public string [] Endget_script(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_verification_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CLIScript", 
		RequestNamespace="urn:iControl:Management/CLIScript", ResponseNamespace="urn:iControl:Management/CLIScript")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonVerificationStatus [] get_verification_status(
		string [] scripts
	) {
		object [] results = this.Invoke("get_verification_status", new object [] {
				scripts});
		return ((CommonVerificationStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_verification_status(string [] scripts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_verification_status", new object[] {
			scripts}, callback, asyncState);
	}
	public CommonVerificationStatus [] Endget_verification_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonVerificationStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CLIScript", 
		RequestNamespace="urn:iControl:Management/CLIScript", ResponseNamespace="urn:iControl:Management/CLIScript")]
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
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CLIScript", 
		RequestNamespace="urn:iControl:Management/CLIScript", ResponseNamespace="urn:iControl:Management/CLIScript")]
	public void set_description(
		string [] scripts,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				scripts,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] scripts,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			scripts,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ignore_verification_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CLIScript", 
		RequestNamespace="urn:iControl:Management/CLIScript", ResponseNamespace="urn:iControl:Management/CLIScript")]
	public void set_ignore_verification_state(
		string [] scripts,
		CommonEnabledState [] states
	) {
		this.Invoke("set_ignore_verification_state", new object [] {
				scripts,
				states});

	}
	public System.IAsyncResult Beginset_ignore_verification_state(string [] scripts,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ignore_verification_state", new object[] {
			scripts,
			states}, callback, asyncState);
	}
	public void Endset_ignore_verification_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_script
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/CLIScript", 
		RequestNamespace="urn:iControl:Management/CLIScript", ResponseNamespace="urn:iControl:Management/CLIScript")]
	public void set_script(
		string [] scripts,
		string [] definitions
	) {
		this.Invoke("set_script", new object [] {
				scripts,
				definitions});

	}
	public System.IAsyncResult Beginset_script(string [] scripts,string [] definitions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_script", new object[] {
			scripts,
			definitions}, callback, asyncState);
	}
	public void Endset_script(System.IAsyncResult asyncResult) {
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
