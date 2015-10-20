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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.ContentPolicyBinding", Namespace="urn:iControl")]
	public partial class LocalLBContentPolicy : iControlInterface {
		public LocalLBContentPolicy() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_condition_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void add_condition_value(
		string [] policies,
		string [] [] rules,
		long [] [] [] condition_ids,
		string [] [] [] [] values
	) {
		this.Invoke("add_condition_value", new object [] {
				policies,
				rules,
				condition_ids,
				values});

	}
	public System.IAsyncResult Beginadd_condition_value(string [] policies,string [] [] rules,long [] [] [] condition_ids,string [] [] [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_condition_value", new object[] {
			policies,
			rules,
			condition_ids,
			values}, callback, asyncState);
	}
	public void Endadd_condition_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_policy_controls
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void add_policy_controls(
		string [] policies,
		LocalLBContentPolicyPolicyControls [] [] controls
	) {
		this.Invoke("add_policy_controls", new object [] {
				policies,
				controls});

	}
	public System.IAsyncResult Beginadd_policy_controls(string [] policies,LocalLBContentPolicyPolicyControls [] [] controls, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_policy_controls", new object[] {
			policies,
			controls}, callback, asyncState);
	}
	public void Endadd_policy_controls(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_policy_requires
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void add_policy_requires(
		string [] policies,
		LocalLBContentPolicyPolicyRequires [] [] requires
	) {
		this.Invoke("add_policy_requires", new object [] {
				policies,
				requires});

	}
	public System.IAsyncResult Beginadd_policy_requires(string [] policies,LocalLBContentPolicyPolicyRequires [] [] requires, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_policy_requires", new object[] {
			policies,
			requires}, callback, asyncState);
	}
	public void Endadd_policy_requires(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_policy_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void add_policy_rule(
		string [] policies,
		string [] [] rules
	) {
		this.Invoke("add_policy_rule", new object [] {
				policies,
				rules});

	}
	public System.IAsyncResult Beginadd_policy_rule(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_policy_rule", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public void Endadd_policy_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_rule_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void add_rule_action(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids
	) {
		this.Invoke("add_rule_action", new object [] {
				policies,
				rules,
				action_ids});

	}
	public System.IAsyncResult Beginadd_rule_action(string [] policies,string [] [] rules,long [] [] [] action_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_rule_action", new object[] {
			policies,
			rules,
			action_ids}, callback, asyncState);
	}
	public void Endadd_rule_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_rule_condition
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void add_rule_condition(
		string [] policies,
		string [] [] rules,
		long [] [] [] condition_ids
	) {
		this.Invoke("add_rule_condition", new object [] {
				policies,
				rules,
				condition_ids});

	}
	public System.IAsyncResult Beginadd_rule_condition(string [] policies,string [] [] rules,long [] [] [] condition_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_rule_condition", new object[] {
			policies,
			rules,
			condition_ids}, callback, asyncState);
	}
	public void Endadd_rule_condition(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void create(
		string [] policies,
		string [] strategies
	) {
		this.Invoke("create", new object [] {
				policies,
				strategies});

	}
	public System.IAsyncResult Begincreate(string [] policies,string [] strategies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			policies,
			strategies}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_policies
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
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
	// get_action_application
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_action_application(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids
	) {
		object [] results = this.Invoke("get_action_application", new object [] {
				policies,
				rules,
				action_ids});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_action_application(string [] policies,string [] [] rules,long [] [] [] action_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action_application", new object[] {
			policies,
			rules,
			action_ids}, callback, asyncState);
	}
	public string [] [] [] Endget_action_application(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_action_category
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_action_category(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids
	) {
		object [] results = this.Invoke("get_action_category", new object [] {
				policies,
				rules,
				action_ids});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_action_category(string [] policies,string [] [] rules,long [] [] [] action_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action_category", new object[] {
			policies,
			rules,
			action_ids}, callback, asyncState);
	}
	public string [] [] [] Endget_action_category(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_action_clone_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_action_clone_pool(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids
	) {
		object [] results = this.Invoke("get_action_clone_pool", new object [] {
				policies,
				rules,
				action_ids});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_action_clone_pool(string [] policies,string [] [] rules,long [] [] [] action_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action_clone_pool", new object[] {
			policies,
			rules,
			action_ids}, callback, asyncState);
	}
	public string [] [] [] Endget_action_clone_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_action_defer_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] [] get_action_defer_state(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids
	) {
		object [] results = this.Invoke("get_action_defer_state", new object [] {
				policies,
				rules,
				action_ids});
		return ((CommonEnabledState [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_action_defer_state(string [] policies,string [] [] rules,long [] [] [] action_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action_defer_state", new object[] {
			policies,
			rules,
			action_ids}, callback, asyncState);
	}
	public CommonEnabledState [] [] [] Endget_action_defer_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_action_domain
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_action_domain(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids
	) {
		object [] results = this.Invoke("get_action_domain", new object [] {
				policies,
				rules,
				action_ids});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_action_domain(string [] policies,string [] [] rules,long [] [] [] action_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action_domain", new object[] {
			policies,
			rules,
			action_ids}, callback, asyncState);
	}
	public string [] [] [] Endget_action_domain(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_action_event
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBPolicyEvent [] [] [] get_action_event(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids
	) {
		object [] results = this.Invoke("get_action_event", new object [] {
				policies,
				rules,
				action_ids});
		return ((LocalLBPolicyEvent [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_action_event(string [] policies,string [] [] rules,long [] [] [] action_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action_event", new object[] {
			policies,
			rules,
			action_ids}, callback, asyncState);
	}
	public LocalLBPolicyEvent [] [] [] Endget_action_event(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBPolicyEvent [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_action_expiry
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_action_expiry(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids
	) {
		object [] results = this.Invoke("get_action_expiry", new object [] {
				policies,
				rules,
				action_ids});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_action_expiry(string [] policies,string [] [] rules,long [] [] [] action_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action_expiry", new object[] {
			policies,
			rules,
			action_ids}, callback, asyncState);
	}
	public string [] [] [] Endget_action_expiry(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_action_expression
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_action_expression(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids
	) {
		object [] results = this.Invoke("get_action_expression", new object [] {
				policies,
				rules,
				action_ids});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_action_expression(string [] policies,string [] [] rules,long [] [] [] action_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action_expression", new object[] {
			policies,
			rules,
			action_ids}, callback, asyncState);
	}
	public string [] [] [] Endget_action_expression(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_action_facility
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_action_facility(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids
	) {
		object [] results = this.Invoke("get_action_facility", new object [] {
				policies,
				rules,
				action_ids});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_action_facility(string [] policies,string [] [] rules,long [] [] [] action_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action_facility", new object[] {
			policies,
			rules,
			action_ids}, callback, asyncState);
	}
	public string [] [] [] Endget_action_facility(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_action_from_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_action_from_profile(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids
	) {
		object [] results = this.Invoke("get_action_from_profile", new object [] {
				policies,
				rules,
				action_ids});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_action_from_profile(string [] policies,string [] [] rules,long [] [] [] action_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action_from_profile", new object[] {
			policies,
			rules,
			action_ids}, callback, asyncState);
	}
	public string [] [] [] Endget_action_from_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_action_internal_virtual_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_action_internal_virtual_server(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids
	) {
		object [] results = this.Invoke("get_action_internal_virtual_server", new object [] {
				policies,
				rules,
				action_ids});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_action_internal_virtual_server(string [] policies,string [] [] rules,long [] [] [] action_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action_internal_virtual_server", new object[] {
			policies,
			rules,
			action_ids}, callback, asyncState);
	}
	public string [] [] [] Endget_action_internal_virtual_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_action_key
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_action_key(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids
	) {
		object [] results = this.Invoke("get_action_key", new object [] {
				policies,
				rules,
				action_ids});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_action_key(string [] policies,string [] [] rules,long [] [] [] action_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action_key", new object[] {
			policies,
			rules,
			action_ids}, callback, asyncState);
	}
	public string [] [] [] Endget_action_key(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_action_location
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_action_location(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids
	) {
		object [] results = this.Invoke("get_action_location", new object [] {
				policies,
				rules,
				action_ids});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_action_location(string [] policies,string [] [] rules,long [] [] [] action_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action_location", new object[] {
			policies,
			rules,
			action_ids}, callback, asyncState);
	}
	public string [] [] [] Endget_action_location(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_action_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_action_member(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids
	) {
		object [] results = this.Invoke("get_action_member", new object [] {
				policies,
				rules,
				action_ids});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_action_member(string [] policies,string [] [] rules,long [] [] [] action_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action_member", new object[] {
			policies,
			rules,
			action_ids}, callback, asyncState);
	}
	public string [] [] [] Endget_action_member(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_action_message
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_action_message(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids
	) {
		object [] results = this.Invoke("get_action_message", new object [] {
				policies,
				rules,
				action_ids});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_action_message(string [] policies,string [] [] rules,long [] [] [] action_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action_message", new object[] {
			policies,
			rules,
			action_ids}, callback, asyncState);
	}
	public string [] [] [] Endget_action_message(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_action_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_action_name(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids
	) {
		object [] results = this.Invoke("get_action_name", new object [] {
				policies,
				rules,
				action_ids});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_action_name(string [] policies,string [] [] rules,long [] [] [] action_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action_name", new object[] {
			policies,
			rules,
			action_ids}, callback, asyncState);
	}
	public string [] [] [] Endget_action_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_action_netmask
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_action_netmask(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids
	) {
		object [] results = this.Invoke("get_action_netmask", new object [] {
				policies,
				rules,
				action_ids});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_action_netmask(string [] policies,string [] [] rules,long [] [] [] action_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action_netmask", new object[] {
			policies,
			rules,
			action_ids}, callback, asyncState);
	}
	public string [] [] [] Endget_action_netmask(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_action_nexthop
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_action_nexthop(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids
	) {
		object [] results = this.Invoke("get_action_nexthop", new object [] {
				policies,
				rules,
				action_ids});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_action_nexthop(string [] policies,string [] [] rules,long [] [] [] action_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action_nexthop", new object[] {
			policies,
			rules,
			action_ids}, callback, asyncState);
	}
	public string [] [] [] Endget_action_nexthop(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_action_node
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_action_node(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids
	) {
		object [] results = this.Invoke("get_action_node", new object [] {
				policies,
				rules,
				action_ids});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_action_node(string [] policies,string [] [] rules,long [] [] [] action_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action_node", new object[] {
			policies,
			rules,
			action_ids}, callback, asyncState);
	}
	public string [] [] [] Endget_action_node(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_action_offset
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] [] get_action_offset(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids
	) {
		object [] results = this.Invoke("get_action_offset", new object [] {
				policies,
				rules,
				action_ids});
		return ((long [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_action_offset(string [] policies,string [] [] rules,long [] [] [] action_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action_offset", new object[] {
			policies,
			rules,
			action_ids}, callback, asyncState);
	}
	public long [] [] [] Endget_action_offset(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_action_path
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_action_path(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids
	) {
		object [] results = this.Invoke("get_action_path", new object [] {
				policies,
				rules,
				action_ids});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_action_path(string [] policies,string [] [] rules,long [] [] [] action_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action_path", new object[] {
			policies,
			rules,
			action_ids}, callback, asyncState);
	}
	public string [] [] [] Endget_action_path(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_action_pin_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] [] get_action_pin_state(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids
	) {
		object [] results = this.Invoke("get_action_pin_state", new object [] {
				policies,
				rules,
				action_ids});
		return ((CommonEnabledState [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_action_pin_state(string [] policies,string [] [] rules,long [] [] [] action_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action_pin_state", new object[] {
			policies,
			rules,
			action_ids}, callback, asyncState);
	}
	public CommonEnabledState [] [] [] Endget_action_pin_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_action_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_action_policy(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids
	) {
		object [] results = this.Invoke("get_action_policy", new object [] {
				policies,
				rules,
				action_ids});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_action_policy(string [] policies,string [] [] rules,long [] [] [] action_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action_policy", new object[] {
			policies,
			rules,
			action_ids}, callback, asyncState);
	}
	public string [] [] [] Endget_action_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_action_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_action_pool(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids
	) {
		object [] results = this.Invoke("get_action_pool", new object [] {
				policies,
				rules,
				action_ids});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_action_pool(string [] policies,string [] [] rules,long [] [] [] action_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action_pool", new object[] {
			policies,
			rules,
			action_ids}, callback, asyncState);
	}
	public string [] [] [] Endget_action_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_action_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] [] get_action_port(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids
	) {
		object [] results = this.Invoke("get_action_port", new object [] {
				policies,
				rules,
				action_ids});
		return ((long [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_action_port(string [] policies,string [] [] rules,long [] [] [] action_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action_port", new object[] {
			policies,
			rules,
			action_ids}, callback, asyncState);
	}
	public long [] [] [] Endget_action_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_action_priority
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_action_priority(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids
	) {
		object [] results = this.Invoke("get_action_priority", new object [] {
				policies,
				rules,
				action_ids});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_action_priority(string [] policies,string [] [] rules,long [] [] [] action_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action_priority", new object[] {
			policies,
			rules,
			action_ids}, callback, asyncState);
	}
	public string [] [] [] Endget_action_priority(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_action_protocol
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_action_protocol(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids
	) {
		object [] results = this.Invoke("get_action_protocol", new object [] {
				policies,
				rules,
				action_ids});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_action_protocol(string [] policies,string [] [] rules,long [] [] [] action_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action_protocol", new object[] {
			policies,
			rules,
			action_ids}, callback, asyncState);
	}
	public string [] [] [] Endget_action_protocol(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_action_query_string
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_action_query_string(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids
	) {
		object [] results = this.Invoke("get_action_query_string", new object [] {
				policies,
				rules,
				action_ids});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_action_query_string(string [] policies,string [] [] rules,long [] [] [] action_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action_query_string", new object[] {
			policies,
			rules,
			action_ids}, callback, asyncState);
	}
	public string [] [] [] Endget_action_query_string(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_action_rateclass
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_action_rateclass(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids
	) {
		object [] results = this.Invoke("get_action_rateclass", new object [] {
				policies,
				rules,
				action_ids});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_action_rateclass(string [] policies,string [] [] rules,long [] [] [] action_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action_rateclass", new object[] {
			policies,
			rules,
			action_ids}, callback, asyncState);
	}
	public string [] [] [] Endget_action_rateclass(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_action_snat_automap_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] [] get_action_snat_automap_state(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids
	) {
		object [] results = this.Invoke("get_action_snat_automap_state", new object [] {
				policies,
				rules,
				action_ids});
		return ((CommonEnabledState [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_action_snat_automap_state(string [] policies,string [] [] rules,long [] [] [] action_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action_snat_automap_state", new object[] {
			policies,
			rules,
			action_ids}, callback, asyncState);
	}
	public CommonEnabledState [] [] [] Endget_action_snat_automap_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_action_snatpool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_action_snatpool(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids
	) {
		object [] results = this.Invoke("get_action_snatpool", new object [] {
				policies,
				rules,
				action_ids});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_action_snatpool(string [] policies,string [] [] rules,long [] [] [] action_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action_snatpool", new object[] {
			policies,
			rules,
			action_ids}, callback, asyncState);
	}
	public string [] [] [] Endget_action_snatpool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_action_ssl_session_id_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] [] get_action_ssl_session_id_state(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids
	) {
		object [] results = this.Invoke("get_action_ssl_session_id_state", new object [] {
				policies,
				rules,
				action_ids});
		return ((CommonEnabledState [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_action_ssl_session_id_state(string [] policies,string [] [] rules,long [] [] [] action_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action_ssl_session_id_state", new object[] {
			policies,
			rules,
			action_ids}, callback, asyncState);
	}
	public CommonEnabledState [] [] [] Endget_action_ssl_session_id_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_action_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] [] get_action_status(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids
	) {
		object [] results = this.Invoke("get_action_status", new object [] {
				policies,
				rules,
				action_ids});
		return ((long [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_action_status(string [] policies,string [] [] rules,long [] [] [] action_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action_status", new object[] {
			policies,
			rules,
			action_ids}, callback, asyncState);
	}
	public long [] [] [] Endget_action_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_action_target
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBContentPolicyPolicyTarget [] [] [] get_action_target(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids
	) {
		object [] results = this.Invoke("get_action_target", new object [] {
				policies,
				rules,
				action_ids});
		return ((LocalLBContentPolicyPolicyTarget [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_action_target(string [] policies,string [] [] rules,long [] [] [] action_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action_target", new object[] {
			policies,
			rules,
			action_ids}, callback, asyncState);
	}
	public LocalLBContentPolicyPolicyTarget [] [] [] Endget_action_target(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBContentPolicyPolicyTarget [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_action_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] [] get_action_timeout(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids
	) {
		object [] results = this.Invoke("get_action_timeout", new object [] {
				policies,
				rules,
				action_ids});
		return ((long [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_action_timeout(string [] policies,string [] [] rules,long [] [] [] action_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action_timeout", new object[] {
			policies,
			rules,
			action_ids}, callback, asyncState);
	}
	public long [] [] [] Endget_action_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_action_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBContentPolicyPolicyAction [] [] [] get_action_type(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids
	) {
		object [] results = this.Invoke("get_action_type", new object [] {
				policies,
				rules,
				action_ids});
		return ((LocalLBContentPolicyPolicyAction [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_action_type(string [] policies,string [] [] rules,long [] [] [] action_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action_type", new object[] {
			policies,
			rules,
			action_ids}, callback, asyncState);
	}
	public LocalLBContentPolicyPolicyAction [] [] [] Endget_action_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBContentPolicyPolicyAction [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_action_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_action_value(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids
	) {
		object [] results = this.Invoke("get_action_value", new object [] {
				policies,
				rules,
				action_ids});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_action_value(string [] policies,string [] [] rules,long [] [] [] action_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action_value", new object[] {
			policies,
			rules,
			action_ids}, callback, asyncState);
	}
	public string [] [] [] Endget_action_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_action_virtual_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_action_virtual_server(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids
	) {
		object [] results = this.Invoke("get_action_virtual_server", new object [] {
				policies,
				rules,
				action_ids});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_action_virtual_server(string [] policies,string [] [] rules,long [] [] [] action_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action_virtual_server", new object[] {
			policies,
			rules,
			action_ids}, callback, asyncState);
	}
	public string [] [] [] Endget_action_virtual_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_action_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_action_vlan(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids
	) {
		object [] results = this.Invoke("get_action_vlan", new object [] {
				policies,
				rules,
				action_ids});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_action_vlan(string [] policies,string [] [] rules,long [] [] [] action_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action_vlan", new object[] {
			policies,
			rules,
			action_ids}, callback, asyncState);
	}
	public string [] [] [] Endget_action_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_action_vlan_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] [] get_action_vlan_id(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids
	) {
		object [] results = this.Invoke("get_action_vlan_id", new object [] {
				policies,
				rules,
				action_ids});
		return ((long [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_action_vlan_id(string [] policies,string [] [] rules,long [] [] [] action_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action_vlan_id", new object[] {
			policies,
			rules,
			action_ids}, callback, asyncState);
	}
	public long [] [] [] Endget_action_vlan_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_condition_can_be_missing_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] [] get_condition_can_be_missing_state(
		string [] policies,
		string [] [] rules,
		long [] [] [] condition_ids
	) {
		object [] results = this.Invoke("get_condition_can_be_missing_state", new object [] {
				policies,
				rules,
				condition_ids});
		return ((CommonEnabledState [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_condition_can_be_missing_state(string [] policies,string [] [] rules,long [] [] [] condition_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_condition_can_be_missing_state", new object[] {
			policies,
			rules,
			condition_ids}, callback, asyncState);
	}
	public CommonEnabledState [] [] [] Endget_condition_can_be_missing_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_condition_case_sensitive_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] [] get_condition_case_sensitive_state(
		string [] policies,
		string [] [] rules,
		long [] [] [] condition_ids
	) {
		object [] results = this.Invoke("get_condition_case_sensitive_state", new object [] {
				policies,
				rules,
				condition_ids});
		return ((CommonEnabledState [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_condition_case_sensitive_state(string [] policies,string [] [] rules,long [] [] [] condition_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_condition_case_sensitive_state", new object[] {
			policies,
			rules,
			condition_ids}, callback, asyncState);
	}
	public CommonEnabledState [] [] [] Endget_condition_case_sensitive_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_condition_event
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBPolicyEvent [] [] [] get_condition_event(
		string [] policies,
		string [] [] rules,
		long [] [] [] condition_ids
	) {
		object [] results = this.Invoke("get_condition_event", new object [] {
				policies,
				rules,
				condition_ids});
		return ((LocalLBPolicyEvent [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_condition_event(string [] policies,string [] [] rules,long [] [] [] condition_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_condition_event", new object[] {
			policies,
			rules,
			condition_ids}, callback, asyncState);
	}
	public LocalLBPolicyEvent [] [] [] Endget_condition_event(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBPolicyEvent [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_condition_index
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] [] get_condition_index(
		string [] policies,
		string [] [] rules,
		long [] [] [] condition_ids
	) {
		object [] results = this.Invoke("get_condition_index", new object [] {
				policies,
				rules,
				condition_ids});
		return ((long [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_condition_index(string [] policies,string [] [] rules,long [] [] [] condition_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_condition_index", new object[] {
			policies,
			rules,
			condition_ids}, callback, asyncState);
	}
	public long [] [] [] Endget_condition_index(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_condition_internal_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] [] get_condition_internal_state(
		string [] policies,
		string [] [] rules,
		long [] [] [] condition_ids
	) {
		object [] results = this.Invoke("get_condition_internal_state", new object [] {
				policies,
				rules,
				condition_ids});
		return ((CommonEnabledState [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_condition_internal_state(string [] policies,string [] [] rules,long [] [] [] condition_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_condition_internal_state", new object[] {
			policies,
			rules,
			condition_ids}, callback, asyncState);
	}
	public CommonEnabledState [] [] [] Endget_condition_internal_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_condition_local_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] [] get_condition_local_state(
		string [] policies,
		string [] [] rules,
		long [] [] [] condition_ids
	) {
		object [] results = this.Invoke("get_condition_local_state", new object [] {
				policies,
				rules,
				condition_ids});
		return ((CommonEnabledState [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_condition_local_state(string [] policies,string [] [] rules,long [] [] [] condition_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_condition_local_state", new object[] {
			policies,
			rules,
			condition_ids}, callback, asyncState);
	}
	public CommonEnabledState [] [] [] Endget_condition_local_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_condition_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_condition_name(
		string [] policies,
		string [] [] rules,
		long [] [] [] condition_ids
	) {
		object [] results = this.Invoke("get_condition_name", new object [] {
				policies,
				rules,
				condition_ids});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_condition_name(string [] policies,string [] [] rules,long [] [] [] condition_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_condition_name", new object[] {
			policies,
			rules,
			condition_ids}, callback, asyncState);
	}
	public string [] [] [] Endget_condition_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_condition_negate_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] [] get_condition_negate_state(
		string [] policies,
		string [] [] rules,
		long [] [] [] condition_ids
	) {
		object [] results = this.Invoke("get_condition_negate_state", new object [] {
				policies,
				rules,
				condition_ids});
		return ((CommonEnabledState [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_condition_negate_state(string [] policies,string [] [] rules,long [] [] [] condition_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_condition_negate_state", new object[] {
			policies,
			rules,
			condition_ids}, callback, asyncState);
	}
	public CommonEnabledState [] [] [] Endget_condition_negate_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_condition_operand
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBPolicyOperand [] [] [] get_condition_operand(
		string [] policies,
		string [] [] rules,
		long [] [] [] condition_ids
	) {
		object [] results = this.Invoke("get_condition_operand", new object [] {
				policies,
				rules,
				condition_ids});
		return ((LocalLBPolicyOperand [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_condition_operand(string [] policies,string [] [] rules,long [] [] [] condition_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_condition_operand", new object[] {
			policies,
			rules,
			condition_ids}, callback, asyncState);
	}
	public LocalLBPolicyOperand [] [] [] Endget_condition_operand(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBPolicyOperand [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_condition_selector
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBPolicySelector [] [] [] get_condition_selector(
		string [] policies,
		string [] [] rules,
		long [] [] [] condition_ids
	) {
		object [] results = this.Invoke("get_condition_selector", new object [] {
				policies,
				rules,
				condition_ids});
		return ((LocalLBPolicySelector [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_condition_selector(string [] policies,string [] [] rules,long [] [] [] condition_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_condition_selector", new object[] {
			policies,
			rules,
			condition_ids}, callback, asyncState);
	}
	public LocalLBPolicySelector [] [] [] Endget_condition_selector(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBPolicySelector [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_condition_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBContentPolicyPolicyCondition [] [] [] get_condition_type(
		string [] policies,
		string [] [] rules,
		long [] [] [] condition_ids
	) {
		object [] results = this.Invoke("get_condition_type", new object [] {
				policies,
				rules,
				condition_ids});
		return ((LocalLBContentPolicyPolicyCondition [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_condition_type(string [] policies,string [] [] rules,long [] [] [] condition_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_condition_type", new object[] {
			policies,
			rules,
			condition_ids}, callback, asyncState);
	}
	public LocalLBContentPolicyPolicyCondition [] [] [] Endget_condition_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBContentPolicyPolicyCondition [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_condition_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] [] get_condition_value(
		string [] policies,
		string [] [] rules,
		long [] [] [] condition_ids
	) {
		object [] results = this.Invoke("get_condition_value", new object [] {
				policies,
				rules,
				condition_ids});
		return ((string [] [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_condition_value(string [] policies,string [] [] rules,long [] [] [] condition_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_condition_value", new object[] {
			policies,
			rules,
			condition_ids}, callback, asyncState);
	}
	public string [] [] [] [] Endget_condition_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
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
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
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
	// get_policy_controls
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBContentPolicyPolicyControls [] [] get_policy_controls(
		string [] policies
	) {
		object [] results = this.Invoke("get_policy_controls", new object [] {
				policies});
		return ((LocalLBContentPolicyPolicyControls [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_policy_controls(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_policy_controls", new object[] {
			policies}, callback, asyncState);
	}
	public LocalLBContentPolicyPolicyControls [] [] Endget_policy_controls(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBContentPolicyPolicyControls [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_policy_requires
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBContentPolicyPolicyRequires [] [] get_policy_requires(
		string [] policies
	) {
		object [] results = this.Invoke("get_policy_requires", new object [] {
				policies});
		return ((LocalLBContentPolicyPolicyRequires [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_policy_requires(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_policy_requires", new object[] {
			policies}, callback, asyncState);
	}
	public LocalLBContentPolicyPolicyRequires [] [] Endget_policy_requires(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBContentPolicyPolicyRequires [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_policy_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_policy_rule(
		string [] policies
	) {
		object [] results = this.Invoke("get_policy_rule", new object [] {
				policies});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_policy_rule(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_policy_rule", new object[] {
			policies}, callback, asyncState);
	}
	public string [] [] Endget_policy_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rule_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] [] get_rule_action(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_rule_action", new object [] {
				policies,
				rules});
		return ((long [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_rule_action(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rule_action", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public long [] [] [] Endget_rule_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rule_condition
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] [] get_rule_condition(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_rule_condition", new object [] {
				policies,
				rules});
		return ((long [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_rule_condition(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rule_condition", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public long [] [] [] Endget_rule_condition(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rule_ordinal
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_rule_ordinal(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_rule_ordinal", new object [] {
				policies,
				rules});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_rule_ordinal(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rule_ordinal", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public long [] [] Endget_rule_ordinal(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_strategy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_strategy(
		string [] policies
	) {
		object [] results = this.Invoke("get_strategy", new object [] {
				policies});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_strategy(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_strategy", new object[] {
			policies}, callback, asyncState);
	}
	public string [] Endget_strategy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
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
	// remove_all_condition_values
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void remove_all_condition_values(
		string [] policies,
		string [] [] rules,
		long [] [] [] condition_ids
	) {
		this.Invoke("remove_all_condition_values", new object [] {
				policies,
				rules,
				condition_ids});

	}
	public System.IAsyncResult Beginremove_all_condition_values(string [] policies,string [] [] rules,long [] [] [] condition_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_condition_values", new object[] {
			policies,
			rules,
			condition_ids}, callback, asyncState);
	}
	public void Endremove_all_condition_values(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_policy_controls
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void remove_all_policy_controls(
		string [] policies
	) {
		this.Invoke("remove_all_policy_controls", new object [] {
				policies});

	}
	public System.IAsyncResult Beginremove_all_policy_controls(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_policy_controls", new object[] {
			policies}, callback, asyncState);
	}
	public void Endremove_all_policy_controls(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_policy_requires
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void remove_all_policy_requires(
		string [] policies
	) {
		this.Invoke("remove_all_policy_requires", new object [] {
				policies});

	}
	public System.IAsyncResult Beginremove_all_policy_requires(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_policy_requires", new object[] {
			policies}, callback, asyncState);
	}
	public void Endremove_all_policy_requires(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_policy_rules
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void remove_all_policy_rules(
		string [] policies
	) {
		this.Invoke("remove_all_policy_rules", new object [] {
				policies});

	}
	public System.IAsyncResult Beginremove_all_policy_rules(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_policy_rules", new object[] {
			policies}, callback, asyncState);
	}
	public void Endremove_all_policy_rules(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_rule_actions
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void remove_all_rule_actions(
		string [] policies,
		string [] [] rules
	) {
		this.Invoke("remove_all_rule_actions", new object [] {
				policies,
				rules});

	}
	public System.IAsyncResult Beginremove_all_rule_actions(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_rule_actions", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public void Endremove_all_rule_actions(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_rule_conditions
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void remove_all_rule_conditions(
		string [] policies,
		string [] [] rules
	) {
		this.Invoke("remove_all_rule_conditions", new object [] {
				policies,
				rules});

	}
	public System.IAsyncResult Beginremove_all_rule_conditions(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_rule_conditions", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public void Endremove_all_rule_conditions(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_condition_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void remove_condition_value(
		string [] policies,
		string [] [] rules,
		long [] [] [] condition_ids,
		string [] [] [] [] values
	) {
		this.Invoke("remove_condition_value", new object [] {
				policies,
				rules,
				condition_ids,
				values});

	}
	public System.IAsyncResult Beginremove_condition_value(string [] policies,string [] [] rules,long [] [] [] condition_ids,string [] [] [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_condition_value", new object[] {
			policies,
			rules,
			condition_ids,
			values}, callback, asyncState);
	}
	public void Endremove_condition_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_policy_controls
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void remove_policy_controls(
		string [] policies,
		LocalLBContentPolicyPolicyControls [] [] controls
	) {
		this.Invoke("remove_policy_controls", new object [] {
				policies,
				controls});

	}
	public System.IAsyncResult Beginremove_policy_controls(string [] policies,LocalLBContentPolicyPolicyControls [] [] controls, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_policy_controls", new object[] {
			policies,
			controls}, callback, asyncState);
	}
	public void Endremove_policy_controls(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_policy_requires
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void remove_policy_requires(
		string [] policies,
		LocalLBContentPolicyPolicyRequires [] [] requires
	) {
		this.Invoke("remove_policy_requires", new object [] {
				policies,
				requires});

	}
	public System.IAsyncResult Beginremove_policy_requires(string [] policies,LocalLBContentPolicyPolicyRequires [] [] requires, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_policy_requires", new object[] {
			policies,
			requires}, callback, asyncState);
	}
	public void Endremove_policy_requires(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_policy_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void remove_policy_rule(
		string [] policies,
		string [] [] rules
	) {
		this.Invoke("remove_policy_rule", new object [] {
				policies,
				rules});

	}
	public System.IAsyncResult Beginremove_policy_rule(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_policy_rule", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public void Endremove_policy_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_rule_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void remove_rule_action(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids
	) {
		this.Invoke("remove_rule_action", new object [] {
				policies,
				rules,
				action_ids});

	}
	public System.IAsyncResult Beginremove_rule_action(string [] policies,string [] [] rules,long [] [] [] action_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_rule_action", new object[] {
			policies,
			rules,
			action_ids}, callback, asyncState);
	}
	public void Endremove_rule_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_rule_condition
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void remove_rule_condition(
		string [] policies,
		string [] [] rules,
		long [] [] [] condition_ids
	) {
		this.Invoke("remove_rule_condition", new object [] {
				policies,
				rules,
				condition_ids});

	}
	public System.IAsyncResult Beginremove_rule_condition(string [] policies,string [] [] rules,long [] [] [] condition_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_rule_condition", new object[] {
			policies,
			rules,
			condition_ids}, callback, asyncState);
	}
	public void Endremove_rule_condition(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_action_application
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_action_application(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids,
		string [] [] [] applications
	) {
		this.Invoke("set_action_application", new object [] {
				policies,
				rules,
				action_ids,
				applications});

	}
	public System.IAsyncResult Beginset_action_application(string [] policies,string [] [] rules,long [] [] [] action_ids,string [] [] [] applications, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_action_application", new object[] {
			policies,
			rules,
			action_ids,
			applications}, callback, asyncState);
	}
	public void Endset_action_application(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_action_category
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_action_category(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids,
		string [] [] [] categories
	) {
		this.Invoke("set_action_category", new object [] {
				policies,
				rules,
				action_ids,
				categories});

	}
	public System.IAsyncResult Beginset_action_category(string [] policies,string [] [] rules,long [] [] [] action_ids,string [] [] [] categories, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_action_category", new object[] {
			policies,
			rules,
			action_ids,
			categories}, callback, asyncState);
	}
	public void Endset_action_category(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_action_clone_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_action_clone_pool(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids,
		string [] [] [] clone_pools
	) {
		this.Invoke("set_action_clone_pool", new object [] {
				policies,
				rules,
				action_ids,
				clone_pools});

	}
	public System.IAsyncResult Beginset_action_clone_pool(string [] policies,string [] [] rules,long [] [] [] action_ids,string [] [] [] clone_pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_action_clone_pool", new object[] {
			policies,
			rules,
			action_ids,
			clone_pools}, callback, asyncState);
	}
	public void Endset_action_clone_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_action_defer_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_action_defer_state(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids,
		CommonEnabledState [] [] [] states
	) {
		this.Invoke("set_action_defer_state", new object [] {
				policies,
				rules,
				action_ids,
				states});

	}
	public System.IAsyncResult Beginset_action_defer_state(string [] policies,string [] [] rules,long [] [] [] action_ids,CommonEnabledState [] [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_action_defer_state", new object[] {
			policies,
			rules,
			action_ids,
			states}, callback, asyncState);
	}
	public void Endset_action_defer_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_action_domain
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_action_domain(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids,
		string [] [] [] domains
	) {
		this.Invoke("set_action_domain", new object [] {
				policies,
				rules,
				action_ids,
				domains});

	}
	public System.IAsyncResult Beginset_action_domain(string [] policies,string [] [] rules,long [] [] [] action_ids,string [] [] [] domains, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_action_domain", new object[] {
			policies,
			rules,
			action_ids,
			domains}, callback, asyncState);
	}
	public void Endset_action_domain(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_action_event
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_action_event(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids,
		LocalLBPolicyEvent [] [] [] events
	) {
		this.Invoke("set_action_event", new object [] {
				policies,
				rules,
				action_ids,
				events});

	}
	public System.IAsyncResult Beginset_action_event(string [] policies,string [] [] rules,long [] [] [] action_ids,LocalLBPolicyEvent [] [] [] events, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_action_event", new object[] {
			policies,
			rules,
			action_ids,
			events}, callback, asyncState);
	}
	public void Endset_action_event(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_action_expiry
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_action_expiry(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids,
		string [] [] [] expiries
	) {
		this.Invoke("set_action_expiry", new object [] {
				policies,
				rules,
				action_ids,
				expiries});

	}
	public System.IAsyncResult Beginset_action_expiry(string [] policies,string [] [] rules,long [] [] [] action_ids,string [] [] [] expiries, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_action_expiry", new object[] {
			policies,
			rules,
			action_ids,
			expiries}, callback, asyncState);
	}
	public void Endset_action_expiry(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_action_expression
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_action_expression(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids,
		string [] [] [] expressions
	) {
		this.Invoke("set_action_expression", new object [] {
				policies,
				rules,
				action_ids,
				expressions});

	}
	public System.IAsyncResult Beginset_action_expression(string [] policies,string [] [] rules,long [] [] [] action_ids,string [] [] [] expressions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_action_expression", new object[] {
			policies,
			rules,
			action_ids,
			expressions}, callback, asyncState);
	}
	public void Endset_action_expression(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_action_facility
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_action_facility(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids,
		string [] [] [] facilities
	) {
		this.Invoke("set_action_facility", new object [] {
				policies,
				rules,
				action_ids,
				facilities});

	}
	public System.IAsyncResult Beginset_action_facility(string [] policies,string [] [] rules,long [] [] [] action_ids,string [] [] [] facilities, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_action_facility", new object[] {
			policies,
			rules,
			action_ids,
			facilities}, callback, asyncState);
	}
	public void Endset_action_facility(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_action_from_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_action_from_profile(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids,
		string [] [] [] from_profiles
	) {
		this.Invoke("set_action_from_profile", new object [] {
				policies,
				rules,
				action_ids,
				from_profiles});

	}
	public System.IAsyncResult Beginset_action_from_profile(string [] policies,string [] [] rules,long [] [] [] action_ids,string [] [] [] from_profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_action_from_profile", new object[] {
			policies,
			rules,
			action_ids,
			from_profiles}, callback, asyncState);
	}
	public void Endset_action_from_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_action_internal_virtual_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_action_internal_virtual_server(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids,
		string [] [] [] internal_virtual_servers
	) {
		this.Invoke("set_action_internal_virtual_server", new object [] {
				policies,
				rules,
				action_ids,
				internal_virtual_servers});

	}
	public System.IAsyncResult Beginset_action_internal_virtual_server(string [] policies,string [] [] rules,long [] [] [] action_ids,string [] [] [] internal_virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_action_internal_virtual_server", new object[] {
			policies,
			rules,
			action_ids,
			internal_virtual_servers}, callback, asyncState);
	}
	public void Endset_action_internal_virtual_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_action_key
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_action_key(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids,
		string [] [] [] keys
	) {
		this.Invoke("set_action_key", new object [] {
				policies,
				rules,
				action_ids,
				keys});

	}
	public System.IAsyncResult Beginset_action_key(string [] policies,string [] [] rules,long [] [] [] action_ids,string [] [] [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_action_key", new object[] {
			policies,
			rules,
			action_ids,
			keys}, callback, asyncState);
	}
	public void Endset_action_key(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_action_location
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_action_location(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids,
		string [] [] [] locations
	) {
		this.Invoke("set_action_location", new object [] {
				policies,
				rules,
				action_ids,
				locations});

	}
	public System.IAsyncResult Beginset_action_location(string [] policies,string [] [] rules,long [] [] [] action_ids,string [] [] [] locations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_action_location", new object[] {
			policies,
			rules,
			action_ids,
			locations}, callback, asyncState);
	}
	public void Endset_action_location(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_action_member
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_action_member(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids,
		string [] [] [] members
	) {
		this.Invoke("set_action_member", new object [] {
				policies,
				rules,
				action_ids,
				members});

	}
	public System.IAsyncResult Beginset_action_member(string [] policies,string [] [] rules,long [] [] [] action_ids,string [] [] [] members, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_action_member", new object[] {
			policies,
			rules,
			action_ids,
			members}, callback, asyncState);
	}
	public void Endset_action_member(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_action_message
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_action_message(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids,
		string [] [] [] messages
	) {
		this.Invoke("set_action_message", new object [] {
				policies,
				rules,
				action_ids,
				messages});

	}
	public System.IAsyncResult Beginset_action_message(string [] policies,string [] [] rules,long [] [] [] action_ids,string [] [] [] messages, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_action_message", new object[] {
			policies,
			rules,
			action_ids,
			messages}, callback, asyncState);
	}
	public void Endset_action_message(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_action_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_action_name(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids,
		string [] [] [] names
	) {
		this.Invoke("set_action_name", new object [] {
				policies,
				rules,
				action_ids,
				names});

	}
	public System.IAsyncResult Beginset_action_name(string [] policies,string [] [] rules,long [] [] [] action_ids,string [] [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_action_name", new object[] {
			policies,
			rules,
			action_ids,
			names}, callback, asyncState);
	}
	public void Endset_action_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_action_netmask
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_action_netmask(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids,
		string [] [] [] netmasks
	) {
		this.Invoke("set_action_netmask", new object [] {
				policies,
				rules,
				action_ids,
				netmasks});

	}
	public System.IAsyncResult Beginset_action_netmask(string [] policies,string [] [] rules,long [] [] [] action_ids,string [] [] [] netmasks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_action_netmask", new object[] {
			policies,
			rules,
			action_ids,
			netmasks}, callback, asyncState);
	}
	public void Endset_action_netmask(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_action_nexthop
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_action_nexthop(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids,
		string [] [] [] nexthops
	) {
		this.Invoke("set_action_nexthop", new object [] {
				policies,
				rules,
				action_ids,
				nexthops});

	}
	public System.IAsyncResult Beginset_action_nexthop(string [] policies,string [] [] rules,long [] [] [] action_ids,string [] [] [] nexthops, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_action_nexthop", new object[] {
			policies,
			rules,
			action_ids,
			nexthops}, callback, asyncState);
	}
	public void Endset_action_nexthop(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_action_node
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_action_node(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids,
		string [] [] [] nodes
	) {
		this.Invoke("set_action_node", new object [] {
				policies,
				rules,
				action_ids,
				nodes});

	}
	public System.IAsyncResult Beginset_action_node(string [] policies,string [] [] rules,long [] [] [] action_ids,string [] [] [] nodes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_action_node", new object[] {
			policies,
			rules,
			action_ids,
			nodes}, callback, asyncState);
	}
	public void Endset_action_node(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_action_offset
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_action_offset(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids,
		long [] [] [] offsets
	) {
		this.Invoke("set_action_offset", new object [] {
				policies,
				rules,
				action_ids,
				offsets});

	}
	public System.IAsyncResult Beginset_action_offset(string [] policies,string [] [] rules,long [] [] [] action_ids,long [] [] [] offsets, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_action_offset", new object[] {
			policies,
			rules,
			action_ids,
			offsets}, callback, asyncState);
	}
	public void Endset_action_offset(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_action_path
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_action_path(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids,
		string [] [] [] paths
	) {
		this.Invoke("set_action_path", new object [] {
				policies,
				rules,
				action_ids,
				paths});

	}
	public System.IAsyncResult Beginset_action_path(string [] policies,string [] [] rules,long [] [] [] action_ids,string [] [] [] paths, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_action_path", new object[] {
			policies,
			rules,
			action_ids,
			paths}, callback, asyncState);
	}
	public void Endset_action_path(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_action_pin_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_action_pin_state(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids,
		CommonEnabledState [] [] [] states
	) {
		this.Invoke("set_action_pin_state", new object [] {
				policies,
				rules,
				action_ids,
				states});

	}
	public System.IAsyncResult Beginset_action_pin_state(string [] policies,string [] [] rules,long [] [] [] action_ids,CommonEnabledState [] [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_action_pin_state", new object[] {
			policies,
			rules,
			action_ids,
			states}, callback, asyncState);
	}
	public void Endset_action_pin_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_action_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_action_policy(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids,
		string [] [] [] action_policies
	) {
		this.Invoke("set_action_policy", new object [] {
				policies,
				rules,
				action_ids,
				action_policies});

	}
	public System.IAsyncResult Beginset_action_policy(string [] policies,string [] [] rules,long [] [] [] action_ids,string [] [] [] action_policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_action_policy", new object[] {
			policies,
			rules,
			action_ids,
			action_policies}, callback, asyncState);
	}
	public void Endset_action_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_action_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_action_pool(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids,
		string [] [] [] pools
	) {
		this.Invoke("set_action_pool", new object [] {
				policies,
				rules,
				action_ids,
				pools});

	}
	public System.IAsyncResult Beginset_action_pool(string [] policies,string [] [] rules,long [] [] [] action_ids,string [] [] [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_action_pool", new object[] {
			policies,
			rules,
			action_ids,
			pools}, callback, asyncState);
	}
	public void Endset_action_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_action_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_action_port(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids,
		long [] [] [] ports
	) {
		this.Invoke("set_action_port", new object [] {
				policies,
				rules,
				action_ids,
				ports});

	}
	public System.IAsyncResult Beginset_action_port(string [] policies,string [] [] rules,long [] [] [] action_ids,long [] [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_action_port", new object[] {
			policies,
			rules,
			action_ids,
			ports}, callback, asyncState);
	}
	public void Endset_action_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_action_priority
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_action_priority(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids,
		string [] [] [] priorities
	) {
		this.Invoke("set_action_priority", new object [] {
				policies,
				rules,
				action_ids,
				priorities});

	}
	public System.IAsyncResult Beginset_action_priority(string [] policies,string [] [] rules,long [] [] [] action_ids,string [] [] [] priorities, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_action_priority", new object[] {
			policies,
			rules,
			action_ids,
			priorities}, callback, asyncState);
	}
	public void Endset_action_priority(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_action_protocol
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_action_protocol(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids,
		string [] [] [] protocols
	) {
		this.Invoke("set_action_protocol", new object [] {
				policies,
				rules,
				action_ids,
				protocols});

	}
	public System.IAsyncResult Beginset_action_protocol(string [] policies,string [] [] rules,long [] [] [] action_ids,string [] [] [] protocols, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_action_protocol", new object[] {
			policies,
			rules,
			action_ids,
			protocols}, callback, asyncState);
	}
	public void Endset_action_protocol(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_action_query_string
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_action_query_string(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids,
		string [] [] [] query_strings
	) {
		this.Invoke("set_action_query_string", new object [] {
				policies,
				rules,
				action_ids,
				query_strings});

	}
	public System.IAsyncResult Beginset_action_query_string(string [] policies,string [] [] rules,long [] [] [] action_ids,string [] [] [] query_strings, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_action_query_string", new object[] {
			policies,
			rules,
			action_ids,
			query_strings}, callback, asyncState);
	}
	public void Endset_action_query_string(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_action_rateclass
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_action_rateclass(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids,
		string [] [] [] rateclasses
	) {
		this.Invoke("set_action_rateclass", new object [] {
				policies,
				rules,
				action_ids,
				rateclasses});

	}
	public System.IAsyncResult Beginset_action_rateclass(string [] policies,string [] [] rules,long [] [] [] action_ids,string [] [] [] rateclasses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_action_rateclass", new object[] {
			policies,
			rules,
			action_ids,
			rateclasses}, callback, asyncState);
	}
	public void Endset_action_rateclass(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_action_snat_automap_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_action_snat_automap_state(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids,
		CommonEnabledState [] [] [] states
	) {
		this.Invoke("set_action_snat_automap_state", new object [] {
				policies,
				rules,
				action_ids,
				states});

	}
	public System.IAsyncResult Beginset_action_snat_automap_state(string [] policies,string [] [] rules,long [] [] [] action_ids,CommonEnabledState [] [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_action_snat_automap_state", new object[] {
			policies,
			rules,
			action_ids,
			states}, callback, asyncState);
	}
	public void Endset_action_snat_automap_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_action_snatpool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_action_snatpool(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids,
		string [] [] [] snatpools
	) {
		this.Invoke("set_action_snatpool", new object [] {
				policies,
				rules,
				action_ids,
				snatpools});

	}
	public System.IAsyncResult Beginset_action_snatpool(string [] policies,string [] [] rules,long [] [] [] action_ids,string [] [] [] snatpools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_action_snatpool", new object[] {
			policies,
			rules,
			action_ids,
			snatpools}, callback, asyncState);
	}
	public void Endset_action_snatpool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_action_ssl_session_id_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_action_ssl_session_id_state(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids,
		CommonEnabledState [] [] [] states
	) {
		this.Invoke("set_action_ssl_session_id_state", new object [] {
				policies,
				rules,
				action_ids,
				states});

	}
	public System.IAsyncResult Beginset_action_ssl_session_id_state(string [] policies,string [] [] rules,long [] [] [] action_ids,CommonEnabledState [] [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_action_ssl_session_id_state", new object[] {
			policies,
			rules,
			action_ids,
			states}, callback, asyncState);
	}
	public void Endset_action_ssl_session_id_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_action_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_action_status(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids,
		long [] [] [] statuses
	) {
		this.Invoke("set_action_status", new object [] {
				policies,
				rules,
				action_ids,
				statuses});

	}
	public System.IAsyncResult Beginset_action_status(string [] policies,string [] [] rules,long [] [] [] action_ids,long [] [] [] statuses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_action_status", new object[] {
			policies,
			rules,
			action_ids,
			statuses}, callback, asyncState);
	}
	public void Endset_action_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_action_target
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_action_target(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids,
		LocalLBContentPolicyPolicyTarget [] [] [] targets
	) {
		this.Invoke("set_action_target", new object [] {
				policies,
				rules,
				action_ids,
				targets});

	}
	public System.IAsyncResult Beginset_action_target(string [] policies,string [] [] rules,long [] [] [] action_ids,LocalLBContentPolicyPolicyTarget [] [] [] targets, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_action_target", new object[] {
			policies,
			rules,
			action_ids,
			targets}, callback, asyncState);
	}
	public void Endset_action_target(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_action_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_action_timeout(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids,
		long [] [] [] timeouts
	) {
		this.Invoke("set_action_timeout", new object [] {
				policies,
				rules,
				action_ids,
				timeouts});

	}
	public System.IAsyncResult Beginset_action_timeout(string [] policies,string [] [] rules,long [] [] [] action_ids,long [] [] [] timeouts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_action_timeout", new object[] {
			policies,
			rules,
			action_ids,
			timeouts}, callback, asyncState);
	}
	public void Endset_action_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_action_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_action_type(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids,
		LocalLBContentPolicyPolicyAction [] [] [] actions
	) {
		this.Invoke("set_action_type", new object [] {
				policies,
				rules,
				action_ids,
				actions});

	}
	public System.IAsyncResult Beginset_action_type(string [] policies,string [] [] rules,long [] [] [] action_ids,LocalLBContentPolicyPolicyAction [] [] [] actions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_action_type", new object[] {
			policies,
			rules,
			action_ids,
			actions}, callback, asyncState);
	}
	public void Endset_action_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_action_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_action_value(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids,
		string [] [] [] values
	) {
		this.Invoke("set_action_value", new object [] {
				policies,
				rules,
				action_ids,
				values});

	}
	public System.IAsyncResult Beginset_action_value(string [] policies,string [] [] rules,long [] [] [] action_ids,string [] [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_action_value", new object[] {
			policies,
			rules,
			action_ids,
			values}, callback, asyncState);
	}
	public void Endset_action_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_action_virtual_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_action_virtual_server(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids,
		string [] [] [] virtual_servers
	) {
		this.Invoke("set_action_virtual_server", new object [] {
				policies,
				rules,
				action_ids,
				virtual_servers});

	}
	public System.IAsyncResult Beginset_action_virtual_server(string [] policies,string [] [] rules,long [] [] [] action_ids,string [] [] [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_action_virtual_server", new object[] {
			policies,
			rules,
			action_ids,
			virtual_servers}, callback, asyncState);
	}
	public void Endset_action_virtual_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_action_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_action_vlan(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids,
		string [] [] [] vlans
	) {
		this.Invoke("set_action_vlan", new object [] {
				policies,
				rules,
				action_ids,
				vlans});

	}
	public System.IAsyncResult Beginset_action_vlan(string [] policies,string [] [] rules,long [] [] [] action_ids,string [] [] [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_action_vlan", new object[] {
			policies,
			rules,
			action_ids,
			vlans}, callback, asyncState);
	}
	public void Endset_action_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_action_vlan_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_action_vlan_id(
		string [] policies,
		string [] [] rules,
		long [] [] [] action_ids,
		long [] [] [] vlan_ids
	) {
		this.Invoke("set_action_vlan_id", new object [] {
				policies,
				rules,
				action_ids,
				vlan_ids});

	}
	public System.IAsyncResult Beginset_action_vlan_id(string [] policies,string [] [] rules,long [] [] [] action_ids,long [] [] [] vlan_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_action_vlan_id", new object[] {
			policies,
			rules,
			action_ids,
			vlan_ids}, callback, asyncState);
	}
	public void Endset_action_vlan_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_condition_can_be_missing_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_condition_can_be_missing_state(
		string [] policies,
		string [] [] rules,
		long [] [] [] condition_ids,
		CommonEnabledState [] [] [] states
	) {
		this.Invoke("set_condition_can_be_missing_state", new object [] {
				policies,
				rules,
				condition_ids,
				states});

	}
	public System.IAsyncResult Beginset_condition_can_be_missing_state(string [] policies,string [] [] rules,long [] [] [] condition_ids,CommonEnabledState [] [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_condition_can_be_missing_state", new object[] {
			policies,
			rules,
			condition_ids,
			states}, callback, asyncState);
	}
	public void Endset_condition_can_be_missing_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_condition_case_sensitive_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_condition_case_sensitive_state(
		string [] policies,
		string [] [] rules,
		long [] [] [] condition_ids,
		CommonEnabledState [] [] [] states
	) {
		this.Invoke("set_condition_case_sensitive_state", new object [] {
				policies,
				rules,
				condition_ids,
				states});

	}
	public System.IAsyncResult Beginset_condition_case_sensitive_state(string [] policies,string [] [] rules,long [] [] [] condition_ids,CommonEnabledState [] [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_condition_case_sensitive_state", new object[] {
			policies,
			rules,
			condition_ids,
			states}, callback, asyncState);
	}
	public void Endset_condition_case_sensitive_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_condition_event
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_condition_event(
		string [] policies,
		string [] [] rules,
		long [] [] [] condition_ids,
		LocalLBPolicyEvent [] [] [] events
	) {
		this.Invoke("set_condition_event", new object [] {
				policies,
				rules,
				condition_ids,
				events});

	}
	public System.IAsyncResult Beginset_condition_event(string [] policies,string [] [] rules,long [] [] [] condition_ids,LocalLBPolicyEvent [] [] [] events, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_condition_event", new object[] {
			policies,
			rules,
			condition_ids,
			events}, callback, asyncState);
	}
	public void Endset_condition_event(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_condition_index
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_condition_index(
		string [] policies,
		string [] [] rules,
		long [] [] [] condition_ids,
		long [] [] [] indices
	) {
		this.Invoke("set_condition_index", new object [] {
				policies,
				rules,
				condition_ids,
				indices});

	}
	public System.IAsyncResult Beginset_condition_index(string [] policies,string [] [] rules,long [] [] [] condition_ids,long [] [] [] indices, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_condition_index", new object[] {
			policies,
			rules,
			condition_ids,
			indices}, callback, asyncState);
	}
	public void Endset_condition_index(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_condition_internal_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_condition_internal_state(
		string [] policies,
		string [] [] rules,
		long [] [] [] condition_ids,
		CommonEnabledState [] [] [] states
	) {
		this.Invoke("set_condition_internal_state", new object [] {
				policies,
				rules,
				condition_ids,
				states});

	}
	public System.IAsyncResult Beginset_condition_internal_state(string [] policies,string [] [] rules,long [] [] [] condition_ids,CommonEnabledState [] [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_condition_internal_state", new object[] {
			policies,
			rules,
			condition_ids,
			states}, callback, asyncState);
	}
	public void Endset_condition_internal_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_condition_local_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_condition_local_state(
		string [] policies,
		string [] [] rules,
		long [] [] [] condition_ids,
		CommonEnabledState [] [] [] states
	) {
		this.Invoke("set_condition_local_state", new object [] {
				policies,
				rules,
				condition_ids,
				states});

	}
	public System.IAsyncResult Beginset_condition_local_state(string [] policies,string [] [] rules,long [] [] [] condition_ids,CommonEnabledState [] [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_condition_local_state", new object[] {
			policies,
			rules,
			condition_ids,
			states}, callback, asyncState);
	}
	public void Endset_condition_local_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_condition_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_condition_name(
		string [] policies,
		string [] [] rules,
		long [] [] [] condition_ids,
		string [] [] [] names
	) {
		this.Invoke("set_condition_name", new object [] {
				policies,
				rules,
				condition_ids,
				names});

	}
	public System.IAsyncResult Beginset_condition_name(string [] policies,string [] [] rules,long [] [] [] condition_ids,string [] [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_condition_name", new object[] {
			policies,
			rules,
			condition_ids,
			names}, callback, asyncState);
	}
	public void Endset_condition_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_condition_negate_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_condition_negate_state(
		string [] policies,
		string [] [] rules,
		long [] [] [] condition_ids,
		CommonEnabledState [] [] [] states
	) {
		this.Invoke("set_condition_negate_state", new object [] {
				policies,
				rules,
				condition_ids,
				states});

	}
	public System.IAsyncResult Beginset_condition_negate_state(string [] policies,string [] [] rules,long [] [] [] condition_ids,CommonEnabledState [] [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_condition_negate_state", new object[] {
			policies,
			rules,
			condition_ids,
			states}, callback, asyncState);
	}
	public void Endset_condition_negate_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_condition_operand
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_condition_operand(
		string [] policies,
		string [] [] rules,
		long [] [] [] condition_ids,
		LocalLBPolicyOperand [] [] [] operands
	) {
		this.Invoke("set_condition_operand", new object [] {
				policies,
				rules,
				condition_ids,
				operands});

	}
	public System.IAsyncResult Beginset_condition_operand(string [] policies,string [] [] rules,long [] [] [] condition_ids,LocalLBPolicyOperand [] [] [] operands, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_condition_operand", new object[] {
			policies,
			rules,
			condition_ids,
			operands}, callback, asyncState);
	}
	public void Endset_condition_operand(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_condition_selector
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_condition_selector(
		string [] policies,
		string [] [] rules,
		long [] [] [] condition_ids,
		LocalLBPolicySelector [] [] [] selectors
	) {
		this.Invoke("set_condition_selector", new object [] {
				policies,
				rules,
				condition_ids,
				selectors});

	}
	public System.IAsyncResult Beginset_condition_selector(string [] policies,string [] [] rules,long [] [] [] condition_ids,LocalLBPolicySelector [] [] [] selectors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_condition_selector", new object[] {
			policies,
			rules,
			condition_ids,
			selectors}, callback, asyncState);
	}
	public void Endset_condition_selector(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_condition_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_condition_type(
		string [] policies,
		string [] [] rules,
		long [] [] [] condition_ids,
		LocalLBContentPolicyPolicyCondition [] [] [] types
	) {
		this.Invoke("set_condition_type", new object [] {
				policies,
				rules,
				condition_ids,
				types});

	}
	public System.IAsyncResult Beginset_condition_type(string [] policies,string [] [] rules,long [] [] [] condition_ids,LocalLBContentPolicyPolicyCondition [] [] [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_condition_type", new object[] {
			policies,
			rules,
			condition_ids,
			types}, callback, asyncState);
	}
	public void Endset_condition_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
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
	// set_rule_ordinal
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_rule_ordinal(
		string [] policies,
		string [] [] rules,
		long [] [] ordinals
	) {
		this.Invoke("set_rule_ordinal", new object [] {
				policies,
				rules,
				ordinals});

	}
	public System.IAsyncResult Beginset_rule_ordinal(string [] policies,string [] [] rules,long [] [] ordinals, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rule_ordinal", new object[] {
			policies,
			rules,
			ordinals}, callback, asyncState);
	}
	public void Endset_rule_ordinal(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_strategy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicy")]
	public void set_strategy(
		string [] policies,
		string [] strategies
	) {
		this.Invoke("set_strategy", new object [] {
				policies,
				strategies});

	}
	public System.IAsyncResult Beginset_strategy(string [] policies,string [] strategies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_strategy", new object[] {
			policies,
			strategies}, callback, asyncState);
	}
	public void Endset_strategy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ContentPolicy.PolicyAction", Namespace = "urn:iControl")]
	public enum LocalLBContentPolicyPolicyAction
	{
		POLICY_ACTION_UNKNOWN,
		POLICY_ACTION_INSERT,
		POLICY_ACTION_REPLACE,
		POLICY_ACTION_APPLY,
		POLICY_ACTION_ADD,
		POLICY_ACTION_CLASSIFY,
		POLICY_ACTION_REMOVE,
		POLICY_ACTION_SELECT,
		POLICY_ACTION_ENABLE,
		POLICY_ACTION_DISABLE,
		POLICY_ACTION_REDIRECT,
		POLICY_ACTION_WRITE,
		POLICY_ACTION_RESET,
		POLICY_ACTION_EVENT,
		POLICY_ACTION_SET_VARIABLE,
		POLICY_ACTION_RENEGOTIATE,
		POLICY_ACTION_PERSIST_SOURCE_ADDRESS,
		POLICY_ACTION_PERSIST_DESTINATION_ADDRESS,
		POLICY_ACTION_PERSIST_COOKIE_INSERT,
		POLICY_ACTION_PERSIST_COOKIE_REWRITE,
		POLICY_ACTION_PERSIST_COOKIE_PASSIVE,
		POLICY_ACTION_PERSIST_COOKIE_HASH,
		POLICY_ACTION_PERSIST_UNIVERSAL,
		POLICY_ACTION_PERSIST_HASH,
		POLICY_ACTION_PERSIST_CARP,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ContentPolicy.PolicyCondition", Namespace = "urn:iControl")]
	public enum LocalLBContentPolicyPolicyCondition
	{
		POLICY_CONDITION_UNKNOWN,
		POLICY_CONDITION_EQUALS,
		POLICY_CONDITION_STARTS,
		POLICY_CONDITION_ENDS,
		POLICY_CONDITION_CONTAINS,
		POLICY_CONDITION_LESS,
		POLICY_CONDITION_GREATER,
		POLICY_CONDITION_LESS_OR_EQUAL,
		POLICY_CONDITION_GREATER_OR_EQUAL,
		POLICY_CONDITION_MATCHES,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ContentPolicy.PolicyControls", Namespace = "urn:iControl")]
	public enum LocalLBContentPolicyPolicyControls
	{
		POLICY_CONTROLS_UNKNOWN,
		POLICY_CONTROLS_FORWARDING,
		POLICY_CONTROLS_CACHING,
		POLICY_CONTROLS_COMPRESSION,
		POLICY_CONTROLS_WAM,
		POLICY_CONTROLS_ASM,
		POLICY_CONTROLS_AVR,
		POLICY_CONTROLS_L7DOS,
		POLICY_CONTROLS_CLASSIFICATION,
		POLICY_CONTROLS_REQUEST_ADAPTATION,
		POLICY_CONTROLS_RESPONSE_ADAPTATION,
		POLICY_CONTROLS_SERVER_SSL,
		POLICY_CONTROLS_PERSISTENCE,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ContentPolicy.PolicyRequires", Namespace = "urn:iControl")]
	public enum LocalLBContentPolicyPolicyRequires
	{
		POLICY_REQUIRES_UNKNOWN,
		POLICY_REQUIRES_HTTP,
		POLICY_REQUIRES_TCP,
		POLICY_REQUIRES_CLIENT_SSL,
		POLICY_REQUIRES_SSL_PERSIST,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ContentPolicy.PolicyTarget", Namespace = "urn:iControl")]
	public enum LocalLBContentPolicyPolicyTarget
	{
		POLICY_TARGET_UNKNOWN,
		POLICY_TARGET_HTTP,
		POLICY_TARGET_HTTP_METHOD,
		POLICY_TARGET_HTTP_URI,
		POLICY_TARGET_HTTP_HOST,
		POLICY_TARGET_HTTP_HEADER,
		POLICY_TARGET_HTTP_REFERER,
		POLICY_TARGET_HTTP_COOKIE,
		POLICY_TARGET_HTTP_SET_COOKIE,
		POLICY_TARGET_HTTP_BASIC_AUTH,
		POLICY_TARGET_HTTP_REPLY,
		POLICY_TARGET_LOG,
		POLICY_TARGET_PEM,
		POLICY_TARGET_CACHE,
		POLICY_TARGET_COMPRESS,
		POLICY_TARGET_DECOMPRESS,
		POLICY_TARGET_FORWARD,
		POLICY_TARGET_TCP_NAGLE,
		POLICY_TARGET_WAM,
		POLICY_TARGET_ASM,
		POLICY_TARGET_L7DOS,
		POLICY_TARGET_AVR,
		POLICY_TARGET_TCL,
		POLICY_TARGET_RESPONSE_ADAPT,
		POLICY_TARGET_REQUEST_ADAPT,
		POLICY_TARGET_SERVER_SSL,
		POLICY_TARGET_POLICY,
		POLICY_TARGET_PERSIST,
	}

	//=======================================================================
	// Structs
	//=======================================================================

}
