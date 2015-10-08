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
	[System.Web.Services.WebServiceBindingAttribute(Name="GlobalLB.VirtualServerBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBVirtualServerDefinition))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBVirtualServerVirtualServerStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBVirtualServerVirtualServerMetricLimit))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBVirtualServerMonitorAssociation))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonObjectStatus))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonIPPortDefinition))]
	public partial class GlobalLBVirtualServer : iControlInterface {
		public GlobalLBVirtualServer() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_dependency
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServer", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServer", ResponseNamespace="urn:iControl:GlobalLB/VirtualServer")]
	public void add_dependency(
		GlobalLBVirtualServerDefinition [] virtual_servers,
		GlobalLBVirtualServerDefinition [] [] dependencies
	) {
		this.Invoke("add_dependency", new object [] {
				virtual_servers,
				dependencies});

	}
	public System.IAsyncResult Beginadd_dependency(GlobalLBVirtualServerDefinition [] virtual_servers,GlobalLBVirtualServerDefinition [] [] dependencies, System.AsyncCallback callback, object asyncState) {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServer", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServer", ResponseNamespace="urn:iControl:GlobalLB/VirtualServer")]
	public void create(
		GlobalLBVirtualServerDefinition [] virtual_servers,
		string [] servers
	) {
		this.Invoke("create", new object [] {
				virtual_servers,
				servers});

	}
	public System.IAsyncResult Begincreate(GlobalLBVirtualServerDefinition [] virtual_servers,string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			virtual_servers,
			servers}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_virtual_servers
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServer", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServer", ResponseNamespace="urn:iControl:GlobalLB/VirtualServer")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServer", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServer", ResponseNamespace="urn:iControl:GlobalLB/VirtualServer")]
	public void delete_virtual_server(
		GlobalLBVirtualServerDefinition [] virtual_servers
	) {
		this.Invoke("delete_virtual_server", new object [] {
				virtual_servers});

	}
	public System.IAsyncResult Begindelete_virtual_server(GlobalLBVirtualServerDefinition [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_virtual_server", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public void Enddelete_virtual_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServer", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServer", ResponseNamespace="urn:iControl:GlobalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBVirtualServerVirtualServerStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((GlobalLBVirtualServerVirtualServerStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public GlobalLBVirtualServerVirtualServerStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBVirtualServerVirtualServerStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dependency
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServer", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServer", ResponseNamespace="urn:iControl:GlobalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBVirtualServerDefinition [] [] get_dependency(
		GlobalLBVirtualServerDefinition [] virtual_servers
	) {
		object [] results = this.Invoke("get_dependency", new object [] {
				virtual_servers});
		return ((GlobalLBVirtualServerDefinition [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_dependency(GlobalLBVirtualServerDefinition [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dependency", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public GlobalLBVirtualServerDefinition [] [] Endget_dependency(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBVirtualServerDefinition [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServer", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServer", ResponseNamespace="urn:iControl:GlobalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_enabled_state(
		GlobalLBVirtualServerDefinition [] virtual_servers
	) {
		object [] results = this.Invoke("get_enabled_state", new object [] {
				virtual_servers});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_enabled_state(GlobalLBVirtualServerDefinition [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_enabled_state", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServer", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServer", ResponseNamespace="urn:iControl:GlobalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBVirtualServerVirtualServerMetricLimit [] get_limit(
		GlobalLBVirtualServerDefinition [] virtual_servers
	) {
		object [] results = this.Invoke("get_limit", new object [] {
				virtual_servers});
		return ((GlobalLBVirtualServerVirtualServerMetricLimit [])(results[0]));
	}
	public System.IAsyncResult Beginget_limit(GlobalLBVirtualServerDefinition [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_limit", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public GlobalLBVirtualServerVirtualServerMetricLimit [] Endget_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBVirtualServerVirtualServerMetricLimit [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServer", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServer", ResponseNamespace="urn:iControl:GlobalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBVirtualServerDefinition [] get_list(

	) {
		object [] results = this.Invoke("get_list", new object [0]);
		return ((GlobalLBVirtualServerDefinition [])(results[0]));
	}
	public System.IAsyncResult Beginget_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_list", new object[0], callback, asyncState);
	}
	public GlobalLBVirtualServerDefinition [] Endget_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBVirtualServerDefinition [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_monitor_association
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServer", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServer", ResponseNamespace="urn:iControl:GlobalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBVirtualServerMonitorAssociation [] get_monitor_association(
		GlobalLBVirtualServerDefinition [] virtual_servers
	) {
		object [] results = this.Invoke("get_monitor_association", new object [] {
				virtual_servers});
		return ((GlobalLBVirtualServerMonitorAssociation [])(results[0]));
	}
	public System.IAsyncResult Beginget_monitor_association(GlobalLBVirtualServerDefinition [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_monitor_association", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public GlobalLBVirtualServerMonitorAssociation [] Endget_monitor_association(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBVirtualServerMonitorAssociation [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_object_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServer", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServer", ResponseNamespace="urn:iControl:GlobalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonObjectStatus [] get_object_status(
		GlobalLBVirtualServerDefinition [] virtual_servers
	) {
		object [] results = this.Invoke("get_object_status", new object [] {
				virtual_servers});
		return ((CommonObjectStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_object_status(GlobalLBVirtualServerDefinition [] virtual_servers, System.AsyncCallback callback, object asyncState) {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServer", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServer", ResponseNamespace="urn:iControl:GlobalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_parent_link(
		GlobalLBVirtualServerDefinition [] virtual_servers
	) {
		object [] results = this.Invoke("get_parent_link", new object [] {
				virtual_servers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_parent_link(GlobalLBVirtualServerDefinition [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_parent_link", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public string [] Endget_parent_link(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServer", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServer", ResponseNamespace="urn:iControl:GlobalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_server(
		GlobalLBVirtualServerDefinition [] virtual_servers
	) {
		object [] results = this.Invoke("get_server", new object [] {
				virtual_servers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_server(GlobalLBVirtualServerDefinition [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_server", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public string [] Endget_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServer", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServer", ResponseNamespace="urn:iControl:GlobalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBVirtualServerVirtualServerStatistics get_statistics(
		GlobalLBVirtualServerDefinition [] virtual_servers
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				virtual_servers});
		return ((GlobalLBVirtualServerVirtualServerStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(GlobalLBVirtualServerDefinition [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public GlobalLBVirtualServerVirtualServerStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBVirtualServerVirtualServerStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_translation
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServer", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServer", ResponseNamespace="urn:iControl:GlobalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonIPPortDefinition [] get_translation(
		GlobalLBVirtualServerDefinition [] virtual_servers
	) {
		object [] results = this.Invoke("get_translation", new object [] {
				virtual_servers});
		return ((CommonIPPortDefinition [])(results[0]));
	}
	public System.IAsyncResult Beginget_translation(GlobalLBVirtualServerDefinition [] virtual_servers, System.AsyncCallback callback, object asyncState) {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServer", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServer", ResponseNamespace="urn:iControl:GlobalLB/VirtualServer")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServer", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServer", ResponseNamespace="urn:iControl:GlobalLB/VirtualServer")]
	public void remove_all_dependencies(
		GlobalLBVirtualServerDefinition [] virtual_servers
	) {
		this.Invoke("remove_all_dependencies", new object [] {
				virtual_servers});

	}
	public System.IAsyncResult Beginremove_all_dependencies(GlobalLBVirtualServerDefinition [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_dependencies", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public void Endremove_all_dependencies(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_dependency
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServer", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServer", ResponseNamespace="urn:iControl:GlobalLB/VirtualServer")]
	public void remove_dependency(
		GlobalLBVirtualServerDefinition [] virtual_servers,
		GlobalLBVirtualServerDefinition [] [] dependencies
	) {
		this.Invoke("remove_dependency", new object [] {
				virtual_servers,
				dependencies});

	}
	public System.IAsyncResult Beginremove_dependency(GlobalLBVirtualServerDefinition [] virtual_servers,GlobalLBVirtualServerDefinition [] [] dependencies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_dependency", new object[] {
			virtual_servers,
			dependencies}, callback, asyncState);
	}
	public void Endremove_dependency(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_monitor_association
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServer", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServer", ResponseNamespace="urn:iControl:GlobalLB/VirtualServer")]
	public void remove_monitor_association(
		GlobalLBVirtualServerDefinition [] virtual_servers
	) {
		this.Invoke("remove_monitor_association", new object [] {
				virtual_servers});

	}
	public System.IAsyncResult Beginremove_monitor_association(GlobalLBVirtualServerDefinition [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_monitor_association", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public void Endremove_monitor_association(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServer", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServer", ResponseNamespace="urn:iControl:GlobalLB/VirtualServer")]
	public void reset_statistics(
		GlobalLBVirtualServerDefinition [] virtual_servers
	) {
		this.Invoke("reset_statistics", new object [] {
				virtual_servers});

	}
	public System.IAsyncResult Beginreset_statistics(GlobalLBVirtualServerDefinition [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public void Endreset_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServer", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServer", ResponseNamespace="urn:iControl:GlobalLB/VirtualServer")]
	public void set_enabled_state(
		GlobalLBVirtualServerDefinition [] virtual_servers,
		CommonEnabledState [] states
	) {
		this.Invoke("set_enabled_state", new object [] {
				virtual_servers,
				states});

	}
	public System.IAsyncResult Beginset_enabled_state(GlobalLBVirtualServerDefinition [] virtual_servers,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_enabled_state", new object[] {
			virtual_servers,
			states}, callback, asyncState);
	}
	public void Endset_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServer", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServer", ResponseNamespace="urn:iControl:GlobalLB/VirtualServer")]
	public void set_limit(
		GlobalLBVirtualServerVirtualServerMetricLimit [] limits
	) {
		this.Invoke("set_limit", new object [] {
				limits});

	}
	public System.IAsyncResult Beginset_limit(GlobalLBVirtualServerVirtualServerMetricLimit [] limits, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_limit", new object[] {
			limits}, callback, asyncState);
	}
	public void Endset_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_monitor_association
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServer", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServer", ResponseNamespace="urn:iControl:GlobalLB/VirtualServer")]
	public void set_monitor_association(
		GlobalLBVirtualServerMonitorAssociation [] monitor_associations
	) {
		this.Invoke("set_monitor_association", new object [] {
				monitor_associations});

	}
	public System.IAsyncResult Beginset_monitor_association(GlobalLBVirtualServerMonitorAssociation [] monitor_associations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_monitor_association", new object[] {
			monitor_associations}, callback, asyncState);
	}
	public void Endset_monitor_association(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServer", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServer", ResponseNamespace="urn:iControl:GlobalLB/VirtualServer")]
	public void set_server(
		GlobalLBVirtualServerDefinition [] virtual_servers,
		string [] servers
	) {
		this.Invoke("set_server", new object [] {
				virtual_servers,
				servers});

	}
	public System.IAsyncResult Beginset_server(GlobalLBVirtualServerDefinition [] virtual_servers,string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_server", new object[] {
			virtual_servers,
			servers}, callback, asyncState);
	}
	public void Endset_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_translation
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/VirtualServer", 
		RequestNamespace="urn:iControl:GlobalLB/VirtualServer", ResponseNamespace="urn:iControl:GlobalLB/VirtualServer")]
	public void set_translation(
		GlobalLBVirtualServerDefinition [] virtual_servers,
		CommonIPPortDefinition [] translations
	) {
		this.Invoke("set_translation", new object [] {
				virtual_servers,
				translations});

	}
	public System.IAsyncResult Beginset_translation(GlobalLBVirtualServerDefinition [] virtual_servers,CommonIPPortDefinition [] translations, System.AsyncCallback callback, object asyncState) {
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.VirtualServer.MonitorAssociation", Namespace = "urn:iControl")]
	public partial class GlobalLBVirtualServerMonitorAssociation
	{
		private GlobalLBVirtualServerDefinition virtual_serverField;
		public GlobalLBVirtualServerDefinition virtual_server
		{
			get { return this.virtual_serverField; }
			set { this.virtual_serverField = value; }
		}
		private GlobalLBMonitorRule monitor_ruleField;
		public GlobalLBMonitorRule monitor_rule
		{
			get { return this.monitor_ruleField; }
			set { this.monitor_ruleField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.VirtualServer.VirtualServerMetricLimit", Namespace = "urn:iControl")]
	public partial class GlobalLBVirtualServerVirtualServerMetricLimit
	{
		private GlobalLBVirtualServerDefinition virtual_serverField;
		public GlobalLBVirtualServerDefinition virtual_server
		{
			get { return this.virtual_serverField; }
			set { this.virtual_serverField = value; }
		}
		private GlobalLBMetricLimit [] metric_limitsField;
		public GlobalLBMetricLimit [] metric_limits
		{
			get { return this.metric_limitsField; }
			set { this.metric_limitsField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.VirtualServer.VirtualServerStatisticEntry", Namespace = "urn:iControl")]
	public partial class GlobalLBVirtualServerVirtualServerStatisticEntry
	{
		private GlobalLBVirtualServerDefinition virtual_serverField;
		public GlobalLBVirtualServerDefinition virtual_server
		{
			get { return this.virtual_serverField; }
			set { this.virtual_serverField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.VirtualServer.VirtualServerStatistics", Namespace = "urn:iControl")]
	public partial class GlobalLBVirtualServerVirtualServerStatistics
	{
		private GlobalLBVirtualServerVirtualServerStatisticEntry [] statisticsField;
		public GlobalLBVirtualServerVirtualServerStatisticEntry [] statistics
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
