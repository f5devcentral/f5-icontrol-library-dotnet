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
	[System.Web.Services.WebServiceBindingAttribute(Name="Management.KeyCertificateBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementKeyCertificateX509Data))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementKeyCertificateCertificate))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementKeyCertificateCertificateExtension))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementKeyCertificateCertificateRequest))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementKeyCertificateCertificateDetail))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementKeyCertificateCertificateDetail_v2))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementKeyCertificateCertificateInformation))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementKeyCertificateCertificateInformation_v2))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementKeyCertificateCertificateRequestInformation))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementKeyCertificateCertificateRequestInformation_v2))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementKeyCertificateKeyInformation))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementKeyCertificateKeyInformation_v2))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementKeyCertificateKey_v2))]
	public partial class ManagementKeyCertificate : iControlInterface {
		public ManagementKeyCertificate() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// certificate_add_file_to_bundle
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	public void certificate_add_file_to_bundle(
		ManagementKeyCertificateManagementModeType mode,
		string [] cert_ids,
		string [] certificate_files
	) {
		this.Invoke("certificate_add_file_to_bundle", new object [] {
				mode,
				cert_ids,
				certificate_files});

	}
	public System.IAsyncResult Begincertificate_add_file_to_bundle(ManagementKeyCertificateManagementModeType mode,string [] cert_ids,string [] certificate_files, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("certificate_add_file_to_bundle", new object[] {
			mode,
			cert_ids,
			certificate_files}, callback, asyncState);
	}
	public void Endcertificate_add_file_to_bundle(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// certificate_add_pem_to_bundle
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	public void certificate_add_pem_to_bundle(
		ManagementKeyCertificateManagementModeType mode,
		string [] cert_ids,
		string [] pem_data
	) {
		this.Invoke("certificate_add_pem_to_bundle", new object [] {
				mode,
				cert_ids,
				pem_data});

	}
	public System.IAsyncResult Begincertificate_add_pem_to_bundle(ManagementKeyCertificateManagementModeType mode,string [] cert_ids,string [] pem_data, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("certificate_add_pem_to_bundle", new object[] {
			mode,
			cert_ids,
			pem_data}, callback, asyncState);
	}
	public void Endcertificate_add_pem_to_bundle(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// certificate_bind
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	public void certificate_bind(
		ManagementKeyCertificateManagementModeType mode,
		string [] cert_ids,
		string [] key_ids
	) {
		this.Invoke("certificate_bind", new object [] {
				mode,
				cert_ids,
				key_ids});

	}
	public System.IAsyncResult Begincertificate_bind(ManagementKeyCertificateManagementModeType mode,string [] cert_ids,string [] key_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("certificate_bind", new object[] {
			mode,
			cert_ids,
			key_ids}, callback, asyncState);
	}
	public void Endcertificate_bind(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// certificate_check_validity
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementKeyCertificateValidityType [] certificate_check_validity(
		ManagementKeyCertificateManagementModeType mode,
		string [] cert_ids,
		long [] watermark_days
	) {
		object [] results = this.Invoke("certificate_check_validity", new object [] {
				mode,
				cert_ids,
				watermark_days});
		return ((ManagementKeyCertificateValidityType [])(results[0]));
	}
	public System.IAsyncResult Begincertificate_check_validity(ManagementKeyCertificateManagementModeType mode,string [] cert_ids,long [] watermark_days, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("certificate_check_validity", new object[] {
			mode,
			cert_ids,
			watermark_days}, callback, asyncState);
	}
	public ManagementKeyCertificateValidityType [] Endcertificate_check_validity(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementKeyCertificateValidityType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// certificate_delete
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	public void certificate_delete(
		ManagementKeyCertificateManagementModeType mode,
		string [] cert_ids
	) {
		this.Invoke("certificate_delete", new object [] {
				mode,
				cert_ids});

	}
	public System.IAsyncResult Begincertificate_delete(ManagementKeyCertificateManagementModeType mode,string [] cert_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("certificate_delete", new object[] {
			mode,
			cert_ids}, callback, asyncState);
	}
	public void Endcertificate_delete(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// certificate_delete_from_bundle
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	public void certificate_delete_from_bundle(
		ManagementKeyCertificateManagementModeType mode,
		string [] cert_ids,
		ManagementKeyCertificateX509Data [] x509_data
	) {
		this.Invoke("certificate_delete_from_bundle", new object [] {
				mode,
				cert_ids,
				x509_data});

	}
	public System.IAsyncResult Begincertificate_delete_from_bundle(ManagementKeyCertificateManagementModeType mode,string [] cert_ids,ManagementKeyCertificateX509Data [] x509_data, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("certificate_delete_from_bundle", new object[] {
			mode,
			cert_ids,
			x509_data}, callback, asyncState);
	}
	public void Endcertificate_delete_from_bundle(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// certificate_delete_from_bundle_by_serial_number
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	public void certificate_delete_from_bundle_by_serial_number(
		ManagementKeyCertificateManagementModeType mode,
		string [] cert_ids,
		string [] serial_numbers,
		ManagementKeyCertificateX509Data [] x509_data
	) {
		this.Invoke("certificate_delete_from_bundle_by_serial_number", new object [] {
				mode,
				cert_ids,
				serial_numbers,
				x509_data});

	}
	public System.IAsyncResult Begincertificate_delete_from_bundle_by_serial_number(ManagementKeyCertificateManagementModeType mode,string [] cert_ids,string [] serial_numbers,ManagementKeyCertificateX509Data [] x509_data, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("certificate_delete_from_bundle_by_serial_number", new object[] {
			mode,
			cert_ids,
			serial_numbers,
			x509_data}, callback, asyncState);
	}
	public void Endcertificate_delete_from_bundle_by_serial_number(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// certificate_export_to_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	public void certificate_export_to_file(
		ManagementKeyCertificateManagementModeType mode,
		string [] cert_ids,
		string [] file_names,
		bool overwrite
	) {
		this.Invoke("certificate_export_to_file", new object [] {
				mode,
				cert_ids,
				file_names,
				overwrite});

	}
	public System.IAsyncResult Begincertificate_export_to_file(ManagementKeyCertificateManagementModeType mode,string [] cert_ids,string [] file_names,bool overwrite, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("certificate_export_to_file", new object[] {
			mode,
			cert_ids,
			file_names,
			overwrite}, callback, asyncState);
	}
	public void Endcertificate_export_to_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// certificate_export_to_pem
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] certificate_export_to_pem(
		ManagementKeyCertificateManagementModeType mode,
		string [] cert_ids
	) {
		object [] results = this.Invoke("certificate_export_to_pem", new object [] {
				mode,
				cert_ids});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Begincertificate_export_to_pem(ManagementKeyCertificateManagementModeType mode,string [] cert_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("certificate_export_to_pem", new object[] {
			mode,
			cert_ids}, callback, asyncState);
	}
	public string [] Endcertificate_export_to_pem(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// certificate_generate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	public void certificate_generate(
		ManagementKeyCertificateManagementModeType mode,
		ManagementKeyCertificateCertificate [] certs,
		ManagementKeyCertificateX509Data [] x509_data,
		long [] lifetime_days,
		bool overwrite
	) {
		this.Invoke("certificate_generate", new object [] {
				mode,
				certs,
				x509_data,
				lifetime_days,
				overwrite});

	}
	public System.IAsyncResult Begincertificate_generate(ManagementKeyCertificateManagementModeType mode,ManagementKeyCertificateCertificate [] certs,ManagementKeyCertificateX509Data [] x509_data,long [] lifetime_days,bool overwrite, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("certificate_generate", new object[] {
			mode,
			certs,
			x509_data,
			lifetime_days,
			overwrite}, callback, asyncState);
	}
	public void Endcertificate_generate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// certificate_generate_with_extensions
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	public void certificate_generate_with_extensions(
		ManagementKeyCertificateManagementModeType mode,
		ManagementKeyCertificateCertificate [] certs,
		ManagementKeyCertificateX509Data [] x509_data,
		long [] lifetime_days,
		ManagementKeyCertificateCertificateExtension [] [] extensions,
		bool overwrite
	) {
		this.Invoke("certificate_generate_with_extensions", new object [] {
				mode,
				certs,
				x509_data,
				lifetime_days,
				extensions,
				overwrite});

	}
	public System.IAsyncResult Begincertificate_generate_with_extensions(ManagementKeyCertificateManagementModeType mode,ManagementKeyCertificateCertificate [] certs,ManagementKeyCertificateX509Data [] x509_data,long [] lifetime_days,ManagementKeyCertificateCertificateExtension [] [] extensions,bool overwrite, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("certificate_generate_with_extensions", new object[] {
			mode,
			certs,
			x509_data,
			lifetime_days,
			extensions,
			overwrite}, callback, asyncState);
	}
	public void Endcertificate_generate_with_extensions(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// certificate_import_from_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	public void certificate_import_from_file(
		ManagementKeyCertificateManagementModeType mode,
		string [] cert_ids,
		string [] file_names,
		bool overwrite
	) {
		this.Invoke("certificate_import_from_file", new object [] {
				mode,
				cert_ids,
				file_names,
				overwrite});

	}
	public System.IAsyncResult Begincertificate_import_from_file(ManagementKeyCertificateManagementModeType mode,string [] cert_ids,string [] file_names,bool overwrite, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("certificate_import_from_file", new object[] {
			mode,
			cert_ids,
			file_names,
			overwrite}, callback, asyncState);
	}
	public void Endcertificate_import_from_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// certificate_import_from_pem
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	public void certificate_import_from_pem(
		ManagementKeyCertificateManagementModeType mode,
		string [] cert_ids,
		string [] pem_data,
		bool overwrite
	) {
		this.Invoke("certificate_import_from_pem", new object [] {
				mode,
				cert_ids,
				pem_data,
				overwrite});

	}
	public System.IAsyncResult Begincertificate_import_from_pem(ManagementKeyCertificateManagementModeType mode,string [] cert_ids,string [] pem_data,bool overwrite, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("certificate_import_from_pem", new object[] {
			mode,
			cert_ids,
			pem_data,
			overwrite}, callback, asyncState);
	}
	public void Endcertificate_import_from_pem(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// certificate_request_delete
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	public void certificate_request_delete(
		ManagementKeyCertificateManagementModeType mode,
		string [] csr_ids
	) {
		this.Invoke("certificate_request_delete", new object [] {
				mode,
				csr_ids});

	}
	public System.IAsyncResult Begincertificate_request_delete(ManagementKeyCertificateManagementModeType mode,string [] csr_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("certificate_request_delete", new object[] {
			mode,
			csr_ids}, callback, asyncState);
	}
	public void Endcertificate_request_delete(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// certificate_request_export_to_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	public void certificate_request_export_to_file(
		ManagementKeyCertificateManagementModeType mode,
		string [] csr_ids,
		string [] file_names,
		bool overwrite
	) {
		this.Invoke("certificate_request_export_to_file", new object [] {
				mode,
				csr_ids,
				file_names,
				overwrite});

	}
	public System.IAsyncResult Begincertificate_request_export_to_file(ManagementKeyCertificateManagementModeType mode,string [] csr_ids,string [] file_names,bool overwrite, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("certificate_request_export_to_file", new object[] {
			mode,
			csr_ids,
			file_names,
			overwrite}, callback, asyncState);
	}
	public void Endcertificate_request_export_to_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// certificate_request_export_to_pem
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] certificate_request_export_to_pem(
		ManagementKeyCertificateManagementModeType mode,
		string [] csr_ids
	) {
		object [] results = this.Invoke("certificate_request_export_to_pem", new object [] {
				mode,
				csr_ids});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Begincertificate_request_export_to_pem(ManagementKeyCertificateManagementModeType mode,string [] csr_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("certificate_request_export_to_pem", new object[] {
			mode,
			csr_ids}, callback, asyncState);
	}
	public string [] Endcertificate_request_export_to_pem(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// certificate_request_generate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	public void certificate_request_generate(
		ManagementKeyCertificateManagementModeType mode,
		ManagementKeyCertificateCertificateRequest [] csrs,
		ManagementKeyCertificateX509Data [] x509_data,
		bool overwrite
	) {
		this.Invoke("certificate_request_generate", new object [] {
				mode,
				csrs,
				x509_data,
				overwrite});

	}
	public System.IAsyncResult Begincertificate_request_generate(ManagementKeyCertificateManagementModeType mode,ManagementKeyCertificateCertificateRequest [] csrs,ManagementKeyCertificateX509Data [] x509_data,bool overwrite, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("certificate_request_generate", new object[] {
			mode,
			csrs,
			x509_data,
			overwrite}, callback, asyncState);
	}
	public void Endcertificate_request_generate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// certificate_request_generate_with_extensions
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	public void certificate_request_generate_with_extensions(
		ManagementKeyCertificateManagementModeType mode,
		ManagementKeyCertificateCertificateRequest [] csrs,
		ManagementKeyCertificateX509Data [] x509_data,
		ManagementKeyCertificateCertificateExtension [] [] extensions,
		bool overwrite
	) {
		this.Invoke("certificate_request_generate_with_extensions", new object [] {
				mode,
				csrs,
				x509_data,
				extensions,
				overwrite});

	}
	public System.IAsyncResult Begincertificate_request_generate_with_extensions(ManagementKeyCertificateManagementModeType mode,ManagementKeyCertificateCertificateRequest [] csrs,ManagementKeyCertificateX509Data [] x509_data,ManagementKeyCertificateCertificateExtension [] [] extensions,bool overwrite, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("certificate_request_generate_with_extensions", new object[] {
			mode,
			csrs,
			x509_data,
			extensions,
			overwrite}, callback, asyncState);
	}
	public void Endcertificate_request_generate_with_extensions(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// certificate_request_import_from_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	public void certificate_request_import_from_file(
		ManagementKeyCertificateManagementModeType mode,
		string [] csr_ids,
		string [] file_names,
		bool overwrite
	) {
		this.Invoke("certificate_request_import_from_file", new object [] {
				mode,
				csr_ids,
				file_names,
				overwrite});

	}
	public System.IAsyncResult Begincertificate_request_import_from_file(ManagementKeyCertificateManagementModeType mode,string [] csr_ids,string [] file_names,bool overwrite, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("certificate_request_import_from_file", new object[] {
			mode,
			csr_ids,
			file_names,
			overwrite}, callback, asyncState);
	}
	public void Endcertificate_request_import_from_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// certificate_request_import_from_pem
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	public void certificate_request_import_from_pem(
		ManagementKeyCertificateManagementModeType mode,
		string [] csr_ids,
		string [] pem_data,
		bool overwrite
	) {
		this.Invoke("certificate_request_import_from_pem", new object [] {
				mode,
				csr_ids,
				pem_data,
				overwrite});

	}
	public System.IAsyncResult Begincertificate_request_import_from_pem(ManagementKeyCertificateManagementModeType mode,string [] csr_ids,string [] pem_data,bool overwrite, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("certificate_request_import_from_pem", new object[] {
			mode,
			csr_ids,
			pem_data,
			overwrite}, callback, asyncState);
	}
	public void Endcertificate_request_import_from_pem(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// export_all_to_archive_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	public void export_all_to_archive_file(
		ManagementKeyCertificateManagementModeType mode,
		string archive_location,
		string archive_name
	) {
		this.Invoke("export_all_to_archive_file", new object [] {
				mode,
				archive_location,
				archive_name});

	}
	public System.IAsyncResult Beginexport_all_to_archive_file(ManagementKeyCertificateManagementModeType mode,string archive_location,string archive_name, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("export_all_to_archive_file", new object[] {
			mode,
			archive_location,
			archive_name}, callback, asyncState);
	}
	public void Endexport_all_to_archive_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// export_all_to_archive_stream
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public byte [] export_all_to_archive_stream(
		ManagementKeyCertificateManagementModeType mode
	) {
		object [] results = this.Invoke("export_all_to_archive_stream", new object [] {
				mode});
		return ((byte [])(results[0]));
	}
	public System.IAsyncResult Beginexport_all_to_archive_stream(ManagementKeyCertificateManagementModeType mode, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("export_all_to_archive_stream", new object[] {
			mode}, callback, asyncState);
	}
	public byte [] Endexport_all_to_archive_stream(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((byte [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// export_to_archive_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	public void export_to_archive_file(
		ManagementKeyCertificateManagementModeType mode,
		string archive_location,
		string archive_name,
		string [] keys,
		string [] certs
	) {
		this.Invoke("export_to_archive_file", new object [] {
				mode,
				archive_location,
				archive_name,
				keys,
				certs});

	}
	public System.IAsyncResult Beginexport_to_archive_file(ManagementKeyCertificateManagementModeType mode,string archive_location,string archive_name,string [] keys,string [] certs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("export_to_archive_file", new object[] {
			mode,
			archive_location,
			archive_name,
			keys,
			certs}, callback, asyncState);
	}
	public void Endexport_to_archive_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// export_to_archive_stream
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public byte [] export_to_archive_stream(
		ManagementKeyCertificateManagementModeType mode,
		string [] keys,
		string [] certs
	) {
		object [] results = this.Invoke("export_to_archive_stream", new object [] {
				mode,
				keys,
				certs});
		return ((byte [])(results[0]));
	}
	public System.IAsyncResult Beginexport_to_archive_stream(ManagementKeyCertificateManagementModeType mode,string [] keys,string [] certs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("export_to_archive_stream", new object[] {
			mode,
			keys,
			certs}, callback, asyncState);
	}
	public byte [] Endexport_to_archive_stream(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((byte [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_certificate_bundle
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementKeyCertificateCertificateDetail [] [] get_certificate_bundle(
		ManagementKeyCertificateManagementModeType mode,
		string [] file_names
	) {
		object [] results = this.Invoke("get_certificate_bundle", new object [] {
				mode,
				file_names});
		return ((ManagementKeyCertificateCertificateDetail [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_certificate_bundle(ManagementKeyCertificateManagementModeType mode,string [] file_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_certificate_bundle", new object[] {
			mode,
			file_names}, callback, asyncState);
	}
	public ManagementKeyCertificateCertificateDetail [] [] Endget_certificate_bundle(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementKeyCertificateCertificateDetail [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_certificate_bundle_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementKeyCertificateCertificateDetail_v2 [] [] get_certificate_bundle_v2(
		ManagementKeyCertificateManagementModeType mode,
		string [] file_names
	) {
		object [] results = this.Invoke("get_certificate_bundle_v2", new object [] {
				mode,
				file_names});
		return ((ManagementKeyCertificateCertificateDetail_v2 [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_certificate_bundle_v2(ManagementKeyCertificateManagementModeType mode,string [] file_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_certificate_bundle_v2", new object[] {
			mode,
			file_names}, callback, asyncState);
	}
	public ManagementKeyCertificateCertificateDetail_v2 [] [] Endget_certificate_bundle_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementKeyCertificateCertificateDetail_v2 [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_certificate_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementKeyCertificateCertificateInformation [] get_certificate_list(
		ManagementKeyCertificateManagementModeType mode
	) {
		object [] results = this.Invoke("get_certificate_list", new object [] {
				mode});
		return ((ManagementKeyCertificateCertificateInformation [])(results[0]));
	}
	public System.IAsyncResult Beginget_certificate_list(ManagementKeyCertificateManagementModeType mode, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_certificate_list", new object[] {
			mode}, callback, asyncState);
	}
	public ManagementKeyCertificateCertificateInformation [] Endget_certificate_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementKeyCertificateCertificateInformation [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_certificate_list_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementKeyCertificateCertificateInformation_v2 [] get_certificate_list_v2(
		ManagementKeyCertificateManagementModeType mode
	) {
		object [] results = this.Invoke("get_certificate_list_v2", new object [] {
				mode});
		return ((ManagementKeyCertificateCertificateInformation_v2 [])(results[0]));
	}
	public System.IAsyncResult Beginget_certificate_list_v2(ManagementKeyCertificateManagementModeType mode, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_certificate_list_v2", new object[] {
			mode}, callback, asyncState);
	}
	public ManagementKeyCertificateCertificateInformation_v2 [] Endget_certificate_list_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementKeyCertificateCertificateInformation_v2 [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_certificate_request_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementKeyCertificateCertificateRequestInformation [] get_certificate_request_list(
		ManagementKeyCertificateManagementModeType mode
	) {
		object [] results = this.Invoke("get_certificate_request_list", new object [] {
				mode});
		return ((ManagementKeyCertificateCertificateRequestInformation [])(results[0]));
	}
	public System.IAsyncResult Beginget_certificate_request_list(ManagementKeyCertificateManagementModeType mode, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_certificate_request_list", new object[] {
			mode}, callback, asyncState);
	}
	public ManagementKeyCertificateCertificateRequestInformation [] Endget_certificate_request_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementKeyCertificateCertificateRequestInformation [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_certificate_request_list_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementKeyCertificateCertificateRequestInformation_v2 [] get_certificate_request_list_v2(
		ManagementKeyCertificateManagementModeType mode
	) {
		object [] results = this.Invoke("get_certificate_request_list_v2", new object [] {
				mode});
		return ((ManagementKeyCertificateCertificateRequestInformation_v2 [])(results[0]));
	}
	public System.IAsyncResult Beginget_certificate_request_list_v2(ManagementKeyCertificateManagementModeType mode, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_certificate_request_list_v2", new object[] {
			mode}, callback, asyncState);
	}
	public ManagementKeyCertificateCertificateRequestInformation_v2 [] Endget_certificate_request_list_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementKeyCertificateCertificateRequestInformation_v2 [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_certificate_request_subject_alternative_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_certificate_request_subject_alternative_name(
		ManagementKeyCertificateManagementModeType mode,
		string [] files
	) {
		object [] results = this.Invoke("get_certificate_request_subject_alternative_name", new object [] {
				mode,
				files});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_certificate_request_subject_alternative_name(ManagementKeyCertificateManagementModeType mode,string [] files, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_certificate_request_subject_alternative_name", new object[] {
			mode,
			files}, callback, asyncState);
	}
	public string [] Endget_certificate_request_subject_alternative_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_certificate_subject_alternative_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_certificate_subject_alternative_name(
		ManagementKeyCertificateManagementModeType mode,
		string [] file_names
	) {
		object [] results = this.Invoke("get_certificate_subject_alternative_name", new object [] {
				mode,
				file_names});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_certificate_subject_alternative_name(ManagementKeyCertificateManagementModeType mode,string [] file_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_certificate_subject_alternative_name", new object[] {
			mode,
			file_names}, callback, asyncState);
	}
	public string [] Endget_certificate_subject_alternative_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_certificate_subject_alternative_name_bundle
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_certificate_subject_alternative_name_bundle(
		ManagementKeyCertificateManagementModeType mode,
		string [] file_names
	) {
		object [] results = this.Invoke("get_certificate_subject_alternative_name_bundle", new object [] {
				mode,
				file_names});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_certificate_subject_alternative_name_bundle(ManagementKeyCertificateManagementModeType mode,string [] file_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_certificate_subject_alternative_name_bundle", new object[] {
			mode,
			file_names}, callback, asyncState);
	}
	public string [] [] Endget_certificate_subject_alternative_name_bundle(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_key_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementKeyCertificateKeyInformation [] get_key_list(
		ManagementKeyCertificateManagementModeType mode
	) {
		object [] results = this.Invoke("get_key_list", new object [] {
				mode});
		return ((ManagementKeyCertificateKeyInformation [])(results[0]));
	}
	public System.IAsyncResult Beginget_key_list(ManagementKeyCertificateManagementModeType mode, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_key_list", new object[] {
			mode}, callback, asyncState);
	}
	public ManagementKeyCertificateKeyInformation [] Endget_key_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementKeyCertificateKeyInformation [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_key_list_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementKeyCertificateKeyInformation_v2 [] get_key_list_v2(
		ManagementKeyCertificateManagementModeType mode
	) {
		object [] results = this.Invoke("get_key_list_v2", new object [] {
				mode});
		return ((ManagementKeyCertificateKeyInformation_v2 [])(results[0]));
	}
	public System.IAsyncResult Beginget_key_list_v2(ManagementKeyCertificateManagementModeType mode, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_key_list_v2", new object[] {
			mode}, callback, asyncState);
	}
	public ManagementKeyCertificateKeyInformation_v2 [] Endget_key_list_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementKeyCertificateKeyInformation_v2 [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_valid_key_sizes
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] [] get_valid_key_sizes(
		ManagementKeyCertificateManagementModeType mode,
		ManagementKeyCertificateKeyType [] key_types,
		bool [] fips
	) {
		object [] results = this.Invoke("get_valid_key_sizes", new object [] {
				mode,
				key_types,
				fips});
		return ((long [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_valid_key_sizes(ManagementKeyCertificateManagementModeType mode,ManagementKeyCertificateKeyType [] key_types,bool [] fips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_valid_key_sizes", new object[] {
			mode,
			key_types,
			fips}, callback, asyncState);
	}
	public long [] [] Endget_valid_key_sizes(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
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
	// import_all_from_archive_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	public void import_all_from_archive_file(
		ManagementKeyCertificateManagementModeType mode,
		string archive_location,
		string archive_name
	) {
		this.Invoke("import_all_from_archive_file", new object [] {
				mode,
				archive_location,
				archive_name});

	}
	public System.IAsyncResult Beginimport_all_from_archive_file(ManagementKeyCertificateManagementModeType mode,string archive_location,string archive_name, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("import_all_from_archive_file", new object[] {
			mode,
			archive_location,
			archive_name}, callback, asyncState);
	}
	public void Endimport_all_from_archive_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// import_all_from_archive_stream
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	public void import_all_from_archive_stream(
		ManagementKeyCertificateManagementModeType mode,
		byte [] archive_stream
	) {
		this.Invoke("import_all_from_archive_stream", new object [] {
				mode,
				archive_stream});

	}
	public System.IAsyncResult Beginimport_all_from_archive_stream(ManagementKeyCertificateManagementModeType mode,byte [] archive_stream, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("import_all_from_archive_stream", new object[] {
			mode,
			archive_stream}, callback, asyncState);
	}
	public void Endimport_all_from_archive_stream(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// import_from_archive_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	public void import_from_archive_file(
		ManagementKeyCertificateManagementModeType mode,
		string archive_location,
		string archive_name,
		string [] keys,
		string [] certs
	) {
		this.Invoke("import_from_archive_file", new object [] {
				mode,
				archive_location,
				archive_name,
				keys,
				certs});

	}
	public System.IAsyncResult Beginimport_from_archive_file(ManagementKeyCertificateManagementModeType mode,string archive_location,string archive_name,string [] keys,string [] certs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("import_from_archive_file", new object[] {
			mode,
			archive_location,
			archive_name,
			keys,
			certs}, callback, asyncState);
	}
	public void Endimport_from_archive_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// import_from_archive_stream
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	public void import_from_archive_stream(
		ManagementKeyCertificateManagementModeType mode,
		byte [] archive_stream,
		string [] keys,
		string [] certs
	) {
		this.Invoke("import_from_archive_stream", new object [] {
				mode,
				archive_stream,
				keys,
				certs});

	}
	public System.IAsyncResult Beginimport_from_archive_stream(ManagementKeyCertificateManagementModeType mode,byte [] archive_stream,string [] keys,string [] certs, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("import_from_archive_stream", new object[] {
			mode,
			archive_stream,
			keys,
			certs}, callback, asyncState);
	}
	public void Endimport_from_archive_stream(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// is_fips_available
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool is_fips_available(
		ManagementKeyCertificateManagementModeType mode
	) {
		object [] results = this.Invoke("is_fips_available", new object [] {
				mode});
		return ((bool)(results[0]));
	}
	public System.IAsyncResult Beginis_fips_available(ManagementKeyCertificateManagementModeType mode, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("is_fips_available", new object[] {
			mode}, callback, asyncState);
	}
	public bool Endis_fips_available(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool)(results[0]));
	}

	//-----------------------------------------------------------------------
	// key_certificate_import_from_pem
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	public void key_certificate_import_from_pem(
		ManagementKeyCertificateManagementModeType mode,
		string [] ids,
		string [] key_pem_data,
		ManagementKeyCertificateSecurityType security,
		string [] passwords,
		string [] certificate_pem_data,
		bool overwrite
	) {
		this.Invoke("key_certificate_import_from_pem", new object [] {
				mode,
				ids,
				key_pem_data,
				security,
				passwords,
				certificate_pem_data,
				overwrite});

	}
	public System.IAsyncResult Beginkey_certificate_import_from_pem(ManagementKeyCertificateManagementModeType mode,string [] ids,string [] key_pem_data,ManagementKeyCertificateSecurityType security,string [] passwords,string [] certificate_pem_data,bool overwrite, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("key_certificate_import_from_pem", new object[] {
			mode,
			ids,
			key_pem_data,
			security,
			passwords,
			certificate_pem_data,
			overwrite}, callback, asyncState);
	}
	public void Endkey_certificate_import_from_pem(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// key_delete
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	public void key_delete(
		ManagementKeyCertificateManagementModeType mode,
		string [] key_ids
	) {
		this.Invoke("key_delete", new object [] {
				mode,
				key_ids});

	}
	public System.IAsyncResult Beginkey_delete(ManagementKeyCertificateManagementModeType mode,string [] key_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("key_delete", new object[] {
			mode,
			key_ids}, callback, asyncState);
	}
	public void Endkey_delete(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// key_export_to_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	public void key_export_to_file(
		ManagementKeyCertificateManagementModeType mode,
		string [] key_ids,
		string [] file_names,
		bool overwrite
	) {
		this.Invoke("key_export_to_file", new object [] {
				mode,
				key_ids,
				file_names,
				overwrite});

	}
	public System.IAsyncResult Beginkey_export_to_file(ManagementKeyCertificateManagementModeType mode,string [] key_ids,string [] file_names,bool overwrite, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("key_export_to_file", new object[] {
			mode,
			key_ids,
			file_names,
			overwrite}, callback, asyncState);
	}
	public void Endkey_export_to_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// key_export_to_pem
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] key_export_to_pem(
		ManagementKeyCertificateManagementModeType mode,
		string [] key_ids
	) {
		object [] results = this.Invoke("key_export_to_pem", new object [] {
				mode,
				key_ids});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginkey_export_to_pem(ManagementKeyCertificateManagementModeType mode,string [] key_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("key_export_to_pem", new object[] {
			mode,
			key_ids}, callback, asyncState);
	}
	public string [] Endkey_export_to_pem(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// key_generate
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	public void key_generate(
		ManagementKeyCertificateManagementModeType mode,
		ManagementKeyCertificateKey [] keys,
		ManagementKeyCertificateX509Data [] x509_data,
		bool create_optional_cert_csr,
		bool overwrite
	) {
		this.Invoke("key_generate", new object [] {
				mode,
				keys,
				x509_data,
				create_optional_cert_csr,
				overwrite});

	}
	public System.IAsyncResult Beginkey_generate(ManagementKeyCertificateManagementModeType mode,ManagementKeyCertificateKey [] keys,ManagementKeyCertificateX509Data [] x509_data,bool create_optional_cert_csr,bool overwrite, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("key_generate", new object[] {
			mode,
			keys,
			x509_data,
			create_optional_cert_csr,
			overwrite}, callback, asyncState);
	}
	public void Endkey_generate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// key_generate_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	public void key_generate_v2(
		ManagementKeyCertificateManagementModeType mode,
		ManagementKeyCertificateKey_v2 [] keys,
		ManagementKeyCertificateX509Data [] x509_data,
		bool create_optional_cert_csr,
		bool overwrite
	) {
		this.Invoke("key_generate_v2", new object [] {
				mode,
				keys,
				x509_data,
				create_optional_cert_csr,
				overwrite});

	}
	public System.IAsyncResult Beginkey_generate_v2(ManagementKeyCertificateManagementModeType mode,ManagementKeyCertificateKey_v2 [] keys,ManagementKeyCertificateX509Data [] x509_data,bool create_optional_cert_csr,bool overwrite, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("key_generate_v2", new object[] {
			mode,
			keys,
			x509_data,
			create_optional_cert_csr,
			overwrite}, callback, asyncState);
	}
	public void Endkey_generate_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// key_import_from_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	public void key_import_from_file(
		ManagementKeyCertificateManagementModeType mode,
		string [] key_ids,
		string [] file_names,
		bool overwrite
	) {
		this.Invoke("key_import_from_file", new object [] {
				mode,
				key_ids,
				file_names,
				overwrite});

	}
	public System.IAsyncResult Beginkey_import_from_file(ManagementKeyCertificateManagementModeType mode,string [] key_ids,string [] file_names,bool overwrite, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("key_import_from_file", new object[] {
			mode,
			key_ids,
			file_names,
			overwrite}, callback, asyncState);
	}
	public void Endkey_import_from_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// key_import_from_pem
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	public void key_import_from_pem(
		ManagementKeyCertificateManagementModeType mode,
		string [] key_ids,
		string [] pem_data,
		bool overwrite
	) {
		this.Invoke("key_import_from_pem", new object [] {
				mode,
				key_ids,
				pem_data,
				overwrite});

	}
	public System.IAsyncResult Beginkey_import_from_pem(ManagementKeyCertificateManagementModeType mode,string [] key_ids,string [] pem_data,bool overwrite, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("key_import_from_pem", new object[] {
			mode,
			key_ids,
			pem_data,
			overwrite}, callback, asyncState);
	}
	public void Endkey_import_from_pem(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// key_import_from_pem_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	public void key_import_from_pem_v2(
		ManagementKeyCertificateManagementModeType mode,
		string [] key_ids,
		string [] pem_data,
		ManagementKeyCertificateSecurityType security,
		string [] passwords,
		bool overwrite
	) {
		this.Invoke("key_import_from_pem_v2", new object [] {
				mode,
				key_ids,
				pem_data,
				security,
				passwords,
				overwrite});

	}
	public System.IAsyncResult Beginkey_import_from_pem_v2(ManagementKeyCertificateManagementModeType mode,string [] key_ids,string [] pem_data,ManagementKeyCertificateSecurityType security,string [] passwords,bool overwrite, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("key_import_from_pem_v2", new object[] {
			mode,
			key_ids,
			pem_data,
			security,
			passwords,
			overwrite}, callback, asyncState);
	}
	public void Endkey_import_from_pem_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// key_to_fips
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	public void key_to_fips(
		ManagementKeyCertificateManagementModeType mode,
		string [] key_ids
	) {
		this.Invoke("key_to_fips", new object [] {
				mode,
				key_ids});

	}
	public System.IAsyncResult Beginkey_to_fips(ManagementKeyCertificateManagementModeType mode,string [] key_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("key_to_fips", new object[] {
			mode,
			key_ids}, callback, asyncState);
	}
	public void Endkey_to_fips(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// pkcs12_import_from_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	public void pkcs12_import_from_file(
		ManagementKeyCertificateManagementModeType mode,
		string [] ids,
		string [] file_names,
		string [] passwords,
		bool overwrite
	) {
		this.Invoke("pkcs12_import_from_file", new object [] {
				mode,
				ids,
				file_names,
				passwords,
				overwrite});

	}
	public System.IAsyncResult Beginpkcs12_import_from_file(ManagementKeyCertificateManagementModeType mode,string [] ids,string [] file_names,string [] passwords,bool overwrite, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("pkcs12_import_from_file", new object[] {
			mode,
			ids,
			file_names,
			passwords,
			overwrite}, callback, asyncState);
	}
	public void Endpkcs12_import_from_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// pkcs12_import_from_file_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/KeyCertificate", 
		RequestNamespace="urn:iControl:Management/KeyCertificate", ResponseNamespace="urn:iControl:Management/KeyCertificate")]
	public void pkcs12_import_from_file_v2(
		ManagementKeyCertificateManagementModeType mode,
		string [] ids,
		string [] file_names,
		string [] passwords,
		ManagementKeyCertificateSecurityType security,
		string [] key_passwords,
		bool overwrite
	) {
		this.Invoke("pkcs12_import_from_file_v2", new object [] {
				mode,
				ids,
				file_names,
				passwords,
				security,
				key_passwords,
				overwrite});

	}
	public System.IAsyncResult Beginpkcs12_import_from_file_v2(ManagementKeyCertificateManagementModeType mode,string [] ids,string [] file_names,string [] passwords,ManagementKeyCertificateSecurityType security,string [] key_passwords,bool overwrite, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("pkcs12_import_from_file_v2", new object[] {
			mode,
			ids,
			file_names,
			passwords,
			security,
			key_passwords,
			overwrite}, callback, asyncState);
	}
	public void Endpkcs12_import_from_file_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.KeyCertificate.CertificateExtensionType", Namespace = "urn:iControl")]
	public enum ManagementKeyCertificateCertificateExtensionType
	{
		CERTIFICATE_EXTENSION_UNKNOWN,
		CERTIFICATE_EXTENSION_NONE,
		CERTIFICATE_EXTENSION_SAN,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.KeyCertificate.CertificateType", Namespace = "urn:iControl")]
	public enum ManagementKeyCertificateCertificateType
	{
		CTYPE_CA_SIGNED_YES,
		CTYPE_CA_SIGNED_NO,
		CTYPE_CA_SIGNED_UNKNOWN,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.KeyCertificate.CurveName", Namespace = "urn:iControl")]
	public enum ManagementKeyCertificateCurveName
	{
		ELLIPTIC_CURVE_NONE,
		ELLIPTIC_CURVE_PRIME256V1,
		ELLIPTIC_CURVE_SECP384R1,
		ELLIPTIC_CURVE_SECP521R1,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.KeyCertificate.KeyType", Namespace = "urn:iControl")]
	public enum ManagementKeyCertificateKeyType
	{
		KTYPE_RSA_PRIVATE,
		KTYPE_RSA_PUBLIC,
		KTYPE_DSA_PRIVATE,
		KTYPE_DSA_PUBLIC,
		KTYPE_EC_PRIVATE,
		KTYPE_EC_PUBLIC,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.KeyCertificate.ManagementModeType", Namespace = "urn:iControl")]
	public enum ManagementKeyCertificateManagementModeType
	{
		MANAGEMENT_MODE_DEFAULT,
		MANAGEMENT_MODE_WEBSERVER,
		MANAGEMENT_MODE_EM,
		MANAGEMENT_MODE_IQUERY,
		MANAGEMENT_MODE_IQUERY_BIG3D,
		MANAGEMENT_MODE_APACHE,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.KeyCertificate.SecurityType", Namespace = "urn:iControl")]
	public enum ManagementKeyCertificateSecurityType
	{
		STYPE_NORMAL,
		STYPE_FIPS,
		STYPE_PASSWORD,
		STYPE_NETHSM,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.KeyCertificate.ValidityType", Namespace = "urn:iControl")]
	public enum ManagementKeyCertificateValidityType
	{
		VTYPE_CERTIFICATE_VALID,
		VTYPE_CERTIFICATE_EXPIRED,
		VTYPE_CERTIFICATE_WILL_EXPIRE,
		VTYPE_CERTIFICATE_INVALID,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.KeyCertificate.Certificate", Namespace = "urn:iControl")]
	public partial class ManagementKeyCertificateCertificate
	{
		private string idField;
		public string id
		{
			get { return this.idField; }
			set { this.idField = value; }
		}
		private string emailField;
		public string email
		{
			get { return this.emailField; }
			set { this.emailField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.KeyCertificate.CertificateDetail", Namespace = "urn:iControl")]
	public partial class ManagementKeyCertificateCertificateDetail
	{
		private ManagementKeyCertificateCertificate cert_infoField;
		public ManagementKeyCertificateCertificate cert_info
		{
			get { return this.cert_infoField; }
			set { this.cert_infoField = value; }
		}
		private ManagementKeyCertificateCertificateType cert_typeField;
		public ManagementKeyCertificateCertificateType cert_type
		{
			get { return this.cert_typeField; }
			set { this.cert_typeField = value; }
		}
		private ManagementKeyCertificateKeyType key_typeField;
		public ManagementKeyCertificateKeyType key_type
		{
			get { return this.key_typeField; }
			set { this.key_typeField = value; }
		}
		private long bit_lengthField;
		public long bit_length
		{
			get { return this.bit_lengthField; }
			set { this.bit_lengthField = value; }
		}
		private long versionField;
		public long version
		{
			get { return this.versionField; }
			set { this.versionField = value; }
		}
		private string serial_numberField;
		public string serial_number
		{
			get { return this.serial_numberField; }
			set { this.serial_numberField = value; }
		}
		private string expiration_stringField;
		public string expiration_string
		{
			get { return this.expiration_stringField; }
			set { this.expiration_stringField = value; }
		}
		private long expiration_dateField;
		public long expiration_date
		{
			get { return this.expiration_dateField; }
			set { this.expiration_dateField = value; }
		}
		private ManagementKeyCertificateX509Data subjectField;
		public ManagementKeyCertificateX509Data subject
		{
			get { return this.subjectField; }
			set { this.subjectField = value; }
		}
		private ManagementKeyCertificateX509Data issuerField;
		public ManagementKeyCertificateX509Data issuer
		{
			get { return this.issuerField; }
			set { this.issuerField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.KeyCertificate.CertificateDetail_v2", Namespace = "urn:iControl")]
	public partial class ManagementKeyCertificateCertificateDetail_v2
	{
		private ManagementKeyCertificateCertificate cert_infoField;
		public ManagementKeyCertificateCertificate cert_info
		{
			get { return this.cert_infoField; }
			set { this.cert_infoField = value; }
		}
		private ManagementKeyCertificateCertificateType cert_typeField;
		public ManagementKeyCertificateCertificateType cert_type
		{
			get { return this.cert_typeField; }
			set { this.cert_typeField = value; }
		}
		private ManagementKeyCertificateKeyType key_typeField;
		public ManagementKeyCertificateKeyType key_type
		{
			get { return this.key_typeField; }
			set { this.key_typeField = value; }
		}
		private long bit_lengthField;
		public long bit_length
		{
			get { return this.bit_lengthField; }
			set { this.bit_lengthField = value; }
		}
		private long versionField;
		public long version
		{
			get { return this.versionField; }
			set { this.versionField = value; }
		}
		private string serial_numberField;
		public string serial_number
		{
			get { return this.serial_numberField; }
			set { this.serial_numberField = value; }
		}
		private string expiration_stringField;
		public string expiration_string
		{
			get { return this.expiration_stringField; }
			set { this.expiration_stringField = value; }
		}
		private long expiration_dateField;
		public long expiration_date
		{
			get { return this.expiration_dateField; }
			set { this.expiration_dateField = value; }
		}
		private ManagementKeyCertificateX509Data subjectField;
		public ManagementKeyCertificateX509Data subject
		{
			get { return this.subjectField; }
			set { this.subjectField = value; }
		}
		private ManagementKeyCertificateX509Data issuerField;
		public ManagementKeyCertificateX509Data issuer
		{
			get { return this.issuerField; }
			set { this.issuerField = value; }
		}
		private ManagementKeyCertificateCurveName curve_nameField;
		public ManagementKeyCertificateCurveName curve_name
		{
			get { return this.curve_nameField; }
			set { this.curve_nameField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.KeyCertificate.CertificateExtension", Namespace = "urn:iControl")]
	public partial class ManagementKeyCertificateCertificateExtension
	{
		private ManagementKeyCertificateCertificateExtensionType extension_typeField;
		public ManagementKeyCertificateCertificateExtensionType extension_type
		{
			get { return this.extension_typeField; }
			set { this.extension_typeField = value; }
		}
		private string valueField;
		public string value
		{
			get { return this.valueField; }
			set { this.valueField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.KeyCertificate.CertificateInformation", Namespace = "urn:iControl")]
	public partial class ManagementKeyCertificateCertificateInformation
	{
		private bool is_bundledField;
		public bool is_bundled
		{
			get { return this.is_bundledField; }
			set { this.is_bundledField = value; }
		}
		private string file_nameField;
		public string file_name
		{
			get { return this.file_nameField; }
			set { this.file_nameField = value; }
		}
		private ManagementKeyCertificateCertificateDetail certificateField;
		public ManagementKeyCertificateCertificateDetail certificate
		{
			get { return this.certificateField; }
			set { this.certificateField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.KeyCertificate.CertificateInformation_v2", Namespace = "urn:iControl")]
	public partial class ManagementKeyCertificateCertificateInformation_v2
	{
		private bool is_bundledField;
		public bool is_bundled
		{
			get { return this.is_bundledField; }
			set { this.is_bundledField = value; }
		}
		private string file_nameField;
		public string file_name
		{
			get { return this.file_nameField; }
			set { this.file_nameField = value; }
		}
		private ManagementKeyCertificateCertificateDetail_v2 certificateField;
		public ManagementKeyCertificateCertificateDetail_v2 certificate
		{
			get { return this.certificateField; }
			set { this.certificateField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.KeyCertificate.CertificateRequest", Namespace = "urn:iControl")]
	public partial class ManagementKeyCertificateCertificateRequest
	{
		private string idField;
		public string id
		{
			get { return this.idField; }
			set { this.idField = value; }
		}
		private string emailField;
		public string email
		{
			get { return this.emailField; }
			set { this.emailField = value; }
		}
		private string challenge_passwordField;
		public string challenge_password
		{
			get { return this.challenge_passwordField; }
			set { this.challenge_passwordField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.KeyCertificate.CertificateRequestInformation", Namespace = "urn:iControl")]
	public partial class ManagementKeyCertificateCertificateRequestInformation
	{
		private ManagementKeyCertificateCertificateRequest csr_infoField;
		public ManagementKeyCertificateCertificateRequest csr_info
		{
			get { return this.csr_infoField; }
			set { this.csr_infoField = value; }
		}
		private string titleField;
		public string title
		{
			get { return this.titleField; }
			set { this.titleField = value; }
		}
		private string serial_numberField;
		public string serial_number
		{
			get { return this.serial_numberField; }
			set { this.serial_numberField = value; }
		}
		private string file_nameField;
		public string file_name
		{
			get { return this.file_nameField; }
			set { this.file_nameField = value; }
		}
		private ManagementKeyCertificateKeyType key_typeField;
		public ManagementKeyCertificateKeyType key_type
		{
			get { return this.key_typeField; }
			set { this.key_typeField = value; }
		}
		private long bit_lengthField;
		public long bit_length
		{
			get { return this.bit_lengthField; }
			set { this.bit_lengthField = value; }
		}
		private ManagementKeyCertificateX509Data subjectField;
		public ManagementKeyCertificateX509Data subject
		{
			get { return this.subjectField; }
			set { this.subjectField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.KeyCertificate.CertificateRequestInformation_v2", Namespace = "urn:iControl")]
	public partial class ManagementKeyCertificateCertificateRequestInformation_v2
	{
		private ManagementKeyCertificateCertificateRequest csr_infoField;
		public ManagementKeyCertificateCertificateRequest csr_info
		{
			get { return this.csr_infoField; }
			set { this.csr_infoField = value; }
		}
		private string titleField;
		public string title
		{
			get { return this.titleField; }
			set { this.titleField = value; }
		}
		private string serial_numberField;
		public string serial_number
		{
			get { return this.serial_numberField; }
			set { this.serial_numberField = value; }
		}
		private string file_nameField;
		public string file_name
		{
			get { return this.file_nameField; }
			set { this.file_nameField = value; }
		}
		private ManagementKeyCertificateKeyType key_typeField;
		public ManagementKeyCertificateKeyType key_type
		{
			get { return this.key_typeField; }
			set { this.key_typeField = value; }
		}
		private long bit_lengthField;
		public long bit_length
		{
			get { return this.bit_lengthField; }
			set { this.bit_lengthField = value; }
		}
		private ManagementKeyCertificateX509Data subjectField;
		public ManagementKeyCertificateX509Data subject
		{
			get { return this.subjectField; }
			set { this.subjectField = value; }
		}
		private ManagementKeyCertificateCurveName curve_nameField;
		public ManagementKeyCertificateCurveName curve_name
		{
			get { return this.curve_nameField; }
			set { this.curve_nameField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.KeyCertificate.Key", Namespace = "urn:iControl")]
	public partial class ManagementKeyCertificateKey
	{
		private string idField;
		public string id
		{
			get { return this.idField; }
			set { this.idField = value; }
		}
		private ManagementKeyCertificateKeyType key_typeField;
		public ManagementKeyCertificateKeyType key_type
		{
			get { return this.key_typeField; }
			set { this.key_typeField = value; }
		}
		private long bit_lengthField;
		public long bit_length
		{
			get { return this.bit_lengthField; }
			set { this.bit_lengthField = value; }
		}
		private ManagementKeyCertificateSecurityType securityField;
		public ManagementKeyCertificateSecurityType security
		{
			get { return this.securityField; }
			set { this.securityField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.KeyCertificate.KeyInformation", Namespace = "urn:iControl")]
	public partial class ManagementKeyCertificateKeyInformation
	{
		private ManagementKeyCertificateKey key_infoField;
		public ManagementKeyCertificateKey key_info
		{
			get { return this.key_infoField; }
			set { this.key_infoField = value; }
		}
		private string file_nameField;
		public string file_name
		{
			get { return this.file_nameField; }
			set { this.file_nameField = value; }
		}
		private long flagsField;
		public long flags
		{
			get { return this.flagsField; }
			set { this.flagsField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.KeyCertificate.KeyInformation_v2", Namespace = "urn:iControl")]
	public partial class ManagementKeyCertificateKeyInformation_v2
	{
		private ManagementKeyCertificateKey_v2 key_infoField;
		public ManagementKeyCertificateKey_v2 key_info
		{
			get { return this.key_infoField; }
			set { this.key_infoField = value; }
		}
		private string file_nameField;
		public string file_name
		{
			get { return this.file_nameField; }
			set { this.file_nameField = value; }
		}
		private long flagsField;
		public long flags
		{
			get { return this.flagsField; }
			set { this.flagsField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.KeyCertificate.Key_v2", Namespace = "urn:iControl")]
	public partial class ManagementKeyCertificateKey_v2
	{
		private string idField;
		public string id
		{
			get { return this.idField; }
			set { this.idField = value; }
		}
		private ManagementKeyCertificateKeyType key_typeField;
		public ManagementKeyCertificateKeyType key_type
		{
			get { return this.key_typeField; }
			set { this.key_typeField = value; }
		}
		private long bit_lengthField;
		public long bit_length
		{
			get { return this.bit_lengthField; }
			set { this.bit_lengthField = value; }
		}
		private ManagementKeyCertificateSecurityType securityField;
		public ManagementKeyCertificateSecurityType security
		{
			get { return this.securityField; }
			set { this.securityField = value; }
		}
		private ManagementKeyCertificateCurveName curve_nameField;
		public ManagementKeyCertificateCurveName curve_name
		{
			get { return this.curve_nameField; }
			set { this.curve_nameField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.KeyCertificate.X509Data", Namespace = "urn:iControl")]
	public partial class ManagementKeyCertificateX509Data
	{
		private string common_nameField;
		public string common_name
		{
			get { return this.common_nameField; }
			set { this.common_nameField = value; }
		}
		private string country_nameField;
		public string country_name
		{
			get { return this.country_nameField; }
			set { this.country_nameField = value; }
		}
		private string state_nameField;
		public string state_name
		{
			get { return this.state_nameField; }
			set { this.state_nameField = value; }
		}
		private string locality_nameField;
		public string locality_name
		{
			get { return this.locality_nameField; }
			set { this.locality_nameField = value; }
		}
		private string organization_nameField;
		public string organization_name
		{
			get { return this.organization_nameField; }
			set { this.organization_nameField = value; }
		}
		private string division_nameField;
		public string division_name
		{
			get { return this.division_nameField; }
			set { this.division_nameField = value; }
		}
	};

}
