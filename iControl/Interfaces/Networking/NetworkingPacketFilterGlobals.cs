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
	[System.Web.Services.WebServiceBindingAttribute(Name="Networking.PacketFilterGlobalsBinding", Namespace="urn:iControl")]
	public partial class NetworkingPacketFilterGlobals : iControlInterface {
		public NetworkingPacketFilterGlobals() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_trusted_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PacketFilterGlobals", 
		RequestNamespace="urn:iControl:Networking/PacketFilterGlobals", ResponseNamespace="urn:iControl:Networking/PacketFilterGlobals")]
	public void add_trusted_address(
		string [] addresses
	) {
		this.Invoke("add_trusted_address", new object [] {
				addresses});

	}
	public System.IAsyncResult Beginadd_trusted_address(string [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_trusted_address", new object[] {
			addresses}, callback, asyncState);
	}
	public void Endadd_trusted_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_trusted_mac_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PacketFilterGlobals", 
		RequestNamespace="urn:iControl:Networking/PacketFilterGlobals", ResponseNamespace="urn:iControl:Networking/PacketFilterGlobals")]
	public void add_trusted_mac_address(
		string [] mac_addresses
	) {
		this.Invoke("add_trusted_mac_address", new object [] {
				mac_addresses});

	}
	public System.IAsyncResult Beginadd_trusted_mac_address(string [] mac_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_trusted_mac_address", new object[] {
			mac_addresses}, callback, asyncState);
	}
	public void Endadd_trusted_mac_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_trusted_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PacketFilterGlobals", 
		RequestNamespace="urn:iControl:Networking/PacketFilterGlobals", ResponseNamespace="urn:iControl:Networking/PacketFilterGlobals")]
	public void add_trusted_vlan(
		string [] vlans
	) {
		this.Invoke("add_trusted_vlan", new object [] {
				vlans});

	}
	public System.IAsyncResult Beginadd_trusted_vlan(string [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_trusted_vlan", new object[] {
			vlans}, callback, asyncState);
	}
	public void Endadd_trusted_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_always_accept_arp_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PacketFilterGlobals", 
		RequestNamespace="urn:iControl:Networking/PacketFilterGlobals", ResponseNamespace="urn:iControl:Networking/PacketFilterGlobals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState get_always_accept_arp_state(

	) {
		object [] results = this.Invoke("get_always_accept_arp_state", new object [0]);
		return ((CommonEnabledState)(results[0]));
	}
	public System.IAsyncResult Beginget_always_accept_arp_state(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_always_accept_arp_state", new object[0], callback, asyncState);
	}
	public CommonEnabledState Endget_always_accept_arp_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_always_accept_important_icmp_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PacketFilterGlobals", 
		RequestNamespace="urn:iControl:Networking/PacketFilterGlobals", ResponseNamespace="urn:iControl:Networking/PacketFilterGlobals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState get_always_accept_important_icmp_state(

	) {
		object [] results = this.Invoke("get_always_accept_important_icmp_state", new object [0]);
		return ((CommonEnabledState)(results[0]));
	}
	public System.IAsyncResult Beginget_always_accept_important_icmp_state(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_always_accept_important_icmp_state", new object[0], callback, asyncState);
	}
	public CommonEnabledState Endget_always_accept_important_icmp_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_default_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PacketFilterGlobals", 
		RequestNamespace="urn:iControl:Networking/PacketFilterGlobals", ResponseNamespace="urn:iControl:Networking/PacketFilterGlobals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingPacketFilterGlobalsDefaultAction get_default_action(

	) {
		object [] results = this.Invoke("get_default_action", new object [0]);
		return ((NetworkingPacketFilterGlobalsDefaultAction)(results[0]));
	}
	public System.IAsyncResult Beginget_default_action(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_default_action", new object[0], callback, asyncState);
	}
	public NetworkingPacketFilterGlobalsDefaultAction Endget_default_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingPacketFilterGlobalsDefaultAction)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_filter_established_connections_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PacketFilterGlobals", 
		RequestNamespace="urn:iControl:Networking/PacketFilterGlobals", ResponseNamespace="urn:iControl:Networking/PacketFilterGlobals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState get_filter_established_connections_state(

	) {
		object [] results = this.Invoke("get_filter_established_connections_state", new object [0]);
		return ((CommonEnabledState)(results[0]));
	}
	public System.IAsyncResult Beginget_filter_established_connections_state(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_filter_established_connections_state", new object[0], callback, asyncState);
	}
	public CommonEnabledState Endget_filter_established_connections_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_packet_filter_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PacketFilterGlobals", 
		RequestNamespace="urn:iControl:Networking/PacketFilterGlobals", ResponseNamespace="urn:iControl:Networking/PacketFilterGlobals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState get_packet_filter_state(

	) {
		object [] results = this.Invoke("get_packet_filter_state", new object [0]);
		return ((CommonEnabledState)(results[0]));
	}
	public System.IAsyncResult Beginget_packet_filter_state(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_packet_filter_state", new object[0], callback, asyncState);
	}
	public CommonEnabledState Endget_packet_filter_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_send_icmp_error_on_packet_reject_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PacketFilterGlobals", 
		RequestNamespace="urn:iControl:Networking/PacketFilterGlobals", ResponseNamespace="urn:iControl:Networking/PacketFilterGlobals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState get_send_icmp_error_on_packet_reject_state(

	) {
		object [] results = this.Invoke("get_send_icmp_error_on_packet_reject_state", new object [0]);
		return ((CommonEnabledState)(results[0]));
	}
	public System.IAsyncResult Beginget_send_icmp_error_on_packet_reject_state(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_send_icmp_error_on_packet_reject_state", new object[0], callback, asyncState);
	}
	public CommonEnabledState Endget_send_icmp_error_on_packet_reject_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_trusted_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PacketFilterGlobals", 
		RequestNamespace="urn:iControl:Networking/PacketFilterGlobals", ResponseNamespace="urn:iControl:Networking/PacketFilterGlobals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_trusted_address(

	) {
		object [] results = this.Invoke("get_trusted_address", new object [0]);
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_trusted_address(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_trusted_address", new object[0], callback, asyncState);
	}
	public string [] Endget_trusted_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_trusted_mac_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PacketFilterGlobals", 
		RequestNamespace="urn:iControl:Networking/PacketFilterGlobals", ResponseNamespace="urn:iControl:Networking/PacketFilterGlobals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_trusted_mac_address(

	) {
		object [] results = this.Invoke("get_trusted_mac_address", new object [0]);
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_trusted_mac_address(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_trusted_mac_address", new object[0], callback, asyncState);
	}
	public string [] Endget_trusted_mac_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_trusted_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PacketFilterGlobals", 
		RequestNamespace="urn:iControl:Networking/PacketFilterGlobals", ResponseNamespace="urn:iControl:Networking/PacketFilterGlobals")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_trusted_vlan(

	) {
		object [] results = this.Invoke("get_trusted_vlan", new object [0]);
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_trusted_vlan(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_trusted_vlan", new object[0], callback, asyncState);
	}
	public string [] Endget_trusted_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PacketFilterGlobals", 
		RequestNamespace="urn:iControl:Networking/PacketFilterGlobals", ResponseNamespace="urn:iControl:Networking/PacketFilterGlobals")]
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
	// remove_trusted_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PacketFilterGlobals", 
		RequestNamespace="urn:iControl:Networking/PacketFilterGlobals", ResponseNamespace="urn:iControl:Networking/PacketFilterGlobals")]
	public void remove_trusted_address(
		string [] addresses
	) {
		this.Invoke("remove_trusted_address", new object [] {
				addresses});

	}
	public System.IAsyncResult Beginremove_trusted_address(string [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_trusted_address", new object[] {
			addresses}, callback, asyncState);
	}
	public void Endremove_trusted_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_trusted_mac_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PacketFilterGlobals", 
		RequestNamespace="urn:iControl:Networking/PacketFilterGlobals", ResponseNamespace="urn:iControl:Networking/PacketFilterGlobals")]
	public void remove_trusted_mac_address(
		string [] mac_addresses
	) {
		this.Invoke("remove_trusted_mac_address", new object [] {
				mac_addresses});

	}
	public System.IAsyncResult Beginremove_trusted_mac_address(string [] mac_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_trusted_mac_address", new object[] {
			mac_addresses}, callback, asyncState);
	}
	public void Endremove_trusted_mac_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_trusted_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PacketFilterGlobals", 
		RequestNamespace="urn:iControl:Networking/PacketFilterGlobals", ResponseNamespace="urn:iControl:Networking/PacketFilterGlobals")]
	public void remove_trusted_vlan(
		string [] vlans
	) {
		this.Invoke("remove_trusted_vlan", new object [] {
				vlans});

	}
	public System.IAsyncResult Beginremove_trusted_vlan(string [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_trusted_vlan", new object[] {
			vlans}, callback, asyncState);
	}
	public void Endremove_trusted_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_always_accept_arp_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PacketFilterGlobals", 
		RequestNamespace="urn:iControl:Networking/PacketFilterGlobals", ResponseNamespace="urn:iControl:Networking/PacketFilterGlobals")]
	public void set_always_accept_arp_state(
		CommonEnabledState state
	) {
		this.Invoke("set_always_accept_arp_state", new object [] {
				state});

	}
	public System.IAsyncResult Beginset_always_accept_arp_state(CommonEnabledState state, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_always_accept_arp_state", new object[] {
			state}, callback, asyncState);
	}
	public void Endset_always_accept_arp_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_always_accept_important_icmp_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PacketFilterGlobals", 
		RequestNamespace="urn:iControl:Networking/PacketFilterGlobals", ResponseNamespace="urn:iControl:Networking/PacketFilterGlobals")]
	public void set_always_accept_important_icmp_state(
		CommonEnabledState state
	) {
		this.Invoke("set_always_accept_important_icmp_state", new object [] {
				state});

	}
	public System.IAsyncResult Beginset_always_accept_important_icmp_state(CommonEnabledState state, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_always_accept_important_icmp_state", new object[] {
			state}, callback, asyncState);
	}
	public void Endset_always_accept_important_icmp_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_default_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PacketFilterGlobals", 
		RequestNamespace="urn:iControl:Networking/PacketFilterGlobals", ResponseNamespace="urn:iControl:Networking/PacketFilterGlobals")]
	public void set_default_action(
		NetworkingPacketFilterGlobalsDefaultAction action
	) {
		this.Invoke("set_default_action", new object [] {
				action});

	}
	public System.IAsyncResult Beginset_default_action(NetworkingPacketFilterGlobalsDefaultAction action, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_default_action", new object[] {
			action}, callback, asyncState);
	}
	public void Endset_default_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_filter_established_connections_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PacketFilterGlobals", 
		RequestNamespace="urn:iControl:Networking/PacketFilterGlobals", ResponseNamespace="urn:iControl:Networking/PacketFilterGlobals")]
	public void set_filter_established_connections_state(
		CommonEnabledState state
	) {
		this.Invoke("set_filter_established_connections_state", new object [] {
				state});

	}
	public System.IAsyncResult Beginset_filter_established_connections_state(CommonEnabledState state, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_filter_established_connections_state", new object[] {
			state}, callback, asyncState);
	}
	public void Endset_filter_established_connections_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_packet_filter_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PacketFilterGlobals", 
		RequestNamespace="urn:iControl:Networking/PacketFilterGlobals", ResponseNamespace="urn:iControl:Networking/PacketFilterGlobals")]
	public void set_packet_filter_state(
		CommonEnabledState state
	) {
		this.Invoke("set_packet_filter_state", new object [] {
				state});

	}
	public System.IAsyncResult Beginset_packet_filter_state(CommonEnabledState state, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_packet_filter_state", new object[] {
			state}, callback, asyncState);
	}
	public void Endset_packet_filter_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_send_icmp_error_on_packet_reject_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/PacketFilterGlobals", 
		RequestNamespace="urn:iControl:Networking/PacketFilterGlobals", ResponseNamespace="urn:iControl:Networking/PacketFilterGlobals")]
	public void set_send_icmp_error_on_packet_reject_state(
		CommonEnabledState state
	) {
		this.Invoke("set_send_icmp_error_on_packet_reject_state", new object [] {
				state});

	}
	public System.IAsyncResult Beginset_send_icmp_error_on_packet_reject_state(CommonEnabledState state, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_send_icmp_error_on_packet_reject_state", new object[] {
			state}, callback, asyncState);
	}
	public void Endset_send_icmp_error_on_packet_reject_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.PacketFilterGlobals.DefaultAction", Namespace = "urn:iControl")]
	public enum NetworkingPacketFilterGlobalsDefaultAction
	{
		PACKET_FILTER_DEFAULT_ACTION_UNKNOWN,
		PACKET_FILTER_DEFAULT_ACTION_ACCEPT,
		PACKET_FILTER_DEFAULT_ACTION_DISCARD,
		PACKET_FILTER_DEFAULT_ACTION_REJECT,
	}

	//=======================================================================
	// Structs
	//=======================================================================

}
