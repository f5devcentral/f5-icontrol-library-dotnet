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
	public partial class NetworkingTunnel : iControlInterface {
		public NetworkingTunnel() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
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

}
