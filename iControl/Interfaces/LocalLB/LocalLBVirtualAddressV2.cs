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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.VirtualAddressV2Binding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBVirtualAddressV2VirtualAddressStatistics))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(LocalLBObjectStatus))]
	public partial class LocalLBVirtualAddressV2 : iControlInterface {
		public LocalLBVirtualAddressV2() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddressV2", ResponseNamespace="urn:iControl:LocalLB/VirtualAddressV2")]
	public void add_metadata(
		string [] virtual_addresses,
		string [] [] names,
		string [] [] values
	) {
		this.Invoke("add_metadata", new object [] {
				virtual_addresses,
				names,
				values});

	}
	public System.IAsyncResult Beginadd_metadata(string [] virtual_addresses,string [] [] names,string [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_metadata", new object[] {
			virtual_addresses,
			names,
			values}, callback, asyncState);
	}
	public void Endadd_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddressV2", ResponseNamespace="urn:iControl:LocalLB/VirtualAddressV2")]
	public void create(
		string [] virtual_addresses,
		string [] addresses,
		string [] netmasks
	) {
		this.Invoke("create", new object [] {
				virtual_addresses,
				addresses,
				netmasks});

	}
	public System.IAsyncResult Begincreate(string [] virtual_addresses,string [] addresses,string [] netmasks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			virtual_addresses,
			addresses,
			netmasks}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_virtual_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddressV2", ResponseNamespace="urn:iControl:LocalLB/VirtualAddressV2")]
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
	// get_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddressV2", ResponseNamespace="urn:iControl:LocalLB/VirtualAddressV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_address(
		string [] virtual_addresses
	) {
		object [] results = this.Invoke("get_address", new object [] {
				virtual_addresses});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_address(string [] virtual_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_address", new object[] {
			virtual_addresses}, callback, asyncState);
	}
	public string [] Endget_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_all_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddressV2", ResponseNamespace="urn:iControl:LocalLB/VirtualAddressV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBVirtualAddressV2VirtualAddressStatistics get_all_statistics(

	) {
		object [] results = this.Invoke("get_all_statistics", new object [0]);
		return ((LocalLBVirtualAddressV2VirtualAddressStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_all_statistics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_statistics", new object[0], callback, asyncState);
	}
	public LocalLBVirtualAddressV2VirtualAddressStatistics Endget_all_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBVirtualAddressV2VirtualAddressStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_arp_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddressV2", ResponseNamespace="urn:iControl:LocalLB/VirtualAddressV2")]
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
	// get_auto_delete_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddressV2", ResponseNamespace="urn:iControl:LocalLB/VirtualAddressV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_auto_delete_state(
		string [] virtual_addresses
	) {
		object [] results = this.Invoke("get_auto_delete_state", new object [] {
				virtual_addresses});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_auto_delete_state(string [] virtual_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_auto_delete_state", new object[] {
			virtual_addresses}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_auto_delete_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_connection_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddressV2", ResponseNamespace="urn:iControl:LocalLB/VirtualAddressV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_connection_limit(
		string [] virtual_addresses
	) {
		object [] results = this.Invoke("get_connection_limit", new object [] {
				virtual_addresses});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_connection_limit(string [] virtual_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_connection_limit", new object[] {
			virtual_addresses}, callback, asyncState);
	}
	public long [] Endget_connection_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddressV2", ResponseNamespace="urn:iControl:LocalLB/VirtualAddressV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] virtual_addresses
	) {
		object [] results = this.Invoke("get_description", new object [] {
				virtual_addresses});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] virtual_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			virtual_addresses}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddressV2", ResponseNamespace="urn:iControl:LocalLB/VirtualAddressV2")]
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
	// get_icmp_echo_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddressV2", ResponseNamespace="urn:iControl:LocalLB/VirtualAddressV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_icmp_echo_state(
		string [] virtual_addresses
	) {
		object [] results = this.Invoke("get_icmp_echo_state", new object [] {
				virtual_addresses});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_icmp_echo_state(string [] virtual_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_icmp_echo_state", new object[] {
			virtual_addresses}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_icmp_echo_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_icmp_echo_state_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddressV2", ResponseNamespace="urn:iControl:LocalLB/VirtualAddressV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBVirtualAddressV2IcmpEchoType [] get_icmp_echo_state_v2(
		string [] virtual_addresses
	) {
		object [] results = this.Invoke("get_icmp_echo_state_v2", new object [] {
				virtual_addresses});
		return ((LocalLBVirtualAddressV2IcmpEchoType [])(results[0]));
	}
	public System.IAsyncResult Beginget_icmp_echo_state_v2(string [] virtual_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_icmp_echo_state_v2", new object[] {
			virtual_addresses}, callback, asyncState);
	}
	public LocalLBVirtualAddressV2IcmpEchoType [] Endget_icmp_echo_state_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBVirtualAddressV2IcmpEchoType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_is_floating_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddressV2", ResponseNamespace="urn:iControl:LocalLB/VirtualAddressV2")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddressV2", ResponseNamespace="urn:iControl:LocalLB/VirtualAddressV2")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddressV2", ResponseNamespace="urn:iControl:LocalLB/VirtualAddressV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_metadata(
		string [] virtual_addresses
	) {
		object [] results = this.Invoke("get_metadata", new object [] {
				virtual_addresses});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata(string [] virtual_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_metadata", new object[] {
			virtual_addresses}, callback, asyncState);
	}
	public string [] [] Endget_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_metadata_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddressV2", ResponseNamespace="urn:iControl:LocalLB/VirtualAddressV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_metadata_description(
		string [] virtual_addresses,
		string [] [] names
	) {
		object [] results = this.Invoke("get_metadata_description", new object [] {
				virtual_addresses,
				names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata_description(string [] virtual_addresses,string [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_metadata_description", new object[] {
			virtual_addresses,
			names}, callback, asyncState);
	}
	public string [] [] Endget_metadata_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_metadata_persistence
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddressV2", ResponseNamespace="urn:iControl:LocalLB/VirtualAddressV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonMetadataPersistence [] [] get_metadata_persistence(
		string [] virtual_addresses,
		string [] [] names
	) {
		object [] results = this.Invoke("get_metadata_persistence", new object [] {
				virtual_addresses,
				names});
		return ((CommonMetadataPersistence [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata_persistence(string [] virtual_addresses,string [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_metadata_persistence", new object[] {
			virtual_addresses,
			names}, callback, asyncState);
	}
	public CommonMetadataPersistence [] [] Endget_metadata_persistence(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonMetadataPersistence [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_metadata_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddressV2", ResponseNamespace="urn:iControl:LocalLB/VirtualAddressV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_metadata_value(
		string [] virtual_addresses,
		string [] [] names
	) {
		object [] results = this.Invoke("get_metadata_value", new object [] {
				virtual_addresses,
				names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_metadata_value(string [] virtual_addresses,string [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_metadata_value", new object[] {
			virtual_addresses,
			names}, callback, asyncState);
	}
	public string [] [] Endget_metadata_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_netmask
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddressV2", ResponseNamespace="urn:iControl:LocalLB/VirtualAddressV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_netmask(
		string [] virtual_addresses
	) {
		object [] results = this.Invoke("get_netmask", new object [] {
				virtual_addresses});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_netmask(string [] virtual_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_netmask", new object[] {
			virtual_addresses}, callback, asyncState);
	}
	public string [] Endget_netmask(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_object_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddressV2", ResponseNamespace="urn:iControl:LocalLB/VirtualAddressV2")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddressV2", ResponseNamespace="urn:iControl:LocalLB/VirtualAddressV2")]
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
	// get_spanning_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddressV2", ResponseNamespace="urn:iControl:LocalLB/VirtualAddressV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_spanning_state(
		string [] virtual_addresses
	) {
		object [] results = this.Invoke("get_spanning_state", new object [] {
				virtual_addresses});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_spanning_state(string [] virtual_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_spanning_state", new object[] {
			virtual_addresses}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_spanning_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddressV2", ResponseNamespace="urn:iControl:LocalLB/VirtualAddressV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBVirtualAddressV2VirtualAddressStatistics get_statistics(
		string [] virtual_addresses
	) {
		object [] results = this.Invoke("get_statistics", new object [] {
				virtual_addresses});
		return ((LocalLBVirtualAddressV2VirtualAddressStatistics)(results[0]));
	}
	public System.IAsyncResult Beginget_statistics(string [] virtual_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_statistics", new object[] {
			virtual_addresses}, callback, asyncState);
	}
	public LocalLBVirtualAddressV2VirtualAddressStatistics Endget_statistics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBVirtualAddressV2VirtualAddressStatistics)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_status_dependency_scope
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddressV2", ResponseNamespace="urn:iControl:LocalLB/VirtualAddressV2")]
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
	// get_traffic_group
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddressV2", ResponseNamespace="urn:iControl:LocalLB/VirtualAddressV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_traffic_group(
		string [] virtual_addresses
	) {
		object [] results = this.Invoke("get_traffic_group", new object [] {
				virtual_addresses});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_traffic_group(string [] virtual_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_traffic_group", new object[] {
			virtual_addresses}, callback, asyncState);
	}
	public string [] Endget_traffic_group(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddressV2", ResponseNamespace="urn:iControl:LocalLB/VirtualAddressV2")]
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
	// is_traffic_group_inherited
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddressV2", ResponseNamespace="urn:iControl:LocalLB/VirtualAddressV2")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] is_traffic_group_inherited(
		string [] virtual_addresses
	) {
		object [] results = this.Invoke("is_traffic_group_inherited", new object [] {
				virtual_addresses});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Beginis_traffic_group_inherited(string [] virtual_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("is_traffic_group_inherited", new object[] {
			virtual_addresses}, callback, asyncState);
	}
	public bool [] Endis_traffic_group_inherited(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// remove_all_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddressV2", ResponseNamespace="urn:iControl:LocalLB/VirtualAddressV2")]
	public void remove_all_metadata(
		string [] virtual_addresses
	) {
		this.Invoke("remove_all_metadata", new object [] {
				virtual_addresses});

	}
	public System.IAsyncResult Beginremove_all_metadata(string [] virtual_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_metadata", new object[] {
			virtual_addresses}, callback, asyncState);
	}
	public void Endremove_all_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_metadata
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddressV2", ResponseNamespace="urn:iControl:LocalLB/VirtualAddressV2")]
	public void remove_metadata(
		string [] virtual_addresses,
		string [] [] names
	) {
		this.Invoke("remove_metadata", new object [] {
				virtual_addresses,
				names});

	}
	public System.IAsyncResult Beginremove_metadata(string [] virtual_addresses,string [] [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_metadata", new object[] {
			virtual_addresses,
			names}, callback, asyncState);
	}
	public void Endremove_metadata(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_statistics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddressV2", ResponseNamespace="urn:iControl:LocalLB/VirtualAddressV2")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddressV2", ResponseNamespace="urn:iControl:LocalLB/VirtualAddressV2")]
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
	// set_auto_delete_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddressV2", ResponseNamespace="urn:iControl:LocalLB/VirtualAddressV2")]
	public void set_auto_delete_state(
		string [] virtual_addresses,
		CommonEnabledState [] states
	) {
		this.Invoke("set_auto_delete_state", new object [] {
				virtual_addresses,
				states});

	}
	public System.IAsyncResult Beginset_auto_delete_state(string [] virtual_addresses,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_auto_delete_state", new object[] {
			virtual_addresses,
			states}, callback, asyncState);
	}
	public void Endset_auto_delete_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_connection_limit
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddressV2", ResponseNamespace="urn:iControl:LocalLB/VirtualAddressV2")]
	public void set_connection_limit(
		string [] virtual_addresses,
		long [] limits
	) {
		this.Invoke("set_connection_limit", new object [] {
				virtual_addresses,
				limits});

	}
	public System.IAsyncResult Beginset_connection_limit(string [] virtual_addresses,long [] limits, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_connection_limit", new object[] {
			virtual_addresses,
			limits}, callback, asyncState);
	}
	public void Endset_connection_limit(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddressV2", ResponseNamespace="urn:iControl:LocalLB/VirtualAddressV2")]
	public void set_description(
		string [] virtual_addresses,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				virtual_addresses,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] virtual_addresses,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			virtual_addresses,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddressV2", ResponseNamespace="urn:iControl:LocalLB/VirtualAddressV2")]
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
	// set_icmp_echo_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddressV2", ResponseNamespace="urn:iControl:LocalLB/VirtualAddressV2")]
	public void set_icmp_echo_state(
		string [] virtual_addresses,
		CommonEnabledState [] states
	) {
		this.Invoke("set_icmp_echo_state", new object [] {
				virtual_addresses,
				states});

	}
	public System.IAsyncResult Beginset_icmp_echo_state(string [] virtual_addresses,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_icmp_echo_state", new object[] {
			virtual_addresses,
			states}, callback, asyncState);
	}
	public void Endset_icmp_echo_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_icmp_echo_state_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddressV2", ResponseNamespace="urn:iControl:LocalLB/VirtualAddressV2")]
	public void set_icmp_echo_state_v2(
		string [] virtual_addresses,
		LocalLBVirtualAddressV2IcmpEchoType [] types
	) {
		this.Invoke("set_icmp_echo_state_v2", new object [] {
				virtual_addresses,
				types});

	}
	public System.IAsyncResult Beginset_icmp_echo_state_v2(string [] virtual_addresses,LocalLBVirtualAddressV2IcmpEchoType [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_icmp_echo_state_v2", new object[] {
			virtual_addresses,
			types}, callback, asyncState);
	}
	public void Endset_icmp_echo_state_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_is_floating_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddressV2", ResponseNamespace="urn:iControl:LocalLB/VirtualAddressV2")]
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
	// set_metadata_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddressV2", ResponseNamespace="urn:iControl:LocalLB/VirtualAddressV2")]
	public void set_metadata_description(
		string [] virtual_addresses,
		string [] [] names,
		string [] [] descriptions
	) {
		this.Invoke("set_metadata_description", new object [] {
				virtual_addresses,
				names,
				descriptions});

	}
	public System.IAsyncResult Beginset_metadata_description(string [] virtual_addresses,string [] [] names,string [] [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_metadata_description", new object[] {
			virtual_addresses,
			names,
			descriptions}, callback, asyncState);
	}
	public void Endset_metadata_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_metadata_persistence
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddressV2", ResponseNamespace="urn:iControl:LocalLB/VirtualAddressV2")]
	public void set_metadata_persistence(
		string [] virtual_addresses,
		string [] [] names,
		CommonMetadataPersistence [] [] values
	) {
		this.Invoke("set_metadata_persistence", new object [] {
				virtual_addresses,
				names,
				values});

	}
	public System.IAsyncResult Beginset_metadata_persistence(string [] virtual_addresses,string [] [] names,CommonMetadataPersistence [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_metadata_persistence", new object[] {
			virtual_addresses,
			names,
			values}, callback, asyncState);
	}
	public void Endset_metadata_persistence(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_metadata_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddressV2", ResponseNamespace="urn:iControl:LocalLB/VirtualAddressV2")]
	public void set_metadata_value(
		string [] virtual_addresses,
		string [] [] names,
		string [] [] values
	) {
		this.Invoke("set_metadata_value", new object [] {
				virtual_addresses,
				names,
				values});

	}
	public System.IAsyncResult Beginset_metadata_value(string [] virtual_addresses,string [] [] names,string [] [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_metadata_value", new object[] {
			virtual_addresses,
			names,
			values}, callback, asyncState);
	}
	public void Endset_metadata_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_netmask
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddressV2", ResponseNamespace="urn:iControl:LocalLB/VirtualAddressV2")]
	public void set_netmask(
		string [] virtual_addresses,
		string [] netmask
	) {
		this.Invoke("set_netmask", new object [] {
				virtual_addresses,
				netmask});

	}
	public System.IAsyncResult Beginset_netmask(string [] virtual_addresses,string [] netmask, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_netmask", new object[] {
			virtual_addresses,
			netmask}, callback, asyncState);
	}
	public void Endset_netmask(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_route_advertisement_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddressV2", ResponseNamespace="urn:iControl:LocalLB/VirtualAddressV2")]
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
	// set_spanning_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddressV2", ResponseNamespace="urn:iControl:LocalLB/VirtualAddressV2")]
	public void set_spanning_state(
		string [] virtual_addresses,
		CommonEnabledState [] states
	) {
		this.Invoke("set_spanning_state", new object [] {
				virtual_addresses,
				states});

	}
	public System.IAsyncResult Beginset_spanning_state(string [] virtual_addresses,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_spanning_state", new object[] {
			virtual_addresses,
			states}, callback, asyncState);
	}
	public void Endset_spanning_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_status_dependency_scope
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddressV2", ResponseNamespace="urn:iControl:LocalLB/VirtualAddressV2")]
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
	// set_traffic_group
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/VirtualAddressV2", 
		RequestNamespace="urn:iControl:LocalLB/VirtualAddressV2", ResponseNamespace="urn:iControl:LocalLB/VirtualAddressV2")]
	public void set_traffic_group(
		string [] virtual_addresses,
		string [] traffic_groups
	) {
		this.Invoke("set_traffic_group", new object [] {
				virtual_addresses,
				traffic_groups});

	}
	public System.IAsyncResult Beginset_traffic_group(string [] virtual_addresses,string [] traffic_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_traffic_group", new object[] {
			virtual_addresses,
			traffic_groups}, callback, asyncState);
	}
	public void Endset_traffic_group(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.VirtualAddressV2.IcmpEchoType", Namespace = "urn:iControl")]
	public enum LocalLBVirtualAddressV2IcmpEchoType
	{
		IETYPE_ENABLED,
		IETYPE_DISABLED,
		IETYPE_SELECTIVE,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.VirtualAddressV2.VirtualAddressStatisticEntry", Namespace = "urn:iControl")]
	public partial class LocalLBVirtualAddressV2VirtualAddressStatisticEntry
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.VirtualAddressV2.VirtualAddressStatistics", Namespace = "urn:iControl")]
	public partial class LocalLBVirtualAddressV2VirtualAddressStatistics
	{
		private LocalLBVirtualAddressV2VirtualAddressStatisticEntry [] statisticsField;
		public LocalLBVirtualAddressV2VirtualAddressStatisticEntry [] statistics
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
