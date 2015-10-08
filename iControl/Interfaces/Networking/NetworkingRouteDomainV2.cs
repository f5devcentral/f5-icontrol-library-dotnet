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
	[System.Web.Services.WebServiceBindingAttribute(Name="Networking.RouteDomainV2Binding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonFirewallRulePlacement))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonFirewallRuleStatistics))]
	public partial class NetworkingRouteDomainV2 : iControlInterface {
		public NetworkingRouteDomainV2() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_fw_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void add_fw_rule(
		string [] route_domains,
		string [] [] rules,
		CommonFirewallRulePlacement [] [] placements,
		CommonFirewallRuleAction [] [] actions,
		CommonFirewallRuleState [] [] states
	) {
		this.Invoke("add_fw_rule", new object [] {
				route_domains,
				rules,
				placements,
				actions,
				states});

	}
	public System.IAsyncResult Beginadd_fw_rule(string [] route_domains,string [] [] rules,CommonFirewallRulePlacement [] [] placements,CommonFirewallRuleAction [] [] actions,CommonFirewallRuleState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule", new object[] {
			route_domains,
			rules,
			placements,
			actions,
			states}, callback, asyncState);
	}
	public void Endadd_fw_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_destination_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void add_fw_rule_destination_address(
		string [] route_domains,
		string [] [] rules,
		string [] [] [] addresses
	) {
		this.Invoke("add_fw_rule_destination_address", new object [] {
				route_domains,
				rules,
				addresses});

	}
	public System.IAsyncResult Beginadd_fw_rule_destination_address(string [] route_domains,string [] [] rules,string [] [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_destination_address", new object[] {
			route_domains,
			rules,
			addresses}, callback, asyncState);
	}
	public void Endadd_fw_rule_destination_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_destination_address_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void add_fw_rule_destination_address_list(
		string [] route_domains,
		string [] [] rules,
		string [] [] [] lists
	) {
		this.Invoke("add_fw_rule_destination_address_list", new object [] {
				route_domains,
				rules,
				lists});

	}
	public System.IAsyncResult Beginadd_fw_rule_destination_address_list(string [] route_domains,string [] [] rules,string [] [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_destination_address_list", new object[] {
			route_domains,
			rules,
			lists}, callback, asyncState);
	}
	public void Endadd_fw_rule_destination_address_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_destination_address_range
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void add_fw_rule_destination_address_range(
		string [] route_domains,
		string [] [] rules,
		CommonAddressRange [] [] [] ranges
	) {
		this.Invoke("add_fw_rule_destination_address_range", new object [] {
				route_domains,
				rules,
				ranges});

	}
	public System.IAsyncResult Beginadd_fw_rule_destination_address_range(string [] route_domains,string [] [] rules,CommonAddressRange [] [] [] ranges, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_destination_address_range", new object[] {
			route_domains,
			rules,
			ranges}, callback, asyncState);
	}
	public void Endadd_fw_rule_destination_address_range(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_destination_geo
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void add_fw_rule_destination_geo(
		string [] route_domains,
		string [] [] rules,
		CommonGeoLocation [] [] [] geos
	) {
		this.Invoke("add_fw_rule_destination_geo", new object [] {
				route_domains,
				rules,
				geos});

	}
	public System.IAsyncResult Beginadd_fw_rule_destination_geo(string [] route_domains,string [] [] rules,CommonGeoLocation [] [] [] geos, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_destination_geo", new object[] {
			route_domains,
			rules,
			geos}, callback, asyncState);
	}
	public void Endadd_fw_rule_destination_geo(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_destination_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void add_fw_rule_destination_port(
		string [] route_domains,
		string [] [] rules,
		CommonPortRange [] [] [] ports
	) {
		this.Invoke("add_fw_rule_destination_port", new object [] {
				route_domains,
				rules,
				ports});

	}
	public System.IAsyncResult Beginadd_fw_rule_destination_port(string [] route_domains,string [] [] rules,CommonPortRange [] [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_destination_port", new object[] {
			route_domains,
			rules,
			ports}, callback, asyncState);
	}
	public void Endadd_fw_rule_destination_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_destination_port_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void add_fw_rule_destination_port_list(
		string [] route_domains,
		string [] [] rules,
		string [] [] [] lists
	) {
		this.Invoke("add_fw_rule_destination_port_list", new object [] {
				route_domains,
				rules,
				lists});

	}
	public System.IAsyncResult Beginadd_fw_rule_destination_port_list(string [] route_domains,string [] [] rules,string [] [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_destination_port_list", new object[] {
			route_domains,
			rules,
			lists}, callback, asyncState);
	}
	public void Endadd_fw_rule_destination_port_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_icmp_typecode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void add_fw_rule_icmp_typecode(
		string [] route_domains,
		string [] [] rules,
		CommonFirewallRuleICMPTypeCode [] [] [] typecodes
	) {
		this.Invoke("add_fw_rule_icmp_typecode", new object [] {
				route_domains,
				rules,
				typecodes});

	}
	public System.IAsyncResult Beginadd_fw_rule_icmp_typecode(string [] route_domains,string [] [] rules,CommonFirewallRuleICMPTypeCode [] [] [] typecodes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_icmp_typecode", new object[] {
			route_domains,
			rules,
			typecodes}, callback, asyncState);
	}
	public void Endadd_fw_rule_icmp_typecode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_source_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void add_fw_rule_source_address(
		string [] route_domains,
		string [] [] rules,
		string [] [] [] addresses
	) {
		this.Invoke("add_fw_rule_source_address", new object [] {
				route_domains,
				rules,
				addresses});

	}
	public System.IAsyncResult Beginadd_fw_rule_source_address(string [] route_domains,string [] [] rules,string [] [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_source_address", new object[] {
			route_domains,
			rules,
			addresses}, callback, asyncState);
	}
	public void Endadd_fw_rule_source_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_source_address_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void add_fw_rule_source_address_list(
		string [] route_domains,
		string [] [] rules,
		string [] [] [] lists
	) {
		this.Invoke("add_fw_rule_source_address_list", new object [] {
				route_domains,
				rules,
				lists});

	}
	public System.IAsyncResult Beginadd_fw_rule_source_address_list(string [] route_domains,string [] [] rules,string [] [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_source_address_list", new object[] {
			route_domains,
			rules,
			lists}, callback, asyncState);
	}
	public void Endadd_fw_rule_source_address_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_source_address_range
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void add_fw_rule_source_address_range(
		string [] route_domains,
		string [] [] rules,
		CommonAddressRange [] [] [] ranges
	) {
		this.Invoke("add_fw_rule_source_address_range", new object [] {
				route_domains,
				rules,
				ranges});

	}
	public System.IAsyncResult Beginadd_fw_rule_source_address_range(string [] route_domains,string [] [] rules,CommonAddressRange [] [] [] ranges, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_source_address_range", new object[] {
			route_domains,
			rules,
			ranges}, callback, asyncState);
	}
	public void Endadd_fw_rule_source_address_range(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_source_geo
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void add_fw_rule_source_geo(
		string [] route_domains,
		string [] [] rules,
		CommonGeoLocation [] [] [] geos
	) {
		this.Invoke("add_fw_rule_source_geo", new object [] {
				route_domains,
				rules,
				geos});

	}
	public System.IAsyncResult Beginadd_fw_rule_source_geo(string [] route_domains,string [] [] rules,CommonGeoLocation [] [] [] geos, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_source_geo", new object[] {
			route_domains,
			rules,
			geos}, callback, asyncState);
	}
	public void Endadd_fw_rule_source_geo(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_source_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void add_fw_rule_source_port(
		string [] route_domains,
		string [] [] rules,
		CommonPortRange [] [] [] ports
	) {
		this.Invoke("add_fw_rule_source_port", new object [] {
				route_domains,
				rules,
				ports});

	}
	public System.IAsyncResult Beginadd_fw_rule_source_port(string [] route_domains,string [] [] rules,CommonPortRange [] [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_source_port", new object[] {
			route_domains,
			rules,
			ports}, callback, asyncState);
	}
	public void Endadd_fw_rule_source_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_source_port_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void add_fw_rule_source_port_list(
		string [] route_domains,
		string [] [] rules,
		string [] [] [] lists
	) {
		this.Invoke("add_fw_rule_source_port_list", new object [] {
				route_domains,
				rules,
				lists});

	}
	public System.IAsyncResult Beginadd_fw_rule_source_port_list(string [] route_domains,string [] [] rules,string [] [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_source_port_list", new object[] {
			route_domains,
			rules,
			lists}, callback, asyncState);
	}
	public void Endadd_fw_rule_source_port_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_source_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void add_fw_rule_source_vlan(
		string [] route_domains,
		string [] [] rules,
		string [] [] [] vlans
	) {
		this.Invoke("add_fw_rule_source_vlan", new object [] {
				route_domains,
				rules,
				vlans});

	}
	public System.IAsyncResult Beginadd_fw_rule_source_vlan(string [] route_domains,string [] [] rules,string [] [] [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_source_vlan", new object[] {
			route_domains,
			rules,
			vlans}, callback, asyncState);
	}
	public void Endadd_fw_rule_source_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_with_rule_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void add_fw_rule_with_rule_list(
		string [] route_domains,
		string [] [] rules,
		CommonFirewallRulePlacement [] [] placements,
		string [] [] lists,
		CommonFirewallRuleState [] [] states
	) {
		this.Invoke("add_fw_rule_with_rule_list", new object [] {
				route_domains,
				rules,
				placements,
				lists,
				states});

	}
	public System.IAsyncResult Beginadd_fw_rule_with_rule_list(string [] route_domains,string [] [] rules,CommonFirewallRulePlacement [] [] placements,string [] [] lists,CommonFirewallRuleState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_with_rule_list", new object[] {
			route_domains,
			rules,
			placements,
			lists,
			states}, callback, asyncState);
	}
	public void Endadd_fw_rule_with_rule_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_routing_protocol
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void add_routing_protocol(
		string [] route_domains,
		NetworkingRouteDomainV2RoutingProtocol [] [] protocols
	) {
		this.Invoke("add_routing_protocol", new object [] {
				route_domains,
				protocols});

	}
	public System.IAsyncResult Beginadd_routing_protocol(string [] route_domains,NetworkingRouteDomainV2RoutingProtocol [] [] protocols, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_routing_protocol", new object[] {
			route_domains,
			protocols}, callback, asyncState);
	}
	public void Endadd_routing_protocol(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void add_vlan(
		string [] route_domains,
		string [] [] vlans
	) {
		this.Invoke("add_vlan", new object [] {
				route_domains,
				vlans});

	}
	public System.IAsyncResult Beginadd_vlan(string [] route_domains,string [] [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_vlan", new object[] {
			route_domains,
			vlans}, callback, asyncState);
	}
	public void Endadd_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void create(
		string [] route_domains,
		long [] ids,
		string [] [] vlans
	) {
		this.Invoke("create", new object [] {
				route_domains,
				ids,
				vlans});

	}
	public System.IAsyncResult Begincreate(string [] route_domains,long [] ids,string [] [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			route_domains,
			ids,
			vlans}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_route_domains
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void delete_all_route_domains(

	) {
		this.Invoke("delete_all_route_domains", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_route_domains(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_route_domains", new object[0], callback, asyncState);
	}
	public void Enddelete_all_route_domains(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_route_domain
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void delete_route_domain(
		string [] route_domains
	) {
		this.Invoke("delete_route_domain", new object [] {
				route_domains});

	}
	public System.IAsyncResult Begindelete_route_domain(string [] route_domains, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_route_domain", new object[] {
			route_domains}, callback, asyncState);
	}
	public void Enddelete_route_domain(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_all_fw_rule_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonFirewallRuleStatistics [] get_all_fw_rule_statistics(
		string [] route_domains
	) {
		object [] results = this.Invoke("get_all_fw_rule_statistics", new object [] {
				route_domains});
		return ((CommonFirewallRuleStatistics [])(results[0]));
	}
	public System.IAsyncResult Beginget_all_fw_rule_statistics(string [] route_domains, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_fw_rule_statistics", new object[] {
			route_domains}, callback, asyncState);
	}
	public CommonFirewallRuleStatistics [] Endget_all_fw_rule_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonFirewallRuleStatistics [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_bw_controller_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_bw_controller_policy(
		string [] route_domains
	) {
		object [] results = this.Invoke("get_bw_controller_policy", new object [] {
				route_domains});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_bw_controller_policy(string [] route_domains, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_bw_controller_policy", new object[] {
			route_domains}, callback, asyncState);
	}
	public string [] Endget_bw_controller_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] route_domains
	) {
		object [] results = this.Invoke("get_description", new object [] {
				route_domains});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] route_domains, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			route_domains}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_enforced_firewall_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_enforced_firewall_policy(
		string [] route_domains
	) {
		object [] results = this.Invoke("get_enforced_firewall_policy", new object [] {
				route_domains});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_enforced_firewall_policy(string [] route_domains, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_enforced_firewall_policy", new object[] {
			route_domains}, callback, asyncState);
	}
	public string [] Endget_enforced_firewall_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_fw_rule(
		string [] route_domains
	) {
		object [] results = this.Invoke("get_fw_rule", new object [] {
				route_domains});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule(string [] route_domains, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule", new object[] {
			route_domains}, callback, asyncState);
	}
	public string [] [] Endget_fw_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonFirewallRuleAction [] [] get_fw_rule_action(
		string [] route_domains,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_action", new object [] {
				route_domains,
				rules});
		return ((CommonFirewallRuleAction [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_action(string [] route_domains,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_action", new object[] {
			route_domains,
			rules}, callback, asyncState);
	}
	public CommonFirewallRuleAction [] [] Endget_fw_rule_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonFirewallRuleAction [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_fw_rule_description(
		string [] route_domains,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_description", new object [] {
				route_domains,
				rules});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_description(string [] route_domains,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_description", new object[] {
			route_domains,
			rules}, callback, asyncState);
	}
	public string [] [] Endget_fw_rule_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_destination_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_destination_address(
		string [] route_domains,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_destination_address", new object [] {
				route_domains,
				rules});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_address(string [] route_domains,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_address", new object[] {
			route_domains,
			rules}, callback, asyncState);
	}
	public string [] [] [] Endget_fw_rule_destination_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_destination_address_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_destination_address_description(
		string [] route_domains,
		string [] [] rules,
		string [] [] [] addresses
	) {
		object [] results = this.Invoke("get_fw_rule_destination_address_description", new object [] {
				route_domains,
				rules,
				addresses});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_address_description(string [] route_domains,string [] [] rules,string [] [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_address_description", new object[] {
			route_domains,
			rules,
			addresses}, callback, asyncState);
	}
	public string [] [] [] Endget_fw_rule_destination_address_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_destination_address_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_destination_address_list(
		string [] route_domains,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_destination_address_list", new object [] {
				route_domains,
				rules});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_address_list(string [] route_domains,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_address_list", new object[] {
			route_domains,
			rules}, callback, asyncState);
	}
	public string [] [] [] Endget_fw_rule_destination_address_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_destination_address_range
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonAddressRange [] [] [] get_fw_rule_destination_address_range(
		string [] route_domains,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_destination_address_range", new object [] {
				route_domains,
				rules});
		return ((CommonAddressRange [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_address_range(string [] route_domains,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_address_range", new object[] {
			route_domains,
			rules}, callback, asyncState);
	}
	public CommonAddressRange [] [] [] Endget_fw_rule_destination_address_range(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonAddressRange [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_destination_address_range_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_destination_address_range_description(
		string [] route_domains,
		string [] [] rules,
		CommonAddressRange [] [] [] ranges
	) {
		object [] results = this.Invoke("get_fw_rule_destination_address_range_description", new object [] {
				route_domains,
				rules,
				ranges});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_address_range_description(string [] route_domains,string [] [] rules,CommonAddressRange [] [] [] ranges, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_address_range_description", new object[] {
			route_domains,
			rules,
			ranges}, callback, asyncState);
	}
	public string [] [] [] Endget_fw_rule_destination_address_range_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_destination_geo
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonGeoLocation [] [] [] get_fw_rule_destination_geo(
		string [] route_domains,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_destination_geo", new object [] {
				route_domains,
				rules});
		return ((CommonGeoLocation [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_geo(string [] route_domains,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_geo", new object[] {
			route_domains,
			rules}, callback, asyncState);
	}
	public CommonGeoLocation [] [] [] Endget_fw_rule_destination_geo(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonGeoLocation [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_destination_geo_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_destination_geo_description(
		string [] route_domains,
		string [] [] rules,
		CommonGeoLocation [] [] [] geos
	) {
		object [] results = this.Invoke("get_fw_rule_destination_geo_description", new object [] {
				route_domains,
				rules,
				geos});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_geo_description(string [] route_domains,string [] [] rules,CommonGeoLocation [] [] [] geos, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_geo_description", new object[] {
			route_domains,
			rules,
			geos}, callback, asyncState);
	}
	public string [] [] [] Endget_fw_rule_destination_geo_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_destination_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonPortRange [] [] [] get_fw_rule_destination_port(
		string [] route_domains,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_destination_port", new object [] {
				route_domains,
				rules});
		return ((CommonPortRange [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_port(string [] route_domains,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_port", new object[] {
			route_domains,
			rules}, callback, asyncState);
	}
	public CommonPortRange [] [] [] Endget_fw_rule_destination_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonPortRange [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_destination_port_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_destination_port_description(
		string [] route_domains,
		string [] [] rules,
		CommonPortRange [] [] [] ports
	) {
		object [] results = this.Invoke("get_fw_rule_destination_port_description", new object [] {
				route_domains,
				rules,
				ports});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_port_description(string [] route_domains,string [] [] rules,CommonPortRange [] [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_port_description", new object[] {
			route_domains,
			rules,
			ports}, callback, asyncState);
	}
	public string [] [] [] Endget_fw_rule_destination_port_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_destination_port_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_destination_port_list(
		string [] route_domains,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_destination_port_list", new object [] {
				route_domains,
				rules});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_port_list(string [] route_domains,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_port_list", new object[] {
			route_domains,
			rules}, callback, asyncState);
	}
	public string [] [] [] Endget_fw_rule_destination_port_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_icmp_typecode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonFirewallRuleICMPTypeCode [] [] [] get_fw_rule_icmp_typecode(
		string [] route_domains,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_icmp_typecode", new object [] {
				route_domains,
				rules});
		return ((CommonFirewallRuleICMPTypeCode [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_icmp_typecode(string [] route_domains,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_icmp_typecode", new object[] {
			route_domains,
			rules}, callback, asyncState);
	}
	public CommonFirewallRuleICMPTypeCode [] [] [] Endget_fw_rule_icmp_typecode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonFirewallRuleICMPTypeCode [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_icmp_typecode_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_icmp_typecode_description(
		string [] route_domains,
		string [] [] rules,
		CommonFirewallRuleICMPTypeCode [] [] [] typecodes
	) {
		object [] results = this.Invoke("get_fw_rule_icmp_typecode_description", new object [] {
				route_domains,
				rules,
				typecodes});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_icmp_typecode_description(string [] route_domains,string [] [] rules,CommonFirewallRuleICMPTypeCode [] [] [] typecodes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_icmp_typecode_description", new object[] {
			route_domains,
			rules,
			typecodes}, callback, asyncState);
	}
	public string [] [] [] Endget_fw_rule_icmp_typecode_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_irule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_fw_rule_irule(
		string [] route_domains,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_irule", new object [] {
				route_domains,
				rules});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_irule(string [] route_domains,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_irule", new object[] {
			route_domains,
			rules}, callback, asyncState);
	}
	public string [] [] Endget_fw_rule_irule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_log_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_fw_rule_log_state(
		string [] route_domains,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_log_state", new object [] {
				route_domains,
				rules});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_log_state(string [] route_domains,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_log_state", new object[] {
			route_domains,
			rules}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_fw_rule_log_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_order
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_fw_rule_order(
		string [] route_domains,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_order", new object [] {
				route_domains,
				rules});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_order(string [] route_domains,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_order", new object[] {
			route_domains,
			rules}, callback, asyncState);
	}
	public long [] [] Endget_fw_rule_order(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_protocol
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonProtocolType [] [] get_fw_rule_protocol(
		string [] route_domains,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_protocol", new object [] {
				route_domains,
				rules});
		return ((CommonProtocolType [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_protocol(string [] route_domains,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_protocol", new object[] {
			route_domains,
			rules}, callback, asyncState);
	}
	public CommonProtocolType [] [] Endget_fw_rule_protocol(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonProtocolType [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_protocol_numeric
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_fw_rule_protocol_numeric(
		string [] route_domains,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_protocol_numeric", new object [] {
				route_domains,
				rules});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_protocol_numeric(string [] route_domains,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_protocol_numeric", new object[] {
			route_domains,
			rules}, callback, asyncState);
	}
	public long [] [] Endget_fw_rule_protocol_numeric(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_rule_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_fw_rule_rule_list(
		string [] route_domains,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_rule_list", new object [] {
				route_domains,
				rules});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_rule_list(string [] route_domains,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_rule_list", new object[] {
			route_domains,
			rules}, callback, asyncState);
	}
	public string [] [] Endget_fw_rule_rule_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_source_address(
		string [] route_domains,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_source_address", new object [] {
				route_domains,
				rules});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_address(string [] route_domains,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_address", new object[] {
			route_domains,
			rules}, callback, asyncState);
	}
	public string [] [] [] Endget_fw_rule_source_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_address_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_source_address_description(
		string [] route_domains,
		string [] [] rules,
		string [] [] [] addresses
	) {
		object [] results = this.Invoke("get_fw_rule_source_address_description", new object [] {
				route_domains,
				rules,
				addresses});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_address_description(string [] route_domains,string [] [] rules,string [] [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_address_description", new object[] {
			route_domains,
			rules,
			addresses}, callback, asyncState);
	}
	public string [] [] [] Endget_fw_rule_source_address_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_address_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_source_address_list(
		string [] route_domains,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_source_address_list", new object [] {
				route_domains,
				rules});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_address_list(string [] route_domains,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_address_list", new object[] {
			route_domains,
			rules}, callback, asyncState);
	}
	public string [] [] [] Endget_fw_rule_source_address_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_address_range
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonAddressRange [] [] [] get_fw_rule_source_address_range(
		string [] route_domains,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_source_address_range", new object [] {
				route_domains,
				rules});
		return ((CommonAddressRange [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_address_range(string [] route_domains,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_address_range", new object[] {
			route_domains,
			rules}, callback, asyncState);
	}
	public CommonAddressRange [] [] [] Endget_fw_rule_source_address_range(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonAddressRange [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_address_range_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_source_address_range_description(
		string [] route_domains,
		string [] [] rules,
		CommonAddressRange [] [] [] ranges
	) {
		object [] results = this.Invoke("get_fw_rule_source_address_range_description", new object [] {
				route_domains,
				rules,
				ranges});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_address_range_description(string [] route_domains,string [] [] rules,CommonAddressRange [] [] [] ranges, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_address_range_description", new object[] {
			route_domains,
			rules,
			ranges}, callback, asyncState);
	}
	public string [] [] [] Endget_fw_rule_source_address_range_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_geo
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonGeoLocation [] [] [] get_fw_rule_source_geo(
		string [] route_domains,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_source_geo", new object [] {
				route_domains,
				rules});
		return ((CommonGeoLocation [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_geo(string [] route_domains,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_geo", new object[] {
			route_domains,
			rules}, callback, asyncState);
	}
	public CommonGeoLocation [] [] [] Endget_fw_rule_source_geo(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonGeoLocation [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_geo_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_source_geo_description(
		string [] route_domains,
		string [] [] rules,
		CommonGeoLocation [] [] [] geos
	) {
		object [] results = this.Invoke("get_fw_rule_source_geo_description", new object [] {
				route_domains,
				rules,
				geos});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_geo_description(string [] route_domains,string [] [] rules,CommonGeoLocation [] [] [] geos, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_geo_description", new object[] {
			route_domains,
			rules,
			geos}, callback, asyncState);
	}
	public string [] [] [] Endget_fw_rule_source_geo_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonPortRange [] [] [] get_fw_rule_source_port(
		string [] route_domains,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_source_port", new object [] {
				route_domains,
				rules});
		return ((CommonPortRange [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_port(string [] route_domains,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_port", new object[] {
			route_domains,
			rules}, callback, asyncState);
	}
	public CommonPortRange [] [] [] Endget_fw_rule_source_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonPortRange [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_port_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_source_port_description(
		string [] route_domains,
		string [] [] rules,
		CommonPortRange [] [] [] ports
	) {
		object [] results = this.Invoke("get_fw_rule_source_port_description", new object [] {
				route_domains,
				rules,
				ports});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_port_description(string [] route_domains,string [] [] rules,CommonPortRange [] [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_port_description", new object[] {
			route_domains,
			rules,
			ports}, callback, asyncState);
	}
	public string [] [] [] Endget_fw_rule_source_port_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_port_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_source_port_list(
		string [] route_domains,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_source_port_list", new object [] {
				route_domains,
				rules});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_port_list(string [] route_domains,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_port_list", new object[] {
			route_domains,
			rules}, callback, asyncState);
	}
	public string [] [] [] Endget_fw_rule_source_port_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_source_vlan(
		string [] route_domains,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_source_vlan", new object [] {
				route_domains,
				rules});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_vlan(string [] route_domains,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_vlan", new object[] {
			route_domains,
			rules}, callback, asyncState);
	}
	public string [] [] [] Endget_fw_rule_source_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonFirewallRuleState [] [] get_fw_rule_state(
		string [] route_domains,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_state", new object [] {
				route_domains,
				rules});
		return ((CommonFirewallRuleState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_state(string [] route_domains,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_state", new object[] {
			route_domains,
			rules}, callback, asyncState);
	}
	public CommonFirewallRuleState [] [] Endget_fw_rule_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonFirewallRuleState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonFirewallRuleStatistics [] get_fw_rule_statistics(
		string [] route_domains,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_statistics", new object [] {
				route_domains,
				rules});
		return ((CommonFirewallRuleStatistics [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_statistics(string [] route_domains,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_statistics", new object[] {
			route_domains,
			rules}, callback, asyncState);
	}
	public CommonFirewallRuleStatistics [] Endget_fw_rule_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonFirewallRuleStatistics [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_weekly_schedule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_fw_rule_weekly_schedule(
		string [] route_domains,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_weekly_schedule", new object [] {
				route_domains,
				rules});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_weekly_schedule(string [] route_domains,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_weekly_schedule", new object[] {
			route_domains,
			rules}, callback, asyncState);
	}
	public string [] [] Endget_fw_rule_weekly_schedule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_identifier
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_identifier(
		string [] route_domains
	) {
		object [] results = this.Invoke("get_identifier", new object [] {
				route_domains});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_identifier(string [] route_domains, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_identifier", new object[] {
			route_domains}, callback, asyncState);
	}
	public long [] Endget_identifier(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ip_intelligence_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_ip_intelligence_policy(
		string [] route_domains
	) {
		object [] results = this.Invoke("get_ip_intelligence_policy", new object [] {
				route_domains});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_ip_intelligence_policy(string [] route_domains, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ip_intelligence_policy", new object[] {
			route_domains}, callback, asyncState);
	}
	public string [] Endget_ip_intelligence_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
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
	// get_parent
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_parent(
		string [] route_domains
	) {
		object [] results = this.Invoke("get_parent", new object [] {
				route_domains});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_parent(string [] route_domains, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_parent", new object[] {
			route_domains}, callback, asyncState);
	}
	public string [] Endget_parent(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_routing_protocol
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingRouteDomainV2RoutingProtocol [] [] get_routing_protocol(
		string [] route_domains
	) {
		object [] results = this.Invoke("get_routing_protocol", new object [] {
				route_domains});
		return ((NetworkingRouteDomainV2RoutingProtocol [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_routing_protocol(string [] route_domains, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_routing_protocol", new object[] {
			route_domains}, callback, asyncState);
	}
	public NetworkingRouteDomainV2RoutingProtocol [] [] Endget_routing_protocol(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingRouteDomainV2RoutingProtocol [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_staged_firewall_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_staged_firewall_policy(
		string [] route_domains
	) {
		object [] results = this.Invoke("get_staged_firewall_policy", new object [] {
				route_domains});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_staged_firewall_policy(string [] route_domains, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_staged_firewall_policy", new object[] {
			route_domains}, callback, asyncState);
	}
	public string [] Endget_staged_firewall_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_strict_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_strict_state(
		string [] route_domains
	) {
		object [] results = this.Invoke("get_strict_state", new object [] {
				route_domains});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_strict_state(string [] route_domains, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_strict_state", new object[] {
			route_domains}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_strict_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
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
	// get_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_vlan(
		string [] route_domains
	) {
		object [] results = this.Invoke("get_vlan", new object [] {
				route_domains});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_vlan(string [] route_domains, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_vlan", new object[] {
			route_domains}, callback, asyncState);
	}
	public string [] [] Endget_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_destination_address_lists
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void remove_all_fw_rule_destination_address_lists(
		string [] route_domains,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_destination_address_lists", new object [] {
				route_domains,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_destination_address_lists(string [] route_domains,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_destination_address_lists", new object[] {
			route_domains,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_destination_address_lists(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_destination_address_ranges
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void remove_all_fw_rule_destination_address_ranges(
		string [] route_domains,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_destination_address_ranges", new object [] {
				route_domains,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_destination_address_ranges(string [] route_domains,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_destination_address_ranges", new object[] {
			route_domains,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_destination_address_ranges(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_destination_addresses
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void remove_all_fw_rule_destination_addresses(
		string [] route_domains,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_destination_addresses", new object [] {
				route_domains,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_destination_addresses(string [] route_domains,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_destination_addresses", new object[] {
			route_domains,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_destination_addresses(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_destination_geos
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void remove_all_fw_rule_destination_geos(
		string [] route_domains,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_destination_geos", new object [] {
				route_domains,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_destination_geos(string [] route_domains,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_destination_geos", new object[] {
			route_domains,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_destination_geos(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_destination_port_lists
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void remove_all_fw_rule_destination_port_lists(
		string [] route_domains,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_destination_port_lists", new object [] {
				route_domains,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_destination_port_lists(string [] route_domains,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_destination_port_lists", new object[] {
			route_domains,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_destination_port_lists(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_destination_ports
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void remove_all_fw_rule_destination_ports(
		string [] route_domains,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_destination_ports", new object [] {
				route_domains,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_destination_ports(string [] route_domains,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_destination_ports", new object[] {
			route_domains,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_destination_ports(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_icmp_typecodes
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void remove_all_fw_rule_icmp_typecodes(
		string [] route_domains,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_icmp_typecodes", new object [] {
				route_domains,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_icmp_typecodes(string [] route_domains,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_icmp_typecodes", new object[] {
			route_domains,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_icmp_typecodes(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_source_address_lists
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void remove_all_fw_rule_source_address_lists(
		string [] route_domains,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_source_address_lists", new object [] {
				route_domains,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_source_address_lists(string [] route_domains,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_source_address_lists", new object[] {
			route_domains,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_source_address_lists(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_source_address_ranges
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void remove_all_fw_rule_source_address_ranges(
		string [] route_domains,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_source_address_ranges", new object [] {
				route_domains,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_source_address_ranges(string [] route_domains,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_source_address_ranges", new object[] {
			route_domains,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_source_address_ranges(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_source_addresses
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void remove_all_fw_rule_source_addresses(
		string [] route_domains,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_source_addresses", new object [] {
				route_domains,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_source_addresses(string [] route_domains,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_source_addresses", new object[] {
			route_domains,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_source_addresses(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_source_geos
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void remove_all_fw_rule_source_geos(
		string [] route_domains,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_source_geos", new object [] {
				route_domains,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_source_geos(string [] route_domains,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_source_geos", new object[] {
			route_domains,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_source_geos(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_source_port_lists
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void remove_all_fw_rule_source_port_lists(
		string [] route_domains,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_source_port_lists", new object [] {
				route_domains,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_source_port_lists(string [] route_domains,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_source_port_lists", new object[] {
			route_domains,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_source_port_lists(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_source_ports
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void remove_all_fw_rule_source_ports(
		string [] route_domains,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_source_ports", new object [] {
				route_domains,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_source_ports(string [] route_domains,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_source_ports", new object[] {
			route_domains,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_source_ports(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_source_vlans
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void remove_all_fw_rule_source_vlans(
		string [] route_domains,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_source_vlans", new object [] {
				route_domains,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_source_vlans(string [] route_domains,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_source_vlans", new object[] {
			route_domains,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_source_vlans(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rules
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void remove_all_fw_rules(
		string [] route_domains
	) {
		this.Invoke("remove_all_fw_rules", new object [] {
				route_domains});

	}
	public System.IAsyncResult Beginremove_all_fw_rules(string [] route_domains, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rules", new object[] {
			route_domains}, callback, asyncState);
	}
	public void Endremove_all_fw_rules(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_routing_protocols
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void remove_all_routing_protocols(
		string [] route_domains
	) {
		this.Invoke("remove_all_routing_protocols", new object [] {
				route_domains});

	}
	public System.IAsyncResult Beginremove_all_routing_protocols(string [] route_domains, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_routing_protocols", new object[] {
			route_domains}, callback, asyncState);
	}
	public void Endremove_all_routing_protocols(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_vlans
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void remove_all_vlans(
		string [] route_domains
	) {
		this.Invoke("remove_all_vlans", new object [] {
				route_domains});

	}
	public System.IAsyncResult Beginremove_all_vlans(string [] route_domains, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_vlans", new object[] {
			route_domains}, callback, asyncState);
	}
	public void Endremove_all_vlans(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void remove_fw_rule(
		string [] route_domains,
		string [] [] rules
	) {
		this.Invoke("remove_fw_rule", new object [] {
				route_domains,
				rules});

	}
	public System.IAsyncResult Beginremove_fw_rule(string [] route_domains,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule", new object[] {
			route_domains,
			rules}, callback, asyncState);
	}
	public void Endremove_fw_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_destination_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void remove_fw_rule_destination_address(
		string [] route_domains,
		string [] [] rules,
		string [] [] [] addresses
	) {
		this.Invoke("remove_fw_rule_destination_address", new object [] {
				route_domains,
				rules,
				addresses});

	}
	public System.IAsyncResult Beginremove_fw_rule_destination_address(string [] route_domains,string [] [] rules,string [] [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_destination_address", new object[] {
			route_domains,
			rules,
			addresses}, callback, asyncState);
	}
	public void Endremove_fw_rule_destination_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_destination_address_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void remove_fw_rule_destination_address_list(
		string [] route_domains,
		string [] [] rules,
		string [] [] [] lists
	) {
		this.Invoke("remove_fw_rule_destination_address_list", new object [] {
				route_domains,
				rules,
				lists});

	}
	public System.IAsyncResult Beginremove_fw_rule_destination_address_list(string [] route_domains,string [] [] rules,string [] [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_destination_address_list", new object[] {
			route_domains,
			rules,
			lists}, callback, asyncState);
	}
	public void Endremove_fw_rule_destination_address_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_destination_address_range
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void remove_fw_rule_destination_address_range(
		string [] route_domains,
		string [] [] rules,
		CommonAddressRange [] [] [] ranges
	) {
		this.Invoke("remove_fw_rule_destination_address_range", new object [] {
				route_domains,
				rules,
				ranges});

	}
	public System.IAsyncResult Beginremove_fw_rule_destination_address_range(string [] route_domains,string [] [] rules,CommonAddressRange [] [] [] ranges, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_destination_address_range", new object[] {
			route_domains,
			rules,
			ranges}, callback, asyncState);
	}
	public void Endremove_fw_rule_destination_address_range(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_destination_geo
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void remove_fw_rule_destination_geo(
		string [] route_domains,
		string [] [] rules,
		CommonGeoLocation [] [] [] geos
	) {
		this.Invoke("remove_fw_rule_destination_geo", new object [] {
				route_domains,
				rules,
				geos});

	}
	public System.IAsyncResult Beginremove_fw_rule_destination_geo(string [] route_domains,string [] [] rules,CommonGeoLocation [] [] [] geos, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_destination_geo", new object[] {
			route_domains,
			rules,
			geos}, callback, asyncState);
	}
	public void Endremove_fw_rule_destination_geo(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_destination_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void remove_fw_rule_destination_port(
		string [] route_domains,
		string [] [] rules,
		CommonPortRange [] [] [] ports
	) {
		this.Invoke("remove_fw_rule_destination_port", new object [] {
				route_domains,
				rules,
				ports});

	}
	public System.IAsyncResult Beginremove_fw_rule_destination_port(string [] route_domains,string [] [] rules,CommonPortRange [] [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_destination_port", new object[] {
			route_domains,
			rules,
			ports}, callback, asyncState);
	}
	public void Endremove_fw_rule_destination_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_destination_port_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void remove_fw_rule_destination_port_list(
		string [] route_domains,
		string [] [] rules,
		string [] [] [] lists
	) {
		this.Invoke("remove_fw_rule_destination_port_list", new object [] {
				route_domains,
				rules,
				lists});

	}
	public System.IAsyncResult Beginremove_fw_rule_destination_port_list(string [] route_domains,string [] [] rules,string [] [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_destination_port_list", new object[] {
			route_domains,
			rules,
			lists}, callback, asyncState);
	}
	public void Endremove_fw_rule_destination_port_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_icmp_typecode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void remove_fw_rule_icmp_typecode(
		string [] route_domains,
		string [] [] rules,
		CommonFirewallRuleICMPTypeCode [] [] [] typecodes
	) {
		this.Invoke("remove_fw_rule_icmp_typecode", new object [] {
				route_domains,
				rules,
				typecodes});

	}
	public System.IAsyncResult Beginremove_fw_rule_icmp_typecode(string [] route_domains,string [] [] rules,CommonFirewallRuleICMPTypeCode [] [] [] typecodes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_icmp_typecode", new object[] {
			route_domains,
			rules,
			typecodes}, callback, asyncState);
	}
	public void Endremove_fw_rule_icmp_typecode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_source_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void remove_fw_rule_source_address(
		string [] route_domains,
		string [] [] rules,
		string [] [] [] addresses
	) {
		this.Invoke("remove_fw_rule_source_address", new object [] {
				route_domains,
				rules,
				addresses});

	}
	public System.IAsyncResult Beginremove_fw_rule_source_address(string [] route_domains,string [] [] rules,string [] [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_source_address", new object[] {
			route_domains,
			rules,
			addresses}, callback, asyncState);
	}
	public void Endremove_fw_rule_source_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_source_address_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void remove_fw_rule_source_address_list(
		string [] route_domains,
		string [] [] rules,
		string [] [] [] lists
	) {
		this.Invoke("remove_fw_rule_source_address_list", new object [] {
				route_domains,
				rules,
				lists});

	}
	public System.IAsyncResult Beginremove_fw_rule_source_address_list(string [] route_domains,string [] [] rules,string [] [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_source_address_list", new object[] {
			route_domains,
			rules,
			lists}, callback, asyncState);
	}
	public void Endremove_fw_rule_source_address_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_source_address_range
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void remove_fw_rule_source_address_range(
		string [] route_domains,
		string [] [] rules,
		CommonAddressRange [] [] [] ranges
	) {
		this.Invoke("remove_fw_rule_source_address_range", new object [] {
				route_domains,
				rules,
				ranges});

	}
	public System.IAsyncResult Beginremove_fw_rule_source_address_range(string [] route_domains,string [] [] rules,CommonAddressRange [] [] [] ranges, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_source_address_range", new object[] {
			route_domains,
			rules,
			ranges}, callback, asyncState);
	}
	public void Endremove_fw_rule_source_address_range(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_source_geo
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void remove_fw_rule_source_geo(
		string [] route_domains,
		string [] [] rules,
		CommonGeoLocation [] [] [] geos
	) {
		this.Invoke("remove_fw_rule_source_geo", new object [] {
				route_domains,
				rules,
				geos});

	}
	public System.IAsyncResult Beginremove_fw_rule_source_geo(string [] route_domains,string [] [] rules,CommonGeoLocation [] [] [] geos, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_source_geo", new object[] {
			route_domains,
			rules,
			geos}, callback, asyncState);
	}
	public void Endremove_fw_rule_source_geo(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_source_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void remove_fw_rule_source_port(
		string [] route_domains,
		string [] [] rules,
		CommonPortRange [] [] [] ports
	) {
		this.Invoke("remove_fw_rule_source_port", new object [] {
				route_domains,
				rules,
				ports});

	}
	public System.IAsyncResult Beginremove_fw_rule_source_port(string [] route_domains,string [] [] rules,CommonPortRange [] [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_source_port", new object[] {
			route_domains,
			rules,
			ports}, callback, asyncState);
	}
	public void Endremove_fw_rule_source_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_source_port_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void remove_fw_rule_source_port_list(
		string [] route_domains,
		string [] [] rules,
		string [] [] [] lists
	) {
		this.Invoke("remove_fw_rule_source_port_list", new object [] {
				route_domains,
				rules,
				lists});

	}
	public System.IAsyncResult Beginremove_fw_rule_source_port_list(string [] route_domains,string [] [] rules,string [] [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_source_port_list", new object[] {
			route_domains,
			rules,
			lists}, callback, asyncState);
	}
	public void Endremove_fw_rule_source_port_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_source_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void remove_fw_rule_source_vlan(
		string [] route_domains,
		string [] [] rules,
		string [] [] [] vlans
	) {
		this.Invoke("remove_fw_rule_source_vlan", new object [] {
				route_domains,
				rules,
				vlans});

	}
	public System.IAsyncResult Beginremove_fw_rule_source_vlan(string [] route_domains,string [] [] rules,string [] [] [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_source_vlan", new object[] {
			route_domains,
			rules,
			vlans}, callback, asyncState);
	}
	public void Endremove_fw_rule_source_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_routing_protocol
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void remove_routing_protocol(
		string [] route_domains,
		NetworkingRouteDomainV2RoutingProtocol [] [] protocols
	) {
		this.Invoke("remove_routing_protocol", new object [] {
				route_domains,
				protocols});

	}
	public System.IAsyncResult Beginremove_routing_protocol(string [] route_domains,NetworkingRouteDomainV2RoutingProtocol [] [] protocols, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_routing_protocol", new object[] {
			route_domains,
			protocols}, callback, asyncState);
	}
	public void Endremove_routing_protocol(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void remove_vlan(
		string [] route_domains,
		string [] [] vlans
	) {
		this.Invoke("remove_vlan", new object [] {
				route_domains,
				vlans});

	}
	public System.IAsyncResult Beginremove_vlan(string [] route_domains,string [] [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_vlan", new object[] {
			route_domains,
			vlans}, callback, asyncState);
	}
	public void Endremove_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_fw_rule_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void reset_fw_rule_statistics(
		string [] route_domains,
		string [] [] rules
	) {
		this.Invoke("reset_fw_rule_statistics", new object [] {
				route_domains,
				rules});

	}
	public System.IAsyncResult Beginreset_fw_rule_statistics(string [] route_domains,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_fw_rule_statistics", new object[] {
			route_domains,
			rules}, callback, asyncState);
	}
	public void Endreset_fw_rule_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_bw_controller_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void set_bw_controller_policy(
		string [] route_domains,
		string [] policies
	) {
		this.Invoke("set_bw_controller_policy", new object [] {
				route_domains,
				policies});

	}
	public System.IAsyncResult Beginset_bw_controller_policy(string [] route_domains,string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_bw_controller_policy", new object[] {
			route_domains,
			policies}, callback, asyncState);
	}
	public void Endset_bw_controller_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void set_description(
		string [] route_domains,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				route_domains,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] route_domains,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			route_domains,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_enforced_firewall_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void set_enforced_firewall_policy(
		string [] route_domains,
		string [] policies
	) {
		this.Invoke("set_enforced_firewall_policy", new object [] {
				route_domains,
				policies});

	}
	public System.IAsyncResult Beginset_enforced_firewall_policy(string [] route_domains,string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_enforced_firewall_policy", new object[] {
			route_domains,
			policies}, callback, asyncState);
	}
	public void Endset_enforced_firewall_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void set_fw_rule_action(
		string [] route_domains,
		string [] [] rules,
		CommonFirewallRuleAction [] [] actions
	) {
		this.Invoke("set_fw_rule_action", new object [] {
				route_domains,
				rules,
				actions});

	}
	public System.IAsyncResult Beginset_fw_rule_action(string [] route_domains,string [] [] rules,CommonFirewallRuleAction [] [] actions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_action", new object[] {
			route_domains,
			rules,
			actions}, callback, asyncState);
	}
	public void Endset_fw_rule_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void set_fw_rule_description(
		string [] route_domains,
		string [] [] rules,
		string [] [] descriptions
	) {
		this.Invoke("set_fw_rule_description", new object [] {
				route_domains,
				rules,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_description(string [] route_domains,string [] [] rules,string [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_description", new object[] {
			route_domains,
			rules,
			descriptions}, callback, asyncState);
	}
	public void Endset_fw_rule_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_destination_address_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void set_fw_rule_destination_address_description(
		string [] route_domains,
		string [] [] rules,
		string [] [] [] addresses,
		string [] [] [] descriptions
	) {
		this.Invoke("set_fw_rule_destination_address_description", new object [] {
				route_domains,
				rules,
				addresses,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_destination_address_description(string [] route_domains,string [] [] rules,string [] [] [] addresses,string [] [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_destination_address_description", new object[] {
			route_domains,
			rules,
			addresses,
			descriptions}, callback, asyncState);
	}
	public void Endset_fw_rule_destination_address_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_destination_address_range_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void set_fw_rule_destination_address_range_description(
		string [] route_domains,
		string [] [] rules,
		CommonAddressRange [] [] [] ranges,
		string [] [] [] descriptions
	) {
		this.Invoke("set_fw_rule_destination_address_range_description", new object [] {
				route_domains,
				rules,
				ranges,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_destination_address_range_description(string [] route_domains,string [] [] rules,CommonAddressRange [] [] [] ranges,string [] [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_destination_address_range_description", new object[] {
			route_domains,
			rules,
			ranges,
			descriptions}, callback, asyncState);
	}
	public void Endset_fw_rule_destination_address_range_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_destination_geo_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void set_fw_rule_destination_geo_description(
		string [] route_domains,
		string [] [] rules,
		CommonGeoLocation [] [] [] geos,
		string [] [] [] descriptions
	) {
		this.Invoke("set_fw_rule_destination_geo_description", new object [] {
				route_domains,
				rules,
				geos,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_destination_geo_description(string [] route_domains,string [] [] rules,CommonGeoLocation [] [] [] geos,string [] [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_destination_geo_description", new object[] {
			route_domains,
			rules,
			geos,
			descriptions}, callback, asyncState);
	}
	public void Endset_fw_rule_destination_geo_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_destination_port_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void set_fw_rule_destination_port_description(
		string [] route_domains,
		string [] [] rules,
		CommonPortRange [] [] [] ports,
		string [] [] [] descriptions
	) {
		this.Invoke("set_fw_rule_destination_port_description", new object [] {
				route_domains,
				rules,
				ports,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_destination_port_description(string [] route_domains,string [] [] rules,CommonPortRange [] [] [] ports,string [] [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_destination_port_description", new object[] {
			route_domains,
			rules,
			ports,
			descriptions}, callback, asyncState);
	}
	public void Endset_fw_rule_destination_port_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_icmp_typecode_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void set_fw_rule_icmp_typecode_description(
		string [] route_domains,
		string [] [] rules,
		CommonFirewallRuleICMPTypeCode [] [] [] typecodes,
		string [] [] [] descriptions
	) {
		this.Invoke("set_fw_rule_icmp_typecode_description", new object [] {
				route_domains,
				rules,
				typecodes,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_icmp_typecode_description(string [] route_domains,string [] [] rules,CommonFirewallRuleICMPTypeCode [] [] [] typecodes,string [] [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_icmp_typecode_description", new object[] {
			route_domains,
			rules,
			typecodes,
			descriptions}, callback, asyncState);
	}
	public void Endset_fw_rule_icmp_typecode_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_irule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void set_fw_rule_irule(
		string [] route_domains,
		string [] [] rules,
		string [] [] irules
	) {
		this.Invoke("set_fw_rule_irule", new object [] {
				route_domains,
				rules,
				irules});

	}
	public System.IAsyncResult Beginset_fw_rule_irule(string [] route_domains,string [] [] rules,string [] [] irules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_irule", new object[] {
			route_domains,
			rules,
			irules}, callback, asyncState);
	}
	public void Endset_fw_rule_irule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_log_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void set_fw_rule_log_state(
		string [] route_domains,
		string [] [] rules,
		CommonEnabledState [] [] states
	) {
		this.Invoke("set_fw_rule_log_state", new object [] {
				route_domains,
				rules,
				states});

	}
	public System.IAsyncResult Beginset_fw_rule_log_state(string [] route_domains,string [] [] rules,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_log_state", new object[] {
			route_domains,
			rules,
			states}, callback, asyncState);
	}
	public void Endset_fw_rule_log_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_order
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void set_fw_rule_order(
		string [] route_domains,
		string [] [] rules,
		long [] [] orders
	) {
		this.Invoke("set_fw_rule_order", new object [] {
				route_domains,
				rules,
				orders});

	}
	public System.IAsyncResult Beginset_fw_rule_order(string [] route_domains,string [] [] rules,long [] [] orders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_order", new object[] {
			route_domains,
			rules,
			orders}, callback, asyncState);
	}
	public void Endset_fw_rule_order(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_protocol
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void set_fw_rule_protocol(
		string [] route_domains,
		string [] [] rules,
		CommonProtocolType [] [] protocols
	) {
		this.Invoke("set_fw_rule_protocol", new object [] {
				route_domains,
				rules,
				protocols});

	}
	public System.IAsyncResult Beginset_fw_rule_protocol(string [] route_domains,string [] [] rules,CommonProtocolType [] [] protocols, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_protocol", new object[] {
			route_domains,
			rules,
			protocols}, callback, asyncState);
	}
	public void Endset_fw_rule_protocol(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_protocol_numeric
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void set_fw_rule_protocol_numeric(
		string [] route_domains,
		string [] [] rules,
		long [] [] protocols
	) {
		this.Invoke("set_fw_rule_protocol_numeric", new object [] {
				route_domains,
				rules,
				protocols});

	}
	public System.IAsyncResult Beginset_fw_rule_protocol_numeric(string [] route_domains,string [] [] rules,long [] [] protocols, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_protocol_numeric", new object[] {
			route_domains,
			rules,
			protocols}, callback, asyncState);
	}
	public void Endset_fw_rule_protocol_numeric(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_rule_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void set_fw_rule_rule_list(
		string [] route_domains,
		string [] [] rules,
		string [] [] lists
	) {
		this.Invoke("set_fw_rule_rule_list", new object [] {
				route_domains,
				rules,
				lists});

	}
	public System.IAsyncResult Beginset_fw_rule_rule_list(string [] route_domains,string [] [] rules,string [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_rule_list", new object[] {
			route_domains,
			rules,
			lists}, callback, asyncState);
	}
	public void Endset_fw_rule_rule_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_source_address_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void set_fw_rule_source_address_description(
		string [] route_domains,
		string [] [] rules,
		string [] [] [] addresses,
		string [] [] [] descriptions
	) {
		this.Invoke("set_fw_rule_source_address_description", new object [] {
				route_domains,
				rules,
				addresses,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_source_address_description(string [] route_domains,string [] [] rules,string [] [] [] addresses,string [] [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_source_address_description", new object[] {
			route_domains,
			rules,
			addresses,
			descriptions}, callback, asyncState);
	}
	public void Endset_fw_rule_source_address_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_source_address_range_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void set_fw_rule_source_address_range_description(
		string [] route_domains,
		string [] [] rules,
		CommonAddressRange [] [] [] ranges,
		string [] [] [] descriptions
	) {
		this.Invoke("set_fw_rule_source_address_range_description", new object [] {
				route_domains,
				rules,
				ranges,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_source_address_range_description(string [] route_domains,string [] [] rules,CommonAddressRange [] [] [] ranges,string [] [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_source_address_range_description", new object[] {
			route_domains,
			rules,
			ranges,
			descriptions}, callback, asyncState);
	}
	public void Endset_fw_rule_source_address_range_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_source_geo_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void set_fw_rule_source_geo_description(
		string [] route_domains,
		string [] [] rules,
		CommonGeoLocation [] [] [] geos,
		string [] [] [] descriptions
	) {
		this.Invoke("set_fw_rule_source_geo_description", new object [] {
				route_domains,
				rules,
				geos,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_source_geo_description(string [] route_domains,string [] [] rules,CommonGeoLocation [] [] [] geos,string [] [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_source_geo_description", new object[] {
			route_domains,
			rules,
			geos,
			descriptions}, callback, asyncState);
	}
	public void Endset_fw_rule_source_geo_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_source_port_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void set_fw_rule_source_port_description(
		string [] route_domains,
		string [] [] rules,
		CommonPortRange [] [] [] ports,
		string [] [] [] descriptions
	) {
		this.Invoke("set_fw_rule_source_port_description", new object [] {
				route_domains,
				rules,
				ports,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_source_port_description(string [] route_domains,string [] [] rules,CommonPortRange [] [] [] ports,string [] [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_source_port_description", new object[] {
			route_domains,
			rules,
			ports,
			descriptions}, callback, asyncState);
	}
	public void Endset_fw_rule_source_port_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void set_fw_rule_state(
		string [] route_domains,
		string [] [] rules,
		CommonFirewallRuleState [] [] states
	) {
		this.Invoke("set_fw_rule_state", new object [] {
				route_domains,
				rules,
				states});

	}
	public System.IAsyncResult Beginset_fw_rule_state(string [] route_domains,string [] [] rules,CommonFirewallRuleState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_state", new object[] {
			route_domains,
			rules,
			states}, callback, asyncState);
	}
	public void Endset_fw_rule_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_weekly_schedule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void set_fw_rule_weekly_schedule(
		string [] route_domains,
		string [] [] rules,
		string [] [] schedules
	) {
		this.Invoke("set_fw_rule_weekly_schedule", new object [] {
				route_domains,
				rules,
				schedules});

	}
	public System.IAsyncResult Beginset_fw_rule_weekly_schedule(string [] route_domains,string [] [] rules,string [] [] schedules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_weekly_schedule", new object[] {
			route_domains,
			rules,
			schedules}, callback, asyncState);
	}
	public void Endset_fw_rule_weekly_schedule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ip_intelligence_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void set_ip_intelligence_policy(
		string [] route_domains,
		string [] policies
	) {
		this.Invoke("set_ip_intelligence_policy", new object [] {
				route_domains,
				policies});

	}
	public System.IAsyncResult Beginset_ip_intelligence_policy(string [] route_domains,string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ip_intelligence_policy", new object[] {
			route_domains,
			policies}, callback, asyncState);
	}
	public void Endset_ip_intelligence_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_parent
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void set_parent(
		string [] route_domains,
		string [] names
	) {
		this.Invoke("set_parent", new object [] {
				route_domains,
				names});

	}
	public System.IAsyncResult Beginset_parent(string [] route_domains,string [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_parent", new object[] {
			route_domains,
			names}, callback, asyncState);
	}
	public void Endset_parent(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_staged_firewall_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void set_staged_firewall_policy(
		string [] route_domains,
		string [] policies
	) {
		this.Invoke("set_staged_firewall_policy", new object [] {
				route_domains,
				policies});

	}
	public System.IAsyncResult Beginset_staged_firewall_policy(string [] route_domains,string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_staged_firewall_policy", new object[] {
			route_domains,
			policies}, callback, asyncState);
	}
	public void Endset_staged_firewall_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_strict_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouteDomainV2", 
		RequestNamespace="urn:iControl:Networking/RouteDomainV2", ResponseNamespace="urn:iControl:Networking/RouteDomainV2")]
	public void set_strict_state(
		string [] route_domains,
		CommonEnabledState [] states
	) {
		this.Invoke("set_strict_state", new object [] {
				route_domains,
				states});

	}
	public System.IAsyncResult Beginset_strict_state(string [] route_domains,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_strict_state", new object[] {
			route_domains,
			states}, callback, asyncState);
	}
	public void Endset_strict_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.RouteDomainV2.RoutingProtocol", Namespace = "urn:iControl")]
	public enum NetworkingRouteDomainV2RoutingProtocol
	{
		ROUTING_PROTOCOL_UNKNOWN,
		ROUTING_PROTOCOL_BGP,
		ROUTING_PROTOCOL_ISIS,
		ROUTING_PROTOCOL_OSPF_V2,
		ROUTING_PROTOCOL_OSPF_V3,
		ROUTING_PROTOCOL_RIP,
		ROUTING_PROTOCOL_RIP_NG,
		ROUTING_PROTOCOL_BFD,
	}

	//=======================================================================
	// Structs
	//=======================================================================

}
