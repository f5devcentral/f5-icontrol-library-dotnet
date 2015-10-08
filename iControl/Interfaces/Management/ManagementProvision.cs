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
	[System.Web.Services.WebServiceBindingAttribute(Name="Management.ProvisionBinding", Namespace="urn:iControl")]
	public partial class ManagementProvision : iControlInterface {
		public ManagementProvision() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// get_custom_cpu_ratio
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Provision", 
		RequestNamespace="urn:iControl:Management/Provision", ResponseNamespace="urn:iControl:Management/Provision")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_custom_cpu_ratio(
		CommonTMOSModule [] modules
	) {
		object [] results = this.Invoke("get_custom_cpu_ratio", new object [] {
				modules});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_custom_cpu_ratio(CommonTMOSModule [] modules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_custom_cpu_ratio", new object[] {
			modules}, callback, asyncState);
	}
	public long [] Endget_custom_cpu_ratio(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_custom_disk_ratio
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Provision", 
		RequestNamespace="urn:iControl:Management/Provision", ResponseNamespace="urn:iControl:Management/Provision")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_custom_disk_ratio(
		CommonTMOSModule [] modules
	) {
		object [] results = this.Invoke("get_custom_disk_ratio", new object [] {
				modules});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_custom_disk_ratio(CommonTMOSModule [] modules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_custom_disk_ratio", new object[] {
			modules}, callback, asyncState);
	}
	public long [] Endget_custom_disk_ratio(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_custom_memory_ratio
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Provision", 
		RequestNamespace="urn:iControl:Management/Provision", ResponseNamespace="urn:iControl:Management/Provision")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_custom_memory_ratio(
		CommonTMOSModule [] modules
	) {
		object [] results = this.Invoke("get_custom_memory_ratio", new object [] {
				modules});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_custom_memory_ratio(CommonTMOSModule [] modules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_custom_memory_ratio", new object[] {
			modules}, callback, asyncState);
	}
	public long [] Endget_custom_memory_ratio(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Provision", 
		RequestNamespace="urn:iControl:Management/Provision", ResponseNamespace="urn:iControl:Management/Provision")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		CommonTMOSModule [] modules
	) {
		object [] results = this.Invoke("get_description", new object [] {
				modules});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(CommonTMOSModule [] modules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			modules}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_level
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Provision", 
		RequestNamespace="urn:iControl:Management/Provision", ResponseNamespace="urn:iControl:Management/Provision")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementProvisionProvisionLevel [] get_level(
		CommonTMOSModule [] modules
	) {
		object [] results = this.Invoke("get_level", new object [] {
				modules});
		return ((ManagementProvisionProvisionLevel [])(results[0]));
	}
	public System.IAsyncResult Beginget_level(CommonTMOSModule [] modules, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_level", new object[] {
			modules}, callback, asyncState);
	}
	public ManagementProvisionProvisionLevel [] Endget_level(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementProvisionProvisionLevel [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Provision", 
		RequestNamespace="urn:iControl:Management/Provision", ResponseNamespace="urn:iControl:Management/Provision")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonTMOSModule [] get_list(

	) {
		object [] results = this.Invoke("get_list", new object [0]);
		return ((CommonTMOSModule [])(results[0]));
	}
	public System.IAsyncResult Beginget_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_list", new object[0], callback, asyncState);
	}
	public CommonTMOSModule [] Endget_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonTMOSModule [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_provisioned_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Provision", 
		RequestNamespace="urn:iControl:Management/Provision", ResponseNamespace="urn:iControl:Management/Provision")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonTMOSModule [] get_provisioned_list(

	) {
		object [] results = this.Invoke("get_provisioned_list", new object [0]);
		return ((CommonTMOSModule [])(results[0]));
	}
	public System.IAsyncResult Beginget_provisioned_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_provisioned_list", new object[0], callback, asyncState);
	}
	public CommonTMOSModule [] Endget_provisioned_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonTMOSModule [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Provision", 
		RequestNamespace="urn:iControl:Management/Provision", ResponseNamespace="urn:iControl:Management/Provision")]
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
	// set_custom_cpu_ratio
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Provision", 
		RequestNamespace="urn:iControl:Management/Provision", ResponseNamespace="urn:iControl:Management/Provision")]
	public void set_custom_cpu_ratio(
		CommonTMOSModule [] modules,
		long [] ratios
	) {
		this.Invoke("set_custom_cpu_ratio", new object [] {
				modules,
				ratios});

	}
	public System.IAsyncResult Beginset_custom_cpu_ratio(CommonTMOSModule [] modules,long [] ratios, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_custom_cpu_ratio", new object[] {
			modules,
			ratios}, callback, asyncState);
	}
	public void Endset_custom_cpu_ratio(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_custom_disk_ratio
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Provision", 
		RequestNamespace="urn:iControl:Management/Provision", ResponseNamespace="urn:iControl:Management/Provision")]
	public void set_custom_disk_ratio(
		CommonTMOSModule [] modules,
		long [] ratios
	) {
		this.Invoke("set_custom_disk_ratio", new object [] {
				modules,
				ratios});

	}
	public System.IAsyncResult Beginset_custom_disk_ratio(CommonTMOSModule [] modules,long [] ratios, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_custom_disk_ratio", new object[] {
			modules,
			ratios}, callback, asyncState);
	}
	public void Endset_custom_disk_ratio(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_custom_memory_ratio
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Provision", 
		RequestNamespace="urn:iControl:Management/Provision", ResponseNamespace="urn:iControl:Management/Provision")]
	public void set_custom_memory_ratio(
		CommonTMOSModule [] modules,
		long [] ratios
	) {
		this.Invoke("set_custom_memory_ratio", new object [] {
				modules,
				ratios});

	}
	public System.IAsyncResult Beginset_custom_memory_ratio(CommonTMOSModule [] modules,long [] ratios, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_custom_memory_ratio", new object[] {
			modules,
			ratios}, callback, asyncState);
	}
	public void Endset_custom_memory_ratio(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Provision", 
		RequestNamespace="urn:iControl:Management/Provision", ResponseNamespace="urn:iControl:Management/Provision")]
	public void set_description(
		CommonTMOSModule [] modules,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				modules,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(CommonTMOSModule [] modules,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			modules,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_level
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Provision", 
		RequestNamespace="urn:iControl:Management/Provision", ResponseNamespace="urn:iControl:Management/Provision")]
	public void set_level(
		CommonTMOSModule [] modules,
		ManagementProvisionProvisionLevel [] levels
	) {
		this.Invoke("set_level", new object [] {
				modules,
				levels});

	}
	public System.IAsyncResult Beginset_level(CommonTMOSModule [] modules,ManagementProvisionProvisionLevel [] levels, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_level", new object[] {
			modules,
			levels}, callback, asyncState);
	}
	public void Endset_level(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.Provision.ProvisionLevel", Namespace = "urn:iControl")]
	public enum ManagementProvisionProvisionLevel
	{
		PROVISION_LEVEL_NONE,
		PROVISION_LEVEL_MINIMUM,
		PROVISION_LEVEL_NOMINAL,
		PROVISION_LEVEL_DEDICATED,
		PROVISION_LEVEL_CUSTOM,
		PROVISION_LEVEL_UNKNOWN,
	}

	//=======================================================================
	// Structs
	//=======================================================================

}
