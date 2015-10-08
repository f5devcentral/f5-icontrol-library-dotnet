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
	[System.Web.Services.WebServiceBindingAttribute(Name="Classification.SignatureVersionBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonTimeStamp))]
	public partial class ClassificationSignatureVersion : iControlInterface {
		public ClassificationSignatureVersion() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Classification/SignatureVersion", 
		RequestNamespace="urn:iControl:Classification/SignatureVersion", ResponseNamespace="urn:iControl:Classification/SignatureVersion")]
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
	// get_update_time
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Classification/SignatureVersion", 
		RequestNamespace="urn:iControl:Classification/SignatureVersion", ResponseNamespace="urn:iControl:Classification/SignatureVersion")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonTimeStamp [] get_update_time(
		string [] versions
	) {
		object [] results = this.Invoke("get_update_time", new object [] {
				versions});
		return ((CommonTimeStamp [])(results[0]));
	}
	public System.IAsyncResult Beginget_update_time(string [] versions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_update_time", new object[] {
			versions}, callback, asyncState);
	}
	public CommonTimeStamp [] Endget_update_time(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonTimeStamp [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Classification/SignatureVersion", 
		RequestNamespace="urn:iControl:Classification/SignatureVersion", ResponseNamespace="urn:iControl:Classification/SignatureVersion")]
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
	// get_version_number
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Classification/SignatureVersion", 
		RequestNamespace="urn:iControl:Classification/SignatureVersion", ResponseNamespace="urn:iControl:Classification/SignatureVersion")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_version_number(
		string [] versions
	) {
		object [] results = this.Invoke("get_version_number", new object [] {
				versions});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_version_number(string [] versions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_version_number", new object[] {
			versions}, callback, asyncState);
	}
	public string [] Endget_version_number(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	//=======================================================================
	// Structs
	//=======================================================================

}
