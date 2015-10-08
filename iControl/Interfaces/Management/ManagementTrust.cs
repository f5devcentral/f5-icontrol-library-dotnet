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
	[System.Web.Services.WebServiceBindingAttribute(Name="Management.TrustBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementTrustBrowserCertificateInfo))]
	public partial class ManagementTrust : iControlInterface {
		public ManagementTrust() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// add_authority_device
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Trust", 
		RequestNamespace="urn:iControl:Management/Trust", ResponseNamespace="urn:iControl:Management/Trust")]
	public void add_authority_device(
		string address,
		string username,
		string password,
		string device_object_name,
		string browser_cert_serial_number,
		string browser_cert_signature,
		string browser_cert_sha1_fingerprint,
		string browser_cert_md5_fingerprint
	) {
		this.Invoke("add_authority_device", new object [] {
				address,
				username,
				password,
				device_object_name,
				browser_cert_serial_number,
				browser_cert_signature,
				browser_cert_sha1_fingerprint,
				browser_cert_md5_fingerprint});

	}
	public System.IAsyncResult Beginadd_authority_device(string address,string username,string password,string device_object_name,string browser_cert_serial_number,string browser_cert_signature,string browser_cert_sha1_fingerprint,string browser_cert_md5_fingerprint, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_authority_device", new object[] {
			address,
			username,
			password,
			device_object_name,
			browser_cert_serial_number,
			browser_cert_signature,
			browser_cert_sha1_fingerprint,
			browser_cert_md5_fingerprint}, callback, asyncState);
	}
	public void Endadd_authority_device(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// add_non_authority_device
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Trust", 
		RequestNamespace="urn:iControl:Management/Trust", ResponseNamespace="urn:iControl:Management/Trust")]
	public void add_non_authority_device(
		string address,
		string username,
		string password,
		string device_object_name,
		string browser_cert_serial_number,
		string browser_cert_signature,
		string browser_cert_sha1_fingerprint,
		string browser_cert_md5_fingerprint
	) {
		this.Invoke("add_non_authority_device", new object [] {
				address,
				username,
				password,
				device_object_name,
				browser_cert_serial_number,
				browser_cert_signature,
				browser_cert_sha1_fingerprint,
				browser_cert_md5_fingerprint});

	}
	public System.IAsyncResult Beginadd_non_authority_device(string address,string username,string password,string device_object_name,string browser_cert_serial_number,string browser_cert_signature,string browser_cert_sha1_fingerprint,string browser_cert_md5_fingerprint, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("add_non_authority_device", new object[] {
			address,
			username,
			password,
			device_object_name,
			browser_cert_serial_number,
			browser_cert_signature,
			browser_cert_sha1_fingerprint,
			browser_cert_md5_fingerprint}, callback, asyncState);
	}
	public void Endadd_non_authority_device(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// generate_csr
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Trust", 
		RequestNamespace="urn:iControl:Management/Trust", ResponseNamespace="urn:iControl:Management/Trust")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string generate_csr(
		string device
	) {
		object [] results = this.Invoke("generate_csr", new object [] {
				device});
		return ((string)(results[0]));
	}
	public System.IAsyncResult Begingenerate_csr(string device, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("generate_csr", new object[] {
			device}, callback, asyncState);
	}
	public string Endgenerate_csr(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_browser_certificate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Trust", 
		RequestNamespace="urn:iControl:Management/Trust", ResponseNamespace="urn:iControl:Management/Trust")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementTrustBrowserCertificateInfo get_browser_certificate(
		string address
	) {
		object [] results = this.Invoke("get_browser_certificate", new object [] {
				address});
		return ((ManagementTrustBrowserCertificateInfo)(results[0]));
	}
	public System.IAsyncResult Beginget_browser_certificate(string address, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_browser_certificate", new object[] {
			address}, callback, asyncState);
	}
	public ManagementTrustBrowserCertificateInfo Endget_browser_certificate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementTrustBrowserCertificateInfo)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ca_certificate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Trust", 
		RequestNamespace="urn:iControl:Management/Trust", ResponseNamespace="urn:iControl:Management/Trust")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string get_ca_certificate(

	) {
		object [] results = this.Invoke("get_ca_certificate", new object [0]);
		return ((string)(results[0]));
	}
	public System.IAsyncResult Beginget_ca_certificate(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ca_certificate", new object[0], callback, asyncState);
	}
	public string Endget_ca_certificate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_device_in_use
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Trust", 
		RequestNamespace="urn:iControl:Management/Trust", ResponseNamespace="urn:iControl:Management/Trust")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool get_device_in_use(

	) {
		object [] results = this.Invoke("get_device_in_use", new object [0]);
		return ((bool)(results[0]));
	}
	public System.IAsyncResult Beginget_device_in_use(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_device_in_use", new object[0], callback, asyncState);
	}
	public bool Endget_device_in_use(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_device_object_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Trust", 
		RequestNamespace="urn:iControl:Management/Trust", ResponseNamespace="urn:iControl:Management/Trust")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string get_device_object_name(
		string address,
		string username,
		string password,
		string browser_cert_serial_number,
		string browser_cert_signature,
		string browser_cert_sha1_fingerprint,
		string browser_cert_md5_fingerprint
	) {
		object [] results = this.Invoke("get_device_object_name", new object [] {
				address,
				username,
				password,
				browser_cert_serial_number,
				browser_cert_signature,
				browser_cert_sha1_fingerprint,
				browser_cert_md5_fingerprint});
		return ((string)(results[0]));
	}
	public System.IAsyncResult Beginget_device_object_name(string address,string username,string password,string browser_cert_serial_number,string browser_cert_signature,string browser_cert_sha1_fingerprint,string browser_cert_md5_fingerprint, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_device_object_name", new object[] {
			address,
			username,
			password,
			browser_cert_serial_number,
			browser_cert_signature,
			browser_cert_sha1_fingerprint,
			browser_cert_md5_fingerprint}, callback, asyncState);
	}
	public string Endget_device_object_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_guid
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Trust", 
		RequestNamespace="urn:iControl:Management/Trust", ResponseNamespace="urn:iControl:Management/Trust")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_guid(
		string [] domains
	) {
		object [] results = this.Invoke("get_guid", new object [] {
				domains});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_guid(string [] domains, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_guid", new object[] {
			domains}, callback, asyncState);
	}
	public string [] Endget_guid(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Trust", 
		RequestNamespace="urn:iControl:Management/Trust", ResponseNamespace="urn:iControl:Management/Trust")]
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
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Trust", 
		RequestNamespace="urn:iControl:Management/Trust", ResponseNamespace="urn:iControl:Management/Trust")]
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
	// install_authority_trust
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Trust", 
		RequestNamespace="urn:iControl:Management/Trust", ResponseNamespace="urn:iControl:Management/Trust")]
	public void install_authority_trust(
		string device,
		string identity_cert,
		string ca_cert,
		string ca_key,
		string [] authorities,
		string [] management_addresses,
		string [] configsync_addresses
	) {
		this.Invoke("install_authority_trust", new object [] {
				device,
				identity_cert,
				ca_cert,
				ca_key,
				authorities,
				management_addresses,
				configsync_addresses});

	}
	public System.IAsyncResult Begininstall_authority_trust(string device,string identity_cert,string ca_cert,string ca_key,string [] authorities,string [] management_addresses,string [] configsync_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("install_authority_trust", new object[] {
			device,
			identity_cert,
			ca_cert,
			ca_key,
			authorities,
			management_addresses,
			configsync_addresses}, callback, asyncState);
	}
	public void Endinstall_authority_trust(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// install_device_trust
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Trust", 
		RequestNamespace="urn:iControl:Management/Trust", ResponseNamespace="urn:iControl:Management/Trust")]
	public void install_device_trust(
		string device,
		string identity_cert,
		string ca_cert,
		string [] authorities,
		string [] management_addresses,
		string [] configsync_addresses
	) {
		this.Invoke("install_device_trust", new object [] {
				device,
				identity_cert,
				ca_cert,
				authorities,
				management_addresses,
				configsync_addresses});

	}
	public System.IAsyncResult Begininstall_device_trust(string device,string identity_cert,string ca_cert,string [] authorities,string [] management_addresses,string [] configsync_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("install_device_trust", new object[] {
			device,
			identity_cert,
			ca_cert,
			authorities,
			management_addresses,
			configsync_addresses}, callback, asyncState);
	}
	public void Endinstall_device_trust(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_device
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Trust", 
		RequestNamespace="urn:iControl:Management/Trust", ResponseNamespace="urn:iControl:Management/Trust")]
	public void remove_device(
		string [] devices
	) {
		this.Invoke("remove_device", new object [] {
				devices});

	}
	public System.IAsyncResult Beginremove_device(string [] devices, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_device", new object[] {
			devices}, callback, asyncState);
	}
	public void Endremove_device(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// reset_all
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Trust", 
		RequestNamespace="urn:iControl:Management/Trust", ResponseNamespace="urn:iControl:Management/Trust")]
	public void reset_all(
		string device_object_name,
		bool keep_current_authority,
		string authority_cert,
		string authority_key
	) {
		this.Invoke("reset_all", new object [] {
				device_object_name,
				keep_current_authority,
				authority_cert,
				authority_key});

	}
	public System.IAsyncResult Beginreset_all(string device_object_name,bool keep_current_authority,string authority_cert,string authority_key, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reset_all", new object[] {
			device_object_name,
			keep_current_authority,
			authority_cert,
			authority_key}, callback, asyncState);
	}
	public void Endreset_all(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.Trust.BrowserCertificateInfo", Namespace = "urn:iControl")]
	public partial class ManagementTrustBrowserCertificateInfo
	{
		private string subject_nameField;
		public string subject_name
		{
			get { return this.subject_nameField; }
			set { this.subject_nameField = value; }
		}
		private string serial_numberField;
		public string serial_number
		{
			get { return this.serial_numberField; }
			set { this.serial_numberField = value; }
		}
		private string expiration_dateField;
		public string expiration_date
		{
			get { return this.expiration_dateField; }
			set { this.expiration_dateField = value; }
		}
		private string signatureField;
		public string signature
		{
			get { return this.signatureField; }
			set { this.signatureField = value; }
		}
		private string sha1_fingerprintField;
		public string sha1_fingerprint
		{
			get { return this.sha1_fingerprintField; }
			set { this.sha1_fingerprintField = value; }
		}
		private string md5_fingerprintField;
		public string md5_fingerprint
		{
			get { return this.md5_fingerprintField; }
			set { this.md5_fingerprintField = value; }
		}
	};

}
