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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.VirtualAddressBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBVirtualAddressVirtualAddressStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonULong64))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBObjectStatus))]
	public partial class LocalLBVirtualAddress : iControlInterface {
		public LocalLBVirtualAddress() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// delete_virtual_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddress", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddress", ResponseNamespace="urn:iControl:LocalLB/VirtualAddress")]
	public void delete_virtual_address(
		string [] virtual_addresses
	) {
		this.Invoke("delete_virtual_address", new object [] {
				virtual_addresses});

	}
	public System.IAsyncResult Begindelete_virtual_address(string [] virtual_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_virtual_address", new object[] {
			virtual_addresses}, callback, asyncState);
	}
	public void Enddelete_virtual_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddress", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddress", ResponseNamespace="urn:iControl:LocalLB/VirtualAddress")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBVirtualAddressVirtualAddressStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((LocalLBVirtualAddressVirtualAddressStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public LocalLBVirtualAddressVirtualAddressStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBVirtualAddressVirtualAddressStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_arp_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddress", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddress", ResponseNamespace="urn:iControl:LocalLB/VirtualAddress")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_arp_state(
		string [] virtual_addresses
	) {
		object [] results = this.Invoke("get_arp_state", new object [] {
				virtual_addresses});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_arp_state(string [] virtual_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_arp_state", new object[] {
			virtual_addresses}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_arp_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_connection_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddress", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddress", ResponseNamespace="urn:iControl:LocalLB/VirtualAddress")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonULong64 [] get_connection_limit(
		string [] virtual_addresses
	) {
		object [] results = this.Invoke("get_connection_limit", new object [] {
				virtual_addresses});
		return ((CommonULong64 [])(results[0]));
	}
	public System.IAsyncResult Beginget_connection_limit(string [] virtual_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_connection_limit", new object[] {
			virtual_addresses}, callback, asyncState);
	}
	public CommonULong64 [] Endget_connection_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonULong64 [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddress", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddress", ResponseNamespace="urn:iControl:LocalLB/VirtualAddress")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_enabled_state(
		string [] virtual_addresses
	) {
		object [] results = this.Invoke("get_enabled_state", new object [] {
				virtual_addresses});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_enabled_state(string [] virtual_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_enabled_state", new object[] {
			virtual_addresses}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_is_floating_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddress", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddress", ResponseNamespace="urn:iControl:LocalLB/VirtualAddress")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_is_floating_state(
		string [] virtual_addresses
	) {
		object [] results = this.Invoke("get_is_floating_state", new object [] {
				virtual_addresses});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_is_floating_state(string [] virtual_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_is_floating_state", new object[] {
			virtual_addresses}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_is_floating_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddress", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddress", ResponseNamespace="urn:iControl:LocalLB/VirtualAddress")]
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
	// get_object_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddress", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddress", ResponseNamespace="urn:iControl:LocalLB/VirtualAddress")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBObjectStatus [] get_object_status(
		string [] virtual_addresses
	) {
		object [] results = this.Invoke("get_object_status", new object [] {
				virtual_addresses});
		return ((LocalLBObjectStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_object_status(string [] virtual_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_object_status", new object[] {
			virtual_addresses}, callback, asyncState);
	}
	public LocalLBObjectStatus [] Endget_object_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBObjectStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_route_advertisement_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddress", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddress", ResponseNamespace="urn:iControl:LocalLB/VirtualAddress")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_route_advertisement_state(
		string [] virtual_addresses
	) {
		object [] results = this.Invoke("get_route_advertisement_state", new object [] {
				virtual_addresses});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_route_advertisement_state(string [] virtual_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_route_advertisement_state", new object[] {
			virtual_addresses}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_route_advertisement_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddress", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddress", ResponseNamespace="urn:iControl:LocalLB/VirtualAddress")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBVirtualAddressVirtualAddressStatistics get_statistics(
		string [] virtual_addresses
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				virtual_addresses});
		return ((LocalLBVirtualAddressVirtualAddressStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] virtual_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			virtual_addresses}, callback, asyncState);
	}
	public LocalLBVirtualAddressVirtualAddressStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBVirtualAddressVirtualAddressStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_status_dependency_scope
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddress", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddress", ResponseNamespace="urn:iControl:LocalLB/VirtualAddress")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBVirtualAddressStatusDependency [] get_status_dependency_scope(
		string [] virtual_addresses
	) {
		object [] results = this.Invoke("get_status_dependency_scope", new object [] {
				virtual_addresses});
		return ((LocalLBVirtualAddressStatusDependency [])(results[0]));
	}
	public System.IAsyncResult Beginget_status_dependency_scope(string [] virtual_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_status_dependency_scope", new object[] {
			virtual_addresses}, callback, asyncState);
	}
	public LocalLBVirtualAddressStatusDependency [] Endget_status_dependency_scope(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBVirtualAddressStatusDependency [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_unit_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddress", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddress", ResponseNamespace="urn:iControl:LocalLB/VirtualAddress")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_unit_id(
		string [] virtual_addresses
	) {
		object [] results = this.Invoke("get_unit_id", new object [] {
				virtual_addresses});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_unit_id(string [] virtual_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_unit_id", new object[] {
			virtual_addresses}, callback, asyncState);
	}
	public long [] Endget_unit_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddress", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddress", ResponseNamespace="urn:iControl:LocalLB/VirtualAddress")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddress", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddress", ResponseNamespace="urn:iControl:LocalLB/VirtualAddress")]
	public void reset_statistics(
		string [] virtual_addresses
	) {
		this.Invoke("reset_statistics", new object [] {
				virtual_addresses});

	}
	public System.IAsyncResult Beginreset_statistics(string [] virtual_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_statistics", new object[] {
			virtual_addresses}, callback, asyncState);
	}
	public void Endreset_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_arp_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddress", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddress", ResponseNamespace="urn:iControl:LocalLB/VirtualAddress")]
	public void set_arp_state(
		string [] virtual_addresses,
		CommonEnabledState [] states
	) {
		this.Invoke("set_arp_state", new object [] {
				virtual_addresses,
				states});

	}
	public System.IAsyncResult Beginset_arp_state(string [] virtual_addresses,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_arp_state", new object[] {
			virtual_addresses,
			states}, callback, asyncState);
	}
	public void Endset_arp_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_connection_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddress", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddress", ResponseNamespace="urn:iControl:LocalLB/VirtualAddress")]
	public void set_connection_limit(
		string [] virtual_addresses,
		CommonULong64 [] limits
	) {
		this.Invoke("set_connection_limit", new object [] {
				virtual_addresses,
				limits});

	}
	public System.IAsyncResult Beginset_connection_limit(string [] virtual_addresses,CommonULong64 [] limits, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_connection_limit", new object[] {
			virtual_addresses,
			limits}, callback, asyncState);
	}
	public void Endset_connection_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddress", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddress", ResponseNamespace="urn:iControl:LocalLB/VirtualAddress")]
	public void set_enabled_state(
		string [] virtual_addresses,
		CommonEnabledState [] states
	) {
		this.Invoke("set_enabled_state", new object [] {
				virtual_addresses,
				states});

	}
	public System.IAsyncResult Beginset_enabled_state(string [] virtual_addresses,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_enabled_state", new object[] {
			virtual_addresses,
			states}, callback, asyncState);
	}
	public void Endset_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_is_floating_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddress", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddress", ResponseNamespace="urn:iControl:LocalLB/VirtualAddress")]
	public void set_is_floating_state(
		string [] virtual_addresses,
		CommonEnabledState [] states
	) {
		this.Invoke("set_is_floating_state", new object [] {
				virtual_addresses,
				states});

	}
	public System.IAsyncResult Beginset_is_floating_state(string [] virtual_addresses,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_is_floating_state", new object[] {
			virtual_addresses,
			states}, callback, asyncState);
	}
	public void Endset_is_floating_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_route_advertisement_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddress", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddress", ResponseNamespace="urn:iControl:LocalLB/VirtualAddress")]
	public void set_route_advertisement_state(
		string [] virtual_addresses,
		CommonEnabledState [] states
	) {
		this.Invoke("set_route_advertisement_state", new object [] {
				virtual_addresses,
				states});

	}
	public System.IAsyncResult Beginset_route_advertisement_state(string [] virtual_addresses,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_route_advertisement_state", new object[] {
			virtual_addresses,
			states}, callback, asyncState);
	}
	public void Endset_route_advertisement_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_status_dependency_scope
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddress", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddress", ResponseNamespace="urn:iControl:LocalLB/VirtualAddress")]
	public void set_status_dependency_scope(
		string [] virtual_addresses,
		LocalLBVirtualAddressStatusDependency [] scopes
	) {
		this.Invoke("set_status_dependency_scope", new object [] {
				virtual_addresses,
				scopes});

	}
	public System.IAsyncResult Beginset_status_dependency_scope(string [] virtual_addresses,LocalLBVirtualAddressStatusDependency [] scopes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_status_dependency_scope", new object[] {
			virtual_addresses,
			scopes}, callback, asyncState);
	}
	public void Endset_status_dependency_scope(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_unit_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddress", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddress", ResponseNamespace="urn:iControl:LocalLB/VirtualAddress")]
	public void set_unit_id(
		string [] virtual_addresses,
		long [] unit_ids
	) {
		this.Invoke("set_unit_id", new object [] {
				virtual_addresses,
				unit_ids});

	}
	public System.IAsyncResult Beginset_unit_id(string [] virtual_addresses,long [] unit_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_unit_id", new object[] {
			virtual_addresses,
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.VirtualAddress.VirtualAddressStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBVirtualAddressVirtualAddressStatisticEntry
	{
		private string virtual_addressField;
		public string virtual_address
		{
			get { return this.virtual_addressField; }
			set { this.virtual_addressField = value; }
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.VirtualAddress.VirtualAddressStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBVirtualAddressVirtualAddressStatistics
	{
		private LocalLBVirtualAddressVirtualAddressStatisticEntry [] statisticsField;
		public LocalLBVirtualAddressVirtualAddressStatisticEntry [] statistics
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
