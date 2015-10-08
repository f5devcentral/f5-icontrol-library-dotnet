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
	[System.Web.Services.WebServiceBindingAttribute(Name="Networking.SelfIPV2Binding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(NetworkingSelfIPV2ProtocolPortAccess))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonFirewallRulePlacement))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonFirewallRuleStatistics))]
	public partial class NetworkingSelfIPV2 : iControlInterface {
		public NetworkingSelfIPV2() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_allow_access_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void add_allow_access_list(
		string [] self_ips,
		NetworkingSelfIPV2ProtocolPortAccess [] access_lists
	) {
		this.Invoke("add_allow_access_list", new object [] {
				self_ips,
				access_lists});

	}
	public System.IAsyncResult Beginadd_allow_access_list(string [] self_ips,NetworkingSelfIPV2ProtocolPortAccess [] access_lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_allow_access_list", new object[] {
			self_ips,
			access_lists}, callback, asyncState);
	}
	public void Endadd_allow_access_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_default_protocol_port_access_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void add_default_protocol_port_access_list(
		NetworkingSelfIPV2ProtocolPort [] defaults
	) {
		this.Invoke("add_default_protocol_port_access_list", new object [] {
				defaults});

	}
	public System.IAsyncResult Beginadd_default_protocol_port_access_list(NetworkingSelfIPV2ProtocolPort [] defaults, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_default_protocol_port_access_list", new object[] {
			defaults}, callback, asyncState);
	}
	public void Endadd_default_protocol_port_access_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void add_fw_rule(
		string [] self_ips,
		string [] [] rules,
		CommonFirewallRulePlacement [] [] placements,
		CommonFirewallRuleAction [] [] actions,
		CommonFirewallRuleState [] [] states
	) {
		this.Invoke("add_fw_rule", new object [] {
				self_ips,
				rules,
				placements,
				actions,
				states});

	}
	public System.IAsyncResult Beginadd_fw_rule(string [] self_ips,string [] [] rules,CommonFirewallRulePlacement [] [] placements,CommonFirewallRuleAction [] [] actions,CommonFirewallRuleState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule", new object[] {
			self_ips,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void add_fw_rule_destination_address(
		string [] self_ips,
		string [] [] rules,
		string [] [] [] addresses
	) {
		this.Invoke("add_fw_rule_destination_address", new object [] {
				self_ips,
				rules,
				addresses});

	}
	public System.IAsyncResult Beginadd_fw_rule_destination_address(string [] self_ips,string [] [] rules,string [] [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_destination_address", new object[] {
			self_ips,
			rules,
			addresses}, callback, asyncState);
	}
	public void Endadd_fw_rule_destination_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_destination_address_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void add_fw_rule_destination_address_list(
		string [] self_ips,
		string [] [] rules,
		string [] [] [] lists
	) {
		this.Invoke("add_fw_rule_destination_address_list", new object [] {
				self_ips,
				rules,
				lists});

	}
	public System.IAsyncResult Beginadd_fw_rule_destination_address_list(string [] self_ips,string [] [] rules,string [] [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_destination_address_list", new object[] {
			self_ips,
			rules,
			lists}, callback, asyncState);
	}
	public void Endadd_fw_rule_destination_address_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_destination_address_range
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void add_fw_rule_destination_address_range(
		string [] self_ips,
		string [] [] rules,
		CommonAddressRange [] [] [] ranges
	) {
		this.Invoke("add_fw_rule_destination_address_range", new object [] {
				self_ips,
				rules,
				ranges});

	}
	public System.IAsyncResult Beginadd_fw_rule_destination_address_range(string [] self_ips,string [] [] rules,CommonAddressRange [] [] [] ranges, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_destination_address_range", new object[] {
			self_ips,
			rules,
			ranges}, callback, asyncState);
	}
	public void Endadd_fw_rule_destination_address_range(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_destination_geo
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void add_fw_rule_destination_geo(
		string [] self_ips,
		string [] [] rules,
		CommonGeoLocation [] [] [] geos
	) {
		this.Invoke("add_fw_rule_destination_geo", new object [] {
				self_ips,
				rules,
				geos});

	}
	public System.IAsyncResult Beginadd_fw_rule_destination_geo(string [] self_ips,string [] [] rules,CommonGeoLocation [] [] [] geos, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_destination_geo", new object[] {
			self_ips,
			rules,
			geos}, callback, asyncState);
	}
	public void Endadd_fw_rule_destination_geo(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_destination_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void add_fw_rule_destination_port(
		string [] self_ips,
		string [] [] rules,
		CommonPortRange [] [] [] ports
	) {
		this.Invoke("add_fw_rule_destination_port", new object [] {
				self_ips,
				rules,
				ports});

	}
	public System.IAsyncResult Beginadd_fw_rule_destination_port(string [] self_ips,string [] [] rules,CommonPortRange [] [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_destination_port", new object[] {
			self_ips,
			rules,
			ports}, callback, asyncState);
	}
	public void Endadd_fw_rule_destination_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_destination_port_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void add_fw_rule_destination_port_list(
		string [] self_ips,
		string [] [] rules,
		string [] [] [] lists
	) {
		this.Invoke("add_fw_rule_destination_port_list", new object [] {
				self_ips,
				rules,
				lists});

	}
	public System.IAsyncResult Beginadd_fw_rule_destination_port_list(string [] self_ips,string [] [] rules,string [] [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_destination_port_list", new object[] {
			self_ips,
			rules,
			lists}, callback, asyncState);
	}
	public void Endadd_fw_rule_destination_port_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_icmp_typecode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void add_fw_rule_icmp_typecode(
		string [] self_ips,
		string [] [] rules,
		CommonFirewallRuleICMPTypeCode [] [] [] typecodes
	) {
		this.Invoke("add_fw_rule_icmp_typecode", new object [] {
				self_ips,
				rules,
				typecodes});

	}
	public System.IAsyncResult Beginadd_fw_rule_icmp_typecode(string [] self_ips,string [] [] rules,CommonFirewallRuleICMPTypeCode [] [] [] typecodes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_icmp_typecode", new object[] {
			self_ips,
			rules,
			typecodes}, callback, asyncState);
	}
	public void Endadd_fw_rule_icmp_typecode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_source_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void add_fw_rule_source_address(
		string [] self_ips,
		string [] [] rules,
		string [] [] [] addresses
	) {
		this.Invoke("add_fw_rule_source_address", new object [] {
				self_ips,
				rules,
				addresses});

	}
	public System.IAsyncResult Beginadd_fw_rule_source_address(string [] self_ips,string [] [] rules,string [] [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_source_address", new object[] {
			self_ips,
			rules,
			addresses}, callback, asyncState);
	}
	public void Endadd_fw_rule_source_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_source_address_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void add_fw_rule_source_address_list(
		string [] self_ips,
		string [] [] rules,
		string [] [] [] lists
	) {
		this.Invoke("add_fw_rule_source_address_list", new object [] {
				self_ips,
				rules,
				lists});

	}
	public System.IAsyncResult Beginadd_fw_rule_source_address_list(string [] self_ips,string [] [] rules,string [] [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_source_address_list", new object[] {
			self_ips,
			rules,
			lists}, callback, asyncState);
	}
	public void Endadd_fw_rule_source_address_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_source_address_range
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void add_fw_rule_source_address_range(
		string [] self_ips,
		string [] [] rules,
		CommonAddressRange [] [] [] ranges
	) {
		this.Invoke("add_fw_rule_source_address_range", new object [] {
				self_ips,
				rules,
				ranges});

	}
	public System.IAsyncResult Beginadd_fw_rule_source_address_range(string [] self_ips,string [] [] rules,CommonAddressRange [] [] [] ranges, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_source_address_range", new object[] {
			self_ips,
			rules,
			ranges}, callback, asyncState);
	}
	public void Endadd_fw_rule_source_address_range(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_source_geo
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void add_fw_rule_source_geo(
		string [] self_ips,
		string [] [] rules,
		CommonGeoLocation [] [] [] geos
	) {
		this.Invoke("add_fw_rule_source_geo", new object [] {
				self_ips,
				rules,
				geos});

	}
	public System.IAsyncResult Beginadd_fw_rule_source_geo(string [] self_ips,string [] [] rules,CommonGeoLocation [] [] [] geos, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_source_geo", new object[] {
			self_ips,
			rules,
			geos}, callback, asyncState);
	}
	public void Endadd_fw_rule_source_geo(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_source_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void add_fw_rule_source_port(
		string [] self_ips,
		string [] [] rules,
		CommonPortRange [] [] [] ports
	) {
		this.Invoke("add_fw_rule_source_port", new object [] {
				self_ips,
				rules,
				ports});

	}
	public System.IAsyncResult Beginadd_fw_rule_source_port(string [] self_ips,string [] [] rules,CommonPortRange [] [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_source_port", new object[] {
			self_ips,
			rules,
			ports}, callback, asyncState);
	}
	public void Endadd_fw_rule_source_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_source_port_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void add_fw_rule_source_port_list(
		string [] self_ips,
		string [] [] rules,
		string [] [] [] lists
	) {
		this.Invoke("add_fw_rule_source_port_list", new object [] {
				self_ips,
				rules,
				lists});

	}
	public System.IAsyncResult Beginadd_fw_rule_source_port_list(string [] self_ips,string [] [] rules,string [] [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_source_port_list", new object[] {
			self_ips,
			rules,
			lists}, callback, asyncState);
	}
	public void Endadd_fw_rule_source_port_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_source_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void add_fw_rule_source_vlan(
		string [] self_ips,
		string [] [] rules,
		string [] [] [] vlans
	) {
		this.Invoke("add_fw_rule_source_vlan", new object [] {
				self_ips,
				rules,
				vlans});

	}
	public System.IAsyncResult Beginadd_fw_rule_source_vlan(string [] self_ips,string [] [] rules,string [] [] [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_source_vlan", new object[] {
			self_ips,
			rules,
			vlans}, callback, asyncState);
	}
	public void Endadd_fw_rule_source_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_with_rule_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void add_fw_rule_with_rule_list(
		string [] self_ips,
		string [] [] rules,
		CommonFirewallRulePlacement [] [] placements,
		string [] [] lists,
		CommonFirewallRuleState [] [] states
	) {
		this.Invoke("add_fw_rule_with_rule_list", new object [] {
				self_ips,
				rules,
				placements,
				lists,
				states});

	}
	public System.IAsyncResult Beginadd_fw_rule_with_rule_list(string [] self_ips,string [] [] rules,CommonFirewallRulePlacement [] [] placements,string [] [] lists,CommonFirewallRuleState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_with_rule_list", new object[] {
			self_ips,
			rules,
			placements,
			lists,
			states}, callback, asyncState);
	}
	public void Endadd_fw_rule_with_rule_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void create(
		string [] self_ips,
		string [] vlan_names,
		string [] addresses,
		string [] netmasks,
		string [] traffic_groups,
		CommonEnabledState [] floating_states
	) {
		this.Invoke("create", new object [] {
				self_ips,
				vlan_names,
				addresses,
				netmasks,
				traffic_groups,
				floating_states});

	}
	public System.IAsyncResult Begincreate(string [] self_ips,string [] vlan_names,string [] addresses,string [] netmasks,string [] traffic_groups,CommonEnabledState [] floating_states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			self_ips,
			vlan_names,
			addresses,
			netmasks,
			traffic_groups,
			floating_states}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_self_ips
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void delete_all_self_ips(

	) {
		this.Invoke("delete_all_self_ips", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_self_ips(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_self_ips", new object[0], callback, asyncState);
	}
	public void Enddelete_all_self_ips(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_self_ip
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void delete_self_ip(
		string [] self_ips
	) {
		this.Invoke("delete_self_ip", new object [] {
				self_ips});

	}
	public System.IAsyncResult Begindelete_self_ip(string [] self_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_self_ip", new object[] {
			self_ips}, callback, asyncState);
	}
	public void Enddelete_self_ip(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_address(
		string [] self_ips
	) {
		object [] results = this.Invoke("get_address", new object [] {
				self_ips});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_address(string [] self_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_address", new object[] {
			self_ips}, callback, asyncState);
	}
	public string [] Endget_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_all_fw_rule_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonFirewallRuleStatistics [] get_all_fw_rule_statistics(
		string [] self_ips
	) {
		object [] results = this.Invoke("get_all_fw_rule_statistics", new object [] {
				self_ips});
		return ((CommonFirewallRuleStatistics [])(results[0]));
	}
	public System.IAsyncResult Beginget_all_fw_rule_statistics(string [] self_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_fw_rule_statistics", new object[] {
			self_ips}, callback, asyncState);
	}
	public CommonFirewallRuleStatistics [] Endget_all_fw_rule_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonFirewallRuleStatistics [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_allow_access_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingSelfIPV2ProtocolPortAccess [] get_allow_access_list(
		string [] self_ips
	) {
		object [] results = this.Invoke("get_allow_access_list", new object [] {
				self_ips});
		return ((NetworkingSelfIPV2ProtocolPortAccess [])(results[0]));
	}
	public System.IAsyncResult Beginget_allow_access_list(string [] self_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_allow_access_list", new object[] {
			self_ips}, callback, asyncState);
	}
	public NetworkingSelfIPV2ProtocolPortAccess [] Endget_allow_access_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingSelfIPV2ProtocolPortAccess [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default_protocol_port_access_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingSelfIPV2ProtocolPort [] get_default_protocol_port_access_list(

	) {
		object [] results = this.Invoke("get_default_protocol_port_access_list", new object [0]);
		return ((NetworkingSelfIPV2ProtocolPort [])(results[0]));
	}
	public System.IAsyncResult Beginget_default_protocol_port_access_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_default_protocol_port_access_list", new object[0], callback, asyncState);
	}
	public NetworkingSelfIPV2ProtocolPort [] Endget_default_protocol_port_access_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingSelfIPV2ProtocolPort [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] self_ips
	) {
		object [] results = this.Invoke("get_description", new object [] {
				self_ips});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] self_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			self_ips}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_enforced_firewall_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_enforced_firewall_policy(
		string [] self_ips
	) {
		object [] results = this.Invoke("get_enforced_firewall_policy", new object [] {
				self_ips});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_enforced_firewall_policy(string [] self_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_enforced_firewall_policy", new object[] {
			self_ips}, callback, asyncState);
	}
	public string [] Endget_enforced_firewall_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_floating_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_floating_state(
		string [] self_ips
	) {
		object [] results = this.Invoke("get_floating_state", new object [] {
				self_ips});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_floating_state(string [] self_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_floating_state", new object[] {
			self_ips}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_floating_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_fw_rule(
		string [] self_ips
	) {
		object [] results = this.Invoke("get_fw_rule", new object [] {
				self_ips});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule(string [] self_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule", new object[] {
			self_ips}, callback, asyncState);
	}
	public string [] [] Endget_fw_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonFirewallRuleAction [] [] get_fw_rule_action(
		string [] self_ips,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_action", new object [] {
				self_ips,
				rules});
		return ((CommonFirewallRuleAction [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_action(string [] self_ips,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_action", new object[] {
			self_ips,
			rules}, callback, asyncState);
	}
	public CommonFirewallRuleAction [] [] Endget_fw_rule_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonFirewallRuleAction [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_fw_rule_description(
		string [] self_ips,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_description", new object [] {
				self_ips,
				rules});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_description(string [] self_ips,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_description", new object[] {
			self_ips,
			rules}, callback, asyncState);
	}
	public string [] [] Endget_fw_rule_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_destination_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_destination_address(
		string [] self_ips,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_destination_address", new object [] {
				self_ips,
				rules});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_address(string [] self_ips,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_address", new object[] {
			self_ips,
			rules}, callback, asyncState);
	}
	public string [] [] [] Endget_fw_rule_destination_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_destination_address_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_destination_address_description(
		string [] self_ips,
		string [] [] rules,
		string [] [] [] addresses
	) {
		object [] results = this.Invoke("get_fw_rule_destination_address_description", new object [] {
				self_ips,
				rules,
				addresses});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_address_description(string [] self_ips,string [] [] rules,string [] [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_address_description", new object[] {
			self_ips,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_destination_address_list(
		string [] self_ips,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_destination_address_list", new object [] {
				self_ips,
				rules});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_address_list(string [] self_ips,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_address_list", new object[] {
			self_ips,
			rules}, callback, asyncState);
	}
	public string [] [] [] Endget_fw_rule_destination_address_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_destination_address_range
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonAddressRange [] [] [] get_fw_rule_destination_address_range(
		string [] self_ips,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_destination_address_range", new object [] {
				self_ips,
				rules});
		return ((CommonAddressRange [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_address_range(string [] self_ips,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_address_range", new object[] {
			self_ips,
			rules}, callback, asyncState);
	}
	public CommonAddressRange [] [] [] Endget_fw_rule_destination_address_range(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonAddressRange [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_destination_address_range_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_destination_address_range_description(
		string [] self_ips,
		string [] [] rules,
		CommonAddressRange [] [] [] ranges
	) {
		object [] results = this.Invoke("get_fw_rule_destination_address_range_description", new object [] {
				self_ips,
				rules,
				ranges});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_address_range_description(string [] self_ips,string [] [] rules,CommonAddressRange [] [] [] ranges, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_address_range_description", new object[] {
			self_ips,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonGeoLocation [] [] [] get_fw_rule_destination_geo(
		string [] self_ips,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_destination_geo", new object [] {
				self_ips,
				rules});
		return ((CommonGeoLocation [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_geo(string [] self_ips,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_geo", new object[] {
			self_ips,
			rules}, callback, asyncState);
	}
	public CommonGeoLocation [] [] [] Endget_fw_rule_destination_geo(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonGeoLocation [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_destination_geo_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_destination_geo_description(
		string [] self_ips,
		string [] [] rules,
		CommonGeoLocation [] [] [] geos
	) {
		object [] results = this.Invoke("get_fw_rule_destination_geo_description", new object [] {
				self_ips,
				rules,
				geos});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_geo_description(string [] self_ips,string [] [] rules,CommonGeoLocation [] [] [] geos, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_geo_description", new object[] {
			self_ips,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonPortRange [] [] [] get_fw_rule_destination_port(
		string [] self_ips,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_destination_port", new object [] {
				self_ips,
				rules});
		return ((CommonPortRange [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_port(string [] self_ips,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_port", new object[] {
			self_ips,
			rules}, callback, asyncState);
	}
	public CommonPortRange [] [] [] Endget_fw_rule_destination_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonPortRange [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_destination_port_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_destination_port_description(
		string [] self_ips,
		string [] [] rules,
		CommonPortRange [] [] [] ports
	) {
		object [] results = this.Invoke("get_fw_rule_destination_port_description", new object [] {
				self_ips,
				rules,
				ports});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_port_description(string [] self_ips,string [] [] rules,CommonPortRange [] [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_port_description", new object[] {
			self_ips,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_destination_port_list(
		string [] self_ips,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_destination_port_list", new object [] {
				self_ips,
				rules});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_port_list(string [] self_ips,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_port_list", new object[] {
			self_ips,
			rules}, callback, asyncState);
	}
	public string [] [] [] Endget_fw_rule_destination_port_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_icmp_typecode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonFirewallRuleICMPTypeCode [] [] [] get_fw_rule_icmp_typecode(
		string [] self_ips,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_icmp_typecode", new object [] {
				self_ips,
				rules});
		return ((CommonFirewallRuleICMPTypeCode [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_icmp_typecode(string [] self_ips,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_icmp_typecode", new object[] {
			self_ips,
			rules}, callback, asyncState);
	}
	public CommonFirewallRuleICMPTypeCode [] [] [] Endget_fw_rule_icmp_typecode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonFirewallRuleICMPTypeCode [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_icmp_typecode_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_icmp_typecode_description(
		string [] self_ips,
		string [] [] rules,
		CommonFirewallRuleICMPTypeCode [] [] [] typecodes
	) {
		object [] results = this.Invoke("get_fw_rule_icmp_typecode_description", new object [] {
				self_ips,
				rules,
				typecodes});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_icmp_typecode_description(string [] self_ips,string [] [] rules,CommonFirewallRuleICMPTypeCode [] [] [] typecodes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_icmp_typecode_description", new object[] {
			self_ips,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_fw_rule_irule(
		string [] self_ips,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_irule", new object [] {
				self_ips,
				rules});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_irule(string [] self_ips,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_irule", new object[] {
			self_ips,
			rules}, callback, asyncState);
	}
	public string [] [] Endget_fw_rule_irule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_log_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_fw_rule_log_state(
		string [] self_ips,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_log_state", new object [] {
				self_ips,
				rules});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_log_state(string [] self_ips,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_log_state", new object[] {
			self_ips,
			rules}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_fw_rule_log_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_order
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_fw_rule_order(
		string [] self_ips,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_order", new object [] {
				self_ips,
				rules});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_order(string [] self_ips,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_order", new object[] {
			self_ips,
			rules}, callback, asyncState);
	}
	public long [] [] Endget_fw_rule_order(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_protocol
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonProtocolType [] [] get_fw_rule_protocol(
		string [] self_ips,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_protocol", new object [] {
				self_ips,
				rules});
		return ((CommonProtocolType [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_protocol(string [] self_ips,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_protocol", new object[] {
			self_ips,
			rules}, callback, asyncState);
	}
	public CommonProtocolType [] [] Endget_fw_rule_protocol(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonProtocolType [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_protocol_numeric
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_fw_rule_protocol_numeric(
		string [] self_ips,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_protocol_numeric", new object [] {
				self_ips,
				rules});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_protocol_numeric(string [] self_ips,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_protocol_numeric", new object[] {
			self_ips,
			rules}, callback, asyncState);
	}
	public long [] [] Endget_fw_rule_protocol_numeric(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_rule_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_fw_rule_rule_list(
		string [] self_ips,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_rule_list", new object [] {
				self_ips,
				rules});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_rule_list(string [] self_ips,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_rule_list", new object[] {
			self_ips,
			rules}, callback, asyncState);
	}
	public string [] [] Endget_fw_rule_rule_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_source_address(
		string [] self_ips,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_source_address", new object [] {
				self_ips,
				rules});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_address(string [] self_ips,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_address", new object[] {
			self_ips,
			rules}, callback, asyncState);
	}
	public string [] [] [] Endget_fw_rule_source_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_address_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_source_address_description(
		string [] self_ips,
		string [] [] rules,
		string [] [] [] addresses
	) {
		object [] results = this.Invoke("get_fw_rule_source_address_description", new object [] {
				self_ips,
				rules,
				addresses});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_address_description(string [] self_ips,string [] [] rules,string [] [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_address_description", new object[] {
			self_ips,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_source_address_list(
		string [] self_ips,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_source_address_list", new object [] {
				self_ips,
				rules});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_address_list(string [] self_ips,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_address_list", new object[] {
			self_ips,
			rules}, callback, asyncState);
	}
	public string [] [] [] Endget_fw_rule_source_address_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_address_range
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonAddressRange [] [] [] get_fw_rule_source_address_range(
		string [] self_ips,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_source_address_range", new object [] {
				self_ips,
				rules});
		return ((CommonAddressRange [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_address_range(string [] self_ips,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_address_range", new object[] {
			self_ips,
			rules}, callback, asyncState);
	}
	public CommonAddressRange [] [] [] Endget_fw_rule_source_address_range(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonAddressRange [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_address_range_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_source_address_range_description(
		string [] self_ips,
		string [] [] rules,
		CommonAddressRange [] [] [] ranges
	) {
		object [] results = this.Invoke("get_fw_rule_source_address_range_description", new object [] {
				self_ips,
				rules,
				ranges});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_address_range_description(string [] self_ips,string [] [] rules,CommonAddressRange [] [] [] ranges, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_address_range_description", new object[] {
			self_ips,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonGeoLocation [] [] [] get_fw_rule_source_geo(
		string [] self_ips,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_source_geo", new object [] {
				self_ips,
				rules});
		return ((CommonGeoLocation [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_geo(string [] self_ips,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_geo", new object[] {
			self_ips,
			rules}, callback, asyncState);
	}
	public CommonGeoLocation [] [] [] Endget_fw_rule_source_geo(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonGeoLocation [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_geo_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_source_geo_description(
		string [] self_ips,
		string [] [] rules,
		CommonGeoLocation [] [] [] geos
	) {
		object [] results = this.Invoke("get_fw_rule_source_geo_description", new object [] {
				self_ips,
				rules,
				geos});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_geo_description(string [] self_ips,string [] [] rules,CommonGeoLocation [] [] [] geos, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_geo_description", new object[] {
			self_ips,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonPortRange [] [] [] get_fw_rule_source_port(
		string [] self_ips,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_source_port", new object [] {
				self_ips,
				rules});
		return ((CommonPortRange [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_port(string [] self_ips,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_port", new object[] {
			self_ips,
			rules}, callback, asyncState);
	}
	public CommonPortRange [] [] [] Endget_fw_rule_source_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonPortRange [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_port_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_source_port_description(
		string [] self_ips,
		string [] [] rules,
		CommonPortRange [] [] [] ports
	) {
		object [] results = this.Invoke("get_fw_rule_source_port_description", new object [] {
				self_ips,
				rules,
				ports});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_port_description(string [] self_ips,string [] [] rules,CommonPortRange [] [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_port_description", new object[] {
			self_ips,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_source_port_list(
		string [] self_ips,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_source_port_list", new object [] {
				self_ips,
				rules});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_port_list(string [] self_ips,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_port_list", new object[] {
			self_ips,
			rules}, callback, asyncState);
	}
	public string [] [] [] Endget_fw_rule_source_port_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_source_vlan(
		string [] self_ips,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_source_vlan", new object [] {
				self_ips,
				rules});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_vlan(string [] self_ips,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_vlan", new object[] {
			self_ips,
			rules}, callback, asyncState);
	}
	public string [] [] [] Endget_fw_rule_source_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonFirewallRuleState [] [] get_fw_rule_state(
		string [] self_ips,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_state", new object [] {
				self_ips,
				rules});
		return ((CommonFirewallRuleState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_state(string [] self_ips,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_state", new object[] {
			self_ips,
			rules}, callback, asyncState);
	}
	public CommonFirewallRuleState [] [] Endget_fw_rule_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonFirewallRuleState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonFirewallRuleStatistics [] get_fw_rule_statistics(
		string [] self_ips,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_statistics", new object [] {
				self_ips,
				rules});
		return ((CommonFirewallRuleStatistics [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_statistics(string [] self_ips,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_statistics", new object[] {
			self_ips,
			rules}, callback, asyncState);
	}
	public CommonFirewallRuleStatistics [] Endget_fw_rule_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonFirewallRuleStatistics [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_weekly_schedule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_fw_rule_weekly_schedule(
		string [] self_ips,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_weekly_schedule", new object [] {
				self_ips,
				rules});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_weekly_schedule(string [] self_ips,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_weekly_schedule", new object[] {
			self_ips,
			rules}, callback, asyncState);
	}
	public string [] [] Endget_fw_rule_weekly_schedule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
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
	// get_netmask
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_netmask(
		string [] self_ips
	) {
		object [] results = this.Invoke("get_netmask", new object [] {
				self_ips});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_netmask(string [] self_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_netmask", new object[] {
			self_ips}, callback, asyncState);
	}
	public string [] Endget_netmask(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_staged_firewall_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_staged_firewall_policy(
		string [] self_ips
	) {
		object [] results = this.Invoke("get_staged_firewall_policy", new object [] {
				self_ips});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_staged_firewall_policy(string [] self_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_staged_firewall_policy", new object[] {
			self_ips}, callback, asyncState);
	}
	public string [] Endget_staged_firewall_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_traffic_group
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_traffic_group(
		string [] self_ips
	) {
		object [] results = this.Invoke("get_traffic_group", new object [] {
				self_ips});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_traffic_group(string [] self_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_traffic_group", new object[] {
			self_ips}, callback, asyncState);
	}
	public string [] Endget_traffic_group(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_vlan(
		string [] self_ips
	) {
		object [] results = this.Invoke("get_vlan", new object [] {
				self_ips});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_vlan(string [] self_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_vlan", new object[] {
			self_ips}, callback, asyncState);
	}
	public string [] Endget_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// is_traffic_group_inherited
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] is_traffic_group_inherited(
		string [] self_ips
	) {
		object [] results = this.Invoke("is_traffic_group_inherited", new object [] {
				self_ips});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginis_traffic_group_inherited(string [] self_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("is_traffic_group_inherited", new object[] {
			self_ips}, callback, asyncState);
	}
	public bool [] Endis_traffic_group_inherited(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_destination_address_lists
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void remove_all_fw_rule_destination_address_lists(
		string [] self_ips,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_destination_address_lists", new object [] {
				self_ips,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_destination_address_lists(string [] self_ips,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_destination_address_lists", new object[] {
			self_ips,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_destination_address_lists(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_destination_address_ranges
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void remove_all_fw_rule_destination_address_ranges(
		string [] self_ips,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_destination_address_ranges", new object [] {
				self_ips,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_destination_address_ranges(string [] self_ips,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_destination_address_ranges", new object[] {
			self_ips,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_destination_address_ranges(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_destination_addresses
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void remove_all_fw_rule_destination_addresses(
		string [] self_ips,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_destination_addresses", new object [] {
				self_ips,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_destination_addresses(string [] self_ips,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_destination_addresses", new object[] {
			self_ips,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_destination_addresses(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_destination_geos
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void remove_all_fw_rule_destination_geos(
		string [] self_ips,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_destination_geos", new object [] {
				self_ips,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_destination_geos(string [] self_ips,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_destination_geos", new object[] {
			self_ips,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_destination_geos(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_destination_port_lists
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void remove_all_fw_rule_destination_port_lists(
		string [] self_ips,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_destination_port_lists", new object [] {
				self_ips,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_destination_port_lists(string [] self_ips,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_destination_port_lists", new object[] {
			self_ips,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_destination_port_lists(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_destination_ports
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void remove_all_fw_rule_destination_ports(
		string [] self_ips,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_destination_ports", new object [] {
				self_ips,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_destination_ports(string [] self_ips,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_destination_ports", new object[] {
			self_ips,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_destination_ports(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_icmp_typecodes
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void remove_all_fw_rule_icmp_typecodes(
		string [] self_ips,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_icmp_typecodes", new object [] {
				self_ips,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_icmp_typecodes(string [] self_ips,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_icmp_typecodes", new object[] {
			self_ips,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_icmp_typecodes(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_source_address_lists
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void remove_all_fw_rule_source_address_lists(
		string [] self_ips,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_source_address_lists", new object [] {
				self_ips,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_source_address_lists(string [] self_ips,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_source_address_lists", new object[] {
			self_ips,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_source_address_lists(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_source_address_ranges
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void remove_all_fw_rule_source_address_ranges(
		string [] self_ips,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_source_address_ranges", new object [] {
				self_ips,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_source_address_ranges(string [] self_ips,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_source_address_ranges", new object[] {
			self_ips,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_source_address_ranges(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_source_addresses
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void remove_all_fw_rule_source_addresses(
		string [] self_ips,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_source_addresses", new object [] {
				self_ips,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_source_addresses(string [] self_ips,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_source_addresses", new object[] {
			self_ips,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_source_addresses(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_source_geos
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void remove_all_fw_rule_source_geos(
		string [] self_ips,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_source_geos", new object [] {
				self_ips,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_source_geos(string [] self_ips,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_source_geos", new object[] {
			self_ips,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_source_geos(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_source_port_lists
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void remove_all_fw_rule_source_port_lists(
		string [] self_ips,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_source_port_lists", new object [] {
				self_ips,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_source_port_lists(string [] self_ips,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_source_port_lists", new object[] {
			self_ips,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_source_port_lists(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_source_ports
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void remove_all_fw_rule_source_ports(
		string [] self_ips,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_source_ports", new object [] {
				self_ips,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_source_ports(string [] self_ips,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_source_ports", new object[] {
			self_ips,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_source_ports(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_source_vlans
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void remove_all_fw_rule_source_vlans(
		string [] self_ips,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_source_vlans", new object [] {
				self_ips,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_source_vlans(string [] self_ips,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_source_vlans", new object[] {
			self_ips,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_source_vlans(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rules
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void remove_all_fw_rules(
		string [] self_ips
	) {
		this.Invoke("remove_all_fw_rules", new object [] {
				self_ips});

	}
	public System.IAsyncResult Beginremove_all_fw_rules(string [] self_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rules", new object[] {
			self_ips}, callback, asyncState);
	}
	public void Endremove_all_fw_rules(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_allow_access_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void remove_allow_access_list(
		string [] self_ips,
		NetworkingSelfIPV2ProtocolPortAccess [] access_lists
	) {
		this.Invoke("remove_allow_access_list", new object [] {
				self_ips,
				access_lists});

	}
	public System.IAsyncResult Beginremove_allow_access_list(string [] self_ips,NetworkingSelfIPV2ProtocolPortAccess [] access_lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_allow_access_list", new object[] {
			self_ips,
			access_lists}, callback, asyncState);
	}
	public void Endremove_allow_access_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_default_protocol_port_access_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void remove_default_protocol_port_access_list(
		NetworkingSelfIPV2ProtocolPort [] defaults
	) {
		this.Invoke("remove_default_protocol_port_access_list", new object [] {
				defaults});

	}
	public System.IAsyncResult Beginremove_default_protocol_port_access_list(NetworkingSelfIPV2ProtocolPort [] defaults, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_default_protocol_port_access_list", new object[] {
			defaults}, callback, asyncState);
	}
	public void Endremove_default_protocol_port_access_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void remove_fw_rule(
		string [] self_ips,
		string [] [] rules
	) {
		this.Invoke("remove_fw_rule", new object [] {
				self_ips,
				rules});

	}
	public System.IAsyncResult Beginremove_fw_rule(string [] self_ips,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule", new object[] {
			self_ips,
			rules}, callback, asyncState);
	}
	public void Endremove_fw_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_destination_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void remove_fw_rule_destination_address(
		string [] self_ips,
		string [] [] rules,
		string [] [] [] addresses
	) {
		this.Invoke("remove_fw_rule_destination_address", new object [] {
				self_ips,
				rules,
				addresses});

	}
	public System.IAsyncResult Beginremove_fw_rule_destination_address(string [] self_ips,string [] [] rules,string [] [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_destination_address", new object[] {
			self_ips,
			rules,
			addresses}, callback, asyncState);
	}
	public void Endremove_fw_rule_destination_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_destination_address_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void remove_fw_rule_destination_address_list(
		string [] self_ips,
		string [] [] rules,
		string [] [] [] lists
	) {
		this.Invoke("remove_fw_rule_destination_address_list", new object [] {
				self_ips,
				rules,
				lists});

	}
	public System.IAsyncResult Beginremove_fw_rule_destination_address_list(string [] self_ips,string [] [] rules,string [] [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_destination_address_list", new object[] {
			self_ips,
			rules,
			lists}, callback, asyncState);
	}
	public void Endremove_fw_rule_destination_address_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_destination_address_range
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void remove_fw_rule_destination_address_range(
		string [] self_ips,
		string [] [] rules,
		CommonAddressRange [] [] [] ranges
	) {
		this.Invoke("remove_fw_rule_destination_address_range", new object [] {
				self_ips,
				rules,
				ranges});

	}
	public System.IAsyncResult Beginremove_fw_rule_destination_address_range(string [] self_ips,string [] [] rules,CommonAddressRange [] [] [] ranges, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_destination_address_range", new object[] {
			self_ips,
			rules,
			ranges}, callback, asyncState);
	}
	public void Endremove_fw_rule_destination_address_range(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_destination_geo
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void remove_fw_rule_destination_geo(
		string [] self_ips,
		string [] [] rules,
		CommonGeoLocation [] [] [] geos
	) {
		this.Invoke("remove_fw_rule_destination_geo", new object [] {
				self_ips,
				rules,
				geos});

	}
	public System.IAsyncResult Beginremove_fw_rule_destination_geo(string [] self_ips,string [] [] rules,CommonGeoLocation [] [] [] geos, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_destination_geo", new object[] {
			self_ips,
			rules,
			geos}, callback, asyncState);
	}
	public void Endremove_fw_rule_destination_geo(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_destination_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void remove_fw_rule_destination_port(
		string [] self_ips,
		string [] [] rules,
		CommonPortRange [] [] [] ports
	) {
		this.Invoke("remove_fw_rule_destination_port", new object [] {
				self_ips,
				rules,
				ports});

	}
	public System.IAsyncResult Beginremove_fw_rule_destination_port(string [] self_ips,string [] [] rules,CommonPortRange [] [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_destination_port", new object[] {
			self_ips,
			rules,
			ports}, callback, asyncState);
	}
	public void Endremove_fw_rule_destination_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_destination_port_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void remove_fw_rule_destination_port_list(
		string [] self_ips,
		string [] [] rules,
		string [] [] [] lists
	) {
		this.Invoke("remove_fw_rule_destination_port_list", new object [] {
				self_ips,
				rules,
				lists});

	}
	public System.IAsyncResult Beginremove_fw_rule_destination_port_list(string [] self_ips,string [] [] rules,string [] [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_destination_port_list", new object[] {
			self_ips,
			rules,
			lists}, callback, asyncState);
	}
	public void Endremove_fw_rule_destination_port_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_icmp_typecode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void remove_fw_rule_icmp_typecode(
		string [] self_ips,
		string [] [] rules,
		CommonFirewallRuleICMPTypeCode [] [] [] typecodes
	) {
		this.Invoke("remove_fw_rule_icmp_typecode", new object [] {
				self_ips,
				rules,
				typecodes});

	}
	public System.IAsyncResult Beginremove_fw_rule_icmp_typecode(string [] self_ips,string [] [] rules,CommonFirewallRuleICMPTypeCode [] [] [] typecodes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_icmp_typecode", new object[] {
			self_ips,
			rules,
			typecodes}, callback, asyncState);
	}
	public void Endremove_fw_rule_icmp_typecode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_source_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void remove_fw_rule_source_address(
		string [] self_ips,
		string [] [] rules,
		string [] [] [] addresses
	) {
		this.Invoke("remove_fw_rule_source_address", new object [] {
				self_ips,
				rules,
				addresses});

	}
	public System.IAsyncResult Beginremove_fw_rule_source_address(string [] self_ips,string [] [] rules,string [] [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_source_address", new object[] {
			self_ips,
			rules,
			addresses}, callback, asyncState);
	}
	public void Endremove_fw_rule_source_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_source_address_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void remove_fw_rule_source_address_list(
		string [] self_ips,
		string [] [] rules,
		string [] [] [] lists
	) {
		this.Invoke("remove_fw_rule_source_address_list", new object [] {
				self_ips,
				rules,
				lists});

	}
	public System.IAsyncResult Beginremove_fw_rule_source_address_list(string [] self_ips,string [] [] rules,string [] [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_source_address_list", new object[] {
			self_ips,
			rules,
			lists}, callback, asyncState);
	}
	public void Endremove_fw_rule_source_address_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_source_address_range
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void remove_fw_rule_source_address_range(
		string [] self_ips,
		string [] [] rules,
		CommonAddressRange [] [] [] ranges
	) {
		this.Invoke("remove_fw_rule_source_address_range", new object [] {
				self_ips,
				rules,
				ranges});

	}
	public System.IAsyncResult Beginremove_fw_rule_source_address_range(string [] self_ips,string [] [] rules,CommonAddressRange [] [] [] ranges, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_source_address_range", new object[] {
			self_ips,
			rules,
			ranges}, callback, asyncState);
	}
	public void Endremove_fw_rule_source_address_range(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_source_geo
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void remove_fw_rule_source_geo(
		string [] self_ips,
		string [] [] rules,
		CommonGeoLocation [] [] [] geos
	) {
		this.Invoke("remove_fw_rule_source_geo", new object [] {
				self_ips,
				rules,
				geos});

	}
	public System.IAsyncResult Beginremove_fw_rule_source_geo(string [] self_ips,string [] [] rules,CommonGeoLocation [] [] [] geos, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_source_geo", new object[] {
			self_ips,
			rules,
			geos}, callback, asyncState);
	}
	public void Endremove_fw_rule_source_geo(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_source_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void remove_fw_rule_source_port(
		string [] self_ips,
		string [] [] rules,
		CommonPortRange [] [] [] ports
	) {
		this.Invoke("remove_fw_rule_source_port", new object [] {
				self_ips,
				rules,
				ports});

	}
	public System.IAsyncResult Beginremove_fw_rule_source_port(string [] self_ips,string [] [] rules,CommonPortRange [] [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_source_port", new object[] {
			self_ips,
			rules,
			ports}, callback, asyncState);
	}
	public void Endremove_fw_rule_source_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_source_port_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void remove_fw_rule_source_port_list(
		string [] self_ips,
		string [] [] rules,
		string [] [] [] lists
	) {
		this.Invoke("remove_fw_rule_source_port_list", new object [] {
				self_ips,
				rules,
				lists});

	}
	public System.IAsyncResult Beginremove_fw_rule_source_port_list(string [] self_ips,string [] [] rules,string [] [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_source_port_list", new object[] {
			self_ips,
			rules,
			lists}, callback, asyncState);
	}
	public void Endremove_fw_rule_source_port_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_source_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void remove_fw_rule_source_vlan(
		string [] self_ips,
		string [] [] rules,
		string [] [] [] vlans
	) {
		this.Invoke("remove_fw_rule_source_vlan", new object [] {
				self_ips,
				rules,
				vlans});

	}
	public System.IAsyncResult Beginremove_fw_rule_source_vlan(string [] self_ips,string [] [] rules,string [] [] [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_source_vlan", new object[] {
			self_ips,
			rules,
			vlans}, callback, asyncState);
	}
	public void Endremove_fw_rule_source_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_fw_rule_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void reset_fw_rule_statistics(
		string [] self_ips,
		string [] [] rules
	) {
		this.Invoke("reset_fw_rule_statistics", new object [] {
				self_ips,
				rules});

	}
	public System.IAsyncResult Beginreset_fw_rule_statistics(string [] self_ips,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_fw_rule_statistics", new object[] {
			self_ips,
			rules}, callback, asyncState);
	}
	public void Endreset_fw_rule_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void set_description(
		string [] self_ips,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				self_ips,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] self_ips,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			self_ips,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_enforced_firewall_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void set_enforced_firewall_policy(
		string [] self_ips,
		string [] policies
	) {
		this.Invoke("set_enforced_firewall_policy", new object [] {
				self_ips,
				policies});

	}
	public System.IAsyncResult Beginset_enforced_firewall_policy(string [] self_ips,string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_enforced_firewall_policy", new object[] {
			self_ips,
			policies}, callback, asyncState);
	}
	public void Endset_enforced_firewall_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_floating_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void set_floating_state(
		string [] self_ips,
		CommonEnabledState [] states
	) {
		this.Invoke("set_floating_state", new object [] {
				self_ips,
				states});

	}
	public System.IAsyncResult Beginset_floating_state(string [] self_ips,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_floating_state", new object[] {
			self_ips,
			states}, callback, asyncState);
	}
	public void Endset_floating_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void set_fw_rule_action(
		string [] self_ips,
		string [] [] rules,
		CommonFirewallRuleAction [] [] actions
	) {
		this.Invoke("set_fw_rule_action", new object [] {
				self_ips,
				rules,
				actions});

	}
	public System.IAsyncResult Beginset_fw_rule_action(string [] self_ips,string [] [] rules,CommonFirewallRuleAction [] [] actions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_action", new object[] {
			self_ips,
			rules,
			actions}, callback, asyncState);
	}
	public void Endset_fw_rule_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void set_fw_rule_description(
		string [] self_ips,
		string [] [] rules,
		string [] [] descriptions
	) {
		this.Invoke("set_fw_rule_description", new object [] {
				self_ips,
				rules,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_description(string [] self_ips,string [] [] rules,string [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_description", new object[] {
			self_ips,
			rules,
			descriptions}, callback, asyncState);
	}
	public void Endset_fw_rule_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_destination_address_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void set_fw_rule_destination_address_description(
		string [] self_ips,
		string [] [] rules,
		string [] [] [] addresses,
		string [] [] [] descriptions
	) {
		this.Invoke("set_fw_rule_destination_address_description", new object [] {
				self_ips,
				rules,
				addresses,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_destination_address_description(string [] self_ips,string [] [] rules,string [] [] [] addresses,string [] [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_destination_address_description", new object[] {
			self_ips,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void set_fw_rule_destination_address_range_description(
		string [] self_ips,
		string [] [] rules,
		CommonAddressRange [] [] [] ranges,
		string [] [] [] descriptions
	) {
		this.Invoke("set_fw_rule_destination_address_range_description", new object [] {
				self_ips,
				rules,
				ranges,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_destination_address_range_description(string [] self_ips,string [] [] rules,CommonAddressRange [] [] [] ranges,string [] [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_destination_address_range_description", new object[] {
			self_ips,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void set_fw_rule_destination_geo_description(
		string [] self_ips,
		string [] [] rules,
		CommonGeoLocation [] [] [] geos,
		string [] [] [] descriptions
	) {
		this.Invoke("set_fw_rule_destination_geo_description", new object [] {
				self_ips,
				rules,
				geos,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_destination_geo_description(string [] self_ips,string [] [] rules,CommonGeoLocation [] [] [] geos,string [] [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_destination_geo_description", new object[] {
			self_ips,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void set_fw_rule_destination_port_description(
		string [] self_ips,
		string [] [] rules,
		CommonPortRange [] [] [] ports,
		string [] [] [] descriptions
	) {
		this.Invoke("set_fw_rule_destination_port_description", new object [] {
				self_ips,
				rules,
				ports,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_destination_port_description(string [] self_ips,string [] [] rules,CommonPortRange [] [] [] ports,string [] [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_destination_port_description", new object[] {
			self_ips,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void set_fw_rule_icmp_typecode_description(
		string [] self_ips,
		string [] [] rules,
		CommonFirewallRuleICMPTypeCode [] [] [] typecodes,
		string [] [] [] descriptions
	) {
		this.Invoke("set_fw_rule_icmp_typecode_description", new object [] {
				self_ips,
				rules,
				typecodes,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_icmp_typecode_description(string [] self_ips,string [] [] rules,CommonFirewallRuleICMPTypeCode [] [] [] typecodes,string [] [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_icmp_typecode_description", new object[] {
			self_ips,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void set_fw_rule_irule(
		string [] self_ips,
		string [] [] rules,
		string [] [] irules
	) {
		this.Invoke("set_fw_rule_irule", new object [] {
				self_ips,
				rules,
				irules});

	}
	public System.IAsyncResult Beginset_fw_rule_irule(string [] self_ips,string [] [] rules,string [] [] irules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_irule", new object[] {
			self_ips,
			rules,
			irules}, callback, asyncState);
	}
	public void Endset_fw_rule_irule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_log_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void set_fw_rule_log_state(
		string [] self_ips,
		string [] [] rules,
		CommonEnabledState [] [] states
	) {
		this.Invoke("set_fw_rule_log_state", new object [] {
				self_ips,
				rules,
				states});

	}
	public System.IAsyncResult Beginset_fw_rule_log_state(string [] self_ips,string [] [] rules,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_log_state", new object[] {
			self_ips,
			rules,
			states}, callback, asyncState);
	}
	public void Endset_fw_rule_log_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_order
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void set_fw_rule_order(
		string [] self_ips,
		string [] [] rules,
		long [] [] orders
	) {
		this.Invoke("set_fw_rule_order", new object [] {
				self_ips,
				rules,
				orders});

	}
	public System.IAsyncResult Beginset_fw_rule_order(string [] self_ips,string [] [] rules,long [] [] orders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_order", new object[] {
			self_ips,
			rules,
			orders}, callback, asyncState);
	}
	public void Endset_fw_rule_order(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_protocol
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void set_fw_rule_protocol(
		string [] self_ips,
		string [] [] rules,
		CommonProtocolType [] [] protocols
	) {
		this.Invoke("set_fw_rule_protocol", new object [] {
				self_ips,
				rules,
				protocols});

	}
	public System.IAsyncResult Beginset_fw_rule_protocol(string [] self_ips,string [] [] rules,CommonProtocolType [] [] protocols, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_protocol", new object[] {
			self_ips,
			rules,
			protocols}, callback, asyncState);
	}
	public void Endset_fw_rule_protocol(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_protocol_numeric
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void set_fw_rule_protocol_numeric(
		string [] self_ips,
		string [] [] rules,
		long [] [] protocols
	) {
		this.Invoke("set_fw_rule_protocol_numeric", new object [] {
				self_ips,
				rules,
				protocols});

	}
	public System.IAsyncResult Beginset_fw_rule_protocol_numeric(string [] self_ips,string [] [] rules,long [] [] protocols, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_protocol_numeric", new object[] {
			self_ips,
			rules,
			protocols}, callback, asyncState);
	}
	public void Endset_fw_rule_protocol_numeric(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_rule_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void set_fw_rule_rule_list(
		string [] self_ips,
		string [] [] rules,
		string [] [] lists
	) {
		this.Invoke("set_fw_rule_rule_list", new object [] {
				self_ips,
				rules,
				lists});

	}
	public System.IAsyncResult Beginset_fw_rule_rule_list(string [] self_ips,string [] [] rules,string [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_rule_list", new object[] {
			self_ips,
			rules,
			lists}, callback, asyncState);
	}
	public void Endset_fw_rule_rule_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_source_address_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void set_fw_rule_source_address_description(
		string [] self_ips,
		string [] [] rules,
		string [] [] [] addresses,
		string [] [] [] descriptions
	) {
		this.Invoke("set_fw_rule_source_address_description", new object [] {
				self_ips,
				rules,
				addresses,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_source_address_description(string [] self_ips,string [] [] rules,string [] [] [] addresses,string [] [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_source_address_description", new object[] {
			self_ips,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void set_fw_rule_source_address_range_description(
		string [] self_ips,
		string [] [] rules,
		CommonAddressRange [] [] [] ranges,
		string [] [] [] descriptions
	) {
		this.Invoke("set_fw_rule_source_address_range_description", new object [] {
				self_ips,
				rules,
				ranges,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_source_address_range_description(string [] self_ips,string [] [] rules,CommonAddressRange [] [] [] ranges,string [] [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_source_address_range_description", new object[] {
			self_ips,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void set_fw_rule_source_geo_description(
		string [] self_ips,
		string [] [] rules,
		CommonGeoLocation [] [] [] geos,
		string [] [] [] descriptions
	) {
		this.Invoke("set_fw_rule_source_geo_description", new object [] {
				self_ips,
				rules,
				geos,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_source_geo_description(string [] self_ips,string [] [] rules,CommonGeoLocation [] [] [] geos,string [] [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_source_geo_description", new object[] {
			self_ips,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void set_fw_rule_source_port_description(
		string [] self_ips,
		string [] [] rules,
		CommonPortRange [] [] [] ports,
		string [] [] [] descriptions
	) {
		this.Invoke("set_fw_rule_source_port_description", new object [] {
				self_ips,
				rules,
				ports,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_source_port_description(string [] self_ips,string [] [] rules,CommonPortRange [] [] [] ports,string [] [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_source_port_description", new object[] {
			self_ips,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void set_fw_rule_state(
		string [] self_ips,
		string [] [] rules,
		CommonFirewallRuleState [] [] states
	) {
		this.Invoke("set_fw_rule_state", new object [] {
				self_ips,
				rules,
				states});

	}
	public System.IAsyncResult Beginset_fw_rule_state(string [] self_ips,string [] [] rules,CommonFirewallRuleState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_state", new object[] {
			self_ips,
			rules,
			states}, callback, asyncState);
	}
	public void Endset_fw_rule_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_weekly_schedule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void set_fw_rule_weekly_schedule(
		string [] self_ips,
		string [] [] rules,
		string [] [] schedules
	) {
		this.Invoke("set_fw_rule_weekly_schedule", new object [] {
				self_ips,
				rules,
				schedules});

	}
	public System.IAsyncResult Beginset_fw_rule_weekly_schedule(string [] self_ips,string [] [] rules,string [] [] schedules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_weekly_schedule", new object[] {
			self_ips,
			rules,
			schedules}, callback, asyncState);
	}
	public void Endset_fw_rule_weekly_schedule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_netmask
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void set_netmask(
		string [] self_ips,
		string [] netmasks
	) {
		this.Invoke("set_netmask", new object [] {
				self_ips,
				netmasks});

	}
	public System.IAsyncResult Beginset_netmask(string [] self_ips,string [] netmasks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_netmask", new object[] {
			self_ips,
			netmasks}, callback, asyncState);
	}
	public void Endset_netmask(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_staged_firewall_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void set_staged_firewall_policy(
		string [] self_ips,
		string [] policies
	) {
		this.Invoke("set_staged_firewall_policy", new object [] {
				self_ips,
				policies});

	}
	public System.IAsyncResult Beginset_staged_firewall_policy(string [] self_ips,string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_staged_firewall_policy", new object[] {
			self_ips,
			policies}, callback, asyncState);
	}
	public void Endset_staged_firewall_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_traffic_group
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void set_traffic_group(
		string [] self_ips,
		string [] traffic_groups
	) {
		this.Invoke("set_traffic_group", new object [] {
				self_ips,
				traffic_groups});

	}
	public System.IAsyncResult Beginset_traffic_group(string [] self_ips,string [] traffic_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_traffic_group", new object[] {
			self_ips,
			traffic_groups}, callback, asyncState);
	}
	public void Endset_traffic_group(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/SelfIPV2", 
		RequestNamespace="urn:iControl:Networking/SelfIPV2", ResponseNamespace="urn:iControl:Networking/SelfIPV2")]
	public void set_vlan(
		string [] self_ips,
		string [] vlan_names
	) {
		this.Invoke("set_vlan", new object [] {
				self_ips,
				vlan_names});

	}
	public System.IAsyncResult Beginset_vlan(string [] self_ips,string [] vlan_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_vlan", new object[] {
			self_ips,
			vlan_names}, callback, asyncState);
	}
	public void Endset_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.SelfIPV2.AllowMode", Namespace = "urn:iControl")]
	public enum NetworkingSelfIPV2AllowMode
	{
		ALLOW_MODE_PROTOCOL_PORT,
		ALLOW_MODE_NONE,
		ALLOW_MODE_DEFAULTS,
		ALLOW_MODE_ALL,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.SelfIPV2.ProtocolPort", Namespace = "urn:iControl")]
	public partial class NetworkingSelfIPV2ProtocolPort
	{
		private CommonProtocolType protocolField;
		public CommonProtocolType protocol
		{
			get { return this.protocolField; }
			set { this.protocolField = value; }
		}
		private long portField;
		public long port
		{
			get { return this.portField; }
			set { this.portField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.SelfIPV2.ProtocolPortAccess", Namespace = "urn:iControl")]
	public partial class NetworkingSelfIPV2ProtocolPortAccess
	{
		private NetworkingSelfIPV2AllowMode modeField;
		public NetworkingSelfIPV2AllowMode mode
		{
			get { return this.modeField; }
			set { this.modeField = value; }
		}
		private NetworkingSelfIPV2ProtocolPort [] protocol_portsField;
		public NetworkingSelfIPV2ProtocolPort [] protocol_ports
		{
			get { return this.protocol_portsField; }
			set { this.protocol_portsField = value; }
		}
	};

}
