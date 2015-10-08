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
	[System.Web.Services.WebServiceBindingAttribute(Name="PEM.PolicyBinding", Namespace="urn:iControl")]
	public partial class PEMPolicy : iControlInterface {
		public PEMPolicy() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_classification_filter
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void add_classification_filter(
		string [] policies,
		string [] [] rules,
		string [] [] [] filters,
		string [] [] [] applications,
		string [] [] [] categories
	) {
		this.Invoke("add_classification_filter", new object [] {
				policies,
				rules,
				filters,
				applications,
				categories});

	}
	public System.IAsyncResult Beginadd_classification_filter(string [] policies,string [] [] rules,string [] [] [] filters,string [] [] [] applications,string [] [] [] categories, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_classification_filter", new object[] {
			policies,
			rules,
			filters,
			applications,
			categories}, callback, asyncState);
	}
	public void Endadd_classification_filter(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_flow_info_filter
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void add_flow_info_filter(
		string [] policies,
		string [] [] rules,
		string [] [] [] filters
	) {
		this.Invoke("add_flow_info_filter", new object [] {
				policies,
				rules,
				filters});

	}
	public System.IAsyncResult Beginadd_flow_info_filter(string [] policies,string [] [] rules,string [] [] [] filters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_flow_info_filter", new object[] {
			policies,
			rules,
			filters}, callback, asyncState);
	}
	public void Endadd_flow_info_filter(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void add_rule(
		string [] policies,
		string [] [] rules,
		long [] [] precedences
	) {
		this.Invoke("add_rule", new object [] {
				policies,
				rules,
				precedences});

	}
	public System.IAsyncResult Beginadd_rule(string [] policies,string [] [] rules,long [] [] precedences, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_rule", new object[] {
			policies,
			rules,
			precedences}, callback, asyncState);
	}
	public void Endadd_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
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
	// delete_all_policies
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void delete_all_policies(

	) {
		this.Invoke("delete_all_policies", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_policies(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_policies", new object[0], callback, asyncState);
	}
	public void Enddelete_all_policies(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void delete_policy(
		string [] policies
	) {
		this.Invoke("delete_policy", new object [] {
				policies});

	}
	public System.IAsyncResult Begindelete_policy(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_policy", new object[] {
			policies}, callback, asyncState);
	}
	public void Enddelete_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_classification_filter
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_classification_filter(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_classification_filter", new object [] {
				policies,
				rules});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_classification_filter(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_classification_filter", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public string [] [] [] Endget_classification_filter(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_classification_filter_application
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_classification_filter_application(
		string [] policies,
		string [] [] rules,
		string [] [] [] filters
	) {
		object [] results = this.Invoke("get_classification_filter_application", new object [] {
				policies,
				rules,
				filters});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_classification_filter_application(string [] policies,string [] [] rules,string [] [] [] filters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_classification_filter_application", new object[] {
			policies,
			rules,
			filters}, callback, asyncState);
	}
	public string [] [] [] Endget_classification_filter_application(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_classification_filter_category
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_classification_filter_category(
		string [] policies,
		string [] [] rules,
		string [] [] [] filters
	) {
		object [] results = this.Invoke("get_classification_filter_category", new object [] {
				policies,
				rules,
				filters});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_classification_filter_category(string [] policies,string [] [] rules,string [] [] [] filters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_classification_filter_category", new object[] {
			policies,
			rules,
			filters}, callback, asyncState);
	}
	public string [] [] [] Endget_classification_filter_category(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_classification_filter_operation_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public PEMPolicyFilterOperationType [] [] [] get_classification_filter_operation_type(
		string [] policies,
		string [] [] rules,
		string [] [] [] filters
	) {
		object [] results = this.Invoke("get_classification_filter_operation_type", new object [] {
				policies,
				rules,
				filters});
		return ((PEMPolicyFilterOperationType [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_classification_filter_operation_type(string [] policies,string [] [] rules,string [] [] [] filters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_classification_filter_operation_type", new object[] {
			policies,
			rules,
			filters}, callback, asyncState);
	}
	public PEMPolicyFilterOperationType [] [] [] Endget_classification_filter_operation_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((PEMPolicyFilterOperationType [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
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
	// get_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_enabled_state(
		string [] policies
	) {
		object [] results = this.Invoke("get_enabled_state", new object [] {
				policies});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_enabled_state(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_enabled_state", new object[] {
			policies}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_flow_info_filter
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_flow_info_filter(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_flow_info_filter", new object [] {
				policies,
				rules});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_flow_info_filter(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_flow_info_filter", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public string [] [] [] Endget_flow_info_filter(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_flow_info_filter_destination_ip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonIPNetmask [] [] [] get_flow_info_filter_destination_ip(
		string [] policies,
		string [] [] rules,
		string [] [] [] filters
	) {
		object [] results = this.Invoke("get_flow_info_filter_destination_ip", new object [] {
				policies,
				rules,
				filters});
		return ((CommonIPNetmask [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_flow_info_filter_destination_ip(string [] policies,string [] [] rules,string [] [] [] filters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_flow_info_filter_destination_ip", new object[] {
			policies,
			rules,
			filters}, callback, asyncState);
	}
	public CommonIPNetmask [] [] [] Endget_flow_info_filter_destination_ip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonIPNetmask [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_flow_info_filter_destination_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] [] get_flow_info_filter_destination_port(
		string [] policies,
		string [] [] rules,
		string [] [] [] filters
	) {
		object [] results = this.Invoke("get_flow_info_filter_destination_port", new object [] {
				policies,
				rules,
				filters});
		return ((long [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_flow_info_filter_destination_port(string [] policies,string [] [] rules,string [] [] [] filters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_flow_info_filter_destination_port", new object[] {
			policies,
			rules,
			filters}, callback, asyncState);
	}
	public long [] [] [] Endget_flow_info_filter_destination_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_flow_info_filter_dscp_code
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] [] get_flow_info_filter_dscp_code(
		string [] policies,
		string [] [] rules,
		string [] [] [] filters
	) {
		object [] results = this.Invoke("get_flow_info_filter_dscp_code", new object [] {
				policies,
				rules,
				filters});
		return ((long [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_flow_info_filter_dscp_code(string [] policies,string [] [] rules,string [] [] [] filters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_flow_info_filter_dscp_code", new object[] {
			policies,
			rules,
			filters}, callback, asyncState);
	}
	public long [] [] [] Endget_flow_info_filter_dscp_code(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_flow_info_filter_from_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_flow_info_filter_from_vlan(
		string [] policies,
		string [] [] rules,
		string [] [] [] filters
	) {
		object [] results = this.Invoke("get_flow_info_filter_from_vlan", new object [] {
				policies,
				rules,
				filters});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_flow_info_filter_from_vlan(string [] policies,string [] [] rules,string [] [] [] filters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_flow_info_filter_from_vlan", new object[] {
			policies,
			rules,
			filters}, callback, asyncState);
	}
	public string [] [] [] Endget_flow_info_filter_from_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_flow_info_filter_l2_endpoint_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public PEMPolicyL2EndpointType [] [] [] get_flow_info_filter_l2_endpoint_type(
		string [] policies,
		string [] [] rules,
		string [] [] [] filters
	) {
		object [] results = this.Invoke("get_flow_info_filter_l2_endpoint_type", new object [] {
				policies,
				rules,
				filters});
		return ((PEMPolicyL2EndpointType [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_flow_info_filter_l2_endpoint_type(string [] policies,string [] [] rules,string [] [] [] filters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_flow_info_filter_l2_endpoint_type", new object[] {
			policies,
			rules,
			filters}, callback, asyncState);
	}
	public PEMPolicyL2EndpointType [] [] [] Endget_flow_info_filter_l2_endpoint_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((PEMPolicyL2EndpointType [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_flow_info_filter_operation_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public PEMPolicyFilterOperationType [] [] [] get_flow_info_filter_operation_type(
		string [] policies,
		string [] [] rules,
		string [] [] [] filters
	) {
		object [] results = this.Invoke("get_flow_info_filter_operation_type", new object [] {
				policies,
				rules,
				filters});
		return ((PEMPolicyFilterOperationType [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_flow_info_filter_operation_type(string [] policies,string [] [] rules,string [] [] [] filters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_flow_info_filter_operation_type", new object[] {
			policies,
			rules,
			filters}, callback, asyncState);
	}
	public PEMPolicyFilterOperationType [] [] [] Endget_flow_info_filter_operation_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((PEMPolicyFilterOperationType [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_flow_info_filter_protocol_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public PEMPolicyProtocolType [] [] [] get_flow_info_filter_protocol_type(
		string [] policies,
		string [] [] rules,
		string [] [] [] filters
	) {
		object [] results = this.Invoke("get_flow_info_filter_protocol_type", new object [] {
				policies,
				rules,
				filters});
		return ((PEMPolicyProtocolType [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_flow_info_filter_protocol_type(string [] policies,string [] [] rules,string [] [] [] filters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_flow_info_filter_protocol_type", new object[] {
			policies,
			rules,
			filters}, callback, asyncState);
	}
	public PEMPolicyProtocolType [] [] [] Endget_flow_info_filter_protocol_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((PEMPolicyProtocolType [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_flow_info_filter_source_ip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonIPNetmask [] [] [] get_flow_info_filter_source_ip(
		string [] policies,
		string [] [] rules,
		string [] [] [] filters
	) {
		object [] results = this.Invoke("get_flow_info_filter_source_ip", new object [] {
				policies,
				rules,
				filters});
		return ((CommonIPNetmask [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_flow_info_filter_source_ip(string [] policies,string [] [] rules,string [] [] [] filters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_flow_info_filter_source_ip", new object[] {
			policies,
			rules,
			filters}, callback, asyncState);
	}
	public CommonIPNetmask [] [] [] Endget_flow_info_filter_source_ip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonIPNetmask [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_flow_info_filter_source_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] [] get_flow_info_filter_source_port(
		string [] policies,
		string [] [] rules,
		string [] [] [] filters
	) {
		object [] results = this.Invoke("get_flow_info_filter_source_port", new object [] {
				policies,
				rules,
				filters});
		return ((long [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_flow_info_filter_source_port(string [] policies,string [] [] rules,string [] [] [] filters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_flow_info_filter_source_port", new object[] {
			policies,
			rules,
			filters}, callback, asyncState);
	}
	public long [] [] [] Endget_flow_info_filter_source_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
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
	// get_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_rule(
		string [] policies
	) {
		object [] results = this.Invoke("get_rule", new object [] {
				policies});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_rule(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rule", new object[] {
			policies}, callback, asyncState);
	}
	public string [] [] Endget_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rule_downlink_volume_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_rule_downlink_volume_threshold(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_rule_downlink_volume_threshold", new object [] {
				policies,
				rules});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_rule_downlink_volume_threshold(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rule_downlink_volume_threshold", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public long [] [] Endget_rule_downlink_volume_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rule_dscp_marking_downlink
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_rule_dscp_marking_downlink(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_rule_dscp_marking_downlink", new object [] {
				policies,
				rules});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_rule_dscp_marking_downlink(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rule_dscp_marking_downlink", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public long [] [] Endget_rule_dscp_marking_downlink(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rule_dscp_marking_uplink
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_rule_dscp_marking_uplink(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_rule_dscp_marking_uplink", new object [] {
				policies,
				rules});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_rule_dscp_marking_uplink(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rule_dscp_marking_uplink", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public long [] [] Endget_rule_dscp_marking_uplink(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rule_forwarding_action_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public PEMPolicyForwardingActionType [] [] get_rule_forwarding_action_type(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_rule_forwarding_action_type", new object [] {
				policies,
				rules});
		return ((PEMPolicyForwardingActionType [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_rule_forwarding_action_type(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rule_forwarding_action_type", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public PEMPolicyForwardingActionType [] [] Endget_rule_forwarding_action_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((PEMPolicyForwardingActionType [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rule_forwarding_endpoint
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_rule_forwarding_endpoint(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_rule_forwarding_endpoint", new object [] {
				policies,
				rules});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_rule_forwarding_endpoint(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rule_forwarding_endpoint", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public string [] [] Endget_rule_forwarding_endpoint(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rule_gate_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public PEMPolicyGateStatusType [] [] get_rule_gate_state(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_rule_gate_state", new object [] {
				policies,
				rules});
		return ((PEMPolicyGateStatusType [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_rule_gate_state(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rule_gate_state", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public PEMPolicyGateStatusType [] [] Endget_rule_gate_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((PEMPolicyGateStatusType [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rule_gx_monitoring_key
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_rule_gx_monitoring_key(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_rule_gx_monitoring_key", new object [] {
				policies,
				rules});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_rule_gx_monitoring_key(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rule_gx_monitoring_key", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public string [] [] Endget_rule_gx_monitoring_key(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rule_hsl_endpoint
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_rule_hsl_endpoint(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_rule_hsl_endpoint", new object [] {
				policies,
				rules});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_rule_hsl_endpoint(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rule_hsl_endpoint", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public string [] [] Endget_rule_hsl_endpoint(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rule_hsl_format_script
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_rule_hsl_format_script(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_rule_hsl_format_script", new object [] {
				policies,
				rules});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_rule_hsl_format_script(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rule_hsl_format_script", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public string [] [] Endget_rule_hsl_format_script(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rule_http_redirect
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_rule_http_redirect(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_rule_http_redirect", new object [] {
				policies,
				rules});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_rule_http_redirect(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rule_http_redirect", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public string [] [] Endget_rule_http_redirect(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rule_intercept
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_rule_intercept(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_rule_intercept", new object [] {
				policies,
				rules});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_rule_intercept(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rule_intercept", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public string [] [] Endget_rule_intercept(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rule_internal_virtual_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_rule_internal_virtual_server(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_rule_internal_virtual_server", new object [] {
				policies,
				rules});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_rule_internal_virtual_server(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rule_internal_virtual_server", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public string [] [] Endget_rule_internal_virtual_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rule_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_rule_interval(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_rule_interval", new object [] {
				policies,
				rules});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_rule_interval(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rule_interval", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public long [] [] Endget_rule_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rule_l2_marking_downlink_level
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_rule_l2_marking_downlink_level(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_rule_l2_marking_downlink_level", new object [] {
				policies,
				rules});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_rule_l2_marking_downlink_level(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rule_l2_marking_downlink_level", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public long [] [] Endget_rule_l2_marking_downlink_level(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rule_l2_marking_uplink_level
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_rule_l2_marking_uplink_level(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_rule_l2_marking_uplink_level", new object [] {
				policies,
				rules});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_rule_l2_marking_uplink_level(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rule_l2_marking_uplink_level", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public long [] [] Endget_rule_l2_marking_uplink_level(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rule_modify_http_header_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_rule_modify_http_header_name(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_rule_modify_http_header_name", new object [] {
				policies,
				rules});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_rule_modify_http_header_name(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rule_modify_http_header_name", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public string [] [] Endget_rule_modify_http_header_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rule_modify_http_header_operation
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public PEMPolicyModifyHTTPHeaderOperationType [] [] get_rule_modify_http_header_operation(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_rule_modify_http_header_operation", new object [] {
				policies,
				rules});
		return ((PEMPolicyModifyHTTPHeaderOperationType [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_rule_modify_http_header_operation(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rule_modify_http_header_operation", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public PEMPolicyModifyHTTPHeaderOperationType [] [] Endget_rule_modify_http_header_operation(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((PEMPolicyModifyHTTPHeaderOperationType [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rule_modify_http_header_value_content
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_rule_modify_http_header_value_content(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_rule_modify_http_header_value_content", new object [] {
				policies,
				rules});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_rule_modify_http_header_value_content(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rule_modify_http_header_value_content", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public string [] [] Endget_rule_modify_http_header_value_content(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rule_modify_http_header_value_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public PEMPolicyModifyHTTPHeaderValueType [] [] get_rule_modify_http_header_value_type(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_rule_modify_http_header_value_type", new object [] {
				policies,
				rules});
		return ((PEMPolicyModifyHTTPHeaderValueType [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_rule_modify_http_header_value_type(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rule_modify_http_header_value_type", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public PEMPolicyModifyHTTPHeaderValueType [] [] Endget_rule_modify_http_header_value_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((PEMPolicyModifyHTTPHeaderValueType [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rule_precedence
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_rule_precedence(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_rule_precedence", new object [] {
				policies,
				rules});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_rule_precedence(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rule_precedence", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public long [] [] Endget_rule_precedence(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rule_qos_rate_pir_downlink
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_rule_qos_rate_pir_downlink(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_rule_qos_rate_pir_downlink", new object [] {
				policies,
				rules});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_rule_qos_rate_pir_downlink(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rule_qos_rate_pir_downlink", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public string [] [] Endget_rule_qos_rate_pir_downlink(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rule_qos_rate_pir_uplink
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_rule_qos_rate_pir_uplink(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_rule_qos_rate_pir_uplink", new object [] {
				policies,
				rules});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_rule_qos_rate_pir_uplink(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rule_qos_rate_pir_uplink", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public string [] [] Endget_rule_qos_rate_pir_uplink(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rule_report_granularity
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public PEMPolicyReportGranularityType [] [] get_rule_report_granularity(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_rule_report_granularity", new object [] {
				policies,
				rules});
		return ((PEMPolicyReportGranularityType [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_rule_report_granularity(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rule_report_granularity", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public PEMPolicyReportGranularityType [] [] Endget_rule_report_granularity(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((PEMPolicyReportGranularityType [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rule_service_chain
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_rule_service_chain(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_rule_service_chain", new object [] {
				policies,
				rules});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_rule_service_chain(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rule_service_chain", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public string [] [] Endget_rule_service_chain(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rule_sub_policy_downlink
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_rule_sub_policy_downlink(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_rule_sub_policy_downlink", new object [] {
				policies,
				rules});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_rule_sub_policy_downlink(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rule_sub_policy_downlink", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public string [] [] Endget_rule_sub_policy_downlink(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rule_sub_policy_uplink
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_rule_sub_policy_uplink(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_rule_sub_policy_uplink", new object [] {
				policies,
				rules});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_rule_sub_policy_uplink(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rule_sub_policy_uplink", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public string [] [] Endget_rule_sub_policy_uplink(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rule_tcl_filter
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_rule_tcl_filter(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_rule_tcl_filter", new object [] {
				policies,
				rules});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_rule_tcl_filter(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rule_tcl_filter", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public string [] [] Endget_rule_tcl_filter(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rule_total_volume_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_rule_total_volume_threshold(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_rule_total_volume_threshold", new object [] {
				policies,
				rules});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_rule_total_volume_threshold(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rule_total_volume_threshold", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public long [] [] Endget_rule_total_volume_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rule_uplink_volume_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_rule_uplink_volume_threshold(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_rule_uplink_volume_threshold", new object [] {
				policies,
				rules});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_rule_uplink_volume_threshold(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rule_uplink_volume_threshold", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public long [] [] Endget_rule_uplink_volume_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
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
	// remove_all_classification_filters
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void remove_all_classification_filters(
		string [] policies,
		string [] [] rules
	) {
		this.Invoke("remove_all_classification_filters", new object [] {
				policies,
				rules});

	}
	public System.IAsyncResult Beginremove_all_classification_filters(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_classification_filters", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public void Endremove_all_classification_filters(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_flow_info_filters
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void remove_all_flow_info_filters(
		string [] policies,
		string [] [] rules
	) {
		this.Invoke("remove_all_flow_info_filters", new object [] {
				policies,
				rules});

	}
	public System.IAsyncResult Beginremove_all_flow_info_filters(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_flow_info_filters", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public void Endremove_all_flow_info_filters(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_rules
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void remove_all_rules(
		string [] policies
	) {
		this.Invoke("remove_all_rules", new object [] {
				policies});

	}
	public System.IAsyncResult Beginremove_all_rules(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_rules", new object[] {
			policies}, callback, asyncState);
	}
	public void Endremove_all_rules(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_classification_filter
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void remove_classification_filter(
		string [] policies,
		string [] [] rules,
		string [] [] [] filters
	) {
		this.Invoke("remove_classification_filter", new object [] {
				policies,
				rules,
				filters});

	}
	public System.IAsyncResult Beginremove_classification_filter(string [] policies,string [] [] rules,string [] [] [] filters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_classification_filter", new object[] {
			policies,
			rules,
			filters}, callback, asyncState);
	}
	public void Endremove_classification_filter(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_flow_info_filter
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void remove_flow_info_filter(
		string [] policies,
		string [] [] rules,
		string [] [] [] filters
	) {
		this.Invoke("remove_flow_info_filter", new object [] {
				policies,
				rules,
				filters});

	}
	public System.IAsyncResult Beginremove_flow_info_filter(string [] policies,string [] [] rules,string [] [] [] filters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_flow_info_filter", new object[] {
			policies,
			rules,
			filters}, callback, asyncState);
	}
	public void Endremove_flow_info_filter(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void remove_rule(
		string [] policies,
		string [] [] rules
	) {
		this.Invoke("remove_rule", new object [] {
				policies,
				rules});

	}
	public System.IAsyncResult Beginremove_rule(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_rule", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public void Endremove_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_classification_filter_application
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void set_classification_filter_application(
		string [] policies,
		string [] [] rules,
		string [] [] [] filters,
		string [] [] [] applications,
		string [] [] [] categories
	) {
		this.Invoke("set_classification_filter_application", new object [] {
				policies,
				rules,
				filters,
				applications,
				categories});

	}
	public System.IAsyncResult Beginset_classification_filter_application(string [] policies,string [] [] rules,string [] [] [] filters,string [] [] [] applications,string [] [] [] categories, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_classification_filter_application", new object[] {
			policies,
			rules,
			filters,
			applications,
			categories}, callback, asyncState);
	}
	public void Endset_classification_filter_application(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_classification_filter_category
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void set_classification_filter_category(
		string [] policies,
		string [] [] rules,
		string [] [] [] filters,
		string [] [] [] applications,
		string [] [] [] categories
	) {
		this.Invoke("set_classification_filter_category", new object [] {
				policies,
				rules,
				filters,
				applications,
				categories});

	}
	public System.IAsyncResult Beginset_classification_filter_category(string [] policies,string [] [] rules,string [] [] [] filters,string [] [] [] applications,string [] [] [] categories, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_classification_filter_category", new object[] {
			policies,
			rules,
			filters,
			applications,
			categories}, callback, asyncState);
	}
	public void Endset_classification_filter_category(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_classification_filter_operation_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void set_classification_filter_operation_type(
		string [] policies,
		string [] [] rules,
		string [] [] [] filters,
		PEMPolicyFilterOperationType [] [] [] types
	) {
		this.Invoke("set_classification_filter_operation_type", new object [] {
				policies,
				rules,
				filters,
				types});

	}
	public System.IAsyncResult Beginset_classification_filter_operation_type(string [] policies,string [] [] rules,string [] [] [] filters,PEMPolicyFilterOperationType [] [] [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_classification_filter_operation_type", new object[] {
			policies,
			rules,
			filters,
			types}, callback, asyncState);
	}
	public void Endset_classification_filter_operation_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
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
	// set_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void set_enabled_state(
		string [] policies,
		CommonEnabledState [] states
	) {
		this.Invoke("set_enabled_state", new object [] {
				policies,
				states});

	}
	public System.IAsyncResult Beginset_enabled_state(string [] policies,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_enabled_state", new object[] {
			policies,
			states}, callback, asyncState);
	}
	public void Endset_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_flow_info_filter_destination_ip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void set_flow_info_filter_destination_ip(
		string [] policies,
		string [] [] rules,
		string [] [] [] filters,
		CommonIPNetmask [] [] [] ip_netmasks
	) {
		this.Invoke("set_flow_info_filter_destination_ip", new object [] {
				policies,
				rules,
				filters,
				ip_netmasks});

	}
	public System.IAsyncResult Beginset_flow_info_filter_destination_ip(string [] policies,string [] [] rules,string [] [] [] filters,CommonIPNetmask [] [] [] ip_netmasks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_flow_info_filter_destination_ip", new object[] {
			policies,
			rules,
			filters,
			ip_netmasks}, callback, asyncState);
	}
	public void Endset_flow_info_filter_destination_ip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_flow_info_filter_destination_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void set_flow_info_filter_destination_port(
		string [] policies,
		string [] [] rules,
		string [] [] [] filters,
		long [] [] [] ports
	) {
		this.Invoke("set_flow_info_filter_destination_port", new object [] {
				policies,
				rules,
				filters,
				ports});

	}
	public System.IAsyncResult Beginset_flow_info_filter_destination_port(string [] policies,string [] [] rules,string [] [] [] filters,long [] [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_flow_info_filter_destination_port", new object[] {
			policies,
			rules,
			filters,
			ports}, callback, asyncState);
	}
	public void Endset_flow_info_filter_destination_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_flow_info_filter_dscp_code
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void set_flow_info_filter_dscp_code(
		string [] policies,
		string [] [] rules,
		string [] [] [] filters,
		long [] [] [] codes
	) {
		this.Invoke("set_flow_info_filter_dscp_code", new object [] {
				policies,
				rules,
				filters,
				codes});

	}
	public System.IAsyncResult Beginset_flow_info_filter_dscp_code(string [] policies,string [] [] rules,string [] [] [] filters,long [] [] [] codes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_flow_info_filter_dscp_code", new object[] {
			policies,
			rules,
			filters,
			codes}, callback, asyncState);
	}
	public void Endset_flow_info_filter_dscp_code(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_flow_info_filter_from_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void set_flow_info_filter_from_vlan(
		string [] policies,
		string [] [] rules,
		string [] [] [] filters,
		string [] [] [] vlans
	) {
		this.Invoke("set_flow_info_filter_from_vlan", new object [] {
				policies,
				rules,
				filters,
				vlans});

	}
	public System.IAsyncResult Beginset_flow_info_filter_from_vlan(string [] policies,string [] [] rules,string [] [] [] filters,string [] [] [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_flow_info_filter_from_vlan", new object[] {
			policies,
			rules,
			filters,
			vlans}, callback, asyncState);
	}
	public void Endset_flow_info_filter_from_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_flow_info_filter_l2_endpoint_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void set_flow_info_filter_l2_endpoint_type(
		string [] policies,
		string [] [] rules,
		string [] [] [] filters,
		PEMPolicyL2EndpointType [] [] [] types
	) {
		this.Invoke("set_flow_info_filter_l2_endpoint_type", new object [] {
				policies,
				rules,
				filters,
				types});

	}
	public System.IAsyncResult Beginset_flow_info_filter_l2_endpoint_type(string [] policies,string [] [] rules,string [] [] [] filters,PEMPolicyL2EndpointType [] [] [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_flow_info_filter_l2_endpoint_type", new object[] {
			policies,
			rules,
			filters,
			types}, callback, asyncState);
	}
	public void Endset_flow_info_filter_l2_endpoint_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_flow_info_filter_operation_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void set_flow_info_filter_operation_type(
		string [] policies,
		string [] [] rules,
		string [] [] [] filters,
		PEMPolicyFilterOperationType [] [] [] types
	) {
		this.Invoke("set_flow_info_filter_operation_type", new object [] {
				policies,
				rules,
				filters,
				types});

	}
	public System.IAsyncResult Beginset_flow_info_filter_operation_type(string [] policies,string [] [] rules,string [] [] [] filters,PEMPolicyFilterOperationType [] [] [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_flow_info_filter_operation_type", new object[] {
			policies,
			rules,
			filters,
			types}, callback, asyncState);
	}
	public void Endset_flow_info_filter_operation_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_flow_info_filter_protocol_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void set_flow_info_filter_protocol_type(
		string [] policies,
		string [] [] rules,
		string [] [] [] filters,
		PEMPolicyProtocolType [] [] [] types
	) {
		this.Invoke("set_flow_info_filter_protocol_type", new object [] {
				policies,
				rules,
				filters,
				types});

	}
	public System.IAsyncResult Beginset_flow_info_filter_protocol_type(string [] policies,string [] [] rules,string [] [] [] filters,PEMPolicyProtocolType [] [] [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_flow_info_filter_protocol_type", new object[] {
			policies,
			rules,
			filters,
			types}, callback, asyncState);
	}
	public void Endset_flow_info_filter_protocol_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_flow_info_filter_source_ip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void set_flow_info_filter_source_ip(
		string [] policies,
		string [] [] rules,
		string [] [] [] filters,
		CommonIPNetmask [] [] [] ip_netmasks
	) {
		this.Invoke("set_flow_info_filter_source_ip", new object [] {
				policies,
				rules,
				filters,
				ip_netmasks});

	}
	public System.IAsyncResult Beginset_flow_info_filter_source_ip(string [] policies,string [] [] rules,string [] [] [] filters,CommonIPNetmask [] [] [] ip_netmasks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_flow_info_filter_source_ip", new object[] {
			policies,
			rules,
			filters,
			ip_netmasks}, callback, asyncState);
	}
	public void Endset_flow_info_filter_source_ip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_flow_info_filter_source_ip_and_destination_ip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void set_flow_info_filter_source_ip_and_destination_ip(
		string [] policies,
		string [] [] rules,
		string [] [] [] filters,
		CommonIPNetmask [] [] [] source_ip_netmasks,
		CommonIPNetmask [] [] [] destination_ip_netmasks
	) {
		this.Invoke("set_flow_info_filter_source_ip_and_destination_ip", new object [] {
				policies,
				rules,
				filters,
				source_ip_netmasks,
				destination_ip_netmasks});

	}
	public System.IAsyncResult Beginset_flow_info_filter_source_ip_and_destination_ip(string [] policies,string [] [] rules,string [] [] [] filters,CommonIPNetmask [] [] [] source_ip_netmasks,CommonIPNetmask [] [] [] destination_ip_netmasks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_flow_info_filter_source_ip_and_destination_ip", new object[] {
			policies,
			rules,
			filters,
			source_ip_netmasks,
			destination_ip_netmasks}, callback, asyncState);
	}
	public void Endset_flow_info_filter_source_ip_and_destination_ip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_flow_info_filter_source_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void set_flow_info_filter_source_port(
		string [] policies,
		string [] [] rules,
		string [] [] [] filters,
		long [] [] [] ports
	) {
		this.Invoke("set_flow_info_filter_source_port", new object [] {
				policies,
				rules,
				filters,
				ports});

	}
	public System.IAsyncResult Beginset_flow_info_filter_source_port(string [] policies,string [] [] rules,string [] [] [] filters,long [] [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_flow_info_filter_source_port", new object[] {
			policies,
			rules,
			filters,
			ports}, callback, asyncState);
	}
	public void Endset_flow_info_filter_source_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rule_downlink_volume_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void set_rule_downlink_volume_threshold(
		string [] policies,
		string [] [] rules,
		long [] [] thresholds
	) {
		this.Invoke("set_rule_downlink_volume_threshold", new object [] {
				policies,
				rules,
				thresholds});

	}
	public System.IAsyncResult Beginset_rule_downlink_volume_threshold(string [] policies,string [] [] rules,long [] [] thresholds, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rule_downlink_volume_threshold", new object[] {
			policies,
			rules,
			thresholds}, callback, asyncState);
	}
	public void Endset_rule_downlink_volume_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rule_dscp_marking_downlink
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void set_rule_dscp_marking_downlink(
		string [] policies,
		string [] [] rules,
		long [] [] markings
	) {
		this.Invoke("set_rule_dscp_marking_downlink", new object [] {
				policies,
				rules,
				markings});

	}
	public System.IAsyncResult Beginset_rule_dscp_marking_downlink(string [] policies,string [] [] rules,long [] [] markings, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rule_dscp_marking_downlink", new object[] {
			policies,
			rules,
			markings}, callback, asyncState);
	}
	public void Endset_rule_dscp_marking_downlink(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rule_dscp_marking_uplink
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void set_rule_dscp_marking_uplink(
		string [] policies,
		string [] [] rules,
		long [] [] markings
	) {
		this.Invoke("set_rule_dscp_marking_uplink", new object [] {
				policies,
				rules,
				markings});

	}
	public System.IAsyncResult Beginset_rule_dscp_marking_uplink(string [] policies,string [] [] rules,long [] [] markings, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rule_dscp_marking_uplink", new object[] {
			policies,
			rules,
			markings}, callback, asyncState);
	}
	public void Endset_rule_dscp_marking_uplink(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rule_forwarding_action_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void set_rule_forwarding_action_type(
		string [] policies,
		string [] [] rules,
		PEMPolicyForwardingActionType [] [] values
	) {
		this.Invoke("set_rule_forwarding_action_type", new object [] {
				policies,
				rules,
				values});

	}
	public System.IAsyncResult Beginset_rule_forwarding_action_type(string [] policies,string [] [] rules,PEMPolicyForwardingActionType [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rule_forwarding_action_type", new object[] {
			policies,
			rules,
			values}, callback, asyncState);
	}
	public void Endset_rule_forwarding_action_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rule_forwarding_endpoint
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void set_rule_forwarding_endpoint(
		string [] policies,
		string [] [] rules,
		string [] [] endpoints
	) {
		this.Invoke("set_rule_forwarding_endpoint", new object [] {
				policies,
				rules,
				endpoints});

	}
	public System.IAsyncResult Beginset_rule_forwarding_endpoint(string [] policies,string [] [] rules,string [] [] endpoints, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rule_forwarding_endpoint", new object[] {
			policies,
			rules,
			endpoints}, callback, asyncState);
	}
	public void Endset_rule_forwarding_endpoint(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rule_gate_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void set_rule_gate_state(
		string [] policies,
		string [] [] rules,
		PEMPolicyGateStatusType [] [] states
	) {
		this.Invoke("set_rule_gate_state", new object [] {
				policies,
				rules,
				states});

	}
	public System.IAsyncResult Beginset_rule_gate_state(string [] policies,string [] [] rules,PEMPolicyGateStatusType [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rule_gate_state", new object[] {
			policies,
			rules,
			states}, callback, asyncState);
	}
	public void Endset_rule_gate_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rule_gx_monitoring_key
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void set_rule_gx_monitoring_key(
		string [] policies,
		string [] [] rules,
		string [] [] keys
	) {
		this.Invoke("set_rule_gx_monitoring_key", new object [] {
				policies,
				rules,
				keys});

	}
	public System.IAsyncResult Beginset_rule_gx_monitoring_key(string [] policies,string [] [] rules,string [] [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rule_gx_monitoring_key", new object[] {
			policies,
			rules,
			keys}, callback, asyncState);
	}
	public void Endset_rule_gx_monitoring_key(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rule_hsl_endpoint
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void set_rule_hsl_endpoint(
		string [] policies,
		string [] [] rules,
		string [] [] endpoints
	) {
		this.Invoke("set_rule_hsl_endpoint", new object [] {
				policies,
				rules,
				endpoints});

	}
	public System.IAsyncResult Beginset_rule_hsl_endpoint(string [] policies,string [] [] rules,string [] [] endpoints, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rule_hsl_endpoint", new object[] {
			policies,
			rules,
			endpoints}, callback, asyncState);
	}
	public void Endset_rule_hsl_endpoint(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rule_hsl_format_script
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void set_rule_hsl_format_script(
		string [] policies,
		string [] [] rules,
		string [] [] scripts
	) {
		this.Invoke("set_rule_hsl_format_script", new object [] {
				policies,
				rules,
				scripts});

	}
	public System.IAsyncResult Beginset_rule_hsl_format_script(string [] policies,string [] [] rules,string [] [] scripts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rule_hsl_format_script", new object[] {
			policies,
			rules,
			scripts}, callback, asyncState);
	}
	public void Endset_rule_hsl_format_script(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rule_http_redirect
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void set_rule_http_redirect(
		string [] policies,
		string [] [] rules,
		string [] [] redirects
	) {
		this.Invoke("set_rule_http_redirect", new object [] {
				policies,
				rules,
				redirects});

	}
	public System.IAsyncResult Beginset_rule_http_redirect(string [] policies,string [] [] rules,string [] [] redirects, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rule_http_redirect", new object[] {
			policies,
			rules,
			redirects}, callback, asyncState);
	}
	public void Endset_rule_http_redirect(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rule_intercept
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void set_rule_intercept(
		string [] policies,
		string [] [] rules,
		string [] [] intercepts
	) {
		this.Invoke("set_rule_intercept", new object [] {
				policies,
				rules,
				intercepts});

	}
	public System.IAsyncResult Beginset_rule_intercept(string [] policies,string [] [] rules,string [] [] intercepts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rule_intercept", new object[] {
			policies,
			rules,
			intercepts}, callback, asyncState);
	}
	public void Endset_rule_intercept(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rule_internal_virtual_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void set_rule_internal_virtual_server(
		string [] policies,
		string [] [] rules,
		string [] [] virtual_servers
	) {
		this.Invoke("set_rule_internal_virtual_server", new object [] {
				policies,
				rules,
				virtual_servers});

	}
	public System.IAsyncResult Beginset_rule_internal_virtual_server(string [] policies,string [] [] rules,string [] [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rule_internal_virtual_server", new object[] {
			policies,
			rules,
			virtual_servers}, callback, asyncState);
	}
	public void Endset_rule_internal_virtual_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rule_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void set_rule_interval(
		string [] policies,
		string [] [] rules,
		long [] [] intervals
	) {
		this.Invoke("set_rule_interval", new object [] {
				policies,
				rules,
				intervals});

	}
	public System.IAsyncResult Beginset_rule_interval(string [] policies,string [] [] rules,long [] [] intervals, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rule_interval", new object[] {
			policies,
			rules,
			intervals}, callback, asyncState);
	}
	public void Endset_rule_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rule_l2_marking_downlink_level
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void set_rule_l2_marking_downlink_level(
		string [] policies,
		string [] [] rules,
		long [] [] levels
	) {
		this.Invoke("set_rule_l2_marking_downlink_level", new object [] {
				policies,
				rules,
				levels});

	}
	public System.IAsyncResult Beginset_rule_l2_marking_downlink_level(string [] policies,string [] [] rules,long [] [] levels, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rule_l2_marking_downlink_level", new object[] {
			policies,
			rules,
			levels}, callback, asyncState);
	}
	public void Endset_rule_l2_marking_downlink_level(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rule_l2_marking_uplink_level
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void set_rule_l2_marking_uplink_level(
		string [] policies,
		string [] [] rules,
		long [] [] levels
	) {
		this.Invoke("set_rule_l2_marking_uplink_level", new object [] {
				policies,
				rules,
				levels});

	}
	public System.IAsyncResult Beginset_rule_l2_marking_uplink_level(string [] policies,string [] [] rules,long [] [] levels, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rule_l2_marking_uplink_level", new object[] {
			policies,
			rules,
			levels}, callback, asyncState);
	}
	public void Endset_rule_l2_marking_uplink_level(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rule_modify_http_header_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void set_rule_modify_http_header_name(
		string [] policies,
		string [] [] rules,
		string [] [] values
	) {
		this.Invoke("set_rule_modify_http_header_name", new object [] {
				policies,
				rules,
				values});

	}
	public System.IAsyncResult Beginset_rule_modify_http_header_name(string [] policies,string [] [] rules,string [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rule_modify_http_header_name", new object[] {
			policies,
			rules,
			values}, callback, asyncState);
	}
	public void Endset_rule_modify_http_header_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rule_modify_http_header_operation
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void set_rule_modify_http_header_operation(
		string [] policies,
		string [] [] rules,
		PEMPolicyModifyHTTPHeaderOperationType [] [] values
	) {
		this.Invoke("set_rule_modify_http_header_operation", new object [] {
				policies,
				rules,
				values});

	}
	public System.IAsyncResult Beginset_rule_modify_http_header_operation(string [] policies,string [] [] rules,PEMPolicyModifyHTTPHeaderOperationType [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rule_modify_http_header_operation", new object[] {
			policies,
			rules,
			values}, callback, asyncState);
	}
	public void Endset_rule_modify_http_header_operation(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rule_modify_http_header_value_content
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void set_rule_modify_http_header_value_content(
		string [] policies,
		string [] [] rules,
		string [] [] values
	) {
		this.Invoke("set_rule_modify_http_header_value_content", new object [] {
				policies,
				rules,
				values});

	}
	public System.IAsyncResult Beginset_rule_modify_http_header_value_content(string [] policies,string [] [] rules,string [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rule_modify_http_header_value_content", new object[] {
			policies,
			rules,
			values}, callback, asyncState);
	}
	public void Endset_rule_modify_http_header_value_content(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rule_modify_http_header_value_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void set_rule_modify_http_header_value_type(
		string [] policies,
		string [] [] rules,
		PEMPolicyModifyHTTPHeaderValueType [] [] values
	) {
		this.Invoke("set_rule_modify_http_header_value_type", new object [] {
				policies,
				rules,
				values});

	}
	public System.IAsyncResult Beginset_rule_modify_http_header_value_type(string [] policies,string [] [] rules,PEMPolicyModifyHTTPHeaderValueType [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rule_modify_http_header_value_type", new object[] {
			policies,
			rules,
			values}, callback, asyncState);
	}
	public void Endset_rule_modify_http_header_value_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rule_precedence
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void set_rule_precedence(
		string [] policies,
		string [] [] rules,
		long [] [] precedences
	) {
		this.Invoke("set_rule_precedence", new object [] {
				policies,
				rules,
				precedences});

	}
	public System.IAsyncResult Beginset_rule_precedence(string [] policies,string [] [] rules,long [] [] precedences, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rule_precedence", new object[] {
			policies,
			rules,
			precedences}, callback, asyncState);
	}
	public void Endset_rule_precedence(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rule_qos_rate_pir_downlink
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void set_rule_qos_rate_pir_downlink(
		string [] policies,
		string [] [] rules,
		string [] [] controls
	) {
		this.Invoke("set_rule_qos_rate_pir_downlink", new object [] {
				policies,
				rules,
				controls});

	}
	public System.IAsyncResult Beginset_rule_qos_rate_pir_downlink(string [] policies,string [] [] rules,string [] [] controls, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rule_qos_rate_pir_downlink", new object[] {
			policies,
			rules,
			controls}, callback, asyncState);
	}
	public void Endset_rule_qos_rate_pir_downlink(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rule_qos_rate_pir_uplink
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void set_rule_qos_rate_pir_uplink(
		string [] policies,
		string [] [] rules,
		string [] [] controls
	) {
		this.Invoke("set_rule_qos_rate_pir_uplink", new object [] {
				policies,
				rules,
				controls});

	}
	public System.IAsyncResult Beginset_rule_qos_rate_pir_uplink(string [] policies,string [] [] rules,string [] [] controls, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rule_qos_rate_pir_uplink", new object[] {
			policies,
			rules,
			controls}, callback, asyncState);
	}
	public void Endset_rule_qos_rate_pir_uplink(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rule_report_granularity
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void set_rule_report_granularity(
		string [] policies,
		string [] [] rules,
		PEMPolicyReportGranularityType [] [] types
	) {
		this.Invoke("set_rule_report_granularity", new object [] {
				policies,
				rules,
				types});

	}
	public System.IAsyncResult Beginset_rule_report_granularity(string [] policies,string [] [] rules,PEMPolicyReportGranularityType [] [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rule_report_granularity", new object[] {
			policies,
			rules,
			types}, callback, asyncState);
	}
	public void Endset_rule_report_granularity(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rule_service_chain
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void set_rule_service_chain(
		string [] policies,
		string [] [] rules,
		string [] [] chains
	) {
		this.Invoke("set_rule_service_chain", new object [] {
				policies,
				rules,
				chains});

	}
	public System.IAsyncResult Beginset_rule_service_chain(string [] policies,string [] [] rules,string [] [] chains, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rule_service_chain", new object[] {
			policies,
			rules,
			chains}, callback, asyncState);
	}
	public void Endset_rule_service_chain(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rule_sub_policy_downlink
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void set_rule_sub_policy_downlink(
		string [] policies,
		string [] [] rules,
		string [] [] sub_policies
	) {
		this.Invoke("set_rule_sub_policy_downlink", new object [] {
				policies,
				rules,
				sub_policies});

	}
	public System.IAsyncResult Beginset_rule_sub_policy_downlink(string [] policies,string [] [] rules,string [] [] sub_policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rule_sub_policy_downlink", new object[] {
			policies,
			rules,
			sub_policies}, callback, asyncState);
	}
	public void Endset_rule_sub_policy_downlink(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rule_sub_policy_uplink
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void set_rule_sub_policy_uplink(
		string [] policies,
		string [] [] rules,
		string [] [] sub_policies
	) {
		this.Invoke("set_rule_sub_policy_uplink", new object [] {
				policies,
				rules,
				sub_policies});

	}
	public System.IAsyncResult Beginset_rule_sub_policy_uplink(string [] policies,string [] [] rules,string [] [] sub_policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rule_sub_policy_uplink", new object[] {
			policies,
			rules,
			sub_policies}, callback, asyncState);
	}
	public void Endset_rule_sub_policy_uplink(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rule_tcl_filter
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void set_rule_tcl_filter(
		string [] policies,
		string [] [] rules,
		string [] [] filters
	) {
		this.Invoke("set_rule_tcl_filter", new object [] {
				policies,
				rules,
				filters});

	}
	public System.IAsyncResult Beginset_rule_tcl_filter(string [] policies,string [] [] rules,string [] [] filters, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rule_tcl_filter", new object[] {
			policies,
			rules,
			filters}, callback, asyncState);
	}
	public void Endset_rule_tcl_filter(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rule_total_volume_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void set_rule_total_volume_threshold(
		string [] policies,
		string [] [] rules,
		long [] [] thresholds
	) {
		this.Invoke("set_rule_total_volume_threshold", new object [] {
				policies,
				rules,
				thresholds});

	}
	public System.IAsyncResult Beginset_rule_total_volume_threshold(string [] policies,string [] [] rules,long [] [] thresholds, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rule_total_volume_threshold", new object[] {
			policies,
			rules,
			thresholds}, callback, asyncState);
	}
	public void Endset_rule_total_volume_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rule_uplink_volume_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:PEM/Policy", 
		RequestNamespace="urn:iControl:PEM/Policy", ResponseNamespace="urn:iControl:PEM/Policy")]
	public void set_rule_uplink_volume_threshold(
		string [] policies,
		string [] [] rules,
		long [] [] thresholds
	) {
		this.Invoke("set_rule_uplink_volume_threshold", new object [] {
				policies,
				rules,
				thresholds});

	}
	public System.IAsyncResult Beginset_rule_uplink_volume_threshold(string [] policies,string [] [] rules,long [] [] thresholds, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rule_uplink_volume_threshold", new object[] {
			policies,
			rules,
			thresholds}, callback, asyncState);
	}
	public void Endset_rule_uplink_volume_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "PEM.Policy.FilterOperationType", Namespace = "urn:iControl")]
	public enum PEMPolicyFilterOperationType
	{
		FILTER_OPERATION_TYPE_UNKNOWN,
		FILTER_OPERATION_TYPE_NOMATCH,
		FILTER_OPERATION_TYPE_MATCH,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "PEM.Policy.ForwardingActionType", Namespace = "urn:iControl")]
	public enum PEMPolicyForwardingActionType
	{
		FORWARDING_ACTION_TYPE_UNKNOWN,
		FORWARDING_ACTION_TYPE_NONE,
		FORWARDING_ACTION_TYPE_ROUTE_TO_NETWORK,
		FORWARDING_ACTION_TYPE_POOL,
		FORWARDING_ACTION_TYPE_ICAP,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "PEM.Policy.GateStatusType", Namespace = "urn:iControl")]
	public enum PEMPolicyGateStatusType
	{
		GATE_STATUS_TYPE_UNKNOWN,
		GATE_STATUS_TYPE_ENABLED,
		GATE_STATUS_TYPE_DISABLED,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "PEM.Policy.L2EndpointType", Namespace = "urn:iControl")]
	public enum PEMPolicyL2EndpointType
	{
		L2_ENDPOINT_TYPE_UNKNOWN,
		L2_ENDPOINT_TYPE_DISABLED,
		L2_ENDPOINT_TYPE_VLAN,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "PEM.Policy.ModifyHTTPHeaderOperationType", Namespace = "urn:iControl")]
	public enum PEMPolicyModifyHTTPHeaderOperationType
	{
		MODIFY_HTTP_HEADER_OPERATION_TYPE_UNKNOWN,
		MODIFY_HTTP_HEADER_OPERATION_TYPE_NONE,
		MODIFY_HTTP_HEADER_OPERATION_TYPE_INSERT,
		MODIFY_HTTP_HEADER_OPERATION_TYPE_REMOVE,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "PEM.Policy.ModifyHTTPHeaderValueType", Namespace = "urn:iControl")]
	public enum PEMPolicyModifyHTTPHeaderValueType
	{
		MODIFY_HTTP_HEADER_VALUE_TYPE_UNKNOWN,
		MODIFY_HTTP_HEADER_VALUE_TYPE_STRING,
		MODIFY_HTTP_HEADER_VALUE_TYPE_TCL_SNIPPET,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "PEM.Policy.ProtocolType", Namespace = "urn:iControl")]
	public enum PEMPolicyProtocolType
	{
		RULE_PROTOCOL_TYPE_UNKNOWN,
		RULE_PROTOCOL_TYPE_ANY,
		RULE_PROTOCOL_TYPE_TCP,
		RULE_PROTOCOL_TYPE_UDP,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "PEM.Policy.ReportGranularityType", Namespace = "urn:iControl")]
	public enum PEMPolicyReportGranularityType
	{
		REPORT_GRANULARITY_TYPE_UNKNOWN,
		REPORT_GRANULARITY_TYPE_SESSION,
		REPORT_GRANULARITY_TYPE_FLOW,
	}

	//=======================================================================
	// Structs
	//=======================================================================

}
