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
	[System.Web.Services.WebServiceBindingAttribute(Name="Security.FirewallGlobalAdminIPRuleListBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonFirewallRulePlacement))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonAddressRange))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonPortRange))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonFirewallRuleICMPTypeCode))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonFirewallRuleStatistics))]
	public partial class SecurityFirewallGlobalAdminIPRuleList : iControlInterface {
		public SecurityFirewallGlobalAdminIPRuleList() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_fw_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void add_fw_rule(
		string [] rules,
		CommonFirewallRulePlacement [] placements,
		CommonFirewallRuleAction [] actions,
		CommonFirewallRuleState [] states
	) {
		this.Invoke("add_fw_rule", new object [] {
				rules,
				placements,
				actions,
				states});

	}
	public System.IAsyncResult Beginadd_fw_rule(string [] rules,CommonFirewallRulePlacement [] placements,CommonFirewallRuleAction [] actions,CommonFirewallRuleState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule", new object[] {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void add_fw_rule_destination_address(
		string [] rules,
		string [] [] addresses
	) {
		this.Invoke("add_fw_rule_destination_address", new object [] {
				rules,
				addresses});

	}
	public System.IAsyncResult Beginadd_fw_rule_destination_address(string [] rules,string [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_destination_address", new object[] {
			rules,
			addresses}, callback, asyncState);
	}
	public void Endadd_fw_rule_destination_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_destination_address_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void add_fw_rule_destination_address_list(
		string [] rules,
		string [] [] lists
	) {
		this.Invoke("add_fw_rule_destination_address_list", new object [] {
				rules,
				lists});

	}
	public System.IAsyncResult Beginadd_fw_rule_destination_address_list(string [] rules,string [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_destination_address_list", new object[] {
			rules,
			lists}, callback, asyncState);
	}
	public void Endadd_fw_rule_destination_address_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_destination_address_range
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void add_fw_rule_destination_address_range(
		string [] rules,
		CommonAddressRange [] [] ranges
	) {
		this.Invoke("add_fw_rule_destination_address_range", new object [] {
				rules,
				ranges});

	}
	public System.IAsyncResult Beginadd_fw_rule_destination_address_range(string [] rules,CommonAddressRange [] [] ranges, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_destination_address_range", new object[] {
			rules,
			ranges}, callback, asyncState);
	}
	public void Endadd_fw_rule_destination_address_range(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_destination_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void add_fw_rule_destination_port(
		string [] rules,
		CommonPortRange [] [] ports
	) {
		this.Invoke("add_fw_rule_destination_port", new object [] {
				rules,
				ports});

	}
	public System.IAsyncResult Beginadd_fw_rule_destination_port(string [] rules,CommonPortRange [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_destination_port", new object[] {
			rules,
			ports}, callback, asyncState);
	}
	public void Endadd_fw_rule_destination_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_destination_port_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void add_fw_rule_destination_port_list(
		string [] rules,
		string [] [] lists
	) {
		this.Invoke("add_fw_rule_destination_port_list", new object [] {
				rules,
				lists});

	}
	public System.IAsyncResult Beginadd_fw_rule_destination_port_list(string [] rules,string [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_destination_port_list", new object[] {
			rules,
			lists}, callback, asyncState);
	}
	public void Endadd_fw_rule_destination_port_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_icmp_typecode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void add_fw_rule_icmp_typecode(
		string [] rules,
		CommonFirewallRuleICMPTypeCode [] [] typecodes
	) {
		this.Invoke("add_fw_rule_icmp_typecode", new object [] {
				rules,
				typecodes});

	}
	public System.IAsyncResult Beginadd_fw_rule_icmp_typecode(string [] rules,CommonFirewallRuleICMPTypeCode [] [] typecodes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_icmp_typecode", new object[] {
			rules,
			typecodes}, callback, asyncState);
	}
	public void Endadd_fw_rule_icmp_typecode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_source_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void add_fw_rule_source_address(
		string [] rules,
		string [] [] addresses
	) {
		this.Invoke("add_fw_rule_source_address", new object [] {
				rules,
				addresses});

	}
	public System.IAsyncResult Beginadd_fw_rule_source_address(string [] rules,string [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_source_address", new object[] {
			rules,
			addresses}, callback, asyncState);
	}
	public void Endadd_fw_rule_source_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_source_address_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void add_fw_rule_source_address_list(
		string [] rules,
		string [] [] lists
	) {
		this.Invoke("add_fw_rule_source_address_list", new object [] {
				rules,
				lists});

	}
	public System.IAsyncResult Beginadd_fw_rule_source_address_list(string [] rules,string [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_source_address_list", new object[] {
			rules,
			lists}, callback, asyncState);
	}
	public void Endadd_fw_rule_source_address_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_source_address_range
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void add_fw_rule_source_address_range(
		string [] rules,
		CommonAddressRange [] [] ranges
	) {
		this.Invoke("add_fw_rule_source_address_range", new object [] {
				rules,
				ranges});

	}
	public System.IAsyncResult Beginadd_fw_rule_source_address_range(string [] rules,CommonAddressRange [] [] ranges, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_source_address_range", new object[] {
			rules,
			ranges}, callback, asyncState);
	}
	public void Endadd_fw_rule_source_address_range(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_source_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void add_fw_rule_source_port(
		string [] rules,
		CommonPortRange [] [] ports
	) {
		this.Invoke("add_fw_rule_source_port", new object [] {
				rules,
				ports});

	}
	public System.IAsyncResult Beginadd_fw_rule_source_port(string [] rules,CommonPortRange [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_source_port", new object[] {
			rules,
			ports}, callback, asyncState);
	}
	public void Endadd_fw_rule_source_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_source_port_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void add_fw_rule_source_port_list(
		string [] rules,
		string [] [] lists
	) {
		this.Invoke("add_fw_rule_source_port_list", new object [] {
				rules,
				lists});

	}
	public System.IAsyncResult Beginadd_fw_rule_source_port_list(string [] rules,string [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_source_port_list", new object[] {
			rules,
			lists}, callback, asyncState);
	}
	public void Endadd_fw_rule_source_port_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_with_rule_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void add_fw_rule_with_rule_list(
		string [] rules,
		CommonFirewallRulePlacement [] placements,
		string [] lists,
		CommonFirewallRuleState [] states
	) {
		this.Invoke("add_fw_rule_with_rule_list", new object [] {
				rules,
				placements,
				lists,
				states});

	}
	public System.IAsyncResult Beginadd_fw_rule_with_rule_list(string [] rules,CommonFirewallRulePlacement [] placements,string [] lists,CommonFirewallRuleState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_with_rule_list", new object[] {
			rules,
			placements,
			lists,
			states}, callback, asyncState);
	}
	public void Endadd_fw_rule_with_rule_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_all_fw_rule_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonFirewallRuleStatistics get_all_fw_rule_statistics(

	) {
		object [] results = this.Invoke("get_all_fw_rule_statistics", new object [0]);
		return ((CommonFirewallRuleStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_fw_rule_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_fw_rule_statistics", new object[0], callback, asyncState);
	}
	public CommonFirewallRuleStatistics Endget_all_fw_rule_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonFirewallRuleStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string get_description(

	) {
		object [] results = this.Invoke("get_description", new object [0]);
		return ((string)(results[0]));
	}
	public System.IAsyncResult Beginget_description(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[0], callback, asyncState);
	}
	public string Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_fw_rule(

	) {
		object [] results = this.Invoke("get_fw_rule", new object [0]);
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule", new object[0], callback, asyncState);
	}
	public string [] Endget_fw_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonFirewallRuleAction [] get_fw_rule_action(
		string [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_action", new object [] {
				rules});
		return ((CommonFirewallRuleAction [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_action(string [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_action", new object[] {
			rules}, callback, asyncState);
	}
	public CommonFirewallRuleAction [] Endget_fw_rule_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonFirewallRuleAction [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_fw_rule_description(
		string [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_description", new object [] {
				rules});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_description(string [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_description", new object[] {
			rules}, callback, asyncState);
	}
	public string [] Endget_fw_rule_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_destination_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_fw_rule_destination_address(
		string [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_destination_address", new object [] {
				rules});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_address(string [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_address", new object[] {
			rules}, callback, asyncState);
	}
	public string [] [] Endget_fw_rule_destination_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_destination_address_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_fw_rule_destination_address_description(
		string [] rules,
		string [] [] addresses
	) {
		object [] results = this.Invoke("get_fw_rule_destination_address_description", new object [] {
				rules,
				addresses});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_address_description(string [] rules,string [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_address_description", new object[] {
			rules,
			addresses}, callback, asyncState);
	}
	public string [] [] Endget_fw_rule_destination_address_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_destination_address_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_fw_rule_destination_address_list(
		string [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_destination_address_list", new object [] {
				rules});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_address_list(string [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_address_list", new object[] {
			rules}, callback, asyncState);
	}
	public string [] [] Endget_fw_rule_destination_address_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_destination_address_range
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonAddressRange [] [] get_fw_rule_destination_address_range(
		string [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_destination_address_range", new object [] {
				rules});
		return ((CommonAddressRange [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_address_range(string [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_address_range", new object[] {
			rules}, callback, asyncState);
	}
	public CommonAddressRange [] [] Endget_fw_rule_destination_address_range(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonAddressRange [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_destination_address_range_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_fw_rule_destination_address_range_description(
		string [] rules,
		CommonAddressRange [] [] ranges
	) {
		object [] results = this.Invoke("get_fw_rule_destination_address_range_description", new object [] {
				rules,
				ranges});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_address_range_description(string [] rules,CommonAddressRange [] [] ranges, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_address_range_description", new object[] {
			rules,
			ranges}, callback, asyncState);
	}
	public string [] [] Endget_fw_rule_destination_address_range_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_destination_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonPortRange [] [] get_fw_rule_destination_port(
		string [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_destination_port", new object [] {
				rules});
		return ((CommonPortRange [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_port(string [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_port", new object[] {
			rules}, callback, asyncState);
	}
	public CommonPortRange [] [] Endget_fw_rule_destination_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonPortRange [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_destination_port_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_fw_rule_destination_port_description(
		string [] rules,
		CommonPortRange [] [] ports
	) {
		object [] results = this.Invoke("get_fw_rule_destination_port_description", new object [] {
				rules,
				ports});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_port_description(string [] rules,CommonPortRange [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_port_description", new object[] {
			rules,
			ports}, callback, asyncState);
	}
	public string [] [] Endget_fw_rule_destination_port_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_destination_port_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_fw_rule_destination_port_list(
		string [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_destination_port_list", new object [] {
				rules});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_port_list(string [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_port_list", new object[] {
			rules}, callback, asyncState);
	}
	public string [] [] Endget_fw_rule_destination_port_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_icmp_typecode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonFirewallRuleICMPTypeCode [] [] get_fw_rule_icmp_typecode(
		string [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_icmp_typecode", new object [] {
				rules});
		return ((CommonFirewallRuleICMPTypeCode [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_icmp_typecode(string [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_icmp_typecode", new object[] {
			rules}, callback, asyncState);
	}
	public CommonFirewallRuleICMPTypeCode [] [] Endget_fw_rule_icmp_typecode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonFirewallRuleICMPTypeCode [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_icmp_typecode_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_fw_rule_icmp_typecode_description(
		string [] rules,
		CommonFirewallRuleICMPTypeCode [] [] typecodes
	) {
		object [] results = this.Invoke("get_fw_rule_icmp_typecode_description", new object [] {
				rules,
				typecodes});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_icmp_typecode_description(string [] rules,CommonFirewallRuleICMPTypeCode [] [] typecodes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_icmp_typecode_description", new object[] {
			rules,
			typecodes}, callback, asyncState);
	}
	public string [] [] Endget_fw_rule_icmp_typecode_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_log_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_fw_rule_log_state(
		string [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_log_state", new object [] {
				rules});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_log_state(string [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_log_state", new object[] {
			rules}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_fw_rule_log_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_order
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_fw_rule_order(
		string [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_order", new object [] {
				rules});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_order(string [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_order", new object[] {
			rules}, callback, asyncState);
	}
	public long [] Endget_fw_rule_order(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_protocol
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonProtocolType [] get_fw_rule_protocol(
		string [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_protocol", new object [] {
				rules});
		return ((CommonProtocolType [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_protocol(string [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_protocol", new object[] {
			rules}, callback, asyncState);
	}
	public CommonProtocolType [] Endget_fw_rule_protocol(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonProtocolType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_protocol_numeric
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_fw_rule_protocol_numeric(
		string [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_protocol_numeric", new object [] {
				rules});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_protocol_numeric(string [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_protocol_numeric", new object[] {
			rules}, callback, asyncState);
	}
	public long [] Endget_fw_rule_protocol_numeric(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_rule_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_fw_rule_rule_list(
		string [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_rule_list", new object [] {
				rules});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_rule_list(string [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_rule_list", new object[] {
			rules}, callback, asyncState);
	}
	public string [] Endget_fw_rule_rule_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_fw_rule_source_address(
		string [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_source_address", new object [] {
				rules});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_address(string [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_address", new object[] {
			rules}, callback, asyncState);
	}
	public string [] [] Endget_fw_rule_source_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_address_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_fw_rule_source_address_description(
		string [] rules,
		string [] [] addresses
	) {
		object [] results = this.Invoke("get_fw_rule_source_address_description", new object [] {
				rules,
				addresses});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_address_description(string [] rules,string [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_address_description", new object[] {
			rules,
			addresses}, callback, asyncState);
	}
	public string [] [] Endget_fw_rule_source_address_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_address_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_fw_rule_source_address_list(
		string [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_source_address_list", new object [] {
				rules});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_address_list(string [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_address_list", new object[] {
			rules}, callback, asyncState);
	}
	public string [] [] Endget_fw_rule_source_address_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_address_range
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonAddressRange [] [] get_fw_rule_source_address_range(
		string [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_source_address_range", new object [] {
				rules});
		return ((CommonAddressRange [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_address_range(string [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_address_range", new object[] {
			rules}, callback, asyncState);
	}
	public CommonAddressRange [] [] Endget_fw_rule_source_address_range(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonAddressRange [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_address_range_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_fw_rule_source_address_range_description(
		string [] rules,
		CommonAddressRange [] [] ranges
	) {
		object [] results = this.Invoke("get_fw_rule_source_address_range_description", new object [] {
				rules,
				ranges});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_address_range_description(string [] rules,CommonAddressRange [] [] ranges, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_address_range_description", new object[] {
			rules,
			ranges}, callback, asyncState);
	}
	public string [] [] Endget_fw_rule_source_address_range_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonPortRange [] [] get_fw_rule_source_port(
		string [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_source_port", new object [] {
				rules});
		return ((CommonPortRange [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_port(string [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_port", new object[] {
			rules}, callback, asyncState);
	}
	public CommonPortRange [] [] Endget_fw_rule_source_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonPortRange [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_port_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_fw_rule_source_port_description(
		string [] rules,
		CommonPortRange [] [] ports
	) {
		object [] results = this.Invoke("get_fw_rule_source_port_description", new object [] {
				rules,
				ports});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_port_description(string [] rules,CommonPortRange [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_port_description", new object[] {
			rules,
			ports}, callback, asyncState);
	}
	public string [] [] Endget_fw_rule_source_port_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_port_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_fw_rule_source_port_list(
		string [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_source_port_list", new object [] {
				rules});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_port_list(string [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_port_list", new object[] {
			rules}, callback, asyncState);
	}
	public string [] [] Endget_fw_rule_source_port_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonFirewallRuleState [] get_fw_rule_state(
		string [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_state", new object [] {
				rules});
		return ((CommonFirewallRuleState [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_state(string [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_state", new object[] {
			rules}, callback, asyncState);
	}
	public CommonFirewallRuleState [] Endget_fw_rule_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonFirewallRuleState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonFirewallRuleStatistics get_fw_rule_statistics(
		string [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_statistics", new object [] {
				rules});
		return ((CommonFirewallRuleStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_statistics(string [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_statistics", new object[] {
			rules}, callback, asyncState);
	}
	public CommonFirewallRuleStatistics Endget_fw_rule_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonFirewallRuleStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_weekly_schedule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_fw_rule_weekly_schedule(
		string [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_weekly_schedule", new object [] {
				rules});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_weekly_schedule(string [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_weekly_schedule", new object[] {
			rules}, callback, asyncState);
	}
	public string [] Endget_fw_rule_weekly_schedule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void remove_all_fw_rule_destination_address_lists(
		string [] rules
	) {
		this.Invoke("remove_all_fw_rule_destination_address_lists", new object [] {
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_destination_address_lists(string [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_destination_address_lists", new object[] {
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_destination_address_lists(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_destination_address_ranges
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void remove_all_fw_rule_destination_address_ranges(
		string [] rules
	) {
		this.Invoke("remove_all_fw_rule_destination_address_ranges", new object [] {
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_destination_address_ranges(string [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_destination_address_ranges", new object[] {
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_destination_address_ranges(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_destination_addresses
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void remove_all_fw_rule_destination_addresses(
		string [] rules
	) {
		this.Invoke("remove_all_fw_rule_destination_addresses", new object [] {
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_destination_addresses(string [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_destination_addresses", new object[] {
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_destination_addresses(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_destination_port_lists
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void remove_all_fw_rule_destination_port_lists(
		string [] rules
	) {
		this.Invoke("remove_all_fw_rule_destination_port_lists", new object [] {
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_destination_port_lists(string [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_destination_port_lists", new object[] {
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_destination_port_lists(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_destination_ports
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void remove_all_fw_rule_destination_ports(
		string [] rules
	) {
		this.Invoke("remove_all_fw_rule_destination_ports", new object [] {
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_destination_ports(string [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_destination_ports", new object[] {
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_destination_ports(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_icmp_typecodes
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void remove_all_fw_rule_icmp_typecodes(
		string [] rules
	) {
		this.Invoke("remove_all_fw_rule_icmp_typecodes", new object [] {
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_icmp_typecodes(string [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_icmp_typecodes", new object[] {
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_icmp_typecodes(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_source_address_lists
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void remove_all_fw_rule_source_address_lists(
		string [] rules
	) {
		this.Invoke("remove_all_fw_rule_source_address_lists", new object [] {
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_source_address_lists(string [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_source_address_lists", new object[] {
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_source_address_lists(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_source_address_ranges
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void remove_all_fw_rule_source_address_ranges(
		string [] rules
	) {
		this.Invoke("remove_all_fw_rule_source_address_ranges", new object [] {
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_source_address_ranges(string [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_source_address_ranges", new object[] {
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_source_address_ranges(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_source_addresses
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void remove_all_fw_rule_source_addresses(
		string [] rules
	) {
		this.Invoke("remove_all_fw_rule_source_addresses", new object [] {
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_source_addresses(string [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_source_addresses", new object[] {
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_source_addresses(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_source_port_lists
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void remove_all_fw_rule_source_port_lists(
		string [] rules
	) {
		this.Invoke("remove_all_fw_rule_source_port_lists", new object [] {
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_source_port_lists(string [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_source_port_lists", new object[] {
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_source_port_lists(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_source_ports
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void remove_all_fw_rule_source_ports(
		string [] rules
	) {
		this.Invoke("remove_all_fw_rule_source_ports", new object [] {
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_source_ports(string [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_source_ports", new object[] {
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_source_ports(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rules
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void remove_all_fw_rules(

	) {
		this.Invoke("remove_all_fw_rules", new object [0]);

	}
	public System.IAsyncResult Beginremove_all_fw_rules(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rules", new object[0], callback, asyncState);
	}
	public void Endremove_all_fw_rules(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void remove_fw_rule(
		string [] rules
	) {
		this.Invoke("remove_fw_rule", new object [] {
				rules});

	}
	public System.IAsyncResult Beginremove_fw_rule(string [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule", new object[] {
			rules}, callback, asyncState);
	}
	public void Endremove_fw_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_destination_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void remove_fw_rule_destination_address(
		string [] rules,
		string [] [] addresses
	) {
		this.Invoke("remove_fw_rule_destination_address", new object [] {
				rules,
				addresses});

	}
	public System.IAsyncResult Beginremove_fw_rule_destination_address(string [] rules,string [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_destination_address", new object[] {
			rules,
			addresses}, callback, asyncState);
	}
	public void Endremove_fw_rule_destination_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_destination_address_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void remove_fw_rule_destination_address_list(
		string [] rules,
		string [] [] lists
	) {
		this.Invoke("remove_fw_rule_destination_address_list", new object [] {
				rules,
				lists});

	}
	public System.IAsyncResult Beginremove_fw_rule_destination_address_list(string [] rules,string [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_destination_address_list", new object[] {
			rules,
			lists}, callback, asyncState);
	}
	public void Endremove_fw_rule_destination_address_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_destination_address_range
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void remove_fw_rule_destination_address_range(
		string [] rules,
		CommonAddressRange [] [] ranges
	) {
		this.Invoke("remove_fw_rule_destination_address_range", new object [] {
				rules,
				ranges});

	}
	public System.IAsyncResult Beginremove_fw_rule_destination_address_range(string [] rules,CommonAddressRange [] [] ranges, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_destination_address_range", new object[] {
			rules,
			ranges}, callback, asyncState);
	}
	public void Endremove_fw_rule_destination_address_range(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_destination_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void remove_fw_rule_destination_port(
		string [] rules,
		CommonPortRange [] [] ports
	) {
		this.Invoke("remove_fw_rule_destination_port", new object [] {
				rules,
				ports});

	}
	public System.IAsyncResult Beginremove_fw_rule_destination_port(string [] rules,CommonPortRange [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_destination_port", new object[] {
			rules,
			ports}, callback, asyncState);
	}
	public void Endremove_fw_rule_destination_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_destination_port_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void remove_fw_rule_destination_port_list(
		string [] rules,
		string [] [] lists
	) {
		this.Invoke("remove_fw_rule_destination_port_list", new object [] {
				rules,
				lists});

	}
	public System.IAsyncResult Beginremove_fw_rule_destination_port_list(string [] rules,string [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_destination_port_list", new object[] {
			rules,
			lists}, callback, asyncState);
	}
	public void Endremove_fw_rule_destination_port_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_icmp_typecode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void remove_fw_rule_icmp_typecode(
		string [] rules,
		CommonFirewallRuleICMPTypeCode [] [] typecodes
	) {
		this.Invoke("remove_fw_rule_icmp_typecode", new object [] {
				rules,
				typecodes});

	}
	public System.IAsyncResult Beginremove_fw_rule_icmp_typecode(string [] rules,CommonFirewallRuleICMPTypeCode [] [] typecodes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_icmp_typecode", new object[] {
			rules,
			typecodes}, callback, asyncState);
	}
	public void Endremove_fw_rule_icmp_typecode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_source_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void remove_fw_rule_source_address(
		string [] rules,
		string [] [] addresses
	) {
		this.Invoke("remove_fw_rule_source_address", new object [] {
				rules,
				addresses});

	}
	public System.IAsyncResult Beginremove_fw_rule_source_address(string [] rules,string [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_source_address", new object[] {
			rules,
			addresses}, callback, asyncState);
	}
	public void Endremove_fw_rule_source_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_source_address_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void remove_fw_rule_source_address_list(
		string [] rules,
		string [] [] lists
	) {
		this.Invoke("remove_fw_rule_source_address_list", new object [] {
				rules,
				lists});

	}
	public System.IAsyncResult Beginremove_fw_rule_source_address_list(string [] rules,string [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_source_address_list", new object[] {
			rules,
			lists}, callback, asyncState);
	}
	public void Endremove_fw_rule_source_address_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_source_address_range
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void remove_fw_rule_source_address_range(
		string [] rules,
		CommonAddressRange [] [] ranges
	) {
		this.Invoke("remove_fw_rule_source_address_range", new object [] {
				rules,
				ranges});

	}
	public System.IAsyncResult Beginremove_fw_rule_source_address_range(string [] rules,CommonAddressRange [] [] ranges, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_source_address_range", new object[] {
			rules,
			ranges}, callback, asyncState);
	}
	public void Endremove_fw_rule_source_address_range(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_source_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void remove_fw_rule_source_port(
		string [] rules,
		CommonPortRange [] [] ports
	) {
		this.Invoke("remove_fw_rule_source_port", new object [] {
				rules,
				ports});

	}
	public System.IAsyncResult Beginremove_fw_rule_source_port(string [] rules,CommonPortRange [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_source_port", new object[] {
			rules,
			ports}, callback, asyncState);
	}
	public void Endremove_fw_rule_source_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_source_port_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void remove_fw_rule_source_port_list(
		string [] rules,
		string [] [] lists
	) {
		this.Invoke("remove_fw_rule_source_port_list", new object [] {
				rules,
				lists});

	}
	public System.IAsyncResult Beginremove_fw_rule_source_port_list(string [] rules,string [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_source_port_list", new object[] {
			rules,
			lists}, callback, asyncState);
	}
	public void Endremove_fw_rule_source_port_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_fw_rule_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void reset_fw_rule_statistics(
		string [] rules
	) {
		this.Invoke("reset_fw_rule_statistics", new object [] {
				rules});

	}
	public System.IAsyncResult Beginreset_fw_rule_statistics(string [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_fw_rule_statistics", new object[] {
			rules}, callback, asyncState);
	}
	public void Endreset_fw_rule_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void set_description(
		string description
	) {
		this.Invoke("set_description", new object [] {
				description});

	}
	public System.IAsyncResult Beginset_description(string description, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			description}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void set_fw_rule_action(
		string [] rules,
		CommonFirewallRuleAction [] actions
	) {
		this.Invoke("set_fw_rule_action", new object [] {
				rules,
				actions});

	}
	public System.IAsyncResult Beginset_fw_rule_action(string [] rules,CommonFirewallRuleAction [] actions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_action", new object[] {
			rules,
			actions}, callback, asyncState);
	}
	public void Endset_fw_rule_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void set_fw_rule_description(
		string [] rules,
		string [] descriptions
	) {
		this.Invoke("set_fw_rule_description", new object [] {
				rules,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_description(string [] rules,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_description", new object[] {
			rules,
			descriptions}, callback, asyncState);
	}
	public void Endset_fw_rule_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_destination_address_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void set_fw_rule_destination_address_description(
		string [] rules,
		string [] [] addresses,
		string [] [] descriptions
	) {
		this.Invoke("set_fw_rule_destination_address_description", new object [] {
				rules,
				addresses,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_destination_address_description(string [] rules,string [] [] addresses,string [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_destination_address_description", new object[] {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void set_fw_rule_destination_address_range_description(
		string [] rules,
		CommonAddressRange [] [] ranges,
		string [] [] descriptions
	) {
		this.Invoke("set_fw_rule_destination_address_range_description", new object [] {
				rules,
				ranges,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_destination_address_range_description(string [] rules,CommonAddressRange [] [] ranges,string [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_destination_address_range_description", new object[] {
			rules,
			ranges,
			descriptions}, callback, asyncState);
	}
	public void Endset_fw_rule_destination_address_range_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_destination_port_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void set_fw_rule_destination_port_description(
		string [] rules,
		CommonPortRange [] [] ports,
		string [] [] descriptions
	) {
		this.Invoke("set_fw_rule_destination_port_description", new object [] {
				rules,
				ports,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_destination_port_description(string [] rules,CommonPortRange [] [] ports,string [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_destination_port_description", new object[] {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void set_fw_rule_icmp_typecode_description(
		string [] rules,
		CommonFirewallRuleICMPTypeCode [] [] typecodes,
		string [] [] descriptions
	) {
		this.Invoke("set_fw_rule_icmp_typecode_description", new object [] {
				rules,
				typecodes,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_icmp_typecode_description(string [] rules,CommonFirewallRuleICMPTypeCode [] [] typecodes,string [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_icmp_typecode_description", new object[] {
			rules,
			typecodes,
			descriptions}, callback, asyncState);
	}
	public void Endset_fw_rule_icmp_typecode_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_log_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void set_fw_rule_log_state(
		string [] rules,
		CommonEnabledState [] states
	) {
		this.Invoke("set_fw_rule_log_state", new object [] {
				rules,
				states});

	}
	public System.IAsyncResult Beginset_fw_rule_log_state(string [] rules,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_log_state", new object[] {
			rules,
			states}, callback, asyncState);
	}
	public void Endset_fw_rule_log_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_order
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void set_fw_rule_order(
		string [] rules,
		long [] orders
	) {
		this.Invoke("set_fw_rule_order", new object [] {
				rules,
				orders});

	}
	public System.IAsyncResult Beginset_fw_rule_order(string [] rules,long [] orders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_order", new object[] {
			rules,
			orders}, callback, asyncState);
	}
	public void Endset_fw_rule_order(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_protocol
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void set_fw_rule_protocol(
		string [] rules,
		CommonProtocolType [] protocols
	) {
		this.Invoke("set_fw_rule_protocol", new object [] {
				rules,
				protocols});

	}
	public System.IAsyncResult Beginset_fw_rule_protocol(string [] rules,CommonProtocolType [] protocols, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_protocol", new object[] {
			rules,
			protocols}, callback, asyncState);
	}
	public void Endset_fw_rule_protocol(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_protocol_numeric
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void set_fw_rule_protocol_numeric(
		string [] rules,
		long [] protocols
	) {
		this.Invoke("set_fw_rule_protocol_numeric", new object [] {
				rules,
				protocols});

	}
	public System.IAsyncResult Beginset_fw_rule_protocol_numeric(string [] rules,long [] protocols, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_protocol_numeric", new object[] {
			rules,
			protocols}, callback, asyncState);
	}
	public void Endset_fw_rule_protocol_numeric(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_rule_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void set_fw_rule_rule_list(
		string [] rules,
		string [] lists
	) {
		this.Invoke("set_fw_rule_rule_list", new object [] {
				rules,
				lists});

	}
	public System.IAsyncResult Beginset_fw_rule_rule_list(string [] rules,string [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_rule_list", new object[] {
			rules,
			lists}, callback, asyncState);
	}
	public void Endset_fw_rule_rule_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_source_address_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void set_fw_rule_source_address_description(
		string [] rules,
		string [] [] addresses,
		string [] [] descriptions
	) {
		this.Invoke("set_fw_rule_source_address_description", new object [] {
				rules,
				addresses,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_source_address_description(string [] rules,string [] [] addresses,string [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_source_address_description", new object[] {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void set_fw_rule_source_address_range_description(
		string [] rules,
		CommonAddressRange [] [] ranges,
		string [] [] descriptions
	) {
		this.Invoke("set_fw_rule_source_address_range_description", new object [] {
				rules,
				ranges,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_source_address_range_description(string [] rules,CommonAddressRange [] [] ranges,string [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_source_address_range_description", new object[] {
			rules,
			ranges,
			descriptions}, callback, asyncState);
	}
	public void Endset_fw_rule_source_address_range_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_source_port_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void set_fw_rule_source_port_description(
		string [] rules,
		CommonPortRange [] [] ports,
		string [] [] descriptions
	) {
		this.Invoke("set_fw_rule_source_port_description", new object [] {
				rules,
				ports,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_source_port_description(string [] rules,CommonPortRange [] [] ports,string [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_source_port_description", new object[] {
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void set_fw_rule_state(
		string [] rules,
		CommonFirewallRuleState [] states
	) {
		this.Invoke("set_fw_rule_state", new object [] {
				rules,
				states});

	}
	public System.IAsyncResult Beginset_fw_rule_state(string [] rules,CommonFirewallRuleState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_state", new object[] {
			rules,
			states}, callback, asyncState);
	}
	public void Endset_fw_rule_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_weekly_schedule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Security/FirewallGlobalAdminIPRuleList", 
		RequestNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList", ResponseNamespace="urn:iControl:Security/FirewallGlobalAdminIPRuleList")]
	public void set_fw_rule_weekly_schedule(
		string [] rules,
		string [] schedules
	) {
		this.Invoke("set_fw_rule_weekly_schedule", new object [] {
				rules,
				schedules});

	}
	public System.IAsyncResult Beginset_fw_rule_weekly_schedule(string [] rules,string [] schedules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_weekly_schedule", new object[] {
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
