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
	[System.Web.Services.WebServiceBindingAttribute(Name="System.SystemInfoBinding", Namespace="urn:iControl")]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemCPUUsageExtendedInformation))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemBladeTemperature))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemChassisSlot))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemConnectionInformation))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemPlatformCPUs))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemCPUUsageInformation))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemDiskUsageInformation))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemPlatformFans))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemGlobalCPUUsageExtendedInformation))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemHardwareInformation))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemLockStatus))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemMemoryUsageInformation))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemPlatformPowerSupplies))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemProductInformation))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemSystemInformation))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(SystemPlatformTemperatures))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonTimeStamp))]
	[System.Xml.Serialization.SoapIncludeAttribute(typeof(CommonTimeZone))]
	public partial class SystemSystemInfo : iControlInterface {
		public SystemSystemInfo() {
			this.Url = "https://url_to_service";
		}

	//=======================================================================
	// Operations
	//=======================================================================
	//-----------------------------------------------------------------------
	// acquire_lock
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SystemInfo", 
		RequestNamespace="urn:iControl:System/SystemInfo", ResponseNamespace="urn:iControl:System/SystemInfo")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public bool acquire_lock(
		string lock_name,
		long duration_sec,
		string comment
	) {
		object [] results = this.Invoke("acquire_lock", new object [] {
				lock_name,
				duration_sec,
				comment});
		return ((bool)(results[0]));
	}
	public System.IAsyncResult Beginacquire_lock(string lock_name,long duration_sec,string comment, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("acquire_lock", new object[] {
			lock_name,
			duration_sec,
			comment}, callback, asyncState);
	}
	public bool Endacquire_lock(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((bool)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_all_cpu_usage_extended_information
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SystemInfo", 
		RequestNamespace="urn:iControl:System/SystemInfo", ResponseNamespace="urn:iControl:System/SystemInfo")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemCPUUsageExtendedInformation get_all_cpu_usage_extended_information(

	) {
		object [] results = this.Invoke("get_all_cpu_usage_extended_information", new object [0]);
		return ((SystemCPUUsageExtendedInformation)(results[0]));
	}
	public System.IAsyncResult Beginget_all_cpu_usage_extended_information(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_all_cpu_usage_extended_information", new object[0], callback, asyncState);
	}
	public SystemCPUUsageExtendedInformation Endget_all_cpu_usage_extended_information(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemCPUUsageExtendedInformation)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_base_mac_address
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SystemInfo", 
		RequestNamespace="urn:iControl:System/SystemInfo", ResponseNamespace="urn:iControl:System/SystemInfo")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string get_base_mac_address(

	) {
		object [] results = this.Invoke("get_base_mac_address", new object [0]);
		return ((string)(results[0]));
	}
	public System.IAsyncResult Beginget_base_mac_address(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_base_mac_address", new object[0], callback, asyncState);
	}
	public string Endget_base_mac_address(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_blade_temperature
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SystemInfo", 
		RequestNamespace="urn:iControl:System/SystemInfo", ResponseNamespace="urn:iControl:System/SystemInfo")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemBladeTemperature [] get_blade_temperature(

	) {
		object [] results = this.Invoke("get_blade_temperature", new object [0]);
		return ((SystemBladeTemperature [])(results[0]));
	}
	public System.IAsyncResult Beginget_blade_temperature(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_blade_temperature", new object[0], callback, asyncState);
	}
	public SystemBladeTemperature [] Endget_blade_temperature(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemBladeTemperature [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_chassis_slot_information
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SystemInfo", 
		RequestNamespace="urn:iControl:System/SystemInfo", ResponseNamespace="urn:iControl:System/SystemInfo")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemChassisSlot [] get_chassis_slot_information(

	) {
		object [] results = this.Invoke("get_chassis_slot_information", new object [0]);
		return ((SystemChassisSlot [])(results[0]));
	}
	public System.IAsyncResult Beginget_chassis_slot_information(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_chassis_slot_information", new object[0], callback, asyncState);
	}
	public SystemChassisSlot [] Endget_chassis_slot_information(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemChassisSlot [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_connection_information
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SystemInfo", 
		RequestNamespace="urn:iControl:System/SystemInfo", ResponseNamespace="urn:iControl:System/SystemInfo")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemConnectionInformation get_connection_information(

	) {
		object [] results = this.Invoke("get_connection_information", new object [0]);
		return ((SystemConnectionInformation)(results[0]));
	}
	public System.IAsyncResult Beginget_connection_information(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_connection_information", new object[0], callback, asyncState);
	}
	public SystemConnectionInformation Endget_connection_information(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemConnectionInformation)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_connection_type
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SystemInfo", 
		RequestNamespace="urn:iControl:System/SystemInfo", ResponseNamespace="urn:iControl:System/SystemInfo")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemConnectionType get_connection_type(

	) {
		object [] results = this.Invoke("get_connection_type", new object [0]);
		return ((SystemConnectionType)(results[0]));
	}
	public System.IAsyncResult Beginget_connection_type(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_connection_type", new object[0], callback, asyncState);
	}
	public SystemConnectionType Endget_connection_type(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemConnectionType)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cpu_metrics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SystemInfo", 
		RequestNamespace="urn:iControl:System/SystemInfo", ResponseNamespace="urn:iControl:System/SystemInfo")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemPlatformCPUs get_cpu_metrics(

	) {
		object [] results = this.Invoke("get_cpu_metrics", new object [0]);
		return ((SystemPlatformCPUs)(results[0]));
	}
	public System.IAsyncResult Beginget_cpu_metrics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cpu_metrics", new object[0], callback, asyncState);
	}
	public SystemPlatformCPUs Endget_cpu_metrics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemPlatformCPUs)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cpu_usage_extended_information
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SystemInfo", 
		RequestNamespace="urn:iControl:System/SystemInfo", ResponseNamespace="urn:iControl:System/SystemInfo")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemCPUUsageExtendedInformation get_cpu_usage_extended_information(
		string [] host_ids
	) {
		object [] results = this.Invoke("get_cpu_usage_extended_information", new object [] {
				host_ids});
		return ((SystemCPUUsageExtendedInformation)(results[0]));
	}
	public System.IAsyncResult Beginget_cpu_usage_extended_information(string [] host_ids, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cpu_usage_extended_information", new object[] {
			host_ids}, callback, asyncState);
	}
	public SystemCPUUsageExtendedInformation Endget_cpu_usage_extended_information(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemCPUUsageExtendedInformation)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_cpu_usage_information
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SystemInfo", 
		RequestNamespace="urn:iControl:System/SystemInfo", ResponseNamespace="urn:iControl:System/SystemInfo")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemCPUUsageInformation get_cpu_usage_information(

	) {
		object [] results = this.Invoke("get_cpu_usage_information", new object [0]);
		return ((SystemCPUUsageInformation)(results[0]));
	}
	public System.IAsyncResult Beginget_cpu_usage_information(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_cpu_usage_information", new object[0], callback, asyncState);
	}
	public SystemCPUUsageInformation Endget_cpu_usage_information(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemCPUUsageInformation)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_disk_usage_information
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SystemInfo", 
		RequestNamespace="urn:iControl:System/SystemInfo", ResponseNamespace="urn:iControl:System/SystemInfo")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemDiskUsageInformation get_disk_usage_information(

	) {
		object [] results = this.Invoke("get_disk_usage_information", new object [0]);
		return ((SystemDiskUsageInformation)(results[0]));
	}
	public System.IAsyncResult Beginget_disk_usage_information(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_disk_usage_information", new object[0], callback, asyncState);
	}
	public SystemDiskUsageInformation Endget_disk_usage_information(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemDiskUsageInformation)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_fan_metrics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SystemInfo", 
		RequestNamespace="urn:iControl:System/SystemInfo", ResponseNamespace="urn:iControl:System/SystemInfo")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemPlatformFans get_fan_metrics(

	) {
		object [] results = this.Invoke("get_fan_metrics", new object [0]);
		return ((SystemPlatformFans)(results[0]));
	}
	public System.IAsyncResult Beginget_fan_metrics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_fan_metrics", new object[0], callback, asyncState);
	}
	public SystemPlatformFans Endget_fan_metrics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemPlatformFans)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_global_cpu_usage_extended_information
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SystemInfo", 
		RequestNamespace="urn:iControl:System/SystemInfo", ResponseNamespace="urn:iControl:System/SystemInfo")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemGlobalCPUUsageExtendedInformation get_global_cpu_usage_extended_information(

	) {
		object [] results = this.Invoke("get_global_cpu_usage_extended_information", new object [0]);
		return ((SystemGlobalCPUUsageExtendedInformation)(results[0]));
	}
	public System.IAsyncResult Beginget_global_cpu_usage_extended_information(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_global_cpu_usage_extended_information", new object[0], callback, asyncState);
	}
	public SystemGlobalCPUUsageExtendedInformation Endget_global_cpu_usage_extended_information(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemGlobalCPUUsageExtendedInformation)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_globally_unique_identifier
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SystemInfo", 
		RequestNamespace="urn:iControl:System/SystemInfo", ResponseNamespace="urn:iControl:System/SystemInfo")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string get_globally_unique_identifier(

	) {
		object [] results = this.Invoke("get_globally_unique_identifier", new object [0]);
		return ((string)(results[0]));
	}
	public System.IAsyncResult Beginget_globally_unique_identifier(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_globally_unique_identifier", new object[0], callback, asyncState);
	}
	public string Endget_globally_unique_identifier(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_group_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SystemInfo", 
		RequestNamespace="urn:iControl:System/SystemInfo", ResponseNamespace="urn:iControl:System/SystemInfo")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string get_group_id(

	) {
		object [] results = this.Invoke("get_group_id", new object [0]);
		return ((string)(results[0]));
	}
	public System.IAsyncResult Beginget_group_id(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_group_id", new object[0], callback, asyncState);
	}
	public string Endget_group_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_hardware_information
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SystemInfo", 
		RequestNamespace="urn:iControl:System/SystemInfo", ResponseNamespace="urn:iControl:System/SystemInfo")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemHardwareInformation [] get_hardware_information(

	) {
		object [] results = this.Invoke("get_hardware_information", new object [0]);
		return ((SystemHardwareInformation [])(results[0]));
	}
	public System.IAsyncResult Beginget_hardware_information(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_hardware_information", new object[0], callback, asyncState);
	}
	public SystemHardwareInformation [] Endget_hardware_information(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemHardwareInformation [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_lock_list
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SystemInfo", 
		RequestNamespace="urn:iControl:System/SystemInfo", ResponseNamespace="urn:iControl:System/SystemInfo")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string [] get_lock_list(

	) {
		object [] results = this.Invoke("get_lock_list", new object [0]);
		return ((string [])(results[0]));
	}
	public System.IAsyncResult Beginget_lock_list(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_lock_list", new object[0], callback, asyncState);
	}
	public string [] Endget_lock_list(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_lock_status
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SystemInfo", 
		RequestNamespace="urn:iControl:System/SystemInfo", ResponseNamespace="urn:iControl:System/SystemInfo")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemLockStatus [] get_lock_status(
		string [] lock_names
	) {
		object [] results = this.Invoke("get_lock_status", new object [] {
				lock_names});
		return ((SystemLockStatus [])(results[0]));
	}
	public System.IAsyncResult Beginget_lock_status(string [] lock_names, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_lock_status", new object[] {
			lock_names}, callback, asyncState);
	}
	public SystemLockStatus [] Endget_lock_status(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemLockStatus [])(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_marketing_name
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SystemInfo", 
		RequestNamespace="urn:iControl:System/SystemInfo", ResponseNamespace="urn:iControl:System/SystemInfo")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string get_marketing_name(

	) {
		object [] results = this.Invoke("get_marketing_name", new object [0]);
		return ((string)(results[0]));
	}
	public System.IAsyncResult Beginget_marketing_name(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_marketing_name", new object[0], callback, asyncState);
	}
	public string Endget_marketing_name(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_memory_usage_information
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SystemInfo", 
		RequestNamespace="urn:iControl:System/SystemInfo", ResponseNamespace="urn:iControl:System/SystemInfo")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemMemoryUsageInformation get_memory_usage_information(

	) {
		object [] results = this.Invoke("get_memory_usage_information", new object [0]);
		return ((SystemMemoryUsageInformation)(results[0]));
	}
	public System.IAsyncResult Beginget_memory_usage_information(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_memory_usage_information", new object[0], callback, asyncState);
	}
	public SystemMemoryUsageInformation Endget_memory_usage_information(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemMemoryUsageInformation)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_power_supply_metrics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SystemInfo", 
		RequestNamespace="urn:iControl:System/SystemInfo", ResponseNamespace="urn:iControl:System/SystemInfo")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemPlatformPowerSupplies get_power_supply_metrics(

	) {
		object [] results = this.Invoke("get_power_supply_metrics", new object [0]);
		return ((SystemPlatformPowerSupplies)(results[0]));
	}
	public System.IAsyncResult Beginget_power_supply_metrics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_power_supply_metrics", new object[0], callback, asyncState);
	}
	public SystemPlatformPowerSupplies Endget_power_supply_metrics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemPlatformPowerSupplies)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_product_information
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SystemInfo", 
		RequestNamespace="urn:iControl:System/SystemInfo", ResponseNamespace="urn:iControl:System/SystemInfo")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemProductInformation get_product_information(

	) {
		object [] results = this.Invoke("get_product_information", new object [0]);
		return ((SystemProductInformation)(results[0]));
	}
	public System.IAsyncResult Beginget_product_information(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_product_information", new object[0], callback, asyncState);
	}
	public SystemProductInformation Endget_product_information(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemProductInformation)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_pva_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SystemInfo", 
		RequestNamespace="urn:iControl:System/SystemInfo", ResponseNamespace="urn:iControl:System/SystemInfo")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string get_pva_version(

	) {
		object [] results = this.Invoke("get_pva_version", new object [0]);
		return ((string)(results[0]));
	}
	public System.IAsyncResult Beginget_pva_version(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_pva_version", new object[0], callback, asyncState);
	}
	public string Endget_pva_version(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_system_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SystemInfo", 
		RequestNamespace="urn:iControl:System/SystemInfo", ResponseNamespace="urn:iControl:System/SystemInfo")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public string get_system_id(

	) {
		object [] results = this.Invoke("get_system_id", new object [0]);
		return ((string)(results[0]));
	}
	public System.IAsyncResult Beginget_system_id(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_system_id", new object[0], callback, asyncState);
	}
	public string Endget_system_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((string)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_system_information
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SystemInfo", 
		RequestNamespace="urn:iControl:System/SystemInfo", ResponseNamespace="urn:iControl:System/SystemInfo")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemSystemInformation get_system_information(

	) {
		object [] results = this.Invoke("get_system_information", new object [0]);
		return ((SystemSystemInformation)(results[0]));
	}
	public System.IAsyncResult Beginget_system_information(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_system_information", new object[0], callback, asyncState);
	}
	public SystemSystemInformation Endget_system_information(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemSystemInformation)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_temperature_metrics
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SystemInfo", 
		RequestNamespace="urn:iControl:System/SystemInfo", ResponseNamespace="urn:iControl:System/SystemInfo")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public SystemPlatformTemperatures get_temperature_metrics(

	) {
		object [] results = this.Invoke("get_temperature_metrics", new object [0]);
		return ((SystemPlatformTemperatures)(results[0]));
	}
	public System.IAsyncResult Beginget_temperature_metrics(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_temperature_metrics", new object[0], callback, asyncState);
	}
	public SystemPlatformTemperatures Endget_temperature_metrics(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((SystemPlatformTemperatures)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_time
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SystemInfo", 
		RequestNamespace="urn:iControl:System/SystemInfo", ResponseNamespace="urn:iControl:System/SystemInfo")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonTimeStamp get_time(

	) {
		object [] results = this.Invoke("get_time", new object [0]);
		return ((CommonTimeStamp)(results[0]));
	}
	public System.IAsyncResult Beginget_time(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_time", new object[0], callback, asyncState);
	}
	public CommonTimeStamp Endget_time(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonTimeStamp)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_time_zone
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SystemInfo", 
		RequestNamespace="urn:iControl:System/SystemInfo", ResponseNamespace="urn:iControl:System/SystemInfo")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public CommonTimeZone get_time_zone(

	) {
		object [] results = this.Invoke("get_time_zone", new object [0]);
		return ((CommonTimeZone)(results[0]));
	}
	public System.IAsyncResult Beginget_time_zone(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_time_zone", new object[0], callback, asyncState);
	}
	public CommonTimeZone Endget_time_zone(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((CommonTimeZone)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_uptime
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SystemInfo", 
		RequestNamespace="urn:iControl:System/SystemInfo", ResponseNamespace="urn:iControl:System/SystemInfo")]
	[return: System.Xml.Serialization.SoapElementAttribute("return")]
	public long get_uptime(

	) {
		object [] results = this.Invoke("get_uptime", new object [0]);
		return ((long)(results[0]));
	}
	public System.IAsyncResult Beginget_uptime(System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("get_uptime", new object[0], callback, asyncState);
	}
	public long Endget_uptime(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
		return ((long)(results[0]));
	}

	//-----------------------------------------------------------------------
	// get_version
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SystemInfo", 
		RequestNamespace="urn:iControl:System/SystemInfo", ResponseNamespace="urn:iControl:System/SystemInfo")]
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
	// release_lock
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SystemInfo", 
		RequestNamespace="urn:iControl:System/SystemInfo", ResponseNamespace="urn:iControl:System/SystemInfo")]
	public void release_lock(
		string lock_name
	) {
		this.Invoke("release_lock", new object [] {
				lock_name});

	}
	public System.IAsyncResult Beginrelease_lock(string lock_name, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("release_lock", new object[] {
			lock_name}, callback, asyncState);
	}
	public void Endrelease_lock(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_group_id
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SystemInfo", 
		RequestNamespace="urn:iControl:System/SystemInfo", ResponseNamespace="urn:iControl:System/SystemInfo")]
	public void set_group_id(
		string group_id
	) {
		this.Invoke("set_group_id", new object [] {
				group_id});

	}
	public System.IAsyncResult Beginset_group_id(string group_id, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_group_id", new object[] {
			group_id}, callback, asyncState);
	}
	public void Endset_group_id(System.IAsyncResult asyncResult) {
		object [] results = this.EndInvoke(asyncResult);
	}

	//-----------------------------------------------------------------------
	// set_time
	//-----------------------------------------------------------------------
	[System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:iControl:System/SystemInfo", 
		RequestNamespace="urn:iControl:System/SystemInfo", ResponseNamespace="urn:iControl:System/SystemInfo")]
	public void set_time(
		CommonTimeStamp time
	) {
		this.Invoke("set_time", new object [] {
				time});

	}
	public System.IAsyncResult Beginset_time(CommonTimeStamp time, System.AsyncCallback callback, object asyncState) {
		return this.BeginInvoke("set_time", new object[] {
			time}, callback, asyncState);
	}
	public void Endset_time(System.IAsyncResult asyncResult) {
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
