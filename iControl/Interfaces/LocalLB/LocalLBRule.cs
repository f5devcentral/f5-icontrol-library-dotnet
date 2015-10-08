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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.RuleBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBRuleRuleDefinition))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBRuleRuleStatistics))]
	public partial class LocalLBRule : iControlInterface {
		public LocalLBRule() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_checksum
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Rule", 
		RequestNamespace="urn:iControl:LocalLB/Rule", ResponseNamespace="urn:iControl:LocalLB/Rule")]
	public void add_checksum(
		string [] rule_names
	) {
		this.Invoke("add_checksum", new object [] {
				rule_names});

	}
	public System.IAsyncResult Beginadd_checksum(string [] rule_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_checksum", new object[] {
			rule_names}, callback, asyncState);
	}
	public void Endadd_checksum(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Rule", 
		RequestNamespace="urn:iControl:LocalLB/Rule", ResponseNamespace="urn:iControl:LocalLB/Rule")]
	public void add_metadata(
		string [] rule_names,
		string [] [] names,
		string [] [] values
	) {
		this.Invoke("add_metadata", new object [] {
				rule_names,
				names,
				values});

	}
	public System.IAsyncResult Beginadd_metadata(string [] rule_names,string [] [] names,string [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_metadata", new object[] {
			rule_names,
			names,
			values}, callback, asyncState);
	}
	public void Endadd_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_signature
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Rule", 
		RequestNamespace="urn:iControl:LocalLB/Rule", ResponseNamespace="urn:iControl:LocalLB/Rule")]
	public void add_signature(
		string [] rule_names,
		string [] signing_key_names
	) {
		this.Invoke("add_signature", new object [] {
				rule_names,
				signing_key_names});

	}
	public System.IAsyncResult Beginadd_signature(string [] rule_names,string [] signing_key_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_signature", new object[] {
			rule_names,
			signing_key_names}, callback, asyncState);
	}
	public void Endadd_signature(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Rule", 
		RequestNamespace="urn:iControl:LocalLB/Rule", ResponseNamespace="urn:iControl:LocalLB/Rule")]
	public void create(
		LocalLBRuleRuleDefinition [] rules
	) {
		this.Invoke("create", new object [] {
				rules});

	}
	public System.IAsyncResult Begincreate(LocalLBRuleRuleDefinition [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			rules}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_rules
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Rule", 
		RequestNamespace="urn:iControl:LocalLB/Rule", ResponseNamespace="urn:iControl:LocalLB/Rule")]
	public void delete_all_rules(

	) {
		this.Invoke("delete_all_rules", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_rules(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_rules", new object[0], callback, asyncState);
	}
	public void Enddelete_all_rules(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Rule", 
		RequestNamespace="urn:iControl:LocalLB/Rule", ResponseNamespace="urn:iControl:LocalLB/Rule")]
	public void delete_rule(
		string [] rule_names
	) {
		this.Invoke("delete_rule", new object [] {
				rule_names});

	}
	public System.IAsyncResult Begindelete_rule(string [] rule_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_rule", new object[] {
			rule_names}, callback, asyncState);
	}
	public void Enddelete_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Rule", 
		RequestNamespace="urn:iControl:LocalLB/Rule", ResponseNamespace="urn:iControl:LocalLB/Rule")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBRuleRuleStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((LocalLBRuleRuleStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public LocalLBRuleRuleStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBRuleRuleStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Rule", 
		RequestNamespace="urn:iControl:LocalLB/Rule", ResponseNamespace="urn:iControl:LocalLB/Rule")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] rule_names
	) {
		object [] results = this.Invoke("get_description", new object [] {
				rule_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] rule_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			rule_names}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ignore_verification
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Rule", 
		RequestNamespace="urn:iControl:LocalLB/Rule", ResponseNamespace="urn:iControl:LocalLB/Rule")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_ignore_verification(
		string [] rule_names
	) {
		object [] results = this.Invoke("get_ignore_verification", new object [] {
				rule_names});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_ignore_verification(string [] rule_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ignore_verification", new object[] {
			rule_names}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_ignore_verification(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Rule", 
		RequestNamespace="urn:iControl:LocalLB/Rule", ResponseNamespace="urn:iControl:LocalLB/Rule")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Rule", 
		RequestNamespace="urn:iControl:LocalLB/Rule", ResponseNamespace="urn:iControl:LocalLB/Rule")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_metadata(
		string [] rule_names
	) {
		object [] results = this.Invoke("get_metadata", new object [] {
				rule_names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata(string [] rule_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_metadata", new object[] {
			rule_names}, callback, asyncState);
	}
	public string [] [] Endget_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_metadata_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Rule", 
		RequestNamespace="urn:iControl:LocalLB/Rule", ResponseNamespace="urn:iControl:LocalLB/Rule")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_metadata_description(
		string [] rule_names,
		string [] [] names
	) {
		object [] results = this.Invoke("get_metadata_description", new object [] {
				rule_names,
				names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata_description(string [] rule_names,string [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_metadata_description", new object[] {
			rule_names,
			names}, callback, asyncState);
	}
	public string [] [] Endget_metadata_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_metadata_persistence
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Rule", 
		RequestNamespace="urn:iControl:LocalLB/Rule", ResponseNamespace="urn:iControl:LocalLB/Rule")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonMetadataPersistence [] [] get_metadata_persistence(
		string [] rule_names,
		string [] [] names
	) {
		object [] results = this.Invoke("get_metadata_persistence", new object [] {
				rule_names,
				names});
		return ((CommonMetadataPersistence [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata_persistence(string [] rule_names,string [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_metadata_persistence", new object[] {
			rule_names,
			names}, callback, asyncState);
	}
	public CommonMetadataPersistence [] [] Endget_metadata_persistence(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonMetadataPersistence [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_metadata_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Rule", 
		RequestNamespace="urn:iControl:LocalLB/Rule", ResponseNamespace="urn:iControl:LocalLB/Rule")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_metadata_value(
		string [] rule_names,
		string [] [] names
	) {
		object [] results = this.Invoke("get_metadata_value", new object [] {
				rule_names,
				names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata_value(string [] rule_names,string [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_metadata_value", new object[] {
			rule_names,
			names}, callback, asyncState);
	}
	public string [] [] Endget_metadata_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Rule", 
		RequestNamespace="urn:iControl:LocalLB/Rule", ResponseNamespace="urn:iControl:LocalLB/Rule")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBRuleRuleStatistics get_statistics(
		string [] rule_names
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				rule_names});
		return ((LocalLBRuleRuleStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] rule_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			rule_names}, callback, asyncState);
	}
	public LocalLBRuleRuleStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBRuleRuleStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_verification_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Rule", 
		RequestNamespace="urn:iControl:LocalLB/Rule", ResponseNamespace="urn:iControl:LocalLB/Rule")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBRuleVerificationStatus [] get_verification_status(
		string [] rule_names
	) {
		object [] results = this.Invoke("get_verification_status", new object [] {
				rule_names});
		return ((LocalLBRuleVerificationStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_verification_status(string [] rule_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_verification_status", new object[] {
			rule_names}, callback, asyncState);
	}
	public LocalLBRuleVerificationStatus [] Endget_verification_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBRuleVerificationStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_verification_status_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Rule", 
		RequestNamespace="urn:iControl:LocalLB/Rule", ResponseNamespace="urn:iControl:LocalLB/Rule")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonVerificationStatus [] get_verification_status_v2(
		string [] rule_names
	) {
		object [] results = this.Invoke("get_verification_status_v2", new object [] {
				rule_names});
		return ((CommonVerificationStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_verification_status_v2(string [] rule_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_verification_status_v2", new object[] {
			rule_names}, callback, asyncState);
	}
	public CommonVerificationStatus [] Endget_verification_status_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonVerificationStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Rule", 
		RequestNamespace="urn:iControl:LocalLB/Rule", ResponseNamespace="urn:iControl:LocalLB/Rule")]
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
	// modify_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Rule", 
		RequestNamespace="urn:iControl:LocalLB/Rule", ResponseNamespace="urn:iControl:LocalLB/Rule")]
	public void modify_rule(
		LocalLBRuleRuleDefinition [] rules
	) {
		this.Invoke("modify_rule", new object [] {
				rules});

	}
	public System.IAsyncResult Beginmodify_rule(LocalLBRuleRuleDefinition [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("modify_rule", new object[] {
			rules}, callback, asyncState);
	}
	public void Endmodify_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// query_all_rules
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Rule", 
		RequestNamespace="urn:iControl:LocalLB/Rule", ResponseNamespace="urn:iControl:LocalLB/Rule")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBRuleRuleDefinition [] query_all_rules(

	) {
		object [] results = this.Invoke("query_all_rules", new object [0]);
		return ((LocalLBRuleRuleDefinition [])(results[0]));
	}
	public System.IAsyncResult Beginquery_all_rules(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("query_all_rules", new object[0], callback, asyncState);
	}
	public LocalLBRuleRuleDefinition [] Endquery_all_rules(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBRuleRuleDefinition [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// query_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Rule", 
		RequestNamespace="urn:iControl:LocalLB/Rule", ResponseNamespace="urn:iControl:LocalLB/Rule")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBRuleRuleDefinition [] query_rule(
		string [] rule_names
	) {
		object [] results = this.Invoke("query_rule", new object [] {
				rule_names});
		return ((LocalLBRuleRuleDefinition [])(results[0]));
	}
	public System.IAsyncResult Beginquery_rule(string [] rule_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("query_rule", new object[] {
			rule_names}, callback, asyncState);
	}
	public LocalLBRuleRuleDefinition [] Endquery_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBRuleRuleDefinition [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// remove_all_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Rule", 
		RequestNamespace="urn:iControl:LocalLB/Rule", ResponseNamespace="urn:iControl:LocalLB/Rule")]
	public void remove_all_metadata(
		string [] rule_names
	) {
		this.Invoke("remove_all_metadata", new object [] {
				rule_names});

	}
	public System.IAsyncResult Beginremove_all_metadata(string [] rule_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_metadata", new object[] {
			rule_names}, callback, asyncState);
	}
	public void Endremove_all_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Rule", 
		RequestNamespace="urn:iControl:LocalLB/Rule", ResponseNamespace="urn:iControl:LocalLB/Rule")]
	public void remove_metadata(
		string [] rule_names,
		string [] [] names
	) {
		this.Invoke("remove_metadata", new object [] {
				rule_names,
				names});

	}
	public System.IAsyncResult Beginremove_metadata(string [] rule_names,string [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_metadata", new object[] {
			rule_names,
			names}, callback, asyncState);
	}
	public void Endremove_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Rule", 
		RequestNamespace="urn:iControl:LocalLB/Rule", ResponseNamespace="urn:iControl:LocalLB/Rule")]
	public void reset_statistics(
		string [] rule_names
	) {
		this.Invoke("reset_statistics", new object [] {
				rule_names});

	}
	public System.IAsyncResult Beginreset_statistics(string [] rule_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics", new object[] {
			rule_names}, callback, asyncState);
	}
	public void Endreset_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Rule", 
		RequestNamespace="urn:iControl:LocalLB/Rule", ResponseNamespace="urn:iControl:LocalLB/Rule")]
	public void set_description(
		string [] rule_names,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				rule_names,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] rule_names,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			rule_names,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ignore_verification
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Rule", 
		RequestNamespace="urn:iControl:LocalLB/Rule", ResponseNamespace="urn:iControl:LocalLB/Rule")]
	public void set_ignore_verification(
		string [] rule_names,
		CommonEnabledState [] states
	) {
		this.Invoke("set_ignore_verification", new object [] {
				rule_names,
				states});

	}
	public System.IAsyncResult Beginset_ignore_verification(string [] rule_names,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ignore_verification", new object[] {
			rule_names,
			states}, callback, asyncState);
	}
	public void Endset_ignore_verification(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_metadata_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Rule", 
		RequestNamespace="urn:iControl:LocalLB/Rule", ResponseNamespace="urn:iControl:LocalLB/Rule")]
	public void set_metadata_description(
		string [] rule_names,
		string [] [] names,
		string [] [] descriptions
	) {
		this.Invoke("set_metadata_description", new object [] {
				rule_names,
				names,
				descriptions});

	}
	public System.IAsyncResult Beginset_metadata_description(string [] rule_names,string [] [] names,string [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_metadata_description", new object[] {
			rule_names,
			names,
			descriptions}, callback, asyncState);
	}
	public void Endset_metadata_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_metadata_persistence
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Rule", 
		RequestNamespace="urn:iControl:LocalLB/Rule", ResponseNamespace="urn:iControl:LocalLB/Rule")]
	public void set_metadata_persistence(
		string [] rule_names,
		string [] [] names,
		CommonMetadataPersistence [] [] values
	) {
		this.Invoke("set_metadata_persistence", new object [] {
				rule_names,
				names,
				values});

	}
	public System.IAsyncResult Beginset_metadata_persistence(string [] rule_names,string [] [] names,CommonMetadataPersistence [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_metadata_persistence", new object[] {
			rule_names,
			names,
			values}, callback, asyncState);
	}
	public void Endset_metadata_persistence(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_metadata_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/Rule", 
		RequestNamespace="urn:iControl:LocalLB/Rule", ResponseNamespace="urn:iControl:LocalLB/Rule")]
	public void set_metadata_value(
		string [] rule_names,
		string [] [] names,
		string [] [] values
	) {
		this.Invoke("set_metadata_value", new object [] {
				rule_names,
				names,
				values});

	}
	public System.IAsyncResult Beginset_metadata_value(string [] rule_names,string [] [] names,string [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_metadata_value", new object[] {
			rule_names,
			names,
			values}, callback, asyncState);
	}
	public void Endset_metadata_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.Rule.VerificationStatus", Namespace = "urn:iControl")]
	public enum LocalLBRuleVerificationStatus
	{
		VERIFICATION_STATUS_NONE,
		VERIFICATION_STATUS_SIGNATURE_NOT_VERIFIED,
		VERIFICATION_STATUS_SIGNATURE_VERIFIED,
		VERIFICATION_STATUS_CHECKSUM_NOT_VERIFIED,
		VERIFICATION_STATUS_CHECKSUM_VERIFIED,
		VERIFICATION_STATUS_UNKNOWN,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.Rule.RuleDefinition", Namespace = "urn:iControl")]
	public partial class LocalLBRuleRuleDefinition
	{
		private string rule_nameField;
		public string rule_name
		{
			get { return this.rule_nameField; }
			set { this.rule_nameField = value; }
		}
		private string rule_definitionField;
		public string rule_definition
		{
			get { return this.rule_definitionField; }
			set { this.rule_definitionField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.Rule.RuleStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBRuleRuleStatisticEntry
	{
		private string rule_nameField;
		public string rule_name
		{
			get { return this.rule_nameField; }
			set { this.rule_nameField = value; }
		}
		private string event_nameField;
		public string event_name
		{
			get { return this.event_nameField; }
			set { this.event_nameField = value; }
		}
		private long priorityField;
		public long priority
		{
			get { return this.priorityField; }
			set { this.priorityField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.Rule.RuleStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBRuleRuleStatistics
	{
		private LocalLBRuleRuleStatisticEntry [] statisticsField;
		public LocalLBRuleRuleStatisticEntry [] statistics
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
