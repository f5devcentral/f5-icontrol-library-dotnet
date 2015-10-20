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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.DNSCacheBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBDNSCacheLocalZone))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBDNSCacheDNSCacheStatistics))]
	public partial class LocalLBDNSCache : iControlInterface {
		public LocalLBDNSCache() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_dlv_anchor
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void add_dlv_anchor(
		string [] caches,
		string [] [] anchors
	) {
		this.Invoke("add_dlv_anchor", new object [] {
				caches,
				anchors});

	}
	public System.IAsyncResult Beginadd_dlv_anchor(string [] caches,string [] [] anchors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_dlv_anchor", new object[] {
			caches,
			anchors}, callback, asyncState);
	}
	public void Endadd_dlv_anchor(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_forward_zone
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void add_forward_zone(
		string [] caches,
		string [] [] zones
	) {
		this.Invoke("add_forward_zone", new object [] {
				caches,
				zones});

	}
	public System.IAsyncResult Beginadd_forward_zone(string [] caches,string [] [] zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_forward_zone", new object[] {
			caches,
			zones}, callback, asyncState);
	}
	public void Endadd_forward_zone(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_nameserver
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void add_nameserver(
		string [] caches,
		string [] [] zones,
		CommonIPPortDefinition [] [] [] nameservers
	) {
		this.Invoke("add_nameserver", new object [] {
				caches,
				zones,
				nameservers});

	}
	public System.IAsyncResult Beginadd_nameserver(string [] caches,string [] [] zones,CommonIPPortDefinition [] [] [] nameservers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_nameserver", new object[] {
			caches,
			zones,
			nameservers}, callback, asyncState);
	}
	public void Endadd_nameserver(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_response_policy_zone
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void add_response_policy_zone(
		string [] caches,
		string [] [] zones,
		LocalLBRPZActionType [] [] actions,
		string [] [] walled_gardens
	) {
		this.Invoke("add_response_policy_zone", new object [] {
				caches,
				zones,
				actions,
				walled_gardens});

	}
	public System.IAsyncResult Beginadd_response_policy_zone(string [] caches,string [] [] zones,LocalLBRPZActionType [] [] actions,string [] [] walled_gardens, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_response_policy_zone", new object[] {
			caches,
			zones,
			actions,
			walled_gardens}, callback, asyncState);
	}
	public void Endadd_response_policy_zone(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_root_hint
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void add_root_hint(
		string [] caches,
		string [] [] hints
	) {
		this.Invoke("add_root_hint", new object [] {
				caches,
				hints});

	}
	public System.IAsyncResult Beginadd_root_hint(string [] caches,string [] [] hints, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_root_hint", new object[] {
			caches,
			hints}, callback, asyncState);
	}
	public void Endadd_root_hint(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_trust_anchor
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void add_trust_anchor(
		string [] caches,
		string [] [] anchors
	) {
		this.Invoke("add_trust_anchor", new object [] {
				caches,
				anchors});

	}
	public System.IAsyncResult Beginadd_trust_anchor(string [] caches,string [] [] anchors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_trust_anchor", new object[] {
			caches,
			anchors}, callback, asyncState);
	}
	public void Endadd_trust_anchor(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void create(
		string [] caches,
		LocalLBDNSCacheType [] types
	) {
		this.Invoke("create", new object [] {
				caches,
				types});

	}
	public System.IAsyncResult Begincreate(string [] caches,LocalLBDNSCacheType [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			caches,
			types}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_dns_caches
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void delete_all_dns_caches(

	) {
		this.Invoke("delete_all_dns_caches", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_dns_caches(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_dns_caches", new object[0], callback, asyncState);
	}
	public void Enddelete_all_dns_caches(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_key_records
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void delete_all_key_records(
		string [] caches
	) {
		this.Invoke("delete_all_key_records", new object [] {
				caches});

	}
	public System.IAsyncResult Begindelete_all_key_records(string [] caches, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_key_records", new object[] {
			caches}, callback, asyncState);
	}
	public void Enddelete_all_key_records(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_message_records
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void delete_all_message_records(
		string [] caches
	) {
		this.Invoke("delete_all_message_records", new object [] {
				caches});

	}
	public System.IAsyncResult Begindelete_all_message_records(string [] caches, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_message_records", new object[] {
			caches}, callback, asyncState);
	}
	public void Enddelete_all_message_records(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_nameserver_records
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void delete_all_nameserver_records(
		string [] caches
	) {
		this.Invoke("delete_all_nameserver_records", new object [] {
				caches});

	}
	public System.IAsyncResult Begindelete_all_nameserver_records(string [] caches, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_nameserver_records", new object[] {
			caches}, callback, asyncState);
	}
	public void Enddelete_all_nameserver_records(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_resource_records
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void delete_all_resource_records(
		string [] caches
	) {
		this.Invoke("delete_all_resource_records", new object [] {
				caches});

	}
	public System.IAsyncResult Begindelete_all_resource_records(string [] caches, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_resource_records", new object[] {
			caches}, callback, asyncState);
	}
	public void Enddelete_all_resource_records(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_dns_cache
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void delete_dns_cache(
		string [] caches
	) {
		this.Invoke("delete_dns_cache", new object [] {
				caches});

	}
	public System.IAsyncResult Begindelete_dns_cache(string [] caches, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_dns_cache", new object[] {
			caches}, callback, asyncState);
	}
	public void Enddelete_dns_cache(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_allowed_query_time
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_allowed_query_time(
		string [] caches
	) {
		object [] results = this.Invoke("get_allowed_query_time", new object [] {
				caches});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_allowed_query_time(string [] caches, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_allowed_query_time", new object[] {
			caches}, callback, asyncState);
	}
	public long [] Endget_allowed_query_time(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_answer_default_zones_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_answer_default_zones_state(
		string [] caches
	) {
		object [] results = this.Invoke("get_answer_default_zones_state", new object [] {
				caches});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_answer_default_zones_state(string [] caches, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_answer_default_zones_state", new object[] {
			caches}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_answer_default_zones_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] caches
	) {
		object [] results = this.Invoke("get_description", new object [] {
				caches});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] caches, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			caches}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dlv_anchor
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_dlv_anchor(
		string [] caches
	) {
		object [] results = this.Invoke("get_dlv_anchor", new object [] {
				caches});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_dlv_anchor(string [] caches, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dlv_anchor", new object[] {
			caches}, callback, asyncState);
	}
	public string [] [] Endget_dlv_anchor(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_forward_zone
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_forward_zone(
		string [] caches
	) {
		object [] results = this.Invoke("get_forward_zone", new object [] {
				caches});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_forward_zone(string [] caches, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_forward_zone", new object[] {
			caches}, callback, asyncState);
	}
	public string [] [] Endget_forward_zone(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ignore_cd_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_ignore_cd_state(
		string [] caches
	) {
		object [] results = this.Invoke("get_ignore_cd_state", new object [] {
				caches});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_ignore_cd_state(string [] caches, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ignore_cd_state", new object[] {
			caches}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_ignore_cd_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_key_cache_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_key_cache_size(
		string [] caches
	) {
		object [] results = this.Invoke("get_key_cache_size", new object [] {
				caches});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_key_cache_size(string [] caches, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_key_cache_size", new object[] {
			caches}, callback, asyncState);
	}
	public long [] Endget_key_cache_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
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
	// get_local_zone
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBDNSCacheLocalZone [] [] get_local_zone(
		string [] caches
	) {
		object [] results = this.Invoke("get_local_zone", new object [] {
				caches});
		return ((LocalLBDNSCacheLocalZone [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_local_zone(string [] caches, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_local_zone", new object[] {
			caches}, callback, asyncState);
	}
	public LocalLBDNSCacheLocalZone [] [] Endget_local_zone(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBDNSCacheLocalZone [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_maximum_concurrent_queries
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_maximum_concurrent_queries(
		string [] caches
	) {
		object [] results = this.Invoke("get_maximum_concurrent_queries", new object [] {
				caches});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_concurrent_queries(string [] caches, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_concurrent_queries", new object[] {
			caches}, callback, asyncState);
	}
	public long [] Endget_maximum_concurrent_queries(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_maximum_tcp_flows
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_maximum_tcp_flows(
		string [] caches
	) {
		object [] results = this.Invoke("get_maximum_tcp_flows", new object [] {
				caches});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_tcp_flows(string [] caches, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_tcp_flows", new object[] {
			caches}, callback, asyncState);
	}
	public long [] Endget_maximum_tcp_flows(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_maximum_udp_flows
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_maximum_udp_flows(
		string [] caches
	) {
		object [] results = this.Invoke("get_maximum_udp_flows", new object [] {
				caches});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_udp_flows(string [] caches, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_udp_flows", new object[] {
			caches}, callback, asyncState);
	}
	public long [] Endget_maximum_udp_flows(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_message_cache_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_message_cache_size(
		string [] caches
	) {
		object [] results = this.Invoke("get_message_cache_size", new object [] {
				caches});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_message_cache_size(string [] caches, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_message_cache_size", new object[] {
			caches}, callback, asyncState);
	}
	public long [] Endget_message_cache_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_nameserver
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonIPPortDefinition [] [] [] get_nameserver(
		string [] caches,
		string [] [] zones
	) {
		object [] results = this.Invoke("get_nameserver", new object [] {
				caches,
				zones});
		return ((CommonIPPortDefinition [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_nameserver(string [] caches,string [] [] zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_nameserver", new object[] {
			caches,
			zones}, callback, asyncState);
	}
	public CommonIPPortDefinition [] [] [] Endget_nameserver(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonIPPortDefinition [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_nameserver_cache_count
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_nameserver_cache_count(
		string [] caches
	) {
		object [] results = this.Invoke("get_nameserver_cache_count", new object [] {
				caches});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_nameserver_cache_count(string [] caches, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_nameserver_cache_count", new object[] {
			caches}, callback, asyncState);
	}
	public long [] Endget_nameserver_cache_count(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_prefetch_key_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_prefetch_key_state(
		string [] caches
	) {
		object [] results = this.Invoke("get_prefetch_key_state", new object [] {
				caches});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_prefetch_key_state(string [] caches, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_prefetch_key_state", new object[] {
			caches}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_prefetch_key_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_randomize_query_name_case_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_randomize_query_name_case_state(
		string [] caches
	) {
		object [] results = this.Invoke("get_randomize_query_name_case_state", new object [] {
				caches});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_randomize_query_name_case_state(string [] caches, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_randomize_query_name_case_state", new object[] {
			caches}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_randomize_query_name_case_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_resource_record_cache_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_resource_record_cache_size(
		string [] caches
	) {
		object [] results = this.Invoke("get_resource_record_cache_size", new object [] {
				caches});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_resource_record_cache_size(string [] caches, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_resource_record_cache_size", new object[] {
			caches}, callback, asyncState);
	}
	public long [] Endget_resource_record_cache_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_response_policy_zone
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_response_policy_zone(
		string [] caches
	) {
		object [] results = this.Invoke("get_response_policy_zone", new object [] {
				caches});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_response_policy_zone(string [] caches, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_response_policy_zone", new object[] {
			caches}, callback, asyncState);
	}
	public string [] [] Endget_response_policy_zone(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_response_policy_zone_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBRPZActionType [] [] get_response_policy_zone_action(
		string [] caches,
		string [] [] zones
	) {
		object [] results = this.Invoke("get_response_policy_zone_action", new object [] {
				caches,
				zones});
		return ((LocalLBRPZActionType [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_response_policy_zone_action(string [] caches,string [] [] zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_response_policy_zone_action", new object[] {
			caches,
			zones}, callback, asyncState);
	}
	public LocalLBRPZActionType [] [] Endget_response_policy_zone_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBRPZActionType [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_response_policy_zone_walled_garden
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_response_policy_zone_walled_garden(
		string [] caches,
		string [] [] zones
	) {
		object [] results = this.Invoke("get_response_policy_zone_walled_garden", new object [] {
				caches,
				zones});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_response_policy_zone_walled_garden(string [] caches,string [] [] zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_response_policy_zone_walled_garden", new object[] {
			caches,
			zones}, callback, asyncState);
	}
	public string [] [] Endget_response_policy_zone_walled_garden(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_root_hint
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_root_hint(
		string [] caches
	) {
		object [] results = this.Invoke("get_root_hint", new object [] {
				caches});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_root_hint(string [] caches, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_root_hint", new object[] {
			caches}, callback, asyncState);
	}
	public string [] [] Endget_root_hint(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_route_domain
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_route_domain(
		string [] caches
	) {
		object [] results = this.Invoke("get_route_domain", new object [] {
				caches});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_route_domain(string [] caches, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_route_domain", new object[] {
			caches}, callback, asyncState);
	}
	public string [] Endget_route_domain(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBDNSCacheDNSCacheStatistics get_statistics(
		string [] caches
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				caches});
		return ((LocalLBDNSCacheDNSCacheStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] caches, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			caches}, callback, asyncState);
	}
	public LocalLBDNSCacheDNSCacheStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBDNSCacheDNSCacheStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_trust_anchor
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_trust_anchor(
		string [] caches
	) {
		object [] results = this.Invoke("get_trust_anchor", new object [] {
				caches});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_trust_anchor(string [] caches, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_trust_anchor", new object[] {
			caches}, callback, asyncState);
	}
	public string [] [] Endget_trust_anchor(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBDNSCacheType [] get_type(
		string [] caches
	) {
		object [] results = this.Invoke("get_type", new object [] {
				caches});
		return ((LocalLBDNSCacheType [])(results[0]));
	}
	public System.IAsyncResult Beginget_type(string [] caches, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_type", new object[] {
			caches}, callback, asyncState);
	}
	public LocalLBDNSCacheType [] Endget_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBDNSCacheType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_unwanted_reply_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_unwanted_reply_threshold(
		string [] caches
	) {
		object [] results = this.Invoke("get_unwanted_reply_threshold", new object [] {
				caches});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_unwanted_reply_threshold(string [] caches, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_unwanted_reply_threshold", new object[] {
			caches}, callback, asyncState);
	}
	public long [] Endget_unwanted_reply_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_use_ipv4_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_use_ipv4_state(
		string [] caches
	) {
		object [] results = this.Invoke("get_use_ipv4_state", new object [] {
				caches});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_use_ipv4_state(string [] caches, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_use_ipv4_state", new object[] {
			caches}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_use_ipv4_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_use_ipv6_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_use_ipv6_state(
		string [] caches
	) {
		object [] results = this.Invoke("get_use_ipv6_state", new object [] {
				caches});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_use_ipv6_state(string [] caches, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_use_ipv6_state", new object[] {
			caches}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_use_ipv6_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_use_tcp_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_use_tcp_state(
		string [] caches
	) {
		object [] results = this.Invoke("get_use_tcp_state", new object [] {
				caches});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_use_tcp_state(string [] caches, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_use_tcp_state", new object[] {
			caches}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_use_tcp_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_use_udp_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_use_udp_state(
		string [] caches
	) {
		object [] results = this.Invoke("get_use_udp_state", new object [] {
				caches});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_use_udp_state(string [] caches, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_use_udp_state", new object[] {
			caches}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_use_udp_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
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
	// remove_all_dlv_anchors
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void remove_all_dlv_anchors(
		string [] caches
	) {
		this.Invoke("remove_all_dlv_anchors", new object [] {
				caches});

	}
	public System.IAsyncResult Beginremove_all_dlv_anchors(string [] caches, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_dlv_anchors", new object[] {
			caches}, callback, asyncState);
	}
	public void Endremove_all_dlv_anchors(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_forward_zones
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void remove_all_forward_zones(
		string [] caches
	) {
		this.Invoke("remove_all_forward_zones", new object [] {
				caches});

	}
	public System.IAsyncResult Beginremove_all_forward_zones(string [] caches, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_forward_zones", new object[] {
			caches}, callback, asyncState);
	}
	public void Endremove_all_forward_zones(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_local_zones
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void remove_all_local_zones(
		string [] caches
	) {
		this.Invoke("remove_all_local_zones", new object [] {
				caches});

	}
	public System.IAsyncResult Beginremove_all_local_zones(string [] caches, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_local_zones", new object[] {
			caches}, callback, asyncState);
	}
	public void Endremove_all_local_zones(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_nameservers
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void remove_all_nameservers(
		string [] caches,
		string [] [] zones
	) {
		this.Invoke("remove_all_nameservers", new object [] {
				caches,
				zones});

	}
	public System.IAsyncResult Beginremove_all_nameservers(string [] caches,string [] [] zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_nameservers", new object[] {
			caches,
			zones}, callback, asyncState);
	}
	public void Endremove_all_nameservers(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_response_policy_zones
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void remove_all_response_policy_zones(
		string [] caches
	) {
		this.Invoke("remove_all_response_policy_zones", new object [] {
				caches});

	}
	public System.IAsyncResult Beginremove_all_response_policy_zones(string [] caches, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_response_policy_zones", new object[] {
			caches}, callback, asyncState);
	}
	public void Endremove_all_response_policy_zones(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_root_hints
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void remove_all_root_hints(
		string [] caches
	) {
		this.Invoke("remove_all_root_hints", new object [] {
				caches});

	}
	public System.IAsyncResult Beginremove_all_root_hints(string [] caches, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_root_hints", new object[] {
			caches}, callback, asyncState);
	}
	public void Endremove_all_root_hints(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_trust_anchors
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void remove_all_trust_anchors(
		string [] caches
	) {
		this.Invoke("remove_all_trust_anchors", new object [] {
				caches});

	}
	public System.IAsyncResult Beginremove_all_trust_anchors(string [] caches, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_trust_anchors", new object[] {
			caches}, callback, asyncState);
	}
	public void Endremove_all_trust_anchors(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_dlv_anchor
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void remove_dlv_anchor(
		string [] caches,
		string [] [] anchors
	) {
		this.Invoke("remove_dlv_anchor", new object [] {
				caches,
				anchors});

	}
	public System.IAsyncResult Beginremove_dlv_anchor(string [] caches,string [] [] anchors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_dlv_anchor", new object[] {
			caches,
			anchors}, callback, asyncState);
	}
	public void Endremove_dlv_anchor(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_forward_zone
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void remove_forward_zone(
		string [] caches,
		string [] [] zones
	) {
		this.Invoke("remove_forward_zone", new object [] {
				caches,
				zones});

	}
	public System.IAsyncResult Beginremove_forward_zone(string [] caches,string [] [] zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_forward_zone", new object[] {
			caches,
			zones}, callback, asyncState);
	}
	public void Endremove_forward_zone(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_nameserver
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void remove_nameserver(
		string [] caches,
		string [] [] zones,
		CommonIPPortDefinition [] [] [] nameservers
	) {
		this.Invoke("remove_nameserver", new object [] {
				caches,
				zones,
				nameservers});

	}
	public System.IAsyncResult Beginremove_nameserver(string [] caches,string [] [] zones,CommonIPPortDefinition [] [] [] nameservers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_nameserver", new object[] {
			caches,
			zones,
			nameservers}, callback, asyncState);
	}
	public void Endremove_nameserver(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_response_policy_zone
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void remove_response_policy_zone(
		string [] caches,
		string [] [] zones
	) {
		this.Invoke("remove_response_policy_zone", new object [] {
				caches,
				zones});

	}
	public System.IAsyncResult Beginremove_response_policy_zone(string [] caches,string [] [] zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_response_policy_zone", new object[] {
			caches,
			zones}, callback, asyncState);
	}
	public void Endremove_response_policy_zone(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_root_hint
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void remove_root_hint(
		string [] caches,
		string [] [] hints
	) {
		this.Invoke("remove_root_hint", new object [] {
				caches,
				hints});

	}
	public System.IAsyncResult Beginremove_root_hint(string [] caches,string [] [] hints, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_root_hint", new object[] {
			caches,
			hints}, callback, asyncState);
	}
	public void Endremove_root_hint(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_trust_anchor
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void remove_trust_anchor(
		string [] caches,
		string [] [] anchors
	) {
		this.Invoke("remove_trust_anchor", new object [] {
				caches,
				anchors});

	}
	public System.IAsyncResult Beginremove_trust_anchor(string [] caches,string [] [] anchors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_trust_anchor", new object[] {
			caches,
			anchors}, callback, asyncState);
	}
	public void Endremove_trust_anchor(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// replace_local_zone
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void replace_local_zone(
		string [] caches,
		LocalLBDNSCacheLocalZone [] [] zones
	) {
		this.Invoke("replace_local_zone", new object [] {
				caches,
				zones});

	}
	public System.IAsyncResult Beginreplace_local_zone(string [] caches,LocalLBDNSCacheLocalZone [] [] zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("replace_local_zone", new object[] {
			caches,
			zones}, callback, asyncState);
	}
	public void Endreplace_local_zone(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void reset_statistics(
		string [] caches
	) {
		this.Invoke("reset_statistics", new object [] {
				caches});

	}
	public System.IAsyncResult Beginreset_statistics(string [] caches, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics", new object[] {
			caches}, callback, asyncState);
	}
	public void Endreset_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_allowed_query_time
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void set_allowed_query_time(
		string [] caches,
		long [] times
	) {
		this.Invoke("set_allowed_query_time", new object [] {
				caches,
				times});

	}
	public System.IAsyncResult Beginset_allowed_query_time(string [] caches,long [] times, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_allowed_query_time", new object[] {
			caches,
			times}, callback, asyncState);
	}
	public void Endset_allowed_query_time(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_answer_default_zones_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void set_answer_default_zones_state(
		string [] caches,
		CommonEnabledState [] states
	) {
		this.Invoke("set_answer_default_zones_state", new object [] {
				caches,
				states});

	}
	public System.IAsyncResult Beginset_answer_default_zones_state(string [] caches,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_answer_default_zones_state", new object[] {
			caches,
			states}, callback, asyncState);
	}
	public void Endset_answer_default_zones_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void set_description(
		string [] caches,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				caches,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] caches,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			caches,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ignore_cd_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void set_ignore_cd_state(
		string [] caches,
		CommonEnabledState [] states
	) {
		this.Invoke("set_ignore_cd_state", new object [] {
				caches,
				states});

	}
	public System.IAsyncResult Beginset_ignore_cd_state(string [] caches,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ignore_cd_state", new object[] {
			caches,
			states}, callback, asyncState);
	}
	public void Endset_ignore_cd_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_key_cache_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void set_key_cache_size(
		string [] caches,
		long [] sizes
	) {
		this.Invoke("set_key_cache_size", new object [] {
				caches,
				sizes});

	}
	public System.IAsyncResult Beginset_key_cache_size(string [] caches,long [] sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_key_cache_size", new object[] {
			caches,
			sizes}, callback, asyncState);
	}
	public void Endset_key_cache_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_concurrent_queries
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void set_maximum_concurrent_queries(
		string [] caches,
		long [] queries
	) {
		this.Invoke("set_maximum_concurrent_queries", new object [] {
				caches,
				queries});

	}
	public System.IAsyncResult Beginset_maximum_concurrent_queries(string [] caches,long [] queries, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_concurrent_queries", new object[] {
			caches,
			queries}, callback, asyncState);
	}
	public void Endset_maximum_concurrent_queries(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_tcp_flows
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void set_maximum_tcp_flows(
		string [] caches,
		long [] flows
	) {
		this.Invoke("set_maximum_tcp_flows", new object [] {
				caches,
				flows});

	}
	public System.IAsyncResult Beginset_maximum_tcp_flows(string [] caches,long [] flows, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_tcp_flows", new object[] {
			caches,
			flows}, callback, asyncState);
	}
	public void Endset_maximum_tcp_flows(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_udp_flows
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void set_maximum_udp_flows(
		string [] caches,
		long [] flows
	) {
		this.Invoke("set_maximum_udp_flows", new object [] {
				caches,
				flows});

	}
	public System.IAsyncResult Beginset_maximum_udp_flows(string [] caches,long [] flows, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_udp_flows", new object[] {
			caches,
			flows}, callback, asyncState);
	}
	public void Endset_maximum_udp_flows(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_message_cache_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void set_message_cache_size(
		string [] caches,
		long [] sizes
	) {
		this.Invoke("set_message_cache_size", new object [] {
				caches,
				sizes});

	}
	public System.IAsyncResult Beginset_message_cache_size(string [] caches,long [] sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_message_cache_size", new object[] {
			caches,
			sizes}, callback, asyncState);
	}
	public void Endset_message_cache_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_nameserver_cache_count
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void set_nameserver_cache_count(
		string [] caches,
		long [] counts
	) {
		this.Invoke("set_nameserver_cache_count", new object [] {
				caches,
				counts});

	}
	public System.IAsyncResult Beginset_nameserver_cache_count(string [] caches,long [] counts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_nameserver_cache_count", new object[] {
			caches,
			counts}, callback, asyncState);
	}
	public void Endset_nameserver_cache_count(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_prefetch_key_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void set_prefetch_key_state(
		string [] caches,
		CommonEnabledState [] states
	) {
		this.Invoke("set_prefetch_key_state", new object [] {
				caches,
				states});

	}
	public System.IAsyncResult Beginset_prefetch_key_state(string [] caches,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_prefetch_key_state", new object[] {
			caches,
			states}, callback, asyncState);
	}
	public void Endset_prefetch_key_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_randomize_query_name_case_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void set_randomize_query_name_case_state(
		string [] caches,
		CommonEnabledState [] states
	) {
		this.Invoke("set_randomize_query_name_case_state", new object [] {
				caches,
				states});

	}
	public System.IAsyncResult Beginset_randomize_query_name_case_state(string [] caches,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_randomize_query_name_case_state", new object[] {
			caches,
			states}, callback, asyncState);
	}
	public void Endset_randomize_query_name_case_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_resource_record_cache_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void set_resource_record_cache_size(
		string [] caches,
		long [] sizes
	) {
		this.Invoke("set_resource_record_cache_size", new object [] {
				caches,
				sizes});

	}
	public System.IAsyncResult Beginset_resource_record_cache_size(string [] caches,long [] sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_resource_record_cache_size", new object[] {
			caches,
			sizes}, callback, asyncState);
	}
	public void Endset_resource_record_cache_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_route_domain
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void set_route_domain(
		string [] caches,
		string [] domains
	) {
		this.Invoke("set_route_domain", new object [] {
				caches,
				domains});

	}
	public System.IAsyncResult Beginset_route_domain(string [] caches,string [] domains, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_route_domain", new object[] {
			caches,
			domains}, callback, asyncState);
	}
	public void Endset_route_domain(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_unwanted_reply_threshold
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void set_unwanted_reply_threshold(
		string [] caches,
		long [] thresholds
	) {
		this.Invoke("set_unwanted_reply_threshold", new object [] {
				caches,
				thresholds});

	}
	public System.IAsyncResult Beginset_unwanted_reply_threshold(string [] caches,long [] thresholds, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_unwanted_reply_threshold", new object[] {
			caches,
			thresholds}, callback, asyncState);
	}
	public void Endset_unwanted_reply_threshold(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_use_ipv4_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void set_use_ipv4_state(
		string [] caches,
		CommonEnabledState [] states
	) {
		this.Invoke("set_use_ipv4_state", new object [] {
				caches,
				states});

	}
	public System.IAsyncResult Beginset_use_ipv4_state(string [] caches,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_use_ipv4_state", new object[] {
			caches,
			states}, callback, asyncState);
	}
	public void Endset_use_ipv4_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_use_ipv6_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void set_use_ipv6_state(
		string [] caches,
		CommonEnabledState [] states
	) {
		this.Invoke("set_use_ipv6_state", new object [] {
				caches,
				states});

	}
	public System.IAsyncResult Beginset_use_ipv6_state(string [] caches,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_use_ipv6_state", new object[] {
			caches,
			states}, callback, asyncState);
	}
	public void Endset_use_ipv6_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_use_tcp_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void set_use_tcp_state(
		string [] caches,
		CommonEnabledState [] states
	) {
		this.Invoke("set_use_tcp_state", new object [] {
				caches,
				states});

	}
	public System.IAsyncResult Beginset_use_tcp_state(string [] caches,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_use_tcp_state", new object[] {
			caches,
			states}, callback, asyncState);
	}
	public void Endset_use_tcp_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_use_udp_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/DNSCache", 
		RequestNamespace="urn:iControl:LocalLB/DNSCache", ResponseNamespace="urn:iControl:LocalLB/DNSCache")]
	public void set_use_udp_state(
		string [] caches,
		CommonEnabledState [] states
	) {
		this.Invoke("set_use_udp_state", new object [] {
				caches,
				states});

	}
	public System.IAsyncResult Beginset_use_udp_state(string [] caches,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_use_udp_state", new object[] {
			caches,
			states}, callback, asyncState);
	}
	public void Endset_use_udp_state(System.IAsyncResult asyncResult) {
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.DNSCache.DNSCacheStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBDNSCacheDNSCacheStatisticEntry
	{
		private string nameField;
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.DNSCache.DNSCacheStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBDNSCacheDNSCacheStatistics
	{
		private LocalLBDNSCacheDNSCacheStatisticEntry [] statisticsField;
		public LocalLBDNSCacheDNSCacheStatisticEntry [] statistics
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.DNSCache.LocalZone", Namespace = "urn:iControl")]
	public partial class LocalLBDNSCacheLocalZone
	{
		private string nameField;
		public string name
		{
			get { return this.nameField; }
			set { this.nameField = value; }
		}
		private LocalLBDNSCacheLocalZoneType typeField;
		public LocalLBDNSCacheLocalZoneType type
		{
			get { return this.typeField; }
			set { this.typeField = value; }
		}
		private string [] recordsField;
		public string [] records
		{
			get { return this.recordsField; }
			set { this.recordsField = value; }
		}
	};

}
