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
	[System.Web.Services.WebServiceBindingAttribute(Name="GlobalLB.VirtualServerV2Binding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBVirtualServerID))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonIPPortDefinition))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBMetricLimit))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBMonitorRule))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonObjectStatus))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBVirtualServerV2VirtualServerStatistics))]
	public partial class GlobalLBVirtualServerV2 : iControlInterface {
		public GlobalLBVirtualServerV2() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_dependency
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServerV2", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServerV2", ResponseNamespace="urn:iControl:GlobalLB/VirtualServerV2")]
	public void add_dependency(
		GlobalLBVirtualServerID [] virtual_servers,
		GlobalLBVirtualServerID [] [] dependencies
	) {
		this.Invoke("add_dependency", new object [] {
				virtual_servers,
				dependencies});

	}
	public System.IAsyncResult Beginadd_dependency(GlobalLBVirtualServerID [] virtual_servers,GlobalLBVirtualServerID [] [] dependencies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_dependency", new object[] {
			virtual_servers,
			dependencies}, callback, asyncState);
	}
	public void Endadd_dependency(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServerV2", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServerV2", ResponseNamespace="urn:iControl:GlobalLB/VirtualServerV2")]
	public void create(
		GlobalLBVirtualServerID [] virtual_servers,
		CommonIPPortDefinition [] addresses
	) {
		this.Invoke("create", new object [] {
				virtual_servers,
				addresses});

	}
	public System.IAsyncResult Begincreate(GlobalLBVirtualServerID [] virtual_servers,CommonIPPortDefinition [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			virtual_servers,
			addresses}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_virtual_servers
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServerV2", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServerV2", ResponseNamespace="urn:iControl:GlobalLB/VirtualServerV2")]
	public void delete_all_virtual_servers(

	) {
		this.Invoke("delete_all_virtual_servers", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_virtual_servers(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_virtual_servers", new object[0], callback, asyncState);
	}
	public void Enddelete_all_virtual_servers(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_virtual_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServerV2", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServerV2", ResponseNamespace="urn:iControl:GlobalLB/VirtualServerV2")]
	public void delete_virtual_server(
		GlobalLBVirtualServerID [] virtual_servers
	) {
		this.Invoke("delete_virtual_server", new object [] {
				virtual_servers});

	}
	public System.IAsyncResult Begindelete_virtual_server(GlobalLBVirtualServerID [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_virtual_server", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public void Enddelete_virtual_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServerV2", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServerV2", ResponseNamespace="urn:iControl:GlobalLB/VirtualServerV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonIPPortDefinition [] get_address(
		GlobalLBVirtualServerID [] virtual_servers
	) {
		object [] results = this.Invoke("get_address", new object [] {
				virtual_servers});
		return ((CommonIPPortDefinition [])(results[0]));
	}
	public System.IAsyncResult Beginget_address(GlobalLBVirtualServerID [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_address", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public CommonIPPortDefinition [] Endget_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonIPPortDefinition [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dependency
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServerV2", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServerV2", ResponseNamespace="urn:iControl:GlobalLB/VirtualServerV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBVirtualServerID [] [] get_dependency(
		GlobalLBVirtualServerID [] virtual_servers
	) {
		object [] results = this.Invoke("get_dependency", new object [] {
				virtual_servers});
		return ((GlobalLBVirtualServerID [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_dependency(GlobalLBVirtualServerID [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dependency", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public GlobalLBVirtualServerID [] [] Endget_dependency(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBVirtualServerID [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServerV2", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServerV2", ResponseNamespace="urn:iControl:GlobalLB/VirtualServerV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		GlobalLBVirtualServerID [] virtual_servers
	) {
		object [] results = this.Invoke("get_description", new object [] {
				virtual_servers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(GlobalLBVirtualServerID [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServerV2", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServerV2", ResponseNamespace="urn:iControl:GlobalLB/VirtualServerV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_enabled_state(
		GlobalLBVirtualServerID [] virtual_servers
	) {
		object [] results = this.Invoke("get_enabled_state", new object [] {
				virtual_servers});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_enabled_state(GlobalLBVirtualServerID [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_enabled_state", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_explicit_link
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServerV2", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServerV2", ResponseNamespace="urn:iControl:GlobalLB/VirtualServerV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_explicit_link(
		GlobalLBVirtualServerID [] virtual_servers
	) {
		object [] results = this.Invoke("get_explicit_link", new object [] {
				virtual_servers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_explicit_link(GlobalLBVirtualServerID [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_explicit_link", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public string [] Endget_explicit_link(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServerV2", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServerV2", ResponseNamespace="urn:iControl:GlobalLB/VirtualServerV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBMetricLimit [] [] get_limit(
		GlobalLBVirtualServerID [] virtual_servers
	) {
		object [] results = this.Invoke("get_limit", new object [] {
				virtual_servers});
		return ((GlobalLBMetricLimit [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_limit(GlobalLBVirtualServerID [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_limit", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public GlobalLBMetricLimit [] [] Endget_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBMetricLimit [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServerV2", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServerV2", ResponseNamespace="urn:iControl:GlobalLB/VirtualServerV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBVirtualServerID [] get_list(

	) {
		object [] results = this.Invoke("get_list", new object [0]);
		return ((GlobalLBVirtualServerID [])(results[0]));
	}
	public System.IAsyncResult Beginget_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_list", new object[0], callback, asyncState);
	}
	public GlobalLBVirtualServerID [] Endget_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBVirtualServerID [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ltm_virtual_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServerV2", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServerV2", ResponseNamespace="urn:iControl:GlobalLB/VirtualServerV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_ltm_virtual_server(
		GlobalLBVirtualServerID [] virtual_servers
	) {
		object [] results = this.Invoke("get_ltm_virtual_server", new object [] {
				virtual_servers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_ltm_virtual_server(GlobalLBVirtualServerID [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ltm_virtual_server", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public string [] Endget_ltm_virtual_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_monitor_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServerV2", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServerV2", ResponseNamespace="urn:iControl:GlobalLB/VirtualServerV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBMonitorRule [] get_monitor_rule(
		GlobalLBVirtualServerID [] virtual_servers
	) {
		object [] results = this.Invoke("get_monitor_rule", new object [] {
				virtual_servers});
		return ((GlobalLBMonitorRule [])(results[0]));
	}
	public System.IAsyncResult Beginget_monitor_rule(GlobalLBVirtualServerID [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_monitor_rule", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public GlobalLBMonitorRule [] Endget_monitor_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBMonitorRule [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_object_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServerV2", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServerV2", ResponseNamespace="urn:iControl:GlobalLB/VirtualServerV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonObjectStatus [] get_object_status(
		GlobalLBVirtualServerID [] virtual_servers
	) {
		object [] results = this.Invoke("get_object_status", new object [] {
				virtual_servers});
		return ((CommonObjectStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_object_status(GlobalLBVirtualServerID [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_object_status", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public CommonObjectStatus [] Endget_object_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonObjectStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_parent_link
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServerV2", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServerV2", ResponseNamespace="urn:iControl:GlobalLB/VirtualServerV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_parent_link(
		GlobalLBVirtualServerID [] virtual_servers
	) {
		object [] results = this.Invoke("get_parent_link", new object [] {
				virtual_servers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_parent_link(GlobalLBVirtualServerID [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_parent_link", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public string [] Endget_parent_link(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServerV2", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServerV2", ResponseNamespace="urn:iControl:GlobalLB/VirtualServerV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBVirtualServerV2VirtualServerStatistics get_statistics(
		GlobalLBVirtualServerID [] virtual_servers
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				virtual_servers});
		return ((GlobalLBVirtualServerV2VirtualServerStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(GlobalLBVirtualServerID [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public GlobalLBVirtualServerV2VirtualServerStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBVirtualServerV2VirtualServerStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_translation
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServerV2", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServerV2", ResponseNamespace="urn:iControl:GlobalLB/VirtualServerV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonIPPortDefinition [] get_translation(
		GlobalLBVirtualServerID [] virtual_servers
	) {
		object [] results = this.Invoke("get_translation", new object [] {
				virtual_servers});
		return ((CommonIPPortDefinition [])(results[0]));
	}
	public System.IAsyncResult Beginget_translation(GlobalLBVirtualServerID [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_translation", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public CommonIPPortDefinition [] Endget_translation(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonIPPortDefinition [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServerV2", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServerV2", ResponseNamespace="urn:iControl:GlobalLB/VirtualServerV2")]
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
	// remove_all_dependencies
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServerV2", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServerV2", ResponseNamespace="urn:iControl:GlobalLB/VirtualServerV2")]
	public void remove_all_dependencies(
		GlobalLBVirtualServerID [] virtual_servers
	) {
		this.Invoke("remove_all_dependencies", new object [] {
				virtual_servers});

	}
	public System.IAsyncResult Beginremove_all_dependencies(GlobalLBVirtualServerID [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_dependencies", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public void Endremove_all_dependencies(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_dependency
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServerV2", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServerV2", ResponseNamespace="urn:iControl:GlobalLB/VirtualServerV2")]
	public void remove_dependency(
		GlobalLBVirtualServerID [] virtual_servers,
		GlobalLBVirtualServerID [] [] dependencies
	) {
		this.Invoke("remove_dependency", new object [] {
				virtual_servers,
				dependencies});

	}
	public System.IAsyncResult Beginremove_dependency(GlobalLBVirtualServerID [] virtual_servers,GlobalLBVirtualServerID [] [] dependencies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_dependency", new object[] {
			virtual_servers,
			dependencies}, callback, asyncState);
	}
	public void Endremove_dependency(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServerV2", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServerV2", ResponseNamespace="urn:iControl:GlobalLB/VirtualServerV2")]
	public void reset_statistics(
		GlobalLBVirtualServerID [] virtual_servers
	) {
		this.Invoke("reset_statistics", new object [] {
				virtual_servers});

	}
	public System.IAsyncResult Beginreset_statistics(GlobalLBVirtualServerID [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public void Endreset_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServerV2", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServerV2", ResponseNamespace="urn:iControl:GlobalLB/VirtualServerV2")]
	public void set_description(
		GlobalLBVirtualServerID [] virtual_servers,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				virtual_servers,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(GlobalLBVirtualServerID [] virtual_servers,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			virtual_servers,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServerV2", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServerV2", ResponseNamespace="urn:iControl:GlobalLB/VirtualServerV2")]
	public void set_enabled_state(
		GlobalLBVirtualServerID [] virtual_servers,
		CommonEnabledState [] states
	) {
		this.Invoke("set_enabled_state", new object [] {
				virtual_servers,
				states});

	}
	public System.IAsyncResult Beginset_enabled_state(GlobalLBVirtualServerID [] virtual_servers,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_enabled_state", new object[] {
			virtual_servers,
			states}, callback, asyncState);
	}
	public void Endset_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_explicit_link
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServerV2", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServerV2", ResponseNamespace="urn:iControl:GlobalLB/VirtualServerV2")]
	public void set_explicit_link(
		GlobalLBVirtualServerID [] virtual_servers,
		string [] links
	) {
		this.Invoke("set_explicit_link", new object [] {
				virtual_servers,
				links});

	}
	public System.IAsyncResult Beginset_explicit_link(GlobalLBVirtualServerID [] virtual_servers,string [] links, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_explicit_link", new object[] {
			virtual_servers,
			links}, callback, asyncState);
	}
	public void Endset_explicit_link(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServerV2", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServerV2", ResponseNamespace="urn:iControl:GlobalLB/VirtualServerV2")]
	public void set_limit(
		GlobalLBVirtualServerID [] virtual_servers,
		GlobalLBMetricLimit [] [] limits
	) {
		this.Invoke("set_limit", new object [] {
				virtual_servers,
				limits});

	}
	public System.IAsyncResult Beginset_limit(GlobalLBVirtualServerID [] virtual_servers,GlobalLBMetricLimit [] [] limits, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_limit", new object[] {
			virtual_servers,
			limits}, callback, asyncState);
	}
	public void Endset_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ltm_virtual_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServerV2", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServerV2", ResponseNamespace="urn:iControl:GlobalLB/VirtualServerV2")]
	public void set_ltm_virtual_server(
		GlobalLBVirtualServerID [] virtual_servers,
		string [] ltm_virtual_servers
	) {
		this.Invoke("set_ltm_virtual_server", new object [] {
				virtual_servers,
				ltm_virtual_servers});

	}
	public System.IAsyncResult Beginset_ltm_virtual_server(GlobalLBVirtualServerID [] virtual_servers,string [] ltm_virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ltm_virtual_server", new object[] {
			virtual_servers,
			ltm_virtual_servers}, callback, asyncState);
	}
	public void Endset_ltm_virtual_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_monitor_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServerV2", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServerV2", ResponseNamespace="urn:iControl:GlobalLB/VirtualServerV2")]
	public void set_monitor_rule(
		GlobalLBVirtualServerID [] virtual_servers,
		GlobalLBMonitorRule [] rules
	) {
		this.Invoke("set_monitor_rule", new object [] {
				virtual_servers,
				rules});

	}
	public System.IAsyncResult Beginset_monitor_rule(GlobalLBVirtualServerID [] virtual_servers,GlobalLBMonitorRule [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_monitor_rule", new object[] {
			virtual_servers,
			rules}, callback, asyncState);
	}
	public void Endset_monitor_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_translation
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServerV2", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServerV2", ResponseNamespace="urn:iControl:GlobalLB/VirtualServerV2")]
	public void set_translation(
		GlobalLBVirtualServerID [] virtual_servers,
		CommonIPPortDefinition [] translations
	) {
		this.Invoke("set_translation", new object [] {
				virtual_servers,
				translations});

	}
	public System.IAsyncResult Beginset_translation(GlobalLBVirtualServerID [] virtual_servers,CommonIPPortDefinition [] translations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_translation", new object[] {
			virtual_servers,
			translations}, callback, asyncState);
	}
	public void Endset_translation(System.IAsyncResult asyncResult) {
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.VirtualServerV2.VirtualServerStatistics", Namespace = "urn:iControl")]
	public partial class GlobalLBVirtualServerV2VirtualServerStatistics
	{
		private CommonStatistic [] [] statisticsField;
		public CommonStatistic [] [] statistics
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
