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
	[System.Web.Services.WebServiceBindingAttribute(Name="Classification.ApplicationBinding", Namespace="urn:iControl")]
	public partial class ClassificationApplication : iControlInterface {
		public ClassificationApplication() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Classification/Application", 
		RequestNamespace="urn:iControl:Classification/Application", ResponseNamespace="urn:iControl:Classification/Application")]
	public void create(
		string [] applications,
		string [] categories,
		long [] ids
	) {
		this.Invoke("create", new object [] {
				applications,
				categories,
				ids});

	}
	public System.IAsyncResult Begincreate(string [] applications,string [] categories,long [] ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			applications,
			categories,
			ids}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_applications
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Classification/Application", 
		RequestNamespace="urn:iControl:Classification/Application", ResponseNamespace="urn:iControl:Classification/Application")]
	public void delete_all_applications(

	) {
		this.Invoke("delete_all_applications", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_applications(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_applications", new object[0], callback, asyncState);
	}
	public void Enddelete_all_applications(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_application
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Classification/Application", 
		RequestNamespace="urn:iControl:Classification/Application", ResponseNamespace="urn:iControl:Classification/Application")]
	public void delete_application(
		string [] applications
	) {
		this.Invoke("delete_application", new object [] {
				applications});

	}
	public System.IAsyncResult Begindelete_application(string [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_application", new object[] {
			applications}, callback, asyncState);
	}
	public void Enddelete_application(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_category
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Classification/Application", 
		RequestNamespace="urn:iControl:Classification/Application", ResponseNamespace="urn:iControl:Classification/Application")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_category(
		string [] applications
	) {
		object [] results = this.Invoke("get_category", new object [] {
				applications});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_category(string [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_category", new object[] {
			applications}, callback, asyncState);
	}
	public string [] Endget_category(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Classification/Application", 
		RequestNamespace="urn:iControl:Classification/Application", ResponseNamespace="urn:iControl:Classification/Application")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] applications
	) {
		object [] results = this.Invoke("get_description", new object [] {
				applications});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			applications}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Classification/Application", 
		RequestNamespace="urn:iControl:Classification/Application", ResponseNamespace="urn:iControl:Classification/Application")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_enabled_state(
		string [] applications
	) {
		object [] results = this.Invoke("get_enabled_state", new object [] {
				applications});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_enabled_state(string [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_enabled_state", new object[] {
			applications}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Classification/Application", 
		RequestNamespace="urn:iControl:Classification/Application", ResponseNamespace="urn:iControl:Classification/Application")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_id(
		string [] applications
	) {
		object [] results = this.Invoke("get_id", new object [] {
				applications});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_id(string [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_id", new object[] {
			applications}, callback, asyncState);
	}
	public long [] Endget_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Classification/Application", 
		RequestNamespace="urn:iControl:Classification/Application", ResponseNamespace="urn:iControl:Classification/Application")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Classification/Application", 
		RequestNamespace="urn:iControl:Classification/Application", ResponseNamespace="urn:iControl:Classification/Application")]
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
	// set_category
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Classification/Application", 
		RequestNamespace="urn:iControl:Classification/Application", ResponseNamespace="urn:iControl:Classification/Application")]
	public void set_category(
		string [] applications,
		string [] categories
	) {
		this.Invoke("set_category", new object [] {
				applications,
				categories});

	}
	public System.IAsyncResult Beginset_category(string [] applications,string [] categories, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_category", new object[] {
			applications,
			categories}, callback, asyncState);
	}
	public void Endset_category(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Classification/Application", 
		RequestNamespace="urn:iControl:Classification/Application", ResponseNamespace="urn:iControl:Classification/Application")]
	public void set_description(
		string [] applications,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				applications,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] applications,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			applications,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Classification/Application", 
		RequestNamespace="urn:iControl:Classification/Application", ResponseNamespace="urn:iControl:Classification/Application")]
	public void set_enabled_state(
		string [] applications,
		CommonEnabledState [] states
	) {
		this.Invoke("set_enabled_state", new object [] {
				applications,
				states});

	}
	public System.IAsyncResult Beginset_enabled_state(string [] applications,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_enabled_state", new object[] {
			applications,
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
