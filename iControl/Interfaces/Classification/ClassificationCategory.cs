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
	[System.Web.Services.WebServiceBindingAttribute(Name="Classification.CategoryBinding", Namespace="urn:iControl")]
	public partial class ClassificationCategory : iControlInterface {
		public ClassificationCategory() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Classification/Category", 
		RequestNamespace="urn:iControl:Classification/Category", ResponseNamespace="urn:iControl:Classification/Category")]
	public void create(
		string [] categories,
		long [] ids
	) {
		this.Invoke("create", new object [] {
				categories,
				ids});

	}
	public System.IAsyncResult Begincreate(string [] categories,long [] ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			categories,
			ids}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_categories
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Classification/Category", 
		RequestNamespace="urn:iControl:Classification/Category", ResponseNamespace="urn:iControl:Classification/Category")]
	public void delete_all_categories(

	) {
		this.Invoke("delete_all_categories", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_categories(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_categories", new object[0], callback, asyncState);
	}
	public void Enddelete_all_categories(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_category
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Classification/Category", 
		RequestNamespace="urn:iControl:Classification/Category", ResponseNamespace="urn:iControl:Classification/Category")]
	public void delete_category(
		string [] categories
	) {
		this.Invoke("delete_category", new object [] {
				categories});

	}
	public System.IAsyncResult Begindelete_category(string [] categories, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_category", new object[] {
			categories}, callback, asyncState);
	}
	public void Enddelete_category(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Classification/Category", 
		RequestNamespace="urn:iControl:Classification/Category", ResponseNamespace="urn:iControl:Classification/Category")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] categories
	) {
		object [] results = this.Invoke("get_description", new object [] {
				categories});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] categories, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			categories}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Classification/Category", 
		RequestNamespace="urn:iControl:Classification/Category", ResponseNamespace="urn:iControl:Classification/Category")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_enabled_state(
		string [] categories
	) {
		object [] results = this.Invoke("get_enabled_state", new object [] {
				categories});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_enabled_state(string [] categories, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_enabled_state", new object[] {
			categories}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Classification/Category", 
		RequestNamespace="urn:iControl:Classification/Category", ResponseNamespace="urn:iControl:Classification/Category")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_id(
		string [] categories
	) {
		object [] results = this.Invoke("get_id", new object [] {
				categories});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_id(string [] categories, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_id", new object[] {
			categories}, callback, asyncState);
	}
	public long [] Endget_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_irule_event_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Classification/Category", 
		RequestNamespace="urn:iControl:Classification/Category", ResponseNamespace="urn:iControl:Classification/Category")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_irule_event_state(
		string [] categories
	) {
		object [] results = this.Invoke("get_irule_event_state", new object [] {
				categories});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_irule_event_state(string [] categories, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_irule_event_state", new object[] {
			categories}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_irule_event_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Classification/Category", 
		RequestNamespace="urn:iControl:Classification/Category", ResponseNamespace="urn:iControl:Classification/Category")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Classification/Category", 
		RequestNamespace="urn:iControl:Classification/Category", ResponseNamespace="urn:iControl:Classification/Category")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Classification/Category", 
		RequestNamespace="urn:iControl:Classification/Category", ResponseNamespace="urn:iControl:Classification/Category")]
	public void set_description(
		string [] categories,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				categories,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] categories,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			categories,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Classification/Category", 
		RequestNamespace="urn:iControl:Classification/Category", ResponseNamespace="urn:iControl:Classification/Category")]
	public void set_enabled_state(
		string [] categories,
		CommonEnabledState [] states
	) {
		this.Invoke("set_enabled_state", new object [] {
				categories,
				states});

	}
	public System.IAsyncResult Beginset_enabled_state(string [] categories,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_enabled_state", new object[] {
			categories,
			states}, callback, asyncState);
	}
	public void Endset_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_irule_event_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Classification/Category", 
		RequestNamespace="urn:iControl:Classification/Category", ResponseNamespace="urn:iControl:Classification/Category")]
	public void set_irule_event_state(
		string [] categories,
		CommonEnabledState [] states
	) {
		this.Invoke("set_irule_event_state", new object [] {
				categories,
				states});

	}
	public System.IAsyncResult Beginset_irule_event_state(string [] categories,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_irule_event_state", new object[] {
			categories,
			states}, callback, asyncState);
	}
	public void Endset_irule_event_state(System.IAsyncResult asyncResult) {
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
