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
	[System.Web.Services.WebServiceBindingAttribute(Name="Networking.DNSResolverBinding", Namespace="urn:iControl")]
	public partial class NetworkingDNSResolver : iControlInterface {
		public NetworkingDNSResolver() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_forward_zone
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/DNSResolver", 
		RequestNamespace="urn:iControl:Networking/DNSResolver", ResponseNamespace="urn:iControl:Networking/DNSResolver")]
	public void add_forward_zone(
		string [] resolvers,
		string [] [] zones
	) {
		this.Invoke("add_forward_zone", new object [] {
				resolvers,
				zones});

	}
	public System.IAsyncResult Beginadd_forward_zone(string [] resolvers,string [] [] zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_forward_zone", new object[] {
			resolvers,
			zones}, callback, asyncState);
	}
	public void Endadd_forward_zone(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_nameserver
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/DNSResolver", 
		RequestNamespace="urn:iControl:Networking/DNSResolver", ResponseNamespace="urn:iControl:Networking/DNSResolver")]
	public void add_nameserver(
		string [] resolvers,
		string [] [] zones,
		CommonIPPortDefinition [] [] [] nameservers
	) {
		this.Invoke("add_nameserver", new object [] {
				resolvers,
				zones,
				nameservers});

	}
	public System.IAsyncResult Beginadd_nameserver(string [] resolvers,string [] [] zones,CommonIPPortDefinition [] [] [] nameservers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_nameserver", new object[] {
			resolvers,
			zones,
			nameservers}, callback, asyncState);
	}
	public void Endadd_nameserver(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/DNSResolver", 
		RequestNamespace="urn:iControl:Networking/DNSResolver", ResponseNamespace="urn:iControl:Networking/DNSResolver")]
	public void create(
		string [] resolvers
	) {
		this.Invoke("create", new object [] {
				resolvers});

	}
	public System.IAsyncResult Begincreate(string [] resolvers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			resolvers}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_dns_resolvers
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/DNSResolver", 
		RequestNamespace="urn:iControl:Networking/DNSResolver", ResponseNamespace="urn:iControl:Networking/DNSResolver")]
	public void delete_all_dns_resolvers(

	) {
		this.Invoke("delete_all_dns_resolvers", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_dns_resolvers(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_dns_resolvers", new object[0], callback, asyncState);
	}
	public void Enddelete_all_dns_resolvers(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_dns_resolver
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/DNSResolver", 
		RequestNamespace="urn:iControl:Networking/DNSResolver", ResponseNamespace="urn:iControl:Networking/DNSResolver")]
	public void delete_dns_resolver(
		string [] resolvers
	) {
		this.Invoke("delete_dns_resolver", new object [] {
				resolvers});

	}
	public System.IAsyncResult Begindelete_dns_resolver(string [] resolvers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_dns_resolver", new object[] {
			resolvers}, callback, asyncState);
	}
	public void Enddelete_dns_resolver(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_answer_default_zones_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/DNSResolver", 
		RequestNamespace="urn:iControl:Networking/DNSResolver", ResponseNamespace="urn:iControl:Networking/DNSResolver")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_answer_default_zones_state(
		string [] resolvers
	) {
		object [] results = this.Invoke("get_answer_default_zones_state", new object [] {
				resolvers});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_answer_default_zones_state(string [] resolvers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_answer_default_zones_state", new object[] {
			resolvers}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_answer_default_zones_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cache_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/DNSResolver", 
		RequestNamespace="urn:iControl:Networking/DNSResolver", ResponseNamespace="urn:iControl:Networking/DNSResolver")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_cache_size(
		string [] resolvers
	) {
		object [] results = this.Invoke("get_cache_size", new object [] {
				resolvers});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_cache_size(string [] resolvers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cache_size", new object[] {
			resolvers}, callback, asyncState);
	}
	public long [] Endget_cache_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_forward_zone
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/DNSResolver", 
		RequestNamespace="urn:iControl:Networking/DNSResolver", ResponseNamespace="urn:iControl:Networking/DNSResolver")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_forward_zone(
		string [] resolvers
	) {
		object [] results = this.Invoke("get_forward_zone", new object [] {
				resolvers});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_forward_zone(string [] resolvers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_forward_zone", new object[] {
			resolvers}, callback, asyncState);
	}
	public string [] [] Endget_forward_zone(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/DNSResolver", 
		RequestNamespace="urn:iControl:Networking/DNSResolver", ResponseNamespace="urn:iControl:Networking/DNSResolver")]
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
	// get_nameserver
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/DNSResolver", 
		RequestNamespace="urn:iControl:Networking/DNSResolver", ResponseNamespace="urn:iControl:Networking/DNSResolver")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonIPPortDefinition [] [] [] get_nameserver(
		string [] resolvers,
		string [] [] zones
	) {
		object [] results = this.Invoke("get_nameserver", new object [] {
				resolvers,
				zones});
		return ((CommonIPPortDefinition [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_nameserver(string [] resolvers,string [] [] zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_nameserver", new object[] {
			resolvers,
			zones}, callback, asyncState);
	}
	public CommonIPPortDefinition [] [] [] Endget_nameserver(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonIPPortDefinition [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_randomize_query_character_case_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/DNSResolver", 
		RequestNamespace="urn:iControl:Networking/DNSResolver", ResponseNamespace="urn:iControl:Networking/DNSResolver")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_randomize_query_character_case_state(
		string [] resolvers
	) {
		object [] results = this.Invoke("get_randomize_query_character_case_state", new object [] {
				resolvers});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_randomize_query_character_case_state(string [] resolvers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_randomize_query_character_case_state", new object[] {
			resolvers}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_randomize_query_character_case_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_route_domain
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/DNSResolver", 
		RequestNamespace="urn:iControl:Networking/DNSResolver", ResponseNamespace="urn:iControl:Networking/DNSResolver")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_route_domain(
		string [] resolvers
	) {
		object [] results = this.Invoke("get_route_domain", new object [] {
				resolvers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_route_domain(string [] resolvers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_route_domain", new object[] {
			resolvers}, callback, asyncState);
	}
	public string [] Endget_route_domain(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_use_ipv4_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/DNSResolver", 
		RequestNamespace="urn:iControl:Networking/DNSResolver", ResponseNamespace="urn:iControl:Networking/DNSResolver")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_use_ipv4_state(
		string [] resolvers
	) {
		object [] results = this.Invoke("get_use_ipv4_state", new object [] {
				resolvers});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_use_ipv4_state(string [] resolvers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_use_ipv4_state", new object[] {
			resolvers}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_use_ipv4_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_use_ipv6_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/DNSResolver", 
		RequestNamespace="urn:iControl:Networking/DNSResolver", ResponseNamespace="urn:iControl:Networking/DNSResolver")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_use_ipv6_state(
		string [] resolvers
	) {
		object [] results = this.Invoke("get_use_ipv6_state", new object [] {
				resolvers});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_use_ipv6_state(string [] resolvers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_use_ipv6_state", new object[] {
			resolvers}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_use_ipv6_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_use_tcp_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/DNSResolver", 
		RequestNamespace="urn:iControl:Networking/DNSResolver", ResponseNamespace="urn:iControl:Networking/DNSResolver")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_use_tcp_state(
		string [] resolvers
	) {
		object [] results = this.Invoke("get_use_tcp_state", new object [] {
				resolvers});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_use_tcp_state(string [] resolvers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_use_tcp_state", new object[] {
			resolvers}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_use_tcp_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_use_udp_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/DNSResolver", 
		RequestNamespace="urn:iControl:Networking/DNSResolver", ResponseNamespace="urn:iControl:Networking/DNSResolver")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_use_udp_state(
		string [] resolvers
	) {
		object [] results = this.Invoke("get_use_udp_state", new object [] {
				resolvers});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_use_udp_state(string [] resolvers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_use_udp_state", new object[] {
			resolvers}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_use_udp_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/DNSResolver", 
		RequestNamespace="urn:iControl:Networking/DNSResolver", ResponseNamespace="urn:iControl:Networking/DNSResolver")]
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
	// remove_all_forward_zones
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/DNSResolver", 
		RequestNamespace="urn:iControl:Networking/DNSResolver", ResponseNamespace="urn:iControl:Networking/DNSResolver")]
	public void remove_all_forward_zones(
		string [] resolvers
	) {
		this.Invoke("remove_all_forward_zones", new object [] {
				resolvers});

	}
	public System.IAsyncResult Beginremove_all_forward_zones(string [] resolvers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_forward_zones", new object[] {
			resolvers}, callback, asyncState);
	}
	public void Endremove_all_forward_zones(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_nameservers
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/DNSResolver", 
		RequestNamespace="urn:iControl:Networking/DNSResolver", ResponseNamespace="urn:iControl:Networking/DNSResolver")]
	public void remove_all_nameservers(
		string [] resolvers,
		string [] [] zones
	) {
		this.Invoke("remove_all_nameservers", new object [] {
				resolvers,
				zones});

	}
	public System.IAsyncResult Beginremove_all_nameservers(string [] resolvers,string [] [] zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_nameservers", new object[] {
			resolvers,
			zones}, callback, asyncState);
	}
	public void Endremove_all_nameservers(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_forward_zone
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/DNSResolver", 
		RequestNamespace="urn:iControl:Networking/DNSResolver", ResponseNamespace="urn:iControl:Networking/DNSResolver")]
	public void remove_forward_zone(
		string [] resolvers,
		string [] [] zones
	) {
		this.Invoke("remove_forward_zone", new object [] {
				resolvers,
				zones});

	}
	public System.IAsyncResult Beginremove_forward_zone(string [] resolvers,string [] [] zones, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_forward_zone", new object[] {
			resolvers,
			zones}, callback, asyncState);
	}
	public void Endremove_forward_zone(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_nameserver
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/DNSResolver", 
		RequestNamespace="urn:iControl:Networking/DNSResolver", ResponseNamespace="urn:iControl:Networking/DNSResolver")]
	public void remove_nameserver(
		string [] resolvers,
		string [] [] zones,
		CommonIPPortDefinition [] [] [] nameservers
	) {
		this.Invoke("remove_nameserver", new object [] {
				resolvers,
				zones,
				nameservers});

	}
	public System.IAsyncResult Beginremove_nameserver(string [] resolvers,string [] [] zones,CommonIPPortDefinition [] [] [] nameservers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_nameserver", new object[] {
			resolvers,
			zones,
			nameservers}, callback, asyncState);
	}
	public void Endremove_nameserver(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_answer_default_zones_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/DNSResolver", 
		RequestNamespace="urn:iControl:Networking/DNSResolver", ResponseNamespace="urn:iControl:Networking/DNSResolver")]
	public void set_answer_default_zones_state(
		string [] resolvers,
		CommonEnabledState [] states
	) {
		this.Invoke("set_answer_default_zones_state", new object [] {
				resolvers,
				states});

	}
	public System.IAsyncResult Beginset_answer_default_zones_state(string [] resolvers,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_answer_default_zones_state", new object[] {
			resolvers,
			states}, callback, asyncState);
	}
	public void Endset_answer_default_zones_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_cache_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/DNSResolver", 
		RequestNamespace="urn:iControl:Networking/DNSResolver", ResponseNamespace="urn:iControl:Networking/DNSResolver")]
	public void set_cache_size(
		string [] resolvers,
		long [] sizes
	) {
		this.Invoke("set_cache_size", new object [] {
				resolvers,
				sizes});

	}
	public System.IAsyncResult Beginset_cache_size(string [] resolvers,long [] sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cache_size", new object[] {
			resolvers,
			sizes}, callback, asyncState);
	}
	public void Endset_cache_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_randomize_query_character_case_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/DNSResolver", 
		RequestNamespace="urn:iControl:Networking/DNSResolver", ResponseNamespace="urn:iControl:Networking/DNSResolver")]
	public void set_randomize_query_character_case_state(
		string [] resolvers,
		CommonEnabledState [] states
	) {
		this.Invoke("set_randomize_query_character_case_state", new object [] {
				resolvers,
				states});

	}
	public System.IAsyncResult Beginset_randomize_query_character_case_state(string [] resolvers,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_randomize_query_character_case_state", new object[] {
			resolvers,
			states}, callback, asyncState);
	}
	public void Endset_randomize_query_character_case_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_route_domain
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/DNSResolver", 
		RequestNamespace="urn:iControl:Networking/DNSResolver", ResponseNamespace="urn:iControl:Networking/DNSResolver")]
	public void set_route_domain(
		string [] resolvers,
		string [] domains
	) {
		this.Invoke("set_route_domain", new object [] {
				resolvers,
				domains});

	}
	public System.IAsyncResult Beginset_route_domain(string [] resolvers,string [] domains, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_route_domain", new object[] {
			resolvers,
			domains}, callback, asyncState);
	}
	public void Endset_route_domain(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_use_ipv4_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/DNSResolver", 
		RequestNamespace="urn:iControl:Networking/DNSResolver", ResponseNamespace="urn:iControl:Networking/DNSResolver")]
	public void set_use_ipv4_state(
		string [] resolvers,
		CommonEnabledState [] states
	) {
		this.Invoke("set_use_ipv4_state", new object [] {
				resolvers,
				states});

	}
	public System.IAsyncResult Beginset_use_ipv4_state(string [] resolvers,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_use_ipv4_state", new object[] {
			resolvers,
			states}, callback, asyncState);
	}
	public void Endset_use_ipv4_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_use_ipv6_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/DNSResolver", 
		RequestNamespace="urn:iControl:Networking/DNSResolver", ResponseNamespace="urn:iControl:Networking/DNSResolver")]
	public void set_use_ipv6_state(
		string [] resolvers,
		CommonEnabledState [] states
	) {
		this.Invoke("set_use_ipv6_state", new object [] {
				resolvers,
				states});

	}
	public System.IAsyncResult Beginset_use_ipv6_state(string [] resolvers,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_use_ipv6_state", new object[] {
			resolvers,
			states}, callback, asyncState);
	}
	public void Endset_use_ipv6_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_use_tcp_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/DNSResolver", 
		RequestNamespace="urn:iControl:Networking/DNSResolver", ResponseNamespace="urn:iControl:Networking/DNSResolver")]
	public void set_use_tcp_state(
		string [] resolvers,
		CommonEnabledState [] states
	) {
		this.Invoke("set_use_tcp_state", new object [] {
				resolvers,
				states});

	}
	public System.IAsyncResult Beginset_use_tcp_state(string [] resolvers,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_use_tcp_state", new object[] {
			resolvers,
			states}, callback, asyncState);
	}
	public void Endset_use_tcp_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_use_udp_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/DNSResolver", 
		RequestNamespace="urn:iControl:Networking/DNSResolver", ResponseNamespace="urn:iControl:Networking/DNSResolver")]
	public void set_use_udp_state(
		string [] resolvers,
		CommonEnabledState [] states
	) {
		this.Invoke("set_use_udp_state", new object [] {
				resolvers,
				states});

	}
	public System.IAsyncResult Beginset_use_udp_state(string [] resolvers,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_use_udp_state", new object[] {
			resolvers,
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

}
