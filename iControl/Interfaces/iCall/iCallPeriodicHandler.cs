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
	[System.Web.Services.WebServiceBindingAttribute(Name="iCall.PeriodicHandlerBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonTimeStamp))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(iCallPeriodicHandlerExpiry))]
	public partial class iCallPeriodicHandler : iControlInterface {
		public iCallPeriodicHandler() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/PeriodicHandler", 
		RequestNamespace="urn:iControl:iCall/PeriodicHandler", ResponseNamespace="urn:iControl:iCall/PeriodicHandler")]
	public void create(
		string [] handlers,
		string [] scripts,
		long [] intervals
	) {
		this.Invoke("create", new object [] {
				handlers,
				scripts,
				intervals});

	}
	public System.IAsyncResult Begincreate(string [] handlers,string [] scripts,long [] intervals, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			handlers,
			scripts,
			intervals}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_handlers
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/PeriodicHandler", 
		RequestNamespace="urn:iControl:iCall/PeriodicHandler", ResponseNamespace="urn:iControl:iCall/PeriodicHandler")]
	public void delete_all_handlers(

	) {
		this.Invoke("delete_all_handlers", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_handlers(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_handlers", new object[0], callback, asyncState);
	}
	public void Enddelete_all_handlers(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_handler
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/PeriodicHandler", 
		RequestNamespace="urn:iControl:iCall/PeriodicHandler", ResponseNamespace="urn:iControl:iCall/PeriodicHandler")]
	public void delete_handler(
		string [] handlers
	) {
		this.Invoke("delete_handler", new object [] {
				handlers});

	}
	public System.IAsyncResult Begindelete_handler(string [] handlers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_handler", new object[] {
			handlers}, callback, asyncState);
	}
	public void Enddelete_handler(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/PeriodicHandler", 
		RequestNamespace="urn:iControl:iCall/PeriodicHandler", ResponseNamespace="urn:iControl:iCall/PeriodicHandler")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] handlers
	) {
		object [] results = this.Invoke("get_description", new object [] {
				handlers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] handlers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			handlers}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_first_occurrence
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/PeriodicHandler", 
		RequestNamespace="urn:iControl:iCall/PeriodicHandler", ResponseNamespace="urn:iControl:iCall/PeriodicHandler")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonTimeStamp [] get_first_occurrence(
		string [] handlers
	) {
		object [] results = this.Invoke("get_first_occurrence", new object [] {
				handlers});
		return ((CommonTimeStamp [])(results[0]));
	}
	public System.IAsyncResult Beginget_first_occurrence(string [] handlers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_first_occurrence", new object[] {
			handlers}, callback, asyncState);
	}
	public CommonTimeStamp [] Endget_first_occurrence(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonTimeStamp [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_handler_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/PeriodicHandler", 
		RequestNamespace="urn:iControl:iCall/PeriodicHandler", ResponseNamespace="urn:iControl:iCall/PeriodicHandler")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public iCallGeneralHandlerState [] get_handler_state(
		string [] handlers
	) {
		object [] results = this.Invoke("get_handler_state", new object [] {
				handlers});
		return ((iCallGeneralHandlerState [])(results[0]));
	}
	public System.IAsyncResult Beginget_handler_state(string [] handlers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_handler_state", new object[] {
			handlers}, callback, asyncState);
	}
	public iCallGeneralHandlerState [] Endget_handler_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((iCallGeneralHandlerState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/PeriodicHandler", 
		RequestNamespace="urn:iControl:iCall/PeriodicHandler", ResponseNamespace="urn:iControl:iCall/PeriodicHandler")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_interval(
		string [] handlers
	) {
		object [] results = this.Invoke("get_interval", new object [] {
				handlers});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_interval(string [] handlers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_interval", new object[] {
			handlers}, callback, asyncState);
	}
	public long [] Endget_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_last_occurrence
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/PeriodicHandler", 
		RequestNamespace="urn:iControl:iCall/PeriodicHandler", ResponseNamespace="urn:iControl:iCall/PeriodicHandler")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public iCallPeriodicHandlerExpiry [] get_last_occurrence(
		string [] handlers
	) {
		object [] results = this.Invoke("get_last_occurrence", new object [] {
				handlers});
		return ((iCallPeriodicHandlerExpiry [])(results[0]));
	}
	public System.IAsyncResult Beginget_last_occurrence(string [] handlers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_last_occurrence", new object[] {
			handlers}, callback, asyncState);
	}
	public iCallPeriodicHandlerExpiry [] Endget_last_occurrence(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((iCallPeriodicHandlerExpiry [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/PeriodicHandler", 
		RequestNamespace="urn:iControl:iCall/PeriodicHandler", ResponseNamespace="urn:iControl:iCall/PeriodicHandler")]
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
	// get_script
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/PeriodicHandler", 
		RequestNamespace="urn:iControl:iCall/PeriodicHandler", ResponseNamespace="urn:iControl:iCall/PeriodicHandler")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_script(
		string [] handlers
	) {
		object [] results = this.Invoke("get_script", new object [] {
				handlers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_script(string [] handlers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_script", new object[] {
			handlers}, callback, asyncState);
	}
	public string [] Endget_script(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/PeriodicHandler", 
		RequestNamespace="urn:iControl:iCall/PeriodicHandler", ResponseNamespace="urn:iControl:iCall/PeriodicHandler")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/PeriodicHandler", 
		RequestNamespace="urn:iControl:iCall/PeriodicHandler", ResponseNamespace="urn:iControl:iCall/PeriodicHandler")]
	public void set_description(
		string [] handlers,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				handlers,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] handlers,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			handlers,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_first_occurrence
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/PeriodicHandler", 
		RequestNamespace="urn:iControl:iCall/PeriodicHandler", ResponseNamespace="urn:iControl:iCall/PeriodicHandler")]
	public void set_first_occurrence(
		string [] handlers,
		CommonTimeStamp [] occurrences
	) {
		this.Invoke("set_first_occurrence", new object [] {
				handlers,
				occurrences});

	}
	public System.IAsyncResult Beginset_first_occurrence(string [] handlers,CommonTimeStamp [] occurrences, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_first_occurrence", new object[] {
			handlers,
			occurrences}, callback, asyncState);
	}
	public void Endset_first_occurrence(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_handler_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/PeriodicHandler", 
		RequestNamespace="urn:iControl:iCall/PeriodicHandler", ResponseNamespace="urn:iControl:iCall/PeriodicHandler")]
	public void set_handler_state(
		string [] handlers,
		iCallGeneralHandlerState [] states
	) {
		this.Invoke("set_handler_state", new object [] {
				handlers,
				states});

	}
	public System.IAsyncResult Beginset_handler_state(string [] handlers,iCallGeneralHandlerState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_handler_state", new object[] {
			handlers,
			states}, callback, asyncState);
	}
	public void Endset_handler_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/PeriodicHandler", 
		RequestNamespace="urn:iControl:iCall/PeriodicHandler", ResponseNamespace="urn:iControl:iCall/PeriodicHandler")]
	public void set_interval(
		string [] handlers,
		long [] intervals
	) {
		this.Invoke("set_interval", new object [] {
				handlers,
				intervals});

	}
	public System.IAsyncResult Beginset_interval(string [] handlers,long [] intervals, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_interval", new object[] {
			handlers,
			intervals}, callback, asyncState);
	}
	public void Endset_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_last_occurrence
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/PeriodicHandler", 
		RequestNamespace="urn:iControl:iCall/PeriodicHandler", ResponseNamespace="urn:iControl:iCall/PeriodicHandler")]
	public void set_last_occurrence(
		string [] handlers,
		iCallPeriodicHandlerExpiry [] occurrences
	) {
		this.Invoke("set_last_occurrence", new object [] {
				handlers,
				occurrences});

	}
	public System.IAsyncResult Beginset_last_occurrence(string [] handlers,iCallPeriodicHandlerExpiry [] occurrences, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_last_occurrence", new object[] {
			handlers,
			occurrences}, callback, asyncState);
	}
	public void Endset_last_occurrence(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_script
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/PeriodicHandler", 
		RequestNamespace="urn:iControl:iCall/PeriodicHandler", ResponseNamespace="urn:iControl:iCall/PeriodicHandler")]
	public void set_script(
		string [] handlers,
		string [] scripts
	) {
		this.Invoke("set_script", new object [] {
				handlers,
				scripts});

	}
	public System.IAsyncResult Beginset_script(string [] handlers,string [] scripts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_script", new object[] {
			handlers,
			scripts}, callback, asyncState);
	}
	public void Endset_script(System.IAsyncResult asyncResult) {
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
