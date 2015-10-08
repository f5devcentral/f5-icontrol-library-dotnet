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
	[System.Web.Services.WebServiceBindingAttribute(Name="Management.SNMPConfigurationBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementSNMPConfigurationAccessInformation))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementSNMPConfigurationAgentInterface))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementSNMPConfigurationAgentListenAddressPort))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementSNMPConfigurationAgentXInformation))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementSNMPConfigurationDiskCheckInformation))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementSNMPConfigurationFileCheckInformation))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementSNMPConfigurationLoadAverageInformation))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementSNMPConfigurationProcessInformation))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementSNMPConfigurationClientAccess))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementSNMPConfigurationSecurityInformation))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementSNMPConfigurationUserInformation))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementSNMPConfigurationDynamicLoadableModule))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementSNMPConfigurationMibnumNameProgArgs))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementSNMPConfigurationNameProgArgs))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementSNMPConfigurationGenericSinkInformation))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementSNMPConfigurationGenericSinkInformation2))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementSNMPConfigurationGroupInformation))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementSNMPConfigurationPassThroughInformation))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementSNMPConfigurationWrapperSecurityInformation))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementSNMPConfigurationWrapperUserInformation))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementSNMPConfigurationSmuxSubAgentInformation))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementSNMPConfigurationSystemInformation))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementSNMPConfigurationSinkInformation))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementSNMPConfigurationViewInformation))]
	public partial class ManagementSNMPConfiguration : iControlInterface {
		public ManagementSNMPConfiguration() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// get_access_info
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementSNMPConfigurationAccessInformation [] get_access_info(

	) {
		object [] results = this.Invoke("get_access_info", new object [0]);
		return ((ManagementSNMPConfigurationAccessInformation [])(results[0]));
	}
	public System.IAsyncResult Beginget_access_info(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_access_info", new object[0], callback, asyncState);
	}
	public ManagementSNMPConfigurationAccessInformation [] Endget_access_info(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementSNMPConfigurationAccessInformation [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_agent_group_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string get_agent_group_id(

	) {
		object [] results = this.Invoke("get_agent_group_id", new object [0]);
		return ((string)(results[0]));
	}
	public System.IAsyncResult Beginget_agent_group_id(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_agent_group_id", new object[0], callback, asyncState);
	}
	public string Endget_agent_group_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_agent_interface
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementSNMPConfigurationAgentInterface get_agent_interface(

	) {
		object [] results = this.Invoke("get_agent_interface", new object [0]);
		return ((ManagementSNMPConfigurationAgentInterface)(results[0]));
	}
	public System.IAsyncResult Beginget_agent_interface(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_agent_interface", new object[0], callback, asyncState);
	}
	public ManagementSNMPConfigurationAgentInterface Endget_agent_interface(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementSNMPConfigurationAgentInterface)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_agent_listen_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementSNMPConfigurationAgentListenAddressPort [] get_agent_listen_address(

	) {
		object [] results = this.Invoke("get_agent_listen_address", new object [0]);
		return ((ManagementSNMPConfigurationAgentListenAddressPort [])(results[0]));
	}
	public System.IAsyncResult Beginget_agent_listen_address(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_agent_listen_address", new object[0], callback, asyncState);
	}
	public ManagementSNMPConfigurationAgentListenAddressPort [] Endget_agent_listen_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementSNMPConfigurationAgentListenAddressPort [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_agent_trap_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState get_agent_trap_state(

	) {
		object [] results = this.Invoke("get_agent_trap_state", new object [0]);
		return ((CommonEnabledState)(results[0]));
	}
	public System.IAsyncResult Beginget_agent_trap_state(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_agent_trap_state", new object[0], callback, asyncState);
	}
	public CommonEnabledState Endget_agent_trap_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_agent_user_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string get_agent_user_id(

	) {
		object [] results = this.Invoke("get_agent_user_id", new object [0]);
		return ((string)(results[0]));
	}
	public System.IAsyncResult Beginget_agent_user_id(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_agent_user_id", new object[0], callback, asyncState);
	}
	public string Endget_agent_user_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_agentx_information
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementSNMPConfigurationAgentXInformation get_agentx_information(

	) {
		object [] results = this.Invoke("get_agentx_information", new object [0]);
		return ((ManagementSNMPConfigurationAgentXInformation)(results[0]));
	}
	public System.IAsyncResult Beginget_agentx_information(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_agentx_information", new object[0], callback, asyncState);
	}
	public ManagementSNMPConfigurationAgentXInformation Endget_agentx_information(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementSNMPConfigurationAgentXInformation)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_auth_trap_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonEnabledState get_auth_trap_state(

	) {
		object [] results = this.Invoke("get_auth_trap_state", new object [0]);
		return ((CommonEnabledState)(results[0]));
	}
	public System.IAsyncResult Beginget_auth_trap_state(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_auth_trap_state", new object[0], callback, asyncState);
	}
	public CommonEnabledState Endget_auth_trap_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonEnabledState)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_check_disk
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementSNMPConfigurationDiskCheckInformation [] get_check_disk(

	) {
		object [] results = this.Invoke("get_check_disk", new object [0]);
		return ((ManagementSNMPConfigurationDiskCheckInformation [])(results[0]));
	}
	public System.IAsyncResult Beginget_check_disk(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_check_disk", new object[0], callback, asyncState);
	}
	public ManagementSNMPConfigurationDiskCheckInformation [] Endget_check_disk(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementSNMPConfigurationDiskCheckInformation [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_check_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementSNMPConfigurationFileCheckInformation [] get_check_file(

	) {
		object [] results = this.Invoke("get_check_file", new object [0]);
		return ((ManagementSNMPConfigurationFileCheckInformation [])(results[0]));
	}
	public System.IAsyncResult Beginget_check_file(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_check_file", new object[0], callback, asyncState);
	}
	public ManagementSNMPConfigurationFileCheckInformation [] Endget_check_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementSNMPConfigurationFileCheckInformation [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_check_load
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementSNMPConfigurationLoadAverageInformation get_check_load(

	) {
		object [] results = this.Invoke("get_check_load", new object [0]);
		return ((ManagementSNMPConfigurationLoadAverageInformation)(results[0]));
	}
	public System.IAsyncResult Beginget_check_load(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_check_load", new object[0], callback, asyncState);
	}
	public ManagementSNMPConfigurationLoadAverageInformation Endget_check_load(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementSNMPConfigurationLoadAverageInformation)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_check_process
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementSNMPConfigurationProcessInformation [] get_check_process(

	) {
		object [] results = this.Invoke("get_check_process", new object [0]);
		return ((ManagementSNMPConfigurationProcessInformation [])(results[0]));
	}
	public System.IAsyncResult Beginget_check_process(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_check_process", new object[0], callback, asyncState);
	}
	public ManagementSNMPConfigurationProcessInformation [] Endget_check_process(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementSNMPConfigurationProcessInformation [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_client_access
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementSNMPConfigurationClientAccess [] get_client_access(

	) {
		object [] results = this.Invoke("get_client_access", new object [0]);
		return ((ManagementSNMPConfigurationClientAccess [])(results[0]));
	}
	public System.IAsyncResult Beginget_client_access(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_client_access", new object[0], callback, asyncState);
	}
	public ManagementSNMPConfigurationClientAccess [] Endget_client_access(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementSNMPConfigurationClientAccess [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_community_to_security_info
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementSNMPConfigurationSecurityInformation [] get_community_to_security_info(

	) {
		object [] results = this.Invoke("get_community_to_security_info", new object [0]);
		return ((ManagementSNMPConfigurationSecurityInformation [])(results[0]));
	}
	public System.IAsyncResult Beginget_community_to_security_info(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_community_to_security_info", new object[0], callback, asyncState);
	}
	public ManagementSNMPConfigurationSecurityInformation [] Endget_community_to_security_info(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementSNMPConfigurationSecurityInformation [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_create_user
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementSNMPConfigurationUserInformation [] get_create_user(

	) {
		object [] results = this.Invoke("get_create_user", new object [0]);
		return ((ManagementSNMPConfigurationUserInformation [])(results[0]));
	}
	public System.IAsyncResult Beginget_create_user(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_create_user", new object[0], callback, asyncState);
	}
	public ManagementSNMPConfigurationUserInformation [] Endget_create_user(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementSNMPConfigurationUserInformation [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_dynamic_loadable_module
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementSNMPConfigurationDynamicLoadableModule [] get_dynamic_loadable_module(

	) {
		object [] results = this.Invoke("get_dynamic_loadable_module", new object [0]);
		return ((ManagementSNMPConfigurationDynamicLoadableModule [])(results[0]));
	}
	public System.IAsyncResult Beginget_dynamic_loadable_module(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_dynamic_loadable_module", new object[0], callback, asyncState);
	}
	public ManagementSNMPConfigurationDynamicLoadableModule [] Endget_dynamic_loadable_module(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementSNMPConfigurationDynamicLoadableModule [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_engine_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string get_engine_id(

	) {
		object [] results = this.Invoke("get_engine_id", new object [0]);
		return ((string)(results[0]));
	}
	public System.IAsyncResult Beginget_engine_id(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_engine_id", new object[0], callback, asyncState);
	}
	public string Endget_engine_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_exec
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementSNMPConfigurationMibnumNameProgArgs [] get_exec(

	) {
		object [] results = this.Invoke("get_exec", new object [0]);
		return ((ManagementSNMPConfigurationMibnumNameProgArgs [])(results[0]));
	}
	public System.IAsyncResult Beginget_exec(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_exec", new object[0], callback, asyncState);
	}
	public ManagementSNMPConfigurationMibnumNameProgArgs [] Endget_exec(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementSNMPConfigurationMibnumNameProgArgs [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_exec_fix
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementSNMPConfigurationNameProgArgs [] get_exec_fix(

	) {
		object [] results = this.Invoke("get_exec_fix", new object [0]);
		return ((ManagementSNMPConfigurationNameProgArgs [])(results[0]));
	}
	public System.IAsyncResult Beginget_exec_fix(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_exec_fix", new object[0], callback, asyncState);
	}
	public ManagementSNMPConfigurationNameProgArgs [] Endget_exec_fix(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementSNMPConfigurationNameProgArgs [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_generic_traps
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementSNMPConfigurationGenericSinkInformation [] get_generic_traps(

	) {
		object [] results = this.Invoke("get_generic_traps", new object [0]);
		return ((ManagementSNMPConfigurationGenericSinkInformation [])(results[0]));
	}
	public System.IAsyncResult Beginget_generic_traps(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_generic_traps", new object[0], callback, asyncState);
	}
	public ManagementSNMPConfigurationGenericSinkInformation [] Endget_generic_traps(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementSNMPConfigurationGenericSinkInformation [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_generic_traps_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementSNMPConfigurationGenericSinkInformation2 [] get_generic_traps_v2(

	) {
		object [] results = this.Invoke("get_generic_traps_v2", new object [0]);
		return ((ManagementSNMPConfigurationGenericSinkInformation2 [])(results[0]));
	}
	public System.IAsyncResult Beginget_generic_traps_v2(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_generic_traps_v2", new object[0], callback, asyncState);
	}
	public ManagementSNMPConfigurationGenericSinkInformation2 [] Endget_generic_traps_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementSNMPConfigurationGenericSinkInformation2 [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_group_info
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementSNMPConfigurationGroupInformation [] get_group_info(

	) {
		object [] results = this.Invoke("get_group_info", new object [0]);
		return ((ManagementSNMPConfigurationGroupInformation [])(results[0]));
	}
	public System.IAsyncResult Beginget_group_info(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_group_info", new object[0], callback, asyncState);
	}
	public ManagementSNMPConfigurationGroupInformation [] Endget_group_info(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementSNMPConfigurationGroupInformation [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ignore_disk
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_ignore_disk(

	) {
		object [] results = this.Invoke("get_ignore_disk", new object [0]);
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_ignore_disk(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ignore_disk", new object[0], callback, asyncState);
	}
	public string [] Endget_ignore_disk(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_pass_through
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementSNMPConfigurationPassThroughInformation [] get_pass_through(

	) {
		object [] results = this.Invoke("get_pass_through", new object [0]);
		return ((ManagementSNMPConfigurationPassThroughInformation [])(results[0]));
	}
	public System.IAsyncResult Beginget_pass_through(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_pass_through", new object[0], callback, asyncState);
	}
	public ManagementSNMPConfigurationPassThroughInformation [] Endget_pass_through(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementSNMPConfigurationPassThroughInformation [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_pass_through_persist
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementSNMPConfigurationPassThroughInformation [] get_pass_through_persist(

	) {
		object [] results = this.Invoke("get_pass_through_persist", new object [0]);
		return ((ManagementSNMPConfigurationPassThroughInformation [])(results[0]));
	}
	public System.IAsyncResult Beginget_pass_through_persist(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_pass_through_persist", new object[0], callback, asyncState);
	}
	public ManagementSNMPConfigurationPassThroughInformation [] Endget_pass_through_persist(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementSNMPConfigurationPassThroughInformation [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_process_fix
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementSNMPConfigurationNameProgArgs [] get_process_fix(

	) {
		object [] results = this.Invoke("get_process_fix", new object [0]);
		return ((ManagementSNMPConfigurationNameProgArgs [])(results[0]));
	}
	public System.IAsyncResult Beginget_process_fix(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_process_fix", new object[0], callback, asyncState);
	}
	public ManagementSNMPConfigurationNameProgArgs [] Endget_process_fix(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementSNMPConfigurationNameProgArgs [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_proxy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_proxy(

	) {
		object [] results = this.Invoke("get_proxy", new object [0]);
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_proxy(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_proxy", new object[0], callback, asyncState);
	}
	public string [] Endget_proxy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_readonly_community
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementSNMPConfigurationWrapperSecurityInformation [] get_readonly_community(

	) {
		object [] results = this.Invoke("get_readonly_community", new object [0]);
		return ((ManagementSNMPConfigurationWrapperSecurityInformation [])(results[0]));
	}
	public System.IAsyncResult Beginget_readonly_community(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_readonly_community", new object[0], callback, asyncState);
	}
	public ManagementSNMPConfigurationWrapperSecurityInformation [] Endget_readonly_community(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementSNMPConfigurationWrapperSecurityInformation [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_readonly_user
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementSNMPConfigurationWrapperUserInformation [] get_readonly_user(

	) {
		object [] results = this.Invoke("get_readonly_user", new object [0]);
		return ((ManagementSNMPConfigurationWrapperUserInformation [])(results[0]));
	}
	public System.IAsyncResult Beginget_readonly_user(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_readonly_user", new object[0], callback, asyncState);
	}
	public ManagementSNMPConfigurationWrapperUserInformation [] Endget_readonly_user(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementSNMPConfigurationWrapperUserInformation [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_readwrite_community
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementSNMPConfigurationWrapperSecurityInformation [] get_readwrite_community(

	) {
		object [] results = this.Invoke("get_readwrite_community", new object [0]);
		return ((ManagementSNMPConfigurationWrapperSecurityInformation [])(results[0]));
	}
	public System.IAsyncResult Beginget_readwrite_community(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_readwrite_community", new object[0], callback, asyncState);
	}
	public ManagementSNMPConfigurationWrapperSecurityInformation [] Endget_readwrite_community(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementSNMPConfigurationWrapperSecurityInformation [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_readwrite_user
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementSNMPConfigurationWrapperUserInformation [] get_readwrite_user(

	) {
		object [] results = this.Invoke("get_readwrite_user", new object [0]);
		return ((ManagementSNMPConfigurationWrapperUserInformation [])(results[0]));
	}
	public System.IAsyncResult Beginget_readwrite_user(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_readwrite_user", new object[0], callback, asyncState);
	}
	public ManagementSNMPConfigurationWrapperUserInformation [] Endget_readwrite_user(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementSNMPConfigurationWrapperUserInformation [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_smux_subagent
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementSNMPConfigurationSmuxSubAgentInformation [] get_smux_subagent(

	) {
		object [] results = this.Invoke("get_smux_subagent", new object [0]);
		return ((ManagementSNMPConfigurationSmuxSubAgentInformation [])(results[0]));
	}
	public System.IAsyncResult Beginget_smux_subagent(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_smux_subagent", new object[0], callback, asyncState);
	}
	public ManagementSNMPConfigurationSmuxSubAgentInformation [] Endget_smux_subagent(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementSNMPConfigurationSmuxSubAgentInformation [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_storage_use_nfs
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_storage_use_nfs(

	) {
		object [] results = this.Invoke("get_storage_use_nfs", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_storage_use_nfs(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_storage_use_nfs", new object[0], callback, asyncState);
	}
	public long Endget_storage_use_nfs(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_system_information
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementSNMPConfigurationSystemInformation get_system_information(

	) {
		object [] results = this.Invoke("get_system_information", new object [0]);
		return ((ManagementSNMPConfigurationSystemInformation)(results[0]));
	}
	public System.IAsyncResult Beginget_system_information(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_system_information", new object[0], callback, asyncState);
	}
	public ManagementSNMPConfigurationSystemInformation Endget_system_information(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementSNMPConfigurationSystemInformation)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_trap_community
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string get_trap_community(

	) {
		object [] results = this.Invoke("get_trap_community", new object [0]);
		return ((string)(results[0]));
	}
	public System.IAsyncResult Beginget_trap_community(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_trap_community", new object[0], callback, asyncState);
	}
	public string Endget_trap_community(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_trap_sinks
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementSNMPConfigurationSinkInformation [] get_trap_sinks(
		ManagementSNMPConfigurationSinkType sink_type
	) {
		object [] results = this.Invoke("get_trap_sinks", new object [] {
				sink_type});
		return ((ManagementSNMPConfigurationSinkInformation [])(results[0]));
	}
	public System.IAsyncResult Beginget_trap_sinks(ManagementSNMPConfigurationSinkType sink_type, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_trap_sinks", new object[] {
			sink_type}, callback, asyncState);
	}
	public ManagementSNMPConfigurationSinkInformation [] Endget_trap_sinks(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementSNMPConfigurationSinkInformation [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
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
	// get_view_info
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementSNMPConfigurationViewInformation [] get_view_info(

	) {
		object [] results = this.Invoke("get_view_info", new object [0]);
		return ((ManagementSNMPConfigurationViewInformation [])(results[0]));
	}
	public System.IAsyncResult Beginget_view_info(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_view_info", new object[0], callback, asyncState);
	}
	public ManagementSNMPConfigurationViewInformation [] Endget_view_info(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementSNMPConfigurationViewInformation [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// remove_access_info
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void remove_access_info(
		ManagementSNMPConfigurationAccessInformation [] access_info
	) {
		this.Invoke("remove_access_info", new object [] {
				access_info});

	}
	public System.IAsyncResult Beginremove_access_info(ManagementSNMPConfigurationAccessInformation [] access_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_access_info", new object[] {
			access_info}, callback, asyncState);
	}
	public void Endremove_access_info(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_agent_group_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void remove_agent_group_id(
		string group_id
	) {
		this.Invoke("remove_agent_group_id", new object [] {
				group_id});

	}
	public System.IAsyncResult Beginremove_agent_group_id(string group_id, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_agent_group_id", new object[] {
			group_id}, callback, asyncState);
	}
	public void Endremove_agent_group_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_agent_interface
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void remove_agent_interface(
		ManagementSNMPConfigurationAgentInterface agent_intf
	) {
		this.Invoke("remove_agent_interface", new object [] {
				agent_intf});

	}
	public System.IAsyncResult Beginremove_agent_interface(ManagementSNMPConfigurationAgentInterface agent_intf, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_agent_interface", new object[] {
			agent_intf}, callback, asyncState);
	}
	public void Endremove_agent_interface(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_agent_listen_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void remove_agent_listen_address(
		ManagementSNMPConfigurationAgentListenAddressPort [] agent_listen_addresses
	) {
		this.Invoke("remove_agent_listen_address", new object [] {
				agent_listen_addresses});

	}
	public System.IAsyncResult Beginremove_agent_listen_address(ManagementSNMPConfigurationAgentListenAddressPort [] agent_listen_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_agent_listen_address", new object[] {
			agent_listen_addresses}, callback, asyncState);
	}
	public void Endremove_agent_listen_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_agent_trap_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void remove_agent_trap_state(
		CommonEnabledState state
	) {
		this.Invoke("remove_agent_trap_state", new object [] {
				state});

	}
	public System.IAsyncResult Beginremove_agent_trap_state(CommonEnabledState state, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_agent_trap_state", new object[] {
			state}, callback, asyncState);
	}
	public void Endremove_agent_trap_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_agent_user_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void remove_agent_user_id(
		string user_id
	) {
		this.Invoke("remove_agent_user_id", new object [] {
				user_id});

	}
	public System.IAsyncResult Beginremove_agent_user_id(string user_id, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_agent_user_id", new object[] {
			user_id}, callback, asyncState);
	}
	public void Endremove_agent_user_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_agentx_information
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void remove_agentx_information(
		ManagementSNMPConfigurationAgentXInformation agentx_info
	) {
		this.Invoke("remove_agentx_information", new object [] {
				agentx_info});

	}
	public System.IAsyncResult Beginremove_agentx_information(ManagementSNMPConfigurationAgentXInformation agentx_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_agentx_information", new object[] {
			agentx_info}, callback, asyncState);
	}
	public void Endremove_agentx_information(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_auth_trap_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void remove_auth_trap_state(
		CommonEnabledState state
	) {
		this.Invoke("remove_auth_trap_state", new object [] {
				state});

	}
	public System.IAsyncResult Beginremove_auth_trap_state(CommonEnabledState state, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_auth_trap_state", new object[] {
			state}, callback, asyncState);
	}
	public void Endremove_auth_trap_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_check_disk
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void remove_check_disk(
		ManagementSNMPConfigurationDiskCheckInformation [] disk_info
	) {
		this.Invoke("remove_check_disk", new object [] {
				disk_info});

	}
	public System.IAsyncResult Beginremove_check_disk(ManagementSNMPConfigurationDiskCheckInformation [] disk_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_check_disk", new object[] {
			disk_info}, callback, asyncState);
	}
	public void Endremove_check_disk(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_check_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void remove_check_file(
		ManagementSNMPConfigurationFileCheckInformation [] file_info
	) {
		this.Invoke("remove_check_file", new object [] {
				file_info});

	}
	public System.IAsyncResult Beginremove_check_file(ManagementSNMPConfigurationFileCheckInformation [] file_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_check_file", new object[] {
			file_info}, callback, asyncState);
	}
	public void Endremove_check_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_check_load
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void remove_check_load(
		ManagementSNMPConfigurationLoadAverageInformation load_info
	) {
		this.Invoke("remove_check_load", new object [] {
				load_info});

	}
	public System.IAsyncResult Beginremove_check_load(ManagementSNMPConfigurationLoadAverageInformation load_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_check_load", new object[] {
			load_info}, callback, asyncState);
	}
	public void Endremove_check_load(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_check_process
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void remove_check_process(
		ManagementSNMPConfigurationProcessInformation [] proc_info
	) {
		this.Invoke("remove_check_process", new object [] {
				proc_info});

	}
	public System.IAsyncResult Beginremove_check_process(ManagementSNMPConfigurationProcessInformation [] proc_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_check_process", new object[] {
			proc_info}, callback, asyncState);
	}
	public void Endremove_check_process(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_client_access
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void remove_client_access(
		ManagementSNMPConfigurationClientAccess [] client_access_info
	) {
		this.Invoke("remove_client_access", new object [] {
				client_access_info});

	}
	public System.IAsyncResult Beginremove_client_access(ManagementSNMPConfigurationClientAccess [] client_access_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_client_access", new object[] {
			client_access_info}, callback, asyncState);
	}
	public void Endremove_client_access(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_community_to_security_info
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void remove_community_to_security_info(
		ManagementSNMPConfigurationSecurityInformation [] security_info
	) {
		this.Invoke("remove_community_to_security_info", new object [] {
				security_info});

	}
	public System.IAsyncResult Beginremove_community_to_security_info(ManagementSNMPConfigurationSecurityInformation [] security_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_community_to_security_info", new object[] {
			security_info}, callback, asyncState);
	}
	public void Endremove_community_to_security_info(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_create_user
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void remove_create_user(
		ManagementSNMPConfigurationUserInformation [] user_info
	) {
		this.Invoke("remove_create_user", new object [] {
				user_info});

	}
	public System.IAsyncResult Beginremove_create_user(ManagementSNMPConfigurationUserInformation [] user_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_create_user", new object[] {
			user_info}, callback, asyncState);
	}
	public void Endremove_create_user(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_dynamic_loadable_module
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void remove_dynamic_loadable_module(
		ManagementSNMPConfigurationDynamicLoadableModule [] mod_info
	) {
		this.Invoke("remove_dynamic_loadable_module", new object [] {
				mod_info});

	}
	public System.IAsyncResult Beginremove_dynamic_loadable_module(ManagementSNMPConfigurationDynamicLoadableModule [] mod_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_dynamic_loadable_module", new object[] {
			mod_info}, callback, asyncState);
	}
	public void Endremove_dynamic_loadable_module(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_engine_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void remove_engine_id(
		string engine_id
	) {
		this.Invoke("remove_engine_id", new object [] {
				engine_id});

	}
	public System.IAsyncResult Beginremove_engine_id(string engine_id, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_engine_id", new object[] {
			engine_id}, callback, asyncState);
	}
	public void Endremove_engine_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_exec
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void remove_exec(
		ManagementSNMPConfigurationMibnumNameProgArgs [] exec_info
	) {
		this.Invoke("remove_exec", new object [] {
				exec_info});

	}
	public System.IAsyncResult Beginremove_exec(ManagementSNMPConfigurationMibnumNameProgArgs [] exec_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_exec", new object[] {
			exec_info}, callback, asyncState);
	}
	public void Endremove_exec(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_exec_fix
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void remove_exec_fix(
		ManagementSNMPConfigurationNameProgArgs [] exec_info
	) {
		this.Invoke("remove_exec_fix", new object [] {
				exec_info});

	}
	public System.IAsyncResult Beginremove_exec_fix(ManagementSNMPConfigurationNameProgArgs [] exec_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_exec_fix", new object[] {
			exec_info}, callback, asyncState);
	}
	public void Endremove_exec_fix(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_generic_traps
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void remove_generic_traps(
		ManagementSNMPConfigurationGenericSinkInformation [] sink_info
	) {
		this.Invoke("remove_generic_traps", new object [] {
				sink_info});

	}
	public System.IAsyncResult Beginremove_generic_traps(ManagementSNMPConfigurationGenericSinkInformation [] sink_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_generic_traps", new object[] {
			sink_info}, callback, asyncState);
	}
	public void Endremove_generic_traps(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_generic_traps_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void remove_generic_traps_v2(
		ManagementSNMPConfigurationGenericSinkInformation2 [] sink_info
	) {
		this.Invoke("remove_generic_traps_v2", new object [] {
				sink_info});

	}
	public System.IAsyncResult Beginremove_generic_traps_v2(ManagementSNMPConfigurationGenericSinkInformation2 [] sink_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_generic_traps_v2", new object[] {
			sink_info}, callback, asyncState);
	}
	public void Endremove_generic_traps_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_group_info
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void remove_group_info(
		ManagementSNMPConfigurationGroupInformation [] group_info
	) {
		this.Invoke("remove_group_info", new object [] {
				group_info});

	}
	public System.IAsyncResult Beginremove_group_info(ManagementSNMPConfigurationGroupInformation [] group_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_group_info", new object[] {
			group_info}, callback, asyncState);
	}
	public void Endremove_group_info(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_ignore_disk
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void remove_ignore_disk(
		string [] ignore_disk
	) {
		this.Invoke("remove_ignore_disk", new object [] {
				ignore_disk});

	}
	public System.IAsyncResult Beginremove_ignore_disk(string [] ignore_disk, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_ignore_disk", new object[] {
			ignore_disk}, callback, asyncState);
	}
	public void Endremove_ignore_disk(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_pass_through
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void remove_pass_through(
		ManagementSNMPConfigurationPassThroughInformation [] passthru_info
	) {
		this.Invoke("remove_pass_through", new object [] {
				passthru_info});

	}
	public System.IAsyncResult Beginremove_pass_through(ManagementSNMPConfigurationPassThroughInformation [] passthru_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_pass_through", new object[] {
			passthru_info}, callback, asyncState);
	}
	public void Endremove_pass_through(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_pass_through_persist
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void remove_pass_through_persist(
		ManagementSNMPConfigurationPassThroughInformation [] passthru_info
	) {
		this.Invoke("remove_pass_through_persist", new object [] {
				passthru_info});

	}
	public System.IAsyncResult Beginremove_pass_through_persist(ManagementSNMPConfigurationPassThroughInformation [] passthru_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_pass_through_persist", new object[] {
			passthru_info}, callback, asyncState);
	}
	public void Endremove_pass_through_persist(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_process_fix
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void remove_process_fix(
		ManagementSNMPConfigurationNameProgArgs [] fix_info
	) {
		this.Invoke("remove_process_fix", new object [] {
				fix_info});

	}
	public System.IAsyncResult Beginremove_process_fix(ManagementSNMPConfigurationNameProgArgs [] fix_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_process_fix", new object[] {
			fix_info}, callback, asyncState);
	}
	public void Endremove_process_fix(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_proxy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void remove_proxy(
		string [] proxy_info
	) {
		this.Invoke("remove_proxy", new object [] {
				proxy_info});

	}
	public System.IAsyncResult Beginremove_proxy(string [] proxy_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_proxy", new object[] {
			proxy_info}, callback, asyncState);
	}
	public void Endremove_proxy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_readonly_community
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void remove_readonly_community(
		ManagementSNMPConfigurationWrapperSecurityInformation [] ro_community_info
	) {
		this.Invoke("remove_readonly_community", new object [] {
				ro_community_info});

	}
	public System.IAsyncResult Beginremove_readonly_community(ManagementSNMPConfigurationWrapperSecurityInformation [] ro_community_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_readonly_community", new object[] {
			ro_community_info}, callback, asyncState);
	}
	public void Endremove_readonly_community(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_readonly_user
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void remove_readonly_user(
		ManagementSNMPConfigurationWrapperUserInformation [] ro_user_info
	) {
		this.Invoke("remove_readonly_user", new object [] {
				ro_user_info});

	}
	public System.IAsyncResult Beginremove_readonly_user(ManagementSNMPConfigurationWrapperUserInformation [] ro_user_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_readonly_user", new object[] {
			ro_user_info}, callback, asyncState);
	}
	public void Endremove_readonly_user(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_readwrite_community
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void remove_readwrite_community(
		ManagementSNMPConfigurationWrapperSecurityInformation [] rw_community_info
	) {
		this.Invoke("remove_readwrite_community", new object [] {
				rw_community_info});

	}
	public System.IAsyncResult Beginremove_readwrite_community(ManagementSNMPConfigurationWrapperSecurityInformation [] rw_community_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_readwrite_community", new object[] {
			rw_community_info}, callback, asyncState);
	}
	public void Endremove_readwrite_community(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_readwrite_user
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void remove_readwrite_user(
		ManagementSNMPConfigurationWrapperUserInformation [] rw_user_info
	) {
		this.Invoke("remove_readwrite_user", new object [] {
				rw_user_info});

	}
	public System.IAsyncResult Beginremove_readwrite_user(ManagementSNMPConfigurationWrapperUserInformation [] rw_user_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_readwrite_user", new object[] {
			rw_user_info}, callback, asyncState);
	}
	public void Endremove_readwrite_user(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_smux_subagent
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void remove_smux_subagent(
		ManagementSNMPConfigurationSmuxSubAgentInformation [] subagent_info
	) {
		this.Invoke("remove_smux_subagent", new object [] {
				subagent_info});

	}
	public System.IAsyncResult Beginremove_smux_subagent(ManagementSNMPConfigurationSmuxSubAgentInformation [] subagent_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_smux_subagent", new object[] {
			subagent_info}, callback, asyncState);
	}
	public void Endremove_smux_subagent(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_storage_use_nfs
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void remove_storage_use_nfs(
		long usage
	) {
		this.Invoke("remove_storage_use_nfs", new object [] {
				usage});

	}
	public System.IAsyncResult Beginremove_storage_use_nfs(long usage, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_storage_use_nfs", new object[] {
			usage}, callback, asyncState);
	}
	public void Endremove_storage_use_nfs(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_system_information
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void remove_system_information(
		ManagementSNMPConfigurationSystemInformation system_info
	) {
		this.Invoke("remove_system_information", new object [] {
				system_info});

	}
	public System.IAsyncResult Beginremove_system_information(ManagementSNMPConfigurationSystemInformation system_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_system_information", new object[] {
			system_info}, callback, asyncState);
	}
	public void Endremove_system_information(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_trap_community
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void remove_trap_community(
		string community
	) {
		this.Invoke("remove_trap_community", new object [] {
				community});

	}
	public System.IAsyncResult Beginremove_trap_community(string community, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_trap_community", new object[] {
			community}, callback, asyncState);
	}
	public void Endremove_trap_community(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_trap_sinks
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void remove_trap_sinks(
		ManagementSNMPConfigurationSinkType sink_type,
		ManagementSNMPConfigurationSinkInformation [] sink_info
	) {
		this.Invoke("remove_trap_sinks", new object [] {
				sink_type,
				sink_info});

	}
	public System.IAsyncResult Beginremove_trap_sinks(ManagementSNMPConfigurationSinkType sink_type,ManagementSNMPConfigurationSinkInformation [] sink_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_trap_sinks", new object[] {
			sink_type,
			sink_info}, callback, asyncState);
	}
	public void Endremove_trap_sinks(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// remove_view_info
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void remove_view_info(
		ManagementSNMPConfigurationViewInformation [] view_info
	) {
		this.Invoke("remove_view_info", new object [] {
				view_info});

	}
	public System.IAsyncResult Beginremove_view_info(ManagementSNMPConfigurationViewInformation [] view_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("remove_view_info", new object[] {
			view_info}, callback, asyncState);
	}
	public void Endremove_view_info(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_access_info
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void set_access_info(
		ManagementSNMPConfigurationAccessInformation [] access_info
	) {
		this.Invoke("set_access_info", new object [] {
				access_info});

	}
	public System.IAsyncResult Beginset_access_info(ManagementSNMPConfigurationAccessInformation [] access_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_access_info", new object[] {
			access_info}, callback, asyncState);
	}
	public void Endset_access_info(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_agent_group_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void set_agent_group_id(
		string group_id
	) {
		this.Invoke("set_agent_group_id", new object [] {
				group_id});

	}
	public System.IAsyncResult Beginset_agent_group_id(string group_id, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_agent_group_id", new object[] {
			group_id}, callback, asyncState);
	}
	public void Endset_agent_group_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_agent_interface
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void set_agent_interface(
		ManagementSNMPConfigurationAgentInterface agent_intf
	) {
		this.Invoke("set_agent_interface", new object [] {
				agent_intf});

	}
	public System.IAsyncResult Beginset_agent_interface(ManagementSNMPConfigurationAgentInterface agent_intf, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_agent_interface", new object[] {
			agent_intf}, callback, asyncState);
	}
	public void Endset_agent_interface(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_agent_listen_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void set_agent_listen_address(
		ManagementSNMPConfigurationAgentListenAddressPort [] agent_listen_addresses
	) {
		this.Invoke("set_agent_listen_address", new object [] {
				agent_listen_addresses});

	}
	public System.IAsyncResult Beginset_agent_listen_address(ManagementSNMPConfigurationAgentListenAddressPort [] agent_listen_addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_agent_listen_address", new object[] {
			agent_listen_addresses}, callback, asyncState);
	}
	public void Endset_agent_listen_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_agent_trap_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void set_agent_trap_state(
		CommonEnabledState state
	) {
		this.Invoke("set_agent_trap_state", new object [] {
				state});

	}
	public System.IAsyncResult Beginset_agent_trap_state(CommonEnabledState state, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_agent_trap_state", new object[] {
			state}, callback, asyncState);
	}
	public void Endset_agent_trap_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_agent_user_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void set_agent_user_id(
		string user_id
	) {
		this.Invoke("set_agent_user_id", new object [] {
				user_id});

	}
	public System.IAsyncResult Beginset_agent_user_id(string user_id, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_agent_user_id", new object[] {
			user_id}, callback, asyncState);
	}
	public void Endset_agent_user_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_agentx_information
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void set_agentx_information(
		ManagementSNMPConfigurationAgentXInformation agentx_info
	) {
		this.Invoke("set_agentx_information", new object [] {
				agentx_info});

	}
	public System.IAsyncResult Beginset_agentx_information(ManagementSNMPConfigurationAgentXInformation agentx_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_agentx_information", new object[] {
			agentx_info}, callback, asyncState);
	}
	public void Endset_agentx_information(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_auth_trap_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void set_auth_trap_state(
		CommonEnabledState state
	) {
		this.Invoke("set_auth_trap_state", new object [] {
				state});

	}
	public System.IAsyncResult Beginset_auth_trap_state(CommonEnabledState state, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_auth_trap_state", new object[] {
			state}, callback, asyncState);
	}
	public void Endset_auth_trap_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_check_disk
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void set_check_disk(
		ManagementSNMPConfigurationDiskCheckInformation [] disk_info
	) {
		this.Invoke("set_check_disk", new object [] {
				disk_info});

	}
	public System.IAsyncResult Beginset_check_disk(ManagementSNMPConfigurationDiskCheckInformation [] disk_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_check_disk", new object[] {
			disk_info}, callback, asyncState);
	}
	public void Endset_check_disk(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_check_file
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void set_check_file(
		ManagementSNMPConfigurationFileCheckInformation [] file_info
	) {
		this.Invoke("set_check_file", new object [] {
				file_info});

	}
	public System.IAsyncResult Beginset_check_file(ManagementSNMPConfigurationFileCheckInformation [] file_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_check_file", new object[] {
			file_info}, callback, asyncState);
	}
	public void Endset_check_file(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_check_load
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void set_check_load(
		ManagementSNMPConfigurationLoadAverageInformation load_info
	) {
		this.Invoke("set_check_load", new object [] {
				load_info});

	}
	public System.IAsyncResult Beginset_check_load(ManagementSNMPConfigurationLoadAverageInformation load_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_check_load", new object[] {
			load_info}, callback, asyncState);
	}
	public void Endset_check_load(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_check_process
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void set_check_process(
		ManagementSNMPConfigurationProcessInformation [] proc_info
	) {
		this.Invoke("set_check_process", new object [] {
				proc_info});

	}
	public System.IAsyncResult Beginset_check_process(ManagementSNMPConfigurationProcessInformation [] proc_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_check_process", new object[] {
			proc_info}, callback, asyncState);
	}
	public void Endset_check_process(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_client_access
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void set_client_access(
		ManagementSNMPConfigurationClientAccess [] client_access_info
	) {
		this.Invoke("set_client_access", new object [] {
				client_access_info});

	}
	public System.IAsyncResult Beginset_client_access(ManagementSNMPConfigurationClientAccess [] client_access_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_client_access", new object[] {
			client_access_info}, callback, asyncState);
	}
	public void Endset_client_access(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_community_to_security_info
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void set_community_to_security_info(
		ManagementSNMPConfigurationSecurityInformation [] security_info
	) {
		this.Invoke("set_community_to_security_info", new object [] {
				security_info});

	}
	public System.IAsyncResult Beginset_community_to_security_info(ManagementSNMPConfigurationSecurityInformation [] security_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_community_to_security_info", new object[] {
			security_info}, callback, asyncState);
	}
	public void Endset_community_to_security_info(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_create_user
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void set_create_user(
		ManagementSNMPConfigurationUserInformation [] user_info
	) {
		this.Invoke("set_create_user", new object [] {
				user_info});

	}
	public System.IAsyncResult Beginset_create_user(ManagementSNMPConfigurationUserInformation [] user_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_create_user", new object[] {
			user_info}, callback, asyncState);
	}
	public void Endset_create_user(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_dynamic_loadable_module
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void set_dynamic_loadable_module(
		ManagementSNMPConfigurationDynamicLoadableModule [] mod_info
	) {
		this.Invoke("set_dynamic_loadable_module", new object [] {
				mod_info});

	}
	public System.IAsyncResult Beginset_dynamic_loadable_module(ManagementSNMPConfigurationDynamicLoadableModule [] mod_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_dynamic_loadable_module", new object[] {
			mod_info}, callback, asyncState);
	}
	public void Endset_dynamic_loadable_module(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_engine_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void set_engine_id(
		string engine_id
	) {
		this.Invoke("set_engine_id", new object [] {
				engine_id});

	}
	public System.IAsyncResult Beginset_engine_id(string engine_id, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_engine_id", new object[] {
			engine_id}, callback, asyncState);
	}
	public void Endset_engine_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_exec
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void set_exec(
		ManagementSNMPConfigurationMibnumNameProgArgs [] exec_info
	) {
		this.Invoke("set_exec", new object [] {
				exec_info});

	}
	public System.IAsyncResult Beginset_exec(ManagementSNMPConfigurationMibnumNameProgArgs [] exec_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_exec", new object[] {
			exec_info}, callback, asyncState);
	}
	public void Endset_exec(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_exec_fix
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void set_exec_fix(
		ManagementSNMPConfigurationNameProgArgs [] exec_info
	) {
		this.Invoke("set_exec_fix", new object [] {
				exec_info});

	}
	public System.IAsyncResult Beginset_exec_fix(ManagementSNMPConfigurationNameProgArgs [] exec_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_exec_fix", new object[] {
			exec_info}, callback, asyncState);
	}
	public void Endset_exec_fix(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_generic_traps
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void set_generic_traps(
		ManagementSNMPConfigurationGenericSinkInformation [] sink_info
	) {
		this.Invoke("set_generic_traps", new object [] {
				sink_info});

	}
	public System.IAsyncResult Beginset_generic_traps(ManagementSNMPConfigurationGenericSinkInformation [] sink_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_generic_traps", new object[] {
			sink_info}, callback, asyncState);
	}
	public void Endset_generic_traps(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_generic_traps_v2
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void set_generic_traps_v2(
		ManagementSNMPConfigurationGenericSinkInformation2 [] sink_info
	) {
		this.Invoke("set_generic_traps_v2", new object [] {
				sink_info});

	}
	public System.IAsyncResult Beginset_generic_traps_v2(ManagementSNMPConfigurationGenericSinkInformation2 [] sink_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_generic_traps_v2", new object[] {
			sink_info}, callback, asyncState);
	}
	public void Endset_generic_traps_v2(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_group_info
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void set_group_info(
		ManagementSNMPConfigurationGroupInformation [] group_info
	) {
		this.Invoke("set_group_info", new object [] {
				group_info});

	}
	public System.IAsyncResult Beginset_group_info(ManagementSNMPConfigurationGroupInformation [] group_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_group_info", new object[] {
			group_info}, callback, asyncState);
	}
	public void Endset_group_info(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ignore_disk
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void set_ignore_disk(
		string [] ignore_disk
	) {
		this.Invoke("set_ignore_disk", new object [] {
				ignore_disk});

	}
	public System.IAsyncResult Beginset_ignore_disk(string [] ignore_disk, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ignore_disk", new object[] {
			ignore_disk}, callback, asyncState);
	}
	public void Endset_ignore_disk(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_pass_through
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void set_pass_through(
		ManagementSNMPConfigurationPassThroughInformation [] passthru_info
	) {
		this.Invoke("set_pass_through", new object [] {
				passthru_info});

	}
	public System.IAsyncResult Beginset_pass_through(ManagementSNMPConfigurationPassThroughInformation [] passthru_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_pass_through", new object[] {
			passthru_info}, callback, asyncState);
	}
	public void Endset_pass_through(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_pass_through_persist
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void set_pass_through_persist(
		ManagementSNMPConfigurationPassThroughInformation [] passthru_info
	) {
		this.Invoke("set_pass_through_persist", new object [] {
				passthru_info});

	}
	public System.IAsyncResult Beginset_pass_through_persist(ManagementSNMPConfigurationPassThroughInformation [] passthru_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_pass_through_persist", new object[] {
			passthru_info}, callback, asyncState);
	}
	public void Endset_pass_through_persist(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_process_fix
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void set_process_fix(
		ManagementSNMPConfigurationNameProgArgs [] fix_info
	) {
		this.Invoke("set_process_fix", new object [] {
				fix_info});

	}
	public System.IAsyncResult Beginset_process_fix(ManagementSNMPConfigurationNameProgArgs [] fix_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_process_fix", new object[] {
			fix_info}, callback, asyncState);
	}
	public void Endset_process_fix(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_proxy
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void set_proxy(
		string [] proxy_info
	) {
		this.Invoke("set_proxy", new object [] {
				proxy_info});

	}
	public System.IAsyncResult Beginset_proxy(string [] proxy_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_proxy", new object[] {
			proxy_info}, callback, asyncState);
	}
	public void Endset_proxy(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_readonly_community
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void set_readonly_community(
		ManagementSNMPConfigurationWrapperSecurityInformation [] ro_community_info
	) {
		this.Invoke("set_readonly_community", new object [] {
				ro_community_info});

	}
	public System.IAsyncResult Beginset_readonly_community(ManagementSNMPConfigurationWrapperSecurityInformation [] ro_community_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_readonly_community", new object[] {
			ro_community_info}, callback, asyncState);
	}
	public void Endset_readonly_community(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_readonly_user
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void set_readonly_user(
		ManagementSNMPConfigurationWrapperUserInformation [] ro_user_info
	) {
		this.Invoke("set_readonly_user", new object [] {
				ro_user_info});

	}
	public System.IAsyncResult Beginset_readonly_user(ManagementSNMPConfigurationWrapperUserInformation [] ro_user_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_readonly_user", new object[] {
			ro_user_info}, callback, asyncState);
	}
	public void Endset_readonly_user(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_readwrite_community
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void set_readwrite_community(
		ManagementSNMPConfigurationWrapperSecurityInformation [] rw_community_info
	) {
		this.Invoke("set_readwrite_community", new object [] {
				rw_community_info});

	}
	public System.IAsyncResult Beginset_readwrite_community(ManagementSNMPConfigurationWrapperSecurityInformation [] rw_community_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_readwrite_community", new object[] {
			rw_community_info}, callback, asyncState);
	}
	public void Endset_readwrite_community(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_readwrite_user
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void set_readwrite_user(
		ManagementSNMPConfigurationWrapperUserInformation [] rw_user_info
	) {
		this.Invoke("set_readwrite_user", new object [] {
				rw_user_info});

	}
	public System.IAsyncResult Beginset_readwrite_user(ManagementSNMPConfigurationWrapperUserInformation [] rw_user_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_readwrite_user", new object[] {
			rw_user_info}, callback, asyncState);
	}
	public void Endset_readwrite_user(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_smux_subagent
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void set_smux_subagent(
		ManagementSNMPConfigurationSmuxSubAgentInformation [] subagent_info
	) {
		this.Invoke("set_smux_subagent", new object [] {
				subagent_info});

	}
	public System.IAsyncResult Beginset_smux_subagent(ManagementSNMPConfigurationSmuxSubAgentInformation [] subagent_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_smux_subagent", new object[] {
			subagent_info}, callback, asyncState);
	}
	public void Endset_smux_subagent(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_storage_use_nfs
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void set_storage_use_nfs(
		long usage
	) {
		this.Invoke("set_storage_use_nfs", new object [] {
				usage});

	}
	public System.IAsyncResult Beginset_storage_use_nfs(long usage, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_storage_use_nfs", new object[] {
			usage}, callback, asyncState);
	}
	public void Endset_storage_use_nfs(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_system_information
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void set_system_information(
		ManagementSNMPConfigurationSystemInformation system_info
	) {
		this.Invoke("set_system_information", new object [] {
				system_info});

	}
	public System.IAsyncResult Beginset_system_information(ManagementSNMPConfigurationSystemInformation system_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_system_information", new object[] {
			system_info}, callback, asyncState);
	}
	public void Endset_system_information(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_trap_community
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void set_trap_community(
		string community
	) {
		this.Invoke("set_trap_community", new object [] {
				community});

	}
	public System.IAsyncResult Beginset_trap_community(string community, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_trap_community", new object[] {
			community}, callback, asyncState);
	}
	public void Endset_trap_community(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_trap_sinks
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void set_trap_sinks(
		ManagementSNMPConfigurationSinkType sink_type,
		ManagementSNMPConfigurationSinkInformation [] sink_info
	) {
		this.Invoke("set_trap_sinks", new object [] {
				sink_type,
				sink_info});

	}
	public System.IAsyncResult Beginset_trap_sinks(ManagementSNMPConfigurationSinkType sink_type,ManagementSNMPConfigurationSinkInformation [] sink_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_trap_sinks", new object[] {
			sink_type,
			sink_info}, callback, asyncState);
	}
	public void Endset_trap_sinks(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_view_info
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/SNMPConfiguration", 
		RequestNamespace="urn:iControl:Management/SNMPConfiguration", ResponseNamespace="urn:iControl:Management/SNMPConfiguration")]
	public void set_view_info(
		ManagementSNMPConfigurationViewInformation [] view_info
	) {
		this.Invoke("set_view_info", new object [] {
				view_info});

	}
	public System.IAsyncResult Beginset_view_info(ManagementSNMPConfigurationViewInformation [] view_info, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_view_info", new object[] {
			view_info}, callback, asyncState);
	}
	public void Endset_view_info(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.SNMPConfiguration.AuthType", Namespace = "urn:iControl")]
	public enum ManagementSNMPConfigurationAuthType
	{
		AUTH_MD5,
		AUTH_SHA,
		AUTH_NONE,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.SNMPConfiguration.DiskCheckType", Namespace = "urn:iControl")]
	public enum ManagementSNMPConfigurationDiskCheckType
	{
		DISKCHECK_SIZE,
		DISKCHECK_PERCENT,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.SNMPConfiguration.LevelType", Namespace = "urn:iControl")]
	public enum ManagementSNMPConfigurationLevelType
	{
		LEVEL_NOAUTH,
		LEVEL_AUTH,
		LEVEL_PRIV,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.SNMPConfiguration.ModelType", Namespace = "urn:iControl")]
	public enum ManagementSNMPConfigurationModelType
	{
		MODEL_ANY,
		MODEL_V1,
		MODEL_V2C,
		MODEL_USM,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.SNMPConfiguration.PrefixType", Namespace = "urn:iControl")]
	public enum ManagementSNMPConfigurationPrefixType
	{
		PREFIX_EXACT,
		PREFIX_PREFIX,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.SNMPConfiguration.PrivacyProtocolType", Namespace = "urn:iControl")]
	public enum ManagementSNMPConfigurationPrivacyProtocolType
	{
		PRIV_PROTOCOL_DES,
		PRIV_PROTOCOL_NONE,
		PRIV_PROTOCOL_AES,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.SNMPConfiguration.SinkType", Namespace = "urn:iControl")]
	public enum ManagementSNMPConfigurationSinkType
	{
		SINK_TRAPSINK,
		SINK_TRAP2SINK,
		SINK_INFORMSINK,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.SNMPConfiguration.TransportType", Namespace = "urn:iControl")]
	public enum ManagementSNMPConfigurationTransportType
	{
		TRANSPORT_UDP,
		TRANSPORT_TCP,
		TRANSPORT_UDP6,
		TRANSPORT_TCP6,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.SNMPConfiguration.ViewType", Namespace = "urn:iControl")]
	public enum ManagementSNMPConfigurationViewType
	{
		VIEW_INCLUDED,
		VIEW_EXCLUDED,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.SNMPConfiguration.AccessInformation", Namespace = "urn:iControl")]
	public partial class ManagementSNMPConfigurationAccessInformation
	{
		private string access_nameField;
		public string access_name
		{
			get { return this.access_nameField; }
			set { this.access_nameField = value; }
		}
		private string access_contextField;
		public string access_context
		{
			get { return this.access_contextField; }
			set { this.access_contextField = value; }
		}
		private ManagementSNMPConfigurationModelType modelField;
		public ManagementSNMPConfigurationModelType model
		{
			get { return this.modelField; }
			set { this.modelField = value; }
		}
		private ManagementSNMPConfigurationLevelType levelField;
		public ManagementSNMPConfigurationLevelType level
		{
			get { return this.levelField; }
			set { this.levelField = value; }
		}
		private ManagementSNMPConfigurationPrefixType prefixField;
		public ManagementSNMPConfigurationPrefixType prefix
		{
			get { return this.prefixField; }
			set { this.prefixField = value; }
		}
		private string read_accessField;
		public string read_access
		{
			get { return this.read_accessField; }
			set { this.read_accessField = value; }
		}
		private string write_accessField;
		public string write_access
		{
			get { return this.write_accessField; }
			set { this.write_accessField = value; }
		}
		private string notify_accessField;
		public string notify_access
		{
			get { return this.notify_accessField; }
			set { this.notify_accessField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.SNMPConfiguration.AgentInterface", Namespace = "urn:iControl")]
	public partial class ManagementSNMPConfigurationAgentInterface
	{
		private string intf_nameField;
		public string intf_name
		{
			get { return this.intf_nameField; }
			set { this.intf_nameField = value; }
		}
		private string intf_typeField;
		public string intf_type
		{
			get { return this.intf_typeField; }
			set { this.intf_typeField = value; }
		}
		private string intf_speedField;
		public string intf_speed
		{
			get { return this.intf_speedField; }
			set { this.intf_speedField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.SNMPConfiguration.AgentListenAddressPort", Namespace = "urn:iControl")]
	public partial class ManagementSNMPConfigurationAgentListenAddressPort
	{
		private ManagementSNMPConfigurationTransportType transportField;
		public ManagementSNMPConfigurationTransportType transport
		{
			get { return this.transportField; }
			set { this.transportField = value; }
		}
		private CommonIPPortDefinition ipportField;
		public CommonIPPortDefinition ipport
		{
			get { return this.ipportField; }
			set { this.ipportField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.SNMPConfiguration.AgentXInformation", Namespace = "urn:iControl")]
	public partial class ManagementSNMPConfigurationAgentXInformation
	{
		private string addressField;
		public string address
		{
			get { return this.addressField; }
			set { this.addressField = value; }
		}
		private long timeoutField;
		public long timeout
		{
			get { return this.timeoutField; }
			set { this.timeoutField = value; }
		}
		private long retriesField;
		public long retries
		{
			get { return this.retriesField; }
			set { this.retriesField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.SNMPConfiguration.ClientAccess", Namespace = "urn:iControl")]
	public partial class ManagementSNMPConfigurationClientAccess
	{
		private string addressField;
		public string address
		{
			get { return this.addressField; }
			set { this.addressField = value; }
		}
		private string netmaskField;
		public string netmask
		{
			get { return this.netmaskField; }
			set { this.netmaskField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.SNMPConfiguration.DiskCheckInformation", Namespace = "urn:iControl")]
	public partial class ManagementSNMPConfigurationDiskCheckInformation
	{
		private string disk_pathField;
		public string disk_path
		{
			get { return this.disk_pathField; }
			set { this.disk_pathField = value; }
		}
		private ManagementSNMPConfigurationDiskCheckType check_typeField;
		public ManagementSNMPConfigurationDiskCheckType check_type
		{
			get { return this.check_typeField; }
			set { this.check_typeField = value; }
		}
		private long minimum_spaceField;
		public long minimum_space
		{
			get { return this.minimum_spaceField; }
			set { this.minimum_spaceField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.SNMPConfiguration.DynamicLoadableModule", Namespace = "urn:iControl")]
	public partial class ManagementSNMPConfigurationDynamicLoadableModule
	{
		private string module_nameField;
		public string module_name
		{
			get { return this.module_nameField; }
			set { this.module_nameField = value; }
		}
		private string module_pathField;
		public string module_path
		{
			get { return this.module_pathField; }
			set { this.module_pathField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.SNMPConfiguration.FileCheckInformation", Namespace = "urn:iControl")]
	public partial class ManagementSNMPConfigurationFileCheckInformation
	{
		private string file_nameField;
		public string file_name
		{
			get { return this.file_nameField; }
			set { this.file_nameField = value; }
		}
		private long maximum_sizeField;
		public long maximum_size
		{
			get { return this.maximum_sizeField; }
			set { this.maximum_sizeField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.SNMPConfiguration.GenericSinkInformation", Namespace = "urn:iControl")]
	public partial class ManagementSNMPConfigurationGenericSinkInformation
	{
		private string snmpcmd_argsField;
		public string snmpcmd_args
		{
			get { return this.snmpcmd_argsField; }
			set { this.snmpcmd_argsField = value; }
		}
		private string sink_hostField;
		public string sink_host
		{
			get { return this.sink_hostField; }
			set { this.sink_hostField = value; }
		}
		private string sink_communityField;
		public string sink_community
		{
			get { return this.sink_communityField; }
			set { this.sink_communityField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.SNMPConfiguration.GenericSinkInformation2", Namespace = "urn:iControl")]
	public partial class ManagementSNMPConfigurationGenericSinkInformation2
	{
		private string snmpcmd_argsField;
		public string snmpcmd_args
		{
			get { return this.snmpcmd_argsField; }
			set { this.snmpcmd_argsField = value; }
		}
		private string sink_hostField;
		public string sink_host
		{
			get { return this.sink_hostField; }
			set { this.sink_hostField = value; }
		}
		private long sink_portField;
		public long sink_port
		{
			get { return this.sink_portField; }
			set { this.sink_portField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.SNMPConfiguration.GroupInformation", Namespace = "urn:iControl")]
	public partial class ManagementSNMPConfigurationGroupInformation
	{
		private string group_nameField;
		public string group_name
		{
			get { return this.group_nameField; }
			set { this.group_nameField = value; }
		}
		private ManagementSNMPConfigurationModelType modelField;
		public ManagementSNMPConfigurationModelType model
		{
			get { return this.modelField; }
			set { this.modelField = value; }
		}
		private string security_nameField;
		public string security_name
		{
			get { return this.security_nameField; }
			set { this.security_nameField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.SNMPConfiguration.LoadAverageInformation", Namespace = "urn:iControl")]
	public partial class ManagementSNMPConfigurationLoadAverageInformation
	{
		private long max_1_minute_loadField;
		public long max_1_minute_load
		{
			get { return this.max_1_minute_loadField; }
			set { this.max_1_minute_loadField = value; }
		}
		private long max_5_minute_loadField;
		public long max_5_minute_load
		{
			get { return this.max_5_minute_loadField; }
			set { this.max_5_minute_loadField = value; }
		}
		private long max_15_minute_loadField;
		public long max_15_minute_load
		{
			get { return this.max_15_minute_loadField; }
			set { this.max_15_minute_loadField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.SNMPConfiguration.MibnumNameProgArgs", Namespace = "urn:iControl")]
	public partial class ManagementSNMPConfigurationMibnumNameProgArgs
	{
		private string mib_numField;
		public string mib_num
		{
			get { return this.mib_numField; }
			set { this.mib_numField = value; }
		}
		private ManagementSNMPConfigurationNameProgArgs name_prog_argsField;
		public ManagementSNMPConfigurationNameProgArgs name_prog_args
		{
			get { return this.name_prog_argsField; }
			set { this.name_prog_argsField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.SNMPConfiguration.NameProgArgs", Namespace = "urn:iControl")]
	public partial class ManagementSNMPConfigurationNameProgArgs
	{
		private string process_nameField;
		public string process_name
		{
			get { return this.process_nameField; }
			set { this.process_nameField = value; }
		}
		private string program_nameField;
		public string program_name
		{
			get { return this.program_nameField; }
			set { this.program_nameField = value; }
		}
		private string program_argsField;
		public string program_args
		{
			get { return this.program_argsField; }
			set { this.program_argsField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.SNMPConfiguration.PassThroughInformation", Namespace = "urn:iControl")]
	public partial class ManagementSNMPConfigurationPassThroughInformation
	{
		private string mib_oidField;
		public string mib_oid
		{
			get { return this.mib_oidField; }
			set { this.mib_oidField = value; }
		}
		private string exec_nameField;
		public string exec_name
		{
			get { return this.exec_nameField; }
			set { this.exec_nameField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.SNMPConfiguration.ProcessInformation", Namespace = "urn:iControl")]
	public partial class ManagementSNMPConfigurationProcessInformation
	{
		private string process_nameField;
		public string process_name
		{
			get { return this.process_nameField; }
			set { this.process_nameField = value; }
		}
		private long maxField;
		public long max
		{
			get { return this.maxField; }
			set { this.maxField = value; }
		}
		private long minField;
		public long min
		{
			get { return this.minField; }
			set { this.minField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.SNMPConfiguration.ProxyInformation", Namespace = "urn:iControl")]
	public partial class ManagementSNMPConfigurationProxyInformation
	{
		private string snmpcmd_argsField;
		public string snmpcmd_args
		{
			get { return this.snmpcmd_argsField; }
			set { this.snmpcmd_argsField = value; }
		}
		private string remote_hostField;
		public string remote_host
		{
			get { return this.remote_hostField; }
			set { this.remote_hostField = value; }
		}
		private string local_oidField;
		public string local_oid
		{
			get { return this.local_oidField; }
			set { this.local_oidField = value; }
		}
		private string remote_oidField;
		public string remote_oid
		{
			get { return this.remote_oidField; }
			set { this.remote_oidField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.SNMPConfiguration.SecurityInformation", Namespace = "urn:iControl")]
	public partial class ManagementSNMPConfigurationSecurityInformation
	{
		private string security_nameField;
		public string security_name
		{
			get { return this.security_nameField; }
			set { this.security_nameField = value; }
		}
		private string sourceField;
		public string source
		{
			get { return this.sourceField; }
			set { this.sourceField = value; }
		}
		private string community_nameField;
		public string community_name
		{
			get { return this.community_nameField; }
			set { this.community_nameField = value; }
		}
		private bool ipv6Field;
		public bool ipv6
		{
			get { return this.ipv6Field; }
			set { this.ipv6Field = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.SNMPConfiguration.SinkInformation", Namespace = "urn:iControl")]
	public partial class ManagementSNMPConfigurationSinkInformation
	{
		private string sink_hostField;
		public string sink_host
		{
			get { return this.sink_hostField; }
			set { this.sink_hostField = value; }
		}
		private string sink_communityField;
		public string sink_community
		{
			get { return this.sink_communityField; }
			set { this.sink_communityField = value; }
		}
		private long sink_portField;
		public long sink_port
		{
			get { return this.sink_portField; }
			set { this.sink_portField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.SNMPConfiguration.SmuxSubAgentInformation", Namespace = "urn:iControl")]
	public partial class ManagementSNMPConfigurationSmuxSubAgentInformation
	{
		private string oidField;
		public string oid
		{
			get { return this.oidField; }
			set { this.oidField = value; }
		}
		private string passwordField;
		public string password
		{
			get { return this.passwordField; }
			set { this.passwordField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.SNMPConfiguration.SystemInformation", Namespace = "urn:iControl")]
	public partial class ManagementSNMPConfigurationSystemInformation
	{
		private string sys_nameField;
		public string sys_name
		{
			get { return this.sys_nameField; }
			set { this.sys_nameField = value; }
		}
		private string sys_locationField;
		public string sys_location
		{
			get { return this.sys_locationField; }
			set { this.sys_locationField = value; }
		}
		private string sys_contactField;
		public string sys_contact
		{
			get { return this.sys_contactField; }
			set { this.sys_contactField = value; }
		}
		private string sys_descriptionField;
		public string sys_description
		{
			get { return this.sys_descriptionField; }
			set { this.sys_descriptionField = value; }
		}
		private string sys_object_idField;
		public string sys_object_id
		{
			get { return this.sys_object_idField; }
			set { this.sys_object_idField = value; }
		}
		private long sys_servicesField;
		public long sys_services
		{
			get { return this.sys_servicesField; }
			set { this.sys_servicesField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.SNMPConfiguration.UserInformation", Namespace = "urn:iControl")]
	public partial class ManagementSNMPConfigurationUserInformation
	{
		private string user_nameField;
		public string user_name
		{
			get { return this.user_nameField; }
			set { this.user_nameField = value; }
		}
		private ManagementSNMPConfigurationAuthType auth_typeField;
		public ManagementSNMPConfigurationAuthType auth_type
		{
			get { return this.auth_typeField; }
			set { this.auth_typeField = value; }
		}
		private string auth_pass_phraseField;
		public string auth_pass_phrase
		{
			get { return this.auth_pass_phraseField; }
			set { this.auth_pass_phraseField = value; }
		}
		private ManagementSNMPConfigurationPrivacyProtocolType priv_protocolField;
		public ManagementSNMPConfigurationPrivacyProtocolType priv_protocol
		{
			get { return this.priv_protocolField; }
			set { this.priv_protocolField = value; }
		}
		private string priv_pass_phraseField;
		public string priv_pass_phrase
		{
			get { return this.priv_pass_phraseField; }
			set { this.priv_pass_phraseField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.SNMPConfiguration.ViewInformation", Namespace = "urn:iControl")]
	public partial class ManagementSNMPConfigurationViewInformation
	{
		private string view_nameField;
		public string view_name
		{
			get { return this.view_nameField; }
			set { this.view_nameField = value; }
		}
		private ManagementSNMPConfigurationViewType typeField;
		public ManagementSNMPConfigurationViewType type
		{
			get { return this.typeField; }
			set { this.typeField = value; }
		}
		private string subtreeField;
		public string subtree
		{
			get { return this.subtreeField; }
			set { this.subtreeField = value; }
		}
		private string masksField;
		public string masks
		{
			get { return this.masksField; }
			set { this.masksField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.SNMPConfiguration.WrapperSecurityInformation", Namespace = "urn:iControl")]
	public partial class ManagementSNMPConfigurationWrapperSecurityInformation
	{
		private string communityField;
		public string community
		{
			get { return this.communityField; }
			set { this.communityField = value; }
		}
		private string sourceField;
		public string source
		{
			get { return this.sourceField; }
			set { this.sourceField = value; }
		}
		private string oidField;
		public string oid
		{
			get { return this.oidField; }
			set { this.oidField = value; }
		}
		private bool ipv6Field;
		public bool ipv6
		{
			get { return this.ipv6Field; }
			set { this.ipv6Field = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.SNMPConfiguration.WrapperUserInformation", Namespace = "urn:iControl")]
	public partial class ManagementSNMPConfigurationWrapperUserInformation
	{
		private string userField;
		public string user
		{
			get { return this.userField; }
			set { this.userField = value; }
		}
		private ManagementSNMPConfigurationLevelType levelField;
		public ManagementSNMPConfigurationLevelType level
		{
			get { return this.levelField; }
			set { this.levelField = value; }
		}
		private string oidField;
		public string oid
		{
			get { return this.oidField; }
			set { this.oidField = value; }
		}
	};

}
