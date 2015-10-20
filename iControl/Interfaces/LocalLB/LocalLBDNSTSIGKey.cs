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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.DNSTSIGKeyBinding", Namespace="urn:iControl")]
	public partial class LocalLBDNSTSIGKey : iControlInterface {
		public LocalLBDNSTSIGKey() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSTSIGKey", 
		RequestNamespace="urn:iControl:LocalLB/DNSTSIGKey", ResponseNamespace="urn:iControl:LocalLB/DNSTSIGKey")]
	public void create(
		string [] keys,
		LocalLBDNSTSIGKeyTSIGKeyAlgorithm [] algorithms,
		string [] secrets
	) {
		this.Invoke("create", new object [] {
				keys,
				algorithms,
				secrets});

	}
	public System.IAsyncResult Begincreate(string [] keys,LocalLBDNSTSIGKeyTSIGKeyAlgorithm [] algorithms,string [] secrets, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			keys,
			algorithms,
			secrets}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_tsig_keys
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSTSIGKey", 
		RequestNamespace="urn:iControl:LocalLB/DNSTSIGKey", ResponseNamespace="urn:iControl:LocalLB/DNSTSIGKey")]
	public void delete_all_tsig_keys(

	) {
		this.Invoke("delete_all_tsig_keys", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_tsig_keys(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_tsig_keys", new object[0], callback, asyncState);
	}
	public void Enddelete_all_tsig_keys(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_tsig_key
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSTSIGKey", 
		RequestNamespace="urn:iControl:LocalLB/DNSTSIGKey", ResponseNamespace="urn:iControl:LocalLB/DNSTSIGKey")]
	public void delete_tsig_key(
		string [] keys
	) {
		this.Invoke("delete_tsig_key", new object [] {
				keys});

	}
	public System.IAsyncResult Begindelete_tsig_key(string [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_tsig_key", new object[] {
			keys}, callback, asyncState);
	}
	public void Enddelete_tsig_key(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_algorithm
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSTSIGKey", 
		RequestNamespace="urn:iControl:LocalLB/DNSTSIGKey", ResponseNamespace="urn:iControl:LocalLB/DNSTSIGKey")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBDNSTSIGKeyTSIGKeyAlgorithm [] get_algorithm(
		string [] keys
	) {
		object [] results = this.Invoke("get_algorithm", new object [] {
				keys});
		return ((LocalLBDNSTSIGKeyTSIGKeyAlgorithm [])(results[0]));
	}
	public System.IAsyncResult Beginget_algorithm(string [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_algorithm", new object[] {
			keys}, callback, asyncState);
	}
	public LocalLBDNSTSIGKeyTSIGKeyAlgorithm [] Endget_algorithm(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBDNSTSIGKeyTSIGKeyAlgorithm [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSTSIGKey", 
		RequestNamespace="urn:iControl:LocalLB/DNSTSIGKey", ResponseNamespace="urn:iControl:LocalLB/DNSTSIGKey")]
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
	// get_secret
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSTSIGKey", 
		RequestNamespace="urn:iControl:LocalLB/DNSTSIGKey", ResponseNamespace="urn:iControl:LocalLB/DNSTSIGKey")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_secret(
		string [] keys
	) {
		object [] results = this.Invoke("get_secret", new object [] {
				keys});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_secret(string [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_secret", new object[] {
			keys}, callback, asyncState);
	}
	public string [] Endget_secret(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSTSIGKey", 
		RequestNamespace="urn:iControl:LocalLB/DNSTSIGKey", ResponseNamespace="urn:iControl:LocalLB/DNSTSIGKey")]
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
	// set_algorithm
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSTSIGKey", 
		RequestNamespace="urn:iControl:LocalLB/DNSTSIGKey", ResponseNamespace="urn:iControl:LocalLB/DNSTSIGKey")]
	public void set_algorithm(
		string [] keys,
		LocalLBDNSTSIGKeyTSIGKeyAlgorithm [] algorithms
	) {
		this.Invoke("set_algorithm", new object [] {
				keys,
				algorithms});

	}
	public System.IAsyncResult Beginset_algorithm(string [] keys,LocalLBDNSTSIGKeyTSIGKeyAlgorithm [] algorithms, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_algorithm", new object[] {
			keys,
			algorithms}, callback, asyncState);
	}
	public void Endset_algorithm(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_secret
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSTSIGKey", 
		RequestNamespace="urn:iControl:LocalLB/DNSTSIGKey", ResponseNamespace="urn:iControl:LocalLB/DNSTSIGKey")]
	public void set_secret(
		string [] keys,
		string [] secrets
	) {
		this.Invoke("set_secret", new object [] {
				keys,
				secrets});

	}
	public System.IAsyncResult Beginset_secret(string [] keys,string [] secrets, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_secret", new object[] {
			keys,
			secrets}, callback, asyncState);
	}
	public void Endset_secret(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.DNSTSIGKey.TSIGKeyAlgorithm", Namespace = "urn:iControl")]
	public enum LocalLBDNSTSIGKeyTSIGKeyAlgorithm
	{
		KEY_ALGORITHM_UNKNOWN,
		KEY_ALGORITHM_HMACMD5,
		KEY_ALGORITHM_HMACSHA1,
		KEY_ALGORITHM_HMACSHA256,
	}

	//=======================================================================
	// Structs
	//=======================================================================

}
