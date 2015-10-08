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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.SNATTranslationAddressBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBSNATTranslationAddressSNATTranslationAddressStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonULong64))]
	public partial class LocalLBSNATTranslationAddress : iControlInterface {
		public LocalLBSNATTranslationAddress() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATTranslationAddress", 
		RequestNamespace="urn:iControl:LocalLB/SNATTranslationAddress", ResponseNamespace="urn:iControl:LocalLB/SNATTranslationAddress")]
	public void create(
		string [] translation_addresses,
		long [] unit_ids
	) {
		this.Invoke("create", new object [] {
				translation_addresses,
				unit_ids});

	}
	public System.IAsyncResult Begincreate(string [] translation_addresses,long [] unit_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			translation_addresses,
			unit_ids}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_translation_addresses
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATTranslationAddress", 
		RequestNamespace="urn:iControl:LocalLB/SNATTranslationAddress", ResponseNamespace="urn:iControl:LocalLB/SNATTranslationAddress")]
	public void delete_all_translation_addresses(

	) {
		this.Invoke("delete_all_translation_addresses", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_translation_addresses(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_translation_addresses", new object[0], callback, asyncState);
	}
	public void Enddelete_all_translation_addresses(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_translation_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATTranslationAddress", 
		RequestNamespace="urn:iControl:LocalLB/SNATTranslationAddress", ResponseNamespace="urn:iControl:LocalLB/SNATTranslationAddress")]
	public void delete_translation_address(
		string [] translation_addresses
	) {
		this.Invoke("delete_translation_address", new object [] {
				translation_addresses});

	}
	public System.IAsyncResult Begindelete_translation_address(string [] translation_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_translation_address", new object[] {
			translation_addresses}, callback, asyncState);
	}
	public void Enddelete_translation_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATTranslationAddress", 
		RequestNamespace="urn:iControl:LocalLB/SNATTranslationAddress", ResponseNamespace="urn:iControl:LocalLB/SNATTranslationAddress")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBSNATTranslationAddressSNATTranslationAddressStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((LocalLBSNATTranslationAddressSNATTranslationAddressStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public LocalLBSNATTranslationAddressSNATTranslationAddressStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBSNATTranslationAddressSNATTranslationAddressStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_arp_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATTranslationAddress", 
		RequestNamespace="urn:iControl:LocalLB/SNATTranslationAddress", ResponseNamespace="urn:iControl:LocalLB/SNATTranslationAddress")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_arp_state(
		string [] translation_addresses
	) {
		object [] results = this.Invoke("get_arp_state", new object [] {
				translation_addresses});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_arp_state(string [] translation_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_arp_state", new object[] {
			translation_addresses}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_arp_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_connection_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATTranslationAddress", 
		RequestNamespace="urn:iControl:LocalLB/SNATTranslationAddress", ResponseNamespace="urn:iControl:LocalLB/SNATTranslationAddress")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonULong64 [] get_connection_limit(
		string [] translation_addresses
	) {
		object [] results = this.Invoke("get_connection_limit", new object [] {
				translation_addresses});
		return ((CommonULong64 [])(results[0]));
	}
	public System.IAsyncResult Beginget_connection_limit(string [] translation_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_connection_limit", new object[] {
			translation_addresses}, callback, asyncState);
	}
	public CommonULong64 [] Endget_connection_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonULong64 [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATTranslationAddress", 
		RequestNamespace="urn:iControl:LocalLB/SNATTranslationAddress", ResponseNamespace="urn:iControl:LocalLB/SNATTranslationAddress")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_enabled_state(
		string [] translation_addresses
	) {
		object [] results = this.Invoke("get_enabled_state", new object [] {
				translation_addresses});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_enabled_state(string [] translation_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_enabled_state", new object[] {
			translation_addresses}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ip_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATTranslationAddress", 
		RequestNamespace="urn:iControl:LocalLB/SNATTranslationAddress", ResponseNamespace="urn:iControl:LocalLB/SNATTranslationAddress")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_ip_timeout(
		string [] translation_addresses
	) {
		object [] results = this.Invoke("get_ip_timeout", new object [] {
				translation_addresses});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_ip_timeout(string [] translation_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ip_timeout", new object[] {
			translation_addresses}, callback, asyncState);
	}
	public long [] Endget_ip_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATTranslationAddress", 
		RequestNamespace="urn:iControl:LocalLB/SNATTranslationAddress", ResponseNamespace="urn:iControl:LocalLB/SNATTranslationAddress")]
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
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATTranslationAddress", 
		RequestNamespace="urn:iControl:LocalLB/SNATTranslationAddress", ResponseNamespace="urn:iControl:LocalLB/SNATTranslationAddress")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBSNATTranslationAddressSNATTranslationAddressStatistics get_statistics(
		string [] translation_addresses
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				translation_addresses});
		return ((LocalLBSNATTranslationAddressSNATTranslationAddressStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] translation_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			translation_addresses}, callback, asyncState);
	}
	public LocalLBSNATTranslationAddressSNATTranslationAddressStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBSNATTranslationAddressSNATTranslationAddressStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_tcp_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATTranslationAddress", 
		RequestNamespace="urn:iControl:LocalLB/SNATTranslationAddress", ResponseNamespace="urn:iControl:LocalLB/SNATTranslationAddress")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_tcp_timeout(
		string [] translation_addresses
	) {
		object [] results = this.Invoke("get_tcp_timeout", new object [] {
				translation_addresses});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_tcp_timeout(string [] translation_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_tcp_timeout", new object[] {
			translation_addresses}, callback, asyncState);
	}
	public long [] Endget_tcp_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_udp_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATTranslationAddress", 
		RequestNamespace="urn:iControl:LocalLB/SNATTranslationAddress", ResponseNamespace="urn:iControl:LocalLB/SNATTranslationAddress")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_udp_timeout(
		string [] translation_addresses
	) {
		object [] results = this.Invoke("get_udp_timeout", new object [] {
				translation_addresses});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_udp_timeout(string [] translation_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_udp_timeout", new object[] {
			translation_addresses}, callback, asyncState);
	}
	public long [] Endget_udp_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_unit_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATTranslationAddress", 
		RequestNamespace="urn:iControl:LocalLB/SNATTranslationAddress", ResponseNamespace="urn:iControl:LocalLB/SNATTranslationAddress")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_unit_id(
		string [] translation_addresses
	) {
		object [] results = this.Invoke("get_unit_id", new object [] {
				translation_addresses});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_unit_id(string [] translation_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_unit_id", new object[] {
			translation_addresses}, callback, asyncState);
	}
	public long [] Endget_unit_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATTranslationAddress", 
		RequestNamespace="urn:iControl:LocalLB/SNATTranslationAddress", ResponseNamespace="urn:iControl:LocalLB/SNATTranslationAddress")]
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
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATTranslationAddress", 
		RequestNamespace="urn:iControl:LocalLB/SNATTranslationAddress", ResponseNamespace="urn:iControl:LocalLB/SNATTranslationAddress")]
	public void reset_statistics(
		string [] translation_addresses
	) {
		this.Invoke("reset_statistics", new object [] {
				translation_addresses});

	}
	public System.IAsyncResult Beginreset_statistics(string [] translation_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics", new object[] {
			translation_addresses}, callback, asyncState);
	}
	public void Endreset_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_arp_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATTranslationAddress", 
		RequestNamespace="urn:iControl:LocalLB/SNATTranslationAddress", ResponseNamespace="urn:iControl:LocalLB/SNATTranslationAddress")]
	public void set_arp_state(
		string [] translation_addresses,
		CommonEnabledState [] states
	) {
		this.Invoke("set_arp_state", new object [] {
				translation_addresses,
				states});

	}
	public System.IAsyncResult Beginset_arp_state(string [] translation_addresses,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_arp_state", new object[] {
			translation_addresses,
			states}, callback, asyncState);
	}
	public void Endset_arp_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_connection_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATTranslationAddress", 
		RequestNamespace="urn:iControl:LocalLB/SNATTranslationAddress", ResponseNamespace="urn:iControl:LocalLB/SNATTranslationAddress")]
	public void set_connection_limit(
		string [] translation_addresses,
		CommonULong64 [] limits
	) {
		this.Invoke("set_connection_limit", new object [] {
				translation_addresses,
				limits});

	}
	public System.IAsyncResult Beginset_connection_limit(string [] translation_addresses,CommonULong64 [] limits, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_connection_limit", new object[] {
			translation_addresses,
			limits}, callback, asyncState);
	}
	public void Endset_connection_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATTranslationAddress", 
		RequestNamespace="urn:iControl:LocalLB/SNATTranslationAddress", ResponseNamespace="urn:iControl:LocalLB/SNATTranslationAddress")]
	public void set_enabled_state(
		string [] translation_addresses,
		CommonEnabledState [] states
	) {
		this.Invoke("set_enabled_state", new object [] {
				translation_addresses,
				states});

	}
	public System.IAsyncResult Beginset_enabled_state(string [] translation_addresses,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_enabled_state", new object[] {
			translation_addresses,
			states}, callback, asyncState);
	}
	public void Endset_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ip_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATTranslationAddress", 
		RequestNamespace="urn:iControl:LocalLB/SNATTranslationAddress", ResponseNamespace="urn:iControl:LocalLB/SNATTranslationAddress")]
	public void set_ip_timeout(
		string [] translation_addresses,
		long [] timeouts
	) {
		this.Invoke("set_ip_timeout", new object [] {
				translation_addresses,
				timeouts});

	}
	public System.IAsyncResult Beginset_ip_timeout(string [] translation_addresses,long [] timeouts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ip_timeout", new object[] {
			translation_addresses,
			timeouts}, callback, asyncState);
	}
	public void Endset_ip_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_tcp_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATTranslationAddress", 
		RequestNamespace="urn:iControl:LocalLB/SNATTranslationAddress", ResponseNamespace="urn:iControl:LocalLB/SNATTranslationAddress")]
	public void set_tcp_timeout(
		string [] translation_addresses,
		long [] timeouts
	) {
		this.Invoke("set_tcp_timeout", new object [] {
				translation_addresses,
				timeouts});

	}
	public System.IAsyncResult Beginset_tcp_timeout(string [] translation_addresses,long [] timeouts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_tcp_timeout", new object[] {
			translation_addresses,
			timeouts}, callback, asyncState);
	}
	public void Endset_tcp_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_udp_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATTranslationAddress", 
		RequestNamespace="urn:iControl:LocalLB/SNATTranslationAddress", ResponseNamespace="urn:iControl:LocalLB/SNATTranslationAddress")]
	public void set_udp_timeout(
		string [] translation_addresses,
		long [] timeouts
	) {
		this.Invoke("set_udp_timeout", new object [] {
				translation_addresses,
				timeouts});

	}
	public System.IAsyncResult Beginset_udp_timeout(string [] translation_addresses,long [] timeouts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_udp_timeout", new object[] {
			translation_addresses,
			timeouts}, callback, asyncState);
	}
	public void Endset_udp_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_unit_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/SNATTranslationAddress", 
		RequestNamespace="urn:iControl:LocalLB/SNATTranslationAddress", ResponseNamespace="urn:iControl:LocalLB/SNATTranslationAddress")]
	public void set_unit_id(
		string [] translation_addresses,
		long [] unit_ids
	) {
		this.Invoke("set_unit_id", new object [] {
				translation_addresses,
				unit_ids});

	}
	public System.IAsyncResult Beginset_unit_id(string [] translation_addresses,long [] unit_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_unit_id", new object[] {
			translation_addresses,
			unit_ids}, callback, asyncState);
	}
	public void Endset_unit_id(System.IAsyncResult asyncResult) {
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.SNATTranslationAddress.SNATTranslationAddressStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBSNATTranslationAddressSNATTranslationAddressStatisticEntry
	{
		private string translation_addressField;
		public string translation_address
		{
			get { return this.translation_addressField; }
			set { this.translation_addressField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.SNATTranslationAddress.SNATTranslationAddressStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBSNATTranslationAddressSNATTranslationAddressStatistics
	{
		private LocalLBSNATTranslationAddressSNATTranslationAddressStatisticEntry [] statisticsField;
		public LocalLBSNATTranslationAddressSNATTranslationAddressStatisticEntry [] statistics
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
