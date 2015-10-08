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
	[System.Web.Services.WebServiceBindingAttribute(Name="Networking.IPsecManualSecurityAssociationBinding", Namespace="urn:iControl")]
	public partial class NetworkingIPsecManualSecurityAssociation : iControlInterface {
		public NetworkingIPsecManualSecurityAssociation() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecManualSecurityAssociation", 
		RequestNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation", ResponseNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation")]
	public void create(
		string [] associations,
		string [] addresses
	) {
		this.Invoke("create", new object [] {
				associations,
				addresses});

	}
	public System.IAsyncResult Begincreate(string [] associations,string [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			associations,
			addresses}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_manual_security_associations
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecManualSecurityAssociation", 
		RequestNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation", ResponseNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation")]
	public void delete_all_manual_security_associations(

	) {
		this.Invoke("delete_all_manual_security_associations", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_manual_security_associations(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_manual_security_associations", new object[0], callback, asyncState);
	}
	public void Enddelete_all_manual_security_associations(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_manual_security_association
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecManualSecurityAssociation", 
		RequestNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation", ResponseNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation")]
	public void delete_manual_security_association(
		string [] associations
	) {
		this.Invoke("delete_manual_security_association", new object [] {
				associations});

	}
	public System.IAsyncResult Begindelete_manual_security_association(string [] associations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_manual_security_association", new object[] {
			associations}, callback, asyncState);
	}
	public void Enddelete_manual_security_association(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_auth_algorithm
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecManualSecurityAssociation", 
		RequestNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation", ResponseNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingIPsecSaManAlgorithm [] get_auth_algorithm(
		string [] associations
	) {
		object [] results = this.Invoke("get_auth_algorithm", new object [] {
				associations});
		return ((NetworkingIPsecSaManAlgorithm [])(results[0]));
	}
	public System.IAsyncResult Beginget_auth_algorithm(string [] associations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_auth_algorithm", new object[] {
			associations}, callback, asyncState);
	}
	public NetworkingIPsecSaManAlgorithm [] Endget_auth_algorithm(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingIPsecSaManAlgorithm [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_auth_key
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecManualSecurityAssociation", 
		RequestNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation", ResponseNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_auth_key(
		string [] associations
	) {
		object [] results = this.Invoke("get_auth_key", new object [] {
				associations});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_auth_key(string [] associations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_auth_key", new object[] {
			associations}, callback, asyncState);
	}
	public string [] Endget_auth_key(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_auth_key_encrypted
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecManualSecurityAssociation", 
		RequestNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation", ResponseNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_auth_key_encrypted(
		string [] associations
	) {
		object [] results = this.Invoke("get_auth_key_encrypted", new object [] {
				associations});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_auth_key_encrypted(string [] associations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_auth_key_encrypted", new object[] {
			associations}, callback, asyncState);
	}
	public string [] Endget_auth_key_encrypted(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecManualSecurityAssociation", 
		RequestNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation", ResponseNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] associations
	) {
		object [] results = this.Invoke("get_description", new object [] {
				associations});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] associations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			associations}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_destination_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecManualSecurityAssociation", 
		RequestNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation", ResponseNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_destination_address(
		string [] associations
	) {
		object [] results = this.Invoke("get_destination_address", new object [] {
				associations});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_destination_address(string [] associations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_destination_address", new object[] {
			associations}, callback, asyncState);
	}
	public string [] Endget_destination_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_encrypt_algorithm
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecManualSecurityAssociation", 
		RequestNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation", ResponseNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingIPsecManSaEncrAlgorithm [] get_encrypt_algorithm(
		string [] associations
	) {
		object [] results = this.Invoke("get_encrypt_algorithm", new object [] {
				associations});
		return ((NetworkingIPsecManSaEncrAlgorithm [])(results[0]));
	}
	public System.IAsyncResult Beginget_encrypt_algorithm(string [] associations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_encrypt_algorithm", new object[] {
			associations}, callback, asyncState);
	}
	public NetworkingIPsecManSaEncrAlgorithm [] Endget_encrypt_algorithm(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingIPsecManSaEncrAlgorithm [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_encrypt_key
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecManualSecurityAssociation", 
		RequestNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation", ResponseNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_encrypt_key(
		string [] associations
	) {
		object [] results = this.Invoke("get_encrypt_key", new object [] {
				associations});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_encrypt_key(string [] associations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_encrypt_key", new object[] {
			associations}, callback, asyncState);
	}
	public string [] Endget_encrypt_key(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_encrypt_key_encrypted
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecManualSecurityAssociation", 
		RequestNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation", ResponseNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_encrypt_key_encrypted(
		string [] associations
	) {
		object [] results = this.Invoke("get_encrypt_key_encrypted", new object [] {
				associations});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_encrypt_key_encrypted(string [] associations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_encrypt_key_encrypted", new object[] {
			associations}, callback, asyncState);
	}
	public string [] Endget_encrypt_key_encrypted(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecManualSecurityAssociation", 
		RequestNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation", ResponseNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation")]
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
	// get_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecManualSecurityAssociation", 
		RequestNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation", ResponseNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_policy(
		string [] associations
	) {
		object [] results = this.Invoke("get_policy", new object [] {
				associations});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_policy(string [] associations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_policy", new object[] {
			associations}, callback, asyncState);
	}
	public string [] Endget_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_protocol
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecManualSecurityAssociation", 
		RequestNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation", ResponseNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingIPsecProtocol [] get_protocol(
		string [] associations
	) {
		object [] results = this.Invoke("get_protocol", new object [] {
				associations});
		return ((NetworkingIPsecProtocol [])(results[0]));
	}
	public System.IAsyncResult Beginget_protocol(string [] associations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_protocol", new object[] {
			associations}, callback, asyncState);
	}
	public NetworkingIPsecProtocol [] Endget_protocol(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingIPsecProtocol [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_source_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecManualSecurityAssociation", 
		RequestNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation", ResponseNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_source_address(
		string [] associations
	) {
		object [] results = this.Invoke("get_source_address", new object [] {
				associations});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_source_address(string [] associations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_source_address", new object[] {
			associations}, callback, asyncState);
	}
	public string [] Endget_source_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_spi
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecManualSecurityAssociation", 
		RequestNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation", ResponseNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_spi(
		string [] associations
	) {
		object [] results = this.Invoke("get_spi", new object [] {
				associations});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_spi(string [] associations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_spi", new object[] {
			associations}, callback, asyncState);
	}
	public long [] Endget_spi(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecManualSecurityAssociation", 
		RequestNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation", ResponseNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation")]
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
	// set_auth_algorithm
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecManualSecurityAssociation", 
		RequestNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation", ResponseNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation")]
	public void set_auth_algorithm(
		string [] associations,
		NetworkingIPsecSaManAlgorithm [] algorithms
	) {
		this.Invoke("set_auth_algorithm", new object [] {
				associations,
				algorithms});

	}
	public System.IAsyncResult Beginset_auth_algorithm(string [] associations,NetworkingIPsecSaManAlgorithm [] algorithms, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_auth_algorithm", new object[] {
			associations,
			algorithms}, callback, asyncState);
	}
	public void Endset_auth_algorithm(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_auth_key
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecManualSecurityAssociation", 
		RequestNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation", ResponseNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation")]
	public void set_auth_key(
		string [] associations,
		string [] keys
	) {
		this.Invoke("set_auth_key", new object [] {
				associations,
				keys});

	}
	public System.IAsyncResult Beginset_auth_key(string [] associations,string [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_auth_key", new object[] {
			associations,
			keys}, callback, asyncState);
	}
	public void Endset_auth_key(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_auth_key_encrypted
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecManualSecurityAssociation", 
		RequestNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation", ResponseNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation")]
	public void set_auth_key_encrypted(
		string [] associations,
		string [] keys
	) {
		this.Invoke("set_auth_key_encrypted", new object [] {
				associations,
				keys});

	}
	public System.IAsyncResult Beginset_auth_key_encrypted(string [] associations,string [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_auth_key_encrypted", new object[] {
			associations,
			keys}, callback, asyncState);
	}
	public void Endset_auth_key_encrypted(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecManualSecurityAssociation", 
		RequestNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation", ResponseNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation")]
	public void set_description(
		string [] associations,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				associations,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] associations,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			associations,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_destination_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecManualSecurityAssociation", 
		RequestNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation", ResponseNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation")]
	public void set_destination_address(
		string [] associations,
		string [] addresses
	) {
		this.Invoke("set_destination_address", new object [] {
				associations,
				addresses});

	}
	public System.IAsyncResult Beginset_destination_address(string [] associations,string [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_destination_address", new object[] {
			associations,
			addresses}, callback, asyncState);
	}
	public void Endset_destination_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_encrypt_algorithm
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecManualSecurityAssociation", 
		RequestNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation", ResponseNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation")]
	public void set_encrypt_algorithm(
		string [] associations,
		NetworkingIPsecManSaEncrAlgorithm [] algorithms
	) {
		this.Invoke("set_encrypt_algorithm", new object [] {
				associations,
				algorithms});

	}
	public System.IAsyncResult Beginset_encrypt_algorithm(string [] associations,NetworkingIPsecManSaEncrAlgorithm [] algorithms, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_encrypt_algorithm", new object[] {
			associations,
			algorithms}, callback, asyncState);
	}
	public void Endset_encrypt_algorithm(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_encrypt_key
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecManualSecurityAssociation", 
		RequestNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation", ResponseNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation")]
	public void set_encrypt_key(
		string [] associations,
		string [] keys
	) {
		this.Invoke("set_encrypt_key", new object [] {
				associations,
				keys});

	}
	public System.IAsyncResult Beginset_encrypt_key(string [] associations,string [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_encrypt_key", new object[] {
			associations,
			keys}, callback, asyncState);
	}
	public void Endset_encrypt_key(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_encrypt_key_encrypted
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecManualSecurityAssociation", 
		RequestNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation", ResponseNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation")]
	public void set_encrypt_key_encrypted(
		string [] associations,
		string [] keys
	) {
		this.Invoke("set_encrypt_key_encrypted", new object [] {
				associations,
				keys});

	}
	public System.IAsyncResult Beginset_encrypt_key_encrypted(string [] associations,string [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_encrypt_key_encrypted", new object[] {
			associations,
			keys}, callback, asyncState);
	}
	public void Endset_encrypt_key_encrypted(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecManualSecurityAssociation", 
		RequestNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation", ResponseNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation")]
	public void set_policy(
		string [] associations,
		string [] policies
	) {
		this.Invoke("set_policy", new object [] {
				associations,
				policies});

	}
	public System.IAsyncResult Beginset_policy(string [] associations,string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_policy", new object[] {
			associations,
			policies}, callback, asyncState);
	}
	public void Endset_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_protocol
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecManualSecurityAssociation", 
		RequestNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation", ResponseNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation")]
	public void set_protocol(
		string [] associations,
		NetworkingIPsecProtocol [] protocols
	) {
		this.Invoke("set_protocol", new object [] {
				associations,
				protocols});

	}
	public System.IAsyncResult Beginset_protocol(string [] associations,NetworkingIPsecProtocol [] protocols, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_protocol", new object[] {
			associations,
			protocols}, callback, asyncState);
	}
	public void Endset_protocol(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_source_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecManualSecurityAssociation", 
		RequestNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation", ResponseNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation")]
	public void set_source_address(
		string [] associations,
		string [] addresses
	) {
		this.Invoke("set_source_address", new object [] {
				associations,
				addresses});

	}
	public System.IAsyncResult Beginset_source_address(string [] associations,string [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_source_address", new object[] {
			associations,
			addresses}, callback, asyncState);
	}
	public void Endset_source_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_spi
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecManualSecurityAssociation", 
		RequestNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation", ResponseNamespace="urn:iControl:Networking/IPsecManualSecurityAssociation")]
	public void set_spi(
		string [] associations,
		long [] spis
	) {
		this.Invoke("set_spi", new object [] {
				associations,
				spis});

	}
	public System.IAsyncResult Beginset_spi(string [] associations,long [] spis, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_spi", new object[] {
			associations,
			spis}, callback, asyncState);
	}
	public void Endset_spi(System.IAsyncResult asyncResult) {
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
