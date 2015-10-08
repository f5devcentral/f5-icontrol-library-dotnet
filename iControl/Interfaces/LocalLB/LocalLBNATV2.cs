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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.NATV2Binding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonVLANFilterList))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBNATV2NATStatistics))]
	public partial class LocalLBNATV2 : iControlInterface {
		public LocalLBNATV2() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NATV2", 
		RequestNamespace="urn:iControl:LocalLB/NATV2", ResponseNamespace="urn:iControl:LocalLB/NATV2")]
	public void create(
		string [] nats,
		string [] orig_addrs,
		string [] trans_addrs,
		string [] traffic_groups,
		CommonVLANFilterList [] vlans
	) {
		this.Invoke("create", new object [] {
				nats,
				orig_addrs,
				trans_addrs,
				traffic_groups,
				vlans});

	}
	public System.IAsyncResult Begincreate(string [] nats,string [] orig_addrs,string [] trans_addrs,string [] traffic_groups,CommonVLANFilterList [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			nats,
			orig_addrs,
			trans_addrs,
			traffic_groups,
			vlans}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_nats
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NATV2", 
		RequestNamespace="urn:iControl:LocalLB/NATV2", ResponseNamespace="urn:iControl:LocalLB/NATV2")]
	public void delete_all_nats(

	) {
		this.Invoke("delete_all_nats", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_nats(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_nats", new object[0], callback, asyncState);
	}
	public void Enddelete_all_nats(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_nat
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NATV2", 
		RequestNamespace="urn:iControl:LocalLB/NATV2", ResponseNamespace="urn:iControl:LocalLB/NATV2")]
	public void delete_nat(
		string [] nats
	) {
		this.Invoke("delete_nat", new object [] {
				nats});

	}
	public System.IAsyncResult Begindelete_nat(string [] nats, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_nat", new object[] {
			nats}, callback, asyncState);
	}
	public void Enddelete_nat(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NATV2", 
		RequestNamespace="urn:iControl:LocalLB/NATV2", ResponseNamespace="urn:iControl:LocalLB/NATV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBNATV2NATStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((LocalLBNATV2NATStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public LocalLBNATV2NATStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBNATV2NATStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_arp_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NATV2", 
		RequestNamespace="urn:iControl:LocalLB/NATV2", ResponseNamespace="urn:iControl:LocalLB/NATV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_arp_state(
		string [] nats
	) {
		object [] results = this.Invoke("get_arp_state", new object [] {
				nats});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_arp_state(string [] nats, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_arp_state", new object[] {
			nats}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_arp_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_auto_lasthop
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NATV2", 
		RequestNamespace="urn:iControl:LocalLB/NATV2", ResponseNamespace="urn:iControl:LocalLB/NATV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonAutoLasthop [] get_auto_lasthop(
		string [] nats
	) {
		object [] results = this.Invoke("get_auto_lasthop", new object [] {
				nats});
		return ((CommonAutoLasthop [])(results[0]));
	}
	public System.IAsyncResult Beginget_auto_lasthop(string [] nats, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_auto_lasthop", new object[] {
			nats}, callback, asyncState);
	}
	public CommonAutoLasthop [] Endget_auto_lasthop(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonAutoLasthop [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NATV2", 
		RequestNamespace="urn:iControl:LocalLB/NATV2", ResponseNamespace="urn:iControl:LocalLB/NATV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] nats
	) {
		object [] results = this.Invoke("get_description", new object [] {
				nats});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] nats, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			nats}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NATV2", 
		RequestNamespace="urn:iControl:LocalLB/NATV2", ResponseNamespace="urn:iControl:LocalLB/NATV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_enabled_state(
		string [] nats
	) {
		object [] results = this.Invoke("get_enabled_state", new object [] {
				nats});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_enabled_state(string [] nats, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_enabled_state", new object[] {
			nats}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NATV2", 
		RequestNamespace="urn:iControl:LocalLB/NATV2", ResponseNamespace="urn:iControl:LocalLB/NATV2")]
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
	// get_origin_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NATV2", 
		RequestNamespace="urn:iControl:LocalLB/NATV2", ResponseNamespace="urn:iControl:LocalLB/NATV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_origin_address(
		string [] nats
	) {
		object [] results = this.Invoke("get_origin_address", new object [] {
				nats});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_origin_address(string [] nats, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_origin_address", new object[] {
			nats}, callback, asyncState);
	}
	public string [] Endget_origin_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NATV2", 
		RequestNamespace="urn:iControl:LocalLB/NATV2", ResponseNamespace="urn:iControl:LocalLB/NATV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBNATV2NATStatistics get_statistics(
		string [] nats
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				nats});
		return ((LocalLBNATV2NATStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] nats, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			nats}, callback, asyncState);
	}
	public LocalLBNATV2NATStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBNATV2NATStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_traffic_group
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NATV2", 
		RequestNamespace="urn:iControl:LocalLB/NATV2", ResponseNamespace="urn:iControl:LocalLB/NATV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_traffic_group(
		string [] nats
	) {
		object [] results = this.Invoke("get_traffic_group", new object [] {
				nats});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_traffic_group(string [] nats, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_traffic_group", new object[] {
			nats}, callback, asyncState);
	}
	public string [] Endget_traffic_group(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_translation_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NATV2", 
		RequestNamespace="urn:iControl:LocalLB/NATV2", ResponseNamespace="urn:iControl:LocalLB/NATV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_translation_address(
		string [] nats
	) {
		object [] results = this.Invoke("get_translation_address", new object [] {
				nats});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_translation_address(string [] nats, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_translation_address", new object[] {
			nats}, callback, asyncState);
	}
	public string [] Endget_translation_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NATV2", 
		RequestNamespace="urn:iControl:LocalLB/NATV2", ResponseNamespace="urn:iControl:LocalLB/NATV2")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NATV2", 
		RequestNamespace="urn:iControl:LocalLB/NATV2", ResponseNamespace="urn:iControl:LocalLB/NATV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonVLANFilterList [] get_vlan(
		string [] nats
	) {
		object [] results = this.Invoke("get_vlan", new object [] {
				nats});
		return ((CommonVLANFilterList [])(results[0]));
	}
	public System.IAsyncResult Beginget_vlan(string [] nats, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_vlan", new object[] {
			nats}, callback, asyncState);
	}
	public CommonVLANFilterList [] Endget_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonVLANFilterList [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// is_traffic_group_inherited
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NATV2", 
		RequestNamespace="urn:iControl:LocalLB/NATV2", ResponseNamespace="urn:iControl:LocalLB/NATV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] is_traffic_group_inherited(
		string [] nats
	) {
		object [] results = this.Invoke("is_traffic_group_inherited", new object [] {
				nats});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginis_traffic_group_inherited(string [] nats, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("is_traffic_group_inherited", new object[] {
			nats}, callback, asyncState);
	}
	public bool [] Endis_traffic_group_inherited(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NATV2", 
		RequestNamespace="urn:iControl:LocalLB/NATV2", ResponseNamespace="urn:iControl:LocalLB/NATV2")]
	public void reset_statistics(
		string [] nats
	) {
		this.Invoke("reset_statistics", new object [] {
				nats});

	}
	public System.IAsyncResult Beginreset_statistics(string [] nats, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics", new object[] {
			nats}, callback, asyncState);
	}
	public void Endreset_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_arp_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NATV2", 
		RequestNamespace="urn:iControl:LocalLB/NATV2", ResponseNamespace="urn:iControl:LocalLB/NATV2")]
	public void set_arp_state(
		string [] nats,
		CommonEnabledState [] states
	) {
		this.Invoke("set_arp_state", new object [] {
				nats,
				states});

	}
	public System.IAsyncResult Beginset_arp_state(string [] nats,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_arp_state", new object[] {
			nats,
			states}, callback, asyncState);
	}
	public void Endset_arp_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_auto_lasthop
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NATV2", 
		RequestNamespace="urn:iControl:LocalLB/NATV2", ResponseNamespace="urn:iControl:LocalLB/NATV2")]
	public void set_auto_lasthop(
		string [] nats,
		CommonAutoLasthop [] values
	) {
		this.Invoke("set_auto_lasthop", new object [] {
				nats,
				values});

	}
	public System.IAsyncResult Beginset_auto_lasthop(string [] nats,CommonAutoLasthop [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_auto_lasthop", new object[] {
			nats,
			values}, callback, asyncState);
	}
	public void Endset_auto_lasthop(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NATV2", 
		RequestNamespace="urn:iControl:LocalLB/NATV2", ResponseNamespace="urn:iControl:LocalLB/NATV2")]
	public void set_description(
		string [] nats,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				nats,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] nats,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			nats,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NATV2", 
		RequestNamespace="urn:iControl:LocalLB/NATV2", ResponseNamespace="urn:iControl:LocalLB/NATV2")]
	public void set_enabled_state(
		string [] nats,
		CommonEnabledState [] states
	) {
		this.Invoke("set_enabled_state", new object [] {
				nats,
				states});

	}
	public System.IAsyncResult Beginset_enabled_state(string [] nats,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_enabled_state", new object[] {
			nats,
			states}, callback, asyncState);
	}
	public void Endset_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_origin_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NATV2", 
		RequestNamespace="urn:iControl:LocalLB/NATV2", ResponseNamespace="urn:iControl:LocalLB/NATV2")]
	public void set_origin_address(
		string [] nats,
		string [] addrs
	) {
		this.Invoke("set_origin_address", new object [] {
				nats,
				addrs});

	}
	public System.IAsyncResult Beginset_origin_address(string [] nats,string [] addrs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_origin_address", new object[] {
			nats,
			addrs}, callback, asyncState);
	}
	public void Endset_origin_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_traffic_group
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NATV2", 
		RequestNamespace="urn:iControl:LocalLB/NATV2", ResponseNamespace="urn:iControl:LocalLB/NATV2")]
	public void set_traffic_group(
		string [] nats,
		string [] traffic_groups
	) {
		this.Invoke("set_traffic_group", new object [] {
				nats,
				traffic_groups});

	}
	public System.IAsyncResult Beginset_traffic_group(string [] nats,string [] traffic_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_traffic_group", new object[] {
			nats,
			traffic_groups}, callback, asyncState);
	}
	public void Endset_traffic_group(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NATV2", 
		RequestNamespace="urn:iControl:LocalLB/NATV2", ResponseNamespace="urn:iControl:LocalLB/NATV2")]
	public void set_vlan(
		string [] nats,
		CommonVLANFilterList [] vlans
	) {
		this.Invoke("set_vlan", new object [] {
				nats,
				vlans});

	}
	public System.IAsyncResult Beginset_vlan(string [] nats,CommonVLANFilterList [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_vlan", new object[] {
			nats,
			vlans}, callback, asyncState);
	}
	public void Endset_vlan(System.IAsyncResult asyncResult) {
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.NATV2.NATStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBNATV2NATStatisticEntry
	{
		private string natField;
		public string nat
		{
			get { return this.natField; }
			set { this.natField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.NATV2.NATStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBNATV2NATStatistics
	{
		private LocalLBNATV2NATStatisticEntry [] statisticsField;
		public LocalLBNATV2NATStatisticEntry [] statistics
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
