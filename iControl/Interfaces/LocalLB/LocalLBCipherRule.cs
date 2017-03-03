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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.CipherRuleBinding", Namespace="urn:iControl")]
	public partial class LocalLBCipherRule : iControlInterface {
		public LocalLBCipherRule() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/CipherRule", 
		RequestNamespace="urn:iControl:LocalLB/CipherRule", ResponseNamespace="urn:iControl:LocalLB/CipherRule")]
	public void create(
		string [] rules,
		string [] ciphers
	) {
		this.Invoke("create", new object [] {
				rules,
				ciphers});

	}
	public System.IAsyncResult Begincreate(string [] rules,string [] ciphers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			rules,
			ciphers}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_cipher_rules
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/CipherRule", 
		RequestNamespace="urn:iControl:LocalLB/CipherRule", ResponseNamespace="urn:iControl:LocalLB/CipherRule")]
	public void delete_all_cipher_rules(

	) {
		this.Invoke("delete_all_cipher_rules", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_cipher_rules(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_cipher_rules", new object[0], callback, asyncState);
	}
	public void Enddelete_all_cipher_rules(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_cipher_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/CipherRule", 
		RequestNamespace="urn:iControl:LocalLB/CipherRule", ResponseNamespace="urn:iControl:LocalLB/CipherRule")]
	public void delete_cipher_rule(
		string [] rules
	) {
		this.Invoke("delete_cipher_rule", new object [] {
				rules});

	}
	public System.IAsyncResult Begindelete_cipher_rule(string [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_cipher_rule", new object[] {
			rules}, callback, asyncState);
	}
	public void Enddelete_cipher_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_cipher
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/CipherRule", 
		RequestNamespace="urn:iControl:LocalLB/CipherRule", ResponseNamespace="urn:iControl:LocalLB/CipherRule")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_cipher(
		string [] rules
	) {
		object [] results = this.Invoke("get_cipher", new object [] {
				rules});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_cipher(string [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cipher", new object[] {
			rules}, callback, asyncState);
	}
	public string [] Endget_cipher(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/CipherRule", 
		RequestNamespace="urn:iControl:LocalLB/CipherRule", ResponseNamespace="urn:iControl:LocalLB/CipherRule")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] rules
	) {
		object [] results = this.Invoke("get_description", new object [] {
				rules});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			rules}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/CipherRule", 
		RequestNamespace="urn:iControl:LocalLB/CipherRule", ResponseNamespace="urn:iControl:LocalLB/CipherRule")]
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
	// get_result_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/CipherRule", 
		RequestNamespace="urn:iControl:LocalLB/CipherRule", ResponseNamespace="urn:iControl:LocalLB/CipherRule")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_result_list(
		string [] rules
	) {
		object [] results = this.Invoke("get_result_list", new object [] {
				rules});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_result_list(string [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_result_list", new object[] {
			rules}, callback, asyncState);
	}
	public string [] Endget_result_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/CipherRule", 
		RequestNamespace="urn:iControl:LocalLB/CipherRule", ResponseNamespace="urn:iControl:LocalLB/CipherRule")]
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
	// set_cipher
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/CipherRule", 
		RequestNamespace="urn:iControl:LocalLB/CipherRule", ResponseNamespace="urn:iControl:LocalLB/CipherRule")]
	public void set_cipher(
		string [] rules,
		string [] ciphers
	) {
		this.Invoke("set_cipher", new object [] {
				rules,
				ciphers});

	}
	public System.IAsyncResult Beginset_cipher(string [] rules,string [] ciphers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cipher", new object[] {
			rules,
			ciphers}, callback, asyncState);
	}
	public void Endset_cipher(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/CipherRule", 
		RequestNamespace="urn:iControl:LocalLB/CipherRule", ResponseNamespace="urn:iControl:LocalLB/CipherRule")]
	public void set_description(
		string [] rules,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				rules,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] rules,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			rules,
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
