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
	[System.Web.Services.WebServiceBindingAttribute(Name="System.ServicesBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemServicesServiceStatus))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemServicesSSHAccess))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemServicesSSHAccess_v2))]
	public partial class SystemServices : iControlInterface {
		public SystemServices() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// get_all_service_statuses
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Services", 
		RequestNamespace="urn:iControl:System/Services", ResponseNamespace="urn:iControl:System/Services")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemServicesServiceStatus [] get_all_service_statuses(

	) {
		object [] results = this.Invoke("get_all_service_statuses", new object [0]);
		return ((SystemServicesServiceStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_all_service_statuses(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_service_statuses", new object[0], callback, asyncState);
	}
	public SystemServicesServiceStatus [] Endget_all_service_statuses(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemServicesServiceStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Services", 
		RequestNamespace="urn:iControl:System/Services", ResponseNamespace="urn:iControl:System/Services")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemServicesServiceType [] get_list(

	) {
		object [] results = this.Invoke("get_list", new object [0]);
		return ((SystemServicesServiceType [])(results[0]));
	}
	public System.IAsyncResult Beginget_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_list", new object[0], callback, asyncState);
	}
	public SystemServicesServiceType [] Endget_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemServicesServiceType [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_service_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Services", 
		RequestNamespace="urn:iControl:System/Services", ResponseNamespace="urn:iControl:System/Services")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemServicesServiceStatus [] get_service_status(
		SystemServicesServiceType [] services
	) {
		object [] results = this.Invoke("get_service_status", new object [] {
				services});
		return ((SystemServicesServiceStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_service_status(SystemServicesServiceType [] services, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_service_status", new object[] {
			services}, callback, asyncState);
	}
	public SystemServicesServiceStatus [] Endget_service_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemServicesServiceStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ssh_access
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Services", 
		RequestNamespace="urn:iControl:System/Services", ResponseNamespace="urn:iControl:System/Services")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemServicesSSHAccess get_ssh_access(

	) {
		object [] results = this.Invoke("get_ssh_access", new object [0]);
		return ((SystemServicesSSHAccess)(results[0]));
	}
	public System.IAsyncResult Beginget_ssh_access(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ssh_access", new object[0], callback, asyncState);
	}
	public SystemServicesSSHAccess Endget_ssh_access(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemServicesSSHAccess)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ssh_access_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Services", 
		RequestNamespace="urn:iControl:System/Services", ResponseNamespace="urn:iControl:System/Services")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemServicesSSHAccess_v2 get_ssh_access_v2(

	) {
		object [] results = this.Invoke("get_ssh_access_v2", new object [0]);
		return ((SystemServicesSSHAccess_v2)(results[0]));
	}
	public System.IAsyncResult Beginget_ssh_access_v2(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ssh_access_v2", new object[0], callback, asyncState);
	}
	public SystemServicesSSHAccess_v2 Endget_ssh_access_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemServicesSSHAccess_v2)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Services", 
		RequestNamespace="urn:iControl:System/Services", ResponseNamespace="urn:iControl:System/Services")]
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
	// reboot_system
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Services", 
		RequestNamespace="urn:iControl:System/Services", ResponseNamespace="urn:iControl:System/Services")]
	public void reboot_system(
		long seconds_to_reboot
	) {
		this.Invoke("reboot_system", new object [] {
				seconds_to_reboot});

	}
	public System.IAsyncResult Beginreboot_system(long seconds_to_reboot, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("reboot_system", new object[] {
			seconds_to_reboot}, callback, asyncState);
	}
	public void Endreboot_system(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_all_services
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Services", 
		RequestNamespace="urn:iControl:System/Services", ResponseNamespace="urn:iControl:System/Services")]
	public void set_all_services(
		SystemServicesServiceAction service_action
	) {
		this.Invoke("set_all_services", new object [] {
				service_action});

	}
	public System.IAsyncResult Beginset_all_services(SystemServicesServiceAction service_action, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_all_services", new object[] {
			service_action}, callback, asyncState);
	}
	public void Endset_all_services(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_service
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Services", 
		RequestNamespace="urn:iControl:System/Services", ResponseNamespace="urn:iControl:System/Services")]
	public void set_service(
		SystemServicesServiceType [] services,
		SystemServicesServiceAction service_action
	) {
		this.Invoke("set_service", new object [] {
				services,
				service_action});

	}
	public System.IAsyncResult Beginset_service(SystemServicesServiceType [] services,SystemServicesServiceAction service_action, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_service", new object[] {
			services,
			service_action}, callback, asyncState);
	}
	public void Endset_service(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ssh_access
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Services", 
		RequestNamespace="urn:iControl:System/Services", ResponseNamespace="urn:iControl:System/Services")]
	public void set_ssh_access(
		SystemServicesSSHAccess access
	) {
		this.Invoke("set_ssh_access", new object [] {
				access});

	}
	public System.IAsyncResult Beginset_ssh_access(SystemServicesSSHAccess access, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ssh_access", new object[] {
			access}, callback, asyncState);
	}
	public void Endset_ssh_access(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ssh_access_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/Services", 
		RequestNamespace="urn:iControl:System/Services", ResponseNamespace="urn:iControl:System/Services")]
	public void set_ssh_access_v2(
		SystemServicesSSHAccess_v2 access
	) {
		this.Invoke("set_ssh_access_v2", new object [] {
				access});

	}
	public System.IAsyncResult Beginset_ssh_access_v2(SystemServicesSSHAccess_v2 access, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ssh_access_v2", new object[] {
			access}, callback, asyncState);
	}
	public void Endset_ssh_access_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Services.ServiceAction", Namespace = "urn:iControl")]
	public enum SystemServicesServiceAction
	{
		SERVICE_ACTION_START,
		SERVICE_ACTION_STOP,
		SERVICE_ACTION_REINIT,
		SERVICE_ACTION_RESTART,
		SERVICE_ACTION_ADD_TO_BOOT_LIST,
		SERVICE_ACTION_REMOVE_FROM_BOOT_LIST,
		SERVICE_ACTION_ADD_TO_DEFAULT_LIST,
		SERVICE_ACTION_REMOVE_FROM_DEFAULT_LIST,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Services.ServiceStatusType", Namespace = "urn:iControl")]
	public enum SystemServicesServiceStatusType
	{
		SERVICE_STATUS_NOT_FOUND,
		SERVICE_STATUS_UP,
		SERVICE_STATUS_DOWN,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Services.ServiceType", Namespace = "urn:iControl")]
	public enum SystemServicesServiceType
	{
		SERVICE_UNKNOWN,
		SERVICE_ALERTD,
		SERVICE_BCM56XXD,
		SERVICE_BIG3D,
		SERVICE_BIG3DSHIM,
		SERVICE_BIGD,
		SERVICE_BIGDBD,
		SERVICE_BIGSNMPD,
		SERVICE_CHMAND,
		SERVICE_CSSD,
		SERVICE_EVENTD,
		SERVICE_FPDD,
		SERVICE_HTTPD,
		SERVICE_LACPD,
		SERVICE_MCPD,
		SERVICE_NAMED,
		SERVICE_NOKIASNMPD,
		SERVICE_NTPD,
		SERVICE_OVERDOG,
		SERVICE_PVAD,
		SERVICE_RADVD,
		SERVICE_RMONSNMPD,
		SERVICE_SNMPD,
		SERVICE_SOD,
		SERVICE_SSHD,
		SERVICE_STATSD,
		SERVICE_STPD,
		SERVICE_SYSCALLD,
		SERVICE_SYSLOGD,
		SERVICE_TAMD,
		SERVICE_TMM,
		SERVICE_TMROUTED,
		SERVICE_TMSNMPD,
		SERVICE_TOMCAT4,
		SERVICE_ZEBOSD,
		SERVICE_GTMD,
		SERVICE_SUBSNMPD,
		SERVICE_ZRD,
		SERVICE_ASM,
		SERVICE_PVAC,
		SERVICE_COMM_SRV,
		SERVICE_HDS_PRUNE,
		SERVICE_TMZD,
		SERVICE_WAICD,
		SERVICE_CLUSTERD,
		SERVICE_CSYNCD,
		SERVICE_LIND,
		SERVICE_WAMD,
		SERVICE_DATASTOR,
		SERVICE_APD,
		SERVICE_APMD,
		SERVICE_ACCTD,
		SERVICE_ACED,
		SERVICE_DNSCACHED,
		SERVICE_REWRITE,
		SERVICE_WEBSSO,
		SERVICE_EAM,
		SERVICE_RBA,
		SERVICE_HTTPD_APM,
		SERVICE_MONPD,
		SERVICE_MYSQL,
		SERVICE_LOGSTATD,
		SERVICE_LOGD,
		SERVICE_WOCD,
		SERVICE_WCCPD,
		SERVICE_DEDUP_ADMIN,
		SERVICE_WOCPLUGIN,
		SERVICE_MD,
		SERVICE_DPID,
		SERVICE_VCMPD,
		SERVICE_ZXFRD,
		SERVICE_CBRD,
		SERVICE_ISTATSD,
		SERVICE_LLDPD,
		SERVICE_MERGED,
		SERVICE_NTLMCONNPOOL,
		SERVICE_SCRIPTD,
		SERVICE_DEVMGMTD,
		SERVICE_DISKEVENT,
		SERVICE_EMADMIND,
		SERVICE_EMALERTD,
		SERVICE_EMDEVICED,
		SERVICE_EMFILED,
		SERVICE_EMSTATSD,
		SERVICE_EMSNMPD,
		SERVICE_SWIMD,
		SERVICE_PKCS11D,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Services.SSHAccess", Namespace = "urn:iControl")]
	public partial class SystemServicesSSHAccess
	{
		private CommonEnabledState stateField;
		public CommonEnabledState state
		{
			get { return this.stateField; }
			set { this.stateField = value; }
		}
		private string [] addressesField;
		public string [] addresses
		{
			get { return this.addressesField; }
			set { this.addressesField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Services.SSHAccess_v2", Namespace = "urn:iControl")]
	public partial class SystemServicesSSHAccess_v2
	{
		private CommonEnabledState stateField;
		public CommonEnabledState state
		{
			get { return this.stateField; }
			set { this.stateField = value; }
		}
		private string [] addressesField;
		public string [] addresses
		{
			get { return this.addressesField; }
			set { this.addressesField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "System.Services.ServiceStatus", Namespace = "urn:iControl")]
	public partial class SystemServicesServiceStatus
	{
		private SystemServicesServiceType serviceField;
		public SystemServicesServiceType service
		{
			get { return this.serviceField; }
			set { this.serviceField = value; }
		}
		private SystemServicesServiceStatusType statusField;
		public SystemServicesServiceStatusType status
		{
			get { return this.statusField; }
			set { this.statusField = value; }
		}
	};

}
