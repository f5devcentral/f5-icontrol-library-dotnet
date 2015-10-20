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
	[System.Web.Services.WebServiceBindingAttribute(Name="LocalLB.MessageRoutingPeerBinding", Namespace="urn:iControl")]
	public partial class LocalLBMessageRoutingPeer : iControlInterface {
		public LocalLBMessageRoutingPeer() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingPeer", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingPeer", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingPeer")]
	public void create(
		string [] peers,
		LocalLBMessageRoutingProtocol [] protocols
	) {
		this.Invoke("create", new object [] {
				peers,
				protocols});

	}
	public System.IAsyncResult Begincreate(string [] peers,LocalLBMessageRoutingProtocol [] protocols, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			peers,
			protocols}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_peers
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingPeer", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingPeer", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingPeer")]
	public void delete_all_peers(

	) {
		this.Invoke("delete_all_peers", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_peers(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_peers", new object[0], callback, asyncState);
	}
	public void Enddelete_all_peers(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_peer
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingPeer", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingPeer", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingPeer")]
	public void delete_peer(
		string [] peers
	) {
		this.Invoke("delete_peer", new object [] {
				peers});

	}
	public System.IAsyncResult Begindelete_peer(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_peer", new object[] {
			peers}, callback, asyncState);
	}
	public void Enddelete_peer(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_connection_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingPeer", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingPeer", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingPeer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBMessageRoutingPeerConnectionMode [] get_connection_mode(
		string [] peers
	) {
		object [] results = this.Invoke("get_connection_mode", new object [] {
				peers});
		return ((LocalLBMessageRoutingPeerConnectionMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_connection_mode(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_connection_mode", new object[] {
			peers}, callback, asyncState);
	}
	public LocalLBMessageRoutingPeerConnectionMode [] Endget_connection_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBMessageRoutingPeerConnectionMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingPeer", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingPeer", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingPeer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] peers
	) {
		object [] results = this.Invoke("get_description", new object [] {
				peers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			peers}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingPeer", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingPeer", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingPeer")]
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
	// get_number_connections
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingPeer", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingPeer", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingPeer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_number_connections(
		string [] peers
	) {
		object [] results = this.Invoke("get_number_connections", new object [] {
				peers});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_number_connections(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_number_connections", new object[] {
			peers}, callback, asyncState);
	}
	public long [] Endget_number_connections(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingPeer", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingPeer", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingPeer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_pool(
		string [] peers
	) {
		object [] results = this.Invoke("get_pool", new object [] {
				peers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_pool(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_pool", new object[] {
			peers}, callback, asyncState);
	}
	public string [] Endget_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_protocol
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingPeer", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingPeer", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingPeer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public LocalLBMessageRoutingProtocol [] get_protocol(
		string [] peers
	) {
		object [] results = this.Invoke("get_protocol", new object [] {
				peers});
		return ((LocalLBMessageRoutingProtocol [])(results[0]));
	}
	public System.IAsyncResult Beginget_protocol(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_protocol", new object[] {
			peers}, callback, asyncState);
	}
	public LocalLBMessageRoutingProtocol [] Endget_protocol(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((LocalLBMessageRoutingProtocol [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ratio
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingPeer", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingPeer", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingPeer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_ratio(
		string [] peers
	) {
		object [] results = this.Invoke("get_ratio", new object [] {
				peers});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_ratio(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ratio", new object[] {
			peers}, callback, asyncState);
	}
	public long [] Endget_ratio(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_transport_config
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingPeer", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingPeer", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingPeer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_transport_config(
		string [] peers
	) {
		object [] results = this.Invoke("get_transport_config", new object [] {
				peers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_transport_config(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_transport_config", new object[] {
			peers}, callback, asyncState);
	}
	public string [] Endget_transport_config(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingPeer", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingPeer", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingPeer")]
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
	// set_connection_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingPeer", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingPeer", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingPeer")]
	public void set_connection_mode(
		string [] peers,
		LocalLBMessageRoutingPeerConnectionMode [] modes
	) {
		this.Invoke("set_connection_mode", new object [] {
				peers,
				modes});

	}
	public System.IAsyncResult Beginset_connection_mode(string [] peers,LocalLBMessageRoutingPeerConnectionMode [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_connection_mode", new object[] {
			peers,
			modes}, callback, asyncState);
	}
	public void Endset_connection_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingPeer", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingPeer", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingPeer")]
	public void set_description(
		string [] peers,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				peers,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] peers,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			peers,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_number_connections
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingPeer", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingPeer", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingPeer")]
	public void set_number_connections(
		string [] peers,
		long [] values
	) {
		this.Invoke("set_number_connections", new object [] {
				peers,
				values});

	}
	public System.IAsyncResult Beginset_number_connections(string [] peers,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_number_connections", new object[] {
			peers,
			values}, callback, asyncState);
	}
	public void Endset_number_connections(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_pool
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingPeer", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingPeer", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingPeer")]
	public void set_pool(
		string [] peers,
		string [] pools
	) {
		this.Invoke("set_pool", new object [] {
				peers,
				pools});

	}
	public System.IAsyncResult Beginset_pool(string [] peers,string [] pools, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_pool", new object[] {
			peers,
			pools}, callback, asyncState);
	}
	public void Endset_pool(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ratio
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingPeer", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingPeer", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingPeer")]
	public void set_ratio(
		string [] peers,
		long [] values
	) {
		this.Invoke("set_ratio", new object [] {
				peers,
				values});

	}
	public System.IAsyncResult Beginset_ratio(string [] peers,long [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ratio", new object[] {
			peers,
			values}, callback, asyncState);
	}
	public void Endset_ratio(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_transport_config
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:LocalLB/MessageRoutingPeer", 
		RequestNamespace="urn:iControl:LocalLB/MessageRoutingPeer", ResponseNamespace="urn:iControl:LocalLB/MessageRoutingPeer")]
	public void set_transport_config(
		string [] peers,
		string [] transport_configs
	) {
		this.Invoke("set_transport_config", new object [] {
				peers,
				transport_configs});

	}
	public System.IAsyncResult Beginset_transport_config(string [] peers,string [] transport_configs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_transport_config", new object[] {
			peers,
			transport_configs}, callback, asyncState);
	}
	public void Endset_transport_config(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "LocalLB.MessageRoutingPeer.ConnectionMode", Namespace = "urn:iControl")]
	public enum LocalLBMessageRoutingPeerConnectionMode
	{
		CONNECTION_MODE_UNKNOWN,
		CONNECTION_MODE_PER_PEER,
		CONNECTION_MODE_PER_BLADE,
		CONNECTION_MODE_PER_TMM,
		CONNECTION_MODE_PER_CLIENT,
	}

	//=======================================================================
	// Structs
	//=======================================================================

}
