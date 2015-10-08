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
	[System.Web.Services.WebServiceBindingAttribute(Name="GlobalLB.DNSSECKeyBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonULong64))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonTimeStamp))]
	public partial class GlobalLBDNSSECKey : iControlInterface {
		public GlobalLBDNSSECKey() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECKey", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECKey", ResponseNamespace="urn:iControl:GlobalLB/DNSSECKey")]
	public void create(
		string [] keys,
		long [] sizes,
		GlobalLBDNSSECKeyKeyType [] types,
		GlobalLBDNSSECKeyKeyAlgorithm [] algorithms,
		CommonEnabledState [] fips
	) {
		this.Invoke("create", new object [] {
				keys,
				sizes,
				types,
				algorithms,
				fips});

	}
	public System.IAsyncResult Begincreate(string [] keys,long [] sizes,GlobalLBDNSSECKeyKeyType [] types,GlobalLBDNSSECKeyKeyAlgorithm [] algorithms,CommonEnabledState [] fips, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			keys,
			sizes,
			types,
			algorithms,
			fips}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create_manual
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECKey", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECKey", ResponseNamespace="urn:iControl:GlobalLB/DNSSECKey")]
	public void create_manual(
		string [] keys,
		GlobalLBDNSSECKeyKeyType [] types,
		GlobalLBDNSSECKeyKeyAlgorithm [] algorithms,
		GlobalLBHardwareSecurityModuleType [] hsm_types,
		string [] cert_files,
		string [] key_files
	) {
		this.Invoke("create_manual", new object [] {
				keys,
				types,
				algorithms,
				hsm_types,
				cert_files,
				key_files});

	}
	public System.IAsyncResult Begincreate_manual(string [] keys,GlobalLBDNSSECKeyKeyType [] types,GlobalLBDNSSECKeyKeyAlgorithm [] algorithms,GlobalLBHardwareSecurityModuleType [] hsm_types,string [] cert_files,string [] key_files, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_manual", new object[] {
			keys,
			types,
			algorithms,
			hsm_types,
			cert_files,
			key_files}, callback, asyncState);
	}
	public void Endcreate_manual(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// create_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECKey", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECKey", ResponseNamespace="urn:iControl:GlobalLB/DNSSECKey")]
	public void create_v2(
		string [] keys,
		long [] sizes,
		GlobalLBDNSSECKeyKeyType [] types,
		GlobalLBDNSSECKeyKeyAlgorithm [] algorithms,
		GlobalLBHardwareSecurityModuleType [] hsm_types
	) {
		this.Invoke("create_v2", new object [] {
				keys,
				sizes,
				types,
				algorithms,
				hsm_types});

	}
	public System.IAsyncResult Begincreate_v2(string [] keys,long [] sizes,GlobalLBDNSSECKeyKeyType [] types,GlobalLBDNSSECKeyKeyAlgorithm [] algorithms,GlobalLBHardwareSecurityModuleType [] hsm_types, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create_v2", new object[] {
			keys,
			sizes,
			types,
			algorithms,
			hsm_types}, callback, asyncState);
	}
	public void Endcreate_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_all_keys
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECKey", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECKey", ResponseNamespace="urn:iControl:GlobalLB/DNSSECKey")]
	public void delete_all_keys(

	) {
		this.Invoke("delete_all_keys", new object [0]);

	}
	public System.IAsyncResult Begindelete_all_keys(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_all_keys", new object[0], callback, asyncState);
	}
	public void Enddelete_all_keys(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// delete_key
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECKey", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECKey", ResponseNamespace="urn:iControl:GlobalLB/DNSSECKey")]
	public void delete_key(
		string [] keys
	) {
		this.Invoke("delete_key", new object [] {
				keys});

	}
	public System.IAsyncResult Begindelete_key(string [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("delete_key", new object[] {
			keys}, callback, asyncState);
	}
	public void Enddelete_key(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_algorithm
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECKey", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECKey", ResponseNamespace="urn:iControl:GlobalLB/DNSSECKey")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBDNSSECKeyKeyAlgorithm [] get_algorithm(
		string [] keys
	) {
		object [] results = this.Invoke("get_algorithm", new object [] {
				keys});
		return ((GlobalLBDNSSECKeyKeyAlgorithm [])(results[0]));
	}
	public System.IAsyncResult Beginget_algorithm(string [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_algorithm", new object[] {
			keys}, callback, asyncState);
	}
	public GlobalLBDNSSECKeyKeyAlgorithm [] Endget_algorithm(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBDNSSECKeyKeyAlgorithm [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_certificate_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECKey", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECKey", ResponseNamespace="urn:iControl:GlobalLB/DNSSECKey")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_certificate_file(
		string [] keys
	) {
		object [] results = this.Invoke("get_certificate_file", new object [] {
				keys});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_certificate_file(string [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_certificate_file", new object[] {
			keys}, callback, asyncState);
	}
	public string [] Endget_certificate_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECKey", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECKey", ResponseNamespace="urn:iControl:GlobalLB/DNSSECKey")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] keys
	) {
		object [] results = this.Invoke("get_description", new object [] {
				keys});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			keys}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECKey", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECKey", ResponseNamespace="urn:iControl:GlobalLB/DNSSECKey")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_enabled_state(
		string [] keys
	) {
		object [] results = this.Invoke("get_enabled_state", new object [] {
				keys});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_enabled_state(string [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_enabled_state", new object[] {
			keys}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_expiration_period
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECKey", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECKey", ResponseNamespace="urn:iControl:GlobalLB/DNSSECKey")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_expiration_period(
		string [] keys
	) {
		object [] results = this.Invoke("get_expiration_period", new object [] {
				keys});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_expiration_period(string [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_expiration_period", new object[] {
			keys}, callback, asyncState);
	}
	public long [] Endget_expiration_period(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fips_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECKey", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECKey", ResponseNamespace="urn:iControl:GlobalLB/DNSSECKey")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_fips_state(
		string [] keys
	) {
		object [] results = this.Invoke("get_fips_state", new object [] {
				keys});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_fips_state(string [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fips_state", new object[] {
			keys}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_fips_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_generation
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECKey", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECKey", ResponseNamespace="urn:iControl:GlobalLB/DNSSECKey")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonULong64 [] [] get_generation(
		string [] keys
	) {
		object [] results = this.Invoke("get_generation", new object [] {
				keys});
		return ((CommonULong64 [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_generation(string [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_generation", new object[] {
			keys}, callback, asyncState);
	}
	public CommonULong64 [] [] Endget_generation(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonULong64 [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_generation_creator
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECKey", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECKey", ResponseNamespace="urn:iControl:GlobalLB/DNSSECKey")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_generation_creator(
		string [] keys,
		CommonULong64 [] [] generations
	) {
		object [] results = this.Invoke("get_generation_creator", new object [] {
				keys,
				generations});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_generation_creator(string [] keys,CommonULong64 [] [] generations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_generation_creator", new object[] {
			keys,
			generations}, callback, asyncState);
	}
	public string [] [] Endget_generation_creator(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_generation_expiration_time
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECKey", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECKey", ResponseNamespace="urn:iControl:GlobalLB/DNSSECKey")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonTimeStamp [] [] get_generation_expiration_time(
		string [] keys,
		CommonULong64 [] [] generations
	) {
		object [] results = this.Invoke("get_generation_expiration_time", new object [] {
				keys,
				generations});
		return ((CommonTimeStamp [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_generation_expiration_time(string [] keys,CommonULong64 [] [] generations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_generation_expiration_time", new object[] {
			keys,
			generations}, callback, asyncState);
	}
	public CommonTimeStamp [] [] Endget_generation_expiration_time(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonTimeStamp [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_generation_key_tag
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECKey", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECKey", ResponseNamespace="urn:iControl:GlobalLB/DNSSECKey")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public short [] [] get_generation_key_tag(
		string [] keys,
		CommonULong64 [] [] generations
	) {
		object [] results = this.Invoke("get_generation_key_tag", new object [] {
				keys,
				generations});
		return ((short [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_generation_key_tag(string [] keys,CommonULong64 [] [] generations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_generation_key_tag", new object[] {
			keys,
			generations}, callback, asyncState);
	}
	public short [] [] Endget_generation_key_tag(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((short [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_generation_public_text
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECKey", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECKey", ResponseNamespace="urn:iControl:GlobalLB/DNSSECKey")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_generation_public_text(
		string [] keys,
		CommonULong64 [] [] generations
	) {
		object [] results = this.Invoke("get_generation_public_text", new object [] {
				keys,
				generations});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_generation_public_text(string [] keys,CommonULong64 [] [] generations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_generation_public_text", new object[] {
			keys,
			generations}, callback, asyncState);
	}
	public string [] [] Endget_generation_public_text(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_generation_rollover_time
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECKey", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECKey", ResponseNamespace="urn:iControl:GlobalLB/DNSSECKey")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonTimeStamp [] [] get_generation_rollover_time(
		string [] keys,
		CommonULong64 [] [] generations
	) {
		object [] results = this.Invoke("get_generation_rollover_time", new object [] {
				keys,
				generations});
		return ((CommonTimeStamp [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_generation_rollover_time(string [] keys,CommonULong64 [] [] generations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_generation_rollover_time", new object[] {
			keys,
			generations}, callback, asyncState);
	}
	public CommonTimeStamp [] [] Endget_generation_rollover_time(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonTimeStamp [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_hardware_security_module_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECKey", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECKey", ResponseNamespace="urn:iControl:GlobalLB/DNSSECKey")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBHardwareSecurityModuleType [] get_hardware_security_module_type(
		string [] keys
	) {
		object [] results = this.Invoke("get_hardware_security_module_type", new object [] {
				keys});
		return ((GlobalLBHardwareSecurityModuleType [])(results[0]));
	}
	public System.IAsyncResult Beginget_hardware_security_module_type(string [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_hardware_security_module_type", new object[] {
			keys}, callback, asyncState);
	}
	public GlobalLBHardwareSecurityModuleType [] Endget_hardware_security_module_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBHardwareSecurityModuleType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_key_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECKey", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECKey", ResponseNamespace="urn:iControl:GlobalLB/DNSSECKey")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_key_file(
		string [] keys
	) {
		object [] results = this.Invoke("get_key_file", new object [] {
				keys});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_key_file(string [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_key_file", new object[] {
			keys}, callback, asyncState);
	}
	public string [] Endget_key_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECKey", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECKey", ResponseNamespace="urn:iControl:GlobalLB/DNSSECKey")]
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
	// get_rollover_period
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECKey", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECKey", ResponseNamespace="urn:iControl:GlobalLB/DNSSECKey")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_rollover_period(
		string [] keys
	) {
		object [] results = this.Invoke("get_rollover_period", new object [] {
				keys});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_rollover_period(string [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_rollover_period", new object[] {
			keys}, callback, asyncState);
	}
	public long [] Endget_rollover_period(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_signature_publication_period
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECKey", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECKey", ResponseNamespace="urn:iControl:GlobalLB/DNSSECKey")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_signature_publication_period(
		string [] keys
	) {
		object [] results = this.Invoke("get_signature_publication_period", new object [] {
				keys});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_signature_publication_period(string [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_signature_publication_period", new object[] {
			keys}, callback, asyncState);
	}
	public long [] Endget_signature_publication_period(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_signature_validity_period
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECKey", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECKey", ResponseNamespace="urn:iControl:GlobalLB/DNSSECKey")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_signature_validity_period(
		string [] keys
	) {
		object [] results = this.Invoke("get_signature_validity_period", new object [] {
				keys});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_signature_validity_period(string [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_signature_validity_period", new object[] {
			keys}, callback, asyncState);
	}
	public long [] Endget_signature_validity_period(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_size
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECKey", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECKey", ResponseNamespace="urn:iControl:GlobalLB/DNSSECKey")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_size(
		string [] keys
	) {
		object [] results = this.Invoke("get_size", new object [] {
				keys});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_size(string [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_size", new object[] {
			keys}, callback, asyncState);
	}
	public long [] Endget_size(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_time_to_live
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECKey", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECKey", ResponseNamespace="urn:iControl:GlobalLB/DNSSECKey")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_time_to_live(
		string [] keys
	) {
		object [] results = this.Invoke("get_time_to_live", new object [] {
				keys});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_time_to_live(string [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_time_to_live", new object[] {
			keys}, callback, asyncState);
	}
	public long [] Endget_time_to_live(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECKey", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECKey", ResponseNamespace="urn:iControl:GlobalLB/DNSSECKey")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public GlobalLBDNSSECKeyKeyType [] get_type(
		string [] keys
	) {
		object [] results = this.Invoke("get_type", new object [] {
				keys});
		return ((GlobalLBDNSSECKeyKeyType [])(results[0]));
	}
	public System.IAsyncResult Beginget_type(string [] keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_type", new object[] {
			keys}, callback, asyncState);
	}
	public GlobalLBDNSSECKeyKeyType [] Endget_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((GlobalLBDNSSECKeyKeyType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECKey", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECKey", ResponseNamespace="urn:iControl:GlobalLB/DNSSECKey")]
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
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECKey", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECKey", ResponseNamespace="urn:iControl:GlobalLB/DNSSECKey")]
	public void set_description(
		string [] keys,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				keys,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] keys,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			keys,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECKey", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECKey", ResponseNamespace="urn:iControl:GlobalLB/DNSSECKey")]
	public void set_enabled_state(
		string [] keys,
		CommonEnabledState [] states
	) {
		this.Invoke("set_enabled_state", new object [] {
				keys,
				states});

	}
	public System.IAsyncResult Beginset_enabled_state(string [] keys,CommonEnabledState [] states, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_enabled_state", new object[] {
			keys,
			states}, callback, asyncState);
	}
	public void Endset_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_expiration_period
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECKey", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECKey", ResponseNamespace="urn:iControl:GlobalLB/DNSSECKey")]
	public void set_expiration_period(
		string [] keys,
		long [] times
	) {
		this.Invoke("set_expiration_period", new object [] {
				keys,
				times});

	}
	public System.IAsyncResult Beginset_expiration_period(string [] keys,long [] times, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_expiration_period", new object[] {
			keys,
			times}, callback, asyncState);
	}
	public void Endset_expiration_period(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_generation_expiration_time
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECKey", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECKey", ResponseNamespace="urn:iControl:GlobalLB/DNSSECKey")]
	public void set_generation_expiration_time(
		string [] keys,
		CommonULong64 [] [] generations,
		CommonTimeStamp [] [] times
	) {
		this.Invoke("set_generation_expiration_time", new object [] {
				keys,
				generations,
				times});

	}
	public System.IAsyncResult Beginset_generation_expiration_time(string [] keys,CommonULong64 [] [] generations,CommonTimeStamp [] [] times, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_generation_expiration_time", new object[] {
			keys,
			generations,
			times}, callback, asyncState);
	}
	public void Endset_generation_expiration_time(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_generation_rollover_time
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECKey", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECKey", ResponseNamespace="urn:iControl:GlobalLB/DNSSECKey")]
	public void set_generation_rollover_time(
		string [] keys,
		CommonULong64 [] [] generations,
		CommonTimeStamp [] [] times
	) {
		this.Invoke("set_generation_rollover_time", new object [] {
				keys,
				generations,
				times});

	}
	public System.IAsyncResult Beginset_generation_rollover_time(string [] keys,CommonULong64 [] [] generations,CommonTimeStamp [] [] times, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_generation_rollover_time", new object[] {
			keys,
			generations,
			times}, callback, asyncState);
	}
	public void Endset_generation_rollover_time(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_rollover_period
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECKey", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECKey", ResponseNamespace="urn:iControl:GlobalLB/DNSSECKey")]
	public void set_rollover_period(
		string [] keys,
		long [] times
	) {
		this.Invoke("set_rollover_period", new object [] {
				keys,
				times});

	}
	public System.IAsyncResult Beginset_rollover_period(string [] keys,long [] times, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_rollover_period", new object[] {
			keys,
			times}, callback, asyncState);
	}
	public void Endset_rollover_period(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_signature_publication_period
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECKey", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECKey", ResponseNamespace="urn:iControl:GlobalLB/DNSSECKey")]
	public void set_signature_publication_period(
		string [] keys,
		long [] times
	) {
		this.Invoke("set_signature_publication_period", new object [] {
				keys,
				times});

	}
	public System.IAsyncResult Beginset_signature_publication_period(string [] keys,long [] times, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_signature_publication_period", new object[] {
			keys,
			times}, callback, asyncState);
	}
	public void Endset_signature_publication_period(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_signature_validity_period
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECKey", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECKey", ResponseNamespace="urn:iControl:GlobalLB/DNSSECKey")]
	public void set_signature_validity_period(
		string [] keys,
		long [] times
	) {
		this.Invoke("set_signature_validity_period", new object [] {
				keys,
				times});

	}
	public System.IAsyncResult Beginset_signature_validity_period(string [] keys,long [] times, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_signature_validity_period", new object[] {
			keys,
			times}, callback, asyncState);
	}
	public void Endset_signature_validity_period(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_time_to_live
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:GlobalLB/DNSSECKey", 
		RequestNamespace="urn:iControl:GlobalLB/DNSSECKey", ResponseNamespace="urn:iControl:GlobalLB/DNSSECKey")]
	public void set_time_to_live(
		string [] keys,
		long [] times
	) {
		this.Invoke("set_time_to_live", new object [] {
				keys,
				times});

	}
	public System.IAsyncResult Beginset_time_to_live(string [] keys,long [] times, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_time_to_live", new object[] {
			keys,
			times}, callback, asyncState);
	}
	public void Endset_time_to_live(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.DNSSECKey.KeyAlgorithm", Namespace = "urn:iControl")]
	public enum GlobalLBDNSSECKeyKeyAlgorithm
	{
		KEY_ALGORITHM_UNKNOWN,
		KEY_ALGORITHM_RSASHA1,
		KEY_ALGORITHM_RSASHA256,
		KEY_ALGORITHM_RSASHA512,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "GlobalLB.DNSSECKey.KeyType", Namespace = "urn:iControl")]
	public enum GlobalLBDNSSECKeyKeyType
	{
		KEY_TYPE_UNKNOWN,
		KEY_TYPE_ZONE_SIGNING,
		KEY_TYPE_KEY_SIGNING,
	}

	//=======================================================================
	// Structs
	//=======================================================================

}
