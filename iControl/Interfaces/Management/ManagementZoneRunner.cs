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
	[System.Web.Services.WebServiceBindingAttribute(Name="Management.ZoneRunnerBinding", Namespace="urn:iControl")]
	public partial class ManagementZoneRunner : iControlInterface {
		public ManagementZoneRunner() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ZoneRunner", 
		RequestNamespace="urn:iControl:Management/ZoneRunner", ResponseNamespace="urn:iControl:Management/ZoneRunner")]
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
	// init
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ZoneRunner", 
		RequestNamespace="urn:iControl:Management/ZoneRunner", ResponseNamespace="urn:iControl:Management/ZoneRunner")]
	public void init(

	) {
		this.Invoke("init", new object [0]);

	}
	public System.IAsyncResult Begininit(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("init", new object[0], callback, asyncState);
	}
	public void Endinit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_loglevel
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/ZoneRunner", 
		RequestNamespace="urn:iControl:Management/ZoneRunner", ResponseNamespace="urn:iControl:Management/ZoneRunner")]
	public void set_loglevel(
		ManagementDebugLevel level
	) {
		this.Invoke("set_loglevel", new object [] {
				level});

	}
	public System.IAsyncResult Beginset_loglevel(ManagementDebugLevel level, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_loglevel", new object[] {
			level}, callback, asyncState);
	}
	public void Endset_loglevel(System.IAsyncResult asyncResult) {
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
