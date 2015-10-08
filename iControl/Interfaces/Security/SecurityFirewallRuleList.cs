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
	[System.Web.Services.WebServiceBindingAttribute(Name="Security.FirewallRuleListBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonFirewallRulePlacement))]
	public partial class SecurityFirewallRuleList : iControlInterface {
		public SecurityFirewallRuleList() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_fw_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void add_fw_rule(
		string [] rule_lists,
		string [] [] rules,
		CommonFirewallRulePlacement [] [] placements,
		CommonFirewallRuleAction [] [] actions,
		CommonFirewallRuleState [] [] states
	) {
		this.Invoke("add_fw_rule", new object [] {
				rule_lists,
				rules,
				placements,
				actions,
				states});

	}
	public System.IAsyncResult Beginadd_fw_rule(string [] rule_lists,string [] [] rules,CommonFirewallRulePlacement [] [] placements,CommonFirewallRuleAction [] [] actions,CommonFirewallRuleState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule", new object[] {
			rule_lists,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void add_fw_rule_destination_address(
		string [] rule_lists,
		string [] [] rules,
		string [] [] [] addresses
	) {
		this.Invoke("add_fw_rule_destination_address", new object [] {
				rule_lists,
				rules,
				addresses});

	}
	public System.IAsyncResult Beginadd_fw_rule_destination_address(string [] rule_lists,string [] [] rules,string [] [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_destination_address", new object[] {
			rule_lists,
			rules,
			addresses}, callback, asyncState);
	}
	public void Endadd_fw_rule_destination_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_destination_address_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void add_fw_rule_destination_address_list(
		string [] rule_lists,
		string [] [] rules,
		string [] [] [] lists
	) {
		this.Invoke("add_fw_rule_destination_address_list", new object [] {
				rule_lists,
				rules,
				lists});

	}
	public System.IAsyncResult Beginadd_fw_rule_destination_address_list(string [] rule_lists,string [] [] rules,string [] [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_destination_address_list", new object[] {
			rule_lists,
			rules,
			lists}, callback, asyncState);
	}
	public void Endadd_fw_rule_destination_address_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_destination_address_range
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void add_fw_rule_destination_address_range(
		string [] rule_lists,
		string [] [] rules,
		CommonAddressRange [] [] [] ranges
	) {
		this.Invoke("add_fw_rule_destination_address_range", new object [] {
				rule_lists,
				rules,
				ranges});

	}
	public System.IAsyncResult Beginadd_fw_rule_destination_address_range(string [] rule_lists,string [] [] rules,CommonAddressRange [] [] [] ranges, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_destination_address_range", new object[] {
			rule_lists,
			rules,
			ranges}, callback, asyncState);
	}
	public void Endadd_fw_rule_destination_address_range(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_destination_geo
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void add_fw_rule_destination_geo(
		string [] rule_lists,
		string [] [] rules,
		CommonGeoLocation [] [] [] geos
	) {
		this.Invoke("add_fw_rule_destination_geo", new object [] {
				rule_lists,
				rules,
				geos});

	}
	public System.IAsyncResult Beginadd_fw_rule_destination_geo(string [] rule_lists,string [] [] rules,CommonGeoLocation [] [] [] geos, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_destination_geo", new object[] {
			rule_lists,
			rules,
			geos}, callback, asyncState);
	}
	public void Endadd_fw_rule_destination_geo(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_destination_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void add_fw_rule_destination_port(
		string [] rule_lists,
		string [] [] rules,
		CommonPortRange [] [] [] ports
	) {
		this.Invoke("add_fw_rule_destination_port", new object [] {
				rule_lists,
				rules,
				ports});

	}
	public System.IAsyncResult Beginadd_fw_rule_destination_port(string [] rule_lists,string [] [] rules,CommonPortRange [] [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_destination_port", new object[] {
			rule_lists,
			rules,
			ports}, callback, asyncState);
	}
	public void Endadd_fw_rule_destination_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_destination_port_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void add_fw_rule_destination_port_list(
		string [] rule_lists,
		string [] [] rules,
		string [] [] [] lists
	) {
		this.Invoke("add_fw_rule_destination_port_list", new object [] {
				rule_lists,
				rules,
				lists});

	}
	public System.IAsyncResult Beginadd_fw_rule_destination_port_list(string [] rule_lists,string [] [] rules,string [] [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_destination_port_list", new object[] {
			rule_lists,
			rules,
			lists}, callback, asyncState);
	}
	public void Endadd_fw_rule_destination_port_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_icmp_typecode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void add_fw_rule_icmp_typecode(
		string [] rule_lists,
		string [] [] rules,
		CommonFirewallRuleICMPTypeCode [] [] [] typecodes
	) {
		this.Invoke("add_fw_rule_icmp_typecode", new object [] {
				rule_lists,
				rules,
				typecodes});

	}
	public System.IAsyncResult Beginadd_fw_rule_icmp_typecode(string [] rule_lists,string [] [] rules,CommonFirewallRuleICMPTypeCode [] [] [] typecodes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_icmp_typecode", new object[] {
			rule_lists,
			rules,
			typecodes}, callback, asyncState);
	}
	public void Endadd_fw_rule_icmp_typecode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_source_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void add_fw_rule_source_address(
		string [] rule_lists,
		string [] [] rules,
		string [] [] [] addresses
	) {
		this.Invoke("add_fw_rule_source_address", new object [] {
				rule_lists,
				rules,
				addresses});

	}
	public System.IAsyncResult Beginadd_fw_rule_source_address(string [] rule_lists,string [] [] rules,string [] [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_source_address", new object[] {
			rule_lists,
			rules,
			addresses}, callback, asyncState);
	}
	public void Endadd_fw_rule_source_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_source_address_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void add_fw_rule_source_address_list(
		string [] rule_lists,
		string [] [] rules,
		string [] [] [] lists
	) {
		this.Invoke("add_fw_rule_source_address_list", new object [] {
				rule_lists,
				rules,
				lists});

	}
	public System.IAsyncResult Beginadd_fw_rule_source_address_list(string [] rule_lists,string [] [] rules,string [] [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_source_address_list", new object[] {
			rule_lists,
			rules,
			lists}, callback, asyncState);
	}
	public void Endadd_fw_rule_source_address_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_source_address_range
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void add_fw_rule_source_address_range(
		string [] rule_lists,
		string [] [] rules,
		CommonAddressRange [] [] [] ranges
	) {
		this.Invoke("add_fw_rule_source_address_range", new object [] {
				rule_lists,
				rules,
				ranges});

	}
	public System.IAsyncResult Beginadd_fw_rule_source_address_range(string [] rule_lists,string [] [] rules,CommonAddressRange [] [] [] ranges, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_source_address_range", new object[] {
			rule_lists,
			rules,
			ranges}, callback, asyncState);
	}
	public void Endadd_fw_rule_source_address_range(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_source_geo
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void add_fw_rule_source_geo(
		string [] rule_lists,
		string [] [] rules,
		CommonGeoLocation [] [] [] geos
	) {
		this.Invoke("add_fw_rule_source_geo", new object [] {
				rule_lists,
				rules,
				geos});

	}
	public System.IAsyncResult Beginadd_fw_rule_source_geo(string [] rule_lists,string [] [] rules,CommonGeoLocation [] [] [] geos, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_source_geo", new object[] {
			rule_lists,
			rules,
			geos}, callback, asyncState);
	}
	public void Endadd_fw_rule_source_geo(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_source_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void add_fw_rule_source_port(
		string [] rule_lists,
		string [] [] rules,
		CommonPortRange [] [] [] ports
	) {
		this.Invoke("add_fw_rule_source_port", new object [] {
				rule_lists,
				rules,
				ports});

	}
	public System.IAsyncResult Beginadd_fw_rule_source_port(string [] rule_lists,string [] [] rules,CommonPortRange [] [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_source_port", new object[] {
			rule_lists,
			rules,
			ports}, callback, asyncState);
	}
	public void Endadd_fw_rule_source_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_source_port_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void add_fw_rule_source_port_list(
		string [] rule_lists,
		string [] [] rules,
		string [] [] [] lists
	) {
		this.Invoke("add_fw_rule_source_port_list", new object [] {
				rule_lists,
				rules,
				lists});

	}
	public System.IAsyncResult Beginadd_fw_rule_source_port_list(string [] rule_lists,string [] [] rules,string [] [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_source_port_list", new object[] {
			rule_lists,
			rules,
			lists}, callback, asyncState);
	}
	public void Endadd_fw_rule_source_port_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_source_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void add_fw_rule_source_vlan(
		string [] rule_lists,
		string [] [] rules,
		string [] [] [] vlans
	) {
		this.Invoke("add_fw_rule_source_vlan", new object [] {
				rule_lists,
				rules,
				vlans});

	}
	public System.IAsyncResult Beginadd_fw_rule_source_vlan(string [] rule_lists,string [] [] rules,string [] [] [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_source_vlan", new object[] {
			rule_lists,
			rules,
			vlans}, callback, asyncState);
	}
	public void Endadd_fw_rule_source_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void create(
		string [] rule_lists
	) {
		this.Invoke("create", new object [] {
				rule_lists});

	}
	public System.IAsyncResult Begincreate(string [] rule_lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			rule_lists}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_rule_lists
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void delete_all_rule_lists(

	) {
		this.Invoke("delete_all_rule_lists", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_rule_lists(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_rule_lists", new object[0], callback, asyncState);
	}
	public void Enddelete_all_rule_lists(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_rule_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void delete_rule_list(
		string [] rule_lists
	) {
		this.Invoke("delete_rule_list", new object [] {
				rule_lists});

	}
	public System.IAsyncResult Begindelete_rule_list(string [] rule_lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_rule_list", new object[] {
			rule_lists}, callback, asyncState);
	}
	public void Enddelete_rule_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] rule_lists
	) {
		object [] results = this.Invoke("get_description", new object [] {
				rule_lists});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] rule_lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			rule_lists}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_fw_rule(
		string [] rule_lists
	) {
		object [] results = this.Invoke("get_fw_rule", new object [] {
				rule_lists});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule(string [] rule_lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule", new object[] {
			rule_lists}, callback, asyncState);
	}
	public string [] [] Endget_fw_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonFirewallRuleAction [] [] get_fw_rule_action(
		string [] rule_lists,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_action", new object [] {
				rule_lists,
				rules});
		return ((CommonFirewallRuleAction [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_action(string [] rule_lists,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_action", new object[] {
			rule_lists,
			rules}, callback, asyncState);
	}
	public CommonFirewallRuleAction [] [] Endget_fw_rule_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonFirewallRuleAction [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_fw_rule_description(
		string [] rule_lists,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_description", new object [] {
				rule_lists,
				rules});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_description(string [] rule_lists,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_description", new object[] {
			rule_lists,
			rules}, callback, asyncState);
	}
	public string [] [] Endget_fw_rule_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_destination_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_destination_address(
		string [] rule_lists,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_destination_address", new object [] {
				rule_lists,
				rules});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_address(string [] rule_lists,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_address", new object[] {
			rule_lists,
			rules}, callback, asyncState);
	}
	public string [] [] [] Endget_fw_rule_destination_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_destination_address_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_destination_address_description(
		string [] rule_lists,
		string [] [] rules,
		string [] [] [] addresses
	) {
		object [] results = this.Invoke("get_fw_rule_destination_address_description", new object [] {
				rule_lists,
				rules,
				addresses});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_address_description(string [] rule_lists,string [] [] rules,string [] [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_address_description", new object[] {
			rule_lists,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_destination_address_list(
		string [] rule_lists,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_destination_address_list", new object [] {
				rule_lists,
				rules});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_address_list(string [] rule_lists,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_address_list", new object[] {
			rule_lists,
			rules}, callback, asyncState);
	}
	public string [] [] [] Endget_fw_rule_destination_address_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_destination_address_range
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonAddressRange [] [] [] get_fw_rule_destination_address_range(
		string [] rule_lists,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_destination_address_range", new object [] {
				rule_lists,
				rules});
		return ((CommonAddressRange [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_address_range(string [] rule_lists,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_address_range", new object[] {
			rule_lists,
			rules}, callback, asyncState);
	}
	public CommonAddressRange [] [] [] Endget_fw_rule_destination_address_range(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonAddressRange [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_destination_address_range_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_destination_address_range_description(
		string [] rule_lists,
		string [] [] rules,
		CommonAddressRange [] [] [] ranges
	) {
		object [] results = this.Invoke("get_fw_rule_destination_address_range_description", new object [] {
				rule_lists,
				rules,
				ranges});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_address_range_description(string [] rule_lists,string [] [] rules,CommonAddressRange [] [] [] ranges, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_address_range_description", new object[] {
			rule_lists,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonGeoLocation [] [] [] get_fw_rule_destination_geo(
		string [] rule_lists,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_destination_geo", new object [] {
				rule_lists,
				rules});
		return ((CommonGeoLocation [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_geo(string [] rule_lists,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_geo", new object[] {
			rule_lists,
			rules}, callback, asyncState);
	}
	public CommonGeoLocation [] [] [] Endget_fw_rule_destination_geo(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonGeoLocation [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_destination_geo_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_destination_geo_description(
		string [] rule_lists,
		string [] [] rules,
		CommonGeoLocation [] [] [] geos
	) {
		object [] results = this.Invoke("get_fw_rule_destination_geo_description", new object [] {
				rule_lists,
				rules,
				geos});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_geo_description(string [] rule_lists,string [] [] rules,CommonGeoLocation [] [] [] geos, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_geo_description", new object[] {
			rule_lists,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonPortRange [] [] [] get_fw_rule_destination_port(
		string [] rule_lists,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_destination_port", new object [] {
				rule_lists,
				rules});
		return ((CommonPortRange [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_port(string [] rule_lists,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_port", new object[] {
			rule_lists,
			rules}, callback, asyncState);
	}
	public CommonPortRange [] [] [] Endget_fw_rule_destination_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonPortRange [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_destination_port_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_destination_port_description(
		string [] rule_lists,
		string [] [] rules,
		CommonPortRange [] [] [] ports
	) {
		object [] results = this.Invoke("get_fw_rule_destination_port_description", new object [] {
				rule_lists,
				rules,
				ports});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_port_description(string [] rule_lists,string [] [] rules,CommonPortRange [] [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_port_description", new object[] {
			rule_lists,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_destination_port_list(
		string [] rule_lists,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_destination_port_list", new object [] {
				rule_lists,
				rules});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_port_list(string [] rule_lists,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_port_list", new object[] {
			rule_lists,
			rules}, callback, asyncState);
	}
	public string [] [] [] Endget_fw_rule_destination_port_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_icmp_typecode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonFirewallRuleICMPTypeCode [] [] [] get_fw_rule_icmp_typecode(
		string [] rule_lists,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_icmp_typecode", new object [] {
				rule_lists,
				rules});
		return ((CommonFirewallRuleICMPTypeCode [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_icmp_typecode(string [] rule_lists,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_icmp_typecode", new object[] {
			rule_lists,
			rules}, callback, asyncState);
	}
	public CommonFirewallRuleICMPTypeCode [] [] [] Endget_fw_rule_icmp_typecode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonFirewallRuleICMPTypeCode [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_icmp_typecode_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_icmp_typecode_description(
		string [] rule_lists,
		string [] [] rules,
		CommonFirewallRuleICMPTypeCode [] [] [] typecodes
	) {
		object [] results = this.Invoke("get_fw_rule_icmp_typecode_description", new object [] {
				rule_lists,
				rules,
				typecodes});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_icmp_typecode_description(string [] rule_lists,string [] [] rules,CommonFirewallRuleICMPTypeCode [] [] [] typecodes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_icmp_typecode_description", new object[] {
			rule_lists,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_fw_rule_irule(
		string [] rule_lists,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_irule", new object [] {
				rule_lists,
				rules});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_irule(string [] rule_lists,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_irule", new object[] {
			rule_lists,
			rules}, callback, asyncState);
	}
	public string [] [] Endget_fw_rule_irule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_log_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_fw_rule_log_state(
		string [] rule_lists,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_log_state", new object [] {
				rule_lists,
				rules});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_log_state(string [] rule_lists,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_log_state", new object[] {
			rule_lists,
			rules}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_fw_rule_log_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_order
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_fw_rule_order(
		string [] rule_lists,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_order", new object [] {
				rule_lists,
				rules});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_order(string [] rule_lists,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_order", new object[] {
			rule_lists,
			rules}, callback, asyncState);
	}
	public long [] [] Endget_fw_rule_order(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_protocol
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonProtocolType [] [] get_fw_rule_protocol(
		string [] rule_lists,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_protocol", new object [] {
				rule_lists,
				rules});
		return ((CommonProtocolType [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_protocol(string [] rule_lists,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_protocol", new object[] {
			rule_lists,
			rules}, callback, asyncState);
	}
	public CommonProtocolType [] [] Endget_fw_rule_protocol(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonProtocolType [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_protocol_numeric
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_fw_rule_protocol_numeric(
		string [] rule_lists,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_protocol_numeric", new object [] {
				rule_lists,
				rules});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_protocol_numeric(string [] rule_lists,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_protocol_numeric", new object[] {
			rule_lists,
			rules}, callback, asyncState);
	}
	public long [] [] Endget_fw_rule_protocol_numeric(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_rule_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_fw_rule_rule_list(
		string [] rule_lists,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_rule_list", new object [] {
				rule_lists,
				rules});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_rule_list(string [] rule_lists,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_rule_list", new object[] {
			rule_lists,
			rules}, callback, asyncState);
	}
	public string [] [] Endget_fw_rule_rule_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_source_address(
		string [] rule_lists,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_source_address", new object [] {
				rule_lists,
				rules});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_address(string [] rule_lists,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_address", new object[] {
			rule_lists,
			rules}, callback, asyncState);
	}
	public string [] [] [] Endget_fw_rule_source_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_address_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_source_address_description(
		string [] rule_lists,
		string [] [] rules,
		string [] [] [] addresses
	) {
		object [] results = this.Invoke("get_fw_rule_source_address_description", new object [] {
				rule_lists,
				rules,
				addresses});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_address_description(string [] rule_lists,string [] [] rules,string [] [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_address_description", new object[] {
			rule_lists,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_source_address_list(
		string [] rule_lists,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_source_address_list", new object [] {
				rule_lists,
				rules});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_address_list(string [] rule_lists,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_address_list", new object[] {
			rule_lists,
			rules}, callback, asyncState);
	}
	public string [] [] [] Endget_fw_rule_source_address_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_address_range
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonAddressRange [] [] [] get_fw_rule_source_address_range(
		string [] rule_lists,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_source_address_range", new object [] {
				rule_lists,
				rules});
		return ((CommonAddressRange [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_address_range(string [] rule_lists,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_address_range", new object[] {
			rule_lists,
			rules}, callback, asyncState);
	}
	public CommonAddressRange [] [] [] Endget_fw_rule_source_address_range(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonAddressRange [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_address_range_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_source_address_range_description(
		string [] rule_lists,
		string [] [] rules,
		CommonAddressRange [] [] [] ranges
	) {
		object [] results = this.Invoke("get_fw_rule_source_address_range_description", new object [] {
				rule_lists,
				rules,
				ranges});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_address_range_description(string [] rule_lists,string [] [] rules,CommonAddressRange [] [] [] ranges, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_address_range_description", new object[] {
			rule_lists,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonGeoLocation [] [] [] get_fw_rule_source_geo(
		string [] rule_lists,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_source_geo", new object [] {
				rule_lists,
				rules});
		return ((CommonGeoLocation [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_geo(string [] rule_lists,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_geo", new object[] {
			rule_lists,
			rules}, callback, asyncState);
	}
	public CommonGeoLocation [] [] [] Endget_fw_rule_source_geo(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonGeoLocation [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_geo_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_source_geo_description(
		string [] rule_lists,
		string [] [] rules,
		CommonGeoLocation [] [] [] geos
	) {
		object [] results = this.Invoke("get_fw_rule_source_geo_description", new object [] {
				rule_lists,
				rules,
				geos});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_geo_description(string [] rule_lists,string [] [] rules,CommonGeoLocation [] [] [] geos, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_geo_description", new object[] {
			rule_lists,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonPortRange [] [] [] get_fw_rule_source_port(
		string [] rule_lists,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_source_port", new object [] {
				rule_lists,
				rules});
		return ((CommonPortRange [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_port(string [] rule_lists,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_port", new object[] {
			rule_lists,
			rules}, callback, asyncState);
	}
	public CommonPortRange [] [] [] Endget_fw_rule_source_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonPortRange [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_port_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_source_port_description(
		string [] rule_lists,
		string [] [] rules,
		CommonPortRange [] [] [] ports
	) {
		object [] results = this.Invoke("get_fw_rule_source_port_description", new object [] {
				rule_lists,
				rules,
				ports});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_port_description(string [] rule_lists,string [] [] rules,CommonPortRange [] [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_port_description", new object[] {
			rule_lists,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_source_port_list(
		string [] rule_lists,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_source_port_list", new object [] {
				rule_lists,
				rules});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_port_list(string [] rule_lists,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_port_list", new object[] {
			rule_lists,
			rules}, callback, asyncState);
	}
	public string [] [] [] Endget_fw_rule_source_port_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_source_vlan(
		string [] rule_lists,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_source_vlan", new object [] {
				rule_lists,
				rules});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_vlan(string [] rule_lists,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_vlan", new object[] {
			rule_lists,
			rules}, callback, asyncState);
	}
	public string [] [] [] Endget_fw_rule_source_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonFirewallRuleState [] [] get_fw_rule_state(
		string [] rule_lists,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_state", new object [] {
				rule_lists,
				rules});
		return ((CommonFirewallRuleState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_state(string [] rule_lists,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_state", new object[] {
			rule_lists,
			rules}, callback, asyncState);
	}
	public CommonFirewallRuleState [] [] Endget_fw_rule_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonFirewallRuleState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_weekly_schedule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_fw_rule_weekly_schedule(
		string [] rule_lists,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_weekly_schedule", new object [] {
				rule_lists,
				rules});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_weekly_schedule(string [] rule_lists,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_weekly_schedule", new object[] {
			rule_lists,
			rules}, callback, asyncState);
	}
	public string [] [] Endget_fw_rule_weekly_schedule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void remove_all_fw_rule_destination_address_lists(
		string [] rule_lists,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_destination_address_lists", new object [] {
				rule_lists,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_destination_address_lists(string [] rule_lists,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_destination_address_lists", new object[] {
			rule_lists,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_destination_address_lists(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_destination_address_ranges
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void remove_all_fw_rule_destination_address_ranges(
		string [] rule_lists,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_destination_address_ranges", new object [] {
				rule_lists,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_destination_address_ranges(string [] rule_lists,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_destination_address_ranges", new object[] {
			rule_lists,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_destination_address_ranges(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_destination_addresses
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void remove_all_fw_rule_destination_addresses(
		string [] rule_lists,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_destination_addresses", new object [] {
				rule_lists,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_destination_addresses(string [] rule_lists,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_destination_addresses", new object[] {
			rule_lists,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_destination_addresses(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_destination_geos
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void remove_all_fw_rule_destination_geos(
		string [] rule_lists,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_destination_geos", new object [] {
				rule_lists,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_destination_geos(string [] rule_lists,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_destination_geos", new object[] {
			rule_lists,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_destination_geos(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_destination_port_lists
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void remove_all_fw_rule_destination_port_lists(
		string [] rule_lists,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_destination_port_lists", new object [] {
				rule_lists,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_destination_port_lists(string [] rule_lists,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_destination_port_lists", new object[] {
			rule_lists,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_destination_port_lists(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_destination_ports
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void remove_all_fw_rule_destination_ports(
		string [] rule_lists,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_destination_ports", new object [] {
				rule_lists,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_destination_ports(string [] rule_lists,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_destination_ports", new object[] {
			rule_lists,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_destination_ports(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_icmp_typecodes
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void remove_all_fw_rule_icmp_typecodes(
		string [] rule_lists,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_icmp_typecodes", new object [] {
				rule_lists,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_icmp_typecodes(string [] rule_lists,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_icmp_typecodes", new object[] {
			rule_lists,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_icmp_typecodes(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_source_address_lists
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void remove_all_fw_rule_source_address_lists(
		string [] rule_lists,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_source_address_lists", new object [] {
				rule_lists,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_source_address_lists(string [] rule_lists,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_source_address_lists", new object[] {
			rule_lists,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_source_address_lists(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_source_address_ranges
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void remove_all_fw_rule_source_address_ranges(
		string [] rule_lists,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_source_address_ranges", new object [] {
				rule_lists,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_source_address_ranges(string [] rule_lists,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_source_address_ranges", new object[] {
			rule_lists,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_source_address_ranges(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_source_addresses
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void remove_all_fw_rule_source_addresses(
		string [] rule_lists,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_source_addresses", new object [] {
				rule_lists,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_source_addresses(string [] rule_lists,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_source_addresses", new object[] {
			rule_lists,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_source_addresses(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_source_geos
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void remove_all_fw_rule_source_geos(
		string [] rule_lists,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_source_geos", new object [] {
				rule_lists,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_source_geos(string [] rule_lists,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_source_geos", new object[] {
			rule_lists,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_source_geos(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_source_port_lists
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void remove_all_fw_rule_source_port_lists(
		string [] rule_lists,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_source_port_lists", new object [] {
				rule_lists,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_source_port_lists(string [] rule_lists,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_source_port_lists", new object[] {
			rule_lists,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_source_port_lists(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_source_ports
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void remove_all_fw_rule_source_ports(
		string [] rule_lists,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_source_ports", new object [] {
				rule_lists,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_source_ports(string [] rule_lists,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_source_ports", new object[] {
			rule_lists,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_source_ports(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_source_vlans
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void remove_all_fw_rule_source_vlans(
		string [] rule_lists,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_source_vlans", new object [] {
				rule_lists,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_source_vlans(string [] rule_lists,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_source_vlans", new object[] {
			rule_lists,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_source_vlans(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rules
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void remove_all_fw_rules(
		string [] rule_lists
	) {
		this.Invoke("remove_all_fw_rules", new object [] {
				rule_lists});

	}
	public System.IAsyncResult Beginremove_all_fw_rules(string [] rule_lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rules", new object[] {
			rule_lists}, callback, asyncState);
	}
	public void Endremove_all_fw_rules(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void remove_fw_rule(
		string [] rule_lists,
		string [] [] rules
	) {
		this.Invoke("remove_fw_rule", new object [] {
				rule_lists,
				rules});

	}
	public System.IAsyncResult Beginremove_fw_rule(string [] rule_lists,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule", new object[] {
			rule_lists,
			rules}, callback, asyncState);
	}
	public void Endremove_fw_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_destination_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void remove_fw_rule_destination_address(
		string [] rule_lists,
		string [] [] rules,
		string [] [] [] addresses
	) {
		this.Invoke("remove_fw_rule_destination_address", new object [] {
				rule_lists,
				rules,
				addresses});

	}
	public System.IAsyncResult Beginremove_fw_rule_destination_address(string [] rule_lists,string [] [] rules,string [] [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_destination_address", new object[] {
			rule_lists,
			rules,
			addresses}, callback, asyncState);
	}
	public void Endremove_fw_rule_destination_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_destination_address_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void remove_fw_rule_destination_address_list(
		string [] rule_lists,
		string [] [] rules,
		string [] [] [] lists
	) {
		this.Invoke("remove_fw_rule_destination_address_list", new object [] {
				rule_lists,
				rules,
				lists});

	}
	public System.IAsyncResult Beginremove_fw_rule_destination_address_list(string [] rule_lists,string [] [] rules,string [] [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_destination_address_list", new object[] {
			rule_lists,
			rules,
			lists}, callback, asyncState);
	}
	public void Endremove_fw_rule_destination_address_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_destination_address_range
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void remove_fw_rule_destination_address_range(
		string [] rule_lists,
		string [] [] rules,
		CommonAddressRange [] [] [] ranges
	) {
		this.Invoke("remove_fw_rule_destination_address_range", new object [] {
				rule_lists,
				rules,
				ranges});

	}
	public System.IAsyncResult Beginremove_fw_rule_destination_address_range(string [] rule_lists,string [] [] rules,CommonAddressRange [] [] [] ranges, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_destination_address_range", new object[] {
			rule_lists,
			rules,
			ranges}, callback, asyncState);
	}
	public void Endremove_fw_rule_destination_address_range(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_destination_geo
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void remove_fw_rule_destination_geo(
		string [] rule_lists,
		string [] [] rules,
		CommonGeoLocation [] [] [] geos
	) {
		this.Invoke("remove_fw_rule_destination_geo", new object [] {
				rule_lists,
				rules,
				geos});

	}
	public System.IAsyncResult Beginremove_fw_rule_destination_geo(string [] rule_lists,string [] [] rules,CommonGeoLocation [] [] [] geos, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_destination_geo", new object[] {
			rule_lists,
			rules,
			geos}, callback, asyncState);
	}
	public void Endremove_fw_rule_destination_geo(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_destination_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void remove_fw_rule_destination_port(
		string [] rule_lists,
		string [] [] rules,
		CommonPortRange [] [] [] ports
	) {
		this.Invoke("remove_fw_rule_destination_port", new object [] {
				rule_lists,
				rules,
				ports});

	}
	public System.IAsyncResult Beginremove_fw_rule_destination_port(string [] rule_lists,string [] [] rules,CommonPortRange [] [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_destination_port", new object[] {
			rule_lists,
			rules,
			ports}, callback, asyncState);
	}
	public void Endremove_fw_rule_destination_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_destination_port_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void remove_fw_rule_destination_port_list(
		string [] rule_lists,
		string [] [] rules,
		string [] [] [] lists
	) {
		this.Invoke("remove_fw_rule_destination_port_list", new object [] {
				rule_lists,
				rules,
				lists});

	}
	public System.IAsyncResult Beginremove_fw_rule_destination_port_list(string [] rule_lists,string [] [] rules,string [] [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_destination_port_list", new object[] {
			rule_lists,
			rules,
			lists}, callback, asyncState);
	}
	public void Endremove_fw_rule_destination_port_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_icmp_typecode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void remove_fw_rule_icmp_typecode(
		string [] rule_lists,
		string [] [] rules,
		CommonFirewallRuleICMPTypeCode [] [] [] typecodes
	) {
		this.Invoke("remove_fw_rule_icmp_typecode", new object [] {
				rule_lists,
				rules,
				typecodes});

	}
	public System.IAsyncResult Beginremove_fw_rule_icmp_typecode(string [] rule_lists,string [] [] rules,CommonFirewallRuleICMPTypeCode [] [] [] typecodes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_icmp_typecode", new object[] {
			rule_lists,
			rules,
			typecodes}, callback, asyncState);
	}
	public void Endremove_fw_rule_icmp_typecode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_source_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void remove_fw_rule_source_address(
		string [] rule_lists,
		string [] [] rules,
		string [] [] [] addresses
	) {
		this.Invoke("remove_fw_rule_source_address", new object [] {
				rule_lists,
				rules,
				addresses});

	}
	public System.IAsyncResult Beginremove_fw_rule_source_address(string [] rule_lists,string [] [] rules,string [] [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_source_address", new object[] {
			rule_lists,
			rules,
			addresses}, callback, asyncState);
	}
	public void Endremove_fw_rule_source_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_source_address_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void remove_fw_rule_source_address_list(
		string [] rule_lists,
		string [] [] rules,
		string [] [] [] lists
	) {
		this.Invoke("remove_fw_rule_source_address_list", new object [] {
				rule_lists,
				rules,
				lists});

	}
	public System.IAsyncResult Beginremove_fw_rule_source_address_list(string [] rule_lists,string [] [] rules,string [] [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_source_address_list", new object[] {
			rule_lists,
			rules,
			lists}, callback, asyncState);
	}
	public void Endremove_fw_rule_source_address_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_source_address_range
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void remove_fw_rule_source_address_range(
		string [] rule_lists,
		string [] [] rules,
		CommonAddressRange [] [] [] ranges
	) {
		this.Invoke("remove_fw_rule_source_address_range", new object [] {
				rule_lists,
				rules,
				ranges});

	}
	public System.IAsyncResult Beginremove_fw_rule_source_address_range(string [] rule_lists,string [] [] rules,CommonAddressRange [] [] [] ranges, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_source_address_range", new object[] {
			rule_lists,
			rules,
			ranges}, callback, asyncState);
	}
	public void Endremove_fw_rule_source_address_range(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_source_geo
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void remove_fw_rule_source_geo(
		string [] rule_lists,
		string [] [] rules,
		CommonGeoLocation [] [] [] geos
	) {
		this.Invoke("remove_fw_rule_source_geo", new object [] {
				rule_lists,
				rules,
				geos});

	}
	public System.IAsyncResult Beginremove_fw_rule_source_geo(string [] rule_lists,string [] [] rules,CommonGeoLocation [] [] [] geos, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_source_geo", new object[] {
			rule_lists,
			rules,
			geos}, callback, asyncState);
	}
	public void Endremove_fw_rule_source_geo(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_source_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void remove_fw_rule_source_port(
		string [] rule_lists,
		string [] [] rules,
		CommonPortRange [] [] [] ports
	) {
		this.Invoke("remove_fw_rule_source_port", new object [] {
				rule_lists,
				rules,
				ports});

	}
	public System.IAsyncResult Beginremove_fw_rule_source_port(string [] rule_lists,string [] [] rules,CommonPortRange [] [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_source_port", new object[] {
			rule_lists,
			rules,
			ports}, callback, asyncState);
	}
	public void Endremove_fw_rule_source_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_source_port_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void remove_fw_rule_source_port_list(
		string [] rule_lists,
		string [] [] rules,
		string [] [] [] lists
	) {
		this.Invoke("remove_fw_rule_source_port_list", new object [] {
				rule_lists,
				rules,
				lists});

	}
	public System.IAsyncResult Beginremove_fw_rule_source_port_list(string [] rule_lists,string [] [] rules,string [] [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_source_port_list", new object[] {
			rule_lists,
			rules,
			lists}, callback, asyncState);
	}
	public void Endremove_fw_rule_source_port_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_source_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void remove_fw_rule_source_vlan(
		string [] rule_lists,
		string [] [] rules,
		string [] [] [] vlans
	) {
		this.Invoke("remove_fw_rule_source_vlan", new object [] {
				rule_lists,
				rules,
				vlans});

	}
	public System.IAsyncResult Beginremove_fw_rule_source_vlan(string [] rule_lists,string [] [] rules,string [] [] [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_source_vlan", new object[] {
			rule_lists,
			rules,
			vlans}, callback, asyncState);
	}
	public void Endremove_fw_rule_source_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void set_description(
		string [] rule_lists,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				rule_lists,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] rule_lists,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			rule_lists,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void set_fw_rule_action(
		string [] rule_lists,
		string [] [] rules,
		CommonFirewallRuleAction [] [] actions
	) {
		this.Invoke("set_fw_rule_action", new object [] {
				rule_lists,
				rules,
				actions});

	}
	public System.IAsyncResult Beginset_fw_rule_action(string [] rule_lists,string [] [] rules,CommonFirewallRuleAction [] [] actions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_action", new object[] {
			rule_lists,
			rules,
			actions}, callback, asyncState);
	}
	public void Endset_fw_rule_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void set_fw_rule_description(
		string [] rule_lists,
		string [] [] rules,
		string [] [] descriptions
	) {
		this.Invoke("set_fw_rule_description", new object [] {
				rule_lists,
				rules,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_description(string [] rule_lists,string [] [] rules,string [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_description", new object[] {
			rule_lists,
			rules,
			descriptions}, callback, asyncState);
	}
	public void Endset_fw_rule_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_destination_address_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void set_fw_rule_destination_address_description(
		string [] rule_lists,
		string [] [] rules,
		string [] [] [] addresses,
		string [] [] [] descriptions
	) {
		this.Invoke("set_fw_rule_destination_address_description", new object [] {
				rule_lists,
				rules,
				addresses,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_destination_address_description(string [] rule_lists,string [] [] rules,string [] [] [] addresses,string [] [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_destination_address_description", new object[] {
			rule_lists,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void set_fw_rule_destination_address_range_description(
		string [] rule_lists,
		string [] [] rules,
		CommonAddressRange [] [] [] ranges,
		string [] [] [] descriptions
	) {
		this.Invoke("set_fw_rule_destination_address_range_description", new object [] {
				rule_lists,
				rules,
				ranges,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_destination_address_range_description(string [] rule_lists,string [] [] rules,CommonAddressRange [] [] [] ranges,string [] [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_destination_address_range_description", new object[] {
			rule_lists,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void set_fw_rule_destination_geo_description(
		string [] rule_lists,
		string [] [] rules,
		CommonGeoLocation [] [] [] geos,
		string [] [] [] descriptions
	) {
		this.Invoke("set_fw_rule_destination_geo_description", new object [] {
				rule_lists,
				rules,
				geos,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_destination_geo_description(string [] rule_lists,string [] [] rules,CommonGeoLocation [] [] [] geos,string [] [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_destination_geo_description", new object[] {
			rule_lists,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void set_fw_rule_destination_port_description(
		string [] rule_lists,
		string [] [] rules,
		CommonPortRange [] [] [] ports,
		string [] [] [] descriptions
	) {
		this.Invoke("set_fw_rule_destination_port_description", new object [] {
				rule_lists,
				rules,
				ports,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_destination_port_description(string [] rule_lists,string [] [] rules,CommonPortRange [] [] [] ports,string [] [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_destination_port_description", new object[] {
			rule_lists,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void set_fw_rule_icmp_typecode_description(
		string [] rule_lists,
		string [] [] rules,
		CommonFirewallRuleICMPTypeCode [] [] [] typecodes,
		string [] [] [] descriptions
	) {
		this.Invoke("set_fw_rule_icmp_typecode_description", new object [] {
				rule_lists,
				rules,
				typecodes,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_icmp_typecode_description(string [] rule_lists,string [] [] rules,CommonFirewallRuleICMPTypeCode [] [] [] typecodes,string [] [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_icmp_typecode_description", new object[] {
			rule_lists,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void set_fw_rule_irule(
		string [] rule_lists,
		string [] [] rules,
		string [] [] irules
	) {
		this.Invoke("set_fw_rule_irule", new object [] {
				rule_lists,
				rules,
				irules});

	}
	public System.IAsyncResult Beginset_fw_rule_irule(string [] rule_lists,string [] [] rules,string [] [] irules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_irule", new object[] {
			rule_lists,
			rules,
			irules}, callback, asyncState);
	}
	public void Endset_fw_rule_irule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_log_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void set_fw_rule_log_state(
		string [] rule_lists,
		string [] [] rules,
		CommonEnabledState [] [] states
	) {
		this.Invoke("set_fw_rule_log_state", new object [] {
				rule_lists,
				rules,
				states});

	}
	public System.IAsyncResult Beginset_fw_rule_log_state(string [] rule_lists,string [] [] rules,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_log_state", new object[] {
			rule_lists,
			rules,
			states}, callback, asyncState);
	}
	public void Endset_fw_rule_log_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_order
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void set_fw_rule_order(
		string [] rule_lists,
		string [] [] rules,
		long [] [] orders
	) {
		this.Invoke("set_fw_rule_order", new object [] {
				rule_lists,
				rules,
				orders});

	}
	public System.IAsyncResult Beginset_fw_rule_order(string [] rule_lists,string [] [] rules,long [] [] orders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_order", new object[] {
			rule_lists,
			rules,
			orders}, callback, asyncState);
	}
	public void Endset_fw_rule_order(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_protocol
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void set_fw_rule_protocol(
		string [] rule_lists,
		string [] [] rules,
		CommonProtocolType [] [] protocols
	) {
		this.Invoke("set_fw_rule_protocol", new object [] {
				rule_lists,
				rules,
				protocols});

	}
	public System.IAsyncResult Beginset_fw_rule_protocol(string [] rule_lists,string [] [] rules,CommonProtocolType [] [] protocols, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_protocol", new object[] {
			rule_lists,
			rules,
			protocols}, callback, asyncState);
	}
	public void Endset_fw_rule_protocol(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_protocol_numeric
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void set_fw_rule_protocol_numeric(
		string [] rule_lists,
		string [] [] rules,
		long [] [] protocols
	) {
		this.Invoke("set_fw_rule_protocol_numeric", new object [] {
				rule_lists,
				rules,
				protocols});

	}
	public System.IAsyncResult Beginset_fw_rule_protocol_numeric(string [] rule_lists,string [] [] rules,long [] [] protocols, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_protocol_numeric", new object[] {
			rule_lists,
			rules,
			protocols}, callback, asyncState);
	}
	public void Endset_fw_rule_protocol_numeric(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_rule_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void set_fw_rule_rule_list(
		string [] rule_lists,
		string [] [] rules,
		string [] [] lists
	) {
		this.Invoke("set_fw_rule_rule_list", new object [] {
				rule_lists,
				rules,
				lists});

	}
	public System.IAsyncResult Beginset_fw_rule_rule_list(string [] rule_lists,string [] [] rules,string [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_rule_list", new object[] {
			rule_lists,
			rules,
			lists}, callback, asyncState);
	}
	public void Endset_fw_rule_rule_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_source_address_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void set_fw_rule_source_address_description(
		string [] rule_lists,
		string [] [] rules,
		string [] [] [] addresses,
		string [] [] [] descriptions
	) {
		this.Invoke("set_fw_rule_source_address_description", new object [] {
				rule_lists,
				rules,
				addresses,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_source_address_description(string [] rule_lists,string [] [] rules,string [] [] [] addresses,string [] [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_source_address_description", new object[] {
			rule_lists,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void set_fw_rule_source_address_range_description(
		string [] rule_lists,
		string [] [] rules,
		CommonAddressRange [] [] [] ranges,
		string [] [] [] descriptions
	) {
		this.Invoke("set_fw_rule_source_address_range_description", new object [] {
				rule_lists,
				rules,
				ranges,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_source_address_range_description(string [] rule_lists,string [] [] rules,CommonAddressRange [] [] [] ranges,string [] [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_source_address_range_description", new object[] {
			rule_lists,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void set_fw_rule_source_geo_description(
		string [] rule_lists,
		string [] [] rules,
		CommonGeoLocation [] [] [] geos,
		string [] [] [] descriptions
	) {
		this.Invoke("set_fw_rule_source_geo_description", new object [] {
				rule_lists,
				rules,
				geos,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_source_geo_description(string [] rule_lists,string [] [] rules,CommonGeoLocation [] [] [] geos,string [] [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_source_geo_description", new object[] {
			rule_lists,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void set_fw_rule_source_port_description(
		string [] rule_lists,
		string [] [] rules,
		CommonPortRange [] [] [] ports,
		string [] [] [] descriptions
	) {
		this.Invoke("set_fw_rule_source_port_description", new object [] {
				rule_lists,
				rules,
				ports,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_source_port_description(string [] rule_lists,string [] [] rules,CommonPortRange [] [] [] ports,string [] [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_source_port_description", new object[] {
			rule_lists,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void set_fw_rule_state(
		string [] rule_lists,
		string [] [] rules,
		CommonFirewallRuleState [] [] states
	) {
		this.Invoke("set_fw_rule_state", new object [] {
				rule_lists,
				rules,
				states});

	}
	public System.IAsyncResult Beginset_fw_rule_state(string [] rule_lists,string [] [] rules,CommonFirewallRuleState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_state", new object[] {
			rule_lists,
			rules,
			states}, callback, asyncState);
	}
	public void Endset_fw_rule_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_weekly_schedule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallRuleList", ResponseNamespace="urn:iControl:Security/FirewallRuleList")]
	public void set_fw_rule_weekly_schedule(
		string [] rule_lists,
		string [] [] rules,
		string [] [] schedules
	) {
		this.Invoke("set_fw_rule_weekly_schedule", new object [] {
				rule_lists,
				rules,
				schedules});

	}
	public System.IAsyncResult Beginset_fw_rule_weekly_schedule(string [] rule_lists,string [] [] rules,string [] [] schedules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_weekly_schedule", new object[] {
			rule_lists,
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

}
