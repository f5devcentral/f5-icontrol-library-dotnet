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
	[System.Web.Services.WebServiceBindingAttribute(Name="Management.FeatureModuleBinding", Namespace="urn:iControl")]
	public partial class ManagementFeatureModule : iControlInterface {
		public ManagementFeatureModule() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/FeatureModule", 
		RequestNamespace="urn:iControl:Management/FeatureModule", ResponseNamespace="urn:iControl:Management/FeatureModule")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		CommonTMOSModule [] modules
	) {
		object [] results = this.Invoke("get_description", new object [] {
				modules});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(CommonTMOSModule [] modules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			modules}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/FeatureModule", 
		RequestNamespace="urn:iControl:Management/FeatureModule", ResponseNamespace="urn:iControl:Management/FeatureModule")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_enabled_state(
		CommonTMOSModule [] modules
	) {
		object [] results = this.Invoke("get_enabled_state", new object [] {
				modules});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_enabled_state(CommonTMOSModule [] modules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_enabled_state", new object[] {
			modules}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/FeatureModule", 
		RequestNamespace="urn:iControl:Management/FeatureModule", ResponseNamespace="urn:iControl:Management/FeatureModule")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonTMOSModule [] get_list(

	) {
		object [] results = this.Invoke("get_list", new object [0]);
		return ((CommonTMOSModule [])(results[0]));
	}
	public System.IAsyncResult Beginget_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_list", new object[0], callback, asyncState);
	}
	public CommonTMOSModule [] Endget_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonTMOSModule [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/FeatureModule", 
		RequestNamespace="urn:iControl:Management/FeatureModule", ResponseNamespace="urn:iControl:Management/FeatureModule")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/FeatureModule", 
		RequestNamespace="urn:iControl:Management/FeatureModule", ResponseNamespace="urn:iControl:Management/FeatureModule")]
	public void set_description(
		CommonTMOSModule [] modules,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				modules,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(CommonTMOSModule [] modules,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			modules,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/FeatureModule", 
		RequestNamespace="urn:iControl:Management/FeatureModule", ResponseNamespace="urn:iControl:Management/FeatureModule")]
	public void set_enabled_state(
		CommonTMOSModule [] modules,
		CommonEnabledState [] states
	) {
		this.Invoke("set_enabled_state", new object [] {
				modules,
				states});

	}
	public System.IAsyncResult Beginset_enabled_state(CommonTMOSModule [] modules,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_enabled_state", new object[] {
			modules,
			states}, callback, asyncState);
	}
	public void Endset_enabled_state(System.IAsyncResult asyncResult) {
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
