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
	[System.Web.Services.WebServiceBindingAttribute(Name="Networking.iSessionLocalInterfaceBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(NetworkingUuid_128))]
	public partial class NetworkingiSessionLocalInterface : iControlInterface {
		public NetworkingiSessionLocalInterface() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionLocalInterface", 
		RequestNamespace="urn:iControl:Networking/iSessionLocalInterface", ResponseNamespace="urn:iControl:Networking/iSessionLocalInterface")]
	public void create(
		long woc_instance,
		string [] local_ips,
		CommonEnabledState enabled,
		string serverssl
	) {
		this.Invoke("create", new object [] {
				woc_instance,
				local_ips,
				enabled,
				serverssl});

	}
	public System.IAsyncResult Begincreate(long woc_instance,string [] local_ips,CommonEnabledState enabled,string serverssl, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			woc_instance,
			local_ips,
			enabled,
			serverssl}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_local
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionLocalInterface", 
		RequestNamespace="urn:iControl:Networking/iSessionLocalInterface", ResponseNamespace="urn:iControl:Networking/iSessionLocalInterface")]
	public void delete_local(
		long [] wocs
	) {
		this.Invoke("delete_local", new object [] {
				wocs});

	}
	public System.IAsyncResult Begindelete_local(long [] wocs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_local", new object[] {
			wocs}, callback, asyncState);
	}
	public void Enddelete_local(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_UUID
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionLocalInterface", 
		RequestNamespace="urn:iControl:Networking/iSessionLocalInterface", ResponseNamespace="urn:iControl:Networking/iSessionLocalInterface")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingUuid_128 [] get_UUID(
		long [] wocs
	) {
		object [] results = this.Invoke("get_UUID", new object [] {
				wocs});
		return ((NetworkingUuid_128 [])(results[0]));
	}
	public System.IAsyncResult Beginget_UUID(long [] wocs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_UUID", new object[] {
			wocs}, callback, asyncState);
	}
	public NetworkingUuid_128 [] Endget_UUID(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingUuid_128 [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_allow_nat
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionLocalInterface", 
		RequestNamespace="urn:iControl:Networking/iSessionLocalInterface", ResponseNamespace="urn:iControl:Networking/iSessionLocalInterface")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_allow_nat(
		long [] wocs
	) {
		object [] results = this.Invoke("get_allow_nat", new object [] {
				wocs});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_allow_nat(long [] wocs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_allow_nat", new object[] {
			wocs}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_allow_nat(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionLocalInterface", 
		RequestNamespace="urn:iControl:Networking/iSessionLocalInterface", ResponseNamespace="urn:iControl:Networking/iSessionLocalInterface")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string get_description(

	) {
		object [] results = this.Invoke("get_description", new object [0]);
		return ((string)(results[0]));
	}
	public System.IAsyncResult Beginget_description(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[0], callback, asyncState);
	}
	public string Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionLocalInterface", 
		RequestNamespace="urn:iControl:Networking/iSessionLocalInterface", ResponseNamespace="urn:iControl:Networking/iSessionLocalInterface")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_enabled_state(
		long [] wocs
	) {
		object [] results = this.Invoke("get_enabled_state", new object [] {
				wocs});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_enabled_state(long [] wocs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_enabled_state", new object[] {
			wocs}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_internal_forwarding_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionLocalInterface", 
		RequestNamespace="urn:iControl:Networking/iSessionLocalInterface", ResponseNamespace="urn:iControl:Networking/iSessionLocalInterface")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_internal_forwarding_state(
		long [] wocs
	) {
		object [] results = this.Invoke("get_internal_forwarding_state", new object [] {
				wocs});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_internal_forwarding_state(long [] wocs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_internal_forwarding_state", new object[] {
			wocs}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_internal_forwarding_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ip_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionLocalInterface", 
		RequestNamespace="urn:iControl:Networking/iSessionLocalInterface", ResponseNamespace="urn:iControl:Networking/iSessionLocalInterface")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_ip_list(
		long [] wocs
	) {
		object [] results = this.Invoke("get_ip_list", new object [] {
				wocs});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_ip_list(long [] wocs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ip_list", new object[] {
			wocs}, callback, asyncState);
	}
	public string [] [] Endget_ip_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionLocalInterface", 
		RequestNamespace="urn:iControl:Networking/iSessionLocalInterface", ResponseNamespace="urn:iControl:Networking/iSessionLocalInterface")]
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
	// get_management_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionLocalInterface", 
		RequestNamespace="urn:iControl:Networking/iSessionLocalInterface", ResponseNamespace="urn:iControl:Networking/iSessionLocalInterface")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_management_address(
		long [] wocs
	) {
		object [] results = this.Invoke("get_management_address", new object [] {
				wocs});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_management_address(long [] wocs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_management_address", new object[] {
			wocs}, callback, asyncState);
	}
	public string [] Endget_management_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_nat_source_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionLocalInterface", 
		RequestNamespace="urn:iControl:Networking/iSessionLocalInterface", ResponseNamespace="urn:iControl:Networking/iSessionLocalInterface")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingiSessionLocalInterfaceNatSourceAddress [] get_nat_source_address(
		long [] wocs
	) {
		object [] results = this.Invoke("get_nat_source_address", new object [] {
				wocs});
		return ((NetworkingiSessionLocalInterfaceNatSourceAddress [])(results[0]));
	}
	public System.IAsyncResult Beginget_nat_source_address(long [] wocs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_nat_source_address", new object[] {
			wocs}, callback, asyncState);
	}
	public NetworkingiSessionLocalInterfaceNatSourceAddress [] Endget_nat_source_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingiSessionLocalInterfaceNatSourceAddress [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_serverssl
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionLocalInterface", 
		RequestNamespace="urn:iControl:Networking/iSessionLocalInterface", ResponseNamespace="urn:iControl:Networking/iSessionLocalInterface")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_serverssl(
		long [] wocs
	) {
		object [] results = this.Invoke("get_serverssl", new object [] {
				wocs});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_serverssl(long [] wocs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_serverssl", new object[] {
			wocs}, callback, asyncState);
	}
	public string [] Endget_serverssl(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_tunnel_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionLocalInterface", 
		RequestNamespace="urn:iControl:Networking/iSessionLocalInterface", ResponseNamespace="urn:iControl:Networking/iSessionLocalInterface")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_tunnel_port(
		long [] wocs
	) {
		object [] results = this.Invoke("get_tunnel_port", new object [] {
				wocs});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_tunnel_port(long [] wocs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_tunnel_port", new object[] {
			wocs}, callback, asyncState);
	}
	public long [] Endget_tunnel_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionLocalInterface", 
		RequestNamespace="urn:iControl:Networking/iSessionLocalInterface", ResponseNamespace="urn:iControl:Networking/iSessionLocalInterface")]
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
	// set_allow_nat
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionLocalInterface", 
		RequestNamespace="urn:iControl:Networking/iSessionLocalInterface", ResponseNamespace="urn:iControl:Networking/iSessionLocalInterface")]
	public void set_allow_nat(
		long [] wocs,
		CommonEnabledState [] nat_states
	) {
		this.Invoke("set_allow_nat", new object [] {
				wocs,
				nat_states});

	}
	public System.IAsyncResult Beginset_allow_nat(long [] wocs,CommonEnabledState [] nat_states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_allow_nat", new object[] {
			wocs,
			nat_states}, callback, asyncState);
	}
	public void Endset_allow_nat(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionLocalInterface", 
		RequestNamespace="urn:iControl:Networking/iSessionLocalInterface", ResponseNamespace="urn:iControl:Networking/iSessionLocalInterface")]
	public void set_description(
		string description
	) {
		this.Invoke("set_description", new object [] {
				description});

	}
	public System.IAsyncResult Beginset_description(string description, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			description}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionLocalInterface", 
		RequestNamespace="urn:iControl:Networking/iSessionLocalInterface", ResponseNamespace="urn:iControl:Networking/iSessionLocalInterface")]
	public void set_enabled_state(
		long [] wocs,
		CommonEnabledState [] enabled_states
	) {
		this.Invoke("set_enabled_state", new object [] {
				wocs,
				enabled_states});

	}
	public System.IAsyncResult Beginset_enabled_state(long [] wocs,CommonEnabledState [] enabled_states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_enabled_state", new object[] {
			wocs,
			enabled_states}, callback, asyncState);
	}
	public void Endset_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_internal_forwarding_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionLocalInterface", 
		RequestNamespace="urn:iControl:Networking/iSessionLocalInterface", ResponseNamespace="urn:iControl:Networking/iSessionLocalInterface")]
	public void set_internal_forwarding_state(
		long [] wocs,
		CommonEnabledState [] states
	) {
		this.Invoke("set_internal_forwarding_state", new object [] {
				wocs,
				states});

	}
	public System.IAsyncResult Beginset_internal_forwarding_state(long [] wocs,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_internal_forwarding_state", new object[] {
			wocs,
			states}, callback, asyncState);
	}
	public void Endset_internal_forwarding_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ip_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionLocalInterface", 
		RequestNamespace="urn:iControl:Networking/iSessionLocalInterface", ResponseNamespace="urn:iControl:Networking/iSessionLocalInterface")]
	public void set_ip_list(
		long [] wocs,
		string [] [] local_ips
	) {
		this.Invoke("set_ip_list", new object [] {
				wocs,
				local_ips});

	}
	public System.IAsyncResult Beginset_ip_list(long [] wocs,string [] [] local_ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ip_list", new object[] {
			wocs,
			local_ips}, callback, asyncState);
	}
	public void Endset_ip_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_management_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionLocalInterface", 
		RequestNamespace="urn:iControl:Networking/iSessionLocalInterface", ResponseNamespace="urn:iControl:Networking/iSessionLocalInterface")]
	public void set_management_address(
		long [] wocs,
		string [] ips
	) {
		this.Invoke("set_management_address", new object [] {
				wocs,
				ips});

	}
	public System.IAsyncResult Beginset_management_address(long [] wocs,string [] ips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_management_address", new object[] {
			wocs,
			ips}, callback, asyncState);
	}
	public void Endset_management_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_nat_source_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionLocalInterface", 
		RequestNamespace="urn:iControl:Networking/iSessionLocalInterface", ResponseNamespace="urn:iControl:Networking/iSessionLocalInterface")]
	public void set_nat_source_address(
		long [] wocs,
		NetworkingiSessionLocalInterfaceNatSourceAddress [] nat_states
	) {
		this.Invoke("set_nat_source_address", new object [] {
				wocs,
				nat_states});

	}
	public System.IAsyncResult Beginset_nat_source_address(long [] wocs,NetworkingiSessionLocalInterfaceNatSourceAddress [] nat_states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_nat_source_address", new object[] {
			wocs,
			nat_states}, callback, asyncState);
	}
	public void Endset_nat_source_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_serverssl
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionLocalInterface", 
		RequestNamespace="urn:iControl:Networking/iSessionLocalInterface", ResponseNamespace="urn:iControl:Networking/iSessionLocalInterface")]
	public void set_serverssl(
		long [] wocs,
		string [] serverssls
	) {
		this.Invoke("set_serverssl", new object [] {
				wocs,
				serverssls});

	}
	public System.IAsyncResult Beginset_serverssl(long [] wocs,string [] serverssls, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_serverssl", new object[] {
			wocs,
			serverssls}, callback, asyncState);
	}
	public void Endset_serverssl(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_tunnel_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/iSessionLocalInterface", 
		RequestNamespace="urn:iControl:Networking/iSessionLocalInterface", ResponseNamespace="urn:iControl:Networking/iSessionLocalInterface")]
	public void set_tunnel_port(
		long [] wocs,
		long [] ports
	) {
		this.Invoke("set_tunnel_port", new object [] {
				wocs,
				ports});

	}
	public System.IAsyncResult Beginset_tunnel_port(long [] wocs,long [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_tunnel_port", new object[] {
			wocs,
			ports}, callback, asyncState);
	}
	public void Endset_tunnel_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Networking.iSessionLocalInterface.NatSourceAddress", Namespace = "urn:iControl")]
	public enum NetworkingiSessionLocalInterfaceNatSourceAddress
	{
		WOC_NAT_SOURCE_ADDRESS_NONE,
		WOC_NAT_SOURCE_ADDRESS_CLIENT,
		WOC_NAT_SOURCE_ADDRESS_WOM,
		WOC_NAT_SOURCE_ADDRESS_TUNNEL,
	}

	//=======================================================================
	// Structs
	//=======================================================================

}
