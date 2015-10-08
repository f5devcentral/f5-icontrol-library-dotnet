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
	[System.Web.Services.WebServiceBindingAttribute(Name="GlobalLB.RuleBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBRuleRuleDefinition))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBRuleRuleStatistics))]
	public partial class GlobalLBRule : iControlInterface {
		public GlobalLBRule() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Rule", 
		RequestNamespace="urn:iControl:GlobalLB/Rule", ResponseNamespace="urn:iControl:GlobalLB/Rule")]
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
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Rule", 
		RequestNamespace="urn:iControl:GlobalLB/Rule", ResponseNamespace="urn:iControl:GlobalLB/Rule")]
	public void create(
		GlobalLBRuleRuleDefinition [] rules
	) {
		this.Invoke("create", new object [] {
				rules});

	}
	public System.IAsyncResult Begincreate(GlobalLBRuleRuleDefinition [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			rules}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_rules
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Rule", 
		RequestNamespace="urn:iControl:GlobalLB/Rule", ResponseNamespace="urn:iControl:GlobalLB/Rule")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Rule", 
		RequestNamespace="urn:iControl:GlobalLB/Rule", ResponseNamespace="urn:iControl:GlobalLB/Rule")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Rule", 
		RequestNamespace="urn:iControl:GlobalLB/Rule", ResponseNamespace="urn:iControl:GlobalLB/Rule")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBRuleRuleStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((GlobalLBRuleRuleStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public GlobalLBRuleRuleStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBRuleRuleStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Rule", 
		RequestNamespace="urn:iControl:GlobalLB/Rule", ResponseNamespace="urn:iControl:GlobalLB/Rule")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Rule", 
		RequestNamespace="urn:iControl:GlobalLB/Rule", ResponseNamespace="urn:iControl:GlobalLB/Rule")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Rule", 
		RequestNamespace="urn:iControl:GlobalLB/Rule", ResponseNamespace="urn:iControl:GlobalLB/Rule")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Rule", 
		RequestNamespace="urn:iControl:GlobalLB/Rule", ResponseNamespace="urn:iControl:GlobalLB/Rule")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Rule", 
		RequestNamespace="urn:iControl:GlobalLB/Rule", ResponseNamespace="urn:iControl:GlobalLB/Rule")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Rule", 
		RequestNamespace="urn:iControl:GlobalLB/Rule", ResponseNamespace="urn:iControl:GlobalLB/Rule")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBRuleRuleStatistics get_statistics(
		string [] rule_names
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				rule_names});
		return ((GlobalLBRuleRuleStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] rule_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			rule_names}, callback, asyncState);
	}
	public GlobalLBRuleRuleStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBRuleRuleStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Rule", 
		RequestNamespace="urn:iControl:GlobalLB/Rule", ResponseNamespace="urn:iControl:GlobalLB/Rule")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Rule", 
		RequestNamespace="urn:iControl:GlobalLB/Rule", ResponseNamespace="urn:iControl:GlobalLB/Rule")]
	public void modify_rule(
		GlobalLBRuleRuleDefinition [] rules
	) {
		this.Invoke("modify_rule", new object [] {
				rules});

	}
	public System.IAsyncResult Beginmodify_rule(GlobalLBRuleRuleDefinition [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("modify_rule", new object[] {
			rules}, callback, asyncState);
	}
	public void Endmodify_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// query_all_rules
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Rule", 
		RequestNamespace="urn:iControl:GlobalLB/Rule", ResponseNamespace="urn:iControl:GlobalLB/Rule")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBRuleRuleDefinition [] query_all_rules(

	) {
		object [] results = this.Invoke("query_all_rules", new object [0]);
		return ((GlobalLBRuleRuleDefinition [])(results[0]));
	}
	public System.IAsyncResult Beginquery_all_rules(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("query_all_rules", new object[0], callback, asyncState);
	}
	public GlobalLBRuleRuleDefinition [] Endquery_all_rules(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBRuleRuleDefinition [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// query_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Rule", 
		RequestNamespace="urn:iControl:GlobalLB/Rule", ResponseNamespace="urn:iControl:GlobalLB/Rule")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBRuleRuleDefinition [] query_rule(
		string [] rule_names
	) {
		object [] results = this.Invoke("query_rule", new object [] {
				rule_names});
		return ((GlobalLBRuleRuleDefinition [])(results[0]));
	}
	public System.IAsyncResult Beginquery_rule(string [] rule_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("query_rule", new object[] {
			rule_names}, callback, asyncState);
	}
	public GlobalLBRuleRuleDefinition [] Endquery_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBRuleRuleDefinition [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// remove_all_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Rule", 
		RequestNamespace="urn:iControl:GlobalLB/Rule", ResponseNamespace="urn:iControl:GlobalLB/Rule")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Rule", 
		RequestNamespace="urn:iControl:GlobalLB/Rule", ResponseNamespace="urn:iControl:GlobalLB/Rule")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Rule", 
		RequestNamespace="urn:iControl:GlobalLB/Rule", ResponseNamespace="urn:iControl:GlobalLB/Rule")]
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
	// set_metadata_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Rule", 
		RequestNamespace="urn:iControl:GlobalLB/Rule", ResponseNamespace="urn:iControl:GlobalLB/Rule")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Rule", 
		RequestNamespace="urn:iControl:GlobalLB/Rule", ResponseNamespace="urn:iControl:GlobalLB/Rule")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Rule", 
		RequestNamespace="urn:iControl:GlobalLB/Rule", ResponseNamespace="urn:iControl:GlobalLB/Rule")]
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

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.Rule.RuleDefinition", Namespace = "urn:iControl")]
	public partial class GlobalLBRuleRuleDefinition
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.Rule.RuleStatisticEntry", Namespace = "urn:iControl")]
	public partial class GlobalLBRuleRuleStatisticEntry
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.Rule.RuleStatistics", Namespace = "urn:iControl")]
	public partial class GlobalLBRuleRuleStatistics
	{
		private GlobalLBRuleRuleStatisticEntry [] statisticsField;
		public GlobalLBRuleRuleStatisticEntry [] statistics
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
