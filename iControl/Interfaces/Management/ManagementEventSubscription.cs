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
	[System.Web.Services.WebServiceBindingAttribute(Name="Management.EventSubscriptionBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementEventSubscriptionSubscriptionStatus))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementEventSubscriptionSubscriptionDetails))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementEventSubscriptionSubscriptionDetailsV2))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementEventSubscriptionUserCredential))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementEventSubscriptionSubscriptionStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementEventSubscriptionSubscriptionDefinition))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementEventSubscriptionSubscriptionDefinitionV2))]
	public partial class ManagementEventSubscription : iControlInterface {
		public ManagementEventSubscription() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/EventSubscription", 
		RequestNamespace="urn:iControl:Management/EventSubscription", ResponseNamespace="urn:iControl:Management/EventSubscription")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementEventSubscriptionSubscriptionStatus [] create(
		ManagementEventSubscriptionSubscriptionDetails [] sub_detail_list
	) {
		object [] results = this.Invoke("create", new object [] {
				sub_detail_list});
		return ((ManagementEventSubscriptionSubscriptionStatus [])(results[0]));
	}
	public System.IAsyncResult Begincreate(ManagementEventSubscriptionSubscriptionDetails [] sub_detail_list, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			sub_detail_list}, callback, asyncState);
	}
	public ManagementEventSubscriptionSubscriptionStatus [] Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementEventSubscriptionSubscriptionStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// create_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/EventSubscription", 
		RequestNamespace="urn:iControl:Management/EventSubscription", ResponseNamespace="urn:iControl:Management/EventSubscription")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementEventSubscriptionSubscriptionStatus [] create_v2(
		ManagementEventSubscriptionSubscriptionDetailsV2 [] sub_detail_list
	) {
		object [] results = this.Invoke("create_v2", new object [] {
				sub_detail_list});
		return ((ManagementEventSubscriptionSubscriptionStatus [])(results[0]));
	}
	public System.IAsyncResult Begincreate_v2(ManagementEventSubscriptionSubscriptionDetailsV2 [] sub_detail_list, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_v2", new object[] {
			sub_detail_list}, callback, asyncState);
	}
	public ManagementEventSubscriptionSubscriptionStatus [] Endcreate_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementEventSubscriptionSubscriptionStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_authentication
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/EventSubscription", 
		RequestNamespace="urn:iControl:Management/EventSubscription", ResponseNamespace="urn:iControl:Management/EventSubscription")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementEventSubscriptionSubscriptionStatus [] get_authentication(
		string [] id_list,
		out ManagementEventSubscriptionUserCredential [] credential_list
	) {
		object [] results = this.Invoke("get_authentication", new object [] {
				id_list});
		credential_list = ((ManagementEventSubscriptionUserCredential [])(results[1]));
		return ((ManagementEventSubscriptionSubscriptionStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_authentication(string [] id_list, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_authentication", new object[] {
			id_list}, callback, asyncState);
	}
	public ManagementEventSubscriptionSubscriptionStatus [] Endget_authentication(System.IAsyncResult asyncResult,
 out ManagementEventSubscriptionUserCredential [] credential_list) {
		object [] results = this.EndInvoke(asyncResult);
		credential_list = ((ManagementEventSubscriptionUserCredential [])(results[1]));
		return ((ManagementEventSubscriptionSubscriptionStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_available_event_types
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/EventSubscription", 
		RequestNamespace="urn:iControl:Management/EventSubscription", ResponseNamespace="urn:iControl:Management/EventSubscription")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementEventSubscriptionEventType [] get_available_event_types(

	) {
		object [] results = this.Invoke("get_available_event_types", new object [0]);
		return ((ManagementEventSubscriptionEventType [])(results[0]));
	}
	public System.IAsyncResult Beginget_available_event_types(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_available_event_types", new object[0], callback, asyncState);
	}
	public ManagementEventSubscriptionEventType [] Endget_available_event_types(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementEventSubscriptionEventType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/EventSubscription", 
		RequestNamespace="urn:iControl:Management/EventSubscription", ResponseNamespace="urn:iControl:Management/EventSubscription")]
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
	// get_max_timeslice
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/EventSubscription", 
		RequestNamespace="urn:iControl:Management/EventSubscription", ResponseNamespace="urn:iControl:Management/EventSubscription")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementEventSubscriptionSubscriptionStatus [] get_max_timeslice(
		string [] id_list,
		out long [] max_timeslice_list
	) {
		object [] results = this.Invoke("get_max_timeslice", new object [] {
				id_list});
		max_timeslice_list = ((long [])(results[1]));
		return ((ManagementEventSubscriptionSubscriptionStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_max_timeslice(string [] id_list, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_max_timeslice", new object[] {
			id_list}, callback, asyncState);
	}
	public ManagementEventSubscriptionSubscriptionStatus [] Endget_max_timeslice(System.IAsyncResult asyncResult,
 out long [] max_timeslice_list) {
		object [] results = this.EndInvoke(asyncResult);
		max_timeslice_list = ((long [])(results[1]));
		return ((ManagementEventSubscriptionSubscriptionStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_min_events_per_timeslice
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/EventSubscription", 
		RequestNamespace="urn:iControl:Management/EventSubscription", ResponseNamespace="urn:iControl:Management/EventSubscription")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementEventSubscriptionSubscriptionStatus [] get_min_events_per_timeslice(
		string [] id_list,
		out long [] min_events_list
	) {
		object [] results = this.Invoke("get_min_events_per_timeslice", new object [] {
				id_list});
		min_events_list = ((long [])(results[1]));
		return ((ManagementEventSubscriptionSubscriptionStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_min_events_per_timeslice(string [] id_list, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_min_events_per_timeslice", new object[] {
			id_list}, callback, asyncState);
	}
	public ManagementEventSubscriptionSubscriptionStatus [] Endget_min_events_per_timeslice(System.IAsyncResult asyncResult,
 out long [] min_events_list) {
		object [] results = this.EndInvoke(asyncResult);
		min_events_list = ((long [])(results[1]));
		return ((ManagementEventSubscriptionSubscriptionStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_proxy_url
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/EventSubscription", 
		RequestNamespace="urn:iControl:Management/EventSubscription", ResponseNamespace="urn:iControl:Management/EventSubscription")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementEventSubscriptionSubscriptionStatus [] get_proxy_url(
		string [] id_list,
		out string [] proxies
	) {
		object [] results = this.Invoke("get_proxy_url", new object [] {
				id_list});
		proxies = ((string [])(results[1]));
		return ((ManagementEventSubscriptionSubscriptionStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_proxy_url(string [] id_list, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_proxy_url", new object[] {
			id_list}, callback, asyncState);
	}
	public ManagementEventSubscriptionSubscriptionStatus [] Endget_proxy_url(System.IAsyncResult asyncResult,
 out string [] proxies) {
		object [] results = this.EndInvoke(asyncResult);
		proxies = ((string [])(results[1]));
		return ((ManagementEventSubscriptionSubscriptionStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/EventSubscription", 
		RequestNamespace="urn:iControl:Management/EventSubscription", ResponseNamespace="urn:iControl:Management/EventSubscription")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementEventSubscriptionSubscriptionStatus [] get_state(
		string [] id_list,
		out CommonEnabledState [] state_list
	) {
		object [] results = this.Invoke("get_state", new object [] {
				id_list});
		state_list = ((CommonEnabledState [])(results[1]));
		return ((ManagementEventSubscriptionSubscriptionStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_state(string [] id_list, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_state", new object[] {
			id_list}, callback, asyncState);
	}
	public ManagementEventSubscriptionSubscriptionStatus [] Endget_state(System.IAsyncResult asyncResult,
 out CommonEnabledState [] state_list) {
		object [] results = this.EndInvoke(asyncResult);
		state_list = ((CommonEnabledState [])(results[1]));
		return ((ManagementEventSubscriptionSubscriptionStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/EventSubscription", 
		RequestNamespace="urn:iControl:Management/EventSubscription", ResponseNamespace="urn:iControl:Management/EventSubscription")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementEventSubscriptionSubscriptionStatus [] get_statistics(
		string [] id_list,
		out ManagementEventSubscriptionSubscriptionStatistics [] statistics_list
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				id_list});
		statistics_list = ((ManagementEventSubscriptionSubscriptionStatistics [])(results[1]));
		return ((ManagementEventSubscriptionSubscriptionStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] id_list, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			id_list}, callback, asyncState);
	}
	public ManagementEventSubscriptionSubscriptionStatus [] Endget_statistics(System.IAsyncResult asyncResult,
 out ManagementEventSubscriptionSubscriptionStatistics [] statistics_list) {
		object [] results = this.EndInvoke(asyncResult);
		statistics_list = ((ManagementEventSubscriptionSubscriptionStatistics [])(results[1]));
		return ((ManagementEventSubscriptionSubscriptionStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ttl
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/EventSubscription", 
		RequestNamespace="urn:iControl:Management/EventSubscription", ResponseNamespace="urn:iControl:Management/EventSubscription")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementEventSubscriptionSubscriptionStatus [] get_ttl(
		string [] id_list,
		out long [] ttl_list
	) {
		object [] results = this.Invoke("get_ttl", new object [] {
				id_list});
		ttl_list = ((long [])(results[1]));
		return ((ManagementEventSubscriptionSubscriptionStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_ttl(string [] id_list, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ttl", new object[] {
			id_list}, callback, asyncState);
	}
	public ManagementEventSubscriptionSubscriptionStatus [] Endget_ttl(System.IAsyncResult asyncResult,
 out long [] ttl_list) {
		object [] results = this.EndInvoke(asyncResult);
		ttl_list = ((long [])(results[1]));
		return ((ManagementEventSubscriptionSubscriptionStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_url
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/EventSubscription", 
		RequestNamespace="urn:iControl:Management/EventSubscription", ResponseNamespace="urn:iControl:Management/EventSubscription")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementEventSubscriptionSubscriptionStatus [] get_url(
		string [] id_list,
		out string [] url_list
	) {
		object [] results = this.Invoke("get_url", new object [] {
				id_list});
		url_list = ((string [])(results[1]));
		return ((ManagementEventSubscriptionSubscriptionStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_url(string [] id_list, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_url", new object[] {
			id_list}, callback, asyncState);
	}
	public ManagementEventSubscriptionSubscriptionStatus [] Endget_url(System.IAsyncResult asyncResult,
 out string [] url_list) {
		object [] results = this.EndInvoke(asyncResult);
		url_list = ((string [])(results[1]));
		return ((ManagementEventSubscriptionSubscriptionStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/EventSubscription", 
		RequestNamespace="urn:iControl:Management/EventSubscription", ResponseNamespace="urn:iControl:Management/EventSubscription")]
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
	// modify
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/EventSubscription", 
		RequestNamespace="urn:iControl:Management/EventSubscription", ResponseNamespace="urn:iControl:Management/EventSubscription")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementEventSubscriptionSubscriptionStatus [] modify(
		ManagementEventSubscriptionSubscriptionDefinition [] sub_def_list
	) {
		object [] results = this.Invoke("modify", new object [] {
				sub_def_list});
		return ((ManagementEventSubscriptionSubscriptionStatus [])(results[0]));
	}
	public System.IAsyncResult Beginmodify(ManagementEventSubscriptionSubscriptionDefinition [] sub_def_list, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("modify", new object[] {
			sub_def_list}, callback, asyncState);
	}
	public ManagementEventSubscriptionSubscriptionStatus [] Endmodify(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementEventSubscriptionSubscriptionStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// modify_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/EventSubscription", 
		RequestNamespace="urn:iControl:Management/EventSubscription", ResponseNamespace="urn:iControl:Management/EventSubscription")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementEventSubscriptionSubscriptionStatus [] modify_v2(
		ManagementEventSubscriptionSubscriptionDefinitionV2 [] sub_def_list
	) {
		object [] results = this.Invoke("modify_v2", new object [] {
				sub_def_list});
		return ((ManagementEventSubscriptionSubscriptionStatus [])(results[0]));
	}
	public System.IAsyncResult Beginmodify_v2(ManagementEventSubscriptionSubscriptionDefinitionV2 [] sub_def_list, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("modify_v2", new object[] {
			sub_def_list}, callback, asyncState);
	}
	public ManagementEventSubscriptionSubscriptionStatus [] Endmodify_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementEventSubscriptionSubscriptionStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// ping
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/EventSubscription", 
		RequestNamespace="urn:iControl:Management/EventSubscription", ResponseNamespace="urn:iControl:Management/EventSubscription")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementEventSubscriptionSubscriptionStatus ping(

	) {
		object [] results = this.Invoke("ping", new object [0]);
		return ((ManagementEventSubscriptionSubscriptionStatus)(results[0]));
	}
	public System.IAsyncResult Beginping(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("ping", new object[0], callback, asyncState);
	}
	public ManagementEventSubscriptionSubscriptionStatus Endping(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementEventSubscriptionSubscriptionStatus)(results[0]));
	}

	//-----------------------------------------------------------------------
	// query
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/EventSubscription", 
		RequestNamespace="urn:iControl:Management/EventSubscription", ResponseNamespace="urn:iControl:Management/EventSubscription")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementEventSubscriptionSubscriptionStatus [] query(
		string [] id_list,
		out ManagementEventSubscriptionSubscriptionDefinition [] sub_def_list
	) {
		object [] results = this.Invoke("query", new object [] {
				id_list});
		sub_def_list = ((ManagementEventSubscriptionSubscriptionDefinition [])(results[1]));
		return ((ManagementEventSubscriptionSubscriptionStatus [])(results[0]));
	}
	public System.IAsyncResult Beginquery(string [] id_list, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("query", new object[] {
			id_list}, callback, asyncState);
	}
	public ManagementEventSubscriptionSubscriptionStatus [] Endquery(System.IAsyncResult asyncResult,
 out ManagementEventSubscriptionSubscriptionDefinition [] sub_def_list) {
		object [] results = this.EndInvoke(asyncResult);
		sub_def_list = ((ManagementEventSubscriptionSubscriptionDefinition [])(results[1]));
		return ((ManagementEventSubscriptionSubscriptionStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// query_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/EventSubscription", 
		RequestNamespace="urn:iControl:Management/EventSubscription", ResponseNamespace="urn:iControl:Management/EventSubscription")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementEventSubscriptionSubscriptionStatus [] query_v2(
		string [] id_list,
		out ManagementEventSubscriptionSubscriptionDefinitionV2 [] sub_def_list
	) {
		object [] results = this.Invoke("query_v2", new object [] {
				id_list});
		sub_def_list = ((ManagementEventSubscriptionSubscriptionDefinitionV2 [])(results[1]));
		return ((ManagementEventSubscriptionSubscriptionStatus [])(results[0]));
	}
	public System.IAsyncResult Beginquery_v2(string [] id_list, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("query_v2", new object[] {
			id_list}, callback, asyncState);
	}
	public ManagementEventSubscriptionSubscriptionStatus [] Endquery_v2(System.IAsyncResult asyncResult,
 out ManagementEventSubscriptionSubscriptionDefinitionV2 [] sub_def_list) {
		object [] results = this.EndInvoke(asyncResult);
		sub_def_list = ((ManagementEventSubscriptionSubscriptionDefinitionV2 [])(results[1]));
		return ((ManagementEventSubscriptionSubscriptionStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// remove
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/EventSubscription", 
		RequestNamespace="urn:iControl:Management/EventSubscription", ResponseNamespace="urn:iControl:Management/EventSubscription")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementEventSubscriptionSubscriptionStatus [] remove(
		string [] id_list
	) {
		object [] results = this.Invoke("remove", new object [] {
				id_list});
		return ((ManagementEventSubscriptionSubscriptionStatus [])(results[0]));
	}
	public System.IAsyncResult Beginremove(string [] id_list, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove", new object[] {
			id_list}, callback, asyncState);
	}
	public ManagementEventSubscriptionSubscriptionStatus [] Endremove(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementEventSubscriptionSubscriptionStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/EventSubscription", 
		RequestNamespace="urn:iControl:Management/EventSubscription", ResponseNamespace="urn:iControl:Management/EventSubscription")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementEventSubscriptionSubscriptionStatus [] reset_statistics(
		string [] id_list
	) {
		object [] results = this.Invoke("reset_statistics", new object [] {
				id_list});
		return ((ManagementEventSubscriptionSubscriptionStatus [])(results[0]));
	}
	public System.IAsyncResult Beginreset_statistics(string [] id_list, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics", new object[] {
			id_list}, callback, asyncState);
	}
	public ManagementEventSubscriptionSubscriptionStatus [] Endreset_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementEventSubscriptionSubscriptionStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// set_authentication
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/EventSubscription", 
		RequestNamespace="urn:iControl:Management/EventSubscription", ResponseNamespace="urn:iControl:Management/EventSubscription")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementEventSubscriptionSubscriptionStatus [] set_authentication(
		string [] id_list,
		ManagementEventSubscriptionUserCredential [] credential_list
	) {
		object [] results = this.Invoke("set_authentication", new object [] {
				id_list,
				credential_list});
		return ((ManagementEventSubscriptionSubscriptionStatus [])(results[0]));
	}
	public System.IAsyncResult Beginset_authentication(string [] id_list,ManagementEventSubscriptionUserCredential [] credential_list, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_authentication", new object[] {
			id_list,
			credential_list}, callback, asyncState);
	}
	public ManagementEventSubscriptionSubscriptionStatus [] Endset_authentication(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementEventSubscriptionSubscriptionStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// set_max_timeslice
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/EventSubscription", 
		RequestNamespace="urn:iControl:Management/EventSubscription", ResponseNamespace="urn:iControl:Management/EventSubscription")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementEventSubscriptionSubscriptionStatus [] set_max_timeslice(
		string [] id_list,
		long [] max_timeslice_list
	) {
		object [] results = this.Invoke("set_max_timeslice", new object [] {
				id_list,
				max_timeslice_list});
		return ((ManagementEventSubscriptionSubscriptionStatus [])(results[0]));
	}
	public System.IAsyncResult Beginset_max_timeslice(string [] id_list,long [] max_timeslice_list, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_max_timeslice", new object[] {
			id_list,
			max_timeslice_list}, callback, asyncState);
	}
	public ManagementEventSubscriptionSubscriptionStatus [] Endset_max_timeslice(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementEventSubscriptionSubscriptionStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// set_min_events_per_timeslice
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/EventSubscription", 
		RequestNamespace="urn:iControl:Management/EventSubscription", ResponseNamespace="urn:iControl:Management/EventSubscription")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementEventSubscriptionSubscriptionStatus [] set_min_events_per_timeslice(
		string [] id_list,
		long [] min_events_list
	) {
		object [] results = this.Invoke("set_min_events_per_timeslice", new object [] {
				id_list,
				min_events_list});
		return ((ManagementEventSubscriptionSubscriptionStatus [])(results[0]));
	}
	public System.IAsyncResult Beginset_min_events_per_timeslice(string [] id_list,long [] min_events_list, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_min_events_per_timeslice", new object[] {
			id_list,
			min_events_list}, callback, asyncState);
	}
	public ManagementEventSubscriptionSubscriptionStatus [] Endset_min_events_per_timeslice(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementEventSubscriptionSubscriptionStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// set_proxy_url
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/EventSubscription", 
		RequestNamespace="urn:iControl:Management/EventSubscription", ResponseNamespace="urn:iControl:Management/EventSubscription")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementEventSubscriptionSubscriptionStatus [] set_proxy_url(
		string [] id_list,
		string [] proxies
	) {
		object [] results = this.Invoke("set_proxy_url", new object [] {
				id_list,
				proxies});
		return ((ManagementEventSubscriptionSubscriptionStatus [])(results[0]));
	}
	public System.IAsyncResult Beginset_proxy_url(string [] id_list,string [] proxies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_proxy_url", new object[] {
			id_list,
			proxies}, callback, asyncState);
	}
	public ManagementEventSubscriptionSubscriptionStatus [] Endset_proxy_url(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementEventSubscriptionSubscriptionStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// set_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/EventSubscription", 
		RequestNamespace="urn:iControl:Management/EventSubscription", ResponseNamespace="urn:iControl:Management/EventSubscription")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementEventSubscriptionSubscriptionStatus [] set_state(
		string [] id_list,
		CommonEnabledState [] state_list
	) {
		object [] results = this.Invoke("set_state", new object [] {
				id_list,
				state_list});
		return ((ManagementEventSubscriptionSubscriptionStatus [])(results[0]));
	}
	public System.IAsyncResult Beginset_state(string [] id_list,CommonEnabledState [] state_list, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_state", new object[] {
			id_list,
			state_list}, callback, asyncState);
	}
	public ManagementEventSubscriptionSubscriptionStatus [] Endset_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementEventSubscriptionSubscriptionStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// set_ttl
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/EventSubscription", 
		RequestNamespace="urn:iControl:Management/EventSubscription", ResponseNamespace="urn:iControl:Management/EventSubscription")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementEventSubscriptionSubscriptionStatus [] set_ttl(
		string [] id_list,
		long [] ttl_list
	) {
		object [] results = this.Invoke("set_ttl", new object [] {
				id_list,
				ttl_list});
		return ((ManagementEventSubscriptionSubscriptionStatus [])(results[0]));
	}
	public System.IAsyncResult Beginset_ttl(string [] id_list,long [] ttl_list, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ttl", new object[] {
			id_list,
			ttl_list}, callback, asyncState);
	}
	public ManagementEventSubscriptionSubscriptionStatus [] Endset_ttl(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementEventSubscriptionSubscriptionStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// set_url
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/EventSubscription", 
		RequestNamespace="urn:iControl:Management/EventSubscription", ResponseNamespace="urn:iControl:Management/EventSubscription")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementEventSubscriptionSubscriptionStatus [] set_url(
		string [] id_list,
		string [] url_list
	) {
		object [] results = this.Invoke("set_url", new object [] {
				id_list,
				url_list});
		return ((ManagementEventSubscriptionSubscriptionStatus [])(results[0]));
	}
	public System.IAsyncResult Beginset_url(string [] id_list,string [] url_list, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_url", new object[] {
			id_list,
			url_list}, callback, asyncState);
	}
	public ManagementEventSubscriptionSubscriptionStatus [] Endset_url(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementEventSubscriptionSubscriptionStatus [])(results[0]));
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.EventSubscription.AuthenticationMode", Namespace = "urn:iControl")]
	public enum ManagementEventSubscriptionAuthenticationMode
	{
		AUTHMODE_NONE,
		AUTHMODE_BASIC,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.EventSubscription.EventType", Namespace = "urn:iControl")]
	public enum ManagementEventSubscriptionEventType
	{
		EVENTTYPE_NONE,
		EVENTTYPE_TEST,
		EVENTTYPE_ALL,
		EVENTTYPE_SYSTEM_STARTUP,
		EVENTTYPE_SYSTEM_SHUTDOWN,
		EVENTTYPE_SYSTEM_CONFIG_LOAD,
		EVENTTYPE_CREATE,
		EVENTTYPE_MODIFY,
		EVENTTYPE_DELETE,
		EVENTTYPE_ADMIN_IP,
		EVENTTYPE_ARP_ENTRY,
		EVENTTYPE_DAEMON_HA,
		EVENTTYPE_DB_VARIABLE,
		EVENTTYPE_FEATURE_FLAGS,
		EVENTTYPE_FILTER_PROFILE,
		EVENTTYPE_GTMD,
		EVENTTYPE_INTERFACE,
		EVENTTYPE_LCDWARN,
		EVENTTYPE_L2_FORWARD,
		EVENTTYPE_MIRROR_PORT_MEMBER,
		EVENTTYPE_MIRROR_PORT,
		EVENTTYPE_MIRROR_VLAN,
		EVENTTYPE_MONITOR,
		EVENTTYPE_NAT,
		EVENTTYPE_NODE_ADDRESS,
		EVENTTYPE_PACKET_FILTER,
		EVENTTYPE_PCI_DEVICE,
		EVENTTYPE_POOL,
		EVENTTYPE_POOL_MEMBER,
		EVENTTYPE_RATE_FILTER,
		EVENTTYPE_ROUTE_MGMT,
		EVENTTYPE_ROUTE_UPDATE,
		EVENTTYPE_RULE,
		EVENTTYPE_SELF_IP,
		EVENTTYPE_SENSOR,
		EVENTTYPE_SNAT_ADDRESS,
		EVENTTYPE_SNAT_POOL,
		EVENTTYPE_SNAT_POOL_MEMBER,
		EVENTTYPE_STP,
		EVENTTYPE_SWITCH_DOMAIN,
		EVENTTYPE_SWITCH_EDGE,
		EVENTTYPE_TAMD_AUTH,
		EVENTTYPE_TRUNK,
		EVENTTYPE_TRUNK_CONFIG_MEMBER,
		EVENTTYPE_TRUNK_WORKING_MEMBER,
		EVENTTYPE_VALUE_LIST,
		EVENTTYPE_VIRTUAL_ADDRESS,
		EVENTTYPE_VIRTUAL_SERVER,
		EVENTTYPE_VIRTUAL_SERVER_PROFILE,
		EVENTTYPE_VLAN,
		EVENTTYPE_VLAN_MEMBER,
		EVENTTYPE_VLANGROUP,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.EventSubscription.ObjectType", Namespace = "urn:iControl")]
	public enum ManagementEventSubscriptionObjectType
	{
		OBJECTTYPE_UNKNOWN,
		OBJECTTYPE_ADMIN_IP,
		OBJECTTYPE_ARP_STATIC_ENTRY,
		OBJECTTYPE_AUTH_GENERIC_CONFIG,
		OBJECTTYPE_AUTH_LDAP_CONFIG,
		OBJECTTYPE_AUTH_RADIUS_CONFIG,
		OBJECTTYPE_AUTH_RADIUS_CONFIG_RADIUS_SERVER,
		OBJECTTYPE_AUTH_SSL_CC_LDAP_CONFIG,
		OBJECTTYPE_AUTH_SSL_OCSP_CONFIG,
		OBJECTTYPE_AUTH_TACACS_CONFIG,
		OBJECTTYPE_DAEMON_HA,
		OBJECTTYPE_DAEMON_STATUS,
		OBJECTTYPE_DB_VARIABLE,
		OBJECTTYPE_DEFAULT_MONITOR_RULE,
		OBJECTTYPE_GTM_BOX,
		OBJECTTYPE_GTM_DC,
		OBJECTTYPE_GTM_ECV,
		OBJECTTYPE_GTM_GLOBALS,
		OBJECTTYPE_GTM_IP,
		OBJECTTYPE_GTM_LINK,
		OBJECTTYPE_GTM_POOL,
		OBJECTTYPE_GTM_POOL_MEMBER,
		OBJECTTYPE_GTM_QOS_COEFF,
		OBJECTTYPE_GTM_REG_ITEM,
		OBJECTTYPE_GTM_REGION_ENTRY,
		OBJECTTYPE_GTM_SERVER,
		OBJECTTYPE_GTM_TOP_ITEM,
		OBJECTTYPE_GTM_VS,
		OBJECTTYPE_GTM_WIDEIP,
		OBJECTTYPE_GTM_WIDEIP_ALIAS,
		OBJECTTYPE_GTM_WIDEIP_POOL,
		OBJECTTYPE_INTERFACE,
		OBJECTTYPE_JOIN_AUTH_SSL_OCSP_CONFIG_OCSP_RESPONDER,
		OBJECTTYPE_L2_FORWARD,
		OBJECTTYPE_LICENSE_BLOB,
		OBJECTTYPE_MIRROR_PORT,
		OBJECTTYPE_MIRROR_PORT_MBR,
		OBJECTTYPE_MIRROR_VLAN,
		OBJECTTYPE_MONITOR,
		OBJECTTYPE_MONITOR_INSTANCE,
		OBJECTTYPE_MONITOR_PARAM,
		OBJECTTYPE_MONITOR_RULE,
		OBJECTTYPE_MONITOR_RULE_INSTANCE,
		OBJECTTYPE_NAT,
		OBJECTTYPE_NAT_VLAN,
		OBJECTTYPE_NODE_ADDRESS,
		OBJECTTYPE_NOKIA_ALARM,
		OBJECTTYPE_NOKIA_LOG,
		OBJECTTYPE_OCSP_RESPONDER,
		OBJECTTYPE_PACKET_FILTER_ALLOW_TRUSTED,
		OBJECTTYPE_PACKET_FILTER_RULE,
		OBJECTTYPE_PAM_LINE,
		OBJECTTYPE_PCI_DEVICE,
		OBJECTTYPE_PLATFORM,
		OBJECTTYPE_POOL,
		OBJECTTYPE_POOL_MEMBER,
		OBJECTTYPE_PROFILE_AUTH,
		OBJECTTYPE_PROFILE_BIGPROTO,
		OBJECTTYPE_PROFILE_CLIENTSSL,
		OBJECTTYPE_PROFILE_CONNPOOL,
		OBJECTTYPE_PROFILE_FTP,
		OBJECTTYPE_PROFILE_HTTP,
		OBJECTTYPE_PROFILE_PERSIST,
		OBJECTTYPE_PROFILE_SERVERSSL,
		OBJECTTYPE_PROFILE_STREAM,
		OBJECTTYPE_PROFILE_TCP,
		OBJECTTYPE_PROFILE_UDP,
		OBJECTTYPE_PROXY_EXCLUSION,
		OBJECTTYPE_RADIUS_SERVER,
		OBJECTTYPE_RATE_FILTER_CLASS,
		OBJECTTYPE_ROUTE_STATIC_ENTRY,
		OBJECTTYPE_ROUTE_MGMT_ENTRY,
		OBJECTTYPE_RULE,
		OBJECTTYPE_RULE_EVENT,
		OBJECTTYPE_SELF_IP,
		OBJECTTYPE_SNAT,
		OBJECTTYPE_SNAT_ORIG_ADDR,
		OBJECTTYPE_SNAT_VLAN,
		OBJECTTYPE_SNATPOOL,
		OBJECTTYPE_SNATPOOL_TRANS_ADDR,
		OBJECTTYPE_STP,
		OBJECTTYPE_STP_GLOBALS,
		OBJECTTYPE_STP_INTERFACE_MBR,
		OBJECTTYPE_STP_VLAN_MBR,
		OBJECTTYPE_SWITCH_DOMAIN,
		OBJECTTYPE_SWITCH_EDGE,
		OBJECTTYPE_SYSTEM_INFORMATION,
		OBJECTTYPE_TRANS_ADDR,
		OBJECTTYPE_TRUNK,
		OBJECTTYPE_TRUNK_CFG_MBR,
		OBJECTTYPE_TRUNK_WRKNG_MBR,
		OBJECTTYPE_USERDB_ENTRY,
		OBJECTTYPE_VALUE_LIST,
		OBJECTTYPE_VIRTUAL_ADDRESS,
		OBJECTTYPE_VIRTUAL_SERVER,
		OBJECTTYPE_VIRTUAL_SERVER_AUTH,
		OBJECTTYPE_VIRTUAL_SERVER_CLONE_POOL,
		OBJECTTYPE_VIRTUAL_SERVER_PERSIST,
		OBJECTTYPE_VIRTUAL_SERVER_POOL,
		OBJECTTYPE_VIRTUAL_SERVER_PROFILE,
		OBJECTTYPE_VIRTUAL_SERVER_RULE,
		OBJECTTYPE_VIRTUAL_SERVER_VLAN,
		OBJECTTYPE_VLAN,
		OBJECTTYPE_VLAN_ID_CONTAINER,
		OBJECTTYPE_VLAN_MEMBER,
		OBJECTTYPE_VLANGROUP,
		OBJECTTYPE_VLANGROUP_MBR,
		OBJECTTYPE_GTM_APPLICATION,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.EventSubscription.SubscriptionStatusCode", Namespace = "urn:iControl")]
	public enum ManagementEventSubscriptionSubscriptionStatusCode
	{
		E_OK,
		E_GENERAL_ERROR,
		E_INVALID_EVENT_TYPE,
		E_INVALID_ID,
		E_INVALID_URL,
		E_INVALID_USERNAME,
		E_INVALID_PASSWORD,
		E_INVALID_TTL,
		E_INVALID_MIN_EVENTS_PER_TIMESLICE,
		E_INVALID_MAX_TIMESLICE,
		E_INVALID_ENABLED_STATE,
		E_CONNECTION_REFUSED,
		E_CONNECTION_TIMEDOUT,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.EventSubscription.SubscriptionDefinition", Namespace = "urn:iControl")]
	public partial class ManagementEventSubscriptionSubscriptionDefinition
	{
		private string idField;
		public string id
		{
			get { return this.idField; }
			set { this.idField = value; }
		}
		private ManagementEventSubscriptionSubscriptionDetails detailsField;
		public ManagementEventSubscriptionSubscriptionDetails details
		{
			get { return this.detailsField; }
			set { this.detailsField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.EventSubscription.SubscriptionDefinitionV2", Namespace = "urn:iControl")]
	public partial class ManagementEventSubscriptionSubscriptionDefinitionV2
	{
		private string idField;
		public string id
		{
			get { return this.idField; }
			set { this.idField = value; }
		}
		private ManagementEventSubscriptionSubscriptionDetailsV2 detailsField;
		public ManagementEventSubscriptionSubscriptionDetailsV2 details
		{
			get { return this.detailsField; }
			set { this.detailsField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.EventSubscription.SubscriptionDetails", Namespace = "urn:iControl")]
	public partial class ManagementEventSubscriptionSubscriptionDetails
	{
		private string nameField;
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}
		private ManagementEventSubscriptionEventType [] event_type_listField;
		public ManagementEventSubscriptionEventType [] event_type_list
		{
			get { return this.event_type_listField; }
			set { this.event_type_listField = value; }
		}
		private string urlField;
		public string url
		{
			get { return this.urlField; }
			set { this.urlField = value; }
		}
		private ManagementEventSubscriptionUserCredential url_credentialsField;
		public ManagementEventSubscriptionUserCredential url_credentials
		{
			get { return this.url_credentialsField; }
			set { this.url_credentialsField = value; }
		}
		private long ttlField;
		public long ttl
		{
			get { return this.ttlField; }
			set { this.ttlField = value; }
		}
		private long min_events_per_timesliceField;
		public long min_events_per_timeslice
		{
			get { return this.min_events_per_timesliceField; }
			set { this.min_events_per_timesliceField = value; }
		}
		private long max_timesliceField;
		public long max_timeslice
		{
			get { return this.max_timesliceField; }
			set { this.max_timesliceField = value; }
		}
		private CommonEnabledState enabled_stateField;
		public CommonEnabledState enabled_state
		{
			get { return this.enabled_stateField; }
			set { this.enabled_stateField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.EventSubscription.SubscriptionDetailsV2", Namespace = "urn:iControl")]
	public partial class ManagementEventSubscriptionSubscriptionDetailsV2
	{
		private string nameField;
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}
		private ManagementEventSubscriptionEventType [] event_type_listField;
		public ManagementEventSubscriptionEventType [] event_type_list
		{
			get { return this.event_type_listField; }
			set { this.event_type_listField = value; }
		}
		private string urlField;
		public string url
		{
			get { return this.urlField; }
			set { this.urlField = value; }
		}
		private ManagementEventSubscriptionUserCredential url_credentialsField;
		public ManagementEventSubscriptionUserCredential url_credentials
		{
			get { return this.url_credentialsField; }
			set { this.url_credentialsField = value; }
		}
		private long ttlField;
		public long ttl
		{
			get { return this.ttlField; }
			set { this.ttlField = value; }
		}
		private long min_events_per_timesliceField;
		public long min_events_per_timeslice
		{
			get { return this.min_events_per_timesliceField; }
			set { this.min_events_per_timesliceField = value; }
		}
		private long max_timesliceField;
		public long max_timeslice
		{
			get { return this.max_timesliceField; }
			set { this.max_timesliceField = value; }
		}
		private CommonEnabledState enabled_stateField;
		public CommonEnabledState enabled_state
		{
			get { return this.enabled_stateField; }
			set { this.enabled_stateField = value; }
		}
		private string proxy_urlField;
		public string proxy_url
		{
			get { return this.proxy_urlField; }
			set { this.proxy_urlField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.EventSubscription.SubscriptionStatistics", Namespace = "urn:iControl")]
	public partial class ManagementEventSubscriptionSubscriptionStatistics
	{
		private string idField;
		public string id
		{
			get { return this.idField; }
			set { this.idField = value; }
		}
		private CommonTimeStamp time_createdField;
		public CommonTimeStamp time_created
		{
			get { return this.time_createdField; }
			set { this.time_createdField = value; }
		}
		private CommonTimeStamp time_last_modifiedField;
		public CommonTimeStamp time_last_modified
		{
			get { return this.time_last_modifiedField; }
			set { this.time_last_modifiedField = value; }
		}
		private CommonTimeStamp time_last_notifiedField;
		public CommonTimeStamp time_last_notified
		{
			get { return this.time_last_notifiedField; }
			set { this.time_last_notifiedField = value; }
		}
		private long notifications_sentField;
		public long notifications_sent
		{
			get { return this.notifications_sentField; }
			set { this.notifications_sentField = value; }
		}
		private ManagementEventSubscriptionSubscriptionStatus last_statusField;
		public ManagementEventSubscriptionSubscriptionStatus last_status
		{
			get { return this.last_statusField; }
			set { this.last_statusField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.EventSubscription.SubscriptionStatus", Namespace = "urn:iControl")]
	public partial class ManagementEventSubscriptionSubscriptionStatus
	{
		private ManagementEventSubscriptionSubscriptionStatusCode codeField;
		public ManagementEventSubscriptionSubscriptionStatusCode code
		{
			get { return this.codeField; }
			set { this.codeField = value; }
		}
		private string dataField;
		public string data
		{
			get { return this.dataField; }
			set { this.dataField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.EventSubscription.UserCredential", Namespace = "urn:iControl")]
	public partial class ManagementEventSubscriptionUserCredential
	{
		private ManagementEventSubscriptionAuthenticationMode auth_modeField;
		public ManagementEventSubscriptionAuthenticationMode auth_mode
		{
			get { return this.auth_modeField; }
			set { this.auth_modeField = value; }
		}
		private string usernameField;
		public string username
		{
			get { return this.usernameField; }
			set { this.usernameField = value; }
		}
		private string passwordField;
		public string password
		{
			get { return this.passwordField; }
			set { this.passwordField = value; }
		}
	};

}
