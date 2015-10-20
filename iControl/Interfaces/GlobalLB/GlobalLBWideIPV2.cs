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
	[System.Web.Services.WebServiceBindingAttribute(Name="GlobalLB.WideIPV2Binding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBWideIPID))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBPoolID))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBWideIPV2WideIPStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonObjectStatus))]
	public partial class GlobalLBWideIPV2 : iControlInterface {
		public GlobalLBWideIPV2() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_alias
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	public void add_alias(
		GlobalLBWideIPID [] wide_ips,
		string [] [] aliases
	) {
		this.Invoke("add_alias", new object [] {
				wide_ips,
				aliases});

	}
	public System.IAsyncResult Beginadd_alias(GlobalLBWideIPID [] wide_ips,string [] [] aliases, System.AsyncCallback callback, object asyncState) {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	public void add_metadata(
		GlobalLBWideIPID [] wide_ips,
		string [] [] names,
		string [] [] values
	) {
		this.Invoke("add_metadata", new object [] {
				wide_ips,
				names,
				values});

	}
	public System.IAsyncResult Beginadd_metadata(GlobalLBWideIPID [] wide_ips,string [] [] names,string [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_metadata", new object[] {
			wide_ips,
			names,
			values}, callback, asyncState);
	}
	public void Endadd_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_wide_ip_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	public void add_wide_ip_pool(
		GlobalLBWideIPID [] wide_ips,
		GlobalLBPoolID [] [] wide_ip_pools,
		long [] [] orders,
		long [] [] ratios
	) {
		this.Invoke("add_wide_ip_pool", new object [] {
				wide_ips,
				wide_ip_pools,
				orders,
				ratios});

	}
	public System.IAsyncResult Beginadd_wide_ip_pool(GlobalLBWideIPID [] wide_ips,GlobalLBPoolID [] [] wide_ip_pools,long [] [] orders,long [] [] ratios, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_wide_ip_pool", new object[] {
			wide_ips,
			wide_ip_pools,
			orders,
			ratios}, callback, asyncState);
	}
	public void Endadd_wide_ip_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_wide_ip_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	public void add_wide_ip_rule(
		GlobalLBWideIPID [] wide_ips,
		string [] [] wide_ip_rules,
		long [] [] priorities
	) {
		this.Invoke("add_wide_ip_rule", new object [] {
				wide_ips,
				wide_ip_rules,
				priorities});

	}
	public System.IAsyncResult Beginadd_wide_ip_rule(GlobalLBWideIPID [] wide_ips,string [] [] wide_ip_rules,long [] [] priorities, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_wide_ip_rule", new object[] {
			wide_ips,
			wide_ip_rules,
			priorities}, callback, asyncState);
	}
	public void Endadd_wide_ip_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	public void create(
		GlobalLBWideIPID [] wide_ips,
		GlobalLBLBMethod [] lb_methods
	) {
		this.Invoke("create", new object [] {
				wide_ips,
				lb_methods});

	}
	public System.IAsyncResult Begincreate(GlobalLBWideIPID [] wide_ips,GlobalLBLBMethod [] lb_methods, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			wide_ips,
			lb_methods}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_wide_ips
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	public void delete_all_wide_ips(

	) {
		this.Invoke("delete_all_wide_ips", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_wide_ips(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_wide_ips", new object[0], callback, asyncState);
	}
	public void Enddelete_all_wide_ips(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_wide_ip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	public void delete_wide_ip(
		GlobalLBWideIPID [] wide_ips
	) {
		this.Invoke("delete_wide_ip", new object [] {
				wide_ips});

	}
	public System.IAsyncResult Begindelete_wide_ip(GlobalLBWideIPID [] wide_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_wide_ip", new object[] {
			wide_ips}, callback, asyncState);
	}
	public void Enddelete_wide_ip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_alias
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_alias(
		GlobalLBWideIPID [] wide_ips
	) {
		object [] results = this.Invoke("get_alias", new object [] {
				wide_ips});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_alias(GlobalLBWideIPID [] wide_ips, System.AsyncCallback callback, object asyncState) {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBWideIPV2WideIPStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((GlobalLBWideIPV2WideIPStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public GlobalLBWideIPV2WideIPStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBWideIPV2WideIPStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		GlobalLBWideIPID [] wide_ips
	) {
		object [] results = this.Invoke("get_description", new object [] {
				wide_ips});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(GlobalLBWideIPID [] wide_ips, System.AsyncCallback callback, object asyncState) {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_enabled_state(
		GlobalLBWideIPID [] wide_ips
	) {
		object [] results = this.Invoke("get_enabled_state", new object [] {
				wide_ips});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_enabled_state(GlobalLBWideIPID [] wide_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_enabled_state", new object[] {
			wide_ips}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_failure_response_return_code
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBDNSReturnCode [] get_failure_response_return_code(
		GlobalLBWideIPID [] wide_ips
	) {
		object [] results = this.Invoke("get_failure_response_return_code", new object [] {
				wide_ips});
		return ((GlobalLBDNSReturnCode [])(results[0]));
	}
	public System.IAsyncResult Beginget_failure_response_return_code(GlobalLBWideIPID [] wide_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_failure_response_return_code", new object[] {
			wide_ips}, callback, asyncState);
	}
	public GlobalLBDNSReturnCode [] Endget_failure_response_return_code(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBDNSReturnCode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_failure_response_return_code_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_failure_response_return_code_state(
		GlobalLBWideIPID [] wide_ips
	) {
		object [] results = this.Invoke("get_failure_response_return_code_state", new object [] {
				wide_ips});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_failure_response_return_code_state(GlobalLBWideIPID [] wide_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_failure_response_return_code_state", new object[] {
			wide_ips}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_failure_response_return_code_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_failure_response_return_code_ttl
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_failure_response_return_code_ttl(
		GlobalLBWideIPID [] wide_ips
	) {
		object [] results = this.Invoke("get_failure_response_return_code_ttl", new object [] {
				wide_ips});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_failure_response_return_code_ttl(GlobalLBWideIPID [] wide_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_failure_response_return_code_ttl", new object[] {
			wide_ips}, callback, asyncState);
	}
	public long [] Endget_failure_response_return_code_ttl(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_last_resort_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBPoolID [] get_last_resort_pool(
		GlobalLBWideIPID [] wide_ips
	) {
		object [] results = this.Invoke("get_last_resort_pool", new object [] {
				wide_ips});
		return ((GlobalLBPoolID [])(results[0]));
	}
	public System.IAsyncResult Beginget_last_resort_pool(GlobalLBWideIPID [] wide_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_last_resort_pool", new object[] {
			wide_ips}, callback, asyncState);
	}
	public GlobalLBPoolID [] Endget_last_resort_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBPoolID [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_lb_decision_log_verbosity
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBLBDecisionLogVerbosity [] [] get_lb_decision_log_verbosity(
		GlobalLBWideIPID [] wide_ips
	) {
		object [] results = this.Invoke("get_lb_decision_log_verbosity", new object [] {
				wide_ips});
		return ((GlobalLBLBDecisionLogVerbosity [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_lb_decision_log_verbosity(GlobalLBWideIPID [] wide_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_lb_decision_log_verbosity", new object[] {
			wide_ips}, callback, asyncState);
	}
	public GlobalLBLBDecisionLogVerbosity [] [] Endget_lb_decision_log_verbosity(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBLBDecisionLogVerbosity [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_lb_method
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBLBMethod [] get_lb_method(
		GlobalLBWideIPID [] wide_ips
	) {
		object [] results = this.Invoke("get_lb_method", new object [] {
				wide_ips});
		return ((GlobalLBLBMethod [])(results[0]));
	}
	public System.IAsyncResult Beginget_lb_method(GlobalLBWideIPID [] wide_ips, System.AsyncCallback callback, object asyncState) {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBWideIPID [] get_list(

	) {
		object [] results = this.Invoke("get_list", new object [0]);
		return ((GlobalLBWideIPID [])(results[0]));
	}
	public System.IAsyncResult Beginget_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_list", new object[0], callback, asyncState);
	}
	public GlobalLBWideIPID [] Endget_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBWideIPID [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list_by_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBWideIPID [] [] get_list_by_type(
		GlobalLBGTMQueryType [] types
	) {
		object [] results = this.Invoke("get_list_by_type", new object [] {
				types});
		return ((GlobalLBWideIPID [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_list_by_type(GlobalLBGTMQueryType [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_list_by_type", new object[] {
			types}, callback, asyncState);
	}
	public GlobalLBWideIPID [] [] Endget_list_by_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBWideIPID [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_metadata(
		GlobalLBWideIPID [] wide_ips
	) {
		object [] results = this.Invoke("get_metadata", new object [] {
				wide_ips});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata(GlobalLBWideIPID [] wide_ips, System.AsyncCallback callback, object asyncState) {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_metadata_description(
		GlobalLBWideIPID [] wide_ips,
		string [] [] names
	) {
		object [] results = this.Invoke("get_metadata_description", new object [] {
				wide_ips,
				names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata_description(GlobalLBWideIPID [] wide_ips,string [] [] names, System.AsyncCallback callback, object asyncState) {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonMetadataPersistence [] [] get_metadata_persistence(
		GlobalLBWideIPID [] wide_ips,
		string [] [] names
	) {
		object [] results = this.Invoke("get_metadata_persistence", new object [] {
				wide_ips,
				names});
		return ((CommonMetadataPersistence [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata_persistence(GlobalLBWideIPID [] wide_ips,string [] [] names, System.AsyncCallback callback, object asyncState) {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_metadata_value(
		GlobalLBWideIPID [] wide_ips,
		string [] [] names
	) {
		object [] results = this.Invoke("get_metadata_value", new object [] {
				wide_ips,
				names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata_value(GlobalLBWideIPID [] wide_ips,string [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_metadata_value", new object[] {
			wide_ips,
			names}, callback, asyncState);
	}
	public string [] [] Endget_metadata_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_minimal_response_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_minimal_response_state(
		GlobalLBWideIPID [] wide_ips
	) {
		object [] results = this.Invoke("get_minimal_response_state", new object [] {
				wide_ips});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_minimal_response_state(GlobalLBWideIPID [] wide_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_minimal_response_state", new object[] {
			wide_ips}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_minimal_response_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_object_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonObjectStatus [] get_object_status(
		GlobalLBWideIPID [] wide_ips
	) {
		object [] results = this.Invoke("get_object_status", new object [] {
				wide_ips});
		return ((CommonObjectStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_object_status(GlobalLBWideIPID [] wide_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_object_status", new object[] {
			wide_ips}, callback, asyncState);
	}
	public CommonObjectStatus [] Endget_object_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonObjectStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_persistence_cidr_ipv4
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_persistence_cidr_ipv4(
		GlobalLBWideIPID [] wide_ips
	) {
		object [] results = this.Invoke("get_persistence_cidr_ipv4", new object [] {
				wide_ips});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_persistence_cidr_ipv4(GlobalLBWideIPID [] wide_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_persistence_cidr_ipv4", new object[] {
			wide_ips}, callback, asyncState);
	}
	public long [] Endget_persistence_cidr_ipv4(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_persistence_cidr_ipv6
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_persistence_cidr_ipv6(
		GlobalLBWideIPID [] wide_ips
	) {
		object [] results = this.Invoke("get_persistence_cidr_ipv6", new object [] {
				wide_ips});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_persistence_cidr_ipv6(GlobalLBWideIPID [] wide_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_persistence_cidr_ipv6", new object[] {
			wide_ips}, callback, asyncState);
	}
	public long [] Endget_persistence_cidr_ipv6(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_persistence_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_persistence_state(
		GlobalLBWideIPID [] wide_ips
	) {
		object [] results = this.Invoke("get_persistence_state", new object [] {
				wide_ips});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_persistence_state(GlobalLBWideIPID [] wide_ips, System.AsyncCallback callback, object asyncState) {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_persistence_ttl(
		GlobalLBWideIPID [] wide_ips
	) {
		object [] results = this.Invoke("get_persistence_ttl", new object [] {
				wide_ips});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_persistence_ttl(GlobalLBWideIPID [] wide_ips, System.AsyncCallback callback, object asyncState) {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBWideIPV2WideIPStatistics get_statistics(
		GlobalLBWideIPID [] wide_ips
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				wide_ips});
		return ((GlobalLBWideIPV2WideIPStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(GlobalLBWideIPID [] wide_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			wide_ips}, callback, asyncState);
	}
	public GlobalLBWideIPV2WideIPStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBWideIPV2WideIPStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
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
	// get_wide_ip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBWideIPID [] [] get_wide_ip(
		string [] aliases
	) {
		object [] results = this.Invoke("get_wide_ip", new object [] {
				aliases});
		return ((GlobalLBWideIPID [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_wide_ip(string [] aliases, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_wide_ip", new object[] {
			aliases}, callback, asyncState);
	}
	public GlobalLBWideIPID [] [] Endget_wide_ip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBWideIPID [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_wide_ip_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBPoolID [] [] get_wide_ip_pool(
		GlobalLBWideIPID [] wide_ips
	) {
		object [] results = this.Invoke("get_wide_ip_pool", new object [] {
				wide_ips});
		return ((GlobalLBPoolID [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_wide_ip_pool(GlobalLBWideIPID [] wide_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_wide_ip_pool", new object[] {
			wide_ips}, callback, asyncState);
	}
	public GlobalLBPoolID [] [] Endget_wide_ip_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBPoolID [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_wide_ip_pool_order
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_wide_ip_pool_order(
		GlobalLBWideIPID [] wide_ips,
		GlobalLBPoolID [] [] wide_ip_pools
	) {
		object [] results = this.Invoke("get_wide_ip_pool_order", new object [] {
				wide_ips,
				wide_ip_pools});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_wide_ip_pool_order(GlobalLBWideIPID [] wide_ips,GlobalLBPoolID [] [] wide_ip_pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_wide_ip_pool_order", new object[] {
			wide_ips,
			wide_ip_pools}, callback, asyncState);
	}
	public long [] [] Endget_wide_ip_pool_order(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_wide_ip_pool_ratio
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_wide_ip_pool_ratio(
		GlobalLBWideIPID [] wide_ips,
		GlobalLBPoolID [] [] wide_ip_pools
	) {
		object [] results = this.Invoke("get_wide_ip_pool_ratio", new object [] {
				wide_ips,
				wide_ip_pools});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_wide_ip_pool_ratio(GlobalLBWideIPID [] wide_ips,GlobalLBPoolID [] [] wide_ip_pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_wide_ip_pool_ratio", new object[] {
			wide_ips,
			wide_ip_pools}, callback, asyncState);
	}
	public long [] [] Endget_wide_ip_pool_ratio(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_wide_ip_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_wide_ip_rule(
		GlobalLBWideIPID [] wide_ips
	) {
		object [] results = this.Invoke("get_wide_ip_rule", new object [] {
				wide_ips});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_wide_ip_rule(GlobalLBWideIPID [] wide_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_wide_ip_rule", new object[] {
			wide_ips}, callback, asyncState);
	}
	public string [] [] Endget_wide_ip_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_wide_ip_rule_priority
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_wide_ip_rule_priority(
		GlobalLBWideIPID [] wide_ips,
		string [] [] wide_ip_rules
	) {
		object [] results = this.Invoke("get_wide_ip_rule_priority", new object [] {
				wide_ips,
				wide_ip_rules});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_wide_ip_rule_priority(GlobalLBWideIPID [] wide_ips,string [] [] wide_ip_rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_wide_ip_rule_priority", new object[] {
			wide_ips,
			wide_ip_rules}, callback, asyncState);
	}
	public long [] [] Endget_wide_ip_rule_priority(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// remove_alias
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	public void remove_alias(
		GlobalLBWideIPID [] wide_ips,
		string [] [] aliases
	) {
		this.Invoke("remove_alias", new object [] {
				wide_ips,
				aliases});

	}
	public System.IAsyncResult Beginremove_alias(GlobalLBWideIPID [] wide_ips,string [] [] aliases, System.AsyncCallback callback, object asyncState) {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	public void remove_all_aliases(
		GlobalLBWideIPID [] wide_ips
	) {
		this.Invoke("remove_all_aliases", new object [] {
				wide_ips});

	}
	public System.IAsyncResult Beginremove_all_aliases(GlobalLBWideIPID [] wide_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_aliases", new object[] {
			wide_ips}, callback, asyncState);
	}
	public void Endremove_all_aliases(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	public void remove_all_metadata(
		GlobalLBWideIPID [] wide_ips
	) {
		this.Invoke("remove_all_metadata", new object [] {
				wide_ips});

	}
	public System.IAsyncResult Beginremove_all_metadata(GlobalLBWideIPID [] wide_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_metadata", new object[] {
			wide_ips}, callback, asyncState);
	}
	public void Endremove_all_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_wide_ip_pools
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	public void remove_all_wide_ip_pools(
		GlobalLBWideIPID [] wide_ips
	) {
		this.Invoke("remove_all_wide_ip_pools", new object [] {
				wide_ips});

	}
	public System.IAsyncResult Beginremove_all_wide_ip_pools(GlobalLBWideIPID [] wide_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_wide_ip_pools", new object[] {
			wide_ips}, callback, asyncState);
	}
	public void Endremove_all_wide_ip_pools(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_wide_ip_rules
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	public void remove_all_wide_ip_rules(
		GlobalLBWideIPID [] wide_ips
	) {
		this.Invoke("remove_all_wide_ip_rules", new object [] {
				wide_ips});

	}
	public System.IAsyncResult Beginremove_all_wide_ip_rules(GlobalLBWideIPID [] wide_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_wide_ip_rules", new object[] {
			wide_ips}, callback, asyncState);
	}
	public void Endremove_all_wide_ip_rules(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	public void remove_metadata(
		GlobalLBWideIPID [] wide_ips,
		string [] [] names
	) {
		this.Invoke("remove_metadata", new object [] {
				wide_ips,
				names});

	}
	public System.IAsyncResult Beginremove_metadata(GlobalLBWideIPID [] wide_ips,string [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_metadata", new object[] {
			wide_ips,
			names}, callback, asyncState);
	}
	public void Endremove_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_wide_ip_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	public void remove_wide_ip_pool(
		GlobalLBWideIPID [] wide_ips,
		GlobalLBPoolID [] [] wide_ip_pools
	) {
		this.Invoke("remove_wide_ip_pool", new object [] {
				wide_ips,
				wide_ip_pools});

	}
	public System.IAsyncResult Beginremove_wide_ip_pool(GlobalLBWideIPID [] wide_ips,GlobalLBPoolID [] [] wide_ip_pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_wide_ip_pool", new object[] {
			wide_ips,
			wide_ip_pools}, callback, asyncState);
	}
	public void Endremove_wide_ip_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_wide_ip_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	public void remove_wide_ip_rule(
		GlobalLBWideIPID [] wide_ips,
		string [] [] wide_ip_rules
	) {
		this.Invoke("remove_wide_ip_rule", new object [] {
				wide_ips,
				wide_ip_rules});

	}
	public System.IAsyncResult Beginremove_wide_ip_rule(GlobalLBWideIPID [] wide_ips,string [] [] wide_ip_rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_wide_ip_rule", new object[] {
			wide_ips,
			wide_ip_rules}, callback, asyncState);
	}
	public void Endremove_wide_ip_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	public void reset_statistics(
		GlobalLBWideIPID [] wide_ips
	) {
		this.Invoke("reset_statistics", new object [] {
				wide_ips});

	}
	public System.IAsyncResult Beginreset_statistics(GlobalLBWideIPID [] wide_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics", new object[] {
			wide_ips}, callback, asyncState);
	}
	public void Endreset_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	public void set_description(
		GlobalLBWideIPID [] wide_ips,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				wide_ips,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(GlobalLBWideIPID [] wide_ips,string [] descriptions, System.AsyncCallback callback, object asyncState) {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	public void set_enabled_state(
		GlobalLBWideIPID [] wide_ips,
		CommonEnabledState [] states
	) {
		this.Invoke("set_enabled_state", new object [] {
				wide_ips,
				states});

	}
	public System.IAsyncResult Beginset_enabled_state(GlobalLBWideIPID [] wide_ips,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_enabled_state", new object[] {
			wide_ips,
			states}, callback, asyncState);
	}
	public void Endset_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_failure_response_return_code
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	public void set_failure_response_return_code(
		GlobalLBWideIPID [] wide_ips,
		GlobalLBDNSReturnCode [] return_codes
	) {
		this.Invoke("set_failure_response_return_code", new object [] {
				wide_ips,
				return_codes});

	}
	public System.IAsyncResult Beginset_failure_response_return_code(GlobalLBWideIPID [] wide_ips,GlobalLBDNSReturnCode [] return_codes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_failure_response_return_code", new object[] {
			wide_ips,
			return_codes}, callback, asyncState);
	}
	public void Endset_failure_response_return_code(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_failure_response_return_code_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	public void set_failure_response_return_code_state(
		GlobalLBWideIPID [] wide_ips,
		CommonEnabledState [] states
	) {
		this.Invoke("set_failure_response_return_code_state", new object [] {
				wide_ips,
				states});

	}
	public System.IAsyncResult Beginset_failure_response_return_code_state(GlobalLBWideIPID [] wide_ips,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_failure_response_return_code_state", new object[] {
			wide_ips,
			states}, callback, asyncState);
	}
	public void Endset_failure_response_return_code_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_failure_response_return_code_ttl
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	public void set_failure_response_return_code_ttl(
		GlobalLBWideIPID [] wide_ips,
		long [] values
	) {
		this.Invoke("set_failure_response_return_code_ttl", new object [] {
				wide_ips,
				values});

	}
	public System.IAsyncResult Beginset_failure_response_return_code_ttl(GlobalLBWideIPID [] wide_ips,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_failure_response_return_code_ttl", new object[] {
			wide_ips,
			values}, callback, asyncState);
	}
	public void Endset_failure_response_return_code_ttl(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_last_resort_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	public void set_last_resort_pool(
		GlobalLBWideIPID [] wide_ips,
		GlobalLBPoolID [] pools
	) {
		this.Invoke("set_last_resort_pool", new object [] {
				wide_ips,
				pools});

	}
	public System.IAsyncResult Beginset_last_resort_pool(GlobalLBWideIPID [] wide_ips,GlobalLBPoolID [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_last_resort_pool", new object[] {
			wide_ips,
			pools}, callback, asyncState);
	}
	public void Endset_last_resort_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_lb_decision_log_verbosity
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	public void set_lb_decision_log_verbosity(
		GlobalLBWideIPID [] wide_ips,
		GlobalLBLBDecisionLogVerbosity [] [] verbosities
	) {
		this.Invoke("set_lb_decision_log_verbosity", new object [] {
				wide_ips,
				verbosities});

	}
	public System.IAsyncResult Beginset_lb_decision_log_verbosity(GlobalLBWideIPID [] wide_ips,GlobalLBLBDecisionLogVerbosity [] [] verbosities, System.AsyncCallback callback, object asyncState) {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	public void set_lb_method(
		GlobalLBWideIPID [] wide_ips,
		GlobalLBLBMethod [] lb_methods
	) {
		this.Invoke("set_lb_method", new object [] {
				wide_ips,
				lb_methods});

	}
	public System.IAsyncResult Beginset_lb_method(GlobalLBWideIPID [] wide_ips,GlobalLBLBMethod [] lb_methods, System.AsyncCallback callback, object asyncState) {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	public void set_metadata_description(
		GlobalLBWideIPID [] wide_ips,
		string [] [] names,
		string [] [] descriptions
	) {
		this.Invoke("set_metadata_description", new object [] {
				wide_ips,
				names,
				descriptions});

	}
	public System.IAsyncResult Beginset_metadata_description(GlobalLBWideIPID [] wide_ips,string [] [] names,string [] [] descriptions, System.AsyncCallback callback, object asyncState) {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	public void set_metadata_persistence(
		GlobalLBWideIPID [] wide_ips,
		string [] [] names,
		CommonMetadataPersistence [] [] values
	) {
		this.Invoke("set_metadata_persistence", new object [] {
				wide_ips,
				names,
				values});

	}
	public System.IAsyncResult Beginset_metadata_persistence(GlobalLBWideIPID [] wide_ips,string [] [] names,CommonMetadataPersistence [] [] values, System.AsyncCallback callback, object asyncState) {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	public void set_metadata_value(
		GlobalLBWideIPID [] wide_ips,
		string [] [] names,
		string [] [] values
	) {
		this.Invoke("set_metadata_value", new object [] {
				wide_ips,
				names,
				values});

	}
	public System.IAsyncResult Beginset_metadata_value(GlobalLBWideIPID [] wide_ips,string [] [] names,string [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_metadata_value", new object[] {
			wide_ips,
			names,
			values}, callback, asyncState);
	}
	public void Endset_metadata_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_minimal_response_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	public void set_minimal_response_state(
		GlobalLBWideIPID [] wide_ips,
		CommonEnabledState [] states
	) {
		this.Invoke("set_minimal_response_state", new object [] {
				wide_ips,
				states});

	}
	public System.IAsyncResult Beginset_minimal_response_state(GlobalLBWideIPID [] wide_ips,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_minimal_response_state", new object[] {
			wide_ips,
			states}, callback, asyncState);
	}
	public void Endset_minimal_response_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_persistence_cidr_ipv4
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	public void set_persistence_cidr_ipv4(
		GlobalLBWideIPID [] wide_ips,
		long [] values
	) {
		this.Invoke("set_persistence_cidr_ipv4", new object [] {
				wide_ips,
				values});

	}
	public System.IAsyncResult Beginset_persistence_cidr_ipv4(GlobalLBWideIPID [] wide_ips,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_persistence_cidr_ipv4", new object[] {
			wide_ips,
			values}, callback, asyncState);
	}
	public void Endset_persistence_cidr_ipv4(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_persistence_cidr_ipv6
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	public void set_persistence_cidr_ipv6(
		GlobalLBWideIPID [] wide_ips,
		long [] values
	) {
		this.Invoke("set_persistence_cidr_ipv6", new object [] {
				wide_ips,
				values});

	}
	public System.IAsyncResult Beginset_persistence_cidr_ipv6(GlobalLBWideIPID [] wide_ips,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_persistence_cidr_ipv6", new object[] {
			wide_ips,
			values}, callback, asyncState);
	}
	public void Endset_persistence_cidr_ipv6(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_persistence_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	public void set_persistence_state(
		GlobalLBWideIPID [] wide_ips,
		CommonEnabledState [] states
	) {
		this.Invoke("set_persistence_state", new object [] {
				wide_ips,
				states});

	}
	public System.IAsyncResult Beginset_persistence_state(GlobalLBWideIPID [] wide_ips,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	public void set_persistence_ttl(
		GlobalLBWideIPID [] wide_ips,
		long [] values
	) {
		this.Invoke("set_persistence_ttl", new object [] {
				wide_ips,
				values});

	}
	public System.IAsyncResult Beginset_persistence_ttl(GlobalLBWideIPID [] wide_ips,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_persistence_ttl", new object[] {
			wide_ips,
			values}, callback, asyncState);
	}
	public void Endset_persistence_ttl(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_wide_ip_pool_order
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	public void set_wide_ip_pool_order(
		GlobalLBWideIPID [] wide_ips,
		GlobalLBPoolID [] [] wide_ip_pools,
		long [] [] orders
	) {
		this.Invoke("set_wide_ip_pool_order", new object [] {
				wide_ips,
				wide_ip_pools,
				orders});

	}
	public System.IAsyncResult Beginset_wide_ip_pool_order(GlobalLBWideIPID [] wide_ips,GlobalLBPoolID [] [] wide_ip_pools,long [] [] orders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_wide_ip_pool_order", new object[] {
			wide_ips,
			wide_ip_pools,
			orders}, callback, asyncState);
	}
	public void Endset_wide_ip_pool_order(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_wide_ip_pool_ratio
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	public void set_wide_ip_pool_ratio(
		GlobalLBWideIPID [] wide_ips,
		GlobalLBPoolID [] [] wide_ip_pools,
		long [] [] ratios
	) {
		this.Invoke("set_wide_ip_pool_ratio", new object [] {
				wide_ips,
				wide_ip_pools,
				ratios});

	}
	public System.IAsyncResult Beginset_wide_ip_pool_ratio(GlobalLBWideIPID [] wide_ips,GlobalLBPoolID [] [] wide_ip_pools,long [] [] ratios, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_wide_ip_pool_ratio", new object[] {
			wide_ips,
			wide_ip_pools,
			ratios}, callback, asyncState);
	}
	public void Endset_wide_ip_pool_ratio(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_wide_ip_rule_priority
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/WideIPV2", 
		RequestNamespace="urn:iControl:GlobalLB/WideIPV2", ResponseNamespace="urn:iControl:GlobalLB/WideIPV2")]
	public void set_wide_ip_rule_priority(
		GlobalLBWideIPID [] wide_ips,
		string [] [] wide_ip_rules,
		long [] [] priorities
	) {
		this.Invoke("set_wide_ip_rule_priority", new object [] {
				wide_ips,
				wide_ip_rules,
				priorities});

	}
	public System.IAsyncResult Beginset_wide_ip_rule_priority(GlobalLBWideIPID [] wide_ips,string [] [] wide_ip_rules,long [] [] priorities, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_wide_ip_rule_priority", new object[] {
			wide_ips,
			wide_ip_rules,
			priorities}, callback, asyncState);
	}
	public void Endset_wide_ip_rule_priority(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.WideIPV2.WideIPStatisticEntry", Namespace = "urn:iControl")]
	public partial class GlobalLBWideIPV2WideIPStatisticEntry
	{
		private GlobalLBWideIPID wide_ipField;
		public GlobalLBWideIPID wide_ip
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.WideIPV2.WideIPStatistics", Namespace = "urn:iControl")]
	public partial class GlobalLBWideIPV2WideIPStatistics
	{
		private GlobalLBWideIPV2WideIPStatisticEntry [] statisticsField;
		public GlobalLBWideIPV2WideIPStatisticEntry [] statistics
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
