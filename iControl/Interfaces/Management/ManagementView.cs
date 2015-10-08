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
	[System.Web.Services.WebServiceBindingAttribute(Name="Management.ViewBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementViewInfo))]
	public partial class ManagementView : iControlInterface {
		public ManagementView() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_view
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/View", 
		RequestNamespace="urn:iControl:Management/View", ResponseNamespace="urn:iControl:Management/View")]
	public void add_view(
		ManagementViewInfo [] views
	) {
		this.Invoke("add_view", new object [] {
				views});

	}
	public System.IAsyncResult Beginadd_view(ManagementViewInfo [] views, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_view", new object[] {
			views}, callback, asyncState);
	}
	public void Endadd_view(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_view_option
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/View", 
		RequestNamespace="urn:iControl:Management/View", ResponseNamespace="urn:iControl:Management/View")]
	public void add_view_option(
		ManagementViewInfo [] view_infos
	) {
		this.Invoke("add_view_option", new object [] {
				view_infos});

	}
	public System.IAsyncResult Beginadd_view_option(ManagementViewInfo [] view_infos, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_view_option", new object[] {
			view_infos}, callback, asyncState);
	}
	public void Endadd_view_option(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_view
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/View", 
		RequestNamespace="urn:iControl:Management/View", ResponseNamespace="urn:iControl:Management/View")]
	public void delete_view(
		ManagementViewInfo [] views
	) {
		this.Invoke("delete_view", new object [] {
				views});

	}
	public System.IAsyncResult Begindelete_view(ManagementViewInfo [] views, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_view", new object[] {
			views}, callback, asyncState);
	}
	public void Enddelete_view(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_view_option
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/View", 
		RequestNamespace="urn:iControl:Management/View", ResponseNamespace="urn:iControl:Management/View")]
	public void delete_view_option(
		ManagementViewInfo [] view_infos
	) {
		this.Invoke("delete_view_option", new object [] {
				view_infos});

	}
	public System.IAsyncResult Begindelete_view_option(ManagementViewInfo [] view_infos, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_view_option", new object[] {
			view_infos}, callback, asyncState);
	}
	public void Enddelete_view_option(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/View", 
		RequestNamespace="urn:iControl:Management/View", ResponseNamespace="urn:iControl:Management/View")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementViewInfo [] get_list(

	) {
		object [] results = this.Invoke("get_list", new object [0]);
		return ((ManagementViewInfo [])(results[0]));
	}
	public System.IAsyncResult Beginget_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_list", new object[0], callback, asyncState);
	}
	public ManagementViewInfo [] Endget_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementViewInfo [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/View", 
		RequestNamespace="urn:iControl:Management/View", ResponseNamespace="urn:iControl:Management/View")]
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
	// get_view
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/View", 
		RequestNamespace="urn:iControl:Management/View", ResponseNamespace="urn:iControl:Management/View")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementViewInfo [] get_view(
		string [] view_names
	) {
		object [] results = this.Invoke("get_view", new object [] {
				view_names});
		return ((ManagementViewInfo [])(results[0]));
	}
	public System.IAsyncResult Beginget_view(string [] view_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_view", new object[] {
			view_names}, callback, asyncState);
	}
	public ManagementViewInfo [] Endget_view(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementViewInfo [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// move_view
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/View", 
		RequestNamespace="urn:iControl:Management/View", ResponseNamespace="urn:iControl:Management/View")]
	public void move_view(
		ManagementViewInfo [] views
	) {
		this.Invoke("move_view", new object [] {
				views});

	}
	public System.IAsyncResult Beginmove_view(ManagementViewInfo [] views, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("move_view", new object[] {
			views}, callback, asyncState);
	}
	public void Endmove_view(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_view_option
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/View", 
		RequestNamespace="urn:iControl:Management/View", ResponseNamespace="urn:iControl:Management/View")]
	public void set_view_option(
		ManagementViewInfo [] view_infos
	) {
		this.Invoke("set_view_option", new object [] {
				view_infos});

	}
	public System.IAsyncResult Beginset_view_option(ManagementViewInfo [] view_infos, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_view_option", new object[] {
			view_infos}, callback, asyncState);
	}
	public void Endset_view_option(System.IAsyncResult asyncResult) {
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
