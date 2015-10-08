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
	[System.Web.Services.WebServiceBindingAttribute(Name="Networking.IPsecPolicyBinding", Namespace="urn:iControl")]
	public partial class NetworkingIPsecPolicy : iControlInterface {
		public NetworkingIPsecPolicy() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecPolicy", 
		RequestNamespace="urn:iControl:Networking/IPsecPolicy", ResponseNamespace="urn:iControl:Networking/IPsecPolicy")]
	public void create(
		string [] policies
	) {
		this.Invoke("create", new object [] {
				policies});

	}
	public System.IAsyncResult Begincreate(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			policies}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_policies
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecPolicy", 
		RequestNamespace="urn:iControl:Networking/IPsecPolicy", ResponseNamespace="urn:iControl:Networking/IPsecPolicy")]
	public void delete_all_policies(

	) {
		this.Invoke("delete_all_policies", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_policies(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_policies", new object[0], callback, asyncState);
	}
	public void Enddelete_all_policies(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_policy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecPolicy", 
		RequestNamespace="urn:iControl:Networking/IPsecPolicy", ResponseNamespace="urn:iControl:Networking/IPsecPolicy")]
	public void delete_policy(
		string [] policies
	) {
		this.Invoke("delete_policy", new object [] {
				policies});

	}
	public System.IAsyncResult Begindelete_policy(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_policy", new object[] {
			policies}, callback, asyncState);
	}
	public void Enddelete_policy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_auth_algorithm
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecPolicy", 
		RequestNamespace="urn:iControl:Networking/IPsecPolicy", ResponseNamespace="urn:iControl:Networking/IPsecPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingIPsecSaAuthAlgorithm [] get_auth_algorithm(
		string [] policies
	) {
		object [] results = this.Invoke("get_auth_algorithm", new object [] {
				policies});
		return ((NetworkingIPsecSaAuthAlgorithm [])(results[0]));
	}
	public System.IAsyncResult Beginget_auth_algorithm(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_auth_algorithm", new object[] {
			policies}, callback, asyncState);
	}
	public NetworkingIPsecSaAuthAlgorithm [] Endget_auth_algorithm(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingIPsecSaAuthAlgorithm [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecPolicy", 
		RequestNamespace="urn:iControl:Networking/IPsecPolicy", ResponseNamespace="urn:iControl:Networking/IPsecPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] policies
	) {
		object [] results = this.Invoke("get_description", new object [] {
				policies});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			policies}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_encrypt_algorithm
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecPolicy", 
		RequestNamespace="urn:iControl:Networking/IPsecPolicy", ResponseNamespace="urn:iControl:Networking/IPsecPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingIPsecDynSaEncryptAlgorithm [] get_encrypt_algorithm(
		string [] policies
	) {
		object [] results = this.Invoke("get_encrypt_algorithm", new object [] {
				policies});
		return ((NetworkingIPsecDynSaEncryptAlgorithm [])(results[0]));
	}
	public System.IAsyncResult Beginget_encrypt_algorithm(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_encrypt_algorithm", new object[] {
			policies}, callback, asyncState);
	}
	public NetworkingIPsecDynSaEncryptAlgorithm [] Endget_encrypt_algorithm(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingIPsecDynSaEncryptAlgorithm [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_forward_secrecy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecPolicy", 
		RequestNamespace="urn:iControl:Networking/IPsecPolicy", ResponseNamespace="urn:iControl:Networking/IPsecPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingIPsecDiffieHellmanGroup [] get_forward_secrecy(
		string [] policies
	) {
		object [] results = this.Invoke("get_forward_secrecy", new object [] {
				policies});
		return ((NetworkingIPsecDiffieHellmanGroup [])(results[0]));
	}
	public System.IAsyncResult Beginget_forward_secrecy(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_forward_secrecy", new object[] {
			policies}, callback, asyncState);
	}
	public NetworkingIPsecDiffieHellmanGroup [] Endget_forward_secrecy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingIPsecDiffieHellmanGroup [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ipcomp_algorithm
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecPolicy", 
		RequestNamespace="urn:iControl:Networking/IPsecPolicy", ResponseNamespace="urn:iControl:Networking/IPsecPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingIPCompAlgorithm [] get_ipcomp_algorithm(
		string [] policies
	) {
		object [] results = this.Invoke("get_ipcomp_algorithm", new object [] {
				policies});
		return ((NetworkingIPCompAlgorithm [])(results[0]));
	}
	public System.IAsyncResult Beginget_ipcomp_algorithm(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ipcomp_algorithm", new object[] {
			policies}, callback, asyncState);
	}
	public NetworkingIPCompAlgorithm [] Endget_ipcomp_algorithm(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingIPCompAlgorithm [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ipcomp_deflate_level
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecPolicy", 
		RequestNamespace="urn:iControl:Networking/IPsecPolicy", ResponseNamespace="urn:iControl:Networking/IPsecPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public short [] get_ipcomp_deflate_level(
		string [] policies
	) {
		object [] results = this.Invoke("get_ipcomp_deflate_level", new object [] {
				policies});
		return ((short [])(results[0]));
	}
	public System.IAsyncResult Beginget_ipcomp_deflate_level(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ipcomp_deflate_level", new object[] {
			policies}, callback, asyncState);
	}
	public short [] Endget_ipcomp_deflate_level(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((short [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_lifetime
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecPolicy", 
		RequestNamespace="urn:iControl:Networking/IPsecPolicy", ResponseNamespace="urn:iControl:Networking/IPsecPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_lifetime(
		string [] policies
	) {
		object [] results = this.Invoke("get_lifetime", new object [] {
				policies});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_lifetime(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_lifetime", new object[] {
			policies}, callback, asyncState);
	}
	public long [] Endget_lifetime(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_lifetime_kilobytes
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecPolicy", 
		RequestNamespace="urn:iControl:Networking/IPsecPolicy", ResponseNamespace="urn:iControl:Networking/IPsecPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_lifetime_kilobytes(
		string [] policies
	) {
		object [] results = this.Invoke("get_lifetime_kilobytes", new object [] {
				policies});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_lifetime_kilobytes(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_lifetime_kilobytes", new object[] {
			policies}, callback, asyncState);
	}
	public long [] Endget_lifetime_kilobytes(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecPolicy", 
		RequestNamespace="urn:iControl:Networking/IPsecPolicy", ResponseNamespace="urn:iControl:Networking/IPsecPolicy")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecPolicy", 
		RequestNamespace="urn:iControl:Networking/IPsecPolicy", ResponseNamespace="urn:iControl:Networking/IPsecPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_local_address(
		string [] policies
	) {
		object [] results = this.Invoke("get_local_address", new object [] {
				policies});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_local_address(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_local_address", new object[] {
			policies}, callback, asyncState);
	}
	public string [] Endget_local_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecPolicy", 
		RequestNamespace="urn:iControl:Networking/IPsecPolicy", ResponseNamespace="urn:iControl:Networking/IPsecPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingIPsecMode [] get_mode(
		string [] policies
	) {
		object [] results = this.Invoke("get_mode", new object [] {
				policies});
		return ((NetworkingIPsecMode [])(results[0]));
	}
	public System.IAsyncResult Beginget_mode(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_mode", new object[] {
			policies}, callback, asyncState);
	}
	public NetworkingIPsecMode [] Endget_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingIPsecMode [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_protocol
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecPolicy", 
		RequestNamespace="urn:iControl:Networking/IPsecPolicy", ResponseNamespace="urn:iControl:Networking/IPsecPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public NetworkingIPsecProtocol [] get_protocol(
		string [] policies
	) {
		object [] results = this.Invoke("get_protocol", new object [] {
				policies});
		return ((NetworkingIPsecProtocol [])(results[0]));
	}
	public System.IAsyncResult Beginget_protocol(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_protocol", new object[] {
			policies}, callback, asyncState);
	}
	public NetworkingIPsecProtocol [] Endget_protocol(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((NetworkingIPsecProtocol [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_remote_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecPolicy", 
		RequestNamespace="urn:iControl:Networking/IPsecPolicy", ResponseNamespace="urn:iControl:Networking/IPsecPolicy")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_remote_address(
		string [] policies
	) {
		object [] results = this.Invoke("get_remote_address", new object [] {
				policies});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_remote_address(string [] policies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_remote_address", new object[] {
			policies}, callback, asyncState);
	}
	public string [] Endget_remote_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecPolicy", 
		RequestNamespace="urn:iControl:Networking/IPsecPolicy", ResponseNamespace="urn:iControl:Networking/IPsecPolicy")]
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
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecPolicy", 
		RequestNamespace="urn:iControl:Networking/IPsecPolicy", ResponseNamespace="urn:iControl:Networking/IPsecPolicy")]
	public void set_auth_algorithm(
		string [] policies,
		NetworkingIPsecSaAuthAlgorithm [] algorithms
	) {
		this.Invoke("set_auth_algorithm", new object [] {
				policies,
				algorithms});

	}
	public System.IAsyncResult Beginset_auth_algorithm(string [] policies,NetworkingIPsecSaAuthAlgorithm [] algorithms, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_auth_algorithm", new object[] {
			policies,
			algorithms}, callback, asyncState);
	}
	public void Endset_auth_algorithm(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecPolicy", 
		RequestNamespace="urn:iControl:Networking/IPsecPolicy", ResponseNamespace="urn:iControl:Networking/IPsecPolicy")]
	public void set_description(
		string [] policies,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				policies,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] policies,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			policies,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_encrypt_algorithm
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecPolicy", 
		RequestNamespace="urn:iControl:Networking/IPsecPolicy", ResponseNamespace="urn:iControl:Networking/IPsecPolicy")]
	public void set_encrypt_algorithm(
		string [] policies,
		NetworkingIPsecDynSaEncryptAlgorithm [] algorithms
	) {
		this.Invoke("set_encrypt_algorithm", new object [] {
				policies,
				algorithms});

	}
	public System.IAsyncResult Beginset_encrypt_algorithm(string [] policies,NetworkingIPsecDynSaEncryptAlgorithm [] algorithms, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_encrypt_algorithm", new object[] {
			policies,
			algorithms}, callback, asyncState);
	}
	public void Endset_encrypt_algorithm(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_forward_secrecy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecPolicy", 
		RequestNamespace="urn:iControl:Networking/IPsecPolicy", ResponseNamespace="urn:iControl:Networking/IPsecPolicy")]
	public void set_forward_secrecy(
		string [] policies,
		NetworkingIPsecDiffieHellmanGroup [] secrecies
	) {
		this.Invoke("set_forward_secrecy", new object [] {
				policies,
				secrecies});

	}
	public System.IAsyncResult Beginset_forward_secrecy(string [] policies,NetworkingIPsecDiffieHellmanGroup [] secrecies, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_forward_secrecy", new object[] {
			policies,
			secrecies}, callback, asyncState);
	}
	public void Endset_forward_secrecy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ipcomp_algorithm
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecPolicy", 
		RequestNamespace="urn:iControl:Networking/IPsecPolicy", ResponseNamespace="urn:iControl:Networking/IPsecPolicy")]
	public void set_ipcomp_algorithm(
		string [] policies,
		NetworkingIPCompAlgorithm [] algorithms
	) {
		this.Invoke("set_ipcomp_algorithm", new object [] {
				policies,
				algorithms});

	}
	public System.IAsyncResult Beginset_ipcomp_algorithm(string [] policies,NetworkingIPCompAlgorithm [] algorithms, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ipcomp_algorithm", new object[] {
			policies,
			algorithms}, callback, asyncState);
	}
	public void Endset_ipcomp_algorithm(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ipcomp_deflate_level
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecPolicy", 
		RequestNamespace="urn:iControl:Networking/IPsecPolicy", ResponseNamespace="urn:iControl:Networking/IPsecPolicy")]
	public void set_ipcomp_deflate_level(
		string [] policies,
		short [] levels
	) {
		this.Invoke("set_ipcomp_deflate_level", new object [] {
				policies,
				levels});

	}
	public System.IAsyncResult Beginset_ipcomp_deflate_level(string [] policies,short [] levels, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ipcomp_deflate_level", new object[] {
			policies,
			levels}, callback, asyncState);
	}
	public void Endset_ipcomp_deflate_level(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_lifetime
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecPolicy", 
		RequestNamespace="urn:iControl:Networking/IPsecPolicy", ResponseNamespace="urn:iControl:Networking/IPsecPolicy")]
	public void set_lifetime(
		string [] policies,
		long [] lifetimes
	) {
		this.Invoke("set_lifetime", new object [] {
				policies,
				lifetimes});

	}
	public System.IAsyncResult Beginset_lifetime(string [] policies,long [] lifetimes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_lifetime", new object[] {
			policies,
			lifetimes}, callback, asyncState);
	}
	public void Endset_lifetime(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_lifetime_kilobytes
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecPolicy", 
		RequestNamespace="urn:iControl:Networking/IPsecPolicy", ResponseNamespace="urn:iControl:Networking/IPsecPolicy")]
	public void set_lifetime_kilobytes(
		string [] policies,
		long [] lifetimes
	) {
		this.Invoke("set_lifetime_kilobytes", new object [] {
				policies,
				lifetimes});

	}
	public System.IAsyncResult Beginset_lifetime_kilobytes(string [] policies,long [] lifetimes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_lifetime_kilobytes", new object[] {
			policies,
			lifetimes}, callback, asyncState);
	}
	public void Endset_lifetime_kilobytes(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_local_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecPolicy", 
		RequestNamespace="urn:iControl:Networking/IPsecPolicy", ResponseNamespace="urn:iControl:Networking/IPsecPolicy")]
	public void set_local_address(
		string [] policies,
		string [] addresses
	) {
		this.Invoke("set_local_address", new object [] {
				policies,
				addresses});

	}
	public System.IAsyncResult Beginset_local_address(string [] policies,string [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_local_address", new object[] {
			policies,
			addresses}, callback, asyncState);
	}
	public void Endset_local_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_mode
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecPolicy", 
		RequestNamespace="urn:iControl:Networking/IPsecPolicy", ResponseNamespace="urn:iControl:Networking/IPsecPolicy")]
	public void set_mode(
		string [] policies,
		NetworkingIPsecMode [] modes
	) {
		this.Invoke("set_mode", new object [] {
				policies,
				modes});

	}
	public System.IAsyncResult Beginset_mode(string [] policies,NetworkingIPsecMode [] modes, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_mode", new object[] {
			policies,
			modes}, callback, asyncState);
	}
	public void Endset_mode(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_protocol
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecPolicy", 
		RequestNamespace="urn:iControl:Networking/IPsecPolicy", ResponseNamespace="urn:iControl:Networking/IPsecPolicy")]
	public void set_protocol(
		string [] policies,
		NetworkingIPsecProtocol [] protocols
	) {
		this.Invoke("set_protocol", new object [] {
				policies,
				protocols});

	}
	public System.IAsyncResult Beginset_protocol(string [] policies,NetworkingIPsecProtocol [] protocols, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_protocol", new object[] {
			policies,
			protocols}, callback, asyncState);
	}
	public void Endset_protocol(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_remote_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Networking/IPsecPolicy", 
		RequestNamespace="urn:iControl:Networking/IPsecPolicy", ResponseNamespace="urn:iControl:Networking/IPsecPolicy")]
	public void set_remote_address(
		string [] policies,
		string [] addresses
	) {
		this.Invoke("set_remote_address", new object [] {
				policies,
				addresses});

	}
	public System.IAsyncResult Beginset_remote_address(string [] policies,string [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_remote_address", new object[] {
			policies,
			addresses}, callback, asyncState);
	}
	public void Endset_remote_address(System.IAsyncResult asyncResult) {
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
