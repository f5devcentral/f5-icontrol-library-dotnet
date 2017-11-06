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
	[System.Web.Services.WebServiceBindingAttribute(Name="System.CABundleManagerBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemCABundleManagerCABundleManagerStatistics))]
	public partial class SystemCABundleManager : iControlInterface {
		public SystemCABundleManager() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_exclude_bundle
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CABundleManager", 
		RequestNamespace="urn:iControl:System/CABundleManager", ResponseNamespace="urn:iControl:System/CABundleManager")]
	public void add_exclude_bundle(
		string [] managers,
		string [] [] bundles
	) {
		this.Invoke("add_exclude_bundle", new object [] {
				managers,
				bundles});

	}
	public System.IAsyncResult Beginadd_exclude_bundle(string [] managers,string [] [] bundles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_exclude_bundle", new object[] {
			managers,
			bundles}, callback, asyncState);
	}
	public void Endadd_exclude_bundle(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_exclude_url
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CABundleManager", 
		RequestNamespace="urn:iControl:System/CABundleManager", ResponseNamespace="urn:iControl:System/CABundleManager")]
	public void add_exclude_url(
		string [] managers,
		string [] [] urls
	) {
		this.Invoke("add_exclude_url", new object [] {
				managers,
				urls});

	}
	public System.IAsyncResult Beginadd_exclude_url(string [] managers,string [] [] urls, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_exclude_url", new object[] {
			managers,
			urls}, callback, asyncState);
	}
	public void Endadd_exclude_url(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_include_bundle
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CABundleManager", 
		RequestNamespace="urn:iControl:System/CABundleManager", ResponseNamespace="urn:iControl:System/CABundleManager")]
	public void add_include_bundle(
		string [] managers,
		string [] [] bundles
	) {
		this.Invoke("add_include_bundle", new object [] {
				managers,
				bundles});

	}
	public System.IAsyncResult Beginadd_include_bundle(string [] managers,string [] [] bundles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_include_bundle", new object[] {
			managers,
			bundles}, callback, asyncState);
	}
	public void Endadd_include_bundle(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_include_url
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CABundleManager", 
		RequestNamespace="urn:iControl:System/CABundleManager", ResponseNamespace="urn:iControl:System/CABundleManager")]
	public void add_include_url(
		string [] managers,
		string [] [] urls
	) {
		this.Invoke("add_include_url", new object [] {
				managers,
				urls});

	}
	public System.IAsyncResult Beginadd_include_url(string [] managers,string [] [] urls, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_include_url", new object[] {
			managers,
			urls}, callback, asyncState);
	}
	public void Endadd_include_url(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CABundleManager", 
		RequestNamespace="urn:iControl:System/CABundleManager", ResponseNamespace="urn:iControl:System/CABundleManager")]
	public void create(
		string [] managers
	) {
		this.Invoke("create", new object [] {
				managers});

	}
	public System.IAsyncResult Begincreate(string [] managers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			managers}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_managers
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CABundleManager", 
		RequestNamespace="urn:iControl:System/CABundleManager", ResponseNamespace="urn:iControl:System/CABundleManager")]
	public void delete_all_managers(

	) {
		this.Invoke("delete_all_managers", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_managers(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_managers", new object[0], callback, asyncState);
	}
	public void Enddelete_all_managers(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_manager
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CABundleManager", 
		RequestNamespace="urn:iControl:System/CABundleManager", ResponseNamespace="urn:iControl:System/CABundleManager")]
	public void delete_manager(
		string [] managers
	) {
		this.Invoke("delete_manager", new object [] {
				managers});

	}
	public System.IAsyncResult Begindelete_manager(string [] managers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_manager", new object[] {
			managers}, callback, asyncState);
	}
	public void Enddelete_manager(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CABundleManager", 
		RequestNamespace="urn:iControl:System/CABundleManager", ResponseNamespace="urn:iControl:System/CABundleManager")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemCABundleManagerCABundleManagerStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((SystemCABundleManagerCABundleManagerStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public SystemCABundleManagerCABundleManagerStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemCABundleManagerCABundleManagerStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CABundleManager", 
		RequestNamespace="urn:iControl:System/CABundleManager", ResponseNamespace="urn:iControl:System/CABundleManager")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] managers
	) {
		object [] results = this.Invoke("get_description", new object [] {
				managers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] managers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			managers}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_exclude_bundle
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CABundleManager", 
		RequestNamespace="urn:iControl:System/CABundleManager", ResponseNamespace="urn:iControl:System/CABundleManager")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_exclude_bundle(
		string [] managers
	) {
		object [] results = this.Invoke("get_exclude_bundle", new object [] {
				managers});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_exclude_bundle(string [] managers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_exclude_bundle", new object[] {
			managers}, callback, asyncState);
	}
	public string [] [] Endget_exclude_bundle(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_exclude_url
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CABundleManager", 
		RequestNamespace="urn:iControl:System/CABundleManager", ResponseNamespace="urn:iControl:System/CABundleManager")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_exclude_url(
		string [] managers
	) {
		object [] results = this.Invoke("get_exclude_url", new object [] {
				managers});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_exclude_url(string [] managers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_exclude_url", new object[] {
			managers}, callback, asyncState);
	}
	public string [] [] Endget_exclude_url(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_include_bundle
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CABundleManager", 
		RequestNamespace="urn:iControl:System/CABundleManager", ResponseNamespace="urn:iControl:System/CABundleManager")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_include_bundle(
		string [] managers
	) {
		object [] results = this.Invoke("get_include_bundle", new object [] {
				managers});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_include_bundle(string [] managers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_include_bundle", new object[] {
			managers}, callback, asyncState);
	}
	public string [] [] Endget_include_bundle(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_include_url
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CABundleManager", 
		RequestNamespace="urn:iControl:System/CABundleManager", ResponseNamespace="urn:iControl:System/CABundleManager")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_include_url(
		string [] managers
	) {
		object [] results = this.Invoke("get_include_url", new object [] {
				managers});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_include_url(string [] managers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_include_url", new object[] {
			managers}, callback, asyncState);
	}
	public string [] [] Endget_include_url(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CABundleManager", 
		RequestNamespace="urn:iControl:System/CABundleManager", ResponseNamespace="urn:iControl:System/CABundleManager")]
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
	// get_proxy_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CABundleManager", 
		RequestNamespace="urn:iControl:System/CABundleManager", ResponseNamespace="urn:iControl:System/CABundleManager")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_proxy_port(
		string [] managers
	) {
		object [] results = this.Invoke("get_proxy_port", new object [] {
				managers});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_proxy_port(string [] managers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_proxy_port", new object[] {
			managers}, callback, asyncState);
	}
	public long [] Endget_proxy_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_proxy_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CABundleManager", 
		RequestNamespace="urn:iControl:System/CABundleManager", ResponseNamespace="urn:iControl:System/CABundleManager")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_proxy_server(
		string [] managers
	) {
		object [] results = this.Invoke("get_proxy_server", new object [] {
				managers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_proxy_server(string [] managers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_proxy_server", new object[] {
			managers}, callback, asyncState);
	}
	public string [] Endget_proxy_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CABundleManager", 
		RequestNamespace="urn:iControl:System/CABundleManager", ResponseNamespace="urn:iControl:System/CABundleManager")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemCABundleManagerCABundleManagerStatistics get_statistics(
		string [] managers
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				managers});
		return ((SystemCABundleManagerCABundleManagerStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] managers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			managers}, callback, asyncState);
	}
	public SystemCABundleManagerCABundleManagerStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemCABundleManagerCABundleManagerStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CABundleManager", 
		RequestNamespace="urn:iControl:System/CABundleManager", ResponseNamespace="urn:iControl:System/CABundleManager")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_timeout(
		string [] managers
	) {
		object [] results = this.Invoke("get_timeout", new object [] {
				managers});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_timeout(string [] managers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_timeout", new object[] {
			managers}, callback, asyncState);
	}
	public long [] Endget_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_trusted_ca_bundle
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CABundleManager", 
		RequestNamespace="urn:iControl:System/CABundleManager", ResponseNamespace="urn:iControl:System/CABundleManager")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_trusted_ca_bundle(
		string [] managers
	) {
		object [] results = this.Invoke("get_trusted_ca_bundle", new object [] {
				managers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_trusted_ca_bundle(string [] managers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_trusted_ca_bundle", new object[] {
			managers}, callback, asyncState);
	}
	public string [] Endget_trusted_ca_bundle(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_update_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CABundleManager", 
		RequestNamespace="urn:iControl:System/CABundleManager", ResponseNamespace="urn:iControl:System/CABundleManager")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_update_interval(
		string [] managers
	) {
		object [] results = this.Invoke("get_update_interval", new object [] {
				managers});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_update_interval(string [] managers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_update_interval", new object[] {
			managers}, callback, asyncState);
	}
	public long [] Endget_update_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CABundleManager", 
		RequestNamespace="urn:iControl:System/CABundleManager", ResponseNamespace="urn:iControl:System/CABundleManager")]
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
	// remove_all_exclude_bundles
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CABundleManager", 
		RequestNamespace="urn:iControl:System/CABundleManager", ResponseNamespace="urn:iControl:System/CABundleManager")]
	public void remove_all_exclude_bundles(
		string [] managers
	) {
		this.Invoke("remove_all_exclude_bundles", new object [] {
				managers});

	}
	public System.IAsyncResult Beginremove_all_exclude_bundles(string [] managers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_exclude_bundles", new object[] {
			managers}, callback, asyncState);
	}
	public void Endremove_all_exclude_bundles(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_exclude_urls
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CABundleManager", 
		RequestNamespace="urn:iControl:System/CABundleManager", ResponseNamespace="urn:iControl:System/CABundleManager")]
	public void remove_all_exclude_urls(
		string [] managers
	) {
		this.Invoke("remove_all_exclude_urls", new object [] {
				managers});

	}
	public System.IAsyncResult Beginremove_all_exclude_urls(string [] managers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_exclude_urls", new object[] {
			managers}, callback, asyncState);
	}
	public void Endremove_all_exclude_urls(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_include_bundles
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CABundleManager", 
		RequestNamespace="urn:iControl:System/CABundleManager", ResponseNamespace="urn:iControl:System/CABundleManager")]
	public void remove_all_include_bundles(
		string [] managers
	) {
		this.Invoke("remove_all_include_bundles", new object [] {
				managers});

	}
	public System.IAsyncResult Beginremove_all_include_bundles(string [] managers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_include_bundles", new object[] {
			managers}, callback, asyncState);
	}
	public void Endremove_all_include_bundles(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_include_urls
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CABundleManager", 
		RequestNamespace="urn:iControl:System/CABundleManager", ResponseNamespace="urn:iControl:System/CABundleManager")]
	public void remove_all_include_urls(
		string [] managers
	) {
		this.Invoke("remove_all_include_urls", new object [] {
				managers});

	}
	public System.IAsyncResult Beginremove_all_include_urls(string [] managers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_include_urls", new object[] {
			managers}, callback, asyncState);
	}
	public void Endremove_all_include_urls(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_exclude_bundle
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CABundleManager", 
		RequestNamespace="urn:iControl:System/CABundleManager", ResponseNamespace="urn:iControl:System/CABundleManager")]
	public void remove_exclude_bundle(
		string [] managers,
		string [] [] bundles
	) {
		this.Invoke("remove_exclude_bundle", new object [] {
				managers,
				bundles});

	}
	public System.IAsyncResult Beginremove_exclude_bundle(string [] managers,string [] [] bundles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_exclude_bundle", new object[] {
			managers,
			bundles}, callback, asyncState);
	}
	public void Endremove_exclude_bundle(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_exclude_url
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CABundleManager", 
		RequestNamespace="urn:iControl:System/CABundleManager", ResponseNamespace="urn:iControl:System/CABundleManager")]
	public void remove_exclude_url(
		string [] managers,
		string [] [] urls
	) {
		this.Invoke("remove_exclude_url", new object [] {
				managers,
				urls});

	}
	public System.IAsyncResult Beginremove_exclude_url(string [] managers,string [] [] urls, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_exclude_url", new object[] {
			managers,
			urls}, callback, asyncState);
	}
	public void Endremove_exclude_url(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_include_bundle
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CABundleManager", 
		RequestNamespace="urn:iControl:System/CABundleManager", ResponseNamespace="urn:iControl:System/CABundleManager")]
	public void remove_include_bundle(
		string [] managers,
		string [] [] bundles
	) {
		this.Invoke("remove_include_bundle", new object [] {
				managers,
				bundles});

	}
	public System.IAsyncResult Beginremove_include_bundle(string [] managers,string [] [] bundles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_include_bundle", new object[] {
			managers,
			bundles}, callback, asyncState);
	}
	public void Endremove_include_bundle(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_include_url
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CABundleManager", 
		RequestNamespace="urn:iControl:System/CABundleManager", ResponseNamespace="urn:iControl:System/CABundleManager")]
	public void remove_include_url(
		string [] managers,
		string [] [] urls
	) {
		this.Invoke("remove_include_url", new object [] {
				managers,
				urls});

	}
	public System.IAsyncResult Beginremove_include_url(string [] managers,string [] [] urls, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_include_url", new object[] {
			managers,
			urls}, callback, asyncState);
	}
	public void Endremove_include_url(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CABundleManager", 
		RequestNamespace="urn:iControl:System/CABundleManager", ResponseNamespace="urn:iControl:System/CABundleManager")]
	public void set_description(
		string [] managers,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				managers,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] managers,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			managers,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_proxy_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CABundleManager", 
		RequestNamespace="urn:iControl:System/CABundleManager", ResponseNamespace="urn:iControl:System/CABundleManager")]
	public void set_proxy_port(
		string [] managers,
		long [] ports
	) {
		this.Invoke("set_proxy_port", new object [] {
				managers,
				ports});

	}
	public System.IAsyncResult Beginset_proxy_port(string [] managers,long [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_proxy_port", new object[] {
			managers,
			ports}, callback, asyncState);
	}
	public void Endset_proxy_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_proxy_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CABundleManager", 
		RequestNamespace="urn:iControl:System/CABundleManager", ResponseNamespace="urn:iControl:System/CABundleManager")]
	public void set_proxy_server(
		string [] managers,
		string [] servers
	) {
		this.Invoke("set_proxy_server", new object [] {
				managers,
				servers});

	}
	public System.IAsyncResult Beginset_proxy_server(string [] managers,string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_proxy_server", new object[] {
			managers,
			servers}, callback, asyncState);
	}
	public void Endset_proxy_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CABundleManager", 
		RequestNamespace="urn:iControl:System/CABundleManager", ResponseNamespace="urn:iControl:System/CABundleManager")]
	public void set_timeout(
		string [] managers,
		long [] timeouts
	) {
		this.Invoke("set_timeout", new object [] {
				managers,
				timeouts});

	}
	public System.IAsyncResult Beginset_timeout(string [] managers,long [] timeouts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_timeout", new object[] {
			managers,
			timeouts}, callback, asyncState);
	}
	public void Endset_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_trusted_ca_bundle
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CABundleManager", 
		RequestNamespace="urn:iControl:System/CABundleManager", ResponseNamespace="urn:iControl:System/CABundleManager")]
	public void set_trusted_ca_bundle(
		string [] managers,
		string [] trusted_ca_bundles
	) {
		this.Invoke("set_trusted_ca_bundle", new object [] {
				managers,
				trusted_ca_bundles});

	}
	public System.IAsyncResult Beginset_trusted_ca_bundle(string [] managers,string [] trusted_ca_bundles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_trusted_ca_bundle", new object[] {
			managers,
			trusted_ca_bundles}, callback, asyncState);
	}
	public void Endset_trusted_ca_bundle(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_update_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CABundleManager", 
		RequestNamespace="urn:iControl:System/CABundleManager", ResponseNamespace="urn:iControl:System/CABundleManager")]
	public void set_update_interval(
		string [] managers,
		long [] intervals
	) {
		this.Invoke("set_update_interval", new object [] {
				managers,
				intervals});

	}
	public System.IAsyncResult Beginset_update_interval(string [] managers,long [] intervals, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_update_interval", new object[] {
			managers,
			intervals}, callback, asyncState);
	}
	public void Endset_update_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_update_now
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/CABundleManager", 
		RequestNamespace="urn:iControl:System/CABundleManager", ResponseNamespace="urn:iControl:System/CABundleManager")]
	public void set_update_now(
		string [] managers,
		SystemCABundleManagerUpdateNowCommand [] update_now
	) {
		this.Invoke("set_update_now", new object [] {
				managers,
				update_now});

	}
	public System.IAsyncResult Beginset_update_now(string [] managers,SystemCABundleManagerUpdateNowCommand [] update_now, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_update_now", new object[] {
			managers,
			update_now}, callback, asyncState);
	}
	public void Endset_update_now(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.CABundleManager.UpdateNowCommand", Namespace = "urn:iControl")]
	public enum SystemCABundleManagerUpdateNowCommand
	{
		YES,
		NO,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.CABundleManager.CABundleManagerStatistics", Namespace = "urn:iControl")]
	public partial class SystemCABundleManagerCABundleManagerStatistics
	{
		private SystemCABundleManagerCABundleManagerStatisticsEntry [] statisticsField;
		public SystemCABundleManagerCABundleManagerStatisticsEntry [] statistics
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.CABundleManager.CABundleManagerStatisticsEntry", Namespace = "urn:iControl")]
	public partial class SystemCABundleManagerCABundleManagerStatisticsEntry
	{
		private string nameField;
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}
		private string update_statusField;
		public string update_status
		{
			get { return this.update_statusField; }
			set { this.update_statusField = value; }
		}
		private CommonStatistic [] statisticsField;
		public CommonStatistic [] statistics
		{
			get { return this.statisticsField; }
			set { this.statisticsField = value; }
		}
	};

}
