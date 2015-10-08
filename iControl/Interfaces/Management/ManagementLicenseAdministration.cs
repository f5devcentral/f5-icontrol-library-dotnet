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
	[System.Web.Services.WebServiceBindingAttribute(Name="Management.LicenseAdministrationBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementLicenseAdministrationEvaluationExpiration))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementLicenseAdministrationModuleExpiry))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementLicenseAdministrationModuleKey))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementLicenseAdministrationTimeLimitedModuleKey))]
	public partial class ManagementLicenseAdministration : iControlInterface {
		public ManagementLicenseAdministration() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// activate_license
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/LicenseAdministration", 
		RequestNamespace="urn:iControl:Management/LicenseAdministration", ResponseNamespace="urn:iControl:Management/LicenseAdministration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool activate_license(
		string [] registration_keys
	) {
		object [] results = this.Invoke("activate_license", new object [] {
				registration_keys});
		return ((bool)(results[0]));
	}
	public System.IAsyncResult Beginactivate_license(string [] registration_keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("activate_license", new object[] {
			registration_keys}, callback, asyncState);
	}
	public bool Endactivate_license(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool)(results[0]));
	}

	//-----------------------------------------------------------------------
	// check_registration_key_crc
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/LicenseAdministration", 
		RequestNamespace="urn:iControl:Management/LicenseAdministration", ResponseNamespace="urn:iControl:Management/LicenseAdministration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool [] check_registration_key_crc(
		string [] registration_keys
	) {
		object [] results = this.Invoke("check_registration_key_crc", new object [] {
				registration_keys});
		return ((bool [])(results[0]));
	}
	public System.IAsyncResult Begincheck_registration_key_crc(string [] registration_keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("check_registration_key_crc", new object[] {
			registration_keys}, callback, asyncState);
	}
	public bool [] Endcheck_registration_key_crc(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_copyright_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/LicenseAdministration", 
		RequestNamespace="urn:iControl:Management/LicenseAdministration", ResponseNamespace="urn:iControl:Management/LicenseAdministration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public byte [] get_copyright_file(

	) {
		object [] results = this.Invoke("get_copyright_file", new object [0]);
		return ((byte [])(results[0]));
	}
	public System.IAsyncResult Beginget_copyright_file(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_copyright_file", new object[0], callback, asyncState);
	}
	public byte [] Endget_copyright_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((byte [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_eula_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/LicenseAdministration", 
		RequestNamespace="urn:iControl:Management/LicenseAdministration", ResponseNamespace="urn:iControl:Management/LicenseAdministration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public byte [] get_eula_file(

	) {
		object [] results = this.Invoke("get_eula_file", new object [0]);
		return ((byte [])(results[0]));
	}
	public System.IAsyncResult Beginget_eula_file(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_eula_file", new object[0], callback, asyncState);
	}
	public byte [] Endget_eula_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((byte [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_evaluation_license_expiration
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/LicenseAdministration", 
		RequestNamespace="urn:iControl:Management/LicenseAdministration", ResponseNamespace="urn:iControl:Management/LicenseAdministration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementLicenseAdministrationEvaluationExpiration get_evaluation_license_expiration(

	) {
		object [] results = this.Invoke("get_evaluation_license_expiration", new object [0]);
		return ((ManagementLicenseAdministrationEvaluationExpiration)(results[0]));
	}
	public System.IAsyncResult Beginget_evaluation_license_expiration(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_evaluation_license_expiration", new object[0], callback, asyncState);
	}
	public ManagementLicenseAdministrationEvaluationExpiration Endget_evaluation_license_expiration(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementLicenseAdministrationEvaluationExpiration)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_license_activation_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/LicenseAdministration", 
		RequestNamespace="urn:iControl:Management/LicenseAdministration", ResponseNamespace="urn:iControl:Management/LicenseAdministration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState get_license_activation_status(

	) {
		object [] results = this.Invoke("get_license_activation_status", new object [0]);
		return ((CommonEnabledState)(results[0]));
	}
	public System.IAsyncResult Beginget_license_activation_status(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_license_activation_status", new object[0], callback, asyncState);
	}
	public CommonEnabledState Endget_license_activation_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_license_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/LicenseAdministration", 
		RequestNamespace="urn:iControl:Management/LicenseAdministration", ResponseNamespace="urn:iControl:Management/LicenseAdministration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public byte [] get_license_file(

	) {
		object [] results = this.Invoke("get_license_file", new object [0]);
		return ((byte [])(results[0]));
	}
	public System.IAsyncResult Beginget_license_file(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_license_file", new object[0], callback, asyncState);
	}
	public byte [] Endget_license_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((byte [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_module_enabled_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/LicenseAdministration", 
		RequestNamespace="urn:iControl:Management/LicenseAdministration", ResponseNamespace="urn:iControl:Management/LicenseAdministration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState [] get_module_enabled_state(
		CommonTMOSModule [] modules
	) {
		object [] results = this.Invoke("get_module_enabled_state", new object [] {
				modules});
		return ((CommonEnabledState [])(results[0]));
	}
	public System.IAsyncResult Beginget_module_enabled_state(CommonTMOSModule [] modules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_module_enabled_state", new object[] {
			modules}, callback, asyncState);
	}
	public CommonEnabledState [] Endget_module_enabled_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_module_expiry
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/LicenseAdministration", 
		RequestNamespace="urn:iControl:Management/LicenseAdministration", ResponseNamespace="urn:iControl:Management/LicenseAdministration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementLicenseAdministrationModuleExpiry [] get_module_expiry(
		CommonTMOSModule [] modules
	) {
		object [] results = this.Invoke("get_module_expiry", new object [] {
				modules});
		return ((ManagementLicenseAdministrationModuleExpiry [])(results[0]));
	}
	public System.IAsyncResult Beginget_module_expiry(CommonTMOSModule [] modules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_module_expiry", new object[] {
			modules}, callback, asyncState);
	}
	public ManagementLicenseAdministrationModuleExpiry [] Endget_module_expiry(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementLicenseAdministrationModuleExpiry [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_module_keys
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/LicenseAdministration", 
		RequestNamespace="urn:iControl:Management/LicenseAdministration", ResponseNamespace="urn:iControl:Management/LicenseAdministration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementLicenseAdministrationModuleKey [] get_module_keys(

	) {
		object [] results = this.Invoke("get_module_keys", new object [0]);
		return ((ManagementLicenseAdministrationModuleKey [])(results[0]));
	}
	public System.IAsyncResult Beginget_module_keys(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_module_keys", new object[0], callback, asyncState);
	}
	public ManagementLicenseAdministrationModuleKey [] Endget_module_keys(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementLicenseAdministrationModuleKey [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_registration_keys
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/LicenseAdministration", 
		RequestNamespace="urn:iControl:Management/LicenseAdministration", ResponseNamespace="urn:iControl:Management/LicenseAdministration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_registration_keys(

	) {
		object [] results = this.Invoke("get_registration_keys", new object [0]);
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_registration_keys(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_registration_keys", new object[0], callback, asyncState);
	}
	public string [] Endget_registration_keys(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_system_dossier
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/LicenseAdministration", 
		RequestNamespace="urn:iControl:Management/LicenseAdministration", ResponseNamespace="urn:iControl:Management/LicenseAdministration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string get_system_dossier(
		string [] registration_keys
	) {
		object [] results = this.Invoke("get_system_dossier", new object [] {
				registration_keys});
		return ((string)(results[0]));
	}
	public System.IAsyncResult Beginget_system_dossier(string [] registration_keys, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_system_dossier", new object[] {
			registration_keys}, callback, asyncState);
	}
	public string Endget_system_dossier(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_time_limited_module_keys
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/LicenseAdministration", 
		RequestNamespace="urn:iControl:Management/LicenseAdministration", ResponseNamespace="urn:iControl:Management/LicenseAdministration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementLicenseAdministrationTimeLimitedModuleKey [] get_time_limited_module_keys(

	) {
		object [] results = this.Invoke("get_time_limited_module_keys", new object [0]);
		return ((ManagementLicenseAdministrationTimeLimitedModuleKey [])(results[0]));
	}
	public System.IAsyncResult Beginget_time_limited_module_keys(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_time_limited_module_keys", new object[0], callback, asyncState);
	}
	public ManagementLicenseAdministrationTimeLimitedModuleKey [] Endget_time_limited_module_keys(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementLicenseAdministrationTimeLimitedModuleKey [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/LicenseAdministration", 
		RequestNamespace="urn:iControl:Management/LicenseAdministration", ResponseNamespace="urn:iControl:Management/LicenseAdministration")]
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
	// install_license
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/LicenseAdministration", 
		RequestNamespace="urn:iControl:Management/LicenseAdministration", ResponseNamespace="urn:iControl:Management/LicenseAdministration")]
	public void install_license(
		byte [] license_file_data
	) {
		this.Invoke("install_license", new object [] {
				license_file_data});

	}
	public System.IAsyncResult Begininstall_license(byte [] license_file_data, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("install_license", new object[] {
			license_file_data}, callback, asyncState);
	}
	public void Endinstall_license(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// install_license_from_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/LicenseAdministration", 
		RequestNamespace="urn:iControl:Management/LicenseAdministration", ResponseNamespace="urn:iControl:Management/LicenseAdministration")]
	public void install_license_from_file(
		string license_file
	) {
		this.Invoke("install_license_from_file", new object [] {
				license_file});

	}
	public System.IAsyncResult Begininstall_license_from_file(string license_file, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("install_license_from_file", new object[] {
			license_file}, callback, asyncState);
	}
	public void Endinstall_license_from_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// is_evaluation_license
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/LicenseAdministration", 
		RequestNamespace="urn:iControl:Management/LicenseAdministration", ResponseNamespace="urn:iControl:Management/LicenseAdministration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool is_evaluation_license(

	) {
		object [] results = this.Invoke("is_evaluation_license", new object [0]);
		return ((bool)(results[0]));
	}
	public System.IAsyncResult Beginis_evaluation_license(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("is_evaluation_license", new object[0], callback, asyncState);
	}
	public bool Endis_evaluation_license(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool)(results[0]));
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
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.LicenseAdministration.EvaluationExpiration", Namespace = "urn:iControl")]
	public partial class ManagementLicenseAdministrationEvaluationExpiration
	{
		private long current_system_timeField;
		public long current_system_time
		{
			get { return this.current_system_timeField; }
			set { this.current_system_timeField = value; }
		}
		private long evaluation_startField;
		public long evaluation_start
		{
			get { return this.evaluation_startField; }
			set { this.evaluation_startField = value; }
		}
		private long evaluation_expireField;
		public long evaluation_expire
		{
			get { return this.evaluation_expireField; }
			set { this.evaluation_expireField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.LicenseAdministration.ModuleExpiry", Namespace = "urn:iControl")]
	public partial class ManagementLicenseAdministrationModuleExpiry
	{
		private CommonEnabledState enabledField;
		public CommonEnabledState enabled
		{
			get { return this.enabledField; }
			set { this.enabledField = value; }
		}
		private bool expiresField;
		public bool expires
		{
			get { return this.expiresField; }
			set { this.expiresField = value; }
		}
		private long expiry_timeField;
		public long expiry_time
		{
			get { return this.expiry_timeField; }
			set { this.expiry_timeField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.LicenseAdministration.ModuleKey", Namespace = "urn:iControl")]
	public partial class ManagementLicenseAdministrationModuleKey
	{
		private string descriptionField;
		public string description
		{
			get { return this.descriptionField; }
			set { this.descriptionField = value; }
		}
		private string keyField;
		public string key
		{
			get { return this.keyField; }
			set { this.keyField = value; }
		}
		private string [] child_descriptionField;
		public string [] child_description
		{
			get { return this.child_descriptionField; }
			set { this.child_descriptionField = value; }
		}
		private bool activeField;
		public bool active
		{
			get { return this.activeField; }
			set { this.activeField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.LicenseAdministration.ModuleKeyTimeLimits", Namespace = "urn:iControl")]
	public partial class ManagementLicenseAdministrationModuleKeyTimeLimits
	{
		private long current_system_timeField;
		public long current_system_time
		{
			get { return this.current_system_timeField; }
			set { this.current_system_timeField = value; }
		}
		private long start_timeField;
		public long start_time
		{
			get { return this.start_timeField; }
			set { this.start_timeField = value; }
		}
		private long end_timeField;
		public long end_time
		{
			get { return this.end_timeField; }
			set { this.end_timeField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.LicenseAdministration.TimeLimitedModuleKey", Namespace = "urn:iControl")]
	public partial class ManagementLicenseAdministrationTimeLimitedModuleKey
	{
		private string descriptionField;
		public string description
		{
			get { return this.descriptionField; }
			set { this.descriptionField = value; }
		}
		private string keyField;
		public string key
		{
			get { return this.keyField; }
			set { this.keyField = value; }
		}
		private ManagementLicenseAdministrationModuleKeyTimeLimits limitsField;
		public ManagementLicenseAdministrationModuleKeyTimeLimits limits
		{
			get { return this.limitsField; }
			set { this.limitsField = value; }
		}
		private bool activeField;
		public bool active
		{
			get { return this.activeField; }
			set { this.activeField = value; }
		}
	};

}
