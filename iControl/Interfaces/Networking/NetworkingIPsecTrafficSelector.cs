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
	[System.Web.Services.WebServiceBindingAttribute(Name="Networking.IPsecTrafficSelectorBinding", Namespace="urn:iControl")]
	public partial class NetworkingIPsecTrafficSelector : iControlInterface {
		public NetworkingIPsecTrafficSelector() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecTrafficSelector", 
		RequestNamespace="urn:iControl:Networking/IPsecTrafficSelector", ResponseNamespace="urn:iControl:Networking/IPsecTrafficSelector")]
	public void create(
		string [] selectors,
		string [] src_addresses,
		string [] src_netmasks,
		string [] dst_addresses,
		string [] dst_netmasks
	) {
		this.Invoke("create", new object [] {
				selectors,
				src_addresses,
				src_netmasks,
				dst_addresses,
				dst_netmasks});

	}
	public System.IAsyncResult Begincreate(string [] selectors,string [] src_addresses,string [] src_netmasks,string [] dst_addresses,string [] dst_netmasks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			selectors,
			src_addresses,
			src_netmasks,
			dst_addresses,
			dst_netmasks}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_traffic_selectors
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecTrafficSelector", 
		RequestNamespace="urn:iControl:Networking/IPsecTrafficSelector", ResponseNamespace="urn:iControl:Networking/IPsecTrafficSelector")]
	public void delete_all_traffic_selectors(

	) {
		this.Invoke("delete_all_traffic_selectors", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_traffic_selectors(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_traffic_selectors", new object[0], callback, asyncState);
	}
	public void Enddelete_all_traffic_selectors(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_traffic_selector
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecTrafficSelector", 
		RequestNamespace="urn:iControl:Networking/IPsecTrafficSelector", ResponseNamespace="urn:iControl:Networking/IPsecTrafficSelector")]
	public void delete_traffic_selector(
		string [] selectors
	) {
		this.Invoke("delete_traffic_selector", new object [] {
				selectors});

	}
	public System.IAsyncResult Begindelete_traffic_selector(string [] selectors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_traffic_selector", new object[] {
			selectors}, callback, asyncState);
	}
	public void Enddelete_traffic_selector(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecTrafficSelector", 
		RequestNamespace="urn:iControl:Networking/IPsecTrafficSelector", ResponseNamespace="urn:iControl:Networking/IPsecTrafficSelector")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingIPsecTrafficSelectorAction [] get_action(
		string [] selectors
	) {
		object [] results = this.Invoke("get_action", new object [] {
				selectors});
		return ((NetworkingIPsecTrafficSelectorAction [])(results[0]));
	}
	public System.IAsyncResult Beginget_action(string [] selectors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_action", new object[] {
			selectors}, callback, asyncState);
	}
	public NetworkingIPsecTrafficSelectorAction [] Endget_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingIPsecTrafficSelectorAction [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecTrafficSelector", 
		RequestNamespace="urn:iControl:Networking/IPsecTrafficSelector", ResponseNamespace="urn:iControl:Networking/IPsecTrafficSelector")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] selectors
	) {
		object [] results = this.Invoke("get_description", new object [] {
				selectors});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] selectors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			selectors}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_destination_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecTrafficSelector", 
		RequestNamespace="urn:iControl:Networking/IPsecTrafficSelector", ResponseNamespace="urn:iControl:Networking/IPsecTrafficSelector")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_destination_address(
		string [] selectors
	) {
		object [] results = this.Invoke("get_destination_address", new object [] {
				selectors});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_destination_address(string [] selectors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_destination_address", new object[] {
			selectors}, callback, asyncState);
	}
	public string [] Endget_destination_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_destination_netmask
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecTrafficSelector", 
		RequestNamespace="urn:iControl:Networking/IPsecTrafficSelector", ResponseNamespace="urn:iControl:Networking/IPsecTrafficSelector")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_destination_netmask(
		string [] selectors
	) {
		object [] results = this.Invoke("get_destination_netmask", new object [] {
				selectors});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_destination_netmask(string [] selectors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_destination_netmask", new object[] {
			selectors}, callback, asyncState);
	}
	public string [] Endget_destination_netmask(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_destination_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecTrafficSelector", 
		RequestNamespace="urn:iControl:Networking/IPsecTrafficSelector", ResponseNamespace="urn:iControl:Networking/IPsecTrafficSelector")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_destination_port(
		string [] selectors
	) {
		object [] results = this.Invoke("get_destination_port", new object [] {
				selectors});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_destination_port(string [] selectors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_destination_port", new object[] {
			selectors}, callback, asyncState);
	}
	public long [] Endget_destination_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_direction
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecTrafficSelector", 
		RequestNamespace="urn:iControl:Networking/IPsecTrafficSelector", ResponseNamespace="urn:iControl:Networking/IPsecTrafficSelector")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingIPsecDirection [] get_direction(
		string [] selectors
	) {
		object [] results = this.Invoke("get_direction", new object [] {
				selectors});
		return ((NetworkingIPsecDirection [])(results[0]));
	}
	public System.IAsyncResult Beginget_direction(string [] selectors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_direction", new object[] {
			selectors}, callback, asyncState);
	}
	public NetworkingIPsecDirection [] Endget_direction(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingIPsecDirection [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ip_protocol
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecTrafficSelector", 
		RequestNamespace="urn:iControl:Networking/IPsecTrafficSelector", ResponseNamespace="urn:iControl:Networking/IPsecTrafficSelector")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_ip_protocol(
		string [] selectors
	) {
		object [] results = this.Invoke("get_ip_protocol", new object [] {
				selectors});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_ip_protocol(string [] selectors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ip_protocol", new object[] {
			selectors}, callback, asyncState);
	}
	public long [] Endget_ip_protocol(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecTrafficSelector", 
		RequestNamespace="urn:iControl:Networking/IPsecTrafficSelector", ResponseNamespace="urn:iControl:Networking/IPsecTrafficSelector")]
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
	// get_order
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecTrafficSelector", 
		RequestNamespace="urn:iControl:Networking/IPsecTrafficSelector", ResponseNamespace="urn:iControl:Networking/IPsecTrafficSelector")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_order(
		string [] selectors
	) {
		object [] results = this.Invoke("get_order", new object [] {
				selectors});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_order(string [] selectors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_order", new object[] {
			selectors}, callback, asyncState);
	}
	public long [] Endget_order(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecTrafficSelector", 
		RequestNamespace="urn:iControl:Networking/IPsecTrafficSelector", ResponseNamespace="urn:iControl:Networking/IPsecTrafficSelector")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_policy(
		string [] selectors
	) {
		object [] results = this.Invoke("get_policy", new object [] {
				selectors});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_policy(string [] selectors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_policy", new object[] {
			selectors}, callback, asyncState);
	}
	public string [] Endget_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_source_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecTrafficSelector", 
		RequestNamespace="urn:iControl:Networking/IPsecTrafficSelector", ResponseNamespace="urn:iControl:Networking/IPsecTrafficSelector")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_source_address(
		string [] selectors
	) {
		object [] results = this.Invoke("get_source_address", new object [] {
				selectors});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_source_address(string [] selectors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_source_address", new object[] {
			selectors}, callback, asyncState);
	}
	public string [] Endget_source_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_source_netmask
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecTrafficSelector", 
		RequestNamespace="urn:iControl:Networking/IPsecTrafficSelector", ResponseNamespace="urn:iControl:Networking/IPsecTrafficSelector")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_source_netmask(
		string [] selectors
	) {
		object [] results = this.Invoke("get_source_netmask", new object [] {
				selectors});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_source_netmask(string [] selectors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_source_netmask", new object[] {
			selectors}, callback, asyncState);
	}
	public string [] Endget_source_netmask(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_source_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecTrafficSelector", 
		RequestNamespace="urn:iControl:Networking/IPsecTrafficSelector", ResponseNamespace="urn:iControl:Networking/IPsecTrafficSelector")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_source_port(
		string [] selectors
	) {
		object [] results = this.Invoke("get_source_port", new object [] {
				selectors});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_source_port(string [] selectors, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_source_port", new object[] {
			selectors}, callback, asyncState);
	}
	public long [] Endget_source_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecTrafficSelector", 
		RequestNamespace="urn:iControl:Networking/IPsecTrafficSelector", ResponseNamespace="urn:iControl:Networking/IPsecTrafficSelector")]
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
	// set_action
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecTrafficSelector", 
		RequestNamespace="urn:iControl:Networking/IPsecTrafficSelector", ResponseNamespace="urn:iControl:Networking/IPsecTrafficSelector")]
	public void set_action(
		string [] selectors,
		NetworkingIPsecTrafficSelectorAction [] actions
	) {
		this.Invoke("set_action", new object [] {
				selectors,
				actions});

	}
	public System.IAsyncResult Beginset_action(string [] selectors,NetworkingIPsecTrafficSelectorAction [] actions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_action", new object[] {
			selectors,
			actions}, callback, asyncState);
	}
	public void Endset_action(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecTrafficSelector", 
		RequestNamespace="urn:iControl:Networking/IPsecTrafficSelector", ResponseNamespace="urn:iControl:Networking/IPsecTrafficSelector")]
	public void set_description(
		string [] selectors,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				selectors,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] selectors,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			selectors,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_destination_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecTrafficSelector", 
		RequestNamespace="urn:iControl:Networking/IPsecTrafficSelector", ResponseNamespace="urn:iControl:Networking/IPsecTrafficSelector")]
	public void set_destination_address(
		string [] selectors,
		string [] addresses,
		string [] netmasks
	) {
		this.Invoke("set_destination_address", new object [] {
				selectors,
				addresses,
				netmasks});

	}
	public System.IAsyncResult Beginset_destination_address(string [] selectors,string [] addresses,string [] netmasks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_destination_address", new object[] {
			selectors,
			addresses,
			netmasks}, callback, asyncState);
	}
	public void Endset_destination_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_destination_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecTrafficSelector", 
		RequestNamespace="urn:iControl:Networking/IPsecTrafficSelector", ResponseNamespace="urn:iControl:Networking/IPsecTrafficSelector")]
	public void set_destination_port(
		string [] selectors,
		long [] ports
	) {
		this.Invoke("set_destination_port", new object [] {
				selectors,
				ports});

	}
	public System.IAsyncResult Beginset_destination_port(string [] selectors,long [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_destination_port", new object[] {
			selectors,
			ports}, callback, asyncState);
	}
	public void Endset_destination_port(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_direction
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecTrafficSelector", 
		RequestNamespace="urn:iControl:Networking/IPsecTrafficSelector", ResponseNamespace="urn:iControl:Networking/IPsecTrafficSelector")]
	public void set_direction(
		string [] selectors,
		NetworkingIPsecDirection [] directions
	) {
		this.Invoke("set_direction", new object [] {
				selectors,
				directions});

	}
	public System.IAsyncResult Beginset_direction(string [] selectors,NetworkingIPsecDirection [] directions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_direction", new object[] {
			selectors,
			directions}, callback, asyncState);
	}
	public void Endset_direction(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ip_protocol
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecTrafficSelector", 
		RequestNamespace="urn:iControl:Networking/IPsecTrafficSelector", ResponseNamespace="urn:iControl:Networking/IPsecTrafficSelector")]
	public void set_ip_protocol(
		string [] selectors,
		long [] ip_protocols
	) {
		this.Invoke("set_ip_protocol", new object [] {
				selectors,
				ip_protocols});

	}
	public System.IAsyncResult Beginset_ip_protocol(string [] selectors,long [] ip_protocols, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ip_protocol", new object[] {
			selectors,
			ip_protocols}, callback, asyncState);
	}
	public void Endset_ip_protocol(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_order
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecTrafficSelector", 
		RequestNamespace="urn:iControl:Networking/IPsecTrafficSelector", ResponseNamespace="urn:iControl:Networking/IPsecTrafficSelector")]
	public void set_order(
		string [] selectors,
		long [] orders
	) {
		this.Invoke("set_order", new object [] {
				selectors,
				orders});

	}
	public System.IAsyncResult Beginset_order(string [] selectors,long [] orders, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_order", new object[] {
			selectors,
			orders}, callback, asyncState);
	}
	public void Endset_order(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecTrafficSelector", 
		RequestNamespace="urn:iControl:Networking/IPsecTrafficSelector", ResponseNamespace="urn:iControl:Networking/IPsecTrafficSelector")]
	public void set_policy(
		string [] selectors,
		string [] policies
	) {
		this.Invoke("set_policy", new object [] {
				selectors,
				policies});

	}
	public System.IAsyncResult Beginset_policy(string [] selectors,string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_policy", new object[] {
			selectors,
			policies}, callback, asyncState);
	}
	public void Endset_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_source_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecTrafficSelector", 
		RequestNamespace="urn:iControl:Networking/IPsecTrafficSelector", ResponseNamespace="urn:iControl:Networking/IPsecTrafficSelector")]
	public void set_source_address(
		string [] selectors,
		string [] addresses,
		string [] netmasks
	) {
		this.Invoke("set_source_address", new object [] {
				selectors,
				addresses,
				netmasks});

	}
	public System.IAsyncResult Beginset_source_address(string [] selectors,string [] addresses,string [] netmasks, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_source_address", new object[] {
			selectors,
			addresses,
			netmasks}, callback, asyncState);
	}
	public void Endset_source_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_source_port
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecTrafficSelector", 
		RequestNamespace="urn:iControl:Networking/IPsecTrafficSelector", ResponseNamespace="urn:iControl:Networking/IPsecTrafficSelector")]
	public void set_source_port(
		string [] selectors,
		long [] ports
	) {
		this.Invoke("set_source_port", new object [] {
				selectors,
				ports});

	}
	public System.IAsyncResult Beginset_source_port(string [] selectors,long [] ports, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_source_port", new object[] {
			selectors,
			ports}, callback, asyncState);
	}
	public void Endset_source_port(System.IAsyncResult asyncResult) {
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
