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
	[System.Web.Services.WebServiceBindingAttribute(Name="GlobalLB.PoolV2Binding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBPoolID))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBVirtualServerID))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBPoolV2PoolStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBMetricLimit))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBMonitorRule))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBMonitorRuleV2))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonObjectStatus))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBPoolV2MemberStatistics))]
	public partial class GlobalLBPoolV2 : iControlInterface {
		public GlobalLBPoolV2() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void add_member(
		GlobalLBPoolID [] pools,
		GlobalLBVirtualServerID [] [] members,
		long [] [] orders
	) {
		this.Invoke("add_member", new object [] {
				pools,
				members,
				orders});

	}
	public System.IAsyncResult Beginadd_member(GlobalLBPoolID [] pools,GlobalLBVirtualServerID [] [] members,long [] [] orders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_member", new object[] {
			pools,
			members,
			orders}, callback, asyncState);
	}
	public void Endadd_member(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_member_dependency
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void add_member_dependency(
		GlobalLBPoolID [] pools,
		GlobalLBVirtualServerID [] [] members,
		GlobalLBVirtualServerID [] [] [] dependencies
	) {
		this.Invoke("add_member_dependency", new object [] {
				pools,
				members,
				dependencies});

	}
	public System.IAsyncResult Beginadd_member_dependency(GlobalLBPoolID [] pools,GlobalLBVirtualServerID [] [] members,GlobalLBVirtualServerID [] [] [] dependencies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_member_dependency", new object[] {
			pools,
			members,
			dependencies}, callback, asyncState);
	}
	public void Endadd_member_dependency(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void add_metadata(
		GlobalLBPoolID [] pools,
		string [] [] names,
		string [] [] values
	) {
		this.Invoke("add_metadata", new object [] {
				pools,
				names,
				values});

	}
	public System.IAsyncResult Beginadd_metadata(GlobalLBPoolID [] pools,string [] [] names,string [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_metadata", new object[] {
			pools,
			names,
			values}, callback, asyncState);
	}
	public void Endadd_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_non_terminal_member_cname
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void add_non_terminal_member_cname(
		GlobalLBPoolID [] pools,
		string [] [] members,
		long [] [] orders,
		CommonEnabledState [] [] states
	) {
		this.Invoke("add_non_terminal_member_cname", new object [] {
				pools,
				members,
				orders,
				states});

	}
	public System.IAsyncResult Beginadd_non_terminal_member_cname(GlobalLBPoolID [] pools,string [] [] members,long [] [] orders,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_non_terminal_member_cname", new object[] {
			pools,
			members,
			orders,
			states}, callback, asyncState);
	}
	public void Endadd_non_terminal_member_cname(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_non_terminal_member_mx
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void add_non_terminal_member_mx(
		GlobalLBPoolID [] pools,
		string [] [] members,
		long [] [] orders
	) {
		this.Invoke("add_non_terminal_member_mx", new object [] {
				pools,
				members,
				orders});

	}
	public System.IAsyncResult Beginadd_non_terminal_member_mx(GlobalLBPoolID [] pools,string [] [] members,long [] [] orders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_non_terminal_member_mx", new object[] {
			pools,
			members,
			orders}, callback, asyncState);
	}
	public void Endadd_non_terminal_member_mx(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_non_terminal_member_naptr
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void add_non_terminal_member_naptr(
		GlobalLBPoolID [] pools,
		string [] [] members,
		long [] [] orders,
		string [] [] flags,
		string [] [] services
	) {
		this.Invoke("add_non_terminal_member_naptr", new object [] {
				pools,
				members,
				orders,
				flags,
				services});

	}
	public System.IAsyncResult Beginadd_non_terminal_member_naptr(GlobalLBPoolID [] pools,string [] [] members,long [] [] orders,string [] [] flags,string [] [] services, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_non_terminal_member_naptr", new object[] {
			pools,
			members,
			orders,
			flags,
			services}, callback, asyncState);
	}
	public void Endadd_non_terminal_member_naptr(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_non_terminal_member_srv
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void add_non_terminal_member_srv(
		GlobalLBPoolID [] pools,
		string [] [] members,
		long [] [] orders,
		long [] [] ports
	) {
		this.Invoke("add_non_terminal_member_srv", new object [] {
				pools,
				members,
				orders,
				ports});

	}
	public System.IAsyncResult Beginadd_non_terminal_member_srv(GlobalLBPoolID [] pools,string [] [] members,long [] [] orders,long [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_non_terminal_member_srv", new object[] {
			pools,
			members,
			orders,
			ports}, callback, asyncState);
	}
	public void Endadd_non_terminal_member_srv(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void create(
		GlobalLBPoolID [] pools,
		GlobalLBLBMethod [] lb_methods
	) {
		this.Invoke("create", new object [] {
				pools,
				lb_methods});

	}
	public System.IAsyncResult Begincreate(GlobalLBPoolID [] pools,GlobalLBLBMethod [] lb_methods, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			pools,
			lb_methods}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_pools
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void delete_all_pools(

	) {
		this.Invoke("delete_all_pools", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_pools(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_pools", new object[0], callback, asyncState);
	}
	public void Enddelete_all_pools(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void delete_pool(
		GlobalLBPoolID [] pools
	) {
		this.Invoke("delete_pool", new object [] {
				pools});

	}
	public System.IAsyncResult Begindelete_pool(GlobalLBPoolID [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_pool", new object[] {
			pools}, callback, asyncState);
	}
	public void Enddelete_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBPoolV2PoolStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((GlobalLBPoolV2PoolStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public GlobalLBPoolV2PoolStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBPoolV2PoolStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_alternate_lb_method
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBLBMethod [] get_alternate_lb_method(
		GlobalLBPoolID [] pools
	) {
		object [] results = this.Invoke("get_alternate_lb_method", new object [] {
				pools});
		return ((GlobalLBLBMethod [])(results[0]));
	}
	public System.IAsyncResult Beginget_alternate_lb_method(GlobalLBPoolID [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_alternate_lb_method", new object[] {
			pools}, callback, asyncState);
	}
	public GlobalLBLBMethod [] Endget_alternate_lb_method(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBLBMethod [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		GlobalLBPoolID [] pools
	) {
		object [] results = this.Invoke("get_description", new object [] {
				pools});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(GlobalLBPoolID [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			pools}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dynamic_ratio_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_dynamic_ratio_state(
		GlobalLBPoolID [] pools
	) {
		object [] results = this.Invoke("get_dynamic_ratio_state", new object [] {
				pools});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_dynamic_ratio_state(GlobalLBPoolID [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dynamic_ratio_state", new object[] {
			pools}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_dynamic_ratio_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_enabled_state(
		GlobalLBPoolID [] pools
	) {
		object [] results = this.Invoke("get_enabled_state", new object [] {
				pools});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_enabled_state(GlobalLBPoolID [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_enabled_state", new object[] {
			pools}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fallback_ip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_fallback_ip(
		GlobalLBPoolID [] pools
	) {
		object [] results = this.Invoke("get_fallback_ip", new object [] {
				pools});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_fallback_ip(GlobalLBPoolID [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fallback_ip", new object[] {
			pools}, callback, asyncState);
	}
	public string [] Endget_fallback_ip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fallback_lb_method
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBLBMethod [] get_fallback_lb_method(
		GlobalLBPoolID [] pools
	) {
		object [] results = this.Invoke("get_fallback_lb_method", new object [] {
				pools});
		return ((GlobalLBLBMethod [])(results[0]));
	}
	public System.IAsyncResult Beginget_fallback_lb_method(GlobalLBPoolID [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fallback_lb_method", new object[] {
			pools}, callback, asyncState);
	}
	public GlobalLBLBMethod [] Endget_fallback_lb_method(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBLBMethod [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBMetricLimit [] [] get_limit(
		GlobalLBPoolID [] pools
	) {
		object [] results = this.Invoke("get_limit", new object [] {
				pools});
		return ((GlobalLBMetricLimit [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_limit(GlobalLBPoolID [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_limit", new object[] {
			pools}, callback, asyncState);
	}
	public GlobalLBMetricLimit [] [] Endget_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBMetricLimit [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBPoolID [] get_list(

	) {
		object [] results = this.Invoke("get_list", new object [0]);
		return ((GlobalLBPoolID [])(results[0]));
	}
	public System.IAsyncResult Beginget_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_list", new object[0], callback, asyncState);
	}
	public GlobalLBPoolID [] Endget_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBPoolID [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list_by_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBPoolID [] [] get_list_by_type(
		GlobalLBGTMQueryType [] types
	) {
		object [] results = this.Invoke("get_list_by_type", new object [] {
				types});
		return ((GlobalLBPoolID [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_list_by_type(GlobalLBGTMQueryType [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_list_by_type", new object[] {
			types}, callback, asyncState);
	}
	public GlobalLBPoolID [] [] Endget_list_by_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBPoolID [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_manual_resume_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_manual_resume_state(
		GlobalLBPoolID [] pools
	) {
		object [] results = this.Invoke("get_manual_resume_state", new object [] {
				pools});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_manual_resume_state(GlobalLBPoolID [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_manual_resume_state", new object[] {
			pools}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_manual_resume_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBVirtualServerID [] [] get_member(
		GlobalLBPoolID [] pools
	) {
		object [] results = this.Invoke("get_member", new object [] {
				pools});
		return ((GlobalLBVirtualServerID [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member(GlobalLBPoolID [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member", new object[] {
			pools}, callback, asyncState);
	}
	public GlobalLBVirtualServerID [] [] Endget_member(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBVirtualServerID [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_dependency
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBVirtualServerID [] [] [] get_member_dependency(
		GlobalLBPoolID [] pools,
		GlobalLBVirtualServerID [] [] members
	) {
		object [] results = this.Invoke("get_member_dependency", new object [] {
				pools,
				members});
		return ((GlobalLBVirtualServerID [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_dependency(GlobalLBPoolID [] pools,GlobalLBVirtualServerID [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_dependency", new object[] {
			pools,
			members}, callback, asyncState);
	}
	public GlobalLBVirtualServerID [] [] [] Endget_member_dependency(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBVirtualServerID [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_member_description(
		GlobalLBPoolID [] pools,
		GlobalLBVirtualServerID [] [] members
	) {
		object [] results = this.Invoke("get_member_description", new object [] {
				pools,
				members});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_description(GlobalLBPoolID [] pools,GlobalLBVirtualServerID [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_description", new object[] {
			pools,
			members}, callback, asyncState);
	}
	public string [] [] Endget_member_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_member_enabled_state(
		GlobalLBPoolID [] pools,
		GlobalLBVirtualServerID [] [] members
	) {
		object [] results = this.Invoke("get_member_enabled_state", new object [] {
				pools,
				members});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_enabled_state(GlobalLBPoolID [] pools,GlobalLBVirtualServerID [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_enabled_state", new object[] {
			pools,
			members}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_member_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBMetricLimit [] [] [] get_member_limit(
		GlobalLBPoolID [] pools,
		GlobalLBVirtualServerID [] [] members
	) {
		object [] results = this.Invoke("get_member_limit", new object [] {
				pools,
				members});
		return ((GlobalLBMetricLimit [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_limit(GlobalLBPoolID [] pools,GlobalLBVirtualServerID [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_limit", new object[] {
			pools,
			members}, callback, asyncState);
	}
	public GlobalLBMetricLimit [] [] [] Endget_member_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBMetricLimit [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_monitor_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBMonitorRule [] [] get_member_monitor_rule(
		GlobalLBPoolID [] pools,
		GlobalLBVirtualServerID [] [] members
	) {
		object [] results = this.Invoke("get_member_monitor_rule", new object [] {
				pools,
				members});
		return ((GlobalLBMonitorRule [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_monitor_rule(GlobalLBPoolID [] pools,GlobalLBVirtualServerID [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_monitor_rule", new object[] {
			pools,
			members}, callback, asyncState);
	}
	public GlobalLBMonitorRule [] [] Endget_member_monitor_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBMonitorRule [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_monitor_rule_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBMonitorRuleV2 [] [] get_member_monitor_rule_v2(
		GlobalLBPoolID [] pools,
		GlobalLBVirtualServerID [] [] members
	) {
		object [] results = this.Invoke("get_member_monitor_rule_v2", new object [] {
				pools,
				members});
		return ((GlobalLBMonitorRuleV2 [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_monitor_rule_v2(GlobalLBPoolID [] pools,GlobalLBVirtualServerID [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_monitor_rule_v2", new object[] {
			pools,
			members}, callback, asyncState);
	}
	public GlobalLBMonitorRuleV2 [] [] Endget_member_monitor_rule_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBMonitorRuleV2 [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_object_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonObjectStatus [] [] get_member_object_status(
		GlobalLBPoolID [] pools,
		GlobalLBVirtualServerID [] [] members
	) {
		object [] results = this.Invoke("get_member_object_status", new object [] {
				pools,
				members});
		return ((CommonObjectStatus [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_object_status(GlobalLBPoolID [] pools,GlobalLBVirtualServerID [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_object_status", new object[] {
			pools,
			members}, callback, asyncState);
	}
	public CommonObjectStatus [] [] Endget_member_object_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonObjectStatus [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_order
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_member_order(
		GlobalLBPoolID [] pools,
		GlobalLBVirtualServerID [] [] members
	) {
		object [] results = this.Invoke("get_member_order", new object [] {
				pools,
				members});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_order(GlobalLBPoolID [] pools,GlobalLBVirtualServerID [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_order", new object[] {
			pools,
			members}, callback, asyncState);
	}
	public long [] [] Endget_member_order(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_ratio
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_member_ratio(
		GlobalLBPoolID [] pools,
		GlobalLBVirtualServerID [] [] members
	) {
		object [] results = this.Invoke("get_member_ratio", new object [] {
				pools,
				members});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_ratio(GlobalLBPoolID [] pools,GlobalLBVirtualServerID [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_ratio", new object[] {
			pools,
			members}, callback, asyncState);
	}
	public long [] [] Endget_member_ratio(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBPoolV2MemberStatistics get_member_statistics(
		GlobalLBPoolID [] pools,
		GlobalLBVirtualServerID [] [] members
	) {
		object [] results = this.Invoke("get_member_statistics", new object [] {
				pools,
				members});
		return ((GlobalLBPoolV2MemberStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_member_statistics(GlobalLBPoolID [] pools,GlobalLBVirtualServerID [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_statistics", new object[] {
			pools,
			members}, callback, asyncState);
	}
	public GlobalLBPoolV2MemberStatistics Endget_member_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBPoolV2MemberStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_metadata(
		GlobalLBPoolID [] pools
	) {
		object [] results = this.Invoke("get_metadata", new object [] {
				pools});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata(GlobalLBPoolID [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_metadata", new object[] {
			pools}, callback, asyncState);
	}
	public string [] [] Endget_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_metadata_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_metadata_description(
		GlobalLBPoolID [] pools,
		string [] [] names
	) {
		object [] results = this.Invoke("get_metadata_description", new object [] {
				pools,
				names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata_description(GlobalLBPoolID [] pools,string [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_metadata_description", new object[] {
			pools,
			names}, callback, asyncState);
	}
	public string [] [] Endget_metadata_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_metadata_persistence
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonMetadataPersistence [] [] get_metadata_persistence(
		GlobalLBPoolID [] pools,
		string [] [] names
	) {
		object [] results = this.Invoke("get_metadata_persistence", new object [] {
				pools,
				names});
		return ((CommonMetadataPersistence [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata_persistence(GlobalLBPoolID [] pools,string [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_metadata_persistence", new object[] {
			pools,
			names}, callback, asyncState);
	}
	public CommonMetadataPersistence [] [] Endget_metadata_persistence(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonMetadataPersistence [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_metadata_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_metadata_value(
		GlobalLBPoolID [] pools,
		string [] [] names
	) {
		object [] results = this.Invoke("get_metadata_value", new object [] {
				pools,
				names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata_value(GlobalLBPoolID [] pools,string [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_metadata_value", new object[] {
			pools,
			names}, callback, asyncState);
	}
	public string [] [] Endget_metadata_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_monitor_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBMonitorRule [] get_monitor_rule(
		GlobalLBPoolID [] pools
	) {
		object [] results = this.Invoke("get_monitor_rule", new object [] {
				pools});
		return ((GlobalLBMonitorRule [])(results[0]));
	}
	public System.IAsyncResult Beginget_monitor_rule(GlobalLBPoolID [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_monitor_rule", new object[] {
			pools}, callback, asyncState);
	}
	public GlobalLBMonitorRule [] Endget_monitor_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBMonitorRule [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_monitor_rule_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBMonitorRuleV2 [] get_monitor_rule_v2(
		GlobalLBPoolID [] pools
	) {
		object [] results = this.Invoke("get_monitor_rule_v2", new object [] {
				pools});
		return ((GlobalLBMonitorRuleV2 [])(results[0]));
	}
	public System.IAsyncResult Beginget_monitor_rule_v2(GlobalLBPoolID [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_monitor_rule_v2", new object[] {
			pools}, callback, asyncState);
	}
	public GlobalLBMonitorRuleV2 [] Endget_monitor_rule_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBMonitorRuleV2 [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_non_terminal_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_non_terminal_member(
		GlobalLBPoolID [] pools
	) {
		object [] results = this.Invoke("get_non_terminal_member", new object [] {
				pools});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_non_terminal_member(GlobalLBPoolID [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_non_terminal_member", new object[] {
			pools}, callback, asyncState);
	}
	public string [] [] Endget_non_terminal_member(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_non_terminal_member_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_non_terminal_member_description(
		GlobalLBPoolID [] pools,
		string [] [] members
	) {
		object [] results = this.Invoke("get_non_terminal_member_description", new object [] {
				pools,
				members});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_non_terminal_member_description(GlobalLBPoolID [] pools,string [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_non_terminal_member_description", new object[] {
			pools,
			members}, callback, asyncState);
	}
	public string [] [] Endget_non_terminal_member_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_non_terminal_member_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_non_terminal_member_enabled_state(
		GlobalLBPoolID [] pools,
		string [] [] members
	) {
		object [] results = this.Invoke("get_non_terminal_member_enabled_state", new object [] {
				pools,
				members});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_non_terminal_member_enabled_state(GlobalLBPoolID [] pools,string [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_non_terminal_member_enabled_state", new object[] {
			pools,
			members}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_non_terminal_member_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_non_terminal_member_object_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonObjectStatus [] [] get_non_terminal_member_object_status(
		GlobalLBPoolID [] pools,
		string [] [] members
	) {
		object [] results = this.Invoke("get_non_terminal_member_object_status", new object [] {
				pools,
				members});
		return ((CommonObjectStatus [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_non_terminal_member_object_status(GlobalLBPoolID [] pools,string [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_non_terminal_member_object_status", new object[] {
			pools,
			members}, callback, asyncState);
	}
	public CommonObjectStatus [] [] Endget_non_terminal_member_object_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonObjectStatus [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_non_terminal_member_order
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_non_terminal_member_order(
		GlobalLBPoolID [] pools,
		string [] [] members
	) {
		object [] results = this.Invoke("get_non_terminal_member_order", new object [] {
				pools,
				members});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_non_terminal_member_order(GlobalLBPoolID [] pools,string [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_non_terminal_member_order", new object[] {
			pools,
			members}, callback, asyncState);
	}
	public long [] [] Endget_non_terminal_member_order(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_non_terminal_member_ratio
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_non_terminal_member_ratio(
		GlobalLBPoolID [] pools,
		string [] [] members
	) {
		object [] results = this.Invoke("get_non_terminal_member_ratio", new object [] {
				pools,
				members});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_non_terminal_member_ratio(GlobalLBPoolID [] pools,string [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_non_terminal_member_ratio", new object[] {
			pools,
			members}, callback, asyncState);
	}
	public long [] [] Endget_non_terminal_member_ratio(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_non_terminal_member_rdata_flags
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_non_terminal_member_rdata_flags(
		GlobalLBPoolID [] pools,
		string [] [] members
	) {
		object [] results = this.Invoke("get_non_terminal_member_rdata_flags", new object [] {
				pools,
				members});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_non_terminal_member_rdata_flags(GlobalLBPoolID [] pools,string [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_non_terminal_member_rdata_flags", new object[] {
			pools,
			members}, callback, asyncState);
	}
	public string [] [] Endget_non_terminal_member_rdata_flags(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_non_terminal_member_rdata_order
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_non_terminal_member_rdata_order(
		GlobalLBPoolID [] pools,
		string [] [] members
	) {
		object [] results = this.Invoke("get_non_terminal_member_rdata_order", new object [] {
				pools,
				members});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_non_terminal_member_rdata_order(GlobalLBPoolID [] pools,string [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_non_terminal_member_rdata_order", new object[] {
			pools,
			members}, callback, asyncState);
	}
	public long [] [] Endget_non_terminal_member_rdata_order(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_non_terminal_member_rdata_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_non_terminal_member_rdata_port(
		GlobalLBPoolID [] pools,
		string [] [] members
	) {
		object [] results = this.Invoke("get_non_terminal_member_rdata_port", new object [] {
				pools,
				members});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_non_terminal_member_rdata_port(GlobalLBPoolID [] pools,string [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_non_terminal_member_rdata_port", new object[] {
			pools,
			members}, callback, asyncState);
	}
	public long [] [] Endget_non_terminal_member_rdata_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_non_terminal_member_rdata_preference
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_non_terminal_member_rdata_preference(
		GlobalLBPoolID [] pools,
		string [] [] members
	) {
		object [] results = this.Invoke("get_non_terminal_member_rdata_preference", new object [] {
				pools,
				members});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_non_terminal_member_rdata_preference(GlobalLBPoolID [] pools,string [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_non_terminal_member_rdata_preference", new object[] {
			pools,
			members}, callback, asyncState);
	}
	public long [] [] Endget_non_terminal_member_rdata_preference(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_non_terminal_member_rdata_priority
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_non_terminal_member_rdata_priority(
		GlobalLBPoolID [] pools,
		string [] [] members
	) {
		object [] results = this.Invoke("get_non_terminal_member_rdata_priority", new object [] {
				pools,
				members});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_non_terminal_member_rdata_priority(GlobalLBPoolID [] pools,string [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_non_terminal_member_rdata_priority", new object[] {
			pools,
			members}, callback, asyncState);
	}
	public long [] [] Endget_non_terminal_member_rdata_priority(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_non_terminal_member_rdata_service
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_non_terminal_member_rdata_service(
		GlobalLBPoolID [] pools,
		string [] [] members
	) {
		object [] results = this.Invoke("get_non_terminal_member_rdata_service", new object [] {
				pools,
				members});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_non_terminal_member_rdata_service(GlobalLBPoolID [] pools,string [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_non_terminal_member_rdata_service", new object[] {
			pools,
			members}, callback, asyncState);
	}
	public string [] [] Endget_non_terminal_member_rdata_service(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_non_terminal_member_rdata_weight
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_non_terminal_member_rdata_weight(
		GlobalLBPoolID [] pools,
		string [] [] members
	) {
		object [] results = this.Invoke("get_non_terminal_member_rdata_weight", new object [] {
				pools,
				members});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_non_terminal_member_rdata_weight(GlobalLBPoolID [] pools,string [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_non_terminal_member_rdata_weight", new object[] {
			pools,
			members}, callback, asyncState);
	}
	public long [] [] Endget_non_terminal_member_rdata_weight(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_non_terminal_member_static_target_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_non_terminal_member_static_target_state(
		GlobalLBPoolID [] pools,
		string [] [] members
	) {
		object [] results = this.Invoke("get_non_terminal_member_static_target_state", new object [] {
				pools,
				members});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_non_terminal_member_static_target_state(GlobalLBPoolID [] pools,string [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_non_terminal_member_static_target_state", new object[] {
			pools,
			members}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_non_terminal_member_static_target_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_non_terminal_member_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBPoolV2MemberStatistics get_non_terminal_member_statistics(
		GlobalLBPoolID [] pools,
		string [] [] members
	) {
		object [] results = this.Invoke("get_non_terminal_member_statistics", new object [] {
				pools,
				members});
		return ((GlobalLBPoolV2MemberStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_non_terminal_member_statistics(GlobalLBPoolID [] pools,string [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_non_terminal_member_statistics", new object[] {
			pools,
			members}, callback, asyncState);
	}
	public GlobalLBPoolV2MemberStatistics Endget_non_terminal_member_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBPoolV2MemberStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_object_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonObjectStatus [] get_object_status(
		GlobalLBPoolID [] pools
	) {
		object [] results = this.Invoke("get_object_status", new object [] {
				pools});
		return ((CommonObjectStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_object_status(GlobalLBPoolID [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_object_status", new object[] {
			pools}, callback, asyncState);
	}
	public CommonObjectStatus [] Endget_object_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonObjectStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_preferred_lb_method
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBLBMethod [] get_preferred_lb_method(
		GlobalLBPoolID [] pools
	) {
		object [] results = this.Invoke("get_preferred_lb_method", new object [] {
				pools});
		return ((GlobalLBLBMethod [])(results[0]));
	}
	public System.IAsyncResult Beginget_preferred_lb_method(GlobalLBPoolID [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_preferred_lb_method", new object[] {
			pools}, callback, asyncState);
	}
	public GlobalLBLBMethod [] Endget_preferred_lb_method(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBLBMethod [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_qos_coefficient_hit_ratio
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_qos_coefficient_hit_ratio(
		GlobalLBPoolID [] pools
	) {
		object [] results = this.Invoke("get_qos_coefficient_hit_ratio", new object [] {
				pools});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_qos_coefficient_hit_ratio(GlobalLBPoolID [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_qos_coefficient_hit_ratio", new object[] {
			pools}, callback, asyncState);
	}
	public long [] Endget_qos_coefficient_hit_ratio(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_qos_coefficient_hops
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_qos_coefficient_hops(
		GlobalLBPoolID [] pools
	) {
		object [] results = this.Invoke("get_qos_coefficient_hops", new object [] {
				pools});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_qos_coefficient_hops(GlobalLBPoolID [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_qos_coefficient_hops", new object[] {
			pools}, callback, asyncState);
	}
	public long [] Endget_qos_coefficient_hops(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_qos_coefficient_kbps
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_qos_coefficient_kbps(
		GlobalLBPoolID [] pools
	) {
		object [] results = this.Invoke("get_qos_coefficient_kbps", new object [] {
				pools});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_qos_coefficient_kbps(GlobalLBPoolID [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_qos_coefficient_kbps", new object[] {
			pools}, callback, asyncState);
	}
	public long [] Endget_qos_coefficient_kbps(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_qos_coefficient_link_capacity
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_qos_coefficient_link_capacity(
		GlobalLBPoolID [] pools
	) {
		object [] results = this.Invoke("get_qos_coefficient_link_capacity", new object [] {
				pools});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_qos_coefficient_link_capacity(GlobalLBPoolID [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_qos_coefficient_link_capacity", new object[] {
			pools}, callback, asyncState);
	}
	public long [] Endget_qos_coefficient_link_capacity(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_qos_coefficient_packet_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_qos_coefficient_packet_rate(
		GlobalLBPoolID [] pools
	) {
		object [] results = this.Invoke("get_qos_coefficient_packet_rate", new object [] {
				pools});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_qos_coefficient_packet_rate(GlobalLBPoolID [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_qos_coefficient_packet_rate", new object[] {
			pools}, callback, asyncState);
	}
	public long [] Endget_qos_coefficient_packet_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_qos_coefficient_rtt
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_qos_coefficient_rtt(
		GlobalLBPoolID [] pools
	) {
		object [] results = this.Invoke("get_qos_coefficient_rtt", new object [] {
				pools});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_qos_coefficient_rtt(GlobalLBPoolID [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_qos_coefficient_rtt", new object[] {
			pools}, callback, asyncState);
	}
	public long [] Endget_qos_coefficient_rtt(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_qos_coefficient_topology
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_qos_coefficient_topology(
		GlobalLBPoolID [] pools
	) {
		object [] results = this.Invoke("get_qos_coefficient_topology", new object [] {
				pools});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_qos_coefficient_topology(GlobalLBPoolID [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_qos_coefficient_topology", new object[] {
			pools}, callback, asyncState);
	}
	public long [] Endget_qos_coefficient_topology(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_qos_coefficient_vs_capacity
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_qos_coefficient_vs_capacity(
		GlobalLBPoolID [] pools
	) {
		object [] results = this.Invoke("get_qos_coefficient_vs_capacity", new object [] {
				pools});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_qos_coefficient_vs_capacity(GlobalLBPoolID [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_qos_coefficient_vs_capacity", new object[] {
			pools}, callback, asyncState);
	}
	public long [] Endget_qos_coefficient_vs_capacity(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_qos_coefficient_vs_score
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_qos_coefficient_vs_score(
		GlobalLBPoolID [] pools
	) {
		object [] results = this.Invoke("get_qos_coefficient_vs_score", new object [] {
				pools});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_qos_coefficient_vs_score(GlobalLBPoolID [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_qos_coefficient_vs_score", new object[] {
			pools}, callback, asyncState);
	}
	public long [] Endget_qos_coefficient_vs_score(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_returned_answers_count
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_returned_answers_count(
		GlobalLBPoolID [] pools
	) {
		object [] results = this.Invoke("get_returned_answers_count", new object [] {
				pools});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_returned_answers_count(GlobalLBPoolID [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_returned_answers_count", new object[] {
			pools}, callback, asyncState);
	}
	public long [] Endget_returned_answers_count(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBPoolV2PoolStatistics get_statistics(
		GlobalLBPoolID [] pools
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				pools});
		return ((GlobalLBPoolV2PoolStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(GlobalLBPoolID [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			pools}, callback, asyncState);
	}
	public GlobalLBPoolV2PoolStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBPoolV2PoolStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ttl
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_ttl(
		GlobalLBPoolID [] pools
	) {
		object [] results = this.Invoke("get_ttl", new object [] {
				pools});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_ttl(GlobalLBPoolID [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ttl", new object[] {
			pools}, callback, asyncState);
	}
	public long [] Endget_ttl(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_verify_member_availability_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_verify_member_availability_state(
		GlobalLBPoolID [] pools
	) {
		object [] results = this.Invoke("get_verify_member_availability_state", new object [] {
				pools});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_verify_member_availability_state(GlobalLBPoolID [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_verify_member_availability_state", new object[] {
			pools}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_verify_member_availability_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
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
	// remove_all_member_dependencies
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void remove_all_member_dependencies(
		GlobalLBPoolID [] pools,
		GlobalLBVirtualServerID [] [] members
	) {
		this.Invoke("remove_all_member_dependencies", new object [] {
				pools,
				members});

	}
	public System.IAsyncResult Beginremove_all_member_dependencies(GlobalLBPoolID [] pools,GlobalLBVirtualServerID [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_member_dependencies", new object[] {
			pools,
			members}, callback, asyncState);
	}
	public void Endremove_all_member_dependencies(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_members
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void remove_all_members(
		GlobalLBPoolID [] pools
	) {
		this.Invoke("remove_all_members", new object [] {
				pools});

	}
	public System.IAsyncResult Beginremove_all_members(GlobalLBPoolID [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_members", new object[] {
			pools}, callback, asyncState);
	}
	public void Endremove_all_members(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void remove_all_metadata(
		GlobalLBPoolID [] pools
	) {
		this.Invoke("remove_all_metadata", new object [] {
				pools});

	}
	public System.IAsyncResult Beginremove_all_metadata(GlobalLBPoolID [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_metadata", new object[] {
			pools}, callback, asyncState);
	}
	public void Endremove_all_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void remove_member(
		GlobalLBPoolID [] pools,
		GlobalLBVirtualServerID [] [] members
	) {
		this.Invoke("remove_member", new object [] {
				pools,
				members});

	}
	public System.IAsyncResult Beginremove_member(GlobalLBPoolID [] pools,GlobalLBVirtualServerID [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_member", new object[] {
			pools,
			members}, callback, asyncState);
	}
	public void Endremove_member(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_member_dependency
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void remove_member_dependency(
		GlobalLBPoolID [] pools,
		GlobalLBVirtualServerID [] [] members,
		GlobalLBVirtualServerID [] [] [] dependencies
	) {
		this.Invoke("remove_member_dependency", new object [] {
				pools,
				members,
				dependencies});

	}
	public System.IAsyncResult Beginremove_member_dependency(GlobalLBPoolID [] pools,GlobalLBVirtualServerID [] [] members,GlobalLBVirtualServerID [] [] [] dependencies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_member_dependency", new object[] {
			pools,
			members,
			dependencies}, callback, asyncState);
	}
	public void Endremove_member_dependency(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void remove_metadata(
		GlobalLBPoolID [] pools,
		string [] [] names
	) {
		this.Invoke("remove_metadata", new object [] {
				pools,
				names});

	}
	public System.IAsyncResult Beginremove_metadata(GlobalLBPoolID [] pools,string [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_metadata", new object[] {
			pools,
			names}, callback, asyncState);
	}
	public void Endremove_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_monitor_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void remove_monitor_rule(
		GlobalLBPoolID [] pools
	) {
		this.Invoke("remove_monitor_rule", new object [] {
				pools});

	}
	public System.IAsyncResult Beginremove_monitor_rule(GlobalLBPoolID [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_monitor_rule", new object[] {
			pools}, callback, asyncState);
	}
	public void Endremove_monitor_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_non_terminal_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void remove_non_terminal_member(
		GlobalLBPoolID [] pools,
		string [] [] members
	) {
		this.Invoke("remove_non_terminal_member", new object [] {
				pools,
				members});

	}
	public System.IAsyncResult Beginremove_non_terminal_member(GlobalLBPoolID [] pools,string [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_non_terminal_member", new object[] {
			pools,
			members}, callback, asyncState);
	}
	public void Endremove_non_terminal_member(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_member_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void reset_member_statistics(
		GlobalLBPoolID [] pools,
		GlobalLBVirtualServerID [] [] members
	) {
		this.Invoke("reset_member_statistics", new object [] {
				pools,
				members});

	}
	public System.IAsyncResult Beginreset_member_statistics(GlobalLBPoolID [] pools,GlobalLBVirtualServerID [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_member_statistics", new object[] {
			pools,
			members}, callback, asyncState);
	}
	public void Endreset_member_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_non_terminal_member_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void reset_non_terminal_member_statistics(
		GlobalLBPoolID [] pools,
		string [] [] members
	) {
		this.Invoke("reset_non_terminal_member_statistics", new object [] {
				pools,
				members});

	}
	public System.IAsyncResult Beginreset_non_terminal_member_statistics(GlobalLBPoolID [] pools,string [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_non_terminal_member_statistics", new object[] {
			pools,
			members}, callback, asyncState);
	}
	public void Endreset_non_terminal_member_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void reset_statistics(
		GlobalLBPoolID [] pools
	) {
		this.Invoke("reset_statistics", new object [] {
				pools});

	}
	public System.IAsyncResult Beginreset_statistics(GlobalLBPoolID [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics", new object[] {
			pools}, callback, asyncState);
	}
	public void Endreset_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_alternate_lb_method
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void set_alternate_lb_method(
		GlobalLBPoolID [] pools,
		GlobalLBLBMethod [] lb_methods
	) {
		this.Invoke("set_alternate_lb_method", new object [] {
				pools,
				lb_methods});

	}
	public System.IAsyncResult Beginset_alternate_lb_method(GlobalLBPoolID [] pools,GlobalLBLBMethod [] lb_methods, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_alternate_lb_method", new object[] {
			pools,
			lb_methods}, callback, asyncState);
	}
	public void Endset_alternate_lb_method(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void set_description(
		GlobalLBPoolID [] pools,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				pools,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(GlobalLBPoolID [] pools,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			pools,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dynamic_ratio_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void set_dynamic_ratio_state(
		GlobalLBPoolID [] pools,
		CommonEnabledState [] states
	) {
		this.Invoke("set_dynamic_ratio_state", new object [] {
				pools,
				states});

	}
	public System.IAsyncResult Beginset_dynamic_ratio_state(GlobalLBPoolID [] pools,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dynamic_ratio_state", new object[] {
			pools,
			states}, callback, asyncState);
	}
	public void Endset_dynamic_ratio_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void set_enabled_state(
		GlobalLBPoolID [] pools,
		CommonEnabledState [] states
	) {
		this.Invoke("set_enabled_state", new object [] {
				pools,
				states});

	}
	public System.IAsyncResult Beginset_enabled_state(GlobalLBPoolID [] pools,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_enabled_state", new object[] {
			pools,
			states}, callback, asyncState);
	}
	public void Endset_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fallback_ip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void set_fallback_ip(
		GlobalLBPoolID [] pools,
		string [] ips
	) {
		this.Invoke("set_fallback_ip", new object [] {
				pools,
				ips});

	}
	public System.IAsyncResult Beginset_fallback_ip(GlobalLBPoolID [] pools,string [] ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fallback_ip", new object[] {
			pools,
			ips}, callback, asyncState);
	}
	public void Endset_fallback_ip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fallback_lb_method
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void set_fallback_lb_method(
		GlobalLBPoolID [] pools,
		GlobalLBLBMethod [] lb_methods
	) {
		this.Invoke("set_fallback_lb_method", new object [] {
				pools,
				lb_methods});

	}
	public System.IAsyncResult Beginset_fallback_lb_method(GlobalLBPoolID [] pools,GlobalLBLBMethod [] lb_methods, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fallback_lb_method", new object[] {
			pools,
			lb_methods}, callback, asyncState);
	}
	public void Endset_fallback_lb_method(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void set_limit(
		GlobalLBPoolID [] pools,
		GlobalLBMetricLimit [] [] limits
	) {
		this.Invoke("set_limit", new object [] {
				pools,
				limits});

	}
	public System.IAsyncResult Beginset_limit(GlobalLBPoolID [] pools,GlobalLBMetricLimit [] [] limits, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_limit", new object[] {
			pools,
			limits}, callback, asyncState);
	}
	public void Endset_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_manual_resume_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void set_manual_resume_state(
		GlobalLBPoolID [] pools,
		CommonEnabledState [] states
	) {
		this.Invoke("set_manual_resume_state", new object [] {
				pools,
				states});

	}
	public System.IAsyncResult Beginset_manual_resume_state(GlobalLBPoolID [] pools,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_manual_resume_state", new object[] {
			pools,
			states}, callback, asyncState);
	}
	public void Endset_manual_resume_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_member_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void set_member_description(
		GlobalLBPoolID [] pools,
		GlobalLBVirtualServerID [] [] members,
		string [] [] descriptions
	) {
		this.Invoke("set_member_description", new object [] {
				pools,
				members,
				descriptions});

	}
	public System.IAsyncResult Beginset_member_description(GlobalLBPoolID [] pools,GlobalLBVirtualServerID [] [] members,string [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_member_description", new object[] {
			pools,
			members,
			descriptions}, callback, asyncState);
	}
	public void Endset_member_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_member_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void set_member_enabled_state(
		GlobalLBPoolID [] pools,
		GlobalLBVirtualServerID [] [] members,
		CommonEnabledState [] [] states
	) {
		this.Invoke("set_member_enabled_state", new object [] {
				pools,
				members,
				states});

	}
	public System.IAsyncResult Beginset_member_enabled_state(GlobalLBPoolID [] pools,GlobalLBVirtualServerID [] [] members,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_member_enabled_state", new object[] {
			pools,
			members,
			states}, callback, asyncState);
	}
	public void Endset_member_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_member_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void set_member_limit(
		GlobalLBPoolID [] pools,
		GlobalLBVirtualServerID [] [] members,
		GlobalLBMetricLimit [] [] [] limits
	) {
		this.Invoke("set_member_limit", new object [] {
				pools,
				members,
				limits});

	}
	public System.IAsyncResult Beginset_member_limit(GlobalLBPoolID [] pools,GlobalLBVirtualServerID [] [] members,GlobalLBMetricLimit [] [] [] limits, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_member_limit", new object[] {
			pools,
			members,
			limits}, callback, asyncState);
	}
	public void Endset_member_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_member_monitor_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void set_member_monitor_rule(
		GlobalLBPoolID [] pools,
		GlobalLBVirtualServerID [] [] members,
		GlobalLBMonitorRule [] [] rules
	) {
		this.Invoke("set_member_monitor_rule", new object [] {
				pools,
				members,
				rules});

	}
	public System.IAsyncResult Beginset_member_monitor_rule(GlobalLBPoolID [] pools,GlobalLBVirtualServerID [] [] members,GlobalLBMonitorRule [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_member_monitor_rule", new object[] {
			pools,
			members,
			rules}, callback, asyncState);
	}
	public void Endset_member_monitor_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_member_monitor_rule_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void set_member_monitor_rule_v2(
		GlobalLBPoolID [] pools,
		GlobalLBVirtualServerID [] [] members,
		GlobalLBMonitorRuleV2 [] [] monitor_rules
	) {
		this.Invoke("set_member_monitor_rule_v2", new object [] {
				pools,
				members,
				monitor_rules});

	}
	public System.IAsyncResult Beginset_member_monitor_rule_v2(GlobalLBPoolID [] pools,GlobalLBVirtualServerID [] [] members,GlobalLBMonitorRuleV2 [] [] monitor_rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_member_monitor_rule_v2", new object[] {
			pools,
			members,
			monitor_rules}, callback, asyncState);
	}
	public void Endset_member_monitor_rule_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_member_order
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void set_member_order(
		GlobalLBPoolID [] pools,
		GlobalLBVirtualServerID [] [] members,
		long [] [] orders
	) {
		this.Invoke("set_member_order", new object [] {
				pools,
				members,
				orders});

	}
	public System.IAsyncResult Beginset_member_order(GlobalLBPoolID [] pools,GlobalLBVirtualServerID [] [] members,long [] [] orders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_member_order", new object[] {
			pools,
			members,
			orders}, callback, asyncState);
	}
	public void Endset_member_order(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_member_ratio
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void set_member_ratio(
		GlobalLBPoolID [] pools,
		GlobalLBVirtualServerID [] [] members,
		long [] [] ratios
	) {
		this.Invoke("set_member_ratio", new object [] {
				pools,
				members,
				ratios});

	}
	public System.IAsyncResult Beginset_member_ratio(GlobalLBPoolID [] pools,GlobalLBVirtualServerID [] [] members,long [] [] ratios, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_member_ratio", new object[] {
			pools,
			members,
			ratios}, callback, asyncState);
	}
	public void Endset_member_ratio(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_metadata_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void set_metadata_description(
		GlobalLBPoolID [] pools,
		string [] [] names,
		string [] [] descriptions
	) {
		this.Invoke("set_metadata_description", new object [] {
				pools,
				names,
				descriptions});

	}
	public System.IAsyncResult Beginset_metadata_description(GlobalLBPoolID [] pools,string [] [] names,string [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_metadata_description", new object[] {
			pools,
			names,
			descriptions}, callback, asyncState);
	}
	public void Endset_metadata_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_metadata_persistence
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void set_metadata_persistence(
		GlobalLBPoolID [] pools,
		string [] [] names,
		CommonMetadataPersistence [] [] values
	) {
		this.Invoke("set_metadata_persistence", new object [] {
				pools,
				names,
				values});

	}
	public System.IAsyncResult Beginset_metadata_persistence(GlobalLBPoolID [] pools,string [] [] names,CommonMetadataPersistence [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_metadata_persistence", new object[] {
			pools,
			names,
			values}, callback, asyncState);
	}
	public void Endset_metadata_persistence(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_metadata_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void set_metadata_value(
		GlobalLBPoolID [] pools,
		string [] [] names,
		string [] [] values
	) {
		this.Invoke("set_metadata_value", new object [] {
				pools,
				names,
				values});

	}
	public System.IAsyncResult Beginset_metadata_value(GlobalLBPoolID [] pools,string [] [] names,string [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_metadata_value", new object[] {
			pools,
			names,
			values}, callback, asyncState);
	}
	public void Endset_metadata_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_monitor_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void set_monitor_rule(
		GlobalLBPoolID [] pools,
		GlobalLBMonitorRule [] rules
	) {
		this.Invoke("set_monitor_rule", new object [] {
				pools,
				rules});

	}
	public System.IAsyncResult Beginset_monitor_rule(GlobalLBPoolID [] pools,GlobalLBMonitorRule [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_monitor_rule", new object[] {
			pools,
			rules}, callback, asyncState);
	}
	public void Endset_monitor_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_monitor_rule_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void set_monitor_rule_v2(
		GlobalLBPoolID [] pools,
		GlobalLBMonitorRuleV2 [] monitor_rules
	) {
		this.Invoke("set_monitor_rule_v2", new object [] {
				pools,
				monitor_rules});

	}
	public System.IAsyncResult Beginset_monitor_rule_v2(GlobalLBPoolID [] pools,GlobalLBMonitorRuleV2 [] monitor_rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_monitor_rule_v2", new object[] {
			pools,
			monitor_rules}, callback, asyncState);
	}
	public void Endset_monitor_rule_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_non_terminal_member_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void set_non_terminal_member_description(
		GlobalLBPoolID [] pools,
		string [] [] members,
		string [] [] descriptions
	) {
		this.Invoke("set_non_terminal_member_description", new object [] {
				pools,
				members,
				descriptions});

	}
	public System.IAsyncResult Beginset_non_terminal_member_description(GlobalLBPoolID [] pools,string [] [] members,string [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_non_terminal_member_description", new object[] {
			pools,
			members,
			descriptions}, callback, asyncState);
	}
	public void Endset_non_terminal_member_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_non_terminal_member_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void set_non_terminal_member_enabled_state(
		GlobalLBPoolID [] pools,
		string [] [] members,
		CommonEnabledState [] [] states
	) {
		this.Invoke("set_non_terminal_member_enabled_state", new object [] {
				pools,
				members,
				states});

	}
	public System.IAsyncResult Beginset_non_terminal_member_enabled_state(GlobalLBPoolID [] pools,string [] [] members,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_non_terminal_member_enabled_state", new object[] {
			pools,
			members,
			states}, callback, asyncState);
	}
	public void Endset_non_terminal_member_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_non_terminal_member_order
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void set_non_terminal_member_order(
		GlobalLBPoolID [] pools,
		string [] [] members,
		long [] [] orders
	) {
		this.Invoke("set_non_terminal_member_order", new object [] {
				pools,
				members,
				orders});

	}
	public System.IAsyncResult Beginset_non_terminal_member_order(GlobalLBPoolID [] pools,string [] [] members,long [] [] orders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_non_terminal_member_order", new object[] {
			pools,
			members,
			orders}, callback, asyncState);
	}
	public void Endset_non_terminal_member_order(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_non_terminal_member_ratio
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void set_non_terminal_member_ratio(
		GlobalLBPoolID [] pools,
		string [] [] members,
		long [] [] ratios
	) {
		this.Invoke("set_non_terminal_member_ratio", new object [] {
				pools,
				members,
				ratios});

	}
	public System.IAsyncResult Beginset_non_terminal_member_ratio(GlobalLBPoolID [] pools,string [] [] members,long [] [] ratios, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_non_terminal_member_ratio", new object[] {
			pools,
			members,
			ratios}, callback, asyncState);
	}
	public void Endset_non_terminal_member_ratio(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_non_terminal_member_rdata_flags
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void set_non_terminal_member_rdata_flags(
		GlobalLBPoolID [] pools,
		string [] [] members,
		string [] [] flags
	) {
		this.Invoke("set_non_terminal_member_rdata_flags", new object [] {
				pools,
				members,
				flags});

	}
	public System.IAsyncResult Beginset_non_terminal_member_rdata_flags(GlobalLBPoolID [] pools,string [] [] members,string [] [] flags, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_non_terminal_member_rdata_flags", new object[] {
			pools,
			members,
			flags}, callback, asyncState);
	}
	public void Endset_non_terminal_member_rdata_flags(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_non_terminal_member_rdata_order
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void set_non_terminal_member_rdata_order(
		GlobalLBPoolID [] pools,
		string [] [] members,
		long [] [] orders
	) {
		this.Invoke("set_non_terminal_member_rdata_order", new object [] {
				pools,
				members,
				orders});

	}
	public System.IAsyncResult Beginset_non_terminal_member_rdata_order(GlobalLBPoolID [] pools,string [] [] members,long [] [] orders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_non_terminal_member_rdata_order", new object[] {
			pools,
			members,
			orders}, callback, asyncState);
	}
	public void Endset_non_terminal_member_rdata_order(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_non_terminal_member_rdata_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void set_non_terminal_member_rdata_port(
		GlobalLBPoolID [] pools,
		string [] [] members,
		long [] [] ports
	) {
		this.Invoke("set_non_terminal_member_rdata_port", new object [] {
				pools,
				members,
				ports});

	}
	public System.IAsyncResult Beginset_non_terminal_member_rdata_port(GlobalLBPoolID [] pools,string [] [] members,long [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_non_terminal_member_rdata_port", new object[] {
			pools,
			members,
			ports}, callback, asyncState);
	}
	public void Endset_non_terminal_member_rdata_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_non_terminal_member_rdata_preference
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void set_non_terminal_member_rdata_preference(
		GlobalLBPoolID [] pools,
		string [] [] members,
		long [] [] preferences
	) {
		this.Invoke("set_non_terminal_member_rdata_preference", new object [] {
				pools,
				members,
				preferences});

	}
	public System.IAsyncResult Beginset_non_terminal_member_rdata_preference(GlobalLBPoolID [] pools,string [] [] members,long [] [] preferences, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_non_terminal_member_rdata_preference", new object[] {
			pools,
			members,
			preferences}, callback, asyncState);
	}
	public void Endset_non_terminal_member_rdata_preference(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_non_terminal_member_rdata_priority
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void set_non_terminal_member_rdata_priority(
		GlobalLBPoolID [] pools,
		string [] [] members,
		long [] [] priorities
	) {
		this.Invoke("set_non_terminal_member_rdata_priority", new object [] {
				pools,
				members,
				priorities});

	}
	public System.IAsyncResult Beginset_non_terminal_member_rdata_priority(GlobalLBPoolID [] pools,string [] [] members,long [] [] priorities, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_non_terminal_member_rdata_priority", new object[] {
			pools,
			members,
			priorities}, callback, asyncState);
	}
	public void Endset_non_terminal_member_rdata_priority(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_non_terminal_member_rdata_service
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void set_non_terminal_member_rdata_service(
		GlobalLBPoolID [] pools,
		string [] [] members,
		string [] [] services
	) {
		this.Invoke("set_non_terminal_member_rdata_service", new object [] {
				pools,
				members,
				services});

	}
	public System.IAsyncResult Beginset_non_terminal_member_rdata_service(GlobalLBPoolID [] pools,string [] [] members,string [] [] services, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_non_terminal_member_rdata_service", new object[] {
			pools,
			members,
			services}, callback, asyncState);
	}
	public void Endset_non_terminal_member_rdata_service(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_non_terminal_member_rdata_weight
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void set_non_terminal_member_rdata_weight(
		GlobalLBPoolID [] pools,
		string [] [] members,
		long [] [] weights
	) {
		this.Invoke("set_non_terminal_member_rdata_weight", new object [] {
				pools,
				members,
				weights});

	}
	public System.IAsyncResult Beginset_non_terminal_member_rdata_weight(GlobalLBPoolID [] pools,string [] [] members,long [] [] weights, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_non_terminal_member_rdata_weight", new object[] {
			pools,
			members,
			weights}, callback, asyncState);
	}
	public void Endset_non_terminal_member_rdata_weight(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_non_terminal_member_static_target_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void set_non_terminal_member_static_target_state(
		GlobalLBPoolID [] pools,
		string [] [] members,
		CommonEnabledState [] [] states
	) {
		this.Invoke("set_non_terminal_member_static_target_state", new object [] {
				pools,
				members,
				states});

	}
	public System.IAsyncResult Beginset_non_terminal_member_static_target_state(GlobalLBPoolID [] pools,string [] [] members,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_non_terminal_member_static_target_state", new object[] {
			pools,
			members,
			states}, callback, asyncState);
	}
	public void Endset_non_terminal_member_static_target_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_preferred_lb_method
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void set_preferred_lb_method(
		GlobalLBPoolID [] pools,
		GlobalLBLBMethod [] lb_methods
	) {
		this.Invoke("set_preferred_lb_method", new object [] {
				pools,
				lb_methods});

	}
	public System.IAsyncResult Beginset_preferred_lb_method(GlobalLBPoolID [] pools,GlobalLBLBMethod [] lb_methods, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_preferred_lb_method", new object[] {
			pools,
			lb_methods}, callback, asyncState);
	}
	public void Endset_preferred_lb_method(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_qos_coefficient_hit_ratio
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void set_qos_coefficient_hit_ratio(
		GlobalLBPoolID [] pools,
		long [] values
	) {
		this.Invoke("set_qos_coefficient_hit_ratio", new object [] {
				pools,
				values});

	}
	public System.IAsyncResult Beginset_qos_coefficient_hit_ratio(GlobalLBPoolID [] pools,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_qos_coefficient_hit_ratio", new object[] {
			pools,
			values}, callback, asyncState);
	}
	public void Endset_qos_coefficient_hit_ratio(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_qos_coefficient_hops
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void set_qos_coefficient_hops(
		GlobalLBPoolID [] pools,
		long [] values
	) {
		this.Invoke("set_qos_coefficient_hops", new object [] {
				pools,
				values});

	}
	public System.IAsyncResult Beginset_qos_coefficient_hops(GlobalLBPoolID [] pools,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_qos_coefficient_hops", new object[] {
			pools,
			values}, callback, asyncState);
	}
	public void Endset_qos_coefficient_hops(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_qos_coefficient_kbps
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void set_qos_coefficient_kbps(
		GlobalLBPoolID [] pools,
		long [] values
	) {
		this.Invoke("set_qos_coefficient_kbps", new object [] {
				pools,
				values});

	}
	public System.IAsyncResult Beginset_qos_coefficient_kbps(GlobalLBPoolID [] pools,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_qos_coefficient_kbps", new object[] {
			pools,
			values}, callback, asyncState);
	}
	public void Endset_qos_coefficient_kbps(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_qos_coefficient_link_capacity
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void set_qos_coefficient_link_capacity(
		GlobalLBPoolID [] pools,
		long [] values
	) {
		this.Invoke("set_qos_coefficient_link_capacity", new object [] {
				pools,
				values});

	}
	public System.IAsyncResult Beginset_qos_coefficient_link_capacity(GlobalLBPoolID [] pools,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_qos_coefficient_link_capacity", new object[] {
			pools,
			values}, callback, asyncState);
	}
	public void Endset_qos_coefficient_link_capacity(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_qos_coefficient_packet_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void set_qos_coefficient_packet_rate(
		GlobalLBPoolID [] pools,
		long [] values
	) {
		this.Invoke("set_qos_coefficient_packet_rate", new object [] {
				pools,
				values});

	}
	public System.IAsyncResult Beginset_qos_coefficient_packet_rate(GlobalLBPoolID [] pools,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_qos_coefficient_packet_rate", new object[] {
			pools,
			values}, callback, asyncState);
	}
	public void Endset_qos_coefficient_packet_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_qos_coefficient_rtt
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void set_qos_coefficient_rtt(
		GlobalLBPoolID [] pools,
		long [] values
	) {
		this.Invoke("set_qos_coefficient_rtt", new object [] {
				pools,
				values});

	}
	public System.IAsyncResult Beginset_qos_coefficient_rtt(GlobalLBPoolID [] pools,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_qos_coefficient_rtt", new object[] {
			pools,
			values}, callback, asyncState);
	}
	public void Endset_qos_coefficient_rtt(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_qos_coefficient_topology
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void set_qos_coefficient_topology(
		GlobalLBPoolID [] pools,
		long [] values
	) {
		this.Invoke("set_qos_coefficient_topology", new object [] {
				pools,
				values});

	}
	public System.IAsyncResult Beginset_qos_coefficient_topology(GlobalLBPoolID [] pools,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_qos_coefficient_topology", new object[] {
			pools,
			values}, callback, asyncState);
	}
	public void Endset_qos_coefficient_topology(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_qos_coefficient_vs_capacity
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void set_qos_coefficient_vs_capacity(
		GlobalLBPoolID [] pools,
		long [] values
	) {
		this.Invoke("set_qos_coefficient_vs_capacity", new object [] {
				pools,
				values});

	}
	public System.IAsyncResult Beginset_qos_coefficient_vs_capacity(GlobalLBPoolID [] pools,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_qos_coefficient_vs_capacity", new object[] {
			pools,
			values}, callback, asyncState);
	}
	public void Endset_qos_coefficient_vs_capacity(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_qos_coefficient_vs_score
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void set_qos_coefficient_vs_score(
		GlobalLBPoolID [] pools,
		long [] values
	) {
		this.Invoke("set_qos_coefficient_vs_score", new object [] {
				pools,
				values});

	}
	public System.IAsyncResult Beginset_qos_coefficient_vs_score(GlobalLBPoolID [] pools,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_qos_coefficient_vs_score", new object[] {
			pools,
			values}, callback, asyncState);
	}
	public void Endset_qos_coefficient_vs_score(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_returned_answers_count
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void set_returned_answers_count(
		GlobalLBPoolID [] pools,
		long [] answers
	) {
		this.Invoke("set_returned_answers_count", new object [] {
				pools,
				answers});

	}
	public System.IAsyncResult Beginset_returned_answers_count(GlobalLBPoolID [] pools,long [] answers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_returned_answers_count", new object[] {
			pools,
			answers}, callback, asyncState);
	}
	public void Endset_returned_answers_count(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ttl
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void set_ttl(
		GlobalLBPoolID [] pools,
		long [] values
	) {
		this.Invoke("set_ttl", new object [] {
				pools,
				values});

	}
	public System.IAsyncResult Beginset_ttl(GlobalLBPoolID [] pools,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ttl", new object[] {
			pools,
			values}, callback, asyncState);
	}
	public void Endset_ttl(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_verify_member_availability_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/PoolV2", 
		RequestNamespace="urn:iControl:GlobalLB/PoolV2", ResponseNamespace="urn:iControl:GlobalLB/PoolV2")]
	public void set_verify_member_availability_state(
		GlobalLBPoolID [] pools,
		CommonEnabledState [] states
	) {
		this.Invoke("set_verify_member_availability_state", new object [] {
				pools,
				states});

	}
	public System.IAsyncResult Beginset_verify_member_availability_state(GlobalLBPoolID [] pools,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_verify_member_availability_state", new object[] {
			pools,
			states}, callback, asyncState);
	}
	public void Endset_verify_member_availability_state(System.IAsyncResult asyncResult) {
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.PoolV2.MemberStatistics", Namespace = "urn:iControl")]
	public partial class GlobalLBPoolV2MemberStatistics
	{
		private CommonStatistic [] [] [] statisticsField;
		public CommonStatistic [] [] [] statistics
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

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.PoolV2.PoolStatisticEntry", Namespace = "urn:iControl")]
	public partial class GlobalLBPoolV2PoolStatisticEntry
	{
		private GlobalLBPoolID poolField;
		public GlobalLBPoolID pool
		{
			get { return this.poolField; }
			set { this.poolField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.PoolV2.PoolStatistics", Namespace = "urn:iControl")]
	public partial class GlobalLBPoolV2PoolStatistics
	{
		private GlobalLBPoolV2PoolStatisticEntry [] statisticsField;
		public GlobalLBPoolV2PoolStatisticEntry [] statistics
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
