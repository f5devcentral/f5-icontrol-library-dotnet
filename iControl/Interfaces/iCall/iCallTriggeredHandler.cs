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
	[System.Web.Services.WebServiceBindingAttribute(Name="iCall.TriggeredHandlerBinding", Namespace="urn:iControl")]
	public partial class iCallTriggeredHandler : iControlInterface {
		public iCallTriggeredHandler() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_filter
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/TriggeredHandler", 
		RequestNamespace="urn:iControl:iCall/TriggeredHandler", ResponseNamespace="urn:iControl:iCall/TriggeredHandler")]
	public void add_filter(
		string [] handlers,
		string [] [] subscriptions,
		string [] [] [] filters,
		string [] [] [] values
	) {
		this.Invoke("add_filter", new object [] {
				handlers,
				subscriptions,
				filters,
				values});

	}
	public System.IAsyncResult Beginadd_filter(string [] handlers,string [] [] subscriptions,string [] [] [] filters,string [] [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_filter", new object[] {
			handlers,
			subscriptions,
			filters,
			values}, callback, asyncState);
	}
	public void Endadd_filter(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_subscription
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/TriggeredHandler", 
		RequestNamespace="urn:iControl:iCall/TriggeredHandler", ResponseNamespace="urn:iControl:iCall/TriggeredHandler")]
	public void add_subscription(
		string [] handlers,
		string [] [] subscriptions,
		string [] [] events
	) {
		this.Invoke("add_subscription", new object [] {
				handlers,
				subscriptions,
				events});

	}
	public System.IAsyncResult Beginadd_subscription(string [] handlers,string [] [] subscriptions,string [] [] events, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_subscription", new object[] {
			handlers,
			subscriptions,
			events}, callback, asyncState);
	}
	public void Endadd_subscription(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/TriggeredHandler", 
		RequestNamespace="urn:iControl:iCall/TriggeredHandler", ResponseNamespace="urn:iControl:iCall/TriggeredHandler")]
	public void create(
		string [] handlers,
		string [] scripts
	) {
		this.Invoke("create", new object [] {
				handlers,
				scripts});

	}
	public System.IAsyncResult Begincreate(string [] handlers,string [] scripts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			handlers,
			scripts}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_handlers
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/TriggeredHandler", 
		RequestNamespace="urn:iControl:iCall/TriggeredHandler", ResponseNamespace="urn:iControl:iCall/TriggeredHandler")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/TriggeredHandler", 
		RequestNamespace="urn:iControl:iCall/TriggeredHandler", ResponseNamespace="urn:iControl:iCall/TriggeredHandler")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/TriggeredHandler", 
		RequestNamespace="urn:iControl:iCall/TriggeredHandler", ResponseNamespace="urn:iControl:iCall/TriggeredHandler")]
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
	// get_filter
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/TriggeredHandler", 
		RequestNamespace="urn:iControl:iCall/TriggeredHandler", ResponseNamespace="urn:iControl:iCall/TriggeredHandler")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_filter(
		string [] handlers,
		string [] [] subscriptions
	) {
		object [] results = this.Invoke("get_filter", new object [] {
				handlers,
				subscriptions});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_filter(string [] handlers,string [] [] subscriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_filter", new object[] {
			handlers,
			subscriptions}, callback, asyncState);
	}
	public string [] [] [] Endget_filter(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_filter_match_algorithm
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/TriggeredHandler", 
		RequestNamespace="urn:iControl:iCall/TriggeredHandler", ResponseNamespace="urn:iControl:iCall/TriggeredHandler")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public iCallMatchAlgorithm [] [] [] get_filter_match_algorithm(
		string [] handlers,
		string [] [] subscriptions,
		string [] [] [] filters
	) {
		object [] results = this.Invoke("get_filter_match_algorithm", new object [] {
				handlers,
				subscriptions,
				filters});
		return ((iCallMatchAlgorithm [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_filter_match_algorithm(string [] handlers,string [] [] subscriptions,string [] [] [] filters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_filter_match_algorithm", new object[] {
			handlers,
			subscriptions,
			filters}, callback, asyncState);
	}
	public iCallMatchAlgorithm [] [] [] Endget_filter_match_algorithm(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((iCallMatchAlgorithm [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_filter_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/TriggeredHandler", 
		RequestNamespace="urn:iControl:iCall/TriggeredHandler", ResponseNamespace="urn:iControl:iCall/TriggeredHandler")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_filter_value(
		string [] handlers,
		string [] [] subscriptions,
		string [] [] [] filters
	) {
		object [] results = this.Invoke("get_filter_value", new object [] {
				handlers,
				subscriptions,
				filters});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_filter_value(string [] handlers,string [] [] subscriptions,string [] [] [] filters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_filter_value", new object[] {
			handlers,
			subscriptions,
			filters}, callback, asyncState);
	}
	public string [] [] [] Endget_filter_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_handler_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/TriggeredHandler", 
		RequestNamespace="urn:iControl:iCall/TriggeredHandler", ResponseNamespace="urn:iControl:iCall/TriggeredHandler")]
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
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/TriggeredHandler", 
		RequestNamespace="urn:iControl:iCall/TriggeredHandler", ResponseNamespace="urn:iControl:iCall/TriggeredHandler")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/TriggeredHandler", 
		RequestNamespace="urn:iControl:iCall/TriggeredHandler", ResponseNamespace="urn:iControl:iCall/TriggeredHandler")]
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
	// get_subscription
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/TriggeredHandler", 
		RequestNamespace="urn:iControl:iCall/TriggeredHandler", ResponseNamespace="urn:iControl:iCall/TriggeredHandler")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_subscription(
		string [] handlers
	) {
		object [] results = this.Invoke("get_subscription", new object [] {
				handlers});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_subscription(string [] handlers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_subscription", new object[] {
			handlers}, callback, asyncState);
	}
	public string [] [] Endget_subscription(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_subscription_event
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/TriggeredHandler", 
		RequestNamespace="urn:iControl:iCall/TriggeredHandler", ResponseNamespace="urn:iControl:iCall/TriggeredHandler")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_subscription_event(
		string [] handlers,
		string [] [] subscriptions
	) {
		object [] results = this.Invoke("get_subscription_event", new object [] {
				handlers,
				subscriptions});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_subscription_event(string [] handlers,string [] [] subscriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_subscription_event", new object[] {
			handlers,
			subscriptions}, callback, asyncState);
	}
	public string [] [] Endget_subscription_event(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/TriggeredHandler", 
		RequestNamespace="urn:iControl:iCall/TriggeredHandler", ResponseNamespace="urn:iControl:iCall/TriggeredHandler")]
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
	// remove_all_filters
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/TriggeredHandler", 
		RequestNamespace="urn:iControl:iCall/TriggeredHandler", ResponseNamespace="urn:iControl:iCall/TriggeredHandler")]
	public void remove_all_filters(
		string [] handlers,
		string [] [] subscriptions
	) {
		this.Invoke("remove_all_filters", new object [] {
				handlers,
				subscriptions});

	}
	public System.IAsyncResult Beginremove_all_filters(string [] handlers,string [] [] subscriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_filters", new object[] {
			handlers,
			subscriptions}, callback, asyncState);
	}
	public void Endremove_all_filters(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_subscriptions
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/TriggeredHandler", 
		RequestNamespace="urn:iControl:iCall/TriggeredHandler", ResponseNamespace="urn:iControl:iCall/TriggeredHandler")]
	public void remove_all_subscriptions(
		string [] handlers
	) {
		this.Invoke("remove_all_subscriptions", new object [] {
				handlers});

	}
	public System.IAsyncResult Beginremove_all_subscriptions(string [] handlers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_subscriptions", new object[] {
			handlers}, callback, asyncState);
	}
	public void Endremove_all_subscriptions(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_filter
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/TriggeredHandler", 
		RequestNamespace="urn:iControl:iCall/TriggeredHandler", ResponseNamespace="urn:iControl:iCall/TriggeredHandler")]
	public void remove_filter(
		string [] handlers,
		string [] [] subscriptions,
		string [] [] [] filters
	) {
		this.Invoke("remove_filter", new object [] {
				handlers,
				subscriptions,
				filters});

	}
	public System.IAsyncResult Beginremove_filter(string [] handlers,string [] [] subscriptions,string [] [] [] filters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_filter", new object[] {
			handlers,
			subscriptions,
			filters}, callback, asyncState);
	}
	public void Endremove_filter(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_subscription
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/TriggeredHandler", 
		RequestNamespace="urn:iControl:iCall/TriggeredHandler", ResponseNamespace="urn:iControl:iCall/TriggeredHandler")]
	public void remove_subscription(
		string [] handlers,
		string [] [] subscriptions
	) {
		this.Invoke("remove_subscription", new object [] {
				handlers,
				subscriptions});

	}
	public System.IAsyncResult Beginremove_subscription(string [] handlers,string [] [] subscriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_subscription", new object[] {
			handlers,
			subscriptions}, callback, asyncState);
	}
	public void Endremove_subscription(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/TriggeredHandler", 
		RequestNamespace="urn:iControl:iCall/TriggeredHandler", ResponseNamespace="urn:iControl:iCall/TriggeredHandler")]
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
	// set_filter_match_algorithm
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/TriggeredHandler", 
		RequestNamespace="urn:iControl:iCall/TriggeredHandler", ResponseNamespace="urn:iControl:iCall/TriggeredHandler")]
	public void set_filter_match_algorithm(
		string [] handlers,
		string [] [] subscriptions,
		string [] [] [] filters,
		iCallMatchAlgorithm [] [] [] algorithms
	) {
		this.Invoke("set_filter_match_algorithm", new object [] {
				handlers,
				subscriptions,
				filters,
				algorithms});

	}
	public System.IAsyncResult Beginset_filter_match_algorithm(string [] handlers,string [] [] subscriptions,string [] [] [] filters,iCallMatchAlgorithm [] [] [] algorithms, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_filter_match_algorithm", new object[] {
			handlers,
			subscriptions,
			filters,
			algorithms}, callback, asyncState);
	}
	public void Endset_filter_match_algorithm(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_filter_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/TriggeredHandler", 
		RequestNamespace="urn:iControl:iCall/TriggeredHandler", ResponseNamespace="urn:iControl:iCall/TriggeredHandler")]
	public void set_filter_value(
		string [] handlers,
		string [] [] subscriptions,
		string [] [] [] filters,
		string [] [] [] values
	) {
		this.Invoke("set_filter_value", new object [] {
				handlers,
				subscriptions,
				filters,
				values});

	}
	public System.IAsyncResult Beginset_filter_value(string [] handlers,string [] [] subscriptions,string [] [] [] filters,string [] [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_filter_value", new object[] {
			handlers,
			subscriptions,
			filters,
			values}, callback, asyncState);
	}
	public void Endset_filter_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_handler_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/TriggeredHandler", 
		RequestNamespace="urn:iControl:iCall/TriggeredHandler", ResponseNamespace="urn:iControl:iCall/TriggeredHandler")]
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
	// set_script
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/TriggeredHandler", 
		RequestNamespace="urn:iControl:iCall/TriggeredHandler", ResponseNamespace="urn:iControl:iCall/TriggeredHandler")]
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

	//-----------------------------------------------------------------------
	// set_subscription_event
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:iCall/TriggeredHandler", 
		RequestNamespace="urn:iControl:iCall/TriggeredHandler", ResponseNamespace="urn:iControl:iCall/TriggeredHandler")]
	public void set_subscription_event(
		string [] handlers,
		string [] [] subscriptions,
		string [] [] events
	) {
		this.Invoke("set_subscription_event", new object [] {
				handlers,
				subscriptions,
				events});

	}
	public System.IAsyncResult Beginset_subscription_event(string [] handlers,string [] [] subscriptions,string [] [] events, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_subscription_event", new object[] {
			handlers,
			subscriptions,
			events}, callback, asyncState);
	}
	public void Endset_subscription_event(System.IAsyncResult asyncResult) {
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
