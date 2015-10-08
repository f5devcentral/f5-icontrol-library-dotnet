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
	[System.Web.Services.WebServiceBindingAttribute(Name="Networking.IPsecIkePeerBinding", Namespace="urn:iControl")]
	public partial class NetworkingIPsecIkePeer : iControlInterface {
		public NetworkingIPsecIkePeer() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	public void create(
		string [] peers,
		string [] files,
		string [] keys,
		string [] addresses
	) {
		this.Invoke("create", new object [] {
				peers,
				files,
				keys,
				addresses});

	}
	public System.IAsyncResult Begincreate(string [] peers,string [] files,string [] keys,string [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			peers,
			files,
			keys,
			addresses}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_ike_peers
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	public void delete_all_ike_peers(

	) {
		this.Invoke("delete_all_ike_peers", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_ike_peers(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_ike_peers", new object[0], callback, asyncState);
	}
	public void Enddelete_all_ike_peers(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_ike_peer
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	public void delete_ike_peer(
		string [] peers
	) {
		this.Invoke("delete_ike_peer", new object [] {
				peers});

	}
	public System.IAsyncResult Begindelete_ike_peer(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_ike_peer", new object[] {
			peers}, callback, asyncState);
	}
	public void Enddelete_ike_peer(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_ca_certificate_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_ca_certificate_file(
		string [] peers
	) {
		object [] results = this.Invoke("get_ca_certificate_file", new object [] {
				peers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_ca_certificate_file(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ca_certificate_file", new object[] {
			peers}, callback, asyncState);
	}
	public string [] Endget_ca_certificate_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_certificate_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingIPsecIkePeerCertType [] get_certificate_type(
		string [] peers
	) {
		object [] results = this.Invoke("get_certificate_type", new object [] {
				peers});
		return ((NetworkingIPsecIkePeerCertType [])(results[0]));
	}
	public System.IAsyncResult Beginget_certificate_type(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_certificate_type", new object[] {
			peers}, callback, asyncState);
	}
	public NetworkingIPsecIkePeerCertType [] Endget_certificate_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingIPsecIkePeerCertType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_crl_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_crl_file(
		string [] peers
	) {
		object [] results = this.Invoke("get_crl_file", new object [] {
				peers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_crl_file(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_crl_file", new object[] {
			peers}, callback, asyncState);
	}
	public string [] Endget_crl_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
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
	// get_dpd_delay
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_dpd_delay(
		string [] peers
	) {
		object [] results = this.Invoke("get_dpd_delay", new object [] {
				peers});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_dpd_delay(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dpd_delay", new object[] {
			peers}, callback, asyncState);
	}
	public long [] Endget_dpd_delay(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_enabled_state(
		string [] peers
	) {
		object [] results = this.Invoke("get_enabled_state", new object [] {
				peers});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_enabled_state(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_enabled_state", new object[] {
			peers}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_generate_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingIPsecIkePeerGeneratePolicy [] get_generate_policy(
		string [] peers
	) {
		object [] results = this.Invoke("get_generate_policy", new object [] {
				peers});
		return ((NetworkingIPsecIkePeerGeneratePolicy [])(results[0]));
	}
	public System.IAsyncResult Beginget_generate_policy(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_generate_policy", new object[] {
			peers}, callback, asyncState);
	}
	public NetworkingIPsecIkePeerGeneratePolicy [] Endget_generate_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingIPsecIkePeerGeneratePolicy [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ike_proposal_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_ike_proposal_name(
		string [] peers
	) {
		object [] results = this.Invoke("get_ike_proposal_name", new object [] {
				peers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_ike_proposal_name(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ike_proposal_name", new object[] {
			peers}, callback, asyncState);
	}
	public string [] Endget_ike_proposal_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_lifetime
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_lifetime(
		string [] peers
	) {
		object [] results = this.Invoke("get_lifetime", new object [] {
				peers});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_lifetime(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_lifetime", new object[] {
			peers}, callback, asyncState);
	}
	public long [] Endget_lifetime(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
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
	// get_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingIPsecIkePeerMode [] get_mode(
		string [] peers
	) {
		object [] results = this.Invoke("get_mode", new object [] {
				peers});
		return ((NetworkingIPsecIkePeerMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_mode(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_mode", new object[] {
			peers}, callback, asyncState);
	}
	public NetworkingIPsecIkePeerMode [] Endget_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingIPsecIkePeerMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_my_certificate_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_my_certificate_file(
		string [] peers
	) {
		object [] results = this.Invoke("get_my_certificate_file", new object [] {
				peers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_my_certificate_file(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_my_certificate_file", new object[] {
			peers}, callback, asyncState);
	}
	public string [] Endget_my_certificate_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_my_certificate_key_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_my_certificate_key_file(
		string [] peers
	) {
		object [] results = this.Invoke("get_my_certificate_key_file", new object [] {
				peers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_my_certificate_key_file(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_my_certificate_key_file", new object[] {
			peers}, callback, asyncState);
	}
	public string [] Endget_my_certificate_key_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_my_id_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingIPsecIkePeerIDType [] get_my_id_type(
		string [] peers
	) {
		object [] results = this.Invoke("get_my_id_type", new object [] {
				peers});
		return ((NetworkingIPsecIkePeerIDType [])(results[0]));
	}
	public System.IAsyncResult Beginget_my_id_type(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_my_id_type", new object[] {
			peers}, callback, asyncState);
	}
	public NetworkingIPsecIkePeerIDType [] Endget_my_id_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingIPsecIkePeerIDType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_my_id_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_my_id_value(
		string [] peers
	) {
		object [] results = this.Invoke("get_my_id_value", new object [] {
				peers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_my_id_value(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_my_id_value", new object[] {
			peers}, callback, asyncState);
	}
	public string [] Endget_my_id_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_nat_traversal
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingIPsecIkePeerNatTraversal [] get_nat_traversal(
		string [] peers
	) {
		object [] results = this.Invoke("get_nat_traversal", new object [] {
				peers});
		return ((NetworkingIPsecIkePeerNatTraversal [])(results[0]));
	}
	public System.IAsyncResult Beginget_nat_traversal(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_nat_traversal", new object[] {
			peers}, callback, asyncState);
	}
	public NetworkingIPsecIkePeerNatTraversal [] Endget_nat_traversal(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingIPsecIkePeerNatTraversal [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_passive_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_passive_state(
		string [] peers
	) {
		object [] results = this.Invoke("get_passive_state", new object [] {
				peers});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_passive_state(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_passive_state", new object[] {
			peers}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_passive_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_peer_certificate_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_peer_certificate_file(
		string [] peers
	) {
		object [] results = this.Invoke("get_peer_certificate_file", new object [] {
				peers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_peer_certificate_file(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_peer_certificate_file", new object[] {
			peers}, callback, asyncState);
	}
	public string [] Endget_peer_certificate_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_peer_id_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingIPsecIkePeerIDType [] get_peer_id_type(
		string [] peers
	) {
		object [] results = this.Invoke("get_peer_id_type", new object [] {
				peers});
		return ((NetworkingIPsecIkePeerIDType [])(results[0]));
	}
	public System.IAsyncResult Beginget_peer_id_type(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_peer_id_type", new object[] {
			peers}, callback, asyncState);
	}
	public NetworkingIPsecIkePeerIDType [] Endget_peer_id_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingIPsecIkePeerIDType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_peer_id_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_peer_id_value(
		string [] peers
	) {
		object [] results = this.Invoke("get_peer_id_value", new object [] {
				peers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_peer_id_value(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_peer_id_value", new object[] {
			peers}, callback, asyncState);
	}
	public string [] Endget_peer_id_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_phase1_auth_method
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingIPsecSaMethod [] get_phase1_auth_method(
		string [] peers
	) {
		object [] results = this.Invoke("get_phase1_auth_method", new object [] {
				peers});
		return ((NetworkingIPsecSaMethod [])(results[0]));
	}
	public System.IAsyncResult Beginget_phase1_auth_method(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_phase1_auth_method", new object[] {
			peers}, callback, asyncState);
	}
	public NetworkingIPsecSaMethod [] Endget_phase1_auth_method(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingIPsecSaMethod [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_phase1_encryption_algorithm
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingIPsecIkeEncrAlgorithm [] get_phase1_encryption_algorithm(
		string [] peers
	) {
		object [] results = this.Invoke("get_phase1_encryption_algorithm", new object [] {
				peers});
		return ((NetworkingIPsecIkeEncrAlgorithm [])(results[0]));
	}
	public System.IAsyncResult Beginget_phase1_encryption_algorithm(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_phase1_encryption_algorithm", new object[] {
			peers}, callback, asyncState);
	}
	public NetworkingIPsecIkeEncrAlgorithm [] Endget_phase1_encryption_algorithm(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingIPsecIkeEncrAlgorithm [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_phase1_hash_algorithm
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingIPsecIkeHashAlgorithm [] get_phase1_hash_algorithm(
		string [] peers
	) {
		object [] results = this.Invoke("get_phase1_hash_algorithm", new object [] {
				peers});
		return ((NetworkingIPsecIkeHashAlgorithm [])(results[0]));
	}
	public System.IAsyncResult Beginget_phase1_hash_algorithm(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_phase1_hash_algorithm", new object[] {
			peers}, callback, asyncState);
	}
	public NetworkingIPsecIkeHashAlgorithm [] Endget_phase1_hash_algorithm(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingIPsecIkeHashAlgorithm [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_phase1_perfect_forward_secrecy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingIPsecDiffieHellmanGroup [] get_phase1_perfect_forward_secrecy(
		string [] peers
	) {
		object [] results = this.Invoke("get_phase1_perfect_forward_secrecy", new object [] {
				peers});
		return ((NetworkingIPsecDiffieHellmanGroup [])(results[0]));
	}
	public System.IAsyncResult Beginget_phase1_perfect_forward_secrecy(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_phase1_perfect_forward_secrecy", new object[] {
			peers}, callback, asyncState);
	}
	public NetworkingIPsecDiffieHellmanGroup [] Endget_phase1_perfect_forward_secrecy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingIPsecDiffieHellmanGroup [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_preshared_key
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_preshared_key(
		string [] peers
	) {
		object [] results = this.Invoke("get_preshared_key", new object [] {
				peers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_preshared_key(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_preshared_key", new object[] {
			peers}, callback, asyncState);
	}
	public string [] Endget_preshared_key(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_preshared_key_encrypted
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_preshared_key_encrypted(
		string [] peers
	) {
		object [] results = this.Invoke("get_preshared_key_encrypted", new object [] {
				peers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_preshared_key_encrypted(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_preshared_key_encrypted", new object[] {
			peers}, callback, asyncState);
	}
	public string [] Endget_preshared_key_encrypted(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_proxy_support_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_proxy_support_state(
		string [] peers
	) {
		object [] results = this.Invoke("get_proxy_support_state", new object [] {
				peers});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_proxy_support_state(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_proxy_support_state", new object[] {
			peers}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_proxy_support_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_remote_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_remote_address(
		string [] peers
	) {
		object [] results = this.Invoke("get_remote_address", new object [] {
				peers});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_remote_address(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_remote_address", new object[] {
			peers}, callback, asyncState);
	}
	public string [] Endget_remote_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_replay_window_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_replay_window_size(
		string [] peers
	) {
		object [] results = this.Invoke("get_replay_window_size", new object [] {
				peers});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_replay_window_size(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_replay_window_size", new object[] {
			peers}, callback, asyncState);
	}
	public long [] Endget_replay_window_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_verify_certificate_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_verify_certificate_state(
		string [] peers
	) {
		object [] results = this.Invoke("get_verify_certificate_state", new object [] {
				peers});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_verify_certificate_state(string [] peers, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_verify_certificate_state", new object[] {
			peers}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_verify_certificate_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
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
	// set_ca_certificate_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	public void set_ca_certificate_file(
		string [] peers,
		string [] files
	) {
		this.Invoke("set_ca_certificate_file", new object [] {
				peers,
				files});

	}
	public System.IAsyncResult Beginset_ca_certificate_file(string [] peers,string [] files, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ca_certificate_file", new object[] {
			peers,
			files}, callback, asyncState);
	}
	public void Endset_ca_certificate_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_certificate_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	public void set_certificate_type(
		string [] peers,
		NetworkingIPsecIkePeerCertType [] types
	) {
		this.Invoke("set_certificate_type", new object [] {
				peers,
				types});

	}
	public System.IAsyncResult Beginset_certificate_type(string [] peers,NetworkingIPsecIkePeerCertType [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_certificate_type", new object[] {
			peers,
			types}, callback, asyncState);
	}
	public void Endset_certificate_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_crl_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	public void set_crl_file(
		string [] peers,
		string [] files
	) {
		this.Invoke("set_crl_file", new object [] {
				peers,
				files});

	}
	public System.IAsyncResult Beginset_crl_file(string [] peers,string [] files, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_crl_file", new object[] {
			peers,
			files}, callback, asyncState);
	}
	public void Endset_crl_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
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
	// set_dpd_delay
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	public void set_dpd_delay(
		string [] peers,
		long [] delays
	) {
		this.Invoke("set_dpd_delay", new object [] {
				peers,
				delays});

	}
	public System.IAsyncResult Beginset_dpd_delay(string [] peers,long [] delays, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dpd_delay", new object[] {
			peers,
			delays}, callback, asyncState);
	}
	public void Endset_dpd_delay(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	public void set_enabled_state(
		string [] peers,
		CommonEnabledState [] states
	) {
		this.Invoke("set_enabled_state", new object [] {
				peers,
				states});

	}
	public System.IAsyncResult Beginset_enabled_state(string [] peers,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_enabled_state", new object[] {
			peers,
			states}, callback, asyncState);
	}
	public void Endset_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_generate_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	public void set_generate_policy(
		string [] peers,
		NetworkingIPsecIkePeerGeneratePolicy [] policies
	) {
		this.Invoke("set_generate_policy", new object [] {
				peers,
				policies});

	}
	public System.IAsyncResult Beginset_generate_policy(string [] peers,NetworkingIPsecIkePeerGeneratePolicy [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_generate_policy", new object[] {
			peers,
			policies}, callback, asyncState);
	}
	public void Endset_generate_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ike_proposal_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	public void set_ike_proposal_name(
		string [] peers,
		string [] names
	) {
		this.Invoke("set_ike_proposal_name", new object [] {
				peers,
				names});

	}
	public System.IAsyncResult Beginset_ike_proposal_name(string [] peers,string [] names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ike_proposal_name", new object[] {
			peers,
			names}, callback, asyncState);
	}
	public void Endset_ike_proposal_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_lifetime
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	public void set_lifetime(
		string [] peers,
		long [] lifetimes
	) {
		this.Invoke("set_lifetime", new object [] {
				peers,
				lifetimes});

	}
	public System.IAsyncResult Beginset_lifetime(string [] peers,long [] lifetimes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_lifetime", new object[] {
			peers,
			lifetimes}, callback, asyncState);
	}
	public void Endset_lifetime(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	public void set_mode(
		string [] peers,
		NetworkingIPsecIkePeerMode [] modes
	) {
		this.Invoke("set_mode", new object [] {
				peers,
				modes});

	}
	public System.IAsyncResult Beginset_mode(string [] peers,NetworkingIPsecIkePeerMode [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_mode", new object[] {
			peers,
			modes}, callback, asyncState);
	}
	public void Endset_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_my_certificate_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	public void set_my_certificate_file(
		string [] peers,
		string [] files
	) {
		this.Invoke("set_my_certificate_file", new object [] {
				peers,
				files});

	}
	public System.IAsyncResult Beginset_my_certificate_file(string [] peers,string [] files, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_my_certificate_file", new object[] {
			peers,
			files}, callback, asyncState);
	}
	public void Endset_my_certificate_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_my_certificate_key_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	public void set_my_certificate_key_file(
		string [] peers,
		string [] files
	) {
		this.Invoke("set_my_certificate_key_file", new object [] {
				peers,
				files});

	}
	public System.IAsyncResult Beginset_my_certificate_key_file(string [] peers,string [] files, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_my_certificate_key_file", new object[] {
			peers,
			files}, callback, asyncState);
	}
	public void Endset_my_certificate_key_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_my_id_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	public void set_my_id_type(
		string [] peers,
		NetworkingIPsecIkePeerIDType [] types
	) {
		this.Invoke("set_my_id_type", new object [] {
				peers,
				types});

	}
	public System.IAsyncResult Beginset_my_id_type(string [] peers,NetworkingIPsecIkePeerIDType [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_my_id_type", new object[] {
			peers,
			types}, callback, asyncState);
	}
	public void Endset_my_id_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_my_id_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	public void set_my_id_value(
		string [] peers,
		string [] values
	) {
		this.Invoke("set_my_id_value", new object [] {
				peers,
				values});

	}
	public System.IAsyncResult Beginset_my_id_value(string [] peers,string [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_my_id_value", new object[] {
			peers,
			values}, callback, asyncState);
	}
	public void Endset_my_id_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_nat_traversal
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	public void set_nat_traversal(
		string [] peers,
		NetworkingIPsecIkePeerNatTraversal [] nat_traversals
	) {
		this.Invoke("set_nat_traversal", new object [] {
				peers,
				nat_traversals});

	}
	public System.IAsyncResult Beginset_nat_traversal(string [] peers,NetworkingIPsecIkePeerNatTraversal [] nat_traversals, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_nat_traversal", new object[] {
			peers,
			nat_traversals}, callback, asyncState);
	}
	public void Endset_nat_traversal(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_passive_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	public void set_passive_state(
		string [] peers,
		CommonEnabledState [] states
	) {
		this.Invoke("set_passive_state", new object [] {
				peers,
				states});

	}
	public System.IAsyncResult Beginset_passive_state(string [] peers,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_passive_state", new object[] {
			peers,
			states}, callback, asyncState);
	}
	public void Endset_passive_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_peer_certificate_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	public void set_peer_certificate_file(
		string [] peers,
		string [] files
	) {
		this.Invoke("set_peer_certificate_file", new object [] {
				peers,
				files});

	}
	public System.IAsyncResult Beginset_peer_certificate_file(string [] peers,string [] files, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_peer_certificate_file", new object[] {
			peers,
			files}, callback, asyncState);
	}
	public void Endset_peer_certificate_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_peer_id_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	public void set_peer_id_type(
		string [] peers,
		NetworkingIPsecIkePeerIDType [] types
	) {
		this.Invoke("set_peer_id_type", new object [] {
				peers,
				types});

	}
	public System.IAsyncResult Beginset_peer_id_type(string [] peers,NetworkingIPsecIkePeerIDType [] types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_peer_id_type", new object[] {
			peers,
			types}, callback, asyncState);
	}
	public void Endset_peer_id_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_peer_id_value
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	public void set_peer_id_value(
		string [] peers,
		string [] values
	) {
		this.Invoke("set_peer_id_value", new object [] {
				peers,
				values});

	}
	public System.IAsyncResult Beginset_peer_id_value(string [] peers,string [] values, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_peer_id_value", new object[] {
			peers,
			values}, callback, asyncState);
	}
	public void Endset_peer_id_value(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_phase1_auth_method
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	public void set_phase1_auth_method(
		string [] peers,
		NetworkingIPsecSaMethod [] methods
	) {
		this.Invoke("set_phase1_auth_method", new object [] {
				peers,
				methods});

	}
	public System.IAsyncResult Beginset_phase1_auth_method(string [] peers,NetworkingIPsecSaMethod [] methods, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_phase1_auth_method", new object[] {
			peers,
			methods}, callback, asyncState);
	}
	public void Endset_phase1_auth_method(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_phase1_encryption_algorithm
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	public void set_phase1_encryption_algorithm(
		string [] peers,
		NetworkingIPsecIkeEncrAlgorithm [] algorithms
	) {
		this.Invoke("set_phase1_encryption_algorithm", new object [] {
				peers,
				algorithms});

	}
	public System.IAsyncResult Beginset_phase1_encryption_algorithm(string [] peers,NetworkingIPsecIkeEncrAlgorithm [] algorithms, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_phase1_encryption_algorithm", new object[] {
			peers,
			algorithms}, callback, asyncState);
	}
	public void Endset_phase1_encryption_algorithm(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_phase1_hash_algorithm
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	public void set_phase1_hash_algorithm(
		string [] peers,
		NetworkingIPsecIkeHashAlgorithm [] algorithms
	) {
		this.Invoke("set_phase1_hash_algorithm", new object [] {
				peers,
				algorithms});

	}
	public System.IAsyncResult Beginset_phase1_hash_algorithm(string [] peers,NetworkingIPsecIkeHashAlgorithm [] algorithms, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_phase1_hash_algorithm", new object[] {
			peers,
			algorithms}, callback, asyncState);
	}
	public void Endset_phase1_hash_algorithm(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_phase1_perfect_forward_secrecy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	public void set_phase1_perfect_forward_secrecy(
		string [] peers,
		NetworkingIPsecDiffieHellmanGroup [] secrecies
	) {
		this.Invoke("set_phase1_perfect_forward_secrecy", new object [] {
				peers,
				secrecies});

	}
	public System.IAsyncResult Beginset_phase1_perfect_forward_secrecy(string [] peers,NetworkingIPsecDiffieHellmanGroup [] secrecies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_phase1_perfect_forward_secrecy", new object[] {
			peers,
			secrecies}, callback, asyncState);
	}
	public void Endset_phase1_perfect_forward_secrecy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_preshared_key
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	public void set_preshared_key(
		string [] peers,
		string [] keys
	) {
		this.Invoke("set_preshared_key", new object [] {
				peers,
				keys});

	}
	public System.IAsyncResult Beginset_preshared_key(string [] peers,string [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_preshared_key", new object[] {
			peers,
			keys}, callback, asyncState);
	}
	public void Endset_preshared_key(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_preshared_key_encrypted
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	public void set_preshared_key_encrypted(
		string [] peers,
		string [] keys
	) {
		this.Invoke("set_preshared_key_encrypted", new object [] {
				peers,
				keys});

	}
	public System.IAsyncResult Beginset_preshared_key_encrypted(string [] peers,string [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_preshared_key_encrypted", new object[] {
			peers,
			keys}, callback, asyncState);
	}
	public void Endset_preshared_key_encrypted(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_proxy_support_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	public void set_proxy_support_state(
		string [] peers,
		CommonEnabledState [] states
	) {
		this.Invoke("set_proxy_support_state", new object [] {
				peers,
				states});

	}
	public System.IAsyncResult Beginset_proxy_support_state(string [] peers,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_proxy_support_state", new object[] {
			peers,
			states}, callback, asyncState);
	}
	public void Endset_proxy_support_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_remote_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	public void set_remote_address(
		string [] peers,
		string [] addresses
	) {
		this.Invoke("set_remote_address", new object [] {
				peers,
				addresses});

	}
	public System.IAsyncResult Beginset_remote_address(string [] peers,string [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_remote_address", new object[] {
			peers,
			addresses}, callback, asyncState);
	}
	public void Endset_remote_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_replay_window_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	public void set_replay_window_size(
		string [] peers,
		long [] sizes
	) {
		this.Invoke("set_replay_window_size", new object [] {
				peers,
				sizes});

	}
	public System.IAsyncResult Beginset_replay_window_size(string [] peers,long [] sizes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_replay_window_size", new object[] {
			peers,
			sizes}, callback, asyncState);
	}
	public void Endset_replay_window_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_verify_certificate_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecIkePeer", 
		RequestNamespace="urn:iControl:Networking/IPsecIkePeer", ResponseNamespace="urn:iControl:Networking/IPsecIkePeer")]
	public void set_verify_certificate_state(
		string [] peers,
		CommonEnabledState [] states
	) {
		this.Invoke("set_verify_certificate_state", new object [] {
				peers,
				states});

	}
	public System.IAsyncResult Beginset_verify_certificate_state(string [] peers,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_verify_certificate_state", new object[] {
			peers,
			states}, callback, asyncState);
	}
	public void Endset_verify_certificate_state(System.IAsyncResult asyncResult) {
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
