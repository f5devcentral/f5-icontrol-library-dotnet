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
	[System.Web.Services.WebServiceBindingAttribute(Name="Networking.iSessionPeerDiscoveryBinding", Namespace="urn:iControl")]
	public partial class NetworkingiSessionPeerDiscovery : iControlInterface {
		public NetworkingiSessionPeerDiscovery() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// get_discoverable_peer_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionPeerDiscovery", 
		RequestNamespace="urn:iControl:Networking/iSessionPeerDiscovery", ResponseNamespace="urn:iControl:Networking/iSessionPeerDiscovery")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_discoverable_peer_enabled_state(
		long [] dynpeerlist
	) {
		object [] results = this.Invoke("get_discoverable_peer_enabled_state", new object [] {
				dynpeerlist});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_discoverable_peer_enabled_state(long [] dynpeerlist, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_discoverable_peer_enabled_state", new object[] {
			dynpeerlist}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_discoverable_peer_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_discovered_peer_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionPeerDiscovery", 
		RequestNamespace="urn:iControl:Networking/iSessionPeerDiscovery", ResponseNamespace="urn:iControl:Networking/iSessionPeerDiscovery")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_discovered_peer_enabled_state(
		long [] dynpeerlist
	) {
		object [] results = this.Invoke("get_discovered_peer_enabled_state", new object [] {
				dynpeerlist});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_discovered_peer_enabled_state(long [] dynpeerlist, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_discovered_peer_enabled_state", new object[] {
			dynpeerlist}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_discovered_peer_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_discovery_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionPeerDiscovery", 
		RequestNamespace="urn:iControl:Networking/iSessionPeerDiscovery", ResponseNamespace="urn:iControl:Networking/iSessionPeerDiscovery")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingiSessionPeerDiscoveryDiscoveryMode [] get_discovery_mode(
		long [] dynpeerlist
	) {
		object [] results = this.Invoke("get_discovery_mode", new object [] {
				dynpeerlist});
		return ((NetworkingiSessionPeerDiscoveryDiscoveryMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_discovery_mode(long [] dynpeerlist, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_discovery_mode", new object[] {
			dynpeerlist}, callback, asyncState);
	}
	public NetworkingiSessionPeerDiscoveryDiscoveryMode [] Endget_discovery_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingiSessionPeerDiscoveryDiscoveryMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_discovery_mode_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionPeerDiscovery", 
		RequestNamespace="urn:iControl:Networking/iSessionPeerDiscovery", ResponseNamespace="urn:iControl:Networking/iSessionPeerDiscovery")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingiSessionPeerDiscoveryFilterMode [] get_discovery_mode_enabled_state(
		long [] dynpeerlist
	) {
		object [] results = this.Invoke("get_discovery_mode_enabled_state", new object [] {
				dynpeerlist});
		return ((NetworkingiSessionPeerDiscoveryFilterMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_discovery_mode_enabled_state(long [] dynpeerlist, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_discovery_mode_enabled_state", new object[] {
			dynpeerlist}, callback, asyncState);
	}
	public NetworkingiSessionPeerDiscoveryFilterMode [] Endget_discovery_mode_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingiSessionPeerDiscoveryFilterMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_icmp_backoff_time
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionPeerDiscovery", 
		RequestNamespace="urn:iControl:Networking/iSessionPeerDiscovery", ResponseNamespace="urn:iControl:Networking/iSessionPeerDiscovery")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public short [] get_icmp_backoff_time(
		long [] dynpeerlist
	) {
		object [] results = this.Invoke("get_icmp_backoff_time", new object [] {
				dynpeerlist});
		return ((short [])(results[0]));
	}
	public System.IAsyncResult Beginget_icmp_backoff_time(long [] dynpeerlist, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_icmp_backoff_time", new object[] {
			dynpeerlist}, callback, asyncState);
	}
	public short [] Endget_icmp_backoff_time(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((short [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_icmp_max_requests
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionPeerDiscovery", 
		RequestNamespace="urn:iControl:Networking/iSessionPeerDiscovery", ResponseNamespace="urn:iControl:Networking/iSessionPeerDiscovery")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public short [] get_icmp_max_requests(
		long [] dynpeerlist
	) {
		object [] results = this.Invoke("get_icmp_max_requests", new object [] {
				dynpeerlist});
		return ((short [])(results[0]));
	}
	public System.IAsyncResult Beginget_icmp_max_requests(long [] dynpeerlist, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_icmp_max_requests", new object[] {
			dynpeerlist}, callback, asyncState);
	}
	public short [] Endget_icmp_max_requests(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((short [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_icmp_max_retries
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionPeerDiscovery", 
		RequestNamespace="urn:iControl:Networking/iSessionPeerDiscovery", ResponseNamespace="urn:iControl:Networking/iSessionPeerDiscovery")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public short [] get_icmp_max_retries(
		long [] dynpeerlist
	) {
		object [] results = this.Invoke("get_icmp_max_retries", new object [] {
				dynpeerlist});
		return ((short [])(results[0]));
	}
	public System.IAsyncResult Beginget_icmp_max_retries(long [] dynpeerlist, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_icmp_max_retries", new object[] {
			dynpeerlist}, callback, asyncState);
	}
	public short [] Endget_icmp_max_retries(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((short [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionPeerDiscovery", 
		RequestNamespace="urn:iControl:Networking/iSessionPeerDiscovery", ResponseNamespace="urn:iControl:Networking/iSessionPeerDiscovery")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_list(

	) {
		object [] results = this.Invoke("get_list", new object [0]);
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_list", new object[0], callback, asyncState);
	}
	public long [] Endget_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_max_peer_count
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionPeerDiscovery", 
		RequestNamespace="urn:iControl:Networking/iSessionPeerDiscovery", ResponseNamespace="urn:iControl:Networking/iSessionPeerDiscovery")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public short [] get_max_peer_count(
		long [] dynpeerlist
	) {
		object [] results = this.Invoke("get_max_peer_count", new object [] {
				dynpeerlist});
		return ((short [])(results[0]));
	}
	public System.IAsyncResult Beginget_max_peer_count(long [] dynpeerlist, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_max_peer_count", new object[] {
			dynpeerlist}, callback, asyncState);
	}
	public short [] Endget_max_peer_count(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((short [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionPeerDiscovery", 
		RequestNamespace="urn:iControl:Networking/iSessionPeerDiscovery", ResponseNamespace="urn:iControl:Networking/iSessionPeerDiscovery")]
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
	// set_discoverable_peer_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionPeerDiscovery", 
		RequestNamespace="urn:iControl:Networking/iSessionPeerDiscovery", ResponseNamespace="urn:iControl:Networking/iSessionPeerDiscovery")]
	public void set_discoverable_peer_enabled_state(
		long [] dynpeerlist,
		CommonEnabledState [] discoverable_peer
	) {
		this.Invoke("set_discoverable_peer_enabled_state", new object [] {
				dynpeerlist,
				discoverable_peer});

	}
	public System.IAsyncResult Beginset_discoverable_peer_enabled_state(long [] dynpeerlist,CommonEnabledState [] discoverable_peer, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_discoverable_peer_enabled_state", new object[] {
			dynpeerlist,
			discoverable_peer}, callback, asyncState);
	}
	public void Endset_discoverable_peer_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_discovered_peer_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionPeerDiscovery", 
		RequestNamespace="urn:iControl:Networking/iSessionPeerDiscovery", ResponseNamespace="urn:iControl:Networking/iSessionPeerDiscovery")]
	public void set_discovered_peer_enabled_state(
		long [] dynpeerlist,
		CommonEnabledState [] discover_peer
	) {
		this.Invoke("set_discovered_peer_enabled_state", new object [] {
				dynpeerlist,
				discover_peer});

	}
	public System.IAsyncResult Beginset_discovered_peer_enabled_state(long [] dynpeerlist,CommonEnabledState [] discover_peer, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_discovered_peer_enabled_state", new object[] {
			dynpeerlist,
			discover_peer}, callback, asyncState);
	}
	public void Endset_discovered_peer_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_discovery_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionPeerDiscovery", 
		RequestNamespace="urn:iControl:Networking/iSessionPeerDiscovery", ResponseNamespace="urn:iControl:Networking/iSessionPeerDiscovery")]
	public void set_discovery_mode(
		long [] dynpeerlist,
		NetworkingiSessionPeerDiscoveryDiscoveryMode [] discovery_modes
	) {
		this.Invoke("set_discovery_mode", new object [] {
				dynpeerlist,
				discovery_modes});

	}
	public System.IAsyncResult Beginset_discovery_mode(long [] dynpeerlist,NetworkingiSessionPeerDiscoveryDiscoveryMode [] discovery_modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_discovery_mode", new object[] {
			dynpeerlist,
			discovery_modes}, callback, asyncState);
	}
	public void Endset_discovery_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_discovery_mode_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionPeerDiscovery", 
		RequestNamespace="urn:iControl:Networking/iSessionPeerDiscovery", ResponseNamespace="urn:iControl:Networking/iSessionPeerDiscovery")]
	public void set_discovery_mode_enabled_state(
		long [] dynpeerlist,
		NetworkingiSessionPeerDiscoveryFilterMode [] discovery_mode
	) {
		this.Invoke("set_discovery_mode_enabled_state", new object [] {
				dynpeerlist,
				discovery_mode});

	}
	public System.IAsyncResult Beginset_discovery_mode_enabled_state(long [] dynpeerlist,NetworkingiSessionPeerDiscoveryFilterMode [] discovery_mode, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_discovery_mode_enabled_state", new object[] {
			dynpeerlist,
			discovery_mode}, callback, asyncState);
	}
	public void Endset_discovery_mode_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_icmp_backoff_time
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionPeerDiscovery", 
		RequestNamespace="urn:iControl:Networking/iSessionPeerDiscovery", ResponseNamespace="urn:iControl:Networking/iSessionPeerDiscovery")]
	public void set_icmp_backoff_time(
		long [] dynpeerlist,
		short [] max_backoff_time
	) {
		this.Invoke("set_icmp_backoff_time", new object [] {
				dynpeerlist,
				max_backoff_time});

	}
	public System.IAsyncResult Beginset_icmp_backoff_time(long [] dynpeerlist,short [] max_backoff_time, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_icmp_backoff_time", new object[] {
			dynpeerlist,
			max_backoff_time}, callback, asyncState);
	}
	public void Endset_icmp_backoff_time(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_icmp_max_requests
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionPeerDiscovery", 
		RequestNamespace="urn:iControl:Networking/iSessionPeerDiscovery", ResponseNamespace="urn:iControl:Networking/iSessionPeerDiscovery")]
	public void set_icmp_max_requests(
		long [] dynpeerlist,
		short [] max_requests
	) {
		this.Invoke("set_icmp_max_requests", new object [] {
				dynpeerlist,
				max_requests});

	}
	public System.IAsyncResult Beginset_icmp_max_requests(long [] dynpeerlist,short [] max_requests, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_icmp_max_requests", new object[] {
			dynpeerlist,
			max_requests}, callback, asyncState);
	}
	public void Endset_icmp_max_requests(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_icmp_max_retries
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionPeerDiscovery", 
		RequestNamespace="urn:iControl:Networking/iSessionPeerDiscovery", ResponseNamespace="urn:iControl:Networking/iSessionPeerDiscovery")]
	public void set_icmp_max_retries(
		long [] dynpeerlist,
		short [] max_retries
	) {
		this.Invoke("set_icmp_max_retries", new object [] {
				dynpeerlist,
				max_retries});

	}
	public System.IAsyncResult Beginset_icmp_max_retries(long [] dynpeerlist,short [] max_retries, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_icmp_max_retries", new object[] {
			dynpeerlist,
			max_retries}, callback, asyncState);
	}
	public void Endset_icmp_max_retries(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_max_peer_count
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionPeerDiscovery", 
		RequestNamespace="urn:iControl:Networking/iSessionPeerDiscovery", ResponseNamespace="urn:iControl:Networking/iSessionPeerDiscovery")]
	public void set_max_peer_count(
		long [] dynpeerlist,
		short [] max_peers
	) {
		this.Invoke("set_max_peer_count", new object [] {
				dynpeerlist,
				max_peers});

	}
	public System.IAsyncResult Beginset_max_peer_count(long [] dynpeerlist,short [] max_peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_max_peer_count", new object[] {
			dynpeerlist,
			max_peers}, callback, asyncState);
	}
	public void Endset_max_peer_count(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.iSessionPeerDiscovery.DiscoveryMode", Namespace = "urn:iControl")]
	public enum NetworkingiSessionPeerDiscoveryDiscoveryMode
	{
		DISCOVERY_MODE_ENABLE_ALL,
		DISCOVERY_MODE_DISABLE,
		DISCOVERY_MODE_ENABLE_ICMP,
		DISCOVERY_MODE_ENABLE_TCP,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.iSessionPeerDiscovery.FilterMode", Namespace = "urn:iControl")]
	public enum NetworkingiSessionPeerDiscoveryFilterMode
	{
		DISCOVERY_FILTER_MODE_EXCLUDE,
		DISCOVERY_FILTER_MODE_INCLUDE,
	}

	//=======================================================================
	// Structs
	//=======================================================================

}
