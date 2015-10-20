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
	[System.Web.Services.WebServiceBindingAttribute(Name="Networking.TunnelBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(NetworkingTunnelL2TunnelFDBEntry))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(NetworkingTunnelL2TunnelFDBEntryV2))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(NetworkingTunnelTunnelProfileAttribute))]
	public partial class NetworkingTunnel : iControlInterface {
		public NetworkingTunnel() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_static_forwarding
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Tunnel", 
		RequestNamespace="urn:iControl:Networking/Tunnel", ResponseNamespace="urn:iControl:Networking/Tunnel")]
	public void add_static_forwarding(
		string [] tunnels,
		NetworkingTunnelL2TunnelFDBEntry [] [] entries
	) {
		this.Invoke("add_static_forwarding", new object [] {
				tunnels,
				entries});

	}
	public System.IAsyncResult Beginadd_static_forwarding(string [] tunnels,NetworkingTunnelL2TunnelFDBEntry [] [] entries, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_static_forwarding", new object[] {
			tunnels,
			entries}, callback, asyncState);
	}
	public void Endadd_static_forwarding(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_static_forwarding_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Tunnel", 
		RequestNamespace="urn:iControl:Networking/Tunnel", ResponseNamespace="urn:iControl:Networking/Tunnel")]
	public void add_static_forwarding_v2(
		string [] tunnels,
		NetworkingTunnelL2TunnelFDBEntryV2 [] [] entries
	) {
		this.Invoke("add_static_forwarding_v2", new object [] {
				tunnels,
				entries});

	}
	public System.IAsyncResult Beginadd_static_forwarding_v2(string [] tunnels,NetworkingTunnelL2TunnelFDBEntryV2 [] [] entries, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_static_forwarding_v2", new object[] {
			tunnels,
			entries}, callback, asyncState);
	}
	public void Endadd_static_forwarding_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Tunnel", 
		RequestNamespace="urn:iControl:Networking/Tunnel", ResponseNamespace="urn:iControl:Networking/Tunnel")]
	public void create(
		string [] tunnels,
		string [] local_addresses,
		string [] remote_addresses,
		string [] profiles
	) {
		this.Invoke("create", new object [] {
				tunnels,
				local_addresses,
				remote_addresses,
				profiles});

	}
	public System.IAsyncResult Begincreate(string [] tunnels,string [] local_addresses,string [] remote_addresses,string [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			tunnels,
			local_addresses,
			remote_addresses,
			profiles}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create_with_key
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Tunnel", 
		RequestNamespace="urn:iControl:Networking/Tunnel", ResponseNamespace="urn:iControl:Networking/Tunnel")]
	public void create_with_key(
		string [] tunnels,
		string [] local_addresses,
		string [] remote_addresses,
		string [] profiles,
		long [] keys
	) {
		this.Invoke("create_with_key", new object [] {
				tunnels,
				local_addresses,
				remote_addresses,
				profiles,
				keys});

	}
	public System.IAsyncResult Begincreate_with_key(string [] tunnels,string [] local_addresses,string [] remote_addresses,string [] profiles,long [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_with_key", new object[] {
			tunnels,
			local_addresses,
			remote_addresses,
			profiles,
			keys}, callback, asyncState);
	}
	public void Endcreate_with_key(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create_with_transparent_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Tunnel", 
		RequestNamespace="urn:iControl:Networking/Tunnel", ResponseNamespace="urn:iControl:Networking/Tunnel")]
	public void create_with_transparent_state(
		string [] tunnels,
		string [] local_addresses,
		string [] remote_addresses,
		string [] profiles,
		CommonEnabledState [] states
	) {
		this.Invoke("create_with_transparent_state", new object [] {
				tunnels,
				local_addresses,
				remote_addresses,
				profiles,
				states});

	}
	public System.IAsyncResult Begincreate_with_transparent_state(string [] tunnels,string [] local_addresses,string [] remote_addresses,string [] profiles,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_with_transparent_state", new object[] {
			tunnels,
			local_addresses,
			remote_addresses,
			profiles,
			states}, callback, asyncState);
	}
	public void Endcreate_with_transparent_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_tunnels
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Tunnel", 
		RequestNamespace="urn:iControl:Networking/Tunnel", ResponseNamespace="urn:iControl:Networking/Tunnel")]
	public void delete_all_tunnels(

	) {
		this.Invoke("delete_all_tunnels", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_tunnels(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_tunnels", new object[0], callback, asyncState);
	}
	public void Enddelete_all_tunnels(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_tunnel
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Tunnel", 
		RequestNamespace="urn:iControl:Networking/Tunnel", ResponseNamespace="urn:iControl:Networking/Tunnel")]
	public void delete_tunnel(
		string [] tunnels
	) {
		this.Invoke("delete_tunnel", new object [] {
				tunnels});

	}
	public System.IAsyncResult Begindelete_tunnel(string [] tunnels, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_tunnel", new object[] {
			tunnels}, callback, asyncState);
	}
	public void Enddelete_tunnel(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_auto_lasthop
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Tunnel", 
		RequestNamespace="urn:iControl:Networking/Tunnel", ResponseNamespace="urn:iControl:Networking/Tunnel")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonAutoLasthop [] get_auto_lasthop(
		string [] tunnels
	) {
		object [] results = this.Invoke("get_auto_lasthop", new object [] {
				tunnels});
		return ((CommonAutoLasthop [])(results[0]));
	}
	public System.IAsyncResult Beginget_auto_lasthop(string [] tunnels, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_auto_lasthop", new object[] {
			tunnels}, callback, asyncState);
	}
	public CommonAutoLasthop [] Endget_auto_lasthop(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonAutoLasthop [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Tunnel", 
		RequestNamespace="urn:iControl:Networking/Tunnel", ResponseNamespace="urn:iControl:Networking/Tunnel")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] tunnels
	) {
		object [] results = this.Invoke("get_description", new object [] {
				tunnels});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] tunnels, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			tunnels}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_direction
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Tunnel", 
		RequestNamespace="urn:iControl:Networking/Tunnel", ResponseNamespace="urn:iControl:Networking/Tunnel")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingTunnelTunnelDirection [] get_direction(
		string [] tunnels
	) {
		object [] results = this.Invoke("get_direction", new object [] {
				tunnels});
		return ((NetworkingTunnelTunnelDirection [])(results[0]));
	}
	public System.IAsyncResult Beginget_direction(string [] tunnels, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_direction", new object[] {
			tunnels}, callback, asyncState);
	}
	public NetworkingTunnelTunnelDirection [] Endget_direction(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingTunnelTunnelDirection [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_idle_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Tunnel", 
		RequestNamespace="urn:iControl:Networking/Tunnel", ResponseNamespace="urn:iControl:Networking/Tunnel")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_idle_timeout(
		string [] tunnels
	) {
		object [] results = this.Invoke("get_idle_timeout", new object [] {
				tunnels});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_idle_timeout(string [] tunnels, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_idle_timeout", new object[] {
			tunnels}, callback, asyncState);
	}
	public long [] Endget_idle_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_if_index
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Tunnel", 
		RequestNamespace="urn:iControl:Networking/Tunnel", ResponseNamespace="urn:iControl:Networking/Tunnel")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_if_index(
		string [] tunnels
	) {
		object [] results = this.Invoke("get_if_index", new object [] {
				tunnels});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_if_index(string [] tunnels, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_if_index", new object[] {
			tunnels}, callback, asyncState);
	}
	public long [] Endget_if_index(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_key
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Tunnel", 
		RequestNamespace="urn:iControl:Networking/Tunnel", ResponseNamespace="urn:iControl:Networking/Tunnel")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_key(
		string [] tunnels
	) {
		object [] results = this.Invoke("get_key", new object [] {
				tunnels});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_key(string [] tunnels, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_key", new object[] {
			tunnels}, callback, asyncState);
	}
	public long [] Endget_key(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Tunnel", 
		RequestNamespace="urn:iControl:Networking/Tunnel", ResponseNamespace="urn:iControl:Networking/Tunnel")]
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
	// get_local_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Tunnel", 
		RequestNamespace="urn:iControl:Networking/Tunnel", ResponseNamespace="urn:iControl:Networking/Tunnel")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_local_address(
		string [] tunnels
	) {
		object [] results = this.Invoke("get_local_address", new object [] {
				tunnels});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_local_address(string [] tunnels, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_local_address", new object[] {
			tunnels}, callback, asyncState);
	}
	public string [] Endget_local_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_mac_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Tunnel", 
		RequestNamespace="urn:iControl:Networking/Tunnel", ResponseNamespace="urn:iControl:Networking/Tunnel")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_mac_address(
		string [] tunnels
	) {
		object [] results = this.Invoke("get_mac_address", new object [] {
				tunnels});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_mac_address(string [] tunnels, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_mac_address", new object[] {
			tunnels}, callback, asyncState);
	}
	public string [] Endget_mac_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_mtu
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Tunnel", 
		RequestNamespace="urn:iControl:Networking/Tunnel", ResponseNamespace="urn:iControl:Networking/Tunnel")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_mtu(
		string [] tunnels
	) {
		object [] results = this.Invoke("get_mtu", new object [] {
				tunnels});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_mtu(string [] tunnels, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_mtu", new object[] {
			tunnels}, callback, asyncState);
	}
	public long [] Endget_mtu(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Tunnel", 
		RequestNamespace="urn:iControl:Networking/Tunnel", ResponseNamespace="urn:iControl:Networking/Tunnel")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_profile(
		string [] tunnels
	) {
		object [] results = this.Invoke("get_profile", new object [] {
				tunnels});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_profile(string [] tunnels, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_profile", new object[] {
			tunnels}, callback, asyncState);
	}
	public string [] Endget_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_profile_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Tunnel", 
		RequestNamespace="urn:iControl:Networking/Tunnel", ResponseNamespace="urn:iControl:Networking/Tunnel")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingTunnelTunnelProfileAttribute [] get_profile_v2(
		string [] tunnels
	) {
		object [] results = this.Invoke("get_profile_v2", new object [] {
				tunnels});
		return ((NetworkingTunnelTunnelProfileAttribute [])(results[0]));
	}
	public System.IAsyncResult Beginget_profile_v2(string [] tunnels, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_profile_v2", new object[] {
			tunnels}, callback, asyncState);
	}
	public NetworkingTunnelTunnelProfileAttribute [] Endget_profile_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingTunnelTunnelProfileAttribute [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_remote_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Tunnel", 
		RequestNamespace="urn:iControl:Networking/Tunnel", ResponseNamespace="urn:iControl:Networking/Tunnel")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_remote_address(
		string [] tunnels
	) {
		object [] results = this.Invoke("get_remote_address", new object [] {
				tunnels});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_remote_address(string [] tunnels, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_remote_address", new object[] {
			tunnels}, callback, asyncState);
	}
	public string [] Endget_remote_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_secondary_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Tunnel", 
		RequestNamespace="urn:iControl:Networking/Tunnel", ResponseNamespace="urn:iControl:Networking/Tunnel")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_secondary_address(
		string [] tunnels
	) {
		object [] results = this.Invoke("get_secondary_address", new object [] {
				tunnels});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_secondary_address(string [] tunnels, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_secondary_address", new object[] {
			tunnels}, callback, asyncState);
	}
	public string [] Endget_secondary_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_static_forwarding
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Tunnel", 
		RequestNamespace="urn:iControl:Networking/Tunnel", ResponseNamespace="urn:iControl:Networking/Tunnel")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingTunnelL2TunnelFDBEntry [] [] get_static_forwarding(
		string [] tunnels
	) {
		object [] results = this.Invoke("get_static_forwarding", new object [] {
				tunnels});
		return ((NetworkingTunnelL2TunnelFDBEntry [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_static_forwarding(string [] tunnels, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_static_forwarding", new object[] {
			tunnels}, callback, asyncState);
	}
	public NetworkingTunnelL2TunnelFDBEntry [] [] Endget_static_forwarding(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingTunnelL2TunnelFDBEntry [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_static_forwarding_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Tunnel", 
		RequestNamespace="urn:iControl:Networking/Tunnel", ResponseNamespace="urn:iControl:Networking/Tunnel")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingTunnelL2TunnelFDBEntryV2 [] [] get_static_forwarding_v2(
		string [] tunnels
	) {
		object [] results = this.Invoke("get_static_forwarding_v2", new object [] {
				tunnels});
		return ((NetworkingTunnelL2TunnelFDBEntryV2 [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_static_forwarding_v2(string [] tunnels, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_static_forwarding_v2", new object[] {
			tunnels}, callback, asyncState);
	}
	public NetworkingTunnelL2TunnelFDBEntryV2 [] [] Endget_static_forwarding_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingTunnelL2TunnelFDBEntryV2 [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_tos
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Tunnel", 
		RequestNamespace="urn:iControl:Networking/Tunnel", ResponseNamespace="urn:iControl:Networking/Tunnel")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_tos(
		string [] tunnels
	) {
		object [] results = this.Invoke("get_tos", new object [] {
				tunnels});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_tos(string [] tunnels, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_tos", new object[] {
			tunnels}, callback, asyncState);
	}
	public long [] Endget_tos(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_traffic_group
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Tunnel", 
		RequestNamespace="urn:iControl:Networking/Tunnel", ResponseNamespace="urn:iControl:Networking/Tunnel")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_traffic_group(
		string [] tunnels
	) {
		object [] results = this.Invoke("get_traffic_group", new object [] {
				tunnels});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_traffic_group(string [] tunnels, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_traffic_group", new object[] {
			tunnels}, callback, asyncState);
	}
	public string [] Endget_traffic_group(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_transparent_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Tunnel", 
		RequestNamespace="urn:iControl:Networking/Tunnel", ResponseNamespace="urn:iControl:Networking/Tunnel")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_transparent_state(
		string [] tunnels
	) {
		object [] results = this.Invoke("get_transparent_state", new object [] {
				tunnels});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_transparent_state(string [] tunnels, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_transparent_state", new object[] {
			tunnels}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_transparent_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Tunnel", 
		RequestNamespace="urn:iControl:Networking/Tunnel", ResponseNamespace="urn:iControl:Networking/Tunnel")]
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
	// remove_all_static_forwardings
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Tunnel", 
		RequestNamespace="urn:iControl:Networking/Tunnel", ResponseNamespace="urn:iControl:Networking/Tunnel")]
	public void remove_all_static_forwardings(
		string [] tunnels
	) {
		this.Invoke("remove_all_static_forwardings", new object [] {
				tunnels});

	}
	public System.IAsyncResult Beginremove_all_static_forwardings(string [] tunnels, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_all_static_forwardings", new object[] {
			tunnels}, callback, asyncState);
	}
	public void Endremove_all_static_forwardings(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_static_forwarding
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Tunnel", 
		RequestNamespace="urn:iControl:Networking/Tunnel", ResponseNamespace="urn:iControl:Networking/Tunnel")]
	public void remove_static_forwarding(
		string [] tunnels,
		NetworkingTunnelL2TunnelFDBEntry [] [] entries
	) {
		this.Invoke("remove_static_forwarding", new object [] {
				tunnels,
				entries});

	}
	public System.IAsyncResult Beginremove_static_forwarding(string [] tunnels,NetworkingTunnelL2TunnelFDBEntry [] [] entries, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_static_forwarding", new object[] {
			tunnels,
			entries}, callback, asyncState);
	}
	public void Endremove_static_forwarding(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_static_forwarding_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Tunnel", 
		RequestNamespace="urn:iControl:Networking/Tunnel", ResponseNamespace="urn:iControl:Networking/Tunnel")]
	public void remove_static_forwarding_v2(
		string [] tunnels,
		NetworkingTunnelL2TunnelFDBEntryV2 [] [] entries
	) {
		this.Invoke("remove_static_forwarding_v2", new object [] {
				tunnels,
				entries});

	}
	public System.IAsyncResult Beginremove_static_forwarding_v2(string [] tunnels,NetworkingTunnelL2TunnelFDBEntryV2 [] [] entries, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_static_forwarding_v2", new object[] {
			tunnels,
			entries}, callback, asyncState);
	}
	public void Endremove_static_forwarding_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_auto_lasthop
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Tunnel", 
		RequestNamespace="urn:iControl:Networking/Tunnel", ResponseNamespace="urn:iControl:Networking/Tunnel")]
	public void set_auto_lasthop(
		string [] tunnels,
		CommonAutoLasthop [] values
	) {
		this.Invoke("set_auto_lasthop", new object [] {
				tunnels,
				values});

	}
	public System.IAsyncResult Beginset_auto_lasthop(string [] tunnels,CommonAutoLasthop [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_auto_lasthop", new object[] {
			tunnels,
			values}, callback, asyncState);
	}
	public void Endset_auto_lasthop(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Tunnel", 
		RequestNamespace="urn:iControl:Networking/Tunnel", ResponseNamespace="urn:iControl:Networking/Tunnel")]
	public void set_description(
		string [] tunnels,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				tunnels,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] tunnels,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			tunnels,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_direction
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Tunnel", 
		RequestNamespace="urn:iControl:Networking/Tunnel", ResponseNamespace="urn:iControl:Networking/Tunnel")]
	public void set_direction(
		string [] tunnels,
		NetworkingTunnelTunnelDirection [] directions
	) {
		this.Invoke("set_direction", new object [] {
				tunnels,
				directions});

	}
	public System.IAsyncResult Beginset_direction(string [] tunnels,NetworkingTunnelTunnelDirection [] directions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_direction", new object[] {
			tunnels,
			directions}, callback, asyncState);
	}
	public void Endset_direction(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_idle_timeout
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Tunnel", 
		RequestNamespace="urn:iControl:Networking/Tunnel", ResponseNamespace="urn:iControl:Networking/Tunnel")]
	public void set_idle_timeout(
		string [] tunnels,
		long [] timeouts
	) {
		this.Invoke("set_idle_timeout", new object [] {
				tunnels,
				timeouts});

	}
	public System.IAsyncResult Beginset_idle_timeout(string [] tunnels,long [] timeouts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_idle_timeout", new object[] {
			tunnels,
			timeouts}, callback, asyncState);
	}
	public void Endset_idle_timeout(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_key
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Tunnel", 
		RequestNamespace="urn:iControl:Networking/Tunnel", ResponseNamespace="urn:iControl:Networking/Tunnel")]
	public void set_key(
		string [] tunnels,
		long [] keys
	) {
		this.Invoke("set_key", new object [] {
				tunnels,
				keys});

	}
	public System.IAsyncResult Beginset_key(string [] tunnels,long [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_key", new object[] {
			tunnels,
			keys}, callback, asyncState);
	}
	public void Endset_key(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_local_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Tunnel", 
		RequestNamespace="urn:iControl:Networking/Tunnel", ResponseNamespace="urn:iControl:Networking/Tunnel")]
	public void set_local_address(
		string [] tunnels,
		string [] addresses
	) {
		this.Invoke("set_local_address", new object [] {
				tunnels,
				addresses});

	}
	public System.IAsyncResult Beginset_local_address(string [] tunnels,string [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_local_address", new object[] {
			tunnels,
			addresses}, callback, asyncState);
	}
	public void Endset_local_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_local_address_with_transparent_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Tunnel", 
		RequestNamespace="urn:iControl:Networking/Tunnel", ResponseNamespace="urn:iControl:Networking/Tunnel")]
	public void set_local_address_with_transparent_state(
		string [] tunnels,
		string [] addresses,
		CommonEnabledState [] states
	) {
		this.Invoke("set_local_address_with_transparent_state", new object [] {
				tunnels,
				addresses,
				states});

	}
	public System.IAsyncResult Beginset_local_address_with_transparent_state(string [] tunnels,string [] addresses,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_local_address_with_transparent_state", new object[] {
			tunnels,
			addresses,
			states}, callback, asyncState);
	}
	public void Endset_local_address_with_transparent_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_mtu
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Tunnel", 
		RequestNamespace="urn:iControl:Networking/Tunnel", ResponseNamespace="urn:iControl:Networking/Tunnel")]
	public void set_mtu(
		string [] tunnels,
		long [] mtus
	) {
		this.Invoke("set_mtu", new object [] {
				tunnels,
				mtus});

	}
	public System.IAsyncResult Beginset_mtu(string [] tunnels,long [] mtus, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_mtu", new object[] {
			tunnels,
			mtus}, callback, asyncState);
	}
	public void Endset_mtu(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_profile
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Tunnel", 
		RequestNamespace="urn:iControl:Networking/Tunnel", ResponseNamespace="urn:iControl:Networking/Tunnel")]
	public void set_profile(
		string [] tunnels,
		string [] profiles
	) {
		this.Invoke("set_profile", new object [] {
				tunnels,
				profiles});

	}
	public System.IAsyncResult Beginset_profile(string [] tunnels,string [] profiles, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_profile", new object[] {
			tunnels,
			profiles}, callback, asyncState);
	}
	public void Endset_profile(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_remote_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Tunnel", 
		RequestNamespace="urn:iControl:Networking/Tunnel", ResponseNamespace="urn:iControl:Networking/Tunnel")]
	public void set_remote_address(
		string [] tunnels,
		string [] addresses
	) {
		this.Invoke("set_remote_address", new object [] {
				tunnels,
				addresses});

	}
	public System.IAsyncResult Beginset_remote_address(string [] tunnels,string [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_remote_address", new object[] {
			tunnels,
			addresses}, callback, asyncState);
	}
	public void Endset_remote_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_secondary_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Tunnel", 
		RequestNamespace="urn:iControl:Networking/Tunnel", ResponseNamespace="urn:iControl:Networking/Tunnel")]
	public void set_secondary_address(
		string [] tunnels,
		string [] addresses
	) {
		this.Invoke("set_secondary_address", new object [] {
				tunnels,
				addresses});

	}
	public System.IAsyncResult Beginset_secondary_address(string [] tunnels,string [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_secondary_address", new object[] {
			tunnels,
			addresses}, callback, asyncState);
	}
	public void Endset_secondary_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_tos
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Tunnel", 
		RequestNamespace="urn:iControl:Networking/Tunnel", ResponseNamespace="urn:iControl:Networking/Tunnel")]
	public void set_tos(
		string [] tunnels,
		long [] values
	) {
		this.Invoke("set_tos", new object [] {
				tunnels,
				values});

	}
	public System.IAsyncResult Beginset_tos(string [] tunnels,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_tos", new object[] {
			tunnels,
			values}, callback, asyncState);
	}
	public void Endset_tos(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_traffic_group
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Tunnel", 
		RequestNamespace="urn:iControl:Networking/Tunnel", ResponseNamespace="urn:iControl:Networking/Tunnel")]
	public void set_traffic_group(
		string [] tunnels,
		string [] traffic_groups
	) {
		this.Invoke("set_traffic_group", new object [] {
				tunnels,
				traffic_groups});

	}
	public System.IAsyncResult Beginset_traffic_group(string [] tunnels,string [] traffic_groups, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_traffic_group", new object[] {
			tunnels,
			traffic_groups}, callback, asyncState);
	}
	public void Endset_traffic_group(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_transparent_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/Tunnel", 
		RequestNamespace="urn:iControl:Networking/Tunnel", ResponseNamespace="urn:iControl:Networking/Tunnel")]
	public void set_transparent_state(
		string [] tunnels,
		CommonEnabledState [] states
	) {
		this.Invoke("set_transparent_state", new object [] {
				tunnels,
				states});

	}
	public System.IAsyncResult Beginset_transparent_state(string [] tunnels,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_transparent_state", new object[] {
			tunnels,
			states}, callback, asyncState);
	}
	public void Endset_transparent_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.Tunnel.TunnelDirection", Namespace = "urn:iControl")]
	public enum NetworkingTunnelTunnelDirection
	{
		TUNNEL_DIRECTION_UNKNOWN,
		TUNNEL_DIRECTION_INBOUND,
		TUNNEL_DIRECTION_OUTBOUND,
		TUNNEL_DIRECTION_BIDIRECTIONAL,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.Tunnel.L2TunnelFDBEntry", Namespace = "urn:iControl")]
	public partial class NetworkingTunnelL2TunnelFDBEntry
	{
		private string mac_addressField;
		public string mac_address
		{
			get { return this.mac_addressField; }
			set { this.mac_addressField = value; }
		}
		private string endpointField;
		public string endpoint
		{
			get { return this.endpointField; }
			set { this.endpointField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.Tunnel.L2TunnelFDBEntryV2", Namespace = "urn:iControl")]
	public partial class NetworkingTunnelL2TunnelFDBEntryV2
	{
		private string mac_addressField;
		public string mac_address
		{
			get { return this.mac_addressField; }
			set { this.mac_addressField = value; }
		}
		private string endpointField;
		public string endpoint
		{
			get { return this.endpointField; }
			set { this.endpointField = value; }
		}
		private string [] replicatorsField;
		public string [] replicators
		{
			get { return this.replicatorsField; }
			set { this.replicatorsField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.Tunnel.TunnelProfileAttribute", Namespace = "urn:iControl")]
	public partial class NetworkingTunnelTunnelProfileAttribute
	{
		private NetworkingTunnelProfileType profile_typeField;
		public NetworkingTunnelProfileType profile_type
		{
			get { return this.profile_typeField; }
			set { this.profile_typeField = value; }
		}
		private string profile_nameField;
		public string profile_name
		{
			get { return this.profile_nameField; }
			set { this.profile_nameField = value; }
		}
	};

}
