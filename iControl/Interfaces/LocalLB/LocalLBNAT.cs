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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.NATBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBNATNATDefinition))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonVLANFilterList))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBNATNATStatistics))]
	public partial class LocalLBNAT : iControlInterface {
		public LocalLBNAT() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NAT", 
		RequestNamespace="urn:iControl:LocalLB/NAT", ResponseNamespace="urn:iControl:LocalLB/NAT")]
	public void create(
		LocalLBNATNATDefinition [] nat_definitions,
		long [] unit_ids,
		CommonVLANFilterList [] vlans
	) {
		this.Invoke("create", new object [] {
				nat_definitions,
				unit_ids,
				vlans});

	}
	public System.IAsyncResult Begincreate(LocalLBNATNATDefinition [] nat_definitions,long [] unit_ids,CommonVLANFilterList [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			nat_definitions,
			unit_ids,
			vlans}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_nats
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NAT", 
		RequestNamespace="urn:iControl:LocalLB/NAT", ResponseNamespace="urn:iControl:LocalLB/NAT")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NAT", 
		RequestNamespace="urn:iControl:LocalLB/NAT", ResponseNamespace="urn:iControl:LocalLB/NAT")]
	public void delete_nat(
		LocalLBNATNATDefinition [] nat_definitions
	) {
		this.Invoke("delete_nat", new object [] {
				nat_definitions});

	}
	public System.IAsyncResult Begindelete_nat(LocalLBNATNATDefinition [] nat_definitions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_nat", new object[] {
			nat_definitions}, callback, asyncState);
	}
	public void Enddelete_nat(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NAT", 
		RequestNamespace="urn:iControl:LocalLB/NAT", ResponseNamespace="urn:iControl:LocalLB/NAT")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBNATNATStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((LocalLBNATNATStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public LocalLBNATNATStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBNATNATStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_arp_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NAT", 
		RequestNamespace="urn:iControl:LocalLB/NAT", ResponseNamespace="urn:iControl:LocalLB/NAT")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_arp_state(
		LocalLBNATNATDefinition [] nat_definitions
	) {
		object [] results = this.Invoke("get_arp_state", new object [] {
				nat_definitions});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_arp_state(LocalLBNATNATDefinition [] nat_definitions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_arp_state", new object[] {
			nat_definitions}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_arp_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NAT", 
		RequestNamespace="urn:iControl:LocalLB/NAT", ResponseNamespace="urn:iControl:LocalLB/NAT")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_enabled_state(
		LocalLBNATNATDefinition [] nat_definitions
	) {
		object [] results = this.Invoke("get_enabled_state", new object [] {
				nat_definitions});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_enabled_state(LocalLBNATNATDefinition [] nat_definitions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_enabled_state", new object[] {
			nat_definitions}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NAT", 
		RequestNamespace="urn:iControl:LocalLB/NAT", ResponseNamespace="urn:iControl:LocalLB/NAT")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBNATNATDefinition [] get_list(

	) {
		object [] results = this.Invoke("get_list", new object [0]);
		return ((LocalLBNATNATDefinition [])(results[0]));
	}
	public System.IAsyncResult Beginget_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_list", new object[0], callback, asyncState);
	}
	public LocalLBNATNATDefinition [] Endget_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBNATNATDefinition [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NAT", 
		RequestNamespace="urn:iControl:LocalLB/NAT", ResponseNamespace="urn:iControl:LocalLB/NAT")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBNATNATStatistics get_statistics(
		LocalLBNATNATDefinition [] nat_definitions
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				nat_definitions});
		return ((LocalLBNATNATStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(LocalLBNATNATDefinition [] nat_definitions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			nat_definitions}, callback, asyncState);
	}
	public LocalLBNATNATStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBNATNATStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_unit_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NAT", 
		RequestNamespace="urn:iControl:LocalLB/NAT", ResponseNamespace="urn:iControl:LocalLB/NAT")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_unit_id(
		LocalLBNATNATDefinition [] nat_definitions
	) {
		object [] results = this.Invoke("get_unit_id", new object [] {
				nat_definitions});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_unit_id(LocalLBNATNATDefinition [] nat_definitions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_unit_id", new object[] {
			nat_definitions}, callback, asyncState);
	}
	public long [] Endget_unit_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NAT", 
		RequestNamespace="urn:iControl:LocalLB/NAT", ResponseNamespace="urn:iControl:LocalLB/NAT")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NAT", 
		RequestNamespace="urn:iControl:LocalLB/NAT", ResponseNamespace="urn:iControl:LocalLB/NAT")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonVLANFilterList [] get_vlan(
		LocalLBNATNATDefinition [] nat_definitions
	) {
		object [] results = this.Invoke("get_vlan", new object [] {
				nat_definitions});
		return ((CommonVLANFilterList [])(results[0]));
	}
	public System.IAsyncResult Beginget_vlan(LocalLBNATNATDefinition [] nat_definitions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_vlan", new object[] {
			nat_definitions}, callback, asyncState);
	}
	public CommonVLANFilterList [] Endget_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonVLANFilterList [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NAT", 
		RequestNamespace="urn:iControl:LocalLB/NAT", ResponseNamespace="urn:iControl:LocalLB/NAT")]
	public void reset_statistics(
		LocalLBNATNATDefinition [] nat_definitions
	) {
		this.Invoke("reset_statistics", new object [] {
				nat_definitions});

	}
	public System.IAsyncResult Beginreset_statistics(LocalLBNATNATDefinition [] nat_definitions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics", new object[] {
			nat_definitions}, callback, asyncState);
	}
	public void Endreset_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_arp_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NAT", 
		RequestNamespace="urn:iControl:LocalLB/NAT", ResponseNamespace="urn:iControl:LocalLB/NAT")]
	public void set_arp_state(
		LocalLBNATNATDefinition [] nat_definitions,
		CommonEnabledState [] states
	) {
		this.Invoke("set_arp_state", new object [] {
				nat_definitions,
				states});

	}
	public System.IAsyncResult Beginset_arp_state(LocalLBNATNATDefinition [] nat_definitions,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_arp_state", new object[] {
			nat_definitions,
			states}, callback, asyncState);
	}
	public void Endset_arp_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NAT", 
		RequestNamespace="urn:iControl:LocalLB/NAT", ResponseNamespace="urn:iControl:LocalLB/NAT")]
	public void set_enabled_state(
		LocalLBNATNATDefinition [] nat_definitions,
		CommonEnabledState [] states
	) {
		this.Invoke("set_enabled_state", new object [] {
				nat_definitions,
				states});

	}
	public System.IAsyncResult Beginset_enabled_state(LocalLBNATNATDefinition [] nat_definitions,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_enabled_state", new object[] {
			nat_definitions,
			states}, callback, asyncState);
	}
	public void Endset_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_unit_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NAT", 
		RequestNamespace="urn:iControl:LocalLB/NAT", ResponseNamespace="urn:iControl:LocalLB/NAT")]
	public void set_unit_id(
		LocalLBNATNATDefinition [] nat_definitions,
		long [] unit_ids
	) {
		this.Invoke("set_unit_id", new object [] {
				nat_definitions,
				unit_ids});

	}
	public System.IAsyncResult Beginset_unit_id(LocalLBNATNATDefinition [] nat_definitions,long [] unit_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_unit_id", new object[] {
			nat_definitions,
			unit_ids}, callback, asyncState);
	}
	public void Endset_unit_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/NAT", 
		RequestNamespace="urn:iControl:LocalLB/NAT", ResponseNamespace="urn:iControl:LocalLB/NAT")]
	public void set_vlan(
		LocalLBNATNATDefinition [] nat_definitions,
		CommonVLANFilterList [] vlans
	) {
		this.Invoke("set_vlan", new object [] {
				nat_definitions,
				vlans});

	}
	public System.IAsyncResult Beginset_vlan(LocalLBNATNATDefinition [] nat_definitions,CommonVLANFilterList [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_vlan", new object[] {
			nat_definitions,
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.NAT.NATDefinition", Namespace = "urn:iControl")]
	public partial class LocalLBNATNATDefinition
	{
		private string translation_addressField;
		public string translation_address
		{
			get { return this.translation_addressField; }
			set { this.translation_addressField = value; }
		}
		private string original_addressField;
		public string original_address
		{
			get { return this.original_addressField; }
			set { this.original_addressField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.NAT.NATStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBNATNATStatisticEntry
	{
		private LocalLBNATNATDefinition natField;
		public LocalLBNATNATDefinition nat
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.NAT.NATStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBNATNATStatistics
	{
		private LocalLBNATNATStatisticEntry [] statisticsField;
		public LocalLBNATNATStatisticEntry [] statistics
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
