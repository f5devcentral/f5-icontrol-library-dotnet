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
	[System.Web.Services.WebServiceBindingAttribute(Name="Security.IPIntelligenceFeedListBinding", Namespace="urn:iControl")]
	public partial class SecurityIPIntelligenceFeedList : iControlInterface {
		public SecurityIPIntelligenceFeedList() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_feed
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligenceFeedList", 
		RequestNamespace="urn:iControl:Security/IPIntelligenceFeedList", ResponseNamespace="urn:iControl:Security/IPIntelligenceFeedList")]
	public void add_feed(
		string [] lists,
		string [] [] feeds,
		string [] [] categories,
		string [] [] urls
	) {
		this.Invoke("add_feed", new object [] {
				lists,
				feeds,
				categories,
				urls});

	}
	public System.IAsyncResult Beginadd_feed(string [] lists,string [] [] feeds,string [] [] categories,string [] [] urls, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_feed", new object[] {
			lists,
			feeds,
			categories,
			urls}, callback, asyncState);
	}
	public void Endadd_feed(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligenceFeedList", 
		RequestNamespace="urn:iControl:Security/IPIntelligenceFeedList", ResponseNamespace="urn:iControl:Security/IPIntelligenceFeedList")]
	public void create(
		string [] lists
	) {
		this.Invoke("create", new object [] {
				lists});

	}
	public System.IAsyncResult Begincreate(string [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			lists}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_feed_lists
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligenceFeedList", 
		RequestNamespace="urn:iControl:Security/IPIntelligenceFeedList", ResponseNamespace="urn:iControl:Security/IPIntelligenceFeedList")]
	public void delete_all_feed_lists(

	) {
		this.Invoke("delete_all_feed_lists", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_feed_lists(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_feed_lists", new object[0], callback, asyncState);
	}
	public void Enddelete_all_feed_lists(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_feed_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligenceFeedList", 
		RequestNamespace="urn:iControl:Security/IPIntelligenceFeedList", ResponseNamespace="urn:iControl:Security/IPIntelligenceFeedList")]
	public void delete_feed_list(
		string [] lists
	) {
		this.Invoke("delete_feed_list", new object [] {
				lists});

	}
	public System.IAsyncResult Begindelete_feed_list(string [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_feed_list", new object[] {
			lists}, callback, asyncState);
	}
	public void Enddelete_feed_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// download_feed
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligenceFeedList", 
		RequestNamespace="urn:iControl:Security/IPIntelligenceFeedList", ResponseNamespace="urn:iControl:Security/IPIntelligenceFeedList")]
	public void download_feed(
		string [] lists,
		string [] [] feeds
	) {
		this.Invoke("download_feed", new object [] {
				lists,
				feeds});

	}
	public System.IAsyncResult Begindownload_feed(string [] lists,string [] [] feeds, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("download_feed", new object[] {
			lists,
			feeds}, callback, asyncState);
	}
	public void Enddownload_feed(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligenceFeedList", 
		RequestNamespace="urn:iControl:Security/IPIntelligenceFeedList", ResponseNamespace="urn:iControl:Security/IPIntelligenceFeedList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] lists
	) {
		object [] results = this.Invoke("get_description", new object [] {
				lists});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			lists}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_feed
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligenceFeedList", 
		RequestNamespace="urn:iControl:Security/IPIntelligenceFeedList", ResponseNamespace="urn:iControl:Security/IPIntelligenceFeedList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_feed(
		string [] lists
	) {
		object [] results = this.Invoke("get_feed", new object [] {
				lists});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_feed(string [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_feed", new object[] {
			lists}, callback, asyncState);
	}
	public string [] [] Endget_feed(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_feed_default_blacklist_category
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligenceFeedList", 
		RequestNamespace="urn:iControl:Security/IPIntelligenceFeedList", ResponseNamespace="urn:iControl:Security/IPIntelligenceFeedList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_feed_default_blacklist_category(
		string [] lists,
		string [] [] feeds
	) {
		object [] results = this.Invoke("get_feed_default_blacklist_category", new object [] {
				lists,
				feeds});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_feed_default_blacklist_category(string [] lists,string [] [] feeds, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_feed_default_blacklist_category", new object[] {
			lists,
			feeds}, callback, asyncState);
	}
	public string [] [] Endget_feed_default_blacklist_category(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_feed_default_list_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligenceFeedList", 
		RequestNamespace="urn:iControl:Security/IPIntelligenceFeedList", ResponseNamespace="urn:iControl:Security/IPIntelligenceFeedList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityIPIntelligenceFeedListIPIntelligenceAddressType [] [] get_feed_default_list_type(
		string [] lists,
		string [] [] feeds
	) {
		object [] results = this.Invoke("get_feed_default_list_type", new object [] {
				lists,
				feeds});
		return ((SecurityIPIntelligenceFeedListIPIntelligenceAddressType [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_feed_default_list_type(string [] lists,string [] [] feeds, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_feed_default_list_type", new object[] {
			lists,
			feeds}, callback, asyncState);
	}
	public SecurityIPIntelligenceFeedListIPIntelligenceAddressType [] [] Endget_feed_default_list_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityIPIntelligenceFeedListIPIntelligenceAddressType [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_feed_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligenceFeedList", 
		RequestNamespace="urn:iControl:Security/IPIntelligenceFeedList", ResponseNamespace="urn:iControl:Security/IPIntelligenceFeedList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_feed_description(
		string [] lists,
		string [] [] feeds
	) {
		object [] results = this.Invoke("get_feed_description", new object [] {
				lists,
				feeds});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_feed_description(string [] lists,string [] [] feeds, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_feed_description", new object[] {
			lists,
			feeds}, callback, asyncState);
	}
	public string [] [] Endget_feed_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_feed_password
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligenceFeedList", 
		RequestNamespace="urn:iControl:Security/IPIntelligenceFeedList", ResponseNamespace="urn:iControl:Security/IPIntelligenceFeedList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_feed_password(
		string [] lists,
		string [] [] feeds
	) {
		object [] results = this.Invoke("get_feed_password", new object [] {
				lists,
				feeds});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_feed_password(string [] lists,string [] [] feeds, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_feed_password", new object[] {
			lists,
			feeds}, callback, asyncState);
	}
	public string [] [] Endget_feed_password(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_feed_poll_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligenceFeedList", 
		RequestNamespace="urn:iControl:Security/IPIntelligenceFeedList", ResponseNamespace="urn:iControl:Security/IPIntelligenceFeedList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_feed_poll_interval(
		string [] lists,
		string [] [] feeds
	) {
		object [] results = this.Invoke("get_feed_poll_interval", new object [] {
				lists,
				feeds});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_feed_poll_interval(string [] lists,string [] [] feeds, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_feed_poll_interval", new object[] {
			lists,
			feeds}, callback, asyncState);
	}
	public long [] [] Endget_feed_poll_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_feed_url
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligenceFeedList", 
		RequestNamespace="urn:iControl:Security/IPIntelligenceFeedList", ResponseNamespace="urn:iControl:Security/IPIntelligenceFeedList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_feed_url(
		string [] lists,
		string [] [] feeds
	) {
		object [] results = this.Invoke("get_feed_url", new object [] {
				lists,
				feeds});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_feed_url(string [] lists,string [] [] feeds, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_feed_url", new object[] {
			lists,
			feeds}, callback, asyncState);
	}
	public string [] [] Endget_feed_url(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_feed_user
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligenceFeedList", 
		RequestNamespace="urn:iControl:Security/IPIntelligenceFeedList", ResponseNamespace="urn:iControl:Security/IPIntelligenceFeedList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_feed_user(
		string [] lists,
		string [] [] feeds
	) {
		object [] results = this.Invoke("get_feed_user", new object [] {
				lists,
				feeds});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_feed_user(string [] lists,string [] [] feeds, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_feed_user", new object[] {
			lists,
			feeds}, callback, asyncState);
	}
	public string [] [] Endget_feed_user(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligenceFeedList", 
		RequestNamespace="urn:iControl:Security/IPIntelligenceFeedList", ResponseNamespace="urn:iControl:Security/IPIntelligenceFeedList")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligenceFeedList", 
		RequestNamespace="urn:iControl:Security/IPIntelligenceFeedList", ResponseNamespace="urn:iControl:Security/IPIntelligenceFeedList")]
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
	// remove_all_feeds
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligenceFeedList", 
		RequestNamespace="urn:iControl:Security/IPIntelligenceFeedList", ResponseNamespace="urn:iControl:Security/IPIntelligenceFeedList")]
	public void remove_all_feeds(
		string [] lists
	) {
		this.Invoke("remove_all_feeds", new object [] {
				lists});

	}
	public System.IAsyncResult Beginremove_all_feeds(string [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_feeds", new object[] {
			lists}, callback, asyncState);
	}
	public void Endremove_all_feeds(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_feed
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligenceFeedList", 
		RequestNamespace="urn:iControl:Security/IPIntelligenceFeedList", ResponseNamespace="urn:iControl:Security/IPIntelligenceFeedList")]
	public void remove_feed(
		string [] lists,
		string [] [] feeds
	) {
		this.Invoke("remove_feed", new object [] {
				lists,
				feeds});

	}
	public System.IAsyncResult Beginremove_feed(string [] lists,string [] [] feeds, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_feed", new object[] {
			lists,
			feeds}, callback, asyncState);
	}
	public void Endremove_feed(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligenceFeedList", 
		RequestNamespace="urn:iControl:Security/IPIntelligenceFeedList", ResponseNamespace="urn:iControl:Security/IPIntelligenceFeedList")]
	public void set_description(
		string [] lists,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				lists,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] lists,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			lists,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_feed_default_blacklist_category
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligenceFeedList", 
		RequestNamespace="urn:iControl:Security/IPIntelligenceFeedList", ResponseNamespace="urn:iControl:Security/IPIntelligenceFeedList")]
	public void set_feed_default_blacklist_category(
		string [] lists,
		string [] [] feeds,
		string [] [] categories
	) {
		this.Invoke("set_feed_default_blacklist_category", new object [] {
				lists,
				feeds,
				categories});

	}
	public System.IAsyncResult Beginset_feed_default_blacklist_category(string [] lists,string [] [] feeds,string [] [] categories, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_feed_default_blacklist_category", new object[] {
			lists,
			feeds,
			categories}, callback, asyncState);
	}
	public void Endset_feed_default_blacklist_category(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_feed_default_list_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligenceFeedList", 
		RequestNamespace="urn:iControl:Security/IPIntelligenceFeedList", ResponseNamespace="urn:iControl:Security/IPIntelligenceFeedList")]
	public void set_feed_default_list_type(
		string [] lists,
		string [] [] feeds,
		SecurityIPIntelligenceFeedListIPIntelligenceAddressType [] [] types
	) {
		this.Invoke("set_feed_default_list_type", new object [] {
				lists,
				feeds,
				types});

	}
	public System.IAsyncResult Beginset_feed_default_list_type(string [] lists,string [] [] feeds,SecurityIPIntelligenceFeedListIPIntelligenceAddressType [] [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_feed_default_list_type", new object[] {
			lists,
			feeds,
			types}, callback, asyncState);
	}
	public void Endset_feed_default_list_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_feed_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligenceFeedList", 
		RequestNamespace="urn:iControl:Security/IPIntelligenceFeedList", ResponseNamespace="urn:iControl:Security/IPIntelligenceFeedList")]
	public void set_feed_description(
		string [] lists,
		string [] [] feeds,
		string [] [] descriptions
	) {
		this.Invoke("set_feed_description", new object [] {
				lists,
				feeds,
				descriptions});

	}
	public System.IAsyncResult Beginset_feed_description(string [] lists,string [] [] feeds,string [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_feed_description", new object[] {
			lists,
			feeds,
			descriptions}, callback, asyncState);
	}
	public void Endset_feed_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_feed_password
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligenceFeedList", 
		RequestNamespace="urn:iControl:Security/IPIntelligenceFeedList", ResponseNamespace="urn:iControl:Security/IPIntelligenceFeedList")]
	public void set_feed_password(
		string [] lists,
		string [] [] feeds,
		string [] [] passwords
	) {
		this.Invoke("set_feed_password", new object [] {
				lists,
				feeds,
				passwords});

	}
	public System.IAsyncResult Beginset_feed_password(string [] lists,string [] [] feeds,string [] [] passwords, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_feed_password", new object[] {
			lists,
			feeds,
			passwords}, callback, asyncState);
	}
	public void Endset_feed_password(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_feed_poll_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligenceFeedList", 
		RequestNamespace="urn:iControl:Security/IPIntelligenceFeedList", ResponseNamespace="urn:iControl:Security/IPIntelligenceFeedList")]
	public void set_feed_poll_interval(
		string [] lists,
		string [] [] feeds,
		long [] [] intervals
	) {
		this.Invoke("set_feed_poll_interval", new object [] {
				lists,
				feeds,
				intervals});

	}
	public System.IAsyncResult Beginset_feed_poll_interval(string [] lists,string [] [] feeds,long [] [] intervals, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_feed_poll_interval", new object[] {
			lists,
			feeds,
			intervals}, callback, asyncState);
	}
	public void Endset_feed_poll_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_feed_url
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligenceFeedList", 
		RequestNamespace="urn:iControl:Security/IPIntelligenceFeedList", ResponseNamespace="urn:iControl:Security/IPIntelligenceFeedList")]
	public void set_feed_url(
		string [] lists,
		string [] [] feeds,
		string [] [] urls
	) {
		this.Invoke("set_feed_url", new object [] {
				lists,
				feeds,
				urls});

	}
	public System.IAsyncResult Beginset_feed_url(string [] lists,string [] [] feeds,string [] [] urls, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_feed_url", new object[] {
			lists,
			feeds,
			urls}, callback, asyncState);
	}
	public void Endset_feed_url(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_feed_user
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/IPIntelligenceFeedList", 
		RequestNamespace="urn:iControl:Security/IPIntelligenceFeedList", ResponseNamespace="urn:iControl:Security/IPIntelligenceFeedList")]
	public void set_feed_user(
		string [] lists,
		string [] [] feeds,
		string [] [] users
	) {
		this.Invoke("set_feed_user", new object [] {
				lists,
				feeds,
				users});

	}
	public System.IAsyncResult Beginset_feed_user(string [] lists,string [] [] feeds,string [] [] users, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_feed_user", new object[] {
			lists,
			feeds,
			users}, callback, asyncState);
	}
	public void Endset_feed_user(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Security.IPIntelligenceFeedList.IPIntelligenceAddressType", Namespace = "urn:iControl")]
	public enum SecurityIPIntelligenceFeedListIPIntelligenceAddressType
	{
		IP_INTELLIGENCE_ADDRESS_TYPE_UNKNOWN,
		IP_INTELLIGENCE_ADDRESS_TYPE_WHITELIST,
		IP_INTELLIGENCE_ADDRESS_TYPE_BLACKLIST,
	}

	//=======================================================================
	// Structs
	//=======================================================================

}
