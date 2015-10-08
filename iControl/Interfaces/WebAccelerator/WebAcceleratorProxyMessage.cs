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
	[System.Web.Services.WebServiceBindingAttribute(Name="WebAccelerator.ProxyMessageBinding", Namespace="urn:iControl")]
	public partial class WebAcceleratorProxyMessage : iControlInterface {
		public WebAcceleratorProxyMessage() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// esi_invalidate_content
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/ProxyMessage", 
		RequestNamespace="urn:iControl:WebAccelerator/ProxyMessage", ResponseNamespace="urn:iControl:WebAccelerator/ProxyMessage")]
	public void esi_invalidate_content(
		byte [] invalidation_message
	) {
		this.Invoke("esi_invalidate_content", new object [] {
				invalidation_message});

	}
	public System.IAsyncResult Beginesi_invalidate_content(byte [] invalidation_message, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("esi_invalidate_content", new object[] {
			invalidation_message}, callback, asyncState);
	}
	public void Endesi_invalidate_content(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/ProxyMessage", 
		RequestNamespace="urn:iControl:WebAccelerator/ProxyMessage", ResponseNamespace="urn:iControl:WebAccelerator/ProxyMessage")]
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
	// invalidate_content
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:WebAccelerator/ProxyMessage", 
		RequestNamespace="urn:iControl:WebAccelerator/ProxyMessage", ResponseNamespace="urn:iControl:WebAccelerator/ProxyMessage")]
	public void invalidate_content(
		byte [] invalidation_message
	) {
		this.Invoke("invalidate_content", new object [] {
				invalidation_message});

	}
	public System.IAsyncResult Begininvalidate_content(byte [] invalidation_message, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("invalidate_content", new object[] {
			invalidation_message}, callback, asyncState);
	}
	public void Endinvalidate_content(System.IAsyncResult asyncResult) {
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
