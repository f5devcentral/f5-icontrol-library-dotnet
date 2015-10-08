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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.iFileBinding", Namespace="urn:iControl")]
	public partial class LocalLBiFile : iControlInterface {
		public LocalLBiFile() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/iFile", 
		RequestNamespace="urn:iControl:LocalLB/iFile", ResponseNamespace="urn:iControl:LocalLB/iFile")]
	public void create(
		string [] names,
		string [] file_names
	) {
		this.Invoke("create", new object [] {
				names,
				file_names});

	}
	public System.IAsyncResult Begincreate(string [] names,string [] file_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			names,
			file_names}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_ifiles
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/iFile", 
		RequestNamespace="urn:iControl:LocalLB/iFile", ResponseNamespace="urn:iControl:LocalLB/iFile")]
	public void delete_all_ifiles(

	) {
		this.Invoke("delete_all_ifiles", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_ifiles(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_ifiles", new object[0], callback, asyncState);
	}
	public void Enddelete_all_ifiles(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_ifile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/iFile", 
		RequestNamespace="urn:iControl:LocalLB/iFile", ResponseNamespace="urn:iControl:LocalLB/iFile")]
	public void delete_ifile(
		string [] names
	) {
		this.Invoke("delete_ifile", new object [] {
				names});

	}
	public System.IAsyncResult Begindelete_ifile(string [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_ifile", new object[] {
			names}, callback, asyncState);
	}
	public void Enddelete_ifile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_file_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/iFile", 
		RequestNamespace="urn:iControl:LocalLB/iFile", ResponseNamespace="urn:iControl:LocalLB/iFile")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_file_name(
		string [] names
	) {
		object [] results = this.Invoke("get_file_name", new object [] {
				names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_file_name(string [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_file_name", new object[] {
			names}, callback, asyncState);
	}
	public string [] Endget_file_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/iFile", 
		RequestNamespace="urn:iControl:LocalLB/iFile", ResponseNamespace="urn:iControl:LocalLB/iFile")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/iFile", 
		RequestNamespace="urn:iControl:LocalLB/iFile", ResponseNamespace="urn:iControl:LocalLB/iFile")]
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
	// set_file_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/iFile", 
		RequestNamespace="urn:iControl:LocalLB/iFile", ResponseNamespace="urn:iControl:LocalLB/iFile")]
	public void set_file_name(
		string [] names,
		string [] file_names
	) {
		this.Invoke("set_file_name", new object [] {
				names,
				file_names});

	}
	public System.IAsyncResult Beginset_file_name(string [] names,string [] file_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_file_name", new object[] {
			names,
			file_names}, callback, asyncState);
	}
	public void Endset_file_name(System.IAsyncResult asyncResult) {
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
