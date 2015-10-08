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
	[System.Web.Services.WebServiceBindingAttribute(Name="Management.GlobalsBinding", Namespace="urn:iControl")]
	public partial class ManagementGlobals : iControlInterface {
		public ManagementGlobals() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// get_local_file_path_prefixes
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Globals", 
		RequestNamespace="urn:iControl:Management/Globals", ResponseNamespace="urn:iControl:Management/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_local_file_path_prefixes(

	) {
		object [] results = this.Invoke("get_local_file_path_prefixes", new object [0]);
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_local_file_path_prefixes(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_local_file_path_prefixes", new object[0], callback, asyncState);
	}
	public string [] Endget_local_file_path_prefixes(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Globals", 
		RequestNamespace="urn:iControl:Management/Globals", ResponseNamespace="urn:iControl:Management/Globals")]
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
	// set_local_file_path_prefixes
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Globals", 
		RequestNamespace="urn:iControl:Management/Globals", ResponseNamespace="urn:iControl:Management/Globals")]
	public void set_local_file_path_prefixes(
		string [] prefixes
	) {
		this.Invoke("set_local_file_path_prefixes", new object [] {
				prefixes});

	}
	public System.IAsyncResult Beginset_local_file_path_prefixes(string [] prefixes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_local_file_path_prefixes", new object[] {
			prefixes}, callback, asyncState);
	}
	public void Endset_local_file_path_prefixes(System.IAsyncResult asyncResult) {
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
