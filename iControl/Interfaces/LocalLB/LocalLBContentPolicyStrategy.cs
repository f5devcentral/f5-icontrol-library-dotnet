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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.ContentPolicyStrategyBinding", Namespace="urn:iControl")]
	public partial class LocalLBContentPolicyStrategy : iControlInterface {
		public LocalLBContentPolicyStrategy() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_operand
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicyStrategy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicyStrategy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicyStrategy")]
	public void add_operand(
		string [] strategies,
		long [] [] operand_ids,
		LocalLBPolicyOperand [] [] operands,
		LocalLBPolicyEvent [] [] events,
		LocalLBPolicySelector [] [] selectors
	) {
		this.Invoke("add_operand", new object [] {
				strategies,
				operand_ids,
				operands,
				events,
				selectors});

	}
	public System.IAsyncResult Beginadd_operand(string [] strategies,long [] [] operand_ids,LocalLBPolicyOperand [] [] operands,LocalLBPolicyEvent [] [] events,LocalLBPolicySelector [] [] selectors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_operand", new object[] {
			strategies,
			operand_ids,
			operands,
			events,
			selectors}, callback, asyncState);
	}
	public void Endadd_operand(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicyStrategy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicyStrategy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicyStrategy")]
	public void create(
		string [] strategies
	) {
		this.Invoke("create", new object [] {
				strategies});

	}
	public System.IAsyncResult Begincreate(string [] strategies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			strategies}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_policy_strategies
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicyStrategy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicyStrategy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicyStrategy")]
	public void delete_all_policy_strategies(

	) {
		this.Invoke("delete_all_policy_strategies", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_policy_strategies(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_policy_strategies", new object[0], callback, asyncState);
	}
	public void Enddelete_all_policy_strategies(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_policy_strategy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicyStrategy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicyStrategy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicyStrategy")]
	public void delete_policy_strategy(
		string [] strategies
	) {
		this.Invoke("delete_policy_strategy", new object [] {
				strategies});

	}
	public System.IAsyncResult Begindelete_policy_strategy(string [] strategies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_policy_strategy", new object[] {
			strategies}, callback, asyncState);
	}
	public void Enddelete_policy_strategy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicyStrategy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicyStrategy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicyStrategy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] strategies
	) {
		object [] results = this.Invoke("get_description", new object [] {
				strategies});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] strategies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			strategies}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicyStrategy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicyStrategy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicyStrategy")]
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
	// get_operand
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicyStrategy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicyStrategy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicyStrategy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_operand(
		string [] strategies
	) {
		object [] results = this.Invoke("get_operand", new object [] {
				strategies});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_operand(string [] strategies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_operand", new object[] {
			strategies}, callback, asyncState);
	}
	public long [] [] Endget_operand(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_operand_event
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicyStrategy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicyStrategy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicyStrategy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBPolicyEvent [] [] get_operand_event(
		string [] strategies,
		long [] [] operand_ids
	) {
		object [] results = this.Invoke("get_operand_event", new object [] {
				strategies,
				operand_ids});
		return ((LocalLBPolicyEvent [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_operand_event(string [] strategies,long [] [] operand_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_operand_event", new object[] {
			strategies,
			operand_ids}, callback, asyncState);
	}
	public LocalLBPolicyEvent [] [] Endget_operand_event(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBPolicyEvent [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_operand_selector
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicyStrategy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicyStrategy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicyStrategy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBPolicySelector [] [] get_operand_selector(
		string [] strategies,
		long [] [] operand_ids
	) {
		object [] results = this.Invoke("get_operand_selector", new object [] {
				strategies,
				operand_ids});
		return ((LocalLBPolicySelector [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_operand_selector(string [] strategies,long [] [] operand_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_operand_selector", new object[] {
			strategies,
			operand_ids}, callback, asyncState);
	}
	public LocalLBPolicySelector [] [] Endget_operand_selector(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBPolicySelector [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_operand_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicyStrategy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicyStrategy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicyStrategy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBPolicyOperand [] [] get_operand_type(
		string [] strategies,
		long [] [] operand_ids
	) {
		object [] results = this.Invoke("get_operand_type", new object [] {
				strategies,
				operand_ids});
		return ((LocalLBPolicyOperand [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_operand_type(string [] strategies,long [] [] operand_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_operand_type", new object[] {
			strategies,
			operand_ids}, callback, asyncState);
	}
	public LocalLBPolicyOperand [] [] Endget_operand_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBPolicyOperand [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicyStrategy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicyStrategy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicyStrategy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBContentPolicyStrategyPolicyStrategy [] get_type(
		string [] strategies
	) {
		object [] results = this.Invoke("get_type", new object [] {
				strategies});
		return ((LocalLBContentPolicyStrategyPolicyStrategy [])(results[0]));
	}
	public System.IAsyncResult Beginget_type(string [] strategies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_type", new object[] {
			strategies}, callback, asyncState);
	}
	public LocalLBContentPolicyStrategyPolicyStrategy [] Endget_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBContentPolicyStrategyPolicyStrategy [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicyStrategy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicyStrategy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicyStrategy")]
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
	// remove_all_operands
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicyStrategy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicyStrategy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicyStrategy")]
	public void remove_all_operands(
		string [] strategies
	) {
		this.Invoke("remove_all_operands", new object [] {
				strategies});

	}
	public System.IAsyncResult Beginremove_all_operands(string [] strategies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_operands", new object[] {
			strategies}, callback, asyncState);
	}
	public void Endremove_all_operands(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_operand
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicyStrategy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicyStrategy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicyStrategy")]
	public void remove_operand(
		string [] strategies,
		long [] [] operand_ids
	) {
		this.Invoke("remove_operand", new object [] {
				strategies,
				operand_ids});

	}
	public System.IAsyncResult Beginremove_operand(string [] strategies,long [] [] operand_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_operand", new object[] {
			strategies,
			operand_ids}, callback, asyncState);
	}
	public void Endremove_operand(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicyStrategy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicyStrategy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicyStrategy")]
	public void set_description(
		string [] strategies,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				strategies,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] strategies,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			strategies,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_operand_event
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicyStrategy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicyStrategy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicyStrategy")]
	public void set_operand_event(
		string [] strategies,
		long [] [] operand_ids,
		LocalLBPolicyEvent [] [] events
	) {
		this.Invoke("set_operand_event", new object [] {
				strategies,
				operand_ids,
				events});

	}
	public System.IAsyncResult Beginset_operand_event(string [] strategies,long [] [] operand_ids,LocalLBPolicyEvent [] [] events, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_operand_event", new object[] {
			strategies,
			operand_ids,
			events}, callback, asyncState);
	}
	public void Endset_operand_event(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_operand_selector
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicyStrategy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicyStrategy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicyStrategy")]
	public void set_operand_selector(
		string [] strategies,
		long [] [] operand_ids,
		LocalLBPolicySelector [] [] selectors
	) {
		this.Invoke("set_operand_selector", new object [] {
				strategies,
				operand_ids,
				selectors});

	}
	public System.IAsyncResult Beginset_operand_selector(string [] strategies,long [] [] operand_ids,LocalLBPolicySelector [] [] selectors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_operand_selector", new object[] {
			strategies,
			operand_ids,
			selectors}, callback, asyncState);
	}
	public void Endset_operand_selector(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_operand_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicyStrategy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicyStrategy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicyStrategy")]
	public void set_operand_type(
		string [] strategies,
		long [] [] operand_ids,
		LocalLBPolicyOperand [] [] operands
	) {
		this.Invoke("set_operand_type", new object [] {
				strategies,
				operand_ids,
				operands});

	}
	public System.IAsyncResult Beginset_operand_type(string [] strategies,long [] [] operand_ids,LocalLBPolicyOperand [] [] operands, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_operand_type", new object[] {
			strategies,
			operand_ids,
			operands}, callback, asyncState);
	}
	public void Endset_operand_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/ContentPolicyStrategy", 
		RequestNamespace="urn:iControl:LocalLB/ContentPolicyStrategy", ResponseNamespace="urn:iControl:LocalLB/ContentPolicyStrategy")]
	public void set_type(
		string [] strategies,
		LocalLBContentPolicyStrategyPolicyStrategy [] types
	) {
		this.Invoke("set_type", new object [] {
				strategies,
				types});

	}
	public System.IAsyncResult Beginset_type(string [] strategies,LocalLBContentPolicyStrategyPolicyStrategy [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_type", new object[] {
			strategies,
			types}, callback, asyncState);
	}
	public void Endset_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.ContentPolicyStrategy.PolicyStrategy", Namespace = "urn:iControl")]
	public enum LocalLBContentPolicyStrategyPolicyStrategy
	{
		STRATEGY_UNKNOWN,
		STRATEGY_FIRST_MATCH,
		STRATEGY_BEST_MATCH,
		STRATEGY_ALL_MATCH,
	}

	//=======================================================================
	// Structs
	//=======================================================================

}
