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
	[System.Web.Services.WebServiceBindingAttribute(Name="Security.FirewallPolicyBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonFirewallRulePlacement))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SecurityFirewallPolicyFirewallPolicyRuleStatistics))]
	public partial class SecurityFirewallPolicy : iControlInterface {
		public SecurityFirewallPolicy() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_fw_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void add_fw_rule(
		string [] policies,
		string [] [] rules,
		CommonFirewallRulePlacement [] [] placements,
		CommonFirewallRuleAction [] [] actions,
		CommonFirewallRuleState [] [] states
	) {
		this.Invoke("add_fw_rule", new object [] {
				policies,
				rules,
				placements,
				actions,
				states});

	}
	public System.IAsyncResult Beginadd_fw_rule(string [] policies,string [] [] rules,CommonFirewallRulePlacement [] [] placements,CommonFirewallRuleAction [] [] actions,CommonFirewallRuleState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule", new object[] {
			policies,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void add_fw_rule_destination_address(
		string [] policies,
		string [] [] rules,
		string [] [] [] addresses
	) {
		this.Invoke("add_fw_rule_destination_address", new object [] {
				policies,
				rules,
				addresses});

	}
	public System.IAsyncResult Beginadd_fw_rule_destination_address(string [] policies,string [] [] rules,string [] [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_destination_address", new object[] {
			policies,
			rules,
			addresses}, callback, asyncState);
	}
	public void Endadd_fw_rule_destination_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_destination_address_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void add_fw_rule_destination_address_list(
		string [] policies,
		string [] [] rules,
		string [] [] [] lists
	) {
		this.Invoke("add_fw_rule_destination_address_list", new object [] {
				policies,
				rules,
				lists});

	}
	public System.IAsyncResult Beginadd_fw_rule_destination_address_list(string [] policies,string [] [] rules,string [] [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_destination_address_list", new object[] {
			policies,
			rules,
			lists}, callback, asyncState);
	}
	public void Endadd_fw_rule_destination_address_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_destination_address_range
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void add_fw_rule_destination_address_range(
		string [] policies,
		string [] [] rules,
		CommonAddressRange [] [] [] ranges
	) {
		this.Invoke("add_fw_rule_destination_address_range", new object [] {
				policies,
				rules,
				ranges});

	}
	public System.IAsyncResult Beginadd_fw_rule_destination_address_range(string [] policies,string [] [] rules,CommonAddressRange [] [] [] ranges, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_destination_address_range", new object[] {
			policies,
			rules,
			ranges}, callback, asyncState);
	}
	public void Endadd_fw_rule_destination_address_range(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_destination_geo
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void add_fw_rule_destination_geo(
		string [] policies,
		string [] [] rules,
		CommonGeoLocation [] [] [] geos
	) {
		this.Invoke("add_fw_rule_destination_geo", new object [] {
				policies,
				rules,
				geos});

	}
	public System.IAsyncResult Beginadd_fw_rule_destination_geo(string [] policies,string [] [] rules,CommonGeoLocation [] [] [] geos, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_destination_geo", new object[] {
			policies,
			rules,
			geos}, callback, asyncState);
	}
	public void Endadd_fw_rule_destination_geo(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_destination_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void add_fw_rule_destination_port(
		string [] policies,
		string [] [] rules,
		CommonPortRange [] [] [] ports
	) {
		this.Invoke("add_fw_rule_destination_port", new object [] {
				policies,
				rules,
				ports});

	}
	public System.IAsyncResult Beginadd_fw_rule_destination_port(string [] policies,string [] [] rules,CommonPortRange [] [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_destination_port", new object[] {
			policies,
			rules,
			ports}, callback, asyncState);
	}
	public void Endadd_fw_rule_destination_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_destination_port_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void add_fw_rule_destination_port_list(
		string [] policies,
		string [] [] rules,
		string [] [] [] lists
	) {
		this.Invoke("add_fw_rule_destination_port_list", new object [] {
				policies,
				rules,
				lists});

	}
	public System.IAsyncResult Beginadd_fw_rule_destination_port_list(string [] policies,string [] [] rules,string [] [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_destination_port_list", new object[] {
			policies,
			rules,
			lists}, callback, asyncState);
	}
	public void Endadd_fw_rule_destination_port_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_icmp_typecode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void add_fw_rule_icmp_typecode(
		string [] policies,
		string [] [] rules,
		CommonFirewallRuleICMPTypeCode [] [] [] typecodes
	) {
		this.Invoke("add_fw_rule_icmp_typecode", new object [] {
				policies,
				rules,
				typecodes});

	}
	public System.IAsyncResult Beginadd_fw_rule_icmp_typecode(string [] policies,string [] [] rules,CommonFirewallRuleICMPTypeCode [] [] [] typecodes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_icmp_typecode", new object[] {
			policies,
			rules,
			typecodes}, callback, asyncState);
	}
	public void Endadd_fw_rule_icmp_typecode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_source_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void add_fw_rule_source_address(
		string [] policies,
		string [] [] rules,
		string [] [] [] addresses
	) {
		this.Invoke("add_fw_rule_source_address", new object [] {
				policies,
				rules,
				addresses});

	}
	public System.IAsyncResult Beginadd_fw_rule_source_address(string [] policies,string [] [] rules,string [] [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_source_address", new object[] {
			policies,
			rules,
			addresses}, callback, asyncState);
	}
	public void Endadd_fw_rule_source_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_source_address_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void add_fw_rule_source_address_list(
		string [] policies,
		string [] [] rules,
		string [] [] [] lists
	) {
		this.Invoke("add_fw_rule_source_address_list", new object [] {
				policies,
				rules,
				lists});

	}
	public System.IAsyncResult Beginadd_fw_rule_source_address_list(string [] policies,string [] [] rules,string [] [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_source_address_list", new object[] {
			policies,
			rules,
			lists}, callback, asyncState);
	}
	public void Endadd_fw_rule_source_address_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_source_address_range
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void add_fw_rule_source_address_range(
		string [] policies,
		string [] [] rules,
		CommonAddressRange [] [] [] ranges
	) {
		this.Invoke("add_fw_rule_source_address_range", new object [] {
				policies,
				rules,
				ranges});

	}
	public System.IAsyncResult Beginadd_fw_rule_source_address_range(string [] policies,string [] [] rules,CommonAddressRange [] [] [] ranges, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_source_address_range", new object[] {
			policies,
			rules,
			ranges}, callback, asyncState);
	}
	public void Endadd_fw_rule_source_address_range(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_source_geo
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void add_fw_rule_source_geo(
		string [] policies,
		string [] [] rules,
		CommonGeoLocation [] [] [] geos
	) {
		this.Invoke("add_fw_rule_source_geo", new object [] {
				policies,
				rules,
				geos});

	}
	public System.IAsyncResult Beginadd_fw_rule_source_geo(string [] policies,string [] [] rules,CommonGeoLocation [] [] [] geos, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_source_geo", new object[] {
			policies,
			rules,
			geos}, callback, asyncState);
	}
	public void Endadd_fw_rule_source_geo(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_source_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void add_fw_rule_source_port(
		string [] policies,
		string [] [] rules,
		CommonPortRange [] [] [] ports
	) {
		this.Invoke("add_fw_rule_source_port", new object [] {
				policies,
				rules,
				ports});

	}
	public System.IAsyncResult Beginadd_fw_rule_source_port(string [] policies,string [] [] rules,CommonPortRange [] [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_source_port", new object[] {
			policies,
			rules,
			ports}, callback, asyncState);
	}
	public void Endadd_fw_rule_source_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_source_port_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void add_fw_rule_source_port_list(
		string [] policies,
		string [] [] rules,
		string [] [] [] lists
	) {
		this.Invoke("add_fw_rule_source_port_list", new object [] {
				policies,
				rules,
				lists});

	}
	public System.IAsyncResult Beginadd_fw_rule_source_port_list(string [] policies,string [] [] rules,string [] [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_source_port_list", new object[] {
			policies,
			rules,
			lists}, callback, asyncState);
	}
	public void Endadd_fw_rule_source_port_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_source_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void add_fw_rule_source_vlan(
		string [] policies,
		string [] [] rules,
		string [] [] [] vlans
	) {
		this.Invoke("add_fw_rule_source_vlan", new object [] {
				policies,
				rules,
				vlans});

	}
	public System.IAsyncResult Beginadd_fw_rule_source_vlan(string [] policies,string [] [] rules,string [] [] [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_source_vlan", new object[] {
			policies,
			rules,
			vlans}, callback, asyncState);
	}
	public void Endadd_fw_rule_source_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_with_rule_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void add_fw_rule_with_rule_list(
		string [] policies,
		string [] [] rules,
		CommonFirewallRulePlacement [] [] placements,
		string [] [] lists,
		CommonFirewallRuleState [] [] states
	) {
		this.Invoke("add_fw_rule_with_rule_list", new object [] {
				policies,
				rules,
				placements,
				lists,
				states});

	}
	public System.IAsyncResult Beginadd_fw_rule_with_rule_list(string [] policies,string [] [] rules,CommonFirewallRulePlacement [] [] placements,string [] [] lists,CommonFirewallRuleState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_with_rule_list", new object[] {
			policies,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void create(
		string [] policies
	) {
		this.Invoke("create", new object [] {
				policies});

	}
	public System.IAsyncResult Begincreate(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			policies}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create_from_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void create_from_policy(
		string [] policies,
		string [] from_policies
	) {
		this.Invoke("create_from_policy", new object [] {
				policies,
				from_policies});

	}
	public System.IAsyncResult Begincreate_from_policy(string [] policies,string [] from_policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_from_policy", new object[] {
			policies,
			from_policies}, callback, asyncState);
	}
	public void Endcreate_from_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_firewall_policies
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void delete_all_firewall_policies(

	) {
		this.Invoke("delete_all_firewall_policies", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_firewall_policies(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_firewall_policies", new object[0], callback, asyncState);
	}
	public void Enddelete_all_firewall_policies(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_firewall_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void delete_firewall_policy(
		string [] policies
	) {
		this.Invoke("delete_firewall_policy", new object [] {
				policies});

	}
	public System.IAsyncResult Begindelete_firewall_policy(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_firewall_policy", new object[] {
			policies}, callback, asyncState);
	}
	public void Enddelete_firewall_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_all_fw_rule_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityFirewallPolicyFirewallPolicyRuleStatistics [] get_all_fw_rule_statistics(
		string [] policies
	) {
		object [] results = this.Invoke("get_all_fw_rule_statistics", new object [] {
				policies});
		return ((SecurityFirewallPolicyFirewallPolicyRuleStatistics [])(results[0]));
	}
	public System.IAsyncResult Beginget_all_fw_rule_statistics(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_fw_rule_statistics", new object[] {
			policies}, callback, asyncState);
	}
	public SecurityFirewallPolicyFirewallPolicyRuleStatistics [] Endget_all_fw_rule_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityFirewallPolicyFirewallPolicyRuleStatistics [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] policies
	) {
		object [] results = this.Invoke("get_description", new object [] {
				policies});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			policies}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_fw_rule(
		string [] policies
	) {
		object [] results = this.Invoke("get_fw_rule", new object [] {
				policies});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule", new object[] {
			policies}, callback, asyncState);
	}
	public string [] [] Endget_fw_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonFirewallRuleAction [] [] get_fw_rule_action(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_action", new object [] {
				policies,
				rules});
		return ((CommonFirewallRuleAction [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_action(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_action", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public CommonFirewallRuleAction [] [] Endget_fw_rule_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonFirewallRuleAction [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_fw_rule_description(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_description", new object [] {
				policies,
				rules});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_description(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_description", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public string [] [] Endget_fw_rule_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_destination_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_destination_address(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_destination_address", new object [] {
				policies,
				rules});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_address(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_address", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public string [] [] [] Endget_fw_rule_destination_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_destination_address_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_destination_address_description(
		string [] policies,
		string [] [] rules,
		string [] [] [] addresses
	) {
		object [] results = this.Invoke("get_fw_rule_destination_address_description", new object [] {
				policies,
				rules,
				addresses});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_address_description(string [] policies,string [] [] rules,string [] [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_address_description", new object[] {
			policies,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_destination_address_list(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_destination_address_list", new object [] {
				policies,
				rules});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_address_list(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_address_list", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public string [] [] [] Endget_fw_rule_destination_address_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_destination_address_range
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonAddressRange [] [] [] get_fw_rule_destination_address_range(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_destination_address_range", new object [] {
				policies,
				rules});
		return ((CommonAddressRange [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_address_range(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_address_range", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public CommonAddressRange [] [] [] Endget_fw_rule_destination_address_range(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonAddressRange [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_destination_address_range_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_destination_address_range_description(
		string [] policies,
		string [] [] rules,
		CommonAddressRange [] [] [] ranges
	) {
		object [] results = this.Invoke("get_fw_rule_destination_address_range_description", new object [] {
				policies,
				rules,
				ranges});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_address_range_description(string [] policies,string [] [] rules,CommonAddressRange [] [] [] ranges, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_address_range_description", new object[] {
			policies,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonGeoLocation [] [] [] get_fw_rule_destination_geo(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_destination_geo", new object [] {
				policies,
				rules});
		return ((CommonGeoLocation [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_geo(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_geo", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public CommonGeoLocation [] [] [] Endget_fw_rule_destination_geo(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonGeoLocation [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_destination_geo_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_destination_geo_description(
		string [] policies,
		string [] [] rules,
		CommonGeoLocation [] [] [] geos
	) {
		object [] results = this.Invoke("get_fw_rule_destination_geo_description", new object [] {
				policies,
				rules,
				geos});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_geo_description(string [] policies,string [] [] rules,CommonGeoLocation [] [] [] geos, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_geo_description", new object[] {
			policies,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonPortRange [] [] [] get_fw_rule_destination_port(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_destination_port", new object [] {
				policies,
				rules});
		return ((CommonPortRange [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_port(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_port", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public CommonPortRange [] [] [] Endget_fw_rule_destination_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonPortRange [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_destination_port_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_destination_port_description(
		string [] policies,
		string [] [] rules,
		CommonPortRange [] [] [] ports
	) {
		object [] results = this.Invoke("get_fw_rule_destination_port_description", new object [] {
				policies,
				rules,
				ports});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_port_description(string [] policies,string [] [] rules,CommonPortRange [] [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_port_description", new object[] {
			policies,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_destination_port_list(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_destination_port_list", new object [] {
				policies,
				rules});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_port_list(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_port_list", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public string [] [] [] Endget_fw_rule_destination_port_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_icmp_typecode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonFirewallRuleICMPTypeCode [] [] [] get_fw_rule_icmp_typecode(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_icmp_typecode", new object [] {
				policies,
				rules});
		return ((CommonFirewallRuleICMPTypeCode [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_icmp_typecode(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_icmp_typecode", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public CommonFirewallRuleICMPTypeCode [] [] [] Endget_fw_rule_icmp_typecode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonFirewallRuleICMPTypeCode [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_icmp_typecode_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_icmp_typecode_description(
		string [] policies,
		string [] [] rules,
		CommonFirewallRuleICMPTypeCode [] [] [] typecodes
	) {
		object [] results = this.Invoke("get_fw_rule_icmp_typecode_description", new object [] {
				policies,
				rules,
				typecodes});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_icmp_typecode_description(string [] policies,string [] [] rules,CommonFirewallRuleICMPTypeCode [] [] [] typecodes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_icmp_typecode_description", new object[] {
			policies,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_fw_rule_irule(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_irule", new object [] {
				policies,
				rules});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_irule(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_irule", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public string [] [] Endget_fw_rule_irule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_log_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_fw_rule_log_state(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_log_state", new object [] {
				policies,
				rules});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_log_state(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_log_state", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_fw_rule_log_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_order
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_fw_rule_order(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_order", new object [] {
				policies,
				rules});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_order(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_order", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public long [] [] Endget_fw_rule_order(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_protocol
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonProtocolType [] [] get_fw_rule_protocol(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_protocol", new object [] {
				policies,
				rules});
		return ((CommonProtocolType [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_protocol(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_protocol", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public CommonProtocolType [] [] Endget_fw_rule_protocol(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonProtocolType [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_protocol_numeric
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_fw_rule_protocol_numeric(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_protocol_numeric", new object [] {
				policies,
				rules});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_protocol_numeric(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_protocol_numeric", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public long [] [] Endget_fw_rule_protocol_numeric(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_rule_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_fw_rule_rule_list(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_rule_list", new object [] {
				policies,
				rules});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_rule_list(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_rule_list", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public string [] [] Endget_fw_rule_rule_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_source_address(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_source_address", new object [] {
				policies,
				rules});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_address(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_address", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public string [] [] [] Endget_fw_rule_source_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_address_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_source_address_description(
		string [] policies,
		string [] [] rules,
		string [] [] [] addresses
	) {
		object [] results = this.Invoke("get_fw_rule_source_address_description", new object [] {
				policies,
				rules,
				addresses});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_address_description(string [] policies,string [] [] rules,string [] [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_address_description", new object[] {
			policies,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_source_address_list(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_source_address_list", new object [] {
				policies,
				rules});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_address_list(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_address_list", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public string [] [] [] Endget_fw_rule_source_address_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_address_range
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonAddressRange [] [] [] get_fw_rule_source_address_range(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_source_address_range", new object [] {
				policies,
				rules});
		return ((CommonAddressRange [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_address_range(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_address_range", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public CommonAddressRange [] [] [] Endget_fw_rule_source_address_range(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonAddressRange [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_address_range_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_source_address_range_description(
		string [] policies,
		string [] [] rules,
		CommonAddressRange [] [] [] ranges
	) {
		object [] results = this.Invoke("get_fw_rule_source_address_range_description", new object [] {
				policies,
				rules,
				ranges});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_address_range_description(string [] policies,string [] [] rules,CommonAddressRange [] [] [] ranges, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_address_range_description", new object[] {
			policies,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonGeoLocation [] [] [] get_fw_rule_source_geo(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_source_geo", new object [] {
				policies,
				rules});
		return ((CommonGeoLocation [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_geo(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_geo", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public CommonGeoLocation [] [] [] Endget_fw_rule_source_geo(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonGeoLocation [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_geo_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_source_geo_description(
		string [] policies,
		string [] [] rules,
		CommonGeoLocation [] [] [] geos
	) {
		object [] results = this.Invoke("get_fw_rule_source_geo_description", new object [] {
				policies,
				rules,
				geos});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_geo_description(string [] policies,string [] [] rules,CommonGeoLocation [] [] [] geos, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_geo_description", new object[] {
			policies,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonPortRange [] [] [] get_fw_rule_source_port(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_source_port", new object [] {
				policies,
				rules});
		return ((CommonPortRange [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_port(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_port", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public CommonPortRange [] [] [] Endget_fw_rule_source_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonPortRange [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_port_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_source_port_description(
		string [] policies,
		string [] [] rules,
		CommonPortRange [] [] [] ports
	) {
		object [] results = this.Invoke("get_fw_rule_source_port_description", new object [] {
				policies,
				rules,
				ports});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_port_description(string [] policies,string [] [] rules,CommonPortRange [] [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_port_description", new object[] {
			policies,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_source_port_list(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_source_port_list", new object [] {
				policies,
				rules});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_port_list(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_port_list", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public string [] [] [] Endget_fw_rule_source_port_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_source_vlan(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_source_vlan", new object [] {
				policies,
				rules});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_vlan(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_vlan", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public string [] [] [] Endget_fw_rule_source_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonFirewallRuleState [] [] get_fw_rule_state(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_state", new object [] {
				policies,
				rules});
		return ((CommonFirewallRuleState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_state(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_state", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public CommonFirewallRuleState [] [] Endget_fw_rule_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonFirewallRuleState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SecurityFirewallPolicyFirewallPolicyRuleStatistics [] get_fw_rule_statistics(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_statistics", new object [] {
				policies,
				rules});
		return ((SecurityFirewallPolicyFirewallPolicyRuleStatistics [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_statistics(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_statistics", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public SecurityFirewallPolicyFirewallPolicyRuleStatistics [] Endget_fw_rule_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SecurityFirewallPolicyFirewallPolicyRuleStatistics [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_weekly_schedule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_fw_rule_weekly_schedule(
		string [] policies,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_weekly_schedule", new object [] {
				policies,
				rules});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_weekly_schedule(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_weekly_schedule", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public string [] [] Endget_fw_rule_weekly_schedule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
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
	// remove_all_fw_rule_destination_address_lists
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void remove_all_fw_rule_destination_address_lists(
		string [] policies,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_destination_address_lists", new object [] {
				policies,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_destination_address_lists(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_destination_address_lists", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_destination_address_lists(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_destination_address_ranges
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void remove_all_fw_rule_destination_address_ranges(
		string [] policies,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_destination_address_ranges", new object [] {
				policies,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_destination_address_ranges(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_destination_address_ranges", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_destination_address_ranges(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_destination_addresses
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void remove_all_fw_rule_destination_addresses(
		string [] policies,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_destination_addresses", new object [] {
				policies,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_destination_addresses(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_destination_addresses", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_destination_addresses(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_destination_geos
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void remove_all_fw_rule_destination_geos(
		string [] policies,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_destination_geos", new object [] {
				policies,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_destination_geos(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_destination_geos", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_destination_geos(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_destination_port_lists
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void remove_all_fw_rule_destination_port_lists(
		string [] policies,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_destination_port_lists", new object [] {
				policies,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_destination_port_lists(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_destination_port_lists", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_destination_port_lists(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_destination_ports
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void remove_all_fw_rule_destination_ports(
		string [] policies,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_destination_ports", new object [] {
				policies,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_destination_ports(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_destination_ports", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_destination_ports(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_icmp_typecodes
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void remove_all_fw_rule_icmp_typecodes(
		string [] policies,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_icmp_typecodes", new object [] {
				policies,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_icmp_typecodes(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_icmp_typecodes", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_icmp_typecodes(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_source_address_lists
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void remove_all_fw_rule_source_address_lists(
		string [] policies,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_source_address_lists", new object [] {
				policies,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_source_address_lists(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_source_address_lists", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_source_address_lists(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_source_address_ranges
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void remove_all_fw_rule_source_address_ranges(
		string [] policies,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_source_address_ranges", new object [] {
				policies,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_source_address_ranges(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_source_address_ranges", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_source_address_ranges(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_source_addresses
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void remove_all_fw_rule_source_addresses(
		string [] policies,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_source_addresses", new object [] {
				policies,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_source_addresses(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_source_addresses", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_source_addresses(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_source_geos
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void remove_all_fw_rule_source_geos(
		string [] policies,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_source_geos", new object [] {
				policies,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_source_geos(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_source_geos", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_source_geos(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_source_port_lists
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void remove_all_fw_rule_source_port_lists(
		string [] policies,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_source_port_lists", new object [] {
				policies,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_source_port_lists(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_source_port_lists", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_source_port_lists(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_source_ports
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void remove_all_fw_rule_source_ports(
		string [] policies,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_source_ports", new object [] {
				policies,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_source_ports(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_source_ports", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_source_ports(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_source_vlans
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void remove_all_fw_rule_source_vlans(
		string [] policies,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_source_vlans", new object [] {
				policies,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_source_vlans(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_source_vlans", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_source_vlans(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rules
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void remove_all_fw_rules(
		string [] policies
	) {
		this.Invoke("remove_all_fw_rules", new object [] {
				policies});

	}
	public System.IAsyncResult Beginremove_all_fw_rules(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rules", new object[] {
			policies}, callback, asyncState);
	}
	public void Endremove_all_fw_rules(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void remove_fw_rule(
		string [] policies,
		string [] [] rules
	) {
		this.Invoke("remove_fw_rule", new object [] {
				policies,
				rules});

	}
	public System.IAsyncResult Beginremove_fw_rule(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public void Endremove_fw_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_destination_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void remove_fw_rule_destination_address(
		string [] policies,
		string [] [] rules,
		string [] [] [] addresses
	) {
		this.Invoke("remove_fw_rule_destination_address", new object [] {
				policies,
				rules,
				addresses});

	}
	public System.IAsyncResult Beginremove_fw_rule_destination_address(string [] policies,string [] [] rules,string [] [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_destination_address", new object[] {
			policies,
			rules,
			addresses}, callback, asyncState);
	}
	public void Endremove_fw_rule_destination_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_destination_address_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void remove_fw_rule_destination_address_list(
		string [] policies,
		string [] [] rules,
		string [] [] [] lists
	) {
		this.Invoke("remove_fw_rule_destination_address_list", new object [] {
				policies,
				rules,
				lists});

	}
	public System.IAsyncResult Beginremove_fw_rule_destination_address_list(string [] policies,string [] [] rules,string [] [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_destination_address_list", new object[] {
			policies,
			rules,
			lists}, callback, asyncState);
	}
	public void Endremove_fw_rule_destination_address_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_destination_address_range
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void remove_fw_rule_destination_address_range(
		string [] policies,
		string [] [] rules,
		CommonAddressRange [] [] [] ranges
	) {
		this.Invoke("remove_fw_rule_destination_address_range", new object [] {
				policies,
				rules,
				ranges});

	}
	public System.IAsyncResult Beginremove_fw_rule_destination_address_range(string [] policies,string [] [] rules,CommonAddressRange [] [] [] ranges, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_destination_address_range", new object[] {
			policies,
			rules,
			ranges}, callback, asyncState);
	}
	public void Endremove_fw_rule_destination_address_range(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_destination_geo
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void remove_fw_rule_destination_geo(
		string [] policies,
		string [] [] rules,
		CommonGeoLocation [] [] [] geos
	) {
		this.Invoke("remove_fw_rule_destination_geo", new object [] {
				policies,
				rules,
				geos});

	}
	public System.IAsyncResult Beginremove_fw_rule_destination_geo(string [] policies,string [] [] rules,CommonGeoLocation [] [] [] geos, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_destination_geo", new object[] {
			policies,
			rules,
			geos}, callback, asyncState);
	}
	public void Endremove_fw_rule_destination_geo(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_destination_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void remove_fw_rule_destination_port(
		string [] policies,
		string [] [] rules,
		CommonPortRange [] [] [] ports
	) {
		this.Invoke("remove_fw_rule_destination_port", new object [] {
				policies,
				rules,
				ports});

	}
	public System.IAsyncResult Beginremove_fw_rule_destination_port(string [] policies,string [] [] rules,CommonPortRange [] [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_destination_port", new object[] {
			policies,
			rules,
			ports}, callback, asyncState);
	}
	public void Endremove_fw_rule_destination_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_destination_port_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void remove_fw_rule_destination_port_list(
		string [] policies,
		string [] [] rules,
		string [] [] [] lists
	) {
		this.Invoke("remove_fw_rule_destination_port_list", new object [] {
				policies,
				rules,
				lists});

	}
	public System.IAsyncResult Beginremove_fw_rule_destination_port_list(string [] policies,string [] [] rules,string [] [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_destination_port_list", new object[] {
			policies,
			rules,
			lists}, callback, asyncState);
	}
	public void Endremove_fw_rule_destination_port_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_icmp_typecode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void remove_fw_rule_icmp_typecode(
		string [] policies,
		string [] [] rules,
		CommonFirewallRuleICMPTypeCode [] [] [] typecodes
	) {
		this.Invoke("remove_fw_rule_icmp_typecode", new object [] {
				policies,
				rules,
				typecodes});

	}
	public System.IAsyncResult Beginremove_fw_rule_icmp_typecode(string [] policies,string [] [] rules,CommonFirewallRuleICMPTypeCode [] [] [] typecodes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_icmp_typecode", new object[] {
			policies,
			rules,
			typecodes}, callback, asyncState);
	}
	public void Endremove_fw_rule_icmp_typecode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_source_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void remove_fw_rule_source_address(
		string [] policies,
		string [] [] rules,
		string [] [] [] addresses
	) {
		this.Invoke("remove_fw_rule_source_address", new object [] {
				policies,
				rules,
				addresses});

	}
	public System.IAsyncResult Beginremove_fw_rule_source_address(string [] policies,string [] [] rules,string [] [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_source_address", new object[] {
			policies,
			rules,
			addresses}, callback, asyncState);
	}
	public void Endremove_fw_rule_source_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_source_address_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void remove_fw_rule_source_address_list(
		string [] policies,
		string [] [] rules,
		string [] [] [] lists
	) {
		this.Invoke("remove_fw_rule_source_address_list", new object [] {
				policies,
				rules,
				lists});

	}
	public System.IAsyncResult Beginremove_fw_rule_source_address_list(string [] policies,string [] [] rules,string [] [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_source_address_list", new object[] {
			policies,
			rules,
			lists}, callback, asyncState);
	}
	public void Endremove_fw_rule_source_address_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_source_address_range
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void remove_fw_rule_source_address_range(
		string [] policies,
		string [] [] rules,
		CommonAddressRange [] [] [] ranges
	) {
		this.Invoke("remove_fw_rule_source_address_range", new object [] {
				policies,
				rules,
				ranges});

	}
	public System.IAsyncResult Beginremove_fw_rule_source_address_range(string [] policies,string [] [] rules,CommonAddressRange [] [] [] ranges, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_source_address_range", new object[] {
			policies,
			rules,
			ranges}, callback, asyncState);
	}
	public void Endremove_fw_rule_source_address_range(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_source_geo
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void remove_fw_rule_source_geo(
		string [] policies,
		string [] [] rules,
		CommonGeoLocation [] [] [] geos
	) {
		this.Invoke("remove_fw_rule_source_geo", new object [] {
				policies,
				rules,
				geos});

	}
	public System.IAsyncResult Beginremove_fw_rule_source_geo(string [] policies,string [] [] rules,CommonGeoLocation [] [] [] geos, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_source_geo", new object[] {
			policies,
			rules,
			geos}, callback, asyncState);
	}
	public void Endremove_fw_rule_source_geo(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_source_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void remove_fw_rule_source_port(
		string [] policies,
		string [] [] rules,
		CommonPortRange [] [] [] ports
	) {
		this.Invoke("remove_fw_rule_source_port", new object [] {
				policies,
				rules,
				ports});

	}
	public System.IAsyncResult Beginremove_fw_rule_source_port(string [] policies,string [] [] rules,CommonPortRange [] [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_source_port", new object[] {
			policies,
			rules,
			ports}, callback, asyncState);
	}
	public void Endremove_fw_rule_source_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_source_port_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void remove_fw_rule_source_port_list(
		string [] policies,
		string [] [] rules,
		string [] [] [] lists
	) {
		this.Invoke("remove_fw_rule_source_port_list", new object [] {
				policies,
				rules,
				lists});

	}
	public System.IAsyncResult Beginremove_fw_rule_source_port_list(string [] policies,string [] [] rules,string [] [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_source_port_list", new object[] {
			policies,
			rules,
			lists}, callback, asyncState);
	}
	public void Endremove_fw_rule_source_port_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_source_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void remove_fw_rule_source_vlan(
		string [] policies,
		string [] [] rules,
		string [] [] [] vlans
	) {
		this.Invoke("remove_fw_rule_source_vlan", new object [] {
				policies,
				rules,
				vlans});

	}
	public System.IAsyncResult Beginremove_fw_rule_source_vlan(string [] policies,string [] [] rules,string [] [] [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_source_vlan", new object[] {
			policies,
			rules,
			vlans}, callback, asyncState);
	}
	public void Endremove_fw_rule_source_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_fw_rule_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void reset_fw_rule_statistics(
		string [] policies,
		string [] [] rules
	) {
		this.Invoke("reset_fw_rule_statistics", new object [] {
				policies,
				rules});

	}
	public System.IAsyncResult Beginreset_fw_rule_statistics(string [] policies,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_fw_rule_statistics", new object[] {
			policies,
			rules}, callback, asyncState);
	}
	public void Endreset_fw_rule_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void set_description(
		string [] policies,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				policies,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] policies,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			policies,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void set_fw_rule_action(
		string [] policies,
		string [] [] rules,
		CommonFirewallRuleAction [] [] actions
	) {
		this.Invoke("set_fw_rule_action", new object [] {
				policies,
				rules,
				actions});

	}
	public System.IAsyncResult Beginset_fw_rule_action(string [] policies,string [] [] rules,CommonFirewallRuleAction [] [] actions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_action", new object[] {
			policies,
			rules,
			actions}, callback, asyncState);
	}
	public void Endset_fw_rule_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void set_fw_rule_description(
		string [] policies,
		string [] [] rules,
		string [] [] descriptions
	) {
		this.Invoke("set_fw_rule_description", new object [] {
				policies,
				rules,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_description(string [] policies,string [] [] rules,string [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_description", new object[] {
			policies,
			rules,
			descriptions}, callback, asyncState);
	}
	public void Endset_fw_rule_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_destination_address_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void set_fw_rule_destination_address_description(
		string [] policies,
		string [] [] rules,
		string [] [] [] addresses,
		string [] [] [] descriptions
	) {
		this.Invoke("set_fw_rule_destination_address_description", new object [] {
				policies,
				rules,
				addresses,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_destination_address_description(string [] policies,string [] [] rules,string [] [] [] addresses,string [] [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_destination_address_description", new object[] {
			policies,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void set_fw_rule_destination_address_range_description(
		string [] policies,
		string [] [] rules,
		CommonAddressRange [] [] [] ranges,
		string [] [] [] descriptions
	) {
		this.Invoke("set_fw_rule_destination_address_range_description", new object [] {
				policies,
				rules,
				ranges,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_destination_address_range_description(string [] policies,string [] [] rules,CommonAddressRange [] [] [] ranges,string [] [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_destination_address_range_description", new object[] {
			policies,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void set_fw_rule_destination_geo_description(
		string [] policies,
		string [] [] rules,
		CommonGeoLocation [] [] [] geos,
		string [] [] [] descriptions
	) {
		this.Invoke("set_fw_rule_destination_geo_description", new object [] {
				policies,
				rules,
				geos,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_destination_geo_description(string [] policies,string [] [] rules,CommonGeoLocation [] [] [] geos,string [] [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_destination_geo_description", new object[] {
			policies,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void set_fw_rule_destination_port_description(
		string [] policies,
		string [] [] rules,
		CommonPortRange [] [] [] ports,
		string [] [] [] descriptions
	) {
		this.Invoke("set_fw_rule_destination_port_description", new object [] {
				policies,
				rules,
				ports,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_destination_port_description(string [] policies,string [] [] rules,CommonPortRange [] [] [] ports,string [] [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_destination_port_description", new object[] {
			policies,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void set_fw_rule_icmp_typecode_description(
		string [] policies,
		string [] [] rules,
		CommonFirewallRuleICMPTypeCode [] [] [] typecodes,
		string [] [] [] descriptions
	) {
		this.Invoke("set_fw_rule_icmp_typecode_description", new object [] {
				policies,
				rules,
				typecodes,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_icmp_typecode_description(string [] policies,string [] [] rules,CommonFirewallRuleICMPTypeCode [] [] [] typecodes,string [] [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_icmp_typecode_description", new object[] {
			policies,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void set_fw_rule_irule(
		string [] policies,
		string [] [] rules,
		string [] [] irules
	) {
		this.Invoke("set_fw_rule_irule", new object [] {
				policies,
				rules,
				irules});

	}
	public System.IAsyncResult Beginset_fw_rule_irule(string [] policies,string [] [] rules,string [] [] irules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_irule", new object[] {
			policies,
			rules,
			irules}, callback, asyncState);
	}
	public void Endset_fw_rule_irule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_log_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void set_fw_rule_log_state(
		string [] policies,
		string [] [] rules,
		CommonEnabledState [] [] states
	) {
		this.Invoke("set_fw_rule_log_state", new object [] {
				policies,
				rules,
				states});

	}
	public System.IAsyncResult Beginset_fw_rule_log_state(string [] policies,string [] [] rules,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_log_state", new object[] {
			policies,
			rules,
			states}, callback, asyncState);
	}
	public void Endset_fw_rule_log_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_order
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void set_fw_rule_order(
		string [] policies,
		string [] [] rules,
		long [] [] orders
	) {
		this.Invoke("set_fw_rule_order", new object [] {
				policies,
				rules,
				orders});

	}
	public System.IAsyncResult Beginset_fw_rule_order(string [] policies,string [] [] rules,long [] [] orders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_order", new object[] {
			policies,
			rules,
			orders}, callback, asyncState);
	}
	public void Endset_fw_rule_order(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_protocol
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void set_fw_rule_protocol(
		string [] policies,
		string [] [] rules,
		CommonProtocolType [] [] protocols
	) {
		this.Invoke("set_fw_rule_protocol", new object [] {
				policies,
				rules,
				protocols});

	}
	public System.IAsyncResult Beginset_fw_rule_protocol(string [] policies,string [] [] rules,CommonProtocolType [] [] protocols, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_protocol", new object[] {
			policies,
			rules,
			protocols}, callback, asyncState);
	}
	public void Endset_fw_rule_protocol(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_protocol_numeric
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void set_fw_rule_protocol_numeric(
		string [] policies,
		string [] [] rules,
		long [] [] protocols
	) {
		this.Invoke("set_fw_rule_protocol_numeric", new object [] {
				policies,
				rules,
				protocols});

	}
	public System.IAsyncResult Beginset_fw_rule_protocol_numeric(string [] policies,string [] [] rules,long [] [] protocols, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_protocol_numeric", new object[] {
			policies,
			rules,
			protocols}, callback, asyncState);
	}
	public void Endset_fw_rule_protocol_numeric(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_rule_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void set_fw_rule_rule_list(
		string [] policies,
		string [] [] rules,
		string [] [] lists
	) {
		this.Invoke("set_fw_rule_rule_list", new object [] {
				policies,
				rules,
				lists});

	}
	public System.IAsyncResult Beginset_fw_rule_rule_list(string [] policies,string [] [] rules,string [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_rule_list", new object[] {
			policies,
			rules,
			lists}, callback, asyncState);
	}
	public void Endset_fw_rule_rule_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_source_address_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void set_fw_rule_source_address_description(
		string [] policies,
		string [] [] rules,
		string [] [] [] addresses,
		string [] [] [] descriptions
	) {
		this.Invoke("set_fw_rule_source_address_description", new object [] {
				policies,
				rules,
				addresses,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_source_address_description(string [] policies,string [] [] rules,string [] [] [] addresses,string [] [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_source_address_description", new object[] {
			policies,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void set_fw_rule_source_address_range_description(
		string [] policies,
		string [] [] rules,
		CommonAddressRange [] [] [] ranges,
		string [] [] [] descriptions
	) {
		this.Invoke("set_fw_rule_source_address_range_description", new object [] {
				policies,
				rules,
				ranges,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_source_address_range_description(string [] policies,string [] [] rules,CommonAddressRange [] [] [] ranges,string [] [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_source_address_range_description", new object[] {
			policies,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void set_fw_rule_source_geo_description(
		string [] policies,
		string [] [] rules,
		CommonGeoLocation [] [] [] geos,
		string [] [] [] descriptions
	) {
		this.Invoke("set_fw_rule_source_geo_description", new object [] {
				policies,
				rules,
				geos,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_source_geo_description(string [] policies,string [] [] rules,CommonGeoLocation [] [] [] geos,string [] [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_source_geo_description", new object[] {
			policies,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void set_fw_rule_source_port_description(
		string [] policies,
		string [] [] rules,
		CommonPortRange [] [] [] ports,
		string [] [] [] descriptions
	) {
		this.Invoke("set_fw_rule_source_port_description", new object [] {
				policies,
				rules,
				ports,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_source_port_description(string [] policies,string [] [] rules,CommonPortRange [] [] [] ports,string [] [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_source_port_description", new object[] {
			policies,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void set_fw_rule_state(
		string [] policies,
		string [] [] rules,
		CommonFirewallRuleState [] [] states
	) {
		this.Invoke("set_fw_rule_state", new object [] {
				policies,
				rules,
				states});

	}
	public System.IAsyncResult Beginset_fw_rule_state(string [] policies,string [] [] rules,CommonFirewallRuleState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_state", new object[] {
			policies,
			rules,
			states}, callback, asyncState);
	}
	public void Endset_fw_rule_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_weekly_schedule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallPolicy", 
		RequestNamespace="urn:iControl:Security/FirewallPolicy", ResponseNamespace="urn:iControl:Security/FirewallPolicy")]
	public void set_fw_rule_weekly_schedule(
		string [] policies,
		string [] [] rules,
		string [] [] schedules
	) {
		this.Invoke("set_fw_rule_weekly_schedule", new object [] {
				policies,
				rules,
				schedules});

	}
	public System.IAsyncResult Beginset_fw_rule_weekly_schedule(string [] policies,string [] [] rules,string [] [] schedules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_weekly_schedule", new object[] {
			policies,
			rules,
			schedules}, callback, asyncState);
	}
	public void Endset_fw_rule_weekly_schedule(System.IAsyncResult asyncResult) {
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Security.FirewallPolicy.FirewallPolicyRuleStatisticEntry", Namespace = "urn:iControl")]
	public partial class SecurityFirewallPolicyFirewallPolicyRuleStatisticEntry
	{
		private string ruleField;
		public string rule
		{
			get { return this.ruleField; }
			set { this.ruleField = value; }
		}
		private string actual_ruleField;
		public string actual_rule
		{
			get { return this.actual_ruleField; }
			set { this.actual_ruleField = value; }
		}
		private string context_nameField;
		public string context_name
		{
			get { return this.context_nameField; }
			set { this.context_nameField = value; }
		}
		private string context_typeField;
		public string context_type
		{
			get { return this.context_typeField; }
			set { this.context_typeField = value; }
		}
		private CommonFirewallPolicyType typeField;
		public CommonFirewallPolicyType type
		{
			get { return this.typeField; }
			set { this.typeField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Security.FirewallPolicy.FirewallPolicyRuleStatistics", Namespace = "urn:iControl")]
	public partial class SecurityFirewallPolicyFirewallPolicyRuleStatistics
	{
		private SecurityFirewallPolicyFirewallPolicyRuleStatisticEntry [] [] statisticsField;
		public SecurityFirewallPolicyFirewallPolicyRuleStatisticEntry [] [] statistics
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
