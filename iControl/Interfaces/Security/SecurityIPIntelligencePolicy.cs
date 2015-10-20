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
	[System.Web.Services.WebServiceBindingAttribute(Name="Security.IPIntelligencePolicyBinding", Namespace="urn:iControl")]
	public partial class SecurityIPIntelligencePolicy : iControlInterface {
		public SecurityIPIntelligencePolicy() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_blacklist_category
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligencePolicy", 
		RequestNamespace="urn:iControl:Security/IPIntelligencePolicy", ResponseNamespace="urn:iControl:Security/IPIntelligencePolicy")]
	public void add_blacklist_category(
		string [] policies,
		string [] [] categories
	) {
		this.Invoke("add_blacklist_category", new object [] {
				policies,
				categories});

	}
	public System.IAsyncResult Beginadd_blacklist_category(string [] policies,string [] [] categories, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_blacklist_category", new object[] {
			policies,
			categories}, callback, asyncState);
	}
	public void Endadd_blacklist_category(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_feed_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligencePolicy", 
		RequestNamespace="urn:iControl:Security/IPIntelligencePolicy", ResponseNamespace="urn:iControl:Security/IPIntelligencePolicy")]
	public void add_feed_list(
		string [] policies,
		string [] [] lists
	) {
		this.Invoke("add_feed_list", new object [] {
				policies,
				lists});

	}
	public System.IAsyncResult Beginadd_feed_list(string [] policies,string [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_feed_list", new object[] {
			policies,
			lists}, callback, asyncState);
	}
	public void Endadd_feed_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligencePolicy", 
		RequestNamespace="urn:iControl:Security/IPIntelligencePolicy", ResponseNamespace="urn:iControl:Security/IPIntelligencePolicy")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligencePolicy", 
		RequestNamespace="urn:iControl:Security/IPIntelligencePolicy", ResponseNamespace="urn:iControl:Security/IPIntelligencePolicy")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligencePolicy", 
		RequestNamespace="urn:iControl:Security/IPIntelligencePolicy", ResponseNamespace="urn:iControl:Security/IPIntelligencePolicy")]
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
	// get_blacklist_category
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligencePolicy", 
		RequestNamespace="urn:iControl:Security/IPIntelligencePolicy", ResponseNamespace="urn:iControl:Security/IPIntelligencePolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_blacklist_category(
		string [] policies
	) {
		object [] results = this.Invoke("get_blacklist_category", new object [] {
				policies});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_blacklist_category(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_blacklist_category", new object[] {
			policies}, callback, asyncState);
	}
	public string [] [] Endget_blacklist_category(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_blacklist_category_action_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligencePolicy", 
		RequestNamespace="urn:iControl:Security/IPIntelligencePolicy", ResponseNamespace="urn:iControl:Security/IPIntelligencePolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityIPIntelligencePolicyIPIntelligencePolicyActionType [] [] get_blacklist_category_action_type(
		string [] policies,
		string [] [] categories
	) {
		object [] results = this.Invoke("get_blacklist_category_action_type", new object [] {
				policies,
				categories});
		return ((SecurityIPIntelligencePolicyIPIntelligencePolicyActionType [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_blacklist_category_action_type(string [] policies,string [] [] categories, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_blacklist_category_action_type", new object[] {
			policies,
			categories}, callback, asyncState);
	}
	public SecurityIPIntelligencePolicyIPIntelligencePolicyActionType [] [] Endget_blacklist_category_action_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityIPIntelligencePolicyIPIntelligencePolicyActionType [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_blacklist_category_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligencePolicy", 
		RequestNamespace="urn:iControl:Security/IPIntelligencePolicy", ResponseNamespace="urn:iControl:Security/IPIntelligencePolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_blacklist_category_description(
		string [] policies,
		string [] [] categories
	) {
		object [] results = this.Invoke("get_blacklist_category_description", new object [] {
				policies,
				categories});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_blacklist_category_description(string [] policies,string [] [] categories, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_blacklist_category_description", new object[] {
			policies,
			categories}, callback, asyncState);
	}
	public string [] [] Endget_blacklist_category_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_blacklist_category_log_blacklist_hit_only_setting
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligencePolicy", 
		RequestNamespace="urn:iControl:Security/IPIntelligencePolicy", ResponseNamespace="urn:iControl:Security/IPIntelligencePolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityIPIntelligencePolicyIPIntelligencePolicyBlacklistCategoryLogType [] [] get_blacklist_category_log_blacklist_hit_only_setting(
		string [] policies,
		string [] [] categories
	) {
		object [] results = this.Invoke("get_blacklist_category_log_blacklist_hit_only_setting", new object [] {
				policies,
				categories});
		return ((SecurityIPIntelligencePolicyIPIntelligencePolicyBlacklistCategoryLogType [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_blacklist_category_log_blacklist_hit_only_setting(string [] policies,string [] [] categories, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_blacklist_category_log_blacklist_hit_only_setting", new object[] {
			policies,
			categories}, callback, asyncState);
	}
	public SecurityIPIntelligencePolicyIPIntelligencePolicyBlacklistCategoryLogType [] [] Endget_blacklist_category_log_blacklist_hit_only_setting(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityIPIntelligencePolicyIPIntelligencePolicyBlacklistCategoryLogType [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_blacklist_category_log_blacklist_whitelist_hit_setting
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligencePolicy", 
		RequestNamespace="urn:iControl:Security/IPIntelligencePolicy", ResponseNamespace="urn:iControl:Security/IPIntelligencePolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityIPIntelligencePolicyIPIntelligencePolicyBlacklistCategoryLogType [] [] get_blacklist_category_log_blacklist_whitelist_hit_setting(
		string [] policies,
		string [] [] categories
	) {
		object [] results = this.Invoke("get_blacklist_category_log_blacklist_whitelist_hit_setting", new object [] {
				policies,
				categories});
		return ((SecurityIPIntelligencePolicyIPIntelligencePolicyBlacklistCategoryLogType [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_blacklist_category_log_blacklist_whitelist_hit_setting(string [] policies,string [] [] categories, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_blacklist_category_log_blacklist_whitelist_hit_setting", new object[] {
			policies,
			categories}, callback, asyncState);
	}
	public SecurityIPIntelligencePolicyIPIntelligencePolicyBlacklistCategoryLogType [] [] Endget_blacklist_category_log_blacklist_whitelist_hit_setting(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityIPIntelligencePolicyIPIntelligencePolicyBlacklistCategoryLogType [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_blacklist_category_match_direction
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligencePolicy", 
		RequestNamespace="urn:iControl:Security/IPIntelligencePolicy", ResponseNamespace="urn:iControl:Security/IPIntelligencePolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityIPIntelligencePolicyIPIntelligencePolicyMatchDirection [] [] get_blacklist_category_match_direction(
		string [] policies,
		string [] [] categories
	) {
		object [] results = this.Invoke("get_blacklist_category_match_direction", new object [] {
				policies,
				categories});
		return ((SecurityIPIntelligencePolicyIPIntelligencePolicyMatchDirection [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_blacklist_category_match_direction(string [] policies,string [] [] categories, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_blacklist_category_match_direction", new object[] {
			policies,
			categories}, callback, asyncState);
	}
	public SecurityIPIntelligencePolicyIPIntelligencePolicyMatchDirection [] [] Endget_blacklist_category_match_direction(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityIPIntelligencePolicyIPIntelligencePolicyMatchDirection [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default_action_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligencePolicy", 
		RequestNamespace="urn:iControl:Security/IPIntelligencePolicy", ResponseNamespace="urn:iControl:Security/IPIntelligencePolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityIPIntelligencePolicyIPIntelligencePolicyActionType [] get_default_action_type(
		string [] policies
	) {
		object [] results = this.Invoke("get_default_action_type", new object [] {
				policies});
		return ((SecurityIPIntelligencePolicyIPIntelligencePolicyActionType [])(results[0]));
	}
	public System.IAsyncResult Beginget_default_action_type(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_default_action_type", new object[] {
			policies}, callback, asyncState);
	}
	public SecurityIPIntelligencePolicyIPIntelligencePolicyActionType [] Endget_default_action_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityIPIntelligencePolicyIPIntelligencePolicyActionType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligencePolicy", 
		RequestNamespace="urn:iControl:Security/IPIntelligencePolicy", ResponseNamespace="urn:iControl:Security/IPIntelligencePolicy")]
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
	// get_feed_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligencePolicy", 
		RequestNamespace="urn:iControl:Security/IPIntelligencePolicy", ResponseNamespace="urn:iControl:Security/IPIntelligencePolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_feed_list(
		string [] policies
	) {
		object [] results = this.Invoke("get_feed_list", new object [] {
				policies});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_feed_list(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_feed_list", new object[] {
			policies}, callback, asyncState);
	}
	public string [] [] Endget_feed_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligencePolicy", 
		RequestNamespace="urn:iControl:Security/IPIntelligencePolicy", ResponseNamespace="urn:iControl:Security/IPIntelligencePolicy")]
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
	// get_log_blacklist_hit_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligencePolicy", 
		RequestNamespace="urn:iControl:Security/IPIntelligencePolicy", ResponseNamespace="urn:iControl:Security/IPIntelligencePolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_log_blacklist_hit_state(
		string [] policies
	) {
		object [] results = this.Invoke("get_log_blacklist_hit_state", new object [] {
				policies});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_log_blacklist_hit_state(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_log_blacklist_hit_state", new object[] {
			policies}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_log_blacklist_hit_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_log_blacklist_whitelist_both_hit_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligencePolicy", 
		RequestNamespace="urn:iControl:Security/IPIntelligencePolicy", ResponseNamespace="urn:iControl:Security/IPIntelligencePolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_log_blacklist_whitelist_both_hit_state(
		string [] policies
	) {
		object [] results = this.Invoke("get_log_blacklist_whitelist_both_hit_state", new object [] {
				policies});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_log_blacklist_whitelist_both_hit_state(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_log_blacklist_whitelist_both_hit_state", new object[] {
			policies}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_log_blacklist_whitelist_both_hit_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligencePolicy", 
		RequestNamespace="urn:iControl:Security/IPIntelligencePolicy", ResponseNamespace="urn:iControl:Security/IPIntelligencePolicy")]
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
	// remove_all_blacklist_categories
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligencePolicy", 
		RequestNamespace="urn:iControl:Security/IPIntelligencePolicy", ResponseNamespace="urn:iControl:Security/IPIntelligencePolicy")]
	public void remove_all_blacklist_categories(
		string [] policies
	) {
		this.Invoke("remove_all_blacklist_categories", new object [] {
				policies});

	}
	public System.IAsyncResult Beginremove_all_blacklist_categories(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_blacklist_categories", new object[] {
			policies}, callback, asyncState);
	}
	public void Endremove_all_blacklist_categories(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_feed_lists
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligencePolicy", 
		RequestNamespace="urn:iControl:Security/IPIntelligencePolicy", ResponseNamespace="urn:iControl:Security/IPIntelligencePolicy")]
	public void remove_all_feed_lists(
		string [] policies
	) {
		this.Invoke("remove_all_feed_lists", new object [] {
				policies});

	}
	public System.IAsyncResult Beginremove_all_feed_lists(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_feed_lists", new object[] {
			policies}, callback, asyncState);
	}
	public void Endremove_all_feed_lists(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_blacklist_category
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligencePolicy", 
		RequestNamespace="urn:iControl:Security/IPIntelligencePolicy", ResponseNamespace="urn:iControl:Security/IPIntelligencePolicy")]
	public void remove_blacklist_category(
		string [] policies,
		string [] [] categories
	) {
		this.Invoke("remove_blacklist_category", new object [] {
				policies,
				categories});

	}
	public System.IAsyncResult Beginremove_blacklist_category(string [] policies,string [] [] categories, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_blacklist_category", new object[] {
			policies,
			categories}, callback, asyncState);
	}
	public void Endremove_blacklist_category(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_feed_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligencePolicy", 
		RequestNamespace="urn:iControl:Security/IPIntelligencePolicy", ResponseNamespace="urn:iControl:Security/IPIntelligencePolicy")]
	public void remove_feed_list(
		string [] policies,
		string [] [] lists
	) {
		this.Invoke("remove_feed_list", new object [] {
				policies,
				lists});

	}
	public System.IAsyncResult Beginremove_feed_list(string [] policies,string [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_feed_list", new object[] {
			policies,
			lists}, callback, asyncState);
	}
	public void Endremove_feed_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_blacklist_category_action_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligencePolicy", 
		RequestNamespace="urn:iControl:Security/IPIntelligencePolicy", ResponseNamespace="urn:iControl:Security/IPIntelligencePolicy")]
	public void set_blacklist_category_action_type(
		string [] policies,
		string [] [] categories,
		SecurityIPIntelligencePolicyIPIntelligencePolicyActionType [] [] types
	) {
		this.Invoke("set_blacklist_category_action_type", new object [] {
				policies,
				categories,
				types});

	}
	public System.IAsyncResult Beginset_blacklist_category_action_type(string [] policies,string [] [] categories,SecurityIPIntelligencePolicyIPIntelligencePolicyActionType [] [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_blacklist_category_action_type", new object[] {
			policies,
			categories,
			types}, callback, asyncState);
	}
	public void Endset_blacklist_category_action_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_blacklist_category_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligencePolicy", 
		RequestNamespace="urn:iControl:Security/IPIntelligencePolicy", ResponseNamespace="urn:iControl:Security/IPIntelligencePolicy")]
	public void set_blacklist_category_description(
		string [] policies,
		string [] [] categories,
		string [] [] descriptions
	) {
		this.Invoke("set_blacklist_category_description", new object [] {
				policies,
				categories,
				descriptions});

	}
	public System.IAsyncResult Beginset_blacklist_category_description(string [] policies,string [] [] categories,string [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_blacklist_category_description", new object[] {
			policies,
			categories,
			descriptions}, callback, asyncState);
	}
	public void Endset_blacklist_category_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_blacklist_category_log_blacklist_hit_only_setting
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligencePolicy", 
		RequestNamespace="urn:iControl:Security/IPIntelligencePolicy", ResponseNamespace="urn:iControl:Security/IPIntelligencePolicy")]
	public void set_blacklist_category_log_blacklist_hit_only_setting(
		string [] policies,
		string [] [] categories,
		SecurityIPIntelligencePolicyIPIntelligencePolicyBlacklistCategoryLogType [] [] hits
	) {
		this.Invoke("set_blacklist_category_log_blacklist_hit_only_setting", new object [] {
				policies,
				categories,
				hits});

	}
	public System.IAsyncResult Beginset_blacklist_category_log_blacklist_hit_only_setting(string [] policies,string [] [] categories,SecurityIPIntelligencePolicyIPIntelligencePolicyBlacklistCategoryLogType [] [] hits, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_blacklist_category_log_blacklist_hit_only_setting", new object[] {
			policies,
			categories,
			hits}, callback, asyncState);
	}
	public void Endset_blacklist_category_log_blacklist_hit_only_setting(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_blacklist_category_log_blacklist_whitelist_hit_setting
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligencePolicy", 
		RequestNamespace="urn:iControl:Security/IPIntelligencePolicy", ResponseNamespace="urn:iControl:Security/IPIntelligencePolicy")]
	public void set_blacklist_category_log_blacklist_whitelist_hit_setting(
		string [] policies,
		string [] [] categories,
		SecurityIPIntelligencePolicyIPIntelligencePolicyBlacklistCategoryLogType [] [] hits
	) {
		this.Invoke("set_blacklist_category_log_blacklist_whitelist_hit_setting", new object [] {
				policies,
				categories,
				hits});

	}
	public System.IAsyncResult Beginset_blacklist_category_log_blacklist_whitelist_hit_setting(string [] policies,string [] [] categories,SecurityIPIntelligencePolicyIPIntelligencePolicyBlacklistCategoryLogType [] [] hits, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_blacklist_category_log_blacklist_whitelist_hit_setting", new object[] {
			policies,
			categories,
			hits}, callback, asyncState);
	}
	public void Endset_blacklist_category_log_blacklist_whitelist_hit_setting(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_blacklist_category_match_direction
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligencePolicy", 
		RequestNamespace="urn:iControl:Security/IPIntelligencePolicy", ResponseNamespace="urn:iControl:Security/IPIntelligencePolicy")]
	public void set_blacklist_category_match_direction(
		string [] policies,
		string [] [] categories,
		SecurityIPIntelligencePolicyIPIntelligencePolicyMatchDirection [] [] directions
	) {
		this.Invoke("set_blacklist_category_match_direction", new object [] {
				policies,
				categories,
				directions});

	}
	public System.IAsyncResult Beginset_blacklist_category_match_direction(string [] policies,string [] [] categories,SecurityIPIntelligencePolicyIPIntelligencePolicyMatchDirection [] [] directions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_blacklist_category_match_direction", new object[] {
			policies,
			categories,
			directions}, callback, asyncState);
	}
	public void Endset_blacklist_category_match_direction(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_action_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligencePolicy", 
		RequestNamespace="urn:iControl:Security/IPIntelligencePolicy", ResponseNamespace="urn:iControl:Security/IPIntelligencePolicy")]
	public void set_default_action_type(
		string [] policies,
		SecurityIPIntelligencePolicyIPIntelligencePolicyActionType [] types
	) {
		this.Invoke("set_default_action_type", new object [] {
				policies,
				types});

	}
	public System.IAsyncResult Beginset_default_action_type(string [] policies,SecurityIPIntelligencePolicyIPIntelligencePolicyActionType [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_action_type", new object[] {
			policies,
			types}, callback, asyncState);
	}
	public void Endset_default_action_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligencePolicy", 
		RequestNamespace="urn:iControl:Security/IPIntelligencePolicy", ResponseNamespace="urn:iControl:Security/IPIntelligencePolicy")]
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
	// set_log_blacklist_hit_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligencePolicy", 
		RequestNamespace="urn:iControl:Security/IPIntelligencePolicy", ResponseNamespace="urn:iControl:Security/IPIntelligencePolicy")]
	public void set_log_blacklist_hit_state(
		string [] policies,
		CommonEnabledState [] states
	) {
		this.Invoke("set_log_blacklist_hit_state", new object [] {
				policies,
				states});

	}
	public System.IAsyncResult Beginset_log_blacklist_hit_state(string [] policies,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_log_blacklist_hit_state", new object[] {
			policies,
			states}, callback, asyncState);
	}
	public void Endset_log_blacklist_hit_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_log_blacklist_whitelist_both_hit_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligencePolicy", 
		RequestNamespace="urn:iControl:Security/IPIntelligencePolicy", ResponseNamespace="urn:iControl:Security/IPIntelligencePolicy")]
	public void set_log_blacklist_whitelist_both_hit_state(
		string [] policies,
		CommonEnabledState [] states
	) {
		this.Invoke("set_log_blacklist_whitelist_both_hit_state", new object [] {
				policies,
				states});

	}
	public System.IAsyncResult Beginset_log_blacklist_whitelist_both_hit_state(string [] policies,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_log_blacklist_whitelist_both_hit_state", new object[] {
			policies,
			states}, callback, asyncState);
	}
	public void Endset_log_blacklist_whitelist_both_hit_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Security.IPIntelligencePolicy.IPIntelligencePolicyActionType", Namespace = "urn:iControl")]
	public enum SecurityIPIntelligencePolicyIPIntelligencePolicyActionType
	{
		IP_INTELLIGENCE_POLICY_ACTION_TYPE_UNKNOWN,
		IP_INTELLIGENCE_POLICY_ACTION_TYPE_USE_PARENT,
		IP_INTELLIGENCE_POLICY_ACTION_TYPE_ALLOW,
		IP_INTELLIGENCE_POLICY_ACTION_TYPE_DROP,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Security.IPIntelligencePolicy.IPIntelligencePolicyBlacklistCategoryLogType", Namespace = "urn:iControl")]
	public enum SecurityIPIntelligencePolicyIPIntelligencePolicyBlacklistCategoryLogType
	{
		IP_INTELLIGENCE_POLICY_BLACKLIST_CATEGORY_LOG_TYPE_UNKNOWN,
		IP_INTELLIGENCE_POLICY_BLACKLIST_CATEGORY_LOG_TYPE_USE_PARENT,
		IP_INTELLIGENCE_POLICY_BLACKLIST_CATEGORY_LOG_TYPE_YES,
		IP_INTELLIGENCE_POLICY_BLACKLIST_CATEGORY_LOG_TYPE_NO,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Security.IPIntelligencePolicy.IPIntelligencePolicyMatchDirection", Namespace = "urn:iControl")]
	public enum SecurityIPIntelligencePolicyIPIntelligencePolicyMatchDirection
	{
		IP_INTELLIGENCE_POLICY_MATCH_DIRECTION_UNKNOWN,
		IP_INTELLIGENCE_POLICY_MATCH_DIRECTION_SOURCE,
		IP_INTELLIGENCE_POLICY_MATCH_DIRECTION_DESTINATION,
		IP_INTELLIGENCE_POLICY_MATCH_DIRECTION_SOURCE_AND_DESTINATION,
	}

	//=======================================================================
	// Structs
	//=======================================================================

}
