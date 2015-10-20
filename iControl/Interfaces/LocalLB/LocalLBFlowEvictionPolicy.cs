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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.FlowEvictionPolicyBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBFlowEvictionPolicyPortProtocolPair))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBFlowEvictionPolicyFlowEvictionPolicyStatistics))]
	public partial class LocalLBFlowEvictionPolicy : iControlInterface {
		public LocalLBFlowEvictionPolicy() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_eviction_strategy_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	public void add_eviction_strategy_port(
		string [] policies,
		LocalLBFlowEvictionPolicyPortProtocolPair [] [] ports
	) {
		this.Invoke("add_eviction_strategy_port", new object [] {
				policies,
				ports});

	}
	public System.IAsyncResult Beginadd_eviction_strategy_port(string [] policies,LocalLBFlowEvictionPolicyPortProtocolPair [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_eviction_strategy_port", new object[] {
			policies,
			ports}, callback, asyncState);
	}
	public void Endadd_eviction_strategy_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_low_priority_geography
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	public void add_low_priority_geography(
		string [] policies,
		string [] [] countries
	) {
		this.Invoke("add_low_priority_geography", new object [] {
				policies,
				countries});

	}
	public System.IAsyncResult Beginadd_low_priority_geography(string [] policies,string [] [] countries, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_low_priority_geography", new object[] {
			policies,
			countries}, callback, asyncState);
	}
	public void Endadd_low_priority_geography(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_low_priority_route_domain
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	public void add_low_priority_route_domain(
		string [] policies,
		string [] [] route_domains
	) {
		this.Invoke("add_low_priority_route_domain", new object [] {
				policies,
				route_domains});

	}
	public System.IAsyncResult Beginadd_low_priority_route_domain(string [] policies,string [] [] route_domains, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_low_priority_route_domain", new object[] {
			policies,
			route_domains}, callback, asyncState);
	}
	public void Endadd_low_priority_route_domain(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_low_priority_virtual_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	public void add_low_priority_virtual_server(
		string [] policies,
		string [] [] virtual_servers
	) {
		this.Invoke("add_low_priority_virtual_server", new object [] {
				policies,
				virtual_servers});

	}
	public System.IAsyncResult Beginadd_low_priority_virtual_server(string [] policies,string [] [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_low_priority_virtual_server", new object[] {
			policies,
			virtual_servers}, callback, asyncState);
	}
	public void Endadd_low_priority_virtual_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	public void create(
		string [] policies
	) {
		this.Invoke("create", new object [] {
				policies});

	}
	public System.IAsyncResult Begincreate(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			policies}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_eviction_policies
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	public void delete_all_eviction_policies(

	) {
		this.Invoke("delete_all_eviction_policies", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_eviction_policies(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_eviction_policies", new object[0], callback, asyncState);
	}
	public void Enddelete_all_eviction_policies(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_eviction_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	public void delete_eviction_policy(
		string [] policies
	) {
		this.Invoke("delete_eviction_policy", new object [] {
				policies});

	}
	public System.IAsyncResult Begindelete_eviction_policy(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_eviction_policy", new object[] {
			policies}, callback, asyncState);
	}
	public void Enddelete_eviction_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBFlowEvictionPolicyFlowEvictionPolicyStatistics [] get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((LocalLBFlowEvictionPolicyFlowEvictionPolicyStatistics [])(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public LocalLBFlowEvictionPolicyFlowEvictionPolicyStatistics [] Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBFlowEvictionPolicyFlowEvictionPolicyStatistics [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] policies
	) {
		object [] results = this.Invoke("get_description", new object [] {
				policies});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			policies}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_eviction_strategy_bias_bytes_delay
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_eviction_strategy_bias_bytes_delay(
		string [] policies
	) {
		object [] results = this.Invoke("get_eviction_strategy_bias_bytes_delay", new object [] {
				policies});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_eviction_strategy_bias_bytes_delay(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_eviction_strategy_bias_bytes_delay", new object[] {
			policies}, callback, asyncState);
	}
	public long [] Endget_eviction_strategy_bias_bytes_delay(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_eviction_strategy_bias_fast_delay
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_eviction_strategy_bias_fast_delay(
		string [] policies
	) {
		object [] results = this.Invoke("get_eviction_strategy_bias_fast_delay", new object [] {
				policies});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_eviction_strategy_bias_fast_delay(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_eviction_strategy_bias_fast_delay", new object[] {
			policies}, callback, asyncState);
	}
	public long [] Endget_eviction_strategy_bias_fast_delay(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_eviction_strategy_bias_slow_delay
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_eviction_strategy_bias_slow_delay(
		string [] policies
	) {
		object [] results = this.Invoke("get_eviction_strategy_bias_slow_delay", new object [] {
				policies});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_eviction_strategy_bias_slow_delay(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_eviction_strategy_bias_slow_delay", new object[] {
			policies}, callback, asyncState);
	}
	public long [] Endget_eviction_strategy_bias_slow_delay(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_eviction_strategy_bytes_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_eviction_strategy_bytes_state(
		string [] policies
	) {
		object [] results = this.Invoke("get_eviction_strategy_bytes_state", new object [] {
				policies});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_eviction_strategy_bytes_state(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_eviction_strategy_bytes_state", new object[] {
			policies}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_eviction_strategy_bytes_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_eviction_strategy_fast_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_eviction_strategy_fast_state(
		string [] policies
	) {
		object [] results = this.Invoke("get_eviction_strategy_fast_state", new object [] {
				policies});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_eviction_strategy_fast_state(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_eviction_strategy_fast_state", new object[] {
			policies}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_eviction_strategy_fast_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_eviction_strategy_geography_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_eviction_strategy_geography_state(
		string [] policies
	) {
		object [] results = this.Invoke("get_eviction_strategy_geography_state", new object [] {
				policies});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_eviction_strategy_geography_state(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_eviction_strategy_geography_state", new object[] {
			policies}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_eviction_strategy_geography_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_eviction_strategy_idle_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_eviction_strategy_idle_state(
		string [] policies
	) {
		object [] results = this.Invoke("get_eviction_strategy_idle_state", new object [] {
				policies});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_eviction_strategy_idle_state(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_eviction_strategy_idle_state", new object[] {
			policies}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_eviction_strategy_idle_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_eviction_strategy_oldest_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_eviction_strategy_oldest_state(
		string [] policies
	) {
		object [] results = this.Invoke("get_eviction_strategy_oldest_state", new object [] {
				policies});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_eviction_strategy_oldest_state(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_eviction_strategy_oldest_state", new object[] {
			policies}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_eviction_strategy_oldest_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_eviction_strategy_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBFlowEvictionPolicyPortProtocolPair [] [] get_eviction_strategy_port(
		string [] policies
	) {
		object [] results = this.Invoke("get_eviction_strategy_port", new object [] {
				policies});
		return ((LocalLBFlowEvictionPolicyPortProtocolPair [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_eviction_strategy_port(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_eviction_strategy_port", new object[] {
			policies}, callback, asyncState);
	}
	public LocalLBFlowEvictionPolicyPortProtocolPair [] [] Endget_eviction_strategy_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBFlowEvictionPolicyPortProtocolPair [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_eviction_strategy_port_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_eviction_strategy_port_description(
		string [] policies,
		LocalLBFlowEvictionPolicyPortProtocolPair [] [] ports
	) {
		object [] results = this.Invoke("get_eviction_strategy_port_description", new object [] {
				policies,
				ports});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_eviction_strategy_port_description(string [] policies,LocalLBFlowEvictionPolicyPortProtocolPair [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_eviction_strategy_port_description", new object[] {
			policies,
			ports}, callback, asyncState);
	}
	public string [] [] Endget_eviction_strategy_port_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_eviction_strategy_port_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_eviction_strategy_port_state(
		string [] policies
	) {
		object [] results = this.Invoke("get_eviction_strategy_port_state", new object [] {
				policies});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_eviction_strategy_port_state(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_eviction_strategy_port_state", new object[] {
			policies}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_eviction_strategy_port_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_eviction_strategy_route_domain_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_eviction_strategy_route_domain_state(
		string [] policies
	) {
		object [] results = this.Invoke("get_eviction_strategy_route_domain_state", new object [] {
				policies});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_eviction_strategy_route_domain_state(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_eviction_strategy_route_domain_state", new object[] {
			policies}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_eviction_strategy_route_domain_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_eviction_strategy_slow_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_eviction_strategy_slow_state(
		string [] policies
	) {
		object [] results = this.Invoke("get_eviction_strategy_slow_state", new object [] {
				policies});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_eviction_strategy_slow_state(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_eviction_strategy_slow_state", new object[] {
			policies}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_eviction_strategy_slow_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_eviction_strategy_virtual_server_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_eviction_strategy_virtual_server_state(
		string [] policies
	) {
		object [] results = this.Invoke("get_eviction_strategy_virtual_server_state", new object [] {
				policies});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_eviction_strategy_virtual_server_state(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_eviction_strategy_virtual_server_state", new object[] {
			policies}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_eviction_strategy_virtual_server_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_high_water
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_high_water(
		string [] policies
	) {
		object [] results = this.Invoke("get_high_water", new object [] {
				policies});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_high_water(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_high_water", new object[] {
			policies}, callback, asyncState);
	}
	public long [] Endget_high_water(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
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
	// get_low_priority_geography
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_low_priority_geography(
		string [] policies
	) {
		object [] results = this.Invoke("get_low_priority_geography", new object [] {
				policies});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_low_priority_geography(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_low_priority_geography", new object[] {
			policies}, callback, asyncState);
	}
	public string [] [] Endget_low_priority_geography(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_low_priority_route_domain
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_low_priority_route_domain(
		string [] policies
	) {
		object [] results = this.Invoke("get_low_priority_route_domain", new object [] {
				policies});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_low_priority_route_domain(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_low_priority_route_domain", new object[] {
			policies}, callback, asyncState);
	}
	public string [] [] Endget_low_priority_route_domain(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_low_priority_virtual_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_low_priority_virtual_server(
		string [] policies
	) {
		object [] results = this.Invoke("get_low_priority_virtual_server", new object [] {
				policies});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_low_priority_virtual_server(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_low_priority_virtual_server", new object[] {
			policies}, callback, asyncState);
	}
	public string [] [] Endget_low_priority_virtual_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_low_water
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_low_water(
		string [] policies
	) {
		object [] results = this.Invoke("get_low_water", new object [] {
				policies});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_low_water(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_low_water", new object[] {
			policies}, callback, asyncState);
	}
	public long [] Endget_low_water(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_slow_flow_maximum
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_slow_flow_maximum(
		string [] policies
	) {
		object [] results = this.Invoke("get_slow_flow_maximum", new object [] {
				policies});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_slow_flow_maximum(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_slow_flow_maximum", new object[] {
			policies}, callback, asyncState);
	}
	public long [] Endget_slow_flow_maximum(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_slow_flow_monitoring_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_slow_flow_monitoring_state(
		string [] policies
	) {
		object [] results = this.Invoke("get_slow_flow_monitoring_state", new object [] {
				policies});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_slow_flow_monitoring_state(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_slow_flow_monitoring_state", new object[] {
			policies}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_slow_flow_monitoring_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_slow_flow_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_slow_flow_threshold(
		string [] policies
	) {
		object [] results = this.Invoke("get_slow_flow_threshold", new object [] {
				policies});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_slow_flow_threshold(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_slow_flow_threshold", new object[] {
			policies}, callback, asyncState);
	}
	public long [] Endget_slow_flow_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_slow_flow_throttle_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBFlowEvictionPolicyEvictionSlowFlowThrottleType [] get_slow_flow_throttle_type(
		string [] policies
	) {
		object [] results = this.Invoke("get_slow_flow_throttle_type", new object [] {
				policies});
		return ((LocalLBFlowEvictionPolicyEvictionSlowFlowThrottleType [])(results[0]));
	}
	public System.IAsyncResult Beginget_slow_flow_throttle_type(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_slow_flow_throttle_type", new object[] {
			policies}, callback, asyncState);
	}
	public LocalLBFlowEvictionPolicyEvictionSlowFlowThrottleType [] Endget_slow_flow_throttle_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBFlowEvictionPolicyEvictionSlowFlowThrottleType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_slow_flow_throttling_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_slow_flow_throttling_state(
		string [] policies
	) {
		object [] results = this.Invoke("get_slow_flow_throttling_state", new object [] {
				policies});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_slow_flow_throttling_state(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_slow_flow_throttling_state", new object[] {
			policies}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_slow_flow_throttling_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBFlowEvictionPolicyFlowEvictionPolicyStatistics [] get_statistics(
		string [] policies
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				policies});
		return ((LocalLBFlowEvictionPolicyFlowEvictionPolicyStatistics [])(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			policies}, callback, asyncState);
	}
	public LocalLBFlowEvictionPolicyFlowEvictionPolicyStatistics [] Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBFlowEvictionPolicyFlowEvictionPolicyStatistics [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
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
	// remove_all_eviction_strategy_ports
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	public void remove_all_eviction_strategy_ports(
		string [] policies
	) {
		this.Invoke("remove_all_eviction_strategy_ports", new object [] {
				policies});

	}
	public System.IAsyncResult Beginremove_all_eviction_strategy_ports(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_eviction_strategy_ports", new object[] {
			policies}, callback, asyncState);
	}
	public void Endremove_all_eviction_strategy_ports(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_low_priority_geographies
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	public void remove_all_low_priority_geographies(
		string [] policies
	) {
		this.Invoke("remove_all_low_priority_geographies", new object [] {
				policies});

	}
	public System.IAsyncResult Beginremove_all_low_priority_geographies(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_low_priority_geographies", new object[] {
			policies}, callback, asyncState);
	}
	public void Endremove_all_low_priority_geographies(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_low_priority_route_domains
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	public void remove_all_low_priority_route_domains(
		string [] policies
	) {
		this.Invoke("remove_all_low_priority_route_domains", new object [] {
				policies});

	}
	public System.IAsyncResult Beginremove_all_low_priority_route_domains(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_low_priority_route_domains", new object[] {
			policies}, callback, asyncState);
	}
	public void Endremove_all_low_priority_route_domains(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_low_priority_virtual_servers
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	public void remove_all_low_priority_virtual_servers(
		string [] policies
	) {
		this.Invoke("remove_all_low_priority_virtual_servers", new object [] {
				policies});

	}
	public System.IAsyncResult Beginremove_all_low_priority_virtual_servers(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_low_priority_virtual_servers", new object[] {
			policies}, callback, asyncState);
	}
	public void Endremove_all_low_priority_virtual_servers(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_eviction_strategy_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	public void remove_eviction_strategy_port(
		string [] policies,
		LocalLBFlowEvictionPolicyPortProtocolPair [] [] ports
	) {
		this.Invoke("remove_eviction_strategy_port", new object [] {
				policies,
				ports});

	}
	public System.IAsyncResult Beginremove_eviction_strategy_port(string [] policies,LocalLBFlowEvictionPolicyPortProtocolPair [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_eviction_strategy_port", new object[] {
			policies,
			ports}, callback, asyncState);
	}
	public void Endremove_eviction_strategy_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_low_priority_geography
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	public void remove_low_priority_geography(
		string [] policies,
		string [] [] countries
	) {
		this.Invoke("remove_low_priority_geography", new object [] {
				policies,
				countries});

	}
	public System.IAsyncResult Beginremove_low_priority_geography(string [] policies,string [] [] countries, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_low_priority_geography", new object[] {
			policies,
			countries}, callback, asyncState);
	}
	public void Endremove_low_priority_geography(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_low_priority_route_domain
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	public void remove_low_priority_route_domain(
		string [] policies,
		string [] [] route_domains
	) {
		this.Invoke("remove_low_priority_route_domain", new object [] {
				policies,
				route_domains});

	}
	public System.IAsyncResult Beginremove_low_priority_route_domain(string [] policies,string [] [] route_domains, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_low_priority_route_domain", new object[] {
			policies,
			route_domains}, callback, asyncState);
	}
	public void Endremove_low_priority_route_domain(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_low_priority_virtual_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	public void remove_low_priority_virtual_server(
		string [] policies,
		string [] [] virtual_servers
	) {
		this.Invoke("remove_low_priority_virtual_server", new object [] {
				policies,
				virtual_servers});

	}
	public System.IAsyncResult Beginremove_low_priority_virtual_server(string [] policies,string [] [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_low_priority_virtual_server", new object[] {
			policies,
			virtual_servers}, callback, asyncState);
	}
	public void Endremove_low_priority_virtual_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	public void reset_statistics(
		string [] policies
	) {
		this.Invoke("reset_statistics", new object [] {
				policies});

	}
	public System.IAsyncResult Beginreset_statistics(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics", new object[] {
			policies}, callback, asyncState);
	}
	public void Endreset_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	public void set_description(
		string [] policies,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				policies,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] policies,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			policies,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_eviction_strategy_bias_bytes_delay
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	public void set_eviction_strategy_bias_bytes_delay(
		string [] policies,
		long [] delays
	) {
		this.Invoke("set_eviction_strategy_bias_bytes_delay", new object [] {
				policies,
				delays});

	}
	public System.IAsyncResult Beginset_eviction_strategy_bias_bytes_delay(string [] policies,long [] delays, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_eviction_strategy_bias_bytes_delay", new object[] {
			policies,
			delays}, callback, asyncState);
	}
	public void Endset_eviction_strategy_bias_bytes_delay(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_eviction_strategy_bias_fast_delay
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	public void set_eviction_strategy_bias_fast_delay(
		string [] policies,
		long [] delays
	) {
		this.Invoke("set_eviction_strategy_bias_fast_delay", new object [] {
				policies,
				delays});

	}
	public System.IAsyncResult Beginset_eviction_strategy_bias_fast_delay(string [] policies,long [] delays, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_eviction_strategy_bias_fast_delay", new object[] {
			policies,
			delays}, callback, asyncState);
	}
	public void Endset_eviction_strategy_bias_fast_delay(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_eviction_strategy_bias_slow_delay
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	public void set_eviction_strategy_bias_slow_delay(
		string [] policies,
		long [] delays
	) {
		this.Invoke("set_eviction_strategy_bias_slow_delay", new object [] {
				policies,
				delays});

	}
	public System.IAsyncResult Beginset_eviction_strategy_bias_slow_delay(string [] policies,long [] delays, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_eviction_strategy_bias_slow_delay", new object[] {
			policies,
			delays}, callback, asyncState);
	}
	public void Endset_eviction_strategy_bias_slow_delay(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_eviction_strategy_bytes_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	public void set_eviction_strategy_bytes_state(
		string [] policies,
		CommonEnabledState [] states
	) {
		this.Invoke("set_eviction_strategy_bytes_state", new object [] {
				policies,
				states});

	}
	public System.IAsyncResult Beginset_eviction_strategy_bytes_state(string [] policies,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_eviction_strategy_bytes_state", new object[] {
			policies,
			states}, callback, asyncState);
	}
	public void Endset_eviction_strategy_bytes_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_eviction_strategy_fast_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	public void set_eviction_strategy_fast_state(
		string [] policies,
		CommonEnabledState [] states
	) {
		this.Invoke("set_eviction_strategy_fast_state", new object [] {
				policies,
				states});

	}
	public System.IAsyncResult Beginset_eviction_strategy_fast_state(string [] policies,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_eviction_strategy_fast_state", new object[] {
			policies,
			states}, callback, asyncState);
	}
	public void Endset_eviction_strategy_fast_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_eviction_strategy_geography_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	public void set_eviction_strategy_geography_state(
		string [] policies,
		CommonEnabledState [] states
	) {
		this.Invoke("set_eviction_strategy_geography_state", new object [] {
				policies,
				states});

	}
	public System.IAsyncResult Beginset_eviction_strategy_geography_state(string [] policies,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_eviction_strategy_geography_state", new object[] {
			policies,
			states}, callback, asyncState);
	}
	public void Endset_eviction_strategy_geography_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_eviction_strategy_idle_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	public void set_eviction_strategy_idle_state(
		string [] policies,
		CommonEnabledState [] states
	) {
		this.Invoke("set_eviction_strategy_idle_state", new object [] {
				policies,
				states});

	}
	public System.IAsyncResult Beginset_eviction_strategy_idle_state(string [] policies,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_eviction_strategy_idle_state", new object[] {
			policies,
			states}, callback, asyncState);
	}
	public void Endset_eviction_strategy_idle_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_eviction_strategy_oldest_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	public void set_eviction_strategy_oldest_state(
		string [] policies,
		CommonEnabledState [] states
	) {
		this.Invoke("set_eviction_strategy_oldest_state", new object [] {
				policies,
				states});

	}
	public System.IAsyncResult Beginset_eviction_strategy_oldest_state(string [] policies,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_eviction_strategy_oldest_state", new object[] {
			policies,
			states}, callback, asyncState);
	}
	public void Endset_eviction_strategy_oldest_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_eviction_strategy_port_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	public void set_eviction_strategy_port_description(
		string [] policies,
		LocalLBFlowEvictionPolicyPortProtocolPair [] [] ports,
		string [] [] descriptions
	) {
		this.Invoke("set_eviction_strategy_port_description", new object [] {
				policies,
				ports,
				descriptions});

	}
	public System.IAsyncResult Beginset_eviction_strategy_port_description(string [] policies,LocalLBFlowEvictionPolicyPortProtocolPair [] [] ports,string [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_eviction_strategy_port_description", new object[] {
			policies,
			ports,
			descriptions}, callback, asyncState);
	}
	public void Endset_eviction_strategy_port_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_eviction_strategy_port_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	public void set_eviction_strategy_port_state(
		string [] policies,
		CommonEnabledState [] states
	) {
		this.Invoke("set_eviction_strategy_port_state", new object [] {
				policies,
				states});

	}
	public System.IAsyncResult Beginset_eviction_strategy_port_state(string [] policies,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_eviction_strategy_port_state", new object[] {
			policies,
			states}, callback, asyncState);
	}
	public void Endset_eviction_strategy_port_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_eviction_strategy_route_domain_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	public void set_eviction_strategy_route_domain_state(
		string [] policies,
		CommonEnabledState [] states
	) {
		this.Invoke("set_eviction_strategy_route_domain_state", new object [] {
				policies,
				states});

	}
	public System.IAsyncResult Beginset_eviction_strategy_route_domain_state(string [] policies,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_eviction_strategy_route_domain_state", new object[] {
			policies,
			states}, callback, asyncState);
	}
	public void Endset_eviction_strategy_route_domain_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_eviction_strategy_slow_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	public void set_eviction_strategy_slow_state(
		string [] policies,
		CommonEnabledState [] states
	) {
		this.Invoke("set_eviction_strategy_slow_state", new object [] {
				policies,
				states});

	}
	public System.IAsyncResult Beginset_eviction_strategy_slow_state(string [] policies,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_eviction_strategy_slow_state", new object[] {
			policies,
			states}, callback, asyncState);
	}
	public void Endset_eviction_strategy_slow_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_eviction_strategy_virtual_server_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	public void set_eviction_strategy_virtual_server_state(
		string [] policies,
		CommonEnabledState [] states
	) {
		this.Invoke("set_eviction_strategy_virtual_server_state", new object [] {
				policies,
				states});

	}
	public System.IAsyncResult Beginset_eviction_strategy_virtual_server_state(string [] policies,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_eviction_strategy_virtual_server_state", new object[] {
			policies,
			states}, callback, asyncState);
	}
	public void Endset_eviction_strategy_virtual_server_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_high_water
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	public void set_high_water(
		string [] policies,
		long [] values
	) {
		this.Invoke("set_high_water", new object [] {
				policies,
				values});

	}
	public System.IAsyncResult Beginset_high_water(string [] policies,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_high_water", new object[] {
			policies,
			values}, callback, asyncState);
	}
	public void Endset_high_water(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_low_water
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	public void set_low_water(
		string [] policies,
		long [] values
	) {
		this.Invoke("set_low_water", new object [] {
				policies,
				values});

	}
	public System.IAsyncResult Beginset_low_water(string [] policies,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_low_water", new object[] {
			policies,
			values}, callback, asyncState);
	}
	public void Endset_low_water(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_slow_flow_maximum
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	public void set_slow_flow_maximum(
		string [] policies,
		long [] values
	) {
		this.Invoke("set_slow_flow_maximum", new object [] {
				policies,
				values});

	}
	public System.IAsyncResult Beginset_slow_flow_maximum(string [] policies,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_slow_flow_maximum", new object[] {
			policies,
			values}, callback, asyncState);
	}
	public void Endset_slow_flow_maximum(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_slow_flow_monitoring_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	public void set_slow_flow_monitoring_state(
		string [] policies,
		CommonEnabledState [] states
	) {
		this.Invoke("set_slow_flow_monitoring_state", new object [] {
				policies,
				states});

	}
	public System.IAsyncResult Beginset_slow_flow_monitoring_state(string [] policies,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_slow_flow_monitoring_state", new object[] {
			policies,
			states}, callback, asyncState);
	}
	public void Endset_slow_flow_monitoring_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_slow_flow_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	public void set_slow_flow_threshold(
		string [] policies,
		long [] thresholds
	) {
		this.Invoke("set_slow_flow_threshold", new object [] {
				policies,
				thresholds});

	}
	public System.IAsyncResult Beginset_slow_flow_threshold(string [] policies,long [] thresholds, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_slow_flow_threshold", new object[] {
			policies,
			thresholds}, callback, asyncState);
	}
	public void Endset_slow_flow_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_slow_flow_throttle_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	public void set_slow_flow_throttle_type(
		string [] policies,
		LocalLBFlowEvictionPolicyEvictionSlowFlowThrottleType [] types
	) {
		this.Invoke("set_slow_flow_throttle_type", new object [] {
				policies,
				types});

	}
	public System.IAsyncResult Beginset_slow_flow_throttle_type(string [] policies,LocalLBFlowEvictionPolicyEvictionSlowFlowThrottleType [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_slow_flow_throttle_type", new object[] {
			policies,
			types}, callback, asyncState);
	}
	public void Endset_slow_flow_throttle_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_slow_flow_throttling_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/FlowEvictionPolicy", 
		RequestNamespace="urn:iControl:LocalLB/FlowEvictionPolicy", ResponseNamespace="urn:iControl:LocalLB/FlowEvictionPolicy")]
	public void set_slow_flow_throttling_state(
		string [] policies,
		CommonEnabledState [] states
	) {
		this.Invoke("set_slow_flow_throttling_state", new object [] {
				policies,
				states});

	}
	public System.IAsyncResult Beginset_slow_flow_throttling_state(string [] policies,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_slow_flow_throttling_state", new object[] {
			policies,
			states}, callback, asyncState);
	}
	public void Endset_slow_flow_throttling_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.FlowEvictionPolicy.EvictionSlowFlowThrottleType", Namespace = "urn:iControl")]
	public enum LocalLBFlowEvictionPolicyEvictionSlowFlowThrottleType
	{
		EVICTION_SLOW_FLOW_THROTTLE_TYPE_UNKNOWN,
		EVICTION_SLOW_FLOW_THROTTLE_TYPE_PERCENT,
		EVICTION_SLOW_FLOW_THROTTLE_TYPE_COUNT,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.FlowEvictionPolicy.IPProtocolType", Namespace = "urn:iControl")]
	public enum LocalLBFlowEvictionPolicyIPProtocolType
	{
		FLOW_EVICTION_IP_PROTOCOL_UNKNOWN,
		FLOW_EVICTION_IP_PROTOCOL_TCP,
		FLOW_EVICTION_IP_PROTOCOL_UDP,
		FLOW_EVICTION_IP_PROTOCOL_SCTP,
		FLOW_EVICTION_IP_PROTOCOL_ANY,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.FlowEvictionPolicy.FlowEvictionPolicyStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBFlowEvictionPolicyFlowEvictionPolicyStatisticEntry
	{
		private string eviction_policy_nameField;
		public string eviction_policy_name
		{
			get { return this.eviction_policy_nameField; }
			set { this.eviction_policy_nameField = value; }
		}
		private string context_typeField;
		public string context_type
		{
			get { return this.context_typeField; }
			set { this.context_typeField = value; }
		}
		private string context_nameField;
		public string context_name
		{
			get { return this.context_nameField; }
			set { this.context_nameField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.FlowEvictionPolicy.FlowEvictionPolicyStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBFlowEvictionPolicyFlowEvictionPolicyStatistics
	{
		private LocalLBFlowEvictionPolicyFlowEvictionPolicyStatisticEntry [] statisticsField;
		public LocalLBFlowEvictionPolicyFlowEvictionPolicyStatisticEntry [] statistics
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.FlowEvictionPolicy.PortProtocolPair", Namespace = "urn:iControl")]
	public partial class LocalLBFlowEvictionPolicyPortProtocolPair
	{
		private string nameField;
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}
		private LocalLBFlowEvictionPolicyIPProtocolType protocolField;
		public LocalLBFlowEvictionPolicyIPProtocolType protocol
		{
			get { return this.protocolField; }
			set { this.protocolField = value; }
		}
		private long portField;
		public long port
		{
			get { return this.portField; }
			set { this.portField = value; }
		}
	};

}
