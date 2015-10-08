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
	[System.Web.Services.WebServiceBindingAttribute(Name="iCall.ScriptBinding", Namespace="urn:iControl")]
	public partial class iCallScript : iControlInterface {
		public iCallScript() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/Script", 
		RequestNamespace="urn:iControl:iCall/Script", ResponseNamespace="urn:iControl:iCall/Script")]
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
	// delete_all_scripts
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/Script", 
		RequestNamespace="urn:iControl:iCall/Script", ResponseNamespace="urn:iControl:iCall/Script")]
	public void delete_all_scripts(

	) {
		this.Invoke("delete_all_scripts", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_scripts(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_scripts", new object[0], callback, asyncState);
	}
	public void Enddelete_all_scripts(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_script
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/Script", 
		RequestNamespace="urn:iControl:iCall/Script", ResponseNamespace="urn:iControl:iCall/Script")]
	public void delete_script(
		string [] scripts
	) {
		this.Invoke("delete_script", new object [] {
				scripts});

	}
	public System.IAsyncResult Begindelete_script(string [] scripts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_script", new object[] {
			scripts}, callback, asyncState);
	}
	public void Enddelete_script(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_definition
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/Script", 
		RequestNamespace="urn:iControl:iCall/Script", ResponseNamespace="urn:iControl:iCall/Script")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_definition(
		string [] scripts
	) {
		object [] results = this.Invoke("get_definition", new object [] {
				scripts});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_definition(string [] scripts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_definition", new object[] {
			scripts}, callback, asyncState);
	}
	public string [] Endget_definition(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/Script", 
		RequestNamespace="urn:iControl:iCall/Script", ResponseNamespace="urn:iControl:iCall/Script")]
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
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/Script", 
		RequestNamespace="urn:iControl:iCall/Script", ResponseNamespace="urn:iControl:iCall/Script")]
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
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/Script", 
		RequestNamespace="urn:iControl:iCall/Script", ResponseNamespace="urn:iControl:iCall/Script")]
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
	// set_definition
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/Script", 
		RequestNamespace="urn:iControl:iCall/Script", ResponseNamespace="urn:iControl:iCall/Script")]
	public void set_definition(
		string [] scripts,
		string [] definitions
	) {
		this.Invoke("set_definition", new object [] {
				scripts,
				definitions});

	}
	public System.IAsyncResult Beginset_definition(string [] scripts,string [] definitions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_definition", new object[] {
			scripts,
			definitions}, callback, asyncState);
	}
	public void Endset_definition(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/Script", 
		RequestNamespace="urn:iControl:iCall/Script", ResponseNamespace="urn:iControl:iCall/Script")]
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

	}
	//=======================================================================
	// Enums
	//=======================================================================

	//=======================================================================
	// Structs
	//=======================================================================

}
