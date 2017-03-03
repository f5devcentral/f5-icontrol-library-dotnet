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
	[System.Web.Services.WebServiceBindingAttribute(Name="GlobalLB.ServerBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBServerDeviceDefinition))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBServerServerIPDefinition))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBServerServerIPs))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBServerDeviceStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBServerServerStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBServerServerMetricLimit))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBServerMonitorAssociation))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBMonitorRuleV2))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonObjectStatus))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(GlobalLBProberSelection))]
	public partial class GlobalLBServer : iControlInterface {
		public GlobalLBServer() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_device_ip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	public void add_device_ip(
		GlobalLBServerDeviceDefinition [] devices,
		string [] [] ips
	) {
		this.Invoke("add_device_ip", new object [] {
				devices,
				ips});

	}
	public System.IAsyncResult Beginadd_device_ip(GlobalLBServerDeviceDefinition [] devices,string [] [] ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_device_ip", new object[] {
			devices,
			ips}, callback, asyncState);
	}
	public void Endadd_device_ip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_ip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	public void add_ip(
		GlobalLBServerServerIPDefinition [] ips
	) {
		this.Invoke("add_ip", new object [] {
				ips});

	}
	public System.IAsyncResult Beginadd_ip(GlobalLBServerServerIPDefinition [] ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_ip", new object[] {
			ips}, callback, asyncState);
	}
	public void Endadd_ip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_ip_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	public void add_ip_v2(
		string [] servers,
		GlobalLBServerServerIPs [] [] ips
	) {
		this.Invoke("add_ip_v2", new object [] {
				servers,
				ips});

	}
	public System.IAsyncResult Beginadd_ip_v2(string [] servers,GlobalLBServerServerIPs [] [] ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_ip_v2", new object[] {
			servers,
			ips}, callback, asyncState);
	}
	public void Endadd_ip_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	public void add_metadata(
		string [] servers,
		string [] [] names,
		string [] [] values
	) {
		this.Invoke("add_metadata", new object [] {
				servers,
				names,
				values});

	}
	public System.IAsyncResult Beginadd_metadata(string [] servers,string [] [] names,string [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_metadata", new object[] {
			servers,
			names,
			values}, callback, asyncState);
	}
	public void Endadd_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	public void create(
		GlobalLBServerServerIPDefinition [] servers,
		GlobalLBServerType [] types,
		string [] data_centers
	) {
		this.Invoke("create", new object [] {
				servers,
				types,
				data_centers});

	}
	public System.IAsyncResult Begincreate(GlobalLBServerServerIPDefinition [] servers,GlobalLBServerType [] types,string [] data_centers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			servers,
			types,
			data_centers}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create_device
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	public void create_device(
		GlobalLBServerDeviceDefinition [] devices,
		string [] [] ips
	) {
		this.Invoke("create_device", new object [] {
				devices,
				ips});

	}
	public System.IAsyncResult Begincreate_device(GlobalLBServerDeviceDefinition [] devices,string [] [] ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_device", new object[] {
			devices,
			ips}, callback, asyncState);
	}
	public void Endcreate_device(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	public void create_v2(
		string [] servers,
		GlobalLBServerServerIPs [] [] ips,
		GlobalLBServerType [] types,
		string [] data_centers
	) {
		this.Invoke("create_v2", new object [] {
				servers,
				ips,
				types,
				data_centers});

	}
	public System.IAsyncResult Begincreate_v2(string [] servers,GlobalLBServerServerIPs [] [] ips,GlobalLBServerType [] types,string [] data_centers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_v2", new object[] {
			servers,
			ips,
			types,
			data_centers}, callback, asyncState);
	}
	public void Endcreate_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_servers
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	public void delete_all_servers(

	) {
		this.Invoke("delete_all_servers", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_servers(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_servers", new object[0], callback, asyncState);
	}
	public void Enddelete_all_servers(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_device
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	public void delete_device(
		GlobalLBServerDeviceDefinition [] devices
	) {
		this.Invoke("delete_device", new object [] {
				devices});

	}
	public System.IAsyncResult Begindelete_device(GlobalLBServerDeviceDefinition [] devices, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_device", new object[] {
			devices}, callback, asyncState);
	}
	public void Enddelete_device(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	public void delete_server(
		string [] servers
	) {
		this.Invoke("delete_server", new object [] {
				servers});

	}
	public System.IAsyncResult Begindelete_server(string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_server", new object[] {
			servers}, callback, asyncState);
	}
	public void Enddelete_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_all_device_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBServerDeviceStatistics get_all_device_statistics(

	) {
		object [] results = this.Invoke("get_all_device_statistics", new object [0]);
		return ((GlobalLBServerDeviceStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_device_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_device_statistics", new object[0], callback, asyncState);
	}
	public GlobalLBServerDeviceStatistics Endget_all_device_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBServerDeviceStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBServerServerStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((GlobalLBServerServerStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public GlobalLBServerServerStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBServerServerStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_allow_path_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_allow_path_state(
		string [] servers
	) {
		object [] results = this.Invoke("get_allow_path_state", new object [] {
				servers});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_allow_path_state(string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_allow_path_state", new object[] {
			servers}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_allow_path_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_allow_service_check_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_allow_service_check_state(
		string [] servers
	) {
		object [] results = this.Invoke("get_allow_service_check_state", new object [] {
				servers});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_allow_service_check_state(string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_allow_service_check_state", new object[] {
			servers}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_allow_service_check_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_allow_snmp_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_allow_snmp_state(
		string [] servers
	) {
		object [] results = this.Invoke("get_allow_snmp_state", new object [] {
				servers});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_allow_snmp_state(string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_allow_snmp_state", new object[] {
			servers}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_allow_snmp_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_auto_configuration_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBAutoConfigurationState [] get_auto_configuration_state(
		string [] servers
	) {
		object [] results = this.Invoke("get_auto_configuration_state", new object [] {
				servers});
		return ((GlobalLBAutoConfigurationState [])(results[0]));
	}
	public System.IAsyncResult Beginget_auto_configuration_state(string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_auto_configuration_state", new object[] {
			servers}, callback, asyncState);
	}
	public GlobalLBAutoConfigurationState [] Endget_auto_configuration_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBAutoConfigurationState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_data_center
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_data_center(
		string [] servers
	) {
		object [] results = this.Invoke("get_data_center", new object [] {
				servers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_data_center(string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_data_center", new object[] {
			servers}, callback, asyncState);
	}
	public string [] Endget_data_center(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] servers
	) {
		object [] results = this.Invoke("get_description", new object [] {
				servers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			servers}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_device_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_device_description(
		GlobalLBServerDeviceDefinition [] devices
	) {
		object [] results = this.Invoke("get_device_description", new object [] {
				devices});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_device_description(GlobalLBServerDeviceDefinition [] devices, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_device_description", new object[] {
			devices}, callback, asyncState);
	}
	public string [] Endget_device_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_device_ip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_device_ip(
		GlobalLBServerDeviceDefinition [] devices
	) {
		object [] results = this.Invoke("get_device_ip", new object [] {
				devices});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_device_ip(GlobalLBServerDeviceDefinition [] devices, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_device_ip", new object[] {
			devices}, callback, asyncState);
	}
	public string [] [] Endget_device_ip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_device_ip_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_device_ip_description(
		GlobalLBServerDeviceDefinition [] devices,
		string [] [] ips
	) {
		object [] results = this.Invoke("get_device_ip_description", new object [] {
				devices,
				ips});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_device_ip_description(GlobalLBServerDeviceDefinition [] devices,string [] [] ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_device_ip_description", new object[] {
			devices,
			ips}, callback, asyncState);
	}
	public string [] [] Endget_device_ip_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_device_ip_explicit_link
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_device_ip_explicit_link(
		GlobalLBServerDeviceDefinition [] devices,
		string [] [] ips
	) {
		object [] results = this.Invoke("get_device_ip_explicit_link", new object [] {
				devices,
				ips});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_device_ip_explicit_link(GlobalLBServerDeviceDefinition [] devices,string [] [] ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_device_ip_explicit_link", new object[] {
			devices,
			ips}, callback, asyncState);
	}
	public string [] [] Endget_device_ip_explicit_link(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_device_ip_translation
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_device_ip_translation(
		GlobalLBServerDeviceDefinition [] devices,
		string [] [] ips
	) {
		object [] results = this.Invoke("get_device_ip_translation", new object [] {
				devices,
				ips});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_device_ip_translation(GlobalLBServerDeviceDefinition [] devices,string [] [] ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_device_ip_translation", new object[] {
			devices,
			ips}, callback, asyncState);
	}
	public string [] [] Endget_device_ip_translation(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_device_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBServerDeviceDefinition [] get_device_list(

	) {
		object [] results = this.Invoke("get_device_list", new object [0]);
		return ((GlobalLBServerDeviceDefinition [])(results[0]));
	}
	public System.IAsyncResult Beginget_device_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_device_list", new object[0], callback, asyncState);
	}
	public GlobalLBServerDeviceDefinition [] Endget_device_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBServerDeviceDefinition [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_device_list_by_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBServerDeviceDefinition [] [] get_device_list_by_server(
		string [] servers
	) {
		object [] results = this.Invoke("get_device_list_by_server", new object [] {
				servers});
		return ((GlobalLBServerDeviceDefinition [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_device_list_by_server(string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_device_list_by_server", new object[] {
			servers}, callback, asyncState);
	}
	public GlobalLBServerDeviceDefinition [] [] Endget_device_list_by_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBServerDeviceDefinition [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_device_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBServerDeviceStatistics get_device_statistics(
		GlobalLBServerDeviceDefinition [] devices
	) {
		object [] results = this.Invoke("get_device_statistics", new object [] {
				devices});
		return ((GlobalLBServerDeviceStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_device_statistics(GlobalLBServerDeviceDefinition [] devices, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_device_statistics", new object[] {
			devices}, callback, asyncState);
	}
	public GlobalLBServerDeviceStatistics Endget_device_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBServerDeviceStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_enabled_state(
		string [] servers
	) {
		object [] results = this.Invoke("get_enabled_state", new object [] {
				servers});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_enabled_state(string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_enabled_state", new object[] {
			servers}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBServerServerIPDefinition [] get_ip(
		string [] servers
	) {
		object [] results = this.Invoke("get_ip", new object [] {
				servers});
		return ((GlobalLBServerServerIPDefinition [])(results[0]));
	}
	public System.IAsyncResult Beginget_ip(string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ip", new object[] {
			servers}, callback, asyncState);
	}
	public GlobalLBServerServerIPDefinition [] Endget_ip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBServerServerIPDefinition [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ip_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBServerServerIPs [] [] get_ip_v2(
		string [] servers
	) {
		object [] results = this.Invoke("get_ip_v2", new object [] {
				servers});
		return ((GlobalLBServerServerIPs [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_ip_v2(string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ip_v2", new object[] {
			servers}, callback, asyncState);
	}
	public GlobalLBServerServerIPs [] [] Endget_ip_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBServerServerIPs [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBServerServerMetricLimit [] get_limit(
		string [] servers
	) {
		object [] results = this.Invoke("get_limit", new object [] {
				servers});
		return ((GlobalLBServerServerMetricLimit [])(results[0]));
	}
	public System.IAsyncResult Beginget_limit(string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_limit", new object[] {
			servers}, callback, asyncState);
	}
	public GlobalLBServerServerMetricLimit [] Endget_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBServerServerMetricLimit [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_link_auto_configuration_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBAutoConfigurationState [] get_link_auto_configuration_state(
		string [] servers
	) {
		object [] results = this.Invoke("get_link_auto_configuration_state", new object [] {
				servers});
		return ((GlobalLBAutoConfigurationState [])(results[0]));
	}
	public System.IAsyncResult Beginget_link_auto_configuration_state(string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_link_auto_configuration_state", new object[] {
			servers}, callback, asyncState);
	}
	public GlobalLBAutoConfigurationState [] Endget_link_auto_configuration_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBAutoConfigurationState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_metadata(
		string [] servers
	) {
		object [] results = this.Invoke("get_metadata", new object [] {
				servers});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata(string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_metadata", new object[] {
			servers}, callback, asyncState);
	}
	public string [] [] Endget_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_metadata_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_metadata_description(
		string [] servers,
		string [] [] names
	) {
		object [] results = this.Invoke("get_metadata_description", new object [] {
				servers,
				names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata_description(string [] servers,string [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_metadata_description", new object[] {
			servers,
			names}, callback, asyncState);
	}
	public string [] [] Endget_metadata_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_metadata_persistence
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonMetadataPersistence [] [] get_metadata_persistence(
		string [] servers,
		string [] [] names
	) {
		object [] results = this.Invoke("get_metadata_persistence", new object [] {
				servers,
				names});
		return ((CommonMetadataPersistence [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata_persistence(string [] servers,string [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_metadata_persistence", new object[] {
			servers,
			names}, callback, asyncState);
	}
	public CommonMetadataPersistence [] [] Endget_metadata_persistence(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonMetadataPersistence [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_metadata_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_metadata_value(
		string [] servers,
		string [] [] names
	) {
		object [] results = this.Invoke("get_metadata_value", new object [] {
				servers,
				names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata_value(string [] servers,string [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_metadata_value", new object[] {
			servers,
			names}, callback, asyncState);
	}
	public string [] [] Endget_metadata_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_monitor_association
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBServerMonitorAssociation [] get_monitor_association(
		string [] server_names
	) {
		object [] results = this.Invoke("get_monitor_association", new object [] {
				server_names});
		return ((GlobalLBServerMonitorAssociation [])(results[0]));
	}
	public System.IAsyncResult Beginget_monitor_association(string [] server_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_monitor_association", new object[] {
			server_names}, callback, asyncState);
	}
	public GlobalLBServerMonitorAssociation [] Endget_monitor_association(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBServerMonitorAssociation [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_monitor_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBMonitorRuleV2 [] get_monitor_rule(
		string [] servers
	) {
		object [] results = this.Invoke("get_monitor_rule", new object [] {
				servers});
		return ((GlobalLBMonitorRuleV2 [])(results[0]));
	}
	public System.IAsyncResult Beginget_monitor_rule(string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_monitor_rule", new object[] {
			servers}, callback, asyncState);
	}
	public GlobalLBMonitorRuleV2 [] Endget_monitor_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBMonitorRuleV2 [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_object_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonObjectStatus [] get_object_status(
		string [] servers
	) {
		object [] results = this.Invoke("get_object_status", new object [] {
				servers});
		return ((CommonObjectStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_object_status(string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_object_status", new object[] {
			servers}, callback, asyncState);
	}
	public CommonObjectStatus [] Endget_object_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonObjectStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_prober_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_prober_address(
		string [] servers
	) {
		object [] results = this.Invoke("get_prober_address", new object [] {
				servers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_prober_address(string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_prober_address", new object[] {
			servers}, callback, asyncState);
	}
	public string [] Endget_prober_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_prober_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_prober_pool(
		string [] servers
	) {
		object [] results = this.Invoke("get_prober_pool", new object [] {
				servers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_prober_pool(string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_prober_pool", new object[] {
			servers}, callback, asyncState);
	}
	public string [] Endget_prober_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_prober_selection
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBProberSelection [] get_prober_selection(
		string [] servers
	) {
		object [] results = this.Invoke("get_prober_selection", new object [] {
				servers});
		return ((GlobalLBProberSelection [])(results[0]));
	}
	public System.IAsyncResult Beginget_prober_selection(string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_prober_selection", new object[] {
			servers}, callback, asyncState);
	}
	public GlobalLBProberSelection [] Endget_prober_selection(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBProberSelection [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_server_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBServerType [] get_server_type(
		string [] servers
	) {
		object [] results = this.Invoke("get_server_type", new object [] {
				servers});
		return ((GlobalLBServerType [])(results[0]));
	}
	public System.IAsyncResult Beginget_server_type(string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_server_type", new object[] {
			servers}, callback, asyncState);
	}
	public GlobalLBServerType [] Endget_server_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBServerType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_server_type_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBServerType [] get_server_type_v2(
		string [] servers
	) {
		object [] results = this.Invoke("get_server_type_v2", new object [] {
				servers});
		return ((GlobalLBServerType [])(results[0]));
	}
	public System.IAsyncResult Beginget_server_type_v2(string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_server_type_v2", new object[] {
			servers}, callback, asyncState);
	}
	public GlobalLBServerType [] Endget_server_type_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBServerType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBServerServerStatistics get_statistics(
		string [] server_names
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				server_names});
		return ((GlobalLBServerServerStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] server_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			server_names}, callback, asyncState);
	}
	public GlobalLBServerServerStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBServerServerStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
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
	// remove_all_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	public void remove_all_metadata(
		string [] servers
	) {
		this.Invoke("remove_all_metadata", new object [] {
				servers});

	}
	public System.IAsyncResult Beginremove_all_metadata(string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_metadata", new object[] {
			servers}, callback, asyncState);
	}
	public void Endremove_all_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_device_ip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	public void remove_device_ip(
		GlobalLBServerDeviceDefinition [] devices,
		string [] [] ips
	) {
		this.Invoke("remove_device_ip", new object [] {
				devices,
				ips});

	}
	public System.IAsyncResult Beginremove_device_ip(GlobalLBServerDeviceDefinition [] devices,string [] [] ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_device_ip", new object[] {
			devices,
			ips}, callback, asyncState);
	}
	public void Endremove_device_ip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_ip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	public void remove_ip(
		GlobalLBServerServerIPDefinition [] ips
	) {
		this.Invoke("remove_ip", new object [] {
				ips});

	}
	public System.IAsyncResult Beginremove_ip(GlobalLBServerServerIPDefinition [] ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_ip", new object[] {
			ips}, callback, asyncState);
	}
	public void Endremove_ip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_ip_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	public void remove_ip_v2(
		string [] servers,
		GlobalLBServerServerIPs [] [] ips
	) {
		this.Invoke("remove_ip_v2", new object [] {
				servers,
				ips});

	}
	public System.IAsyncResult Beginremove_ip_v2(string [] servers,GlobalLBServerServerIPs [] [] ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_ip_v2", new object[] {
			servers,
			ips}, callback, asyncState);
	}
	public void Endremove_ip_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	public void remove_metadata(
		string [] servers,
		string [] [] names
	) {
		this.Invoke("remove_metadata", new object [] {
				servers,
				names});

	}
	public System.IAsyncResult Beginremove_metadata(string [] servers,string [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_metadata", new object[] {
			servers,
			names}, callback, asyncState);
	}
	public void Endremove_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_monitor_association
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	public void remove_monitor_association(
		string [] server_names
	) {
		this.Invoke("remove_monitor_association", new object [] {
				server_names});

	}
	public System.IAsyncResult Beginremove_monitor_association(string [] server_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_monitor_association", new object[] {
			server_names}, callback, asyncState);
	}
	public void Endremove_monitor_association(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_monitor_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	public void remove_monitor_rule(
		string [] servers
	) {
		this.Invoke("remove_monitor_rule", new object [] {
				servers});

	}
	public System.IAsyncResult Beginremove_monitor_rule(string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_monitor_rule", new object[] {
			servers}, callback, asyncState);
	}
	public void Endremove_monitor_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_device_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	public void reset_device_statistics(
		GlobalLBServerDeviceDefinition [] devices
	) {
		this.Invoke("reset_device_statistics", new object [] {
				devices});

	}
	public System.IAsyncResult Beginreset_device_statistics(GlobalLBServerDeviceDefinition [] devices, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_device_statistics", new object[] {
			devices}, callback, asyncState);
	}
	public void Endreset_device_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	public void reset_statistics(
		string [] server_names
	) {
		this.Invoke("reset_statistics", new object [] {
				server_names});

	}
	public System.IAsyncResult Beginreset_statistics(string [] server_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics", new object[] {
			server_names}, callback, asyncState);
	}
	public void Endreset_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_allow_path_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	public void set_allow_path_state(
		string [] servers,
		CommonEnabledState [] states
	) {
		this.Invoke("set_allow_path_state", new object [] {
				servers,
				states});

	}
	public System.IAsyncResult Beginset_allow_path_state(string [] servers,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_allow_path_state", new object[] {
			servers,
			states}, callback, asyncState);
	}
	public void Endset_allow_path_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_allow_service_check_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	public void set_allow_service_check_state(
		string [] servers,
		CommonEnabledState [] states
	) {
		this.Invoke("set_allow_service_check_state", new object [] {
				servers,
				states});

	}
	public System.IAsyncResult Beginset_allow_service_check_state(string [] servers,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_allow_service_check_state", new object[] {
			servers,
			states}, callback, asyncState);
	}
	public void Endset_allow_service_check_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_allow_snmp_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	public void set_allow_snmp_state(
		string [] servers,
		CommonEnabledState [] states
	) {
		this.Invoke("set_allow_snmp_state", new object [] {
				servers,
				states});

	}
	public System.IAsyncResult Beginset_allow_snmp_state(string [] servers,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_allow_snmp_state", new object[] {
			servers,
			states}, callback, asyncState);
	}
	public void Endset_allow_snmp_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_auto_configuration_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	public void set_auto_configuration_state(
		string [] servers,
		GlobalLBAutoConfigurationState [] states
	) {
		this.Invoke("set_auto_configuration_state", new object [] {
				servers,
				states});

	}
	public System.IAsyncResult Beginset_auto_configuration_state(string [] servers,GlobalLBAutoConfigurationState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_auto_configuration_state", new object[] {
			servers,
			states}, callback, asyncState);
	}
	public void Endset_auto_configuration_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_data_center
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	public void set_data_center(
		string [] servers,
		string [] data_centers
	) {
		this.Invoke("set_data_center", new object [] {
				servers,
				data_centers});

	}
	public System.IAsyncResult Beginset_data_center(string [] servers,string [] data_centers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_data_center", new object[] {
			servers,
			data_centers}, callback, asyncState);
	}
	public void Endset_data_center(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	public void set_description(
		string [] servers,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				servers,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] servers,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			servers,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_device_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	public void set_device_description(
		GlobalLBServerDeviceDefinition [] devices,
		string [] descriptions
	) {
		this.Invoke("set_device_description", new object [] {
				devices,
				descriptions});

	}
	public System.IAsyncResult Beginset_device_description(GlobalLBServerDeviceDefinition [] devices,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_device_description", new object[] {
			devices,
			descriptions}, callback, asyncState);
	}
	public void Endset_device_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_device_ip_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	public void set_device_ip_description(
		GlobalLBServerDeviceDefinition [] devices,
		string [] [] ips,
		string [] [] descriptions
	) {
		this.Invoke("set_device_ip_description", new object [] {
				devices,
				ips,
				descriptions});

	}
	public System.IAsyncResult Beginset_device_ip_description(GlobalLBServerDeviceDefinition [] devices,string [] [] ips,string [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_device_ip_description", new object[] {
			devices,
			ips,
			descriptions}, callback, asyncState);
	}
	public void Endset_device_ip_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_device_ip_explicit_link
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	public void set_device_ip_explicit_link(
		GlobalLBServerDeviceDefinition [] devices,
		string [] [] ips,
		string [] [] links
	) {
		this.Invoke("set_device_ip_explicit_link", new object [] {
				devices,
				ips,
				links});

	}
	public System.IAsyncResult Beginset_device_ip_explicit_link(GlobalLBServerDeviceDefinition [] devices,string [] [] ips,string [] [] links, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_device_ip_explicit_link", new object[] {
			devices,
			ips,
			links}, callback, asyncState);
	}
	public void Endset_device_ip_explicit_link(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_device_ip_translation
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	public void set_device_ip_translation(
		GlobalLBServerDeviceDefinition [] devices,
		string [] [] ips,
		string [] [] translations
	) {
		this.Invoke("set_device_ip_translation", new object [] {
				devices,
				ips,
				translations});

	}
	public System.IAsyncResult Beginset_device_ip_translation(GlobalLBServerDeviceDefinition [] devices,string [] [] ips,string [] [] translations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_device_ip_translation", new object[] {
			devices,
			ips,
			translations}, callback, asyncState);
	}
	public void Endset_device_ip_translation(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	public void set_enabled_state(
		string [] servers,
		CommonEnabledState [] states
	) {
		this.Invoke("set_enabled_state", new object [] {
				servers,
				states});

	}
	public System.IAsyncResult Beginset_enabled_state(string [] servers,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_enabled_state", new object[] {
			servers,
			states}, callback, asyncState);
	}
	public void Endset_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	public void set_limit(
		GlobalLBServerServerMetricLimit [] limits
	) {
		this.Invoke("set_limit", new object [] {
				limits});

	}
	public System.IAsyncResult Beginset_limit(GlobalLBServerServerMetricLimit [] limits, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_limit", new object[] {
			limits}, callback, asyncState);
	}
	public void Endset_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_link_auto_configuration_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	public void set_link_auto_configuration_state(
		string [] servers,
		GlobalLBAutoConfigurationState [] states
	) {
		this.Invoke("set_link_auto_configuration_state", new object [] {
				servers,
				states});

	}
	public System.IAsyncResult Beginset_link_auto_configuration_state(string [] servers,GlobalLBAutoConfigurationState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_link_auto_configuration_state", new object[] {
			servers,
			states}, callback, asyncState);
	}
	public void Endset_link_auto_configuration_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_metadata_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	public void set_metadata_description(
		string [] servers,
		string [] [] names,
		string [] [] descriptions
	) {
		this.Invoke("set_metadata_description", new object [] {
				servers,
				names,
				descriptions});

	}
	public System.IAsyncResult Beginset_metadata_description(string [] servers,string [] [] names,string [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_metadata_description", new object[] {
			servers,
			names,
			descriptions}, callback, asyncState);
	}
	public void Endset_metadata_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_metadata_persistence
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	public void set_metadata_persistence(
		string [] servers,
		string [] [] names,
		CommonMetadataPersistence [] [] values
	) {
		this.Invoke("set_metadata_persistence", new object [] {
				servers,
				names,
				values});

	}
	public System.IAsyncResult Beginset_metadata_persistence(string [] servers,string [] [] names,CommonMetadataPersistence [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_metadata_persistence", new object[] {
			servers,
			names,
			values}, callback, asyncState);
	}
	public void Endset_metadata_persistence(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_metadata_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	public void set_metadata_value(
		string [] servers,
		string [] [] names,
		string [] [] values
	) {
		this.Invoke("set_metadata_value", new object [] {
				servers,
				names,
				values});

	}
	public System.IAsyncResult Beginset_metadata_value(string [] servers,string [] [] names,string [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_metadata_value", new object[] {
			servers,
			names,
			values}, callback, asyncState);
	}
	public void Endset_metadata_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_monitor_association
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	public void set_monitor_association(
		GlobalLBServerMonitorAssociation [] monitor_associations
	) {
		this.Invoke("set_monitor_association", new object [] {
				monitor_associations});

	}
	public System.IAsyncResult Beginset_monitor_association(GlobalLBServerMonitorAssociation [] monitor_associations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_monitor_association", new object[] {
			monitor_associations}, callback, asyncState);
	}
	public void Endset_monitor_association(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_monitor_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	public void set_monitor_rule(
		string [] servers,
		GlobalLBMonitorRuleV2 [] monitor_rules
	) {
		this.Invoke("set_monitor_rule", new object [] {
				servers,
				monitor_rules});

	}
	public System.IAsyncResult Beginset_monitor_rule(string [] servers,GlobalLBMonitorRuleV2 [] monitor_rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_monitor_rule", new object[] {
			servers,
			monitor_rules}, callback, asyncState);
	}
	public void Endset_monitor_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_prober_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	public void set_prober_address(
		string [] servers,
		string [] addresses
	) {
		this.Invoke("set_prober_address", new object [] {
				servers,
				addresses});

	}
	public System.IAsyncResult Beginset_prober_address(string [] servers,string [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_prober_address", new object[] {
			servers,
			addresses}, callback, asyncState);
	}
	public void Endset_prober_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_prober_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	public void set_prober_pool(
		string [] servers,
		string [] pools
	) {
		this.Invoke("set_prober_pool", new object [] {
				servers,
				pools});

	}
	public System.IAsyncResult Beginset_prober_pool(string [] servers,string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_prober_pool", new object[] {
			servers,
			pools}, callback, asyncState);
	}
	public void Endset_prober_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_prober_selection
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	public void set_prober_selection(
		string [] servers,
		GlobalLBProberSelection [] prober_selections
	) {
		this.Invoke("set_prober_selection", new object [] {
				servers,
				prober_selections});

	}
	public System.IAsyncResult Beginset_prober_selection(string [] servers,GlobalLBProberSelection [] prober_selections, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_prober_selection", new object[] {
			servers,
			prober_selections}, callback, asyncState);
	}
	public void Endset_prober_selection(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_server_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/Server", 
		RequestNamespace="urn:iControl:GlobalLB/Server", ResponseNamespace="urn:iControl:GlobalLB/Server")]
	public void set_server_type(
		string [] servers,
		GlobalLBServerType [] types
	) {
		this.Invoke("set_server_type", new object [] {
				servers,
				types});

	}
	public System.IAsyncResult Beginset_server_type(string [] servers,GlobalLBServerType [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_server_type", new object[] {
			servers,
			types}, callback, asyncState);
	}
	public void Endset_server_type(System.IAsyncResult asyncResult) {
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.Server.DeviceDefinition", Namespace = "urn:iControl")]
	public partial class GlobalLBServerDeviceDefinition
	{
		private string serverField;
		public string server
		{
			get { return this.serverField; }
			set { this.serverField = value; }
		}
		private string deviceField;
		public string device
		{
			get { return this.deviceField; }
			set { this.deviceField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.Server.DeviceStatisticEntry", Namespace = "urn:iControl")]
	public partial class GlobalLBServerDeviceStatisticEntry
	{
		private GlobalLBServerDeviceDefinition deviceField;
		public GlobalLBServerDeviceDefinition device
		{
			get { return this.deviceField; }
			set { this.deviceField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.Server.DeviceStatistics", Namespace = "urn:iControl")]
	public partial class GlobalLBServerDeviceStatistics
	{
		private GlobalLBServerDeviceStatisticEntry [] statisticsField;
		public GlobalLBServerDeviceStatisticEntry [] statistics
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.Server.MonitorAssociation", Namespace = "urn:iControl")]
	public partial class GlobalLBServerMonitorAssociation
	{
		private string server_nameField;
		public string server_name
		{
			get { return this.server_nameField; }
			set { this.server_nameField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.Server.ServerIPDefinition", Namespace = "urn:iControl")]
	public partial class GlobalLBServerServerIPDefinition
	{
		private string serverField;
		public string server
		{
			get { return this.serverField; }
			set { this.serverField = value; }
		}
		private GlobalLBServerServerIPsForUnitID [] addressesField;
		public GlobalLBServerServerIPsForUnitID [] addresses
		{
			get { return this.addressesField; }
			set { this.addressesField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.Server.ServerIPs", Namespace = "urn:iControl")]
	public partial class GlobalLBServerServerIPs
	{
		private string deviceField;
		public string device
		{
			get { return this.deviceField; }
			set { this.deviceField = value; }
		}
		private string [] addresses_on_deviceField;
		public string [] addresses_on_device
		{
			get { return this.addresses_on_deviceField; }
			set { this.addresses_on_deviceField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.Server.ServerIPsForUnitID", Namespace = "urn:iControl")]
	public partial class GlobalLBServerServerIPsForUnitID
	{
		private long unit_idField;
		public long unit_id
		{
			get { return this.unit_idField; }
			set { this.unit_idField = value; }
		}
		private string [] addresses_on_unitField;
		public string [] addresses_on_unit
		{
			get { return this.addresses_on_unitField; }
			set { this.addresses_on_unitField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.Server.ServerMetricLimit", Namespace = "urn:iControl")]
	public partial class GlobalLBServerServerMetricLimit
	{
		private string server_nameField;
		public string server_name
		{
			get { return this.server_nameField; }
			set { this.server_nameField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.Server.ServerStatisticEntry", Namespace = "urn:iControl")]
	public partial class GlobalLBServerServerStatisticEntry
	{
		private string server_nameField;
		public string server_name
		{
			get { return this.server_nameField; }
			set { this.server_nameField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.Server.ServerStatistics", Namespace = "urn:iControl")]
	public partial class GlobalLBServerServerStatistics
	{
		private GlobalLBServerServerStatisticEntry [] statisticsField;
		public GlobalLBServerServerStatisticEntry [] statistics
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
