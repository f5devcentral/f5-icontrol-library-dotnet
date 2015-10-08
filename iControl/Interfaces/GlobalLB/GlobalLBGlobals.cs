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
	[System.Web.Services.WebServiceBindingAttribute(Name="GlobalLB.GlobalsBinding", Namespace="urn:iControl")]
	public partial class GlobalLBGlobals : iControlInterface {
		public GlobalLBGlobals() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// get_aol_aware_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState get_aol_aware_state(

	) {
		object [] results = this.Invoke("get_aol_aware_state", new object [0]);
		return ((CommonEnabledState)(results[0]));
	}
	public System.IAsyncResult Beginget_aol_aware_state(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_aol_aware_state", new object[0], callback, asyncState);
	}
	public CommonEnabledState Endget_aol_aware_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_auto_configuration_save_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_auto_configuration_save_timeout(

	) {
		object [] results = this.Invoke("get_auto_configuration_save_timeout", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_auto_configuration_save_timeout(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_auto_configuration_save_timeout", new object[0], callback, asyncState);
	}
	public long Endget_auto_configuration_save_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_auto_configure_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState get_auto_configure_state(

	) {
		object [] results = this.Invoke("get_auto_configure_state", new object [0]);
		return ((CommonEnabledState)(results[0]));
	}
	public System.IAsyncResult Beginget_auto_configure_state(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_auto_configure_state", new object[0], callback, asyncState);
	}
	public CommonEnabledState Endget_auto_configure_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_auto_sync_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState get_auto_sync_state(

	) {
		object [] results = this.Invoke("get_auto_sync_state", new object [0]);
		return ((CommonEnabledState)(results[0]));
	}
	public System.IAsyncResult Beginget_auto_sync_state(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_auto_sync_state", new object[0], callback, asyncState);
	}
	public CommonEnabledState Endget_auto_sync_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cache_ldns_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState get_cache_ldns_state(

	) {
		object [] results = this.Invoke("get_cache_ldns_state", new object [0]);
		return ((CommonEnabledState)(results[0]));
	}
	public System.IAsyncResult Beginget_cache_ldns_state(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cache_ldns_state", new object[0], callback, asyncState);
	}
	public CommonEnabledState Endget_cache_ldns_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_check_dynamic_dependency_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState get_check_dynamic_dependency_state(

	) {
		object [] results = this.Invoke("get_check_dynamic_dependency_state", new object [0]);
		return ((CommonEnabledState)(results[0]));
	}
	public System.IAsyncResult Beginget_check_dynamic_dependency_state(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_check_dynamic_dependency_state", new object[0], callback, asyncState);
	}
	public CommonEnabledState Endget_check_dynamic_dependency_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_check_static_dependency_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState get_check_static_dependency_state(

	) {
		object [] results = this.Invoke("get_check_static_dependency_state", new object [0]);
		return ((CommonEnabledState)(results[0]));
	}
	public System.IAsyncResult Beginget_check_static_dependency_state(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_check_static_dependency_state", new object[0], callback, asyncState);
	}
	public CommonEnabledState Endget_check_static_dependency_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default_alternate_lb_method
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBLBMethod get_default_alternate_lb_method(

	) {
		object [] results = this.Invoke("get_default_alternate_lb_method", new object [0]);
		return ((GlobalLBLBMethod)(results[0]));
	}
	public System.IAsyncResult Beginget_default_alternate_lb_method(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_default_alternate_lb_method", new object[0], callback, asyncState);
	}
	public GlobalLBLBMethod Endget_default_alternate_lb_method(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBLBMethod)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default_fallback_lb_method
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBLBMethod get_default_fallback_lb_method(

	) {
		object [] results = this.Invoke("get_default_fallback_lb_method", new object [0]);
		return ((GlobalLBLBMethod)(results[0]));
	}
	public System.IAsyncResult Beginget_default_fallback_lb_method(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_default_fallback_lb_method", new object[0], callback, asyncState);
	}
	public GlobalLBLBMethod Endget_default_fallback_lb_method(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBLBMethod)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default_probe_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_default_probe_limit(

	) {
		object [] results = this.Invoke("get_default_probe_limit", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_default_probe_limit(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_default_probe_limit", new object[0], callback, asyncState);
	}
	public long Endget_default_probe_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_domain_name_check_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBDomainNameCheckMode get_domain_name_check_mode(

	) {
		object [] results = this.Invoke("get_domain_name_check_mode", new object [0]);
		return ((GlobalLBDomainNameCheckMode)(results[0]));
	}
	public System.IAsyncResult Beginget_domain_name_check_mode(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_domain_name_check_mode", new object[0], callback, asyncState);
	}
	public GlobalLBDomainNameCheckMode Endget_domain_name_check_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBDomainNameCheckMode)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_down_multiple
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_down_multiple(

	) {
		object [] results = this.Invoke("get_down_multiple", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_down_multiple(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_down_multiple", new object[0], callback, asyncState);
	}
	public long Endget_down_multiple(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_down_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_down_threshold(

	) {
		object [] results = this.Invoke("get_down_threshold", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_down_threshold(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_down_threshold", new object[0], callback, asyncState);
	}
	public long Endget_down_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_drain_request_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState get_drain_request_state(

	) {
		object [] results = this.Invoke("get_drain_request_state", new object [0]);
		return ((CommonEnabledState)(results[0]));
	}
	public System.IAsyncResult Beginget_drain_request_state(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_drain_request_state", new object[0], callback, asyncState);
	}
	public CommonEnabledState Endget_drain_request_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dump_topology_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState get_dump_topology_state(

	) {
		object [] results = this.Invoke("get_dump_topology_state", new object [0]);
		return ((CommonEnabledState)(results[0]));
	}
	public System.IAsyncResult Beginget_dump_topology_state(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dump_topology_state", new object[0], callback, asyncState);
	}
	public CommonEnabledState Endget_dump_topology_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fb_respect_acl_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState get_fb_respect_acl_state(

	) {
		object [] results = this.Invoke("get_fb_respect_acl_state", new object [0]);
		return ((CommonEnabledState)(results[0]));
	}
	public System.IAsyncResult Beginget_fb_respect_acl_state(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fb_respect_acl_state", new object[0], callback, asyncState);
	}
	public CommonEnabledState Endget_fb_respect_acl_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fb_respect_dependency_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState get_fb_respect_dependency_state(

	) {
		object [] results = this.Invoke("get_fb_respect_dependency_state", new object [0]);
		return ((CommonEnabledState)(results[0]));
	}
	public System.IAsyncResult Beginget_fb_respect_dependency_state(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fb_respect_dependency_state", new object[0], callback, asyncState);
	}
	public CommonEnabledState Endget_fb_respect_dependency_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_forward_status_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState get_forward_status_state(

	) {
		object [] results = this.Invoke("get_forward_status_state", new object [0]);
		return ((CommonEnabledState)(results[0]));
	}
	public System.IAsyncResult Beginget_forward_status_state(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_forward_status_state", new object[0], callback, asyncState);
	}
	public CommonEnabledState Endget_forward_status_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ldns_duration
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_ldns_duration(

	) {
		object [] results = this.Invoke("get_ldns_duration", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_ldns_duration(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ldns_duration", new object[0], callback, asyncState);
	}
	public long Endget_ldns_duration(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ldns_probe_protocols
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBLDNSProbeProtocol [] get_ldns_probe_protocols(

	) {
		object [] results = this.Invoke("get_ldns_probe_protocols", new object [0]);
		return ((GlobalLBLDNSProbeProtocol [])(results[0]));
	}
	public System.IAsyncResult Beginget_ldns_probe_protocols(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ldns_probe_protocols", new object[0], callback, asyncState);
	}
	public GlobalLBLDNSProbeProtocol [] Endget_ldns_probe_protocols(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBLDNSProbeProtocol [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ldns_update_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_ldns_update_interval(

	) {
		object [] results = this.Invoke("get_ldns_update_interval", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_ldns_update_interval(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ldns_update_interval", new object[0], callback, asyncState);
	}
	public long Endget_ldns_update_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_link_compensate_inbound_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState get_link_compensate_inbound_state(

	) {
		object [] results = this.Invoke("get_link_compensate_inbound_state", new object [0]);
		return ((CommonEnabledState)(results[0]));
	}
	public System.IAsyncResult Beginget_link_compensate_inbound_state(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_link_compensate_inbound_state", new object[0], callback, asyncState);
	}
	public CommonEnabledState Endget_link_compensate_inbound_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_link_compensate_outbound_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState get_link_compensate_outbound_state(

	) {
		object [] results = this.Invoke("get_link_compensate_outbound_state", new object [0]);
		return ((CommonEnabledState)(results[0]));
	}
	public System.IAsyncResult Beginget_link_compensate_outbound_state(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_link_compensate_outbound_state", new object[0], callback, asyncState);
	}
	public CommonEnabledState Endget_link_compensate_outbound_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_link_compensation_history
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_link_compensation_history(

	) {
		object [] results = this.Invoke("get_link_compensation_history", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_link_compensation_history(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_link_compensation_history", new object[0], callback, asyncState);
	}
	public long Endget_link_compensation_history(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_link_limit_factor
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_link_limit_factor(

	) {
		object [] results = this.Invoke("get_link_limit_factor", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_link_limit_factor(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_link_limit_factor", new object[0], callback, asyncState);
	}
	public long Endget_link_limit_factor(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_link_prepaid_factor
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_link_prepaid_factor(

	) {
		object [] results = this.Invoke("get_link_prepaid_factor", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_link_prepaid_factor(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_link_prepaid_factor", new object[0], callback, asyncState);
	}
	public long Endget_link_prepaid_factor(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_lower_bound_percentage_column
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_lower_bound_percentage_column(

	) {
		object [] results = this.Invoke("get_lower_bound_percentage_column", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_lower_bound_percentage_column(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_lower_bound_percentage_column", new object[0], callback, asyncState);
	}
	public long Endget_lower_bound_percentage_column(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_lower_bound_percentage_row
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_lower_bound_percentage_row(

	) {
		object [] results = this.Invoke("get_lower_bound_percentage_row", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_lower_bound_percentage_row(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_lower_bound_percentage_row", new object[0], callback, asyncState);
	}
	public long Endget_lower_bound_percentage_row(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_maximum_link_over_limit_count
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_maximum_link_over_limit_count(

	) {
		object [] results = this.Invoke("get_maximum_link_over_limit_count", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_link_over_limit_count(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_link_over_limit_count", new object[0], callback, asyncState);
	}
	public long Endget_maximum_link_over_limit_count(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_maximum_synchronous_monitor_request
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_maximum_synchronous_monitor_request(

	) {
		object [] results = this.Invoke("get_maximum_synchronous_monitor_request", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_synchronous_monitor_request(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_synchronous_monitor_request", new object[0], callback, asyncState);
	}
	public long Endget_maximum_synchronous_monitor_request(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_over_limit_link_limit_factor
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_over_limit_link_limit_factor(

	) {
		object [] results = this.Invoke("get_over_limit_link_limit_factor", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_over_limit_link_limit_factor(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_over_limit_link_limit_factor", new object[0], callback, asyncState);
	}
	public long Endget_over_limit_link_limit_factor(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_path_duration
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_path_duration(

	) {
		object [] results = this.Invoke("get_path_duration", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_path_duration(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_path_duration", new object[0], callback, asyncState);
	}
	public long Endget_path_duration(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_path_ttl
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_path_ttl(

	) {
		object [] results = this.Invoke("get_path_ttl", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_path_ttl(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_path_ttl", new object[0], callback, asyncState);
	}
	public long Endget_path_ttl(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_paths_never_die_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState get_paths_never_die_state(

	) {
		object [] results = this.Invoke("get_paths_never_die_state", new object [0]);
		return ((CommonEnabledState)(results[0]));
	}
	public System.IAsyncResult Beginget_paths_never_die_state(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_paths_never_die_state", new object[0], callback, asyncState);
	}
	public CommonEnabledState Endget_paths_never_die_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_peer_leader
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string get_peer_leader(

	) {
		object [] results = this.Invoke("get_peer_leader", new object [0]);
		return ((string)(results[0]));
	}
	public System.IAsyncResult Beginget_peer_leader(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_peer_leader", new object[0], callback, asyncState);
	}
	public string Endget_peer_leader(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_persistence_mask
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_persistence_mask(

	) {
		object [] results = this.Invoke("get_persistence_mask", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_persistence_mask(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_persistence_mask", new object[0], callback, asyncState);
	}
	public long Endget_persistence_mask(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_probe_disabled_object_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState get_probe_disabled_object_state(

	) {
		object [] results = this.Invoke("get_probe_disabled_object_state", new object [0]);
		return ((CommonEnabledState)(results[0]));
	}
	public System.IAsyncResult Beginget_probe_disabled_object_state(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_probe_disabled_object_state", new object[0], callback, asyncState);
	}
	public CommonEnabledState Endget_probe_disabled_object_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_propagate_wild_card_a_records_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState get_propagate_wild_card_a_records_state(

	) {
		object [] results = this.Invoke("get_propagate_wild_card_a_records_state", new object [0]);
		return ((CommonEnabledState)(results[0]));
	}
	public System.IAsyncResult Beginget_propagate_wild_card_a_records_state(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_propagate_wild_card_a_records_state", new object[0], callback, asyncState);
	}
	public CommonEnabledState Endget_propagate_wild_card_a_records_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_qos_factor_bps
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_qos_factor_bps(

	) {
		object [] results = this.Invoke("get_qos_factor_bps", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_qos_factor_bps(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_qos_factor_bps", new object[0], callback, asyncState);
	}
	public long Endget_qos_factor_bps(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_qos_factor_connection_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_qos_factor_connection_rate(

	) {
		object [] results = this.Invoke("get_qos_factor_connection_rate", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_qos_factor_connection_rate(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_qos_factor_connection_rate", new object[0], callback, asyncState);
	}
	public long Endget_qos_factor_connection_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_qos_factor_hit_ratio
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_qos_factor_hit_ratio(

	) {
		object [] results = this.Invoke("get_qos_factor_hit_ratio", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_qos_factor_hit_ratio(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_qos_factor_hit_ratio", new object[0], callback, asyncState);
	}
	public long Endget_qos_factor_hit_ratio(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_qos_factor_hops
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_qos_factor_hops(

	) {
		object [] results = this.Invoke("get_qos_factor_hops", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_qos_factor_hops(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_qos_factor_hops", new object[0], callback, asyncState);
	}
	public long Endget_qos_factor_hops(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_qos_factor_lcs
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_qos_factor_lcs(

	) {
		object [] results = this.Invoke("get_qos_factor_lcs", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_qos_factor_lcs(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_qos_factor_lcs", new object[0], callback, asyncState);
	}
	public long Endget_qos_factor_lcs(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_qos_factor_packet_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_qos_factor_packet_rate(

	) {
		object [] results = this.Invoke("get_qos_factor_packet_rate", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_qos_factor_packet_rate(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_qos_factor_packet_rate", new object[0], callback, asyncState);
	}
	public long Endget_qos_factor_packet_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_qos_factor_rtt
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_qos_factor_rtt(

	) {
		object [] results = this.Invoke("get_qos_factor_rtt", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_qos_factor_rtt(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_qos_factor_rtt", new object[0], callback, asyncState);
	}
	public long Endget_qos_factor_rtt(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_qos_factor_topology
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_qos_factor_topology(

	) {
		object [] results = this.Invoke("get_qos_factor_topology", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_qos_factor_topology(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_qos_factor_topology", new object[0], callback, asyncState);
	}
	public long Endget_qos_factor_topology(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_qos_factor_vs_capacity
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_qos_factor_vs_capacity(

	) {
		object [] results = this.Invoke("get_qos_factor_vs_capacity", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_qos_factor_vs_capacity(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_qos_factor_vs_capacity", new object[0], callback, asyncState);
	}
	public long Endget_qos_factor_vs_capacity(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_qos_factor_vs_score
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_qos_factor_vs_score(

	) {
		object [] results = this.Invoke("get_qos_factor_vs_score", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_qos_factor_vs_score(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_qos_factor_vs_score", new object[0], callback, asyncState);
	}
	public long Endget_qos_factor_vs_score(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_reset_ripeness_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState get_reset_ripeness_state(

	) {
		object [] results = this.Invoke("get_reset_ripeness_state", new object [0]);
		return ((CommonEnabledState)(results[0]));
	}
	public System.IAsyncResult Beginget_reset_ripeness_state(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_reset_ripeness_state", new object[0], callback, asyncState);
	}
	public CommonEnabledState Endget_reset_ripeness_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rtt_packet_length
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_rtt_packet_length(

	) {
		object [] results = this.Invoke("get_rtt_packet_length", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_rtt_packet_length(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rtt_packet_length", new object[0], callback, asyncState);
	}
	public long Endget_rtt_packet_length(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rtt_sample_count
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_rtt_sample_count(

	) {
		object [] results = this.Invoke("get_rtt_sample_count", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_rtt_sample_count(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rtt_sample_count", new object[0], callback, asyncState);
	}
	public long Endget_rtt_sample_count(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rtt_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_rtt_timeout(

	) {
		object [] results = this.Invoke("get_rtt_timeout", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_rtt_timeout(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rtt_timeout", new object[0], callback, asyncState);
	}
	public long Endget_rtt_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_static_persistence_cidr_mask
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_static_persistence_cidr_mask(
		bool v6
	) {
		object [] results = this.Invoke("get_static_persistence_cidr_mask", new object [] {
				v6});
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_static_persistence_cidr_mask(bool v6, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_static_persistence_cidr_mask", new object[] {
			v6}, callback, asyncState);
	}
	public long Endget_static_persistence_cidr_mask(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_sync_group_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string get_sync_group_name(

	) {
		object [] results = this.Invoke("get_sync_group_name", new object [0]);
		return ((string)(results[0]));
	}
	public System.IAsyncResult Beginget_sync_group_name(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_sync_group_name", new object[0], callback, asyncState);
	}
	public string Endget_sync_group_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_sync_named_configuration_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState get_sync_named_configuration_state(

	) {
		object [] results = this.Invoke("get_sync_named_configuration_state", new object [0]);
		return ((CommonEnabledState)(results[0]));
	}
	public System.IAsyncResult Beginget_sync_named_configuration_state(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_sync_named_configuration_state", new object[0], callback, asyncState);
	}
	public CommonEnabledState Endget_sync_named_configuration_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_sync_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_sync_timeout(

	) {
		object [] results = this.Invoke("get_sync_timeout", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_sync_timeout(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_sync_timeout", new object[0], callback, asyncState);
	}
	public long Endget_sync_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_sync_zone_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_sync_zone_timeout(

	) {
		object [] results = this.Invoke("get_sync_zone_timeout", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_sync_zone_timeout(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_sync_zone_timeout", new object[0], callback, asyncState);
	}
	public long Endget_sync_zone_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_time_tolerance
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_time_tolerance(

	) {
		object [] results = this.Invoke("get_time_tolerance", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_time_tolerance(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_time_tolerance", new object[0], callback, asyncState);
	}
	public long Endget_time_tolerance(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_timer_get_auto_configuration_data
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_timer_get_auto_configuration_data(

	) {
		object [] results = this.Invoke("get_timer_get_auto_configuration_data", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_timer_get_auto_configuration_data(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_timer_get_auto_configuration_data", new object[0], callback, asyncState);
	}
	public long Endget_timer_get_auto_configuration_data(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_timer_heartbeat
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_timer_heartbeat(

	) {
		object [] results = this.Invoke("get_timer_heartbeat", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_timer_heartbeat(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_timer_heartbeat", new object[0], callback, asyncState);
	}
	public long Endget_timer_heartbeat(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_timer_persistence_cache
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_timer_persistence_cache(

	) {
		object [] results = this.Invoke("get_timer_persistence_cache", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_timer_persistence_cache(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_timer_persistence_cache", new object[0], callback, asyncState);
	}
	public long Endget_timer_persistence_cache(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_timer_retry_path_data
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_timer_retry_path_data(

	) {
		object [] results = this.Invoke("get_timer_retry_path_data", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_timer_retry_path_data(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_timer_retry_path_data", new object[0], callback, asyncState);
	}
	public long Endget_timer_retry_path_data(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_topology_acl_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_topology_acl_threshold(

	) {
		object [] results = this.Invoke("get_topology_acl_threshold", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_topology_acl_threshold(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_topology_acl_threshold", new object[0], callback, asyncState);
	}
	public long Endget_topology_acl_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_topology_allow_zero_scores_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState get_topology_allow_zero_scores_state(

	) {
		object [] results = this.Invoke("get_topology_allow_zero_scores_state", new object [0]);
		return ((CommonEnabledState)(results[0]));
	}
	public System.IAsyncResult Beginget_topology_allow_zero_scores_state(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_topology_allow_zero_scores_state", new object[0], callback, asyncState);
	}
	public CommonEnabledState Endget_topology_allow_zero_scores_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_topology_longest_match_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState get_topology_longest_match_state(

	) {
		object [] results = this.Invoke("get_topology_longest_match_state", new object [0]);
		return ((CommonEnabledState)(results[0]));
	}
	public System.IAsyncResult Beginget_topology_longest_match_state(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_topology_longest_match_state", new object[0], callback, asyncState);
	}
	public CommonEnabledState Endget_topology_longest_match_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_traceroute_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_traceroute_port(

	) {
		object [] results = this.Invoke("get_traceroute_port", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_traceroute_port(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_traceroute_port", new object[0], callback, asyncState);
	}
	public long Endget_traceroute_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_traceroute_ttl
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_traceroute_ttl(

	) {
		object [] results = this.Invoke("get_traceroute_ttl", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_traceroute_ttl(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_traceroute_ttl", new object[0], callback, asyncState);
	}
	public long Endget_traceroute_ttl(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_use_recursion_bit_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState get_use_recursion_bit_state(

	) {
		object [] results = this.Invoke("get_use_recursion_bit_state", new object [0]);
		return ((CommonEnabledState)(results[0]));
	}
	public System.IAsyncResult Beginget_use_recursion_bit_state(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_use_recursion_bit_state", new object[0], callback, asyncState);
	}
	public CommonEnabledState Endget_use_recursion_bit_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
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
	// get_virtuals_depend_on_server_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState get_virtuals_depend_on_server_state(

	) {
		object [] results = this.Invoke("get_virtuals_depend_on_server_state", new object [0]);
		return ((CommonEnabledState)(results[0]));
	}
	public System.IAsyncResult Beginget_virtuals_depend_on_server_state(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_virtuals_depend_on_server_state", new object[0], callback, asyncState);
	}
	public CommonEnabledState Endget_virtuals_depend_on_server_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState)(results[0]));
	}

	//-----------------------------------------------------------------------
	// set_aol_aware_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_aol_aware_state(
		CommonEnabledState state
	) {
		this.Invoke("set_aol_aware_state", new object [] {
				state});

	}
	public System.IAsyncResult Beginset_aol_aware_state(CommonEnabledState state, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_aol_aware_state", new object[] {
			state}, callback, asyncState);
	}
	public void Endset_aol_aware_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_auto_configuration_save_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_auto_configuration_save_timeout(
		long timeout
	) {
		this.Invoke("set_auto_configuration_save_timeout", new object [] {
				timeout});

	}
	public System.IAsyncResult Beginset_auto_configuration_save_timeout(long timeout, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_auto_configuration_save_timeout", new object[] {
			timeout}, callback, asyncState);
	}
	public void Endset_auto_configuration_save_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_auto_configure_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_auto_configure_state(
		CommonEnabledState state
	) {
		this.Invoke("set_auto_configure_state", new object [] {
				state});

	}
	public System.IAsyncResult Beginset_auto_configure_state(CommonEnabledState state, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_auto_configure_state", new object[] {
			state}, callback, asyncState);
	}
	public void Endset_auto_configure_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_auto_sync_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_auto_sync_state(
		CommonEnabledState state
	) {
		this.Invoke("set_auto_sync_state", new object [] {
				state});

	}
	public System.IAsyncResult Beginset_auto_sync_state(CommonEnabledState state, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_auto_sync_state", new object[] {
			state}, callback, asyncState);
	}
	public void Endset_auto_sync_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_cache_ldns_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_cache_ldns_state(
		CommonEnabledState state
	) {
		this.Invoke("set_cache_ldns_state", new object [] {
				state});

	}
	public System.IAsyncResult Beginset_cache_ldns_state(CommonEnabledState state, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cache_ldns_state", new object[] {
			state}, callback, asyncState);
	}
	public void Endset_cache_ldns_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_check_dynamic_dependency_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_check_dynamic_dependency_state(
		CommonEnabledState state
	) {
		this.Invoke("set_check_dynamic_dependency_state", new object [] {
				state});

	}
	public System.IAsyncResult Beginset_check_dynamic_dependency_state(CommonEnabledState state, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_check_dynamic_dependency_state", new object[] {
			state}, callback, asyncState);
	}
	public void Endset_check_dynamic_dependency_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_check_static_dependency_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_check_static_dependency_state(
		CommonEnabledState state
	) {
		this.Invoke("set_check_static_dependency_state", new object [] {
				state});

	}
	public System.IAsyncResult Beginset_check_static_dependency_state(CommonEnabledState state, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_check_static_dependency_state", new object[] {
			state}, callback, asyncState);
	}
	public void Endset_check_static_dependency_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_alternate_lb_method
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_default_alternate_lb_method(
		GlobalLBLBMethod lb_method
	) {
		this.Invoke("set_default_alternate_lb_method", new object [] {
				lb_method});

	}
	public System.IAsyncResult Beginset_default_alternate_lb_method(GlobalLBLBMethod lb_method, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_alternate_lb_method", new object[] {
			lb_method}, callback, asyncState);
	}
	public void Endset_default_alternate_lb_method(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_fallback_lb_method
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_default_fallback_lb_method(
		GlobalLBLBMethod lb_method
	) {
		this.Invoke("set_default_fallback_lb_method", new object [] {
				lb_method});

	}
	public System.IAsyncResult Beginset_default_fallback_lb_method(GlobalLBLBMethod lb_method, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_fallback_lb_method", new object[] {
			lb_method}, callback, asyncState);
	}
	public void Endset_default_fallback_lb_method(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_probe_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_default_probe_limit(
		long value
	) {
		this.Invoke("set_default_probe_limit", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_default_probe_limit(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_probe_limit", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_default_probe_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_domain_name_check_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_domain_name_check_mode(
		GlobalLBDomainNameCheckMode mode
	) {
		this.Invoke("set_domain_name_check_mode", new object [] {
				mode});

	}
	public System.IAsyncResult Beginset_domain_name_check_mode(GlobalLBDomainNameCheckMode mode, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_domain_name_check_mode", new object[] {
			mode}, callback, asyncState);
	}
	public void Endset_domain_name_check_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_down_multiple
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_down_multiple(
		long value
	) {
		this.Invoke("set_down_multiple", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_down_multiple(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_down_multiple", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_down_multiple(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_down_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_down_threshold(
		long value
	) {
		this.Invoke("set_down_threshold", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_down_threshold(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_down_threshold", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_down_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_drain_request_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_drain_request_state(
		CommonEnabledState state
	) {
		this.Invoke("set_drain_request_state", new object [] {
				state});

	}
	public System.IAsyncResult Beginset_drain_request_state(CommonEnabledState state, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_drain_request_state", new object[] {
			state}, callback, asyncState);
	}
	public void Endset_drain_request_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dump_topology_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_dump_topology_state(
		CommonEnabledState state
	) {
		this.Invoke("set_dump_topology_state", new object [] {
				state});

	}
	public System.IAsyncResult Beginset_dump_topology_state(CommonEnabledState state, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dump_topology_state", new object[] {
			state}, callback, asyncState);
	}
	public void Endset_dump_topology_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fb_respect_acl_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_fb_respect_acl_state(
		CommonEnabledState state
	) {
		this.Invoke("set_fb_respect_acl_state", new object [] {
				state});

	}
	public System.IAsyncResult Beginset_fb_respect_acl_state(CommonEnabledState state, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fb_respect_acl_state", new object[] {
			state}, callback, asyncState);
	}
	public void Endset_fb_respect_acl_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fb_respect_dependency_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_fb_respect_dependency_state(
		CommonEnabledState state
	) {
		this.Invoke("set_fb_respect_dependency_state", new object [] {
				state});

	}
	public System.IAsyncResult Beginset_fb_respect_dependency_state(CommonEnabledState state, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fb_respect_dependency_state", new object[] {
			state}, callback, asyncState);
	}
	public void Endset_fb_respect_dependency_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_forward_status_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_forward_status_state(
		CommonEnabledState state
	) {
		this.Invoke("set_forward_status_state", new object [] {
				state});

	}
	public System.IAsyncResult Beginset_forward_status_state(CommonEnabledState state, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_forward_status_state", new object[] {
			state}, callback, asyncState);
	}
	public void Endset_forward_status_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ldns_duration
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_ldns_duration(
		long value
	) {
		this.Invoke("set_ldns_duration", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_ldns_duration(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ldns_duration", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_ldns_duration(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ldns_probe_protocols
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_ldns_probe_protocols(
		GlobalLBLDNSProbeProtocol [] protocols
	) {
		this.Invoke("set_ldns_probe_protocols", new object [] {
				protocols});

	}
	public System.IAsyncResult Beginset_ldns_probe_protocols(GlobalLBLDNSProbeProtocol [] protocols, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ldns_probe_protocols", new object[] {
			protocols}, callback, asyncState);
	}
	public void Endset_ldns_probe_protocols(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ldns_update_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_ldns_update_interval(
		long value
	) {
		this.Invoke("set_ldns_update_interval", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_ldns_update_interval(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ldns_update_interval", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_ldns_update_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_link_compensate_inbound_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_link_compensate_inbound_state(
		CommonEnabledState state
	) {
		this.Invoke("set_link_compensate_inbound_state", new object [] {
				state});

	}
	public System.IAsyncResult Beginset_link_compensate_inbound_state(CommonEnabledState state, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_link_compensate_inbound_state", new object[] {
			state}, callback, asyncState);
	}
	public void Endset_link_compensate_inbound_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_link_compensate_outbound_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_link_compensate_outbound_state(
		CommonEnabledState state
	) {
		this.Invoke("set_link_compensate_outbound_state", new object [] {
				state});

	}
	public System.IAsyncResult Beginset_link_compensate_outbound_state(CommonEnabledState state, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_link_compensate_outbound_state", new object[] {
			state}, callback, asyncState);
	}
	public void Endset_link_compensate_outbound_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_link_compensation_history
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_link_compensation_history(
		long value
	) {
		this.Invoke("set_link_compensation_history", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_link_compensation_history(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_link_compensation_history", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_link_compensation_history(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_link_limit_factor
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_link_limit_factor(
		long value
	) {
		this.Invoke("set_link_limit_factor", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_link_limit_factor(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_link_limit_factor", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_link_limit_factor(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_link_prepaid_factor
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_link_prepaid_factor(
		long value
	) {
		this.Invoke("set_link_prepaid_factor", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_link_prepaid_factor(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_link_prepaid_factor", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_link_prepaid_factor(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_lnds_duration
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_lnds_duration(
		long value
	) {
		this.Invoke("set_lnds_duration", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_lnds_duration(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_lnds_duration", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_lnds_duration(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_lower_bound_percentage_column
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_lower_bound_percentage_column(
		long value
	) {
		this.Invoke("set_lower_bound_percentage_column", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_lower_bound_percentage_column(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_lower_bound_percentage_column", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_lower_bound_percentage_column(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_lower_bound_percentage_row
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_lower_bound_percentage_row(
		long value
	) {
		this.Invoke("set_lower_bound_percentage_row", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_lower_bound_percentage_row(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_lower_bound_percentage_row", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_lower_bound_percentage_row(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_link_over_limit_count
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_maximum_link_over_limit_count(
		long value
	) {
		this.Invoke("set_maximum_link_over_limit_count", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_maximum_link_over_limit_count(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_link_over_limit_count", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_maximum_link_over_limit_count(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_synchronous_monitor_request
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_maximum_synchronous_monitor_request(
		long value
	) {
		this.Invoke("set_maximum_synchronous_monitor_request", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_maximum_synchronous_monitor_request(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_synchronous_monitor_request", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_maximum_synchronous_monitor_request(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_over_limit_link_limit_factor
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_over_limit_link_limit_factor(
		long value
	) {
		this.Invoke("set_over_limit_link_limit_factor", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_over_limit_link_limit_factor(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_over_limit_link_limit_factor", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_over_limit_link_limit_factor(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_path_duration
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_path_duration(
		long value
	) {
		this.Invoke("set_path_duration", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_path_duration(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_path_duration", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_path_duration(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_path_ttl
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_path_ttl(
		long value
	) {
		this.Invoke("set_path_ttl", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_path_ttl(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_path_ttl", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_path_ttl(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_paths_never_die_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_paths_never_die_state(
		CommonEnabledState state
	) {
		this.Invoke("set_paths_never_die_state", new object [] {
				state});

	}
	public System.IAsyncResult Beginset_paths_never_die_state(CommonEnabledState state, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_paths_never_die_state", new object[] {
			state}, callback, asyncState);
	}
	public void Endset_paths_never_die_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_peer_leader
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_peer_leader(
		string leader
	) {
		this.Invoke("set_peer_leader", new object [] {
				leader});

	}
	public System.IAsyncResult Beginset_peer_leader(string leader, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_peer_leader", new object[] {
			leader}, callback, asyncState);
	}
	public void Endset_peer_leader(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_persistence_mask
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_persistence_mask(
		long value
	) {
		this.Invoke("set_persistence_mask", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_persistence_mask(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_persistence_mask", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_persistence_mask(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_probe_disabled_object_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_probe_disabled_object_state(
		CommonEnabledState state
	) {
		this.Invoke("set_probe_disabled_object_state", new object [] {
				state});

	}
	public System.IAsyncResult Beginset_probe_disabled_object_state(CommonEnabledState state, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_probe_disabled_object_state", new object[] {
			state}, callback, asyncState);
	}
	public void Endset_probe_disabled_object_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_propagate_wild_card_a_records_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_propagate_wild_card_a_records_state(
		CommonEnabledState state
	) {
		this.Invoke("set_propagate_wild_card_a_records_state", new object [] {
				state});

	}
	public System.IAsyncResult Beginset_propagate_wild_card_a_records_state(CommonEnabledState state, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_propagate_wild_card_a_records_state", new object[] {
			state}, callback, asyncState);
	}
	public void Endset_propagate_wild_card_a_records_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_qos_factor_bps
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_qos_factor_bps(
		long value
	) {
		this.Invoke("set_qos_factor_bps", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_qos_factor_bps(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_qos_factor_bps", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_qos_factor_bps(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_qos_factor_connection_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_qos_factor_connection_rate(
		long value
	) {
		this.Invoke("set_qos_factor_connection_rate", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_qos_factor_connection_rate(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_qos_factor_connection_rate", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_qos_factor_connection_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_qos_factor_hit_ratio
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_qos_factor_hit_ratio(
		long value
	) {
		this.Invoke("set_qos_factor_hit_ratio", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_qos_factor_hit_ratio(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_qos_factor_hit_ratio", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_qos_factor_hit_ratio(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_qos_factor_hops
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_qos_factor_hops(
		long value
	) {
		this.Invoke("set_qos_factor_hops", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_qos_factor_hops(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_qos_factor_hops", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_qos_factor_hops(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_qos_factor_lcs
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_qos_factor_lcs(
		long value
	) {
		this.Invoke("set_qos_factor_lcs", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_qos_factor_lcs(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_qos_factor_lcs", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_qos_factor_lcs(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_qos_factor_packet_rate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_qos_factor_packet_rate(
		long value
	) {
		this.Invoke("set_qos_factor_packet_rate", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_qos_factor_packet_rate(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_qos_factor_packet_rate", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_qos_factor_packet_rate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_qos_factor_rtt
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_qos_factor_rtt(
		long value
	) {
		this.Invoke("set_qos_factor_rtt", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_qos_factor_rtt(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_qos_factor_rtt", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_qos_factor_rtt(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_qos_factor_topology
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_qos_factor_topology(
		long value
	) {
		this.Invoke("set_qos_factor_topology", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_qos_factor_topology(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_qos_factor_topology", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_qos_factor_topology(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_qos_factor_vs_capacity
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_qos_factor_vs_capacity(
		long value
	) {
		this.Invoke("set_qos_factor_vs_capacity", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_qos_factor_vs_capacity(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_qos_factor_vs_capacity", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_qos_factor_vs_capacity(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_qos_factor_vs_score
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_qos_factor_vs_score(
		long value
	) {
		this.Invoke("set_qos_factor_vs_score", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_qos_factor_vs_score(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_qos_factor_vs_score", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_qos_factor_vs_score(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_reset_ripeness_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_reset_ripeness_state(
		CommonEnabledState state
	) {
		this.Invoke("set_reset_ripeness_state", new object [] {
				state});

	}
	public System.IAsyncResult Beginset_reset_ripeness_state(CommonEnabledState state, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_reset_ripeness_state", new object[] {
			state}, callback, asyncState);
	}
	public void Endset_reset_ripeness_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rtt_packet_length
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_rtt_packet_length(
		long value
	) {
		this.Invoke("set_rtt_packet_length", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_rtt_packet_length(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rtt_packet_length", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_rtt_packet_length(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rtt_sample_count
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_rtt_sample_count(
		long value
	) {
		this.Invoke("set_rtt_sample_count", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_rtt_sample_count(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rtt_sample_count", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_rtt_sample_count(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rtt_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_rtt_timeout(
		long value
	) {
		this.Invoke("set_rtt_timeout", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_rtt_timeout(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rtt_timeout", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_rtt_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_static_persistence_cidr_mask
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_static_persistence_cidr_mask(
		long value,
		bool v6
	) {
		this.Invoke("set_static_persistence_cidr_mask", new object [] {
				value,
				v6});

	}
	public System.IAsyncResult Beginset_static_persistence_cidr_mask(long value,bool v6, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_static_persistence_cidr_mask", new object[] {
			value,
			v6}, callback, asyncState);
	}
	public void Endset_static_persistence_cidr_mask(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_sync_group_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_sync_group_name(
		string sync_group_name
	) {
		this.Invoke("set_sync_group_name", new object [] {
				sync_group_name});

	}
	public System.IAsyncResult Beginset_sync_group_name(string sync_group_name, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_sync_group_name", new object[] {
			sync_group_name}, callback, asyncState);
	}
	public void Endset_sync_group_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_sync_named_configuration_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_sync_named_configuration_state(
		CommonEnabledState state
	) {
		this.Invoke("set_sync_named_configuration_state", new object [] {
				state});

	}
	public System.IAsyncResult Beginset_sync_named_configuration_state(CommonEnabledState state, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_sync_named_configuration_state", new object[] {
			state}, callback, asyncState);
	}
	public void Endset_sync_named_configuration_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_sync_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_sync_timeout(
		long value
	) {
		this.Invoke("set_sync_timeout", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_sync_timeout(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_sync_timeout", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_sync_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_sync_zone_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_sync_zone_timeout(
		long value
	) {
		this.Invoke("set_sync_zone_timeout", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_sync_zone_timeout(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_sync_zone_timeout", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_sync_zone_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_time_tolerance
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_time_tolerance(
		long value
	) {
		this.Invoke("set_time_tolerance", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_time_tolerance(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_time_tolerance", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_time_tolerance(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_timer_get_auto_configuration_data
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_timer_get_auto_configuration_data(
		long value
	) {
		this.Invoke("set_timer_get_auto_configuration_data", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_timer_get_auto_configuration_data(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_timer_get_auto_configuration_data", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_timer_get_auto_configuration_data(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_timer_heartbeat
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_timer_heartbeat(
		long value
	) {
		this.Invoke("set_timer_heartbeat", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_timer_heartbeat(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_timer_heartbeat", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_timer_heartbeat(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_timer_persistence_cache
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_timer_persistence_cache(
		long value
	) {
		this.Invoke("set_timer_persistence_cache", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_timer_persistence_cache(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_timer_persistence_cache", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_timer_persistence_cache(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_timer_retry_path_data
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_timer_retry_path_data(
		long value
	) {
		this.Invoke("set_timer_retry_path_data", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_timer_retry_path_data(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_timer_retry_path_data", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_timer_retry_path_data(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_topology_acl_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_topology_acl_threshold(
		long value
	) {
		this.Invoke("set_topology_acl_threshold", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_topology_acl_threshold(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_topology_acl_threshold", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_topology_acl_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_topology_allow_zero_scores_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_topology_allow_zero_scores_state(
		CommonEnabledState state
	) {
		this.Invoke("set_topology_allow_zero_scores_state", new object [] {
				state});

	}
	public System.IAsyncResult Beginset_topology_allow_zero_scores_state(CommonEnabledState state, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_topology_allow_zero_scores_state", new object[] {
			state}, callback, asyncState);
	}
	public void Endset_topology_allow_zero_scores_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_topology_longest_match_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_topology_longest_match_state(
		CommonEnabledState state
	) {
		this.Invoke("set_topology_longest_match_state", new object [] {
				state});

	}
	public System.IAsyncResult Beginset_topology_longest_match_state(CommonEnabledState state, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_topology_longest_match_state", new object[] {
			state}, callback, asyncState);
	}
	public void Endset_topology_longest_match_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_traceroute_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_traceroute_port(
		long value
	) {
		this.Invoke("set_traceroute_port", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_traceroute_port(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_traceroute_port", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_traceroute_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_traceroute_ttl
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_traceroute_ttl(
		long value
	) {
		this.Invoke("set_traceroute_ttl", new object [] {
				value});

	}
	public System.IAsyncResult Beginset_traceroute_ttl(long value, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_traceroute_ttl", new object[] {
			value}, callback, asyncState);
	}
	public void Endset_traceroute_ttl(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_use_recursion_bit_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_use_recursion_bit_state(
		CommonEnabledState state
	) {
		this.Invoke("set_use_recursion_bit_state", new object [] {
				state});

	}
	public System.IAsyncResult Beginset_use_recursion_bit_state(CommonEnabledState state, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_use_recursion_bit_state", new object[] {
			state}, callback, asyncState);
	}
	public void Endset_use_recursion_bit_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_virtuals_depend_on_server_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Globals", 
		RequestNamespace="urn:iControl:GlobalLB/Globals", ResponseNamespace="urn:iControl:GlobalLB/Globals")]
	public void set_virtuals_depend_on_server_state(
		CommonEnabledState state
	) {
		this.Invoke("set_virtuals_depend_on_server_state", new object [] {
				state});

	}
	public System.IAsyncResult Beginset_virtuals_depend_on_server_state(CommonEnabledState state, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_virtuals_depend_on_server_state", new object[] {
			state}, callback, asyncState);
	}
	public void Endset_virtuals_depend_on_server_state(System.IAsyncResult asyncResult) {
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
