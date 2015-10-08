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
	[System.Web.Services.WebServiceBindingAttribute(Name="Management.DeviceBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementDeviceMulticastAddress))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(ManagementDeviceUnicastAddress))]
	public partial class ManagementDevice : iControlInterface {
		public ManagementDevice() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// create
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Device", 
		RequestNamespace="urn:iControl:Management/Device", ResponseNamespace="urn:iControl:Management/Device")]
	public void create(
		string [] devices,
		string [] addresses
	) {
		this.Invoke("create", new object [] {
				devices,
				addresses});

	}
	public System.IAsyncResult Begincreate(string [] devices,string [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("create", new object[] {
			devices,
			addresses}, callback, asyncState);
	}
	public void Endcreate(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// get_active_modules
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Device", 
		RequestNamespace="urn:iControl:Management/Device", ResponseNamespace="urn:iControl:Management/Device")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_active_modules(
		string [] devices
	) {
		object [] results = this.Invoke("get_active_modules", new object [] {
				devices});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_active_modules(string [] devices, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_active_modules", new object[] {
			devices}, callback, asyncState);
	}
	public string [] [] Endget_active_modules(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_base_mac_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Device", 
		RequestNamespace="urn:iControl:Management/Device", ResponseNamespace="urn:iControl:Management/Device")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_base_mac_address(
		string [] devices
	) {
		object [] results = this.Invoke("get_base_mac_address", new object [] {
				devices});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_base_mac_address(string [] devices, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_base_mac_address", new object[] {
			devices}, callback, asyncState);
	}
	public string [] Endget_base_mac_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_blade_addresses
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Device", 
		RequestNamespace="urn:iControl:Management/Device", ResponseNamespace="urn:iControl:Management/Device")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_blade_addresses(
		string [] devices
	) {
		object [] results = this.Invoke("get_blade_addresses", new object [] {
				devices});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_blade_addresses(string [] devices, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_blade_addresses", new object[] {
			devices}, callback, asyncState);
	}
	public string [] [] Endget_blade_addresses(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_build
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Device", 
		RequestNamespace="urn:iControl:Management/Device", ResponseNamespace="urn:iControl:Management/Device")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_build(
		string [] devices
	) {
		object [] results = this.Invoke("get_build", new object [] {
				devices});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_build(string [] devices, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_build", new object[] {
			devices}, callback, asyncState);
	}
	public string [] Endget_build(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cert
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Device", 
		RequestNamespace="urn:iControl:Management/Device", ResponseNamespace="urn:iControl:Management/Device")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_cert(
		string [] devices
	) {
		object [] results = this.Invoke("get_cert", new object [] {
				devices});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_cert(string [] devices, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cert", new object[] {
			devices}, callback, asyncState);
	}
	public string [] Endget_cert(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_chassis_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Device", 
		RequestNamespace="urn:iControl:Management/Device", ResponseNamespace="urn:iControl:Management/Device")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_chassis_id(
		string [] devices
	) {
		object [] results = this.Invoke("get_chassis_id", new object [] {
				devices});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_chassis_id(string [] devices, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_chassis_id", new object[] {
			devices}, callback, asyncState);
	}
	public string [] Endget_chassis_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_chassis_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Device", 
		RequestNamespace="urn:iControl:Management/Device", ResponseNamespace="urn:iControl:Management/Device")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementDeviceChassisVersion [] get_chassis_type(
		string [] devices
	) {
		object [] results = this.Invoke("get_chassis_type", new object [] {
				devices});
		return ((ManagementDeviceChassisVersion [])(results[0]));
	}
	public System.IAsyncResult Beginget_chassis_type(string [] devices, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_chassis_type", new object[] {
			devices}, callback, asyncState);
	}
	public ManagementDeviceChassisVersion [] Endget_chassis_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementDeviceChassisVersion [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_comment
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Device", 
		RequestNamespace="urn:iControl:Management/Device", ResponseNamespace="urn:iControl:Management/Device")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_comment(
		string [] devices
	) {
		object [] results = this.Invoke("get_comment", new object [] {
				devices});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_comment(string [] devices, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_comment", new object[] {
			devices}, callback, asyncState);
	}
	public string [] Endget_comment(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_configsync_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Device", 
		RequestNamespace="urn:iControl:Management/Device", ResponseNamespace="urn:iControl:Management/Device")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_configsync_address(
		string [] devices
	) {
		object [] results = this.Invoke("get_configsync_address", new object [] {
				devices});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_configsync_address(string [] devices, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_configsync_address", new object[] {
			devices}, callback, asyncState);
	}
	public string [] Endget_configsync_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_contact
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Device", 
		RequestNamespace="urn:iControl:Management/Device", ResponseNamespace="urn:iControl:Management/Device")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_contact(
		string [] devices
	) {
		object [] results = this.Invoke("get_contact", new object [] {
				devices});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_contact(string [] devices, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_contact", new object[] {
			devices}, callback, asyncState);
	}
	public string [] Endget_contact(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Device", 
		RequestNamespace="urn:iControl:Management/Device", ResponseNamespace="urn:iControl:Management/Device")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_description(
		string [] devices
	) {
		object [] results = this.Invoke("get_description", new object [] {
				devices});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_description(string [] devices, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_description", new object[] {
			devices}, callback, asyncState);
	}
	public string [] Endget_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_edition
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Device", 
		RequestNamespace="urn:iControl:Management/Device", ResponseNamespace="urn:iControl:Management/Device")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_edition(
		string [] devices
	) {
		object [] results = this.Invoke("get_edition", new object [] {
				devices});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_edition(string [] devices, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_edition", new object[] {
			devices}, callback, asyncState);
	}
	public string [] Endget_edition(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_failover_state
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Device", 
		RequestNamespace="urn:iControl:Management/Device", ResponseNamespace="urn:iControl:Management/Device")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonHAState [] get_failover_state(
		string [] devices
	) {
		object [] results = this.Invoke("get_failover_state", new object [] {
				devices});
		return ((CommonHAState [])(results[0]));
	}
	public System.IAsyncResult Beginget_failover_state(string [] devices, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_failover_state", new object[] {
			devices}, callback, asyncState);
	}
	public CommonHAState [] Endget_failover_state(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonHAState [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_ha_capacity
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Device", 
		RequestNamespace="urn:iControl:Management/Device", ResponseNamespace="urn:iControl:Management/Device")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long [] get_ha_capacity(
		string [] devices
	) {
		object [] results = this.Invoke("get_ha_capacity", new object [] {
				devices});
		return ((long [])(results[0]));
	}
	public System.IAsyncResult Beginget_ha_capacity(string [] devices, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_ha_capacity", new object[] {
			devices}, callback, asyncState);
	}
	public long [] Endget_ha_capacity(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_hostname
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Device", 
		RequestNamespace="urn:iControl:Management/Device", ResponseNamespace="urn:iControl:Management/Device")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_hostname(
		string [] devices
	) {
		object [] results = this.Invoke("get_hostname", new object [] {
				devices});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_hostname(string [] devices, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_hostname", new object[] {
			devices}, callback, asyncState);
	}
	public string [] Endget_hostname(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_inactive_modules
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Device", 
		RequestNamespace="urn:iControl:Management/Device", ResponseNamespace="urn:iControl:Management/Device")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_inactive_modules(
		string [] devices
	) {
		object [] results = this.Invoke("get_inactive_modules", new object [] {
				devices});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_inactive_modules(string [] devices, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_inactive_modules", new object[] {
			devices}, callback, asyncState);
	}
	public string [] [] Endget_inactive_modules(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Device", 
		RequestNamespace="urn:iControl:Management/Device", ResponseNamespace="urn:iControl:Management/Device")]
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
	// get_local_device
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Device", 
		RequestNamespace="urn:iControl:Management/Device", ResponseNamespace="urn:iControl:Management/Device")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string get_local_device(

	) {
		object [] results = this.Invoke("get_local_device", new object [0]);
		return ((string)(results[0]));
	}
	public System.IAsyncResult Beginget_local_device(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_local_device", new object[0], callback, asyncState);
	}
	public string Endget_local_device(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_location
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Device", 
		RequestNamespace="urn:iControl:Management/Device", ResponseNamespace="urn:iControl:Management/Device")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_location(
		string [] devices
	) {
		object [] results = this.Invoke("get_location", new object [] {
				devices});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_location(string [] devices, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_location", new object[] {
			devices}, callback, asyncState);
	}
	public string [] Endget_location(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_management_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Device", 
		RequestNamespace="urn:iControl:Management/Device", ResponseNamespace="urn:iControl:Management/Device")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_management_address(
		string [] devices
	) {
		object [] results = this.Invoke("get_management_address", new object [] {
				devices});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_management_address(string [] devices, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_management_address", new object[] {
			devices}, callback, asyncState);
	}
	public string [] Endget_management_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_marketing_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Device", 
		RequestNamespace="urn:iControl:Management/Device", ResponseNamespace="urn:iControl:Management/Device")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_marketing_name(
		string [] devices
	) {
		object [] results = this.Invoke("get_marketing_name", new object [] {
				devices});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_marketing_name(string [] devices, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_marketing_name", new object[] {
			devices}, callback, asyncState);
	}
	public string [] Endget_marketing_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_multicast_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Device", 
		RequestNamespace="urn:iControl:Management/Device", ResponseNamespace="urn:iControl:Management/Device")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementDeviceMulticastAddress [] get_multicast_address(
		string [] devices
	) {
		object [] results = this.Invoke("get_multicast_address", new object [] {
				devices});
		return ((ManagementDeviceMulticastAddress [])(results[0]));
	}
	public System.IAsyncResult Beginget_multicast_address(string [] devices, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_multicast_address", new object[] {
			devices}, callback, asyncState);
	}
	public ManagementDeviceMulticastAddress [] Endget_multicast_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementDeviceMulticastAddress [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_optional_modules
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Device", 
		RequestNamespace="urn:iControl:Management/Device", ResponseNamespace="urn:iControl:Management/Device")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_optional_modules(
		string [] devices
	) {
		object [] results = this.Invoke("get_optional_modules", new object [] {
				devices});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_optional_modules(string [] devices, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_optional_modules", new object[] {
			devices}, callback, asyncState);
	}
	public string [] [] Endget_optional_modules(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_platform_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Device", 
		RequestNamespace="urn:iControl:Management/Device", ResponseNamespace="urn:iControl:Management/Device")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_platform_id(
		string [] devices
	) {
		object [] results = this.Invoke("get_platform_id", new object [] {
				devices});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_platform_id(string [] devices, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_platform_id", new object[] {
			devices}, callback, asyncState);
	}
	public string [] Endget_platform_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_primary_mirror_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Device", 
		RequestNamespace="urn:iControl:Management/Device", ResponseNamespace="urn:iControl:Management/Device")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_primary_mirror_address(
		string [] devices
	) {
		object [] results = this.Invoke("get_primary_mirror_address", new object [] {
				devices});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_primary_mirror_address(string [] devices, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_primary_mirror_address", new object[] {
			devices}, callback, asyncState);
	}
	public string [] Endget_primary_mirror_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_product
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Device", 
		RequestNamespace="urn:iControl:Management/Device", ResponseNamespace="urn:iControl:Management/Device")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_product(
		string [] devices
	) {
		object [] results = this.Invoke("get_product", new object [] {
				devices});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_product(string [] devices, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_product", new object[] {
			devices}, callback, asyncState);
	}
	public string [] Endget_product(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_secondary_mirror_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Device", 
		RequestNamespace="urn:iControl:Management/Device", ResponseNamespace="urn:iControl:Management/Device")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_secondary_mirror_address(
		string [] devices
	) {
		object [] results = this.Invoke("get_secondary_mirror_address", new object [] {
				devices});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_secondary_mirror_address(string [] devices, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_secondary_mirror_address", new object[] {
			devices}, callback, asyncState);
	}
	public string [] Endget_secondary_mirror_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_software_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Device", 
		RequestNamespace="urn:iControl:Management/Device", ResponseNamespace="urn:iControl:Management/Device")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_software_version(
		string [] devices
	) {
		object [] results = this.Invoke("get_software_version", new object [] {
				devices});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_software_version(string [] devices, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_software_version", new object[] {
			devices}, callback, asyncState);
	}
	public string [] Endget_software_version(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_timelimited_modules
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Device", 
		RequestNamespace="urn:iControl:Management/Device", ResponseNamespace="urn:iControl:Management/Device")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] [] get_timelimited_modules(
		string [] devices
	) {
		object [] results = this.Invoke("get_timelimited_modules", new object [] {
				devices});
		return ((string [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_timelimited_modules(string [] devices, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_timelimited_modules", new object[] {
			devices}, callback, asyncState);
	}
	public string [] [] Endget_timelimited_modules(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_timezone
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Device", 
		RequestNamespace="urn:iControl:Management/Device", ResponseNamespace="urn:iControl:Management/Device")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_timezone(
		string [] devices
	) {
		object [] results = this.Invoke("get_timezone", new object [] {
				devices});
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_timezone(string [] devices, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_timezone", new object[] {
			devices}, callback, asyncState);
	}
	public string [] Endget_timezone(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_unicast_addresses
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Device", 
		RequestNamespace="urn:iControl:Management/Device", ResponseNamespace="urn:iControl:Management/Device")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public ManagementDeviceUnicastAddress [] [] get_unicast_addresses(
		string [] devices
	) {
		object [] results = this.Invoke("get_unicast_addresses", new object [] {
				devices});
		return ((ManagementDeviceUnicastAddress [] [])(results[0]));
	}
	public System.IAsyncResult Beginget_unicast_addresses(string [] devices, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_unicast_addresses", new object[] {
			devices}, callback, asyncState);
	}
	public ManagementDeviceUnicastAddress [] [] Endget_unicast_addresses(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((ManagementDeviceUnicastAddress [] [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Device", 
		RequestNamespace="urn:iControl:Management/Device", ResponseNamespace="urn:iControl:Management/Device")]
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
	// set_comment
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Device", 
		RequestNamespace="urn:iControl:Management/Device", ResponseNamespace="urn:iControl:Management/Device")]
	public void set_comment(
		string [] devices,
		string [] comments
	) {
		this.Invoke("set_comment", new object [] {
				devices,
				comments});

	}
	public System.IAsyncResult Beginset_comment(string [] devices,string [] comments, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_comment", new object[] {
			devices,
			comments}, callback, asyncState);
	}
	public void Endset_comment(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_configsync_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Device", 
		RequestNamespace="urn:iControl:Management/Device", ResponseNamespace="urn:iControl:Management/Device")]
	public void set_configsync_address(
		string [] devices,
		string [] addresses
	) {
		this.Invoke("set_configsync_address", new object [] {
				devices,
				addresses});

	}
	public System.IAsyncResult Beginset_configsync_address(string [] devices,string [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_configsync_address", new object[] {
			devices,
			addresses}, callback, asyncState);
	}
	public void Endset_configsync_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_contact
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Device", 
		RequestNamespace="urn:iControl:Management/Device", ResponseNamespace="urn:iControl:Management/Device")]
	public void set_contact(
		string [] devices,
		string [] contacts
	) {
		this.Invoke("set_contact", new object [] {
				devices,
				contacts});

	}
	public System.IAsyncResult Beginset_contact(string [] devices,string [] contacts, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_contact", new object[] {
			devices,
			contacts}, callback, asyncState);
	}
	public void Endset_contact(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_description
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Device", 
		RequestNamespace="urn:iControl:Management/Device", ResponseNamespace="urn:iControl:Management/Device")]
	public void set_description(
		string [] devices,
		string [] descriptions
	) {
		this.Invoke("set_description", new object [] {
				devices,
				descriptions});

	}
	public System.IAsyncResult Beginset_description(string [] devices,string [] descriptions, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_description", new object[] {
			devices,
			descriptions}, callback, asyncState);
	}
	public void Endset_description(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_ha_capacity
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Device", 
		RequestNamespace="urn:iControl:Management/Device", ResponseNamespace="urn:iControl:Management/Device")]
	public void set_ha_capacity(
		string [] devices,
		long [] capacities
	) {
		this.Invoke("set_ha_capacity", new object [] {
				devices,
				capacities});

	}
	public System.IAsyncResult Beginset_ha_capacity(string [] devices,long [] capacities, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_ha_capacity", new object[] {
			devices,
			capacities}, callback, asyncState);
	}
	public void Endset_ha_capacity(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_location
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Device", 
		RequestNamespace="urn:iControl:Management/Device", ResponseNamespace="urn:iControl:Management/Device")]
	public void set_location(
		string [] devices,
		string [] locations
	) {
		this.Invoke("set_location", new object [] {
				devices,
				locations});

	}
	public System.IAsyncResult Beginset_location(string [] devices,string [] locations, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_location", new object[] {
			devices,
			locations}, callback, asyncState);
	}
	public void Endset_location(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_management_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Device", 
		RequestNamespace="urn:iControl:Management/Device", ResponseNamespace="urn:iControl:Management/Device")]
	public void set_management_address(
		string [] devices,
		string [] addresses
	) {
		this.Invoke("set_management_address", new object [] {
				devices,
				addresses});

	}
	public System.IAsyncResult Beginset_management_address(string [] devices,string [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_management_address", new object[] {
			devices,
			addresses}, callback, asyncState);
	}
	public void Endset_management_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_multicast_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Device", 
		RequestNamespace="urn:iControl:Management/Device", ResponseNamespace="urn:iControl:Management/Device")]
	public void set_multicast_address(
		string [] devices,
		ManagementDeviceMulticastAddress [] addresses
	) {
		this.Invoke("set_multicast_address", new object [] {
				devices,
				addresses});

	}
	public System.IAsyncResult Beginset_multicast_address(string [] devices,ManagementDeviceMulticastAddress [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_multicast_address", new object[] {
			devices,
			addresses}, callback, asyncState);
	}
	public void Endset_multicast_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_primary_mirror_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Device", 
		RequestNamespace="urn:iControl:Management/Device", ResponseNamespace="urn:iControl:Management/Device")]
	public void set_primary_mirror_address(
		string [] devices,
		string [] addresses
	) {
		this.Invoke("set_primary_mirror_address", new object [] {
				devices,
				addresses});

	}
	public System.IAsyncResult Beginset_primary_mirror_address(string [] devices,string [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_primary_mirror_address", new object[] {
			devices,
			addresses}, callback, asyncState);
	}
	public void Endset_primary_mirror_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_secondary_mirror_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Device", 
		RequestNamespace="urn:iControl:Management/Device", ResponseNamespace="urn:iControl:Management/Device")]
	public void set_secondary_mirror_address(
		string [] devices,
		string [] addresses
	) {
		this.Invoke("set_secondary_mirror_address", new object [] {
				devices,
				addresses});

	}
	public System.IAsyncResult Beginset_secondary_mirror_address(string [] devices,string [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_secondary_mirror_address", new object[] {
			devices,
			addresses}, callback, asyncState);
	}
	public void Endset_secondary_mirror_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_unicast_addresses
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:Management/Device", 
		RequestNamespace="urn:iControl:Management/Device", ResponseNamespace="urn:iControl:Management/Device")]
	public void set_unicast_addresses(
		string [] devices,
		ManagementDeviceUnicastAddress [] [] addresses
	) {
		this.Invoke("set_unicast_addresses", new object [] {
				devices,
				addresses});

	}
	public System.IAsyncResult Beginset_unicast_addresses(string [] devices,ManagementDeviceUnicastAddress [] [] addresses, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_unicast_addresses", new object[] {
			devices,
			addresses}, callback, asyncState);
	}
	public void Endset_unicast_addresses(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	}
	//=======================================================================
	// Enums
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.Device.ChassisVersion", Namespace = "urn:iControl")]
	public enum ManagementDeviceChassisVersion
	{
		CHASSIS_VERSION_VIPRION,
		CHASSIS_VERSION_INDIVIDUAL,
		CHASSIS_VERSION_UNKNOWN,
	}

	//=======================================================================
	// Structs
	//=======================================================================

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.Device.MulticastAddress", Namespace = "urn:iControl")]
	public partial class ManagementDeviceMulticastAddress
	{
		private string interface_nameField;
		public string interface_name
		{
			get { return this.interface_nameField; }
			set { this.interface_nameField = value; }
		}
		private CommonIPPortDefinition addressField;
		public CommonIPPortDefinition address
		{
			get { return this.addressField; }
			set { this.addressField = value; }
		}
	};

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.SoapTypeAttribute(TypeName = "Management.Device.UnicastAddress", Namespace = "urn:iControl")]
	public partial class ManagementDeviceUnicastAddress
	{
		private CommonIPPortDefinition sourceField;
		public CommonIPPortDefinition source
		{
			get { return this.sourceField; }
			set { this.sourceField = value; }
		}
		private CommonIPPortDefinition effectiveField;
		public CommonIPPortDefinition effective
		{
			get { return this.effectiveField; }
			set { this.effectiveField = value; }
		}
	};

}
