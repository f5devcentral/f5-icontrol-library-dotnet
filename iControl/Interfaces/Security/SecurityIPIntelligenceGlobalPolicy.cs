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
	[System.Web.Services.WebServiceBindingAttribute(Name="Security.IPIntelligenceGlobalPolicyBinding", Namespace="urn:iControl")]
	public partial class SecurityIPIntelligenceGlobalPolicy : iControlInterface {
		public SecurityIPIntelligenceGlobalPolicy() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligenceGlobalPolicy", 
		RequestNamespace="urn:iControl:Security/IPIntelligenceGlobalPolicy", ResponseNamespace="urn:iControl:Security/IPIntelligenceGlobalPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] global_policies
	) {
		object [] results = this.Invoke("get_description", new object [] {
				global_policies});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] global_policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			global_policies}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligenceGlobalPolicy", 
		RequestNamespace="urn:iControl:Security/IPIntelligenceGlobalPolicy", ResponseNamespace="urn:iControl:Security/IPIntelligenceGlobalPolicy")]
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
	// get_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligenceGlobalPolicy", 
		RequestNamespace="urn:iControl:Security/IPIntelligenceGlobalPolicy", ResponseNamespace="urn:iControl:Security/IPIntelligenceGlobalPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_policy(
		string [] global_policies
	) {
		object [] results = this.Invoke("get_policy", new object [] {
				global_policies});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_policy(string [] global_policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_policy", new object[] {
			global_policies}, callback, asyncState);
	}
	public string [] Endget_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligenceGlobalPolicy", 
		RequestNamespace="urn:iControl:Security/IPIntelligenceGlobalPolicy", ResponseNamespace="urn:iControl:Security/IPIntelligenceGlobalPolicy")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligenceGlobalPolicy", 
		RequestNamespace="urn:iControl:Security/IPIntelligenceGlobalPolicy", ResponseNamespace="urn:iControl:Security/IPIntelligenceGlobalPolicy")]
	public void set_description(
		string [] global_policies,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				global_policies,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] global_policies,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			global_policies,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligenceGlobalPolicy", 
		RequestNamespace="urn:iControl:Security/IPIntelligenceGlobalPolicy", ResponseNamespace="urn:iControl:Security/IPIntelligenceGlobalPolicy")]
	public void set_policy(
		string [] global_policies,
		string [] policies
	) {
		this.Invoke("set_policy", new object [] {
				global_policies,
				policies});

	}
	public System.IAsyncResult Beginset_policy(string [] global_policies,string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_policy", new object[] {
			global_policies,
			policies}, callback, asyncState);
	}
	public void Endset_policy(System.IAsyncResult asyncResult) {
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
