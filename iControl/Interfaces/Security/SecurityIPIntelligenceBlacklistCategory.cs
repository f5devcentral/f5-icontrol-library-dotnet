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
	[System.Web.Services.WebServiceBindingAttribute(Name="Security.IPIntelligenceBlacklistCategoryBinding", Namespace="urn:iControl")]
	public partial class SecurityIPIntelligenceBlacklistCategory : iControlInterface {
		public SecurityIPIntelligenceBlacklistCategory() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_ip_ttl
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligenceBlacklistCategory", 
		RequestNamespace="urn:iControl:Security/IPIntelligenceBlacklistCategory", ResponseNamespace="urn:iControl:Security/IPIntelligenceBlacklistCategory")]
	public void add_ip_ttl(
		string [] categories,
		string [] [] ip_ttls
	) {
		this.Invoke("add_ip_ttl", new object [] {
				categories,
				ip_ttls});

	}
	public System.IAsyncResult Beginadd_ip_ttl(string [] categories,string [] [] ip_ttls, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_ip_ttl", new object[] {
			categories,
			ip_ttls}, callback, asyncState);
	}
	public void Endadd_ip_ttl(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligenceBlacklistCategory", 
		RequestNamespace="urn:iControl:Security/IPIntelligenceBlacklistCategory", ResponseNamespace="urn:iControl:Security/IPIntelligenceBlacklistCategory")]
	public void create(
		string [] categories
	) {
		this.Invoke("create", new object [] {
				categories});

	}
	public System.IAsyncResult Begincreate(string [] categories, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			categories}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_blacklist_categories
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligenceBlacklistCategory", 
		RequestNamespace="urn:iControl:Security/IPIntelligenceBlacklistCategory", ResponseNamespace="urn:iControl:Security/IPIntelligenceBlacklistCategory")]
	public void delete_all_blacklist_categories(

	) {
		this.Invoke("delete_all_blacklist_categories", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_blacklist_categories(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_blacklist_categories", new object[0], callback, asyncState);
	}
	public void Enddelete_all_blacklist_categories(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_blacklist_category
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligenceBlacklistCategory", 
		RequestNamespace="urn:iControl:Security/IPIntelligenceBlacklistCategory", ResponseNamespace="urn:iControl:Security/IPIntelligenceBlacklistCategory")]
	public void delete_blacklist_category(
		string [] categories
	) {
		this.Invoke("delete_blacklist_category", new object [] {
				categories});

	}
	public System.IAsyncResult Begindelete_blacklist_category(string [] categories, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_blacklist_category", new object[] {
			categories}, callback, asyncState);
	}
	public void Enddelete_blacklist_category(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_default_match_direction
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligenceBlacklistCategory", 
		RequestNamespace="urn:iControl:Security/IPIntelligenceBlacklistCategory", ResponseNamespace="urn:iControl:Security/IPIntelligenceBlacklistCategory")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityIPIntelligenceBlacklistCategoryIPIntelligenceClassMatchDirection [] get_default_match_direction(
		string [] categories
	) {
		object [] results = this.Invoke("get_default_match_direction", new object [] {
				categories});
		return ((SecurityIPIntelligenceBlacklistCategoryIPIntelligenceClassMatchDirection [])(results[0]));
	}
	public System.IAsyncResult Beginget_default_match_direction(string [] categories, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_default_match_direction", new object[] {
			categories}, callback, asyncState);
	}
	public SecurityIPIntelligenceBlacklistCategoryIPIntelligenceClassMatchDirection [] Endget_default_match_direction(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityIPIntelligenceBlacklistCategoryIPIntelligenceClassMatchDirection [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligenceBlacklistCategory", 
		RequestNamespace="urn:iControl:Security/IPIntelligenceBlacklistCategory", ResponseNamespace="urn:iControl:Security/IPIntelligenceBlacklistCategory")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] categories
	) {
		object [] results = this.Invoke("get_description", new object [] {
				categories});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] categories, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			categories}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligenceBlacklistCategory", 
		RequestNamespace="urn:iControl:Security/IPIntelligenceBlacklistCategory", ResponseNamespace="urn:iControl:Security/IPIntelligenceBlacklistCategory")]
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
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligenceBlacklistCategory", 
		RequestNamespace="urn:iControl:Security/IPIntelligenceBlacklistCategory", ResponseNamespace="urn:iControl:Security/IPIntelligenceBlacklistCategory")]
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
	// is_predefined
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligenceBlacklistCategory", 
		RequestNamespace="urn:iControl:Security/IPIntelligenceBlacklistCategory", ResponseNamespace="urn:iControl:Security/IPIntelligenceBlacklistCategory")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] is_predefined(
		string [] categories
	) {
		object [] results = this.Invoke("is_predefined", new object [] {
				categories});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginis_predefined(string [] categories, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("is_predefined", new object[] {
			categories}, callback, asyncState);
	}
	public bool [] Endis_predefined(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// remove_ip_ttl
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligenceBlacklistCategory", 
		RequestNamespace="urn:iControl:Security/IPIntelligenceBlacklistCategory", ResponseNamespace="urn:iControl:Security/IPIntelligenceBlacklistCategory")]
	public void remove_ip_ttl(
		string [] categories,
		string [] [] ip_ttls
	) {
		this.Invoke("remove_ip_ttl", new object [] {
				categories,
				ip_ttls});

	}
	public System.IAsyncResult Beginremove_ip_ttl(string [] categories,string [] [] ip_ttls, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_ip_ttl", new object[] {
			categories,
			ip_ttls}, callback, asyncState);
	}
	public void Endremove_ip_ttl(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_match_direction
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligenceBlacklistCategory", 
		RequestNamespace="urn:iControl:Security/IPIntelligenceBlacklistCategory", ResponseNamespace="urn:iControl:Security/IPIntelligenceBlacklistCategory")]
	public void set_default_match_direction(
		string [] categories,
		SecurityIPIntelligenceBlacklistCategoryIPIntelligenceClassMatchDirection [] directions
	) {
		this.Invoke("set_default_match_direction", new object [] {
				categories,
				directions});

	}
	public System.IAsyncResult Beginset_default_match_direction(string [] categories,SecurityIPIntelligenceBlacklistCategoryIPIntelligenceClassMatchDirection [] directions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_match_direction", new object[] {
			categories,
			directions}, callback, asyncState);
	}
	public void Endset_default_match_direction(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligenceBlacklistCategory", 
		RequestNamespace="urn:iControl:Security/IPIntelligenceBlacklistCategory", ResponseNamespace="urn:iControl:Security/IPIntelligenceBlacklistCategory")]
	public void set_description(
		string [] categories,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				categories,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] categories,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			categories,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Security.IPIntelligenceBlacklistCategory.IPIntelligenceClassMatchDirection", Namespace = "urn:iControl")]
	public enum SecurityIPIntelligenceBlacklistCategoryIPIntelligenceClassMatchDirection
	{
		IP_INTELLIGENCE_MATCH_DIRECTION_UNKNOWN,
		IP_INTELLIGENCE_MATCH_DIRECTION_SOURCE,
		IP_INTELLIGENCE_MATCH_DIRECTION_DESTINATION,
		IP_INTELLIGENCE_MATCH_DIRECTION_SOURCE_AND_DESTINATION,
	}

	//=======================================================================
	// Structs
	//=======================================================================

}
