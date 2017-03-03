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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.VirtualServerBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBVirtualServerVirtualServerAuthentication))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBVirtualServerVirtualServerClonePool))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonFirewallRulePlacement))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBVirtualServerVirtualServerHttpClass))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBVirtualServerVirtualServerPersistence))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBVirtualServerVirtualServerProfile))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBVirtualServerVirtualServerRule))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonVirtualServerDefinition))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBVirtualServerVirtualServerResource))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonFirewallRuleStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBVirtualServerVirtualServerStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonULong64))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonIPPortDefinition))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonAddressPort))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBVirtualServerVirtualServerModuleScore))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBObjectStatus))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBPersistenceRecord))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBVirtualServerVirtualServerProfileAttribute))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonVLANFilterList))]
	public partial class LocalLBVirtualServer : iControlInterface {
		public LocalLBVirtualServer() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_authentication_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void add_authentication_profile(
		string [] virtual_servers,
		LocalLBVirtualServerVirtualServerAuthentication [] [] profiles
	) {
		this.Invoke("add_authentication_profile", new object [] {
				virtual_servers,
				profiles});

	}
	public System.IAsyncResult Beginadd_authentication_profile(string [] virtual_servers,LocalLBVirtualServerVirtualServerAuthentication [] [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_authentication_profile", new object[] {
			virtual_servers,
			profiles}, callback, asyncState);
	}
	public void Endadd_authentication_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_clone_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void add_clone_pool(
		string [] virtual_servers,
		LocalLBVirtualServerVirtualServerClonePool [] [] clone_pools
	) {
		this.Invoke("add_clone_pool", new object [] {
				virtual_servers,
				clone_pools});

	}
	public System.IAsyncResult Beginadd_clone_pool(string [] virtual_servers,LocalLBVirtualServerVirtualServerClonePool [] [] clone_pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_clone_pool", new object[] {
			virtual_servers,
			clone_pools}, callback, asyncState);
	}
	public void Endadd_clone_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_content_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void add_content_policy(
		string [] virtual_servers,
		string [] [] policies
	) {
		this.Invoke("add_content_policy", new object [] {
				virtual_servers,
				policies});

	}
	public System.IAsyncResult Beginadd_content_policy(string [] virtual_servers,string [] [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_content_policy", new object[] {
			virtual_servers,
			policies}, callback, asyncState);
	}
	public void Endadd_content_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void add_fw_rule(
		string [] virtual_servers,
		string [] [] rules,
		CommonFirewallRulePlacement [] [] placements,
		CommonFirewallRuleAction [] [] actions,
		CommonFirewallRuleState [] [] states
	) {
		this.Invoke("add_fw_rule", new object [] {
				virtual_servers,
				rules,
				placements,
				actions,
				states});

	}
	public System.IAsyncResult Beginadd_fw_rule(string [] virtual_servers,string [] [] rules,CommonFirewallRulePlacement [] [] placements,CommonFirewallRuleAction [] [] actions,CommonFirewallRuleState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule", new object[] {
			virtual_servers,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void add_fw_rule_destination_address(
		string [] virtual_servers,
		string [] [] rules,
		string [] [] [] addresses
	) {
		this.Invoke("add_fw_rule_destination_address", new object [] {
				virtual_servers,
				rules,
				addresses});

	}
	public System.IAsyncResult Beginadd_fw_rule_destination_address(string [] virtual_servers,string [] [] rules,string [] [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_destination_address", new object[] {
			virtual_servers,
			rules,
			addresses}, callback, asyncState);
	}
	public void Endadd_fw_rule_destination_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_destination_address_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void add_fw_rule_destination_address_list(
		string [] virtual_servers,
		string [] [] rules,
		string [] [] [] lists
	) {
		this.Invoke("add_fw_rule_destination_address_list", new object [] {
				virtual_servers,
				rules,
				lists});

	}
	public System.IAsyncResult Beginadd_fw_rule_destination_address_list(string [] virtual_servers,string [] [] rules,string [] [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_destination_address_list", new object[] {
			virtual_servers,
			rules,
			lists}, callback, asyncState);
	}
	public void Endadd_fw_rule_destination_address_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_destination_address_range
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void add_fw_rule_destination_address_range(
		string [] virtual_servers,
		string [] [] rules,
		CommonAddressRange [] [] [] ranges
	) {
		this.Invoke("add_fw_rule_destination_address_range", new object [] {
				virtual_servers,
				rules,
				ranges});

	}
	public System.IAsyncResult Beginadd_fw_rule_destination_address_range(string [] virtual_servers,string [] [] rules,CommonAddressRange [] [] [] ranges, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_destination_address_range", new object[] {
			virtual_servers,
			rules,
			ranges}, callback, asyncState);
	}
	public void Endadd_fw_rule_destination_address_range(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_destination_geo
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void add_fw_rule_destination_geo(
		string [] virtual_servers,
		string [] [] rules,
		CommonGeoLocation [] [] [] geos
	) {
		this.Invoke("add_fw_rule_destination_geo", new object [] {
				virtual_servers,
				rules,
				geos});

	}
	public System.IAsyncResult Beginadd_fw_rule_destination_geo(string [] virtual_servers,string [] [] rules,CommonGeoLocation [] [] [] geos, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_destination_geo", new object[] {
			virtual_servers,
			rules,
			geos}, callback, asyncState);
	}
	public void Endadd_fw_rule_destination_geo(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_destination_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void add_fw_rule_destination_port(
		string [] virtual_servers,
		string [] [] rules,
		CommonPortRange [] [] [] ports
	) {
		this.Invoke("add_fw_rule_destination_port", new object [] {
				virtual_servers,
				rules,
				ports});

	}
	public System.IAsyncResult Beginadd_fw_rule_destination_port(string [] virtual_servers,string [] [] rules,CommonPortRange [] [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_destination_port", new object[] {
			virtual_servers,
			rules,
			ports}, callback, asyncState);
	}
	public void Endadd_fw_rule_destination_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_destination_port_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void add_fw_rule_destination_port_list(
		string [] virtual_servers,
		string [] [] rules,
		string [] [] [] lists
	) {
		this.Invoke("add_fw_rule_destination_port_list", new object [] {
				virtual_servers,
				rules,
				lists});

	}
	public System.IAsyncResult Beginadd_fw_rule_destination_port_list(string [] virtual_servers,string [] [] rules,string [] [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_destination_port_list", new object[] {
			virtual_servers,
			rules,
			lists}, callback, asyncState);
	}
	public void Endadd_fw_rule_destination_port_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_icmp_typecode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void add_fw_rule_icmp_typecode(
		string [] virtual_servers,
		string [] [] rules,
		CommonFirewallRuleICMPTypeCode [] [] [] typecodes
	) {
		this.Invoke("add_fw_rule_icmp_typecode", new object [] {
				virtual_servers,
				rules,
				typecodes});

	}
	public System.IAsyncResult Beginadd_fw_rule_icmp_typecode(string [] virtual_servers,string [] [] rules,CommonFirewallRuleICMPTypeCode [] [] [] typecodes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_icmp_typecode", new object[] {
			virtual_servers,
			rules,
			typecodes}, callback, asyncState);
	}
	public void Endadd_fw_rule_icmp_typecode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_source_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void add_fw_rule_source_address(
		string [] virtual_servers,
		string [] [] rules,
		string [] [] [] addresses
	) {
		this.Invoke("add_fw_rule_source_address", new object [] {
				virtual_servers,
				rules,
				addresses});

	}
	public System.IAsyncResult Beginadd_fw_rule_source_address(string [] virtual_servers,string [] [] rules,string [] [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_source_address", new object[] {
			virtual_servers,
			rules,
			addresses}, callback, asyncState);
	}
	public void Endadd_fw_rule_source_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_source_address_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void add_fw_rule_source_address_list(
		string [] virtual_servers,
		string [] [] rules,
		string [] [] [] lists
	) {
		this.Invoke("add_fw_rule_source_address_list", new object [] {
				virtual_servers,
				rules,
				lists});

	}
	public System.IAsyncResult Beginadd_fw_rule_source_address_list(string [] virtual_servers,string [] [] rules,string [] [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_source_address_list", new object[] {
			virtual_servers,
			rules,
			lists}, callback, asyncState);
	}
	public void Endadd_fw_rule_source_address_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_source_address_range
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void add_fw_rule_source_address_range(
		string [] virtual_servers,
		string [] [] rules,
		CommonAddressRange [] [] [] ranges
	) {
		this.Invoke("add_fw_rule_source_address_range", new object [] {
				virtual_servers,
				rules,
				ranges});

	}
	public System.IAsyncResult Beginadd_fw_rule_source_address_range(string [] virtual_servers,string [] [] rules,CommonAddressRange [] [] [] ranges, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_source_address_range", new object[] {
			virtual_servers,
			rules,
			ranges}, callback, asyncState);
	}
	public void Endadd_fw_rule_source_address_range(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_source_geo
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void add_fw_rule_source_geo(
		string [] virtual_servers,
		string [] [] rules,
		CommonGeoLocation [] [] [] geos
	) {
		this.Invoke("add_fw_rule_source_geo", new object [] {
				virtual_servers,
				rules,
				geos});

	}
	public System.IAsyncResult Beginadd_fw_rule_source_geo(string [] virtual_servers,string [] [] rules,CommonGeoLocation [] [] [] geos, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_source_geo", new object[] {
			virtual_servers,
			rules,
			geos}, callback, asyncState);
	}
	public void Endadd_fw_rule_source_geo(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_source_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void add_fw_rule_source_port(
		string [] virtual_servers,
		string [] [] rules,
		CommonPortRange [] [] [] ports
	) {
		this.Invoke("add_fw_rule_source_port", new object [] {
				virtual_servers,
				rules,
				ports});

	}
	public System.IAsyncResult Beginadd_fw_rule_source_port(string [] virtual_servers,string [] [] rules,CommonPortRange [] [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_source_port", new object[] {
			virtual_servers,
			rules,
			ports}, callback, asyncState);
	}
	public void Endadd_fw_rule_source_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_source_port_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void add_fw_rule_source_port_list(
		string [] virtual_servers,
		string [] [] rules,
		string [] [] [] lists
	) {
		this.Invoke("add_fw_rule_source_port_list", new object [] {
				virtual_servers,
				rules,
				lists});

	}
	public System.IAsyncResult Beginadd_fw_rule_source_port_list(string [] virtual_servers,string [] [] rules,string [] [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_source_port_list", new object[] {
			virtual_servers,
			rules,
			lists}, callback, asyncState);
	}
	public void Endadd_fw_rule_source_port_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_source_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void add_fw_rule_source_vlan(
		string [] virtual_servers,
		string [] [] rules,
		string [] [] [] vlans
	) {
		this.Invoke("add_fw_rule_source_vlan", new object [] {
				virtual_servers,
				rules,
				vlans});

	}
	public System.IAsyncResult Beginadd_fw_rule_source_vlan(string [] virtual_servers,string [] [] rules,string [] [] [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_source_vlan", new object[] {
			virtual_servers,
			rules,
			vlans}, callback, asyncState);
	}
	public void Endadd_fw_rule_source_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_fw_rule_with_rule_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void add_fw_rule_with_rule_list(
		string [] virtual_servers,
		string [] [] rules,
		CommonFirewallRulePlacement [] [] placements,
		string [] [] lists,
		CommonFirewallRuleState [] [] states
	) {
		this.Invoke("add_fw_rule_with_rule_list", new object [] {
				virtual_servers,
				rules,
				placements,
				lists,
				states});

	}
	public System.IAsyncResult Beginadd_fw_rule_with_rule_list(string [] virtual_servers,string [] [] rules,CommonFirewallRulePlacement [] [] placements,string [] [] lists,CommonFirewallRuleState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_fw_rule_with_rule_list", new object[] {
			virtual_servers,
			rules,
			placements,
			lists,
			states}, callback, asyncState);
	}
	public void Endadd_fw_rule_with_rule_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_httpclass_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void add_httpclass_profile(
		string [] virtual_servers,
		LocalLBVirtualServerVirtualServerHttpClass [] [] profiles
	) {
		this.Invoke("add_httpclass_profile", new object [] {
				virtual_servers,
				profiles});

	}
	public System.IAsyncResult Beginadd_httpclass_profile(string [] virtual_servers,LocalLBVirtualServerVirtualServerHttpClass [] [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_httpclass_profile", new object[] {
			virtual_servers,
			profiles}, callback, asyncState);
	}
	public void Endadd_httpclass_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void add_metadata(
		string [] virtual_servers,
		string [] [] names,
		string [] [] values
	) {
		this.Invoke("add_metadata", new object [] {
				virtual_servers,
				names,
				values});

	}
	public System.IAsyncResult Beginadd_metadata(string [] virtual_servers,string [] [] names,string [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_metadata", new object[] {
			virtual_servers,
			names,
			values}, callback, asyncState);
	}
	public void Endadd_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_persistence_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void add_persistence_profile(
		string [] virtual_servers,
		LocalLBVirtualServerVirtualServerPersistence [] [] profiles
	) {
		this.Invoke("add_persistence_profile", new object [] {
				virtual_servers,
				profiles});

	}
	public System.IAsyncResult Beginadd_persistence_profile(string [] virtual_servers,LocalLBVirtualServerVirtualServerPersistence [] [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_persistence_profile", new object[] {
			virtual_servers,
			profiles}, callback, asyncState);
	}
	public void Endadd_persistence_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void add_profile(
		string [] virtual_servers,
		LocalLBVirtualServerVirtualServerProfile [] [] profiles
	) {
		this.Invoke("add_profile", new object [] {
				virtual_servers,
				profiles});

	}
	public System.IAsyncResult Beginadd_profile(string [] virtual_servers,LocalLBVirtualServerVirtualServerProfile [] [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_profile", new object[] {
			virtual_servers,
			profiles}, callback, asyncState);
	}
	public void Endadd_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_related_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void add_related_rule(
		string [] virtual_servers,
		LocalLBVirtualServerVirtualServerRule [] [] rules
	) {
		this.Invoke("add_related_rule", new object [] {
				virtual_servers,
				rules});

	}
	public System.IAsyncResult Beginadd_related_rule(string [] virtual_servers,LocalLBVirtualServerVirtualServerRule [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_related_rule", new object[] {
			virtual_servers,
			rules}, callback, asyncState);
	}
	public void Endadd_related_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void add_rule(
		string [] virtual_servers,
		LocalLBVirtualServerVirtualServerRule [] [] rules
	) {
		this.Invoke("add_rule", new object [] {
				virtual_servers,
				rules});

	}
	public System.IAsyncResult Beginadd_rule(string [] virtual_servers,LocalLBVirtualServerVirtualServerRule [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_rule", new object[] {
			virtual_servers,
			rules}, callback, asyncState);
	}
	public void Endadd_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_security_log_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void add_security_log_profile(
		string [] virtual_servers,
		string [] [] profiles
	) {
		this.Invoke("add_security_log_profile", new object [] {
				virtual_servers,
				profiles});

	}
	public System.IAsyncResult Beginadd_security_log_profile(string [] virtual_servers,string [] [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_security_log_profile", new object[] {
			virtual_servers,
			profiles}, callback, asyncState);
	}
	public void Endadd_security_log_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void create(
		CommonVirtualServerDefinition [] definitions,
		string [] wildmasks,
		LocalLBVirtualServerVirtualServerResource [] resources,
		LocalLBVirtualServerVirtualServerProfile [] [] profiles
	) {
		this.Invoke("create", new object [] {
				definitions,
				wildmasks,
				resources,
				profiles});

	}
	public System.IAsyncResult Begincreate(CommonVirtualServerDefinition [] definitions,string [] wildmasks,LocalLBVirtualServerVirtualServerResource [] resources,LocalLBVirtualServerVirtualServerProfile [] [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			definitions,
			wildmasks,
			resources,
			profiles}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_virtual_servers
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
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
	// delete_persistence_record
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void delete_persistence_record(
		string [] virtual_servers,
		LocalLBPersistenceMode [] persistence_modes
	) {
		this.Invoke("delete_persistence_record", new object [] {
				virtual_servers,
				persistence_modes});

	}
	public System.IAsyncResult Begindelete_persistence_record(string [] virtual_servers,LocalLBPersistenceMode [] persistence_modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_persistence_record", new object[] {
			virtual_servers,
			persistence_modes}, callback, asyncState);
	}
	public void Enddelete_persistence_record(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_virtual_server
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void delete_virtual_server(
		string [] virtual_servers
	) {
		this.Invoke("delete_virtual_server", new object [] {
				virtual_servers});

	}
	public System.IAsyncResult Begindelete_virtual_server(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_virtual_server", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public void Enddelete_virtual_server(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_actual_hardware_acceleration
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBHardwareAccelerationMode [] get_actual_hardware_acceleration(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_actual_hardware_acceleration", new object [] {
				virtual_servers});
		return ((LocalLBHardwareAccelerationMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_actual_hardware_acceleration(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_actual_hardware_acceleration", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public LocalLBHardwareAccelerationMode [] Endget_actual_hardware_acceleration(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBHardwareAccelerationMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_all_fw_rule_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonFirewallRuleStatistics [] get_all_fw_rule_statistics(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_all_fw_rule_statistics", new object [] {
				virtual_servers});
		return ((CommonFirewallRuleStatistics [])(results[0]));
	}
	public System.IAsyncResult Beginget_all_fw_rule_statistics(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_fw_rule_statistics", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public CommonFirewallRuleStatistics [] Endget_all_fw_rule_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonFirewallRuleStatistics [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBVirtualServerVirtualServerStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((LocalLBVirtualServerVirtualServerStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public LocalLBVirtualServerVirtualServerStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBVirtualServerVirtualServerStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_authentication_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBVirtualServerVirtualServerAuthentication [] [] get_authentication_profile(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_authentication_profile", new object [] {
				virtual_servers});
		return ((LocalLBVirtualServerVirtualServerAuthentication [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_authentication_profile(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_authentication_profile", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public LocalLBVirtualServerVirtualServerAuthentication [] [] Endget_authentication_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBVirtualServerVirtualServerAuthentication [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_auto_lasthop
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonAutoLasthop [] get_auto_lasthop(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_auto_lasthop", new object [] {
				virtual_servers});
		return ((CommonAutoLasthop [])(results[0]));
	}
	public System.IAsyncResult Beginget_auto_lasthop(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_auto_lasthop", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public CommonAutoLasthop [] Endget_auto_lasthop(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonAutoLasthop [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_bw_controller_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_bw_controller_policy(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_bw_controller_policy", new object [] {
				virtual_servers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_bw_controller_policy(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_bw_controller_policy", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public string [] Endget_bw_controller_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_clone_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBVirtualServerVirtualServerClonePool [] [] get_clone_pool(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_clone_pool", new object [] {
				virtual_servers});
		return ((LocalLBVirtualServerVirtualServerClonePool [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_clone_pool(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_clone_pool", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public LocalLBVirtualServerVirtualServerClonePool [] [] Endget_clone_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBVirtualServerVirtualServerClonePool [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cmp_enable_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBVirtualServerVirtualServerCMPEnableMode [] get_cmp_enable_mode(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_cmp_enable_mode", new object [] {
				virtual_servers});
		return ((LocalLBVirtualServerVirtualServerCMPEnableMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_cmp_enable_mode(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cmp_enable_mode", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public LocalLBVirtualServerVirtualServerCMPEnableMode [] Endget_cmp_enable_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBVirtualServerVirtualServerCMPEnableMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cmp_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_cmp_enabled_state(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_cmp_enabled_state", new object [] {
				virtual_servers});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_cmp_enabled_state(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cmp_enabled_state", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_cmp_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_connection_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonULong64 [] get_connection_limit(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_connection_limit", new object [] {
				virtual_servers});
		return ((CommonULong64 [])(results[0]));
	}
	public System.IAsyncResult Beginget_connection_limit(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_connection_limit", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public CommonULong64 [] Endget_connection_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonULong64 [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_connection_mirror_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_connection_mirror_state(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_connection_mirror_state", new object [] {
				virtual_servers});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_connection_mirror_state(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_connection_mirror_state", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_connection_mirror_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_content_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_content_policy(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_content_policy", new object [] {
				virtual_servers});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_content_policy(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_content_policy", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public string [] [] Endget_content_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_contribute_to_address_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] get_contribute_to_address_status(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_contribute_to_address_status", new object [] {
				virtual_servers});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginget_contribute_to_address_status(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_contribute_to_address_status", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public bool [] Endget_contribute_to_address_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default_pool_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_default_pool_name(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_default_pool_name", new object [] {
				virtual_servers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_default_pool_name(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_default_pool_name", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public string [] Endget_default_pool_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_description", new object [] {
				virtual_servers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_destination
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonIPPortDefinition [] get_destination(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_destination", new object [] {
				virtual_servers});
		return ((CommonIPPortDefinition [])(results[0]));
	}
	public System.IAsyncResult Beginget_destination(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_destination", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public CommonIPPortDefinition [] Endget_destination(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonIPPortDefinition [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_destination_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonAddressPort [] get_destination_v2(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_destination_v2", new object [] {
				virtual_servers});
		return ((CommonAddressPort [])(results[0]));
	}
	public System.IAsyncResult Beginget_destination_v2(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_destination_v2", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public CommonAddressPort [] Endget_destination_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonAddressPort [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_enabled_state(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_enabled_state", new object [] {
				virtual_servers});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_enabled_state(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_enabled_state", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_enforced_firewall_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_enforced_firewall_policy(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_enforced_firewall_policy", new object [] {
				virtual_servers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_enforced_firewall_policy(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_enforced_firewall_policy", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public string [] Endget_enforced_firewall_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_eviction_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_eviction_policy(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_eviction_policy", new object [] {
				virtual_servers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_eviction_policy(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_eviction_policy", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public string [] Endget_eviction_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fallback_persistence_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_fallback_persistence_profile(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_fallback_persistence_profile", new object [] {
				virtual_servers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_fallback_persistence_profile(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fallback_persistence_profile", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public string [] Endget_fallback_persistence_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_fw_rule(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_fw_rule", new object [] {
				virtual_servers});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public string [] [] Endget_fw_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonFirewallRuleAction [] [] get_fw_rule_action(
		string [] virtual_servers,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_action", new object [] {
				virtual_servers,
				rules});
		return ((CommonFirewallRuleAction [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_action(string [] virtual_servers,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_action", new object[] {
			virtual_servers,
			rules}, callback, asyncState);
	}
	public CommonFirewallRuleAction [] [] Endget_fw_rule_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonFirewallRuleAction [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_fw_rule_description(
		string [] virtual_servers,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_description", new object [] {
				virtual_servers,
				rules});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_description(string [] virtual_servers,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_description", new object[] {
			virtual_servers,
			rules}, callback, asyncState);
	}
	public string [] [] Endget_fw_rule_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_destination_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_destination_address(
		string [] virtual_servers,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_destination_address", new object [] {
				virtual_servers,
				rules});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_address(string [] virtual_servers,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_address", new object[] {
			virtual_servers,
			rules}, callback, asyncState);
	}
	public string [] [] [] Endget_fw_rule_destination_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_destination_address_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_destination_address_description(
		string [] virtual_servers,
		string [] [] rules,
		string [] [] [] addresses
	) {
		object [] results = this.Invoke("get_fw_rule_destination_address_description", new object [] {
				virtual_servers,
				rules,
				addresses});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_address_description(string [] virtual_servers,string [] [] rules,string [] [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_address_description", new object[] {
			virtual_servers,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_destination_address_list(
		string [] virtual_servers,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_destination_address_list", new object [] {
				virtual_servers,
				rules});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_address_list(string [] virtual_servers,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_address_list", new object[] {
			virtual_servers,
			rules}, callback, asyncState);
	}
	public string [] [] [] Endget_fw_rule_destination_address_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_destination_address_range
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonAddressRange [] [] [] get_fw_rule_destination_address_range(
		string [] virtual_servers,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_destination_address_range", new object [] {
				virtual_servers,
				rules});
		return ((CommonAddressRange [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_address_range(string [] virtual_servers,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_address_range", new object[] {
			virtual_servers,
			rules}, callback, asyncState);
	}
	public CommonAddressRange [] [] [] Endget_fw_rule_destination_address_range(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonAddressRange [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_destination_address_range_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_destination_address_range_description(
		string [] virtual_servers,
		string [] [] rules,
		CommonAddressRange [] [] [] ranges
	) {
		object [] results = this.Invoke("get_fw_rule_destination_address_range_description", new object [] {
				virtual_servers,
				rules,
				ranges});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_address_range_description(string [] virtual_servers,string [] [] rules,CommonAddressRange [] [] [] ranges, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_address_range_description", new object[] {
			virtual_servers,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonGeoLocation [] [] [] get_fw_rule_destination_geo(
		string [] virtual_servers,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_destination_geo", new object [] {
				virtual_servers,
				rules});
		return ((CommonGeoLocation [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_geo(string [] virtual_servers,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_geo", new object[] {
			virtual_servers,
			rules}, callback, asyncState);
	}
	public CommonGeoLocation [] [] [] Endget_fw_rule_destination_geo(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonGeoLocation [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_destination_geo_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_destination_geo_description(
		string [] virtual_servers,
		string [] [] rules,
		CommonGeoLocation [] [] [] geos
	) {
		object [] results = this.Invoke("get_fw_rule_destination_geo_description", new object [] {
				virtual_servers,
				rules,
				geos});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_geo_description(string [] virtual_servers,string [] [] rules,CommonGeoLocation [] [] [] geos, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_geo_description", new object[] {
			virtual_servers,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonPortRange [] [] [] get_fw_rule_destination_port(
		string [] virtual_servers,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_destination_port", new object [] {
				virtual_servers,
				rules});
		return ((CommonPortRange [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_port(string [] virtual_servers,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_port", new object[] {
			virtual_servers,
			rules}, callback, asyncState);
	}
	public CommonPortRange [] [] [] Endget_fw_rule_destination_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonPortRange [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_destination_port_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_destination_port_description(
		string [] virtual_servers,
		string [] [] rules,
		CommonPortRange [] [] [] ports
	) {
		object [] results = this.Invoke("get_fw_rule_destination_port_description", new object [] {
				virtual_servers,
				rules,
				ports});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_port_description(string [] virtual_servers,string [] [] rules,CommonPortRange [] [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_port_description", new object[] {
			virtual_servers,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_destination_port_list(
		string [] virtual_servers,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_destination_port_list", new object [] {
				virtual_servers,
				rules});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_destination_port_list(string [] virtual_servers,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_destination_port_list", new object[] {
			virtual_servers,
			rules}, callback, asyncState);
	}
	public string [] [] [] Endget_fw_rule_destination_port_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_icmp_typecode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonFirewallRuleICMPTypeCode [] [] [] get_fw_rule_icmp_typecode(
		string [] virtual_servers,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_icmp_typecode", new object [] {
				virtual_servers,
				rules});
		return ((CommonFirewallRuleICMPTypeCode [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_icmp_typecode(string [] virtual_servers,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_icmp_typecode", new object[] {
			virtual_servers,
			rules}, callback, asyncState);
	}
	public CommonFirewallRuleICMPTypeCode [] [] [] Endget_fw_rule_icmp_typecode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonFirewallRuleICMPTypeCode [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_icmp_typecode_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_icmp_typecode_description(
		string [] virtual_servers,
		string [] [] rules,
		CommonFirewallRuleICMPTypeCode [] [] [] typecodes
	) {
		object [] results = this.Invoke("get_fw_rule_icmp_typecode_description", new object [] {
				virtual_servers,
				rules,
				typecodes});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_icmp_typecode_description(string [] virtual_servers,string [] [] rules,CommonFirewallRuleICMPTypeCode [] [] [] typecodes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_icmp_typecode_description", new object[] {
			virtual_servers,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_fw_rule_irule(
		string [] virtual_servers,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_irule", new object [] {
				virtual_servers,
				rules});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_irule(string [] virtual_servers,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_irule", new object[] {
			virtual_servers,
			rules}, callback, asyncState);
	}
	public string [] [] Endget_fw_rule_irule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_log_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] [] get_fw_rule_log_state(
		string [] virtual_servers,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_log_state", new object [] {
				virtual_servers,
				rules});
		return ((CommonEnabledState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_log_state(string [] virtual_servers,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_log_state", new object[] {
			virtual_servers,
			rules}, callback, asyncState);
	}
	public CommonEnabledState [] [] Endget_fw_rule_log_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_order
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_fw_rule_order(
		string [] virtual_servers,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_order", new object [] {
				virtual_servers,
				rules});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_order(string [] virtual_servers,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_order", new object[] {
			virtual_servers,
			rules}, callback, asyncState);
	}
	public long [] [] Endget_fw_rule_order(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_protocol
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonProtocolType [] [] get_fw_rule_protocol(
		string [] virtual_servers,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_protocol", new object [] {
				virtual_servers,
				rules});
		return ((CommonProtocolType [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_protocol(string [] virtual_servers,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_protocol", new object[] {
			virtual_servers,
			rules}, callback, asyncState);
	}
	public CommonProtocolType [] [] Endget_fw_rule_protocol(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonProtocolType [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_protocol_numeric
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_fw_rule_protocol_numeric(
		string [] virtual_servers,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_protocol_numeric", new object [] {
				virtual_servers,
				rules});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_protocol_numeric(string [] virtual_servers,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_protocol_numeric", new object[] {
			virtual_servers,
			rules}, callback, asyncState);
	}
	public long [] [] Endget_fw_rule_protocol_numeric(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_rule_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_fw_rule_rule_list(
		string [] virtual_servers,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_rule_list", new object [] {
				virtual_servers,
				rules});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_rule_list(string [] virtual_servers,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_rule_list", new object[] {
			virtual_servers,
			rules}, callback, asyncState);
	}
	public string [] [] Endget_fw_rule_rule_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_source_address(
		string [] virtual_servers,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_source_address", new object [] {
				virtual_servers,
				rules});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_address(string [] virtual_servers,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_address", new object[] {
			virtual_servers,
			rules}, callback, asyncState);
	}
	public string [] [] [] Endget_fw_rule_source_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_address_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_source_address_description(
		string [] virtual_servers,
		string [] [] rules,
		string [] [] [] addresses
	) {
		object [] results = this.Invoke("get_fw_rule_source_address_description", new object [] {
				virtual_servers,
				rules,
				addresses});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_address_description(string [] virtual_servers,string [] [] rules,string [] [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_address_description", new object[] {
			virtual_servers,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_source_address_list(
		string [] virtual_servers,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_source_address_list", new object [] {
				virtual_servers,
				rules});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_address_list(string [] virtual_servers,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_address_list", new object[] {
			virtual_servers,
			rules}, callback, asyncState);
	}
	public string [] [] [] Endget_fw_rule_source_address_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_address_range
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonAddressRange [] [] [] get_fw_rule_source_address_range(
		string [] virtual_servers,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_source_address_range", new object [] {
				virtual_servers,
				rules});
		return ((CommonAddressRange [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_address_range(string [] virtual_servers,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_address_range", new object[] {
			virtual_servers,
			rules}, callback, asyncState);
	}
	public CommonAddressRange [] [] [] Endget_fw_rule_source_address_range(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonAddressRange [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_address_range_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_source_address_range_description(
		string [] virtual_servers,
		string [] [] rules,
		CommonAddressRange [] [] [] ranges
	) {
		object [] results = this.Invoke("get_fw_rule_source_address_range_description", new object [] {
				virtual_servers,
				rules,
				ranges});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_address_range_description(string [] virtual_servers,string [] [] rules,CommonAddressRange [] [] [] ranges, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_address_range_description", new object[] {
			virtual_servers,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonGeoLocation [] [] [] get_fw_rule_source_geo(
		string [] virtual_servers,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_source_geo", new object [] {
				virtual_servers,
				rules});
		return ((CommonGeoLocation [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_geo(string [] virtual_servers,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_geo", new object[] {
			virtual_servers,
			rules}, callback, asyncState);
	}
	public CommonGeoLocation [] [] [] Endget_fw_rule_source_geo(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonGeoLocation [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_geo_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_source_geo_description(
		string [] virtual_servers,
		string [] [] rules,
		CommonGeoLocation [] [] [] geos
	) {
		object [] results = this.Invoke("get_fw_rule_source_geo_description", new object [] {
				virtual_servers,
				rules,
				geos});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_geo_description(string [] virtual_servers,string [] [] rules,CommonGeoLocation [] [] [] geos, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_geo_description", new object[] {
			virtual_servers,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonPortRange [] [] [] get_fw_rule_source_port(
		string [] virtual_servers,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_source_port", new object [] {
				virtual_servers,
				rules});
		return ((CommonPortRange [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_port(string [] virtual_servers,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_port", new object[] {
			virtual_servers,
			rules}, callback, asyncState);
	}
	public CommonPortRange [] [] [] Endget_fw_rule_source_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonPortRange [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_port_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_source_port_description(
		string [] virtual_servers,
		string [] [] rules,
		CommonPortRange [] [] [] ports
	) {
		object [] results = this.Invoke("get_fw_rule_source_port_description", new object [] {
				virtual_servers,
				rules,
				ports});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_port_description(string [] virtual_servers,string [] [] rules,CommonPortRange [] [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_port_description", new object[] {
			virtual_servers,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_source_port_list(
		string [] virtual_servers,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_source_port_list", new object [] {
				virtual_servers,
				rules});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_port_list(string [] virtual_servers,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_port_list", new object[] {
			virtual_servers,
			rules}, callback, asyncState);
	}
	public string [] [] [] Endget_fw_rule_source_port_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_source_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] [] get_fw_rule_source_vlan(
		string [] virtual_servers,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_source_vlan", new object [] {
				virtual_servers,
				rules});
		return ((string [] [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_source_vlan(string [] virtual_servers,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_source_vlan", new object[] {
			virtual_servers,
			rules}, callback, asyncState);
	}
	public string [] [] [] Endget_fw_rule_source_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonFirewallRuleState [] [] get_fw_rule_state(
		string [] virtual_servers,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_state", new object [] {
				virtual_servers,
				rules});
		return ((CommonFirewallRuleState [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_state(string [] virtual_servers,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_state", new object[] {
			virtual_servers,
			rules}, callback, asyncState);
	}
	public CommonFirewallRuleState [] [] Endget_fw_rule_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonFirewallRuleState [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonFirewallRuleStatistics [] get_fw_rule_statistics(
		string [] virtual_servers,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_statistics", new object [] {
				virtual_servers,
				rules});
		return ((CommonFirewallRuleStatistics [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_statistics(string [] virtual_servers,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_statistics", new object[] {
			virtual_servers,
			rules}, callback, asyncState);
	}
	public CommonFirewallRuleStatistics [] Endget_fw_rule_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonFirewallRuleStatistics [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fw_rule_weekly_schedule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_fw_rule_weekly_schedule(
		string [] virtual_servers,
		string [] [] rules
	) {
		object [] results = this.Invoke("get_fw_rule_weekly_schedule", new object [] {
				virtual_servers,
				rules});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_fw_rule_weekly_schedule(string [] virtual_servers,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fw_rule_weekly_schedule", new object[] {
			virtual_servers,
			rules}, callback, asyncState);
	}
	public string [] [] Endget_fw_rule_weekly_schedule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_gtm_score
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonULong64 [] get_gtm_score(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_gtm_score", new object [] {
				virtual_servers});
		return ((CommonULong64 [])(results[0]));
	}
	public System.IAsyncResult Beginget_gtm_score(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_gtm_score", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public CommonULong64 [] Endget_gtm_score(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonULong64 [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_httpclass_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBVirtualServerVirtualServerHttpClass [] [] get_httpclass_profile(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_httpclass_profile", new object [] {
				virtual_servers});
		return ((LocalLBVirtualServerVirtualServerHttpClass [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_httpclass_profile(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_httpclass_profile", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public LocalLBVirtualServerVirtualServerHttpClass [] [] Endget_httpclass_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBVirtualServerVirtualServerHttpClass [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ip_intelligence_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_ip_intelligence_policy(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_ip_intelligence_policy", new object [] {
				virtual_servers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_ip_intelligence_policy(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ip_intelligence_policy", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public string [] Endget_ip_intelligence_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_last_hop_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_last_hop_pool(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_last_hop_pool", new object [] {
				virtual_servers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_last_hop_pool(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_last_hop_pool", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public string [] Endget_last_hop_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_metadata(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_metadata", new object [] {
				virtual_servers});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_metadata", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public string [] [] Endget_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_metadata_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_metadata_description(
		string [] virtual_servers,
		string [] [] names
	) {
		object [] results = this.Invoke("get_metadata_description", new object [] {
				virtual_servers,
				names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata_description(string [] virtual_servers,string [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_metadata_description", new object[] {
			virtual_servers,
			names}, callback, asyncState);
	}
	public string [] [] Endget_metadata_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_metadata_persistence
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonMetadataPersistence [] [] get_metadata_persistence(
		string [] virtual_servers,
		string [] [] names
	) {
		object [] results = this.Invoke("get_metadata_persistence", new object [] {
				virtual_servers,
				names});
		return ((CommonMetadataPersistence [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata_persistence(string [] virtual_servers,string [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_metadata_persistence", new object[] {
			virtual_servers,
			names}, callback, asyncState);
	}
	public CommonMetadataPersistence [] [] Endget_metadata_persistence(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonMetadataPersistence [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_metadata_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_metadata_value(
		string [] virtual_servers,
		string [] [] names
	) {
		object [] results = this.Invoke("get_metadata_value", new object [] {
				virtual_servers,
				names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata_value(string [] virtual_servers,string [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_metadata_value", new object[] {
			virtual_servers,
			names}, callback, asyncState);
	}
	public string [] [] Endget_metadata_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_module_score
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBVirtualServerVirtualServerModuleScore [] [] get_module_score(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_module_score", new object [] {
				virtual_servers});
		return ((LocalLBVirtualServerVirtualServerModuleScore [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_module_score(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_module_score", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public LocalLBVirtualServerVirtualServerModuleScore [] [] Endget_module_score(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBVirtualServerVirtualServerModuleScore [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_nat64_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_nat64_state(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_nat64_state", new object [] {
				virtual_servers});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_nat64_state(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_nat64_state", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_nat64_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_object_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBObjectStatus [] get_object_status(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_object_status", new object [] {
				virtual_servers});
		return ((LocalLBObjectStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_object_status(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_object_status", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public LocalLBObjectStatus [] Endget_object_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBObjectStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_persistence_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBVirtualServerVirtualServerPersistence [] [] get_persistence_profile(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_persistence_profile", new object [] {
				virtual_servers});
		return ((LocalLBVirtualServerVirtualServerPersistence [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_persistence_profile(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_persistence_profile", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public LocalLBVirtualServerVirtualServerPersistence [] [] Endget_persistence_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBVirtualServerVirtualServerPersistence [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_persistence_record
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBPersistenceRecord [] [] get_persistence_record(
		string [] virtual_servers,
		LocalLBPersistenceMode [] persistence_modes
	) {
		object [] results = this.Invoke("get_persistence_record", new object [] {
				virtual_servers,
				persistence_modes});
		return ((LocalLBPersistenceRecord [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_persistence_record(string [] virtual_servers,LocalLBPersistenceMode [] persistence_modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_persistence_record", new object[] {
			virtual_servers,
			persistence_modes}, callback, asyncState);
	}
	public LocalLBPersistenceRecord [] [] Endget_persistence_record(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBPersistenceRecord [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBVirtualServerVirtualServerProfileAttribute [] [] get_profile(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_profile", new object [] {
				virtual_servers});
		return ((LocalLBVirtualServerVirtualServerProfileAttribute [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_profile(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_profile", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public LocalLBVirtualServerVirtualServerProfileAttribute [] [] Endget_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBVirtualServerVirtualServerProfileAttribute [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_protocol
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonProtocolType [] get_protocol(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_protocol", new object [] {
				virtual_servers});
		return ((CommonProtocolType [])(results[0]));
	}
	public System.IAsyncResult Beginget_protocol(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_protocol", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public CommonProtocolType [] Endget_protocol(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonProtocolType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rate_class
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_rate_class(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_rate_class", new object [] {
				virtual_servers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_rate_class(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rate_class", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public string [] Endget_rate_class(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rate_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_rate_limit(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_rate_limit", new object [] {
				virtual_servers});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_rate_limit(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rate_limit", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public long [] Endget_rate_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rate_limit_destination_mask
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_rate_limit_destination_mask(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_rate_limit_destination_mask", new object [] {
				virtual_servers});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_rate_limit_destination_mask(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rate_limit_destination_mask", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public long [] Endget_rate_limit_destination_mask(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rate_limit_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBRateLimitMode [] get_rate_limit_mode(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_rate_limit_mode", new object [] {
				virtual_servers});
		return ((LocalLBRateLimitMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_rate_limit_mode(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rate_limit_mode", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public LocalLBRateLimitMode [] Endget_rate_limit_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBRateLimitMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rate_limit_source_mask
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_rate_limit_source_mask(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_rate_limit_source_mask", new object [] {
				virtual_servers});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_rate_limit_source_mask(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rate_limit_source_mask", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public long [] Endget_rate_limit_source_mask(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_related_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBVirtualServerVirtualServerRule [] [] get_related_rule(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_related_rule", new object [] {
				virtual_servers});
		return ((LocalLBVirtualServerVirtualServerRule [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_related_rule(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_related_rule", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public LocalLBVirtualServerVirtualServerRule [] [] Endget_related_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBVirtualServerVirtualServerRule [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBVirtualServerVirtualServerRule [] [] get_rule(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_rule", new object [] {
				virtual_servers});
		return ((LocalLBVirtualServerVirtualServerRule [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_rule(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rule", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public LocalLBVirtualServerVirtualServerRule [] [] Endget_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBVirtualServerVirtualServerRule [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_security_log_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_security_log_profile(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_security_log_profile", new object [] {
				virtual_servers});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_security_log_profile(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_security_log_profile", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public string [] [] Endget_security_log_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_snat_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_snat_pool(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_snat_pool", new object [] {
				virtual_servers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_snat_pool(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_snat_pool", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public string [] Endget_snat_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_snat_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBSnatType [] get_snat_type(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_snat_type", new object [] {
				virtual_servers});
		return ((LocalLBSnatType [])(results[0]));
	}
	public System.IAsyncResult Beginget_snat_type(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_snat_type", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public LocalLBSnatType [] Endget_snat_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBSnatType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_source_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_source_address(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_source_address", new object [] {
				virtual_servers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_source_address(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_source_address", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public string [] Endget_source_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_source_address_translation_lsn_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_source_address_translation_lsn_pool(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_source_address_translation_lsn_pool", new object [] {
				virtual_servers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_source_address_translation_lsn_pool(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_source_address_translation_lsn_pool", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public string [] Endget_source_address_translation_lsn_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_source_address_translation_snat_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_source_address_translation_snat_pool(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_source_address_translation_snat_pool", new object [] {
				virtual_servers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_source_address_translation_snat_pool(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_source_address_translation_snat_pool", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public string [] Endget_source_address_translation_snat_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_source_address_translation_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBVirtualServerSourceAddressTranslationType [] get_source_address_translation_type(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_source_address_translation_type", new object [] {
				virtual_servers});
		return ((LocalLBVirtualServerSourceAddressTranslationType [])(results[0]));
	}
	public System.IAsyncResult Beginget_source_address_translation_type(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_source_address_translation_type", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public LocalLBVirtualServerSourceAddressTranslationType [] Endget_source_address_translation_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBVirtualServerSourceAddressTranslationType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_source_port_behavior
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonSourcePortBehavior [] get_source_port_behavior(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_source_port_behavior", new object [] {
				virtual_servers});
		return ((CommonSourcePortBehavior [])(results[0]));
	}
	public System.IAsyncResult Beginget_source_port_behavior(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_source_port_behavior", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public CommonSourcePortBehavior [] Endget_source_port_behavior(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonSourcePortBehavior [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_staged_firewall_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_staged_firewall_policy(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_staged_firewall_policy", new object [] {
				virtual_servers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_staged_firewall_policy(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_staged_firewall_policy", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public string [] Endget_staged_firewall_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBVirtualServerVirtualServerStatistics get_statistics(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				virtual_servers});
		return ((LocalLBVirtualServerVirtualServerStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public LocalLBVirtualServerVirtualServerStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBVirtualServerVirtualServerStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_traffic_acceleration_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonTrafficAccelerationStatus [] get_traffic_acceleration_status(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_traffic_acceleration_status", new object [] {
				virtual_servers});
		return ((CommonTrafficAccelerationStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_traffic_acceleration_status(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_traffic_acceleration_status", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public CommonTrafficAccelerationStatus [] Endget_traffic_acceleration_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonTrafficAccelerationStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_translate_address_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_translate_address_state(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_translate_address_state", new object [] {
				virtual_servers});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_translate_address_state(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_translate_address_state", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_translate_address_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_translate_port_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_translate_port_state(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_translate_port_state", new object [] {
				virtual_servers});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_translate_port_state(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_translate_port_state", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_translate_port_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBVirtualServerVirtualServerType [] get_type(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_type", new object [] {
				virtual_servers});
		return ((LocalLBVirtualServerVirtualServerType [])(results[0]));
	}
	public System.IAsyncResult Beginget_type(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_type", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public LocalLBVirtualServerVirtualServerType [] Endget_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBVirtualServerVirtualServerType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonVLANFilterList [] get_vlan(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_vlan", new object [] {
				virtual_servers});
		return ((CommonVLANFilterList [])(results[0]));
	}
	public System.IAsyncResult Beginget_vlan(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_vlan", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public CommonVLANFilterList [] Endget_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonVLANFilterList [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_wildmask
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_wildmask(
		string [] virtual_servers
	) {
		object [] results = this.Invoke("get_wildmask", new object [] {
				virtual_servers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_wildmask(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_wildmask", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public string [] Endget_wildmask(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// remove_all_authentication_profiles
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_all_authentication_profiles(
		string [] virtual_servers
	) {
		this.Invoke("remove_all_authentication_profiles", new object [] {
				virtual_servers});

	}
	public System.IAsyncResult Beginremove_all_authentication_profiles(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_authentication_profiles", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public void Endremove_all_authentication_profiles(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_clone_pools
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_all_clone_pools(
		string [] virtual_servers
	) {
		this.Invoke("remove_all_clone_pools", new object [] {
				virtual_servers});

	}
	public System.IAsyncResult Beginremove_all_clone_pools(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_clone_pools", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public void Endremove_all_clone_pools(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_content_policies
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_all_content_policies(
		string [] virtual_servers
	) {
		this.Invoke("remove_all_content_policies", new object [] {
				virtual_servers});

	}
	public System.IAsyncResult Beginremove_all_content_policies(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_content_policies", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public void Endremove_all_content_policies(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_destination_address_lists
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_all_fw_rule_destination_address_lists(
		string [] virtual_servers,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_destination_address_lists", new object [] {
				virtual_servers,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_destination_address_lists(string [] virtual_servers,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_destination_address_lists", new object[] {
			virtual_servers,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_destination_address_lists(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_destination_address_ranges
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_all_fw_rule_destination_address_ranges(
		string [] virtual_servers,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_destination_address_ranges", new object [] {
				virtual_servers,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_destination_address_ranges(string [] virtual_servers,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_destination_address_ranges", new object[] {
			virtual_servers,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_destination_address_ranges(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_destination_addresses
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_all_fw_rule_destination_addresses(
		string [] virtual_servers,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_destination_addresses", new object [] {
				virtual_servers,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_destination_addresses(string [] virtual_servers,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_destination_addresses", new object[] {
			virtual_servers,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_destination_addresses(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_destination_geos
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_all_fw_rule_destination_geos(
		string [] virtual_servers,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_destination_geos", new object [] {
				virtual_servers,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_destination_geos(string [] virtual_servers,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_destination_geos", new object[] {
			virtual_servers,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_destination_geos(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_destination_port_lists
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_all_fw_rule_destination_port_lists(
		string [] virtual_servers,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_destination_port_lists", new object [] {
				virtual_servers,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_destination_port_lists(string [] virtual_servers,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_destination_port_lists", new object[] {
			virtual_servers,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_destination_port_lists(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_destination_ports
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_all_fw_rule_destination_ports(
		string [] virtual_servers,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_destination_ports", new object [] {
				virtual_servers,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_destination_ports(string [] virtual_servers,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_destination_ports", new object[] {
			virtual_servers,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_destination_ports(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_icmp_typecodes
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_all_fw_rule_icmp_typecodes(
		string [] virtual_servers,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_icmp_typecodes", new object [] {
				virtual_servers,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_icmp_typecodes(string [] virtual_servers,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_icmp_typecodes", new object[] {
			virtual_servers,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_icmp_typecodes(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_source_address_lists
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_all_fw_rule_source_address_lists(
		string [] virtual_servers,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_source_address_lists", new object [] {
				virtual_servers,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_source_address_lists(string [] virtual_servers,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_source_address_lists", new object[] {
			virtual_servers,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_source_address_lists(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_source_address_ranges
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_all_fw_rule_source_address_ranges(
		string [] virtual_servers,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_source_address_ranges", new object [] {
				virtual_servers,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_source_address_ranges(string [] virtual_servers,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_source_address_ranges", new object[] {
			virtual_servers,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_source_address_ranges(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_source_addresses
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_all_fw_rule_source_addresses(
		string [] virtual_servers,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_source_addresses", new object [] {
				virtual_servers,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_source_addresses(string [] virtual_servers,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_source_addresses", new object[] {
			virtual_servers,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_source_addresses(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_source_geos
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_all_fw_rule_source_geos(
		string [] virtual_servers,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_source_geos", new object [] {
				virtual_servers,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_source_geos(string [] virtual_servers,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_source_geos", new object[] {
			virtual_servers,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_source_geos(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_source_port_lists
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_all_fw_rule_source_port_lists(
		string [] virtual_servers,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_source_port_lists", new object [] {
				virtual_servers,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_source_port_lists(string [] virtual_servers,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_source_port_lists", new object[] {
			virtual_servers,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_source_port_lists(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_source_ports
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_all_fw_rule_source_ports(
		string [] virtual_servers,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_source_ports", new object [] {
				virtual_servers,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_source_ports(string [] virtual_servers,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_source_ports", new object[] {
			virtual_servers,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_source_ports(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rule_source_vlans
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_all_fw_rule_source_vlans(
		string [] virtual_servers,
		string [] [] rules
	) {
		this.Invoke("remove_all_fw_rule_source_vlans", new object [] {
				virtual_servers,
				rules});

	}
	public System.IAsyncResult Beginremove_all_fw_rule_source_vlans(string [] virtual_servers,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rule_source_vlans", new object[] {
			virtual_servers,
			rules}, callback, asyncState);
	}
	public void Endremove_all_fw_rule_source_vlans(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_fw_rules
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_all_fw_rules(
		string [] virtual_servers
	) {
		this.Invoke("remove_all_fw_rules", new object [] {
				virtual_servers});

	}
	public System.IAsyncResult Beginremove_all_fw_rules(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_fw_rules", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public void Endremove_all_fw_rules(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_httpclass_profiles
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_all_httpclass_profiles(
		string [] virtual_servers
	) {
		this.Invoke("remove_all_httpclass_profiles", new object [] {
				virtual_servers});

	}
	public System.IAsyncResult Beginremove_all_httpclass_profiles(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_httpclass_profiles", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public void Endremove_all_httpclass_profiles(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_all_metadata(
		string [] virtual_servers
	) {
		this.Invoke("remove_all_metadata", new object [] {
				virtual_servers});

	}
	public System.IAsyncResult Beginremove_all_metadata(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_metadata", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public void Endremove_all_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_persistence_profiles
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_all_persistence_profiles(
		string [] virtual_servers
	) {
		this.Invoke("remove_all_persistence_profiles", new object [] {
				virtual_servers});

	}
	public System.IAsyncResult Beginremove_all_persistence_profiles(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_persistence_profiles", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public void Endremove_all_persistence_profiles(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_profiles
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_all_profiles(
		string [] virtual_servers
	) {
		this.Invoke("remove_all_profiles", new object [] {
				virtual_servers});

	}
	public System.IAsyncResult Beginremove_all_profiles(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_profiles", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public void Endremove_all_profiles(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_related_rules
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_all_related_rules(
		string [] virtual_servers
	) {
		this.Invoke("remove_all_related_rules", new object [] {
				virtual_servers});

	}
	public System.IAsyncResult Beginremove_all_related_rules(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_related_rules", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public void Endremove_all_related_rules(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_rules
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_all_rules(
		string [] virtual_servers
	) {
		this.Invoke("remove_all_rules", new object [] {
				virtual_servers});

	}
	public System.IAsyncResult Beginremove_all_rules(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_rules", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public void Endremove_all_rules(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_all_security_log_profiles
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_all_security_log_profiles(
		string [] virtual_servers
	) {
		this.Invoke("remove_all_security_log_profiles", new object [] {
				virtual_servers});

	}
	public System.IAsyncResult Beginremove_all_security_log_profiles(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_security_log_profiles", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public void Endremove_all_security_log_profiles(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_authentication_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_authentication_profile(
		string [] virtual_servers,
		LocalLBVirtualServerVirtualServerAuthentication [] [] profiles
	) {
		this.Invoke("remove_authentication_profile", new object [] {
				virtual_servers,
				profiles});

	}
	public System.IAsyncResult Beginremove_authentication_profile(string [] virtual_servers,LocalLBVirtualServerVirtualServerAuthentication [] [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_authentication_profile", new object[] {
			virtual_servers,
			profiles}, callback, asyncState);
	}
	public void Endremove_authentication_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_clone_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_clone_pool(
		string [] virtual_servers,
		LocalLBVirtualServerVirtualServerClonePool [] [] clone_pools
	) {
		this.Invoke("remove_clone_pool", new object [] {
				virtual_servers,
				clone_pools});

	}
	public System.IAsyncResult Beginremove_clone_pool(string [] virtual_servers,LocalLBVirtualServerVirtualServerClonePool [] [] clone_pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_clone_pool", new object[] {
			virtual_servers,
			clone_pools}, callback, asyncState);
	}
	public void Endremove_clone_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_content_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_content_policy(
		string [] virtual_servers,
		string [] [] policies
	) {
		this.Invoke("remove_content_policy", new object [] {
				virtual_servers,
				policies});

	}
	public System.IAsyncResult Beginremove_content_policy(string [] virtual_servers,string [] [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_content_policy", new object[] {
			virtual_servers,
			policies}, callback, asyncState);
	}
	public void Endremove_content_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_fw_rule(
		string [] virtual_servers,
		string [] [] rules
	) {
		this.Invoke("remove_fw_rule", new object [] {
				virtual_servers,
				rules});

	}
	public System.IAsyncResult Beginremove_fw_rule(string [] virtual_servers,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule", new object[] {
			virtual_servers,
			rules}, callback, asyncState);
	}
	public void Endremove_fw_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_destination_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_fw_rule_destination_address(
		string [] virtual_servers,
		string [] [] rules,
		string [] [] [] addresses
	) {
		this.Invoke("remove_fw_rule_destination_address", new object [] {
				virtual_servers,
				rules,
				addresses});

	}
	public System.IAsyncResult Beginremove_fw_rule_destination_address(string [] virtual_servers,string [] [] rules,string [] [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_destination_address", new object[] {
			virtual_servers,
			rules,
			addresses}, callback, asyncState);
	}
	public void Endremove_fw_rule_destination_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_destination_address_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_fw_rule_destination_address_list(
		string [] virtual_servers,
		string [] [] rules,
		string [] [] [] lists
	) {
		this.Invoke("remove_fw_rule_destination_address_list", new object [] {
				virtual_servers,
				rules,
				lists});

	}
	public System.IAsyncResult Beginremove_fw_rule_destination_address_list(string [] virtual_servers,string [] [] rules,string [] [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_destination_address_list", new object[] {
			virtual_servers,
			rules,
			lists}, callback, asyncState);
	}
	public void Endremove_fw_rule_destination_address_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_destination_address_range
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_fw_rule_destination_address_range(
		string [] virtual_servers,
		string [] [] rules,
		CommonAddressRange [] [] [] ranges
	) {
		this.Invoke("remove_fw_rule_destination_address_range", new object [] {
				virtual_servers,
				rules,
				ranges});

	}
	public System.IAsyncResult Beginremove_fw_rule_destination_address_range(string [] virtual_servers,string [] [] rules,CommonAddressRange [] [] [] ranges, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_destination_address_range", new object[] {
			virtual_servers,
			rules,
			ranges}, callback, asyncState);
	}
	public void Endremove_fw_rule_destination_address_range(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_destination_geo
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_fw_rule_destination_geo(
		string [] virtual_servers,
		string [] [] rules,
		CommonGeoLocation [] [] [] geos
	) {
		this.Invoke("remove_fw_rule_destination_geo", new object [] {
				virtual_servers,
				rules,
				geos});

	}
	public System.IAsyncResult Beginremove_fw_rule_destination_geo(string [] virtual_servers,string [] [] rules,CommonGeoLocation [] [] [] geos, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_destination_geo", new object[] {
			virtual_servers,
			rules,
			geos}, callback, asyncState);
	}
	public void Endremove_fw_rule_destination_geo(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_destination_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_fw_rule_destination_port(
		string [] virtual_servers,
		string [] [] rules,
		CommonPortRange [] [] [] ports
	) {
		this.Invoke("remove_fw_rule_destination_port", new object [] {
				virtual_servers,
				rules,
				ports});

	}
	public System.IAsyncResult Beginremove_fw_rule_destination_port(string [] virtual_servers,string [] [] rules,CommonPortRange [] [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_destination_port", new object[] {
			virtual_servers,
			rules,
			ports}, callback, asyncState);
	}
	public void Endremove_fw_rule_destination_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_destination_port_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_fw_rule_destination_port_list(
		string [] virtual_servers,
		string [] [] rules,
		string [] [] [] lists
	) {
		this.Invoke("remove_fw_rule_destination_port_list", new object [] {
				virtual_servers,
				rules,
				lists});

	}
	public System.IAsyncResult Beginremove_fw_rule_destination_port_list(string [] virtual_servers,string [] [] rules,string [] [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_destination_port_list", new object[] {
			virtual_servers,
			rules,
			lists}, callback, asyncState);
	}
	public void Endremove_fw_rule_destination_port_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_icmp_typecode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_fw_rule_icmp_typecode(
		string [] virtual_servers,
		string [] [] rules,
		CommonFirewallRuleICMPTypeCode [] [] [] typecodes
	) {
		this.Invoke("remove_fw_rule_icmp_typecode", new object [] {
				virtual_servers,
				rules,
				typecodes});

	}
	public System.IAsyncResult Beginremove_fw_rule_icmp_typecode(string [] virtual_servers,string [] [] rules,CommonFirewallRuleICMPTypeCode [] [] [] typecodes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_icmp_typecode", new object[] {
			virtual_servers,
			rules,
			typecodes}, callback, asyncState);
	}
	public void Endremove_fw_rule_icmp_typecode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_source_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_fw_rule_source_address(
		string [] virtual_servers,
		string [] [] rules,
		string [] [] [] addresses
	) {
		this.Invoke("remove_fw_rule_source_address", new object [] {
				virtual_servers,
				rules,
				addresses});

	}
	public System.IAsyncResult Beginremove_fw_rule_source_address(string [] virtual_servers,string [] [] rules,string [] [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_source_address", new object[] {
			virtual_servers,
			rules,
			addresses}, callback, asyncState);
	}
	public void Endremove_fw_rule_source_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_source_address_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_fw_rule_source_address_list(
		string [] virtual_servers,
		string [] [] rules,
		string [] [] [] lists
	) {
		this.Invoke("remove_fw_rule_source_address_list", new object [] {
				virtual_servers,
				rules,
				lists});

	}
	public System.IAsyncResult Beginremove_fw_rule_source_address_list(string [] virtual_servers,string [] [] rules,string [] [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_source_address_list", new object[] {
			virtual_servers,
			rules,
			lists}, callback, asyncState);
	}
	public void Endremove_fw_rule_source_address_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_source_address_range
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_fw_rule_source_address_range(
		string [] virtual_servers,
		string [] [] rules,
		CommonAddressRange [] [] [] ranges
	) {
		this.Invoke("remove_fw_rule_source_address_range", new object [] {
				virtual_servers,
				rules,
				ranges});

	}
	public System.IAsyncResult Beginremove_fw_rule_source_address_range(string [] virtual_servers,string [] [] rules,CommonAddressRange [] [] [] ranges, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_source_address_range", new object[] {
			virtual_servers,
			rules,
			ranges}, callback, asyncState);
	}
	public void Endremove_fw_rule_source_address_range(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_source_geo
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_fw_rule_source_geo(
		string [] virtual_servers,
		string [] [] rules,
		CommonGeoLocation [] [] [] geos
	) {
		this.Invoke("remove_fw_rule_source_geo", new object [] {
				virtual_servers,
				rules,
				geos});

	}
	public System.IAsyncResult Beginremove_fw_rule_source_geo(string [] virtual_servers,string [] [] rules,CommonGeoLocation [] [] [] geos, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_source_geo", new object[] {
			virtual_servers,
			rules,
			geos}, callback, asyncState);
	}
	public void Endremove_fw_rule_source_geo(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_source_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_fw_rule_source_port(
		string [] virtual_servers,
		string [] [] rules,
		CommonPortRange [] [] [] ports
	) {
		this.Invoke("remove_fw_rule_source_port", new object [] {
				virtual_servers,
				rules,
				ports});

	}
	public System.IAsyncResult Beginremove_fw_rule_source_port(string [] virtual_servers,string [] [] rules,CommonPortRange [] [] [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_source_port", new object[] {
			virtual_servers,
			rules,
			ports}, callback, asyncState);
	}
	public void Endremove_fw_rule_source_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_source_port_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_fw_rule_source_port_list(
		string [] virtual_servers,
		string [] [] rules,
		string [] [] [] lists
	) {
		this.Invoke("remove_fw_rule_source_port_list", new object [] {
				virtual_servers,
				rules,
				lists});

	}
	public System.IAsyncResult Beginremove_fw_rule_source_port_list(string [] virtual_servers,string [] [] rules,string [] [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_source_port_list", new object[] {
			virtual_servers,
			rules,
			lists}, callback, asyncState);
	}
	public void Endremove_fw_rule_source_port_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_fw_rule_source_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_fw_rule_source_vlan(
		string [] virtual_servers,
		string [] [] rules,
		string [] [] [] vlans
	) {
		this.Invoke("remove_fw_rule_source_vlan", new object [] {
				virtual_servers,
				rules,
				vlans});

	}
	public System.IAsyncResult Beginremove_fw_rule_source_vlan(string [] virtual_servers,string [] [] rules,string [] [] [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_fw_rule_source_vlan", new object[] {
			virtual_servers,
			rules,
			vlans}, callback, asyncState);
	}
	public void Endremove_fw_rule_source_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_httpclass_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_httpclass_profile(
		string [] virtual_servers,
		LocalLBVirtualServerVirtualServerHttpClass [] [] profiles
	) {
		this.Invoke("remove_httpclass_profile", new object [] {
				virtual_servers,
				profiles});

	}
	public System.IAsyncResult Beginremove_httpclass_profile(string [] virtual_servers,LocalLBVirtualServerVirtualServerHttpClass [] [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_httpclass_profile", new object[] {
			virtual_servers,
			profiles}, callback, asyncState);
	}
	public void Endremove_httpclass_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_metadata(
		string [] virtual_servers,
		string [] [] names
	) {
		this.Invoke("remove_metadata", new object [] {
				virtual_servers,
				names});

	}
	public System.IAsyncResult Beginremove_metadata(string [] virtual_servers,string [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_metadata", new object[] {
			virtual_servers,
			names}, callback, asyncState);
	}
	public void Endremove_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_persistence_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_persistence_profile(
		string [] virtual_servers,
		LocalLBVirtualServerVirtualServerPersistence [] [] profiles
	) {
		this.Invoke("remove_persistence_profile", new object [] {
				virtual_servers,
				profiles});

	}
	public System.IAsyncResult Beginremove_persistence_profile(string [] virtual_servers,LocalLBVirtualServerVirtualServerPersistence [] [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_persistence_profile", new object[] {
			virtual_servers,
			profiles}, callback, asyncState);
	}
	public void Endremove_persistence_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_profile(
		string [] virtual_servers,
		LocalLBVirtualServerVirtualServerProfile [] [] profiles
	) {
		this.Invoke("remove_profile", new object [] {
				virtual_servers,
				profiles});

	}
	public System.IAsyncResult Beginremove_profile(string [] virtual_servers,LocalLBVirtualServerVirtualServerProfile [] [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_profile", new object[] {
			virtual_servers,
			profiles}, callback, asyncState);
	}
	public void Endremove_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_related_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_related_rule(
		string [] virtual_servers,
		LocalLBVirtualServerVirtualServerRule [] [] rules
	) {
		this.Invoke("remove_related_rule", new object [] {
				virtual_servers,
				rules});

	}
	public System.IAsyncResult Beginremove_related_rule(string [] virtual_servers,LocalLBVirtualServerVirtualServerRule [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_related_rule", new object[] {
			virtual_servers,
			rules}, callback, asyncState);
	}
	public void Endremove_related_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_rule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_rule(
		string [] virtual_servers,
		LocalLBVirtualServerVirtualServerRule [] [] rules
	) {
		this.Invoke("remove_rule", new object [] {
				virtual_servers,
				rules});

	}
	public System.IAsyncResult Beginremove_rule(string [] virtual_servers,LocalLBVirtualServerVirtualServerRule [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_rule", new object[] {
			virtual_servers,
			rules}, callback, asyncState);
	}
	public void Endremove_rule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_security_log_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void remove_security_log_profile(
		string [] virtual_servers,
		string [] [] profiles
	) {
		this.Invoke("remove_security_log_profile", new object [] {
				virtual_servers,
				profiles});

	}
	public System.IAsyncResult Beginremove_security_log_profile(string [] virtual_servers,string [] [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_security_log_profile", new object[] {
			virtual_servers,
			profiles}, callback, asyncState);
	}
	public void Endremove_security_log_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_fw_rule_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void reset_fw_rule_statistics(
		string [] virtual_servers,
		string [] [] rules
	) {
		this.Invoke("reset_fw_rule_statistics", new object [] {
				virtual_servers,
				rules});

	}
	public System.IAsyncResult Beginreset_fw_rule_statistics(string [] virtual_servers,string [] [] rules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_fw_rule_statistics", new object[] {
			virtual_servers,
			rules}, callback, asyncState);
	}
	public void Endreset_fw_rule_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void reset_statistics(
		string [] virtual_servers
	) {
		this.Invoke("reset_statistics", new object [] {
				virtual_servers});

	}
	public System.IAsyncResult Beginreset_statistics(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public void Endreset_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_auto_lasthop
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_auto_lasthop(
		string [] virtual_servers,
		CommonAutoLasthop [] values
	) {
		this.Invoke("set_auto_lasthop", new object [] {
				virtual_servers,
				values});

	}
	public System.IAsyncResult Beginset_auto_lasthop(string [] virtual_servers,CommonAutoLasthop [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_auto_lasthop", new object[] {
			virtual_servers,
			values}, callback, asyncState);
	}
	public void Endset_auto_lasthop(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_bw_controller_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_bw_controller_policy(
		string [] virtual_servers,
		string [] policies
	) {
		this.Invoke("set_bw_controller_policy", new object [] {
				virtual_servers,
				policies});

	}
	public System.IAsyncResult Beginset_bw_controller_policy(string [] virtual_servers,string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_bw_controller_policy", new object[] {
			virtual_servers,
			policies}, callback, asyncState);
	}
	public void Endset_bw_controller_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_cmp_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_cmp_enabled_state(
		string [] virtual_servers,
		CommonEnabledState [] states
	) {
		this.Invoke("set_cmp_enabled_state", new object [] {
				virtual_servers,
				states});

	}
	public System.IAsyncResult Beginset_cmp_enabled_state(string [] virtual_servers,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_cmp_enabled_state", new object[] {
			virtual_servers,
			states}, callback, asyncState);
	}
	public void Endset_cmp_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_connection_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_connection_limit(
		string [] virtual_servers,
		CommonULong64 [] limits
	) {
		this.Invoke("set_connection_limit", new object [] {
				virtual_servers,
				limits});

	}
	public System.IAsyncResult Beginset_connection_limit(string [] virtual_servers,CommonULong64 [] limits, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_connection_limit", new object[] {
			virtual_servers,
			limits}, callback, asyncState);
	}
	public void Endset_connection_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_connection_mirror_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_connection_mirror_state(
		string [] virtual_servers,
		CommonEnabledState [] states
	) {
		this.Invoke("set_connection_mirror_state", new object [] {
				virtual_servers,
				states});

	}
	public System.IAsyncResult Beginset_connection_mirror_state(string [] virtual_servers,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_connection_mirror_state", new object[] {
			virtual_servers,
			states}, callback, asyncState);
	}
	public void Endset_connection_mirror_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_contribute_to_address_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_contribute_to_address_status(
		string [] virtual_servers,
		bool [] contribute
	) {
		this.Invoke("set_contribute_to_address_status", new object [] {
				virtual_servers,
				contribute});

	}
	public System.IAsyncResult Beginset_contribute_to_address_status(string [] virtual_servers,bool [] contribute, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_contribute_to_address_status", new object[] {
			virtual_servers,
			contribute}, callback, asyncState);
	}
	public void Endset_contribute_to_address_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_pool_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_default_pool_name(
		string [] virtual_servers,
		string [] default_pools
	) {
		this.Invoke("set_default_pool_name", new object [] {
				virtual_servers,
				default_pools});

	}
	public System.IAsyncResult Beginset_default_pool_name(string [] virtual_servers,string [] default_pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_pool_name", new object[] {
			virtual_servers,
			default_pools}, callback, asyncState);
	}
	public void Endset_default_pool_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_description(
		string [] virtual_servers,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				virtual_servers,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] virtual_servers,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			virtual_servers,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_destination
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_destination(
		string [] virtual_servers,
		CommonIPPortDefinition [] destinations
	) {
		this.Invoke("set_destination", new object [] {
				virtual_servers,
				destinations});

	}
	public System.IAsyncResult Beginset_destination(string [] virtual_servers,CommonIPPortDefinition [] destinations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_destination", new object[] {
			virtual_servers,
			destinations}, callback, asyncState);
	}
	public void Endset_destination(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_destination_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_destination_v2(
		string [] virtual_servers,
		CommonAddressPort [] destinations
	) {
		this.Invoke("set_destination_v2", new object [] {
				virtual_servers,
				destinations});

	}
	public System.IAsyncResult Beginset_destination_v2(string [] virtual_servers,CommonAddressPort [] destinations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_destination_v2", new object[] {
			virtual_servers,
			destinations}, callback, asyncState);
	}
	public void Endset_destination_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_enabled_state(
		string [] virtual_servers,
		CommonEnabledState [] states
	) {
		this.Invoke("set_enabled_state", new object [] {
				virtual_servers,
				states});

	}
	public System.IAsyncResult Beginset_enabled_state(string [] virtual_servers,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_enabled_state", new object[] {
			virtual_servers,
			states}, callback, asyncState);
	}
	public void Endset_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_enforced_firewall_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_enforced_firewall_policy(
		string [] virtual_servers,
		string [] policies
	) {
		this.Invoke("set_enforced_firewall_policy", new object [] {
				virtual_servers,
				policies});

	}
	public System.IAsyncResult Beginset_enforced_firewall_policy(string [] virtual_servers,string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_enforced_firewall_policy", new object[] {
			virtual_servers,
			policies}, callback, asyncState);
	}
	public void Endset_enforced_firewall_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_eviction_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_eviction_policy(
		string [] virtual_servers,
		string [] policies
	) {
		this.Invoke("set_eviction_policy", new object [] {
				virtual_servers,
				policies});

	}
	public System.IAsyncResult Beginset_eviction_policy(string [] virtual_servers,string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_eviction_policy", new object[] {
			virtual_servers,
			policies}, callback, asyncState);
	}
	public void Endset_eviction_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fallback_persistence_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_fallback_persistence_profile(
		string [] virtual_servers,
		string [] profile_names
	) {
		this.Invoke("set_fallback_persistence_profile", new object [] {
				virtual_servers,
				profile_names});

	}
	public System.IAsyncResult Beginset_fallback_persistence_profile(string [] virtual_servers,string [] profile_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fallback_persistence_profile", new object[] {
			virtual_servers,
			profile_names}, callback, asyncState);
	}
	public void Endset_fallback_persistence_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_fw_rule_action(
		string [] virtual_servers,
		string [] [] rules,
		CommonFirewallRuleAction [] [] actions
	) {
		this.Invoke("set_fw_rule_action", new object [] {
				virtual_servers,
				rules,
				actions});

	}
	public System.IAsyncResult Beginset_fw_rule_action(string [] virtual_servers,string [] [] rules,CommonFirewallRuleAction [] [] actions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_action", new object[] {
			virtual_servers,
			rules,
			actions}, callback, asyncState);
	}
	public void Endset_fw_rule_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_fw_rule_description(
		string [] virtual_servers,
		string [] [] rules,
		string [] [] descriptions
	) {
		this.Invoke("set_fw_rule_description", new object [] {
				virtual_servers,
				rules,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_description(string [] virtual_servers,string [] [] rules,string [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_description", new object[] {
			virtual_servers,
			rules,
			descriptions}, callback, asyncState);
	}
	public void Endset_fw_rule_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_destination_address_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_fw_rule_destination_address_description(
		string [] virtual_servers,
		string [] [] rules,
		string [] [] [] addresses,
		string [] [] [] descriptions
	) {
		this.Invoke("set_fw_rule_destination_address_description", new object [] {
				virtual_servers,
				rules,
				addresses,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_destination_address_description(string [] virtual_servers,string [] [] rules,string [] [] [] addresses,string [] [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_destination_address_description", new object[] {
			virtual_servers,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_fw_rule_destination_address_range_description(
		string [] virtual_servers,
		string [] [] rules,
		CommonAddressRange [] [] [] ranges,
		string [] [] [] descriptions
	) {
		this.Invoke("set_fw_rule_destination_address_range_description", new object [] {
				virtual_servers,
				rules,
				ranges,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_destination_address_range_description(string [] virtual_servers,string [] [] rules,CommonAddressRange [] [] [] ranges,string [] [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_destination_address_range_description", new object[] {
			virtual_servers,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_fw_rule_destination_geo_description(
		string [] virtual_servers,
		string [] [] rules,
		CommonGeoLocation [] [] [] geos,
		string [] [] [] descriptions
	) {
		this.Invoke("set_fw_rule_destination_geo_description", new object [] {
				virtual_servers,
				rules,
				geos,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_destination_geo_description(string [] virtual_servers,string [] [] rules,CommonGeoLocation [] [] [] geos,string [] [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_destination_geo_description", new object[] {
			virtual_servers,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_fw_rule_destination_port_description(
		string [] virtual_servers,
		string [] [] rules,
		CommonPortRange [] [] [] ports,
		string [] [] [] descriptions
	) {
		this.Invoke("set_fw_rule_destination_port_description", new object [] {
				virtual_servers,
				rules,
				ports,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_destination_port_description(string [] virtual_servers,string [] [] rules,CommonPortRange [] [] [] ports,string [] [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_destination_port_description", new object[] {
			virtual_servers,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_fw_rule_icmp_typecode_description(
		string [] virtual_servers,
		string [] [] rules,
		CommonFirewallRuleICMPTypeCode [] [] [] typecodes,
		string [] [] [] descriptions
	) {
		this.Invoke("set_fw_rule_icmp_typecode_description", new object [] {
				virtual_servers,
				rules,
				typecodes,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_icmp_typecode_description(string [] virtual_servers,string [] [] rules,CommonFirewallRuleICMPTypeCode [] [] [] typecodes,string [] [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_icmp_typecode_description", new object[] {
			virtual_servers,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_fw_rule_irule(
		string [] virtual_servers,
		string [] [] rules,
		string [] [] irules
	) {
		this.Invoke("set_fw_rule_irule", new object [] {
				virtual_servers,
				rules,
				irules});

	}
	public System.IAsyncResult Beginset_fw_rule_irule(string [] virtual_servers,string [] [] rules,string [] [] irules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_irule", new object[] {
			virtual_servers,
			rules,
			irules}, callback, asyncState);
	}
	public void Endset_fw_rule_irule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_log_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_fw_rule_log_state(
		string [] virtual_servers,
		string [] [] rules,
		CommonEnabledState [] [] states
	) {
		this.Invoke("set_fw_rule_log_state", new object [] {
				virtual_servers,
				rules,
				states});

	}
	public System.IAsyncResult Beginset_fw_rule_log_state(string [] virtual_servers,string [] [] rules,CommonEnabledState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_log_state", new object[] {
			virtual_servers,
			rules,
			states}, callback, asyncState);
	}
	public void Endset_fw_rule_log_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_order
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_fw_rule_order(
		string [] virtual_servers,
		string [] [] rules,
		long [] [] orders
	) {
		this.Invoke("set_fw_rule_order", new object [] {
				virtual_servers,
				rules,
				orders});

	}
	public System.IAsyncResult Beginset_fw_rule_order(string [] virtual_servers,string [] [] rules,long [] [] orders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_order", new object[] {
			virtual_servers,
			rules,
			orders}, callback, asyncState);
	}
	public void Endset_fw_rule_order(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_protocol
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_fw_rule_protocol(
		string [] virtual_servers,
		string [] [] rules,
		CommonProtocolType [] [] protocols
	) {
		this.Invoke("set_fw_rule_protocol", new object [] {
				virtual_servers,
				rules,
				protocols});

	}
	public System.IAsyncResult Beginset_fw_rule_protocol(string [] virtual_servers,string [] [] rules,CommonProtocolType [] [] protocols, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_protocol", new object[] {
			virtual_servers,
			rules,
			protocols}, callback, asyncState);
	}
	public void Endset_fw_rule_protocol(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_protocol_numeric
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_fw_rule_protocol_numeric(
		string [] virtual_servers,
		string [] [] rules,
		long [] [] protocols
	) {
		this.Invoke("set_fw_rule_protocol_numeric", new object [] {
				virtual_servers,
				rules,
				protocols});

	}
	public System.IAsyncResult Beginset_fw_rule_protocol_numeric(string [] virtual_servers,string [] [] rules,long [] [] protocols, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_protocol_numeric", new object[] {
			virtual_servers,
			rules,
			protocols}, callback, asyncState);
	}
	public void Endset_fw_rule_protocol_numeric(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_rule_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_fw_rule_rule_list(
		string [] virtual_servers,
		string [] [] rules,
		string [] [] lists
	) {
		this.Invoke("set_fw_rule_rule_list", new object [] {
				virtual_servers,
				rules,
				lists});

	}
	public System.IAsyncResult Beginset_fw_rule_rule_list(string [] virtual_servers,string [] [] rules,string [] [] lists, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_rule_list", new object[] {
			virtual_servers,
			rules,
			lists}, callback, asyncState);
	}
	public void Endset_fw_rule_rule_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_source_address_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_fw_rule_source_address_description(
		string [] virtual_servers,
		string [] [] rules,
		string [] [] [] addresses,
		string [] [] [] descriptions
	) {
		this.Invoke("set_fw_rule_source_address_description", new object [] {
				virtual_servers,
				rules,
				addresses,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_source_address_description(string [] virtual_servers,string [] [] rules,string [] [] [] addresses,string [] [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_source_address_description", new object[] {
			virtual_servers,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_fw_rule_source_address_range_description(
		string [] virtual_servers,
		string [] [] rules,
		CommonAddressRange [] [] [] ranges,
		string [] [] [] descriptions
	) {
		this.Invoke("set_fw_rule_source_address_range_description", new object [] {
				virtual_servers,
				rules,
				ranges,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_source_address_range_description(string [] virtual_servers,string [] [] rules,CommonAddressRange [] [] [] ranges,string [] [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_source_address_range_description", new object[] {
			virtual_servers,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_fw_rule_source_geo_description(
		string [] virtual_servers,
		string [] [] rules,
		CommonGeoLocation [] [] [] geos,
		string [] [] [] descriptions
	) {
		this.Invoke("set_fw_rule_source_geo_description", new object [] {
				virtual_servers,
				rules,
				geos,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_source_geo_description(string [] virtual_servers,string [] [] rules,CommonGeoLocation [] [] [] geos,string [] [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_source_geo_description", new object[] {
			virtual_servers,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_fw_rule_source_port_description(
		string [] virtual_servers,
		string [] [] rules,
		CommonPortRange [] [] [] ports,
		string [] [] [] descriptions
	) {
		this.Invoke("set_fw_rule_source_port_description", new object [] {
				virtual_servers,
				rules,
				ports,
				descriptions});

	}
	public System.IAsyncResult Beginset_fw_rule_source_port_description(string [] virtual_servers,string [] [] rules,CommonPortRange [] [] [] ports,string [] [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_source_port_description", new object[] {
			virtual_servers,
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_fw_rule_state(
		string [] virtual_servers,
		string [] [] rules,
		CommonFirewallRuleState [] [] states
	) {
		this.Invoke("set_fw_rule_state", new object [] {
				virtual_servers,
				rules,
				states});

	}
	public System.IAsyncResult Beginset_fw_rule_state(string [] virtual_servers,string [] [] rules,CommonFirewallRuleState [] [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_state", new object[] {
			virtual_servers,
			rules,
			states}, callback, asyncState);
	}
	public void Endset_fw_rule_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_fw_rule_weekly_schedule
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_fw_rule_weekly_schedule(
		string [] virtual_servers,
		string [] [] rules,
		string [] [] schedules
	) {
		this.Invoke("set_fw_rule_weekly_schedule", new object [] {
				virtual_servers,
				rules,
				schedules});

	}
	public System.IAsyncResult Beginset_fw_rule_weekly_schedule(string [] virtual_servers,string [] [] rules,string [] [] schedules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_fw_rule_weekly_schedule", new object[] {
			virtual_servers,
			rules,
			schedules}, callback, asyncState);
	}
	public void Endset_fw_rule_weekly_schedule(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_gtm_score
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_gtm_score(
		string [] virtual_servers,
		CommonULong64 [] scores
	) {
		this.Invoke("set_gtm_score", new object [] {
				virtual_servers,
				scores});

	}
	public System.IAsyncResult Beginset_gtm_score(string [] virtual_servers,CommonULong64 [] scores, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_gtm_score", new object[] {
			virtual_servers,
			scores}, callback, asyncState);
	}
	public void Endset_gtm_score(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ip_intelligence_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_ip_intelligence_policy(
		string [] virtual_servers,
		string [] policies
	) {
		this.Invoke("set_ip_intelligence_policy", new object [] {
				virtual_servers,
				policies});

	}
	public System.IAsyncResult Beginset_ip_intelligence_policy(string [] virtual_servers,string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ip_intelligence_policy", new object[] {
			virtual_servers,
			policies}, callback, asyncState);
	}
	public void Endset_ip_intelligence_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_last_hop_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_last_hop_pool(
		string [] virtual_servers,
		string [] last_hop_pools
	) {
		this.Invoke("set_last_hop_pool", new object [] {
				virtual_servers,
				last_hop_pools});

	}
	public System.IAsyncResult Beginset_last_hop_pool(string [] virtual_servers,string [] last_hop_pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_last_hop_pool", new object[] {
			virtual_servers,
			last_hop_pools}, callback, asyncState);
	}
	public void Endset_last_hop_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_metadata_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_metadata_description(
		string [] virtual_servers,
		string [] [] names,
		string [] [] descriptions
	) {
		this.Invoke("set_metadata_description", new object [] {
				virtual_servers,
				names,
				descriptions});

	}
	public System.IAsyncResult Beginset_metadata_description(string [] virtual_servers,string [] [] names,string [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_metadata_description", new object[] {
			virtual_servers,
			names,
			descriptions}, callback, asyncState);
	}
	public void Endset_metadata_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_metadata_persistence
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_metadata_persistence(
		string [] virtual_servers,
		string [] [] names,
		CommonMetadataPersistence [] [] values
	) {
		this.Invoke("set_metadata_persistence", new object [] {
				virtual_servers,
				names,
				values});

	}
	public System.IAsyncResult Beginset_metadata_persistence(string [] virtual_servers,string [] [] names,CommonMetadataPersistence [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_metadata_persistence", new object[] {
			virtual_servers,
			names,
			values}, callback, asyncState);
	}
	public void Endset_metadata_persistence(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_metadata_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_metadata_value(
		string [] virtual_servers,
		string [] [] names,
		string [] [] values
	) {
		this.Invoke("set_metadata_value", new object [] {
				virtual_servers,
				names,
				values});

	}
	public System.IAsyncResult Beginset_metadata_value(string [] virtual_servers,string [] [] names,string [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_metadata_value", new object[] {
			virtual_servers,
			names,
			values}, callback, asyncState);
	}
	public void Endset_metadata_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_nat64_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_nat64_state(
		string [] virtual_servers,
		CommonEnabledState [] states
	) {
		this.Invoke("set_nat64_state", new object [] {
				virtual_servers,
				states});

	}
	public System.IAsyncResult Beginset_nat64_state(string [] virtual_servers,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_nat64_state", new object[] {
			virtual_servers,
			states}, callback, asyncState);
	}
	public void Endset_nat64_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_protocol
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_protocol(
		string [] virtual_servers,
		CommonProtocolType [] protocols
	) {
		this.Invoke("set_protocol", new object [] {
				virtual_servers,
				protocols});

	}
	public System.IAsyncResult Beginset_protocol(string [] virtual_servers,CommonProtocolType [] protocols, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_protocol", new object[] {
			virtual_servers,
			protocols}, callback, asyncState);
	}
	public void Endset_protocol(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rate_class
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_rate_class(
		string [] virtual_servers,
		string [] rate_classes
	) {
		this.Invoke("set_rate_class", new object [] {
				virtual_servers,
				rate_classes});

	}
	public System.IAsyncResult Beginset_rate_class(string [] virtual_servers,string [] rate_classes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rate_class", new object[] {
			virtual_servers,
			rate_classes}, callback, asyncState);
	}
	public void Endset_rate_class(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rate_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_rate_limit(
		string [] virtual_servers,
		long [] limits
	) {
		this.Invoke("set_rate_limit", new object [] {
				virtual_servers,
				limits});

	}
	public System.IAsyncResult Beginset_rate_limit(string [] virtual_servers,long [] limits, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rate_limit", new object[] {
			virtual_servers,
			limits}, callback, asyncState);
	}
	public void Endset_rate_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rate_limit_destination_mask
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_rate_limit_destination_mask(
		string [] virtual_servers,
		long [] masks
	) {
		this.Invoke("set_rate_limit_destination_mask", new object [] {
				virtual_servers,
				masks});

	}
	public System.IAsyncResult Beginset_rate_limit_destination_mask(string [] virtual_servers,long [] masks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rate_limit_destination_mask", new object[] {
			virtual_servers,
			masks}, callback, asyncState);
	}
	public void Endset_rate_limit_destination_mask(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rate_limit_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_rate_limit_mode(
		string [] virtual_servers,
		LocalLBRateLimitMode [] modes
	) {
		this.Invoke("set_rate_limit_mode", new object [] {
				virtual_servers,
				modes});

	}
	public System.IAsyncResult Beginset_rate_limit_mode(string [] virtual_servers,LocalLBRateLimitMode [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rate_limit_mode", new object[] {
			virtual_servers,
			modes}, callback, asyncState);
	}
	public void Endset_rate_limit_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rate_limit_source_mask
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_rate_limit_source_mask(
		string [] virtual_servers,
		long [] masks
	) {
		this.Invoke("set_rate_limit_source_mask", new object [] {
				virtual_servers,
				masks});

	}
	public System.IAsyncResult Beginset_rate_limit_source_mask(string [] virtual_servers,long [] masks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rate_limit_source_mask", new object[] {
			virtual_servers,
			masks}, callback, asyncState);
	}
	public void Endset_rate_limit_source_mask(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_snat_automap
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_snat_automap(
		string [] virtual_servers
	) {
		this.Invoke("set_snat_automap", new object [] {
				virtual_servers});

	}
	public System.IAsyncResult Beginset_snat_automap(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_snat_automap", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public void Endset_snat_automap(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_snat_none
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_snat_none(
		string [] virtual_servers
	) {
		this.Invoke("set_snat_none", new object [] {
				virtual_servers});

	}
	public System.IAsyncResult Beginset_snat_none(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_snat_none", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public void Endset_snat_none(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_snat_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_snat_pool(
		string [] virtual_servers,
		string [] snatpools
	) {
		this.Invoke("set_snat_pool", new object [] {
				virtual_servers,
				snatpools});

	}
	public System.IAsyncResult Beginset_snat_pool(string [] virtual_servers,string [] snatpools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_snat_pool", new object[] {
			virtual_servers,
			snatpools}, callback, asyncState);
	}
	public void Endset_snat_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_source_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_source_address(
		string [] virtual_servers,
		string [] addresses
	) {
		this.Invoke("set_source_address", new object [] {
				virtual_servers,
				addresses});

	}
	public System.IAsyncResult Beginset_source_address(string [] virtual_servers,string [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_source_address", new object[] {
			virtual_servers,
			addresses}, callback, asyncState);
	}
	public void Endset_source_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_source_address_translation_automap
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_source_address_translation_automap(
		string [] virtual_servers
	) {
		this.Invoke("set_source_address_translation_automap", new object [] {
				virtual_servers});

	}
	public System.IAsyncResult Beginset_source_address_translation_automap(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_source_address_translation_automap", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public void Endset_source_address_translation_automap(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_source_address_translation_lsn_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_source_address_translation_lsn_pool(
		string [] virtual_servers,
		string [] pools
	) {
		this.Invoke("set_source_address_translation_lsn_pool", new object [] {
				virtual_servers,
				pools});

	}
	public System.IAsyncResult Beginset_source_address_translation_lsn_pool(string [] virtual_servers,string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_source_address_translation_lsn_pool", new object[] {
			virtual_servers,
			pools}, callback, asyncState);
	}
	public void Endset_source_address_translation_lsn_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_source_address_translation_none
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_source_address_translation_none(
		string [] virtual_servers
	) {
		this.Invoke("set_source_address_translation_none", new object [] {
				virtual_servers});

	}
	public System.IAsyncResult Beginset_source_address_translation_none(string [] virtual_servers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_source_address_translation_none", new object[] {
			virtual_servers}, callback, asyncState);
	}
	public void Endset_source_address_translation_none(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_source_address_translation_snat_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_source_address_translation_snat_pool(
		string [] virtual_servers,
		string [] pools
	) {
		this.Invoke("set_source_address_translation_snat_pool", new object [] {
				virtual_servers,
				pools});

	}
	public System.IAsyncResult Beginset_source_address_translation_snat_pool(string [] virtual_servers,string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_source_address_translation_snat_pool", new object[] {
			virtual_servers,
			pools}, callback, asyncState);
	}
	public void Endset_source_address_translation_snat_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_source_port_behavior
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_source_port_behavior(
		string [] virtual_servers,
		CommonSourcePortBehavior [] source_port_behaviors
	) {
		this.Invoke("set_source_port_behavior", new object [] {
				virtual_servers,
				source_port_behaviors});

	}
	public System.IAsyncResult Beginset_source_port_behavior(string [] virtual_servers,CommonSourcePortBehavior [] source_port_behaviors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_source_port_behavior", new object[] {
			virtual_servers,
			source_port_behaviors}, callback, asyncState);
	}
	public void Endset_source_port_behavior(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_staged_firewall_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_staged_firewall_policy(
		string [] virtual_servers,
		string [] policies
	) {
		this.Invoke("set_staged_firewall_policy", new object [] {
				virtual_servers,
				policies});

	}
	public System.IAsyncResult Beginset_staged_firewall_policy(string [] virtual_servers,string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_staged_firewall_policy", new object[] {
			virtual_servers,
			policies}, callback, asyncState);
	}
	public void Endset_staged_firewall_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_translate_address_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_translate_address_state(
		string [] virtual_servers,
		CommonEnabledState [] states
	) {
		this.Invoke("set_translate_address_state", new object [] {
				virtual_servers,
				states});

	}
	public System.IAsyncResult Beginset_translate_address_state(string [] virtual_servers,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_translate_address_state", new object[] {
			virtual_servers,
			states}, callback, asyncState);
	}
	public void Endset_translate_address_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_translate_port_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_translate_port_state(
		string [] virtual_servers,
		CommonEnabledState [] states
	) {
		this.Invoke("set_translate_port_state", new object [] {
				virtual_servers,
				states});

	}
	public System.IAsyncResult Beginset_translate_port_state(string [] virtual_servers,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_translate_port_state", new object[] {
			virtual_servers,
			states}, callback, asyncState);
	}
	public void Endset_translate_port_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_type(
		string [] virtual_servers,
		LocalLBVirtualServerVirtualServerType [] types
	) {
		this.Invoke("set_type", new object [] {
				virtual_servers,
				types});

	}
	public System.IAsyncResult Beginset_type(string [] virtual_servers,LocalLBVirtualServerVirtualServerType [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_type", new object[] {
			virtual_servers,
			types}, callback, asyncState);
	}
	public void Endset_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_vlan(
		string [] virtual_servers,
		CommonVLANFilterList [] vlans
	) {
		this.Invoke("set_vlan", new object [] {
				virtual_servers,
				vlans});

	}
	public System.IAsyncResult Beginset_vlan(string [] virtual_servers,CommonVLANFilterList [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_vlan", new object[] {
			virtual_servers,
			vlans}, callback, asyncState);
	}
	public void Endset_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_wildmask
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualServer", 
		RequestNamespace="urn:iControl:LocalLB/VirtualServer", ResponseNamespace="urn:iControl:LocalLB/VirtualServer")]
	public void set_wildmask(
		string [] virtual_servers,
		string [] wildmasks
	) {
		this.Invoke("set_wildmask", new object [] {
				virtual_servers,
				wildmasks});

	}
	public System.IAsyncResult Beginset_wildmask(string [] virtual_servers,string [] wildmasks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_wildmask", new object[] {
			virtual_servers,
			wildmasks}, callback, asyncState);
	}
	public void Endset_wildmask(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.VirtualServer.SourceAddressTranslationType", Namespace = "urn:iControl")]
	public enum LocalLBVirtualServerSourceAddressTranslationType
	{
		SRC_TRANS_UNKNOWN,
		SRC_TRANS_NONE,
		SRC_TRANS_AUTOMAP,
		SRC_TRANS_SNATPOOL,
		SRC_TRANS_LSNPOOL,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.VirtualServer.VirtualServerCMPEnableMode", Namespace = "urn:iControl")]
	public enum LocalLBVirtualServerVirtualServerCMPEnableMode
	{
		RESOURCE_TYPE_CMP_ENABLE_ALL,
		RESOURCE_TYPE_CMP_ENABLE_SINGLE,
		RESOURCE_TYPE_CMP_ENABLE_GROUP,
		RESOURCE_TYPE_CMP_ENABLE_UNKNOWN,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.VirtualServer.VirtualServerType", Namespace = "urn:iControl")]
	public enum LocalLBVirtualServerVirtualServerType
	{
		RESOURCE_TYPE_POOL,
		RESOURCE_TYPE_IP_FORWARDING,
		RESOURCE_TYPE_L2_FORWARDING,
		RESOURCE_TYPE_REJECT,
		RESOURCE_TYPE_FAST_L4,
		RESOURCE_TYPE_FAST_HTTP,
		RESOURCE_TYPE_STATELESS,
		RESOURCE_TYPE_DHCP_RELAY,
		RESOURCE_TYPE_UNKNOWN,
		RESOURCE_TYPE_INTERNAL,
		RESOURCE_TYPE_MESSAGE_ROUTING,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.VirtualServer.VirtualServerAuthentication", Namespace = "urn:iControl")]
	public partial class LocalLBVirtualServerVirtualServerAuthentication
	{
		private string profile_nameField;
		public string profile_name
		{
			get { return this.profile_nameField; }
			set { this.profile_nameField = value; }
		}
		private long priorityField;
		public long priority
		{
			get { return this.priorityField; }
			set { this.priorityField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.VirtualServer.VirtualServerClonePool", Namespace = "urn:iControl")]
	public partial class LocalLBVirtualServerVirtualServerClonePool
	{
		private string pool_nameField;
		public string pool_name
		{
			get { return this.pool_nameField; }
			set { this.pool_nameField = value; }
		}
		private LocalLBClonePoolType typeField;
		public LocalLBClonePoolType type
		{
			get { return this.typeField; }
			set { this.typeField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.VirtualServer.VirtualServerHttpClass", Namespace = "urn:iControl")]
	public partial class LocalLBVirtualServerVirtualServerHttpClass
	{
		private string profile_nameField;
		public string profile_name
		{
			get { return this.profile_nameField; }
			set { this.profile_nameField = value; }
		}
		private long priorityField;
		public long priority
		{
			get { return this.priorityField; }
			set { this.priorityField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.VirtualServer.VirtualServerModuleScore", Namespace = "urn:iControl")]
	public partial class LocalLBVirtualServerVirtualServerModuleScore
	{
		private CommonTMOSModule tmos_moduleField;
		public CommonTMOSModule tmos_module
		{
			get { return this.tmos_moduleField; }
			set { this.tmos_moduleField = value; }
		}
		private long scoreField;
		public long score
		{
			get { return this.scoreField; }
			set { this.scoreField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.VirtualServer.VirtualServerPersistence", Namespace = "urn:iControl")]
	public partial class LocalLBVirtualServerVirtualServerPersistence
	{
		private string profile_nameField;
		public string profile_name
		{
			get { return this.profile_nameField; }
			set { this.profile_nameField = value; }
		}
		private bool default_profileField;
		public bool default_profile
		{
			get { return this.default_profileField; }
			set { this.default_profileField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.VirtualServer.VirtualServerProfile", Namespace = "urn:iControl")]
	public partial class LocalLBVirtualServerVirtualServerProfile
	{
		private LocalLBProfileContextType profile_contextField;
		public LocalLBProfileContextType profile_context
		{
			get { return this.profile_contextField; }
			set { this.profile_contextField = value; }
		}
		private string profile_nameField;
		public string profile_name
		{
			get { return this.profile_nameField; }
			set { this.profile_nameField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.VirtualServer.VirtualServerProfileAttribute", Namespace = "urn:iControl")]
	public partial class LocalLBVirtualServerVirtualServerProfileAttribute
	{
		private LocalLBProfileType profile_typeField;
		public LocalLBProfileType profile_type
		{
			get { return this.profile_typeField; }
			set { this.profile_typeField = value; }
		}
		private LocalLBProfileContextType profile_contextField;
		public LocalLBProfileContextType profile_context
		{
			get { return this.profile_contextField; }
			set { this.profile_contextField = value; }
		}
		private string profile_nameField;
		public string profile_name
		{
			get { return this.profile_nameField; }
			set { this.profile_nameField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.VirtualServer.VirtualServerResource", Namespace = "urn:iControl")]
	public partial class LocalLBVirtualServerVirtualServerResource
	{
		private LocalLBVirtualServerVirtualServerType typeField;
		public LocalLBVirtualServerVirtualServerType type
		{
			get { return this.typeField; }
			set { this.typeField = value; }
		}
		private string default_pool_nameField;
		public string default_pool_name
		{
			get { return this.default_pool_nameField; }
			set { this.default_pool_nameField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.VirtualServer.VirtualServerRule", Namespace = "urn:iControl")]
	public partial class LocalLBVirtualServerVirtualServerRule
	{
		private string rule_nameField;
		public string rule_name
		{
			get { return this.rule_nameField; }
			set { this.rule_nameField = value; }
		}
		private long priorityField;
		public long priority
		{
			get { return this.priorityField; }
			set { this.priorityField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.VirtualServer.VirtualServerStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBVirtualServerVirtualServerStatisticEntry
	{
		private CommonVirtualServerDefinition virtual_serverField;
		public CommonVirtualServerDefinition virtual_server
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.VirtualServer.VirtualServerStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBVirtualServerVirtualServerStatistics
	{
		private LocalLBVirtualServerVirtualServerStatisticEntry [] statisticsField;
		public LocalLBVirtualServerVirtualServerStatisticEntry [] statistics
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
