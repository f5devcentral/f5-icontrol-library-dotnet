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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.DNSZoneBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBDNSZoneDNSZoneStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBDNSZoneDNSExpressZoneDBStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonObjectStatus))]
	public partial class LocalLBDNSZone : iControlInterface {
		public LocalLBDNSZone() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_transfer_client
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSZone", 
		RequestNamespace="urn:iControl:LocalLB/DNSZone", ResponseNamespace="urn:iControl:LocalLB/DNSZone")]
	public void add_transfer_client(
		string [] zones,
		string [] [] servers
	) {
		this.Invoke("add_transfer_client", new object [] {
				zones,
				servers});

	}
	public System.IAsyncResult Beginadd_transfer_client(string [] zones,string [] [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_transfer_client", new object[] {
			zones,
			servers}, callback, asyncState);
	}
	public void Endadd_transfer_client(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSZone", 
		RequestNamespace="urn:iControl:LocalLB/DNSZone", ResponseNamespace="urn:iControl:LocalLB/DNSZone")]
	public void create(
		string [] zones
	) {
		this.Invoke("create", new object [] {
				zones});

	}
	public System.IAsyncResult Begincreate(string [] zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			zones}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_zones
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSZone", 
		RequestNamespace="urn:iControl:LocalLB/DNSZone", ResponseNamespace="urn:iControl:LocalLB/DNSZone")]
	public void delete_all_zones(

	) {
		this.Invoke("delete_all_zones", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_zones(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_zones", new object[0], callback, asyncState);
	}
	public void Enddelete_all_zones(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_zone
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSZone", 
		RequestNamespace="urn:iControl:LocalLB/DNSZone", ResponseNamespace="urn:iControl:LocalLB/DNSZone")]
	public void delete_zone(
		string [] zones
	) {
		this.Invoke("delete_zone", new object [] {
				zones});

	}
	public System.IAsyncResult Begindelete_zone(string [] zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_zone", new object[] {
			zones}, callback, asyncState);
	}
	public void Enddelete_zone(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSZone", 
		RequestNamespace="urn:iControl:LocalLB/DNSZone", ResponseNamespace="urn:iControl:LocalLB/DNSZone")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBDNSZoneDNSZoneStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((LocalLBDNSZoneDNSZoneStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public LocalLBDNSZoneDNSZoneStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBDNSZoneDNSZoneStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dns_express_notify_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSZone", 
		RequestNamespace="urn:iControl:LocalLB/DNSZone", ResponseNamespace="urn:iControl:LocalLB/DNSZone")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBDNSZoneNOTIFYAction [] get_dns_express_notify_action(
		string [] zones
	) {
		object [] results = this.Invoke("get_dns_express_notify_action", new object [] {
				zones});
		return ((LocalLBDNSZoneNOTIFYAction [])(results[0]));
	}
	public System.IAsyncResult Beginget_dns_express_notify_action(string [] zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dns_express_notify_action", new object[] {
			zones}, callback, asyncState);
	}
	public LocalLBDNSZoneNOTIFYAction [] Endget_dns_express_notify_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBDNSZoneNOTIFYAction [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dns_express_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSZone", 
		RequestNamespace="urn:iControl:LocalLB/DNSZone", ResponseNamespace="urn:iControl:LocalLB/DNSZone")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_dns_express_server(
		string [] zones
	) {
		object [] results = this.Invoke("get_dns_express_server", new object [] {
				zones});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_dns_express_server(string [] zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dns_express_server", new object[] {
			zones}, callback, asyncState);
	}
	public string [] Endget_dns_express_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dns_express_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSZone", 
		RequestNamespace="urn:iControl:LocalLB/DNSZone", ResponseNamespace="urn:iControl:LocalLB/DNSZone")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_dns_express_state(
		string [] zones
	) {
		object [] results = this.Invoke("get_dns_express_state", new object [] {
				zones});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_dns_express_state(string [] zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dns_express_state", new object[] {
			zones}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_dns_express_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dns_express_verify_notify_tsig_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSZone", 
		RequestNamespace="urn:iControl:LocalLB/DNSZone", ResponseNamespace="urn:iControl:LocalLB/DNSZone")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_dns_express_verify_notify_tsig_state(
		string [] zones
	) {
		object [] results = this.Invoke("get_dns_express_verify_notify_tsig_state", new object [] {
				zones});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_dns_express_verify_notify_tsig_state(string [] zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dns_express_verify_notify_tsig_state", new object[] {
			zones}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_dns_express_verify_notify_tsig_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dns_express_zone_db_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSZone", 
		RequestNamespace="urn:iControl:LocalLB/DNSZone", ResponseNamespace="urn:iControl:LocalLB/DNSZone")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBDNSZoneDNSExpressZoneDBStatistics get_dns_express_zone_db_statistics(
		string [] zones,
		long [] sizes
	) {
		object [] results = this.Invoke("get_dns_express_zone_db_statistics", new object [] {
				zones,
				sizes});
		return ((LocalLBDNSZoneDNSExpressZoneDBStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_dns_express_zone_db_statistics(string [] zones,long [] sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dns_express_zone_db_statistics", new object[] {
			zones,
			sizes}, callback, asyncState);
	}
	public LocalLBDNSZoneDNSExpressZoneDBStatistics Endget_dns_express_zone_db_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBDNSZoneDNSExpressZoneDBStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSZone", 
		RequestNamespace="urn:iControl:LocalLB/DNSZone", ResponseNamespace="urn:iControl:LocalLB/DNSZone")]
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
	// get_object_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSZone", 
		RequestNamespace="urn:iControl:LocalLB/DNSZone", ResponseNamespace="urn:iControl:LocalLB/DNSZone")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonObjectStatus [] get_object_status(
		string [] zones
	) {
		object [] results = this.Invoke("get_object_status", new object [] {
				zones});
		return ((CommonObjectStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_object_status(string [] zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_object_status", new object[] {
			zones}, callback, asyncState);
	}
	public CommonObjectStatus [] Endget_object_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonObjectStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_response_policy_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSZone", 
		RequestNamespace="urn:iControl:LocalLB/DNSZone", ResponseNamespace="urn:iControl:LocalLB/DNSZone")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_response_policy_state(
		string [] zones
	) {
		object [] results = this.Invoke("get_response_policy_state", new object [] {
				zones});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_response_policy_state(string [] zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_response_policy_state", new object[] {
			zones}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_response_policy_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_server_tsig_key
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSZone", 
		RequestNamespace="urn:iControl:LocalLB/DNSZone", ResponseNamespace="urn:iControl:LocalLB/DNSZone")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_server_tsig_key(
		string [] zones
	) {
		object [] results = this.Invoke("get_server_tsig_key", new object [] {
				zones});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_server_tsig_key(string [] zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_server_tsig_key", new object[] {
			zones}, callback, asyncState);
	}
	public string [] Endget_server_tsig_key(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSZone", 
		RequestNamespace="urn:iControl:LocalLB/DNSZone", ResponseNamespace="urn:iControl:LocalLB/DNSZone")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBDNSZoneDNSZoneStatistics get_statistics(
		string [] zones
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				zones});
		return ((LocalLBDNSZoneDNSZoneStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			zones}, callback, asyncState);
	}
	public LocalLBDNSZoneDNSZoneStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBDNSZoneDNSZoneStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_transfer_client
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSZone", 
		RequestNamespace="urn:iControl:LocalLB/DNSZone", ResponseNamespace="urn:iControl:LocalLB/DNSZone")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_transfer_client(
		string [] zones
	) {
		object [] results = this.Invoke("get_transfer_client", new object [] {
				zones});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_transfer_client(string [] zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_transfer_client", new object[] {
			zones}, callback, asyncState);
	}
	public string [] [] Endget_transfer_client(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSZone", 
		RequestNamespace="urn:iControl:LocalLB/DNSZone", ResponseNamespace="urn:iControl:LocalLB/DNSZone")]
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
	// remove_all_transfer_clients
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSZone", 
		RequestNamespace="urn:iControl:LocalLB/DNSZone", ResponseNamespace="urn:iControl:LocalLB/DNSZone")]
	public void remove_all_transfer_clients(
		string [] zones
	) {
		this.Invoke("remove_all_transfer_clients", new object [] {
				zones});

	}
	public System.IAsyncResult Beginremove_all_transfer_clients(string [] zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_transfer_clients", new object[] {
			zones}, callback, asyncState);
	}
	public void Endremove_all_transfer_clients(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_transfer_client
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSZone", 
		RequestNamespace="urn:iControl:LocalLB/DNSZone", ResponseNamespace="urn:iControl:LocalLB/DNSZone")]
	public void remove_transfer_client(
		string [] zones,
		string [] [] servers
	) {
		this.Invoke("remove_transfer_client", new object [] {
				zones,
				servers});

	}
	public System.IAsyncResult Beginremove_transfer_client(string [] zones,string [] [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_transfer_client", new object[] {
			zones,
			servers}, callback, asyncState);
	}
	public void Endremove_transfer_client(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSZone", 
		RequestNamespace="urn:iControl:LocalLB/DNSZone", ResponseNamespace="urn:iControl:LocalLB/DNSZone")]
	public void reset_statistics(
		string [] zones
	) {
		this.Invoke("reset_statistics", new object [] {
				zones});

	}
	public System.IAsyncResult Beginreset_statistics(string [] zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics", new object[] {
			zones}, callback, asyncState);
	}
	public void Endreset_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dns_express_notify_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSZone", 
		RequestNamespace="urn:iControl:LocalLB/DNSZone", ResponseNamespace="urn:iControl:LocalLB/DNSZone")]
	public void set_dns_express_notify_action(
		string [] zones,
		LocalLBDNSZoneNOTIFYAction [] actions
	) {
		this.Invoke("set_dns_express_notify_action", new object [] {
				zones,
				actions});

	}
	public System.IAsyncResult Beginset_dns_express_notify_action(string [] zones,LocalLBDNSZoneNOTIFYAction [] actions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dns_express_notify_action", new object[] {
			zones,
			actions}, callback, asyncState);
	}
	public void Endset_dns_express_notify_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dns_express_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSZone", 
		RequestNamespace="urn:iControl:LocalLB/DNSZone", ResponseNamespace="urn:iControl:LocalLB/DNSZone")]
	public void set_dns_express_server(
		string [] zones,
		string [] servers
	) {
		this.Invoke("set_dns_express_server", new object [] {
				zones,
				servers});

	}
	public System.IAsyncResult Beginset_dns_express_server(string [] zones,string [] servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dns_express_server", new object[] {
			zones,
			servers}, callback, asyncState);
	}
	public void Endset_dns_express_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dns_express_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSZone", 
		RequestNamespace="urn:iControl:LocalLB/DNSZone", ResponseNamespace="urn:iControl:LocalLB/DNSZone")]
	public void set_dns_express_state(
		string [] zones,
		CommonEnabledState [] states
	) {
		this.Invoke("set_dns_express_state", new object [] {
				zones,
				states});

	}
	public System.IAsyncResult Beginset_dns_express_state(string [] zones,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dns_express_state", new object[] {
			zones,
			states}, callback, asyncState);
	}
	public void Endset_dns_express_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dns_express_verify_notify_tsig_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSZone", 
		RequestNamespace="urn:iControl:LocalLB/DNSZone", ResponseNamespace="urn:iControl:LocalLB/DNSZone")]
	public void set_dns_express_verify_notify_tsig_state(
		string [] zones,
		CommonEnabledState [] states
	) {
		this.Invoke("set_dns_express_verify_notify_tsig_state", new object [] {
				zones,
				states});

	}
	public System.IAsyncResult Beginset_dns_express_verify_notify_tsig_state(string [] zones,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dns_express_verify_notify_tsig_state", new object[] {
			zones,
			states}, callback, asyncState);
	}
	public void Endset_dns_express_verify_notify_tsig_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_response_policy_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSZone", 
		RequestNamespace="urn:iControl:LocalLB/DNSZone", ResponseNamespace="urn:iControl:LocalLB/DNSZone")]
	public void set_response_policy_state(
		string [] zones,
		CommonEnabledState [] states
	) {
		this.Invoke("set_response_policy_state", new object [] {
				zones,
				states});

	}
	public System.IAsyncResult Beginset_response_policy_state(string [] zones,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_response_policy_state", new object[] {
			zones,
			states}, callback, asyncState);
	}
	public void Endset_response_policy_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_server_tsig_key
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSZone", 
		RequestNamespace="urn:iControl:LocalLB/DNSZone", ResponseNamespace="urn:iControl:LocalLB/DNSZone")]
	public void set_server_tsig_key(
		string [] zones,
		string [] keys
	) {
		this.Invoke("set_server_tsig_key", new object [] {
				zones,
				keys});

	}
	public System.IAsyncResult Beginset_server_tsig_key(string [] zones,string [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_server_tsig_key", new object[] {
			zones,
			keys}, callback, asyncState);
	}
	public void Endset_server_tsig_key(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.DNSZone.NOTIFYAction", Namespace = "urn:iControl")]
	public enum LocalLBDNSZoneNOTIFYAction
	{
		DNS_EXPRESS_NOTIFY_ACTION_UNKNOWN,
		DNS_EXPRESS_NOTIFY_ACTION_CONSUME,
		DNS_EXPRESS_NOTIFY_ACTION_BYPASS,
		DNS_EXPRESS_NOTIFY_ACTION_REPEAT,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.DNSZone.DNSExpressZoneDBEntry", Namespace = "urn:iControl")]
	public partial class LocalLBDNSZoneDNSExpressZoneDBEntry
	{
		private string nameField;
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}
		private CommonULong64 valueField;
		public CommonULong64 value
		{
			get { return this.valueField; }
			set { this.valueField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.DNSZone.DNSExpressZoneDBStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBDNSZoneDNSExpressZoneDBStatisticEntry
	{
		private string zoneField;
		public string zone
		{
			get { return this.zoneField; }
			set { this.zoneField = value; }
		}
		private CommonStatistic [] statisticsField;
		public CommonStatistic [] statistics
		{
			get { return this.statisticsField; }
			set { this.statisticsField = value; }
		}
		private LocalLBDNSZoneDNSExpressZoneDBEntry [] entriesField;
		public LocalLBDNSZoneDNSExpressZoneDBEntry [] entries
		{
			get { return this.entriesField; }
			set { this.entriesField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.DNSZone.DNSExpressZoneDBStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBDNSZoneDNSExpressZoneDBStatistics
	{
		private LocalLBDNSZoneDNSExpressZoneDBStatisticEntry [] statisticsField;
		public LocalLBDNSZoneDNSExpressZoneDBStatisticEntry [] statistics
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.DNSZone.DNSZoneStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBDNSZoneDNSZoneStatisticEntry
	{
		private string zoneField;
		public string zone
		{
			get { return this.zoneField; }
			set { this.zoneField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.DNSZone.DNSZoneStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBDNSZoneDNSZoneStatistics
	{
		private LocalLBDNSZoneDNSZoneStatisticEntry [] statisticsField;
		public LocalLBDNSZoneDNSZoneStatisticEntry [] statistics
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
