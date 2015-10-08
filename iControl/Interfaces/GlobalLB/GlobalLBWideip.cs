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
	[System.Web.Services.WebServiceBindingAttribute(Name="GlobalLB.WideIPBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBWideIPWideIPPool))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBWideIPWideIPRule))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBWideIPWideIPStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonObjectStatus))]
	public partial class GlobalLBWideIP : iControlInterface {
		public GlobalLBWideIP() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_alias
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	public void add_alias(
		string [] wide_ips,
		string [] [] aliases
	) {
		this.Invoke("add_alias", new object [] {
				wide_ips,
				aliases});

	}
	public System.IAsyncResult Beginadd_alias(string [] wide_ips,string [] [] aliases, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_alias", new object[] {
			wide_ips,
			aliases}, callback, asyncState);
	}
	public void Endadd_alias(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	public void add_metadata(
		string [] wide_ips,
		string [] [] names,
		string [] [] values
	) {
		this.Invoke("add_metadata", new object [] {
				wide_ips,
				names,
				values});

	}
	public System.IAsyncResult Beginadd_metadata(string [] wide_ips,string [] [] names,string [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_metadata", new object[] {
			wide_ips,
			names,
			values}, callback, asyncState);
	}
	public void Endadd_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_wideip_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	public void add_wideip_pool(
		string [] wide_ips,
		GlobalLBWideIPWideIPPool [] [] wideip_pools
	) {
		this.Invoke("add_wideip_pool", new object [] {
				wide_ips,
				wideip_pools});

	}
	public System.IAsyncResult Beginadd_wideip_pool(string [] wide_ips,GlobalLBWideIPWideIPPool [] [] wideip_pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_wideip_pool", new object[] {
			wide_ips,
			wideip_pools}, callback, asyncState);
	}
	public void Endadd_wideip_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_wideip_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	public void add_wideip_rule(
		string [] wide_ips,
		GlobalLBWideIPWideIPRule [] [] wideip_rules
	) {
		this.Invoke("add_wideip_rule", new object [] {
				wide_ips,
				wideip_rules});

	}
	public System.IAsyncResult Beginadd_wideip_rule(string [] wide_ips,GlobalLBWideIPWideIPRule [] [] wideip_rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_wideip_rule", new object[] {
			wide_ips,
			wideip_rules}, callback, asyncState);
	}
	public void Endadd_wideip_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	public void create(
		string [] wide_ips,
		GlobalLBLBMethod [] lb_methods,
		GlobalLBWideIPWideIPPool [] [] wideip_pools,
		GlobalLBWideIPWideIPRule [] [] wideip_rules
	) {
		this.Invoke("create", new object [] {
				wide_ips,
				lb_methods,
				wideip_pools,
				wideip_rules});

	}
	public System.IAsyncResult Begincreate(string [] wide_ips,GlobalLBLBMethod [] lb_methods,GlobalLBWideIPWideIPPool [] [] wideip_pools,GlobalLBWideIPWideIPRule [] [] wideip_rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			wide_ips,
			lb_methods,
			wideip_pools,
			wideip_rules}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_wideips
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	public void delete_all_wideips(

	) {
		this.Invoke("delete_all_wideips", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_wideips(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_wideips", new object[0], callback, asyncState);
	}
	public void Enddelete_all_wideips(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_wideip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	public void delete_wideip(
		string [] wide_ips
	) {
		this.Invoke("delete_wideip", new object [] {
				wide_ips});

	}
	public System.IAsyncResult Begindelete_wideip(string [] wide_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_wideip", new object[] {
			wide_ips}, callback, asyncState);
	}
	public void Enddelete_wideip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_alias
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_alias(
		string [] wide_ips
	) {
		object [] results = this.Invoke("get_alias", new object [] {
				wide_ips});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_alias(string [] wide_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_alias", new object[] {
			wide_ips}, callback, asyncState);
	}
	public string [] [] Endget_alias(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBWideIPWideIPStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((GlobalLBWideIPWideIPStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public GlobalLBWideIPWideIPStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBWideIPWideIPStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_application
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_application(
		string [] wide_ips
	) {
		object [] results = this.Invoke("get_application", new object [] {
				wide_ips});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_application(string [] wide_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_application", new object[] {
			wide_ips}, callback, asyncState);
	}
	public string [] Endget_application(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] wide_ips
	) {
		object [] results = this.Invoke("get_description", new object [] {
				wide_ips});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] wide_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			wide_ips}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_enabled_state(
		string [] wide_ips
	) {
		object [] results = this.Invoke("get_enabled_state", new object [] {
				wide_ips});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_enabled_state(string [] wide_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_enabled_state", new object[] {
			wide_ips}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ipv6_no_error_negative_ttl
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_ipv6_no_error_negative_ttl(
		string [] wide_ips
	) {
		object [] results = this.Invoke("get_ipv6_no_error_negative_ttl", new object [] {
				wide_ips});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_ipv6_no_error_negative_ttl(string [] wide_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ipv6_no_error_negative_ttl", new object[] {
			wide_ips}, callback, asyncState);
	}
	public long [] Endget_ipv6_no_error_negative_ttl(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ipv6_no_error_response_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_ipv6_no_error_response_state(
		string [] wide_ips
	) {
		object [] results = this.Invoke("get_ipv6_no_error_response_state", new object [] {
				wide_ips});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_ipv6_no_error_response_state(string [] wide_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ipv6_no_error_response_state", new object[] {
			wide_ips}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_ipv6_no_error_response_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_last_resort_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_last_resort_pool(
		string [] wide_ips
	) {
		object [] results = this.Invoke("get_last_resort_pool", new object [] {
				wide_ips});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_last_resort_pool(string [] wide_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_last_resort_pool", new object[] {
			wide_ips}, callback, asyncState);
	}
	public string [] Endget_last_resort_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_lb_decision_log_verbosity
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBWideIPLBDecisionLogVerbosity [] [] get_lb_decision_log_verbosity(
		string [] wide_ips
	) {
		object [] results = this.Invoke("get_lb_decision_log_verbosity", new object [] {
				wide_ips});
		return ((GlobalLBWideIPLBDecisionLogVerbosity [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_lb_decision_log_verbosity(string [] wide_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_lb_decision_log_verbosity", new object[] {
			wide_ips}, callback, asyncState);
	}
	public GlobalLBWideIPLBDecisionLogVerbosity [] [] Endget_lb_decision_log_verbosity(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBWideIPLBDecisionLogVerbosity [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_lb_method
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBLBMethod [] get_lb_method(
		string [] wide_ips
	) {
		object [] results = this.Invoke("get_lb_method", new object [] {
				wide_ips});
		return ((GlobalLBLBMethod [])(results[0]));
	}
	public System.IAsyncResult Beginget_lb_method(string [] wide_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_lb_method", new object[] {
			wide_ips}, callback, asyncState);
	}
	public GlobalLBLBMethod [] Endget_lb_method(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBLBMethod [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
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
	// get_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_metadata(
		string [] wide_ips
	) {
		object [] results = this.Invoke("get_metadata", new object [] {
				wide_ips});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata(string [] wide_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_metadata", new object[] {
			wide_ips}, callback, asyncState);
	}
	public string [] [] Endget_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_metadata_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_metadata_description(
		string [] wide_ips,
		string [] [] names
	) {
		object [] results = this.Invoke("get_metadata_description", new object [] {
				wide_ips,
				names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata_description(string [] wide_ips,string [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_metadata_description", new object[] {
			wide_ips,
			names}, callback, asyncState);
	}
	public string [] [] Endget_metadata_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_metadata_persistence
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonMetadataPersistence [] [] get_metadata_persistence(
		string [] wide_ips,
		string [] [] names
	) {
		object [] results = this.Invoke("get_metadata_persistence", new object [] {
				wide_ips,
				names});
		return ((CommonMetadataPersistence [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata_persistence(string [] wide_ips,string [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_metadata_persistence", new object[] {
			wide_ips,
			names}, callback, asyncState);
	}
	public CommonMetadataPersistence [] [] Endget_metadata_persistence(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonMetadataPersistence [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_metadata_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_metadata_value(
		string [] wide_ips,
		string [] [] names
	) {
		object [] results = this.Invoke("get_metadata_value", new object [] {
				wide_ips,
				names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata_value(string [] wide_ips,string [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_metadata_value", new object[] {
			wide_ips,
			names}, callback, asyncState);
	}
	public string [] [] Endget_metadata_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_object_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonObjectStatus [] get_object_status(
		string [] wide_ips
	) {
		object [] results = this.Invoke("get_object_status", new object [] {
				wide_ips});
		return ((CommonObjectStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_object_status(string [] wide_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_object_status", new object[] {
			wide_ips}, callback, asyncState);
	}
	public CommonObjectStatus [] Endget_object_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonObjectStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_persistence_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_persistence_state(
		string [] wide_ips
	) {
		object [] results = this.Invoke("get_persistence_state", new object [] {
				wide_ips});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_persistence_state(string [] wide_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_persistence_state", new object[] {
			wide_ips}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_persistence_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_persistence_ttl
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_persistence_ttl(
		string [] wide_ips
	) {
		object [] results = this.Invoke("get_persistence_ttl", new object [] {
				wide_ips});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_persistence_ttl(string [] wide_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_persistence_ttl", new object[] {
			wide_ips}, callback, asyncState);
	}
	public long [] Endget_persistence_ttl(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBWideIPWideIPStatistics get_statistics(
		string [] wide_ips
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				wide_ips});
		return ((GlobalLBWideIPWideIPStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] wide_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			wide_ips}, callback, asyncState);
	}
	public GlobalLBWideIPWideIPStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBWideIPWideIPStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
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
	// get_wideip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_wideip(
		string [] aliases
	) {
		object [] results = this.Invoke("get_wideip", new object [] {
				aliases});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_wideip(string [] aliases, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_wideip", new object[] {
			aliases}, callback, asyncState);
	}
	public string [] [] Endget_wideip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_wideip_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBWideIPWideIPPool [] [] get_wideip_pool(
		string [] wide_ips
	) {
		object [] results = this.Invoke("get_wideip_pool", new object [] {
				wide_ips});
		return ((GlobalLBWideIPWideIPPool [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_wideip_pool(string [] wide_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_wideip_pool", new object[] {
			wide_ips}, callback, asyncState);
	}
	public GlobalLBWideIPWideIPPool [] [] Endget_wideip_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBWideIPWideIPPool [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_wideip_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBWideIPWideIPRule [] [] get_wideip_rule(
		string [] wide_ips
	) {
		object [] results = this.Invoke("get_wideip_rule", new object [] {
				wide_ips});
		return ((GlobalLBWideIPWideIPRule [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_wideip_rule(string [] wide_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_wideip_rule", new object[] {
			wide_ips}, callback, asyncState);
	}
	public GlobalLBWideIPWideIPRule [] [] Endget_wideip_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBWideIPWideIPRule [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// remove_alias
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	public void remove_alias(
		string [] wide_ips,
		string [] [] aliases
	) {
		this.Invoke("remove_alias", new object [] {
				wide_ips,
				aliases});

	}
	public System.IAsyncResult Beginremove_alias(string [] wide_ips,string [] [] aliases, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_alias", new object[] {
			wide_ips,
			aliases}, callback, asyncState);
	}
	public void Endremove_alias(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_aliases
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	public void remove_all_aliases(
		string [] wide_ips
	) {
		this.Invoke("remove_all_aliases", new object [] {
				wide_ips});

	}
	public System.IAsyncResult Beginremove_all_aliases(string [] wide_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_aliases", new object[] {
			wide_ips}, callback, asyncState);
	}
	public void Endremove_all_aliases(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	public void remove_all_metadata(
		string [] wide_ips
	) {
		this.Invoke("remove_all_metadata", new object [] {
				wide_ips});

	}
	public System.IAsyncResult Beginremove_all_metadata(string [] wide_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_metadata", new object[] {
			wide_ips}, callback, asyncState);
	}
	public void Endremove_all_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_wideip_pools
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	public void remove_all_wideip_pools(
		string [] wide_ips
	) {
		this.Invoke("remove_all_wideip_pools", new object [] {
				wide_ips});

	}
	public System.IAsyncResult Beginremove_all_wideip_pools(string [] wide_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_wideip_pools", new object[] {
			wide_ips}, callback, asyncState);
	}
	public void Endremove_all_wideip_pools(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_wideip_rules
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	public void remove_all_wideip_rules(
		string [] wide_ips
	) {
		this.Invoke("remove_all_wideip_rules", new object [] {
				wide_ips});

	}
	public System.IAsyncResult Beginremove_all_wideip_rules(string [] wide_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_wideip_rules", new object[] {
			wide_ips}, callback, asyncState);
	}
	public void Endremove_all_wideip_rules(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	public void remove_metadata(
		string [] wide_ips,
		string [] [] names
	) {
		this.Invoke("remove_metadata", new object [] {
				wide_ips,
				names});

	}
	public System.IAsyncResult Beginremove_metadata(string [] wide_ips,string [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_metadata", new object[] {
			wide_ips,
			names}, callback, asyncState);
	}
	public void Endremove_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_wideip_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	public void remove_wideip_pool(
		string [] wide_ips,
		GlobalLBWideIPWideIPPool [] [] wideip_pools
	) {
		this.Invoke("remove_wideip_pool", new object [] {
				wide_ips,
				wideip_pools});

	}
	public System.IAsyncResult Beginremove_wideip_pool(string [] wide_ips,GlobalLBWideIPWideIPPool [] [] wideip_pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_wideip_pool", new object[] {
			wide_ips,
			wideip_pools}, callback, asyncState);
	}
	public void Endremove_wideip_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_wideip_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	public void remove_wideip_rule(
		string [] wide_ips,
		GlobalLBWideIPWideIPRule [] [] wideip_rules
	) {
		this.Invoke("remove_wideip_rule", new object [] {
				wide_ips,
				wideip_rules});

	}
	public System.IAsyncResult Beginremove_wideip_rule(string [] wide_ips,GlobalLBWideIPWideIPRule [] [] wideip_rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_wideip_rule", new object[] {
			wide_ips,
			wideip_rules}, callback, asyncState);
	}
	public void Endremove_wideip_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_application
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	public void reset_application(
		string [] wide_ips
	) {
		this.Invoke("reset_application", new object [] {
				wide_ips});

	}
	public System.IAsyncResult Beginreset_application(string [] wide_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_application", new object[] {
			wide_ips}, callback, asyncState);
	}
	public void Endreset_application(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	public void reset_statistics(
		string [] wide_ips
	) {
		this.Invoke("reset_statistics", new object [] {
				wide_ips});

	}
	public System.IAsyncResult Beginreset_statistics(string [] wide_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics", new object[] {
			wide_ips}, callback, asyncState);
	}
	public void Endreset_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_application
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	public void set_application(
		string [] wide_ips,
		string [] applications
	) {
		this.Invoke("set_application", new object [] {
				wide_ips,
				applications});

	}
	public System.IAsyncResult Beginset_application(string [] wide_ips,string [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_application", new object[] {
			wide_ips,
			applications}, callback, asyncState);
	}
	public void Endset_application(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	public void set_description(
		string [] wide_ips,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				wide_ips,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] wide_ips,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			wide_ips,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	public void set_enabled_state(
		string [] wide_ips,
		CommonEnabledState [] states
	) {
		this.Invoke("set_enabled_state", new object [] {
				wide_ips,
				states});

	}
	public System.IAsyncResult Beginset_enabled_state(string [] wide_ips,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_enabled_state", new object[] {
			wide_ips,
			states}, callback, asyncState);
	}
	public void Endset_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ipv6_no_error_negative_ttl
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	public void set_ipv6_no_error_negative_ttl(
		string [] wide_ips,
		long [] values
	) {
		this.Invoke("set_ipv6_no_error_negative_ttl", new object [] {
				wide_ips,
				values});

	}
	public System.IAsyncResult Beginset_ipv6_no_error_negative_ttl(string [] wide_ips,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ipv6_no_error_negative_ttl", new object[] {
			wide_ips,
			values}, callback, asyncState);
	}
	public void Endset_ipv6_no_error_negative_ttl(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ipv6_no_error_response_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	public void set_ipv6_no_error_response_state(
		string [] wide_ips,
		CommonEnabledState [] states
	) {
		this.Invoke("set_ipv6_no_error_response_state", new object [] {
				wide_ips,
				states});

	}
	public System.IAsyncResult Beginset_ipv6_no_error_response_state(string [] wide_ips,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ipv6_no_error_response_state", new object[] {
			wide_ips,
			states}, callback, asyncState);
	}
	public void Endset_ipv6_no_error_response_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_last_resort_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	public void set_last_resort_pool(
		string [] wide_ips,
		string [] pool_names
	) {
		this.Invoke("set_last_resort_pool", new object [] {
				wide_ips,
				pool_names});

	}
	public System.IAsyncResult Beginset_last_resort_pool(string [] wide_ips,string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_last_resort_pool", new object[] {
			wide_ips,
			pool_names}, callback, asyncState);
	}
	public void Endset_last_resort_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_lb_decision_log_verbosity
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	public void set_lb_decision_log_verbosity(
		string [] wide_ips,
		GlobalLBWideIPLBDecisionLogVerbosity [] [] verbosities
	) {
		this.Invoke("set_lb_decision_log_verbosity", new object [] {
				wide_ips,
				verbosities});

	}
	public System.IAsyncResult Beginset_lb_decision_log_verbosity(string [] wide_ips,GlobalLBWideIPLBDecisionLogVerbosity [] [] verbosities, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_lb_decision_log_verbosity", new object[] {
			wide_ips,
			verbosities}, callback, asyncState);
	}
	public void Endset_lb_decision_log_verbosity(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_lb_method
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	public void set_lb_method(
		string [] wide_ips,
		GlobalLBLBMethod [] lb_methods
	) {
		this.Invoke("set_lb_method", new object [] {
				wide_ips,
				lb_methods});

	}
	public System.IAsyncResult Beginset_lb_method(string [] wide_ips,GlobalLBLBMethod [] lb_methods, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_lb_method", new object[] {
			wide_ips,
			lb_methods}, callback, asyncState);
	}
	public void Endset_lb_method(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_metadata_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	public void set_metadata_description(
		string [] wide_ips,
		string [] [] names,
		string [] [] descriptions
	) {
		this.Invoke("set_metadata_description", new object [] {
				wide_ips,
				names,
				descriptions});

	}
	public System.IAsyncResult Beginset_metadata_description(string [] wide_ips,string [] [] names,string [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_metadata_description", new object[] {
			wide_ips,
			names,
			descriptions}, callback, asyncState);
	}
	public void Endset_metadata_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_metadata_persistence
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	public void set_metadata_persistence(
		string [] wide_ips,
		string [] [] names,
		CommonMetadataPersistence [] [] values
	) {
		this.Invoke("set_metadata_persistence", new object [] {
				wide_ips,
				names,
				values});

	}
	public System.IAsyncResult Beginset_metadata_persistence(string [] wide_ips,string [] [] names,CommonMetadataPersistence [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_metadata_persistence", new object[] {
			wide_ips,
			names,
			values}, callback, asyncState);
	}
	public void Endset_metadata_persistence(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_metadata_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	public void set_metadata_value(
		string [] wide_ips,
		string [] [] names,
		string [] [] values
	) {
		this.Invoke("set_metadata_value", new object [] {
				wide_ips,
				names,
				values});

	}
	public System.IAsyncResult Beginset_metadata_value(string [] wide_ips,string [] [] names,string [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_metadata_value", new object[] {
			wide_ips,
			names,
			values}, callback, asyncState);
	}
	public void Endset_metadata_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_persistence_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	public void set_persistence_state(
		string [] wide_ips,
		CommonEnabledState [] states
	) {
		this.Invoke("set_persistence_state", new object [] {
				wide_ips,
				states});

	}
	public System.IAsyncResult Beginset_persistence_state(string [] wide_ips,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_persistence_state", new object[] {
			wide_ips,
			states}, callback, asyncState);
	}
	public void Endset_persistence_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_persistence_ttl
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIP", 
		RequestNamespace="urn:iControl:GlobalLB/WideIP", ResponseNamespace="urn:iControl:GlobalLB/WideIP")]
	public void set_persistence_ttl(
		string [] wide_ips,
		long [] values
	) {
		this.Invoke("set_persistence_ttl", new object [] {
				wide_ips,
				values});

	}
	public System.IAsyncResult Beginset_persistence_ttl(string [] wide_ips,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_persistence_ttl", new object[] {
			wide_ips,
			values}, callback, asyncState);
	}
	public void Endset_persistence_ttl(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.WideIP.LBDecisionLogVerbosity", Namespace = "urn:iControl")]
	public enum GlobalLBWideIPLBDecisionLogVerbosity
	{
		LB_DECISION_LOG_UNKNOWN,
		LB_DECISION_LOG_NONE,
		LB_DECISION_POOL_SELECTION,
		LB_DECISION_POOL_TRAVERSAL,
		LB_DECISION_PM_SELECTION,
		LB_DECISION_PM_TRAVERSAL,
		LB_DECISION_LOG_ALL,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.WideIP.WideIPPool", Namespace = "urn:iControl")]
	public partial class GlobalLBWideIPWideIPPool
	{
		private string pool_nameField;
		public string pool_name
		{
			get { return this.pool_nameField; }
			set { this.pool_nameField = value; }
		}
		private long orderField;
		public long order
		{
			get { return this.orderField; }
			set { this.orderField = value; }
		}
		private long ratioField;
		public long ratio
		{
			get { return this.ratioField; }
			set { this.ratioField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.WideIP.WideIPRule", Namespace = "urn:iControl")]
	public partial class GlobalLBWideIPWideIPRule
	{
		private string rule_nameField;
		public string rule_name
		{
			get { return this.rule_nameField; }
			set { this.rule_nameField = value; }
		}
		private long priorityField;
		public long priority
		{
			get { return this.priorityField; }
			set { this.priorityField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.WideIP.WideIPStatisticEntry", Namespace = "urn:iControl")]
	public partial class GlobalLBWideIPWideIPStatisticEntry
	{
		private string wide_ipField;
		public string wide_ip
		{
			get { return this.wide_ipField; }
			set { this.wide_ipField = value; }
		}
		private CommonStatistic [] statisticsField;
		public CommonStatistic [] statistics
		{
			get { return this.statisticsField; }
			set { this.statisticsField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.WideIP.WideIPStatistics", Namespace = "urn:iControl")]
	public partial class GlobalLBWideIPWideIPStatistics
	{
		private GlobalLBWideIPWideIPStatisticEntry [] statisticsField;
		public GlobalLBWideIPWideIPStatisticEntry [] statistics
		{
			get { return this.statisticsField; }
			set { this.statisticsField = value; }
		}
		private CommonTimeStamp time_stampField;
		public CommonTimeStamp time_stamp
		{
			get { return this.time_stampField; }
			set { this.time_stampField = value; }
		}
	};

}
