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
	[System.Web.Services.WebServiceBindingAttribute(Name="Networking.RouterAdvertisementBinding", Namespace="urn:iControl")]
	public partial class NetworkingRouterAdvertisement : iControlInterface {
		public NetworkingRouterAdvertisement() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouterAdvertisement", 
		RequestNamespace="urn:iControl:Networking/RouterAdvertisement", ResponseNamespace="urn:iControl:Networking/RouterAdvertisement")]
	public void create(
		string [] ras,
		string [] vlans
	) {
		this.Invoke("create", new object [] {
				ras,
				vlans});

	}
	public System.IAsyncResult Begincreate(string [] ras,string [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			ras,
			vlans}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_router_advertisements
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouterAdvertisement", 
		RequestNamespace="urn:iControl:Networking/RouterAdvertisement", ResponseNamespace="urn:iControl:Networking/RouterAdvertisement")]
	public void delete_all_router_advertisements(

	) {
		this.Invoke("delete_all_router_advertisements", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_router_advertisements(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_router_advertisements", new object[0], callback, asyncState);
	}
	public void Enddelete_all_router_advertisements(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_router_advertisement
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouterAdvertisement", 
		RequestNamespace="urn:iControl:Networking/RouterAdvertisement", ResponseNamespace="urn:iControl:Networking/RouterAdvertisement")]
	public void delete_router_advertisement(
		string [] ras
	) {
		this.Invoke("delete_router_advertisement", new object [] {
				ras});

	}
	public System.IAsyncResult Begindelete_router_advertisement(string [] ras, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_router_advertisement", new object[] {
			ras}, callback, asyncState);
	}
	public void Enddelete_router_advertisement(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouterAdvertisement", 
		RequestNamespace="urn:iControl:Networking/RouterAdvertisement", ResponseNamespace="urn:iControl:Networking/RouterAdvertisement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_enabled_state(
		string [] ras
	) {
		object [] results = this.Invoke("get_enabled_state", new object [] {
				ras});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_enabled_state(string [] ras, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_enabled_state", new object[] {
			ras}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouterAdvertisement", 
		RequestNamespace="urn:iControl:Networking/RouterAdvertisement", ResponseNamespace="urn:iControl:Networking/RouterAdvertisement")]
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
	// get_managed_flag_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouterAdvertisement", 
		RequestNamespace="urn:iControl:Networking/RouterAdvertisement", ResponseNamespace="urn:iControl:Networking/RouterAdvertisement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_managed_flag_state(
		string [] ras
	) {
		object [] results = this.Invoke("get_managed_flag_state", new object [] {
				ras});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_managed_flag_state(string [] ras, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_managed_flag_state", new object[] {
			ras}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_managed_flag_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_maximum_hop
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouterAdvertisement", 
		RequestNamespace="urn:iControl:Networking/RouterAdvertisement", ResponseNamespace="urn:iControl:Networking/RouterAdvertisement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_maximum_hop(
		string [] ras
	) {
		object [] results = this.Invoke("get_maximum_hop", new object [] {
				ras});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_hop(string [] ras, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_hop", new object[] {
			ras}, callback, asyncState);
	}
	public long [] Endget_maximum_hop(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_maximum_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouterAdvertisement", 
		RequestNamespace="urn:iControl:Networking/RouterAdvertisement", ResponseNamespace="urn:iControl:Networking/RouterAdvertisement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_maximum_interval(
		string [] ras
	) {
		object [] results = this.Invoke("get_maximum_interval", new object [] {
				ras});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_maximum_interval(string [] ras, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_maximum_interval", new object[] {
			ras}, callback, asyncState);
	}
	public long [] Endget_maximum_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_minimum_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouterAdvertisement", 
		RequestNamespace="urn:iControl:Networking/RouterAdvertisement", ResponseNamespace="urn:iControl:Networking/RouterAdvertisement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_minimum_interval(
		string [] ras
	) {
		object [] results = this.Invoke("get_minimum_interval", new object [] {
				ras});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_minimum_interval(string [] ras, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_minimum_interval", new object[] {
			ras}, callback, asyncState);
	}
	public long [] Endget_minimum_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_mtu
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouterAdvertisement", 
		RequestNamespace="urn:iControl:Networking/RouterAdvertisement", ResponseNamespace="urn:iControl:Networking/RouterAdvertisement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_mtu(
		string [] ras
	) {
		object [] results = this.Invoke("get_mtu", new object [] {
				ras});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_mtu(string [] ras, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_mtu", new object[] {
			ras}, callback, asyncState);
	}
	public long [] Endget_mtu(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_other_configuration_flag_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouterAdvertisement", 
		RequestNamespace="urn:iControl:Networking/RouterAdvertisement", ResponseNamespace="urn:iControl:Networking/RouterAdvertisement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_other_configuration_flag_state(
		string [] ras
	) {
		object [] results = this.Invoke("get_other_configuration_flag_state", new object [] {
				ras});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_other_configuration_flag_state(string [] ras, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_other_configuration_flag_state", new object[] {
			ras}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_other_configuration_flag_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_reachable_time
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouterAdvertisement", 
		RequestNamespace="urn:iControl:Networking/RouterAdvertisement", ResponseNamespace="urn:iControl:Networking/RouterAdvertisement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_reachable_time(
		string [] ras
	) {
		object [] results = this.Invoke("get_reachable_time", new object [] {
				ras});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_reachable_time(string [] ras, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_reachable_time", new object[] {
			ras}, callback, asyncState);
	}
	public long [] Endget_reachable_time(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_retransmit_time
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouterAdvertisement", 
		RequestNamespace="urn:iControl:Networking/RouterAdvertisement", ResponseNamespace="urn:iControl:Networking/RouterAdvertisement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_retransmit_time(
		string [] ras
	) {
		object [] results = this.Invoke("get_retransmit_time", new object [] {
				ras});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_retransmit_time(string [] ras, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_retransmit_time", new object[] {
			ras}, callback, asyncState);
	}
	public long [] Endget_retransmit_time(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_router_lifetime
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouterAdvertisement", 
		RequestNamespace="urn:iControl:Networking/RouterAdvertisement", ResponseNamespace="urn:iControl:Networking/RouterAdvertisement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_router_lifetime(
		string [] ras
	) {
		object [] results = this.Invoke("get_router_lifetime", new object [] {
				ras});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_router_lifetime(string [] ras, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_router_lifetime", new object[] {
			ras}, callback, asyncState);
	}
	public long [] Endget_router_lifetime(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouterAdvertisement", 
		RequestNamespace="urn:iControl:Networking/RouterAdvertisement", ResponseNamespace="urn:iControl:Networking/RouterAdvertisement")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouterAdvertisement", 
		RequestNamespace="urn:iControl:Networking/RouterAdvertisement", ResponseNamespace="urn:iControl:Networking/RouterAdvertisement")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_vlan(
		string [] ras
	) {
		object [] results = this.Invoke("get_vlan", new object [] {
				ras});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_vlan(string [] ras, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_vlan", new object[] {
			ras}, callback, asyncState);
	}
	public string [] Endget_vlan(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// set_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouterAdvertisement", 
		RequestNamespace="urn:iControl:Networking/RouterAdvertisement", ResponseNamespace="urn:iControl:Networking/RouterAdvertisement")]
	public void set_enabled_state(
		string [] ras,
		CommonEnabledState [] states
	) {
		this.Invoke("set_enabled_state", new object [] {
				ras,
				states});

	}
	public System.IAsyncResult Beginset_enabled_state(string [] ras,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_enabled_state", new object[] {
			ras,
			states}, callback, asyncState);
	}
	public void Endset_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_managed_flag_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouterAdvertisement", 
		RequestNamespace="urn:iControl:Networking/RouterAdvertisement", ResponseNamespace="urn:iControl:Networking/RouterAdvertisement")]
	public void set_managed_flag_state(
		string [] ras,
		CommonEnabledState [] states
	) {
		this.Invoke("set_managed_flag_state", new object [] {
				ras,
				states});

	}
	public System.IAsyncResult Beginset_managed_flag_state(string [] ras,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_managed_flag_state", new object[] {
			ras,
			states}, callback, asyncState);
	}
	public void Endset_managed_flag_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_hop
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouterAdvertisement", 
		RequestNamespace="urn:iControl:Networking/RouterAdvertisement", ResponseNamespace="urn:iControl:Networking/RouterAdvertisement")]
	public void set_maximum_hop(
		string [] ras,
		long [] values
	) {
		this.Invoke("set_maximum_hop", new object [] {
				ras,
				values});

	}
	public System.IAsyncResult Beginset_maximum_hop(string [] ras,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_hop", new object[] {
			ras,
			values}, callback, asyncState);
	}
	public void Endset_maximum_hop(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_maximum_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouterAdvertisement", 
		RequestNamespace="urn:iControl:Networking/RouterAdvertisement", ResponseNamespace="urn:iControl:Networking/RouterAdvertisement")]
	public void set_maximum_interval(
		string [] ras,
		long [] intervals
	) {
		this.Invoke("set_maximum_interval", new object [] {
				ras,
				intervals});

	}
	public System.IAsyncResult Beginset_maximum_interval(string [] ras,long [] intervals, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_maximum_interval", new object[] {
			ras,
			intervals}, callback, asyncState);
	}
	public void Endset_maximum_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_minimum_interval
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouterAdvertisement", 
		RequestNamespace="urn:iControl:Networking/RouterAdvertisement", ResponseNamespace="urn:iControl:Networking/RouterAdvertisement")]
	public void set_minimum_interval(
		string [] ras,
		long [] intervals
	) {
		this.Invoke("set_minimum_interval", new object [] {
				ras,
				intervals});

	}
	public System.IAsyncResult Beginset_minimum_interval(string [] ras,long [] intervals, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_minimum_interval", new object[] {
			ras,
			intervals}, callback, asyncState);
	}
	public void Endset_minimum_interval(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_mtu
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouterAdvertisement", 
		RequestNamespace="urn:iControl:Networking/RouterAdvertisement", ResponseNamespace="urn:iControl:Networking/RouterAdvertisement")]
	public void set_mtu(
		string [] ras,
		long [] mtus
	) {
		this.Invoke("set_mtu", new object [] {
				ras,
				mtus});

	}
	public System.IAsyncResult Beginset_mtu(string [] ras,long [] mtus, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_mtu", new object[] {
			ras,
			mtus}, callback, asyncState);
	}
	public void Endset_mtu(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_other_configuration_flag_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouterAdvertisement", 
		RequestNamespace="urn:iControl:Networking/RouterAdvertisement", ResponseNamespace="urn:iControl:Networking/RouterAdvertisement")]
	public void set_other_configuration_flag_state(
		string [] ras,
		CommonEnabledState [] states
	) {
		this.Invoke("set_other_configuration_flag_state", new object [] {
				ras,
				states});

	}
	public System.IAsyncResult Beginset_other_configuration_flag_state(string [] ras,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_other_configuration_flag_state", new object[] {
			ras,
			states}, callback, asyncState);
	}
	public void Endset_other_configuration_flag_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_reachable_time
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouterAdvertisement", 
		RequestNamespace="urn:iControl:Networking/RouterAdvertisement", ResponseNamespace="urn:iControl:Networking/RouterAdvertisement")]
	public void set_reachable_time(
		string [] ras,
		long [] times
	) {
		this.Invoke("set_reachable_time", new object [] {
				ras,
				times});

	}
	public System.IAsyncResult Beginset_reachable_time(string [] ras,long [] times, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_reachable_time", new object[] {
			ras,
			times}, callback, asyncState);
	}
	public void Endset_reachable_time(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_retransmit_time
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouterAdvertisement", 
		RequestNamespace="urn:iControl:Networking/RouterAdvertisement", ResponseNamespace="urn:iControl:Networking/RouterAdvertisement")]
	public void set_retransmit_time(
		string [] ras,
		long [] times
	) {
		this.Invoke("set_retransmit_time", new object [] {
				ras,
				times});

	}
	public System.IAsyncResult Beginset_retransmit_time(string [] ras,long [] times, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_retransmit_time", new object[] {
			ras,
			times}, callback, asyncState);
	}
	public void Endset_retransmit_time(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_router_lifetime
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouterAdvertisement", 
		RequestNamespace="urn:iControl:Networking/RouterAdvertisement", ResponseNamespace="urn:iControl:Networking/RouterAdvertisement")]
	public void set_router_lifetime(
		string [] ras,
		long [] lifetimes
	) {
		this.Invoke("set_router_lifetime", new object [] {
				ras,
				lifetimes});

	}
	public System.IAsyncResult Beginset_router_lifetime(string [] ras,long [] lifetimes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_router_lifetime", new object[] {
			ras,
			lifetimes}, callback, asyncState);
	}
	public void Endset_router_lifetime(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_vlan
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/RouterAdvertisement", 
		RequestNamespace="urn:iControl:Networking/RouterAdvertisement", ResponseNamespace="urn:iControl:Networking/RouterAdvertisement")]
	public void set_vlan(
		string [] ras,
		string [] vlans
	) {
		this.Invoke("set_vlan", new object [] {
				ras,
				vlans});

	}
	public System.IAsyncResult Beginset_vlan(string [] ras,string [] vlans, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_vlan", new object[] {
			ras,
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

}
