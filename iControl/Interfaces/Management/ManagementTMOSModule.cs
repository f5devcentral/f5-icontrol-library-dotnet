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
	[System.Web.Services.WebServiceBindingAttribute(Name="Management.TMOSModuleBinding", Namespace="urn:iControl")]
	public partial class ManagementTMOSModule : iControlInterface {
		public ManagementTMOSModule() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// get_descriptive_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TMOSModule", 
		RequestNamespace="urn:iControl:Management/TMOSModule", ResponseNamespace="urn:iControl:Management/TMOSModule")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_descriptive_name(
		CommonTMOSModule [] modules
	) {
		object [] results = this.Invoke("get_descriptive_name", new object [] {
				modules});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_descriptive_name(CommonTMOSModule [] modules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_descriptive_name", new object[] {
			modules}, callback, asyncState);
	}
	public string [] Endget_descriptive_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_known_module_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TMOSModule", 
		RequestNamespace="urn:iControl:Management/TMOSModule", ResponseNamespace="urn:iControl:Management/TMOSModule")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonTMOSModule [] get_known_module_list(

	) {
		object [] results = this.Invoke("get_known_module_list", new object [0]);
		return ((CommonTMOSModule [])(results[0]));
	}
	public System.IAsyncResult Beginget_known_module_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_known_module_list", new object[0], callback, asyncState);
	}
	public CommonTMOSModule [] Endget_known_module_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonTMOSModule [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/TMOSModule", 
		RequestNamespace="urn:iControl:Management/TMOSModule", ResponseNamespace="urn:iControl:Management/TMOSModule")]
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
