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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.PoolBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonIPPortDefinition))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonAddressPort))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBPoolMemberStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBPoolPoolStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBMonitorInstanceState))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBMonitorRule))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBObjectStatus))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBPoolMonitorAssociation))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBPersistenceRecord))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonPoolProfileAttribute))]
	public partial class LocalLBPool : iControlInterface {
		public LocalLBPool() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void add_member(
		string [] pool_names,
		CommonIPPortDefinition [] [] members
	) {
		this.Invoke("add_member", new object [] {
				pool_names,
				members});

	}
	public System.IAsyncResult Beginadd_member(string [] pool_names,CommonIPPortDefinition [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_member", new object[] {
			pool_names,
			members}, callback, asyncState);
	}
	public void Endadd_member(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_member_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void add_member_metadata(
		string [] pool_names,
		CommonAddressPort [] [] members,
		string [] [] [] names,
		string [] [] [] values
	) {
		this.Invoke("add_member_metadata", new object [] {
				pool_names,
				members,
				names,
				values});

	}
	public System.IAsyncResult Beginadd_member_metadata(string [] pool_names,CommonAddressPort [] [] members,string [] [] [] names,string [] [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_member_metadata", new object[] {
			pool_names,
			members,
			names,
			values}, callback, asyncState);
	}
	public void Endadd_member_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_member_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void add_member_profile(
		string [] pool_names,
		CommonAddressPort [] [] members,
		string [] [] [] profiles
	) {
		this.Invoke("add_member_profile", new object [] {
				pool_names,
				members,
				profiles});

	}
	public System.IAsyncResult Beginadd_member_profile(string [] pool_names,CommonAddressPort [] [] members,string [] [] [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_member_profile", new object[] {
			pool_names,
			members,
			profiles}, callback, asyncState);
	}
	public void Endadd_member_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_member_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void add_member_v2(
		string [] pool_names,
		CommonAddressPort [] [] members
	) {
		this.Invoke("add_member_v2", new object [] {
				pool_names,
				members});

	}
	public System.IAsyncResult Beginadd_member_v2(string [] pool_names,CommonAddressPort [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_member_v2", new object[] {
			pool_names,
			members}, callback, asyncState);
	}
	public void Endadd_member_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
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
	// add_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void add_profile(
		string [] pool_names,
		string [] [] profiles
	) {
		this.Invoke("add_profile", new object [] {
				pool_names,
				profiles});

	}
	public System.IAsyncResult Beginadd_profile(string [] pool_names,string [] [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_profile", new object[] {
			pool_names,
			profiles}, callback, asyncState);
	}
	public void Endadd_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void create(
		string [] pool_names,
		LocalLBLBMethod [] lb_methods,
		CommonIPPortDefinition [] [] members
	) {
		this.Invoke("create", new object [] {
				pool_names,
				lb_methods,
				members});

	}
	public System.IAsyncResult Begincreate(string [] pool_names,LocalLBLBMethod [] lb_methods,CommonIPPortDefinition [] [] members, System.AsyncCallback callback, object asyncState) {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void create_v2(
		string [] pool_names,
		LocalLBLBMethod [] lb_methods,
		CommonAddressPort [] [] members
	) {
		this.Invoke("create_v2", new object [] {
				pool_names,
				lb_methods,
				members});

	}
	public System.IAsyncResult Begincreate_v2(string [] pool_names,LocalLBLBMethod [] lb_methods,CommonAddressPort [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_v2", new object[] {
			pool_names,
			lb_methods,
			members}, callback, asyncState);
	}
	public void Endcreate_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_pools
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
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
	// delete_persistence_record
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void delete_persistence_record(
		string [] pool_names,
		LocalLBPersistenceMode [] persistence_modes
	) {
		this.Invoke("delete_persistence_record", new object [] {
				pool_names,
				persistence_modes});

	}
	public System.IAsyncResult Begindelete_persistence_record(string [] pool_names,LocalLBPersistenceMode [] persistence_modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_persistence_record", new object[] {
			pool_names,
			persistence_modes}, callback, asyncState);
	}
	public void Enddelete_persistence_record(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
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
	// get_action_on_service_down
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBServiceDownAction [] get_action_on_service_down(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_action_on_service_down", new object [] {
				pool_names});
		return ((LocalLBServiceDownAction [])(results[0]));
	}
	public System.IAsyncResult Beginget_action_on_service_down(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action_on_service_down", new object[] {
			pool_names}, callback, asyncState);
	}
	public LocalLBServiceDownAction [] Endget_action_on_service_down(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBServiceDownAction [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_active_member_count
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_active_member_count(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_active_member_count", new object [] {
				pool_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_active_member_count(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_active_member_count", new object[] {
			pool_names}, callback, asyncState);
	}
	public long [] Endget_active_member_count(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_aggregate_dynamic_ratio
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_aggregate_dynamic_ratio(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_aggregate_dynamic_ratio", new object [] {
				pool_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_aggregate_dynamic_ratio(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_aggregate_dynamic_ratio", new object[] {
			pool_names}, callback, asyncState);
	}
	public long [] Endget_aggregate_dynamic_ratio(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_all_member_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBPoolMemberStatistics [] get_all_member_statistics(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_all_member_statistics", new object [] {
				pool_names});
		return ((LocalLBPoolMemberStatistics [])(results[0]));
	}
	public System.IAsyncResult Beginget_all_member_statistics(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_member_statistics", new object[] {
			pool_names}, callback, asyncState);
	}
	public LocalLBPoolMemberStatistics [] Endget_all_member_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBPoolMemberStatistics [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBPoolPoolStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((LocalLBPoolPoolStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public LocalLBPoolPoolStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBPoolPoolStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_allow_nat_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_allow_nat_state(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_allow_nat_state", new object [] {
				pool_names});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_allow_nat_state(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_allow_nat_state", new object[] {
			pool_names}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_allow_nat_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_allow_snat_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_allow_snat_state(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_allow_snat_state", new object [] {
				pool_names});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_allow_snat_state(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_allow_snat_state", new object[] {
			pool_names}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_allow_snat_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_client_ip_tos
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_client_ip_tos(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_client_ip_tos", new object [] {
				pool_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_client_ip_tos(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_client_ip_tos", new object[] {
			pool_names}, callback, asyncState);
	}
	public long [] Endget_client_ip_tos(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_client_link_qos
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_client_link_qos(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_client_link_qos", new object [] {
				pool_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_client_link_qos(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_client_link_qos", new object[] {
			pool_names}, callback, asyncState);
	}
	public long [] Endget_client_link_qos(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
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
	// get_gateway_failsafe_device
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_gateway_failsafe_device(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_gateway_failsafe_device", new object [] {
				pool_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_gateway_failsafe_device(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_gateway_failsafe_device", new object[] {
			pool_names}, callback, asyncState);
	}
	public string [] Endget_gateway_failsafe_device(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_gateway_failsafe_unit_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_gateway_failsafe_unit_id(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_gateway_failsafe_unit_id", new object [] {
				pool_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_gateway_failsafe_unit_id(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_gateway_failsafe_unit_id", new object[] {
			pool_names}, callback, asyncState);
	}
	public long [] Endget_gateway_failsafe_unit_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ignore_persisted_weight_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_ignore_persisted_weight_state(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_ignore_persisted_weight_state", new object [] {
				pool_names});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_ignore_persisted_weight_state(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ignore_persisted_weight_state", new object[] {
			pool_names}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_ignore_persisted_weight_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_lb_method
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBLBMethod [] get_lb_method(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_lb_method", new object [] {
				pool_names});
		return ((LocalLBLBMethod [])(results[0]));
	}
	public System.IAsyncResult Beginget_lb_method(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_lb_method", new object[] {
			pool_names}, callback, asyncState);
	}
	public LocalLBLBMethod [] Endget_lb_method(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBLBMethod [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
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
	// get_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonIPPortDefinition [] [] get_member(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_member", new object [] {
				pool_names});
		return ((CommonIPPortDefinition [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member", new object[] {
			pool_names}, callback, asyncState);
	}
	public CommonIPPortDefinition [] [] Endget_member(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonIPPortDefinition [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_member_address(
		string [] pool_names,
		CommonAddressPort [] [] members
	) {
		object [] results = this.Invoke("get_member_address", new object [] {
				pool_names,
				members});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_address(string [] pool_names,CommonAddressPort [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_address", new object[] {
			pool_names,
			members}, callback, asyncState);
	}
	public string [] [] Endget_member_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_connection_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_member_connection_limit(
		string [] pool_names,
		CommonAddressPort [] [] members
	) {
		object [] results = this.Invoke("get_member_connection_limit", new object [] {
				pool_names,
				members});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_connection_limit(string [] pool_names,CommonAddressPort [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_connection_limit", new object[] {
			pool_names,
			members}, callback, asyncState);
	}
	public long [] [] Endget_member_connection_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_member_description(
		string [] pool_names,
		CommonAddressPort [] [] members
	) {
		object [] results = this.Invoke("get_member_description", new object [] {
				pool_names,
				members});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_description(string [] pool_names,CommonAddressPort [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_description", new object[] {
			pool_names,
			members}, callback, asyncState);
	}
	public string [] [] Endget_member_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_dynamic_ratio
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_member_dynamic_ratio(
		string [] pool_names,
		CommonAddressPort [] [] members
	) {
		object [] results = this.Invoke("get_member_dynamic_ratio", new object [] {
				pool_names,
				members});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_dynamic_ratio(string [] pool_names,CommonAddressPort [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_dynamic_ratio", new object[] {
			pool_names,
			members}, callback, asyncState);
	}
	public long [] [] Endget_member_dynamic_ratio(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_inherit_profile_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_member_inherit_profile_state(
		string [] pool_names,
		CommonAddressPort [] [] members
	) {
		object [] results = this.Invoke("get_member_inherit_profile_state", new object [] {
				pool_names,
				members});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_inherit_profile_state(string [] pool_names,CommonAddressPort [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_inherit_profile_state", new object[] {
			pool_names,
			members}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_member_inherit_profile_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_member_metadata(
		string [] pool_names,
		CommonAddressPort [] [] members
	) {
		object [] results = this.Invoke("get_member_metadata", new object [] {
				pool_names,
				members});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_metadata(string [] pool_names,CommonAddressPort [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_metadata", new object[] {
			pool_names,
			members}, callback, asyncState);
	}
	public string [] [] [] Endget_member_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_metadata_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_member_metadata_description(
		string [] pool_names,
		CommonAddressPort [] [] members,
		string [] [] [] names
	) {
		object [] results = this.Invoke("get_member_metadata_description", new object [] {
				pool_names,
				members,
				names});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_metadata_description(string [] pool_names,CommonAddressPort [] [] members,string [] [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_metadata_description", new object[] {
			pool_names,
			members,
			names}, callback, asyncState);
	}
	public string [] [] [] Endget_member_metadata_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_metadata_persistence
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonMetadataPersistence [] [] [] get_member_metadata_persistence(
		string [] pool_names,
		CommonAddressPort [] [] members,
		string [] [] [] names
	) {
		object [] results = this.Invoke("get_member_metadata_persistence", new object [] {
				pool_names,
				members,
				names});
		return ((CommonMetadataPersistence [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_metadata_persistence(string [] pool_names,CommonAddressPort [] [] members,string [] [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_metadata_persistence", new object[] {
			pool_names,
			members,
			names}, callback, asyncState);
	}
	public CommonMetadataPersistence [] [] [] Endget_member_metadata_persistence(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonMetadataPersistence [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_metadata_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_member_metadata_value(
		string [] pool_names,
		CommonAddressPort [] [] members,
		string [] [] [] names
	) {
		object [] results = this.Invoke("get_member_metadata_value", new object [] {
				pool_names,
				members,
				names});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_metadata_value(string [] pool_names,CommonAddressPort [] [] members,string [] [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_metadata_value", new object[] {
			pool_names,
			members,
			names}, callback, asyncState);
	}
	public string [] [] [] Endget_member_metadata_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_monitor_instance
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBMonitorInstanceState [] [] get_member_monitor_instance(
		string [] pool_names,
		CommonAddressPort [] [] members
	) {
		object [] results = this.Invoke("get_member_monitor_instance", new object [] {
				pool_names,
				members});
		return ((LocalLBMonitorInstanceState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_monitor_instance(string [] pool_names,CommonAddressPort [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_monitor_instance", new object[] {
			pool_names,
			members}, callback, asyncState);
	}
	public LocalLBMonitorInstanceState [] [] Endget_member_monitor_instance(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBMonitorInstanceState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_monitor_logging_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_member_monitor_logging_state(
		string [] pool_names,
		CommonAddressPort [] [] members
	) {
		object [] results = this.Invoke("get_member_monitor_logging_state", new object [] {
				pool_names,
				members});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_monitor_logging_state(string [] pool_names,CommonAddressPort [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_monitor_logging_state", new object[] {
			pool_names,
			members}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_member_monitor_logging_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_monitor_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBMonitorRule [] [] get_member_monitor_rule(
		string [] pool_names,
		CommonAddressPort [] [] members
	) {
		object [] results = this.Invoke("get_member_monitor_rule", new object [] {
				pool_names,
				members});
		return ((LocalLBMonitorRule [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_monitor_rule(string [] pool_names,CommonAddressPort [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_monitor_rule", new object[] {
			pool_names,
			members}, callback, asyncState);
	}
	public LocalLBMonitorRule [] [] Endget_member_monitor_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBMonitorRule [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_monitor_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBMonitorStatus [] [] get_member_monitor_status(
		string [] pool_names,
		CommonAddressPort [] [] members
	) {
		object [] results = this.Invoke("get_member_monitor_status", new object [] {
				pool_names,
				members});
		return ((LocalLBMonitorStatus [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_monitor_status(string [] pool_names,CommonAddressPort [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_monitor_status", new object[] {
			pool_names,
			members}, callback, asyncState);
	}
	public LocalLBMonitorStatus [] [] Endget_member_monitor_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBMonitorStatus [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_object_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBObjectStatus [] [] get_member_object_status(
		string [] pool_names,
		CommonAddressPort [] [] members
	) {
		object [] results = this.Invoke("get_member_object_status", new object [] {
				pool_names,
				members});
		return ((LocalLBObjectStatus [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_object_status(string [] pool_names,CommonAddressPort [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_object_status", new object[] {
			pool_names,
			members}, callback, asyncState);
	}
	public LocalLBObjectStatus [] [] Endget_member_object_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBObjectStatus [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_priority
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_member_priority(
		string [] pool_names,
		CommonAddressPort [] [] members
	) {
		object [] results = this.Invoke("get_member_priority", new object [] {
				pool_names,
				members});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_priority(string [] pool_names,CommonAddressPort [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_priority", new object[] {
			pool_names,
			members}, callback, asyncState);
	}
	public long [] [] Endget_member_priority(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonPoolProfileAttribute [] [] [] get_member_profile(
		string [] pool_names,
		CommonAddressPort [] [] members
	) {
		object [] results = this.Invoke("get_member_profile", new object [] {
				pool_names,
				members});
		return ((CommonPoolProfileAttribute [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_profile(string [] pool_names,CommonAddressPort [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_profile", new object[] {
			pool_names,
			members}, callback, asyncState);
	}
	public CommonPoolProfileAttribute [] [] [] Endget_member_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonPoolProfileAttribute [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_rate_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_member_rate_limit(
		string [] pool_names,
		CommonAddressPort [] [] members
	) {
		object [] results = this.Invoke("get_member_rate_limit", new object [] {
				pool_names,
				members});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_rate_limit(string [] pool_names,CommonAddressPort [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_rate_limit", new object[] {
			pool_names,
			members}, callback, asyncState);
	}
	public long [] [] Endget_member_rate_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_ratio
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_member_ratio(
		string [] pool_names,
		CommonAddressPort [] [] members
	) {
		object [] results = this.Invoke("get_member_ratio", new object [] {
				pool_names,
				members});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_ratio(string [] pool_names,CommonAddressPort [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_ratio", new object[] {
			pool_names,
			members}, callback, asyncState);
	}
	public long [] [] Endget_member_ratio(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_session_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBSessionStatus [] [] get_member_session_status(
		string [] pool_names,
		CommonAddressPort [] [] members
	) {
		object [] results = this.Invoke("get_member_session_status", new object [] {
				pool_names,
				members});
		return ((LocalLBSessionStatus [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_session_status(string [] pool_names,CommonAddressPort [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_session_status", new object[] {
			pool_names,
			members}, callback, asyncState);
	}
	public LocalLBSessionStatus [] [] Endget_member_session_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBSessionStatus [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBPoolMemberStatistics [] get_member_statistics(
		string [] pool_names,
		CommonAddressPort [] [] members
	) {
		object [] results = this.Invoke("get_member_statistics", new object [] {
				pool_names,
				members});
		return ((LocalLBPoolMemberStatistics [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_statistics(string [] pool_names,CommonAddressPort [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_statistics", new object[] {
			pool_names,
			members}, callback, asyncState);
	}
	public LocalLBPoolMemberStatistics [] Endget_member_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBPoolMemberStatistics [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_member_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonAddressPort [] [] get_member_v2(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_member_v2", new object [] {
				pool_names});
		return ((CommonAddressPort [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_member_v2(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_member_v2", new object[] {
			pool_names}, callback, asyncState);
	}
	public CommonAddressPort [] [] Endget_member_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonAddressPort [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
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
	// get_minimum_active_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_minimum_active_member(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_minimum_active_member", new object [] {
				pool_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_minimum_active_member(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_minimum_active_member", new object[] {
			pool_names}, callback, asyncState);
	}
	public long [] Endget_minimum_active_member(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_minimum_up_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_minimum_up_member(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_minimum_up_member", new object [] {
				pool_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_minimum_up_member(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_minimum_up_member", new object[] {
			pool_names}, callback, asyncState);
	}
	public long [] Endget_minimum_up_member(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_minimum_up_member_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonHAAction [] get_minimum_up_member_action(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_minimum_up_member_action", new object [] {
				pool_names});
		return ((CommonHAAction [])(results[0]));
	}
	public System.IAsyncResult Beginget_minimum_up_member_action(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_minimum_up_member_action", new object[] {
			pool_names}, callback, asyncState);
	}
	public CommonHAAction [] Endget_minimum_up_member_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonHAAction [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_minimum_up_member_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_minimum_up_member_enabled_state(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_minimum_up_member_enabled_state", new object [] {
				pool_names});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_minimum_up_member_enabled_state(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_minimum_up_member_enabled_state", new object[] {
			pool_names}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_minimum_up_member_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_monitor_association
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBPoolMonitorAssociation [] get_monitor_association(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_monitor_association", new object [] {
				pool_names});
		return ((LocalLBPoolMonitorAssociation [])(results[0]));
	}
	public System.IAsyncResult Beginget_monitor_association(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_monitor_association", new object[] {
			pool_names}, callback, asyncState);
	}
	public LocalLBPoolMonitorAssociation [] Endget_monitor_association(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBPoolMonitorAssociation [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_monitor_instance
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBMonitorInstanceState [] [] get_monitor_instance(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_monitor_instance", new object [] {
				pool_names});
		return ((LocalLBMonitorInstanceState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_monitor_instance(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_monitor_instance", new object[] {
			pool_names}, callback, asyncState);
	}
	public LocalLBMonitorInstanceState [] [] Endget_monitor_instance(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBMonitorInstanceState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_object_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBObjectStatus [] get_object_status(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_object_status", new object [] {
				pool_names});
		return ((LocalLBObjectStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_object_status(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_object_status", new object[] {
			pool_names}, callback, asyncState);
	}
	public LocalLBObjectStatus [] Endget_object_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBObjectStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_persistence_record
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBPersistenceRecord [] [] get_persistence_record(
		string [] pool_names,
		LocalLBPersistenceMode [] persistence_modes
	) {
		object [] results = this.Invoke("get_persistence_record", new object [] {
				pool_names,
				persistence_modes});
		return ((LocalLBPersistenceRecord [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_persistence_record(string [] pool_names,LocalLBPersistenceMode [] persistence_modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_persistence_record", new object[] {
			pool_names,
			persistence_modes}, callback, asyncState);
	}
	public LocalLBPersistenceRecord [] [] Endget_persistence_record(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBPersistenceRecord [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonPoolProfileAttribute [] [] get_profile(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_profile", new object [] {
				pool_names});
		return ((CommonPoolProfileAttribute [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_profile(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_profile", new object[] {
			pool_names}, callback, asyncState);
	}
	public CommonPoolProfileAttribute [] [] Endget_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonPoolProfileAttribute [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_queue_depth_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_queue_depth_limit(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_queue_depth_limit", new object [] {
				pool_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_queue_depth_limit(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_queue_depth_limit", new object[] {
			pool_names}, callback, asyncState);
	}
	public long [] Endget_queue_depth_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_queue_on_connection_limit_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_queue_on_connection_limit_state(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_queue_on_connection_limit_state", new object [] {
				pool_names});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_queue_on_connection_limit_state(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_queue_on_connection_limit_state", new object[] {
			pool_names}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_queue_on_connection_limit_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_queue_time_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_queue_time_limit(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_queue_time_limit", new object [] {
				pool_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_queue_time_limit(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_queue_time_limit", new object[] {
			pool_names}, callback, asyncState);
	}
	public long [] Endget_queue_time_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_reselect_tries
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_reselect_tries(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_reselect_tries", new object [] {
				pool_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_reselect_tries(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_reselect_tries", new object[] {
			pool_names}, callback, asyncState);
	}
	public long [] Endget_reselect_tries(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_server_ip_tos
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_server_ip_tos(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_server_ip_tos", new object [] {
				pool_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_server_ip_tos(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_server_ip_tos", new object[] {
			pool_names}, callback, asyncState);
	}
	public long [] Endget_server_ip_tos(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_server_link_qos
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_server_link_qos(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_server_link_qos", new object [] {
				pool_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_server_link_qos(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_server_link_qos", new object[] {
			pool_names}, callback, asyncState);
	}
	public long [] Endget_server_link_qos(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_simple_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_simple_timeout(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_simple_timeout", new object [] {
				pool_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_simple_timeout(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_simple_timeout", new object[] {
			pool_names}, callback, asyncState);
	}
	public long [] Endget_simple_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_slow_ramp_time
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_slow_ramp_time(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_slow_ramp_time", new object [] {
				pool_names});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_slow_ramp_time(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_slow_ramp_time", new object[] {
			pool_names}, callback, asyncState);
	}
	public long [] Endget_slow_ramp_time(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBPoolPoolStatistics get_statistics(
		string [] pool_names
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				pool_names});
		return ((LocalLBPoolPoolStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			pool_names}, callback, asyncState);
	}
	public LocalLBPoolPoolStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBPoolPoolStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
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
	// remove_all_member_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void remove_all_member_metadata(
		string [] pool_names,
		CommonAddressPort [] [] members
	) {
		this.Invoke("remove_all_member_metadata", new object [] {
				pool_names,
				members});

	}
	public System.IAsyncResult Beginremove_all_member_metadata(string [] pool_names,CommonAddressPort [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_member_metadata", new object[] {
			pool_names,
			members}, callback, asyncState);
	}
	public void Endremove_all_member_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_member_profiles
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void remove_all_member_profiles(
		string [] pool_names,
		CommonAddressPort [] [] members
	) {
		this.Invoke("remove_all_member_profiles", new object [] {
				pool_names,
				members});

	}
	public System.IAsyncResult Beginremove_all_member_profiles(string [] pool_names,CommonAddressPort [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_member_profiles", new object[] {
			pool_names,
			members}, callback, asyncState);
	}
	public void Endremove_all_member_profiles(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
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
	// remove_all_profiles
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void remove_all_profiles(
		string [] pool_names
	) {
		this.Invoke("remove_all_profiles", new object [] {
				pool_names});

	}
	public System.IAsyncResult Beginremove_all_profiles(string [] pool_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_profiles", new object[] {
			pool_names}, callback, asyncState);
	}
	public void Endremove_all_profiles(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
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
	// remove_member_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void remove_member_metadata(
		string [] pool_names,
		CommonAddressPort [] [] members,
		string [] [] [] names
	) {
		this.Invoke("remove_member_metadata", new object [] {
				pool_names,
				members,
				names});

	}
	public System.IAsyncResult Beginremove_member_metadata(string [] pool_names,CommonAddressPort [] [] members,string [] [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_member_metadata", new object[] {
			pool_names,
			members,
			names}, callback, asyncState);
	}
	public void Endremove_member_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_member_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void remove_member_profile(
		string [] pool_names,
		CommonAddressPort [] [] members,
		string [] [] [] profiles
	) {
		this.Invoke("remove_member_profile", new object [] {
				pool_names,
				members,
				profiles});

	}
	public System.IAsyncResult Beginremove_member_profile(string [] pool_names,CommonAddressPort [] [] members,string [] [] [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_member_profile", new object[] {
			pool_names,
			members,
			profiles}, callback, asyncState);
	}
	public void Endremove_member_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_member_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void remove_member_v2(
		string [] pool_names,
		CommonAddressPort [] [] members
	) {
		this.Invoke("remove_member_v2", new object [] {
				pool_names,
				members});

	}
	public System.IAsyncResult Beginremove_member_v2(string [] pool_names,CommonAddressPort [] [] members, System.AsyncCallback callback, object asyncState) {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
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
	// remove_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void remove_profile(
		string [] pool_names,
		string [] [] profiles
	) {
		this.Invoke("remove_profile", new object [] {
				pool_names,
				profiles});

	}
	public System.IAsyncResult Beginremove_profile(string [] pool_names,string [] [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_profile", new object[] {
			pool_names,
			profiles}, callback, asyncState);
	}
	public void Endremove_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_member_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void reset_member_statistics(
		string [] pool_names,
		CommonAddressPort [] [] members
	) {
		this.Invoke("reset_member_statistics", new object [] {
				pool_names,
				members});

	}
	public System.IAsyncResult Beginreset_member_statistics(string [] pool_names,CommonAddressPort [] [] members, System.AsyncCallback callback, object asyncState) {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
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
	// set_action_on_service_down
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void set_action_on_service_down(
		string [] pool_names,
		LocalLBServiceDownAction [] actions
	) {
		this.Invoke("set_action_on_service_down", new object [] {
				pool_names,
				actions});

	}
	public System.IAsyncResult Beginset_action_on_service_down(string [] pool_names,LocalLBServiceDownAction [] actions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_action_on_service_down", new object[] {
			pool_names,
			actions}, callback, asyncState);
	}
	public void Endset_action_on_service_down(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_allow_nat_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void set_allow_nat_state(
		string [] pool_names,
		CommonEnabledState [] states
	) {
		this.Invoke("set_allow_nat_state", new object [] {
				pool_names,
				states});

	}
	public System.IAsyncResult Beginset_allow_nat_state(string [] pool_names,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_allow_nat_state", new object[] {
			pool_names,
			states}, callback, asyncState);
	}
	public void Endset_allow_nat_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_allow_snat_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void set_allow_snat_state(
		string [] pool_names,
		CommonEnabledState [] states
	) {
		this.Invoke("set_allow_snat_state", new object [] {
				pool_names,
				states});

	}
	public System.IAsyncResult Beginset_allow_snat_state(string [] pool_names,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_allow_snat_state", new object[] {
			pool_names,
			states}, callback, asyncState);
	}
	public void Endset_allow_snat_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_client_ip_tos
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void set_client_ip_tos(
		string [] pool_names,
		long [] values
	) {
		this.Invoke("set_client_ip_tos", new object [] {
				pool_names,
				values});

	}
	public System.IAsyncResult Beginset_client_ip_tos(string [] pool_names,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_client_ip_tos", new object[] {
			pool_names,
			values}, callback, asyncState);
	}
	public void Endset_client_ip_tos(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_client_link_qos
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void set_client_link_qos(
		string [] pool_names,
		long [] values
	) {
		this.Invoke("set_client_link_qos", new object [] {
				pool_names,
				values});

	}
	public System.IAsyncResult Beginset_client_link_qos(string [] pool_names,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_client_link_qos", new object[] {
			pool_names,
			values}, callback, asyncState);
	}
	public void Endset_client_link_qos(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
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
	// set_gateway_failsafe_device
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void set_gateway_failsafe_device(
		string [] pool_names,
		string [] devices
	) {
		this.Invoke("set_gateway_failsafe_device", new object [] {
				pool_names,
				devices});

	}
	public System.IAsyncResult Beginset_gateway_failsafe_device(string [] pool_names,string [] devices, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_gateway_failsafe_device", new object[] {
			pool_names,
			devices}, callback, asyncState);
	}
	public void Endset_gateway_failsafe_device(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_gateway_failsafe_unit_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void set_gateway_failsafe_unit_id(
		string [] pool_names,
		long [] unit_ids
	) {
		this.Invoke("set_gateway_failsafe_unit_id", new object [] {
				pool_names,
				unit_ids});

	}
	public System.IAsyncResult Beginset_gateway_failsafe_unit_id(string [] pool_names,long [] unit_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_gateway_failsafe_unit_id", new object[] {
			pool_names,
			unit_ids}, callback, asyncState);
	}
	public void Endset_gateway_failsafe_unit_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ignore_persisted_weight_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void set_ignore_persisted_weight_state(
		string [] pool_names,
		CommonEnabledState [] states
	) {
		this.Invoke("set_ignore_persisted_weight_state", new object [] {
				pool_names,
				states});

	}
	public System.IAsyncResult Beginset_ignore_persisted_weight_state(string [] pool_names,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ignore_persisted_weight_state", new object[] {
			pool_names,
			states}, callback, asyncState);
	}
	public void Endset_ignore_persisted_weight_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_lb_method
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void set_lb_method(
		string [] pool_names,
		LocalLBLBMethod [] lb_methods
	) {
		this.Invoke("set_lb_method", new object [] {
				pool_names,
				lb_methods});

	}
	public System.IAsyncResult Beginset_lb_method(string [] pool_names,LocalLBLBMethod [] lb_methods, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_lb_method", new object[] {
			pool_names,
			lb_methods}, callback, asyncState);
	}
	public void Endset_lb_method(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_member_connection_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void set_member_connection_limit(
		string [] pool_names,
		CommonAddressPort [] [] members,
		long [] [] limits
	) {
		this.Invoke("set_member_connection_limit", new object [] {
				pool_names,
				members,
				limits});

	}
	public System.IAsyncResult Beginset_member_connection_limit(string [] pool_names,CommonAddressPort [] [] members,long [] [] limits, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_member_connection_limit", new object[] {
			pool_names,
			members,
			limits}, callback, asyncState);
	}
	public void Endset_member_connection_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_member_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void set_member_description(
		string [] pool_names,
		CommonAddressPort [] [] members,
		string [] [] descriptions
	) {
		this.Invoke("set_member_description", new object [] {
				pool_names,
				members,
				descriptions});

	}
	public System.IAsyncResult Beginset_member_description(string [] pool_names,CommonAddressPort [] [] members,string [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_member_description", new object[] {
			pool_names,
			members,
			descriptions}, callback, asyncState);
	}
	public void Endset_member_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_member_dynamic_ratio
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void set_member_dynamic_ratio(
		string [] pool_names,
		CommonAddressPort [] [] members,
		long [] [] dynamic_ratios
	) {
		this.Invoke("set_member_dynamic_ratio", new object [] {
				pool_names,
				members,
				dynamic_ratios});

	}
	public System.IAsyncResult Beginset_member_dynamic_ratio(string [] pool_names,CommonAddressPort [] [] members,long [] [] dynamic_ratios, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_member_dynamic_ratio", new object[] {
			pool_names,
			members,
			dynamic_ratios}, callback, asyncState);
	}
	public void Endset_member_dynamic_ratio(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_member_inherit_profile_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void set_member_inherit_profile_state(
		string [] pool_names,
		CommonAddressPort [] [] members,
		CommonEnabledState [] [] states
	) {
		this.Invoke("set_member_inherit_profile_state", new object [] {
				pool_names,
				members,
				states});

	}
	public System.IAsyncResult Beginset_member_inherit_profile_state(string [] pool_names,CommonAddressPort [] [] members,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_member_inherit_profile_state", new object[] {
			pool_names,
			members,
			states}, callback, asyncState);
	}
	public void Endset_member_inherit_profile_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_member_metadata_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void set_member_metadata_description(
		string [] pool_names,
		CommonAddressPort [] [] members,
		string [] [] [] names,
		string [] [] [] descriptions
	) {
		this.Invoke("set_member_metadata_description", new object [] {
				pool_names,
				members,
				names,
				descriptions});

	}
	public System.IAsyncResult Beginset_member_metadata_description(string [] pool_names,CommonAddressPort [] [] members,string [] [] [] names,string [] [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_member_metadata_description", new object[] {
			pool_names,
			members,
			names,
			descriptions}, callback, asyncState);
	}
	public void Endset_member_metadata_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_member_metadata_persistence
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void set_member_metadata_persistence(
		string [] pool_names,
		CommonAddressPort [] [] members,
		string [] [] [] names,
		CommonMetadataPersistence [] [] [] values
	) {
		this.Invoke("set_member_metadata_persistence", new object [] {
				pool_names,
				members,
				names,
				values});

	}
	public System.IAsyncResult Beginset_member_metadata_persistence(string [] pool_names,CommonAddressPort [] [] members,string [] [] [] names,CommonMetadataPersistence [] [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_member_metadata_persistence", new object[] {
			pool_names,
			members,
			names,
			values}, callback, asyncState);
	}
	public void Endset_member_metadata_persistence(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_member_metadata_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void set_member_metadata_value(
		string [] pool_names,
		CommonAddressPort [] [] members,
		string [] [] [] names,
		string [] [] [] values
	) {
		this.Invoke("set_member_metadata_value", new object [] {
				pool_names,
				members,
				names,
				values});

	}
	public System.IAsyncResult Beginset_member_metadata_value(string [] pool_names,CommonAddressPort [] [] members,string [] [] [] names,string [] [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_member_metadata_value", new object[] {
			pool_names,
			members,
			names,
			values}, callback, asyncState);
	}
	public void Endset_member_metadata_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_member_monitor_logging_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void set_member_monitor_logging_state(
		string [] pool_names,
		CommonAddressPort [] [] members,
		CommonEnabledState [] [] states
	) {
		this.Invoke("set_member_monitor_logging_state", new object [] {
				pool_names,
				members,
				states});

	}
	public System.IAsyncResult Beginset_member_monitor_logging_state(string [] pool_names,CommonAddressPort [] [] members,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_member_monitor_logging_state", new object[] {
			pool_names,
			members,
			states}, callback, asyncState);
	}
	public void Endset_member_monitor_logging_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_member_monitor_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void set_member_monitor_rule(
		string [] pool_names,
		CommonAddressPort [] [] members,
		LocalLBMonitorRule [] [] monitor_rules
	) {
		this.Invoke("set_member_monitor_rule", new object [] {
				pool_names,
				members,
				monitor_rules});

	}
	public System.IAsyncResult Beginset_member_monitor_rule(string [] pool_names,CommonAddressPort [] [] members,LocalLBMonitorRule [] [] monitor_rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_member_monitor_rule", new object[] {
			pool_names,
			members,
			monitor_rules}, callback, asyncState);
	}
	public void Endset_member_monitor_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_member_monitor_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void set_member_monitor_state(
		string [] pool_names,
		CommonAddressPort [] [] members,
		CommonEnabledState [] [] monitor_states
	) {
		this.Invoke("set_member_monitor_state", new object [] {
				pool_names,
				members,
				monitor_states});

	}
	public System.IAsyncResult Beginset_member_monitor_state(string [] pool_names,CommonAddressPort [] [] members,CommonEnabledState [] [] monitor_states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_member_monitor_state", new object[] {
			pool_names,
			members,
			monitor_states}, callback, asyncState);
	}
	public void Endset_member_monitor_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_member_priority
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void set_member_priority(
		string [] pool_names,
		CommonAddressPort [] [] members,
		long [] [] priorities
	) {
		this.Invoke("set_member_priority", new object [] {
				pool_names,
				members,
				priorities});

	}
	public System.IAsyncResult Beginset_member_priority(string [] pool_names,CommonAddressPort [] [] members,long [] [] priorities, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_member_priority", new object[] {
			pool_names,
			members,
			priorities}, callback, asyncState);
	}
	public void Endset_member_priority(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_member_rate_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void set_member_rate_limit(
		string [] pool_names,
		CommonAddressPort [] [] members,
		long [] [] limits
	) {
		this.Invoke("set_member_rate_limit", new object [] {
				pool_names,
				members,
				limits});

	}
	public System.IAsyncResult Beginset_member_rate_limit(string [] pool_names,CommonAddressPort [] [] members,long [] [] limits, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_member_rate_limit", new object[] {
			pool_names,
			members,
			limits}, callback, asyncState);
	}
	public void Endset_member_rate_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_member_ratio
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void set_member_ratio(
		string [] pool_names,
		CommonAddressPort [] [] members,
		long [] [] ratios
	) {
		this.Invoke("set_member_ratio", new object [] {
				pool_names,
				members,
				ratios});

	}
	public System.IAsyncResult Beginset_member_ratio(string [] pool_names,CommonAddressPort [] [] members,long [] [] ratios, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_member_ratio", new object[] {
			pool_names,
			members,
			ratios}, callback, asyncState);
	}
	public void Endset_member_ratio(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_member_session_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void set_member_session_enabled_state(
		string [] pool_names,
		CommonAddressPort [] [] members,
		CommonEnabledState [] [] session_states
	) {
		this.Invoke("set_member_session_enabled_state", new object [] {
				pool_names,
				members,
				session_states});

	}
	public System.IAsyncResult Beginset_member_session_enabled_state(string [] pool_names,CommonAddressPort [] [] members,CommonEnabledState [] [] session_states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_member_session_enabled_state", new object[] {
			pool_names,
			members,
			session_states}, callback, asyncState);
	}
	public void Endset_member_session_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_metadata_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
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
	// set_minimum_active_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void set_minimum_active_member(
		string [] pool_names,
		long [] values
	) {
		this.Invoke("set_minimum_active_member", new object [] {
				pool_names,
				values});

	}
	public System.IAsyncResult Beginset_minimum_active_member(string [] pool_names,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_minimum_active_member", new object[] {
			pool_names,
			values}, callback, asyncState);
	}
	public void Endset_minimum_active_member(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_minimum_up_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void set_minimum_up_member(
		string [] pool_names,
		long [] values
	) {
		this.Invoke("set_minimum_up_member", new object [] {
				pool_names,
				values});

	}
	public System.IAsyncResult Beginset_minimum_up_member(string [] pool_names,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_minimum_up_member", new object[] {
			pool_names,
			values}, callback, asyncState);
	}
	public void Endset_minimum_up_member(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_minimum_up_member_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void set_minimum_up_member_action(
		string [] pool_names,
		CommonHAAction [] actions
	) {
		this.Invoke("set_minimum_up_member_action", new object [] {
				pool_names,
				actions});

	}
	public System.IAsyncResult Beginset_minimum_up_member_action(string [] pool_names,CommonHAAction [] actions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_minimum_up_member_action", new object[] {
			pool_names,
			actions}, callback, asyncState);
	}
	public void Endset_minimum_up_member_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_minimum_up_member_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void set_minimum_up_member_enabled_state(
		string [] pool_names,
		CommonEnabledState [] states
	) {
		this.Invoke("set_minimum_up_member_enabled_state", new object [] {
				pool_names,
				states});

	}
	public System.IAsyncResult Beginset_minimum_up_member_enabled_state(string [] pool_names,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_minimum_up_member_enabled_state", new object[] {
			pool_names,
			states}, callback, asyncState);
	}
	public void Endset_minimum_up_member_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_monitor_association
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void set_monitor_association(
		LocalLBPoolMonitorAssociation [] monitor_associations
	) {
		this.Invoke("set_monitor_association", new object [] {
				monitor_associations});

	}
	public System.IAsyncResult Beginset_monitor_association(LocalLBPoolMonitorAssociation [] monitor_associations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_monitor_association", new object[] {
			monitor_associations}, callback, asyncState);
	}
	public void Endset_monitor_association(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_queue_depth_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void set_queue_depth_limit(
		string [] pool_names,
		long [] values
	) {
		this.Invoke("set_queue_depth_limit", new object [] {
				pool_names,
				values});

	}
	public System.IAsyncResult Beginset_queue_depth_limit(string [] pool_names,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_queue_depth_limit", new object[] {
			pool_names,
			values}, callback, asyncState);
	}
	public void Endset_queue_depth_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_queue_on_connection_limit_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void set_queue_on_connection_limit_state(
		string [] pool_names,
		CommonEnabledState [] states
	) {
		this.Invoke("set_queue_on_connection_limit_state", new object [] {
				pool_names,
				states});

	}
	public System.IAsyncResult Beginset_queue_on_connection_limit_state(string [] pool_names,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_queue_on_connection_limit_state", new object[] {
			pool_names,
			states}, callback, asyncState);
	}
	public void Endset_queue_on_connection_limit_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_queue_time_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void set_queue_time_limit(
		string [] pool_names,
		long [] values
	) {
		this.Invoke("set_queue_time_limit", new object [] {
				pool_names,
				values});

	}
	public System.IAsyncResult Beginset_queue_time_limit(string [] pool_names,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_queue_time_limit", new object[] {
			pool_names,
			values}, callback, asyncState);
	}
	public void Endset_queue_time_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_reselect_tries
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void set_reselect_tries(
		string [] pool_names,
		long [] values
	) {
		this.Invoke("set_reselect_tries", new object [] {
				pool_names,
				values});

	}
	public System.IAsyncResult Beginset_reselect_tries(string [] pool_names,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_reselect_tries", new object[] {
			pool_names,
			values}, callback, asyncState);
	}
	public void Endset_reselect_tries(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_server_ip_tos
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void set_server_ip_tos(
		string [] pool_names,
		long [] values
	) {
		this.Invoke("set_server_ip_tos", new object [] {
				pool_names,
				values});

	}
	public System.IAsyncResult Beginset_server_ip_tos(string [] pool_names,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_server_ip_tos", new object[] {
			pool_names,
			values}, callback, asyncState);
	}
	public void Endset_server_ip_tos(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_server_link_qos
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void set_server_link_qos(
		string [] pool_names,
		long [] values
	) {
		this.Invoke("set_server_link_qos", new object [] {
				pool_names,
				values});

	}
	public System.IAsyncResult Beginset_server_link_qos(string [] pool_names,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_server_link_qos", new object[] {
			pool_names,
			values}, callback, asyncState);
	}
	public void Endset_server_link_qos(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_simple_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void set_simple_timeout(
		string [] pool_names,
		long [] simple_timeouts
	) {
		this.Invoke("set_simple_timeout", new object [] {
				pool_names,
				simple_timeouts});

	}
	public System.IAsyncResult Beginset_simple_timeout(string [] pool_names,long [] simple_timeouts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_simple_timeout", new object[] {
			pool_names,
			simple_timeouts}, callback, asyncState);
	}
	public void Endset_simple_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_slow_ramp_time
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Pool", 
		RequestNamespace="urn:iControl:LocalLB/Pool", ResponseNamespace="urn:iControl:LocalLB/Pool")]
	public void set_slow_ramp_time(
		string [] pool_names,
		long [] values
	) {
		this.Invoke("set_slow_ramp_time", new object [] {
				pool_names,
				values});

	}
	public System.IAsyncResult Beginset_slow_ramp_time(string [] pool_names,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_slow_ramp_time", new object[] {
			pool_names,
			values}, callback, asyncState);
	}
	public void Endset_slow_ramp_time(System.IAsyncResult asyncResult) {
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.Pool.MemberStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBPoolMemberStatisticEntry
	{
		private CommonAddressPort memberField;
		public CommonAddressPort member
		{
			get { return this.memberField; }
			set { this.memberField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.Pool.MemberStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBPoolMemberStatistics
	{
		private LocalLBPoolMemberStatisticEntry [] statisticsField;
		public LocalLBPoolMemberStatisticEntry [] statistics
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.Pool.MonitorAssociation", Namespace = "urn:iControl")]
	public partial class LocalLBPoolMonitorAssociation
	{
		private string pool_nameField;
		public string pool_name
		{
			get { return this.pool_nameField; }
			set { this.pool_nameField = value; }
		}
		private LocalLBMonitorRule monitor_ruleField;
		public LocalLBMonitorRule monitor_rule
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.Pool.PoolStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBPoolPoolStatisticEntry
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.Pool.PoolStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBPoolPoolStatistics
	{
		private LocalLBPoolPoolStatisticEntry [] statisticsField;
		public LocalLBPoolPoolStatisticEntry [] statistics
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
