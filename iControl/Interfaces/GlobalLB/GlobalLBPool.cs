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
	[System.Web.Services.WebServiceBindingAttribute(Name="GlobalLB.PoolBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBPoolPoolMemberDefinition))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBVirtualServerID))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBPoolPoolStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBPoolPoolMetricLimit))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBMonitorRule))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonObjectStatus))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBPoolMemberStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBPoolMonitorAssociation))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonIPPortDefinition))]
	public partial class GlobalLBPool : iControlInterface {
		public GlobalLBPool() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void add_member(
		string [] pool_names,
		GlobalLBPoolPoolMemberDefinition [] [] members
	) {
		this.Invoke("add_member", new object [] {
				pool_names,
				members});

	}
	public System.IAsyncResult Beginadd_member(string [] pool_names,GlobalLBPoolPoolMemberDefinition [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_member", new object[] {
			pool_names,
			members}, callback, asyncState);
	}
	public void Endadd_member(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_member_dependency
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void add_member_dependency(
		string [] pool_names,
		GlobalLBVirtualServerID [] [] members,
		GlobalLBVirtualServerID [] [] [] dependencies
	) {
		this.Invoke("add_member_dependency", new object [] {
				pool_names,
				members,
				dependencies});

	}
	public System.IAsyncResult Beginadd_member_dependency(string [] pool_names,GlobalLBVirtualServerID [] [] members,GlobalLBVirtualServerID [] [] [] dependencies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_member_dependency", new object[] {
			pool_names,
			members,
			dependencies}, callback, asyncState);
	}
	public void Endadd_member_dependency(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_member_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void add_member_v2(
		string [] pool_names,
		GlobalLBVirtualServerID [] [] members,
		long [] [] orders
	) {
		this.Invoke("add_member_v2", new object [] {
				pool_names,
				members,
				orders});

	}
	public System.IAsyncResult Beginadd_member_v2(string [] pool_names,GlobalLBVirtualServerID [] [] members,long [] [] orders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_member_v2", new object[] {
			pool_names,
			members,
			orders}, callback, asyncState);
	}
	public void Endadd_member_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void add_metadata(
		string [] pool_names,
		string [] [] names,
		string [] [] values
	) {
		this.Invoke("add_metadata", new object [] {
				pool_names,
				names,
				values});

	}
	public System.IAsyncResult Beginadd_metadata(string [] pool_names,string [] [] names,string [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_metadata", new object[] {
			pool_names,
			names,
			values}, callback, asyncState);
	}
	public void Endadd_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void create(
		string [] pool_names,
		GlobalLBLBMethod [] lb_methods,
		GlobalLBPoolPoolMemberDefinition [] [] members
	) {
		this.Invoke("create", new object [] {
				pool_names,
				lb_methods,
				members});

	}
	public System.IAsyncResult Begincreate(string [] pool_names,GlobalLBLBMethod [] lb_methods,GlobalLBPoolPoolMemberDefinition [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			pool_names,
			lb_methods,
			members}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void create_v2(
		string [] pool_names,
		GlobalLBLBMethod [] lb_methods,
		GlobalLBVirtualServerID [] [] members,
		long [] [] orders
	) {
		this.Invoke("create_v2", new object [] {
				pool_names,
				lb_methods,
				members,
				orders});

	}
	public System.IAsyncResult Begincreate_v2(string [] pool_names,GlobalLBLBMethod [] lb_methods,GlobalLBVirtualServerID [] [] members,long [] [] orders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_v2", new object[] {
			pool_names,
			lb_methods,
			members,
			orders}, callback, asyncState);
	}
	public void Endcreate_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_pools
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void delete_pool(
		string [] pool_names
	) {
		this.Invoke("delete_pool", new object [] {
				pool_names});

	}
	public System.IAsyncResult Begindelete_pool(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_pool", new object[] {
			pool_names}, callback, asyncState);
	}
	public void Enddelete_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBPoolPoolStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((GlobalLBPoolPoolStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public GlobalLBPoolPoolStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBPoolPoolStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_alternate_lb_method
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBLBMethod [] get_alternate_lb_method(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_alternate_lb_method", new object [] {
				pool_names});
		return ((GlobalLBLBMethod [])(results[0]));
	}
	public System.IAsyncResult Beginget_alternate_lb_method(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_alternate_lb_method", new object[] {
			pool_names}, callback, asyncState);
	}
	public GlobalLBLBMethod [] Endget_alternate_lb_method(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBLBMethod [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_answers_to_return
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_answers_to_return(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_answers_to_return", new object [] {
				pool_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_answers_to_return(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_answers_to_return", new object[] {
			pool_names}, callback, asyncState);
	}
	public long [] Endget_answers_to_return(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cname
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_cname(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_cname", new object [] {
				pool_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_cname(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cname", new object[] {
			pool_names}, callback, asyncState);
	}
	public string [] Endget_cname(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_description", new object [] {
				pool_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			pool_names}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dynamic_ratio_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_dynamic_ratio_state(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_dynamic_ratio_state", new object [] {
				pool_names});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_dynamic_ratio_state(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dynamic_ratio_state", new object[] {
			pool_names}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_dynamic_ratio_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_enabled_state(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_enabled_state", new object [] {
				pool_names});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_enabled_state(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_enabled_state", new object[] {
			pool_names}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fallback_ip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_fallback_ip(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_fallback_ip", new object [] {
				pool_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_fallback_ip(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fallback_ip", new object[] {
			pool_names}, callback, asyncState);
	}
	public string [] Endget_fallback_ip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fallback_ipv4
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_fallback_ipv4(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_fallback_ipv4", new object [] {
				pool_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_fallback_ipv4(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fallback_ipv4", new object[] {
			pool_names}, callback, asyncState);
	}
	public string [] Endget_fallback_ipv4(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fallback_ipv6
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_fallback_ipv6(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_fallback_ipv6", new object [] {
				pool_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_fallback_ipv6(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fallback_ipv6", new object[] {
			pool_names}, callback, asyncState);
	}
	public string [] Endget_fallback_ipv6(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fallback_lb_method
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBLBMethod [] get_fallback_lb_method(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_fallback_lb_method", new object [] {
				pool_names});
		return ((GlobalLBLBMethod [])(results[0]));
	}
	public System.IAsyncResult Beginget_fallback_lb_method(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fallback_lb_method", new object[] {
			pool_names}, callback, asyncState);
	}
	public GlobalLBLBMethod [] Endget_fallback_lb_method(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBLBMethod [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBPoolPoolMetricLimit [] get_limit(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_limit", new object [] {
				pool_names});
		return ((GlobalLBPoolPoolMetricLimit [])(results[0]));
	}
	public System.IAsyncResult Beginget_limit(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_limit", new object[] {
			pool_names}, callback, asyncState);
	}
	public GlobalLBPoolPoolMetricLimit [] Endget_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBPoolPoolMetricLimit [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
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
	// get_manual_resume_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_manual_resume_state(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_manual_resume_state", new object [] {
				pool_names});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_manual_resume_state(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_manual_resume_state", new object[] {
			pool_names}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_manual_resume_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBPoolPoolMemberDefinition [] [] get_member(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_member", new object [] {
				pool_names});
		return ((GlobalLBPoolPoolMemberDefinition [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member", new object[] {
			pool_names}, callback, asyncState);
	}
	public GlobalLBPoolPoolMemberDefinition [] [] Endget_member(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBPoolPoolMemberDefinition [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_dependency
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBVirtualServerID [] [] [] get_member_dependency(
		string [] pool_names,
		GlobalLBVirtualServerID [] [] members
	) {
		object [] results = this.Invoke("get_member_dependency", new object [] {
				pool_names,
				members});
		return ((GlobalLBVirtualServerID [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_dependency(string [] pool_names,GlobalLBVirtualServerID [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_dependency", new object[] {
			pool_names,
			members}, callback, asyncState);
	}
	public GlobalLBVirtualServerID [] [] [] Endget_member_dependency(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBVirtualServerID [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_member_description(
		string [] pool_names,
		GlobalLBVirtualServerID [] [] members
	) {
		object [] results = this.Invoke("get_member_description", new object [] {
				pool_names,
				members});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_description(string [] pool_names,GlobalLBVirtualServerID [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_description", new object[] {
			pool_names,
			members}, callback, asyncState);
	}
	public string [] [] Endget_member_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_member_enabled_state(
		string [] pool_names,
		GlobalLBVirtualServerID [] [] members
	) {
		object [] results = this.Invoke("get_member_enabled_state", new object [] {
				pool_names,
				members});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_enabled_state(string [] pool_names,GlobalLBVirtualServerID [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_enabled_state", new object[] {
			pool_names,
			members}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_member_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBMetricLimit [] [] [] get_member_limit(
		string [] pool_names,
		GlobalLBVirtualServerID [] [] members
	) {
		object [] results = this.Invoke("get_member_limit", new object [] {
				pool_names,
				members});
		return ((GlobalLBMetricLimit [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_limit(string [] pool_names,GlobalLBVirtualServerID [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_limit", new object[] {
			pool_names,
			members}, callback, asyncState);
	}
	public GlobalLBMetricLimit [] [] [] Endget_member_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBMetricLimit [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_monitor_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBMonitorRule [] [] get_member_monitor_rule(
		string [] pool_names,
		GlobalLBVirtualServerID [] [] members
	) {
		object [] results = this.Invoke("get_member_monitor_rule", new object [] {
				pool_names,
				members});
		return ((GlobalLBMonitorRule [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_monitor_rule(string [] pool_names,GlobalLBVirtualServerID [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_monitor_rule", new object[] {
			pool_names,
			members}, callback, asyncState);
	}
	public GlobalLBMonitorRule [] [] Endget_member_monitor_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBMonitorRule [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_object_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonObjectStatus [] [] get_member_object_status(
		string [] pool_names,
		GlobalLBVirtualServerID [] [] members
	) {
		object [] results = this.Invoke("get_member_object_status", new object [] {
				pool_names,
				members});
		return ((CommonObjectStatus [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_object_status(string [] pool_names,GlobalLBVirtualServerID [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_object_status", new object[] {
			pool_names,
			members}, callback, asyncState);
	}
	public CommonObjectStatus [] [] Endget_member_object_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonObjectStatus [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_order
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_member_order(
		string [] pool_names,
		GlobalLBVirtualServerID [] [] members
	) {
		object [] results = this.Invoke("get_member_order", new object [] {
				pool_names,
				members});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_order(string [] pool_names,GlobalLBVirtualServerID [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_order", new object[] {
			pool_names,
			members}, callback, asyncState);
	}
	public long [] [] Endget_member_order(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_ratio
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_member_ratio(
		string [] pool_names,
		GlobalLBVirtualServerID [] [] members
	) {
		object [] results = this.Invoke("get_member_ratio", new object [] {
				pool_names,
				members});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_ratio(string [] pool_names,GlobalLBVirtualServerID [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_ratio", new object[] {
			pool_names,
			members}, callback, asyncState);
	}
	public long [] [] Endget_member_ratio(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBPoolMemberStatistics get_member_statistics(
		string [] pool_names,
		GlobalLBVirtualServerID [] [] members
	) {
		object [] results = this.Invoke("get_member_statistics", new object [] {
				pool_names,
				members});
		return ((GlobalLBPoolMemberStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_member_statistics(string [] pool_names,GlobalLBVirtualServerID [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_statistics", new object[] {
			pool_names,
			members}, callback, asyncState);
	}
	public GlobalLBPoolMemberStatistics Endget_member_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBPoolMemberStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBVirtualServerID [] [] get_member_v2(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_member_v2", new object [] {
				pool_names});
		return ((GlobalLBVirtualServerID [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_v2(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_v2", new object[] {
			pool_names}, callback, asyncState);
	}
	public GlobalLBVirtualServerID [] [] Endget_member_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBVirtualServerID [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_metadata(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_metadata", new object [] {
				pool_names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_metadata", new object[] {
			pool_names}, callback, asyncState);
	}
	public string [] [] Endget_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_metadata_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_metadata_description(
		string [] pool_names,
		string [] [] names
	) {
		object [] results = this.Invoke("get_metadata_description", new object [] {
				pool_names,
				names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata_description(string [] pool_names,string [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_metadata_description", new object[] {
			pool_names,
			names}, callback, asyncState);
	}
	public string [] [] Endget_metadata_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_metadata_persistence
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonMetadataPersistence [] [] get_metadata_persistence(
		string [] pool_names,
		string [] [] names
	) {
		object [] results = this.Invoke("get_metadata_persistence", new object [] {
				pool_names,
				names});
		return ((CommonMetadataPersistence [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata_persistence(string [] pool_names,string [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_metadata_persistence", new object[] {
			pool_names,
			names}, callback, asyncState);
	}
	public CommonMetadataPersistence [] [] Endget_metadata_persistence(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonMetadataPersistence [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_metadata_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_metadata_value(
		string [] pool_names,
		string [] [] names
	) {
		object [] results = this.Invoke("get_metadata_value", new object [] {
				pool_names,
				names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata_value(string [] pool_names,string [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_metadata_value", new object[] {
			pool_names,
			names}, callback, asyncState);
	}
	public string [] [] Endget_metadata_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_monitor_association
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBPoolMonitorAssociation [] get_monitor_association(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_monitor_association", new object [] {
				pool_names});
		return ((GlobalLBPoolMonitorAssociation [])(results[0]));
	}
	public System.IAsyncResult Beginget_monitor_association(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_monitor_association", new object[] {
			pool_names}, callback, asyncState);
	}
	public GlobalLBPoolMonitorAssociation [] Endget_monitor_association(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBPoolMonitorAssociation [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_object_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonObjectStatus [] get_object_status(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_object_status", new object [] {
				pool_names});
		return ((CommonObjectStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_object_status(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_object_status", new object[] {
			pool_names}, callback, asyncState);
	}
	public CommonObjectStatus [] Endget_object_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonObjectStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_preferred_lb_method
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBLBMethod [] get_preferred_lb_method(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_preferred_lb_method", new object [] {
				pool_names});
		return ((GlobalLBLBMethod [])(results[0]));
	}
	public System.IAsyncResult Beginget_preferred_lb_method(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_preferred_lb_method", new object[] {
			pool_names}, callback, asyncState);
	}
	public GlobalLBLBMethod [] Endget_preferred_lb_method(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBLBMethod [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_qos_coefficient_bps
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_qos_coefficient_bps(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_qos_coefficient_bps", new object [] {
				pool_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_qos_coefficient_bps(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_qos_coefficient_bps", new object[] {
			pool_names}, callback, asyncState);
	}
	public long [] Endget_qos_coefficient_bps(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_qos_coefficient_connection_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_qos_coefficient_connection_rate(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_qos_coefficient_connection_rate", new object [] {
				pool_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_qos_coefficient_connection_rate(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_qos_coefficient_connection_rate", new object[] {
			pool_names}, callback, asyncState);
	}
	public long [] Endget_qos_coefficient_connection_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_qos_coefficient_hit_ratio
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_qos_coefficient_hit_ratio(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_qos_coefficient_hit_ratio", new object [] {
				pool_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_qos_coefficient_hit_ratio(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_qos_coefficient_hit_ratio", new object[] {
			pool_names}, callback, asyncState);
	}
	public long [] Endget_qos_coefficient_hit_ratio(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_qos_coefficient_hops
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_qos_coefficient_hops(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_qos_coefficient_hops", new object [] {
				pool_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_qos_coefficient_hops(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_qos_coefficient_hops", new object[] {
			pool_names}, callback, asyncState);
	}
	public long [] Endget_qos_coefficient_hops(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_qos_coefficient_lcs
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_qos_coefficient_lcs(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_qos_coefficient_lcs", new object [] {
				pool_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_qos_coefficient_lcs(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_qos_coefficient_lcs", new object[] {
			pool_names}, callback, asyncState);
	}
	public long [] Endget_qos_coefficient_lcs(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_qos_coefficient_packet_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_qos_coefficient_packet_rate(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_qos_coefficient_packet_rate", new object [] {
				pool_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_qos_coefficient_packet_rate(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_qos_coefficient_packet_rate", new object[] {
			pool_names}, callback, asyncState);
	}
	public long [] Endget_qos_coefficient_packet_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_qos_coefficient_rtt
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_qos_coefficient_rtt(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_qos_coefficient_rtt", new object [] {
				pool_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_qos_coefficient_rtt(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_qos_coefficient_rtt", new object[] {
			pool_names}, callback, asyncState);
	}
	public long [] Endget_qos_coefficient_rtt(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_qos_coefficient_topology
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_qos_coefficient_topology(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_qos_coefficient_topology", new object [] {
				pool_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_qos_coefficient_topology(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_qos_coefficient_topology", new object[] {
			pool_names}, callback, asyncState);
	}
	public long [] Endget_qos_coefficient_topology(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_qos_coefficient_vs_capacity
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_qos_coefficient_vs_capacity(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_qos_coefficient_vs_capacity", new object [] {
				pool_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_qos_coefficient_vs_capacity(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_qos_coefficient_vs_capacity", new object[] {
			pool_names}, callback, asyncState);
	}
	public long [] Endget_qos_coefficient_vs_capacity(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_qos_coefficient_vs_score
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_qos_coefficient_vs_score(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_qos_coefficient_vs_score", new object [] {
				pool_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_qos_coefficient_vs_score(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_qos_coefficient_vs_score", new object[] {
			pool_names}, callback, asyncState);
	}
	public long [] Endget_qos_coefficient_vs_score(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBPoolPoolStatistics get_statistics(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				pool_names});
		return ((GlobalLBPoolPoolStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			pool_names}, callback, asyncState);
	}
	public GlobalLBPoolPoolStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBPoolPoolStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ttl
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_ttl(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_ttl", new object [] {
				pool_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_ttl(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ttl", new object[] {
			pool_names}, callback, asyncState);
	}
	public long [] Endget_ttl(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_verify_member_availability_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_verify_member_availability_state(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_verify_member_availability_state", new object [] {
				pool_names});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_verify_member_availability_state(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_verify_member_availability_state", new object[] {
			pool_names}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_verify_member_availability_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void remove_all_member_dependencies(
		string [] pool_names,
		GlobalLBVirtualServerID [] [] members
	) {
		this.Invoke("remove_all_member_dependencies", new object [] {
				pool_names,
				members});

	}
	public System.IAsyncResult Beginremove_all_member_dependencies(string [] pool_names,GlobalLBVirtualServerID [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_member_dependencies", new object[] {
			pool_names,
			members}, callback, asyncState);
	}
	public void Endremove_all_member_dependencies(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_members
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void remove_all_members(
		string [] pool_names
	) {
		this.Invoke("remove_all_members", new object [] {
				pool_names});

	}
	public System.IAsyncResult Beginremove_all_members(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_members", new object[] {
			pool_names}, callback, asyncState);
	}
	public void Endremove_all_members(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void remove_all_metadata(
		string [] pool_names
	) {
		this.Invoke("remove_all_metadata", new object [] {
				pool_names});

	}
	public System.IAsyncResult Beginremove_all_metadata(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_metadata", new object[] {
			pool_names}, callback, asyncState);
	}
	public void Endremove_all_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void remove_member(
		string [] pool_names,
		CommonIPPortDefinition [] [] members
	) {
		this.Invoke("remove_member", new object [] {
				pool_names,
				members});

	}
	public System.IAsyncResult Beginremove_member(string [] pool_names,CommonIPPortDefinition [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_member", new object[] {
			pool_names,
			members}, callback, asyncState);
	}
	public void Endremove_member(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_member_dependency
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void remove_member_dependency(
		string [] pool_names,
		GlobalLBVirtualServerID [] [] members,
		GlobalLBVirtualServerID [] [] [] dependencies
	) {
		this.Invoke("remove_member_dependency", new object [] {
				pool_names,
				members,
				dependencies});

	}
	public System.IAsyncResult Beginremove_member_dependency(string [] pool_names,GlobalLBVirtualServerID [] [] members,GlobalLBVirtualServerID [] [] [] dependencies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_member_dependency", new object[] {
			pool_names,
			members,
			dependencies}, callback, asyncState);
	}
	public void Endremove_member_dependency(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_member_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void remove_member_v2(
		string [] pool_names,
		GlobalLBVirtualServerID [] [] members
	) {
		this.Invoke("remove_member_v2", new object [] {
				pool_names,
				members});

	}
	public System.IAsyncResult Beginremove_member_v2(string [] pool_names,GlobalLBVirtualServerID [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_member_v2", new object[] {
			pool_names,
			members}, callback, asyncState);
	}
	public void Endremove_member_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void remove_metadata(
		string [] pool_names,
		string [] [] names
	) {
		this.Invoke("remove_metadata", new object [] {
				pool_names,
				names});

	}
	public System.IAsyncResult Beginremove_metadata(string [] pool_names,string [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_metadata", new object[] {
			pool_names,
			names}, callback, asyncState);
	}
	public void Endremove_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_monitor_association
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void remove_monitor_association(
		string [] pool_names
	) {
		this.Invoke("remove_monitor_association", new object [] {
				pool_names});

	}
	public System.IAsyncResult Beginremove_monitor_association(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_monitor_association", new object[] {
			pool_names}, callback, asyncState);
	}
	public void Endremove_monitor_association(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_member_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void reset_member_statistics(
		string [] pool_names,
		GlobalLBVirtualServerID [] [] members
	) {
		this.Invoke("reset_member_statistics", new object [] {
				pool_names,
				members});

	}
	public System.IAsyncResult Beginreset_member_statistics(string [] pool_names,GlobalLBVirtualServerID [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_member_statistics", new object[] {
			pool_names,
			members}, callback, asyncState);
	}
	public void Endreset_member_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void reset_statistics(
		string [] pool_names
	) {
		this.Invoke("reset_statistics", new object [] {
				pool_names});

	}
	public System.IAsyncResult Beginreset_statistics(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics", new object[] {
			pool_names}, callback, asyncState);
	}
	public void Endreset_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_alternate_lb_method
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void set_alternate_lb_method(
		string [] pool_names,
		GlobalLBLBMethod [] lb_methods
	) {
		this.Invoke("set_alternate_lb_method", new object [] {
				pool_names,
				lb_methods});

	}
	public System.IAsyncResult Beginset_alternate_lb_method(string [] pool_names,GlobalLBLBMethod [] lb_methods, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_alternate_lb_method", new object[] {
			pool_names,
			lb_methods}, callback, asyncState);
	}
	public void Endset_alternate_lb_method(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_answers_to_return
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void set_answers_to_return(
		string [] pool_names,
		long [] answers
	) {
		this.Invoke("set_answers_to_return", new object [] {
				pool_names,
				answers});

	}
	public System.IAsyncResult Beginset_answers_to_return(string [] pool_names,long [] answers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_answers_to_return", new object[] {
			pool_names,
			answers}, callback, asyncState);
	}
	public void Endset_answers_to_return(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_cname
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void set_cname(
		string [] pool_names,
		string [] cnames
	) {
		this.Invoke("set_cname", new object [] {
				pool_names,
				cnames});

	}
	public System.IAsyncResult Beginset_cname(string [] pool_names,string [] cnames, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cname", new object[] {
			pool_names,
			cnames}, callback, asyncState);
	}
	public void Endset_cname(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void set_description(
		string [] pool_names,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				pool_names,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] pool_names,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			pool_names,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dynamic_ratio_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void set_dynamic_ratio_state(
		string [] pool_names,
		CommonEnabledState [] states
	) {
		this.Invoke("set_dynamic_ratio_state", new object [] {
				pool_names,
				states});

	}
	public System.IAsyncResult Beginset_dynamic_ratio_state(string [] pool_names,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dynamic_ratio_state", new object[] {
			pool_names,
			states}, callback, asyncState);
	}
	public void Endset_dynamic_ratio_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void set_enabled_state(
		string [] pool_names,
		CommonEnabledState [] states
	) {
		this.Invoke("set_enabled_state", new object [] {
				pool_names,
				states});

	}
	public System.IAsyncResult Beginset_enabled_state(string [] pool_names,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_enabled_state", new object[] {
			pool_names,
			states}, callback, asyncState);
	}
	public void Endset_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fallback_ip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void set_fallback_ip(
		string [] pool_names,
		string [] ips
	) {
		this.Invoke("set_fallback_ip", new object [] {
				pool_names,
				ips});

	}
	public System.IAsyncResult Beginset_fallback_ip(string [] pool_names,string [] ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fallback_ip", new object[] {
			pool_names,
			ips}, callback, asyncState);
	}
	public void Endset_fallback_ip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fallback_ipv4
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void set_fallback_ipv4(
		string [] pool_names,
		string [] ips
	) {
		this.Invoke("set_fallback_ipv4", new object [] {
				pool_names,
				ips});

	}
	public System.IAsyncResult Beginset_fallback_ipv4(string [] pool_names,string [] ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fallback_ipv4", new object[] {
			pool_names,
			ips}, callback, asyncState);
	}
	public void Endset_fallback_ipv4(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fallback_ipv6
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void set_fallback_ipv6(
		string [] pool_names,
		string [] ips
	) {
		this.Invoke("set_fallback_ipv6", new object [] {
				pool_names,
				ips});

	}
	public System.IAsyncResult Beginset_fallback_ipv6(string [] pool_names,string [] ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fallback_ipv6", new object[] {
			pool_names,
			ips}, callback, asyncState);
	}
	public void Endset_fallback_ipv6(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fallback_lb_method
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void set_fallback_lb_method(
		string [] pool_names,
		GlobalLBLBMethod [] lb_methods
	) {
		this.Invoke("set_fallback_lb_method", new object [] {
				pool_names,
				lb_methods});

	}
	public System.IAsyncResult Beginset_fallback_lb_method(string [] pool_names,GlobalLBLBMethod [] lb_methods, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fallback_lb_method", new object[] {
			pool_names,
			lb_methods}, callback, asyncState);
	}
	public void Endset_fallback_lb_method(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void set_limit(
		GlobalLBPoolPoolMetricLimit [] limits
	) {
		this.Invoke("set_limit", new object [] {
				limits});

	}
	public System.IAsyncResult Beginset_limit(GlobalLBPoolPoolMetricLimit [] limits, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_limit", new object[] {
			limits}, callback, asyncState);
	}
	public void Endset_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_manual_resume_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void set_manual_resume_state(
		string [] pool_names,
		CommonEnabledState [] states
	) {
		this.Invoke("set_manual_resume_state", new object [] {
				pool_names,
				states});

	}
	public System.IAsyncResult Beginset_manual_resume_state(string [] pool_names,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_manual_resume_state", new object[] {
			pool_names,
			states}, callback, asyncState);
	}
	public void Endset_manual_resume_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_member_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void set_member_description(
		string [] pool_names,
		GlobalLBVirtualServerID [] [] members,
		string [] [] descriptions
	) {
		this.Invoke("set_member_description", new object [] {
				pool_names,
				members,
				descriptions});

	}
	public System.IAsyncResult Beginset_member_description(string [] pool_names,GlobalLBVirtualServerID [] [] members,string [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_member_description", new object[] {
			pool_names,
			members,
			descriptions}, callback, asyncState);
	}
	public void Endset_member_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_member_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void set_member_enabled_state(
		string [] pool_names,
		GlobalLBVirtualServerID [] [] members,
		CommonEnabledState [] [] states
	) {
		this.Invoke("set_member_enabled_state", new object [] {
				pool_names,
				members,
				states});

	}
	public System.IAsyncResult Beginset_member_enabled_state(string [] pool_names,GlobalLBVirtualServerID [] [] members,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_member_enabled_state", new object[] {
			pool_names,
			members,
			states}, callback, asyncState);
	}
	public void Endset_member_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_member_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void set_member_limit(
		string [] pool_names,
		GlobalLBVirtualServerID [] [] members,
		GlobalLBMetricLimit [] [] [] limits
	) {
		this.Invoke("set_member_limit", new object [] {
				pool_names,
				members,
				limits});

	}
	public System.IAsyncResult Beginset_member_limit(string [] pool_names,GlobalLBVirtualServerID [] [] members,GlobalLBMetricLimit [] [] [] limits, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_member_limit", new object[] {
			pool_names,
			members,
			limits}, callback, asyncState);
	}
	public void Endset_member_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_member_monitor_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void set_member_monitor_rule(
		string [] pool_names,
		GlobalLBVirtualServerID [] [] members,
		GlobalLBMonitorRule [] [] rules
	) {
		this.Invoke("set_member_monitor_rule", new object [] {
				pool_names,
				members,
				rules});

	}
	public System.IAsyncResult Beginset_member_monitor_rule(string [] pool_names,GlobalLBVirtualServerID [] [] members,GlobalLBMonitorRule [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_member_monitor_rule", new object[] {
			pool_names,
			members,
			rules}, callback, asyncState);
	}
	public void Endset_member_monitor_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_member_order
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void set_member_order(
		string [] pool_names,
		GlobalLBVirtualServerID [] [] members,
		long [] [] orders
	) {
		this.Invoke("set_member_order", new object [] {
				pool_names,
				members,
				orders});

	}
	public System.IAsyncResult Beginset_member_order(string [] pool_names,GlobalLBVirtualServerID [] [] members,long [] [] orders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_member_order", new object[] {
			pool_names,
			members,
			orders}, callback, asyncState);
	}
	public void Endset_member_order(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_member_ratio
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void set_member_ratio(
		string [] pool_names,
		GlobalLBVirtualServerID [] [] members,
		long [] [] ratios
	) {
		this.Invoke("set_member_ratio", new object [] {
				pool_names,
				members,
				ratios});

	}
	public System.IAsyncResult Beginset_member_ratio(string [] pool_names,GlobalLBVirtualServerID [] [] members,long [] [] ratios, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_member_ratio", new object[] {
			pool_names,
			members,
			ratios}, callback, asyncState);
	}
	public void Endset_member_ratio(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_metadata_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void set_metadata_description(
		string [] pool_names,
		string [] [] names,
		string [] [] descriptions
	) {
		this.Invoke("set_metadata_description", new object [] {
				pool_names,
				names,
				descriptions});

	}
	public System.IAsyncResult Beginset_metadata_description(string [] pool_names,string [] [] names,string [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_metadata_description", new object[] {
			pool_names,
			names,
			descriptions}, callback, asyncState);
	}
	public void Endset_metadata_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_metadata_persistence
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void set_metadata_persistence(
		string [] pool_names,
		string [] [] names,
		CommonMetadataPersistence [] [] values
	) {
		this.Invoke("set_metadata_persistence", new object [] {
				pool_names,
				names,
				values});

	}
	public System.IAsyncResult Beginset_metadata_persistence(string [] pool_names,string [] [] names,CommonMetadataPersistence [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_metadata_persistence", new object[] {
			pool_names,
			names,
			values}, callback, asyncState);
	}
	public void Endset_metadata_persistence(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_metadata_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void set_metadata_value(
		string [] pool_names,
		string [] [] names,
		string [] [] values
	) {
		this.Invoke("set_metadata_value", new object [] {
				pool_names,
				names,
				values});

	}
	public System.IAsyncResult Beginset_metadata_value(string [] pool_names,string [] [] names,string [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_metadata_value", new object[] {
			pool_names,
			names,
			values}, callback, asyncState);
	}
	public void Endset_metadata_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_monitor_association
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void set_monitor_association(
		GlobalLBPoolMonitorAssociation [] monitor_associations
	) {
		this.Invoke("set_monitor_association", new object [] {
				monitor_associations});

	}
	public System.IAsyncResult Beginset_monitor_association(GlobalLBPoolMonitorAssociation [] monitor_associations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_monitor_association", new object[] {
			monitor_associations}, callback, asyncState);
	}
	public void Endset_monitor_association(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_preferred_lb_method
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void set_preferred_lb_method(
		string [] pool_names,
		GlobalLBLBMethod [] lb_methods
	) {
		this.Invoke("set_preferred_lb_method", new object [] {
				pool_names,
				lb_methods});

	}
	public System.IAsyncResult Beginset_preferred_lb_method(string [] pool_names,GlobalLBLBMethod [] lb_methods, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_preferred_lb_method", new object[] {
			pool_names,
			lb_methods}, callback, asyncState);
	}
	public void Endset_preferred_lb_method(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_qos_coefficient_bps
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void set_qos_coefficient_bps(
		string [] pool_names,
		long [] values
	) {
		this.Invoke("set_qos_coefficient_bps", new object [] {
				pool_names,
				values});

	}
	public System.IAsyncResult Beginset_qos_coefficient_bps(string [] pool_names,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_qos_coefficient_bps", new object[] {
			pool_names,
			values}, callback, asyncState);
	}
	public void Endset_qos_coefficient_bps(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_qos_coefficient_connection_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void set_qos_coefficient_connection_rate(
		string [] pool_names,
		long [] values
	) {
		this.Invoke("set_qos_coefficient_connection_rate", new object [] {
				pool_names,
				values});

	}
	public System.IAsyncResult Beginset_qos_coefficient_connection_rate(string [] pool_names,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_qos_coefficient_connection_rate", new object[] {
			pool_names,
			values}, callback, asyncState);
	}
	public void Endset_qos_coefficient_connection_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_qos_coefficient_hit_ratio
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void set_qos_coefficient_hit_ratio(
		string [] pool_names,
		long [] values
	) {
		this.Invoke("set_qos_coefficient_hit_ratio", new object [] {
				pool_names,
				values});

	}
	public System.IAsyncResult Beginset_qos_coefficient_hit_ratio(string [] pool_names,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_qos_coefficient_hit_ratio", new object[] {
			pool_names,
			values}, callback, asyncState);
	}
	public void Endset_qos_coefficient_hit_ratio(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_qos_coefficient_hops
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void set_qos_coefficient_hops(
		string [] pool_names,
		long [] values
	) {
		this.Invoke("set_qos_coefficient_hops", new object [] {
				pool_names,
				values});

	}
	public System.IAsyncResult Beginset_qos_coefficient_hops(string [] pool_names,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_qos_coefficient_hops", new object[] {
			pool_names,
			values}, callback, asyncState);
	}
	public void Endset_qos_coefficient_hops(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_qos_coefficient_lcs
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void set_qos_coefficient_lcs(
		string [] pool_names,
		long [] values
	) {
		this.Invoke("set_qos_coefficient_lcs", new object [] {
				pool_names,
				values});

	}
	public System.IAsyncResult Beginset_qos_coefficient_lcs(string [] pool_names,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_qos_coefficient_lcs", new object[] {
			pool_names,
			values}, callback, asyncState);
	}
	public void Endset_qos_coefficient_lcs(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_qos_coefficient_packet_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void set_qos_coefficient_packet_rate(
		string [] pool_names,
		long [] values
	) {
		this.Invoke("set_qos_coefficient_packet_rate", new object [] {
				pool_names,
				values});

	}
	public System.IAsyncResult Beginset_qos_coefficient_packet_rate(string [] pool_names,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_qos_coefficient_packet_rate", new object[] {
			pool_names,
			values}, callback, asyncState);
	}
	public void Endset_qos_coefficient_packet_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_qos_coefficient_rtt
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void set_qos_coefficient_rtt(
		string [] pool_names,
		long [] values
	) {
		this.Invoke("set_qos_coefficient_rtt", new object [] {
				pool_names,
				values});

	}
	public System.IAsyncResult Beginset_qos_coefficient_rtt(string [] pool_names,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_qos_coefficient_rtt", new object[] {
			pool_names,
			values}, callback, asyncState);
	}
	public void Endset_qos_coefficient_rtt(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_qos_coefficient_topology
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void set_qos_coefficient_topology(
		string [] pool_names,
		long [] values
	) {
		this.Invoke("set_qos_coefficient_topology", new object [] {
				pool_names,
				values});

	}
	public System.IAsyncResult Beginset_qos_coefficient_topology(string [] pool_names,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_qos_coefficient_topology", new object[] {
			pool_names,
			values}, callback, asyncState);
	}
	public void Endset_qos_coefficient_topology(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_qos_coefficient_vs_capacity
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void set_qos_coefficient_vs_capacity(
		string [] pool_names,
		long [] values
	) {
		this.Invoke("set_qos_coefficient_vs_capacity", new object [] {
				pool_names,
				values});

	}
	public System.IAsyncResult Beginset_qos_coefficient_vs_capacity(string [] pool_names,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_qos_coefficient_vs_capacity", new object[] {
			pool_names,
			values}, callback, asyncState);
	}
	public void Endset_qos_coefficient_vs_capacity(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_qos_coefficient_vs_score
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void set_qos_coefficient_vs_score(
		string [] pool_names,
		long [] values
	) {
		this.Invoke("set_qos_coefficient_vs_score", new object [] {
				pool_names,
				values});

	}
	public System.IAsyncResult Beginset_qos_coefficient_vs_score(string [] pool_names,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_qos_coefficient_vs_score", new object[] {
			pool_names,
			values}, callback, asyncState);
	}
	public void Endset_qos_coefficient_vs_score(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ttl
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void set_ttl(
		string [] pool_names,
		long [] values
	) {
		this.Invoke("set_ttl", new object [] {
				pool_names,
				values});

	}
	public System.IAsyncResult Beginset_ttl(string [] pool_names,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ttl", new object[] {
			pool_names,
			values}, callback, asyncState);
	}
	public void Endset_ttl(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_verify_member_availability_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Pool", 
		RequestNamespace="urn:iControl:GlobalLB/Pool", ResponseNamespace="urn:iControl:GlobalLB/Pool")]
	public void set_verify_member_availability_state(
		string [] pool_names,
		CommonEnabledState [] states
	) {
		this.Invoke("set_verify_member_availability_state", new object [] {
				pool_names,
				states});

	}
	public System.IAsyncResult Beginset_verify_member_availability_state(string [] pool_names,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_verify_member_availability_state", new object[] {
			pool_names,
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.Pool.MemberStatistics", Namespace = "urn:iControl")]
	public partial class GlobalLBPoolMemberStatistics
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.Pool.MonitorAssociation", Namespace = "urn:iControl")]
	public partial class GlobalLBPoolMonitorAssociation
	{
		private string pool_nameField;
		public string pool_name
		{
			get { return this.pool_nameField; }
			set { this.pool_nameField = value; }
		}
		private GlobalLBMonitorRule monitor_ruleField;
		public GlobalLBMonitorRule monitor_rule
		{
			get { return this.monitor_ruleField; }
			set { this.monitor_ruleField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.Pool.PoolMemberDefinition", Namespace = "urn:iControl")]
	public partial class GlobalLBPoolPoolMemberDefinition
	{
		private CommonIPPortDefinition memberField;
		public CommonIPPortDefinition member
		{
			get { return this.memberField; }
			set { this.memberField = value; }
		}
		private long orderField;
		public long order
		{
			get { return this.orderField; }
			set { this.orderField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.Pool.PoolMetricLimit", Namespace = "urn:iControl")]
	public partial class GlobalLBPoolPoolMetricLimit
	{
		private string pool_nameField;
		public string pool_name
		{
			get { return this.pool_nameField; }
			set { this.pool_nameField = value; }
		}
		private GlobalLBMetricLimit [] metric_limitsField;
		public GlobalLBMetricLimit [] metric_limits
		{
			get { return this.metric_limitsField; }
			set { this.metric_limitsField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.Pool.PoolStatisticEntry", Namespace = "urn:iControl")]
	public partial class GlobalLBPoolPoolStatisticEntry
	{
		private string pool_nameField;
		public string pool_name
		{
			get { return this.pool_nameField; }
			set { this.pool_nameField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.Pool.PoolStatistics", Namespace = "urn:iControl")]
	public partial class GlobalLBPoolPoolStatistics
	{
		private GlobalLBPoolPoolStatisticEntry [] statisticsField;
		public GlobalLBPoolPoolStatisticEntry [] statistics
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
